Public Class WeeklyFlash
    Public FlashType As String
    Public UserName As String
    Public UserId As String = Portal.UserID
    Public UserStatus As String
    Public UserLevel As String
    Public UserGroupAccess As String
    Public UnitNumber As Long
    Public UnitName As String
    Public ActiveWeek As New CurrentWeek
    Public ToggleSales As Single
    Public ToggleCOGS As Single
    Public ToggleLabor As Single
    Public ToggleOpex As Single
    Public ToggleNotes(5) As String
    Public ToggleValsLocked As Boolean
    Public FlashLock As Boolean
    Public MaxPeriod As Byte
    Public MaxWeek As Byte
    Public SentFromView As Boolean
    Public CurrDt As Date
    Public CallFromPTD As Boolean
    Public AdminDisplayAllWeeks As Boolean = False
    Private ynchoice As Boolean
    Private ct As Integer
    Public HasSubtotal As Boolean
    Public HasCogs As Boolean
    Public HasOther As Boolean
    Public HasForecast As Boolean
    Public SaveError As Long = 0

#Region "Initialize Flash"

    Private Sub LoadandConstructFlash(sender As Object, e As EventArgs) Handles Me.Load

        ActiveWeek.Parent = Me

        If HasForecast = False Then
            lblForecast.Visible = False
            lblForecastVariance.Visible = False
        End If
        ConstructFlashFields()
        LockUnlockUserCells(False)

        '# Fill all tables
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        DataSets.BudgetAdapt.Fill(DataSets.BudgetTable)
        DataSets.OpDaysAdapt.Fill(DataSets.OpDaysTable)
        DataSets.FlashAdapt.Fill(DataSets.FlashTable)
        DataSets.FlashAccessAdapt.Fill(DataSets.FlashAccessTable)
        DataSets.ForecastAdapt.Fill(DataSets.ForecastTable)

        '#  Determine if user is primary or delegate and enable/disable delegate option accordingly
        '#  Make unlock option visible if user is an admin, but disabled until a locked flash is loaded
        Select Case UserLevel
            Case "User"
                Dim AccessLevelDR() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & UserId & "' and UnitNumber = '" & UnitNumber & "'")
                If AccessLevelDR(0)("UserType") = "Primary" Then
                    tsmiDelegates.Enabled = True
                    PopulateDelegates()
                Else
                    tsmiDelegates.Enabled = False
                End If
            Case "Admin"
                tsmiDelegates.Enabled = True
                tsmiUnlock.Visible = True
                PopulateDelegates()
            Case Else
                tsmiDelegates.Enabled = True
                PopulateDelegates()
        End Select

        '# Populate available periods based on today's date
        Dim CurrDt As Date = FormatDateTime(Now(), DateFormat.ShortDate), p As Byte


        '///    RESTORE FOR PRODUCTION
        CurrDt = CurrDt.Date.AddDays(-6)
        '///    RESTORE FOR PRODUCTION
        '///    TEST
        'CurrDt = CurrDt.Date
        '///    TEST

        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & CurrDt & "'")
        ActiveWeek.FiscalYear = DateDR(0)("MS_FY")
        MaxPeriod = DateDR(0)("MS_Period")
        MaxWeek = DateDR(0)("Week")

        '# Override if in admin mode
        If AdminDisplayAllWeeks = True Then
            MaxPeriod = 12
            MaxWeek = 5
        End If

        For p = 0 To 11
            If p + 1 > MaxPeriod Then
                tsmiPeriod.DropDownItems(p).Enabled = False
            Else
                tsmiPeriod.DropDownItems(p).Enabled = True
            End If
        Next p

        '# React if Flash was called from DM Status View Module by immediately selecting the called period and week
        If SentFromView = True Then
            Dim item As ToolStripMenuItem = tsmiPeriod.DropDownItems.Item(FlashStatus.period - 1) : item.Checked = True : PeriodChosen(item, e)
            item = tsmiWeek.DropDownItems.Item(FlashStatus.Week - 1) : item.Checked = True : WeekChosen(item, e)
        End If

        tsslUser.Text = "Current User: " & Portal.UserName
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub SaveDraft(sender As Object, e As EventArgs) Handles tsmiDraft.Click
        SaveError = 0
        SaveFlash("Draft")
        If SaveError = 0 Then
            With ActiveWeek
                .Saved = True
                .ChangesMade = False
                .SaveType = "Draft"
            End With
            LockUnlockUserCells(True)
            tsslSaveStatus.Text = "Saved"
            tsslInformation.Text = "Draft flash"
            Dim amsg As New AgnesMsgBox("Your draft flash has been saved - note that Finance and your DM can NOT yet view it.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        Else
            Dim amsg As New AgnesMsgBox("Your draft flash was not saved due to error number " & SaveError & ".  Try again and, if this error continues, please notify the Business Intelligence department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        End If
    End Sub

    Private Sub SaveFinal(sender As Object, e As EventArgs) Handles tsmiFinal.Click
        SaveError = 0
        SaveFlash("Flash")
        If SaveError = 0 Then
            With ActiveWeek
                .Saved = True
                .ChangesMade = False
                .SaveType = "Final"
            End With
            LockUnlockUserCells(False)
            tsslSaveStatus.Text = "Saved"
            tsslInformation.Text = "Locked flash - view only"
            Dim amsg As New AgnesMsgBox("Your flash has been saved - the Finance office and your DM can now view it.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            tsmiDraft.Enabled = False
            tsmiFinal.Enabled = False
        Else
            Dim amsg As New AgnesMsgBox("Your flash was not saved due to error number " & SaveError & ".  Try again and, if this error continues, please notify the Business Intelligence department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        End If
    End Sub

    Private Sub PrintTheFlash(sender As Object, e As EventArgs) Handles tsmiPrint.Click
        With PrintFlash
            .PrinterSettings.DefaultPageSettings.Landscape = True
            .PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 100)
            .PrintAction = Printing.PrintAction.PrintToPreview
            .Print()
        End With
    End Sub

    Private Sub ExitFlash(sender As Object, e As EventArgs) Handles tsmiClose.Click
        If (ActiveWeek.ChangesMade = True And ActiveWeek.Saved = False) And ActiveWeek.SaveType = "New" Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Close()
        If SentFromView = False Then
            Portal.Show()
        Else
            FlashStatus.Show()
        End If
    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) Handles tsmiClear.Click
        ActiveWeek.Clear("FlashFields")
        ActiveWeek.RefreshView()
    End Sub

    Private Sub EditOperatingDays(sender As Object, e As EventArgs) Handles tsmiOpDays.Click
        With OperatingDaysMgr
            .FY = ActiveWeek.FiscalYear
            .MSP = ActiveWeek.MSPeriod
            .UnitNum = UnitNumber
            .CalledFromFlash = True
            .Activeweek = ActiveWeek.Week
            .NumberofWeeks = ActiveWeek.NumberofWeeks
            .ShowDialog()
        End With
        ActiveWeek.FetchBudget()
        ActiveWeek.RefreshView()
        tsslPeriodDays.Text = "Period Op Days: " & ActiveWeek.PeriodOpDays
        tsslWeekDays.Text = "Week Op Days: " & ActiveWeek.WeekOpDays
    End Sub

    Private Sub UnlockFlash(sender As Object, e As EventArgs) Handles tsmiUnlock.Click
        LockUnlockUserCells(True)
        tsmiFinal.Enabled = True
        tsslInformation.Text = "EDITING PREVIOUSLY SAVED FLASH!"
    End Sub

    Private Sub PeriodChosen(sender As Object, e As EventArgs) Handles tsmiP1.Click, tsmiP2.Click, tsmiP3.Click, tsmiP4.Click, tsmiP5.Click, tsmiP6.Click,
            tsmiP7.Click, tsmiP8.Click, tsmiP9.Click, tsmiP10.Click, tsmiP11.Click, tsmiP12.Click
        Dim sndr As ToolStripMenuItem = sender, msp As Byte

        '/  Check for unsaved data
        If (ActiveWeek.ChangesMade = True And ActiveWeek.Saved = False) And ActiveWeek.SaveType = "New" Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change periods?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If

        '/  Determine and assign period value
        If Len(sndr.Name) > 6 Then
            msp = Mid(sndr.Name, 6, 2)
        Else
            msp = Mid(sndr.Name, 6, 1)
        End If

        '/  Uncheck the other periods in the dropdown list
        For Each item In tsmiPeriod.DropDownItems
            item.checked = False
        Next
        sndr.Checked = True

        '/  Disable all week-dependent menu items and variables
        tsmiFinal.Enabled = False
        tsmiDraft.Enabled = False
        tsmiPrint.Enabled = False
        tsmiClear.Enabled = False
        tsmiViewPTD.Enabled = False
        tsslSaveStatus.Text = ""
        tsslSaveStatus.Visible = False
        tsslPeriodDays.Visible = False
        For Each item In tsmiWeek.DropDownItems
            item.checked = False
        Next

        '/ Clear and lock user and system fields
        ActiveWeek.Clear("AllFields")
        LockUnlockUserCells(False)

        '/ Set Activeweek object with the selected period
        ActiveWeek.MSPeriod = msp
        ActiveWeek.FetchBudget()

        '/ Enable usable menu items and populate available weeks, based on Max Week value
        For ct = 1 To 4
            tsmiWeek.DropDownItems("tsmiW" & ct).Visible = True
            If ct <= MaxWeek Or msp < MaxPeriod Then
                tsmiWeek.DropDownItems("tsmiW" & ct).Enabled = True
            Else
                tsmiWeek.DropDownItems("tsmiW" & ct).Enabled = False
            End If
        Next
        If ActiveWeek.NumberofWeeks = 5 Then
            tsmiW5.Visible = True
            If MaxWeek = 5 Or msp < MaxPeriod Then
                tsmiW5.Enabled = True
            Else
                tsmiW5.Enabled = False
            End If
        Else
            tsmiW5.Enabled = False
            tsmiW5.Visible = False
        End If

        tsmiOpDays.Enabled = True
        tsmiWeek.Enabled = True

        '/  Populate status bar items
        tsslPeriod.Text = "Period: " & ActiveWeek.MSPeriod
        tsslPeriod.Visible = True
        tsslWeek.Text = ""
        tsslWeek.Visible = False
        tsslInformation.Text = "Waiting for week selection"
    End Sub

    Private Sub WeekChosen(sender As Object, e As EventArgs) Handles tsmiW1.Click, tsmiW2.Click, tsmiW3.Click, tsmiW4.Click, tsmiW5.Click
        Dim sndr As ToolStripMenuItem = sender, wk As Byte

        '/  Check for unsaved data
        If ActiveWeek.ChangesMade = True And ActiveWeek.Saved = False Then '# And ActiveWeek.SaveType = "New" then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change weeks?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If

        '/  Determine and assign week value
        wk = Mid(sndr.Name, 6, 1)

        '/  Uncheck the other weeks in the dropdown list
        For Each item In tsmiWeek.DropDownItems
            item.checked = False
        Next
        sndr.Checked = True

        '/  Clear any data present and search for & fetch saved data
        With ActiveWeek
            .Clear("FlashFields")
            .Clear("BudgetFields")
            .Clear("ForecastFields")
            .Clear("NoteFields")
            .Clear("FlashFields")
        End With

        '/ Set Activeweek object with the selected week and get actual operating days for week from OpDays table
        ActiveWeek.Week = wk

        '///    NEED TO BUILD THE FORECAST FUNCTION
        With ActiveWeek
            .FetchBudget()
            .FetchForecast()
            .FetchSavedFlash()
        End With

        '#  Disable unlock option by default
        tsmiUnlock.Enabled = False

        Select Case ActiveWeek.SaveType
            Case "Final"
                LockUnlockUserCells(False)
                tsslSaveStatus.Text = "Locked"
                tsslSaveStatus.Visible = True
                tsslInformation.Text = "Locked flash - view only"
                tsmiFinal.Enabled = False
                tsmiDraft.Enabled = False
                tsmiPrint.Enabled = True
                ActiveWeek.ChangesMade = False
                If UserLevel = "Admin" Then tsmiUnlock.Enabled = True
            Case "Draft"
                LockUnlockUserCells(True)
                tsslSaveStatus.Text = "Draft"
                tsslSaveStatus.Visible = True
                tsslInformation.Text = "Draft Flash"
                ActiveWeek.ChangesMade = False
                tsmiFinal.Enabled = True
                tsmiDraft.Enabled = True
                tsmiPrint.Enabled = True
                tsmiClear.Enabled = True
            Case Else
                LockUnlockUserCells(True)
                tsslSaveStatus.Text = "Unsaved"
                tsslSaveStatus.Visible = False
                tsslInformation.Text = "New Flash"
                ActiveWeek.ChangesMade = False
                tsmiFinal.Enabled = True
                tsmiDraft.Enabled = True
                tsmiPrint.Enabled = True
                tsmiClear.Enabled = True
        End Select

        tsmiViewPTD.Enabled = True
        tsslWeek.Visible = True
        tsslWeek.Text = "Week: " & ActiveWeek.Week
    End Sub

    Private Sub PeriodorWeekViewToggle(sender As Object, e As EventArgs) Handles tsmiViewPTD.Click
        '#  Determing which view, based on label
        '#  If toggling to current week view, unlock the flash fields and call the recalculate routine
        '#  If toggling to PTD, lock the flash fields and call a different routine.
        '#  Drop out of routine is maxweek is 1.  No point.
        If (MaxWeek = 1 Or ActiveWeek.Week = 1) Then Exit Sub
        Dim ptdopdays As Integer = 0

        If tsmiViewPTD.Text = "Return to week view" Then
            tsmiViewPTD.Text = "View Period to Date"
            tsslWeek.Text = "Week: " & ActiveWeek.Week
            tsslWeekDays.Text = "Week Op Days: " & ActiveWeek.WeekOpDays
            tsmiDraft.Enabled = True
            tsmiFinal.Enabled = True
            tsmiEdit.Enabled = True
            tsmiPeriod.Enabled = True
            tsmiWeek.Enabled = True

            If ActiveWeek.FlashLock = True Or ActiveWeek.SaveType = "Final" Then
                LockUnlockUserCells(False)
            Else
                LockUnlockUserCells(True)
            End If


            With ActiveWeek
                .Clear("FlashFields")
                .RestoreFromSaved()
                .FetchBudget()
                .FetchForecast()
            End With
        Else
            Dim ptdfldr() As DataRow, calcval As Double
            '#  Includes any data present in the user fields - effectively, PTD including the current week, regardless of save status
            '#  Only go as far as the active week, even if the max week is greater and there are saved flashes

            '##################################
            '## UPDATE FLASH VALUES TO PTD
            '##################################

            '#  Check for fields with default zero value and overwrite in order to trigger stored value save

            For Each ctrl In Controls
                If TypeOf ctrl Is FlashGroup Then
                    Dim ftfg As FlashGroup = ctrl
                    Dim tester As Double = FormatNumber(ftfg.controls("FlashField").text, 0)
                    ftfg.StoredFlashValue = 0
                End If
            Next

            Try
                For Each ctrl In Controls
                    If TypeOf ctrl Is FlashGroup Then
                        Dim ftfg As FlashGroup = ctrl
                        ftfg.CalledFromPTD = False
                        If ftfg.Name <> "SUBSIDY" Then
                            ftfg.CalledFromPTD = True
                            ActiveWeek.FlashLock = Not ftfg.Controls("FlashField").Enabled
                            ftfg.StoredFlashValue = ftfg.FlashValue
                            ftfg.StoredNoteValue = ftfg.NoteValue
                            ftfg.NoteValue = "Period View"
                            calcval = ftfg.StoredFlashValue
                            For ct = 1 To ActiveWeek.Week - 1
                                Try
                                    ptdfldr = DataSets.FlashTable.Select("FiscalYear = '" & ActiveWeek.FiscalYear & "' and MSPeriod = '" & ActiveWeek.MSPeriod & "' and Week = '" & ct & "' and Status = 'Flash' and Unit = '" & UnitNumber & "' and GL_Category = '" & ftfg.Name & "'")
                                    calcval = calcval + FormatNumber(ptdfldr(0)("FlashValue"), 2)
                                    With ftfg
                                        .FlashValue = calcval
                                        .Controls("FlashField").Text = FormatCurrency(calcval, 2)
                                    End With
                                Catch ex As Exception
                                End Try
                            Next
                        End If
                    End If
                Next
            Catch ex As Exception

            End Try


            '##################################
            '## UPDATE BUDGET VALUES TO PTD
            '##################################
            For ct = 1 To ActiveWeek.Week
                        ptdopdays = ptdopdays + ActiveWeek.GetWeekOpDays(ct)
                    Next

                    Try
                        For Each ctrl In Controls
                            If TypeOf ctrl Is FlashGroup Then
                                Dim btfg As FlashGroup = ctrl
                                'If btfg.Name <> "SUBSIDY" Then
                                With btfg
                                    .BudgetValue = (btfg.FullBudget / ActiveWeek.PeriodOpDays) * ptdopdays
                                    .Controls("BudgetField").Text = FormatCurrency(btfg.BudgetValue, 0)
                                End With
                                'End If
                            End If
                        Next

                    Catch ex As Exception

                    End Try


                    '##################################
                    '## UPDATE FORECAST VALUES TO PTD
                    '##################################

                    tsmiDraft.Enabled = False
                    tsmiFinal.Enabled = False
                    tsmiEdit.Enabled = False
                    tsmiPeriod.Enabled = False
                    tsmiWeek.Enabled = False
                    tsmiViewPTD.Text = "Return to week view"
                    LockUnlockUserCells(False)
                    tsslWeek.Text = "Period to Date"
                    tsslWeekDays.Text = "Period to Date"
                    ActiveWeek.RefreshView()

                End If

    End Sub

    Private Sub AddNewDelegate(sender As Object, e As EventArgs) Handles tsmiAddDelegate.Click
        Dim amsg As AgnesMsgBox, newDelegate As String = InputBox("Enter the v- alias for the new delegate.", "Add New Delegate")
        If newDelegate = "" Then Exit Sub
        If Mid(newDelegate, 1, 2) <> "v-" Then
            amsg = New AgnesMsgBox("Do you want me to add a 'v-' to this alias?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = True Then newDelegate = "v-" & newDelegate
        End If
        Dim dr As DataRow = DataSets.FlashAccessTable.NewRow()
        dr("UserID") = newDelegate
        dr("UserType") = "Delegate"
        dr("AssignedBy") = UserName
        dr("UnitNumber") = UnitNumber
        dr("Group") = "Cafes"
        DataSets.FlashAccessTable.Rows.Add(dr)
        With DataSets.FlashAccessAdapt
            .Update(DataSets.FlashAccessTable)
            .Fill(DataSets.FlashAccessTable)
        End With

        If Portal.Muted = True Then
            amsg = New AgnesMsgBox(newDelegate & " has been added, but remember to notify the BI department to give them access to install me (AGNES) if I'm not already on their computer.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
        Else
            Portal.Synth.SpeakAsync("I've added your delegate, but remember to notify the bee eye department to give them access to install me if I'm not already on their computer.")
        End If

        PopulateDelegates()
    End Sub

#End Region

#Region "Functions"

    Private Sub ConstructFlashFields()
        Select Case FlashType
            Case "Cafes"
                '/  Create sales group and label
                Dim SalesGroup As New FlashGroup With
            {.Left = 72, .Top = 60, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = True, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "SALES", .DataName = "Sales"}

                Dim SalesLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 60, .Width = 70, .Height = 54, .Text = "Sales", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "SALESLABEL"}
                Controls.Add(SalesLabel)
                Controls.Add(SalesGroup)

                '/  Create cogs group and label
                Dim CogsGroup As New FlashGroup With
            {.Left = 72, .Top = 175, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "COGS", .DataName = "COGS"}

                Dim CogsLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 175, .Width = 70, .Height = 54, .Text = "COGS", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
                Controls.Add(CogsLabel)
                Controls.Add(CogsGroup)

                '/  Create labor group and label
                Dim LaborGroup As New FlashGroup With
            {.Left = 72, .Top = 290, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "LABOR", .DataName = "Labor"}

                Dim LaborLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 290, .Width = 70, .Height = 54, .Text = "Labor", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "LABORLABEL"}
                Controls.Add(LaborLabel)
                Controls.Add(LaborGroup)

                '/  Create opex group and label
                Dim OpexGroup As New FlashGroup With
            {.Left = 72, .Top = 405, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "OPEX", .DataName = "OPEX"}

                Dim OpexLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 405, .Width = 70, .Height = 54, .Text = "OPEX", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "OPEXLABEL"}
                Controls.Add(OpexLabel)
                Controls.Add(OpexGroup)

                '/  Create subsidy group and label
                Dim SubsidyGroup As New FlashGroup With
            {.Left = 72, .Top = 520, .Width = 865, .Height = 54, .FlashIsStatic = True, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .VarianceCallOut = True, .Name = "SUBSIDY"}

                Dim SubsidyLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 520, .Width = 70, .Height = 54, .Text = "Subsidy", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "SUBSIDYLABEL"}
                Controls.Add(SubsidyLabel)
                Controls.Add(SubsidyGroup)
            '===================================================================================
            Case "WCC"
                '/  Create sales group and label
                Dim SalesGroup As New FlashGroup With
            {.Left = 72, .Top = 60, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = True, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "CAM Revenue", .DataName = "CAM"}

                Dim SalesLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 60, .Width = 70, .Height = 112, .Text = "CAM", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "SALESLABEL"}
                Controls.Add(SalesLabel)
                Controls.Add(SalesGroup)

                '/  Create cogs group and label
                Dim CogsGroup As New FlashGroup With
            {.Left = 72, .Top = 175, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "COGS", .DataName = "COGS"}

                Dim CogsLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 175, .Width = 70, .Height = 112, .Text = "COGS", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
                Controls.Add(CogsLabel)
                Controls.Add(CogsGroup)

                '/  Create labor group and label
                Dim LaborGroup As New FlashGroup With
            {.Left = 72, .Top = 290, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "LABOR", .DataName = "Labor"}

                Dim LaborLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 290, .Width = 70, .Height = 112, .Text = "Labor", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "LABORLABEL"}
                Controls.Add(LaborLabel)
                Controls.Add(LaborGroup)

                '/  Create opex group and label
                Dim OpexGroup As New FlashGroup With
            {.Left = 72, .Top = 405, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "OPEX", .DataName = "OPEX"}

                Dim OpexLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 405, .Width = 70, .Height = 112, .Text = "OPEX", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "OPEXLABEL"}
                Controls.Add(OpexLabel)
                Controls.Add(OpexGroup)

                '/  Create subsidy group and label
                Dim SubsidyGroup As New FlashGroup With
            {.Left = 72, .Top = 520, .Width = 865, .Height = 54, .FlashIsStatic = True, .IsRevenueBlock = False, .ExcludeFromSubsidy = False,
            .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = HasForecast, .Name = "SUBSIDY"}

                Dim SubsidyLabel As New Label With
                    {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 520, .Width = 70, .Height = 54, .Text = "Subsidy", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "SUBSIDYLABEL"}
                Controls.Add(SubsidyLabel)
                Controls.Add(SubsidyGroup)
        End Select
    End Sub

    Private Sub LockUnlockUserCells(tf)
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is FlashGroup Then ctrl.Enabled = tf
        Next
    End Sub

    Public Sub FlagChanges(cm)
        If cm = 1 Then ActiveWeek.ChangesMade = True
        tsslSaveStatus.Text = "Not saved"
        tsslSaveStatus.Visible = True
    End Sub

    Public Sub SaveFlash(savetype)
        SaveError = False
        Dim t As FlashGroup
        Select Case ActiveWeek.SaveType
            Case "New"
                '###    HANDLE NON_DINING UNITS
                '###    HANDLE NON_DINING UNITS
                '###    HANDLE NON_DINING UNITS

                Try
                    If UnitNumber = 19837 Then
                        t = Controls("CAM Revenue") : InsertNewRow("CAM Revenue", savetype, t.FlashValue, t.NoteValue)
                    Else
                        t = Controls("Sales") : InsertNewRow("Sales", savetype, t.FlashValue, t.NoteValue)
                    End If

                    t = Controls("COGS") : InsertNewRow("COGS", savetype, t.FlashValue, t.NoteValue)
                    t = Controls("LABOR") : InsertNewRow("Labor", savetype, t.FlashValue, t.NoteValue)
                    t = Controls("OPEX") : InsertNewRow("OPEX", savetype, t.FlashValue, t.NoteValue)
                    DataSets.FlashAdapt.Update(DataSets.FlashTable)
                    DataSets.FlashAdapt.Fill(DataSets.FlashTable)
                Catch ex As Exception
                    SaveError = Err.Number
                End Try

            Case Else
                '###    HANDLE NON_DINING UNITS
                '###    HANDLE NON_DINING UNITS
                '###    HANDLE NON_DINING UNITS
                Try
                    If UnitNumber = 19837 Then
                        t = Controls("CAM Revenue") : UpdateExistingRow("CAM Revenue", savetype, t.FlashValue, t.NoteValue)
                    Else
                        t = Controls("Sales") : UpdateExistingRow("Sales", savetype, t.FlashValue, t.NoteValue)
                    End If
                    t = Controls("COGS") : UpdateExistingRow("COGS", savetype, t.FlashValue, t.NoteValue)
                    t = Controls("LABOR") : UpdateExistingRow("Labor", savetype, t.FlashValue, t.NoteValue)
                    t = Controls("OPEX") : UpdateExistingRow("OPEX", savetype, t.FlashValue, t.NoteValue)
                    If SaveError <> 0 Then Exit Sub
                    DataSets.FlashAdapt.Update(DataSets.FlashTable)
                    DataSets.FlashAdapt.Fill(DataSets.FlashTable)
                Catch ex As Exception
                    SaveError = Err.Number

                End Try
        End Select
    End Sub

    Private Sub InsertNewRow(cat, savetype, flashval, note)
        Dim dr As DataRow = DataSets.FlashTable.NewRow()
        '########
        '#  Reserved for future use - flashing down to the G/L level
        Dim glnum As Long = 0
        '########
        dr("FlashID") = ActiveWeek.FiscalYear & "-" & ActiveWeek.MSPeriod & "-" & ActiveWeek.Week & "-" & UnitNumber & "-" & glnum & "-" & cat
        dr("FiscalYear") = ActiveWeek.FiscalYear
        dr("MSPeriod") = ActiveWeek.MSPeriod
        dr("Week") = ActiveWeek.Week
        dr("Unit") = UnitNumber
        dr("Status") = savetype
        dr("GL") = glnum
        dr("GL_Category") = cat
        dr("FlashValue") = flashval
        dr("FlashNotes") = note
        dr("OpDaysWeek") = ActiveWeek.WeekOpDays
        dr("OpDaysPeriod") = ActiveWeek.PeriodOpDays
        dr("SavedBy") = UserName
        DataSets.FlashTable.Rows.Add(dr)
    End Sub

    Private Sub UpdateExistingRow(cat, savetype, flashval, note)
        Dim upDR() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & ActiveWeek.FiscalYear & "' and MSPeriod = '" & ActiveWeek.MSPeriod & "' and Week = '" & ActiveWeek.Week & "' and Unit = '" & UnitNumber & "' and GL_Category = '" & cat & "'")
            If upDR.Count > 1 Then
            SaveError = 1
            Exit Sub
        End If
        upDR(0)("FlashValue") = flashval
        upDR(0)("Status") = savetype
        upDR(0)("FlashNotes") = note
        upDR(0)("OpDaysWeek") = ActiveWeek.WeekOpDays
        upDR(0)("OpDaysPeriod") = ActiveWeek.PeriodOpDays
        upDR(0)("SavedBy") = UserName
    End Sub

    Private Sub PopulateDelegates()
        Dim tsmi As ToolStripMenuItem, tsmict As Byte = tsmiDelegates.DropDownItems.Count
        '#  Remove existing delegate menu items
        For ct = tsmict - 1 To 0 Step -1
            tsmi = tsmiDelegates.DropDownItems(ct)
            If tsmi.Name <> "tsmiAddDelegate" Then
                tsmiDelegates.DropDownItems.Remove(tsmi)
            End If
        Next

        '# Add delegates to list
        Dim dr() As DataRow = DataSets.FlashAccessTable.Select("UserType = 'Delegate' and UnitNumber = '" & UnitNumber & "'")
        For ct = 0 To dr.Count - 1
            Dim newDel As New ToolStripMenuItem With {.Text = dr(ct)("UserID"), .TextAlign = ContentAlignment.MiddleCenter}
            tsmiDelegates.DropDownItems.Add(newDel)
            AddHandler newDel.Click, AddressOf DeleteDelegate
        Next

    End Sub

    Private Sub DeleteDelegate(sender As Object, e As EventArgs)
        Dim tsmiSender As ToolStripMenuItem = sender
        Dim amsg As New AgnesMsgBox("Are you sure that you want to delete " & tsmiSender.Text & "?", 2, True, Me.Name)
        amsg.ShowDialog()
        ynchoice = amsg.Choicemade
        amsg.Dispose()
        If ynchoice = False Then Exit Sub

        '# Remove from drop down list
        tsmiDelegates.DropDownItems.Remove(tsmiSender)

        '# Remove from database
        Dim dr() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & tsmiSender.Text & "' and UserType = 'Delegate' and UnitNumber = '" & UnitNumber & "'")
        dr(0).Delete()
        DataSets.FlashAccessAdapt.Update(DataSets.FlashAccessTable)

        '#  Repopulate drop down list
        PopulateDelegates()
    End Sub

#End Region

End Class