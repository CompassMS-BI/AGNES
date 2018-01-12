Imports Charting = System.Windows.Forms.DataVisualization.Charting
Imports ComponentModel = System.ComponentModel
Public Class WasteTracking
    Public period As Byte
    Public FY As Long
    Private usernm As String
    Private CurrentView As Boolean
    Private ct As Integer
    Public unum As Long
    Private uname As String
    Private LastStationNum As Byte
    Private slcked As Boolean
    Private savd As Boolean
    Private WasteTypes() As String = {"Production", "Spoilage", "Time/Temp"}     '#  List of waste types - hard coded, but avoids chaos with individualized naming conventions
    Private ynchoice As Boolean
    Private wk As Byte
    Private SelectedWasteType As String = "All"
    Private SelectedStation As String = "All"
    Public Property Datasaved As Boolean
        Get
            Return savd
        End Get
        Set(value As Boolean)
            savd = value
            If value = True Then
                tsslStatus.Text = "Saved"
                tsmiSave.Enabled = False
            Else
                tsslStatus.Text = "Unsaved"
                tsmiSave.Enabled = True
            End If
        End Set
    End Property
    Private Property StationsLocked As Boolean
        Get
            Return slcked
        End Get
        Set(value As Boolean)
            slcked = value
            Dim wsg As WasteStationGroup
            For Each wsg In panStations.Controls
                wsg.Enabled = slcked
            Next
        End Set
    End Property
    Public Property username As String
        Get
            Return usernm
        End Get
        Set(value As String)
            usernm = value
            tsslUser.Text = usernm
        End Set
    End Property
    Public Property unitnm As String
        Get
            Return uname
        End Get
        Set(value As String)
            uname = value
            tsslUnit.Text = uname
        End Set
    End Property
    Public Property msp As Byte
        Get
            Return period
        End Get
        Set(value As Byte)
            period = value
            tsmiWeek.UpdateWeeks(FY, period)
            week = 1
            tsslPeriod.Text = "Period: " & period
            tsslPeriod.Visible = True
            tsmiMSP.MSP = msp
            '#  Add other routine calls here
        End Set
    End Property
    Public Property week As Byte
        Get
            Return wk
        End Get
        Set(value As Byte)
            wk = value
            tsslWeek.Text = "Week: " & wk
            tsslWeek.Visible = True
            LoadSavedData()
            ShowStationAnalytics(False)
            CreatePieChart()
            tsmiWeek.week = wk
            '#  Add other routine calls here
        End Set
    End Property

