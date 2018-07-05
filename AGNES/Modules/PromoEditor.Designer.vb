<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoEditor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromoEditor))
        Me.mstPromos = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddPOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddNote = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewExpenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewNotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstPromos = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPromoName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtPromoName = New System.Windows.Forms.TextBox()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpStartDt = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDt = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxStartTime = New System.Windows.Forms.ComboBox()
        Me.cbxEndTime = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxCoordinator = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMediaURL = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCharCt = New System.Windows.Forms.Label()
        Me.lbxLocations = New System.Windows.Forms.ListBox()
        Me.lbxLocSelected = New System.Windows.Forms.ListBox()
        Me.pbxLocAdd = New System.Windows.Forms.PictureBox()
        Me.pbxLocSub = New System.Windows.Forms.PictureBox()
        Me.pbxStatSub = New System.Windows.Forms.PictureBox()
        Me.pbxStatAdd = New System.Windows.Forms.PictureBox()
        Me.lbxStationSelected = New System.Windows.Forms.ListBox()
        Me.lbxStations = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvPosAssociations = New System.Windows.Forms.DataGridView()
        Me.POSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPromoDesc = New AGNES.PromoDesc()
        Me.mstPromos.SuspendLayout()
        Me.sstPromos.SuspendLayout()
        CType(Me.pbxLocAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLocSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStatSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStatAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPosAssociations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mstPromos
        '
        Me.mstPromos.BackColor = System.Drawing.Color.AliceBlue
        Me.mstPromos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiView})
        Me.mstPromos.Location = New System.Drawing.Point(0, 0)
        Me.mstPromos.Name = "mstPromos"
        Me.mstPromos.Size = New System.Drawing.Size(798, 24)
        Me.mstPromos.TabIndex = 0
        Me.mstPromos.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiDelete, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Enabled = False
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(152, 22)
        Me.tsmiDelete.Text = "Delete"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(152, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAddPOS, Me.tsmiAddExpense, Me.tsmiAddNote})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiAddPOS
        '
        Me.tsmiAddPOS.Enabled = False
        Me.tsmiAddPOS.Name = "tsmiAddPOS"
        Me.tsmiAddPOS.Size = New System.Drawing.Size(152, 22)
        Me.tsmiAddPOS.Text = "Add POS IDs"
        '
        'tsmiAddExpense
        '
        Me.tsmiAddExpense.Enabled = False
        Me.tsmiAddExpense.Name = "tsmiAddExpense"
        Me.tsmiAddExpense.Size = New System.Drawing.Size(152, 22)
        Me.tsmiAddExpense.Text = "Add Expense"
        '
        'tsmiAddNote
        '
        Me.tsmiAddNote.Enabled = False
        Me.tsmiAddNote.Name = "tsmiAddNote"
        Me.tsmiAddNote.Size = New System.Drawing.Size(152, 22)
        Me.tsmiAddNote.Text = "Add Note"
        '
        'tsmiView
        '
        Me.tsmiView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiViewExpenses, Me.tsmiViewNotes})
        Me.tsmiView.Name = "tsmiView"
        Me.tsmiView.Size = New System.Drawing.Size(44, 20)
        Me.tsmiView.Text = "View"
        '
        'tsmiViewExpenses
        '
        Me.tsmiViewExpenses.Enabled = False
        Me.tsmiViewExpenses.Name = "tsmiViewExpenses"
        Me.tsmiViewExpenses.Size = New System.Drawing.Size(181, 22)
        Me.tsmiViewExpenses.Text = "Promotion Expenses"
        '
        'tsmiViewNotes
        '
        Me.tsmiViewNotes.Enabled = False
        Me.tsmiViewNotes.Name = "tsmiViewNotes"
        Me.tsmiViewNotes.Size = New System.Drawing.Size(181, 22)
        Me.tsmiViewNotes.Text = "Promotion Notes"
        '
        'sstPromos
        '
        Me.sstPromos.BackColor = System.Drawing.Color.AliceBlue
        Me.sstPromos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslPromoName, Me.tsslInfo, Me.tsslStatus})
        Me.sstPromos.Location = New System.Drawing.Point(0, 674)
        Me.sstPromos.Name = "sstPromos"
        Me.sstPromos.Size = New System.Drawing.Size(798, 24)
        Me.sstPromos.SizingGrip = False
        Me.sstPromos.TabIndex = 1
        Me.sstPromos.Text = "StatusStrip1"
        '
        'tsslUser
        '
        Me.tsslUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUser.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslUser.Name = "tsslUser"
        Me.tsslUser.Size = New System.Drawing.Size(33, 19)
        Me.tsslUser.Text = "user"
        '
        'tsslPromoName
        '
        Me.tsslPromoName.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslPromoName.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslPromoName.Name = "tsslPromoName"
        Me.tsslPromoName.Size = New System.Drawing.Size(80, 19)
        Me.tsslPromoName.Text = "promo name"
        '
        'tsslInfo
        '
        Me.tsslInfo.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslInfo.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslInfo.Name = "tsslInfo"
        Me.tsslInfo.Size = New System.Drawing.Size(628, 19)
        Me.tsslInfo.Spring = True
        Me.tsslInfo.Text = "info"
        '
        'tsslStatus
        '
        Me.tsslStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(42, 19)
        Me.tsslStatus.Text = "status"
        '
        'txtPromoName
        '
        Me.txtPromoName.Location = New System.Drawing.Point(12, 72)
        Me.txtPromoName.Name = "txtPromoName"
        Me.txtPromoName.Size = New System.Drawing.Size(363, 25)
        Me.txtPromoName.TabIndex = 0
        '
        'cbxType
        '
        Me.cbxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Awareness", "BOGO", "Coupon", "Discount", "Seasonal", "Seasonal Menu", "Other"})
        Me.cbxType.Location = New System.Drawing.Point(381, 72)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(204, 25)
        Me.cbxType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Promotion Name*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Promotion Type*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Locations*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(410, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Stations*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Start Date*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpStartDt
        '
        Me.dtpStartDt.CalendarMonthBackground = System.Drawing.Color.Aqua
        Me.dtpStartDt.CalendarTitleBackColor = System.Drawing.Color.Aqua
        Me.dtpStartDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDt.Location = New System.Drawing.Point(8, 308)
        Me.dtpStartDt.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDt.MinDate = New Date(2017, 12, 1, 0, 0, 0, 0)
        Me.dtpStartDt.Name = "dtpStartDt"
        Me.dtpStartDt.Size = New System.Drawing.Size(116, 25)
        Me.dtpStartDt.TabIndex = 7
        Me.dtpStartDt.Value = New Date(2017, 12, 1, 0, 0, 0, 0)
        '
        'dtpEndDt
        '
        Me.dtpEndDt.CalendarMonthBackground = System.Drawing.Color.Aqua
        Me.dtpEndDt.CalendarTitleBackColor = System.Drawing.Color.Aqua
        Me.dtpEndDt.Enabled = False
        Me.dtpEndDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDt.Location = New System.Drawing.Point(130, 308)
        Me.dtpEndDt.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDt.MinDate = New Date(2017, 12, 1, 0, 0, 0, 0)
        Me.dtpEndDt.Name = "dtpEndDt"
        Me.dtpEndDt.Size = New System.Drawing.Size(116, 25)
        Me.dtpEndDt.TabIndex = 8
        Me.dtpEndDt.Value = New Date(2017, 12, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(130, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "End Date*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(391, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 32)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "End Time*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(273, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 32)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Start Time*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxStartTime
        '
        Me.cbxStartTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxStartTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxStartTime.FormattingEnabled = True
        Me.cbxStartTime.Items.AddRange(New Object() {"All Day", "7:00am", "7:30am", "8:00am", "8:30am", "9:00am", "9:30am", "10:00am", "10:30am", "11:00am", "11:30am", "12:00pm", "12:30pm", "1:00pm", "1:30pm", "2:00pm", "2:30pm", "3:00pm", "3:30pm", "4:00pm", "4:30pm", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm", "7:30pm", "8:00pm", "8:30pm", "9:00pm", "9:30pm", "10:00pm", "10:30pm"})
        Me.cbxStartTime.Location = New System.Drawing.Point(273, 308)
        Me.cbxStartTime.Name = "cbxStartTime"
        Me.cbxStartTime.Size = New System.Drawing.Size(112, 25)
        Me.cbxStartTime.TabIndex = 9
        '
        'cbxEndTime
        '
        Me.cbxEndTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxEndTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxEndTime.Enabled = False
        Me.cbxEndTime.FormattingEnabled = True
        Me.cbxEndTime.Location = New System.Drawing.Point(392, 308)
        Me.cbxEndTime.Name = "cbxEndTime"
        Me.cbxEndTime.Size = New System.Drawing.Size(112, 25)
        Me.cbxEndTime.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(591, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 32)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Coordinator"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxCoordinator
        '
        Me.cbxCoordinator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxCoordinator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxCoordinator.FormattingEnabled = True
        Me.cbxCoordinator.Items.AddRange(New Object() {"Alexia Manthey", "Betsy Anderson", "Lexi Taylor", "Keyanna Hartley", "Melissa Jurcan", "Sarah Rose"})
        Me.cbxCoordinator.Location = New System.Drawing.Point(591, 72)
        Me.cbxCoordinator.Name = "cbxCoordinator"
        Me.cbxCoordinator.Size = New System.Drawing.Size(195, 25)
        Me.cbxCoordinator.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(529, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(257, 32)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Media URL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMediaURL
        '
        Me.txtMediaURL.Location = New System.Drawing.Point(529, 308)
        Me.txtMediaURL.Name = "txtMediaURL"
        Me.txtMediaURL.Size = New System.Drawing.Size(257, 25)
        Me.txtMediaURL.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(778, 32)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Promotion Description (500 char max)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCharCt
        '
        Me.lblCharCt.AutoSize = True
        Me.lblCharCt.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharCt.Location = New System.Drawing.Point(651, 453)
        Me.lblCharCt.Name = "lblCharCt"
        Me.lblCharCt.Size = New System.Drawing.Size(135, 15)
        Me.lblCharCt.TabIndex = 24
        Me.lblCharCt.Text = "500 characters remaining"
        '
        'lbxLocations
        '
        Me.lbxLocations.FormattingEnabled = True
        Me.lbxLocations.ItemHeight = 17
        Me.lbxLocations.Location = New System.Drawing.Point(12, 130)
        Me.lbxLocations.Name = "lbxLocations"
        Me.lbxLocations.Size = New System.Drawing.Size(160, 140)
        Me.lbxLocations.Sorted = True
        Me.lbxLocations.TabIndex = 3
        '
        'lbxLocSelected
        '
        Me.lbxLocSelected.FormattingEnabled = True
        Me.lbxLocSelected.ItemHeight = 17
        Me.lbxLocSelected.Location = New System.Drawing.Point(215, 130)
        Me.lbxLocSelected.Name = "lbxLocSelected"
        Me.lbxLocSelected.Size = New System.Drawing.Size(160, 140)
        Me.lbxLocSelected.Sorted = True
        Me.lbxLocSelected.TabIndex = 4
        '
        'pbxLocAdd
        '
        Me.pbxLocAdd.Image = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.pbxLocAdd.InitialImage = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.pbxLocAdd.Location = New System.Drawing.Point(176, 144)
        Me.pbxLocAdd.Name = "pbxLocAdd"
        Me.pbxLocAdd.Size = New System.Drawing.Size(35, 35)
        Me.pbxLocAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLocAdd.TabIndex = 27
        Me.pbxLocAdd.TabStop = False
        '
        'pbxLocSub
        '
        Me.pbxLocSub.Image = Global.AGNES.My.Resources.Resources.glass_arrow_left
        Me.pbxLocSub.InitialImage = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.pbxLocSub.Location = New System.Drawing.Point(176, 220)
        Me.pbxLocSub.Name = "pbxLocSub"
        Me.pbxLocSub.Size = New System.Drawing.Size(35, 35)
        Me.pbxLocSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLocSub.TabIndex = 28
        Me.pbxLocSub.TabStop = False
        '
        'pbxStatSub
        '
        Me.pbxStatSub.Enabled = False
        Me.pbxStatSub.Image = Global.AGNES.My.Resources.Resources.glass_arrow_left
        Me.pbxStatSub.InitialImage = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.pbxStatSub.Location = New System.Drawing.Point(578, 220)
        Me.pbxStatSub.Name = "pbxStatSub"
        Me.pbxStatSub.Size = New System.Drawing.Size(35, 35)
        Me.pbxStatSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxStatSub.TabIndex = 32
        Me.pbxStatSub.TabStop = False
        '
        'pbxStatAdd
        '
        Me.pbxStatAdd.Enabled = False
        Me.pbxStatAdd.Image = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.pbxStatAdd.InitialImage = Global.AGNES.My.Resources.Resources.glass_arrow_right
        Me.pbxStatAdd.Location = New System.Drawing.Point(578, 144)
        Me.pbxStatAdd.Name = "pbxStatAdd"
        Me.pbxStatAdd.Size = New System.Drawing.Size(35, 35)
        Me.pbxStatAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxStatAdd.TabIndex = 31
        Me.pbxStatAdd.TabStop = False
        '
        'lbxStationSelected
        '
        Me.lbxStationSelected.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbxStationSelected.Enabled = False
        Me.lbxStationSelected.FormattingEnabled = True
        Me.lbxStationSelected.ItemHeight = 17
        Me.lbxStationSelected.Location = New System.Drawing.Point(617, 130)
        Me.lbxStationSelected.Name = "lbxStationSelected"
        Me.lbxStationSelected.Size = New System.Drawing.Size(160, 140)
        Me.lbxStationSelected.Sorted = True
        Me.lbxStationSelected.TabIndex = 6
        '
        'lbxStations
        '
        Me.lbxStations.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbxStations.Enabled = False
        Me.lbxStations.FormattingEnabled = True
        Me.lbxStations.ItemHeight = 17
        Me.lbxStations.Location = New System.Drawing.Point(414, 130)
        Me.lbxStations.Name = "lbxStations"
        Me.lbxStations.Size = New System.Drawing.Size(160, 140)
        Me.lbxStations.Sorted = True
        Me.lbxStations.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 482)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(778, 32)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Associated POS Codes"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPosAssociations
        '
        Me.dgvPosAssociations.AllowUserToAddRows = False
        Me.dgvPosAssociations.AllowUserToDeleteRows = False
        Me.dgvPosAssociations.AllowUserToResizeColumns = False
        Me.dgvPosAssociations.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPosAssociations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPosAssociations.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvPosAssociations.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosAssociations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPosAssociations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosAssociations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POSID, Me.POSType})
        Me.dgvPosAssociations.Enabled = False
        Me.dgvPosAssociations.Location = New System.Drawing.Point(262, 517)
        Me.dgvPosAssociations.Name = "dgvPosAssociations"
        Me.dgvPosAssociations.ReadOnly = True
        Me.dgvPosAssociations.RowHeadersVisible = False
        Me.dgvPosAssociations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPosAssociations.Size = New System.Drawing.Size(263, 150)
        Me.dgvPosAssociations.TabIndex = 34
        '
        'POSID
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.POSID.DefaultCellStyle = DataGridViewCellStyle3
        Me.POSID.Frozen = True
        Me.POSID.HeaderText = "POS Code"
        Me.POSID.MaxInputLength = 16
        Me.POSID.Name = "POSID"
        Me.POSID.ReadOnly = True
        Me.POSID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'POSType
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSType.DefaultCellStyle = DataGridViewCellStyle4
        Me.POSType.Frozen = True
        Me.POSType.HeaderText = "Code Type"
        Me.POSType.MaxInputLength = 24
        Me.POSType.Name = "POSType"
        Me.POSType.ReadOnly = True
        Me.POSType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.POSType.Width = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 453)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 15)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "* indicates required field"
        '
        'txtPromoDesc
        '
        Me.txtPromoDesc.Location = New System.Drawing.Point(8, 371)
        Me.txtPromoDesc.MaxLength = 500
        Me.txtPromoDesc.Multiline = True
        Me.txtPromoDesc.Name = "txtPromoDesc"
        Me.txtPromoDesc.Size = New System.Drawing.Size(778, 83)
        Me.txtPromoDesc.TabIndex = 12
        '
        'PromoEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(798, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvPosAssociations)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pbxStatSub)
        Me.Controls.Add(Me.pbxStatAdd)
        Me.Controls.Add(Me.lbxStationSelected)
        Me.Controls.Add(Me.lbxStations)
        Me.Controls.Add(Me.pbxLocSub)
        Me.Controls.Add(Me.pbxLocAdd)
        Me.Controls.Add(Me.lbxLocSelected)
        Me.Controls.Add(Me.lbxLocations)
        Me.Controls.Add(Me.txtPromoDesc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMediaURL)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxCoordinator)
        Me.Controls.Add(Me.cbxEndTime)
        Me.Controls.Add(Me.cbxStartTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpEndDt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpStartDt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxType)
        Me.Controls.Add(Me.txtPromoName)
        Me.Controls.Add(Me.sstPromos)
        Me.Controls.Add(Me.mstPromos)
        Me.Controls.Add(Me.lblCharCt)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(600, 600)
        Me.MainMenuStrip = Me.mstPromos
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "PromoEditor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstPromos.ResumeLayout(False)
        Me.mstPromos.PerformLayout()
        Me.sstPromos.ResumeLayout(False)
        Me.sstPromos.PerformLayout()
        CType(Me.pbxLocAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLocSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStatSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStatAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPosAssociations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstPromos As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiAddPOS As ToolStripMenuItem
    Friend WithEvents tsmiAddExpense As ToolStripMenuItem
    Friend WithEvents tsmiAddNote As ToolStripMenuItem
    Friend WithEvents tsmiView As ToolStripMenuItem
    Friend WithEvents tsmiViewExpenses As ToolStripMenuItem
    Friend WithEvents tsmiViewNotes As ToolStripMenuItem
    Friend WithEvents sstPromos As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslPromoName As ToolStripStatusLabel
    Friend WithEvents tsslInfo As ToolStripStatusLabel
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents txtPromoName As TextBox
    Friend WithEvents cbxType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpStartDt As DateTimePicker
    Friend WithEvents dtpEndDt As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxStartTime As ComboBox
    Friend WithEvents cbxEndTime As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCoordinator As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMediaURL As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPromoDesc As PromoDesc
    Friend WithEvents lblCharCt As Label
    Friend WithEvents lbxLocations As ListBox
    Friend WithEvents lbxLocSelected As ListBox
    Friend WithEvents pbxLocAdd As PictureBox
    Friend WithEvents pbxLocSub As PictureBox
    Friend WithEvents pbxStatSub As PictureBox
    Friend WithEvents pbxStatAdd As PictureBox
    Friend WithEvents lbxStationSelected As ListBox
    Friend WithEvents lbxStations As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvPosAssociations As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents POSID As DataGridViewTextBoxColumn
    Friend WithEvents POSType As DataGridViewTextBoxColumn
End Class
