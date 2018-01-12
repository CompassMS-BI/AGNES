Public Class Admin
    Private UserPID As Integer
    Private Property SelectedUser As Integer
        Get
            Return UserPID
        End Get
        Set(value As Integer)
            UserPID = value
            PopulateModules()
        End Set
    End Property

#Region "Initialize"

    Private Sub LoadModule(sender As Object, e As EventArgs) Handles Me.Load
        AGNESUsersTableAdapter.Fill(AGNESData.AGNESUsers)
        dgvUsers.ClearSelection()
        panUserAccess.Visible = True
        SelectedUser = -1
        '#  RESERVED FOR LATER USE - HIDE OTHER PANELS
    End Sub

#End Region

#Region "Toolstrip and User Controls"
    Private Sub CloseModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Dispose()
        Portal.Show()
    End Sub

    Private Sub ClearFields(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAlias.Text = ""
        txtName.Text = ""
        txtSpeakName.Text = ""
        cbxAccess.Text = ""
        cbxAccess.SelectedIndex = -1
        SelectedUser = -1
        btnAddEditUser.Text = "Add"
    End Sub

    Private Sub SaveUserInfo(sender As Object, e As EventArgs) Handles btnAddEditUser.Click
        If btnAddEditUser.Text = "Save" Then
            UpdateUser()
        Else
            AddUser()
        End If

    End Sub

    Private Sub UserCellChosen(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim i As Integer = dgvUsers.CurrentRow.Index
        txtAlias.Text = dgvUsers.Item(1, i).Value
        txtName.Text = dgvUsers.Item(2, i).Value
        cbxAccess.Text = dgvUsers.Item(3, i).Value
        txtSpeakName.Text = dgvUsers.Item(4, i).Value
        SelectedUser = FormatNumber(dgvUsers.Item(0, i).Value, 0)
        btnAddEditUser.Text = "Save"
    End Sub

#End Region

#Region "Functions"

    Private Sub PopulateModules()
        dgvModules.Rows.Clear()
        DataSets.ModuleAdapt.Fill(DataSets.ModuleTable)
        DataSets.ModuleAccessAdapt.Fill(DataSets.ModuleAccessTable)
        Dim moddr() As DataRow = DataSets.ModuleTable.Select("GroupName <> 'All' and GroupName <> 'Admin'")
        Dim ct As Byte, accessval As Boolean, modnm As String
        For ct = 0 To moddr.Count - 1
            accessval = False
            modnm = moddr(ct)("ModuleName")
            If cbxAccess.Text = "Admin" Then
                accessval = True
                dgvModules.ReadOnly = True
            Else
                dgvModules.ReadOnly = False
                dgvModules.Columns(0).ReadOnly = True
                Try
                    Dim dr() As DataRow = DataSets.ModuleAccessTable.Select("ModuleAccess = '" & modnm & "' and UID = '" & SelectedUser & "'")
                    If dr.Count > 0 Then accessval = True
                Catch ex As Exception

                End Try
            End If
            dgvModules.Rows.Add(moddr(ct)("ModuleName"), accessval)
        Next
    End Sub

    Private Sub UpdateUser()
        Dim ct As Byte
        '#  VALIDATE BASE USER METADATA IS COMPLETE AND NOTHING WAS CHANGED

        '#  Add module access information
        For ct = 0 To dgvModules.Rows.Count - 1
            Select Case dgvModules.Item(1, ct).Value
                Case True
                    '#  Check to see if access is already present
                    Dim chkdr() As DataRow = DataSets.ModuleAccessTable.Select("UID = '" & SelectedUser & "' and ModuleAccess = '" & dgvModules.Item(0, ct).Value & "'")
                    '#  If it is, ignore.  If not, add a new row
                    If chkdr.Count = 0 Then AddNewModuleAccessRow(SelectedUser, dgvModules.Item(0, ct).Value)

                Case False
                    '#  Check to see if access is already present
                    Dim chkdr() As DataRow = DataSets.ModuleAccessTable.Select("UID = '" & SelectedUser & "' and ModuleAccess = '" & dgvModules.Item(0, ct).Value & "'")
                    '#  If present, delete.  If not, ignore
                    If chkdr.Count > 0 Then chkdr(0).Delete()
            End Select
        Next
        DataSets.ModuleAccessAdapt.Update(DataSets.ModuleAccessTable)
        DataSets.ModuleAccessAdapt.Fill(DataSets.ModuleAccessTable)

    End Sub

    Private Sub AddUser()
        Dim ct As Byte
        '#  VALIDATE BASE USER METADATA IS COMPLETE

        '#  ADD USER TO USERS TABLE
        Dim InsertUserDR As DataRow = DataSets.UsersTable.NewRow()
        InsertUserDR("Username") = txtName.Text
        InsertUserDR("UserAlias") = txtAlias.Text
        InsertUserDR("Shortname") = txtSpeakName.Text
        InsertUserDR("AccessLevel") = cbxAccess.Text
        DataSets.UsersTable.Rows.Add(InsertUserDR)

        '# Get the newly assigned PID for related UID
        DataSets.UsersAdapt.Update(DataSets.UsersTable)
        DataSets.UsersAdapt.Fill(DataSets.UsersTable)
        Dim dr() As DataRow = DataSets.UsersTable.Select("Username = '" & txtName.Text & "'")
        Dim newuid As Integer = dr(0)("PID")

        '#  Add module access information
        For ct = 0 To dgvModules.Rows.Count - 1
            If dgvModules.Item(1, ct).Value = True Then
                '#  If access granted, add datarow
                AddNewModuleAccessRow(newuid, dgvModules.Item(0, ct).Value)
            End If
        Next
        DataSets.ModuleAccessAdapt.Update(DataSets.ModuleAccessTable)
        DataSets.ModuleAccessAdapt.Fill(DataSets.ModuleAccessTable)

        '# UPDATE DGVUSER
        dgvUsers.Refresh()

    End Sub

    Private Sub AddNewModuleAccessRow(uid, modname)

        Try
            Dim InsertModuleDR As DataRow = DataSets.ModuleAccessTable.NewRow()
            InsertModuleDR("UID") = uid
            InsertModuleDR("ModuleAccess") = modname
            DataSets.ModuleAccessTable.Rows.Add(InsertModuleDR)
        Catch ex As Exception
            MsgBox("Something went wrong with saving a new row")
        End Try

    End Sub

#End Region

End Class