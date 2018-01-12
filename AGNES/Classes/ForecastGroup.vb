Public Class ForecastGroup
    Inherits GroupBox
    Public Property GroupName As String = "Test"        '#  Use to identify group - Sales, COGS, etc.               
    Public Property ForecastIsStatic As Boolean         '#  Use to determine whether to create forecast field as a static textbox, or a flashuservalue object.  Also excludes notes if TRUE
    Public Property IsRevenueBlock As Boolean           '#  Use to determine if percentage fields are present and other revenue-related actions
    Public Property ExcludeFromSubsidy As Boolean       '#  Use to flag whether the values present should be excluded from the calculation of subsidy (sales totals, for instance)
    Public Property SubTotalRef As String = ""          '#  Use to indicate if the totals should be included in a subtotal FlashGroup, by name of that FlashGroup (sales totals, for instance)
    Public Property IsSubtotal As Boolean               '#  Use to indicate if this is a subtotal block - will be handled in Recalcuate method
    Public Property ChangeVal As String                 '#  Use to store current value when field is entered; during Recalculate(), this compared to value when field is left and ChangesMade flag triggered as needed 
    Public Property ExcludePercentofSales As Boolean    '#  Use to toggle percent of sales fields
    Public Property AllowAllValues As Boolean           '#  Allows full override of neg/pos value restrictions when TRUE
    Public Property VarianceCallOut As Boolean          '#  Sets subsidy variance to show green/red font for pos/neg values
    Public Property AvailableWeekStart As Byte          '#  Set by parent to enable only those weeks that are remaining in a period
    Public Property ShowFifthWeek As Boolean            '#  Set by parent to enable fifth week in the selected period, if present
    Private Property OldValue As Double                 '#  Temporary storage of field value upon entry for comparison upon exit.  Flags changesmade in parent

    Private Sub InitializeForecastGroup(sender As Object, e As EventArgs) Handles Me.HandleCreated

        '#  Define group object properties
        Height = 60 : Width = 950 : Left = 9

        '#  Scope group object members and their base properties
        Dim TypeLabel As New Label With {.Text = Name, .AutoSize = False, .Left = 1, .Top = 21, .Height = 25, .Width = 49, .Name = "Category", .Font = New Drawing.Font("Segoe UI Emoji", 8, FontStyle.Regular), .TextAlign = HorizontalAlignment.Center}
        Dim RunRateTxt As New FlashUserValue With {.Left = 57, .Top = 21, .Height = 25, .Width = 75, .Name = "DRR", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Text = "$0.00", .Enabled = False, .OpenValue = AllowAllValues}
        Dim Week1FcastTxt As New FlashUserValue With {.Left = 138, .Top = 21, .Height = 25, .Width = 75, .Name = "Week1", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Text = "$0.00", .Enabled = False, .OpenValue = AllowAllValues}
        Dim Week2FcastTxt As New FlashUserValue With {.Left = 219, .Top = 21, .Height = 25, .Width = 75, .Name = "Week2", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Text = "$0.00", .Enabled = False, .OpenValue = AllowAllValues}
        Dim Week3FcastTxt As New FlashUserValue With {.Left = 300, .Top = 21, .Height = 25, .Width = 75, .Name = "Week3", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Text = "$0.00", .Enabled = False, .OpenValue = AllowAllValues}
        Dim Week4FcastTxt As New FlashUserValue With {.Left = 381, .Top = 21, .Height = 25, .Width = 75, .Name = "Week4", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Text = "$0.00", .Enabled = False, .OpenValue = AllowAllValues}
        Dim Week5FcastTxt As New FlashUserValue With {.Left = 462, .Top = 21, .Height = 25, .Width = 75, .Name = "Week5", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Text = "$0.00", .Enabled = False, .Visible = False, .OpenValue = AllowAllValues}
        Dim FCastTotal As New CurrencyBox With {.Enabled = False, .Left = 543, .Top = 21, .Height = 25, .Width = 75, .Name = "FcastTtl", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right}
        Dim FcastPerc As New TextBox With {.Enabled = False, .Left = 625, .Top = 21, .Height = 25, .Width = 75, .Name = "FcastPct", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right}
        Dim BudgetTxt As New CurrencyBox With {.Enabled = False, .Left = 705, .Top = 21, .Height = 25, .Width = 75, .Name = "BudgetField", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right}
        Dim BudgetPerc As New TextBox With {.Enabled = False, .Left = 787, .Top = 21, .Height = 25, .Width = 75, .Name = "BudgetPct", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right}
        Dim FcastVarTxt As New CurrencyBox With {.Enabled = False, .Left = 867, .Top = 21, .Height = 25, .Width = 75, .AllowCredit = True, .Name = "VarianceField", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right}


        '#  Add objects to group, adding custom properties, as needed
        Controls.Add(TypeLabel)
        If IsRevenueBlock = True Then               '#  Define field to accepts credits, if applicable
            RunRateTxt.Debit = False
            Week1FcastTxt.Debit = False
            Week2FcastTxt.Debit = False
            Week3FcastTxt.Debit = False
            Week4FcastTxt.Debit = False
            Week5FcastTxt.Debit = False
            FCastTotal.Debit = False
            BudgetTxt.Debit = False
            Week1FcastTxt.AllowCredit = True
            Week2FcastTxt.AllowCredit = True
            Week3FcastTxt.AllowCredit = True
            Week4FcastTxt.AllowCredit = True
            Week5FcastTxt.AllowCredit = True
            FCastTotal.AllowCredit = True
            BudgetTxt.AllowCredit = True
        End If
        Controls.Add(RunRateTxt)
        If AvailableWeekStart < 6 Then RunRateTxt.Enabled = True
        Controls.Add(Week1FcastTxt)
        If AvailableWeekStart = 1 Then Week1FcastTxt.Enabled = True
        Controls.Add(Week2FcastTxt)
        If AvailableWeekStart <= 2 Then Week2FcastTxt.Enabled = True
        Controls.Add(Week3FcastTxt)
        If AvailableWeekStart <= 3 Then Week3FcastTxt.Enabled = True
        Controls.Add(Week4FcastTxt)
        If AvailableWeekStart <= 4 Then Week4FcastTxt.Enabled = True
        Controls.Add(Week5FcastTxt)
        If ShowFifthWeek = True Then
            Week5FcastTxt.Visible = True
            If AvailableWeekStart <= 5 Then Week5FcastTxt.Enabled = True
        End If
        Controls.Add(FCastTotal)
        If IsRevenueBlock = False Then Controls.Add(FcastPerc)
        Controls.Add(BudgetTxt)
        If IsRevenueBlock = False Then Controls.Add(BudgetPerc)
        Controls.Add(FcastVarTxt)

        AddHandler RunRateTxt.Enter, AddressOf StoreValue
        AddHandler Week1FcastTxt.Enter, AddressOf StoreValue
        AddHandler Week2FcastTxt.Enter, AddressOf StoreValue
        AddHandler Week3FcastTxt.Enter, AddressOf StoreValue
        AddHandler Week4FcastTxt.Enter, AddressOf StoreValue
        AddHandler RunRateTxt.Leave, AddressOf LeaveField
        AddHandler Week1FcastTxt.Leave, AddressOf LeaveField
        AddHandler Week2FcastTxt.Leave, AddressOf LeaveField
        AddHandler Week3FcastTxt.Leave, AddressOf LeaveField
        AddHandler Week4FcastTxt.Leave, AddressOf LeaveField
        If ShowFifthWeek = True Then
            AddHandler Week5FcastTxt.Enter, AddressOf StoreValue
            AddHandler Week5FcastTxt.Leave, AddressOf LeaveField
        End If

    End Sub

    Friend Sub ClearUserFields()
        Controls("Week1").Text = "$0.00"
        Controls("Week2").Text = "$0.00"
        Controls("Week3").Text = "$0.00"
        Controls("Week4").Text = "$0.00"
        Controls("Week5").Text = "$0.00"
    End Sub

    Private Sub StoreValue(sender As Object, e As EventArgs)
        Dim field As CurrencyBox = sender
        If sender.name = "DRR" Then Exit Sub
        OldValue = FormatNumber(field.Text, 2)
    End Sub

    Private Sub LeaveField(sender As Object, e As EventArgs)
        Dim field As CurrencyBox = sender, newval As Double = FormatNumber(field.Text, 2)
        If newval <> OldValue And sender.name <> "DRR" Then
            Dim pan As Panel = Parent
            Dim fcast As WeeklyForecast = pan.Parent
            fcast.ChangesMade = True
            fcast.SaveChanges = False
        End If
        Recalculate()
    End Sub

    Friend Sub Recalculate()

        '#  Total all weeks
        Dim segmenttotal As Double = 0, budgettotal As Double = FormatNumber(Controls("BudgetField").Text, 2), variance As Double
        segmenttotal = segmenttotal + FormatNumber(Controls("Week1").Text, 2)
        segmenttotal = segmenttotal + FormatNumber(Controls("Week2").Text, 2)
        segmenttotal = segmenttotal + FormatNumber(Controls("Week3").Text, 2)
        segmenttotal = segmenttotal + FormatNumber(Controls("Week4").Text, 2)
        If ShowFifthWeek = True Then segmenttotal = segmenttotal + FormatNumber(Controls("Week5").Text, 2)
        Controls("FcastTtl").Text = FormatCurrency(segmenttotal, 0)

        '#  Recalculate variance
        variance = segmenttotal - budgettotal
        Controls("VarianceField").Text = FormatCurrency(variance, 0)

        '#  Identify and recalculate Subtotal Blocks
        If IsSubtotal = True Then SubTotalRecalc(GroupName)
        If SubTotalRef <> "" Then SubTotalRecalc(SubTotalRef)

        '#  Refresh percentages
        WeeklyForecast.RefreshPercentages()
    End Sub

    Private Sub SubTotalRecalc(SubTotalName)
        Dim subtotalfg As ForecastGroup = Parent.Controls(SubTotalName), fg As ForecastGroup, ctrl As Control, field(8) As Double
        For Each ctrl In Parent.Controls
            If TypeOf (ctrl) Is ForecastGroup And ctrl.Name <> SubTotalName Then
                fg = ctrl
                If fg.Controls("Week1").Text <> "" Then field(0) = field(0) + FormatNumber(fg.Controls("Week1").Text, 2)
                If fg.Controls("Week2").Text <> "" Then field(1) = field(1) + FormatNumber(fg.Controls("Week2").Text, 2)
                If fg.Controls("Week3").Text <> "" Then field(2) = field(2) + FormatNumber(fg.Controls("Week3").Text, 2)
                If fg.Controls("Week4").Text <> "" Then field(3) = field(3) + FormatNumber(fg.Controls("Week4").Text, 2)
                If ShowFifthWeek = True And fg.Controls("Week5").Text <> "" Then field(4) = field(4) + FormatNumber(fg.Controls("Week5").Text, 2)
                If fg.Controls("DRR").Text <> "" Then field(5) = field(5) + FormatNumber(fg.Controls("DRR").Text, 2)
                If fg.Controls("FcastTtl").Text <> "" Then field(6) = field(6) + FormatNumber(fg.Controls("FcastTtl").Text, 2)
                If fg.Controls("VarianceField").Text <> "" Then field(7) = field(7) + FormatNumber(fg.Controls("VarianceField").Text, 2)
            End If
        Next
        subtotalfg.Controls("Week1").Text = FormatCurrency(field(0), 0)
        subtotalfg.Controls("Week2").Text = FormatCurrency(field(1), 0)
        subtotalfg.Controls("Week3").Text = FormatCurrency(field(2), 0)
        subtotalfg.Controls("Week4").Text = FormatCurrency(field(3), 0)
        If ShowFifthWeek = True Then subtotalfg.Controls("Week5").Text = FormatCurrency(field(4), 0)
        subtotalfg.Controls("DRR").Text = FormatCurrency(field(5), 0)
        subtotalfg.Controls("FcastTtl").Text = FormatCurrency(field(6), 0)
        subtotalfg.Controls("VarianceField").Text = FormatCurrency(field(7), 0)
    End Sub

    Friend Sub DRR()
        Dim drrperiod As Byte = WeeklyForecast.Period
        If WeeklyForecast.StartWeek = 1 Then drrperiod -= 1
        If drrperiod = 0 Then Exit Sub

        '#  Fetch saved flashes and weekly operating days for the period for the forecast group's category
        Dim wk As Byte, rr As Double, unum As Long = 99999, opdays As Byte, lastflashedweek As Byte
        Dim dr1() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & WeeklyForecast.FiscalYear & "' and MSPeriod = '" & drrperiod & "' and Unit = '" & WeeklyForecast.UnitNumber & "' and GL_Category = '" & GroupName & "'")
        lastflashedweek = dr1.Count
        If lastflashedweek = 0 Then Exit Sub

        '# Test if operating days are present for the unit - if not, use master unit
        Dim opdtest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & WeeklyForecast.UnitNumber & "' and FY = '" & WeeklyForecast.FiscalYear & "' and MSP  = '" & drrperiod & "'")
        If opdtest.Count > 0 Then unum = WeeklyForecast.UnitNumber

        For wk = 1 To lastflashedweek
            Dim dr() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & WeeklyForecast.FiscalYear & "' and MSPeriod = '" & drrperiod & "' and Week = '" & wk & "' and Unit = '" & WeeklyForecast.UnitNumber & "' and GL_Category = '" & GroupName & "'")
            If dr.Count > 0 Then
                rr = rr + FormatNumber(dr(0)("FlashValue"), 2)
                Dim opd() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & unum & "' and FY = '" & WeeklyForecast.FiscalYear & "' and MSP  = '" & drrperiod & "' and Week = '" & wk & "'")
                Dim ct As Byte
                For ct = 5 To 9
                    If opd(0)(ct) = True Then opdays += 1
                Next
            End If
        Next
        '#  Derive average

        Dim dailyrr As Double = rr / opdays

        If IsNumeric(dailyrr) = False Or rr = 0 Then dailyrr = 0
        '#  Populate field with average
        Controls("DRR").Text = FormatCurrency(dailyrr, 0)

    End Sub

    Friend Sub ApplyRunRate()
        Dim drrval As Double = FormatNumber(Controls("DRR").Text, 2)
        If drrval = 0 Then Exit Sub
        Dim wkdayct As Byte, ct As Byte, wks As Byte = 4
        If ShowFifthWeek = True Then wks = 5
        For ct = 1 To wks
            wkdayct = FormatNumber(WeeklyForecast.Controls("lblWeek" & ct).Tag, 0)
            If Controls("Week" & ct).Enabled = True Then Controls("Week" & ct).Text = FormatCurrency((drrval * wkdayct), 0)
        Next
        Recalculate()

    End Sub
End Class

