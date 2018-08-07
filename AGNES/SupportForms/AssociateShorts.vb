Public Class AssociateShorts
    Public Property MSP As Byte
    Public Property Week As Byte
    Public Property Unit As Long
    Public Property StartDate As Date
    Dim ct As Integer
    Dim Fri() As DataRow
    Dim Mon() As DataRow
    Dim Tue() As DataRow
    Dim Wed() As DataRow
    Dim Thu() As DataRow
    Dim HourlyMax As Integer
    Dim SalaryMax As Integer
    Dim RecordExists As Boolean
    Dim Errorspresent As Boolean

    Private Sub InitializeForm(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.AssocOutAdapt.Fill(DataSets.AssocOutTable)
        DataSets.AssocBaseAdapt.Fill(DataSets.AssocBaseTable)
        Dim GetHrMax() As DataRow = DataSets.AssocBaseTable.Select("MSFY = '" & Portal.FiscalYear & "' and UnitNumber = '" & Unit & "'")
        HourlyMax = GetHrMax(0)("HourlyBaseHC")
        SalaryMax = GetHrMax(0)("SalaryBaseHC")
        lblInstruct.Text = "Enter the number of associates OUT in Period " & MSP & ", Week " & Week
        FetchStartDate()
        LoadExisting()
        txtHFri.SelectAll()
        txtHFri.Select()
    End Sub

    Private Sub FetchStartDate()
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        Dim GetStDt() As DataRow = DataSets.DateTable.Select("MS_FY = '" & Portal.FiscalYear & "' and MS_Period = '" & MSP & "' and Week = '" & Week & "'")
        StartDate = GetStDt(0)("Date_ID")
    End Sub

    Private Sub LoadExisting()
        '// Queryand populate
        Fri = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate & "'")
        Mon = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(3) & "'")
        Tue = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(4) & "'")
        Wed = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(5) & "'")
        Thu = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(6) & "'")
        If Fri.Count > 0 Then
            txtHFri.Text = Fri(0)("HourlyOut")
            txtSFri.Text = Fri(0)("SalaryOut")
            txtHMon.Text = Mon(0)("HourlyOut")
            txtSMon.Text = Mon(0)("SalaryOut")
            txtHTue.Text = Tue(0)("HourlyOut")
            txtSTue.Text = Tue(0)("SalaryOut")
            txtHWed.Text = Wed(0)("HourlyOut")
            txtSWed.Text = Wed(0)("SalaryOut")
            txtHThu.Text = Thu(0)("HourlyOut")
            txtSThu.Text = Thu(0)("SalaryOut")
            RecordExists = True
        Else
            txtHFri.Text = 0
            txtSFri.Text = 0
            txtHMon.Text = 0
            txtSMon.Text = 0
            txtHTue.Text = 0
            txtSTue.Text = 0
            txtHWed.Text = 0
            txtSWed.Text = 0
            txtHThu.Text = 0
            txtSThu.Text = 0
            RecordExists = False
        End If

    End Sub

    Private Sub TextFocus(sender As Object, e As EventArgs) Handles txtSFri.Enter, txtSMon.Enter, txtSTue.Enter, txtSWed.Enter, txtSThu.Enter,
            txtHFri.Enter, txtHMon.Enter, txtHTue.Enter, txtHWed.Enter, txtHThu.Enter
        Dim s As TextBox = sender
        s.SelectAll()
    End Sub

    Private Sub ConstrainHourlyValues(sender As Object, e As EventArgs) Handles txtHFri.Leave, txtHMon.Leave, txtHTue.Leave, txtHWed.Leave, txtHThu.Leave
        Errorspresent = ValueCheck(sender, HourlyMax, False)
    End Sub

    Private Sub ConstrainSalaryValues(sender As Object, e As EventArgs) Handles txtSFri.Leave, txtSMon.Leave, txtSTue.Leave, txtSWed.Leave, txtSThu.Leave
        Errorspresent = ValueCheck(sender, SalaryMax, False)
    End Sub

    Private Function ValueCheck(t As TextBox, maxval As Integer, finalvalidation As Boolean) As Boolean
        Dim v As Integer, errorsfound As Boolean = False
        lblWarning.Text = ""
        t.ForeColor = Color.Black
        Try
            v = FormatNumber(t.Text, 0)
        Catch ex As Exception
            If finalvalidation = False Then lblWarning.Text = "Value must be numeric!"
            t.ForeColor = Color.Red
            Errorspresent = True
        End Try
        If v < 0 Then
            If finalvalidation = False Then lblWarning.Text = "Oh, come on.  Negative?  Really?"
            t.ForeColor = Color.Red
            Errorspresent = True
        End If
        If v > maxval Then
            If finalvalidation = False Then lblWarning.Text = "Cannot exceed the budgeted headcount of " & maxval & "!"
            t.Text = maxval
            t.ForeColor = Color.Red
            errorspresent = True
        End If
        Return errorsfound
    End Function

    Private Sub SaveEntries(sender As Object, e As EventArgs) Handles btnOkay.Click
        '//     Cancel save if errors are present
        Dim errorcounter As Byte = 0
        If ValueCheck(txtSFri, SalaryMax, False) = True Then errorcounter += 1
        If ValueCheck(txtSMon, SalaryMax, False) = True Then errorcounter += 1
        If ValueCheck(txtSTue, SalaryMax, False) = True Then errorcounter += 1
        If ValueCheck(txtSWed, SalaryMax, False) = True Then errorcounter += 1
        If ValueCheck(txtSThu, SalaryMax, False) = True Then errorcounter += 1
        If ValueCheck(txtHFri, HourlyMax, False) = True Then errorcounter += 1
        If ValueCheck(txtHMon, HourlyMax, False) = True Then errorcounter += 1
        If ValueCheck(txtHTue, HourlyMax, False) = True Then errorcounter += 1
        If ValueCheck(txtHWed, HourlyMax, False) = True Then errorcounter += 1
        If ValueCheck(txtHThu, HourlyMax, False) = True Then errorcounter += 1

        If Errorspresent = True Or errorcounter > 0 Then
            MsgBox("Cannot save until errors (red text) are corrected.")
            Exit Sub
        End If
        Try
            '// Does an entry exist?
            If RecordExists = True Then
                Fri(0)("HourlyOut") = FormatNumber(txtHFri.Text, 0)
                Fri(0)("SalaryOut") = FormatNumber(txtSFri.Text, 0)
                Mon(0)("HourlyOut") = FormatNumber(txtHMon.Text, 0)
                Mon(0)("SalaryOut") = FormatNumber(txtSMon.Text, 0)
                Tue(0)("HourlyOut") = FormatNumber(txtHTue.Text, 0)
                Tue(0)("SalaryOut") = FormatNumber(txtSTue.Text, 0)
                Wed(0)("HourlyOut") = FormatNumber(txtHWed.Text, 0)
                Wed(0)("SalaryOut") = FormatNumber(txtSWed.Text, 0)
                Thu(0)("HourlyOut") = FormatNumber(txtHThu.Text, 0)
                Thu(0)("SalaryOut") = FormatNumber(txtSThu.Text, 0)
            Else
                '// Create new entries
                InsertFunc(DataSets.AssocOutTable.NewRow(), FormatNumber(txtHFri.Text, 0), FormatNumber(txtSFri.Text, 0), StartDate)
                InsertFunc(DataSets.AssocOutTable.NewRow(), FormatNumber(txtHMon.Text, 0), FormatNumber(txtSMon.Text, 0), StartDate.AddDays(3))
                InsertFunc(DataSets.AssocOutTable.NewRow(), FormatNumber(txtHTue.Text, 0), FormatNumber(txtSTue.Text, 0), StartDate.AddDays(4))
                InsertFunc(DataSets.AssocOutTable.NewRow(), FormatNumber(txtHWed.Text, 0), FormatNumber(txtSWed.Text, 0), StartDate.AddDays(5))
                InsertFunc(DataSets.AssocOutTable.NewRow(), FormatNumber(txtHThu.Text, 0), FormatNumber(txtSThu.Text, 0), StartDate.AddDays(6))
            End If

            DataSets.AssocOutAdapt.Update(DataSets.AssocOutTable)
            DataSets.AssocOutAdapt.Fill(DataSets.AssocOutTable)
        Catch ex As Exception
            MsgBox("Save failed due to error " & ex.Message.ToString)
            Exit Sub
        End Try
        MsgBox("Save successful!")
        Me.Close()
    End Sub

    Private Sub InsertFunc(dr As DataRow, hval As Integer, sval As Integer, dt As Date)
        dr("UnitNumber") = Unit
        dr("Date") = dt
        dr("HourlyOut") = hval
        dr("SalaryOut") = sval
        DataSets.AssocOutTable.Rows.Add(dr)
    End Sub

    Private Sub ExitForm(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class