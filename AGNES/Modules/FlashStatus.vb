Public Class FlashStatus
    Public period As Byte
    Public wk As Byte
    Public FY As Long
    Public username As String
    Private CurrentView As Boolean
    Private ct As Integer
    Private unit As Long
    Private unitnm As String

    Friend Property Msp As Byte
        Get
            Return Msp
        End Get
        Set(value As Byte)
            period = value
            tsmiWeek.UpdateWeeks(FY, period)
            Week = 1
            tsslPeriod.Text = "Period: " & period
            tsslPeriod.Visible = True
            '#  Add other routine calls here
        End Set
    End Property

    Friend Property Week As Byte
        Get
            Return wk
        End Get
        Set(value As Byte)
            wk = value
            tsslWeek.Text = "Week: " & wk
            tsslWeek.Visible = True
            If CurrentView = 0 Then
                FetchSubmissions()
            Else
                FetchPending()
            End If
        End Set
    End Property

#Region "Initialize Flash Status"

    Private Sub LoadFlashStatus(sender As Object, e As EventArgs) Handles Me.Load
        DataSets.DateAdapt.Fill(DataSets.DateTable)
        DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
        Dim wk As Byte, DateDR() As DataRow = DataSets.DateTable.Select("Date_Id = '" & Now().Date & "'")
        FY = DateDR(0)("MS_FY")
        Msp = DateDR(0)("MS_Period")
        wk = DateDR(0)("Week") - 1 : If wk = 0 Then wk = 1
        Week = wk
        tsslFY.Text = FY
        lvwSubmissions.Columns.Item(0).TextAlign = HorizontalAlignment.Center
    End Sub

#End Region

#Region "User Controls"
    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Dispose()
        Portal.Show()
    End Sub

    Private Sub RefreshList(sender As Object, e As EventArgs) Handles tsmiRefresh.Click
        FetchSubmissions()
    End Sub

    Private Sub ViewFlash(sender As Object, e As EventArgs) Handles lvwSubmissions.DoubleClick
        Dim un As Long = FormatNumber(lvwSubmissions.SelectedItems(0).SubItems(0).Text, 0)
        Select Case un
            Case 19837      '#  Commons
                With WeeklyFlash
                    .FlashType = "WCC"
                    .HasForecast = False
                End With
            Case Else       '#  Cafes, BUT THIS SHOULD ALSO BE USED FOR FIELDS, EVENTUALLY
                With WeeklyFlash
                    .FlashType = "Cafes"
                    .HasForecast = True
                End With
        End Select
        With WeeklyFlash
            .UserName = username
            .UserLevel = "SU"
            .tsslUser.Text = "Current user: " & username
            .UnitNumber = FormatNumber(lvwSubmissions.SelectedItems(0).SubItems(0).Text, 0)
            .UnitName = lvwSubmissions.SelectedItems(0).Text
            .Text = "Weekly Flash - Unit " & WeeklyFlash.UnitNumber
            .SentFromView = True
            .Show()
        End With
    End Sub

    Private Sub ViewChosen(sender As Object, e As EventArgs) Handles radSubmitted.Click, radPending.Click
        Dim tmpitem As RadioButton = sender
        Select Case tmpitem.Name
            Case "radSubmitted"
                lblCurrentView.Text = "Submitted Flash Records"
                FetchSubmissions()
            Case "radPending"
                lblCurrentView.Text = "Pending Flash Records"
                FetchPending()
        End Select

    End Sub

#End Region

#Region "Functions"

    Private Sub FetchSubmissions()
        DataSets.FlashAdapt.Fill(DataSets.FlashTable)
        lvwSubmissions.Items.Clear()
        Dim dr() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & FY & "' and MSPeriod = '" & period & "' and Week = '" & Week & "' and Status = 'Flash' and GL_Category = 'COGS'")
        For ct = 0 To dr.Count - 1
            unit = dr(ct)("Unit")
            Dim dr1() As DataRow = DataSets.FlashLocationTable.Select("Unit_Number = '" & unit & "'")
            Dim grp As String = dr1(0)("Group")
            If grp = "Cafes" Or grp = "Commons" Then
                unitnm = dr1(0)("Unit_Number")
                Dim lvi As New ListViewItem(unitnm)
                lvi.SubItems.Add(dr1(0)("Unit"))
                lvwSubmissions.Items.Add(lvi)
            End If
        Next
        If lvwSubmissions.Items.Count = 0 Then lvwSubmissions.Items.Add("No submissions")
        CurrentView = 0
    End Sub

    Private Sub FetchPending()
        DataSets.FlashAdapt.Fill(DataSets.FlashTable)
        lvwSubmissions.Items.Clear()
        Dim dr() As DataRow = DataSets.FlashLocationTable.Select("Group = 'Cafes' or Group = 'Commons'")
        For ct = 0 To dr.Count - 1
            unitnm = dr(ct)("Unit_Number")
            Try
                Dim dr1() As DataRow = DataSets.FlashTable.Select("FiscalYear = '" & FY & "' and MSPeriod = '" & period & "' and Week = '" & Week & "' and Status = 'Flash' and GL_Category = 'COGS' and Unit = '" & unitnm & "'")
                If dr1.Count = 0 Then
                    Dim lvi As New ListViewItem(unitnm)
                    lvi.SubItems.Add(dr(ct)("profit_center_name"))
                    lvwSubmissions.Items.Add(lvi)
                End If
            Catch ex As Exception
                Dim lvi As New ListViewItem(unitnm)
                lvi.SubItems.Add(dr(ct)("Unit_Number"))
                lvwSubmissions.Items.Add(lvi)
            End Try
        Next
        CurrentView = 1
    End Sub

#End Region

End Class