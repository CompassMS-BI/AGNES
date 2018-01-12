Public Class CurrencyBox
    Inherits TextBox
    Public Property AllowCredit As Boolean = False
    Public Property Debit As Boolean = True
    Public Property OpenValue As Boolean = False
    Public Property PosNegFont As Boolean

    Public Sub New()
        Text = "$0.00"
        TextAlign = HorizontalAlignment.Right
        Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular)
    End Sub

    Private Sub EnterField(sender As Object, e As EventArgs) Handles Me.Enter, Me.Click
        Text = FormatNumber(Me.Text, 2)
        [Select](0, Text.Length)
    End Sub

    Private Sub LeaveField(sender As Object, e As EventArgs) Handles Me.Leave
        Dim testsingle As Single
        testsingle = FormatNumber(Text, 2)
        If OpenValue = False Then
            If Debit = False Then
                If testsingle > 0 Then Text = -testsingle
            End If
            If testsingle < 0 And AllowCredit = False Then
                Text = 0
                MsgBox("Negative dollar amounts are Not allowed in this field!", vbCritical, "Invalid entry")
            End If
        End If

        Text = FormatCurrency(Text, 2)
    End Sub

    Private Sub TextValueChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        'If Text = "-" Then Exit Sub
        Dim testsingle As Single, currentlength As Byte
        If Text = "" Then
            Text = "$0.00"
            [Select](0, 1)
            Exit Sub
        End If
        Try
            testsingle = FormatNumber(Text, 2)
        Catch ex As Exception
            Try
                currentlength = Len(Text)
                Text = Mid(Text, 1, currentlength - 1)
                [Select](Text.Length, 0)
            Catch
            End Try
        End Try
        If PosNegFont = True Then
            Select Case testsingle
                Case 0
                    Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular)
                    BackColor = DefaultBackColor
                Case < 0
                    Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Bold)
                    BackColor = Color.Red
                Case Else
                    Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular)
                    BackColor = DefaultBackColor
            End Select
        End If
    End Sub

End Class