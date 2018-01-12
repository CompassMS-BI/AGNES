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
        Me.dtpJournalDate = New System.Windows.Forms.DateTimePicker()
        Me.txtJournalText = New AGNES.AgnesTxt()
        Me.cbxEventCat = New System.Windows.Forms.ComboBox()
        Me.mstJournal = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDGVEntries = New System.Windows.Forms.Label()
        Me.dgvEntryList = New System.Windows.Forms.DataGridView()
        Me.colPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.sstJournal.Size = New System.Drawing.Size(598, 24)
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
        Me.tsslInformation.Size = New System.Drawing.Size(516, 19)
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
        'dtpJournalDate
        '
        Me.dtpJournalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpJournalDate.Location = New System.Drawing.Point(12, 47)
        Me.dtpJournalDate.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpJournalDate.MinDate = New Date(2017, 12, 4, 0, 0, 0, 0)
        Me.dtpJournalDate.Name = "dtpJournalDate"
        Me.dtpJournalDate.Size = New System.Drawing.Size(113, 25)
        Me.dtpJournalDate.TabIndex = 0
        '
        'txtJournalText
        '
        Me.txtJournalText.Enabled = False
        Me.txtJournalText.Location = New System.Drawing.Point(11, 98)
        Me.txtJournalText.MaxLength = 1024
        Me.txtJournalText.Multiline = True
        Me.txtJournalText.Name = "txtJournalText"
        Me.txtJournalText.Size = New System.Drawing.Size(573, 208)
        Me.txtJournalText.TabIndex = 2
        '
        'cbxEventCat
        '
        Me.cbxEventCat.FormattingEnabled = True
        Me.cbxEventCat.Items.AddRange(New Object() {"Equipment", "Event/Meeting", "Facilities", "Staffing", "Technology", "Training", "Other"})
        Me.cbxEventCat.Location = New System.Drawing.Point(161, 47)
        Me.cbxEventCat.Name = "cbxEventCat"
        Me.cbxEventCat.Size = New System.Drawing.Size(424, 25)
        Me.cbxEventCat.TabIndex = 1
        '
        'mstJournal
        '
        Me.mstJournal.BackColor = System.Drawing.Color.AliceBlue
        Me.mstJournal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit})
        Me.mstJournal.Location = New System.Drawing.Point(0, 0)
        Me.mstJournal.Name = "mstJournal"
        Me.mstJournal.Size = New System.Drawing.Size(598, 24)
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
        Me.tsmiSave.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(152, 22)
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Event Detail Journal Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Event Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(427, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Event Category"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDGVEntries
        '
        Me.lblDGVEntries.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVEntries.Location = New System.Drawing.Point(12, 309)
        Me.lblDGVEntries.Name = "lblDGVEntries"
        Me.lblDGVEntries.Size = New System.Drawing.Size(574, 20)
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
        Me.dgvEntryList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPID, Me.colDt, Me.colCAT, Me.colDetail})
        Me.dgvEntryList.Location = New System.Drawing.Point(11, 333)
        Me.dgvEntryList.Name = "dgvEntryList"
        Me.dgvEntryList.ReadOnly = True
        Me.dgvEntryList.RowHeadersVisible = False
        Me.dgvEntryList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEntryList.Size = New System.Drawing.Size(573, 88)
        Me.dgvEntryList.TabIndex = 14
        Me.dgvEntryList.Visible = False
        '
        'colPID
        '
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
        Me.colDetail.Width = 400
        '
        'CafeJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(598, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvEntryList)
        Me.Controls.Add(Me.lblDGVEntries)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxEventCat)
        Me.Controls.Add(Me.txtJournalText)
        Me.Controls.Add(Me.dtpJournalDate)
        Me.Controls.Add(Me.sstJournal)
        Me.Controls.Add(Me.mstJournal)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstJournal
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(600, 450)
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
    Friend WithEvents dtpJournalDate As DateTimePicker
    Friend WithEvents txtJournalText As AgnesTxt
    Friend WithEvents cbxEventCat As ComboBox
    Friend WithEvents mstJournal As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDGVEntries As Label
    Friend WithEvents tsslUnit As ToolStripStatusLabel
    Friend WithEvents tsmiClear As ToolStripMenuItem
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents dgvEntryList As DataGridView
    Friend WithEvents colPID As DataGridViewTextBoxColumn
    Friend WithEvents colDt As DataGridViewTextBoxColumn
    Friend WithEvents colCAT As DataGridViewTextBoxColumn
    Friend WithEvents colDetail As DataGridViewTextBoxColumn
End Class
