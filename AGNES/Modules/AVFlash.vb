Public Class AVFlash
    Friend SaveChanges As Boolean
    Private SavedFlash As Boolean
    Friend ChangesMade As Boolean
    Friend AdminDisplayAllWeeks As Boolean
    Private MSP As Byte
    Private Week As Byte
    Private MaxPeriod As Byte
    Private maxweek As Byte
    Private ynchoice As Boolean
    Private ct As Integer
    Friend Property UserName As String
    Private NumberofWeeks As Byte
    Private FY As Integer
    Friend systemchange As Boolean
    Private AVUnit As Long = 30954

#Region "Initialize Flash"

    Private Sub LoadModule(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.BudgetAdapt.Fill(DataSets.BudgetTable)
        DataSets.FlashAdapt.Fill(DataSets.FlashTable)
        DataSets.DateAdapt.Fill(DataSets.DateTable)

        '#  Construct Flash groups
        ConstructFlashFields()

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
        tsslUnit.Text = "Unit: " & AVUnit

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

    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        If ChangesMade = True Then FlashSave()
    End Sub

    Private Sub CloseModule(sender As Object, e As EventArgs) Handles tsmiClose.Click
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

    Private Sub ClearFlashValues(sender As Object, e As EventArgs) Handles tsmiClearFlash.Click
        ClearActive(1)
        CalcFlashTotal()
        RecalcFields()
    End Sub


    Private Sub PeriodChosen(sender As Object, e As EventArgs) Handles tsmiP1.Click, tsmiP2.Click, tsmiP3.Click, tsmiP4.Click, tsmiP5.Click,
        tsmiP6.Click, tsmiP7.Click, tsmiP8.Click, tsmiP9.Click, tsmiP10.Click, tsmiP11.Click, tsmiP12.Click
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
        tsmiAVField.Enabled = False
        tsmiRedmond.Enabled = False
        'tsmiPTD.Enabled = True
    End Sub

    Private Sub WeekChosen(sender As Object, e As EventArgs) Handles tsmiW1.Click, tsmiW2.Click, tsmiW3.Click, tsmiW4.Click, tsmiW5.Click
        Dim wk As ToolStripDropDownItem = sender
        If wk.Enabled = False Then Exit Sub

        '/  Check for unsaved data
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change weeks?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If

        ChangesMade = False
        SaveChanges = True
        ClearActive(0)

        '/  Determine and assign week value
        Dim sndr As ToolStripMenuItem = sender
        Week = Mid(sndr.Name, 6, 1)
        tsslWeek.Text = "Week: " & Week
        tsslWeek.Visible = True
        tsmiAVField.Enabled = True
        tsmiRedmond.Enabled = True
        FetchFlash(Week)
        FetchBudget()
        CalcFlashTotal()
        RecalcFields()
        LockUnlock(True)
    End Sub

    Private Sub UnitChoice(sender As Object, e As EventArgs) Handles tsmi13331.Click, tsmi13332.Click, tsmi13333.Click, tsmi13335.Click,
            tsmi13797.Click, tsmi17396.Click, tsmi22443.Click, tsmi23403.Click, tsmi28503.Click, tsmi28505.Click, tsmi30946.Click, tsmi30954.Click,
            tsmi32436.Click
        If ChangesMade = True Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change units?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            If ynchoice = False Then Exit Sub
        End If
        Dim sndr As ToolStripMenuItem = sender
        AVUnit = FormatNumber(Mid(sndr.Name, 5, Len(sndr.Name) - 4))
        tsslUnit.Text = "Unit: " & AVUnit
        tsslUnit.Visible = True
        If MSP > 0 And Week > 0 Then
            ClearActive(0)
            FetchFlash(Week)
            FetchBudget()
            CalcFlashTotal()
            RecalcFields()
        End If
    End Sub

#End Region

#Region "Functions"

    Private Sub ConstructFlashFields()
        '/  Create sales/sales tax group and label
        Dim SalesGroup As New FlashGroup With
    {.Left = 72, .Top = 60, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .AllowAllValues = True, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "SALES"}

        Dim SalesLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 60, .Width = 70, .Height = 112, .Text = "Sales", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "SALESLABEL"}
        Controls.Add(SalesLabel)
        Controls.Add(SalesGroup)

        '/  Create labor group and label
        Dim LaborGroup As New FlashGroup With
    {.Left = 72, .Top = 175, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .AllowAllValues = True, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "LABOR"}

        Dim LaborLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 175, .Width = 70, .Height = 112, .Text = "Labor", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(LaborLabel)
        Controls.Add(LaborGroup)

        '/  Create OPEX group and label
        Dim OpexGroup As New FlashGroup With
    {.Left = 72, .Top = 290, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .AllowAllValues = True, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "OPEX"}

        Dim OpexLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 290, .Width = 70, .Height = 112, .Text = "OPEX", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(OpexLabel)
        Controls.Add(OpexGroup)

        '/  Create total group and label
        Dim TotalGroup As New FlashGroup With
    {.Left = 72, .Top = 405, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .ExcludeFromSubsidy = False, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "TOTAL", .Enabled = False}

        Dim TotalLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 405, .Width = 70, .Height = 112, .Text = "Total", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(TotalLabel)
        Controls.Add(TotalGroup)

        '/  Create fees group and label
        Dim FeesGroup As New FlashGroup With
    {.Left = 72, .Top = 520, .Width = 865, .Height = 112, .FlashIsStatic = False, .IsRevenueBlock = False, .AllowAllValues = True, .ExcludeFromSubsidy = True, .ExcludePercentofSales = True,
    .SubTotalRef = "", .IsSubtotal = False, .IncludeForecast = False, .Name = "FEES"}

        Dim FeesLabel As New Label With
            {.TextAlign = ContentAlignment.MiddleCenter, .Left = 1, .Top = 520, .Width = 70, .Height = 112, .Text = "Fees", .Font = New Drawing.Font("Segoe UI Emoji", 11, FontStyle.Regular), .Name = "COGSLABEL"}
        Controls.Add(FeesLabel)
        Controls.Add(FeesGroup)

    End Sub

    Private Sub ClearActive(t)
        Dim tfg As FlashGroup
        tfg = Controls("SALES")
        tfg.Clear(t)
        tfg = Controls("LABOR")
        tfg.Clear(t)
        tfg = Controls("OPEX")
        tfg.Clear(t)
        tfg = Controls("FEES")
        tfg.Clear(t)
    End Sub

    Private Sub FetchFlash(w)
        systemchange = True : SavedFlash = False : ChangesMade = False : tsslSaveStatus.Text = ""
        Dim tmpval As Double

        tmpval = FetchSingleFlashWeek(w, "Revenue")
        Controls("SALES").Controls("FlashField").Text = FormatCurrency(tmpval, 2)

        tmpval = FetchSingleFlashWeek(w, "Labor")
        Controls("LABOR").Controls("FlashField").Text = FormatCurrency(tmpval, 2)

        tmpval = FetchSingleFlashWeek(w, "OPEX")
        Controls("OPEX").Controls("FlashField").Text = FormatCurrency(tmpval, 2)

        tmpval = FetchSingleFlashWeek(w, "FEES")
        Controls("FEES").Controls("FlashField").Text = FormatCurrency(tmpval, 2)

        systemchange = False
    End Sub

    Private Function FetchSingleFlashWeek(wk, cat) As Double
        Dim dr() As DataRow, tempval As Double
        Try
            dr = DataSets.FlashTable.Select("FlashID = '" & FY & "-" & MSP & "-" & wk & "-" & AVUnit & "-0-" & cat & "'")
            tempval = FormatNumber(dr(0)("FlashValue"), 2)
            ChangesMade = False
            SavedFlash = True
            tsslSaveStatus.Text = "Saved Flash"
        Catch ex As Exception
            tempval = 0
            ChangesMade = False
            SavedFlash = False
        End Try
        Return tempval
    End Function

    Private Sub FetchBudget()
        systemchange = True
        Dim cycle As Byte = GetCycle()
        Dim dr() As DataRow
        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & AVUnit & "-Sales-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("SALES").Controls("BudgetField").Text = FormatCurrency((dr(0)("Budget") / NumberofWeeks), 2)
        Catch ex As Exception
            Controls("SALES").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & AVUnit & "-OPEX-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("OPEX").Controls("BudgetField").Text = FormatCurrency((dr(0)("Budget") / NumberofWeeks), 2)
        Catch ex As Exception
            Controls("OPEX").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & AVUnit & "-Labor-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("LABOR").Controls("BudgetField").Text = FormatCurrency((dr(0)("Budget") / NumberofWeeks), 2)
        Catch ex As Exception
            Controls("LABOR").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & AVUnit & "-Fees-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("FEES").Controls("BudgetField").Text = FormatCurrency((dr(0)("Budget") / NumberofWeeks), 2)
        Catch ex As Exception
            Controls("FEES").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try

        Try
            dr = DataSets.BudgetTable.Select("BudgetKey = '" & AVUnit & "-Subsidy-" & FY & "-" & MSP & "' and Cycle = '" & cycle & "'")
            Controls("TOTAL").Controls("BudgetField").Text = FormatCurrency((dr(0)("Budget") / NumberofWeeks), 2)
        Catch ex As Exception
            Controls("TOTAL").Controls("BudgetField").Text = FormatCurrency(0, 2)
        End Try
        systemchange = False
    End Sub
    Private Function GetCycle()
        Return 1
        'TODO: 7/2018: Fix cycle capture on AV Flash
        'Dim c As Integer
        'For c = 4 To 1 Step -1
        '    Dim dr() As DataRow = DataSets.BudgetTable.Select("Unit = '" & AVUnit & "' and Cycle = '" & c & "'")
        '    If dr.Count > 0 Then Exit For
        'Next
        'Return c
    End Function

    Public Sub CalcFlashTotal()
        '#  Recalculate flash total field
        Dim flash As Double
        flash = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)
        flash = flash + FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
        flash = flash + FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
        Controls("TOTAL").Controls("FlashField").Text = FormatCurrency(flash, 2)
    End Sub

    Public Sub RecalcFields()
        Dim budg As Double, flash As Double, vari As Double
        '#  Recalculate variance fields
        budg = FormatNumber(Controls("SALES").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("SALES").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("LABOR").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("LABOR").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("OPEX").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("OPEX").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("FEES").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("FEES").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("FEES").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
        budg = FormatNumber(Controls("TOTAL").Controls("BudgetField").Text, 2) : flash = FormatNumber(Controls("TOTAL").Controls("FlashField").Text, 2) : vari = budg - flash : Controls("TOTAL").Controls("FlashVarianceField").Text = FormatCurrency(vari, 2)
    End Sub

    Private Sub LockUnlock(lu)
        Controls("SALES").Enabled = lu
        Controls("LABOR").Enabled = lu
        Controls("OPEX").Enabled = lu
        Controls("FEES").Enabled = lu
    End Sub

    Private Sub FlashSave()
        Dim baseflashkey As String = FY & "-" & MSP & "-" & Week & "-" & AVUnit & "-0-"
        If SavedFlash = True Then
            Try
                Dim dr() As DataRow
                dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "Revenue'")
                dr(0)("FlashValue") = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)    '# Overwrite flash value for revenue

                dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "Labor'")
                dr(0)("FlashValue") = FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)    '# Overwrite flash value for labor

                dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "OPEX'")
                dr(0)("FlashValue") = FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)     '# Overwrite flash value for opex

                dr = DataSets.FlashTable.Select("FlashID = '" & baseflashkey & "FEES'")
                dr(0)("FlashValue") = FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)     '# Overwrite flash value for fees

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
                Dim dr1 As DataRow = DataSets.FlashTable.NewRow()
                dr1("FlashID") = baseflashkey & "Revenue"
                dr1("FiscalYear") = FY
                dr1("MSPeriod") = MSP
                dr1("Week") = Week
                dr1("Unit") = AVUnit
                dr1("Status") = "Flash"
                dr1("GL") = 0
                dr1("GL_Category") = "Revenue"
                dr1("FlashValue") = FormatNumber(Controls("SALES").Controls("FlashField").Text, 2)
                dr1("FlashNotes") = ""
                dr1("OpDaysWeek") = 1
                dr1("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr1)

                Dim dr2 As DataRow = DataSets.FlashTable.NewRow()
                dr2("FlashID") = baseflashkey & "Labor"
                dr2("FiscalYear") = FY
                dr2("MSPeriod") = MSP
                dr2("Week") = Week
                dr2("Unit") = AVUnit
                dr2("Status") = "Flash"
                dr2("GL") = 0
                dr2("GL_Category") = "Labor"
                dr2("FlashValue") = FormatNumber(Controls("LABOR").Controls("FlashField").Text, 2)
                dr2("FlashNotes") = ""
                dr2("OpDaysWeek") = 1
                dr2("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr2)

                Dim dr3 As DataRow = DataSets.FlashTable.NewRow()
                dr3("FlashID") = baseflashkey & "OPEX"
                dr3("FiscalYear") = FY
                dr3("MSPeriod") = MSP
                dr3("Week") = Week
                dr3("Unit") = AVUnit
                dr3("Status") = "Flash"
                dr3("GL") = 0
                dr3("GL_Category") = "OPEX"
                dr3("FlashValue") = FormatNumber(Controls("OPEX").Controls("FlashField").Text, 2)
                dr3("FlashNotes") = ""
                dr3("OpDaysWeek") = 1
                dr3("OpDaysPeriod") = NumberofWeeks
                DataSets.FlashTable.Rows.Add(dr3)

                Dim dr4 As DataRow = DataSets.FlashTable.NewRow()
                dr4("FlashID") = baseflashkey & "FEES"
                dr4("FiscalYear") = FY
                dr4("MSPeriod") = MSP
                dr4("Week") = Week
                dr4("Unit") = AVUnit
                dr4("Status") = "Flash"
                dr4("GL") = 0
                dr4("GL_Category") = "FEES"
                dr4("FlashValue") = FormatNumber(Controls("FEES").Controls("FlashField").Text, 2)
                dr4("FlashNotes") = ""
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