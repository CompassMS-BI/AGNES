Imports System.ComponentModel

Public Class ChoosePromo
    Private CMSControl As Button
    Private un As String
    Friend Property UserName As String
        Get
            Return un
        End Get
        Set(value As String)
            un = value
            lblGreet.Text = "Hi, " & un & ".  Select a promotion or create a new one!"
        End Set
    End Property

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.UsersAdapt.Fill(DataSets.UsersTable)
        ' Load info into properties
        Dim dr() As DataRow = DataSets.UsersTable.Select("Username = '" & Portal.UserName & "'")
        UserName = dr(0)("Shortname")
        ConstructPromos()
        Select Case UserName
            Case "Lawrence", "Brian"
                tsmiAssignPOS.Enabled = True
                tsmiClone.Enabled = False
                lblGreet.Text = "Hi, " & un & ".  Select a promotion to view or manage POS IDs!"
                PromoEditor.POSEditor = True
            Case Else
        End Select
    End Sub

    Private Sub ConstructPromos()
        DataSets.PromoAdapt.Fill(DataSets.PromoTable)
        'Construct Add New
        Dim dr() As DataRow = DataSets.PromoTable.Select
        If dr.Count = 0 Then Exit Sub
        For ct = 0 To dr.Count - 1
            Dim btn As New Button With {.Width = 230, .Height = 75, .TextAlign = ContentAlignment.MiddleCenter, .Text = dr(ct)("PromoName"),
                .BackColor = Color.Transparent, .FlatStyle = FlatStyle.Flat, .Font = New Font("Segoe UI Emoji", 10), .Tag = dr(ct)("PID"),
                .ContextMenuStrip = cmsPromoChoice, .BackgroundImage = My.Resources.pill_button, .BackgroundImageLayout = ImageLayout.Zoom}
            btn.FlatAppearance.BorderSize = 0
            flpPromotions.Controls.Add(btn)
            AddHandler btn.Click, AddressOf PromoChosen
        Next
        Dim ExitBtn As New Button With {.Width = 230, .Height = 75, .TextAlign = ContentAlignment.MiddleCenter, .Text = "Exit",
        .BackColor = Color.Transparent, .FlatStyle = FlatStyle.Flat, .Font = New Font("Segoe UI Emoji", 14, FontStyle.Bold), .BackgroundImage = My.Resources.pill_button,
        .BackgroundImageLayout = ImageLayout.Zoom, .ForeColor = Color.Yellow}
        ExitBtn.FlatAppearance.BorderSize = 0
        flpPromotions.Controls.Add(ExitBtn)
        AddHandler ExitBtn.Click, AddressOf ExitForm
    End Sub

    Private Sub CreateNewPromo(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dispose()
        With PromoEditor
            .PromoID = -1
            .Cloned = False
            .Show()
        End With
    End Sub

    Private Sub PromoChosen(sender As Object, e As EventArgs)
        Dispose()
        Dim s As Button = sender
        With PromoEditor
            .PromoID = FormatNumber(s.Tag, 0)
            .Show()
        End With
    End Sub

    Private Sub ExitForm()
        Dispose()
        Portal.Show()
    End Sub

    Private Sub ClonePromo(sender As Object, e As EventArgs) Handles tsmiClone.Click
        Dispose()
        With PromoEditor
            .PromoID = FormatNumber(CMSControl.Tag, 0)
            .Cloned = True
            .Show()
        End With
    End Sub

    Private Sub AssignPOSIds_Click(sender As Object, e As EventArgs) Handles tsmiAssignPOS.Click
        Close()
        With PromoIDMgr
            .SelectedPromoName = CMSControl.Text
            .Show()
        End With
    End Sub

    Private Sub cmsPromoChoice_Opening(sender As Object, e As CancelEventArgs) Handles cmsPromoChoice.Opening
        CMSControl = cmsPromoChoice.SourceControl
    End Sub

End Class