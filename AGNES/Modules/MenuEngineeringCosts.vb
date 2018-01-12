Imports System.ComponentModel

Public Class MenuEngineeringCosts
    Private Property ChangesSaved As Boolean = True
    Private Property ynchoice As Boolean
    Private Property un As Integer
    Private Property UnitNum As Integer
        Get
            Return un
        End Get
        Set(value As Integer)
            un = value
            ClearDataGrid()
            With cbxStations
                .Items.Clear()
                .Enabled = False
            End With
            btnStationInactivate.Visible = False
            PopulateStations()
        End Set
    End Property
    Private Property ViewChoice As Byte
    Private Property ViewText As String = " while viewing all items."
    Private Property systemchanges As Boolean
    Private Property AdminAccess As Boolean

#Region "Initialize Module"

    Private Sub LoadMenuEngineering(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.CostingAdapt.Fill(DataSets.CostingTable)
        DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
        DataSets.CostAccessAdapt.Fill(DataSets.CostAccessTable)
        UnitNum = 999
        BuildMIContext()
    End Sub

#End Region

#Region "User interface controls"

    Private Sub SaveWrapper(sender As Object, e As EventArgs) Handles tsmiSave.Click
        If ChangesSaved = True Then Exit Sub
        Dim dr() As DataRow, itemnum As Long, newitemcost As Double, olditemcost As Double
        For ct = 0 To dgvMenuItems.Rows.Count - 1
            itemnum = FormatNumber(dgvMenuItems(1, ct).Value, 0)
            newitemcost = FormatNumber(dgvMenuItems(3, ct).Value, 2)
            If newitemcost = 0 Then newitemcost = -1
            dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and MenuItemId = '" & itemnum & "'") '# Fetch unit specific item datarow
            olditemcost = FormatNumber(dr(0)("ItemCost"), 2)
                If olditemcost <> newitemcost Then                                  '# Check to see if current value <> saved value
                    dr(0)("ItemCost") = newitemcost                                 '# Write current value to saved value column
                    dr(0)("LastItemCost") = olditemcost                             '# Migrate old value to lastvalue
                    dr(0)("ChangedBy") = Environment.UserName                       '# Record who made the change
                    dr(0)("ChangedOn") = Now()                                      '# And timestamp the change
                End If
        Next
        Try
            DataSets.CostingAdapt.Update(DataSets.CostingTable)
        Catch ex As Exception
            Dim errn As Double = Err.Number, errdesc As String = Err.Description
            Dim amsg1 As New AgnesMsgBox("There was a problem saving the data.  Send a screen shot of this msg and notify the BI department if, after trying again in a moment, you are still unable to save.", 2, True, Me.Name)
            amsg1.ShowDialog()
            ynchoice = amsg1.Choicemade
            amsg1.Dispose()
            Exit Sub
        End Try
        ChangesSaved = vbTrue
        Dim amsg As New AgnesMsgBox("Save successful!", 2, False, Me.Name)
        amsg.ShowDialog()
        amsg.Dispose()
    End Sub

    Private Sub QuitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If ChangesSaved = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Close()
        Portal.Show()
    End Sub

    Private Sub SelectView(sender As Object, e As EventArgs) Handles tsmiShowAll.Click, tsmiShowC.Click, tsmiShowM.Click, tsmiShowNC.Click, tsmiShowNM.Click, tsmiShowI.Click
        Dim tempmi As ToolStripMenuItem = sender

        If ChangesSaved = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If

        Select Case tempmi.Name
            Case "tsmiShowAll"
                ViewChoice = 0
                ViewText = " while viewing all items."
                tsmiShowC.Checked = False
                tsmiShowM.Checked = False
                tsmiShowNC.Checked = False
                tsmiShowNM.Checked = False
                tsmiShowI.Checked = False
            Case "tsmiShowNC"
                ViewChoice = 1
                ViewText = " while viewing only non-costed items."
                tsmiShowC.Checked = False
                tsmiShowM.Checked = False
                tsmiShowAll.Checked = False
                tsmiShowNM.Checked = False
                tsmiShowI.Checked = False
            Case "tsmiShowNM"
                ViewChoice = 2
                ViewText = " while viewing only non-mapped items."
                tsmiShowC.Checked = False
                tsmiShowM.Checked = False
                tsmiShowNC.Checked = False
                tsmiShowAll.Checked = False
                tsmiShowI.Checked = False
            Case "tsmiShowC"
                ViewChoice = 3
                ViewText = " while viewing only costed items."
                tsmiShowAll.Checked = False
                tsmiShowM.Checked = False
                tsmiShowNC.Checked = False
                tsmiShowNM.Checked = False
                tsmiShowI.Checked = False
            Case "tsmiShowM"
                ViewChoice = 4
                ViewText = " while viewing only WebT-mapped items."
                tsmiShowC.Checked = False
                tsmiShowAll.Checked = False
                tsmiShowNC.Checked = False
                tsmiShowNM.Checked = False
                tsmiShowI.Checked = False
            Case "tsmiShowI"
                ViewChoice = 5
                ViewText = " while viewing only inactive items."
                tsmiShowC.Checked = False
                tsmiShowAll.Checked = False
                tsmiShowNC.Checked = False
                tsmiShowNM.Checked = False
                tsmiShowM.Checked = False

        End Select

        If ViewChoice = 5 Then
            If btnStationInactivate.Visible = True Then btnStationInactivate.Text = "Activate"
        Else
            If btnStationInactivate.Visible = True Then btnStationInactivate.Text = "Inactivate"
        End If
        If cbxStations.SelectedIndex > -1 Then
            PopulateStations()
            cbxStations.SelectedIndex = 0
            ClearDataGrid()
            PopulateDataGrid(cbxStations.SelectedItem)
        End If

    End Sub

    Private Sub StationChosen(sender As Object, e As EventArgs) Handles cbxStations.SelectedIndexChanged
        btnStationInactivate.Visible = False
        ClearDataGrid()
        If cbxStations.SelectedIndex = -1 Or cbxStations.SelectedItem = "" Then
            dgvMenuItems.Visible = False
            Exit Sub
        End If
        PopulateDataGrid(cbxStations.SelectedItem)
        dgvMenuItems.Visible = True
        If cbxStations.SelectedIndex > 0 Then
            btnStationInactivate.Visible = True
            If ViewChoice = 5 Then
                btnStationInactivate.Text = "Activate"
            Else
                btnStationInactivate.Text = "Inactivate"
            End If
        End If
    End Sub

    Private Sub ClickOnDatacell(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMenuItems.CellMouseClick
        If e.Button = MouseButtons.Left Then Exit Sub
        If ViewChoice < 5 Then
            dgvMenuItems.ContextMenuStrip = cmsItemOptions
        Else
            dgvMenuItems.ContextMenuStrip = cmsReactivate
        End If
    End Sub

    Private Sub cmsItemOptions_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles cmsItemOptions.Closed
        dgvMenuItems.ContextMenuStrip = Nothing
    End Sub

    Private Sub InactivateItem(sender As Object, e As EventArgs) Handles tsmiInactivate.Click
        Dim dr() As DataRow, itemnum As Long
        Try
            itemnum = dgvMenuItems.CurrentRow.Cells(1).Value
            dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and MenuItemId = '" & itemnum & "'") '# Fetch unit specific item datarow
            dr(0)(6) = 1
            DataSets.CostingAdapt.Update(DataSets.CostingTable)
        Catch ex As Exception
        End Try
        ClearDataGrid()
        PopulateDataGrid(cbxStations.SelectedItem)
    End Sub

    Private Sub ActivateItem(sender As Object, e As EventArgs) Handles tsmiActivate.Click
        Dim dr() As DataRow, itemnum As Long
        Try
            itemnum = dgvMenuItems.CurrentRow.Cells(1).Value
            dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and MenuItemId = '" & itemnum & "'") '# Fetch unit specific item datarow
            dr(0)(6) = 0
            DataSets.CostingAdapt.Update(DataSets.CostingTable)
        Catch ex As Exception
        End Try
        ClearDataGrid()
        PopulateDataGrid(cbxStations.SelectedItem)
    End Sub

    Private Sub ToggleStationActivation(sender As Object, e As EventArgs) Handles btnStationInactivate.Click
        If cbxStations.Text = "All" Or cbxStations.Text = "" Then Exit Sub
        Dim dr() As DataRow, stationname As String, togglevalue As Byte = 1
        stationname = cbxStations.Text
        If ViewChoice = 5 Then togglevalue = 0
        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and StationName = '" & stationname & "'") '# Fetch unit specific station datarows
        For ct = 0 To dr.Count - 1
            dr(ct)(6) = togglevalue
        Next

        Try
            DataSets.CostingAdapt.Update(DataSets.CostingTable)
        Catch ex As Exception
            Exit Sub
        End Try
        ClearDataGrid()
        PopulateDataGrid(cbxStations.SelectedItem)

    End Sub

#End Region

#Region "Functions"

    Private Sub ClearDataGrid()
        systemchanges = True
        dgvMenuItems.Rows.Clear()
        systemchanges = False
    End Sub

    Private Sub PopulateStations()
        With cbxStations
            .Items.Clear()
            .Items.Add("All")
            .Enabled = True
            .SelectedIndex = -1
            .Text = ""
        End With
        Dim validdt As New DataView(DataSets.CostingTable)
        If ViewChoice < 5 Then
            validdt.RowFilter = "ProfitCenterID = '" & UnitNum & "' and Invalid = '0'"
        Else
            validdt.RowFilter = "ProfitCenterID = '" & UnitNum & "' and Invalid = '1'"
        End If
        validdt.Sort = "StationName ASC"
        Dim distinctDT As DataTable = validdt.ToTable(True, "StationName")
        For ct = 0 To distinctDT.Rows.Count - 1
            cbxStations.Items.Add(distinctDT(ct)(0))
        Next
        lblListCount.Text = ""
    End Sub

    Private Sub PopulateDataGrid(station)
        systemchanges = True
        Dim dr() As DataRow, itemnm As String, itemid As Long, webt As Double, itemcost As Double
        If station = "All" Then
            Try
                Select Case ViewChoice
                    Case 0  '# View all
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0'")
                    Case 1  '# View non-costed
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and ItemCost = '-1'")
                    Case 2  '# View non-mapped
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and WebT = '-1'")
                    Case 3  '# View costed
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and ItemCost > '-1'")
                    Case 4  '# View mapped
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and WebT > '-1'")
                    Case 5 '# View inactive
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '1'")
                End Select

            Catch ex As Exception
                Exit Sub
            End Try
        Else
            Try
                Select Case ViewChoice
                    Case 0  '# View all
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and StationName = '" & station & "'")
                    Case 1  '# View non-costed
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and StationName = '" & station & "' and ItemCost = '-1'")
                    Case 2  '# View non-mapped
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and StationName = '" & station & "' and WebT = '-1'")
                    Case 3  '# View costed
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and StationName = '" & station & "' and ItemCost > '-1'")
                    Case 4  '# View mapped
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '0' and StationName = '" & station & "' and WebT > '-1'")
                    Case 5 '# View inactive
                        dr = DataSets.CostingTable.Select("ProfitCenterID = '" & UnitNum & "' and Invalid = '1' and StationName = '" & station & "'")
                End Select
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        For ct = 0 To dr.Count - 1
            itemnm = dr(ct)("MenuItemName")
            itemid = dr(ct)("MenuItemID")
            webt = dr(ct)("WebT")
            itemcost = dr(ct)("ItemCost")
            If webt = -1 And itemcost = -1 Then dgvMenuItems.Rows.Add(itemnm, itemid, "", "0")
            If webt = -1 And itemcost <> -1 Then dgvMenuItems.Rows.Add(itemnm, itemid, "", FormatCurrency(itemcost, 2))
            If webt <> -1 And itemcost = -1 Then dgvMenuItems.Rows.Add(itemnm, itemid, webt, "0")
            If webt <> -1 And itemcost <> -1 Then dgvMenuItems.Rows.Add(itemnm, itemid, webt, FormatCurrency(itemcost, 2))
        Next
        lblListCount.Text = Format(dr.Count, "#,###") & " menu items showing" & ViewText
        systemchanges = False
        ChangesSaved = True
    End Sub

    Private Sub CellValidation(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles dgvMenuItems.CellValidating
        If systemchanges = True Or e.ColumnIndex <> 3 Then Exit Sub
        ChangesSaved = False
        dgvMenuItems.Rows(e.RowIndex).ErrorText = ""
        Dim newDouble As Double
        If dgvMenuItems.Rows(e.RowIndex).IsNewRow Then Exit Sub
        If Not Double.TryParse(e.FormattedValue.ToString(), newDouble) _
        OrElse newDouble < 0 Then
            e.Cancel = True
            MsgBox("The cost for " & dgvMenuItems(0, e.RowIndex).Value & " must be a numerical value!")
            dgvMenuItems(3, e.RowIndex).Value = 0
        End If
    End Sub

    Private Sub BuildMIContext()
        Dim ct2 As Integer
        Dim allstations As New DataView(DataSets.CostingTable)
        allstations.Sort = "StationName ASC"
        Dim distinctDT As DataTable = allstations.ToTable(True, "StationName")
        For ct = 0 To distinctDT.Rows.Count - 1
            Dim newStation As ToolStripMenuItem = New ToolStripMenuItem
            tsmiImport.DropDownItems.Add(newStation)
            newStation.Text = distinctDT(ct)(0)
            Dim stationitems As New DataView(DataSets.CostingTable)
            Try
                stationitems.RowFilter = "StationName = '" & distinctDT(ct)(0) & "' and ItemCost > '0'"
                stationitems.Sort = "MenuItemName ASC"
                Dim itemDT As DataTable = stationitems.ToTable(True, "MenuItemName", "ItemCost")
                For ct2 = 0 To itemDT.Rows.Count - 1
                    Dim newitem As ToolStripMenuItem = New ToolStripMenuItem
                    newStation.DropDownItems.Add(newitem)
                    newitem.Text = itemDT(ct2)(0) & " - " & FormatCurrency(itemDT(ct2)(1), 2)
                    newitem.Tag = itemDT(ct2)(1)
                    AddHandler newitem.Click, AddressOf ImportItemSelected
                Next
            Catch ex As Exception
                tsmiImport.DropDownItems.Remove(newStation)
            End Try
        Next
    End Sub

    Private Sub ImportItemSelected(ByVal sender As Object, ByVal e As EventArgs)
        Dim tmpItem As ToolStripMenuItem = sender
        dgvMenuItems.CurrentCell.Value = FormatNumber(tmpItem.Tag, 2)
    End Sub

#End Region

End Class