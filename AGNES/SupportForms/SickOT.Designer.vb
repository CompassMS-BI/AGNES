<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SickOT
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.fuvOT = New AGNES.FlashUserValue()
        Me.fuvSick = New AGNES.FlashUserValue()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sick Dollars"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OT Dollars"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(16, 116)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "OK"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(143, 116)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'fuvOT
        '
        Me.fuvOT.AllowCredit = False
        Me.fuvOT.Debit = True
        Me.fuvOT.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.fuvOT.Location = New System.Drawing.Point(118, 67)
        Me.fuvOT.Name = "fuvOT"
        Me.fuvOT.OpenValue = False
        Me.fuvOT.PosNegFont = False
        Me.fuvOT.Size = New System.Drawing.Size(100, 29)
        Me.fuvOT.TabIndex = 1
        Me.fuvOT.Text = "$0.00"
        Me.fuvOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fuvSick
        '
        Me.fuvSick.AllowCredit = False
        Me.fuvSick.Debit = True
        Me.fuvSick.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.fuvSick.Location = New System.Drawing.Point(118, 20)
        Me.fuvSick.Name = "fuvSick"
        Me.fuvSick.OpenValue = False
        Me.fuvSick.PosNegFont = False
        Me.fuvSick.Size = New System.Drawing.Size(100, 29)
        Me.fuvSick.TabIndex = 0
        Me.fuvSick.Text = "$0.00"
        Me.fuvSick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SickOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(237, 151)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fuvOT)
        Me.Controls.Add(Me.fuvSick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SickOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SickOT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fuvSick As FlashUserValue
    Friend WithEvents fuvOT As FlashUserValue
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
