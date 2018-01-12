Public Class AgnesMsgBox
    Property Choicemade As Boolean
    Public Sub New(msg As String, align As Byte, choice As Boolean, sndr As String)

        InitializeComponent()
        With lblMsgBox
            .Text = msg
            .TextAlign = align
        End With

        If choice = True Then
            btnNo.Visible = True
            btnYes.Visible = True
            btnOK.Visible = False
        Else
            btnNo.Visible = False
            btnYes.Visible = False
            btnOK.Visible = True
        End If
    End Sub

    Private Sub Okay(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Choicemade = True
        Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Choicemade = False
        Close()
    End Sub
End Class