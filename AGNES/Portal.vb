Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Imports AxWMPLib

Public Class Portal
    Friend UserID As String = Environment.UserName
    Friend FiscalYear = 2018
    Friend UserName As String
    Friend ShortName As String
    Friend UserLevel As String
    Friend UID As Integer
    Friend UserGroupAccess As String
    Friend Synth As New SpeechSynthesizer With {.Rate = 1}
    Friend Muted As Boolean
    Private SystemChange As Boolean

#Region "Initialization"

    Private Sub PortalLoad(sender As Object, e As EventArgs) Handles Me.Load
        '#      Check for networks connection
        Dim connected As Boolean = False

        ' UserID = "v-rolagu"      ' Enable and define this to "impersonate" another user for testing

        Try
            DataSets.UsersAdapt.Fill(DataSets.UsersTable)
            DataSets.ModuleAdapt.Fill(DataSets.ModuleTable)
            connected = True
        Catch ex As System.Data.OleDb.OleDbException
            connected = False
        Catch ex As System.Data.SqlClient.SqlException
            connected = False

        Finally
            If connected = False Then

                Dim a As New AgnesMsgBox("Unable To connect To the database.  Make sure that you're online and try opening AGNES again." &
vbCr & vbCr & "If the problem persists, contact the BI dept with this information:" & vbCr & Err.Description, 2, False, Me.Name)
                a.ShowDialog()
                a.Dispose()

            End If

        End Try

        If connected = False Then
            Application.Exit()
            Exit Sub
            Dispose()
        End If

        '///    Get user identity and permissions
        getUserName()
        getannouncements()
        GetAvailableItems()
        gettipoftheday()
        Dim SystemInformation As String = "Version " & Application.ProductVersion & vbCr & "Current User: " & UserName & vbCr & "Access Level: " & UserLevel
        lblPortalInfo.Text = SystemInformation

        With mpWindow
            .uiMode = "none"
            .URL = "\\compasspowerbi\BusinessIntelligence\AGNESMedia\Chef_Feature_500.mp4"
            .settings.mute = True
        End With

        pbxGIFAnnouncement.BackgroundImageLayout = ImageLayout.Zoom

        '#  GET USER PREFERENCES - MUTE OPTION, OTHERS
        Synth.SelectVoice("Microsoft Zira Desktop")
        SystemChange = True


        Muted = My.Settings.MuteAgnes
        chkMute.Checked = Muted

        SystemChange = False

    End Sub

    Private Sub PostLoad(sender As Object, e As EventArgs) Handles Me.Shown
        If Muted = False Then

            Dim tm As Integer = Now.Hour
            'tm = 23 '- -Test time responses
            Select Case tm
                Case < 4
                    Synth.SpeakAsync("Hi-" & ShortName & ",.  Seems a little too early to me,, but,, what are we doing this morning?")
                Case < 12
                    Synth.SpeakAsync("Good morning-" & ShortName & ",.  What are we doing today?")
                Case < 17
                    Synth.SpeakAsync("Good afternoon-" & ShortName & ",.  What are we doing today?")
                Case < 22
                    Synth.SpeakAsync("Good evening-" & ShortName & ",.  What are we doing today?")
                Case Else
                    Synth.SpeakAsync("Hi-" & ShortName & ",.  Look,,it's probably none of my business,, but shouldn't you get some sleep?")
            End Select
        End If
    End Sub

    Private Sub getUserName()
        Dim userDR() As DataRow = DataSets.UsersTable.Select("UserAlias = '" & UserID & "'")
        Try
            UID = userDR(0)("PID")
            UserName = userDR(0)("Username")
            UserLevel = userDR(0)("AccessLevel")
            ShortName = userDR(0)("ShortName")
        Catch ex As Exception
            Dim a As New AgnesMsgBox(vbCr & "You do not appear to have any access.  Please contact your manager.", 2, False, Me.Name)
            a.ShowDialog()
            a.Dispose()
            Application.Exit()
        End Try
    End Sub

    Private Sub GetAvailableItems()
        DataSets.ModuleAccessAdapt.Fill(DataSets.ModuleAccessTable)
        Dim ItemR As Byte
        Select Case UserLevel
            Case "Admin"
                For ItemR = 0 To DataSets.ModuleTable.Rows.Count - 1
                    Dim NewAppButton As New AppButton
                    If DataSets.ModuleTable.Rows(ItemR).Item("ModuleImageResourceName") = "Text" Then
                        With NewAppButton
                            .Visible = True
                            .Text = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                            .AppName = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                        End With
                    Else
                        With NewAppButton
                            .Visible = True
                            .BackgroundImage = My.Resources.ResourceManager.GetObject(DataSets.ModuleTable.Rows(ItemR).Item("ModuleImageResourceName"))
                            .BackgroundImageLayout = ImageLayout.Zoom
                            .AppName = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                        End With
                    End If
                    flpModules.Controls.Add(NewAppButton)
                    AddHandler NewAppButton.Click, AddressOf AppSelected
                Next

            Case "User", "SU"
                Dim modulename As String, modulecount As Byte
                Dim ModulesDR() As DataRow = DataSets.ModuleAccessTable.Select("UID = '" & UID & "'")
                For modulecount = 1 To ModulesDR.Count
                    modulename = ModulesDR(modulecount - 1)("ModuleAccess")
                    For ItemR = 0 To DataSets.ModuleTable.Rows.Count - 1
                        If DataSets.ModuleTable.Rows(ItemR).Item("ModuleName") = modulename Then
                            Dim NewAppButton As New AppButton
                            If DataSets.ModuleTable.Rows(ItemR).Item("ModuleImageResourceName").ToString = "" Then
                                With NewAppButton
                                    .Visible = True
                                    .Text = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                                    .AppName = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                                End With
                            Else
                                With NewAppButton
                                    .Visible = True
                                    .BackgroundImage = My.Resources.ResourceManager.GetObject(DataSets.ModuleTable.Rows(ItemR).Item("ModuleImageResourceName").ToString)
                                    .BackgroundImageLayout = ImageLayout.Zoom
                                    .AppName = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                                End With
                            End If
                            flpModules.Controls.Add(NewAppButton)
                            AddHandler NewAppButton.Click, AddressOf AppSelected
                        End If
                    Next
                Next
                ' Add public access buttons
                For ItemR = 0 To DataSets.ModuleTable.Rows.Count - 1
                    If DataSets.ModuleTable.Rows(ItemR).Item("GroupName") = "All" Then
                        Dim NewAppButton As New AppButton
                        If DataSets.ModuleTable.Rows(ItemR).Item("ModuleImageResourceName").ToString = "" Then
                            With NewAppButton
                                .Visible = True
                                .Text = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                                .AppName = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                            End With
                        Else
                            With NewAppButton
                                .Visible = True
                                .BackgroundImage = My.Resources.ResourceManager.GetObject(DataSets.ModuleTable.Rows(ItemR).Item("ModuleImageResourceName").ToString)
                                .BackgroundImageLayout = ImageLayout.Zoom
                                .AppName = DataSets.ModuleTable.Rows(ItemR).Item("ModuleName")
                            End With
                        End If
                        flpModules.Controls.Add(NewAppButton)
                        AddHandler NewAppButton.Click, AddressOf AppSelected
                    End If
                Next
        End Select

    End Sub

