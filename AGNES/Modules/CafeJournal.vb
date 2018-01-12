Public Class CafeJournal
    Private uname As String
    Private Property UserName As String
        Get
            Return uname
        End Get
        Set(value As String)
            uname = value
            tsslUser.Text = "User: " & uname
        End Set
    End Property

    Private Unit As Long
    Friend Property UnitNum As Long
        Get
            Return Unit
        End Get
        Set(value As Long)
            Unit = value
            tsslUnit.Text = "Unit: " & Unit
        End Set
    End Property

    Private dt As Date
    Private Property SelectedDate As Date
        Get
            Return dt
        End Get
        Set(value As Date)
            dt = value
            dtpJournalDate.Value = dt
            SaveChanges = True
            ChangesMade = False
            PopulatePreviousEntries()
        End Set
    End Property

    Private savd As Boolean
    Private Property SaveChanges As Boolean
        Get
            Return savd
        End Get
        Set(value As Boolean)
            savd = value
            tsmiSave.Enabled = Not savd
        End Set
    End Property

    Private changd As Boolean
    Private Property ChangesMade As Boolean
        Get
            Return changd
        End Get
        Set(value As Boolean)
            changd = value
            tsmiSave.Enabled = changd
        End Set
    End Property

    Private ynchoice As Boolean
    Private Editing As Long
    Private ct As Integer
    Private systemchange As Boolean

#Region "Initialize Journal"

    Private Sub LoadJournal(sender As Object, e As EventArgs) Handles Me.Load
        UserName = Portal.UserName
        tsslInformation.Text = "Waiting for date and category selection"
        tsslSaveStatus.Visible = False
        SelectedDate = Now().Date
        PopulateEventCategories()
        SaveChanges = True
        ChangesMade = False
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub SaveEntry(sender As Object, e As EventArgs) Handles tsmiSave.Click
        If SaveChanges = True Or ChangesMade = False Then Exit Sub
        SaveData()
    End Sub

    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Do you still wish to exit?", 2, True, "journal")
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Dispose()
        Portal.Show()
    End Sub

    Private Sub ClearEntry(sender As Object, e As EventArgs) Handles tsmiClear.Click
        ClearFields()
    End Sub

#End Region

#Region "User Controls"

    Private Sub LeaveDateField(sender As Object, e As EventArgs) Handles dtpJournalDate.Leave
        If systemchange = True Then Exit Sub
        txtJournalText.Enabled = False
        txtJournalText.Text = ""
        SelectedDate = dtpJournalDate.Value
        txtJournalText.Enabled = False
        If cbxEventCat.SelectedIndex <> -1 Then txtJournalText.Enabled = True
        tsslSaveStatus.Visible = False
    End Sub

    Private Sub CategorySelected(sender As Object, e As EventArgs) Handles cbxEventCat.SelectedIndexChanged
        If systemchange = True Then Exit Sub
        If cbxEventCat.SelectedIndex = -1 Then
            With txtJournalText
                .Text = ""
                .Enabled = False
            End With
            ActiveControl = Controls("dtpJournalDate")
            tsslInformation.Text = "Waiting for date and category selection"
            tsslSaveStatus.Visible = False
        Else
            With txtJournalText
                .Text = ""
                .Enabled = True
            End With
            ActiveControl = Controls("txtJournalText")
            tsslInformation.Text = "Please add event details"
            tsslSaveStatus.Text = "Not Saved"
            tsslSaveStatus.Visible = True
        End If
        SaveChanges = False
        ChangesMade = True
    End Sub

    Private Sub CategoryTextChange(sender As Object, e As EventArgs) Handles cbxEventCat.TextChanged
        If systemchange = True Then Exit Sub
        If cbxEventCat.Text = "" Then
            With txtJournalText
                .Text = ""
                .Enabled = False
            End With
            ActiveControl = Controls("dtpJournalDate")
            tsslSaveStatus.Text = "Not Saved"
            tsslSaveStatus.Visible = False
            tsslInformation.Text = "Waiting for date and category selection"
            Exit Sub
        End If

        If cbxEventCat.SelectedIndex = -1 Then cbxEventCat.Text = ""

        SaveChanges = False
        ChangesMade = True

    End Sub

    Private Sub JournalTextChanged(sender As Object, e As EventArgs) Handles txtJournalText.TextChanged
        If systemchange = True Then Exit Sub
        SaveChanges = False
        ChangesMade = True
    End Sub

#End Region

