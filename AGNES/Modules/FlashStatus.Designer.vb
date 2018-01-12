<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlashStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlashStatus))
        Me.mstFlashStatus = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPeriod = New AGNES.PeriodSelector()
        Me.tsmiWeek = New AGNES.WeekSelector()
        Me.tsmiRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstFlashStatus = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeek = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lvwSubmissions = New System.Windows.Forms.ListView()
        Me.UnitNbr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UnitName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.radSubmitted = New System.Windows.Forms.RadioButton()
        Me.radPending = New System.Windows.Forms.RadioButton()
        Me.lblCurrentView = New System.Windows.Forms.Label()
        Me.mstFlashStatus.SuspendLayout()
        Me.sstFlashStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstFlashStatus
        '
        Me.mstFlashStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.mstFlashStatus.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstFlashStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiPeriod, Me.tsmiWeek, Me.tsmiRefresh})
        Me.mstFlashStatus.Location = New System.Drawing.Point(0, 0)
        Me.mstFlashStatus.Name = "mstFlashStatus"
        Me.mstFlashStatus.Size = New System.Drawing.Size(398, 25)
        Me.mstFlashStatus.TabIndex = 0
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(39, 21)
        Me.tsmiFile.Text = "File"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(96, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiPeriod
        '
        Me.tsmiPeriod.MaxPeriod = CType(4, Byte)
        Me.tsmiPeriod.Name = "tsmiPeriod"
        Me.tsmiPeriod.Size = New System.Drawing.Size(119, 21)
        Me.tsmiPeriod.Text = "Select MS Period"
        '
        'tsmiWeek
        '
        Me.tsmiWeek.MaxWeek = CType(4, Byte)
        Me.tsmiWeek.Name = "tsmiWeek"
        Me.tsmiWeek.Size = New System.Drawing.Size(90, 21)
        Me.tsmiWeek.Text = "Select Week"
        '
        'tsmiRefresh
        '
        Me.tsmiRefresh.Name = "tsmiRefresh"
        Me.tsmiRefresh.Size = New System.Drawing.Size(87, 21)
        Me.tsmiRefresh.Text = "Refresh List"
        '
        'sstFlashStatus
        '
        Me.sstFlashStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.sstFlashStatus.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstFlashStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslFY, Me.tsslPeriod, Me.tsslWeek})
        Me.sstFlashStatus.Location = New System.Drawing.Point(0, 572)
        Me.sstFlashStatus.Name = "sstFlashStatus"
        Me.sstFlashStatus.Size = New System.Drawing.Size(398, 26)
        Me.sstFlashStatus.SizingGrip = False
        Me.sstFlashStatus.TabIndex = 2
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
        Me.tsslPeriod.Size = New System.Drawing.Size(50, 21)
        Me.tsslPeriod.Text = "Period"
        Me.tsslPeriod.Visible = False
        '
        'tsslWeek
        '
        Me.tsslWeek.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslWeek.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslWeek.Name = "tsslWeek"
        Me.tsslWeek.Size = New System.Drawing.Size(44, 21)
        Me.tsslWeek.Text = "Week"
        Me.tsslWeek.Visible = False
        '
        'lvwSubmissions
        '
        Me.lvwSubmissions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.UnitNbr, Me.UnitName})
        Me.lvwSubmissions.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwSubmissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwSubmissions.Location = New System.Drawing.Point(12, 110)
        Me.lvwSubmissions.MultiSelect = False
        Me.lvwSubmissions.Name = "lvwSubmissions"
        Me.lvwSubmissions.Size = New System.Drawing.Size(374, 442)
        Me.lvwSubmissions.TabIndex = 5
        Me.lvwSubmissions.UseCompatibleStateImageBehavior = False
        Me.lvwSubmissions.View = System.Windows.Forms.View.Details
        '
        'UnitNbr
        '
        Me.UnitNbr.Text = "Unit Number"
        Me.UnitNbr.Width = 180
        '
        'UnitName
        '
        Me.UnitName.Text = "Unit Name"
        Me.UnitName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UnitName.Width = 181
        '
        'radSubmitted
        '
        Me.radSubmitted.AutoSize = True
        Me.radSubmitted.Checked = True
        Me.radSubmitted.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSubmitted.Location = New System.Drawing.Point(12, 37)
        Me.radSubmitted.Name = "radSubmitted"
        Me.radSubmitted.Size = New System.Drawing.Size(167, 30)
        Me.radSubmitted.TabIndex = 6
        Me.radSubmitted.TabStop = True
        Me.radSubmitted.Text = "Show Submitted"
        Me.radSubmitted.UseVisualStyleBackColor = True
        '
        'radPending
        '
        Me.radPending.AutoSize = True
        Me.radPending.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPending.Location = New System.Drawing.Point(218, 37)
        Me.radPending.Name = "radPending"
        Me.radPending.Size = New System.Drawing.Size(151, 30)
        Me.radPending.TabIndex = 7
        Me.radPending.Text = "Show Pending"
        Me.radPending.UseVisualStyleBackColor = True
        '
        'lblCurrentView
        '
        Me.lblCurrentView.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentView.Location = New System.Drawing.Point(12, 81)
        Me.lblCurrentView.Name = "lblCurrentView"
        Me.lblCurrentView.Size = New System.Drawing.Size(374, 26)
        Me.lblCurrentView.TabIndex = 8
        Me.lblCurrentView.Text = "Submitted Flash Records"
        Me.lblCurrentView.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FlashStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(398, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCurrentView)
        Me.Controls.Add(Me.radPending)
        Me.Controls.Add(Me.radSubmitted)
        Me.Controls.Add(Me.lvwSubmissions)
        Me.Controls.Add(Me.sstFlashStatus)
        Me.Controls.Add(Me.mstFlashStatus)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstFlashStatus
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 600)
        Me.Name = "FlashStatus"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstFlashStatus.ResumeLayout(False)
        Me.mstFlashStatus.PerformLayout()
        Me.sstFlashStatus.ResumeLayout(False)
        Me.sstFlashStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstFlashStatus As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiPeriod As PeriodSelector
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiWeek As WeekSelector
    Friend WithEvents sstFlashStatus As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslWeek As ToolStripStatusLabel
    Friend WithEvents tsmiRefresh As ToolStripMenuItem
    Friend WithEvents lvwSubmissions As ListView
    Friend WithEvents UnitNbr As ColumnHeader
    Friend WithEvents UnitName As ColumnHeader
    Friend WithEvents radSubmitted As RadioButton
    Friend WithEvents radPending As RadioButton
    Friend WithEvents lblCurrentView As Label
End Class
