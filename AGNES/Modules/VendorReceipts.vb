Public Class VendorReceipts
    Private unm As String
    Friend Property UserName As String
        Get
            Return unm
        End Get
        Set(value As String)
            unm = value
            tsslUser.Text = "Current User: " & unm
        End Set
    End Property
    Private FY As Long
    Friend Property FiscalYear As Long
        Get
            Return FY
        End Get
        Set(value As Long)
            FY = value
            tsslFY.Text = "FY: " & FY
        End Set
    End Property
    Private Period As Byte
    Friend Property MSP As Byte
        Get
            Return Period
        End Get
        Set(value As Byte)
            Period = value
            tsslPeriod.Visible = True
            tsslPeriod.Text = "Period: " & Period
            GetAvailableWeeks()
            tsmiWeek.Enabled = True
            tsslInformation.Text = "Waiting for Week selection"
            tsmiDate.Enabled = False
            tsslWeek.Visible = False
            tsslDate.Visible = False
            DestroyView()
        End Set
    End Property
    Private Week As Byte
    Friend Property Wk As Byte
        Get
            Return Week
        End Get
        Set(value As Byte)
            Week = value
            tsslWeek.Text = "Week: " & Week
            tsslWeek.Visible = True
            tsslDate.Visible = False
            tsslInformation.Text = "Waiting for Date selection"
            ViewType = ViewType
            With tsmiDate
                .fy = FiscalYear
                .msp = MSP
                .week = Wk
                .Populate()
                .Enabled = True
            End With
            DestroyView()
        End Set
    End Property
    Private HasFifth As Boolean
    Friend Property HasFifthWeek As Boolean
        Get
            Return HasFifth
        End Get
        Set(value As Boolean)
            HasFifth = value
            tsmiWeek.DropDownItems(4).Visible = HasFifth
        End Set
    End Property
    Private Dt As Date
    Friend Property DateChoice As Date
        Get
            Return Dt
        End Get
        Set(value As Date)
            Dt = value
            tsslDate.Visible = True
            tsslDate.Text = Dt
            DestroyView()
            CreateView()
        End Set
    End Property
    Private changed As Boolean
    Friend Property ChangesMade As Boolean
        Get
            Return changed
        End Get
        Set(value As Boolean)
            changed = value
            tsslSaveStatus.Text = "Not Saved"
            tsslSaveStatus.Visible = True
        End Set
    End Property
    Private Saved As Boolean
    Friend Property SaveChanges As Boolean
        Get
            Return Saved
        End Get
        Set(value As Boolean)
            Saved = value
            If Saved = True Then
                tsslSaveStatus.Text = "Saved"
                tsslSaveStatus.Visible = True
            End If
        End Set
    End Property
    Private ynchoice As Boolean
    Private MoveForm As Boolean
    Private MoveForm_MousePosition As Point
    Private View As Boolean
    Private CurrDt As Date
    Friend Property ViewType As Boolean
        Get
            Return View
        End Get
        Set(value As Boolean)
            '#  0 = Food trucks, 1 = Retail vendors
            View = value
            If View = 0 Then
                tsslInformation.Text = "Currently viewing Food Trucks"
                tsmiRetail.Enabled = True
                tsmiFoodTrucks.Enabled = False
            Else
                tsslInformation.Text = "Currently viewing Retail Vendors"
                tsmiRetail.Enabled = False
                tsmiFoodTrucks.Enabled = True
            End If
            DestroyView()
            CreateView()
        End Set
    End Property
    Friend SystemCall As Boolean
