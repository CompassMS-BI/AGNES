<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BVFlash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BVFlash))
        Me.mstBVFlash = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiBevRollup = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPTD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiP12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiWeek = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiW1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiW2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiW3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiW4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiW5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi2627 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi4404 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi17135 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi27076 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi5109 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstBVFlash = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeek = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUnit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsmiUnlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstBVFlash.SuspendLayout()
        Me.sstBVFlash.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstBVFlash
        '
        Me.mstBVFlash.BackColor = System.Drawing.Color.AliceBlue
        Me.mstBVFlash.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstBVFlash.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiUnlock, Me.ViewToolStripMenuItem, Me.tsmiMsp, Me.tsmiWeek, Me.tsmi2627, Me.tsmi4404, Me.tsmi17135, Me.tsmi27076, Me.tsmi5109})
        Me.mstBVFlash.Location = New System.Drawing.Point(0, 0)
        Me.mstBVFlash.Name = "mstBVFlash"
        Me.mstBVFlash.Size = New System.Drawing.Size(958, 25)
        Me.mstBVFlash.TabIndex = 0
        Me.mstBVFlash.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(39, 21)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmiSave.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tsmiExit.Size = New System.Drawing.Size(152, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiBevRollup, Me.tsmiPTD})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'tsmiBevRollup
        '
        Me.tsmiBevRollup.Name = "tsmiBevRollup"
        Me.tsmiBevRollup.Size = New System.Drawing.Size(171, 22)
        Me.tsmiBevRollup.Text = "Beverage Rollup"
        '
        'tsmiPTD
        '
        Me.tsmiPTD.Name = "tsmiPTD"
        Me.tsmiPTD.Size = New System.Drawing.Size(171, 22)
        Me.tsmiPTD.Text = "Period To Date"
        '
        'tsmiMsp
        '
        Me.tsmiMsp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiP1, Me.tsmiP2, Me.tsmiP3, Me.tsmiP4, Me.tsmiP5, Me.tsmiP6, Me.tsmiP7, Me.tsmiP8, Me.tsmiP9, Me.tsmiP10, Me.tsmiP11, Me.tsmiP12})
        Me.tsmiMsp.Name = "tsmiMsp"
        Me.tsmiMsp.Size = New System.Drawing.Size(119, 21)
        Me.tsmiMsp.Text = "Select MS Period"
        '
        'tsmiP1
        '
        Me.tsmiP1.CheckOnClick = True
        Me.tsmiP1.Name = "tsmiP1"
        Me.tsmiP1.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP1.Text = "1"
        '
        'tsmiP2
        '
        Me.tsmiP2.CheckOnClick = True
        Me.tsmiP2.Name = "tsmiP2"
        Me.tsmiP2.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP2.Text = "2"
        '
        'tsmiP3
        '
        Me.tsmiP3.CheckOnClick = True
        Me.tsmiP3.Name = "tsmiP3"
        Me.tsmiP3.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP3.Text = "3"
        '
        'tsmiP4
        '
        Me.tsmiP4.CheckOnClick = True
        Me.tsmiP4.Name = "tsmiP4"
        Me.tsmiP4.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP4.Text = "4"
        '
        'tsmiP5
        '
        Me.tsmiP5.CheckOnClick = True
        Me.tsmiP5.Name = "tsmiP5"
        Me.tsmiP5.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP5.Text = "5"
        '
        'tsmiP6
        '
        Me.tsmiP6.CheckOnClick = True
        Me.tsmiP6.Name = "tsmiP6"
        Me.tsmiP6.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP6.Text = "6"
        '
        'tsmiP7
        '
        Me.tsmiP7.CheckOnClick = True
        Me.tsmiP7.Name = "tsmiP7"
        Me.tsmiP7.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP7.Text = "7"
        '
        'tsmiP8
        '
        Me.tsmiP8.CheckOnClick = True
        Me.tsmiP8.Name = "tsmiP8"
        Me.tsmiP8.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP8.Text = "8"
        '
        'tsmiP9
        '
        Me.tsmiP9.CheckOnClick = True
        Me.tsmiP9.Name = "tsmiP9"
        Me.tsmiP9.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP9.Text = "9"
        '
        'tsmiP10
        '
        Me.tsmiP10.CheckOnClick = True
        Me.tsmiP10.Name = "tsmiP10"
        Me.tsmiP10.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP10.Text = "10"
        '
        'tsmiP11
        '
        Me.tsmiP11.CheckOnClick = True
        Me.tsmiP11.Name = "tsmiP11"
        Me.tsmiP11.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP11.Text = "11"
        '
        'tsmiP12
        '
        Me.tsmiP12.CheckOnClick = True
        Me.tsmiP12.Name = "tsmiP12"
        Me.tsmiP12.Size = New System.Drawing.Size(90, 22)
        Me.tsmiP12.Text = "12"
        '
        'tsmiWeek
        '
        Me.tsmiWeek.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiW1, Me.tsmiW2, Me.tsmiW3, Me.tsmiW4, Me.tsmiW5})
        Me.tsmiWeek.Enabled = False
        Me.tsmiWeek.Name = "tsmiWeek"
        Me.tsmiWeek.Size = New System.Drawing.Size(90, 21)
        Me.tsmiWeek.Text = "Select Week"
        '
        'tsmiW1
        '
        Me.tsmiW1.Name = "tsmiW1"
        Me.tsmiW1.Size = New System.Drawing.Size(83, 22)
        Me.tsmiW1.Text = "1"
        '
        'tsmiW2
        '
        Me.tsmiW2.Name = "tsmiW2"
        Me.tsmiW2.Size = New System.Drawing.Size(83, 22)
        Me.tsmiW2.Text = "2"
        '
        'tsmiW3
        '
        Me.tsmiW3.Name = "tsmiW3"
        Me.tsmiW3.Size = New System.Drawing.Size(83, 22)
        Me.tsmiW3.Text = "3"
        '
        'tsmiW4
        '
        Me.tsmiW4.Name = "tsmiW4"
        Me.tsmiW4.Size = New System.Drawing.Size(83, 22)
        Me.tsmiW4.Text = "4"
        '
        'tsmiW5
        '
        Me.tsmiW5.Name = "tsmiW5"
        Me.tsmiW5.Size = New System.Drawing.Size(83, 22)
        Me.tsmiW5.Text = "5"
        '
        'tsmi2627
        '
        Me.tsmi2627.Enabled = False
        Me.tsmi2627.Name = "tsmi2627"
        Me.tsmi2627.Size = New System.Drawing.Size(72, 21)
        Me.tsmi2627.Text = "Bev 2627"
        '
        'tsmi4404
        '
        Me.tsmi4404.BackColor = System.Drawing.Color.AliceBlue
        Me.tsmi4404.Enabled = False
        Me.tsmi4404.Name = "tsmi4404"
        Me.tsmi4404.Size = New System.Drawing.Size(95, 21)
        Me.tsmi4404.Text = "Bev OH 4404"
        '
        'tsmi17135
        '
        Me.tsmi17135.Enabled = False
        Me.tsmi17135.Name = "tsmi17135"
        Me.tsmi17135.Size = New System.Drawing.Size(85, 21)
        Me.tsmi17135.Text = "ICup 17135"
        '
        'tsmi27076
        '
        Me.tsmi27076.Enabled = False
        Me.tsmi27076.Name = "tsmi27076"
        Me.tsmi27076.Size = New System.Drawing.Size(74, 21)
        Me.tsmi27076.Text = "IW 27076"
        '
        'tsmi5109
        '
        Me.tsmi5109.Enabled = False
        Me.tsmi5109.Name = "tsmi5109"
        Me.tsmi5109.Size = New System.Drawing.Size(82, 21)
        Me.tsmi5109.Text = "Vend 5109"
        '
        'sstBVFlash
        '
        Me.sstBVFlash.BackColor = System.Drawing.Color.AliceBlue
        Me.sstBVFlash.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstBVFlash.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslFY, Me.tsslPeriod, Me.tsslWeek, Me.tsslUnit, Me.tsslInformation, Me.tsslSaveStatus})
        Me.sstBVFlash.Location = New System.Drawing.Point(0, 692)
        Me.sstBVFlash.Name = "sstBVFlash"
        Me.sstBVFlash.Size = New System.Drawing.Size(958, 26)
        Me.sstBVFlash.SizingGrip = False
        Me.sstBVFlash.TabIndex = 1
        Me.sstBVFlash.Text = "StatusStrip1"
        '
        'tsslUser
        '
        Me.tsslUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUser.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslUser.Name = "tsslUser"
        Me.tsslUser.Size = New System.Drawing.Size(39, 21)
        Me.tsslUser.Text = "User"
        '
        'tsslFY
        '
        Me.tsslFY.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslFY.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslFY.Name = "tsslFY"
        Me.tsslFY.Size = New System.Drawing.Size(44, 21)
        Me.tsslFY.Text = "FYear"
        '
        'tsslPeriod
        '
        Me.tsslPeriod.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslPeriod.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslPeriod.Name = "tsslPeriod"
        Me.tsslPeriod.Size = New System.Drawing.Size(4, 21)
        Me.tsslPeriod.Visible = False
        '
        'tsslWeek
        '
        Me.tsslWeek.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslWeek.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslWeek.Name = "tsslWeek"
        Me.tsslWeek.Size = New System.Drawing.Size(4, 21)
        Me.tsslWeek.Visible = False
        '
        'tsslUnit
        '
        Me.tsslUnit.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUnit.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslUnit.Name = "tsslUnit"
        Me.tsslUnit.Size = New System.Drawing.Size(35, 21)
        Me.tsslUnit.Text = "Unit"
        Me.tsslUnit.Visible = False
        '
        'tsslInformation
        '
        Me.tsslInformation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslInformation.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslInformation.Name = "tsslInformation"
        Me.tsslInformation.Size = New System.Drawing.Size(789, 21)
        Me.tsslInformation.Spring = True
        '
        'tsslSaveStatus
        '
        Me.tsslSaveStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslSaveStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslSaveStatus.Name = "tsslSaveStatus"
        Me.tsslSaveStatus.Size = New System.Drawing.Size(71, 21)
        Me.tsslSaveStatus.Text = "New Flash"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(469, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 35)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Variance"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(281, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 35)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Budget"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 35)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Flash"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsmiUnlock
        '
        Me.tsmiUnlock.Enabled = False
        Me.tsmiUnlock.Name = "tsmiUnlock"
        Me.tsmiUnlock.Size = New System.Drawing.Size(92, 21)
        Me.tsmiUnlock.Text = "Unlock Flash"
        Me.tsmiUnlock.Visible = False
        '
        'BVFlash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(958, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sstBVFlash)
        Me.Controls.Add(Me.mstBVFlash)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstBVFlash
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(960, 720)
        Me.MinimumSize = New System.Drawing.Size(960, 720)
        Me.Name = "BVFlash"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstBVFlash.ResumeLayout(False)
        Me.mstBVFlash.PerformLayout()
        Me.sstBVFlash.ResumeLayout(False)
        Me.sstBVFlash.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstBVFlash As MenuStrip
    Friend WithEvents sstBVFlash As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslWeek As ToolStripStatusLabel
    Friend WithEvents tsslInformation As ToolStripStatusLabel
    Friend WithEvents tsslSaveStatus As ToolStripStatusLabel
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiMsp As ToolStripMenuItem
    Friend WithEvents tsmiP1 As ToolStripMenuItem
    Friend WithEvents tsmiP2 As ToolStripMenuItem
    Friend WithEvents tsmiP3 As ToolStripMenuItem
    Friend WithEvents tsmiP4 As ToolStripMenuItem
    Friend WithEvents tsmiP5 As ToolStripMenuItem
    Friend WithEvents tsmiP6 As ToolStripMenuItem
    Friend WithEvents tsmiP7 As ToolStripMenuItem
    Friend WithEvents tsmiP8 As ToolStripMenuItem
    Friend WithEvents tsmiP9 As ToolStripMenuItem
    Friend WithEvents tsmiP10 As ToolStripMenuItem
    Friend WithEvents tsmiP11 As ToolStripMenuItem
    Friend WithEvents tsmiP12 As ToolStripMenuItem
    Friend WithEvents tsmiWeek As ToolStripMenuItem
    Friend WithEvents tsmiW1 As ToolStripMenuItem
    Friend WithEvents tsmiW2 As ToolStripMenuItem
    Friend WithEvents tsmiW3 As ToolStripMenuItem
    Friend WithEvents tsmiW4 As ToolStripMenuItem
    Friend WithEvents tsmiW5 As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsmi2627 As ToolStripMenuItem
    Friend WithEvents tsmi4404 As ToolStripMenuItem
    Friend WithEvents tsmi17135 As ToolStripMenuItem
    Friend WithEvents tsmi27076 As ToolStripMenuItem
    Friend WithEvents tsmi5109 As ToolStripMenuItem
    Friend WithEvents tsslUnit As ToolStripStatusLabel
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiBevRollup As ToolStripMenuItem
    Friend WithEvents tsmiPTD As ToolStripMenuItem
    Friend WithEvents tsmiUnlock As ToolStripMenuItem
End Class
