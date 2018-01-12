Public Class HRAudit
    Public Property username As String
    Public Property auditor As String
    Public Property UnitMgr As String
    Public auditnotes(16) As String
    Public AuditNotesAggregation As String
    Public Property AuditNotesPresent As Boolean
    Public SavedData As Boolean
    Public DataSaved As Boolean
    Public ChangesMade As Boolean
    Public yn As Boolean
    Public SystemChange As Boolean
    Public ct As Integer
    Private ScoreText As String
    Private ActualScore As Byte
    Private PossibleScore As Byte

#Region "Startup"

    Private Sub StartForm(sender As Object, e As EventArgs) Handles Me.Load
        For ct = 0 To 15 : auditnotes(ct) = "None" : Next ct
        sslblUser.Text = "Auditor: " & username
        auditor = username
        DataSets.HRLocationsAdapt.Fill(DataSets.HRLocationsTable)
        DataSets.HRAuditAdapt.Fill(DataSets.HRAuditTable)
        sslblSaveStatus.Text = ""
        tscboUnit.Items.Clear()
        For ct = 0 To DataSets.HRLocationsTable.Rows.Count - 1
            tscboUnit.Items.Add(DataSets.HRLocationsTable.Rows(ct)("Unit"))
        Next
    End Sub

#End Region

