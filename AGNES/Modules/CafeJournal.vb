Public Class CafeJournal

#Region "Properties"
    Private uname As String
    Private Property UserName As String
        Get
            Return uname
        End Get
        Set(value As String)
            uname = value
            tsslUser.Text = "User: " & uname
            Select Case uname
                Case "Alexia Manthey", "Brian Freeman", "Bethany Whalen", "Lexi Aguilar"
                    metauser = True
                Case Else
                    metauser = False
            End Select
        End Set
    End Property

    Private Unit As Long
    Friend Property UnitNum As Long
        Get
            Return Unit
        End Get
        Set(value As Long)
            Unit = value
            If Unit = 0 Then
                tsslUnit.Text = "Multiple units"
            Else
                tsslUnit.Text = "Unit: " & Unit
            End If
        End Set
    End Property

    Private stdt As Date
    Private Property StartDate As Date
        Get
            Return stdt
        End Get
        Set(value As Date)
            stdt = value
            dtpJournalStartDate.Value = stdt
            dtpJournalEndDate.MinDate = value
            SaveChanges = True
            ChangesMade = False
            If value > EndDate Then EndDate = value
            PopulatePreviousEntries()
        End Set
    End Property

    Private enddt As Date
    Private Property EndDate As Date
        Get
            Return enddt
        End Get
        Set(value As Date)
            enddt = value
            dtpJournalEndDate.Value = enddt
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


#End Region

    Private ynchoice As Boolean
    Private Editing As Long
    Private ct As Integer
    Private systemchange As Boolean
    Private EditAllowed As Boolean
    Shared metauser As Boolean

#Region "Initialize Journal"

    Private Sub LoadJournal(sender As Object, e As EventArgs) Handles Me.Load
        UserName = Portal.UserName
        tsslInformation.Text = "Waiting for date and category selection"
        tsslSaveStatus.Visible = False
        StartDate = Now().Date
        EndDate = Now().Date
        PopulateEventCategories()
        SaveChanges = True
        ChangesMade = False
        lbxUnits.Visible = False
        lblUnitSelection.Visible = False
        PopulateUnitListbox()
        If metauser = True Then
            lbxUnits.Visible = True
            lblUnitSelection.Visible = True
        End If

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

    Private Sub LeaveStartDateField(sender As Object, e As EventArgs) Handles dtpJournalStartDate.Leave
        If systemchange = True Then Exit Sub
        txtJournalText.Enabled = False
        txtJournalText.Text = ""
        StartDate = dtpJournalStartDate.Value
        txtJournalText.Enabled = False
        If cbxEventCat.SelectedIndex <> -1 Then txtJournalText.Enabled = True
        dtpJournalEndDate.MinDate = StartDate
        tsslSaveStatus.Visible = False
    End Sub

    Private Sub LeaveEndDateField(sender As Object, e As EventArgs) Handles dtpJournalEndDate.Leave
        If systemchange = True Then Exit Sub
        EndDate = dtpJournalEndDate.Value
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

    Private Sub UnitSelectionChange(sender As Object, e As EventArgs) Handles lbxUnits.Leave, lbxUnits.SelectedIndexChanged
        If lbxUnits.SelectedItems.Count = 1 Then
            Dim nm As String = lbxUnits.SelectedItem.ToString
            UnitNum = FetchUnitNumber(nm)
        Else
            UnitNum = 0
        End If
        PopulatePreviousEntries()
    End Sub

    Private Sub JournalTextChanged(sender As Object, e As EventArgs) Handles txtJournalText.TextChanged
        If systemchange = True Then Exit Sub
        SaveChanges = False
        ChangesMade = True
    End Sub

    Private Sub SelectPreviousEntry(sender As Object, e As EventArgs) Handles dgvEntryList.DoubleClick
        If EditAllowed = False Then
            Dim amsg As New AgnesMsgBox("Editing is not allowed when multiple units are selected.", 2, False, "Journal")
            With amsg
                .ShowDialog()
                .Dispose()
            End With
            Exit Sub
        End If
        systemchange = True
        Dim ri As Integer = dgvEntryList.CurrentCell.RowIndex

        Editing = FormatNumber(dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(0).Value, 0)
        StartDate = dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(1).Value
        EndDate = StartDate
        cbxEventCat.Text = dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(3).Value
        txtJournalText.Text = dgvEntryList.Rows(dgvEntryList.CurrentCell.RowIndex).Cells(4).Value
        txtJournalText.Enabled = True
        tsslInformation.Text = "Editing previous entry"
        SaveChanges = False
        dgvEntryList.ClearSelection()
        ActiveControl = Controls("txtJournalText")
        tsmiDelete.Visible = True
        systemchange = False
    End Sub

