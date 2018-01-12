<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WeeklyFlash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeeklyFlash))
        Me.mstDiningFlash = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDraft = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpDays = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPeriod = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.tsmiViewPTD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelegates = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddDelegate = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstDiningFlash = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriodDays = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeek = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslWeekDays = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FlashNotes1 = New AGNES.FlashNotes()
        Me.FlashNotes2 = New AGNES.FlashNotes()
        Me.FlashNotes3 = New AGNES.FlashNotes()
        Me.FlashNotes4 = New AGNES.FlashNotes()
        Me.PrintFlash = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblForecast = New System.Windows.Forms.Label()
        Me.lblForecastVariance = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsmiUnlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstDiningFlash.SuspendLayout()
        Me.sstDiningFlash.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstDiningFlash
        '
        Me.mstDiningFlash.BackColor = System.Drawing.Color.AliceBlue
        Me.mstDiningFlash.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstDiningFlash.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiPeriod, Me.tsmiWeek, Me.tsmiViewPTD, Me.tsmiDelegates})
        Me.mstDiningFlash.Location = New System.Drawing.Point(0, 0)
        Me.mstDiningFlash.Name = "mstDiningFlash"
        Me.mstDiningFlash.Size = New System.Drawing.Size(958, 25)
        Me.mstDiningFlash.TabIndex = 0
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDraft, Me.tsmiFinal, Me.tsmiPrint, Me.tsmiClose})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(39, 21)
        Me.tsmiFile.Text = "File"
        '
        'tsmiDraft
        '
        Me.tsmiDraft.Enabled = False
        Me.tsmiDraft.Name = "tsmiDraft"
        Me.tsmiDraft.Size = New System.Drawing.Size(153, 22)
        Me.tsmiDraft.Text = "Save as Draft"
        '
        'tsmiFinal
        '
        Me.tsmiFinal.Enabled = False
        Me.tsmiFinal.Name = "tsmiFinal"
        Me.tsmiFinal.Size = New System.Drawing.Size(153, 22)
        Me.tsmiFinal.Text = "Save as Final"
        '
        'tsmiPrint
        '
        Me.tsmiPrint.Enabled = False
        Me.tsmiPrint.Name = "tsmiPrint"
        Me.tsmiPrint.Size = New System.Drawing.Size(153, 22)
        Me.tsmiPrint.Text = "Print"
        '
        'tsmiClose
        '
        Me.tsmiClose.Name = "tsmiClose"
        Me.tsmiClose.Size = New System.Drawing.Size(153, 22)
        Me.tsmiClose.Text = "Close"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClear, Me.tsmiOpDays, Me.tsmiUnlock})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(42, 21)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiClear
        '
        Me.tsmiClear.Enabled = False
        Me.tsmiClear.Name = "tsmiClear"
        Me.tsmiClear.Size = New System.Drawing.Size(219, 22)
        Me.tsmiClear.Text = "Clear All"
        '
        'tsmiOpDays
        '
        Me.tsmiOpDays.Enabled = False
        Me.tsmiOpDays.Name = "tsmiOpDays"
        Me.tsmiOpDays.Size = New System.Drawing.Size(219, 22)
        Me.tsmiOpDays.Text = "Manage Operating Days"
        '
        'tsmiPeriod
        '
        Me.tsmiPeriod.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiP1, Me.tsmiP2, Me.tsmiP3, Me.tsmiP4, Me.tsmiP5, Me.tsmiP6, Me.tsmiP7, Me.tsmiP8, Me.tsmiP9, Me.tsmiP10, Me.tsmiP11, Me.tsmiP12})
        Me.tsmiPeriod.Name = "tsmiPeriod"
        Me.tsmiPeriod.Size = New System.Drawing.Size(119, 21)
        Me.tsmiPeriod.Text = "Select MS Period"
        '
        'tsmiP1
        '
        Me.tsmiP1.CheckOnClick = True
        Me.tsmiP1.Enabled = False
        Me.tsmiP1.Name = "tsmiP1"
        Me.tsmiP1.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP1.Text = "1 (Jul)"
        '
        'tsmiP2
        '
        Me.tsmiP2.CheckOnClick = True
        Me.tsmiP2.Enabled = False
        Me.tsmiP2.Name = "tsmiP2"
        Me.tsmiP2.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP2.Text = "2 (Aug)"
        '
        'tsmiP3
        '
        Me.tsmiP3.CheckOnClick = True
        Me.tsmiP3.Enabled = False
        Me.tsmiP3.Name = "tsmiP3"
        Me.tsmiP3.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP3.Text = "3 (Sep)"
        '
        'tsmiP4
        '
        Me.tsmiP4.CheckOnClick = True
        Me.tsmiP4.Enabled = False
        Me.tsmiP4.Name = "tsmiP4"
        Me.tsmiP4.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP4.Text = "4 (Oct)"
        '
        'tsmiP5
        '
        Me.tsmiP5.CheckOnClick = True
        Me.tsmiP5.Enabled = False
        Me.tsmiP5.Name = "tsmiP5"
        Me.tsmiP5.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP5.Text = "5 (Nov)"
        '
        'tsmiP6
        '
        Me.tsmiP6.CheckOnClick = True
        Me.tsmiP6.Enabled = False
        Me.tsmiP6.Name = "tsmiP6"
        Me.tsmiP6.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP6.Text = "6 (Dec)"
        '
        'tsmiP7
        '
        Me.tsmiP7.CheckOnClick = True
        Me.tsmiP7.Enabled = False
        Me.tsmiP7.Name = "tsmiP7"
        Me.tsmiP7.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP7.Text = "7 (Jan)"
        '
        'tsmiP8
        '
        Me.tsmiP8.CheckOnClick = True
        Me.tsmiP8.Enabled = False
        Me.tsmiP8.Name = "tsmiP8"
        Me.tsmiP8.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP8.Text = "8 (Feb)"
        '
        'tsmiP9
        '
        Me.tsmiP9.CheckOnClick = True
        Me.tsmiP9.Enabled = False
        Me.tsmiP9.Name = "tsmiP9"
        Me.tsmiP9.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP9.Text = "9 (Mar)"
        '
        'tsmiP10
        '
        Me.tsmiP10.CheckOnClick = True
        Me.tsmiP10.Enabled = False
        Me.tsmiP10.Name = "tsmiP10"
        Me.tsmiP10.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP10.Text = "10 (Apr)"
        '
        'tsmiP11
        '
        Me.tsmiP11.CheckOnClick = True
        Me.tsmiP11.Enabled = False
        Me.tsmiP11.Name = "tsmiP11"
        Me.tsmiP11.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP11.Text = "11 (May)"
        '
        'tsmiP12
        '
        Me.tsmiP12.CheckOnClick = True
        Me.tsmiP12.Enabled = False
        Me.tsmiP12.Name = "tsmiP12"
        Me.tsmiP12.Size = New System.Drawing.Size(152, 22)
        Me.tsmiP12.Text = "12 (Jun)"
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
        'tsmiViewPTD
        '
        Me.tsmiViewPTD.Enabled = False
        Me.tsmiViewPTD.Name = "tsmiViewPTD"
        Me.tsmiViewPTD.Size = New System.Drawing.Size(136, 21)
        Me.tsmiViewPTD.Text = "View Period to Date"
        '
        'tsmiDelegates
        '
        Me.tsmiDelegates.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAddDelegate})
        Me.tsmiDelegates.Enabled = False
        Me.tsmiDelegates.Name = "tsmiDelegates"
        Me.tsmiDelegates.Size = New System.Drawing.Size(78, 21)
        Me.tsmiDelegates.Text = "Delegates"
        '
        'tsmiAddDelegate
        '
        Me.tsmiAddDelegate.Name = "tsmiAddDelegate"
        Me.tsmiAddDelegate.Size = New System.Drawing.Size(169, 22)
        Me.tsmiAddDelegate.Text = "+ Add Delegate"
        '
        'sstDiningFlash
        '
        Me.sstDiningFlash.BackColor = System.Drawing.Color.AliceBlue
        Me.sstDiningFlash.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstDiningFlash.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslFY, Me.tsslPeriod, Me.tsslPeriodDays, Me.tsslWeek, Me.tsslWeekDays, Me.tsslInformation, Me.tsslSaveStatus})
        Me.sstDiningFlash.Location = New System.Drawing.Point(0, 622)
        Me.sstDiningFlash.Name = "sstDiningFlash"
        Me.sstDiningFlash.Size = New System.Drawing.Size(958, 26)
        Me.sstDiningFlash.SizingGrip = False
        Me.sstDiningFlash.TabIndex = 1
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
        Me.tsslInformation.Size = New System.Drawing.Size(534, 21)
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
        'FlashNotes1
        '
        Me.FlashNotes1.ForeColor = System.Drawing.Color.DimGray
        Me.FlashNotes1.Location = New System.Drawing.Point(0, 0)
        Me.FlashNotes1.Multiline = True
        Me.FlashNotes1.Name = "FlashNotes1"
        Me.FlashNotes1.Size = New System.Drawing.Size(100, 54)
        Me.FlashNotes1.TabIndex = 0
        Me.FlashNotes1.Text = "Add notes here"
        '
        'FlashNotes2
        '
        Me.FlashNotes2.ForeColor = System.Drawing.Color.DimGray
        Me.FlashNotes2.Location = New System.Drawing.Point(0, 0)
        Me.FlashNotes2.Multiline = True
        Me.FlashNotes2.Name = "FlashNotes2"
        Me.FlashNotes2.Size = New System.Drawing.Size(100, 54)
        Me.FlashNotes2.TabIndex = 0
        Me.FlashNotes2.Text = "Add notes here"
        '
        'FlashNotes3
        '
        Me.FlashNotes3.ForeColor = System.Drawing.Color.DimGray
        Me.FlashNotes3.Location = New System.Drawing.Point(0, 0)
        Me.FlashNotes3.Multiline = True
        Me.FlashNotes3.Name = "FlashNotes3"
        Me.FlashNotes3.Size = New System.Drawing.Size(100, 54)
        Me.FlashNotes3.TabIndex = 0
        Me.FlashNotes3.Text = "Add notes here"
        '
        'FlashNotes4
        '
        Me.FlashNotes4.ForeColor = System.Drawing.Color.DimGray
        Me.FlashNotes4.Location = New System.Drawing.Point(0, 0)
        Me.FlashNotes4.Multiline = True
        Me.FlashNotes4.Name = "FlashNotes4"
        Me.FlashNotes4.Size = New System.Drawing.Size(100, 54)
        Me.FlashNotes4.TabIndex = 0
        Me.FlashNotes4.Text = "Add notes here"
        '
        'PrintFlash
        '
        Me.PrintFlash.DocumentName = "document"
        Me.PrintFlash.Form = Me
        Me.PrintFlash.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintFlash.PrinterSettings = CType(resources.GetObject("PrintFlash.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFlash.PrintFileName = Nothing
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Flash"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 35)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Budget"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 35)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Variance"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblForecast
        '
        Me.lblForecast.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForecast.Location = New System.Drawing.Point(642, 32)
        Me.lblForecast.Name = "lblForecast"
        Me.lblForecast.Size = New System.Drawing.Size(100, 35)
        Me.lblForecast.TabIndex = 15
        Me.lblForecast.Text = "Forecast"
        Me.lblForecast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblForecastVariance
        '
        Me.lblForecastVariance.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForecastVariance.Location = New System.Drawing.Point(830, 32)
        Me.lblForecastVariance.Name = "lblForecastVariance"
        Me.lblForecastVariance.Size = New System.Drawing.Size(100, 35)
        Me.lblForecastVariance.TabIndex = 16
        Me.lblForecastVariance.Text = "Variance"
        Me.lblForecastVariance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(196, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 35)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 35)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsmiUnlock
        '
        Me.tsmiUnlock.Enabled = False
        Me.tsmiUnlock.Name = "tsmiUnlock"
        Me.tsmiUnlock.Size = New System.Drawing.Size(219, 22)
        Me.tsmiUnlock.Text = "Unlock Flash"
        Me.tsmiUnlock.Visible = False
        '
        'WeeklyFlash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(958, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblForecastVariance)
        Me.Controls.Add(Me.lblForecast)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sstDiningFlash)
        Me.Controls.Add(Me.mstDiningFlash)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstDiningFlash
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(960, 650)
        Me.MinimumSize = New System.Drawing.Size(960, 650)
        Me.Name = "WeeklyFlash"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstDiningFlash.ResumeLayout(False)
        Me.mstDiningFlash.PerformLayout()
        Me.sstDiningFlash.ResumeLayout(False)
        Me.sstDiningFlash.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstDiningFlash As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiDraft As ToolStripMenuItem
    Friend WithEvents tsmiFinal As ToolStripMenuItem
    Friend WithEvents tsmiClose As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiClear As ToolStripMenuItem
    Friend WithEvents tsmiPeriod As ToolStripMenuItem
    Friend WithEvents tsmiP1 As ToolStripMenuItem
    Friend WithEvents tsmiP2 As ToolStripMenuItem
    Friend WithEvents tsmiWeek As ToolStripMenuItem
    Friend WithEvents tsmiViewPTD As ToolStripMenuItem
    Friend WithEvents tsmiDelegates As ToolStripMenuItem
    Friend WithEvents tsmiOpDays As ToolStripMenuItem
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
    Friend WithEvents tsmiW1 As ToolStripMenuItem
    Friend WithEvents tsmiW2 As ToolStripMenuItem
    Friend WithEvents tsmiW3 As ToolStripMenuItem
    Friend WithEvents tsmiW4 As ToolStripMenuItem
    Friend WithEvents tsmiW5 As ToolStripMenuItem
    Friend WithEvents sstDiningFlash As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents FlashNotes1 As FlashNotes
    Friend WithEvents FlashNotes2 As FlashNotes
    Friend WithEvents FlashNotes3 As FlashNotes
    Friend WithEvents FlashNotes4 As FlashNotes
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslPeriodDays As ToolStripStatusLabel
    Friend WithEvents tsslWeek As ToolStripStatusLabel
    Friend WithEvents tsslWeekDays As ToolStripStatusLabel
    Friend WithEvents tsslInformation As ToolStripStatusLabel
    Friend WithEvents tsslSaveStatus As ToolStripStatusLabel
    Friend WithEvents PrintFlash As PowerPacks.Printing.PrintForm
    Friend WithEvents Label10 As Label
    Friend WithEvents lblForecastVariance As Label
    Friend WithEvents lblForecast As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents tsmiAddDelegate As ToolStripMenuItem
    Friend WithEvents tsmiPrint As ToolStripMenuItem
    Friend WithEvents tsmiUnlock As ToolStripMenuItem
End Class
