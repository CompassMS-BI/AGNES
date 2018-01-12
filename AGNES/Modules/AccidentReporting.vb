Public Class AccidentReporting
    Private Property ChangesSaved As Boolean
    Private Property ynchoice As Boolean
    Private Property RecordExists As Boolean
    Private totalexpense As Double
    Private Property lateexpense As Boolean = False
    Private Property medexpense As Boolean = False
    Private Property timeexpense As Boolean = False
    Private Property systemchange As Boolean = False
    Private MoveForm As Boolean
    Private MoveForm_MousePosition As Point
    Dim ct As Integer


#Region "Initialize Module"

    Private Sub LoadModule(sender As Object, e As EventArgs) Handles Me.Load
        Me.AccidentReportingTableAdapter.Fill(Me.AGNESData.AccidentReporting)
        DataSets.IncidentAdapt.Fill(DataSets.IncidentTable)
        With dtpIncidentDate
            .MaxDate = FormatDateTime(Now(), vbShortDate)
            .Value = FormatDateTime(Now(), vbShortDate)
        End With

        With dtpReportingDate
            .MaxDate = FormatDateTime((Now().AddMinutes(5)), vbShortDate)
            .Value = FormatDateTime((Now().AddMinutes(5)), vbShortDate)
        End With
        ChangesSaved = True
        tsslUser.Text = "Current User: " & Portal.UserName
        LoadReportingGroups()
        LoadUnits()
        LoadIncidentTypes()
        dgvIncidentGrid.CurrentCell = Nothing
    End Sub

#End Region