#End Region

#Region "Functions"

    Private Sub PopulateEventCategories()
        Dim ph As String = ""
    End Sub

    Private Sub PopulateUnitListbox()
        lbxUnits.Items.Clear()
        Dim dr() As DataRow = DataSets.FlashLocationTable.Select("Group in ('Cafes','Commons')")
        For ct = 0 To dr.Count - 1
            lbxUnits.Items.Add(dr(ct)("Unit"))
        Next
        Dim index As Integer = lbxUnits.FindString(FetchUnitName())
        lbxUnits.SetSelected(index, True)
    End Sub

    Private Sub PopulatePreviousEntries()
        dgvEntryList.Visible = False
        lblDGVEntries.Visible = False
        dgvEntryList.Rows.Clear()
        txtJournalText.Text = ""
        DataSets.JournalAdapt.Fill(DataSets.JournalTable)
        Dim dr() As DataRow, sqlstring As String, unitstring = "", datestring As String = "", dt As Date = FormatDateTime(dtpJournalStartDate.Value, vbShortDate)
        Do Until dt > FormatDateTime(dtpJournalEndDate.Value, vbShortDate)
            datestring = datestring & "'" & FormatDateTime(dt, vbShortDate).ToString & "',"
            dt = dt.AddDays(1)
        Loop
        datestring = Mid(datestring, 1, Len(datestring) - 1)
        sqlstring = "Date in (" & datestring & ") and Unit "
        If metauser = False Then
            sqlstring = sqlstring & " = '" & UnitNum & "'"
        Else
            If UnitNum > 0 Then
                sqlstring = "Date in (" & datestring & ") and Unit = '" & UnitNum & "'"
                EditAllowed = True
            Else
                For Each Item As String In lbxUnits.SelectedItems
                    unitstring = unitstring & FetchUnitNumber(Item.ToString) & ","
                Next
                unitstring = Mid(unitstring, 1, Len(unitstring) - 1)
                sqlstring = "Date in (" & datestring & ") and Unit in (" & unitstring & ")"
                EditAllowed = False
            End If

        End If

        dr = DataSets.JournalTable.Select(sqlstring)
        If dr.Count = 0 Then Exit Sub
        For ct = 0 To dr.Count - 1
            dgvEntryList.Rows.Add(dr(ct)("PID"), FormatDateTime(dr(ct)("Date"), DateFormat.ShortDate), dr(ct)("Unit"), dr(ct)("Category"), ParseFetchedEntry(dr(ct)("Detail")))
        Next
        dgvEntryList.Visible = True
        lblDGVEntries.Visible = True
        ActiveControl = Controls("dtpJournalDate")
        dgvEntryList.ClearSelection()

    End Sub

    Private Sub ClearFields()
        Editing = 0
        cbxEventCat.SelectedIndex = -1
        cbxEventCat.Text = ""
        txtJournalText.Text = ""
        tsmiDelete.Visible = False
        StartDate = Now().Date
        EndDate = Now().Date
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
                '#  Save new record(s)
                Dim writedate As Date, heldenddate As Date = EndDate
                For Each SelectedUnit As String In lbxUnits.SelectedItems
                    writedate = StartDate
                    Do Until writedate > heldenddate
                        Dim newdr As DataRow = DataSets.JournalTable.NewRow
                        newdr("Date") = writedate
                        newdr("Unit") = FetchUnitNumber(SelectedUnit.ToString)
                        newdr("Category") = cbxEventCat.Text
                        newdr("Detail") = ParseSaveEntry(txtJournalText.Text)
                        newdr("RecordedBy") = uname
                        DataSets.JournalTable.Rows.Add(newdr)
                        writedate = writedate.AddDays(1)
                    Loop
                Next


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

    Private Function FetchUnitNumber(unitname) As Long
        Dim dr() As DataRow = DataSets.FlashLocationTable.Select("Unit = '" & unitname & "'")
        Return dr(0)("Unit_Number")
    End Function

    Private Function FetchUnitName() As String
        Dim dr() As DataRow = DataSets.FlashLocationTable.Select("Unit_Number = '" & UnitNum & "'")
        Return dr(0)("Unit")
    End Function

    Private Function ParseSaveEntry(entry) As String
        'TODO: Add journal entry save validation and parsing (carriage returns, etc.)
        Dim aString As String = Replace(entry, "'", "'''")
        Return aString
    End Function

    Private Function ParseFetchedEntry(entry) As String
        'TODO: Add journal entry retrieve validation and parsing (carriage returns, etc.)
        Dim aString As String = Replace(entry, "'''", "'")
        Return aString
    End Function

#End Region


End Class