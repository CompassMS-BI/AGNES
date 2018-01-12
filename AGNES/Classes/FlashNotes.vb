Public Class FlashNotes
    Inherits AgnesTxt
    Dim systemchange As Boolean
    Public Sub New()
        Text = "Add notes here"
        ForeColor = Color.DimGray
        Multiline = True
        Height = 54
    End Sub

    Private Sub FlashNotes_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        If Text = "Add notes here" Then
            systemchange = True
            Text = ""
            ForeColor = Color.Black
            systemchange = False
        Else
            [Select](Len(Me.Text), 0)
        End If
    End Sub

    Private Sub FlashNotes_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Dim fg As FlashGroup, fn As FlashNotes = sender
        fg = fn.Parent

        Select Case Text
            Case ""
                Text = "Add notes here"
                ForeColor = Color.DimGray
            Case "Add notes here"
                fg.NoteValue = ""
            Case Else
                fg.NoteValue = fn.Text
        End Select

    End Sub

    Private Sub FlashNotes_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

        If Text = "" And systemchange = False Then
            Text = "Add notes here"
            ForeColor = Color.DimGray
        End If
        If Text <> "" Then
            If Mid(Text, 2, Len(Text) - 1) = "Add notes here" Then
                Text = Mid(Text, 1, 1)
                [Select](Len(Text), 0)
                ForeColor = Color.Black
            End If
        End If
    End Sub

End Class

