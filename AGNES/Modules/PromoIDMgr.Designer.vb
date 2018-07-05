<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoIDMgr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromoIDMgr))
        Me.mstPromoID = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAllPromos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUnassociated = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAssociated = New System.Windows.Forms.ToolStripMenuItem()
        Me.radPOS = New System.Windows.Forms.RadioButton()
        Me.radDisc = New System.Windows.Forms.RadioButton()
        Me.sstPOSEditor = New System.Windows.Forms.StatusStrip()
        Me.tsslPromo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbxPromoList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPOSIDs = New System.Windows.Forms.DataGridView()
        Me.POS_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSID_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAssociatedID = New AGNES.AgnesTxt()
        Me.mstPromoID.SuspendLayout()
        Me.sstPOSEditor.SuspendLayout()
        CType(Me.dgvPOSIDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mstPromoID
        '
        Me.mstPromoID.BackColor = System.Drawing.Color.AliceBlue
        Me.mstPromoID.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiView})
        Me.mstPromoID.Location = New System.Drawing.Point(0, 0)
        Me.mstPromoID.Name = "mstPromoID"
        Me.mstPromoID.Size = New System.Drawing.Size(384, 24)
        Me.mstPromoID.TabIndex = 0
        Me.mstPromoID.Text = "MenuStrip1"
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
        Me.tsmiSave.Size = New System.Drawing.Size(98, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(98, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiView
        '
        Me.tsmiView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAllPromos, Me.tsmiUnassociated, Me.tsmiAssociated})
        Me.tsmiView.Name = "tsmiView"
        Me.tsmiView.Size = New System.Drawing.Size(44, 20)
        Me.tsmiView.Text = "View"
        '
        'tsmiAllPromos
        '
        Me.tsmiAllPromos.Checked = True
        Me.tsmiAllPromos.CheckOnClick = True
        Me.tsmiAllPromos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiAllPromos.Name = "tsmiAllPromos"
        Me.tsmiAllPromos.Size = New System.Drawing.Size(223, 22)
        Me.tsmiAllPromos.Text = "All"
        '
        'tsmiUnassociated
        '
        Me.tsmiUnassociated.CheckOnClick = True
        Me.tsmiUnassociated.Name = "tsmiUnassociated"
        Me.tsmiUnassociated.Size = New System.Drawing.Size(223, 22)
        Me.tsmiUnassociated.Text = "Promos without Association"
        '
        'tsmiAssociated
        '
        Me.tsmiAssociated.CheckOnClick = True
        Me.tsmiAssociated.Name = "tsmiAssociated"
        Me.tsmiAssociated.Size = New System.Drawing.Size(223, 22)
        Me.tsmiAssociated.Text = "Promos with Association"
        '
        'radPOS
        '
        Me.radPOS.AutoSize = True
        Me.radPOS.Checked = True
        Me.radPOS.Location = New System.Drawing.Point(12, 231)
        Me.radPOS.Name = "radPOS"
        Me.radPOS.Size = New System.Drawing.Size(66, 21)
        Me.radPOS.TabIndex = 1
        Me.radPOS.TabStop = True
        Me.radPOS.Text = "POS ID"
        Me.radPOS.UseVisualStyleBackColor = True
        '
        'radDisc
        '
        Me.radDisc.AutoSize = True
        Me.radDisc.Location = New System.Drawing.Point(12, 255)
        Me.radDisc.Name = "radDisc"
        Me.radDisc.Size = New System.Drawing.Size(92, 21)
        Me.radDisc.TabIndex = 2
        Me.radDisc.Text = "Discount ID"
        Me.radDisc.UseVisualStyleBackColor = True
        '
        'sstPOSEditor
        '
        Me.sstPOSEditor.BackColor = System.Drawing.Color.AliceBlue
        Me.sstPOSEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslPromo, Me.tsslStatus})
        Me.sstPOSEditor.Location = New System.Drawing.Point(0, 539)
        Me.sstPOSEditor.Name = "sstPOSEditor"
        Me.sstPOSEditor.Size = New System.Drawing.Size(384, 22)
        Me.sstPOSEditor.SizingGrip = False
        Me.sstPOSEditor.Stretch = False
        Me.sstPOSEditor.TabIndex = 6
        Me.sstPOSEditor.Text = "StatusStrip1"
        '
        'tsslPromo
        '
        Me.tsslPromo.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslPromo.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslPromo.Name = "tsslPromo"
        Me.tsslPromo.Size = New System.Drawing.Size(4, 17)
        '
        'tsslStatus
        '
        Me.tsslStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(4, 17)
        '
        'lbxPromoList
        '
        Me.lbxPromoList.BackColor = System.Drawing.Color.White
        Me.lbxPromoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxPromoList.FormattingEnabled = True
        Me.lbxPromoList.ItemHeight = 17
        Me.lbxPromoList.Location = New System.Drawing.Point(13, 63)
        Me.lbxPromoList.Name = "lbxPromoList"
        Me.lbxPromoList.Size = New System.Drawing.Size(359, 155)
        Me.lbxPromoList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 27)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "POS IDs Assigned"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 27)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Promotion Names"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPOSIDs
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Format = "D"
        Me.dgvPOSIDs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPOSIDs.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvPOSIDs.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPOSIDs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPOSIDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPOSIDs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POS_ID, Me.POSID_Type})
        Me.dgvPOSIDs.Enabled = False
        Me.dgvPOSIDs.Location = New System.Drawing.Point(40, 305)
        Me.dgvPOSIDs.Name = "dgvPOSIDs"
        Me.dgvPOSIDs.RowHeadersVisible = False
        Me.dgvPOSIDs.Size = New System.Drawing.Size(333, 210)
        Me.dgvPOSIDs.TabIndex = 4
        '
        'POS_ID
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "D"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.POS_ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.POS_ID.Frozen = True
        Me.POS_ID.HeaderText = "POS or Discount ID"
        Me.POS_ID.MaxInputLength = 12
        Me.POS_ID.Name = "POS_ID"
        Me.POS_ID.ReadOnly = True
        Me.POS_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.POS_ID.Width = 180
        '
        'POSID_Type
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSID_Type.DefaultCellStyle = DataGridViewCellStyle4
        Me.POSID_Type.Frozen = True
        Me.POSID_Type.HeaderText = "POS/Discount"
        Me.POSID_Type.MaxInputLength = 1
        Me.POSID_Type.Name = "POSID_Type"
        Me.POSID_Type.ReadOnly = True
        Me.POSID_Type.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.POSID_Type.Width = 120
        '
        'txtAssociatedID
        '
        Me.txtAssociatedID.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssociatedID.Location = New System.Drawing.Point(112, 233)
        Me.txtAssociatedID.MaxLength = 24
        Me.txtAssociatedID.Name = "txtAssociatedID"
        Me.txtAssociatedID.Size = New System.Drawing.Size(260, 39)
        Me.txtAssociatedID.TabIndex = 3
        Me.txtAssociatedID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PromoIDMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvPOSIDs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxPromoList)
        Me.Controls.Add(Me.sstPOSEditor)
        Me.Controls.Add(Me.txtAssociatedID)
        Me.Controls.Add(Me.radDisc)
        Me.Controls.Add(Me.radPOS)
        Me.Controls.Add(Me.mstPromoID)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstPromoID
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PromoIDMgr"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstPromoID.ResumeLayout(False)
        Me.mstPromoID.PerformLayout()
        Me.sstPOSEditor.ResumeLayout(False)
        Me.sstPOSEditor.PerformLayout()
        CType(Me.dgvPOSIDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstPromoID As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiView As ToolStripMenuItem
    Friend WithEvents tsmiUnassociated As ToolStripMenuItem
    Friend WithEvents tsmiAssociated As ToolStripMenuItem
    Friend WithEvents tsmiAllPromos As ToolStripMenuItem
    Friend WithEvents radPOS As RadioButton
    Friend WithEvents radDisc As RadioButton
    Friend WithEvents txtAssociatedID As AgnesTxt
    Friend WithEvents sstPOSEditor As StatusStrip
    Friend WithEvents tsslPromo As ToolStripStatusLabel
    Friend WithEvents lbxPromoList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPOSIDs As DataGridView
    Friend WithEvents POS_ID As DataGridViewTextBoxColumn
    Friend WithEvents POSID_Type As DataGridViewTextBoxColumn
    Friend WithEvents tsslStatus As ToolStripStatusLabel
End Class
