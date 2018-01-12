Public Class DateSelector
    Inherits ToolStripMenuItem
    Private ct As Byte
    Friend fy As Long
    Friend msp As Byte
    Friend week As Byte
    Public Sub New()
        Text = "Select Date"
        Enabled = False
    End Sub
    Friend Sub Populate()
        '#  Delete existing drop down items
        If DropDownItems.Count > 0 Then
            DropDownItems.Clear()
        End If

        '#  Add new items for the selected week
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        Dim dr() As DataRow = DataSets.DateTable.Select("MS_FY = '" & fy & "' and MS_Period = '" & msp & "' and Week = '" & week & "' and Weekend_Holiday_Flag = 'N'")
        For ct = 0 To dr.Count - 1
            Dim newitem As New ToolStripMenuItem With {.Text = FormatDateTime(dr(ct)("Date_ID"), DateFormat.LongDate), .Name = "D" & ct + 1, .Tag = ct + 1}
            DropDownItems.Add(newitem)
            AddHandler newitem.Click, AddressOf passdate
        Next
    End Sub

    Friend Sub passdate(sender As Object, e As EventArgs)
        Dim tsmi As ToolStripDropDownItem = sender
        Dim tsm As MenuStrip = Me.Parent
        Select Case tsm.Name
            Case "mstReceipts"
                Dim frm As VendorReceipts = tsm.Parent
                frm.SystemCall = False
                frm.DateChoice = FormatDateTime(tsmi.Text, DateFormat.LongDate)
        End Select
    End Sub
End Class
