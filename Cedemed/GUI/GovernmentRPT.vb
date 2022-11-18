Imports Microsoft.Office.Interop
Imports System.IO
Public Class GovernmentRPT

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If File.Exists(Application.StartupPath + "\SalesReportGOVT.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\SalesReportGOVT.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If
        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\SalesReportGOVT.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, dates)
        'Me.SalesTableAdapter.FillBySrpt(TransactionsDataset.Sales, New System.Nullable(Of Date)(CType(from.Value, Date)), New System.Nullable(Of Date)(CType(tod.Value, Date)))
        Me.TransactionsDataset.EnforceConstraints = False
        Me.SalesTableAdapter.FillByGov(Me.TransactionsDataset.Sales, fd, td)

        Dim rc(Me.TransactionsDataset.Sales.DefaultView.Count, 9)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString

        For x As Integer = 0 To Me.TransactionsDataset.Sales.DefaultView.Count - 1
            With Me.TransactionsDataset.Sales.DefaultView.Item(x)


                rc(x, 0) = .Item("TransNo")
                rc(x, 1) = .Item("SalesDT")
                rc(x, 2) = .Item("ItemNo")
                rc(x, 3) = .Item("IDesc")
                rc(x, 4) = .Item("UnitSold")
                rc(x, 5) = .Item("SRP")
                rc(x, 6) = .Item("SRPTotal")
                rc(x, 7) = .Item("Cost")
                rc(x, 8) = .Item("CostTotal")
                rc(x, 9) = .Item("CustName")


            End With
        Next

        Dim lastrow As Long
        lastrow = Me.TransactionsDataset.Sales.DefaultView.Count + 8
        Dim subt As Long
        subt = Me.TransactionsDataset.Sales.DefaultView.Count + 8

        wsheet.Range("A8", "J" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A8", "J" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Borders.Weight = 2
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString, "J" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString, "J" + (Me.TransactionsDataset.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDataset.Sales.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"


        wsheet.Range("G" + (Me.TransactionsDataset.Sales.DefaultView.Count + 9).ToString).Formula = "=SUBTOTAL(9,G8:G" & lastrow & ")"
        wsheet.Range("I" + (Me.TransactionsDataset.Sales.DefaultView.Count + 9).ToString).Formula = "=SUBTOTAL(9,I8:I" & lastrow & ")"
        wbook.SaveAs(Application.StartupPath + "\SalesReportGOVT.xls")
        xapp.Visible = True
    End Sub

    Private Sub GovernmentRPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        from.Value = Now.Date
        tod.Value = Now.Date
    End Sub
End Class