Public Class GridLabel
    Inherits Label
    Property RowNum As Integer
    Property RowName As String
    Public Sub New()
        AutoSize = False
        Height = 25
        Width = 150
        BackColor = Color.LightGray
        MinimumSize = New System.Drawing.Size(75, 25)
        MaximumSize = New System.Drawing.Size(150, 25)
        Font = New Font(FontStyle.Bold, FontStyle.Bold)
        TextAlign = ContentAlignment.MiddleRight
    End Sub
End Class