#Region "User interface controls"

    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles mstIncidentMenuBar.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles mstIncidentMenuBar.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles mstIncidentMenuBar.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub GroupSelected(sender As Object, e As EventArgs) Handles cbxGroup.SelectedIndexChanged
        If systemchange = True Then Exit Sub
        ChangesSaved = False
        LoadUnits()
    End Sub

    Private Sub LeaveGroupBox(sender As Object, e As EventArgs) Handles cbxGroup.Leave
        If cbxGroup.SelectedIndex = -1 And cbxGroup.Text <> "" Then
            If ItemFound(sender) = False Then
                Dim amsg As New AgnesMsgBox("Please confirm that you want to add " & cbxGroup.Text & " as a new reporting group.", 2, True, Me.Name)
                amsg.ShowDialog()
                ynchoice = amsg.Choicemade
                amsg.Dispose()
                If ynchoice = False Then
                    With cbxGroup
                        .Text = ""
                        .SelectedIndex = -1
                    End With
                    Exit Sub
                Else
                    Dim holdname As String, dr As DataRow = DataSets.IncidentRepGrpTable.NewRow()
                    holdname = cbxGroup.Text
                    dr("ReportGroupName") = holdname
                    DataSets.IncidentRepGrpTable.Rows.Add(dr)
                    DataSets.IncidentRepGrpAdapt.Update(DataSets.IncidentRepGrpTable)
                    LoadReportingGroups()
                    cbxGroup.Text = holdname
                End If
            Else End If
        Else End If
        If cbxGroup.Text = "" Then cbxGroup.SelectedIndex = -1
    End Sub

    Private Sub EnterUnitBox(sender As Object, e As EventArgs) Handles cbxUnit.Enter
        If dtpReportingDate.Value < dtpIncidentDate.Value Then
            Dim amsg As New AgnesMsgBox("The reporting date can't be earlier than the incident date.  Reseting to be the same day.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            dtpReportingDate.Value = dtpIncidentDate.Value
        End If
        updateexpense()
        If Len(cbxUnit.Text) > 0 Then cbxUnit.SelectAll()
    End Sub

    Private Sub HighlightAssociateName(sender As Object, e As EventArgs)
        If Len(txtAssociate.Text) > 0 Then txtAssociate.SelectAll()
    End Sub

    Private Sub LeaveIncidentType(sender As Object, e As EventArgs) Handles cbxType.Leave
        If cbxType.SelectedIndex = -1 And cbxType.Text <> "" Then
            If ItemFound(sender) = False Then
                Dim amsg As New AgnesMsgBox("Please confirm that you want to add " & cbxType.Text & " as a new incident type.", 2, True, Me.Name)
                amsg.ShowDialog()
                ynchoice = amsg.Choicemade
                amsg.Dispose()
                If ynchoice = False Then
                    With cbxType
                        .Text = ""
                        .SelectedIndex = -1
                    End With
                    Exit Sub
                Else
                    Dim holdname As String, dr As DataRow = DataSets.IncidentTypeTable.NewRow()
                    holdname = cbxType.Text
                    dr("AccidentType") = holdname
                    DataSets.IncidentTypeTable.Rows.Add(dr)
                    DataSets.IncidentTypeAdapt.Update(DataSets.IncidentTypeTable)
                    LoadIncidentTypes()
                    cbxType.Text = holdname
                End If
            Else End If
        Else End If
        If cbxType.Text = "" Then cbxType.SelectedIndex = -1
    End Sub

    Private Sub MedicalCheckedUnchecked(sender As Object, e As EventArgs) Handles chkMedical.CheckedChanged
        If systemchange = True Then Exit Sub
        If chkMedical.Checked = True Then
            medexpense = True
        Else
            medexpense = False
        End If
        updateexpense()
        ChangesSaved = False
    End Sub

    Private Sub SelectLostTimeText(sender As Object, e As EventArgs) Handles nudLostTime.Enter
        nudLostTime.Select(0, nudLostTime.Text.Length)
    End Sub

    Private Sub LostTimeChanged(sender As Object, e As EventArgs) Handles nudLostTime.ValueChanged
        If systemchange = True Then Exit Sub
        If nudLostTime.Value = 0 Then
            timeexpense = False
        Else
            timeexpense = True
        End If
        updateexpense()
    End Sub

    Private Sub SelectEndOfDescription(sender As Object, e As EventArgs) Handles txtDescription.Enter
        If Len(txtDescription.Text) > 0 Then txtDescription.SelectionStart = Len(txtDescription.Text)
    End Sub

    Private Sub OtherValuesChanged(sender As Object, e As EventArgs) Handles dtpIncidentDate.ValueChanged, dtpReportingDate.ValueChanged,
        cbxUnit.SelectedIndexChanged, cbxType.SelectedIndexChanged, txtDescription.TextChanged, txtAssociate.TextChanged
        If systemchange = True Then Exit Sub
        ChangesSaved = False
    End Sub

    Private Sub SaveRecord(sender As Object, e As EventArgs) Handles tsmiSave.Click
        Dim AllowSave As Boolean = ValidateEntry()
        CheckForOverwrite()
        RecordSave(RecordExists)
    End Sub

    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If ChangesSaved = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Close()
        Portal.Show()
    End Sub

    Private Sub UserSelectedIncidentFromGrid(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvIncidentGrid.CellMouseDoubleClick
        Dim r As Integer = e.RowIndex
        systemchange = True
        txtIncidentID.Text = FormatNumber(dgvIncidentGrid.Rows(r).Cells(0).Value, 0)
        dtpIncidentDate.Value = FormatDateTime(dgvIncidentGrid.Rows(r).Cells(1).Value, vbShortDate)
        dtpReportingDate.Value = FormatDateTime(dgvIncidentGrid.Rows(r).Cells(2).Value, vbShortDate)
        cbxUnit.Text = dgvIncidentGrid.Rows(r).Cells(3).Value
        txtAssociate.Text = dgvIncidentGrid.Rows(r).Cells(4).Value
        txtDescription.Text = dgvIncidentGrid.Rows(r).Cells(5).Value
        chkMedical.Checked = dgvIncidentGrid.Rows(r).Cells(6).Value
        nudLostTime.Value = dgvIncidentGrid.Rows(r).Cells(7).Value
        cbxGroup.Text = dgvIncidentGrid.Rows(r).Cells(11).Value
        cbxType.Text = dgvIncidentGrid.Rows(r).Cells(12).Value

        If IsDBNull(dgvIncidentGrid.Rows(r).Cells(9).Value) = False Then
            curActualCharge.Text = FormatCurrency(dgvIncidentGrid.Rows(r).Cells(9).Value, 2)
        Else
            curActualCharge.Text = FormatCurrency(0, 2)
        End If
        medexpense = chkMedical.Checked
        If nudLostTime.Value > 0 Then timeexpense = True
        updateexpense()
        systemchange = False
    End Sub

#End Region

#Region "Functions"
    Private Function ItemFound(s As ComboBox)
        Dim holdtext As String = UCase(s.Text)
        For ct = 0 To s.Items.Count - 1
            If UCase(s.Items(ct)) = holdtext Then
                s.SelectedIndex = ct
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub LoadReportingGroups()
        cbxGroup.Items.Clear()
        DataSets.IncidentRepGrpAdapt.Fill(DataSets.IncidentRepGrpTable)
        For ct = 0 To DataSets.IncidentRepGrpTable.Count - 1
            cbxGroup.Items.Add(DataSets.IncidentRepGrpTable.Rows(ct).Item(1))
        Next
    End Sub

    Private Sub LoadUnits()
        Dim distinctDT As DataTable = DataSets.IncidentTable.DefaultView.ToTable(True, "Department/Unit", "ReportGroup")
        cbxUnit.Items.Clear()
        If cbxGroup.SelectedIndex = -1 Then
            For ct = 0 To distinctDT.Rows.Count - 1
                cbxUnit.Items.Add(distinctDT.Rows(ct).Item(0))
            Next
        Else
            Dim dr() As DataRow = distinctDT.Select("ReportGroup = '" & cbxGroup.Text & "'")
            For ct = 0 To dr.Count - 1
                cbxUnit.Items.Add(dr(ct)(0))
            Next
        End If
    End Sub

    Private Sub LoadIncidentTypes()
        cbxType.Items.Clear()
        DataSets.IncidentTypeAdapt.Fill(DataSets.IncidentTypeTable)
        For ct = 0 To DataSets.IncidentTypeTable.Count - 1
            cbxType.Items.Add(DataSets.IncidentTypeTable.Rows(ct).Item(1))
        Next
    End Sub

    Private Sub updateexpense()
        totalexpense = 0 : lateexpense = False
        Dim reptdt As Date = dtpReportingDate.Value, incdt As Date = dtpIncidentDate.Value, reportdategap As Integer, lateamount As Double
        reportdategap = DateDiff(DateInterval.Day, incdt, reptdt)
        Select Case reportdategap
            Case < 5                    '#  Late reporting only charged if report date was >4 days late
                lateexpense = False
            Case 5                      '#  Late reporting charge is base $500
                lateexpense = True
                lateamount = 500
            Case > 35
                lateexpense = True      '#  Capped at late threshold+30 days
                lateamount = 2000
            Case Else
                lateexpense = True
                lateamount = 500 + (50 * (reportdategap - 5))    '#  Charge is +$50 for each day past the late threshold
        End Select
        If lateexpense = True Then totalexpense = totalexpense + lateamount
        If medexpense = True Then totalexpense = totalexpense + 3000
        If timeexpense = True Then
            Select Case nudLostTime.Value
                Case 1 To 7
                    totalexpense = totalexpense + 500
                Case 8 To 30
                    totalexpense = totalexpense + 1500
                Case > 30
                    totalexpense = totalexpense + 3000
            End Select
        End If
        txtExpense.Text = FormatCurrency(totalexpense, 2)
    End Sub

    Private Sub CheckForOverwrite()
        Dim dr() As DataRow, incdt As Date
        Try
            incdt = FormatDateTime(dtpIncidentDate.Value, vbShortDate)
            dr = DataSets.IncidentTable.Select("AccidentID = '" & FormatNumber(txtIncidentID.Text, 0) & "'")
            If dr.Count > 0 Then RecordExists = True
        Catch ex As Exception
            RecordExists = False
        End Try
    End Sub

    Private Function ValidateEntry() As Boolean

        '# Add validation checks
        Return True

    End Function

    Private Sub RecordSave(RecordExists)
        Dim incdt As Date, repdt As Date
        incdt = FormatDateTime(dtpIncidentDate.Value, vbShortDate)
        repdt = FormatDateTime(dtpReportingDate.Value, vbShortDate)
        Try
            If RecordExists = True Then
                Dim dr() As DataRow
                dr = DataSets.IncidentTable.Select("AccidentID = '" & FormatNumber(txtIncidentID.Text, 0) & "'")
                repdt = FormatDateTime(dtpReportingDate.Value, vbShortDate)
                dr(0)("Date Reported") = repdt                                                              '# Overwrite reporting date
                dr(0)("Associate's Name") = txtAssociate.Text                                               '# Overwrite associate's name
                dr(0)("Accident Description") = txtDescription.Text                                         '# Overwrite description
                dr(0)("Medical") = medexpense                                                               '# Overwrite medical expense flag
                dr(0)("Time Loss") = nudLostTime.Value                                                      '# Overwrite lost time value
                dr(0)("Late Reporting") = lateexpense                                                       '# Overwrite late reporting flag
                dr(0)("EstimatedAmt") = FormatNumber(txtExpense.Text, 0)                                    '# Overwrite estimated charge
                dr(0)("IncidentType") = cbxType.Text                                                        '# Overwrite incident type
                If FormatNumber(curActualCharge.Text, 0) <> 0 Then dr(0)("AmountCharged") = FormatNumber(curActualCharge.Text, 2)                               '# Overwrite actual charge amount
            Else
                ' New
                Dim dr As DataRow = DataSets.IncidentTable.NewRow()
                dr("Accident Date") = incdt
                dr("Date Reported") = repdt
                dr("Department/Unit") = cbxUnit.Text
                dr("Associate's Name") = txtAssociate.Text
                dr("Accident Description") = txtDescription.Text
                dr("Medical") = medexpense
                dr("Time Loss") = nudLostTime.Value
                dr("Late Reporting") = lateexpense
                dr("AccidentID") = getNewID()
                dr("EstimatedAmt") = FormatNumber(txtExpense.Text, 0)
                dr("ReportGroup") = cbxGroup.Text
                dr("IncidentType") = cbxType.Text
                If FormatNumber(curActualCharge.Text, 0) <> 0 Then dr("AmountCharged") = FormatNumber(curActualCharge.Text, 2)
                DataSets.IncidentTable.Rows.Add(dr)

            End If

            Dim amsg As New AgnesMsgBox("Incident saved successfully.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            ClearAll()
            ChangesSaved = True
        Catch ex As Exception
            ChangesSaved = False
            Dim amsg As New AgnesMsgBox("Incident failed to save - " & vbCr & Err.Description & ". Please make sure you're connected to the corporate network and try again.  If this continues, notify the BI department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        End Try
        DataSets.IncidentAdapt.Update(DataSets.IncidentTable)
        DataSets.IncidentAdapt.Fill(DataSets.IncidentTable)
        dgvIncidentGrid.DataSource = AccidentReportingTableAdapter.GetData()

    End Sub

    Private Sub ClearAll()
        dtpIncidentDate.Value = FormatDateTime(Now(), vbShortDate)
        dtpReportingDate.Value = FormatDateTime((Now().AddMinutes(5)), vbShortDate)
        cbxUnit.SelectedIndex = -1
        cbxUnit.Text = ""
        cbxGroup.SelectedIndex = -1
        cbxGroup.Text = ""
        cbxType.SelectedIndex = -1
        cbxType.Text = ""
        txtAssociate.Text = ""
        txtDescription.Text = ""
        txtExpense.Text = "$0.00"
        curActualCharge.Text = "$0.00"
        chkMedical.Checked = False
        nudLostTime.Value = 0
        medexpense = False
        timeexpense = False
        lateexpense = False
        txtIncidentID.Text = ""
        RecordExists = False
    End Sub

    Private Function getNewID() As Integer
        Dim drmax() As DataRow, id As Integer
        drmax = DataSets.IncidentTable.Select("AccidentID = MAX(AccidentID)")
        id = drmax(0)("AccidentID") + 1
        Return id
    End Function

#End Region

End Class