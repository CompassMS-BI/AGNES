Public Class WeeklyForecast
    Public Property forecasttype As String
    Private Property unm As String
    Public Property UserName As String
        Get
            Return unm
        End Get
        Set(value As String)
            unm = value
            tsslUser.Text = "Current User: " & unm
        End Set
    End Property
    Public Property UserLevel As String
    Public Property UserGroupAccess As String
    Public Property UnitNumber As Long
    Private Property FY As Long
    Public Property FiscalYear As Long
        Get
            Return FY
        End Get
        Set(value As Long)
            FY = value
            Me.tsslFY.Text = "Fiscal Year: " & value
        End Set
    End Property
    Private Property MSP As Byte
    Public Property Period As Byte
        Get
            Return MSP
        End Get
        Set(value As Byte)
            MSP = value
            tsmiEdit.Enabled = True
            tsslPeriod.Text = "Period: " & value
            tsslPeriod.Visible = True
            tsslInformation.Text = ""
            '# Create forecast groups, based on what type of unit/module was selected
            GetPeriodOpDays()
            GetAvailableWeeks()
            GetWeekOpDays()
            DestroyGroups()
            CreateGroups()
            EnableAssociateMgmt()
            FetchBudget()
            FetchDRR()
            tsslSaveStatus.Visible = False
            ChangesMade = False
            SaveChanges = True
            '#      ADD ROUTINE TO FETCH PREVIOUS INFORMATION
        End Set
    End Property
    Private Property Week As Byte
    Private W5 As Boolean
    Friend Property Week5Present As Boolean
        Get
            Return W5
        End Get
        Set(value As Boolean)
            W5 = value
            lblWeek5.Visible = value
            btnAshrt5.Visible = value
            btnAshrt5.Enabled = value
        End Set
    End Property
    Friend Property StartWeek As Byte
    Private pod As Byte
    Friend Property PeriodOpDays As Byte
        Get
            Return pod
        End Get
        Set(value As Byte)
            pod = value
            tsslPeriodDays.Text = "Period Op Days: " & PeriodOpDays
        End Set
    End Property
    Private Property NumberOfWeeks As Byte
    Public Property CalledFromFlash As Boolean
    Private saved As Boolean
    Friend Property SaveChanges As Boolean
        Get
            Return saved
        End Get
        Set(value As Boolean)
            saved = value
            If saved = True Then
                tsslSaveStatus.Text = "Saved"
            Else
                tsslSaveStatus.Text = "Not Saved"
            End If
            tsslSaveStatus.Visible = True
        End Set
    End Property
    Private changes As Boolean
    Friend Property ChangesMade As Boolean
        Get
            Return changes
        End Get
        Set(value As Boolean)
            changes = value
            SaveChanges = False
        End Set
    End Property
    Private ynchoice As Boolean
    Friend RevenueBudget As Double
    Private MoveForm As Boolean
    Private MoveForm_MousePosition As Point

#Region "Initialize Forecast"
    Private Sub LoadForecast(sender As Object, e As EventArgs) Handles Me.Load
        '# Fill all tables
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        DataSets.OpDaysAdapt.Fill(DataSets.OpDaysTable)
        DataSets.FlashAdapt.Fill(DataSets.FlashTable)
        DataSets.BudgetAdapt.Fill(DataSets.BudgetTable)
        DataSets.ForecastAdapt.Fill(DataSets.ForecastTable)
    End Sub
#End Region

