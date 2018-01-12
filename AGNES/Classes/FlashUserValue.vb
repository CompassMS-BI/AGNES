Public Class FlashUserValue
    Inherits CurrencyBox
    Public Sub New()
        Text = 0
        Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular)
    End Sub

    Private Sub EnterOrClickField(sender As Object, e As EventArgs) Handles Me.Enter, Me.Click
        [Select](0, Text.Length)
    End Sub

    Private Sub LeaveField(sender As Object, e As EventArgs) Handles Me.Leave
        Dim testsingle As Single
        testsingle = FormatNumber(Text, 0)
        If Debit = False Then
            If testsingle > 0 Then Text = -testsingle
        End If
        Text = FormatCurrency(Text, 0)

    End Sub

    Private Sub TextWasChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Text = "-" Then Exit Sub
        Dim testsingle As Single, currentlength As Byte
        Try
            'CafeFlash.ActiveWeek.ChangesMade = True
        Catch
        End Try
        If Text = "" Then
            Text = "0"
            [Select](0, 1)
            Exit Sub
        End If
        Try
            testsingle = FormatNumber(Text, 0)
        Catch ex As Exception
            Try
                currentlength = Len(Text)
                Text = Mid(Text, 1, currentlength - 1)
                [Select](Text.Length, 0)
            Catch
            End Try
        End Try
    End Sub

End Class