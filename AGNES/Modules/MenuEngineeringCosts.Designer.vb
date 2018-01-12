<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuEngineeringCosts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuEngineeringCosts))
        Me.dgvMenuItems = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessFlashTableAdapter1 = New AGNES.AGNESDataTableAdapters.AccessFlashTableAdapter()
        Me.lblListCount = New System.Windows.Forms.Label()
        Me.cmsItemOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiInactivate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsReactivate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiActivate = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsStationOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MakeStationInactiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStationInactivate = New System.Windows.Forms.Button()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowNC = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowNM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowC = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowI = New System.Windows.Forms.ToolStripMenuItem()
        Me.StationToolStripMenuItem = New System.Windows.Forms.ToolStripTextBox()
        Me.cbxStations = New System.Windows.Forms.ToolStripComboBox()
        Me.msCosting = New System.Windows.Forms.MenuStrip()
        CType(Me.dgvMenuItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsItemOptions.SuspendLayout()
        Me.cmsReactivate.SuspendLayout()
        Me.cmsStationOptions.SuspendLayout()
        Me.msCosting.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMenuItems
        '
        Me.dgvMenuItems.AllowDrop = True
        Me.dgvMenuItems.AllowUserToAddRows = False
        Me.dgvMenuItems.AllowUserToDeleteRows = False
        Me.dgvMenuItems.AllowUserToResizeColumns = False
        Me.dgvMenuItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMenuItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenuItems.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMenuItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenuItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.POSID, Me.WebT, Me.ItemCost})
        Me.dgvMenuItems.Location = New System.Drawing.Point(25, 48)
        Me.dgvMenuItems.Name = "dgvMenuItems"
        Me.dgvMenuItems.RowHeadersVisible = False
        Me.dgvMenuItems.Size = New System.Drawing.Size(563, 682)
        Me.dgvMenuItems.TabIndex = 1
        Me.dgvMenuItems.Visible = False
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Menu Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 280
        '
        'POSID
        '
        Me.POSID.HeaderText = "POS ID #"
        Me.POSID.Name = "POSID"
        Me.POSID.ReadOnly = True
        '
        'WebT
        '
        Me.WebT.HeaderText = "WebT #"
        Me.WebT.Name = "WebT"
        Me.WebT.ReadOnly = True
        Me.WebT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.WebT.Width = 80
        '
        'ItemCost
        '
        Me.ItemCost.HeaderText = "Item Cost"
        Me.ItemCost.MaxInputLength = 8
        Me.ItemCost.Name = "ItemCost"
        Me.ItemCost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemCost.Width = 75
        '
        'AccessFlashTableAdapter1
        '
        Me.AccessFlashTableAdapter1.ClearBeforeFill = True
        '
        'lblListCount
        '
        Me.lblListCount.BackColor = System.Drawing.Color.OldLace
        Me.lblListCount.Location = New System.Drawing.Point(36, 750)
        Me.lblListCount.Name = "lblListCount"
        Me.lblListCount.Size = New System.Drawing.Size(536, 24)
        Me.lblListCount.TabIndex = 2
        Me.lblListCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmsItemOptions
        '
        Me.cmsItemOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInactivate, Me.tsmiImport})
        Me.cmsItemOptions.Name = "ContextMenuStrip1"
        Me.cmsItemOptions.Size = New System.Drawing.Size(240, 48)
        '
        'tsmiInactivate
        '
        Me.tsmiInactivate.Name = "tsmiInactivate"
        Me.tsmiInactivate.Size = New System.Drawing.Size(239, 22)
        Me.tsmiInactivate.Text = "Make item inactive"
        '
        'tsmiImport
        '
        Me.tsmiImport.Name = "tsmiImport"
        Me.tsmiImport.Size = New System.Drawing.Size(239, 22)
        Me.tsmiImport.Text = "Import Cost from Another Item"
        '
        'cmsReactivate
        '
        Me.cmsReactivate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiActivate})
        Me.cmsReactivate.Name = "cmsReactivate"
        Me.cmsReactivate.Size = New System.Drawing.Size(167, 26)
        '
        'tsmiActivate
        '
        Me.tsmiActivate.Name = "tsmiActivate"
        Me.tsmiActivate.Size = New System.Drawing.Size(166, 22)
        Me.tsmiActivate.Text = "Make Item Active"
        '
        'cmsStationOptions
        '
        Me.cmsStationOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeStationInactiveToolStripMenuItem})
        Me.cmsStationOptions.Name = "cmsStationOptions"
        Me.cmsStationOptions.Size = New System.Drawing.Size(188, 26)
        '
        'MakeStationInactiveToolStripMenuItem
        '
        Me.MakeStationInactiveToolStripMenuItem.Name = "MakeStationInactiveToolStripMenuItem"
        Me.MakeStationInactiveToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.MakeStationInactiveToolStripMenuItem.Text = "Make Station Inactive"
        '
        'btnStationInactivate
        '
        Me.btnStationInactivate.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStationInactivate.Location = New System.Drawing.Point(494, 10)
        Me.btnStationInactivate.Name = "btnStationInactivate"
        Me.btnStationInactivate.Size = New System.Drawing.Size(65, 24)
        Me.btnStationInactivate.TabIndex = 3
        Me.btnStationInactivate.Text = "Inactivate"
        Me.btnStationInactivate.UseVisualStyleBackColor = True
        Me.btnStationInactivate.Visible = False
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(152, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiView
        '
        Me.tsmiView.CheckOnClick = True
        Me.tsmiView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiShowAll, Me.tsmiShowNC, Me.tsmiShowNM, Me.tsmiShowC, Me.tsmiShowM, Me.tsmiShowI})
        Me.tsmiView.Name = "tsmiView"
        Me.tsmiView.Size = New System.Drawing.Size(44, 20)
        Me.tsmiView.Text = "View"
        '
        'tsmiShowAll
        '
        Me.tsmiShowAll.Checked = True
        Me.tsmiShowAll.CheckOnClick = True
        Me.tsmiShowAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiShowAll.Name = "tsmiShowAll"
        Me.tsmiShowAll.Size = New System.Drawing.Size(208, 22)
        Me.tsmiShowAll.Text = "Show All"
        '
        'tsmiShowNC
        '
        Me.tsmiShowNC.CheckOnClick = True
        Me.tsmiShowNC.Name = "tsmiShowNC"
        Me.tsmiShowNC.Size = New System.Drawing.Size(208, 22)
        Me.tsmiShowNC.Text = "Show non-costed items"
        '
        'tsmiShowNM
        '
        Me.tsmiShowNM.CheckOnClick = True
        Me.tsmiShowNM.Name = "tsmiShowNM"
        Me.tsmiShowNM.Size = New System.Drawing.Size(208, 22)
        Me.tsmiShowNM.Text = "Show non-mapped items"
        '
        'tsmiShowC
        '
        Me.tsmiShowC.CheckOnClick = True
        Me.tsmiShowC.Name = "tsmiShowC"
        Me.tsmiShowC.Size = New System.Drawing.Size(208, 22)
        Me.tsmiShowC.Text = "Show costed items"
        '
        'tsmiShowM
        '
        Me.tsmiShowM.CheckOnClick = True
        Me.tsmiShowM.Name = "tsmiShowM"
        Me.tsmiShowM.Size = New System.Drawing.Size(208, 22)
        Me.tsmiShowM.Text = "Show mapped items"
        '
        'tsmiShowI
        '
        Me.tsmiShowI.CheckOnClick = True
        Me.tsmiShowI.Name = "tsmiShowI"
        Me.tsmiShowI.Size = New System.Drawing.Size(208, 22)
        Me.tsmiShowI.Text = "Show inactive items"
        '
        'StationToolStripMenuItem
        '
        Me.StationToolStripMenuItem.AutoSize = False
        Me.StationToolStripMenuItem.BackColor = System.Drawing.Color.OldLace
        Me.StationToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StationToolStripMenuItem.Enabled = False
        Me.StationToolStripMenuItem.Name = "StationToolStripMenuItem"
        Me.StationToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.StationToolStripMenuItem.Text = "Station:"
        '
        'cbxStations
        '
        Me.cbxStations.Enabled = False
        Me.cbxStations.Name = "cbxStations"
        Me.cbxStations.Size = New System.Drawing.Size(240, 20)
        '
        'msCosting
        '
        Me.msCosting.AutoSize = False
        Me.msCosting.BackColor = System.Drawing.Color.OldLace
        Me.msCosting.Dock = System.Windows.Forms.DockStyle.None
        Me.msCosting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiView, Me.StationToolStripMenuItem, Me.cbxStations})
        Me.msCosting.Location = New System.Drawing.Point(39, 9)
        Me.msCosting.Name = "msCosting"
        Me.msCosting.Size = New System.Drawing.Size(465, 24)
        Me.msCosting.TabIndex = 0
        Me.msCosting.Text = "MenuStrip1"
        '
        'MenuEngineeringCosts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.AGNES.My.Resources.Resources.CostingBGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.btnStationInactivate)
        Me.Controls.Add(Me.lblListCount)
        Me.Controls.Add(Me.dgvMenuItems)
        Me.Controls.Add(Me.msCosting)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msCosting
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(600, 800)
        Me.MinimumSize = New System.Drawing.Size(600, 800)
        Me.Name = "MenuEngineeringCosts"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuEngineeringCosts"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.dgvMenuItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsItemOptions.ResumeLayout(False)
        Me.cmsReactivate.ResumeLayout(False)
        Me.cmsStationOptions.ResumeLayout(False)
        Me.msCosting.ResumeLayout(False)
        Me.msCosting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccessFlashTableAdapter1 As AGNESDataTableAdapters.AccessFlashTableAdapter
    Friend WithEvents dgvMenuItems As DataGridView
    Friend WithEvents lblListCount As Label
    Friend WithEvents cmsItemOptions As ContextMenuStrip
    Friend WithEvents tsmiInactivate As ToolStripMenuItem
    Friend WithEvents tsmiImport As ToolStripMenuItem
    Friend WithEvents cmsReactivate As ContextMenuStrip
    Friend WithEvents tsmiActivate As ToolStripMenuItem
    Friend WithEvents cmsStationOptions As ContextMenuStrip
    Friend WithEvents MakeStationInactiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStationInactivate As Button
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiView As ToolStripMenuItem
    Friend WithEvents tsmiShowAll As ToolStripMenuItem
    Friend WithEvents tsmiShowNC As ToolStripMenuItem
    Friend WithEvents tsmiShowNM As ToolStripMenuItem
    Friend WithEvents tsmiShowC As ToolStripMenuItem
    Friend WithEvents tsmiShowM As ToolStripMenuItem
    Friend WithEvents tsmiShowI As ToolStripMenuItem
    Friend WithEvents StationToolStripMenuItem As ToolStripTextBox
    Friend WithEvents cbxStations As ToolStripComboBox
    Friend WithEvents msCosting As MenuStrip
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents POSID As DataGridViewTextBoxColumn
    Friend WithEvents WebT As DataGridViewTextBoxColumn
    Friend WithEvents ItemCost As DataGridViewTextBoxColumn
End Class
