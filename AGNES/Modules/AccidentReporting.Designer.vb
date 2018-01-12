<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccidentReporting
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccidentReporting))
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReportingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudLostTime = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExpense = New System.Windows.Forms.TextBox()
        Me.txtIncidentID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxUnit = New System.Windows.Forms.ComboBox()
        Me.cbxGroup = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.chkMedical = New System.Windows.Forms.CheckBox()
        Me.AGNESData = New AGNES.AGNESData()
        Me.AccidentReportingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccidentReportingTableAdapter = New AGNES.AGNESDataTableAdapters.AccidentReportingTableAdapter()
        Me.dgvIncidentGrid = New System.Windows.Forms.DataGridView()
        Me.AccidentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccidentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssociatesNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccidentDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TimeLossDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LateReportingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountChargedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncidentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mstIncidentMenuBar = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstFlashStatus = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtAssociate = New AGNES.AgnesTxt()
        Me.curActualCharge = New AGNES.CurrencyBox()
        CType(Me.nudLostTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGNESData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccidentReportingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIncidentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mstIncidentMenuBar.SuspendLayout()
        Me.sstFlashStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIncidentDate.Location = New System.Drawing.Point(12, 58)
        Me.dtpIncidentDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpIncidentDate.MinDate = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(179, 39)
        Me.dtpIncidentDate.TabIndex = 0
        '
        'dtpReportingDate
        '
        Me.dtpReportingDate.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReportingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReportingDate.Location = New System.Drawing.Point(200, 58)
        Me.dtpReportingDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpReportingDate.MinDate = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dtpReportingDate.Name = "dtpReportingDate"
        Me.dtpReportingDate.Size = New System.Drawing.Size(179, 39)
        Me.dtpReportingDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Incident Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reporting Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Associate's Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(674, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Department/Unit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(12, 207)
        Me.txtDescription.MaxLength = 320
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ShortcutsEnabled = False
        Me.txtDescription.Size = New System.Drawing.Size(936, 90)
        Me.txtDescription.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(935, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Incident Description"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nudLostTime
        '
        Me.nudLostTime.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLostTime.Location = New System.Drawing.Point(889, 129)
        Me.nudLostTime.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.nudLostTime.Name = "nudLostTime"
        Me.nudLostTime.Size = New System.Drawing.Size(58, 39)
        Me.nudLostTime.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(732, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 39)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Lost Work Days:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 37)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Estimated Expense:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtExpense
        '
        Me.txtExpense.BackColor = System.Drawing.SystemColors.Menu
        Me.txtExpense.Enabled = False
        Me.txtExpense.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpense.Location = New System.Drawing.Point(200, 314)
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.Size = New System.Drawing.Size(134, 39)
        Me.txtExpense.TabIndex = 15
        Me.txtExpense.TabStop = False
        Me.txtExpense.Text = "$0.00"
        Me.txtExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIncidentID
        '
        Me.txtIncidentID.Location = New System.Drawing.Point(435, 322)
        Me.txtIncidentID.Name = "txtIncidentID"
        Me.txtIncidentID.Size = New System.Drawing.Size(100, 25)
        Me.txtIncidentID.TabIndex = 16
        Me.txtIncidentID.TabStop = False
        Me.txtIncidentID.Text = "0"
        Me.txtIncidentID.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(646, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 40)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Actual Expense:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxUnit
        '
        Me.cbxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxUnit.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUnit.FormattingEnabled = True
        Me.cbxUnit.Location = New System.Drawing.Point(673, 58)
        Me.cbxUnit.Name = "cbxUnit"
        Me.cbxUnit.Size = New System.Drawing.Size(275, 40)
        Me.cbxUnit.TabIndex = 3
        '
        'cbxGroup
        '
        Me.cbxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxGroup.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGroup.FormattingEnabled = True
        Me.cbxGroup.Location = New System.Drawing.Point(391, 58)
        Me.cbxGroup.Name = "cbxGroup"
        Me.cbxGroup.Size = New System.Drawing.Size(275, 40)
        Me.cbxGroup.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(392, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(275, 26)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Reporting Group"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(296, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(278, 26)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Incident Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbxType
        '
        Me.cbxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxType.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Location = New System.Drawing.Point(296, 129)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(278, 40)
        Me.cbxType.TabIndex = 5
        '
        'chkMedical
        '
        Me.chkMedical.AutoSize = True
        Me.chkMedical.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMedical.Location = New System.Drawing.Point(608, 132)
        Me.chkMedical.Name = "chkMedical"
        Me.chkMedical.Size = New System.Drawing.Size(107, 30)
        Me.chkMedical.TabIndex = 6
        Me.chkMedical.Text = "Medical?"
        Me.chkMedical.UseVisualStyleBackColor = True
        '
        'AGNESData
        '
        Me.AGNESData.DataSetName = "AGNESData"
        Me.AGNESData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccidentReportingBindingSource
        '
        Me.AccidentReportingBindingSource.DataMember = "AccidentReporting"
        Me.AccidentReportingBindingSource.DataSource = Me.AGNESData
        '
        'AccidentReportingTableAdapter
        '
        Me.AccidentReportingTableAdapter.ClearBeforeFill = True
        '
        'dgvIncidentGrid
        '
        Me.dgvIncidentGrid.AllowUserToAddRows = False
        Me.dgvIncidentGrid.AllowUserToDeleteRows = False
        Me.dgvIncidentGrid.AllowUserToResizeColumns = False
        Me.dgvIncidentGrid.AllowUserToResizeRows = False
        Me.dgvIncidentGrid.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIncidentGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIncidentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncidentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccidentIDDataGridViewTextBoxColumn, Me.AccidentDateDataGridViewTextBoxColumn, Me.DateReportedDataGridViewTextBoxColumn, Me.DepartmentUnitDataGridViewTextBoxColumn, Me.AssociatesNameDataGridViewTextBoxColumn, Me.AccidentDescriptionDataGridViewTextBoxColumn, Me.MedicalDataGridViewTextBoxColumn, Me.TimeLossDataGridViewTextBoxColumn, Me.LateReportingDataGridViewTextBoxColumn, Me.AmountChargedDataGridViewTextBoxColumn, Me.EstimatedAmtDataGridViewTextBoxColumn, Me.ReportGroupDataGridViewTextBoxColumn, Me.IncidentTypeDataGridViewTextBoxColumn})
        Me.dgvIncidentGrid.DataSource = Me.AccidentReportingBindingSource
        Me.dgvIncidentGrid.Location = New System.Drawing.Point(17, 369)
        Me.dgvIncidentGrid.Name = "dgvIncidentGrid"
        Me.dgvIncidentGrid.ReadOnly = True
        Me.dgvIncidentGrid.RowHeadersVisible = False
        Me.dgvIncidentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIncidentGrid.Size = New System.Drawing.Size(931, 237)
        Me.dgvIncidentGrid.TabIndex = 102
        Me.dgvIncidentGrid.TabStop = False
        '
        'AccidentIDDataGridViewTextBoxColumn
        '
        Me.AccidentIDDataGridViewTextBoxColumn.DataPropertyName = "AccidentID"
        Me.AccidentIDDataGridViewTextBoxColumn.HeaderText = "AccidentID"
        Me.AccidentIDDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.AccidentIDDataGridViewTextBoxColumn.Name = "AccidentIDDataGridViewTextBoxColumn"
        Me.AccidentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccidentIDDataGridViewTextBoxColumn.Visible = False
        '
        'AccidentDateDataGridViewTextBoxColumn
        '
        Me.AccidentDateDataGridViewTextBoxColumn.DataPropertyName = "Accident Date"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.AccidentDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccidentDateDataGridViewTextBoxColumn.HeaderText = "Incident Date"
        Me.AccidentDateDataGridViewTextBoxColumn.MaxInputLength = 16
        Me.AccidentDateDataGridViewTextBoxColumn.Name = "AccidentDateDataGridViewTextBoxColumn"
        Me.AccidentDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccidentDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccidentDateDataGridViewTextBoxColumn.Width = 75
        '
        'DateReportedDataGridViewTextBoxColumn
        '
        Me.DateReportedDataGridViewTextBoxColumn.DataPropertyName = "Date reported"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateReportedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateReportedDataGridViewTextBoxColumn.HeaderText = "Report Date"
        Me.DateReportedDataGridViewTextBoxColumn.MaxInputLength = 16
        Me.DateReportedDataGridViewTextBoxColumn.Name = "DateReportedDataGridViewTextBoxColumn"
        Me.DateReportedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateReportedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DateReportedDataGridViewTextBoxColumn.Width = 75
        '
        'DepartmentUnitDataGridViewTextBoxColumn
        '
        Me.DepartmentUnitDataGridViewTextBoxColumn.DataPropertyName = "Department/Unit"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentUnitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DepartmentUnitDataGridViewTextBoxColumn.HeaderText = "Dept/Unit"
        Me.DepartmentUnitDataGridViewTextBoxColumn.MaxInputLength = 128
        Me.DepartmentUnitDataGridViewTextBoxColumn.Name = "DepartmentUnitDataGridViewTextBoxColumn"
        Me.DepartmentUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentUnitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DepartmentUnitDataGridViewTextBoxColumn.Width = 150
        '
        'AssociatesNameDataGridViewTextBoxColumn
        '
        Me.AssociatesNameDataGridViewTextBoxColumn.DataPropertyName = "Associate's name"
        Me.AssociatesNameDataGridViewTextBoxColumn.HeaderText = "Associate's name"
        Me.AssociatesNameDataGridViewTextBoxColumn.MaxInputLength = 128
        Me.AssociatesNameDataGridViewTextBoxColumn.Name = "AssociatesNameDataGridViewTextBoxColumn"
        Me.AssociatesNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.AssociatesNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssociatesNameDataGridViewTextBoxColumn.Width = 200
        '
        'AccidentDescriptionDataGridViewTextBoxColumn
        '
        Me.AccidentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Accident Description"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccidentDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.AccidentDescriptionDataGridViewTextBoxColumn.HeaderText = "Incident Description"
        Me.AccidentDescriptionDataGridViewTextBoxColumn.MaxInputLength = 255
        Me.AccidentDescriptionDataGridViewTextBoxColumn.Name = "AccidentDescriptionDataGridViewTextBoxColumn"
        Me.AccidentDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccidentDescriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccidentDescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'MedicalDataGridViewTextBoxColumn
        '
        Me.MedicalDataGridViewTextBoxColumn.DataPropertyName = "Medical"
        Me.MedicalDataGridViewTextBoxColumn.HeaderText = "Med Exp?"
        Me.MedicalDataGridViewTextBoxColumn.Name = "MedicalDataGridViewTextBoxColumn"
        Me.MedicalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MedicalDataGridViewTextBoxColumn.Width = 60
        '
        'TimeLossDataGridViewTextBoxColumn
        '
        Me.TimeLossDataGridViewTextBoxColumn.DataPropertyName = "Time Loss"
        Me.TimeLossDataGridViewTextBoxColumn.HeaderText = "Lost Time"
        Me.TimeLossDataGridViewTextBoxColumn.MaxInputLength = 3
        Me.TimeLossDataGridViewTextBoxColumn.Name = "TimeLossDataGridViewTextBoxColumn"
        Me.TimeLossDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeLossDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TimeLossDataGridViewTextBoxColumn.Width = 60
        '
        'LateReportingDataGridViewTextBoxColumn
        '
        Me.LateReportingDataGridViewTextBoxColumn.DataPropertyName = "Late Reporting"
        Me.LateReportingDataGridViewTextBoxColumn.HeaderText = "Late Reporting"
        Me.LateReportingDataGridViewTextBoxColumn.MaxInputLength = 4
        Me.LateReportingDataGridViewTextBoxColumn.Name = "LateReportingDataGridViewTextBoxColumn"
        Me.LateReportingDataGridViewTextBoxColumn.ReadOnly = True
        Me.LateReportingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LateReportingDataGridViewTextBoxColumn.Visible = False
        '
        'AmountChargedDataGridViewTextBoxColumn
        '
        Me.AmountChargedDataGridViewTextBoxColumn.DataPropertyName = "AmountCharged"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.AmountChargedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.AmountChargedDataGridViewTextBoxColumn.HeaderText = "Charged Amt"
        Me.AmountChargedDataGridViewTextBoxColumn.MaxInputLength = 16
        Me.AmountChargedDataGridViewTextBoxColumn.Name = "AmountChargedDataGridViewTextBoxColumn"
        Me.AmountChargedDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountChargedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AmountChargedDataGridViewTextBoxColumn.Width = 75
        '
        'EstimatedAmtDataGridViewTextBoxColumn
        '
        Me.EstimatedAmtDataGridViewTextBoxColumn.DataPropertyName = "EstimatedAmt"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.EstimatedAmtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.EstimatedAmtDataGridViewTextBoxColumn.HeaderText = "EstimatedAmt"
        Me.EstimatedAmtDataGridViewTextBoxColumn.MaxInputLength = 8
        Me.EstimatedAmtDataGridViewTextBoxColumn.Name = "EstimatedAmtDataGridViewTextBoxColumn"
        Me.EstimatedAmtDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstimatedAmtDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EstimatedAmtDataGridViewTextBoxColumn.Visible = False
        '
        'ReportGroupDataGridViewTextBoxColumn
        '
        Me.ReportGroupDataGridViewTextBoxColumn.DataPropertyName = "ReportGroup"
        Me.ReportGroupDataGridViewTextBoxColumn.HeaderText = "ReportGroup"
        Me.ReportGroupDataGridViewTextBoxColumn.MaxInputLength = 128
        Me.ReportGroupDataGridViewTextBoxColumn.Name = "ReportGroupDataGridViewTextBoxColumn"
        Me.ReportGroupDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReportGroupDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReportGroupDataGridViewTextBoxColumn.Visible = False
        '
        'IncidentTypeDataGridViewTextBoxColumn
        '
        Me.IncidentTypeDataGridViewTextBoxColumn.DataPropertyName = "IncidentType"
        Me.IncidentTypeDataGridViewTextBoxColumn.HeaderText = "IncidentType"
        Me.IncidentTypeDataGridViewTextBoxColumn.MaxInputLength = 128
        Me.IncidentTypeDataGridViewTextBoxColumn.Name = "IncidentTypeDataGridViewTextBoxColumn"
        Me.IncidentTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.IncidentTypeDataGridViewTextBoxColumn.Visible = False
        '
        'mstIncidentMenuBar
        '
        Me.mstIncidentMenuBar.BackColor = System.Drawing.Color.AliceBlue
        Me.mstIncidentMenuBar.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstIncidentMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile})
        Me.mstIncidentMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mstIncidentMenuBar.Name = "mstIncidentMenuBar"
        Me.mstIncidentMenuBar.Size = New System.Drawing.Size(958, 25)
        Me.mstIncidentMenuBar.TabIndex = 103
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
        Me.tsmiSave.Size = New System.Drawing.Size(147, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tsmiExit.Size = New System.Drawing.Size(147, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'sstFlashStatus
        '
        Me.sstFlashStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.sstFlashStatus.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstFlashStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser})
        Me.sstFlashStatus.Location = New System.Drawing.Point(0, 622)
        Me.sstFlashStatus.Name = "sstFlashStatus"
        Me.sstFlashStatus.Size = New System.Drawing.Size(958, 26)
        Me.sstFlashStatus.SizingGrip = False
        Me.sstFlashStatus.TabIndex = 104
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
        'txtAssociate
        '
        Me.txtAssociate.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssociate.Location = New System.Drawing.Point(12, 129)
        Me.txtAssociate.MaxLength = 255
        Me.txtAssociate.Name = "txtAssociate"
        Me.txtAssociate.Size = New System.Drawing.Size(278, 39)
        Me.txtAssociate.TabIndex = 4
        '
        'curActualCharge
        '
        Me.curActualCharge.AllowCredit = True
        Me.curActualCharge.Cursor = System.Windows.Forms.Cursors.Default
        Me.curActualCharge.Debit = True
        Me.curActualCharge.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curActualCharge.Location = New System.Drawing.Point(812, 314)
        Me.curActualCharge.MaxLength = 16
        Me.curActualCharge.Name = "curActualCharge"
        Me.curActualCharge.OpenValue = False
        Me.curActualCharge.PosNegFont = False
        Me.curActualCharge.Size = New System.Drawing.Size(134, 39)
        Me.curActualCharge.TabIndex = 9
        Me.curActualCharge.Text = "$0.00"
        Me.curActualCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AccidentReporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(958, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.curActualCharge)
        Me.Controls.Add(Me.txtAssociate)
        Me.Controls.Add(Me.sstFlashStatus)
        Me.Controls.Add(Me.mstIncidentMenuBar)
        Me.Controls.Add(Me.dgvIncidentGrid)
        Me.Controls.Add(Me.chkMedical)
        Me.Controls.Add(Me.cbxType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxGroup)
        Me.Controls.Add(Me.cbxUnit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIncidentID)
        Me.Controls.Add(Me.txtExpense)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudLostTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpReportingDate)
        Me.Controls.Add(Me.dtpIncidentDate)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(960, 650)
        Me.MinimumSize = New System.Drawing.Size(960, 650)
        Me.Name = "AccidentReporting"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.nudLostTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGNESData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccidentReportingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIncidentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mstIncidentMenuBar.ResumeLayout(False)
        Me.mstIncidentMenuBar.PerformLayout()
        Me.sstFlashStatus.ResumeLayout(False)
        Me.sstFlashStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpIncidentDate As DateTimePicker
    Friend WithEvents dtpReportingDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudLostTime As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtExpense As TextBox
    Friend WithEvents txtIncidentID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxUnit As ComboBox
    Friend WithEvents cbxGroup As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbxType As ComboBox
    Friend WithEvents chkMedical As CheckBox
    Friend WithEvents AGNESData As AGNESData
    Friend WithEvents AccidentReportingBindingSource As BindingSource
    Friend WithEvents AccidentReportingTableAdapter As AGNESDataTableAdapters.AccidentReportingTableAdapter
    Friend WithEvents dgvIncidentGrid As DataGridView
    Friend WithEvents AccidentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccidentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReportedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssociatesNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccidentDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TimeLossDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LateReportingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountChargedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncidentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mstIncidentMenuBar As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents sstFlashStatus As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents txtAssociate As AgnesTxt
    Friend WithEvents curActualCharge As CurrencyBox
End Class
