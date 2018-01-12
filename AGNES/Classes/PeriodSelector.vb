Public Class PeriodSelector
    Inherits ToolStripMenuItem
    Private maxmsp As Byte
    Private period As Byte
    Property MSP As Byte
        Get
            Return period
        End Get
        Set(value As Byte)
            period = value
            Dim dd As ToolStripMenuItem
            For Each dd In DropDownItems
                If FormatNumber(dd.Tag, 0) = period Then
                    dd.Checked = True
                Else
                    dd.Checked = False
                End If
            Next
        End Set
    End Property
    Property MaxPeriod As Byte
        Get
            Return maxmsp
        End Get
        Set(value As Byte)
            If value < maxmsp Then Exit Property
            maxmsp = value + 1
            If maxmsp = 13 Then maxmsp = 12
            DisablePeriods()
        End Set
    End Property

    Public Sub New()
        Dim ct As Byte, thelist() As String = {"1 (Jul)", "2 (Aug)", "3 (Sep)", "4 (Oct)", "5 (Nov)", "6 (Dec)", "7 (Jan)", "8 (Feb)", "9 (Mar)",
        "10 (Apr)", "11 (May)", "12 (Jun)"}
        Text = "Select MS Period"
        For ct = 0 To 11
            Dim newitem As New ToolStripMenuItem With {.Text = thelist(ct), .Name = "P" & ct + 1, .Tag = ct + 1, .CheckOnClick = True}
            DropDownItems.Add(newitem)
            AddHandler newitem.Click, AddressOf PeriodChosen
        Next
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        Dim dt As Date = Now().Date.AddDays(8)
        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & dt & "'")
        MaxPeriod = DateDR(0)("MS_Period")
    End Sub

    Public Sub PeriodChosen(sender As Object, e As EventArgs)
        Dim tsmi As ToolStripMenuItem = sender
        Dim tsm As MenuStrip = Me.Parent
        Select Case tsm.Name
            Case "mstWasteTracker"
                Dim frm As WasteTracking = tsm.Parent
                frm.msp = DropDownItems.IndexOf(tsmi) + 1
            Case "mstFlashStatus"
                Dim frm As FlashStatus = tsm.Parent
                frm.Msp = DropDownItems.IndexOf(tsmi) + 1
            Case "mstForecast"
                Dim frm As WeeklyForecast = tsm.Parent
                frm.Period = DropDownItems.IndexOf(tsmi) + 1
            Case "mstReceipts"
                Dim frm As VendorReceipts = tsm.Parent
                frm.SystemCall = True
                frm.MSP = DropDownItems.IndexOf(tsmi) + 1
        End Select
        MSP = DropDownItems.IndexOf(tsmi) + 1
    End Sub

    Public Sub DisablePeriods()
        Dim tsmi As ToolStripMenuItem
        For Each tsmi In DropDownItems
            If FormatNumber(tsmi.Tag, 0) > MaxPeriod Then
                tsmi.Enabled = False
            Else
                tsmi.Enabled = True
            End If
        Next
    End Sub

End Class