#Region "Toolstrip Controls"

    Private Sub SaveForecast(sender As Object, e As EventArgs) Handles tsmiSave.Click
        SaveData()
    End Sub

    Private Sub PrintForecast(sender As Object, e As EventArgs) Handles tsmiPrint.Click
        PrintRoutine
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
        If CalledFromFlash = True Then
            WeeklyFlash.Show()
        Else
            Portal.Show()
        End If
    End Sub

    Private Sub ClearUserFields(sender As Object, e As EventArgs) Handles tsmiClear.Click
        Dim ctrl As Control
        For Each ctrl In Controls
            If TypeOf (ctrl) Is ForecastGroup Then
                Dim fg As ForecastGroup = ctrl
                fg.ClearUserFields()
            End If
        Next
        FetchDRR()
    End Sub

    Private Sub RefreshRunRate(sender As Object, e As EventArgs) Handles tsmiRefreshDRR.Click
        FetchDRR()
    End Sub

    Private Sub ApplyRunRate(sender As Object, e As EventArgs) Handles tsmiApplyDRR.Click
        Dim ctrl As Control
        For Each ctrl In panForecast.Controls
            If TypeOf (ctrl) Is ForecastGroup Then
                Dim fg As ForecastGroup = ctrl
                If fg.IsSubtotal = False Then fg.ApplyRunRate
            End If
        Next
    End Sub

    Private Sub ManageOpDays(sender As Object, e As EventArgs) Handles tsmiOpDays.Click
        With OperatingDaysMgr
            .FY = FY
            .MSP = MSP
            .UnitNum = UnitNumber
            .CalledFromFlash = False
            .Activeweek = Week
            .NumberofWeeks = NumberOfWeeks
            .ShowDialog()
        End With
        RefreshView()
    End Sub

    Private Sub tsmiCalc_Click(sender As Object, e As EventArgs) Handles tsmiCalc.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles mstForecast.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles mstForecast.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles mstForecast.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Functions"
    Private Sub EnableAssociateMgmt()
        btnAshrt1.Enabled = True
        btnAshrt2.Enabled = True
        btnAshrt3.Enabled = True
        btnAshrt4.Enabled = True
        If Week5Present = True Then btnAshrt5.Enabled = True
    End Sub

    Private Sub DestroyGroups()
        Dim ctrl As Control, fglist(10) As String, ct As Byte = 0, ct1 As Byte, fg As ForecastGroup
        For Each ctrl In panForecast.Controls
            If TypeOf (ctrl) Is ForecastGroup Then
                fg = ctrl
                fglist(ct) = fg.Name
                ct += 1
            End If
        Next
        If ct > 0 Then
            For ct1 = 0 To ct - 1
                fg = panForecast.Controls(fglist(ct1))
                fg.Dispose()
            Next
        End If
    End Sub

    Private Sub CreateGroups()
        Select Case forecasttype
            Case "Cafes"
                Dim salesgroup As New ForecastGroup With {.Left = 9, .Top = 2, .ShowFifthWeek = Week5Present, .AvailableWeekStart = StartWeek, .IsRevenueBlock = True, .AllowAllValues = False, .Name = "Sales", .GroupName = "Sales", .SubTotalRef = "Total", .Enabled = True}
                Dim cogsgroup As New ForecastGroup With {.Left = 9, .Top = 61, .ShowFifthWeek = Week5Present, .AvailableWeekStart = StartWeek, .Name = "COGS", .GroupName = "COGS", .SubTotalRef = "Total"}
                Dim laborgroup As New ForecastGroup With {.Left = 9, .Top = 120, .ShowFifthWeek = Week5Present, .AvailableWeekStart = StartWeek, .Name = "Labor", .GroupName = "Labor", .SubTotalRef = "Total"}
                Dim opexgroup As New ForecastGroup With {.Left = 9, .Top = 179, .ShowFifthWeek = Week5Present, .AvailableWeekStart = StartWeek, .Name = "OPEX", .GroupName = "OPEX", .SubTotalRef = "Total"}
                Dim subsidygroup As New ForecastGroup With {.Left = 9, .Top = 238, .ShowFifthWeek = Week5Present, .AvailableWeekStart = StartWeek, .IsSubtotal = True, .Name = "Total", .GroupName = "Subsidy", .Enabled = False}
                With panForecast.Controls
                    .Add(salesgroup)
                    .Add(cogsgroup)
                    .Add(laborgroup)
                    .Add(opexgroup)
                    .Add(subsidygroup)
                End With
                FetchSavedForecast()
        End Select
    End Sub

    Friend Sub RefreshView()
        GetPeriodOpDays()
        GetAvailableWeeks()
        GetWeekOpDays()
        FetchBudget()
        FetchDRR()
    End Sub

    Private Sub GetPeriodOpDays()
        Week5Present = False
        Dim CurrDt As Date = FormatDateTime(Now(), DateFormat.ShortDate)
        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & CurrDt & "'")
        FiscalYear = DateDR(0)("MS_FY")
        '#  Check for presence of stored operating days.  If present, fetch.  If none are present, use template unit #99999
        DataSets.OpDaysAdapt.Fill(DataSets.OpDaysTable)
        Dim tempUnitNumber As Long, drTest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & UnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & Period & "'")
        If drTest.Count = 0 Then
            tempUnitNumber = 99999
        Else
            tempUnitNumber = UnitNumber
        End If
        Dim c As Byte, pod As Byte = 0, dr() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & tempUnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & Period & "'")
        For ct = 0 To dr.Count - 1
            For c = 5 To 9
                If dr(ct)(c) = True Then pod += 1
            Next
        Next
        PeriodOpDays = pod
        NumberOfWeeks = dr.Count
        If NumberOfWeeks = 5 Then
            Week5Present = True
            lblWeek5.Visible = True
        End If
        tsslPeriodDays.Text = "Period Op Days: " & PeriodOpDays
        If pod > 0 Then
            tsslPeriodDays.Visible = True
        Else
            tsslPeriodDays.Visible = False
        End If
    End Sub

    Private Sub GetWeekOpDays()
        Dim daycount As Byte, ct1 As Byte, tempUnitNum As Long
        For ct = 1 To NumberOfWeeks
            daycount = 0
            Dim drtest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & UnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & Period & "' and Week = '" & ct & "'")
            If drtest.Count = 0 Then
                tempUnitNum = 99999
            Else
                tempUnitNum = UnitNumber
            End If

            Dim dr() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & tempUnitNum & "' and FY = '" & FiscalYear & "' and MSP = '" & Period & "' and Week = '" & ct & "'")
            For ct1 = 5 To 9
                If dr(0)(ct1) = True Then daycount += 1
            Next
            With Controls("lblWeek" & ct)
                .Text = "Week " & ct & vbCr & daycount & " days"
                .Tag = daycount
            End With
        Next
    End Sub

    Private Sub GetAvailableWeeks()
        '# Get current week to determine which weeks are available
        Dim CurrDt As Date = FormatDateTime(Now(), DateFormat.ShortDate) : CurrDt = CurrDt.Date.AddDays(6)
        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & CurrDt & "'")
            Dim testMSP = DateDR(0)("MS_Period")
        Select Case testMSP
            Case < MSP
                StartWeek = 1
            Case MSP
                StartWeek = DateDR(0)("Week")
            Case > MSP
                StartWeek = 6
        End Select
    End Sub

    Private Sub PrintRoutine()
        With PrintFlash
            .PrinterSettings.DefaultPageSettings.Landscape = True
            .PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 100)
            .PrintAction = Printing.PrintAction.PrintToPreview
            .Print()
        End With
    End Sub

    Private Sub SaveData()
        '#  Check if a current save is present
        Dim SaveOkay As Boolean
        Dim dr() As DataRow = DataSets.ForecastTable.Select("UnitNum = '" & UnitNumber & "' and FY = '" & FY & "' and MSP = '" & Period & "'")
        If dr.Count > 0 Then
            '#  Overwrite existing
            Try
                Dim ctrl As Control
                For Each ctrl In panForecast.Controls
                    If TypeOf (ctrl) Is ForecastGroup Then
                        Dim fg As ForecastGroup = ctrl
                        If fg.IsSubtotal = False Then
                            Dim wks As Byte = 4
                            If fg.ShowFifthWeek = True Then wks = 5
                            Dim ct As Byte
                            For ct = 1 To wks
                                Dim upDR() As DataRow = DataSets.ForecastTable.Select("UnitNum = '" & UnitNumber & "' and FY = '" & FY & "' and MSP = '" & Period & "' and Week = '" & ct & "' and Category = '" & fg.Name & "'")
                                upDR(0)("Value") = FormatNumber(fg.Controls("Week" & ct).Text, 2)
                            Next
                        End If
                    End If
                Next
                SaveOkay = True
            Catch ex As Exception

            End Try

        Else
            '#  Save as new entry
            Try
                Dim ctrl As Control
                For Each ctrl In panForecast.Controls
                    If TypeOf (ctrl) Is ForecastGroup Then
                        Dim fg As ForecastGroup = ctrl
                        If fg.IsSubtotal = False Then
                            Dim wks As Byte = 4
                            If fg.ShowFifthWeek = True Then wks = 5
                            Dim ct As Byte
                            For ct = 1 To wks
                                Dim InsertDR As DataRow = DataSets.ForecastTable.NewRow()
                                InsertDR("UnitNum") = UnitNumber
                                InsertDR("FY") = FY
                                InsertDR("MSP") = Period
                                InsertDR("Week") = ct
                                InsertDR("Category") = fg.Name
                                InsertDR("Value") = FormatNumber(fg.Controls("Week" & ct).Text, 2)
                                DataSets.ForecastTable.Rows.Add(InsertDR)
                            Next
                        End If
                    End If
                Next
                SaveOkay = True
            Catch ex As Exception
            End Try
        End If
        DataSets.ForecastAdapt.Update(DataSets.ForecastTable)
        DataSets.ForecastAdapt.Fill(DataSets.ForecastTable)
        If SaveOkay = True Then
            Dim amsg As New AgnesMsgBox("Your forecast has been saved.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            SaveChanges = True
        Else
            Dim amsg As New AgnesMsgBox("Your flash was not saved due to error number " & Err.Number & ".  Try again and, if this error continues, please notify the Business Intelligence department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            SaveChanges = False
        End If
    End Sub

    Private Sub FetchBudget()
        '#  Determine budget cycle to retrieve, based on calendar month, converted to MS period equivalent
        Dim cycle As Byte
        Select Case Month(Today)
            Case < 4
                cycle = 3
            Case < 7
                cycle = 4
            Case < 10
                cycle = 1
            Case Else
                cycle = 2
        End Select

        '# Get sales total first and store and simultaneously test for presence of data for expected cycle
        Dim st() As DataRow = DataSets.BudgetTable.Select("MSFY = '" & FiscalYear & "' and MSP = '" & Period & "' and Cycle = '" & cycle & "' and Unit = '" & UnitNumber & "' and Category = 'Sales'")

        If st.Count = 0 Then
            '#  No data for expected cycle found
            Dim amsg As New AgnesMsgBox("Unable to locate expected budget information, possibly due to a missing forecast.  Please contact Finance or the BI department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            Exit Sub
        End If

        RevenueBudget = -FormatNumber(st(0)("Budget"), 2)

        Dim fg As ForecastGroup, ctrl As Control, periodbudget As Double
        For Each ctrl In panForecast.Controls
            If TypeOf ctrl Is ForecastGroup Then
                fg = ctrl
                periodbudget = 0
                Dim dr() As DataRow = DataSets.BudgetTable.Select("MSFY = '" & FiscalYear & "' and MSP = '" & Period & "' and Cycle = '" & cycle & "' and Unit = '" & UnitNumber & "' and Category = '" & fg.GroupName & "'")
                For ct = 0 To dr.Count - 1
                    periodbudget = periodbudget + CType(dr(ct)("Budget"), Double)
                Next
                fg.Controls("BudgetField").Text = FormatCurrency(periodbudget, 0)
                If fg.Name <> "Sales" Then fg.Controls("BudgetPct").Text = FormatPercent((periodbudget / RevenueBudget), 1)
                If fg.Name <> "Total" Then fg.Recalculate()
            Else End If

        Next
    End Sub

    Private Sub FetchSavedForecast()
        Dim dr() As DataRow = DataSets.ForecastTable.Select("UnitNum = '" & UnitNumber & "' and FY = '" & FY & "' and MSP = '" & Period & "'")
        If dr.Count = 0 Then Exit Sub
        Dim ct As Byte
        For ct = 0 To dr.Count - 1
            Dim nm As String = Trim(dr(ct)("Category"))
            Dim fg As ForecastGroup = panForecast.Controls(nm)
            fg.Controls("Week" & FormatNumber(dr(ct)("Week"), 0)).Text = FormatCurrency(dr(ct)("Value"), 0)
            fg.Recalculate()
        Next
    End Sub

    Private Sub FetchDRR()
        Dim ctrl As Control
        For Each ctrl In panForecast.Controls
            If TypeOf (ctrl) Is ForecastGroup Then
                Dim fg As ForecastGroup = ctrl
                If fg.IsSubtotal = False Then
                    fg.DRR()
                    fg.Recalculate()
                End If
            End If
        Next

    End Sub

    Friend Sub RefreshPercentages()
        Try
            '#  Get sales total first and store
            Dim salesval As Double, fg As ForecastGroup, ctrl As Control, fieldval As Double
            fg = panForecast.Controls("Sales")
            salesval = -FormatNumber(fg.Controls("FcastTtl").Text, 2)
            '#  Cycle through everything else, calculate, and populate
            For Each ctrl In panForecast.Controls
                If TypeOf (ctrl) Is ForecastGroup Then
                    fg = ctrl
                    If fg.Name <> "Sales" And fg.IsRevenueBlock = False And fg.ExcludePercentofSales = False Then
                        fg.Controls("FcastPct").Text = ""
                        fieldval = FormatNumber(fg.Controls("FcastTtl").Text, 2)
                        If fieldval <> 0 And salesval <> 0 Then fg.Controls("FcastPct").Text = FormatPercent(fieldval / salesval, 1)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadAssociateShortForm(sender As Object, e As EventArgs) Handles btnAshrt1.Click, btnAshrt2.Click, btnAshrt3.Click, btnAshrt4.Click, btnAshrt5.Click
        Dim s As Button = sender
        With AssociateShorts
            .MSP = MSP
            .Week = FormatNumber(s.Tag, 0)
            .Unit = UnitNumber
            .ShowDialog()
        End With
    End Sub
#End Region

End Class