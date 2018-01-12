Public Class WCR
    Private SystemChange As Boolean
    Private ynchoice As Boolean
    Private changesmade As Boolean = False
    Private saved As Boolean = True
    Private activepanel As Byte
    Friend Property CurrentPanel As Byte
        Get
            Return activepanel
        End Get
        Set(value As Byte)
            activepanel = value
            DisplayPanel()
        End Set
    End Property

    Private fy As Long
    Friend Property FiscalYear As Long
        Get
            Return fy
        End Get
        Set(value As Long)
            fy = value
        End Set
    End Property
    Private msp As Byte
    Friend Property Period As Byte
        Get
            Return msp
        End Get
        Set(value As Byte)
            msp = value
        End Set
    End Property
    Private wk As Byte
    Friend Property week As Byte
        Get
            Return wk
        End Get
        Set(value As Byte)
            wk = value
        End Set
    End Property

#Region "Initialize WCR"

    Private Sub LoadWCR(sender As Object, e As EventArgs) Handles Me.Load
        tsslUser.Text = Portal.UserName
        DataSets.VendorAdapt.Fill(DataSets.VendorTable)
        DataSets.TenderAdapt.Fill(DataSets.TenderTable)
        PaintTenderPanel()
        CurrentPanel = 0    '#  Default to tenders page

    End Sub

#End Region

#Region "Toolstrip Controls"

    Private Sub ExitModule(sender As Object, e As EventArgs) Handles tsmiExit.Click
        If changesmade = True And saved = False Then
            Dim amsg As New AgnesMsgBox("You have unsaved data.  Do you still wish to exit?", 2, True, "wcr")
            amsg.ShowDialog()
            ynchoice = amsg.Choicemade
            amsg.Dispose()
            If ynchoice = False Then Exit Sub
        End If
        Dispose()
        Portal.Show()
    End Sub

    Private Sub PasteClipboardContents(sender As Object, e As EventArgs) Handles tsmiPasteTenders.Click
        Dim contents As String = Clipboard.GetText(), pastecells() As String, pasterows() As String = Split(contents, vbCrLf), pasterow As Integer
        Dim colind As Byte = dgvTenders.CurrentCell.ColumnIndex
        Dim coltotal As Double = 0
        For ct = 0 To pasterows.Count - 2
            pastecells = Split(pasterows(ct), vbTab)
            pasterow = GetTenderRow(pastecells(0))
            dgvTenders.Rows(pasterow).Cells(colind).Value = FormatCurrency(pastecells(1), 2)
            coltotal = coltotal + FormatNumber(pastecells(1), 2)
        Next
        dgvTenders.Rows(0).Cells(colind).Value = FormatCurrency(coltotal, 2)
        CalTenderTotals()
    End Sub

    Private Sub MoveToPreviousPanel(sender As Object, e As EventArgs) Handles tsmiPrevious.Click
        CurrentPanel -= 1
    End Sub

    Private Sub MoveToNextPanel(sender As Object, e As EventArgs) Handles tsmiNext.Click
        CurrentPanel += 1
    End Sub

#End Region