#Region "Tool Strip Controls"

    Private Sub SaveData(sender As Object, e As EventArgs) Handles tsbiSave.Click
        If SavedData = True Then
            Dim amsg As New AgnesMsgBox("Are you sure that you want to overwrite the previously saved data?", 2, 1, "")
            amsg.ShowDialog()
            yn = amsg.Choicemade
            amsg.Dispose()
            If yn = False Then Exit Sub
        End If

        '/  Check for missing fields
        Dim cboCheck As Control, missingitem As Boolean = False
        For Each cboCheck In panAudit.Controls
            If TypeOf cboCheck Is ComboBox Then
                If cboCheck.Text = "" Then missingitem = True
            End If
        Next

        If tscboAuditDate.Text = "" Then missingitem = True
        If tscboUnit.Text = "" Then missingitem = True
        If tstxtMgr.Text = "" Then missingitem = True

        If missingitem = True Then
            Dim amsg As New AgnesMsgBox("All fields must have a selection chosen before you can save!", 2, 0, "")
            amsg.ShowDialog()
            amsg.Dispose()
            tscboUnit.Focus()
            Exit Sub
        End If

        SaveDataProcess()
        tscboUnit.Focus()
        tsbiPrint.Enabled = True
    End Sub

    Private Sub PrintAuditReport(sender As Object, e As EventArgs) Handles tsbiPrint.Click
        'Dim outputscore As String
        'Dim oWord As Microsoft.Office.Interop.Word.Application
        'Dim oDoc As Microsoft.Office.Interop.Word.Document
        'oWord = CreateObject("Word.Application")
        'oDoc = oWord.Documents.Add("\\compasspowerbi\agnesdata\Templates\HRAudit.dotx")
        'oDoc.Bookmarks.Item("AuditUnit").Range.Text = tscboUnit.Text
        'oDoc.Bookmarks.Item("Manager").Range.Text = UnitMgr
        'oDoc.Bookmarks.Item("Auditor").Range.Text = auditor
        'oDoc.Bookmarks.Item("AuditDate").Range.Text = tscboAuditDate.Text
        'Dim cbx As ComboBox
        'For ct = 1 To 16
        '    cbx = CType(panAudit.Controls("cboCat" & ct), ComboBox)
        '    oDoc.Bookmarks.Item("AuditItem" & ct).Range.Text = cbx.Text
        'Next

        'Select Case (ActualScore / PossibleScore)
        '    Case < 0.71875
        '        outputscore = ScoreText & " - below target"
        '    Case < 0.84375
        '        outputscore = ScoreText & " - on target"
        '    Case < 0.9375
        '        outputscore = ScoreText & " - above target"
        '    Case Else
        '        outputscore = ScoreText & " - outstanding"
        'End Select

        'oDoc.Bookmarks.Item("OverallScore").Range.Text = outputscore
        'AuditNotesAggregation = "None"
        'For ct = 0 To 15
        '    If auditnotes(ct) <> "None" Then
        '        AuditNotesAggregation = AuditNotesAggregation & auditnotes(ct) & Chr(13)
        '    Else End If
        'Next ct
        'oDoc.Bookmarks.Item("NotesAdd").Range.InsertAfter(Chr(13) & "Audit Notes:" & Chr(13) & Chr(13) & GetAggregatedNotes())
        'oWord.Visible = True
    End Sub

    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsbiExit.Click
        If ChangesMade = True And DataSaved = False Then
            If VerifyClose() = False Then Exit Sub
        End If
        Close()
        Portal.Show()
    End Sub

    Private Sub ClearData(sender As Object, e As EventArgs) Handles tsbiClear.Click
        If SavedData = True And sslblSaveStatus.Text <> "Locked" Then
            Dim amsg As New AgnesMsgBox("This data has already been saved.  Are you sure that you want to clear it?", 2, 1, "")
            amsg.ShowDialog()
            yn = amsg.Choicemade
            amsg.Dispose()
            If yn = False Then Exit Sub
        End If
        ClearUserFields()
        tscboUnit.Focus()
        DataSaved = False
        ChangesMade = False
        tsbiPrint.Enabled = False
        sslblUser.Text = "Auditor: " & username
        auditor = username
    End Sub

    Private Sub ViewNotes(sender As Object, e As EventArgs) Handles tsbiNotes.Click
        Dim notes As New HRAuditNotes
        With notes
            .lblNoteHeader.Text = "Notes for " & tscboAuditDate.Text & " audit of " & tscboUnit.Text
            .rtxtNotes.Text = GetAggregatedNotes()
            .rtxtNotes.Enabled = False
            .btnSave.Text = "Close"
            .CatNum = 0
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub UnlockAudit(sender As Object, e As EventArgs) Handles tsbiUnlock.Click
        panAudit.Enabled = True
        sslblSaveStatus.Text = "Saved"
        tsbiSave.Enabled = True
        SystemChange = True
        cboCat1.Select()
        SystemChange = False
        tsbiUnlock.Enabled = False
        tsbiClear.Enabled = True
    End Sub

    Private Sub ChangedUnitSelection(sender As Object, e As EventArgs) Handles tscboUnit.SelectedIndexChanged
        If ChangesMade = True And DataSaved = False Then
            If VerifyClose() = False Then Exit Sub
        End If
        SystemChange = True
        ClearUserFields()
        ChangesMade = False
        SavedData = False
        SystemChange = False
        If tscboUnit.SelectedIndex = -1 Then
            tscboUnit.Text = ""
            Exit Sub
        End If
        tsbiSave.Enabled = True
        tsbiPrint.Enabled = False
        For ct = 0 To 15 : auditnotes(ct) = "None" : panAudit.Controls("pbxCat" & ct + 1).Visible = False : Next ct
        AuditNotesAggregation = ""
        AuditNotesPresent = False
        FetchPreviousAuditDates()
        tsbiNotes.Enabled = True
    End Sub

    Private Sub ChangedAuditDate(sender As Object, e As EventArgs) Handles tscboAuditDate.SelectedIndexChanged, tscboAuditDate.Leave
        If SystemChange = True Then Exit Sub
        If ChangesMade = True And DataSaved = False Then
            If VerifyClose() = False Then Exit Sub
        End If
        If tscboAuditDate.SelectedIndex = -1 Then
            tscboAuditDate.Text = Now().Date
            tscboAuditDate.Enabled = True
            Dim cbx As ComboBox
            For ct = 1 To 16
                cbx = CType(panAudit.Controls("cboCat" & ct), ComboBox)
                cbx.SelectedIndex = -1
                cbx.Text = ""
            Next
            For ct = 0 To 15 : auditnotes(ct) = "None" : panAudit.Controls("pbxCat" & ct + 1).Visible = False : Next ct
            AuditNotesAggregation = ""
            AuditNotesPresent = False
            sslblInformation.Text = ""
            sslblNotes.Text = ""
            sslblNotes.Visible = False
            sslblSaveStatus.Text = ""
            sslblInformation.Visible = False
            sslblInformation.Text = ""
            sslblInformation.ToolTipText = ""
            tsbiNotes.Enabled = True
            panAudit.Enabled = True
            tsbiSave.Enabled = True
            tsbiPrint.Enabled = False
            tsbiClear.Enabled = True
            auditor = username
            sslblUser.Text = "Auditor: " & auditor
            CalculateScore()
        End If
        populatewithpreviousdata(tscboAuditDate.Text)
        ChangesMade = False
    End Sub

#End Region

