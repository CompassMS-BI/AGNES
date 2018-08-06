<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WeeklyForecast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeeklyForecast))
        Me.mstForecast = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRefreshDRR = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiApplyDRR = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpDays = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMSP = New AGNES.PeriodSelector()
        Me.sstForecast = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPeriodDays = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDRR = New System.Windows.Forms.Label()
        Me.lblWeek1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalPerc = New System.Windows.Forms.Label()
        Me.lblBudgetPerc = New System.Windows.Forms.Label()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.lblVariance = New System.Windows.Forms.Label()
        Me.lblWeek2 = New System.Windows.Forms.Label()
        Me.lblWeek3 = New System.Windows.Forms.Label()
        Me.lblWeek4 = New System.Windows.Forms.Label()
        Me.lblWeek5 = New System.Windows.Forms.Label()
        Me.FlashRecordsTableAdapter1 = New AGNES.AGNESDataTableAdapters.FlashRecordsTableAdapter()
        Me.panForecast = New System.Windows.Forms.Panel()
        Me.PrintFlash = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnAshrt1 = New System.Windows.Forms.Button()
        Me.btnAshrt2 = New System.Windows.Forms.Button()
        Me.btnAshrt3 = New System.Windows.Forms.Button()
        Me.btnAshrt4 = New System.Windows.Forms.Button()
        Me.btnAshrt5 = New System.Windows.Forms.Button()
        Me.mstForecast.SuspendLayout()
        Me.sstForecast.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstForecast
        '
        Me.mstForecast.BackColor = System.Drawing.Color.AliceBlue
        Me.mstForecast.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiTools, Me.tsmiMSP})
        Me.mstForecast.Location = New System.Drawing.Point(0, 0)
        Me.mstForecast.Name = "mstForecast"
        Me.mstForecast.Size = New System.Drawing.Size(968, 24)
        Me.mstForecast.TabIndex = 0
        Me.mstForecast.Text = "mstForecast"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiPrint, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(99, 22)
        Me.tsmiSave.Text = "Save"
        '
        'tsmiPrint
        '
        Me.tsmiPrint.Name = "tsmiPrint"
        Me.tsmiPrint.Size = New System.Drawing.Size(99, 22)
        Me.tsmiPrint.Text = "Print"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(99, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClear, Me.tsmiRefreshDRR, Me.tsmiApplyDRR, Me.tsmiOpDays})
        Me.tsmiEdit.Enabled = False
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmiEdit.Text = "Edit"
        '
        'tsmiClear
        '
        Me.tsmiClear.Name = "tsmiClear"
        Me.tsmiClear.Size = New System.Drawing.Size(201, 22)
        Me.tsmiClear.Text = "Clear All"
        '
        'tsmiRefreshDRR
        '
        Me.tsmiRefreshDRR.Name = "tsmiRefreshDRR"
        Me.tsmiRefreshDRR.Size = New System.Drawing.Size(201, 22)
        Me.tsmiRefreshDRR.Text = "Refresh daily run rates"
        '
        'tsmiApplyDRR
        '
        Me.tsmiApplyDRR.Name = "tsmiApplyDRR"
        Me.tsmiApplyDRR.Size = New System.Drawing.Size(201, 22)
        Me.tsmiApplyDRR.Text = "Apply DRR to all weeks"
        '
        'tsmiOpDays
        '
        Me.tsmiOpDays.Name = "tsmiOpDays"
        Me.tsmiOpDays.Size = New System.Drawing.Size(201, 22)
        Me.tsmiOpDays.Text = "Manage Operating Days"
        '
        'tsmiTools
        '
        Me.tsmiTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCalc})
        Me.tsmiTools.Name = "tsmiTools"
        Me.tsmiTools.Size = New System.Drawing.Size(47, 20)
        Me.tsmiTools.Text = "Tools"
        '
        'tsmiCalc
        '
        Me.tsmiCalc.Name = "tsmiCalc"
        Me.tsmiCalc.Size = New System.Drawing.Size(128, 22)
        Me.tsmiCalc.Text = "Calculator"
        '
        'tsmiMSP
        '
        Me.tsmiMSP.MaxPeriod = CType(12, Byte)
        Me.tsmiMSP.MSP = CType(0, Byte)
        Me.tsmiMSP.Name = "tsmiMSP"
        Me.tsmiMSP.Size = New System.Drawing.Size(107, 20)
        Me.tsmiMSP.Text = "Select MS Period"
        '
        'sstForecast
        '
        Me.sstForecast.BackColor = System.Drawing.Color.AliceBlue
        Me.sstForecast.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser, Me.tsslFY, Me.tsslPeriod, Me.tsslPeriodDays, Me.tsslInformation, Me.tsslSaveStatus})
        Me.sstForecast.Location = New System.Drawing.Point(0, 464)
        Me.sstForecast.Name = "sstForecast"
        Me.sstForecast.Size = New System.Drawing.Size(968, 24)
        Me.sstForecast.SizingGrip = False
        Me.sstForecast.TabIndex = 1
        Me.sstForecast.Text = "StatusStrip1"
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
        '
        'tsslPeriodDays
        '
        Me.tsslPeriodDays.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslPeriodDays.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslPeriodDays.Name = "tsslPeriodDays"
        Me.tsslPeriodDays.Size = New System.Drawing.Size(73, 19)
        Me.tsslPeriodDays.Text = "Period Days"
        '
        'tsslInformation
        '
        Me.tsslInformation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslInformation.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslInformation.Name = "tsslInformation"
        Me.tsslInformation.Size = New System.Drawing.Size(762, 19)
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
        'lblDRR
        '
        Me.lblDRR.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRR.Location = New System.Drawing.Point(66, 90)
        Me.lblDRR.Name = "lblDRR"
        Me.lblDRR.Size = New System.Drawing.Size(75, 34)
        Me.lblDRR.TabIndex = 32
        Me.lblDRR.Text = "Daily Run Rate"
        Me.lblDRR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek1
        '
        Me.lblWeek1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek1.Location = New System.Drawing.Point(147, 90)
        Me.lblWeek1.Name = "lblWeek1"
        Me.lblWeek1.Size = New System.Drawing.Size(75, 34)
        Me.lblWeek1.TabIndex = 33
        Me.lblWeek1.Text = "Week 1"
        Me.lblWeek1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(552, 90)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 34)
        Me.lblTotal.TabIndex = 38
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPerc
        '
        Me.lblTotalPerc.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPerc.Location = New System.Drawing.Point(633, 90)
        Me.lblTotalPerc.Name = "lblTotalPerc"
        Me.lblTotalPerc.Size = New System.Drawing.Size(75, 34)
        Me.lblTotalPerc.TabIndex = 39
        Me.lblTotalPerc.Text = "%"
        Me.lblTotalPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBudgetPerc
        '
        Me.lblBudgetPerc.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudgetPerc.Location = New System.Drawing.Point(795, 90)
        Me.lblBudgetPerc.Name = "lblBudgetPerc"
        Me.lblBudgetPerc.Size = New System.Drawing.Size(75, 34)
        Me.lblBudgetPerc.TabIndex = 40
        Me.lblBudgetPerc.Text = "%"
        Me.lblBudgetPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBudget
        '
        Me.lblBudget.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(714, 90)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(75, 34)
        Me.lblBudget.TabIndex = 41
        Me.lblBudget.Text = "Budget"
        Me.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVariance
        '
        Me.lblVariance.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariance.Location = New System.Drawing.Point(876, 90)
        Me.lblVariance.Name = "lblVariance"
        Me.lblVariance.Size = New System.Drawing.Size(75, 34)
        Me.lblVariance.TabIndex = 42
        Me.lblVariance.Text = "Variance"
        Me.lblVariance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek2
        '
        Me.lblWeek2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek2.Location = New System.Drawing.Point(228, 90)
        Me.lblWeek2.Name = "lblWeek2"
        Me.lblWeek2.Size = New System.Drawing.Size(75, 34)
        Me.lblWeek2.TabIndex = 55
        Me.lblWeek2.Text = "Week 2"
        Me.lblWeek2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek3
        '
        Me.lblWeek3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek3.Location = New System.Drawing.Point(309, 90)
        Me.lblWeek3.Name = "lblWeek3"
        Me.lblWeek3.Size = New System.Drawing.Size(75, 34)
        Me.lblWeek3.TabIndex = 56
        Me.lblWeek3.Text = "Week 3"
        Me.lblWeek3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek4
        '
        Me.lblWeek4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek4.Location = New System.Drawing.Point(390, 90)
        Me.lblWeek4.Name = "lblWeek4"
        Me.lblWeek4.Size = New System.Drawing.Size(75, 34)
        Me.lblWeek4.TabIndex = 57
        Me.lblWeek4.Text = "Week 4"
        Me.lblWeek4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek5
        '
        Me.lblWeek5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek5.Location = New System.Drawing.Point(471, 90)
        Me.lblWeek5.Name = "lblWeek5"
        Me.lblWeek5.Size = New System.Drawing.Size(75, 34)
        Me.lblWeek5.TabIndex = 58
        Me.lblWeek5.Text = "Week 5"
        Me.lblWeek5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlashRecordsTableAdapter1
        '
        Me.FlashRecordsTableAdapter1.ClearBeforeFill = True
        '
        'panForecast
        '
        Me.panForecast.AutoScroll = True
        Me.panForecast.Location = New System.Drawing.Point(0, 127)
        Me.panForecast.Name = "panForecast"
        Me.panForecast.Size = New System.Drawing.Size(968, 335)
        Me.panForecast.TabIndex = 59
        '
        'PrintFlash
        '
        Me.PrintFlash.DocumentName = "document"
        Me.PrintFlash.Form = Me
        Me.PrintFlash.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintFlash.PrinterSettings = CType(resources.GetObject("PrintFlash.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFlash.PrintFileName = Nothing
        '
        'btnAshrt1
        '
        Me.btnAshrt1.Enabled = False
        Me.btnAshrt1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAshrt1.Location = New System.Drawing.Point(150, 27)
        Me.btnAshrt1.Name = "btnAshrt1"
        Me.btnAshrt1.Size = New System.Drawing.Size(72, 58)
        Me.btnAshrt1.TabIndex = 60
        Me.btnAshrt1.TabStop = False
        Me.btnAshrt1.Tag = "1"
        Me.btnAshrt1.Text = "Week 1 Associate Shortages"
        Me.btnAshrt1.UseVisualStyleBackColor = True
        '
        'btnAshrt2
        '
        Me.btnAshrt2.Enabled = False
        Me.btnAshrt2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAshrt2.Location = New System.Drawing.Point(231, 27)
        Me.btnAshrt2.Name = "btnAshrt2"
        Me.btnAshrt2.Size = New System.Drawing.Size(72, 58)
        Me.btnAshrt2.TabIndex = 61
        Me.btnAshrt2.TabStop = False
        Me.btnAshrt2.Tag = "2"
        Me.btnAshrt2.Text = "Week 2 Associate Shortages"
        Me.btnAshrt2.UseVisualStyleBackColor = True
        '
        'btnAshrt3
        '
        Me.btnAshrt3.Enabled = False
        Me.btnAshrt3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAshrt3.Location = New System.Drawing.Point(312, 27)
        Me.btnAshrt3.Name = "btnAshrt3"
        Me.btnAshrt3.Size = New System.Drawing.Size(72, 58)
        Me.btnAshrt3.TabIndex = 62
        Me.btnAshrt3.TabStop = False
        Me.btnAshrt3.Tag = "3"
        Me.btnAshrt3.Text = "Week 3 Associate Shortages"
        Me.btnAshrt3.UseVisualStyleBackColor = True
        '
        'btnAshrt4
        '
        Me.btnAshrt4.Enabled = False
        Me.btnAshrt4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAshrt4.Location = New System.Drawing.Point(393, 27)
        Me.btnAshrt4.Name = "btnAshrt4"
        Me.btnAshrt4.Size = New System.Drawing.Size(72, 58)
        Me.btnAshrt4.TabIndex = 61
        Me.btnAshrt4.TabStop = False
        Me.btnAshrt4.Tag = "4"
        Me.btnAshrt4.Text = "Week 4 Associate Shortages"
        Me.btnAshrt4.UseVisualStyleBackColor = True
        '
        'btnAshrt5
        '
        Me.btnAshrt5.Enabled = False
        Me.btnAshrt5.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAshrt5.Location = New System.Drawing.Point(474, 27)
        Me.btnAshrt5.Name = "btnAshrt5"
        Me.btnAshrt5.Size = New System.Drawing.Size(72, 58)
        Me.btnAshrt5.TabIndex = 61
        Me.btnAshrt5.TabStop = False
        Me.btnAshrt5.Tag = "5"
        Me.btnAshrt5.Text = "Week 5 Associate Shortages"
        Me.btnAshrt5.UseVisualStyleBackColor = True
        Me.btnAshrt5.Visible = False
        '
        'WeeklyForecast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(968, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAshrt5)
        Me.Controls.Add(Me.btnAshrt4)
        Me.Controls.Add(Me.btnAshrt3)
        Me.Controls.Add(Me.btnAshrt2)
        Me.Controls.Add(Me.btnAshrt1)
        Me.Controls.Add(Me.panForecast)
        Me.Controls.Add(Me.lblWeek5)
        Me.Controls.Add(Me.lblWeek4)
        Me.Controls.Add(Me.lblWeek3)
        Me.Controls.Add(Me.lblWeek2)
        Me.Controls.Add(Me.lblVariance)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.lblBudgetPerc)
        Me.Controls.Add(Me.lblTotalPerc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblWeek1)
        Me.Controls.Add(Me.lblDRR)
        Me.Controls.Add(Me.sstForecast)
        Me.Controls.Add(Me.mstForecast)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstForecast
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(970, 490)
        Me.MinimumSize = New System.Drawing.Size(970, 490)
        Me.Name = "WeeklyForecast"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mstForecast.ResumeLayout(False)
        Me.mstForecast.PerformLayout()
        Me.sstForecast.ResumeLayout(False)
        Me.sstForecast.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstForecast As MenuStrip
    Friend WithEvents sstForecast As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents tsslFY As ToolStripStatusLabel
    Friend WithEvents tsslPeriod As ToolStripStatusLabel
    Friend WithEvents tsslPeriodDays As ToolStripStatusLabel
    Friend WithEvents tsslInformation As ToolStripStatusLabel
    Friend WithEvents tsslSaveStatus As ToolStripStatusLabel
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiPrint As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiRefreshDRR As ToolStripMenuItem
    Friend WithEvents tsmiApplyDRR As ToolStripMenuItem
    Friend WithEvents tsmiTools As ToolStripMenuItem
    Friend WithEvents tsmiCalc As ToolStripMenuItem
    Friend WithEvents tsmiMSP As PeriodSelector
    Friend WithEvents tsmiClear As ToolStripMenuItem
    Friend WithEvents tsmiOpDays As ToolStripMenuItem
    Friend WithEvents lblDRR As Label
    Friend WithEvents lblWeek1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalPerc As Label
    Friend WithEvents lblBudgetPerc As Label
    Friend WithEvents lblBudget As Label
    Friend WithEvents lblVariance As Label
    Friend WithEvents lblWeek2 As Label
    Friend WithEvents lblWeek3 As Label
    Friend WithEvents lblWeek4 As Label
    Friend WithEvents lblWeek5 As Label
    Friend WithEvents FlashRecordsTableAdapter1 As AGNESDataTableAdapters.FlashRecordsTableAdapter
    Friend WithEvents panForecast As Panel
    Friend WithEvents PrintFlash As PowerPacks.Printing.PrintForm
    Friend WithEvents btnAshrt5 As Button
    Friend WithEvents btnAshrt4 As Button
    Friend WithEvents btnAshrt3 As Button
    Friend WithEvents btnAshrt2 As Button
    Friend WithEvents btnAshrt1 As Button
End Class
