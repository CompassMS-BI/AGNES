Imports AxWMPLib

Public Class BigMedia
    Private Sub mpBigPlayer_ClickEvent(sender As Object, e As _WMPOCXEvents_ClickEvent) Handles mpBigPlayer.ClickEvent
        Me.Dispose()
        With Portal.mpWindow
            .Ctlcontrols.play()
        End With
        Portal.Show()
        Portal.BringToFront()
    End Sub

End Class