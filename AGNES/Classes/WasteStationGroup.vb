Public Class WasteStationGroup
    Inherits Panel
    Public Property StationID As Integer
    Public Property StationName As String
    Private Sub CreateGroupHandle(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Dim StationLabel As New Label With {.Name = "StationLabel", .Text = StationName, .Width = Width - 2, .Left = 1, .BackColor = Color.SpringGreen, .TextAlign = ContentAlignment.MiddleCenter}
        Controls.Add(StationLabel)
        Dim ProdType As New WasteTypeGroup With {.WasteType = "Prod", .WasteName = "Production", .Width = 445, .Height = 60, .Left = 2, .Top = 20}
        Controls.Add(ProdType)
        Dim SpoilType As New WasteTypeGroup With {.WasteType = "Spoil", .WasteName = "Spoilage", .Width = 445, .Height = 60, .Left = 2, .Top = 75}
        Controls.Add(SpoilType)
        Dim TatType As New WasteTypeGroup With {.WasteType = "TimeAsTemp", .WasteName = "Time/Temp", .Width = 445, .Height = 60, .Left = 2, .Top = 130}
        Controls.Add(TatType)
    End Sub

End Class