#End Region

#Region "StaticControls"
    '#--------------------------------------------------------------
    '#      THIS SECTION HANDLES THE MAIN PAGE STATIC CONTROLS
    '#--------------------------------------------------------------

    Private Sub HoverOverMinimizeBox(sender As Object, e As EventArgs) Handles lblMinimize.MouseEnter
        lblMinimize.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub LeaveMinimizeBox(sender As Object, e As EventArgs) Handles lblMinimize.MouseLeave
        lblMinimize.BackColor = Color.White
    End Sub

    Private Sub MinimizePortal(sender As Object, e As EventArgs) Handles lblMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HoverOverCloseBox(sender As Object, e As EventArgs) Handles lblCloseForm.MouseEnter
        lblCloseForm.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub LeaveCloseBox(sender As Object, e As EventArgs) Handles lblCloseForm.MouseLeave
        lblCloseForm.BackColor = Color.White
    End Sub

    Private Sub ClosePortal(sender As Object, e As EventArgs) Handles lblCloseForm.Click
        Application.Exit()
    End Sub

    Private Sub AppSelected(sender As Object, e As EventArgs)
        Dim btn As AppButton = CType(sender, AppButton)
        OpenApplication(btn.AppName)
    End Sub

    Private Sub ToggleMute(sender As Object, e As EventArgs) Handles chkMute.CheckedChanged
        If SystemChange = True Then Exit Sub
        My.Settings.MuteAgnes = Not My.Settings.MuteAgnes
        My.Settings.Save()
        Muted = Not Muted
    End Sub

