Public Class FlashUnitChooser
    Public ChooserType As Byte
    Public FlashType As String

#Region "Initialize Chooser"

    Private Sub LoadChooser(sender As Object, e As EventArgs) Handles Me.Load
        Select Case Portal.UserLevel
            Case "User"
                Dim AccessDR() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & Portal.UserID & "'")
                PopulateListUser(AccessDR)
            Case "Group"
                Dim AccessDR() As DataRow = DataSets.FlashLocationTable.Select("Group = '" & Portal.UserGroupAccess & "'")
                PopulateList(AccessDR)
            Case "SU", "Admin"
                Dim AccessDR() As DataRow = DataSets.FlashLocationTable.Select("Group = '" & FlashType & "'")
                PopulateList(AccessDR)
        End Select

    End Sub

    Private Sub PopulateList(ByRef aDR)
        Dim ADRtemp() As DataRow = aDR
        Dim ct As Byte
        lbxUnits.Items.Clear()
        For ct = 1 To ADRtemp.Count
            lbxUnits.Items.Add(ADRtemp(ct - 1)("Unit"))
            If ct < 15 And ADRtemp.Count > 2 Then
                lbxUnits.Height = lbxUnits.Height + 17
                Height = Height + 17
            End If
        Next
    End Sub

    Private Sub PopulateListUser(ByRef aDR)
        Dim ADRtemp() As DataRow = aDR
        Dim ct As Byte
        lbxUnits.Items.Clear()
        For ct = 1 To ADRtemp.Count
            Dim locDR() As DataRow = DataSets.FlashLocationTable.Select("Unit_Number = '" & ADRtemp(ct - 1)("UnitNumber") & "'")
            lbxUnits.Items.Add(locDR(0)("Unit"))
            If ct < 15 And ADRtemp.Count > 2 Then
                lbxUnits.Height = lbxUnits.Height + 17
                Height = Height + 17
            End If
        Next
    End Sub


#End Region

#Region "UserControls"
    Private Sub UnitChosen(sender As Object, e As EventArgs) Handles lbxUnits.SelectedValueChanged
        Dim unit As String = lbxUnits.SelectedItem
        Dim LocationDR() As DataRow = DataSets.FlashLocationTable.Select("Unit = '" & unit & "'")
        Select Case ChooserType
            Case 0
                With WeeklyFlash
                    .UnitNumber = LocationDR(0)("Unit_Number")
                    .UnitName = unit
                    .Text = "Weekly Flash - Unit " & WeeklyFlash.UnitNumber
                End With
            Case 1
                With WasteTracking
                    .unum = LocationDR(0)("Unit_Number")
                    .unitnm = unit
                End With
            Case 2
                With WeeklyForecast
                    .UnitNumber = LocationDR(0)("Unit_Number")
                    .forecasttype = "Cafes"
                End With
            Case 3
                With CafeJournal
                    .UnitNum = LocationDR(0)("Unit_Number")
                End With
        End Select
        Dispose()
    End Sub
#End Region

End Class