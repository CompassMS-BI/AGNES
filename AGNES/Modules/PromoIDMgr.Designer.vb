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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromoIDMgr))
        Me.mstPromoID = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUnassociated = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAssociated = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAllPromos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPromos = New System.Windows.Forms.DataGridView()
        Me.dgvAssociations = New System.Windows.Forms.DataGridView()
        Me.radPOS = New System.Windows.Forms.RadioButton()
        Me.radDisc = New System.Windows.Forms.RadioButton()
        Me.txtAssociatedID = New AGNES.AgnesTxt()
        Me.mstPromoID.SuspendLayout()
        CType(Me.dgvPromos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAssociations, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tsmiView
        '
        Me.tsmiView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAssociated, Me.tsmiUnassociated, Me.tsmiAllPromos})
        Me.tsmiView.Name = "tsmiView"
        Me.tsmiView.Size = New System.Drawing.Size(44, 20)
        Me.tsmiView.Text = "View"
        '
        'tsmiUnassociated
        '
        Me.tsmiUnassociated.CheckOnClick = True
        Me.tsmiUnassociated.Name = "tsmiUnassociated"
        Me.tsmiUnassociated.Size = New System.Drawing.Size(223, 22)
        Me.tsmiUnassociated.Text = "Promos with Association"
        '
        'tsmiAssociated
        '
        Me.tsmiAssociated.Checked = True
        Me.tsmiAssociated.CheckOnClick = True
        Me.tsmiAssociated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiAssociated.Name = "tsmiAssociated"
        Me.tsmiAssociated.Size = New System.Drawing.Size(223, 22)
        Me.tsmiAssociated.Text = "Promos without Association"
        '
        'tsmiAllPromos
        '
        Me.tsmiAllPromos.CheckOnClick = True
        Me.tsmiAllPromos.Name = "tsmiAllPromos"
        Me.tsmiAllPromos.Size = New System.Drawing.Size(223, 22)
        Me.tsmiAllPromos.Text = "All"
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
        'dgvPromos
        '
        Me.dgvPromos.AllowUserToAddRows = False
        Me.dgvPromos.AllowUserToDeleteRows = False
        Me.dgvPromos.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromos.Location = New System.Drawing.Point(13, 47)
        Me.dgvPromos.Name = "dgvPromos"
        Me.dgvPromos.ReadOnly = True
        Me.dgvPromos.Size = New System.Drawing.Size(359, 150)
        Me.dgvPromos.TabIndex = 1
        '
        'dgvAssociations
        '
        Me.dgvAssociations.AllowUserToAddRows = False
        Me.dgvAssociations.AllowUserToDeleteRows = False
        Me.dgvAssociations.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvAssociations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssociations.Location = New System.Drawing.Point(13, 257)
        Me.dgvAssociations.Name = "dgvAssociations"
        Me.dgvAssociations.ReadOnly = True
        Me.dgvAssociations.Size = New System.Drawing.Size(359, 292)
        Me.dgvAssociations.TabIndex = 2
        '
        'radPOS
        '
        Me.radPOS.AutoSize = True
        Me.radPOS.Location = New System.Drawing.Point(280, 203)
        Me.radPOS.Name = "radPOS"
        Me.radPOS.Size = New System.Drawing.Size(66, 21)
        Me.radPOS.TabIndex = 3
        Me.radPOS.TabStop = True
        Me.radPOS.Text = "POS ID"
        Me.radPOS.UseVisualStyleBackColor = True
        '
        'radDisc
        '
        Me.radDisc.AutoSize = True
        Me.radDisc.Location = New System.Drawing.Point(280, 230)
        Me.radDisc.Name = "radDisc"
        Me.radDisc.Size = New System.Drawing.Size(92, 21)
        Me.radDisc.TabIndex = 4
        Me.radDisc.TabStop = True
        Me.radDisc.Text = "Discount ID"
        Me.radDisc.UseVisualStyleBackColor = True
        '
        'txtAssociatedID
        '
        Me.txtAssociatedID.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssociatedID.Location = New System.Drawing.Point(13, 207)
        Me.txtAssociatedID.MaxLength = 24
        Me.txtAssociatedID.Name = "txtAssociatedID"
        Me.txtAssociatedID.Size = New System.Drawing.Size(261, 39)
        Me.txtAssociatedID.TabIndex = 5
        Me.txtAssociatedID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PromoIDMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAssociatedID)
        Me.Controls.Add(Me.radDisc)
        Me.Controls.Add(Me.radPOS)
        Me.Controls.Add(Me.dgvAssociations)
        Me.Controls.Add(Me.dgvPromos)
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
        CType(Me.dgvPromos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAssociations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstPromoID As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiView As ToolStripMenuItem
    Friend WithEvents tsmiAssociated As ToolStripMenuItem
    Friend WithEvents tsmiUnassociated As ToolStripMenuItem
    Friend WithEvents tsmiAllPromos As ToolStripMenuItem
    Friend WithEvents dgvPromos As DataGridView
    Friend WithEvents dgvAssociations As DataGridView
    Friend WithEvents radPOS As RadioButton
    Friend WithEvents radDisc As RadioButton
    Friend WithEvents txtAssociatedID As AgnesTxt
End Class
