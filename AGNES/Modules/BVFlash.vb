Public Class BVFlash
    Friend Property UserName As String
    Friend AdminDisplayAllWeeks As Boolean
    Friend SaveChanges As Boolean
    Friend SavedFlash As Boolean
    Friend ChangesMade As Boolean
    Private MSP As Byte
    Private Week As Byte
    Private MaxPeriod As Byte
    Private maxweek As Byte
    Private ynchoice As Boolean
    Private ct As Integer
    Private NumberofWeeks As Byte
    Private FY As Integer
    Friend systemchange As Boolean
    Private Property unnum As Long
    Public Property unit As Long
        Get
            Return unnum
        End Get
        Set(value As Long)
            unnum = value
            tsslUnit.Text = "Unit: " & unnum
        End Set
    End Property
    Private PTDActive As Boolean
    Private UnitHold As Long
    Private MoveForm As Boolean
    Private MoveForm_MousePosition As Point

#Region "Initialize Flash"

    Private Sub LoadFlash(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.BudgetAdapt.Fill(DataSets.BudgetTable)
        DataSets.FlashAdapt.Fill(DataSets.FlashTable)
        DataSets.DateAdapt.Fill(DataSets.DateTable)

        '#  Construct Flash groups
        ConstructFlashFields()

        '#  Set array for held values (temp storage of flash and budget values while toggling back and forth)
        Dim FlashArray(5, 5) As Double
        Dim BudgArray(5, 5) As Double

        tsslUser.Text = UserName
        '# Populate available periods based on today's date
        Dim CurrDt As Date = FormatDateTime(Now(), DateFormat.ShortDate), p As Byte


        '///    RESTORE FOR PRODUCTION
        CurrDt = CurrDt.Date.AddDays(-6)
        '///    RESTORE FOR PRODUCTION
        '///    TEST
        'CurrDt = CurrDt.Date
        '///    TEST

        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & CurrDt & "'")
        MaxPeriod = DateDR(0)("MS_Period")
        maxweek = DateDR(0)("Week")
        FY = DateDR(0)("MS_FY")
        tsslFY.Text = "Fiscal Year: " & FY
        tsslFY.Visible = True

        '# Override if in admin mode
        If AdminDisplayAllWeeks = True Then
            MaxPeriod = 12
            maxweek = 5
        End If

        For p = 0 To 11
            If p + 1 > MaxPeriod Then
                tsmiMsp.DropDownItems(p).Enabled = False
            Else
                tsmiMsp.DropDownItems(p).Enabled = True
            End If
        Next p

        LockUnlock(False)

        '#  Make unlock option visible if user is an admin, but disabled until a locked flash is loaded
        If Portal.UserLevel = "Admin" Then tsmiUnlock.Visible = True
        tsmi2627.BackColor = Color.SpringGreen : tsmi4404.BackColor = Color.AliceBlue : tsmi17135.BackColor = Color.AliceBlue
        tsmi27076.BackColor = Color.AliceBlue : tsmi5109.BackColor = Color.AliceBlue
        unit = 2627
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles mstBVFlash.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles mstBVFlash.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles mstBVFlash.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub SaveCurrentData(sender As Object, e As EventArgs) Handles tsmiSave.Click
        If ChangesMade = True Then FlashSave()
    End Sub

    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Close()
        Portal.Show()
    End Sub

    Private Sub UnlockFlash(sender As Object, e As EventArgs) Handles tsmiUnlock.Click
        LockUnlock(True)
    End Sub

    Private Sub PeriodChosen(sender As Object, e As EventArgs) Handles tsmiP1.Click, tsmiP2.Click, tsmiP3.Click,
            tsmiP4.Click, tsmiP5.Click, tsmiP6.Click, tsmiP7.Click, tsmiP8.Click, tsmiP9.Click, tsmiP10.Click,
            tsmiP11.Click, tsmiP12.Click

        Dim sndr As ToolStripMenuItem = sender
        If sndr.Enabled = False Then Exit Sub

        '/  Check for unsaved data
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change periods?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If

        ChangesMade = False
        SaveChanges = True
        ClearActive(0)
        Controls("TOTAL").Controls("BudgetField").Text = "$0.00"
        CalcFlashTotal()
        RecalcFields()
        tsslWeek.Visible = False
        '/  Determine and assign period value
        If Len(sndr.Name) > 6 Then
            MSP = Mid(sndr.Name, 6, 2)
        Else
            MSP = Mid(sndr.Name, 6, 1)
        End If

        tsslPeriod.Text = "Period " & MSP
        tsslPeriod.Visible = True

        '/  Uncheck the other periods in the dropdown list
        For Each item In tsmiMsp.DropDownItems
            item.checked = False
        Next
        sndr.Checked = True

        For ct = 1 To 4
            If ct <= maxweek Or MSP < MaxPeriod Then
                tsmiWeek.DropDownItems("tsmiW" & ct).Enabled = True
                tsmiWeek.DropDownItems("tsmiW" & ct).Visible = True
            Else
                tsmiWeek.DropDownItems("tsmiW" & ct).Enabled = False
                tsmiWeek.DropDownItems("tsmiW" & ct).Visible = True
            End If
        Next

        Try
            tsmiW5.Enabled = False
            tsmiW5.Visible = False
            Dim dr() As DataRow = DataSets.DateTable.Select("MS_FY = '" & FY & "' and MS_Period = '" & MSP & "' and Week = '5'")
            If dr.Count > 0 Then
                tsmiW5.Visible = True
                If maxweek = 5 Or MSP < MaxPeriod Then tsmiW5.Enabled = True
                NumberofWeeks = 5
            Else
                NumberofWeeks = 4
            End If

        Catch ex As Exception
            tsmiW5.Enabled = False
            tsmiW5.Visible = False
        End Try
        tsmiWeek.Enabled = True
        LockUnlock(False)
        tsmiW1.BackColor = Color.AliceBlue
        tsmiW2.BackColor = Color.AliceBlue
        tsmiW3.BackColor = Color.AliceBlue
        tsmiW1.BackColor = Color.AliceBlue
        tsmiW1.BackColor = Color.AliceBlue
    End Sub

    Private Sub WeekChosen(sender As Object, e As EventArgs) Handles tsmiW1.Click, tsmiW2.Click, tsmiW3.Click,
            tsmiW4.Click, tsmiW5.Click
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change weeks?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Dim wk As ToolStripDropDownItem = sender
        If wk.Enabled = False Then Exit Sub
        tsmiW1.BackColor = Color.AliceBlue
        tsmiW2.BackColor = Color.AliceBlue
        tsmiW3.BackColor = Color.AliceBlue
        tsmiW1.BackColor = Color.AliceBlue
        tsmiW1.BackColor = Color.AliceBlue

        tsmiUnlock.Enabled = False
        ChangesMade = False
        SaveChanges = True
        ClearActive(0)

        '/  Determine and assign week value
        Dim sndr As ToolStripMenuItem = sender
        Week = Mid(sndr.Name, 6, 1)
        tsslWeek.Text = "Week: " & Week
        tsslWeek.Visible = True
        ClearActive(0)
        EnableUnits()
        LockUnlock(True)
        ActivateUnit(sndr)

    End Sub

    Private Sub UnitSelected(sender As Object, e As EventArgs) Handles tsmi2627.Click, tsmi4404.Click, tsmi17135.Click, tsmi27076.Click, tsmi5109.Click
        tsmi2627.BackColor = Color.AliceBlue : tsmi4404.BackColor = Color.AliceBlue : tsmi17135.BackColor = Color.AliceBlue
        tsmi27076.BackColor = Color.AliceBlue : tsmi5109.BackColor = Color.AliceBlue
        Dim snd As ToolStripMenuItem = sender
        unit = FormatNumber(Mid(snd.Name, 5, Len(snd.Name) - 4), 0)
        ClearActive(0)
        ActivateUnit(snd)
        tsmiBevRollup.Enabled = True
        If unit = 5109 Then tsmiBevRollup.Enabled = False
    End Sub

    Private Sub ToggleRollupView(sender As Object, e As EventArgs) Handles tsmiBevRollup.Click
        If tsmiBevRollup.Text = "Beverage Rollup" Then
            If ChangesMade = True And SaveChanges = False Then
                Dim amsg As New AgnesMsgBox("You have unsaved data.  If you change to rollup view without saving, your data will be lost.  Do you want to continue?", 2, True, Me.Name)
                amsg.ShowDialog()
                ynchoice = amsg.Choicemade
                amsg.Dispose()
                If ynchoice = False Then Exit Sub
            End If
            Dim sa(2) As Double, co(2) As Double, la(2) As Double, op(2) As Double, fe(2) As Double
            UnitHold = unit
            tsmiBevRollup.Text = "Single Units"
            LockUnlockMenu(0, False)
            LockUnlock(False)
            ClearActive(0)
            unit = 2627 : FetchBudget() : FetchFlash()
            sa(1) = sa(1) + FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)
            co(1) = co(1) + FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)
            la(1) = la(1) + FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
            op(1) = op(1) + FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
            fe(1) = fe(1) + FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)

            sa(2) = sa(2) + FormatNumber(Controls("SALES").Controls("BudgetField").Text, 2)
            co(2) = co(2) + FormatNumber(Controls("COGS").Controls("BudgetField").Text, 2)
            la(2) = la(2) + FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2)
            op(2) = op(2) + FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2)
            fe(2) = fe(2) + FormatNumber(Controls("FEES").Controls("BudgetField").Text, 2)

            ClearActive(0)
            unit = 4404 : FetchBudget() : FetchFlash()
            co(1) = co(1) + FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)
            la(1) = la(1) + FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
            op(1) = op(1) + FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
            fe(1) = fe(1) + FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)

            co(2) = co(2) + FormatNumber(Controls("COGS").Controls("BudgetField").Text, 2)
            la(2) = la(2) + FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2)
            op(2) = op(2) + FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2)
            fe(2) = fe(2) + FormatNumber(Controls("FEES").Controls("BudgetField").Text, 2)

            ClearActive(0)
            unit = 17135 : FetchBudget() : FetchFlash()
            co(1) = co(1) + FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)
            la(1) = la(1) + FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
            op(1) = op(1) + FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
            fe(1) = fe(1) + FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)

            co(2) = co(2) + FormatNumber(Controls("COGS").Controls("BudgetField").Text, 2)
            la(2) = la(2) + FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2)
            op(2) = op(2) + FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2)
            fe(2) = fe(2) + FormatNumber(Controls("FEES").Controls("BudgetField").Text, 2)

            ClearActive(0)
            unit = 27076 : FetchBudget() : FetchFlash()
            co(1) = co(1) + FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)
            la(1) = la(1) + FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
            op(1) = op(1) + FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
            fe(1) = fe(1) + FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)

            co(2) = co(2) + FormatNumber(Controls("COGS").Controls("BudgetField").Text, 2)
            la(2) = la(2) + FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2)
            op(2) = op(2) + FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2)
            fe(2) = fe(2) + FormatNumber(Controls("FEES").Controls("BudgetField").Text, 2)

            ClearActive(0)
            Controls("SALES").Controls("FlashField").Text = FormatCurrency(sa(1), 2)
            Controls("COGS").Controls("FlashField").Text = FormatCurrency(co(1), 2)
            Controls("LABOR").Controls("FlashField").Text = FormatCurrency(la(1), 2)
            Controls("OPEX").Controls("FlashField").Text = FormatCurrency(op(1), 2)
            Controls("FEES").Controls("FlashField").Text = FormatCurrency(fe(1), 2)

            Controls("SALES").Controls("BudgetField").Text = FormatCurrency(sa(2), 2)
            Controls("COGS").Controls("BudgetField").Text = FormatCurrency(co(2), 2)
            Controls("LABOR").Controls("BudgetField").Text = FormatCurrency(la(2), 2)
            Controls("OPEX").Controls("BudgetField").Text = FormatCurrency(op(2), 2)
            Controls("FEES").Controls("BudgetField").Text = FormatCurrency(fe(2), 2)
            CalcFlashTotal()
            CalcBudgetTotal()
            RecalcFields()
            tsslUnit.Text = "Beverage Rollup"
        Else
            unit = UnitHold
            tsmiBevRollup.Text = "Beverage Rollup"
            LockUnlockMenu(0, True)
            LockUnlock(True)
            ClearActive(0)
            FetchBudget()
            FetchFlash()
            CalcFlashTotal()
            CalcBudgetTotal()
            RecalcFields()
        End If


    End Sub

    Private Sub TogglePTD(sender As Object, e As EventArgs) Handles tsmiPTD.Click
        If tsmiPTD.Text = "Period to Date" Then
            If ChangesMade = True And SaveChanges = False Then
                Dim amsg As New AgnesMsgBox("You have unsaved data.  If you change to PTD view without saving, your data will be lost.  Do you want to continue?", 2, True, Me.Name)
                amsg.ShowDialog()
                ynchoice = amsg.Choicemade
                amsg.Dispose()
                If ynchoice = False Then Exit Sub
            End If
            tsmiPTD.Text = "Week view"
            LockUnlockMenu(1, False)
            LockUnlock(False)
            ClearActive(0)
            PTDActive = True
            FetchBudget()
            FetchFlash()
            CalcFlashTotal()
            CalcBudgetTotal()
            RecalcFields()
        Else
            tsmiPTD.Text = "Period to Date"
            LockUnlockMenu(1, True)
            LockUnlock(True)
            ClearActive(0)
            PTDActive = False
            FetchBudget()
            FetchFlash()
            CalcFlashTotal()
            CalcBudgetTotal()
            RecalcFields()
        End If
    End Sub

