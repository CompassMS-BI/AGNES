Public Class CurrentWeek
    Dim MSP As Byte, FY As Integer, wk As Byte

    Public Property Parent As WeeklyFlash
    Public Property FiscalYear As Integer
        Get
            Return FY
        End Get
        Set(value As Integer)
            Parent.tsslFY.Text = "FY: " & value
            FY = value
        End Set
    End Property
    Public Property MSPeriod As Byte
        Get
            Return MSP
        End Get
        Set(value As Byte)
            '# Update period OpDays and update parent information and labels
            GetPeriodOpDays(value)
            MSP = value
        End Set
    End Property
    Public Property PeriodOpDays As Byte
    Public Property NumberofWeeks As Byte
    Public Property Week As Byte
        Get
            Return wk
        End Get
        Set(value As Byte)
            If value > 0 Then WeekOpDays = GetWeekOpDays(value)
            wk = value
            Parent.tsslWeekDays.Text = "Week Op Days: " & WeekOpDays
            If WeekOpDays > 0 Then
                Parent.tsslWeekDays.Visible = True
            Else
                Parent.tsslWeekDays.Visible = False
            End If
        End Set
    End Property
    Public Property WeekOpDays As Byte
    Public Property BudgetCycle As Byte
    Public Property CurrDt As Date
    Public Property FlashLock As Boolean
    Public Property ChangesMade As Boolean
    Public Property SaveType As String
    Public Property Saved As Boolean
        Get
            Return Saved
        End Get
        Set(value As Boolean)
            If value = True Then
                Dim ctrl As Control
                For Each ctrl In Parent.Controls
                    If TypeOf ctrl Is FlashNotes Or TypeOf ctrl Is FlashUserValue Then
                        ctrl.Enabled = False
                        ctrl.BackColor = SystemColors.ControlLight
                    End If
                Next
            End If
        End Set
    End Property

    Public Sub Clear(ClearType)
        Select Case ClearType
            Case "AllFields"
                ClearActiveWeek("All")
                ClearLabels()
            Case "FlashFields"
                ClearActiveWeek("Flash")
            Case "BudgetFields"
                ClearActiveWeek("Budget")
            Case "ForecastFields"
                ClearActiveWeek("Forecast")
            Case "Labels"
                ClearLabels()
            Case "NoteFields"
                ClearActiveWeek("Notes")
        End Select
    End Sub

    Private Sub ClearActiveWeek(ClearType)
        Select Case ClearType

            Case "All"
                MSPeriod = 0
                Week = 0
                NumberofWeeks = 0
                PeriodOpDays = 0
                WeekOpDays = 0
                Dim tfg As FlashGroup
                For Each ctrl In WeeklyFlash.Controls
                    If TypeOf ctrl Is FlashGroup Then
                        tfg = ctrl
                        tfg.FlashValue = 0
                        tfg.Controls("FlashField").Text = ""
                        tfg.BudgetValue = 0
                        tfg.Controls("BudgetField").Text = ""
                        If Parent.HasForecast = True Then
                            tfg.ForecastValue = 0
                            tfg.Controls("ForecastField").Text = ""
                        End If
                        If tfg.FlashIsStatic = False Then tfg.Controls("Notes").Text = ""
                    End If
                Next
                ChangesMade = False
                SaveType = "New"
                Parent.tsslWeekDays.Visible = False
                Parent.tsslWeek.Visible = False
            Case "Flash"
                Dim tfg As FlashGroup
                For Each ctrl In WeeklyFlash.Controls
                    If TypeOf ctrl Is FlashGroup Then
                        tfg = ctrl
                        tfg.FlashValue = 0
                        tfg.Controls("FlashField").Text = ""
                        If tfg.FlashIsStatic = False Then tfg.Controls("Notes").Text = ""
                    End If
                Next
                ChangesMade = False
                If SaveType = "Draft" Then ChangesMade = True
            Case "Budget"
                Dim tfg As FlashGroup
                For Each ctrl In WeeklyFlash.Controls
                    If TypeOf ctrl Is FlashGroup Then
                        tfg = ctrl
                        tfg.FlashValue = 0
                        tfg.Controls("BudgetField").Text = ""
                        If tfg.FlashIsStatic = False Then tfg.Controls("Notes").Text = ""
                    End If
                Next
                ChangesMade = False
                If SaveType = "Draft" Then ChangesMade = True
            Case "Forecast"
                If Parent.HasForecast = True Then
                    Dim tfg As FlashGroup
                    For Each ctrl In WeeklyFlash.Controls
                        If TypeOf ctrl Is FlashGroup Then
                            tfg = ctrl
                            tfg.FlashValue = 0
                            tfg.Controls("ForecastField").Text = ""
                            If tfg.FlashIsStatic = False Then tfg.Controls("Notes").Text = ""
                        End If
                    Next
                    ChangesMade = False
                    If SaveType = "Draft" Then ChangesMade = True
                End If
            Case "Notes"
                Dim tfg As FlashGroup
                For Each ctrl In WeeklyFlash.Controls
                    If TypeOf ctrl Is FlashGroup Then
                        Try
                            tfg = ctrl
                            tfg.NoteValue = ""
                            tfg.StoredNoteValue = ""
                        Catch ex As Exception

                        End Try
                    End If
                Next
        End Select
    End Sub

    Private Sub ClearLabels()
        Dim placehold As Boolean = True
    End Sub

    Public Sub RestoreFromSaved()
        Dim tfg As FlashGroup
        For Each ctrl In WeeklyFlash.Controls
            If TypeOf ctrl Is FlashGroup Then
                tfg = ctrl
                If tfg.Name <> "SUBSIDY" Then
                    tfg.FlashValue = tfg.StoredFlashValue
                    tfg.Controls("FlashField").Text = FormatCurrency(tfg.FlashValue, 0)
                    tfg.StoredFlashValue = 0

                    With tfg
                        .NoteValue = .StoredNoteValue
                        .Controls("Notes").Text = .NoteValue
                        .StoredNoteValue = ""
                    End With
                End If
            End If
        Next
        '/// ADD HANDLE LATER FOR NON-DINING UNITS AND TOTAL SALES, ETC.

    End Sub

    Public Sub RefreshView()
        Dim totalrevenue(3) As Double, subsidyvalue(3) As Double, ctrl As Control, tfg As FlashGroup, subsidygroup As FlashGroup
        Try
            '#  Update Flash, Budget, and Forecast (if applicable) subsidy block and store total sales for percentage calculations
            For Each ctrl In WeeklyFlash.Controls
                If TypeOf ctrl Is FlashGroup Then
                    '   #  Is this a revenue block?
                    '       #   No  - Add to subsidy totals
                    '       #   Yes
                    '           #   Is there a Subtotal present? 
                    '           #   No - Use this as revenue and add to subsidy
                    '           #   Yes
                    '               #   Is *this* the subtotal?
                    '                   #   No -  Ignore this one
                    '                   #   Yes - Use this as revenue and add to subsidy
                    tfg = ctrl
                    If tfg.Name <> "SUBSIDY" Then
                        subsidygroup = WeeklyFlash.Controls("SUBSIDY")
                        If tfg.IsRevenueBlock Then
                            If WeeklyFlash.HasSubtotal = False Then
                                totalrevenue(0) = tfg.FlashValue
                                totalrevenue(1) = tfg.BudgetValue
                                totalrevenue(2) = tfg.ForecastValue
                                subsidyvalue(0) = subsidyvalue(0) + tfg.FlashValue
                                subsidyvalue(1) = subsidyvalue(1) + tfg.BudgetValue
                                If WeeklyFlash.HasForecast = True Then subsidyvalue(2) = subsidyvalue(2) + tfg.ForecastValue
                            Else
                                If tfg.IsSubtotal = True Then
                                    totalrevenue(0) = tfg.FlashValue
                                    totalrevenue(1) = tfg.BudgetValue
                                    totalrevenue(2) = tfg.ForecastValue
                                    subsidyvalue(0) = subsidyvalue(0) + tfg.FlashValue
                                    subsidyvalue(1) = subsidyvalue(1) + tfg.BudgetValue
                                    If WeeklyFlash.HasForecast = True Then subsidyvalue(2) = subsidyvalue(2) + tfg.ForecastValue
                                End If
                            End If
                        Else
                            subsidyvalue(0) = subsidyvalue(0) + tfg.FlashValue
                            subsidyvalue(1) = subsidyvalue(1) + tfg.BudgetValue
                            If WeeklyFlash.HasForecast = True Then subsidyvalue(2) = subsidyvalue(2) + tfg.ForecastValue
                        End If

                        subsidygroup.FlashValue = FormatCurrency(subsidyvalue(0), 0)
                        subsidygroup.BudgetValue = FormatCurrency(subsidyvalue(1), 0)
                        If WeeklyFlash.HasForecast = True Then subsidygroup.ForecastValue = FormatCurrency(subsidyvalue(2), 0)
                        subsidygroup.Controls("FlashField").Text = FormatCurrency(subsidyvalue(0), 0)
                    End If
                    tfg.Controls("FlashVarianceField").Text = FormatCurrency((tfg.BudgetValue - tfg.FlashValue), 0)
                    If WeeklyFlash.HasForecast = True Then tfg.Controls("ForecastVarianceField").Text = FormatCurrency((tfg.ForecastValue - tfg.FlashValue), 0)
                End If
            Next

        Catch ex As Exception

        End Try

        '#  Update percentage calculations
        For Each ctrl In WeeklyFlash.Controls
            If TypeOf ctrl Is FlashGroup Then
                tfg = ctrl
                If tfg.IsRevenueBlock = False Then
                    If tfg.FlashValue <> 0 Then
                        tfg.Controls("FlashPercentageField").Text = FormatPercent((tfg.FlashValue / -totalrevenue(0)), 1)
                    Else
                        tfg.Controls("FlashPercentageField").Text = ""
                    End If

                    If tfg.BudgetValue <> 0 Then
                        tfg.Controls("BudgetPercentageField").Text = FormatPercent((tfg.BudgetValue / -totalrevenue(1)), 1)
                    Else
                        tfg.Controls("BudgetPercentageField").Text = ""
                    End If

                    If WeeklyFlash.HasForecast = True Then
                        If tfg.ForecastValue <> 0 Then
                            tfg.Controls("ForecastPercentageField").Text = FormatPercent((tfg.ForecastValue / -totalrevenue(2)), 1)
                        Else
                            tfg.Controls("ForecastPercentageField").Text = ""
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub GetPeriodOpDays(p)
        '#  Check for presence of stored operating days.  If present, fetch.  If none are present, use template unit #99999
        Dim tempUnitNumber As Long, drTest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & Parent.UnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & p & "'")
        If drTest.Count = 0 Then
            tempUnitNumber = 99999
        Else
            tempUnitNumber = Parent.UnitNumber
        End If
        Dim c As Byte, pod As Byte = 0, dr() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & tempUnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & p & "'")
        For ct = 0 To dr.Count - 1
            For c = 5 To 9
                If dr(ct)(c) = True Then pod += 1
            Next
        Next
        PeriodOpDays = pod
        NumberofWeeks = dr.Count
        Parent.tsslPeriodDays.Text = "Period Op Days: " & PeriodOpDays
        If pod > 0 Then
            Parent.tsslPeriodDays.Visible = True
        Else
            Parent.tsslPeriodDays.Visible = False
        End If
    End Sub

    Friend Function GetWeekOpDays(w)
        '#  Check for presence of stored operating days.  If present, fetch.  If none are present, use template unit #99999
        Dim tempUnitNumber As Long, drTest() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & Parent.UnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & MSPeriod & "' and Week = '" & w & "'")
        If drTest.Count = 0 Then
            tempUnitNumber = 99999
        Else
            tempUnitNumber = Parent.UnitNumber
        End If
        Dim c As Byte, wod As Byte = 0, dr() As DataRow = DataSets.OpDaysTable.Select("Unit = '" & tempUnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & MSPeriod & "' and Week = '" & w & "'")
        c = dr.Count
        For ct = 5 To 9
            If dr(0)(ct) = True Then wod += 1
        Next
        Return wod
    End Function

    Public Sub FetchSavedFlash()
        SaveType = "New"
        Dim sfdr() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & FY & "' and MSPeriod = '" & MSPeriod & "' and Week = '" & wk & "' and Unit ='" & Parent.UnitNumber & "'")
        For ct = 0 To sfdr.Count - 1
            If RTrim(sfdr(ct)("Status")) = "Draft" Then
                SaveType = "Draft"
            Else
                SaveType = "Final"
            End If
            Dim tfg As FlashGroup = Parent.Controls(UCase(sfdr(ct)("GL_Category")))
            tfg.FlashValue = FormatNumber(sfdr(ct)("FlashValue"), 2)
            tfg.Controls("FlashField").Text = FormatCurrency(tfg.FlashValue, 0)
            If sfdr(ct)("FlashNotes").ToString <> "" Then tfg.NoteValue = sfdr(ct)("FlashNotes")
        Next

    End Sub

    Public Sub FetchBudget()
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

        Dim tfg As FlashGroup, ctrl As Control
        For Each ctrl In Parent.Controls
            If TypeOf ctrl Is FlashGroup Then
                tfg = ctrl
                tfg.FullBudget = 0 : tfg.BudgetValue = 0
                Dim dr() As DataRow = DataSets.BudgetTable.Select("MSFY = '" & FiscalYear & "' and MSP = '" & MSPeriod & "' and Cycle = '" & cycle & "' and Unit = '" & Parent.UnitNumber & "' and Category = '" & tfg.Name & "'")
                For ct = 0 To dr.Count - 1
                    tfg.FullBudget = FormatNumber(tfg.FullBudget, 2) + CType(dr(ct)("Budget"), Double)
                Next
                If Week > 0 Then
                    tfg.BudgetValue = FormatCurrency(((tfg.FullBudget / PeriodOpDays) * WeekOpDays), 2)
                    tfg.Controls("BudgetField").Text = FormatCurrency(tfg.BudgetValue, 0)
                End If
            Else End If
        Next
    End Sub

    Public Sub FetchForecast()
        Dim ctrl As Control, subsidy As Double = 0, subsidycontrol As FlashGroup
        For Each ctrl In WeeklyFlash.Controls
            If TypeOf (ctrl) Is FlashGroup Then
                Dim fg As FlashGroup = ctrl
                If fg.IsSubtotal = False Then
                    Dim dr() As DataRow = DataSets.ForecastTable.Select("UnitNum = '" & Parent.UnitNumber & "' and FY = '" & FiscalYear & "' and MSP = '" & MSP & "' and Week = '" & Week & "' and Category = '" & fg.DataName & "'")
                    If dr.Count > 0 Then
                        fg.Controls("ForecastField").Text = FormatCurrency(dr(0)("Value"), 0)
                        fg.ForecastValue = FormatNumber(dr(0)("Value"), 2)
                        subsidy = subsidy + fg.ForecastValue
                        subsidycontrol = Parent.Controls("SUBSIDY")
                        subsidycontrol.Controls("ForecastField").Text = FormatCurrency(subsidy, 0)
                    End If
                End If
            End If
        Next
    End Sub

End Class