#End Region

#Region "Module Activation"
    '/--------------------------------------------------------------
    '/      THIS SECTION HANDLES OPENING SELECTED MODULES.
    '/      IT REQUIRES UPDATING FOR ANY NEW APPLICATIONS
    '/      APPLY VALUES TO APPLICATION VARIABLES AT LOAD AND
    '/      DEFINE ANY ADDITIONAL SPECIFICATIONS NEEDED TO EXECUTE
    '/--------------------------------------------------------------

    Private Sub OpenApplication(formname)
        If Muted = False Then Synth.SpeakAsyncCancelAll()
        Select Case formname

            Case "Admin"
                If Muted = False Then Synth.SpeakAsync("Wield your power wisely--O great one!")
                Hide()
                With Admin
                    .Show()
                End With

            Case "Power BI"
                Try
                    If Muted = False Then Synth.SpeakAsync("Taking you there,now!")
                    Dim webAddress As String = "https://powerbi.microsoft.com/en-us/"
                    Process.Start(webAddress)
                Catch
                    Dim a As New AgnesMsgBox(vbCr & "Cannot open the PowerBI website at this time.", 2, False, Me.Name)
                    a.ShowDialog()
                    a.Dispose()
                End Try

            Case "Policies and Procedures"
                If Muted = False Then Synth.SpeakAsync("Taking you there...now!")
                Try
                    Dim webAddress As String = "https://portal.sposites.com/sites/CGInternal/Shared%20Documents/Policies%20%26%20Procedures?e=5%3A7f0a658371794647809e9fbbabf6fb97"
                    Process.Start(webAddress)
                Catch
                    Dim a As New AgnesMsgBox(vbCr & "Cannot open Sharepoint site at this time.", 2, False, Me.Name)
                    a.ShowDialog()
                    a.Dispose()
                End Try

            Case "Cafe Weekly Flash"
                If Muted = False Then Synth.SpeakAsync("You got it!!")
                With WeeklyFlash
                    .FlashType = "Cafes"
                    .HasForecast = True
                    .UserName = UserName
                    .UserLevel = UserLevel
                    .UserGroupAccess = UserGroupAccess
                    .tsslInformation.Text = "Waiting for period and week selection"
                    .tsslPeriod.Visible = False
                    .tsslPeriodDays.Visible = False
                    .tsslSaveStatus.Visible = False
                    .tsslWeek.Visible = False
                    .tsslWeekDays.Visible = False
                End With
                '#  Check for access to multiple units; if present, invoke UnitChooser
                DataSets.FlashAdapt.Fill(DataSets.FlashTable)
                DataSets.FlashAccessAdapt.Fill(DataSets.FlashAccessTable)
                DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
                Dim AccessDR() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & UserID & "'")
                If AccessDR.Count = 0 And UserLevel = "User" Then
                    Dim a As New AgnesMsgBox(vbCr & "You do not appear to have any access to specific cafes.  Please contact your manager.", 2, False, Me.Name)
                    a.ShowDialog()
                    a.Dispose()
                    Exit Sub
                End If
                If AccessDR.Count > 1 Or (UserLevel = "SU" Or UserLevel = "Admin") Then
                    With FlashUnitChooser
                        .FlashType = "Cafes"
                        .ChooserType = 0
                        .ShowDialog()
                    End With
                Else
                    WeeklyFlash.UnitNumber = AccessDR(0)("UnitNumber")
                    Dim LocationDR() As DataRow = DataSets.FlashLocationTable.Select("Unit_Number = '" & WeeklyFlash.UnitNumber & "'")
                    WeeklyFlash.UnitName = LocationDR(0)("Unit")
                    WeeklyFlash.Text = "Weekly Flash - Unit " & WeeklyFlash.UnitNumber
                End If

                Hide()
                WeeklyFlash.Show()

            Case "Waste Tracking"
                If Muted = False Then Synth.SpeakAsync("I'll make haste, to waste!")
                '#  Check for access to multiple units; if present, invoke UnitChooser
                DataSets.FlashAdapt.Fill(DataSets.FlashTable)
                DataSets.FlashAccessAdapt.Fill(DataSets.FlashAccessTable)
                DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
                Dim AccessDR() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & UserID & "'")
                If AccessDR.Count = 0 And UserLevel = "User" Then
                    Dim a As New AgnesMsgBox(vbCr & "You do not appear to have any access to specific cafes.  Please contact your manager.", 2, False, Me.Name)
                    a.ShowDialog()
                    a.Dispose()
                    Exit Sub
                End If
                If AccessDR.Count > 1 Or (UserLevel = "SU" Or UserLevel = "Admin" Or UserLevel = "Group") Then
                    With FlashUnitChooser
                        .FlashType = "Cafes"
                        .ChooserType = 1
                        .ShowDialog()
                    End With
                Else
                    WasteTracking.unum = AccessDR(0)("UnitNumber")
                    Dim LocationDR() As DataRow = DataSets.FlashLocationTable.Select("Unit_Number = '" & WasteTracking.unum & "'")
                    WasteTracking.unitnm = LocationDR(0)("Unit")
                End If
                Hide()
                With WasteTracking
                    .username = UserName
                    .Show()
                End With

            Case "Cafe Forecast"
                If Muted = False Then Synth.SpeakAsync("You got it!!")
                Hide()
                With WeeklyForecast
                    .forecasttype = "Cafes"
                    .UserName = UserName
                    .UserLevel = UserLevel
                    .UserGroupAccess = UserGroupAccess
                    .tsslInformation.Text = "Waiting for period selection"
                    .tsslPeriod.Visible = False
                    .tsslPeriodDays.Visible = False
                    .tsslSaveStatus.Visible = False
                    .lblWeek5.Visible = False
                End With
                '#  Check for access to multiple units; if present, invoke UnitChooser
                DataSets.FlashAdapt.Fill(DataSets.FlashTable)
                DataSets.FlashAccessAdapt.Fill(DataSets.FlashAccessTable)
                DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
                Dim AccessDR() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & UserID & "'")
                If AccessDR.Count = 0 And UserLevel = "User" Then
                    Dim a As New AgnesMsgBox(vbCr & "You do not appear to have any access to specific cafes.  Please contact your manager.", 2, False, Me.Name)
                    a.ShowDialog()
                    a.Dispose()
                    Exit Sub
                End If
                If AccessDR.Count > 1 Or (UserLevel = "SU" Or UserLevel = "Admin" Or UserLevel = "Group") Then
                    With FlashUnitChooser
                        .FlashType = "Cafes"
                        .ChooserType = 2
                        .ShowDialog()
                    End With
                Else
                    WeeklyForecast.UnitNumber = AccessDR(0)("UnitNumber")
                    Dim LocationDR() As DataRow = DataSets.FlashLocationTable.Select("Unit_Number = '" & WeeklyFlash.UnitNumber & "'")
                End If

                Hide()
                WeeklyForecast.Show()

            Case "Cafe Event Journal"
                If Muted = False Then Synth.SpeakAsync("Dear diary...")
                '#  Check for access to multiple units; if present, invoke UnitChooser
                DataSets.FlashAdapt.Fill(DataSets.FlashTable)
                DataSets.FlashAccessAdapt.Fill(DataSets.FlashAccessTable)
                DataSets.FlashLocationAdapt.Fill(DataSets.FlashLocationTable)
                Dim AccessDR() As DataRow = DataSets.FlashAccessTable.Select("UserID = '" & UserID & "'")
                If AccessDR.Count = 0 And UserLevel = "User" Then
                    Dim a As New AgnesMsgBox(vbCr & "You do not appear to have any access to specific cafes.  Please contact your manager.", 2, False, Me.Name)
                    a.ShowDialog()
                    a.Dispose()
                    Exit Sub
                End If
                If AccessDR.Count > 1 Or (UserLevel = "SU" Or UserLevel = "Admin" Or UserLevel = "Group") Then
                    With FlashUnitChooser
                        .FlashType = "Cafes"
                        .ChooserType = 3
                        .ShowDialog()
                    End With
                Else
                    CafeJournal.UnitNum = AccessDR(0)("UnitNumber")
                End If
                Hide()
                CafeJournal.Show()

            Case "Weekly Flash Status"
                If Muted = False Then Synth.SpeakAsync("Let's take a look!!")
                Hide()
                FlashStatus.username = UserName
                FlashStatus.Show()

            Case "WCC Weekly Flash"
                If Muted = False Then Synth.SpeakAsync("You got it!!")
                Hide()
                With WeeklyFlash
                    .FlashType = "WCC"
                    .HasForecast = False
                    .UserName = UserName
                    .UserLevel = UserLevel
                    .UserGroupAccess = UserGroupAccess
                    .UnitName = "Commons"
                    .UnitNumber = 19837
                    .Text = "Weekly Flash - Unit " & WeeklyFlash.UnitNumber
                    .tsslUser.Text = "Current user: " & UserName
                    .tsslInformation.Text = "Waiting for period and week selection"
                    .tsslPeriod.Visible = False
                    .tsslPeriodDays.Visible = False
                    .tsslSaveStatus.Visible = False
                    .tsslWeek.Visible = False
                    .tsslWeekDays.Visible = False
                    .Show()
                End With

            Case "WCC Forecast"
                'If Muted = False Then Synth.SpeakAsync("Okay!")
                'Hide()
                'With DiningForecast
                '    .UserName = UserName
                '    .UserLevel = UserLevel
                '    .UnitNumber = 19837
                '    .Text = "Commons Forecasting"
                '    .Show()
                'End With

            Case "WCR"
                Dim a As New AgnesMsgBox(vbCr & "Under construction. Please use my previous version!", 2, False, Me.Name)
                a.ShowDialog()
                a.Dispose()

                'If Muted = False Then Synth.SpeakAsync("Done and done!")
                'Hide()
                'WCR.Show()

            Case "Vendor Receipts"
                If Muted = False Then Synth.SpeakAsync("I'm ready if YU are!")
                Hide()
                With VendorReceipts
                    .UserName = UserName
                    .FiscalYear = FiscalYear
                    .Show()
                End With

            Case "AV Flash"
                If Muted = False Then Synth.SpeakAsync("You got it!!")
                Hide()
                With AVFlash
                    .UserName = UserName
                    .Show()
                End With

            Case "Beverage Flash"
                If Muted = False Then Synth.SpeakAsync("You got it!!")
                Hide()
                With BVFlash
                    .UserName = UserName
                    .Show()
                End With

            Case "Menu Item Cost Manager"
                If Muted = False Then Synth.SpeakAsync("This is going to make me hungry!!")
                Hide()
                With MenuEngineeringCosts
                    '.UserName = UserName
                    .Show()
                End With

            Case "Catering Labor"
                '   If Muted = False Then Synth.SpeakAsync("That works for ME!!")
                '    Hide()
                '    With CaterLabor
                '        .UserName = UserName
                '        .Show()
                '    End With

            Case "Catering Late Orders"
                '   If Muted = False Then Synth.SpeakAsync("Sounds good!!")
                '    Hide()
                '    With CateringLateOrders
                '        .UserName = UserName
                '        .Show()
                '    End With

            Case "HR Unit Audit"
                If Muted = False Then Synth.SpeakAsync("Let's audit!!")
                Hide()
                With HRAudit
                    .username = UserName
                    .Show()
                End With

            Case "IncidentReporting"
                If Muted = False Then Synth.SpeakAsync("I hope nobody was hurt!!")
                Hide()
                AccidentReporting.Show()

            Case "Campaign Mgmt"
                Hide()
                ChoosePromo.Show()

        End Select

    End Sub

