Imports Microsoft.Office.Interop
Public Class CustomersSalesReport

    Private Sub CostumertblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CostumertblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CostumerDataset)

    End Sub

    Private Sub CustomersSalesReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CostumerDataset.Costumertbl' table. You can move, or remove it, as needed.
        Me.CostumertblTableAdapter.Fill(Me.CostumerDataset.Costumertbl)
        from.Value = Now.Date
        tod.Value = Now.Date
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\SalesReportCust.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, dates)
        'Me.SalesTableAdapter.FillBySrpt(TransactionsDataset.Sales, New System.Nullable(Of Date)(CType(from.Value, Date)), New System.Nullable(Of Date)(CType(tod.Value, Date)))

        Me.SalesTA.FillByCustomer(Me.TransactionsDS.Sales, fd, td, NameComboBox.Text)

        Dim rc(Me.TransactionsDS.Sales.DefaultView.Count, 9)
        wsheet.Range("A1").Value = "Customer Name : " + NameComboBox.Text
        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString 

        For x As Integer = 0 To Me.TransactionsDS.Sales.DefaultView.Count - 1
            With Me.TransactionsDS.Sales.DefaultView.Item(x)


                rc(x, 0) = .Item("TransNo")
                rc(x, 1) = .Item("SalesDT")
                rc(x, 2) = .Item("ItemNo")
                rc(x, 3) = .Item("IDesc")
                rc(x, 4) = .Item("UnitSold")
                rc(x, 5) = .Item("SRP")
                rc(x, 6) = .Item("SRPTotal")

            End With
        Next

        Dim lastrow As Long
        lastrow = Me.TransactionsDS.Sales.DefaultView.Count + 8
        Dim subt As Long
        subt = Me.TransactionsDS.Sales.DefaultView.Count + 8

        wsheet.Range("A8", "I" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString, "G" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString, "G" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"


        wsheet.Range("G" + (Me.TransactionsDS.Sales.DefaultView.Count + 9).ToString).Formula = "=Sum(G8:G" & lastrow & ")"


        xapp.Visible = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\SalesReportTranno.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, dates)
        'Me.SalesTableAdapter.FillBySrpt(TransactionsDataset.Sales, New System.Nullable(Of Date)(CType(from.Value, Date)), New System.Nullable(Of Date)(CType(tod.Value, Date)))

        Me.SalesTA.FillByTranNo(Me.TransactionsDS.Sales, Me.TextBox1.Text)

        Dim rc(Me.TransactionsDS.Sales.DefaultView.Count, 9)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = Now.ToShortDateString

        For x As Integer = 0 To Me.TransactionsDS.Sales.DefaultView.Count - 1
            With Me.TransactionsDS.Sales.DefaultView.Item(x)


                rc(x, 0) = .Item("TransNo")
                rc(x, 1) = .Item("SalesDT")
                rc(x, 2) = .Item("ItemNo")
                rc(x, 3) = .Item("IDesc")
                rc(x, 4) = .Item("UnitSold")
                rc(x, 5) = .Item("SRP")
                rc(x, 6) = .Item("SRPTotal")

            End With
        Next

        Dim lastrow As Long
        lastrow = Me.TransactionsDS.Sales.DefaultView.Count + 8
        Dim subt As Long
        subt = Me.TransactionsDS.Sales.DefaultView.Count + 8

        wsheet.Range("A8", "I" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString, "G" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString, "G" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"


        wsheet.Range("G" + (Me.TransactionsDS.Sales.DefaultView.Count + 9).ToString).Formula = "=Sum(G8:G" & lastrow & ")"


        xapp.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(Me.TextBox1.Text) Then
            MsgBox("Enter Only Numeric", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            Me.TextBox1.Focus()
            Me.Button3.Enabled = False
        Else
            Me.Button3.Enabled = True
        End If

    End Sub
End Class