<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Portal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Portal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAnnouncements = New System.Windows.Forms.Label()
        Me.lblTips = New System.Windows.Forms.Label()
        Me.flpModules = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPortalInfo = New System.Windows.Forms.Label()
        Me.pbxGIFAnnouncement = New System.Windows.Forms.PictureBox()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblCloseForm = New System.Windows.Forms.Label()
        Me.mpWindow = New AxWMPLib.AxWindowsMediaPlayer()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGIFAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mpWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(517, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Modules"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.PictureBox1.BackgroundImage = Global.AGNES.My.Resources.Resources.BIGLogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(27, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 63)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Business Intelligence Group" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AGNES Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.OldLace
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(340, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Announcements"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.OldLace
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(340, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tips for using AGNES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnnouncements
        '
        Me.lblAnnouncements.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnnouncements.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnouncements.Location = New System.Drawing.Point(3, 114)
        Me.lblAnnouncements.Name = "lblAnnouncements"
        Me.lblAnnouncements.Size = New System.Drawing.Size(340, 153)
        Me.lblAnnouncements.TabIndex = 5
        Me.lblAnnouncements.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTips
        '
        Me.lblTips.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTips.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTips.Location = New System.Drawing.Point(3, 474)
        Me.lblTips.Name = "lblTips"
        Me.lblTips.Size = New System.Drawing.Size(340, 181)
        Me.lblTips.TabIndex = 6
        Me.lblTips.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'flpModules
        '
        Me.flpModules.BackColor = System.Drawing.Color.OldLace
        Me.flpModules.Location = New System.Drawing.Point(346, 89)
        Me.flpModules.Name = "flpModules"
        Me.flpModules.Size = New System.Drawing.Size(653, 566)
        Me.flpModules.TabIndex = 7
        '
        'lblPortalInfo
        '
        Me.lblPortalInfo.BackColor = System.Drawing.Color.OldLace
        Me.lblPortalInfo.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortalInfo.Location = New System.Drawing.Point(56, 655)
        Me.lblPortalInfo.Name = "lblPortalInfo"
        Me.lblPortalInfo.Size = New System.Drawing.Size(289, 44)
        Me.lblPortalInfo.TabIndex = 8
        '
        'pbxGIFAnnouncement
        '
        Me.pbxGIFAnnouncement.BackColor = System.Drawing.Color.LemonChiffon
        Me.pbxGIFAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxGIFAnnouncement.Location = New System.Drawing.Point(3, 116)
        Me.pbxGIFAnnouncement.Name = "pbxGIFAnnouncement"
        Me.pbxGIFAnnouncement.Size = New System.Drawing.Size(340, 151)
        Me.pbxGIFAnnouncement.TabIndex = 9
        Me.pbxGIFAnnouncement.TabStop = False
        Me.pbxGIFAnnouncement.Visible = False
        '
        'lblMinimize
        '
        Me.lblMinimize.BackColor = System.Drawing.Color.White
        Me.lblMinimize.Font = New System.Drawing.Font("Segoe UI Emoji", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(911, -4)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(34, 48)
        Me.lblMinimize.TabIndex = 10
        Me.lblMinimize.Text = "_"
        Me.lblMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCloseForm
        '
        Me.lblCloseForm.AutoSize = True
        Me.lblCloseForm.BackColor = System.Drawing.Color.White
        Me.lblCloseForm.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseForm.Location = New System.Drawing.Point(951, 12)
        Me.lblCloseForm.Name = "lblCloseForm"
        Me.lblCloseForm.Size = New System.Drawing.Size(30, 32)
        Me.lblCloseForm.TabIndex = 11
        Me.lblCloseForm.Text = "X"
        '
        'mpWindow
        '
        Me.mpWindow.Enabled = True
        Me.mpWindow.Location = New System.Drawing.Point(5, 270)
        Me.mpWindow.Name = "mpWindow"
        Me.mpWindow.OcxState = CType(resources.GetObject("mpWindow.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mpWindow.Size = New System.Drawing.Size(335, 176)
        Me.mpWindow.TabIndex = 12
        '
        'chkMute
        '
        Me.chkMute.AutoSize = True
        Me.chkMute.BackColor = System.Drawing.Color.OldLace
        Me.chkMute.Location = New System.Drawing.Point(887, 666)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(94, 21)
        Me.chkMute.TabIndex = 13
        Me.chkMute.Text = "Shh! (Mute)"
        Me.chkMute.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 180)
        Me.Label5.TabIndex = 7
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Portal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.AGNES.My.Resources.Resources.lgportalbackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkMute)
        Me.Controls.Add(Me.mpWindow)
        Me.Controls.Add(Me.lblCloseForm)
        Me.Controls.Add(Me.lblMinimize)
        Me.Controls.Add(Me.pbxGIFAnnouncement)
        Me.Controls.Add(Me.lblPortalInfo)
        Me.Controls.Add(Me.flpModules)
        Me.Controls.Add(Me.lblTips)
        Me.Controls.Add(Me.lblAnnouncements)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Portal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGNES Portal"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGIFAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mpWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAnnouncements As Label
    Friend WithEvents lblTips As Label
    Friend WithEvents flpModules As FlowLayoutPanel
    Friend WithEvents lblPortalInfo As Label
    Friend WithEvents pbxGIFAnnouncement As PictureBox
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblCloseForm As Label
    Friend WithEvents mpWindow As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents chkMute As CheckBox
    Friend WithEvents Label5 As Label
End Class
