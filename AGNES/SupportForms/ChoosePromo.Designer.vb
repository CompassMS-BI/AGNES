<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoosePromo
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
        Me.components = New System.ComponentModel.Container()
        Me.flpPromotions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblGreet = New System.Windows.Forms.Label()
        Me.cmsPromoChoice = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiClone = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAssignPOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.flpPromotions.SuspendLayout()
        Me.cmsPromoChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpPromotions
        '
        Me.flpPromotions.AutoScroll = True
        Me.flpPromotions.Controls.Add(Me.btnAddNew)
        Me.flpPromotions.Location = New System.Drawing.Point(6, 65)
        Me.flpPromotions.Name = "flpPromotions"
        Me.flpPromotions.Size = New System.Drawing.Size(780, 516)
        Me.flpPromotions.TabIndex = 0
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNew.BackgroundImage = Global.AGNES.My.Resources.Resources.pill_button
        Me.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Yellow
        Me.btnAddNew.Location = New System.Drawing.Point(3, 3)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(230, 75)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "Add New Promo"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'lblGreet
        '
        Me.lblGreet.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreet.Location = New System.Drawing.Point(12, 9)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(774, 53)
        Me.lblGreet.TabIndex = 1
        Me.lblGreet.Text = "Greetings"
        Me.lblGreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmsPromoChoice
        '
        Me.cmsPromoChoice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClone, Me.tsmiAssignPOS})
        Me.cmsPromoChoice.Name = "cmsPromoChoice"
        Me.cmsPromoChoice.Size = New System.Drawing.Size(154, 48)
        '
        'tsmiClone
        '
        Me.tsmiClone.Name = "tsmiClone"
        Me.tsmiClone.Size = New System.Drawing.Size(153, 22)
        Me.tsmiClone.Text = "Clone Promo"
        '
        'tsmiAssignPOS
        '
        Me.tsmiAssignPOS.Enabled = False
        Me.tsmiAssignPOS.Name = "tsmiAssignPOS"
        Me.tsmiAssignPOS.Size = New System.Drawing.Size(153, 22)
        Me.tsmiAssignPOS.Text = "Assign POS IDs"
        '
        'ChoosePromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblGreet)
        Me.Controls.Add(Me.flpPromotions)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "ChoosePromo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.flpPromotions.ResumeLayout(False)
        Me.cmsPromoChoice.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpPromotions As FlowLayoutPanel
    Friend WithEvents lblGreet As Label
    Friend WithEvents btnAddNew As Button
    Friend WithEvents cmsPromoChoice As ContextMenuStrip
    Friend WithEvents tsmiClone As ToolStripMenuItem
    Friend WithEvents tsmiAssignPOS As ToolStripMenuItem
End Class