#Region "Initialize"

    Private Sub LoadModule(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        CurrDt = FormatDateTime(Now(), DateFormat.ShortDate)
        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & CurrDt & "'")
        tsmiMSP.MaxPeriod = DateDR(0)("MS_Period") - 1
        tsmiWeek.Enabled = False
        ViewType = 0
        tsslInformation.Text = "Waiting for Period selection"
        spReceipts.Visible = False
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles mstReceipts.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles mstReceipts.MouseMove
        If MoveForm Then
            Location = Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles mstReceipts.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SaveData(sender As Object, e As EventArgs) Handles tsmiSave.Click
        If ChangesMade = False Then Exit Sub
        Dim ctrl As Control, saveokay As Boolean
        For Each ctrl In spReceipts.Panel1.Controls
            If TypeOf (ctrl) Is RetailGroup Then
                Dim rg As RetailGroup = ctrl
                If rg.Controls("txtSales").Enabled = True And rg.Controls("txtCounts").Enabled = True And rg.ChangesMade = True Then
                    If rg.Extant = False Then
                        '#  Save as new entry
                        Select Case ViewType
                            Case 0
                                Try
                                    Dim InsertDR As DataRow = DataSets.VendorTransTable.NewRow()
                                    InsertDR("Date") = Dt
                                    InsertDR("FY") = FiscalYear
                                    InsertDR("MSP") = MSP
                                    InsertDR("Week") = Wk
                                    InsertDR("Vendor") = rg.DisplayName
                                    InsertDR("VendorType") = "Truck"
                                    InsertDR("Location") = rg.Controls("cbxLocation").Text
                                    InsertDR("Sales") = FormatNumber(rg.Controls("txtSales").Text, 2)
                                    InsertDR("Counts") = FormatNumber(rg.Controls("txtCounts").Text, 0)
                                    InsertDR("TimeStamp") = Now()
                                    InsertDR("SavedBy") = UserName
                                    DataSets.VendorTransTable.Rows.Add(InsertDR)
                                    saveokay = True
                                Catch ex As Exception
                                    saveokay = False
                                End Try
                            Case 1
                                Try
                                    Dim InsertDR As DataRow = DataSets.VendorTransTable.NewRow()
                                    InsertDR("Date") = Dt
                                    InsertDR("FY") = FiscalYear
                                    InsertDR("MSP") = MSP
                                    InsertDR("Week") = Wk
                                    InsertDR("Vendor") = rg.DisplayName
                                    InsertDR("VendorType") = "Retail"
                                    InsertDR("Location") = "Commons"
                                    InsertDR("Sales") = FormatNumber(rg.Controls("txtSales").Text, 2)
                                    InsertDR("Counts") = FormatNumber(rg.Controls("txtCounts").Text, 0)
                                    InsertDR("TimeStamp") = Now()
                                    InsertDR("SavedBy") = UserName
                                    DataSets.VendorTransTable.Rows.Add(InsertDR)
                                    saveokay = True
                                Catch ex As Exception
                                    saveokay = False
                                End Try
                        End Select
                    Else
                        '#  Overwrite existing
                        Try
                            Dim upDR() As DataRow = DataSets.VendorTransTable.Select("Date = '" & rg.SelectedDate & "' and Vendor  = '" & rg.DisplayName & "'")
                            upDR(0)("Sales") = FormatNumber(rg.Controls("txtSales").Text, 2)
                            upDR(0)("Counts") = FormatNumber(rg.Controls("txtCounts").Text, 0)
                            upDR(0)("TimeStamp") = Now()
                            upDR(0)("SavedBy") = UserName
                            saveokay = True
                        Catch ex As Exception
                            saveokay = False
                        End Try
                    End If
                End If
            End If
        Next

        DataSets.VendorTransAdapt.Update(DataSets.VendorTransTable)
        DataSets.VendorTransAdapt.Fill(DataSets.VendorTransTable)
        If saveokay = True Then
            Dim amsg As New AgnesMsgBox("Your entries have been saved.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            SaveChanges = True
            DestroyView()
            CreateView()
        Else
            Dim amsg As New AgnesMsgBox("Your entries were not saved due to error number " & Err.Number & ".  Try again and, if this error continues, please notify the Business Intelligence department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            SaveChanges = False
        End If
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

    Private Sub ClearData(sender As Object, e As EventArgs) Handles tsmiClear.Click
        Dim ctrl As Control
        For Each ctrl In spReceipts.Panel1.Controls
            If TypeOf (ctrl) Is RetailGroup Then
                Dim rg As RetailGroup = ctrl
                If rg.Controls("txtSales").Enabled = True Then rg.Controls("txtSales").Text = "$0.00"
                If rg.Controls("txtCounts").Enabled = True Then rg.Controls("txtCounts").Text = "0"
            End If
        Next

    End Sub

    Private Sub UnlockData(sender As Object, e As EventArgs) Handles tsmiUnlock.Click
        Dim ctrl As Control
        For Each ctrl In spReceipts.Panel1.Controls
            If TypeOf (ctrl) Is RetailGroup Then
                Dim rg As RetailGroup = ctrl
                If rg.Extant = True Then
                    If rg.Controls("txtSales").Enabled = False Then rg.Controls("txtSales").Enabled = True
                    If rg.Controls("txtCounts").Enabled = False Then rg.Controls("txtCounts").Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub DeleteEntry(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        Dim Ph As String = ""
    End Sub

    Private Sub ShowRetail(sender As Object, e As EventArgs) Handles tsmiRetail.Click
        '# Check for unsaved data
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change periods?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        ChangesMade = False
        SaveChanges = True
        ViewType = 1
    End Sub

    Private Sub ShowTrucks(sender As Object, e As EventArgs) Handles tsmiFoodTrucks.Click
        '# Check for unsaved data
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change periods?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        ChangesMade = False
        SaveChanges = True
        ViewType = 0
    End Sub

#End Region

#Region "Functions"

    Private Sub DestroyView()
        spReceipts.Visible = False
        panAvailability.Visible = False
        For i As Integer = (spReceipts.Panel1.Controls.Count - 1) To 0 Step -1
            Dim ctrl As Control = spReceipts.Panel1.Controls(i)
            If TypeOf (ctrl) Is RetailGroup Then
                spReceipts.Panel1.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next i

    End Sub

    Private Sub CreateView()
        If FormatDateTime(DateChoice, DateFormat.ShortDate).ToString = "1/1/0001" Or SystemCall = True Then Exit Sub
        DataSets.VendorAdapt.Fill(DataSets.VendorTable)
        Dim t = 25
        Select Case ViewType
            Case 0
                lblLocation.Visible = False

                '###    ADD ROUTINE TO TIE TO RACHEL'S SCHEDULE AND ONLY DISPLAY TRUCKS SCHEDULED FOR THE SELECTED DAY

                Dim dr() As DataRow = DataSets.VendorTable.Select("VendorType = 'Truck' and Status = 'True'")
                If dr.Count = 0 Then Exit Sub
                lblLocation.Visible = True
                For ct = 0 To dr.Count - 1
                    Dim v As New RetailGroup With {.Left = 1, .Top = t, .DisplayName = dr(ct)("VendorName"), .GroupType = "Truck", .SelectedDate = Dt}
                    spReceipts.Panel1.Controls.Add(v)
                    panAvailability.Visible = True
                    t += 40
                Next
            Case 1
                lblLocation.Visible = False
                Dim dr() As DataRow = DataSets.VendorTable.Select("VendorType = 'Retail' and Status = 'True'")
                If dr.Count = 0 Then Exit Sub
                For ct = 0 To dr.Count - 1
                    Dim v As New RetailGroup With {.Left = 1, .Top = t, .DisplayName = dr(ct)("VendorName"), .GroupType = "Retail", .SelectedDate = Dt}
                    spReceipts.Panel1.Controls.Add(v)
                    t += 40
                Next
        End Select
        spReceipts.Visible = True
    End Sub

    Private Sub GetAvailableWeeks()
        '# Check for unsaved data
        If ChangesMade = True And SaveChanges = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to change periods?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        ChangesMade = False
        SaveChanges = True
        tsslDate.Visible = False
        HasFifthWeek = False
        Dim DateDR() As DataRow = DataSets.DateTable.Select("MS_FY = '" & FiscalYear & "' and MS_Period = '" & MSP & "' and Week = '5'")
                    If DateDR.Count > 0 Then
            HasFifthWeek = True : tsmiWeek.MaxWeek = 5
        Else
            tsmiWeek.MaxWeek = 5
        End If
    End Sub

    Friend Sub VendorInfo(vendor)
        If txtVendorName.Text = vendor Then Exit Sub
        txtVendorName.Text = vendor
        Dim dr() As DataRow = DataSets.VendorTable.Select("VendorName = '" & vendor & "'")
        txtCamType.Text = dr(0)("CAMType")
        txtKPIType.Text = dr(0)("KPIType")
        Select Case txtCamType.Text
            Case "Flat"
                txtCamAmount.Text = FormatCurrency(dr(0)("CAMAmount"), 0)
            Case "Percentage"
                txtCamAmount.Text = FormatPercent(dr(0)("CAMAmount"), 1)
        End Select
        Select Case txtKPIType.Text
            Case "None"
                txtKPIAmount.Text = ""
            Case "Special"
                txtKPIAmount.Text = ""
            Case "Percentage"
                txtKPIAmount.Text = FormatPercent(dr(0)("KPIAmount"), 1)
        End Select
        If ViewType = 0 Then
            chkMon.Checked = dr(0)("Mon")
            chkTue.Checked = dr(0)("Tue")
            chkWed.Checked = dr(0)("Wed")
            chkThu.Checked = dr(0)("Thu")
            chkFri.Checked = dr(0)("Fri")
        End If
    End Sub

#End Region

End Class