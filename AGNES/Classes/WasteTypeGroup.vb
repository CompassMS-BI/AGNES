Public Class WasteTypeGroup
    Inherits Panel
    Public Property WasteType As String
    Public Property WasteName As String
    Public Property TotalWasteValue As Double

    Private Sub CreateGroupHandle(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Dim fri As New WasteNud, mon As New WasteNud, tue As New WasteNud, wed As New WasteNud,
            thu As New WasteNud, ttl As New WasteNud

        Dim frilbl As New Label, monlbl As New Label, tuelbl As New Label, wedlbl As New Label, thulbl As New Label, weeklbl As New Label

        Dim typelbl As New Label With {.Text = WasteName, .AutoSize = False, .Left = 1, .Top = 5, .TextAlign = ContentAlignment.MiddleRight, .Height = 50, .Width = 80}
        Controls.Add(typelbl)

        With frilbl
            .Top = 2
            .Left = 85
            .Width = 55
            .Height = 15
            .Text = "Fri"
            .TextAlign = ContentAlignment.TopCenter
        End With
        Controls.Add(frilbl)

        With fri
            .Top = 20
            .Left = 85
            .Name = "Friday"
            .Maximum = 100
        End With
        Controls.Add(fri)
        AddHandler fri.Enter, AddressOf SaveOld
        AddHandler fri.ValueChanged, AddressOf CompareNew

        With monlbl
            .Top = 2
            .Left = 145
            .Width = 55
            .Height = 15
            .Text = "Mon"
            .TextAlign = ContentAlignment.TopCenter
        End With
        Controls.Add(monlbl)

        With mon
            .Top = 20
            .Left = 145
            .Name = "Monday"
            .Maximum = 100
        End With
        Controls.Add(mon)
        AddHandler mon.Enter, AddressOf SaveOld
        AddHandler mon.ValueChanged, AddressOf CompareNew

        With tuelbl
            .Top = 2
            .Left = 205
            .Width = 55
            .Height = 15
            .Text = "Tue"
            .TextAlign = ContentAlignment.TopCenter
        End With
        Controls.Add(tuelbl)

        With tue
            .Top = 20
            .Left = 205
            .Name = "Tuesday"
            .Maximum = 100
        End With
        Controls.Add(tue)
        AddHandler tue.Enter, AddressOf SaveOld
        AddHandler tue.ValueChanged, AddressOf CompareNew

        With wedlbl
            .Top = 2
            .Left = 265
            .Width = 55
            .Height = 15
            .Text = "Wed"
            .TextAlign = ContentAlignment.TopCenter
        End With
        Controls.Add(wedlbl)

        With wed
            .Top = 20
            .Left = 265
            .Name = "Wednesday"
            .Maximum = 100
        End With
        Controls.Add(wed)
        AddHandler wed.Enter, AddressOf SaveOld
        AddHandler wed.ValueChanged, AddressOf CompareNew

        With thulbl
            .Top = 2
            .Left = 325
            .Width = 55
            .Height = 15
            .Text = "Thu"
            .TextAlign = ContentAlignment.TopCenter
        End With
        Controls.Add(thulbl)

        With thu
            .Top = 20
            .Left = 325
            .Name = "Thursday"
            .Maximum = 100
        End With
        Controls.Add(thu)
        AddHandler thu.Enter, AddressOf SaveOld
        AddHandler thu.ValueChanged, AddressOf CompareNew

        With weeklbl
            .Top = 2
            .Left = 385
            .Width = 55
            .Height = 15
            .Text = "Week"
            .TextAlign = ContentAlignment.TopCenter
        End With
        Controls.Add(weeklbl)

        With ttl
            .Top = 20
            .Left = 385
            .Name = "WeekTotal"
            .Enabled = False
            .TabStop = False
            .Maximum = 999
        End With
        Controls.Add(ttl)
    End Sub

    Friend Sub SaveOld(sender As Object, e As EventArgs)
        Dim sndr As WasteNud = sender
        sndr.OldVal = sndr.Value
    End Sub

    Friend Sub CompareNew(sender As Object, e As EventArgs)
        TotalWasteValue = 0
        Dim sndr As WasteNud = sender
        If sndr.Value <> sndr.OldVal Then
            Dim wsg As WasteStationGroup = Me.Parent
            Dim pan As Panel = wsg.Parent
            Dim frm As WasteTracking = pan.Parent
            frm.Datasaved = False
        End If
        CalculateTotalWaste()
    End Sub

    Friend Sub CalculateTotalWaste()
        Dim wn As Control
        For Each wn In Controls
            If TypeOf (wn) Is WasteNud Then
                Dim activewn As WasteNud = wn
                If activewn.Name <> "WeekTotal" Then TotalWasteValue += FormatNumber(wn.Text, 1)
            End If
        Next

        Dim tot As WasteNud = Controls("WeekTotal")
        tot.Value = TotalWasteValue
    End Sub
End Class