#Region "User Entry Region"

    Private Sub HoverOverForInfo(sender As Object, e As EventArgs) Handles lblCat1.MouseHover, lblCat2.MouseHover, lblCat3.MouseHover, lblCat4.MouseHover,
            lblCat5.MouseHover, lblCat6.MouseHover, lblCat7.MouseHover, lblCat8.MouseHover, lblCat9.MouseHover, lblCat10.MouseHover, lblCat11.MouseHover,
            lblCat12.MouseHover, lblCat13.MouseHover, lblCat14.MouseHover, lblCat15.MouseHover, lblCat16.MouseHover

        sslblInformation.Text = CType(sender, Label).Tag
        sslblInformation.ToolTipText = CType(sender, Label).Tag
        sslblInformation.Visible = True
    End Sub

    Private Sub StopHovering(sender As Object, e As EventArgs) Handles lblCat1.MouseLeave, lblCat2.MouseLeave, lblCat3.MouseLeave, lblCat4.MouseLeave,
            lblCat5.MouseLeave, lblCat6.MouseLeave, lblCat7.MouseLeave, lblCat8.MouseLeave, lblCat9.MouseLeave, lblCat10.MouseLeave, lblCat11.MouseLeave,
            lblCat12.MouseLeave, lblCat13.MouseLeave, lblCat14.MouseLeave, lblCat15.MouseLeave, lblCat16.MouseLeave
        sslblInformation.Text = ""
        sslblInformation.Visible = False
    End Sub

    Private Sub UpdateScore(sender As Object, e As EventArgs) Handles cboCat1.Leave, cboCat2.Leave, cboCat3.Leave, cboCat4.Leave, cboCat5.Leave,
            cboCat6.Leave, cboCat7.Leave, cboCat8.Leave, cboCat9.Leave, cboCat10.Leave, cboCat11.Leave, cboCat12.Leave, cboCat13.Leave, cboCat14.Leave,
            cboCat15.Leave, cboCat16.Leave

        CalculateScore()

    End Sub

    Private Sub ChangeMade(sender As Object, e As EventArgs) Handles cboCat1.SelectedIndexChanged, cboCat2.SelectedIndexChanged, cboCat3.SelectedIndexChanged,
        cboCat4.SelectedIndexChanged, cboCat5.SelectedIndexChanged, cboCat6.SelectedIndexChanged, cboCat7.SelectedIndexChanged, cboCat8.SelectedIndexChanged,
        cboCat9.SelectedIndexChanged, cboCat10.SelectedIndexChanged, cboCat11.SelectedIndexChanged, cboCat12.SelectedIndexChanged, cboCat13.SelectedIndexChanged,
        cboCat14.SelectedIndexChanged, cboCat15.SelectedIndexChanged, cboCat16.SelectedIndexChanged

        ChangesMade = True
        sslblSaveStatus.Text = "Not saved"
    End Sub

    Private Sub CategoryNotes(sender As Object, e As EventArgs) Handles csNotes.Click
        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
        Dim itemnum As Byte
        Select Case Len(cms.SourceControl.Name)
            Case 7
                itemnum = Mid(cms.SourceControl.Name, 7, 1)
            Case 8
                itemnum = Mid(cms.SourceControl.Name, 7, 2)
        End Select
        Dim notes As New HRAuditNotes
        Select Case auditnotes(itemnum - 1)
            Case "None"
                With notes
                    .lblNoteHeader.Text = "Add notes for " & tscboAuditDate.Text & " audit of " & tscboUnit.Text & " - " & panAudit.Controls("lblCat" & itemnum).Text
                    .rtxtNotes.Enabled = False
                    .rtxtNotes.Text = ""
                    .rtxtNotes.Enabled = True
                    .btnSave.Text = "Save"
                End With
            Case Else
                If sslblSaveStatus.Text = "Locked" Then
                    With notes
                        .lblNoteHeader.Text = "Notes for " & tscboAuditDate.Text & " audit of " & tscboUnit.Text & " - " & panAudit.Controls("lblCat" & itemnum).Text
                        .rtxtNotes.Enabled = False
                        .btnSave.Text = "Close"
                    End With
                Else
                    With notes
                        .lblNoteHeader.Text = "Edit notes for " & tscboAuditDate.Text & " audit of " & tscboUnit.Text & " - " & panAudit.Controls("lblCat" & itemnum).Text
                        .rtxtNotes.Enabled = False
                        .rtxtNotes.Enabled = True
                        .btnSave.Text = "Save"
                    End With
                End If
                notes.rtxtNotes.Text = auditnotes(itemnum - 1)
        End Select
        notes.CatNum = itemnum - 1
        notes.ShowDialog()
        notes.Dispose()


    End Sub

