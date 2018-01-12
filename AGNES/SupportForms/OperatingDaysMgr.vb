Public Class OperatingDaysMgr
    Public Property FY As Integer
    Public Property MSP As Byte
    Public Property UnitNum As Long
    Public Property CalledFromFlash As Boolean
    Public Property Activeweek As Byte
    Public Property NumberofWeeks As Byte
    Private Property SystemCall As Boolean = True
    Private ct As Byte

#Region "Initialize Form"

    Private Sub OperatingDaysMgr_Load(sender As Object, e As EventArgs) Handles Me.Load
        nudFY.Value = FY
        nudFY.Minimum = FY
        nudFY.Maximum = FY  '// CHANGE WHEN NEW CALENDAR IS AVAILABLE
        nudPeriod.Value = MSP
        DataSets.OpDaysAdapt.Fill(DataSets.OpDaysTable)
        SystemCall = False
        CheckForLockedFlashes()
        LoadOperatingDays()
    End Sub

#End Region

#Region "User Fields"

    Private Sub UserSelectedFYorMSP(sender As Object, e As EventArgs) Handles nudFY.ValueChanged, nudPeriod.ValueChanged
        If SystemCall = True Then Exit Sub
        FY = nudFY.Value
        MSP = nudPeriod.Value
        EnableAll()
        CheckForLockedFlashes()
        LoadOperatingDays()
    End Sub

    Private Sub UserCheckedABox(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkW1Fri.CheckedChanged, chkW1Mon.CheckedChanged, chkW1Tue.CheckedChanged, chkW1Wed.CheckedChanged, chkW1Thu.CheckedChanged,
            chkW2Fri.CheckedChanged, chkW2Mon.CheckedChanged, chkW2Tue.CheckedChanged, chkW2Wed.CheckedChanged, chkW2Thu.CheckedChanged, chkW3Fri.CheckedChanged, chkW3Mon.CheckedChanged,
            chkW3Tue.CheckedChanged, chkW3Wed.CheckedChanged, chkW3Thu.CheckedChanged, chkW4Fri.CheckedChanged, chkW4Mon.CheckedChanged, chkW4Tue.CheckedChanged, chkW4Wed.CheckedChanged,
            chkW4Thu.CheckedChanged, chkW5Fri.CheckedChanged, chkW5Mon.CheckedChanged, chkW5Tue.CheckedChanged, chkW5Wed.CheckedChanged, chkW5Thu.CheckedChanged
        If SystemCall = True Then Exit Sub
        Dim ctrl As New CheckBox : ctrl = sender
        Dim wc As Byte = Mid(ctrl.Name, 5, 1)
        panWeekOpDays.Controls("lblW" & wc & "Total").Text = CalculateWeekDays(wc)
        lblPeriodTotal.Text = CalculatePeriodDays()
    End Sub

    Private Sub UserSaving(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveOperatingDays()
    End Sub

    Private Sub CancelManager(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dispose()
    End Sub

#End Region

#Region "Functions"
    Private Sub EnableAll()
        For ct = 1 To 5
            With panWeekOpDays
                .Controls("chkW" & ct & "Fri").Enabled = True
                .Controls("chkW" & ct & "Mon").Enabled = True
                .Controls("chkW" & ct & "Tue").Enabled = True
                .Controls("chkW" & ct & "Wed").Enabled = True
                .Controls("chkW" & ct & "Thu").Enabled = True
            End With
        Next ct
    End Sub
    Private Sub CheckForLockedFlashes()
        Dim dr() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & FY & "' and MSPeriod = '" & MSP & "' and Unit = '" & UnitNum & "' and Status = 'Flash'")
        If dr.Count = 0 Then Exit Sub
        For ct = 0 To dr.Count - 1
            panWeekOpDays.Controls("chkW" & FormatNumber(dr(ct)("Week"), 0) & "Fri").Enabled = False
            panWeekOpDays.Controls("chkW" & FormatNumber(dr(ct)("Week"), 0) & "Mon").Enabled = False
            panWeekOpDays.Controls("chkW" & FormatNumber(dr(ct)("Week"), 0) & "Tue").Enabled = False
            panWeekOpDays.Controls("chkW" & FormatNumber(dr(ct)("Week"), 0) & "Wed").Enabled = False
            panWeekOpDays.Controls("chkW" & FormatNumber(dr(ct)("Week"), 0) & "Thu").Enabled = False
        Next
    End Sub

    Private Function CalculateWeekDays(w)
        Dim wkct As Byte = 0, tmpChk As CheckBox
        tmpChk = panWeekOpDays.Controls("ChkW" & w & "Fri")
        If tmpChk.Checked = True Then wkct = wkct + 1
        tmpChk = panWeekOpDays.Controls("ChkW" & w & "Mon")
        If tmpChk.Checked = True Then wkct = wkct + 1
        tmpChk = panWeekOpDays.Controls("ChkW" & w & "Tue")
        If tmpChk.Checked = True Then wkct = wkct + 1
        tmpChk = panWeekOpDays.Controls("ChkW" & w & "Wed")
        If tmpChk.Checked = True Then wkct = wkct + 1
        tmpChk = panWeekOpDays.Controls("ChkW" & w & "Thu")
        If tmpChk.Checked = True Then wkct = wkct + 1
        Return wkct
    End Function

    Private Function CalculatePeriodDays()
        Dim periodct As Byte = 0
        periodct = periodct + FormatNumber(lblW1Total.Text, 0)
        periodct = periodct + FormatNumber(lblW2Total.Text, 0)
        periodct = periodct + FormatNumber(lblW3Total.Text, 0)
        periodct = periodct + FormatNumber(lblW4Total.Text, 0)
        If lblW5Total.Visible = True Then periodct = periodct + FormatNumber(lblW5Total.Text, 0)
        Return periodct
    End Function

    Private Sub LoadOperatingDays()
        '#  Check for presence of stored operating days.  If present, fetch.  If none are present, use template unit #99999
        Dim tempUnitNumber As Long, drTest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & UnitNum & "' and FY = '" & FY & "' and MSP = '" & MSP & "'")
        If drTest.Count = 0 Then
            tempUnitNumber = 99999
        Else
            tempUnitNumber = UnitNum
        End If
        Dim dayct As Byte, periodct As Byte, dr() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & tempUnitNumber & "' and FY = '" & FY & "' and MSP = '" & MSP & "'")
        For ct = 0 To dr.Count - 1
            dayct = 0
            If dr(ct)("Fri") = True Then
                ToggleCheckBox("Fri", 1)
                dayct += 1
            Else
                ToggleCheckBox("Fri", 0)
            End If

            If dr(ct)("Mon") = True Then
                ToggleCheckBox("Mon", 1)
                dayct += 1
            Else
                ToggleCheckBox("Mon", 0)
            End If

            If dr(ct)("Tue") = True Then
                ToggleCheckBox("Tue", 1)
                dayct += 1
            Else
                ToggleCheckBox("Tue", 0)
            End If

            If dr(ct)("Wed") = True Then
                ToggleCheckBox("Wed", 1)
                dayct += 1
            Else
                ToggleCheckBox("Wed", 0)
            End If

            If dr(ct)("Thu") = True Then
                ToggleCheckBox("Thu", 1)
                dayct += 1
            Else
                ToggleCheckBox("Thu", 0)
            End If


            panWeekOpDays.Controls("lblW" & ct + 1 & "Total").Text = dayct
            periodct = periodct + dayct
        Next

        If ct = 5 Then
            ToggleWeek5(1)
        Else
            ToggleWeek5(0)
        End If
        lblPeriodTotal.Text = periodct
    End Sub

    Private Sub ToggleCheckBox(dy, v)
        Dim chk As New CheckBox
        chk = panWeekOpDays.Controls("chkW" & ct + 1 & dy)
        chk.Checked = v
    End Sub

    Private Sub ToggleWeek5(onoff)
        lblWeek5.Visible = onoff
        chkW5Fri.Visible = onoff
        chkW5Mon.Visible = onoff
        chkW5Tue.Visible = onoff
        chkW5Wed.Visible = onoff
        chkW5Thu.Visible = onoff
        lblW5Total.Visible = onoff
    End Sub

    Private Sub SaveOperatingDays()
        '#  Check for presence of stored operating days.  If present, replace.  If none are present, create new rows for the entry
        Dim drTest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & UnitNum & "' and FY = '" & FY & "' and MSP = '" & MSP & "'")
        If drTest.Count > 0 Then
            Dim pkid As long, tmpChk As CheckBox, dr() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & UnitNum & "' and FY = '" & FY & "' and MSP = '" & MSP & "'")
            For ct = 1 To NumberofWeeks
                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Fri")
                pkid = dr(ct - 1)("PKID")
                dr(ct - 1)("Fri") = tmpChk.Checked

                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Mon")
                dr(ct - 1)("Mon") = tmpChk.Checked

                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Tue")
                dr(ct - 1)("Tue") = tmpChk.Checked

                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Wed")
                dr(ct - 1)("Wed") = tmpChk.Checked

                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Thu")
                dr(ct - 1)("Thu") = tmpChk.Checked
            Next
        Else
            For ct = 1 To NumberofWeeks
                Dim tmpChk As CheckBox, newrow As DataRow = DataSets.OpDaysTable.NewRow()
                newrow("Unit") = UnitNum
                newrow("FY") = FY
                newrow("MSP") = MSP
                newrow("Week") = ct
                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Fri")
                newrow("Fri") = tmpChk.Checked
                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Mon")
                newrow("Mon") = tmpChk.Checked
                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Tue")
                newrow("Tue") = tmpChk.Checked
                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Wed")
                newrow("Wed") = tmpChk.Checked
                tmpChk = panWeekOpDays.Controls("chkW" & ct & "Thu")
                newrow("Thu") = tmpChk.Checked
                DataSets.OpDaysTable.Rows.Add(newrow)
            Next
        End If
        Try
            DataSets.OpDaysAdapt.Update(DataSets.OpDaysTable)
            Dim amsg As New AgnesMsgBox("Your changes have been saved.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        Catch ex As Exception
            Dim amsg As New AgnesMsgBox("AGNES has encountered a problem saving this data.  Please try again later.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        End Try
        If CalledFromFlash = True Then
            WeeklyFlash.ActiveWeek.PeriodOpDays = FormatNumber(lblPeriodTotal.Text, 0)
            If Activeweek > 0 Then WeeklyFlash.ActiveWeek.WeekOpDays = FormatNumber(Controls("panWeekOpDays").Controls("lblW" & Activeweek & "Total").Text, 0)
        Else
            WeeklyForecast.PeriodOpDays = FormatNumber(lblPeriodTotal.Text, 0)
        End If
        Close()
        Dispose()
    End Sub

#End Region

End Class