#Region "Functions"

    Private Sub DisplayPanel()
        Select Case activepanel
            Case 0  '#  Tender panel
                tsmiPrevious.Visible = False
                tsmiNext.Visible = True
                tsmiPasteTenders.Visible = True
                panTenders.Visible = False
                With panTenders
                    .Visible = True
                    .BringToFront()
                    .Dock = DockStyle.Fill
                End With

            Case 1  '#  CAM check panel
                tsmiPrevious.Visible = True
                tsmiNext.Visible = True
                tsmiPasteTenders.Visible = False
                panTenders.Visible = False

            Case 2  '#  Recon panel
            Case 3  '#  Review panel
        End Select
    End Sub

    Private Sub PaintTenderPanel()
        'UserCall = False
        Dim VendorCount As Byte, TenderCount As Byte, ct As Byte, rowct As Byte, panelwidth As Integer = 220
        Dim TenderColumn As New DataGridViewTextBoxColumn With
                {
                    .Name = DataSets.VendorTable.Rows(ct).Item("VendorName"),
                    .HeaderText = "Tender Type",
                    .SortMode = DataGridViewColumnSortMode.NotSortable,
                    .Resizable = False,
                    .Frozen = True,
                    .ReadOnly = True,
                    .Width = 120
                }
        dgvTenders.Columns.Add(TenderColumn)
        Dim TotalsColumn As New DataGridViewTextBoxColumn With
                {
                    .Name = DataSets.VendorTable.Rows(ct).Item("VendorName"),
                    .HeaderText = "Total",
                    .SortMode = DataGridViewColumnSortMode.NotSortable,
                    .Resizable = False,
                    .Frozen = True,
                    .ReadOnly = True,
                    .Width = 100
                }
        dgvTenders.Columns.Add(TotalsColumn)
        For ct = 0 To DataSets.VendorTable.Rows.Count - 1
            If DataSets.VendorTable.Rows(ct).Item("VendorType") = "Food" And DataSets.VendorTable.Rows(ct).Item("Status") = True Then
                VendorCount = VendorCount + 1
                Dim NewColumn As New DataGridViewTextBoxColumn With
                {
                    .Name = DataSets.VendorTable.Rows(ct).Item("VendorName"),
                    .HeaderText = DataSets.VendorTable.Rows(ct).Item("VendorName"),
                    .SortMode = DataGridViewColumnSortMode.NotSortable,
                    .Resizable = True,
                    .Frozen = False,
                    .ReadOnly = False,
                    .Width = 80
                }
                NewColumn.DefaultCellStyle.Format = "c"
                dgvTenders.Columns.Add(NewColumn)
                tsmiPasteTenders.Visible = True
                panelwidth = panelwidth + 80
            End If
        Next


        Dim totalstartstring(VendorCount + 1) As String
        For ct = 0 To VendorCount : totalstartstring(ct + 1) = "$0.00" : Next
        totalstartstring(0) = "Totals"
        dgvTenders.Rows.Add(totalstartstring)
        TenderCount = DataSets.TenderTable.Rows.Count
        For rowct = 0 To TenderCount - 1
            totalstartstring(0) = DataSets.TenderTable(rowct)("TenderType")
            dgvTenders.Rows.Add(totalstartstring)
            'PasteTenders.dgvTenderPaste.Rows.Add()
        Next

        '/*     Lock and bold totals row
        Dim BoldRow As New DataGridViewCellStyle With {.Font = New System.Drawing.Font("Segoe UI", 8.0!, FontStyle.Bold)}
        With dgvTenders.Rows(0)
            .DefaultCellStyle = BoldRow
            .ReadOnly = True
        End With


        With dgvTenders
            .CurrentCell = dgvTenders(2, 1)
            .Focus()
        End With

        'UserCall = True
    End Sub

    Private Sub CalTenderTotals()
        Dim ct1 As Integer, rowtotal As Double, fulltotal As Double, colct As Byte = dgvTenders.DisplayedColumnCount(False)
        fulltotal = 0
        For ct1 = 1 To dgvTenders.Rows.Count - 2
            rowtotal = 0
            For ct = 2 To colct - 3
                rowtotal = rowtotal + FormatNumber(dgvTenders.Rows(ct1).Cells(ct).Value, 2)
            Next
            dgvTenders.Rows(ct1).Cells(1).Value = FormatCurrency(rowtotal, 2)
            fulltotal = fulltotal + rowtotal
        Next
        dgvTenders.Rows(0).Cells(1).Value = FormatCurrency(fulltotal, 2)
    End Sub

    Private Function GetTenderRow(r) As Integer
        Dim ct1 As Integer, tendername As String
        Dim dr() As DataRow = DataSets.TenderTable.Select("TenderID = '" & r & "'")
        tendername = dr(0)(1)
        For ct1 = 1 To dgvTenders.Rows.Count - 1
            If dgvTenders.Rows(ct1).Cells(0).Value = tendername Then
                Return ct1
                Exit Function
            End If
        Next
        Return -1
    End Function

#End Region

End Class