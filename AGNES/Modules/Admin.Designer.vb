<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mstAdmin = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstAdmin = New System.Windows.Forms.StatusStrip()
        Me.panUserAccess = New System.Windows.Forms.Panel()
        Me.splUserAccess = New System.Windows.Forms.SplitContainer()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxAccess = New System.Windows.Forms.ComboBox()
        Me.txtSpeakName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.AGNESUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGNESData = New AGNES.AGNESData()
        Me.btnAddEditUser = New System.Windows.Forms.Button()
        Me.dgvModules = New System.Windows.Forms.DataGridView()
        Me.ModuleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Access = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AGNESUsersTableAdapter = New AGNES.AGNESDataTableAdapters.AGNESUsersTableAdapter()
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAliasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mstAdmin.SuspendLayout()
        Me.panUserAccess.SuspendLayout()
        CType(Me.splUserAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splUserAccess.Panel1.SuspendLayout()
        Me.splUserAccess.Panel2.SuspendLayout()
        Me.splUserAccess.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGNESUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGNESData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvModules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mstAdmin
        '
        Me.mstAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile})
        Me.mstAdmin.Location = New System.Drawing.Point(0, 0)
        Me.mstAdmin.Name = "mstAdmin"
        Me.mstAdmin.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.mstAdmin.Size = New System.Drawing.Size(884, 25)
        Me.mstAdmin.TabIndex = 0
        Me.mstAdmin.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 19)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSave
        '
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
        'sstAdmin
        '
        Me.sstAdmin.Location = New System.Drawing.Point(0, 589)
        Me.sstAdmin.Name = "sstAdmin"
        Me.sstAdmin.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.sstAdmin.Size = New System.Drawing.Size(884, 22)
        Me.sstAdmin.SizingGrip = False
        Me.sstAdmin.TabIndex = 1
        Me.sstAdmin.Text = "StatusStrip1"
        '
        'panUserAccess
        '
        Me.panUserAccess.Controls.Add(Me.splUserAccess)
        Me.panUserAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panUserAccess.Location = New System.Drawing.Point(0, 25)
        Me.panUserAccess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panUserAccess.Name = "panUserAccess"
        Me.panUserAccess.Size = New System.Drawing.Size(884, 564)
        Me.panUserAccess.TabIndex = 3
        '
        'splUserAccess
        '
        Me.splUserAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splUserAccess.Location = New System.Drawing.Point(0, 0)
        Me.splUserAccess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splUserAccess.Name = "splUserAccess"
        '
        'splUserAccess.Panel1
        '
        Me.splUserAccess.Panel1.Controls.Add(Me.btnClear)
        Me.splUserAccess.Panel1.Controls.Add(Me.Label4)
        Me.splUserAccess.Panel1.Controls.Add(Me.Label3)
        Me.splUserAccess.Panel1.Controls.Add(Me.Label2)
        Me.splUserAccess.Panel1.Controls.Add(Me.Label1)
        Me.splUserAccess.Panel1.Controls.Add(Me.cbxAccess)
        Me.splUserAccess.Panel1.Controls.Add(Me.txtSpeakName)
        Me.splUserAccess.Panel1.Controls.Add(Me.txtName)
        Me.splUserAccess.Panel1.Controls.Add(Me.txtAlias)
        Me.splUserAccess.Panel1.Controls.Add(Me.dgvUsers)
        Me.splUserAccess.Panel1.Controls.Add(Me.btnAddEditUser)
        '
        'splUserAccess.Panel2
        '
        Me.splUserAccess.Panel2.Controls.Add(Me.dgvModules)
        Me.splUserAccess.Size = New System.Drawing.Size(884, 564)
        Me.splUserAccess.SplitterDistance = 452
        Me.splUserAccess.SplitterWidth = 5
        Me.splUserAccess.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(315, 144)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 30)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "User Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "User Alias"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Spoken Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Access Level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbxAccess
        '
        Me.cbxAccess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAccess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAccess.FormattingEnabled = True
        Me.cbxAccess.Items.AddRange(New Object() {"User", "Super User", "Admin"})
        Me.cbxAccess.Location = New System.Drawing.Point(22, 100)
        Me.cbxAccess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxAccess.Name = "cbxAccess"
        Me.cbxAccess.Size = New System.Drawing.Size(173, 25)
        Me.cbxAccess.TabIndex = 2
        '
        'txtSpeakName
        '
        Me.txtSpeakName.Location = New System.Drawing.Point(223, 100)
        Me.txtSpeakName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSpeakName.Name = "txtSpeakName"
        Me.txtSpeakName.Size = New System.Drawing.Size(179, 25)
        Me.txtSpeakName.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(144, 37)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(258, 25)
        Me.txtName.TabIndex = 1
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(22, 37)
        Me.txtAlias.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(116, 25)
        Me.txtAlias.TabIndex = 0
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.UserAliasDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.AccessLevelDataGridViewTextBoxColumn, Me.ShortnameDataGridViewTextBoxColumn})
        Me.dgvUsers.DataSource = Me.AGNESUsersBindingSource
        Me.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvUsers.Location = New System.Drawing.Point(0, 182)
        Me.dgvUsers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.Size = New System.Drawing.Size(452, 382)
        Me.dgvUsers.TabIndex = 2
        Me.dgvUsers.TabStop = False
        '
        'AGNESUsersBindingSource
        '
        Me.AGNESUsersBindingSource.DataMember = "AGNESUsers"
        Me.AGNESUsersBindingSource.DataSource = Me.AGNESData
        '
        'AGNESData
        '
        Me.AGNESData.DataSetName = "AGNESData"
        Me.AGNESData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAddEditUser
        '
        Me.btnAddEditUser.Location = New System.Drawing.Point(22, 144)
        Me.btnAddEditUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddEditUser.Name = "btnAddEditUser"
        Me.btnAddEditUser.Size = New System.Drawing.Size(87, 30)
        Me.btnAddEditUser.TabIndex = 4
        Me.btnAddEditUser.Text = "Add"
        Me.btnAddEditUser.UseVisualStyleBackColor = True
        '
        'dgvModules
        '
        Me.dgvModules.AllowUserToAddRows = False
        Me.dgvModules.AllowUserToDeleteRows = False
        Me.dgvModules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvModules.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModules.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModuleName, Me.Access})
        Me.dgvModules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvModules.Location = New System.Drawing.Point(0, 0)
        Me.dgvModules.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvModules.Name = "dgvModules"
        Me.dgvModules.RowHeadersVisible = False
        Me.dgvModules.Size = New System.Drawing.Size(427, 564)
        Me.dgvModules.TabIndex = 0
        Me.dgvModules.TabStop = False
        '
        'ModuleName
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModuleName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ModuleName.HeaderText = "Module"
        Me.ModuleName.MaxInputLength = 128
        Me.ModuleName.Name = "ModuleName"
        Me.ModuleName.ReadOnly = True
        Me.ModuleName.Width = 300
        '
        'Access
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.NullValue = False
        Me.Access.DefaultCellStyle = DataGridViewCellStyle4
        Me.Access.HeaderText = "Accessible"
        Me.Access.Name = "Access"
        Me.Access.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'AGNESUsersTableAdapter
        '
        Me.AGNESUsersTableAdapter.ClearBeforeFill = True
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "PID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "PID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        Me.PIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIDDataGridViewTextBoxColumn.Visible = False
        '
        'UserAliasDataGridViewTextBoxColumn
        '
        Me.UserAliasDataGridViewTextBoxColumn.DataPropertyName = "UserAlias"
        Me.UserAliasDataGridViewTextBoxColumn.HeaderText = "UserAlias"
        Me.UserAliasDataGridViewTextBoxColumn.Name = "UserAliasDataGridViewTextBoxColumn"
        Me.UserAliasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessLevelDataGridViewTextBoxColumn
        '
        Me.AccessLevelDataGridViewTextBoxColumn.DataPropertyName = "AccessLevel"
        Me.AccessLevelDataGridViewTextBoxColumn.HeaderText = "AccessLevel"
        Me.AccessLevelDataGridViewTextBoxColumn.Name = "AccessLevelDataGridViewTextBoxColumn"
        Me.AccessLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShortnameDataGridViewTextBoxColumn
        '
        Me.ShortnameDataGridViewTextBoxColumn.DataPropertyName = "Shortname"
        Me.ShortnameDataGridViewTextBoxColumn.HeaderText = "Shortname"
        Me.ShortnameDataGridViewTextBoxColumn.Name = "ShortnameDataGridViewTextBoxColumn"
        Me.ShortnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.panUserAccess)
        Me.Controls.Add(Me.sstAdmin)
        Me.Controls.Add(Me.mstAdmin)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mstAdmin
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(900, 650)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Panel"
        Me.mstAdmin.ResumeLayout(False)
        Me.mstAdmin.PerformLayout()
        Me.panUserAccess.ResumeLayout(False)
        Me.splUserAccess.Panel1.ResumeLayout(False)
        Me.splUserAccess.Panel1.PerformLayout()
        Me.splUserAccess.Panel2.ResumeLayout(False)
        CType(Me.splUserAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splUserAccess.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGNESUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGNESData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvModules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstAdmin As MenuStrip
    Friend WithEvents sstAdmin As StatusStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents AGNESData As AGNESData
    Friend WithEvents panUserAccess As Panel
    Friend WithEvents splUserAccess As SplitContainer
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnAddEditUser As Button
    Friend WithEvents dgvModules As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxAccess As ComboBox
    Friend WithEvents txtSpeakName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents AGNESUsersBindingSource As BindingSource
    Friend WithEvents AGNESUsersTableAdapter As AGNESDataTableAdapters.AGNESUsersTableAdapter
    Friend WithEvents btnClear As Button
    Friend WithEvents ModuleName As DataGridViewTextBoxColumn
    Friend WithEvents Access As DataGridViewCheckBoxColumn
    Friend WithEvents PIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserAliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
