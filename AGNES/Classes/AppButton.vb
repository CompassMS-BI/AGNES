Public Class AppButton
    Inherits Button
    Property AppName As String
    Public Sub New()
        Width = 112
        Height = 112
        FlatStyle = FlatStyle.Flat
        With FlatAppearance
            .BorderSize = 0
            .MouseOverBackColor = ColorTranslator.FromHtml(ColorPalette.MouseOverColor)
            .MouseDownBackColor = ColorTranslator.FromHtml(ColorPalette.MouseOverColor)
        End With
        BackColor = Color.Transparent

    End Sub
End Class