#Region "Initialize Waste Tracker"

    Private Sub LoadFlashStatus(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
        PopulateStations()
        PopulateWasteTypes()
        Dim wkget As Byte, DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & Now().Date.AddDays(-1) & "'")
        FY = DateDR(0)("MS_FY")
        msp = DateDR(0)("MS_Period")
        wkget = DateDR(0)("Week")
        week = wkget
        tsmiMSP.MSP = msp
        tsmiWeek.week = week
        tsslFY.Text = FY
        Datasaved = True
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub SaveWasteData(sender As Object, e As EventArgs) Handles tsmiSave.Click
        Dim wsg As WasteStationGroup, wst As Control, workingwst As WasteTypeGroup, wnud As Control, workingwnud As WasteNud, errkick As Boolean
        errkick = False
        For Each wsg In panStations.Controls
            For Each wst In wsg.Controls
                If TypeOf (wst) Is WasteTypeGroup Then
                    workingwst = wst
                    For Each wnud In workingwst.Controls
                        If TypeOf (wnud) Is WasteNud Then
                            workingwnud = wnud
                            '#              Test for existing
                            Try
                                Dim dr() As DataRow = DataSets.WasteRecordTable.Select("FiscalYear = '" & FY & "' and MSP = '" & msp & "' and Week = '" & wk & "' and Weekday = '" & wnud.Name & "' and UnitNum = '" & unum & "' and Station = '" & wsg.StationID & "' and Type = '" & workingwst.WasteType & "'")
                                If dr.Count > 0 Then
                                    '# Overwrite
                                    dr(0)("WasteVal") = workingwnud.Value
                                Else
                                    Dim newdr As DataRow = DataSets.WasteRecordTable.NewRow
                                    newdr("FiscalYear") = FY
                                    newdr("MSP") = msp
                                    newdr("Week") = week
                                    newdr("Weekday") = workingwnud.Name
                                    newdr("UnitNum") = unum
                                    newdr("Station") = wsg.StationID
                                    newdr("Type") = workingwst.WasteType
                                    newdr("WasteVal") = workingwnud.Value
                                    DataSets.WasteRecordTable.Rows.Add(newdr)
                                End If
                            Catch ex As Exception
                                errkick = True
                            End Try

                        End If
                    Next
                End If
            Next
        Next
        DataSets.WasteRecordAdapt.Update(DataSets.WasteRecordTable)
        If errkick = False Then
            Dim amsg As New AgnesMsgBox("Data saved", 2, False, "Waste")
            amsg.ShowDialog()
            amsg.Dispose()
            Datasaved = True
        Else
            Dim amsg As New AgnesMsgBox("Data not saved due to error #" & Err.Number & ".  Please take a screenshot and notify the BI department!", 2, False, "Waste")
            amsg.ShowDialog()
            amsg.Dispose()
            Datasaved = False
        End If
    End Sub

    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If Datasaved = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Do you still wish to exit?", 2, True, "waste")
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Dispose()
        Portal.Show()
    End Sub

    Private Sub ChangeStationName(sender As Object, e As EventArgs) Handles tsmiChangeName.Click
        Dim wg As WasteTypeGroup = ActiveControl.Parent
        Dim wsg As WasteStationGroup = wg.Parent
        Dim newnm As String = InputBox("Enter New name for this station:      ", "Renaming " & wsg.StationName, "")
        If newnm = "" Then Exit Sub

        '#  Modify drop down items in toolstrip
        Dim ctrl As ToolStripMenuItem
        For Each ctrl In tsmiStations.DropDownItems
            Dim typ As String = ctrl.GetType.ToString
            If ctrl.Name = wsg.StationName Then
                With ctrl
                    .Name = newnm
                    .Text = newnm
                End With
            End If
        Next

        '#  Modify database and waste station group
        Dim dr() As DataRow = DataSets.WasteStationTable.Select("unit_num = '" & unum & "' and station_name = '" & wsg.StationName & "'")
        dr(0)("station_name") = newnm
        DataSets.WasteStationAdapt.Update(DataSets.WasteStationTable)
        wsg.StationName = newnm
        wsg.Controls("StationLabel").Text = StrConv(newnm, vbProperCase)

    End Sub

    Private Sub AddNewStation(sender As Object, e As EventArgs) Handles tsmiNewStation.Click
        Dim newnm As String = InputBox("Enter the new station's name: ", "Add new station")
        If newnm = "" Then Exit Sub
        Dim dr As DataRow = DataSets.WasteStationTable.NewRow
        dr("unit_num") = unum
        dr("station_num") = LastStationNum + 1
        dr("station_name") = newnm
        dr("Creator") = username
        dr("Created") = FormatDateTime(Now(), vbShortDate)
        DataSets.WasteStationTable.AddWasteStationsRow(dr)
        DataSets.WasteStationAdapt.Update(DataSets.WasteStationTable)
        PopulateStations()
    End Sub

    Private Sub UnlockWeek(sender As Object, e As EventArgs) Handles tsmiUnlock.Click
        StationsLocked = False
    End Sub

#End Region

