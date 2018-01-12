<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorReceipts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorReceipts))
        Me.mstReceipts = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUnlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFoodTrucks = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMSP = New AGNES.PeriodSelector()
        Me.tsmiWeek = New AGNES.WeekSelector()
        Me.tsmiDate = New AGNES.DateSelector()
        Me.sstReceipts = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.spReceipts = New System.Windows.Forms.SplitContainer()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblCounts = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKPIAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKPIType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCamAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCamType = New System.Windows.Forms.TextBox()
        Me.txtVendorName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panAvailability = New System.Windows.Forms.Panel()
        Me.chkMon = New System.Windows.Forms.CheckBox()
        Me.chkTue = New System.Windows.Forms.CheckBox()
        Me.chkWed = New System.Windows.Forms.CheckBox()
        Me.chkThu = New System.Windows.Forms.CheckBox()
        Me.chkFri = New System.Windows.Forms.CheckBox()
        Me.tsslWeek = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mstReceipts.SuspendLayout()
        Me.sstReceipts.SuspendLayout()
        CType(Me.spReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spReceipts.Panel1.SuspendLayout()
        Me.spReceipts.Panel2.SuspendLayout()
        Me.spReceipts.SuspendLayout()
        Me.panAvailability.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstReceipts
        '
        Me.mstReceipts.BackColor = System.Drawing.Color.AliceBlue
        Me.mstReceipts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiView, Me.tsmiMSP, Me.tsmiWeek, Me.tsmiDate})
        Me.mstReceipts.Location = New System.Drawing.Point(0, 0)
        Me.mstReceipts.Name = "mstReceipts"
        Me.mstReceipts.Size = New System.Drawing.Size(654, 24)
        Me.mstReceipts.TabIndex = 1
        Me.mstReceipts.Text = "mstForecast"
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
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClear, Me.tsmiUnlock, Me.tsmiDelete})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiClear
        '
        Me.tsmiClear.Name = "tsmiClear"
        Me.tsmiClear.Size = New System.Drawing.Size(137, 22)
        Me.tsmiClear.Text = "Clear All"
        '
        'tsmiUnlock
        '
        Me.tsmiUnlock.Name = "tsmiUnlock"
        Me.tsmiUnlock.Size = New System.Drawing.Size(137, 22)
        Me.tsmiUnlock.Text = "Unlock"
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(137, 22)
        Me.tsmiDelete.Text = "Delete Entry"
        '
        'tsmiView
        '
        Me.tsmiView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRetail, Me.tsmiFoodTrucks})
        Me.tsmiView.Name = "tsmiView"
        Me.tsmiView.Size = New System.Drawing.Size(44, 20)
        Me.tsmiView.Text = "View"
        '
        'tsmiRetail
        '
        Me.tsmiRetail.Name = "tsmiRetail"
        Me.tsmiRetail.Size = New System.Drawing.Size(148, 22)
        Me.tsmiRetail.Text = "Retail Vendors"
        '
        'tsmiFoodTrucks
        '
        Me.tsmiFoodTrucks.Name = "tsmiFoodTrucks"
        Me.tsmiFoodTrucks.Size = New System.Drawing.Size(148, 22)
        Me.tsmiFoodTrucks.Text = "Food Trucks"
        '
        'tsmiMSP
        '
        Me.tsmiMSP.MaxPeriod = CType(12, Byte)
        Me.tsmiMSP.Name = "tsmiMSP"
        Me.tsmiMSP.Size = New System.Drawing.Size(107, 20)
        Me.tsmiMSP.Text = "Select MS Period"
        '
        'tsmiWeek
        '
        Me.tsmiWeek.MaxWeek = CType(4, Byte)
        Me.tsmiWeek.Name = "tsmiWeek"
        Me.tsmiWeek.Size = New System.Drawing.Size(82, 20)
        Me.tsmiWeek.Text = "Select Week"
        '
        'tsmiDate
        '
        Me.tsmiDate.Enabled = False
        Me.tsmiDate.Name = "tsmiDate"
        Me.tsmiDate.Size = New System.Drawing.Size(77, 20)
        Me.tsmiDate.Text = "Select Date"
        '
        'sstReceipts
        '
        Me.sstReceipts.BackColor = System.Drawing.Color.AliceBlue
        Me.sstReceipts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslFY, Me.tsslPeriod, Me.tsslWeek, Me.tsslDate, Me.tsslInformation, Me.tsslSaveStatus})
        Me.sstReceipts.Location = New System.Drawing.Point(0, 620)
        Me.sstReceipts.Name = "sstReceipts"
        Me.sstReceipts.Size = New System.Drawing.Size(654, 24)
        Me.sstReceipts.SizingGrip = False
        Me.sstReceipts.TabIndex = 2
        Me.sstReceipts.Text = "StatusStrip1"
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
        'tsslFY
        '
        Me.tsslFY.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslFY.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslFY.Name = "tsslFY"
        Me.tsslFY.Size = New System.Drawing.Size(39, 19)
        Me.tsslFY.Text = "FYear"
        '
        'tsslPeriod
        '
        Me.tsslPeriod.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslPeriod.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslPeriod.Name = "tsslPeriod"
        Me.tsslPeriod.Size = New System.Drawing.Size(45, 19)
        Me.tsslPeriod.Text = "Period"
        Me.tsslPeriod.Visible = False
        '
        'tsslDate
        '
        Me.tsslDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslDate.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslDate.Name = "tsslDate"
        Me.tsslDate.Size = New System.Drawing.Size(35, 19)
        Me.tsslDate.Text = "Date"
        Me.tsslDate.Visible = False
        '
        'tsslInformation
        '
        Me.tsslInformation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslInformation.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslInformation.Name = "tsslInformation"
        Me.tsslInformation.Size = New System.Drawing.Size(566, 19)
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
        'spReceipts
        '
        Me.spReceipts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spReceipts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spReceipts.IsSplitterFixed = True
        Me.spReceipts.Location = New System.Drawing.Point(0, 24)
        Me.spReceipts.Name = "spReceipts"
        Me.spReceipts.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spReceipts.Panel1
        '
        Me.spReceipts.Panel1.AutoScroll = True
        Me.spReceipts.Panel1.Controls.Add(Me.lblLocation)
        Me.spReceipts.Panel1.Controls.Add(Me.lblCounts)
        Me.spReceipts.Panel1.Controls.Add(Me.lblSales)
        Me.spReceipts.Panel1.Controls.Add(Me.lblVendor)
        '
        'spReceipts.Panel2
        '
        Me.spReceipts.Panel2.Controls.Add(Me.panAvailability)
        Me.spReceipts.Panel2.Controls.Add(Me.Label4)
        Me.spReceipts.Panel2.Controls.Add(Me.txtKPIAmount)
        Me.spReceipts.Panel2.Controls.Add(Me.Label5)
        Me.spReceipts.Panel2.Controls.Add(Me.txtKPIType)
        Me.spReceipts.Panel2.Controls.Add(Me.Label3)
        Me.spReceipts.Panel2.Controls.Add(Me.txtCamAmount)
        Me.spReceipts.Panel2.Controls.Add(Me.Label2)
        Me.spReceipts.Panel2.Controls.Add(Me.Label1)
        Me.spReceipts.Panel2.Controls.Add(Me.txtCamType)
        Me.spReceipts.Panel2.Controls.Add(Me.txtVendorName)
        Me.spReceipts.Size = New System.Drawing.Size(654, 596)
        Me.spReceipts.SplitterDistance = 440
        Me.spReceipts.TabIndex = 3
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(225, 5)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(90, 20)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Location"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCounts
        '
        Me.lblCounts.Location = New System.Drawing.Point(502, 5)
        Me.lblCounts.Name = "lblCounts"
        Me.lblCounts.Size = New System.Drawing.Size(80, 20)
        Me.lblCounts.TabIndex = 2
        Me.lblCounts.Text = "Counts"
        Me.lblCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSales
        '
        Me.lblSales.Location = New System.Drawing.Point(359, 5)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(134, 20)
        Me.lblSales.TabIndex = 1
        Me.lblSales.Text = "Sales"
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVendor
        '
        Me.lblVendor.Location = New System.Drawing.Point(10, 5)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(200, 20)
        Me.lblVendor.TabIndex = 0
        Me.lblVendor.Text = "Vendor Name"
        Me.lblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(548, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "KPI Amount"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKPIAmount
        '
        Me.txtKPIAmount.Enabled = False
        Me.txtKPIAmount.Location = New System.Drawing.Point(548, 41)
        Me.txtKPIAmount.Name = "txtKPIAmount"
        Me.txtKPIAmount.Size = New System.Drawing.Size(92, 25)
        Me.txtKPIAmount.TabIndex = 8
        Me.txtKPIAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(451, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 28)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "KPI Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKPIType
        '
        Me.txtKPIType.Enabled = False
        Me.txtKPIType.Location = New System.Drawing.Point(451, 41)
        Me.txtKPIType.Name = "txtKPIType"
        Me.txtKPIType.Size = New System.Drawing.Size(81, 25)
        Me.txtKPIType.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(343, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CAM Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCamAmount
        '
        Me.txtCamAmount.Enabled = False
        Me.txtCamAmount.Location = New System.Drawing.Point(343, 41)
        Me.txtCamAmount.Name = "txtCamAmount"
        Me.txtCamAmount.Size = New System.Drawing.Size(92, 25)
        Me.txtCamAmount.TabIndex = 4
        Me.txtCamAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(245, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CAM Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vendor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCamType
        '
        Me.txtCamType.Enabled = False
        Me.txtCamType.Location = New System.Drawing.Point(246, 41)
        Me.txtCamType.Name = "txtCamType"
        Me.txtCamType.Size = New System.Drawing.Size(81, 25)
        Me.txtCamType.TabIndex = 1
        '
        'txtVendorName
        '
        Me.txtVendorName.Enabled = False
        Me.txtVendorName.Location = New System.Drawing.Point(14, 41)
        Me.txtVendorName.Name = "txtVendorName"
        Me.txtVendorName.Size = New System.Drawing.Size(216, 25)
        Me.txtVendorName.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(625, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Schedule Availability"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panAvailability
        '
        Me.panAvailability.Controls.Add(Me.chkFri)
        Me.panAvailability.Controls.Add(Me.chkThu)
        Me.panAvailability.Controls.Add(Me.chkWed)
        Me.panAvailability.Controls.Add(Me.chkTue)
        Me.panAvailability.Controls.Add(Me.chkMon)
        Me.panAvailability.Controls.Add(Me.Label6)
        Me.panAvailability.Enabled = False
        Me.panAvailability.Location = New System.Drawing.Point(14, 76)
        Me.panAvailability.Name = "panAvailability"
        Me.panAvailability.Size = New System.Drawing.Size(626, 68)
        Me.panAvailability.TabIndex = 11
        '
        'chkMon
        '
        Me.chkMon.Location = New System.Drawing.Point(18, 25)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(100, 25)
        Me.chkMon.TabIndex = 12
        Me.chkMon.Text = "Monday"
        Me.chkMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'chkTue
        '
        Me.chkTue.Location = New System.Drawing.Point(144, 25)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(100, 25)
        Me.chkTue.TabIndex = 13
        Me.chkTue.Text = "Tuesday"
        Me.chkTue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTue.UseVisualStyleBackColor = True
        '
        'chkWed
        '
        Me.chkWed.Location = New System.Drawing.Point(270, 25)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(100, 25)
        Me.chkWed.TabIndex = 14
        Me.chkWed.Text = "Wednesday"
        Me.chkWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'chkThu
        '
        Me.chkThu.Location = New System.Drawing.Point(396, 25)
        Me.chkThu.Name = "chkThu"
        Me.chkThu.Size = New System.Drawing.Size(100, 25)
        Me.chkThu.TabIndex = 15
        Me.chkThu.Text = "Thursday"
        Me.chkThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkThu.UseVisualStyleBackColor = True
        '
        'chkFri
        '
        Me.chkFri.Location = New System.Drawing.Point(522, 25)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(100, 25)
        Me.chkFri.TabIndex = 16
        Me.chkFri.Text = "Friday"
        Me.chkFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'tsslWeek
        '
        Me.tsslWeek.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslWeek.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslWeek.Name = "tsslWeek"
        Me.tsslWeek.Size = New System.Drawing.Size(40, 19)
        Me.tsslWeek.Text = "Week"
        Me.tsslWeek.Visible = False
        '
        'VendorReceipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(654, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.spReceipts)
        Me.Controls.Add(Me.sstReceipts)
        Me.Controls.Add(Me.mstReceipts)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(660, 650)
        Me.MinimumSize = New System.Drawing.Size(660, 650)
        Me.Name = "VendorReceipts"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstReceipts.ResumeLayout(False)
        Me.mstReceipts.PerformLayout()
        Me.sstReceipts.ResumeLayout(False)
        Me.sstReceipts.PerformLayout()
        Me.spReceipts.Panel1.ResumeLayout(False)
        Me.spReceipts.Panel2.ResumeLayout(False)
        Me.spReceipts.Panel2.PerformLayout()
        CType(Me.spReceipts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spReceipts.ResumeLayout(False)
        Me.panAvailability.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstReceipts As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiClear As ToolStripMenuItem
    Friend WithEvents tsmiUnlock As ToolStripMenuItem
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents tsmiView As ToolStripMenuItem
    Friend WithEvents tsmiRetail As ToolStripMenuItem
    Friend WithEvents tsmiMSP As PeriodSelector
    Friend WithEvents sstReceipts As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslInformation As ToolStripStatusLabel
    Friend WithEvents tsslSaveStatus As ToolStripStatusLabel
    Friend WithEvents tsmiFoodTrucks As ToolStripMenuItem
    Friend WithEvents tsmiWeek As WeekSelector
    Friend WithEvents spReceipts As SplitContainer
    Friend WithEvents tsslDate As ToolStripStatusLabel
    Friend WithEvents tsmiDate As DateSelector
    Friend WithEvents txtVendorName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKPIAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKPIType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCamAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCamType As TextBox
    Friend WithEvents lblVendor As Label
    Friend WithEvents lblCounts As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents panAvailability As Panel
    Friend WithEvents chkFri As CheckBox
    Friend WithEvents chkThu As CheckBox
    Friend WithEvents chkWed As CheckBox
    Friend WithEvents chkTue As CheckBox
    Friend WithEvents chkMon As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tsslWeek As ToolStripStatusLabel
End Class
