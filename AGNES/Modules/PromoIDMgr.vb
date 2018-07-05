Public Class PromoIDMgr
    Private prId As Integer
    Friend Property SelectedPromoID As Integer
        Get
            Return prId
        End Get
        Set(value As Integer)
            prId = value
        End Set
    End Property

    Private promonm As String
    Friend Property SelectedPromoName As String
        Get
            Return promonm
        End Get
        Set(value As String)
            promonm = value
            tsslPromo.Text = promonm
            If promonm = "" Then
                tsslPromo.Visible = False
                SelectedPromoID = 0
            Else
                tsslPromo.Visible = True
                FetchPromoID()
            End If
        End Set
    End Property

    Private Chngd As Boolean
    Friend Property Changed As Boolean
        Get
            Return Chngd
        End Get
        Set(value As Boolean)
            Chngd = value
            If Chngd = True Then
                tsslStatus.Text = "Unsaved"
            Else
                tsslStatus.Text = "Saved"
            End If
        End Set
    End Property

    Private ct As Integer
    Private ynchoice As Boolean

#Region "Initialization"
    Private Sub LoadPOSEditor(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.PromoPOSAdapt.Fill(DataSets.PromoPOSTable)

        '// Clear and load Promo list
        lbxPromoList.Items.Clear()
        FetchAllPromos()

        '// Drop user to default field
        ActiveControl = txtAssociatedID
    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        If Changed = False Then Exit Sub
        SaveInformation()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If Changed = True Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Are you sure that you want to exit?", 2, True, Me.Name)
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Close()
        Portal.Show()
    End Sub

    Private Sub ViewUnassociatedPromos(sender As Object, e As EventArgs) Handles tsmiUnassociated.Click
        lbxPromoList.Items.Clear()
        FetchFilteredPromos(0)
        tsmiAllPromos.Checked = False
        tsmiAssociated.Checked = False
    End Sub

    Private Sub ViewAssociatedPromos(sender As Object, e As EventArgs) Handles tsmiAssociated.Click
        lbxPromoList.Items.Clear()
        FetchFilteredPromos(1)
        tsmiAllPromos.Checked = False
        tsmiUnassociated.Checked = False
    End Sub

    Private Sub ViewAllPromos(sender As Object, e As EventArgs) Handles tsmiAllPromos.Click
        lbxPromoList.Items.Clear()
        FetchAllPromos()
        tsmiUnassociated.Checked = False
        tsmiAssociated.Checked = False
    End Sub

#End Region

#Region "User Fields"

    '// Listbox promo choice
    Private Sub Promotion_Selected(sender As Object, e As EventArgs) Handles lbxPromoList.SelectedIndexChanged
        SelectedPromoName = lbxPromoList.SelectedItem
        FetchPOSIDs()
    End Sub

    '// ID entry field Enter key hit
    Private Sub txtAssociatedID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAssociatedID.KeyDown
        If e.KeyCode = Keys.Enter Then
            '// Validate POS ID isn't already present
            For ct = 0 To dgvPOSIDs.Rows.Count - 1
                If dgvPOSIDs.Rows(ct).Cells(0).Value = txtAssociatedID.Text Then
                    txtAssociatedID.Text = ""
                    Exit Sub
                End If
            Next
            '// Capture type
            Dim ptype As String = "P"
            If radDisc.Checked = True Then ptype = "D"

            '// Add to the datagridview list
            dgvPOSIDs.Rows.Add(txtAssociatedID.Text, ptype)
            txtAssociatedID.Text = ""
            Changed = True
        End If
    End Sub

#End Region

#Region "Functions"

    Private Sub SaveInformation()
        '// Loop through each item in the DGV
        '// Check to see if it exists in the database as an association already
        '// If not, then write a new line
        Dim currentId As String
        For ct = 0 To dgvPOSIDs.RowCount - 1
            currentId = dgvPOSIDs.Rows(ct).Cells(0).Value
            If currentId <> "" Then
                If IsPresent(currentId) = False Then
                    Dim dr As DataRow = DataSets.PromoPOSTable.NewRow()
                    dr("PromoID") = SelectedPromoID
                    dr("POSID") = dgvPOSIDs.Rows(ct).Cells(0).Value
                    dr("POSType") = dgvPOSIDs.Rows(ct).Cells(1).Value
                    DataSets.PromoPOSTable.Rows.Add(dr)
                End If
            End If
        Next
        DataSets.PromoPOSAdapt.Update(DataSets.PromoPOSTable)
        Changed = False
        Dim amsg As New AgnesMsgBox("Changes saved successfully.", 2, False, Me.Name)
        amsg.ShowDialog()
        amsg.Dispose()
    End Sub

    Private Function IsPresent(ID)
        Dim dr() As DataRow = DataSets.PromoPOSTable.Select("PromoID = '" & SelectedPromoID & "' and POSID = '" & ID & "'")
        If dr.Count > 0 Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Sub FetchPromoID()
        '// Fetch the promo ID associated with the promotion name
        Dim dr() As DataRow = DataSets.PromoTable.Select("PromoName = '" & SelectedPromoName & "'")
        If dr.Count = 0 Then
            SelectedPromoID = 0
        Else
            SelectedPromoID = FormatNumber(dr(0)("PID"), 0)

        End If
    End Sub

    Private Sub FetchPOSIDs()
        '// Fetch POSIDs associated with selected Promotion
        dgvPOSIDs.Rows.Clear()
        Dim dr() As DataRow = DataSets.PromoPOSTable.Select("PromoID = '" & SelectedPromoID & "'")
        If dr.Count = 0 Then Exit Sub
        For ct = 0 To dr.Count - 1
            dgvPOSIDs.Rows.Add(dr(ct)("POSID"), dr(ct)("POSType"))
        Next
        dgvPOSIDs.ClearSelection()
    End Sub

    Private Sub FetchAllPromos()
        Dim dr() As DataRow = DataSets.PromoTable.Select()
        For ct = 0 To dr.Count - 1
            lbxPromoList.Items.Add(dr(ct)("PromoName"))
            If dr(ct)("PromoName") = promonm Then lbxPromoList.SelectedIndex = ct
        Next
    End Sub

    Private Sub FetchFilteredPromos(f)
        Dim dr() As DataRow = DataSets.PromoTable.Select()
        For ct = 0 To dr.Count - 1
            Dim tmpID As Integer = dr(ct)("PID")
            Dim dr1() As DataRow = DataSets.PromoPOSTable.Select("PromoID = '" & tmpID & "'")
            Select Case f
                Case 0      ' Unassociated
                    If dr1.Count = 0 Then lbxPromoList.Items.Add(dr(ct)("PromoName"))
                Case 1      ' Associated
                    If dr1.Count > 0 Then lbxPromoList.Items.Add(dr(ct)("PromoName"))
            End Select
        Next
    End Sub

#End Region

End Class