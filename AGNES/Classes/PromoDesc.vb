Public Class PromoDesc
    Inherits TextBox
    Private cc As Integer
    Friend Property CharCount As Integer
        Get
            Return cc
        End Get
        Set(value As Integer)
            cc = value
            Dim p As PromoEditor = Parent
            p.lblCharCt.Text = 500 - cc & " characters remaining"
        End Set
    End Property
    Public Sub New()
        Text = ""
        MaxLength = 500
        Multiline = True
    End Sub

    Private Sub PromoDesc_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        CharCount = TextLength
    End Sub
End Class
