Public Class SubButton
    Inherits System.Windows.Forms.Button
    Property UnitNumber As Single
    Property Submitted As Boolean
    Public Sub New()
        MyBase.Height = 23
        MyBase.Width = 363
    End Sub

    Private Sub SubButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        'With Parent
        '    .UserStatus = "Primary"
        '    .ActiveWeek.UnitNumber = UnitNumber
        '    .ActiveWeek.UnitName = MyBase.Text
        '    .SentFromView = True
        '    .Show()
        'End With
    End Sub
End Class

Public Class WCRTenderValue
    Inherits System.Windows.Forms.TextBox
    Public Sub New()
        Me.Text = 0
    End Sub

    Public Property Debit As Boolean = True
    Public Property VendorID As Integer
    Public Property TenderID As Integer
    Public Changed As Boolean


    Private Sub EnterField(sender As Object, e As EventArgs) Handles Me.Enter, Me.Click
        Me.Select(0, Me.Text.Length)
        Changed = False
    End Sub

    Private Sub LeaveField(sender As Object, e As EventArgs) Handles Me.Leave
        Dim testsingle As Single
        testsingle = FormatNumber(Me.Text, 2)
        If Me.Debit = False Then
            If testsingle > 0 Then Me.Text = -testsingle
        End If
        Me.Text = FormatCurrency(Me.Text, 2)
    End Sub

    Private Sub ChangedText(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Me.Text = "-" Then Exit Sub
        Dim testsingle As Single, currentlength As Byte
        Changed = True
        If Me.Text = "" Then
            Me.Text = "$0.00"
            Me.Select(0, 5)
            Exit Sub
        End If
        Try
            testsingle = FormatNumber(Me.Text, 2)
        Catch ex As Exception
            Try
                currentlength = Len(Me.Text)
                Me.Text = Mid(Me.Text, 1, currentlength - 1)
                Me.Select(Me.Text.Length, 0)
            Catch
            End Try
        End Try
    End Sub
End Class



