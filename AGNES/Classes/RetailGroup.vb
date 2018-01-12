Public Class RetailGroup
    Inherits Panel
    Friend Property DisplayName As String
    Friend Property GroupType As String
    Friend Property SelectedDate As Date
    Friend Property Extant As Boolean
    Friend ChangesMade As Boolean
    Private Property OldSalesValue As Double
    Private Property OldCountValue As Integer

    Private Sub InitializeRetailGroup(sender As Object, e As EventArgs) Handles Me.HandleCreated
        '#  Define group object properties
        Height = 35 : Width = 600 : Left = 12

        '#  Scope group object members and their base properties
        Dim VendorTxt As New AgnesTxt With {.Text = DisplayName, .Left = 3, .Top = 5, .Height = 25, .Width = 339, .Name = "txtVendor", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Left, .Enabled = False}
        Dim SalesTxt As New CurrencyBox With {.Text = "$0.00", .Left = 348, .Top = 5, .Height = 25, .Width = 134, .Name = "txtSales", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Enabled = True, .TabIndex = 1}
        Dim CountTxt As New AgnesTxt With {.Text = "0", .Left = 488, .Top = 5, .Height = 25, .Width = 80, .Name = "txtCounts", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .TextAlign = HorizontalAlignment.Right, .Enabled = True, .TabIndex = 2}

        With Controls
            .Add(VendorTxt)
            .Add(SalesTxt)
            .Add(CountTxt)
        End With
        AddHandler SalesTxt.Enter, AddressOf SaveOldSalesValue
        AddHandler SalesTxt.Leave, AddressOf CompareSalesValues
        AddHandler SalesTxt.GotFocus, AddressOf DisplayInfo
        AddHandler CountTxt.Enter, AddressOf selecteverything
        AddHandler CountTxt.Click, AddressOf selecteverything
        AddHandler CountTxt.Leave, AddressOf validatefield

        Select Case GroupType
            Case "Truck"
                VendorTxt.Width = 200
                CountTxt.Enabled = False
                SalesTxt.Enabled = False
                Dim LocationCombo As New ComboBox With {.Left = 205, .Top = 5, .Height = 25, .Width = 110, .Name = "cbxLocation", .Font = New Drawing.Font("Segoe UI Emoji", 10, FontStyle.Regular), .Enabled = True, .TabIndex = 0, .AutoCompleteMode = AutoCompleteMode.Suggest}

                '###    ADD ROUTINE TO TIE TO RACHEL'S SCHEDULE AND ONLY DISPLAY LOCATIONS SCHEDULED FOR THE SELECTED DAY AND TRUCK

                LocationCombo.Items.Add("110/Studio X")
                LocationCombo.Items.Add("Willows")
                LocationCombo.Items.Add("Cafe 92")
                LocationCombo.Items.Add("Redwest")
                LocationCombo.Items.Add("Building 36")

                Controls.Add(LocationCombo)
                AddHandler LocationCombo.GotFocus, AddressOf DisplayInfo
                AddHandler LocationCombo.Leave, AddressOf LocationSelected
                AddHandler LocationCombo.SelectedIndexChanged, AddressOf LocationSelected
            Case "Retail"
                FetchSavedData()
        End Select

    End Sub

    Private Sub SaveOldSalesValue(sender As Object, e As EventArgs)
        Dim s As CurrencyBox = sender
        OldSalesValue = FormatNumber(s.Text, 2)
    End Sub

    Private Sub CompareSalesValues(sender As Object, e As EventArgs)
        Dim s As CurrencyBox = sender
        Dim newvalue = FormatNumber(s.Text, 2)
        If newvalue <> OldSalesValue Then
            ChangesMade = True
            VendorReceipts.ChangesMade = True
            VendorReceipts.SaveChanges = False
        End If
    End Sub

    Private Sub DisplayInfo()
        VendorReceipts.VendorInfo(DisplayName)
    End Sub

    Private Sub selecteverything(sender As Object, e As EventArgs)
        Dim s As TextBox = sender
        s.SelectionLength = s.Text.Length
        s.SelectAll()
        VendorReceipts.VendorInfo(DisplayName)
        OldCountValue = FormatNumber(s.Text, 2)
    End Sub

    Private Sub validatefield(sender As Object, e As EventArgs)
        Dim testsingle As Single
        Dim s As TextBox = sender
        testsingle = FormatNumber(s.Text, 2)
        If testsingle < 0 Then
            s.Text = 0
            MsgBox("Negative values are not allowed in this field!", vbCritical, "Invalid entry")
        End If
        s.Text = FormatNumber(s.Text, 0)
        Dim newvalue = FormatNumber(s.Text, 2)
        If newvalue <> OldCountValue Then
            ChangesMade = True
            VendorReceipts.ChangesMade = True
            VendorReceipts.SaveChanges = False
        End If
    End Sub

    Private Sub LocationSelected(sender As Object, e As EventArgs)
        Dim s As ComboBox = sender
        If s.Text = "" Then
            Controls("txtSales").Text = FormatCurrency(0, 0)
            Controls("txtCounts").Text = "0"
            Exit Sub
        End If
        If s.Text <> "" And s.SelectedIndex = -1 Then
            Dim amsg As New AgnesMsgBox("Did you want to add " & s.Text & " as a new location?", 2, True, "RetailGroup")
            amsg.ShowDialog()
            Dim ynchoice As Boolean = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
            Controls("txtSales").Enabled = True
            Controls("txtCounts").Enabled = True

            '#  ROUTINE TO INVOKE LOCATION EDITOR FOR TRUCKS

        Else
            FetchSavedData()
        End If
    End Sub

    Private Sub FetchSavedData()
        DataSets.VendorTransAdapt.Fill(DataSets.VendorTransTable)
        Select Case GroupType
            Case "Retail"
                Dim dr() As DataRow = DataSets.VendorTransTable.Select("Date = '" & SelectedDate & "' and Vendor  = '" & DisplayName & "'")
            If dr.Count = 0 Then
                    Controls("txtSales").Text = FormatCurrency(0, 0)
                    Controls("txtCounts").Text = "0"
                    Controls("txtSales").Enabled = True
                    Controls("txtCounts").Enabled = True
                    Extant = False
                Else
                    Controls("txtSales").Text = FormatCurrency(dr(0)("Sales"), 0)
                    Controls("txtCounts").Text = FormatNumber(dr(0)("Counts"), 0)
                    Controls("txtSales").Enabled = False
                    Controls("txtCounts").Enabled = False
                    Extant = True
                End If
            Case "Truck"
                Dim dr() As DataRow = DataSets.VendorTransTable.Select("Date = '" & SelectedDate & "' and Vendor  = '" & DisplayName & "' and Location = '" & Controls("cbxLocation").Text & "'")
                If dr.Count = 0 Then
                    Controls("txtSales").Text = FormatCurrency(0, 0)
                    Controls("txtCounts").Text = "0"
                    Controls("txtSales").Enabled = True
                    Controls("txtCounts").Enabled = True
                    Extant = False
                Else
                    Controls("txtSales").Text = FormatCurrency(dr(0)("Sales"), 0)
                    Controls("txtCounts").Text = FormatNumber(dr(0)("Counts"), 0)
                    Controls("txtSales").Enabled = False
                    Controls("txtCounts").Enabled = False
                    Extant = True
                End If
        End Select

    End Sub

End Class