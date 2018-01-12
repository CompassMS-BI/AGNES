<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperatingDaysMgr
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
        Me.nudFY = New System.Windows.Forms.NumericUpDown()
        Me.nudPeriod = New System.Windows.Forms.NumericUpDown()
        Me.panWeekOpDays = New System.Windows.Forms.Panel()
        Me.lblW5Total = New System.Windows.Forms.Label()
        Me.lblWeek5 = New System.Windows.Forms.Label()
        Me.chkW5Thu = New System.Windows.Forms.CheckBox()
        Me.chkW5Wed = New System.Windows.Forms.CheckBox()
        Me.chkW5Tue = New System.Windows.Forms.CheckBox()
        Me.chkW5Mon = New System.Windows.Forms.CheckBox()
        Me.chkW5Fri = New System.Windows.Forms.CheckBox()
        Me.lblW4Total = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkW4Thu = New System.Windows.Forms.CheckBox()
        Me.chkW4Wed = New System.Windows.Forms.CheckBox()
        Me.chkW4Tue = New System.Windows.Forms.CheckBox()
        Me.chkW4Mon = New System.Windows.Forms.CheckBox()
        Me.chkW4Fri = New System.Windows.Forms.CheckBox()
        Me.lblW3Total = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkW3Thu = New System.Windows.Forms.CheckBox()
        Me.chkW3Wed = New System.Windows.Forms.CheckBox()
        Me.chkW3Tue = New System.Windows.Forms.CheckBox()
        Me.chkW3Mon = New System.Windows.Forms.CheckBox()
        Me.chkW3Fri = New System.Windows.Forms.CheckBox()
        Me.lblW2Total = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkW2Thu = New System.Windows.Forms.CheckBox()
        Me.chkW2Wed = New System.Windows.Forms.CheckBox()
        Me.chkW2Tue = New System.Windows.Forms.CheckBox()
        Me.chkW2Mon = New System.Windows.Forms.CheckBox()
        Me.chkW2Fri = New System.Windows.Forms.CheckBox()
        Me.lblW1Total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkW1Thu = New System.Windows.Forms.CheckBox()
        Me.chkW1Wed = New System.Windows.Forms.CheckBox()
        Me.chkW1Tue = New System.Windows.Forms.CheckBox()
        Me.chkW1Mon = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkW1Fri = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPeriodTotal = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudFY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panWeekOpDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'nudFY
        '
        Me.nudFY.Location = New System.Drawing.Point(55, 8)
        Me.nudFY.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudFY.Minimum = New Decimal(New Integer() {2017, 0, 0, 0})
        Me.nudFY.Name = "nudFY"
        Me.nudFY.Size = New System.Drawing.Size(59, 22)
        Me.nudFY.TabIndex = 0
        Me.nudFY.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'nudPeriod
        '
        Me.nudPeriod.Location = New System.Drawing.Point(184, 8)
        Me.nudPeriod.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPeriod.Name = "nudPeriod"
        Me.nudPeriod.Size = New System.Drawing.Size(59, 22)
        Me.nudPeriod.TabIndex = 1
        Me.nudPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'panWeekOpDays
        '
        Me.panWeekOpDays.Controls.Add(Me.lblW5Total)
        Me.panWeekOpDays.Controls.Add(Me.lblWeek5)
        Me.panWeekOpDays.Controls.Add(Me.chkW5Thu)
        Me.panWeekOpDays.Controls.Add(Me.chkW5Wed)
        Me.panWeekOpDays.Controls.Add(Me.chkW5Tue)
        Me.panWeekOpDays.Controls.Add(Me.chkW5Mon)
        Me.panWeekOpDays.Controls.Add(Me.chkW5Fri)
        Me.panWeekOpDays.Controls.Add(Me.lblW4Total)
        Me.panWeekOpDays.Controls.Add(Me.Label18)
        Me.panWeekOpDays.Controls.Add(Me.chkW4Thu)
        Me.panWeekOpDays.Controls.Add(Me.chkW4Wed)
        Me.panWeekOpDays.Controls.Add(Me.chkW4Tue)
        Me.panWeekOpDays.Controls.Add(Me.chkW4Mon)
        Me.panWeekOpDays.Controls.Add(Me.chkW4Fri)
        Me.panWeekOpDays.Controls.Add(Me.lblW3Total)
        Me.panWeekOpDays.Controls.Add(Me.Label14)
        Me.panWeekOpDays.Controls.Add(Me.chkW3Thu)
        Me.panWeekOpDays.Controls.Add(Me.chkW3Wed)
        Me.panWeekOpDays.Controls.Add(Me.chkW3Tue)
        Me.panWeekOpDays.Controls.Add(Me.chkW3Mon)
        Me.panWeekOpDays.Controls.Add(Me.chkW3Fri)
        Me.panWeekOpDays.Controls.Add(Me.lblW2Total)
        Me.panWeekOpDays.Controls.Add(Me.Label12)
        Me.panWeekOpDays.Controls.Add(Me.chkW2Thu)
        Me.panWeekOpDays.Controls.Add(Me.chkW2Wed)
        Me.panWeekOpDays.Controls.Add(Me.chkW2Tue)
        Me.panWeekOpDays.Controls.Add(Me.chkW2Mon)
        Me.panWeekOpDays.Controls.Add(Me.chkW2Fri)
        Me.panWeekOpDays.Controls.Add(Me.lblW1Total)
        Me.panWeekOpDays.Controls.Add(Me.Label9)
        Me.panWeekOpDays.Controls.Add(Me.Label8)
        Me.panWeekOpDays.Controls.Add(Me.chkW1Thu)
        Me.panWeekOpDays.Controls.Add(Me.chkW1Wed)
        Me.panWeekOpDays.Controls.Add(Me.chkW1Tue)
        Me.panWeekOpDays.Controls.Add(Me.chkW1Mon)
        Me.panWeekOpDays.Controls.Add(Me.Label7)
        Me.panWeekOpDays.Controls.Add(Me.Label6)
        Me.panWeekOpDays.Controls.Add(Me.Label5)
        Me.panWeekOpDays.Controls.Add(Me.Label4)
        Me.panWeekOpDays.Controls.Add(Me.Label3)
        Me.panWeekOpDays.Controls.Add(Me.chkW1Fri)
        Me.panWeekOpDays.Location = New System.Drawing.Point(12, 36)
        Me.panWeekOpDays.Name = "panWeekOpDays"
        Me.panWeekOpDays.Size = New System.Drawing.Size(401, 195)
        Me.panWeekOpDays.TabIndex = 2
        '
        'lblW5Total
        '
        Me.lblW5Total.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblW5Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblW5Total.Location = New System.Drawing.Point(318, 158)
        Me.lblW5Total.Name = "lblW5Total"
        Me.lblW5Total.Size = New System.Drawing.Size(59, 21)
        Me.lblW5Total.TabIndex = 46
        Me.lblW5Total.Text = "0"
        Me.lblW5Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblW5Total.Visible = False
        '
        'lblWeek5
        '
        Me.lblWeek5.AutoSize = True
        Me.lblWeek5.Location = New System.Drawing.Point(12, 161)
        Me.lblWeek5.Name = "lblWeek5"
        Me.lblWeek5.Size = New System.Drawing.Size(45, 15)
        Me.lblWeek5.TabIndex = 45
        Me.lblWeek5.Text = "Week 5"
        Me.lblWeek5.Visible = False
        '
        'chkW5Thu
        '
        Me.chkW5Thu.AutoSize = True
        Me.chkW5Thu.Location = New System.Drawing.Point(273, 162)
        Me.chkW5Thu.Name = "chkW5Thu"
        Me.chkW5Thu.Size = New System.Drawing.Size(15, 14)
        Me.chkW5Thu.TabIndex = 44
        Me.chkW5Thu.UseVisualStyleBackColor = True
        Me.chkW5Thu.Visible = False
        '
        'chkW5Wed
        '
        Me.chkW5Wed.AutoSize = True
        Me.chkW5Wed.Location = New System.Drawing.Point(218, 162)
        Me.chkW5Wed.Name = "chkW5Wed"
        Me.chkW5Wed.Size = New System.Drawing.Size(15, 14)
        Me.chkW5Wed.TabIndex = 43
        Me.chkW5Wed.UseVisualStyleBackColor = True
        Me.chkW5Wed.Visible = False
        '
        'chkW5Tue
        '
        Me.chkW5Tue.AutoSize = True
        Me.chkW5Tue.Location = New System.Drawing.Point(172, 162)
        Me.chkW5Tue.Name = "chkW5Tue"
        Me.chkW5Tue.Size = New System.Drawing.Size(15, 14)
        Me.chkW5Tue.TabIndex = 42
        Me.chkW5Tue.UseVisualStyleBackColor = True
        Me.chkW5Tue.Visible = False
        '
        'chkW5Mon
        '
        Me.chkW5Mon.AutoSize = True
        Me.chkW5Mon.Location = New System.Drawing.Point(125, 162)
        Me.chkW5Mon.Name = "chkW5Mon"
        Me.chkW5Mon.Size = New System.Drawing.Size(15, 14)
        Me.chkW5Mon.TabIndex = 41
        Me.chkW5Mon.UseVisualStyleBackColor = True
        Me.chkW5Mon.Visible = False
        '
        'chkW5Fri
        '
        Me.chkW5Fri.AutoSize = True
        Me.chkW5Fri.Location = New System.Drawing.Point(81, 162)
        Me.chkW5Fri.Name = "chkW5Fri"
        Me.chkW5Fri.Size = New System.Drawing.Size(15, 14)
        Me.chkW5Fri.TabIndex = 40
        Me.chkW5Fri.UseVisualStyleBackColor = True
        Me.chkW5Fri.Visible = False
        '
        'lblW4Total
        '
        Me.lblW4Total.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblW4Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblW4Total.Location = New System.Drawing.Point(318, 125)
        Me.lblW4Total.Name = "lblW4Total"
        Me.lblW4Total.Size = New System.Drawing.Size(59, 21)
        Me.lblW4Total.TabIndex = 39
        Me.lblW4Total.Text = "0"
        Me.lblW4Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 15)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Week 4"
        '
        'chkW4Thu
        '
        Me.chkW4Thu.AutoSize = True
        Me.chkW4Thu.Checked = True
        Me.chkW4Thu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW4Thu.Location = New System.Drawing.Point(273, 127)
        Me.chkW4Thu.Name = "chkW4Thu"
        Me.chkW4Thu.Size = New System.Drawing.Size(15, 14)
        Me.chkW4Thu.TabIndex = 37
        Me.chkW4Thu.UseVisualStyleBackColor = True
        '
        'chkW4Wed
        '
        Me.chkW4Wed.AutoSize = True
        Me.chkW4Wed.Checked = True
        Me.chkW4Wed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW4Wed.Location = New System.Drawing.Point(218, 127)
        Me.chkW4Wed.Name = "chkW4Wed"
        Me.chkW4Wed.Size = New System.Drawing.Size(15, 14)
        Me.chkW4Wed.TabIndex = 36
        Me.chkW4Wed.UseVisualStyleBackColor = True
        '
        'chkW4Tue
        '
        Me.chkW4Tue.AutoSize = True
        Me.chkW4Tue.Checked = True
        Me.chkW4Tue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW4Tue.Location = New System.Drawing.Point(172, 127)
        Me.chkW4Tue.Name = "chkW4Tue"
        Me.chkW4Tue.Size = New System.Drawing.Size(15, 14)
        Me.chkW4Tue.TabIndex = 35
        Me.chkW4Tue.UseVisualStyleBackColor = True
        '
        'chkW4Mon
        '
        Me.chkW4Mon.AutoSize = True
        Me.chkW4Mon.Checked = True
        Me.chkW4Mon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW4Mon.Location = New System.Drawing.Point(125, 127)
        Me.chkW4Mon.Name = "chkW4Mon"
        Me.chkW4Mon.Size = New System.Drawing.Size(15, 14)
        Me.chkW4Mon.TabIndex = 34
        Me.chkW4Mon.UseVisualStyleBackColor = True
        '
        'chkW4Fri
        '
        Me.chkW4Fri.AutoSize = True
        Me.chkW4Fri.Checked = True
        Me.chkW4Fri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW4Fri.Location = New System.Drawing.Point(81, 127)
        Me.chkW4Fri.Name = "chkW4Fri"
        Me.chkW4Fri.Size = New System.Drawing.Size(15, 14)
        Me.chkW4Fri.TabIndex = 33
        Me.chkW4Fri.UseVisualStyleBackColor = True
        '
        'lblW3Total
        '
        Me.lblW3Total.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblW3Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblW3Total.Location = New System.Drawing.Point(318, 92)
        Me.lblW3Total.Name = "lblW3Total"
        Me.lblW3Total.Size = New System.Drawing.Size(59, 21)
        Me.lblW3Total.TabIndex = 32
        Me.lblW3Total.Text = "0"
        Me.lblW3Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Week 3"
        '
        'chkW3Thu
        '
        Me.chkW3Thu.AutoSize = True
        Me.chkW3Thu.Checked = True
        Me.chkW3Thu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW3Thu.Location = New System.Drawing.Point(273, 93)
        Me.chkW3Thu.Name = "chkW3Thu"
        Me.chkW3Thu.Size = New System.Drawing.Size(15, 14)
        Me.chkW3Thu.TabIndex = 30
        Me.chkW3Thu.UseVisualStyleBackColor = True
        '
        'chkW3Wed
        '
        Me.chkW3Wed.AutoSize = True
        Me.chkW3Wed.Checked = True
        Me.chkW3Wed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW3Wed.Location = New System.Drawing.Point(218, 93)
        Me.chkW3Wed.Name = "chkW3Wed"
        Me.chkW3Wed.Size = New System.Drawing.Size(15, 14)
        Me.chkW3Wed.TabIndex = 29
        Me.chkW3Wed.UseVisualStyleBackColor = True
        '
        'chkW3Tue
        '
        Me.chkW3Tue.AutoSize = True
        Me.chkW3Tue.Checked = True
        Me.chkW3Tue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW3Tue.Location = New System.Drawing.Point(172, 93)
        Me.chkW3Tue.Name = "chkW3Tue"
        Me.chkW3Tue.Size = New System.Drawing.Size(15, 14)
        Me.chkW3Tue.TabIndex = 28
        Me.chkW3Tue.UseVisualStyleBackColor = True
        '
        'chkW3Mon
        '
        Me.chkW3Mon.AutoSize = True
        Me.chkW3Mon.Checked = True
        Me.chkW3Mon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW3Mon.Location = New System.Drawing.Point(125, 93)
        Me.chkW3Mon.Name = "chkW3Mon"
        Me.chkW3Mon.Size = New System.Drawing.Size(15, 14)
        Me.chkW3Mon.TabIndex = 27
        Me.chkW3Mon.UseVisualStyleBackColor = True
        '
        'chkW3Fri
        '
        Me.chkW3Fri.AutoSize = True
        Me.chkW3Fri.Checked = True
        Me.chkW3Fri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW3Fri.Location = New System.Drawing.Point(81, 93)
        Me.chkW3Fri.Name = "chkW3Fri"
        Me.chkW3Fri.Size = New System.Drawing.Size(15, 14)
        Me.chkW3Fri.TabIndex = 26
        Me.chkW3Fri.UseVisualStyleBackColor = True
        '
        'lblW2Total
        '
        Me.lblW2Total.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblW2Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblW2Total.Location = New System.Drawing.Point(318, 59)
        Me.lblW2Total.Name = "lblW2Total"
        Me.lblW2Total.Size = New System.Drawing.Size(59, 21)
        Me.lblW2Total.TabIndex = 25
        Me.lblW2Total.Text = "0"
        Me.lblW2Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Week 2"
        '
        'chkW2Thu
        '
        Me.chkW2Thu.AutoSize = True
        Me.chkW2Thu.Checked = True
        Me.chkW2Thu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW2Thu.Location = New System.Drawing.Point(273, 61)
        Me.chkW2Thu.Name = "chkW2Thu"
        Me.chkW2Thu.Size = New System.Drawing.Size(15, 14)
        Me.chkW2Thu.TabIndex = 23
        Me.chkW2Thu.UseVisualStyleBackColor = True
        '
        'chkW2Wed
        '
        Me.chkW2Wed.AutoSize = True
        Me.chkW2Wed.Checked = True
        Me.chkW2Wed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW2Wed.Location = New System.Drawing.Point(218, 61)
        Me.chkW2Wed.Name = "chkW2Wed"
        Me.chkW2Wed.Size = New System.Drawing.Size(15, 14)
        Me.chkW2Wed.TabIndex = 22
        Me.chkW2Wed.UseVisualStyleBackColor = True
        '
        'chkW2Tue
        '
        Me.chkW2Tue.AutoSize = True
        Me.chkW2Tue.Checked = True
        Me.chkW2Tue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW2Tue.Location = New System.Drawing.Point(172, 61)
        Me.chkW2Tue.Name = "chkW2Tue"
        Me.chkW2Tue.Size = New System.Drawing.Size(15, 14)
        Me.chkW2Tue.TabIndex = 21
        Me.chkW2Tue.UseVisualStyleBackColor = True
        '
        'chkW2Mon
        '
        Me.chkW2Mon.AutoSize = True
        Me.chkW2Mon.Checked = True
        Me.chkW2Mon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW2Mon.Location = New System.Drawing.Point(125, 61)
        Me.chkW2Mon.Name = "chkW2Mon"
        Me.chkW2Mon.Size = New System.Drawing.Size(15, 14)
        Me.chkW2Mon.TabIndex = 20
        Me.chkW2Mon.UseVisualStyleBackColor = True
        '
        'chkW2Fri
        '
        Me.chkW2Fri.AutoSize = True
        Me.chkW2Fri.Checked = True
        Me.chkW2Fri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW2Fri.Location = New System.Drawing.Point(81, 61)
        Me.chkW2Fri.Name = "chkW2Fri"
        Me.chkW2Fri.Size = New System.Drawing.Size(15, 14)
        Me.chkW2Fri.TabIndex = 19
        Me.chkW2Fri.UseVisualStyleBackColor = True
        '
        'lblW1Total
        '
        Me.lblW1Total.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblW1Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblW1Total.Location = New System.Drawing.Point(318, 26)
        Me.lblW1Total.Name = "lblW1Total"
        Me.lblW1Total.Size = New System.Drawing.Size(59, 21)
        Me.lblW1Total.TabIndex = 18
        Me.lblW1Total.Text = "0"
        Me.lblW1Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Week 1"
        '
        'chkW1Thu
        '
        Me.chkW1Thu.AutoSize = True
        Me.chkW1Thu.Checked = True
        Me.chkW1Thu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW1Thu.Location = New System.Drawing.Point(273, 29)
        Me.chkW1Thu.Name = "chkW1Thu"
        Me.chkW1Thu.Size = New System.Drawing.Size(15, 14)
        Me.chkW1Thu.TabIndex = 4
        Me.chkW1Thu.UseVisualStyleBackColor = True
        '
        'chkW1Wed
        '
        Me.chkW1Wed.AutoSize = True
        Me.chkW1Wed.Checked = True
        Me.chkW1Wed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW1Wed.Location = New System.Drawing.Point(218, 29)
        Me.chkW1Wed.Name = "chkW1Wed"
        Me.chkW1Wed.Size = New System.Drawing.Size(15, 14)
        Me.chkW1Wed.TabIndex = 3
        Me.chkW1Wed.UseVisualStyleBackColor = True
        '
        'chkW1Tue
        '
        Me.chkW1Tue.AutoSize = True
        Me.chkW1Tue.Location = New System.Drawing.Point(172, 29)
        Me.chkW1Tue.Name = "chkW1Tue"
        Me.chkW1Tue.Size = New System.Drawing.Size(15, 14)
        Me.chkW1Tue.TabIndex = 2
        Me.chkW1Tue.UseVisualStyleBackColor = True
        '
        'chkW1Mon
        '
        Me.chkW1Mon.AutoSize = True
        Me.chkW1Mon.Checked = True
        Me.chkW1Mon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW1Mon.Location = New System.Drawing.Point(125, 29)
        Me.chkW1Mon.Name = "chkW1Mon"
        Me.chkW1Mon.Size = New System.Drawing.Size(15, 14)
        Me.chkW1Mon.TabIndex = 1
        Me.chkW1Mon.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Thu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Wed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fri"
        '
        'chkW1Fri
        '
        Me.chkW1Fri.AutoSize = True
        Me.chkW1Fri.Checked = True
        Me.chkW1Fri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkW1Fri.Location = New System.Drawing.Point(81, 29)
        Me.chkW1Fri.Name = "chkW1Fri"
        Me.chkW1Fri.Size = New System.Drawing.Size(15, 14)
        Me.chkW1Fri.TabIndex = 0
        Me.chkW1Fri.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.OldLace
        Me.btnSave.BackgroundImage = Global.AGNES.My.Resources.Resources.pill_button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(27, 250)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MS Period:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MS FY:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(249, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 15)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Total Days in Period:"
        '
        'lblPeriodTotal
        '
        Me.lblPeriodTotal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPeriodTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPeriodTotal.Location = New System.Drawing.Point(366, 10)
        Me.lblPeriodTotal.Name = "lblPeriodTotal"
        Me.lblPeriodTotal.Size = New System.Drawing.Size(47, 21)
        Me.lblPeriodTotal.TabIndex = 19
        Me.lblPeriodTotal.Text = "0"
        Me.lblPeriodTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.OldLace
        Me.btnCancel.BackgroundImage = Global.AGNES.My.Resources.Resources.pill_button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(302, 250)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 39)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'OperatingDaysMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(425, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblPeriodTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.panWeekOpDays)
        Me.Controls.Add(Me.nudPeriod)
        Me.Controls.Add(Me.nudFY)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "OperatingDaysMgr"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operating Days Manager"
        CType(Me.nudFY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panWeekOpDays.ResumeLayout(False)
        Me.panWeekOpDays.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudFY As NumericUpDown
    Friend WithEvents nudPeriod As NumericUpDown
    Friend WithEvents panWeekOpDays As Panel
    Friend WithEvents lblW5Total As Label
    Friend WithEvents lblWeek5 As Label
    Friend WithEvents chkW5Thu As CheckBox
    Friend WithEvents chkW5Wed As CheckBox
    Friend WithEvents chkW5Tue As CheckBox
    Friend WithEvents chkW5Mon As CheckBox
    Friend WithEvents chkW5Fri As CheckBox
    Friend WithEvents lblW4Total As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents chkW4Thu As CheckBox
    Friend WithEvents chkW4Wed As CheckBox
    Friend WithEvents chkW4Tue As CheckBox
    Friend WithEvents chkW4Mon As CheckBox
    Friend WithEvents chkW4Fri As CheckBox
    Friend WithEvents lblW3Total As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents chkW3Thu As CheckBox
    Friend WithEvents chkW3Wed As CheckBox
    Friend WithEvents chkW3Tue As CheckBox
    Friend WithEvents chkW3Mon As CheckBox
    Friend WithEvents chkW3Fri As CheckBox
    Friend WithEvents lblW2Total As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chkW2Thu As CheckBox
    Friend WithEvents chkW2Wed As CheckBox
    Friend WithEvents chkW2Tue As CheckBox
    Friend WithEvents chkW2Mon As CheckBox
    Friend WithEvents chkW2Fri As CheckBox
    Friend WithEvents lblW1Total As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkW1Thu As CheckBox
    Friend WithEvents chkW1Wed As CheckBox
    Friend WithEvents chkW1Tue As CheckBox
    Friend WithEvents chkW1Mon As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkW1Fri As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPeriodTotal As Label
    Friend WithEvents btnCancel As Button
End Class