#End Region

#Region "Tips, Announcements, and media"

    Private Sub getannouncements()
        Try
            DataSets.AnnounceAdapt.Fill(DataSets.AnnounceTable)
        Catch ex As Exception
            lblAnnouncements.Text = ""
            pbxGIFAnnouncement.Image = Nothing
            pbxGIFAnnouncement.Visible = False
        End Try
        lblAnnouncements.BackColor = Color.LemonChiffon
        Dim announcecount As Byte, announcements As String = "No announcements today", announceDR() As DataRow = DataSets.AnnounceTable.Select("AnnouncementDate <='" & Now().ToShortDateString & "' and Void = False")
        If announceDR.Count > 0 Then
            lblAnnouncements.BackColor = Color.Aqua
            announcements = ""
            For announcecount = 1 To announceDR.Count
                announcements = announcements & announceDR(announcecount - 1)("Text") & vbCr
                If announceDR(announcecount - 1)("Image") = True Then
                    Dim fileloc As String = announceDR(announcecount - 1)("ImageLocation")
                    Dim tClient As System.Net.WebClient = New System.Net.WebClient
                    Dim tImage As Bitmap = Bitmap.FromStream(New System.IO.MemoryStream(tClient.DownloadData(fileloc)))
                    With pbxGIFAnnouncement
                        .Image = tImage
                        .SizeMode = PictureBoxSizeMode.Zoom
                        .Visible = True
                    End With
                End If
            Next
            lblAnnouncements.Text = announcements
        End If
    End Sub

    Private Sub gettipoftheday()
        Randomize()
        Dim tipDR() As DataRow = Nothing
        Try
            DataSets.TipAdapt.Fill(DataSets.TipTable)
        Catch ex As Exception
            lblTips.Text = ""
            Exit Sub
        End Try
        Dim numberofavailabletips As Byte = 0, randomtipnum As Integer
        Select Case UserLevel
            Case "User"
                tipDR = DataSets.TipTable.Select("UserLevel='User'")
            Case "Group"
                tipDR = DataSets.TipTable.Select("UserLevel='User' or UserLevel = 'Group'")
            Case "SU"
                tipDR = DataSets.TipTable.Select("UserLevel='User' or UserLevel = 'SU'")
            Case "Admin"
                tipDR = DataSets.TipTable.Select
        End Select
        Try
            numberofavailabletips = tipDR.Count
        Catch ex As Exception
            lblTips.Text = ""
            Exit Sub
        End Try
        randomtipnum = (CInt(Math.Floor((numberofavailabletips - 1 + 1) * Rnd())))
        lblTips.Text = tipDR(randomtipnum)("Tip")
    End Sub

    Private Sub ToggleBigMedia(sender As Object, e As _WMPOCXEvents_ClickEvent) Handles mpWindow.ClickEvent
        With mpWindow
            .settings.mute = True
            .Ctlcontrols.pause()
        End With
        With BigMedia
            .mpBigPlayer.URL = mpWindow.URL
            .mpBigPlayer.uiMode = "mini"
            .Show()
        End With
    End Sub

#End Region

End Class
