Public Class PromoEditor
    Friend PromoID As Integer
    Friend POSEditor As Boolean
    Friend Cloned As Boolean
    Private cm As Boolean
    Private Property ChangesMade As Boolean
        Get
            Return cm
        End Get
        Set(value As Boolean)
            cm = value
            If cm = True Then Saved = False
        End Set
    End Property
    Private svd As Boolean
    Private Property Saved As Boolean
        Get
            Return svd
        End Get
        Set(value As Boolean)
            svd = value
            If svd = True Then
                tsslStatus.Text = "Saved"
                tsmiSave.Enabled = False
            Else
                tsslStatus.Text = "Not saved"
                tsmiSave.Enabled = True
            End If
        End Set
    End Property
    Private ynchoice As Boolean
    Private MoveForm As Boolean
    Private MoveForm_MousePosition As Point

#Region "Initialization"

    Private Sub LoadPromoEditor(sender As Object, e As EventArgs) Handles Me.Load
        tsslUser.Text = "Current User: " & Portal.UserName
        tsslInfo.Text = ""
        If PromoID = -1 Then tsmiDelete.Enabled = False
        RefreshPromoList()
        FetchSelectedPromo()
        If Cloned = True Then
            txtPromoName.Text = ""
            Cloned = False
            PromoID = -1
        End If
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles mstPromos.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles mstPromos.MouseMove
        If MoveForm Then
            Location = Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles mstPromos.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SavePromo(sender As Object, e As EventArgs) Handles tsmiSave.Click
        Dim invalidsave As Boolean = ValidateForm()
        If invalidsave = True Then
            Dim amsg As New AgnesMsgBox("Cannot save with data missing from required fields.", 2, False, Me.Name)
            amsg.ShowDialog()
            Exit Sub
        End If
        If PromoID = -1 Then
            SaveAsNew()
        Else
            SaveAsOverwrite()
        End If
    End Sub

    Private Sub DeletePromo(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        Dim ph As String = ""
        'TODO: Add promo deletion routine
    End Sub

    Private Sub ExitPromoMgr(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If ChangesMade = True And Saved = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Dispose()
        ChoosePromo.Show()
        Exit Sub
    End Sub

#End Region

#Region "User Fields"

    Private Sub LeaveNameField(sender As Object, e As EventArgs) Handles txtPromoName.Leave
        tsslPromoName.Text = "Current Promo: " & txtPromoName.Text
    End Sub

    Private Sub UserMadeChanges(sender As Object, e As EventArgs) Handles txtPromoName.TextChanged, cbxCoordinator.SelectedIndexChanged, cbxType.TextChanged,
            cbxStartTime.TextChanged, cbxEndTime.TextChanged, txtMediaURL.TextChanged, txtPromoDesc.TextChanged
        ChangesMade = True
    End Sub

    Private Sub AddLocation(sender As Object, e As EventArgs) Handles lbxLocations.DoubleClick, pbxLocAdd.Click
        If lbxLocations.SelectedIndex = -1 Then Exit Sub
        Dim loc As String = lbxLocations.SelectedItem.ToString
        lbxLocations.Items.RemoveAt(lbxLocations.SelectedIndex)
        lbxLocSelected.Items.Add(loc)
        RefreshStations()
        ChangesMade = True
    End Sub

    Private Sub SubLocation(sender As Object, e As EventArgs) Handles lbxLocSelected.DoubleClick, pbxLocSub.Click
        If lbxLocSelected.SelectedIndex = -1 Then Exit Sub
        If lbxLocSelected.Items.Count - 1 = 0 Then
            If lbxStationSelected.Items.Count > 0 Then
                Dim amsg As New AgnesMsgBox("If you remove this item, it will clear all of your station selections.  Do you wish to continue?", 2, True, Me.Name)
                amsg.ShowDialog()
                ynchoice = amsg.Choicemade
                amsg.Dispose()
                If ynchoice = False Then Exit Sub
            End If
        End If
        Dim loc As String = lbxLocSelected.SelectedItem.ToString
        lbxLocSelected.Items.RemoveAt(lbxLocSelected.SelectedIndex)
        lbxLocations.Items.Add(loc)
        RefreshStations()
        ChangesMade = True
    End Sub

    Private Sub AddStation(sender As Object, e As EventArgs) Handles lbxStations.DoubleClick, pbxStatAdd.Click
        If lbxStations.SelectedIndex = -1 Then Exit Sub
        Dim loc As String = lbxStations.SelectedItem.ToString
        lbxStations.Items.RemoveAt(lbxStations.SelectedIndex)
        lbxStationSelected.Items.Add(loc)
        ChangesMade = True
    End Sub

    Private Sub SubStation(sender As Object, e As EventArgs) Handles lbxStationSelected.DoubleClick, pbxStatSub.Click
        If lbxStationSelected.SelectedIndex = -1 Then Exit Sub
        Dim loc As String = lbxStationSelected.SelectedItem.ToString
        lbxStationSelected.Items.RemoveAt(lbxStationSelected.SelectedIndex)
        lbxStations.Items.Add(loc)
        ChangesMade = True
    End Sub

    Private Sub StartDateChanged(sender As Object, e As EventArgs) Handles dtpStartDt.ValueChanged
        dtpEndDt.MinDate = dtpStartDt.Value
        dtpEndDt.Enabled = True
        ChangesMade = True
    End Sub

    Private Sub StartTimeChanged(sender As Object, e As EventArgs) Handles cbxStartTime.SelectedIndexChanged
        RefreshEndTimes()
        ChangesMade = True
    End Sub

    Private Sub EnterURLField(sender As Object, e As EventArgs) Handles txtMediaURL.Enter
        txtMediaURL.SelectAll()
    End Sub

#End Region

#Region "Functions"

    Private Sub SaveAsNew()
        Dim saveokay As Boolean
        Try
            Dim InsertDR As DataRow = DataSets.PromoTable.NewRow()
            InsertDR("PromoName") = txtPromoName.Text
            InsertDR("PromoType") = cbxType.Text
            InsertDR("PromoCoord") = cbxCoordinator.Text
            InsertDR("PromoStart") = dtpStartDt.Value
            InsertDR("PromoEnd") = dtpEndDt.Value
            InsertDR("PromoTimeStart") = cbxStartTime.Text
            InsertDR("PromoTimeEnd") = cbxEndTime.Text
            InsertDR("PromoDesc") = txtPromoDesc.Text
            InsertDR("CreatedAt") = Now()
            InsertDR("CreatedBy") = Portal.UserName

            '#  Create location string concatenation
            Dim locstring As String
            If lbxLocSelected.Items.Count = 1 Then
                locstring = lbxLocSelected.Items(0).ToString
            Else
                locstring = lbxLocSelected.Items(0).ToString
                For ct = 1 To lbxLocSelected.Items.Count - 1
                    locstring = locstring & "," & lbxLocSelected.Items(ct).ToString
                Next
            End If
            InsertDR("PromoLocation") = locstring

            '#  Create station string concatenation
            Dim stationstring As String
            Select Case lbxStationSelected.Items.Count
                Case 0
                    stationstring = ""
                Case 1
                    stationstring = lbxStationSelected.Items(0).ToString
                Case Else
                    stationstring = lbxStationSelected.Items(0).ToString
                    For ct = 1 To lbxStationSelected.Items.Count - 1
                        stationstring = stationstring & "," & lbxStationSelected.Items(ct).ToString
                    Next
            End Select

            InsertDR("PromoStation") = stationstring

            '#  Construct URL correctly
            Dim url As String = ""
            If txtMediaURL.Text <> "" Then
                url = txtMediaURL.Text
                If UCase(Mid(url, 1, 4)) <> "HTTP" Then url = "http://" & txtMediaURL.Text
            End If
            InsertDR("PromoURL") = url

            DataSets.PromoTable.Rows.Add(InsertDR)
            saveokay = True
        Catch ex As Exception
            saveokay = False
        End Try
        DataSets.PromoAdapt.Update(DataSets.PromoTable)
        DataSets.PromoAdapt.Fill(DataSets.PromoTable)
        If saveokay = True Then
            Dim amsg As New AgnesMsgBox("Your promotion has been saved.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            Saved = True
            ChangesMade = False
        Else
            Dim amsg As New AgnesMsgBox("Your promotion was not saved due to error number " & Err.Number & ".  Try again and, if this error continues, please notify the Business Intelligence department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            ChangesMade = False
        End If

    End Sub

    Private Sub SaveAsOverwrite()
        Dim saveokay As Boolean
        Try
            Dim upDR() As DataRow = DataSets.PromoTable.Select("PID = '" & PromoID & "'")
            upDR(0)("PromoName") = txtPromoName.Text
            upDR(0)("PromoType") = cbxType.Text
            upDR(0)("PromoCoord") = cbxCoordinator.Text
            upDR(0)("PromoStart") = dtpStartDt.Value
            upDR(0)("PromoEnd") = dtpEndDt.Value
            upDR(0)("PromoTimeStart") = cbxStartTime.Text
            upDR(0)("PromoTimeEnd") = cbxEndTime.Text
            upDR(0)("PromoDesc") = txtPromoDesc.Text
            upDR(0)("CreatedAt") = Now()
            upDR(0)("CreatedBy") = Portal.UserName

            '#  Create location string concatenation
            Dim locstring As String
            If lbxLocSelected.Items.Count = 1 Then
                locstring = lbxLocSelected.Items(0).ToString
            Else
                locstring = lbxLocSelected.Items(0).ToString
                For ct = 1 To lbxLocSelected.Items.Count - 1
                    locstring = locstring & "," & lbxLocSelected.Items(ct).ToString
                Next
            End If
            upDR(0)("PromoLocation") = locstring

            '#  Create station string concatenation
            Dim stationstring As String
            If lbxStationSelected.Items.Count = 1 Then
                stationstring = lbxStationSelected.Items(0).ToString
            Else
                stationstring = lbxStationSelected.Items(0).ToString
                For ct = 1 To lbxStationSelected.Items.Count - 1
                    stationstring = stationstring & "," & lbxStationSelected.Items(ct).ToString
                Next
            End If
            upDR(0)("PromoStation") = stationstring

            '#  Construct URL correctly
            Dim url As String = txtMediaURL.Text
            If UCase(Mid(url, 1, 4)) <> "HTTP" Then url = "http://" & txtMediaURL.Text
            upDR(0)("PromoURL") = url

            saveokay = True
        Catch ex As Exception
            saveokay = False
        End Try

        DataSets.PromoAdapt.Update(DataSets.PromoTable)
        DataSets.PromoAdapt.Fill(DataSets.PromoTable)
        If saveokay = True Then
            Dim amsg As New AgnesMsgBox("Your promotion has been updated.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            Saved = True
            ChangesMade = False
        Else
            Dim amsg As New AgnesMsgBox("Your promotion was not updated due to error number " & Err.Number & ".  Try again and, if this error continues, please notify the Business Intelligence department.", 2, False, Me.Name)
            amsg.ShowDialog()
            amsg.Dispose()
            ChangesMade = False
        End If

    End Sub

    Private Function ValidateForm()
        Dim invalid As Boolean
        If txtPromoName.Text = "" Then invalid = True
        If cbxType.SelectedIndex = -1 Then invalid = True
        If lbxLocSelected.Items.Count = 0 Then invalid = True
        If lbxStationSelected.Items.Count = 0 And lbxStations.Enabled = True Then invalid = True
        If cbxStartTime.SelectedIndex = -1 Then invalid = True
        If cbxEndTime.SelectedIndex = -1 Then invalid = True
        Return invalid
    End Function

    Private Sub RefreshPromoList()
        DataSets.PromoAdapt.Fill(DataSets.PromoTable)
    End Sub

    Private Sub FetchSelectedPromo()
        If PromoID = -1 Then
            ResetToNew()
        Else
            LoadPromotion()
        End If
    End Sub

    Private Sub ResetToNew()
        txtPromoName.Text = ""
        tsslPromoName.Text = "New Promotion"
        txtPromoName.Select()
        cbxType.Text = ""
        ResetLocations()
        With lbxStations
            .Items.Clear()
            .Enabled = False
        End With
        With lbxStationSelected
            .Items.Clear()
            .Enabled = False
        End With
        dtpStartDt.Value = Now()
        dtpEndDt.Value = Now()
        cbxStartTime.Text = ""
        cbxEndTime.Text = ""
        cbxCoordinator.Text = ""
        txtMediaURL.Text = ""
        txtPromoDesc.Text = ""
        tsmiSave.Enabled = False
        tsmiDelete.Enabled = False
    End Sub

    Private Sub LoadPromotion()
        Dim dr() As DataRow = DataSets.PromoTable.Select("PID = '" & PromoID & "'")
        txtPromoName.Text = dr(0)("PromoName")
        tsslPromoName.Text = "Current Promo: " & txtPromoName.Text
        cbxType.Text = dr(0)("PromoType")
        ResetLocations()
        AssignLocations(dr(0)("PromoLocation"))
        AssignStations(dr(0)("PromoStation"))
        dtpStartDt.Value = dr(0)("PromoStart")
        dtpEndDt.Value = dr(0)("PromoEnd")
        cbxStartTime.Text = dr(0)("PromoTimeStart")
        cbxEndTime.Text = dr(0)("PromoTimeEnd")
        cbxCoordinator.Text = dr(0)("PromoCoord")
        txtMediaURL.Text = dr(0)("PromoURL")
        txtPromoDesc.Text = dr(0)("PromoDesc")
        ChangesMade = False
        Saved = True
        LoadPOSIDList()
        tsmiDelete.Enabled = Not POSEditor
        tsmiAddPOS.Enabled = POSEditor
    End Sub

    Private Sub ResetLocations()
        lbxLocations.Items.Clear()
        DataSets.PromoLocAdapt.Fill(DataSets.PromoLocTable)
        Dim dr() As DataRow = DataSets.PromoLocTable.Select
        For ct = 0 To dr.Count - 1
            lbxLocations.Items.Add(dr(ct)("PromoLocation"))
        Next
    End Sub

    Private Sub AssignLocations(locstring)
        lbxLocSelected.Items.Clear()

        Dim locations As String() = locstring.Split(New Char() {","c})
        Dim loc As String
        For Each loc In locations
            lbxLocSelected.Items.Add(loc)
            For ct = lbxLocations.Items.Count - 1 To 0 Step -1
                If lbxLocations.Items(ct).ToString = loc Then lbxLocations.Items.RemoveAt(ct)
            Next
        Next
        RefreshStations()
    End Sub

    Private Sub RefreshStations()
        lbxStations.Enabled = False
        lbxStations.BackColor = SystemColors.InactiveBorder
        lbxStationSelected.Enabled = False
        lbxStationSelected.BackColor = SystemColors.InactiveBorder
        pbxStatAdd.Enabled = False
        pbxStatSub.Enabled = False
        lbxStations.Items.Clear()
        If lbxLocSelected.Items.Count = 0 Then lbxStationSelected.Items.Clear()
        lbxStations.Items.Add("All")
        For ct = 0 To lbxLocSelected.Items.Count - 1
            PopulateStations(lbxLocSelected.Items(ct).ToString)
        Next
    End Sub

    Private Sub PopulateStations(loc)
        DataSets.WasteStationAdapt.Fill(DataSets.WasteStationTable)
        Select Case loc
            Case "Cafes"
                lbxStations.Items.Clear()
                Dim distinctDT As DataTable = DataSets.WasteStationTable.DefaultView.ToTable(True, "station_name")
                distinctDT.DefaultView.Sort = "station_name ASC"
                Dim rv As DataRowView
                For Each rv In distinctDT.DefaultView
                    lbxStations.Items.Add(rv("station_name"))
                Next
                lbxStations.Enabled = True
                lbxStations.BackColor = Color.White
                lbxStationSelected.Enabled = True
                lbxStationSelected.BackColor = Color.White
                pbxStatAdd.Enabled = True
                pbxStatSub.Enabled = True
            Case "Commons", "Eventions", "Catering", "Boardwalk", "In.gredients"
                lbxStationSelected.Items.Clear()
            Case Else
                Dim pcid As Integer = getPCID(loc)
                Dim unit_num As Integer = getUnitNum(pcid)
                Dim dr() As DataRow = DataSets.WasteStationTable.Select("unit_num = '" & unit_num & "'")
                For ct = 0 To dr.Count - 1
                    Dim alreadypresent As Boolean = False, ct1 As Integer, sn As String
                    For ct1 = 0 To lbxStations.Items.Count - 1
                        sn = dr(ct)("station_name")
                        If lbxStations.Items(ct1).ToString = sn Then
                            alreadypresent = True
                            Exit For
                        End If
                    Next
                    If alreadypresent = False Then lbxStations.Items.Add(dr(ct)("station_name"))
                Next
                lbxStations.Enabled = True
                lbxStations.BackColor = Color.White
                lbxStationSelected.Enabled = True
                lbxStationSelected.BackColor = Color.White
                pbxStatAdd.Enabled = True
                pbxStatSub.Enabled = True
        End Select
    End Sub

    Private Sub AssignStations(stationlist)
        lbxStationSelected.Items.Clear()
        Dim stations As String() = stationlist.Split(New Char() {","c})
        Dim station As String = ""
        If stationlist = "None" Then Exit Sub
        For Each station In stations
            lbxStationSelected.Items.Add(station)
            For ct = lbxStations.Items.Count - 1 To 0 Step -1
                If lbxStations.Items(ct).ToString = station Then lbxStations.Items.RemoveAt(ct)
            Next
        Next
    End Sub

    Private Sub RefreshEndTimes()
        Dim holdtime As String = cbxEndTime.Text
        cbxEndTime.Items.Clear()
        cbxEndTime.Enabled = False
        If cbxStartTime.Text = "All Day" Or cbxStartTime.Text = "" Then
            cbxEndTime.Items.Add("All Day")
            cbxEndTime.Text = holdtime
            If cbxStartTime.Text = "All Day" Then cbxEndTime.Text = "All Day"
            Exit Sub
        End If
        For ct = cbxStartTime.SelectedIndex + 1 To cbxStartTime.Items.Count
            If ct = cbxStartTime.Items.Count Then
                cbxEndTime.Items.Add("11:00pm")
            Else
                cbxEndTime.Items.Add(cbxStartTime.Items(ct))
            End If
        Next
        cbxEndTime.Text = cbxEndTime.Items(0)
        '#  Check for presence of held value to proof against artifacting
        If holdtime <> "" Then
            For ct = 0 To cbxEndTime.Items.Count - 1
                If cbxEndTime.Items(ct).ToString = holdtime Then
                    cbxEndTime.Text = holdtime
                    Exit For
                End If
            Next
        End If
        cbxEndTime.Enabled = True
    End Sub

    Private Function getPCID(locname)
        Dim dr() As DataRow = DataSets.PromoLocTable.Select("PromoLocation = '" & locname & "'")
        Return FormatNumber(dr(0)("PCID"), 0)
    End Function

    Private Function getUnitNum(PCID)
        DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
        Dim dr() As DataRow = DataSets.FlashLocationTable.Select("profit_center_id = '" & PCID & "'")
        Return FormatNumber(dr(0)("Unit_Number"), 0)
    End Function

    Private Sub LoadPOSIDList()
        DataSets.PromoPOSAdapt.Fill(DataSets.PromoPOSTable)
        Dim dr() As DataRow = DataSets.PromoPOSTable.Select("PromoID = '" & PromoID & "'")
        dgvPosAssociations.Rows.Clear()
        If dr.Count = 0 Then Exit Sub
        For ct = 0 To dr.Count - 1
            dgvPosAssociations.Rows.Add(dr(ct)("POSID"), "D", "Something")
        Next
        dgvPosAssociations.ClearSelection()
    End Sub

#End Region

End Class