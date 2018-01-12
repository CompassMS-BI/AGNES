<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WCR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WCR))
        Me.sstWCR = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriodDays = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeek = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeekDays = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mstWCR = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPasteTenders = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPeriod = New AGNES.PeriodSelector()
        Me.tsmiWeek = New AGNES.WeekSelector()
        Me.tsmiPrevious = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.panTenders = New System.Windows.Forms.Panel()
        Me.dgvTenders = New System.Windows.Forms.DataGridView()
        Me.sstWCR.SuspendLayout()
        Me.mstWCR.SuspendLayout()
        Me.panTenders.SuspendLayout()
        CType(Me.dgvTenders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sstWCR
        '
        Me.sstWCR.BackColor = System.Drawing.Color.AliceBlue
        Me.sstWCR.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstWCR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslFY, Me.tsslPeriod, Me.tsslPeriodDays, Me.tsslWeek, Me.tsslWeekDays, Me.tsslInformation, Me.tsslSaveStatus})
        Me.sstWCR.Location = New System.Drawing.Point(0, 585)
        Me.sstWCR.Name = "sstWCR"
        Me.sstWCR.Size = New System.Drawing.Size(944, 26)
        Me.sstWCR.SizingGrip = False
        Me.sstWCR.TabIndex = 0
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
        '
        'tsslPeriodDays
        '
        Me.tsslPeriodDays.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslPeriodDays.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslPeriodDays.Name = "tsslPeriodDays"
        Me.tsslPeriodDays.Size = New System.Drawing.Size(82, 21)
        Me.tsslPeriodDays.Text = "Period Days"
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
        '
        'tsslWeekDays
        '
        Me.tsslWeekDays.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslWeekDays.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslWeekDays.Name = "tsslWeekDays"
        Me.tsslWeekDays.Size = New System.Drawing.Size(76, 21)
        Me.tsslWeekDays.Text = "Week Days"
        '
        'tsslInformation
        '
        Me.tsslInformation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslInformation.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslInformation.Name = "tsslInformation"
        Me.tsslInformation.Size = New System.Drawing.Size(520, 21)
        Me.tsslInformation.Spring = True
        '
        'tsslSaveStatus
        '
        Me.tsslSaveStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslSaveStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslSaveStatus.Name = "tsslSaveStatus"
        Me.tsslSaveStatus.Size = New System.Drawing.Size(74, 21)
        Me.tsslSaveStatus.Text = "SaveStatus"
        '
        'mstWCR
        '
        Me.mstWCR.BackColor = System.Drawing.Color.AliceBlue
        Me.mstWCR.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstWCR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiPeriod, Me.tsmiWeek, Me.tsmiPrevious, Me.tsmiNext})
        Me.mstWCR.Location = New System.Drawing.Point(0, 0)
        Me.mstWCR.Name = "mstWCR"
        Me.mstWCR.Size = New System.Drawing.Size(944, 25)
        Me.mstWCR.TabIndex = 1
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
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClear, Me.tsmiPasteTenders})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(42, 21)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiClear
        '
        Me.tsmiClear.Name = "tsmiClear"
        Me.tsmiClear.Size = New System.Drawing.Size(158, 22)
        Me.tsmiClear.Text = "Clear All"
        '
        'tsmiPasteTenders
        '
        Me.tsmiPasteTenders.Name = "tsmiPasteTenders"
        Me.tsmiPasteTenders.Size = New System.Drawing.Size(158, 22)
        Me.tsmiPasteTenders.Text = "Paste Tenders"
        '
        'tsmiPeriod
        '
        Me.tsmiPeriod.MaxPeriod = CType(10, Byte)
        Me.tsmiPeriod.Name = "tsmiPeriod"
        Me.tsmiPeriod.Size = New System.Drawing.Size(119, 21)
        Me.tsmiPeriod.Text = "Select MS Period"
        '
        'tsmiWeek
        '
        Me.tsmiWeek.MaxWeek = CType(3, Byte)
        Me.tsmiWeek.Name = "tsmiWeek"
        Me.tsmiWeek.Size = New System.Drawing.Size(90, 21)
        Me.tsmiWeek.Text = "Select Week"
        '
        'tsmiPrevious
        '
        Me.tsmiPrevious.Image = Global.AGNES.My.Resources.Resources.glass_arrow_left
        Me.tsmiPrevious.Name = "tsmiPrevious"
        Me.tsmiPrevious.Size = New System.Drawing.Size(131, 21)
        Me.tsmiPrevious.Text = "Previous Section"
        '
        'tsmiNext
        '
        Me.tsmiNext.Image = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.tsmiNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsmiNext.Name = "tsmiNext"
        Me.tsmiNext.Size = New System.Drawing.Size(109, 21)
        Me.tsmiNext.Text = "Next Section"
        Me.tsmiNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'panTenders
        '
        Me.panTenders.Controls.Add(Me.dgvTenders)
        Me.panTenders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTenders.Location = New System.Drawing.Point(0, 25)
        Me.panTenders.Name = "panTenders"
        Me.panTenders.Size = New System.Drawing.Size(944, 560)
        Me.panTenders.TabIndex = 2
        '
        'dgvTenders
        '
        Me.dgvTenders.AllowUserToAddRows = False
        Me.dgvTenders.AllowUserToDeleteRows = False
        Me.dgvTenders.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvTenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTenders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTenders.Location = New System.Drawing.Point(0, 0)
        Me.dgvTenders.Name = "dgvTenders"
        Me.dgvTenders.RowHeadersVisible = False
        Me.dgvTenders.Size = New System.Drawing.Size(944, 560)
        Me.dgvTenders.TabIndex = 0
        '
        'WCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(944, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.panTenders)
        Me.Controls.Add(Me.sstWCR)
        Me.Controls.Add(Me.mstWCR)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstWCR
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(960, 650)
        Me.MinimumSize = New System.Drawing.Size(960, 650)
        Me.Name = "WCR"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Commons WCR"
        Me.sstWCR.ResumeLayout(False)
        Me.sstWCR.PerformLayout()
        Me.mstWCR.ResumeLayout(False)
        Me.mstWCR.PerformLayout()
        Me.panTenders.ResumeLayout(False)
        CType(Me.dgvTenders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sstWCR As StatusStrip
    Friend WithEvents mstWCR As MenuStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslPeriodDays As ToolStripStatusLabel
    Friend WithEvents tsslWeek As ToolStripStatusLabel
    Friend WithEvents tsslWeekDays As ToolStripStatusLabel
    Friend WithEvents tsslInformation As ToolStripStatusLabel
    Friend WithEvents tsslSaveStatus As ToolStripStatusLabel
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiPeriod As PeriodSelector
    Friend WithEvents tsmiWeek As WeekSelector
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiClear As ToolStripMenuItem
    Friend WithEvents tsmiPrevious As ToolStripMenuItem
    Friend WithEvents tsmiNext As ToolStripMenuItem
    Friend WithEvents panTenders As Panel
    Friend WithEvents dgvTenders As DataGridView
    Friend WithEvents tsmiPasteTenders As ToolStripMenuItem
End Class
