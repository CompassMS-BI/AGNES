Public Class SickOT
    Public Property Unit As Long
    Public Property MSP As Byte
    Public Property Wk As Byte
    Private ExistingData As Boolean

    Private Sub SickOT_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.SickOtAdapt.Fill(DataSets.SickOtTable)
        '// Fetch existing data
        Dim dr() As DataRow = DataSets.SickOtTable.Select("UnitNumber = '" & Unit & "' and MSFY = '" & Portal.FiscalYear & "' and MSP = '" & MSP & "' and Week = '" & Wk & "'")
        If dr.Count > 0 Then
            fuvOT.Text = FormatCurrency(dr(0)("OTPay"), 2)
            fuvSick.Text = FormatCurrency(dr(0)("SickPay"), 2)
            ExistingData = True
        End If
    End Sub

    Private Sub SaveandExit(sender As Object, e As EventArgs) Handles btnSave.Click

        If ExistingData = False Then
            Try
                Dim InsertDR As DataRow = DataSets.SickOtTable.NewRow()
                InsertDR("UnitNumber") = Unit
                InsertDR("MSFY") = Portal.FiscalYear
                InsertDR("MSP") = MSP
                InsertDR("Week") = Wk
                InsertDR("SickPay") = FormatNumber(fuvSick.Text, 2)
                InsertDR("OTPay") = FormatNumber(fuvOT.Text, 2)
                DataSets.SickOtTable.Rows.Add(InsertDR)
                DataSets.SickOtAdapt.Update(DataSets.SickOtTable)
                DataSets.SickOtAdapt.Fill(DataSets.SickOtTable)
            Catch ex As Exception
                MsgBox("Unable to save due to the following error: " & ex.Message)
                Me.Close()
                Exit Sub
            End Try
        Else
            Try
                Dim dr() As DataRow = DataSets.SickOtTable.Select("UnitNumber = '" & Unit & "' and MSFY = '" & Portal.FiscalYear & "' and MSP = '" & MSP & "' and Week = '" & Wk & "'")
                dr(0)("OTPay") = FormatNumber(fuvOT.Text, 2)
                dr(0)("SickPay") = FormatNumber(fuvSick.Text, 2)
                DataSets.SickOtAdapt.Update(DataSets.SickOtTable)
                DataSets.SickOtAdapt.Fill(DataSets.SickOtTable)
            Catch ex As Exception
                MsgBox("Unable to save due to the following error: " & ex.Message)
                Me.Close()
                Exit Sub
            End Try
        End If
        MsgBox("Save successful!")
        Me.Close()
    End Sub

    Private Sub ExitForm(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class