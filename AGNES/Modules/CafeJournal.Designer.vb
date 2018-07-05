<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CafeJournal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CafeJournal))
        Me.sstJournal = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUnit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dtpJournalStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cbxEventCat = New System.Windows.Forms.ComboBox()
        Me.mstJournal = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblJournalText = New System.Windows.Forms.Label()
        Me.lblEventStart = New System.Windows.Forms.Label()
        Me.lblEventCat = New System.Windows.Forms.Label()
        Me.lblDGVEntries = New System.Windows.Forms.Label()
        Me.dgvEntryList = New System.Windows.Forms.DataGridView()
        Me.colPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEventEnd = New System.Windows.Forms.Label()
        Me.dtpJournalEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lbxUnits = New System.Windows.Forms.ListBox()
        Me.lblUnitSelection = New System.Windows.Forms.Label()
        Me.txtJournalText = New AGNES.AgnesTxt()
        Me.sstJournal.SuspendLayout()
        Me.mstJournal.SuspendLayout()
        CType(Me.dgvEntryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sstJournal
        '
        Me.sstJournal.BackColor = System.Drawing.Color.AliceBlue
        Me.sstJournal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslUnit, Me.tsslInformation, Me.tsslSaveStatus})
        Me.sstJournal.Location = New System.Drawing.Point(0, 424)
        Me.sstJournal.Name = "sstJournal"
        Me.sstJournal.Size = New System.Drawing.Size(718, 24)
        Me.sstJournal.SizingGrip = False
        Me.sstJournal.TabIndex = 2
        Me.sstJournal.Text = "StatusStrip1"
        '
        'tsslUser
        '
        Me.tsslUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUser.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslUser.Name = "tsslUser"
        Me.tsslUser.Size = New System.Drawing.Size(34, 19)
        Me.tsslUser.Text = "User"
        '
        'tsslUnit
        '
        Me.tsslUnit.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUnit.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslUnit.Name = "tsslUnit"
        Me.tsslUnit.Size = New System.Drawing.Size(33, 19)
        Me.tsslUnit.Text = "Unit"
        '
        'tsslInformation
        '
        Me.tsslInformation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslInformation.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslInformation.Name = "tsslInformation"
        Me.tsslInformation.Size = New System.Drawing.Size(636, 19)
        Me.tsslInformation.Spring = True
        '
        'tsslSaveStatus
        '
        Me.tsslSaveStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslSaveStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslSaveStatus.Name = "tsslSaveStatus"
        Me.tsslSaveStatus.Size = New System.Drawing.Size(67, 19)
        Me.tsslSaveStatus.Text = "SaveStatus"
        Me.tsslSaveStatus.Visible = False
        '
        'dtpJournalStartDate
        '
        Me.dtpJournalStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpJournalStartDate.Location = New System.Drawing.Point(12, 47)
        Me.dtpJournalStartDate.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpJournalStartDate.MinDate = New Date(2017, 12, 4, 0, 0, 0, 0)
        Me.dtpJournalStartDate.Name = "dtpJournalStartDate"
        Me.dtpJournalStartDate.Size = New System.Drawing.Size(113, 25)
        Me.dtpJournalStartDate.TabIndex = 0
        '
        'cbxEventCat
        '
        Me.cbxEventCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxEventCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxEventCat.FormattingEnabled = True
        Me.cbxEventCat.Items.AddRange(New Object() {"Concept Change", "Equipment", "Event/Meeting", "Facilities", "Local Brands", "Staffing", "Technology", "Training", "Weather", "Other"})
        Me.cbxEventCat.Location = New System.Drawing.Point(282, 47)
        Me.cbxEventCat.Name = "cbxEventCat"
        Me.cbxEventCat.Size = New System.Drawing.Size(278, 25)
        Me.cbxEventCat.TabIndex = 2
        '
        'mstJournal
        '
        Me.mstJournal.BackColor = System.Drawing.Color.AliceBlue
        Me.mstJournal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit})
        Me.mstJournal.Location = New System.Drawing.Point(0, 0)
        Me.mstJournal.Name = "mstJournal"
        Me.mstJournal.Size = New System.Drawing.Size(718, 24)
        Me.mstJournal.TabIndex = 8
        Me.mstJournal.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSave
        '
        Me.tsmiSave.Enabled = False
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(98, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(98, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClear, Me.tsmiDelete})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiClear
        '
        Me.tsmiClear.Name = "tsmiClear"
        Me.tsmiClear.Size = New System.Drawing.Size(137, 22)
        Me.tsmiClear.Text = "Clear"
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(137, 22)
        Me.tsmiDelete.Text = "Delete Entry"
        Me.tsmiDelete.Visible = False
        '
        'lblJournalText
        '
        Me.lblJournalText.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJournalText.Location = New System.Drawing.Point(12, 114)
        Me.lblJournalText.Name = "lblJournalText"
        Me.lblJournalText.Size = New System.Drawing.Size(695, 20)
        Me.lblJournalText.TabIndex = 10
        Me.lblJournalText.Text = "Event Detail Journal Entry"
        Me.lblJournalText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEventStart
        '
        Me.lblEventStart.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventStart.Location = New System.Drawing.Point(10, 24)
        Me.lblEventStart.Name = "lblEventStart"
        Me.lblEventStart.Size = New System.Drawing.Size(115, 20)
        Me.lblEventStart.TabIndex = 11
        Me.lblEventStart.Text = "Event Start"
        Me.lblEventStart.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEventCat
        '
        Me.lblEventCat.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventCat.Location = New System.Drawing.Point(281, 24)
        Me.lblEventCat.Name = "lblEventCat"
        Me.lblEventCat.Size = New System.Drawing.Size(279, 20)
        Me.lblEventCat.TabIndex = 12
        Me.lblEventCat.Text = "Event Category"
        Me.lblEventCat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDGVEntries
        '
        Me.lblDGVEntries.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVEntries.Location = New System.Drawing.Point(11, 275)
        Me.lblDGVEntries.Name = "lblDGVEntries"
        Me.lblDGVEntries.Size = New System.Drawing.Size(696, 20)
        Me.lblDGVEntries.TabIndex = 13
        Me.lblDGVEntries.Text = "Other Entries for Selected Date"
        Me.lblDGVEntries.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblDGVEntries.Visible = False
        '
        'dgvEntryList
        '
        Me.dgvEntryList.AllowUserToAddRows = False
        Me.dgvEntryList.AllowUserToDeleteRows = False
        Me.dgvEntryList.BackgroundColor = System.Drawing.Color.OldLace
        Me.dgvEntryList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntryList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntryList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPID, Me.colDt, Me.Unum, Me.colCAT, Me.colDetail})
        Me.dgvEntryList.Location = New System.Drawing.Point(11, 298)
        Me.dgvEntryList.MultiSelect = False
        Me.dgvEntryList.Name = "dgvEntryList"
        Me.dgvEntryList.ReadOnly = True
        Me.dgvEntryList.RowHeadersVisible = False
        Me.dgvEntryList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEntryList.Size = New System.Drawing.Size(707, 123)
        Me.dgvEntryList.TabIndex = 14
        Me.dgvEntryList.TabStop = False
        Me.dgvEntryList.Visible = False
        '
        'colPID
        '
        Me.colPID.Frozen = True
        Me.colPID.HeaderText = "PID"
        Me.colPID.MaxInputLength = 16
        Me.colPID.Name = "colPID"
        Me.colPID.ReadOnly = True
        Me.colPID.Visible = False
        Me.colPID.Width = 16
        '
        'colDt
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDt.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDt.HeaderText = "Date"
        Me.colDt.MaxInputLength = 16
        Me.colDt.Name = "colDt"
        Me.colDt.ReadOnly = True
        Me.colDt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDt.Width = 80
        '
        'Unum
        '
        Me.Unum.HeaderText = "Unit"
        Me.Unum.MaxInputLength = 12
        Me.Unum.Name = "Unum"
        Me.Unum.ReadOnly = True
        Me.Unum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Unum.Width = 60
        '
        'colCAT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCAT.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCAT.HeaderText = "Category"
        Me.colCAT.MaxInputLength = 64
        Me.colCAT.Name = "colCAT"
        Me.colCAT.ReadOnly = True
        Me.colCAT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCAT.Width = 120
        '
        'colDetail
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDetail.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDetail.HeaderText = "Detail"
        Me.colDetail.MaxInputLength = 1024
        Me.colDetail.Name = "colDetail"
        Me.colDetail.ReadOnly = True
        Me.colDetail.Width = 420
        '
        'lblEventEnd
        '
        Me.lblEventEnd.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventEnd.Location = New System.Drawing.Point(145, 24)
        Me.lblEventEnd.Name = "lblEventEnd"
        Me.lblEventEnd.Size = New System.Drawing.Size(115, 20)
        Me.lblEventEnd.TabIndex = 16
        Me.lblEventEnd.Text = "Event End"
        Me.lblEventEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpJournalEndDate
        '
        Me.dtpJournalEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpJournalEndDate.Location = New System.Drawing.Point(147, 47)
        Me.dtpJournalEndDate.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpJournalEndDate.MinDate = New Date(2017, 12, 4, 0, 0, 0, 0)
        Me.dtpJournalEndDate.Name = "dtpJournalEndDate"
        Me.dtpJournalEndDate.Size = New System.Drawing.Size(113, 25)
        Me.dtpJournalEndDate.TabIndex = 1
        '
        'lbxUnits
        '
        Me.lbxUnits.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxUnits.FormattingEnabled = True
        Me.lbxUnits.ItemHeight = 15
        Me.lbxUnits.Location = New System.Drawing.Point(566, 47)
        Me.lbxUnits.Name = "lbxUnits"
        Me.lbxUnits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxUnits.Size = New System.Drawing.Size(140, 64)
        Me.lbxUnits.TabIndex = 17
        '
        'lblUnitSelection
        '
        Me.lblUnitSelection.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitSelection.Location = New System.Drawing.Point(563, 24)
        Me.lblUnitSelection.Name = "lblUnitSelection"
        Me.lblUnitSelection.Size = New System.Drawing.Size(143, 20)
        Me.lblUnitSelection.TabIndex = 18
        Me.lblUnitSelection.Text = "Unit Selection"
        Me.lblUnitSelection.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtJournalText
        '
        Me.txtJournalText.Enabled = False
        Me.txtJournalText.Location = New System.Drawing.Point(12, 137)
        Me.txtJournalText.MaxLength = 1024
        Me.txtJournalText.Multiline = True
        Me.txtJournalText.Name = "txtJournalText"
        Me.txtJournalText.Size = New System.Drawing.Size(695, 135)
        Me.txtJournalText.TabIndex = 3
        '
        'CafeJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(718, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUnitSelection)
        Me.Controls.Add(Me.lbxUnits)
        Me.Controls.Add(Me.lblEventEnd)
        Me.Controls.Add(Me.dtpJournalEndDate)
        Me.Controls.Add(Me.dgvEntryList)
        Me.Controls.Add(Me.lblDGVEntries)
        Me.Controls.Add(Me.lblEventCat)
        Me.Controls.Add(Me.lblEventStart)
        Me.Controls.Add(Me.lblJournalText)
        Me.Controls.Add(Me.cbxEventCat)
        Me.Controls.Add(Me.txtJournalText)
        Me.Controls.Add(Me.dtpJournalStartDate)
        Me.Controls.Add(Me.sstJournal)
        Me.Controls.Add(Me.mstJournal)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstJournal
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(720, 450)
        Me.MinimumSize = New System.Drawing.Size(600, 450)
        Me.Name = "CafeJournal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.sstJournal.ResumeLayout(False)
        Me.sstJournal.PerformLayout()
        Me.mstJournal.ResumeLayout(False)
        Me.mstJournal.PerformLayout()
        CType(Me.dgvEntryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sstJournal As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslInformation As ToolStripStatusLabel
    Friend WithEvents tsslSaveStatus As ToolStripStatusLabel
    Friend WithEvents dtpJournalStartDate As DateTimePicker
    Friend WithEvents txtJournalText As AgnesTxt
    Friend WithEvents cbxEventCat As ComboBox
    Friend WithEvents mstJournal As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents lblJournalText As Label
    Friend WithEvents lblEventStart As Label
    Friend WithEvents lblEventCat As Label
    Friend WithEvents lblDGVEntries As Label
    Friend WithEvents tsslUnit As ToolStripStatusLabel
    Friend WithEvents tsmiClear As ToolStripMenuItem
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents dgvEntryList As DataGridView
    Friend WithEvents lblEventEnd As Label
    Friend WithEvents dtpJournalEndDate As DateTimePicker
    Friend WithEvents lbxUnits As ListBox
    Friend WithEvents lblUnitSelection As Label
    Friend WithEvents colPID As DataGridViewTextBoxColumn
    Friend WithEvents colDt As DataGridViewTextBoxColumn
    Friend WithEvents Unum As DataGridViewTextBoxColumn
    Friend WithEvents colCAT As DataGridViewTextBoxColumn
    Friend WithEvents colDetail As DataGridViewTextBoxColumn
End Class
