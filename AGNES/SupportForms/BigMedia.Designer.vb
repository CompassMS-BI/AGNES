<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BigMedia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BigMedia))
        Me.mpBigPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.mpBigPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mpBigPlayer
        '
        Me.mpBigPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mpBigPlayer.Enabled = True
        Me.mpBigPlayer.Location = New System.Drawing.Point(0, 0)
        Me.mpBigPlayer.Name = "mpBigPlayer"
        Me.mpBigPlayer.OcxState = CType(resources.GetObject("mpBigPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mpBigPlayer.Size = New System.Drawing.Size(998, 698)
        Me.mpBigPlayer.TabIndex = 0
        '
        'BigMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(998, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.mpBigPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(998, 698)
        Me.MinimumSize = New System.Drawing.Size(998, 698)
        Me.Name = "BigMedia"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.mpBigPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpBigPlayer As AxWMPLib.AxWindowsMediaPlayer
End Class
