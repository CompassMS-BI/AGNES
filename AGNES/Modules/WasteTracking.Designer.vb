<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WasteTracking
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WasteTracking))
        Me.panStations = New System.Windows.Forms.Panel()
        Me.mstWasteTracker = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiChangeName = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNewStation = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUnlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMSP = New AGNES.PeriodSelector()
        Me.tsmiWeek = New AGNES.WeekSelector()
        Me.tsmiStations = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiWasteType = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstWasteTracker = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUnit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeek = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslStation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chtWastePie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panCampus = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panStationWaste = New System.Windows.Forms.Panel()
        Me.panRollingBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panPerCheck = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.panAnalytics = New System.Windows.Forms.Panel()
        Me.mstWasteTracker.SuspendLayout()
        Me.sstWasteTracker.SuspendLayout()
        CType(Me.chtWastePie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panCampus.SuspendLayout()
        Me.panStationWaste.SuspendLayout()
        Me.panRollingBar.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panPerCheck.SuspendLayout()
        Me.panAnalytics.SuspendLayout()
        Me.SuspendLayout()
        '
        'panStations
        '
        Me.panStations.AutoScroll = True
        Me.panStations.Location = New System.Drawing.Point(0, 27)
        Me.panStations.Name = "panStations"
        Me.panStations.Size = New System.Drawing.Size(494, 604)
        Me.panStations.TabIndex = 0
        '
        'mstWasteTracker
        '
        Me.mstWasteTracker.BackColor = System.Drawing.Color.AliceBlue
        Me.mstWasteTracker.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstWasteTracker.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mstWasteTracker.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiMSP, Me.tsmiWeek, Me.tsmiStations, Me.tsmiWasteType})
        Me.mstWasteTracker.Location = New System.Drawing.Point(0, 0)
        Me.mstWasteTracker.Name = "mstWasteTracker"
        Me.mstWasteTracker.Size = New System.Drawing.Size(898, 25)
        Me.mstWasteTracker.TabIndex = 1
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
        Me.tsmiSave.Size = New System.Drawing.Size(103, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(103, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiChangeName, Me.tsmiNewStation, Me.tsmiUnlock})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(42, 21)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiChangeName
        '
        Me.tsmiChangeName.Name = "tsmiChangeName"
        Me.tsmiChangeName.Size = New System.Drawing.Size(203, 22)
        Me.tsmiChangeName.Text = "Change Station Name"
        '
        'tsmiNewStation
        '
        Me.tsmiNewStation.Name = "tsmiNewStation"
        Me.tsmiNewStation.Size = New System.Drawing.Size(203, 22)
        Me.tsmiNewStation.Text = "Add New Station"
        '
        'tsmiUnlock
        '
        Me.tsmiUnlock.Name = "tsmiUnlock"
        Me.tsmiUnlock.Size = New System.Drawing.Size(203, 22)
        Me.tsmiUnlock.Text = "Unlock Week"
        '
        'tsmiMSP
        '
        Me.tsmiMSP.MaxPeriod = CType(9, Byte)
        Me.tsmiMSP.MSP = CType(0, Byte)
        Me.tsmiMSP.Name = "tsmiMSP"
        Me.tsmiMSP.Size = New System.Drawing.Size(119, 21)
        Me.tsmiMSP.Text = "Select MS Period"
        '
        'tsmiWeek
        '
        Me.tsmiWeek.MaxWeek = CType(4, Byte)
        Me.tsmiWeek.Name = "tsmiWeek"
        Me.tsmiWeek.Size = New System.Drawing.Size(90, 21)
        Me.tsmiWeek.Text = "Select Week"
        '
        'tsmiStations
        '
        Me.tsmiStations.CheckOnClick = True
        Me.tsmiStations.Name = "tsmiStations"
        Me.tsmiStations.Size = New System.Drawing.Size(98, 21)
        Me.tsmiStations.Text = "Select Station"
        '
        'tsmiWasteType
        '
        Me.tsmiWasteType.Enabled = False
        Me.tsmiWasteType.Name = "tsmiWasteType"
        Me.tsmiWasteType.Size = New System.Drawing.Size(126, 21)
        Me.tsmiWasteType.Text = "Select Waste Type"
        '
        'sstWasteTracker
        '
        Me.sstWasteTracker.BackColor = System.Drawing.Color.AliceBlue
        Me.sstWasteTracker.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstWasteTracker.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.sstWasteTracker.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslUnit, Me.tsslFY, Me.tsslPeriod, Me.tsslWeek, Me.tsslStation, Me.tsslStatus})
        Me.sstWasteTracker.Location = New System.Drawing.Point(0, 572)
        Me.sstWasteTracker.Name = "sstWasteTracker"
        Me.sstWasteTracker.Size = New System.Drawing.Size(898, 26)
        Me.sstWasteTracker.SizingGrip = False
        Me.sstWasteTracker.TabIndex = 2
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
        'tsslUnit
        '
        Me.tsslUnit.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUnit.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslUnit.Name = "tsslUnit"
        Me.tsslUnit.Size = New System.Drawing.Size(35, 21)
        Me.tsslUnit.Text = "Unit"
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
        '
        'tsslStation
        '
        Me.tsslStation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslStation.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslStation.Name = "tsslStation"
        Me.tsslStation.Size = New System.Drawing.Size(52, 21)
        Me.tsslStation.Text = "Station"
        '
        'tsslStatus
        '
        Me.tsslStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(47, 21)
        Me.tsslStatus.Text = "Status"
        '
        'chtWastePie
        '
        Me.chtWastePie.BackColor = System.Drawing.Color.OldLace
        ChartArea1.Name = "ChartArea1"
        Me.chtWastePie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtWastePie.Legends.Add(Legend1)
        Me.chtWastePie.Location = New System.Drawing.Point(-1, 39)
        Me.chtWastePie.Name = "chtWastePie"
        Me.chtWastePie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "StationMix"
        Me.chtWastePie.Series.Add(Series1)
        Me.chtWastePie.Size = New System.Drawing.Size(369, 214)
        Me.chtWastePie.TabIndex = 4
        Me.chtWastePie.Text = "Chart2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SpringGreen
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "% of Waste By Station"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panCampus
        '
        Me.panCampus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panCampus.Controls.Add(Me.Label4)
        Me.panCampus.Controls.Add(Me.Label3)
        Me.panCampus.Location = New System.Drawing.Point(3, 490)
        Me.panCampus.Name = "panCampus"
        Me.panCampus.Size = New System.Drawing.Size(188, 108)
        Me.panCampus.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 68)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "In development"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SpringGreen
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 34)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Avg Campus Waste"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panStationWaste
        '
        Me.panStationWaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panStationWaste.Controls.Add(Me.chtWastePie)
        Me.panStationWaste.Controls.Add(Me.Label1)
        Me.panStationWaste.Location = New System.Drawing.Point(3, 3)
        Me.panStationWaste.Name = "panStationWaste"
        Me.panStationWaste.Size = New System.Drawing.Size(369, 255)
        Me.panStationWaste.TabIndex = 10
        '
        'panRollingBar
        '
        Me.panRollingBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panRollingBar.Controls.Add(Me.Label2)
        Me.panRollingBar.Controls.Add(Me.Chart1)
        Me.panRollingBar.Location = New System.Drawing.Point(3, 263)
        Me.panRollingBar.Name = "panRollingBar"
        Me.panRollingBar.Size = New System.Drawing.Size(369, 221)
        Me.panRollingBar.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SpringGreen
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 34)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Station Waste by Week"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.OldLace
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(-1, 36)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series2.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.ChartArea = "ChartArea1"
        Series2.IsVisibleInLegend = False
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(369, 184)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'panPerCheck
        '
        Me.panPerCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panPerCheck.Controls.Add(Me.Label37)
        Me.panPerCheck.Controls.Add(Me.Label38)
        Me.panPerCheck.Location = New System.Drawing.Point(197, 490)
        Me.panPerCheck.Name = "panPerCheck"
        Me.panPerCheck.Size = New System.Drawing.Size(175, 108)
        Me.panPerCheck.TabIndex = 12
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(3, 34)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(167, 68)
        Me.Label37.TabIndex = 9
        Me.Label37.Text = "In development"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.SpringGreen
        Me.Label38.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(-1, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(175, 34)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "Waste Per Check"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panAnalytics
        '
        Me.panAnalytics.AutoScroll = True
        Me.panAnalytics.Controls.Add(Me.panPerCheck)
        Me.panAnalytics.Controls.Add(Me.panRollingBar)
        Me.panAnalytics.Controls.Add(Me.panCampus)
        Me.panAnalytics.Controls.Add(Me.panStationWaste)
        Me.panAnalytics.Location = New System.Drawing.Point(500, 27)
        Me.panAnalytics.Name = "panAnalytics"
        Me.panAnalytics.Size = New System.Drawing.Size(398, 604)
        Me.panAnalytics.TabIndex = 3
        Me.panAnalytics.Visible = False
        '
        'WasteTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(898, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.panAnalytics)
        Me.Controls.Add(Me.sstWasteTracker)
        Me.Controls.Add(Me.panStations)
        Me.Controls.Add(Me.mstWasteTracker)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstWasteTracker
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "WasteTracking"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstWasteTracker.ResumeLayout(False)
        Me.mstWasteTracker.PerformLayout()
        Me.sstWasteTracker.ResumeLayout(False)
        Me.sstWasteTracker.PerformLayout()
        CType(Me.chtWastePie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panCampus.ResumeLayout(False)
        Me.panStationWaste.ResumeLayout(False)
        Me.panRollingBar.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panPerCheck.ResumeLayout(False)
        Me.panAnalytics.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panStations As Panel
    Friend WithEvents mstWasteTracker As MenuStrip
    Friend WithEvents sstWasteTracker As StatusStrip
    Friend WithEvents chtWastePie As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents panCampus As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panStationWaste As Panel
    Friend WithEvents panRollingBar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiChangeName As ToolStripMenuItem
    Friend WithEvents tsmiNewStation As ToolStripMenuItem
    Friend WithEvents tsmiUnlock As ToolStripMenuItem
    Friend WithEvents tsmiMSP As PeriodSelector
    Friend WithEvents tsmiWeek As WeekSelector
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslUnit As ToolStripStatusLabel
    Friend WithEvents tsslStation As ToolStripStatusLabel
    Friend WithEvents tsslWeek As ToolStripStatusLabel
    Friend WithEvents panPerCheck As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents tsmiStations As ToolStripMenuItem
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents tsmiWasteType As ToolStripMenuItem
    Friend WithEvents panAnalytics As Panel
End Class
