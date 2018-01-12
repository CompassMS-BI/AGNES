<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgnesMsgBox
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
        Me.lblMsgBox = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMsgBox
        '
        Me.lblMsgBox.BackColor = System.Drawing.Color.Aqua
        Me.lblMsgBox.Location = New System.Drawing.Point(24, 9)
        Me.lblMsgBox.Name = "lblMsgBox"
        Me.lblMsgBox.Size = New System.Drawing.Size(237, 80)
        Me.lblMsgBox.TabIndex = 0
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(25, 92)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(105, 92)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(185, 92)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'AgnesMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.AGNES.My.Resources.Resources.agnesmsgbox
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(284, 123)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblMsgBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgnesMsgBox"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AgnesMsgBox"
        Me.TransparencyKey = System.Drawing.Color.Ivory
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMsgBox As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnNo As Button
End Class