#Region "Functions"




    Private Sub ShowStationAnalytics(tf)
        panCampus.Visible = tf
        panPerCheck.Visible = tf
        panRollingBar.Visible = tf
        panStationWaste.Visible = tf
    End Sub
    Private Sub PopulateStations()
        ClearExistingStations()
        Dim AllItem As New ToolStripMenuItem With {.Name = "All", .Text = "All", .CheckOnClick = True, .Checked = True}
        AddHandler AllItem.Click, AddressOf StationSelect
        tsmiStations.DropDownItems.Add(AllItem)
        DataSets.WasteStationAdapt.Fill(DataSets.WasteStationTable)
        Dim dr() As DataRow = DataSets.WasteStationTable.Select("unit_num = '" & unum & "'")
        Dim y As Integer = 5
        For ct = 0 To dr.Count - 1
            Dim newstation As New WasteStationGroup With {.Width = 450, .Height = 190, .StationID = dr(ct)("station_num"), .StationName = dr(ct)("station_name"), .Top = y, .Left = 2, .BorderStyle = BorderStyle.FixedSingle}
            panStations.Controls.Add(newstation)
            AddHandler newstation.Enter, AddressOf StationFocus
            y += 195
            Dim newdd As New ToolStripMenuItem With {.Name = newstation.StationName, .Text = newstation.StationName}
            AddHandler newdd.Click, AddressOf StationSelect
            tsmiStations.DropDownItems.Add(newdd)
            LastStationNum = dr(ct)("station_num")
        Next
    End Sub

    Private Sub PopulateWasteTypes()
        tsmiWasteType.DropDownItems.Clear()
        Dim AllItem As New ToolStripMenuItem With {.Name = "All", .Text = "All", .CheckOnClick = True, .Checked = True}
        AddHandler AllItem.Click, AddressOf WasteTypeSelect
        tsmiWasteType.DropDownItems.Add(AllItem)
        For ct = 0 To WasteTypes.Count - 1
            Dim newwt As New ToolStripMenuItem With {.Name = RemoveWhitespace(WasteTypes(ct)), .Text = WasteTypes(ct)}
            tsmiWasteType.DropDownItems.Add(newwt)
            AddHandler newwt.Click, AddressOf WasteTypeSelect
        Next
    End Sub

    Private Sub ClearExistingStations()
        Dim wsg As WasteStationGroup
        For Each wsg In panStations.Controls
            panStations.Controls.Remove(wsg)
        Next
        tsmiStations.DropDownItems.Clear()
    End Sub

    Private Sub LoadSavedData()
        DataSets.WasteRecordAdapt.Fill(DataSets.WasteRecordTable)
        Dim wsg As WasteStationGroup, totals As Double
        For Each wsg In panStations.Controls
            Dim wtg As Control
            For Each wtg In wsg.Controls
                If TypeOf (wtg) Is WasteTypeGroup Then
                    totals = 0
                    Dim wnud As Control, workingtg As WasteTypeGroup = wtg
                    For Each wnud In wtg.Controls
                        If TypeOf (wnud) Is WasteNud Then
                            Dim workingnud As WasteNud = wnud
                            If workingnud.Name <> "WeekTotal" Then
                                Try
                                    Dim stationget() As DataRow = DataSets.WasteStationTable.Select("unit_num = '" & unum & "' and station_name = '" & wsg.StationName & "'")
                                    Dim statnum As Integer = stationget(0)("station_num")
                                    Dim dr() As DataRow = DataSets.WasteRecordTable.Select("FiscalYear = '" & FY & "' and MSP = '" & msp & "' and Week = '" & wk & "' and Weekday = '" & wnud.Name & "' and UnitNum = '" & unum & "' and Station = '" & statnum & "' and Type = '" & workingtg.WasteType & "'")
                                    If dr.Count = 0 Then
                                        workingnud.Value = 0
                                    Else
                                        workingnud.Value = FormatNumber(dr(0)("WasteVal"), 1)
                                        totals += workingnud.Value
                                        Datasaved = True
                                    End If

                                Catch ex As Exception
                                    workingnud.Value = 0
                                End Try
                                Dim totalnud As WasteNud = workingtg.Controls("WeekTotal")
                                totalnud.Value = totals
                            End If
                        End If
                    Next
                End If
            Next
        Next
        CreatePieChart()
    End Sub

    Private Sub StationFocus(sender As Object, e As EventArgs)
        Dim sndr As WasteStationGroup = sender
        tsslStation.Text = sndr.StationName
    End Sub

    Private Sub StationSelect(sender As Object, e As EventArgs)
        Dim snd As ToolStripMenuItem = sender
        Dim ctrl As ToolStripMenuItem
        For Each ctrl In tsmiStations.DropDownItems
            If ctrl.Name <> snd.Name Then
                ctrl.Checked = False
                SelectedStation = "All"
            Else
                ctrl.Checked = True
                SelectedStation = ctrl.Name
            End If
        Next

        '###################################
        '#  ADD ROUTINES FOR ANALYTICS
        '###################################

    End Sub

    Private Sub WasteTypeSelect(sender As Object, e As EventArgs)
        Dim snd As ToolStripMenuItem = sender
        Dim ctrl As ToolStripMenuItem
        For Each ctrl In tsmiWasteType.DropDownItems
            If ctrl.Name <> snd.Name Then
                ctrl.Checked = False
                SelectedWasteType = "All"
            Else
                ctrl.Checked = True
                SelectedWasteType = ctrl.Name
            End If
        Next

        '###################################
        '#  ADD ROUTINES FOR ANALYTICS
        '###################################

    End Sub

    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Private Sub CreatePieChart()
        panStationWaste.Visible = True
        Dim slicecount As Byte
        Dim slices() As Double
        Dim slicename() As String
        Dim WasteTotal As Double, AllWasteTotal As Double
        Dim ct As Integer

        '#  Count number of stations in order to determine the slice count
        Dim ctrl As Control
        For Each ctrl In panStations.Controls
            If TypeOf (ctrl) Is WasteStationGroup Then slicecount += 1
        Next
        ReDim slices(slicecount)
        ReDim slicename(slicecount)

        '# Get values of each slice
        ct = 0
        For Each ctrl In panStations.Controls
            If TypeOf (ctrl) Is WasteStationGroup Then
                Dim wsg As WasteStationGroup = ctrl
                Dim subctrl As Control
                WasteTotal = 0
                For Each subctrl In wsg.Controls
                    If TypeOf (subctrl) Is WasteTypeGroup Then
                        Dim wtg As WasteTypeGroup = subctrl
                        If SelectedWasteType = "All" Or SelectedWasteType = wtg.WasteName Then
                            Dim wkgnud As WasteNud = wtg.Controls("WeekTotal")
                            WasteTotal += wkgnud.Value
                        End If
                    End If
                Next
                slices(ct) = WasteTotal
                slicename(ct) = wsg.StationName
                AllWasteTotal += WasteTotal
                ct += 1
            End If
        Next

        '# Apply slices to pie chart
        With chtWastePie
            .Legends.Clear()
            .Series.Clear()
            .ChartAreas.Clear()
        End With

        Dim areas1 As Charting.ChartArea = chtWastePie.ChartAreas.Add("Areas1")
        Dim pieslice As Charting.Series = chtWastePie.Series.Add("StationMix")
        With pieslice
            .ChartType = Charting.SeriesChartType.Pie
            .Palette = Charting.ChartColorPalette.Bright

        End With
        For ct = 0 To slicecount - 1
            Dim pct As Double = FormatNumber((slices(ct) / AllWasteTotal), 2)
            With pieslice
                .Points.AddXY(slicename(ct), pct)
                .Label = "#VALX" + ControlChars.Lf + "#VALY"
                .CustomProperties = "PieLabelStyle=Outside"
                .IsValueShownAsLabel = True
                .LabelToolTip = "#VALUE"
                .XValueType = Charting.ChartValueType.String
                .YValueType = Charting.ChartValueType.Double
                .LabelFormat = "#.#%"
                .SmartLabelStyle.Enabled = True
                .SmartLabelStyle.AllowOutsidePlotArea = Charting.LabelOutsidePlotAreaStyle.Yes
                .SmartLabelStyle.MinMovingDistance = 20
                .SmartLabelStyle.MaxMovingDistance = 50
            End With
        Next




        ' Dim legends1 As Legend = Me.chrtRegisterAvailability.Legends.Add("Legends1")
    End Sub
#End Region

End Class