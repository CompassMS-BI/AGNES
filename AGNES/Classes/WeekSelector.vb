Public Class WeekSelector
    Inherits ToolStripMenuItem
    Private wk As Byte
    Friend Property week As Byte
        Get
            Return wk
        End Get
        Set(value As Byte)
            wk = value
            Dim dd As ToolStripMenuItem
            For Each dd In DropDownItems
                If FormatNumber(dd.Tag, 0) = wk Then
                    dd.Checked = True
                Else
                    dd.Checked = False
                End If
            Next
        End Set
    End Property
    Private maxwk As Byte
    Property MaxWeek As Byte
        Get
            Return maxwk
        End Get
        Set(value As Byte)
            maxwk = value
            DisableWeeks()
        End Set
    End Property

    Public Sub New()
        Dim ct As Byte
        Text = "Select Week"
        For ct = 0 To 4
            Dim newitem As New ToolStripMenuItem With {.Text = "Week " & ct + 1, .Name = "P" & ct + 1, .Tag = ct + 1}
            DropDownItems.Add(newitem)
            AddHandler newitem.Click, AddressOf WeekChosen
        Next
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        Dim DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & Now().Date.AddDays(8) & "'")
        MaxWeek = DateDR(0)("Week")
    End Sub

    Public Sub WeekChosen(sender As Object, e As EventArgs)
        Dim tsmi As ToolStripDropDownItem = sender
        Dim tsm As MenuStrip = Me.Parent
        Select Case tsm.Name
            Case "mstWasteTracker"
                Dim frm As WasteTracking = tsm.Parent
                frm.week = DropDownItems.IndexOf(tsmi) + 1
                frm.panStations.Visible = True
            Case "mstFlashStatus"
                Dim frm As FlashStatus = tsm.Parent
                frm.Week = DropDownItems.IndexOf(tsmi) + 1
            Case "mstReceipts"
                Dim frm As VendorReceipts = tsm.Parent
                frm.SystemCall = True
                frm.Wk = DropDownItems.IndexOf(tsmi) + 1
        End Select
    End Sub

    Public Sub DisableWeeks()
        Dim tsmi As ToolStripMenuItem
        For Each tsmi In DropDownItems
            If FormatNumber(tsmi.Tag, 0) > MaxWeek Then
                tsmi.Enabled = False
            Else
                tsmi.Enabled = True
            End If
        Next
    End Sub

    Public Sub UpdateWeeks(fy, msp)
        Dim DateDR() As DataRow = DataSets.DateTable.Select("MS_FY = '" & fy & "' and MS_Period = '" & msp & "'")
        MaxWeek = ((DateDR.Count - 1) / 7)
    End Sub
End Class