#Region "Functions"

    Private Sub PopulateEventCategories()
        Dim ph As String = ""
    End Sub

    Private Sub PopulatePreviousEntries()
        dgvEntryList.Visible = False
        lblDGVEntries.Visible = False

        dgvEntryList.Rows.Clear()

        DataSets.JournalAdapt.Fill(DataSets.JournalTable)
        Dim dr() As DataRow = DataSets.JournalTable.Select("Date = '" & SelectedDate & "' and Unit = '" & UnitNum & "'")
        If dr.Count = 0 Then Exit Sub
        For ct = 0 To dr.Count - 1
            dgvEntryList.Rows.Add(dr(ct)("PID"), FormatDateTime(dr(ct)("Date"), DateFormat.ShortDate), dr(ct)("Category"), dr(ct)("Detail"))
        Next
        dgvEntryList.Visible = True
        lblDGVEntries.Visible = True
        ActiveControl = Controls("dtpJournalDate")
    End Sub

    Private Sub ClearFields()
        Editing = 0
        cbxEventCat.SelectedIndex = -1
        cbxEventCat.Text = ""
        txtJournalText.Text = ""
        tsmiDelete.Visible = False
        SelectedDate = Now().Date
        ActiveControl = Controls("dtpJournalDate")
    End Sub

    Private Sub SaveData()
        If cbxEventCat.Text = "" Or txtJournalText.Text = "" Then
            Dim amsg As New AgnesMsgBox("Missing some data.  Please complete form and try again!", 2, False, "Journal")
            amsg.ShowDialog()
            amsg.Dispose()
            Exit Sub
        End If

        Dim errkick As Boolean
        Try
            If Editing = 0 Then
                '#  Save new record
                Dim newdr As DataRow = DataSets.JournalTable.NewRow
                newdr("Date") = SelectedDate
                newdr("Unit") = UnitNum
                newdr("Category") = cbxEventCat.Text
                newdr("Detail") = txtJournalText.Text
                newdr("RecordedBy") = uname
                DataSets.JournalTable.Rows.Add(newdr)
            Else
                '#  Overwrite existing record
                Dim dr() As DataRow = DataSets.JournalTable.Select("PID = '" & Editing & "'")
                dr(0)("Category") = cbxEventCat.Text
                dr(0)("Detail") = txtJournalText.Text
                dr(0)("RecordedBy") = uname
            End If
        Catch ex As Exception
            errkick = True
        End Try

        DataSets.JournalAdapt.Update(DataSets.JournalTable)
        If errkick = False Then
            Dim amsg As New AgnesMsgBox("Data saved", 2, False, "Waste")
            amsg.ShowDialog()
            amsg.Dispose()
            ClearFields()
            SaveChanges = True
            ChangesMade = False
            tsslInformation.Text = "Waiting for date and category selection"
            tsslSaveStatus.Text = "Saved"
        Else
            Dim amsg As New AgnesMsgBox("Data not saved due to error #" & Err.Number & ".  Please take a screenshot and notify the BI department!", 2, False, "Waste")
            amsg.ShowDialog()
            amsg.Dispose()
            SaveChanges = False
            ChangesMade = True
            tsslSaveStatus.Text = "Not Saved"
        End If

    End Sub

    Private Sub SelectPreviousEntry(sender As Object, e As EventArgs) Handles dgvEntryList.DoubleClick
        systemchange = True
        Dim ri As Integer = dgvEntryList.CurrentCell.RowIndex
        Editing = FormatNumber(dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(0).Value, 0)
        cbxEventCat.Text = dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(2).Value
        txtJournalText.Text = dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(3).Value
        txtJournalText.Enabled = True
        tsslInformation.Text = "Editing previous entry"
        SaveChanges = False
        dgvEntryList.ClearSelection()
        ActiveControl = Controls("txtJournalText")
        tsmiDelete.Visible = True
        systemchange = False
    End Sub

    Private Sub DeleteSelection(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        Dim amsg As New AgnesMsgBox("Are you sure that you wish to delete this entry?", 2, True, "journal")
        amsg.ShowDialog()
        ynchoice = amsg.Choicemade
        amsg.Dispose()
        If ynchoice = False Then Exit Sub
        Dim dr() As DataRow = DataSets.JournalTable.Select("PID = '" & Editing & "'")
        dr(0).Delete()
        DataSets.JournalAdapt.Update(DataSets.JournalTable)
        PopulatePreviousEntries()
        Editing = 0
        ClearFields()
    End Sub

#End Region


End Class