#End Region

#Region "Functions"

    Private Sub ConstructFlashFields()
        '/  Create sales/sales tax group and label
        Dim SalesGroup As New FlashGroup With
    {.Left = 72, .Top = 60, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = True, .ExcludeFromSubsidy = False,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "SALES"}

        Dim SalesLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 60, .Width = 70, .Height = 112, .Text = "Sales", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "SALESLABEL"}
        Controls.Add(SalesLabel)
        Controls.Add(SalesGroup)

        '/  Create cogs group and label
        Dim CogsGroup As New FlashGroup With
    {.Left = 72, .Top = 175, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "COGS"}

        Dim CogsLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 175, .Width = 70, .Height = 112, .Text = "COGS", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(CogsLabel)
        Controls.Add(CogsGroup)

        '/  Create labor group and label
        Dim LaborGroup As New FlashGroup With
    {.Left = 72, .Top = 290, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "LABOR"}

        Dim LaborLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 290, .Width = 70, .Height = 112, .Text = "Labor", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(LaborLabel)
        Controls.Add(LaborGroup)

        '/  Create OPEX group and label
        Dim OpexGroup As New FlashGroup With
    {.Left = 72, .Top = 405, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "OPEX"}

        Dim OpexLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 405, .Width = 70, .Height = 112, .Text = "OPEX", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(OpexLabel)
        Controls.Add(OpexGroup)

        '/  Create fees group and label
        Dim FeesGroup As New FlashGroup With
    {.Left = 72, .Top = 520, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "FEES"}

        Dim FeesLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 520, .Width = 70, .Height = 112, .Text = "Fees", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(FeesLabel)
        Controls.Add(FeesGroup)

        '/  Create total group and label
        Dim TotalGroup As New FlashGroup With
    {.Left = 72, .Top = 635, .Width = 865, .Height = 55, .FlashIsStatic = True, .IsRevenueBlock = False, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "TOTAL", .Enabled = False}

        Dim TotalLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 635, .Width = 70, .Height = 55, .Text = "Total", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(TotalLabel)
        Controls.Add(TotalGroup)

    End Sub

    Private Sub ClearActive(t)
        Dim tfg As FlashGroup
        tfg = Controls("SALES")
        tfg.Clear(t)
        tfg = Controls("COGS")
        tfg.Clear(t)
        tfg = Controls("LABOR")
        tfg.Clear(t)
        tfg = Controls("OPEX")
        tfg.Clear(t)
        tfg = Controls("FEES")
        tfg.Clear(t)
    End Sub

    Private Sub LockUnlock(lu)
        Controls("SALES").Enabled = lu
        Controls("COGS").Enabled = lu
        Controls("LABOR").Enabled = lu
        Controls("OPEX").Enabled = lu
        Controls("FEES").Enabled = lu
        Select Case unit
            Case 2627, 5109
                Controls("SALES").Enabled = True
            Case Else
                Controls("SALES").Enabled = False
        End Select
    End Sub

    Private Sub LockUnlockMenu(ty, lu)
        tsmiSave.Enabled = lu
        tsmiMsp.Enabled = lu
        tsmiWeek.Enabled = lu
        tsmi2627.Enabled = lu
        tsmi4404.Enabled = lu
        tsmi17135.Enabled = lu
        tsmi27076.Enabled = lu
        tsmi5109.Enabled = lu
        If ty = 0 Then
            tsmiPTD.Enabled = lu
        Else
            tsmiBevRollup.Enabled = lu
        End If
    End Sub

    Private Sub EnableUnits()
        tsmi2627.Enabled = True : tsmi4404.Enabled = True : tsmi17135.Enabled = True
        tsmi27076.Enabled = True : tsmi5109.Enabled = True
    End Sub

    Private Sub ActivateUnit(ByRef tsmiobj)
        FetchFlash()
        FetchBudget()
        CalcFlashTotal()
        RecalcFields()

        tsslUnit.Text = "Unit: " & unit
        tsslUnit.Visible = True
        tsmiobj.BackColor = Color.SpringGreen
        tsmiBevRollup.Enabled = (unit = 2627)
        If unit = 5109 Or unit = 2627 Then
            Controls("SALES").Enabled = True
            Controls("SALES").Controls("FlashField").Select()
        Else
            Controls("SALES").Enabled = False
            Controls("COGS").Controls("FlashField").Select()
        End If
    End Sub

    Private Sub FetchFlash()
        systemchange = True
        Dim StartWeek As Byte, endweek As Byte
        If PTDActive = False Then
            StartWeek = Week : endweek = Week
        Else
            StartWeek = 1 : endweek = Week
        End If
        GetFlash(StartWeek, endweek)
        systemchange = False
    End Sub

    Private Sub GetFlash(StWk, EndWk)
        Dim s As Double = 0, c As Double = 0, l As Double = 0, o As Double = 0, f As Double = 0, w As Byte, dr() As DataRow
        For w = StWk To EndWk
            Try
                dr = DataSets.FlashTable.Select("FlashID = '" & FY & "-" & MSP & "-" & w & "-" & unit & "-0-SALES'")
                s = s + FormatNumber(dr(0)("FlashValue"), 2)
                Controls("SALES").Controls("Notes").Text = dr(0)("FlashNotes")
                ChangesMade = False
                SavedFlash = True
                tsslSaveStatus.Text = "Saved Flash"
            Catch ex As Exception
                ChangesMade = False
                SavedFlash = False
            End Try

            Try
                dr = DataSets.FlashTable.Select("FlashID = '" & FY & "-" & MSP & "-" & w & "-" & unit & "-0-COGS'")
                c = c + FormatNumber(dr(0)("FlashValue"), 2)
                Controls("COGS").Controls("Notes").Text = dr(0)("FlashNotes")
                ChangesMade = False
                SavedFlash = True
                tsslSaveStatus.Text = "Saved Flash"
            Catch ex As Exception
                ChangesMade = False
                SavedFlash = False
            End Try

            Try
                dr = DataSets.FlashTable.Select("FlashID = '" & FY & "-" & MSP & "-" & w & "-" & unit & "-0-LABOR'")
                l = l + FormatNumber(dr(0)("FlashValue"), 2)
                Controls("LABOR").Controls("Notes").Text = dr(0)("FlashNotes")
                ChangesMade = False
                SavedFlash = True
                tsslSaveStatus.Text = "Saved Flash"
            Catch ex As Exception
                ChangesMade = False
                SavedFlash = False
            End Try

            Try
                dr = DataSets.FlashTable.Select("FlashID = '" & FY & "-" & MSP & "-" & w & "-" & unit & "-0-OPEX'")
                o = o + FormatNumber(dr(0)("FlashValue"), 2)
                Controls("OPEX").Controls("Notes").Text = dr(0)("FlashNotes")
                ChangesMade = False
                SavedFlash = True
                tsslSaveStatus.Text = "Saved Flash"
            Catch ex As Exception
                ChangesMade = False
                SavedFlash = False
            End Try

            Try
                dr = DataSets.FlashTable.Select("FlashID = '" & FY & "-" & MSP & "-" & w & "-" & unit & "-0-FEES'")
                f = f + FormatNumber(dr(0)("FlashValue"), 2)
                Controls("FEES").Controls("Notes").Text = dr(0)("FlashNotes")
                ChangesMade = False
                SavedFlash = True
                tsslSaveStatus.Text = "Saved Flash"
            Catch ex As Exception
                ChangesMade = False
                SavedFlash = False
            End Try
        Next

        If unit = 5109 Or unit = 2627 Then Controls("SALES").Controls("FlashField").Text = FormatCurrency(s, 2)
        Controls("COGS").Controls("FlashField").Text = FormatCurrency(c, 2)
        Controls("LABOR").Controls("FlashField").Text = FormatCurrency(l, 2)
        Controls("OPEX").Controls("FlashField").Text = FormatCurrency(o, 2)
        Controls("FEES").Controls("FlashField").Text = FormatCurrency(f, 2)
        If SavedFlash = True Then LockUnlock(False)
        If Portal.UserLevel = "Admin" Then tsmiUnlock.Enabled = True
    End Sub

    Private Sub FetchBudget()
        systemchange = True
        Dim PTDMultiplier As Byte
        If PTDActive = 0 Then
            PTDMultiplier = 1
        Else
            PTDMultiplier = Week
        End If
        GetBudget(NumberofWeeks, PTDMultiplier)
        systemchange = False
    End Sub

    Private Sub GetBudget(NumWks, ptdm)
        Dim cycle As Byte = GetCycle()
        Dim dr() As DataRow
        If unit = 5109 Then
            Try
                dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-Sales-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
                Controls("SALES").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
            Catch ex As Exception
                Controls("SALES").Controls("BudgetField").Text = FormatCurrency(0, 2)
            End Try
            Controls("SALESLABEL").Text = "Sales"
        Else
            Try
                dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-Sales Tax-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
                Controls("SALES").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
                'Controls("SALES").Controls("FlashField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
                Controls("SALESLABEL").Text = "Sales Tax"
            Catch ex As Exception
                Controls("SALES").Controls("BudgetField").Text = FormatCurrency(0, 2)
            End Try
        End If

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-COGS-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("COGS").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
        Catch ex As Exception
            Controls("COGS").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-OPEX-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("OPEX").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
        Catch ex As Exception
            Controls("OPEX").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-Labor-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("LABOR").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
        Catch ex As Exception
            Controls("LABOR").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-Fees-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("FEES").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
        Catch ex As Exception
            Controls("FEES").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & unit & "-Subsidy-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("TOTAL").Controls("BudgetField").Text = FormatCurrency(((dr(0)("Budget") / NumWks) * ptdm), 2)
        Catch ex As Exception
            Controls("TOTAL").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try
    End Sub

    Private Function GetCycle()
        'TODO: 7/2018: Fix cycle capture on Bev Flash
        'Dim c As Integer
        'For c = 4 To 1 Step -1
        '    Dim dr() As DataRow = DataSets.BudgetTable.Select("Unit = '" & unit & "' and Cycle = '" & c & "'")
        '    If dr.Count > 0 Then Exit For
        'Next
        Return 1
    End Function

    Public Sub CalcFlashTotal()
        '#  Recalculate flash total field
        Dim flash As Double
        flash = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)
        flash = flash + FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)
        flash = flash + FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
        flash = flash + FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
        Controls("TOTAL").Controls("FlashField").Text = FormatCurrency(flash, 2)
    End Sub

    Private Sub CalcBudgetTotal()
        '#  Recalculate flash total field
        Dim budget As Double
        budget = FormatNumber(Controls("SALES").Controls("BudgetField").Text, 2)
        budget = budget + FormatNumber(Controls("COGS").Controls("BudgetField").Text, 2)
        budget = budget + FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2)
        budget = budget + FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2)
        Controls("TOTAL").Controls("BudgetField").Text = FormatCurrency(budget, 2)
    End Sub

    Public Sub RecalcFields()
        Dim budg As Double, flash As Double, vari As Double
        '#  Recalculate variance fields
        budg = FormatNumber(Controls("SALES").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("SALES").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("COGS").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("COGS").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("COGS").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("LABOR").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("OPEX").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("FEES").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("FEES").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("FEES").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("TOTAL").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("TOTAL").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("TOTAL").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
    End Sub

    Private Sub FlashSave()

        Dim baseflashkey As String = FY & "-" & MSP & "-" & Week & "-" & unit & "-0-"
        If SavedFlash = True Then
            Try
                Dim dr() As DataRow

                If unit = 5109 Then
                    dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "SALES'")
                    dr(0)("FlashValue") = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)    '# Overwrite flash value for revenue
                    If Controls("SALES").Controls("Notes").Text <> "Add notes here" Then
                        dr(0)("FlashNotes") = Controls("SALES").Controls("Notes").Text
                    Else
                        dr(0)("FlashNotes") = ""
                    End If
                End If

                If unit = 2627 Then
                    dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "SALES'")
                    dr(0)("FlashValue") = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)    '# Overwrite flash value for revenue
                    If Controls("SALES").Controls("Notes").Text <> "Add notes here" Then
                        dr(0)("FlashNotes") = Controls("SALES").Controls("Notes").Text
                    Else
                        dr(0)("FlashNotes") = ""
                    End If
                End If

                dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "COGS'")
                dr(0)("FlashValue") = FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)    '# Overwrite flash value for labor
                    If Controls("COGS").Controls("Notes").Text <> "Add notes here" Then
                        dr(0)("FlashNotes") = Controls("COGS").Controls("Notes").Text
                    Else
                        dr(0)("FlashNotes") = ""
                    End If

                    dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "LABOR'")
                dr(0)("FlashValue") = FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)    '# Overwrite flash value for labor
                    If Controls("LABOR").Controls("Notes").Text <> "Add notes here" Then
                        dr(0)("FlashNotes") = Controls("LABOR").Controls("Notes").Text
                    Else
                        dr(0)("FlashNotes") = ""
                    End If

                    dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "OPEX'")
                dr(0)("FlashValue") = FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)     '# Overwrite flash value for opex
                    If Controls("OPEX").Controls("Notes").Text <> "Add notes here" Then
                        dr(0)("FlashNotes") = Controls("OPEX").Controls("Notes").Text
                    Else
                        dr(0)("FlashNotes") = ""
                    End If

                    dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "FEES'")
                dr(0)("FlashValue") = FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)     '# Overwrite flash value for fees
                    If Controls("FEES").Controls("Notes").Text <> "Add notes here" Then
                        dr(0)("FlashNotes") = Controls("FEES").Controls("Notes").Text
                    Else
                        dr(0)("FlashNotes") = ""
                    End If

                    DataSets.FlashAdapt.Update(DataSets.FlashTable)

                Dim amsg As New AgnesMsgBox("Flash saved successfully.", 2, False, Me.Name)
                amsg.ShowDialog()
                amsg.Dispose()
                SaveChanges = True
                ChangesMade = False
                tsslSaveStatus.Text = "Saved"

            Catch ex As Exception
                SaveChanges = False
                tsslSaveStatus.Text = "Not saved"
                Dim amsg As New AgnesMsgBox("Flash failed to save - " & vbCr & Err.Description & ". Please make sure you're connected to the corporate network and try again.  If this continues, notify the BI department.", 2, False, Me.Name)
                amsg.ShowDialog()
                amsg.Dispose()
            End Try


        Else
            Try
                If unit = 5109 Then
                    Dim dr As DataRow = DataSets.FlashTable.NewRow()
                    dr("FlashID") = baseflashkey & "SALES"
                    dr("FiscalYear") = FY
                    dr("MSPeriod") = MSP
                    dr("Week") = Week
                    dr("Unit") = unit
                    dr("Status") = "Flash"
                    dr("GL") = 0
                    dr("GL_Category") = "SALES"
                    dr("FlashValue") = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)
                    If Controls("SALES").Controls("Notes").Text <> "Add notes here" Then
                        dr("FlashNotes") = Controls("SALES").Controls("Notes").Text
                    Else
                        dr("FlashNotes") = ""
                    End If
                    dr("OpDaysWeek") = 1
                    dr("OpDaysPeriod") = NumberofWeeks
                    DataSets.FlashTable.Rows.Add(dr)
                End If

                If unit = 2627 Then
                    Dim dr As DataRow = DataSets.FlashTable.NewRow()
                    dr("FlashID") = baseflashkey & "SALES"
                    dr("FiscalYear") = FY
                    dr("MSPeriod") = MSP
                    dr("Week") = Week
                    dr("Unit") = unit
                    dr("Status") = "Flash"
                    dr("GL") = 0
                    dr("GL_Category") = "SALES"
                    dr("FlashValue") = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)
                    If Controls("SALES").Controls("Notes").Text <> "Add notes here" Then
                        dr("FlashNotes") = Controls("SALES").Controls("Notes").Text
                    Else
                        dr("FlashNotes") = ""
                    End If
                    dr("OpDaysWeek") = 1
                    dr("OpDaysPeriod") = NumberofWeeks
                    DataSets.FlashTable.Rows.Add(dr)
                End If

                Dim dr1 As DataRow = DataSets.FlashTable.NewRow()
                dr1("FlashID") = baseflashkey & "COGS"
                dr1("FiscalYear") = FY
                dr1("MSPeriod") = MSP
                dr1("Week") = Week
                dr1("Unit") = unit
                dr1("Status") = "Flash"
                dr1("GL") = 0
                dr1("GL_Category") = "COGS"
                dr1("FlashValue") = FormatNumber(Controls("COGS").Controls("FlashField").Text, 2)
                If Controls("COGS").Controls("Notes").Text <> "Add notes here" Then
                    dr1("FlashNotes") = Controls("COGS").Controls("Notes").Text
                Else
                    dr1("FlashNotes") = ""
                End If
                dr1("OpDaysWeek") = 1
                dr1("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr1)

                Dim dr2 As DataRow = DataSets.FlashTable.NewRow()
                dr2("FlashID") = baseflashkey & "LABOR"
                dr2("FiscalYear") = FY
                dr2("MSPeriod") = MSP
                dr2("Week") = Week
                dr2("Unit") = unit
                dr2("Status") = "Flash"
                dr2("GL") = 0
                dr2("GL_Category") = "LABOR"
                dr2("FlashValue") = FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
                If Controls("LABOR").Controls("Notes").Text <> "Add notes here" Then
                    dr2("FlashNotes") = Controls("LABOR").Controls("Notes").Text
                Else
                    dr2("FlashNotes") = ""
                End If
                dr2("OpDaysWeek") = 1
                dr2("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr2)

                Dim dr3 As DataRow = DataSets.FlashTable.NewRow()
                dr3("FlashID") = baseflashkey & "OPEX"
                dr3("FiscalYear") = FY
                dr3("MSPeriod") = MSP
                dr3("Week") = Week
                dr3("Unit") = unit
                dr3("Status") = "Flash"
                dr3("GL") = 0
                dr3("GL_Category") = "OPEX"
                dr3("FlashValue") = FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
                If Controls("OPEX").Controls("Notes").Text <> "Add notes here" Then
                    dr3("FlashNotes") = Controls("OPEX").Controls("Notes").Text
                Else
                    dr3("FlashNotes") = ""
                End If
                dr3("OpDaysWeek") = 1
                dr3("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr3)

                Dim dr4 As DataRow = DataSets.FlashTable.NewRow()
                dr4("FlashID") = baseflashkey & "FEES"
                dr4("FiscalYear") = FY
                dr4("MSPeriod") = MSP
                dr4("Week") = Week
                dr4("Unit") = unit
                dr4("Status") = "Flash"
                dr4("GL") = 0
                dr4("GL_Category") = "FEES"
                dr4("FlashValue") = FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)
                If Controls("FEES").Controls("Notes").Text <> "Add notes here" Then
                    dr4("FlashNotes") = Controls("FEES").Controls("Notes").Text
                Else
                    dr4("FlashNotes") = ""
                End If
                dr4("OpDaysWeek") = 1
                dr4("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr4)

                DataSets.FlashAdapt.Update(DataSets.FlashTable)

                Dim amsg As New AgnesMsgBox("Flash saved successfully.", 2, False, Me.Name)
                amsg.ShowDialog()
                amsg.Dispose()
                SaveChanges = True
                ChangesMade = False
                tsslSaveStatus.Text = "Saved"
            Catch ex As Exception
                SaveChanges = False
                tsslSaveStatus.Text = "Not saved"
                Dim amsg As New AgnesMsgBox("Flash failed to save - " & vbCr & Err.Description & ". Please make sure you're connected to the corporate network and try again.  If this continues, notify the BI department.", 2, False, Me.Name)
                amsg.ShowDialog()
                amsg.Dispose()
            End Try

        End If

    End Sub

#End Region

End Class