#End Region

#Region "Functions"

    Private Sub ClearUserFields()
        Dim cbx As ComboBox
        For ct = 1 To 16
            cbx = CType(panAudit.Controls("cboCat" & ct), ComboBox)
            cbx.SelectedIndex = -1
            cbx.Text = ""
        Next
        With tscboAuditDate
            .Items.Clear()
            .Text = ""
            .Enabled = False
        End With
        panAudit.Enabled = False
        tstxtMgr.Text = ""
        For ct = 0 To 15 : auditnotes(ct) = "None" : Next ct
        AuditNotesAggregation = ""
        AuditNotesPresent = False
        sslblInformation.Text = ""
        sslblNotes.Text = ""
        sslblNotes.Visible = False
        sslblSaveStatus.Text = ""
        sslblInformation.Visible = False
        sslblInformation.Text = ""
        sslblInformation.ToolTipText = ""
        auditor = username
        sslblUser.Text = "Auditor: " & auditor
        tsbiNotes.Enabled = False
        If SystemChange = False Then
            tscboUnit.SelectedIndex = -1
            tscboUnit.Text = ""
        End If
        CalculateScore()
    End Sub

    Private Sub FetchPreviousAuditDates()
        Dim dr() As Data.DataRow = DataSets.HRAuditTable.Select("Unit = '" & tscboUnit.Text & "'")
        If dr.Count < 1 Then
            tscboAuditDate.Text = Now().Date
            populatewithpreviousdata(tscboAuditDate.Text)
            tscboAuditDate.Enabled = False
            panAudit.Enabled = True
            tsbiPrint.Enabled = False
            tsbiClear.Enabled = True
            Exit Sub
        End If
        tscboAuditDate.Items.Clear()
        For ct = 0 To dr.Count - 1 Step 17
            Dim dt As Date = dr(ct)("AuditDate")
            Dim tm As String = CType(dt.Date, String)
            tscboAuditDate.Items.Add(tm)
        Next
        tscboAuditDate.Text = Now().Date
        tsbiClear.Enabled = True
        populatewithpreviousdata(tscboAuditDate.Text)
        tscboAuditDate.Enabled = True
        panAudit.Enabled = True
        tsbiPrint.Enabled = False
    End Sub

    Private Sub populatewithpreviousdata(dt)
        Dim dr() As Data.DataRow = DataSets.HRAuditTable.Select("Unit = '" & tscboUnit.Text & "' and AuditDate = '" & FormatDateTime(dt, DateFormat.ShortDate) & "'")
        If dr.Count < 1 Then
            tsbiUnlock.Enabled = False
            tsbiClear.Enabled = True
            Exit Sub
        End If
        For ct = 0 To dr.Count - 1
            panAudit.Controls(getControl(1, dr(ct)("Category"))).Text = dr(ct)("Result")
            auditor = dr(ct)("Auditor")
            UnitMgr = dr(ct)("UnitMgr")
            If dr(ct)("Notes") <> "None" Then
                AuditNotesPresent = True
                panAudit.Controls(getControl(2, dr(ct)("Category"))).Visible = True
                auditnotes(FormatNumber(getControl(3, dr(ct)("Category")), 0) - 1) = dr(ct)("Notes")
            Else
                panAudit.Controls(getControl(2, dr(ct)("Category"))).Visible = False
            End If
        Next
        If AuditNotesPresent = False Then
            sslblNotes.Text = ""
            sslblNotes.Visible = False
        Else
            sslblNotes.Text = "This audit has notes"
            sslblNotes.Visible = True
        End If
        tstxtMgr.Text = dr(dr.Count - 1)("UnitMgr")
        If dt = Now().Date Then
            panAudit.Enabled = True
            sslblSaveStatus.Text = "Saved"
            tsbiSave.Enabled = True
        Else
            panAudit.Enabled = False
            sslblSaveStatus.Text = "Locked"
            tsbiSave.Enabled = False
        End If
        SavedData = True
        CalculateScore()
        tsbiPrint.Enabled = True
        tsbiUnlock.Enabled = True
        tsbiClear.Enabled = False
        sslblUser.Text = "Auditor: " & auditor
    End Sub

    Private Function getControl(requesttype, nm) As String
        Dim ctrl As Control
        For Each ctrl In panAudit.Controls
            Select Case requesttype
                Case 1
                    If TypeOf ctrl Is ComboBox Then
                        If ctrl.Tag = nm Then
                            Return ctrl.Name
                            Exit Function
                        End If
                    End If
                Case 2
                    If TypeOf ctrl Is PictureBox Then
                        If ctrl.Tag = nm Then
                            Return ctrl.Name
                            Exit Function
                        End If
                    End If
                Case 3
                    If TypeOf ctrl Is ComboBox Then
                        If ctrl.Tag = nm Then
                            If Len(ctrl.Name) = 7 Then
                                Return Mid(ctrl.Name, 7, 1)
                            Else
                                Return Mid(ctrl.Name, 7, 2)
                            End If
                            Return ctrl.Name
                            Exit Function
                        End If
                    End If
            End Select
        Next
        Return "NotFound"
    End Function

    Private Sub SaveDataProcess()
        Select Case SavedData
            Case True
                '///    Overwrite existing records (just new result, auditor name, notes,and unit manager)
                Dim dr() As Data.DataRow = DataSets.HRAuditTable.Select("Unit = '" & tscboUnit.Text & "' and AuditDate = '" & FormatDateTime(tscboAuditDate.Text, vbShortDate) & "'")
                For ct = 1 To 16
                    dr(ct - 1)("Result") = panAudit.Controls("cboCat" & ct).Text
                    dr(ct - 1)("Auditor") = username
                    dr(ct - 1)("UnitMgr") = tstxtMgr.Text
                    dr(ct - 1)("Notes") = auditnotes(ct - 1)
                Next
            Case False
                '///    Write new series of records
                For ct = 1 To 16
                    Dim auditrow As DataRow = DataSets.HRAuditTable.NewRow()
                    auditrow.Item("Unit") = tscboUnit.Text
                    auditrow.Item("Category") = panAudit.Controls("cboCat" & ct).Tag
                    auditrow.Item("Result") = panAudit.Controls("cboCat" & ct).Text
                    auditrow.Item("Notes") = auditnotes(ct - 1)
                    auditrow.Item("AuditDate") = FormatDateTime(tscboAuditDate.Text, vbShortDate)
                    auditrow.Item("Auditor") = username
                    auditrow.Item("UnitMgr") = tstxtMgr.Text
                    DataSets.HRAuditTable.Rows.Add(auditrow)
                Next
        End Select
        DataSets.HRAuditAdapt.Update(DataSets.HRAuditTable)
        DataSets.HRAuditAdapt.Fill(DataSets.HRAuditTable)
        sslblSaveStatus.Text = "Saved"
        SavedData = True
        panAudit.Enabled = False
        UnitMgr = tstxtMgr.Text
    End Sub

    Private Sub CalculateScore()
        ScoreText = "Score: 0% (0/0)"
        ActualScore = 0
        PossibleScore = 0
        Dim cbx As ComboBox
        For ct = 1 To 16
            cbx = CType(panAudit.Controls("cboCat" & ct), ComboBox)
            If cbx.SelectedIndex <> -1 Then
                Select Case UCase(cbx.Text)
                    Case "MEETS EXPECTATIONS"
                        ActualScore += 2
                        PossibleScore += 2
                    Case "NEEDS ATTENTION"
                        ActualScore += 1
                        PossibleScore += 2
                    Case "IMMEDIATE ACTION REQUIRED"
                        PossibleScore += 2
                End Select
            End If
        Next
        If PossibleScore > 0 Then ScoreText = "Score: " & FormatPercent((ActualScore / PossibleScore), 1) & " (" & ActualScore & "/" & PossibleScore & ")"
        sslblScore.Text = ScoreText
    End Sub

    Private Function GetAggregatedNotes() As String
        AuditNotesAggregation = ""
        For ct = 0 To 15
            If auditnotes(ct) <> "None" Then AuditNotesAggregation = AuditNotesAggregation &
                panAudit.Controls("lblCat" & ct + 1).Text & ": " & auditnotes(ct) & Chr(13)
        Next ct
        Return AuditNotesAggregation
    End Function

    Private Function VerifyClose() As Boolean
        If ChangesMade = True And DataSaved = False Then
            Dim amsg As New AgnesMsgBox("It appears that you've made changes.  Are you sure that you want to exit without saving?", 2, 1, "")
            amsg.ShowDialog()
            yn = amsg.Choicemade
            amsg.Dispose()
            If yn = False Then
                Return False

            Else
                Return True
            End If
            Exit Function
        End If
        Return True
    End Function

#End Region

End Class