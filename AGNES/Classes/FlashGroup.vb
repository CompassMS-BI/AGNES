Public Class FlashGroup
    Inherits GroupBox
    Public Property GroupName As String                 '#  Use to identify group - Sales, COGS, etc.       
    Public Property DataName As String                  '#  Use to fetch forecast data.  This is a duct-tape solution and should eventually be replaced through a complete overhaul of this class to align with the more efficient ForecastGroup class model
    Public Property FlashIsStatic As Boolean            '#  Use to determine whether to create flash field as a static textbox, or a flashuservalue object.  Also excludes notes if TRUE
    Public Property IsRevenueBlock As Boolean           '#  Use to determine if percentage fields are present and other revenue-related actions
    Public Property ExcludeFromSubsidy As Boolean       '#  Use to flag whether the values present should be excluded from the calculation of subsidy (sales totals, for instance)
    Public Property SubTotalRef As String = ""          '#  Use to indicate if the totals should be included in a subtotal FlashGroup, by name of that FlashGroup (sales totals, for instance)
    Public Property IncludeForecast As Boolean          '#  Use to toggle Forecast fields (static field, variance, and percentage field) based on Flash type
    Public Property IsSubtotal As Boolean               '#  Use to indicate if this is a subtotal block - will be handled in Recalcuate method
    Public Property ChangeVal As String                 '#  Use to store current value when field is entered; during Recalculate(), this compared to value when field is left and ChangesMade flag triggered as needed 
    Public Property ExcludePercentofSales As Boolean    '#  Use to toggle percent of sales fields
    Public Property AllowAllValues As Boolean           '#  Allows full override of neg/pos value restrictions when TRUE
    Public Property CalledFromPTD As Boolean            '#  Toggle to override storedvalue overwrite in PTD view when user has not entered all flash values
    Public Property VarianceCallOut As Boolean          '#  Sets subsidy variance to show green/red font for pos/neg values
    Private fv As Double
    Public Property FlashValue As Double                '# Storage of user-visible flash value of this group (either current week or PTD)
        Get
            Return fv
        End Get
        Set(value As Double)
            fv = value
            If Name <> "SUBSIDY" Then
                Select Case Parent.Name
                    Case "WeeklyFlash"
                        WeeklyFlash.ActiveWeek.RefreshView()
                    Case "AVFlash"
                        With AVFlash
                            .CalcFlashTotal()
                            .RecalcFields()
                        End With
                End Select
            End If
        End Set
    End Property

    Private sfv As Double
    Public Property StoredFlashValue As Double          '# Temporary storage of current flash value - intended for use when returning from a PTD view
        Get
            Return sfv
        End Get
        Set(value As Double)
            sfv = value
        End Set
    End Property

    Private bv As Double
    Public Property BudgetValue As Double               '# Storage of user-visible budget value of this group (either current week or PTD)
        Get
            Return bv
        End Get
        Set(value As Double)
            bv = value
            If Name <> "SUBSIDY" Then WeeklyFlash.ActiveWeek.RefreshView()
        End Set
    End Property

    Private sbv As Double
    Public Property StoredBudgetValue As Double         '# Temporary storage of current budget value - intended for use when returning from a PTD view
        Get
            Return sbv
        End Get
        Set(value As Double)
            sbv = value
        End Set
    End Property

    Private fb As Double
    Public Property FullBudget As Double                '# Temporary storage of full period's budget; weekly and PTD calculations are calculated from this
        Get
            Return fb
        End Get
        Set(value As Double)
            fb = value
        End Set
    End Property

    Private fcv As Double
    Public Property ForecastValue As Double             '#TEST  Use to store user-visible forecast value of this group (either current week or PTD)
        Get
            Return fcv
        End Get
        Set(value As Double)
            fcv = value
            If Name <> "SUBSIDY" Then WeeklyFlash.ActiveWeek.RefreshView()
        End Set
    End Property

    Private sfcv As Double
    Public Property StoredForecastValue As Double       '#TEST  Use for temporary storage of current forecast value - intended for use when returning from a PTD view
        Get
            Return sfcv
        End Get
        Set(value As Double)
            sfcv = value
        End Set
    End Property

    Private nv As String
    Public Property NoteValue As String                '# Storage of current note string
        Get
            Return nv
        End Get
        Set(value As String)
            nv = value
            Controls("Notes").Text = nv
        End Set
    End Property

    Private snv As String
    Public Property StoredNoteValue As String           '# Temporary storage of current note value
        Get
            Return snv
        End Get
        Set(value As String)
            snv = value
        End Set
    End Property

    Private Sub InitializeFlashGroup(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Dim EditableFlashTxt As New FlashUserValue
        Dim StaticFlashText As New CurrencyBox
        Dim FlashPerc As New TextBox With {.Enabled = False, .Left = 117, .Top = 17, .Height = 22, .Width = 76, .Name = "FlashPercentageField", .Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular), .TextAlign = HorizontalAlignment.Center}
        Dim BudgetTxt As New CurrencyBox With {.Enabled = False, .Left = 197, .Top = 17, .Height = 22, .Width = 100, .Name = "BudgetField"}
        Dim BudgetPerc As New TextBox With {.Enabled = False, .Left = 303, .Top = 17, .Height = 22, .Width = 76, .Name = "BudgetPercentageField", .Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular), .TextAlign = HorizontalAlignment.Center}
        Dim FlashVarTxt As New CurrencyBox With {.Enabled = False, .Left = 385, .Top = 17, .Height = 22, .Width = 100, .Name = "FlashVarianceField"}
        Dim ForecastTxt As New CurrencyBox With {.Enabled = False, .Top = 17, .Left = 565, .Height = 22, .Width = 100, .Name = "ForecastField"}
        Dim ForecastPerc As New TextBox With {.Enabled = False, .Top = 17, .Left = 671, .Height = 22, .Width = 76, .Name = "ForecastPercentageField", .Font = New Drawing.Font("Segoe UI Emoji", 12, FontStyle.Regular), .TextAlign = HorizontalAlignment.Center}
        Dim ForecastVarTxt As New CurrencyBox With {.Enabled = False, .Top = 17, .Left = 753, .Height = 22, .Width = 100, .Name = "ForecastVarianceField"}
        Dim notetxt As New FlashNotes With {.Visible = True, .Top = 54, .Left = 7, .Width = 850, .Name = "Notes"}

        '/  Add either user-editable or static flash value field
        Select Case FlashIsStatic
            Case True
                With StaticFlashText
                    .Top = 17
                    .Left = 6
                    .Height = 29
                    .Width = 108
                    .Enabled = False
                    .Debit = Not IsRevenueBlock
                    .AllowCredit = IsRevenueBlock
                    .OpenValue = AllowAllValues
                    .Name = "FlashField"
                End With
                Controls.Add(StaticFlashText)
            Case False
                With EditableFlashTxt
                    .Top = 17
                    .Left = 6
                    .Height = 29
                    .Width = 108
                    .Enabled = True
                    .Debit = Not IsRevenueBlock
                    .AllowCredit = IsRevenueBlock
                    .OpenValue = AllowAllValues
                    .Name = "FlashField"
                End With
                Controls.Add(EditableFlashTxt)
                AddHandler EditableFlashTxt.Enter, AddressOf StoreCurrentVal
                AddHandler EditableFlashTxt.Leave, AddressOf Recalcuate
        End Select

        '/  Add budget field
        Controls.Add(BudgetTxt)

        '/  Add flash to budget variance field and if toggled, trigger formatting to show red for positive, green for negative (tailored to subsidy variances)
        Controls.Add(FlashVarTxt)
        If VarianceCallOut = True Then FlashVarTxt.PosNegFont = True

        '/  Add forecast and forecast variance fields, if applicable for this object
        Select Case IncludeForecast
            Case True
                Controls.Add(ForecastTxt)
                Controls.Add(ForecastVarTxt)
            Case Else
        End Select

        '/  Add percentage fields, if object is not for revenue and toggle is set to true
        Select Case IsRevenueBlock
            Case False
                If ExcludePercentofSales = False Then
                    If IncludeForecast = True Then Controls.Add(ForecastPerc)
                    Controls.Add(FlashPerc)
                    Controls.Add(BudgetPerc)
                End If
            Case Else
        End Select

        '/  Add note field, if object is not a static display field
        If FlashIsStatic = False Then
            Controls.Add(notetxt)
            AddHandler notetxt.Enter, AddressOf StoreNoteVal
            AddHandler notetxt.Leave, AddressOf TriggerChangeFlagFromNotes
        End If

    End Sub

    Private Sub StoreCurrentVal()
        If CalledFromPTD = False Then StoredFlashValue = Controls("FlashField").Text
    End Sub

    Private Sub StoreNoteVal()
        ChangeVal = Controls("Notes").Text
    End Sub

    Private Sub Recalcuate()
        If Controls("FlashField").Text <> StoredFlashValue Then
            Select Case Parent.Name
                Case "AVFlash"
                    If AVFlash.systemchange = False Then
                        With AVFlash
                            .ChangesMade = True
                            .SaveChanges = False
                        End With
                    End If
                Case "BVFlash"
                    If BVFlash.systemchange = False Then
                        With BVFlash
                            .ChangesMade = True
                            .SaveChanges = False
                            .CalcFlashTotal()
                            .RecalcFields()
                        End With
                    End If
                Case Else
                    WeeklyFlash.FlagChanges(1)
            End Select
            FlashValue = FormatNumber(Controls("FlashField").Text, 2)
        End If
    End Sub

    Private Sub TriggerChangeFlagFromNotes()
        If (Controls("Notes").Text <> ChangeVal) And Controls("Notes").Text <> "Add notes here" Then WeeklyFlash.FlagChanges(1)
    End Sub

    Public Sub Clear(t)
        If t = 0 Or 1 Then
            Me.Controls("FlashField").Text = "$0.00"
            Me.Controls("Notes").Text = ""
        End If

        If t = 0 Or 2 Then
            Me.Controls("BudgetField").Text = "$0.00"
            Me.Controls("Notes").Text = ""
        End If
    End Sub

End Class
