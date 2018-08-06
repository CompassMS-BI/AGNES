Public Class AssociateShorts
    Public Property MSP As Byte
    Public Property Week As Byte
    Public Property Unit As Long
    Public Property StartDate As Date
    Dim ct As Integer
    Private Sub InitializeForm(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.AssocOutAdapt.Fill(DataSets.AssocOutTable)
        lblInstruct.Text = "Enter the number of associates OUT in Period " & MSP & ", Week " & Week
        FetchStartDate()
        LoadExisting()
        txtHFri.SelectAll()
    End Sub
    Private Sub FetchStartDate()
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        Dim GetStDt() As DataRow = DataSets.DateTable.Select("MS_FY = '" & Portal.FiscalYear & "' and MS_Period = '" & MSP & "' and Week = '" & Week & "'")
        StartDate = GetStDt(0)("Date_ID")
    End Sub

    Private Sub LoadExisting()
        Dim ph As String = ""
        '// Calculate data range, query, and populate
        Dim Fri() As DataRow = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate & "'")
        Dim Mon() As DataRow = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(3) & "'")
        Dim Tue() As DataRow = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(4) & "'")
        Dim Wed() As DataRow = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(5) & "'")
        Dim Thu() As DataRow = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate.AddDays(6) & "'")
        If Fri.Count > 0 Then txtHFri.Text = Fri(0)("HourlyOut")
        If Fri.Count > 0 Then txtSFri.Text = Fri(0)("SalaryOut")
        If Mon.Count > 0 Then txtHMon.Text = Mon(0)("HourlyOut")
        If Mon.Count > 0 Then txtSMon.Text = Mon(0)("SalaryOut")
        If Tue.Count > 0 Then txtHTue.Text = Tue(0)("HourlyOut")
        If Tue.Count > 0 Then txtSTue.Text = Tue(0)("SalaryOut")
        If Wed.Count > 0 Then txtHWed.Text = Wed(0)("HourlyOut")
        If Wed.Count > 0 Then txtSWed.Text = Wed(0)("SalaryOut")
        If Thu.Count > 0 Then txtHThu.Text = Thu(0)("HourlyOut")
        If Thu.Count > 0 Then txtSThu.Text = Thu(0)("SalaryOut")
    End Sub

    Private Sub SaveEntries(sender As Object, e As EventArgs) Handles btnOkay.Click
        '// Future development: prevent entry from being greater than baseline headcount
        Dim ph As String = ""
        '// Does an entry exist?
        Dim Fri() As DataRow = DataSets.AssocOutTable.Select("UnitNumber = '" & Unit & "' and Date = '" & StartDate & "'")
        If Fri.Count > 0 Then
            '// Overwrite existing entries
        Else
            '// Create new entries

        End If

    End Sub

    Private Sub ExitForm(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class