Imports Microsoft.Office.Interop
Public Class AdminSalesrpt
    Private Sub fixtransno()
        Dim start As Integer
        If Me.TransactionsDataset.Trans.Rows.Count = 0 Or Me.TransactionsDataset.Trans.Rows.Count = 1 Then
        Else
            start = Me.TransactionsDataset.Trans.Rows(0).Item("TransNo")
            Dim xx As Integer
            For xx = 1 To Me.TransactionsDataset.Trans.Rows.Count - 1
                start = start - 1
                Me.TransactionsDataset.Trans.Rows(xx).Item("TransNo") = start
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'On Error Resume Next
        Me.TransactionsDataset.EnforceConstraints = False
        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\SalesReport.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, dates)
        'Me.SalesTableAdapter.FillBySrpt(TransactionsDataset.Sales, New System.Nullable(Of Date)(CType(from.Value, Date)), New System.Nullable(Of Date)(CType(tod.Value, Date)))

        Me.SalesTableAdapter.FillBySrpt(Me.TransactionsDataset.Sales, fd, td)


        Dim rc(Me.TransactionsDataset.Sales.DefaultView.Count, 9)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString

        For x As Integer = 0 To Me.TransactionsDataset.Sales.DefaultView.Count - 1
            With Me.TransactionsDataset.Sales.DefaultView.Item(x)


                rc(x, 0) = .Item("TransNo")
                rc(x, 1) = .Item("SalesDT")
                rc(x, 2) = .Item("CustName")
                rc(x, 3) = .Item("IDesc")
                rc(x, 4) = .Item("UnitSold")
                rc(x, 5) = .Item("SRP")
                rc(x, 6) = .Item("SRPTotal")
                rc(x, 7) = .Item("Cost")
                rc(x, 8) = .Item("CostTotal")



            End With
        Next

        Dim lastrow As Long
        lastrow = Me.TransactionsDataset.Sales.DefaultView.Count + 8
        Dim subt As Long
        subt = Me.TransactionsDataset.Sales.DefaultView.Count + 8

        wsheet.Range("A8", "I" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString, "I" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString, "I" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"


        wsheet.Range("G" + (Me.TransactionsDataset.Sales.DefaultView.Count + 9).ToString).Formula = "=SUBTOTAL(9,G8:G" & lastrow & ")"
        wsheet.Range("I" + (Me.TransactionsDataset.Sales.DefaultView.Count + 9).ToString).Formula = "=SUBTOTAL(9,I8:I" & lastrow & ")"

        xapp.Visible = True


    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub AdminSalesrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        from.Value = Now.Date
        tod.Value = Now.Date
    End Sub
End Class