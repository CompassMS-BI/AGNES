Public Class WasteNud
    Inherits NumericUpDown
    Public OldVal As Double
    Private Sub WasteNud_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        With Me
            .Increment = 0.1
            .Minimum = 0
            .Height = 50
            .Width = 55
            .DecimalPlaces = 1
        End With

    End Sub

    Private Sub SelectAllText(sender As Object, e As EventArgs) Handles Me.Enter, Me.Click
        Me.Select(0, Me.Text.Length)
    End Sub
End Class
