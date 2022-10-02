Imports Microsoft.Office.Interop
Public Class ItemSummary
    Private Sub ItemSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsDescriptionTableAdapter.Fill(Me.InventoryDataset.ItemsDescription)
        itemcombo1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet
        Dim d1 As Date = DateValue(from.Value)
        Dim d2 As Date = DateValue(tod.Value)
        xapp.Workbooks.Open(Application.StartupPath + "\STOCK IN SOLD.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        Dim bal, purchases, sales, transfers As Integer
        Me.StockInDataset.Purchases.Clear()
        Me.PurchasesTableAdapter.ClearBeforeFill = False
        Me.StockInDataset.EnforceConstraints = False

        Me.BalanceTableAdapter.FillByPurchases(Me.StockInDataset.Balance, Me.InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"), d1)
        purchases = Me.StockInDataset.Balance.Rows(0).Item(0)
        Me.BalanceTableAdapter.FillBySales(Me.StockInDataset.Balance, Me.InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"), d1)
        sales = Me.StockInDataset.Balance.Rows(0).Item(0)
        Me.BalanceTableAdapter.FillByTransferOUT(Me.StockInDataset.Balance, Me.InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"), d1)
        transfers = Me.StockInDataset.Balance.Rows(0).Item(0)
        bal = purchases - sales - transfers

        'MsgBox(InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"))
        Me.PurchasesTableAdapter.FillByPurchases(Me.StockInDataset.Purchases, Me.InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"), d1, d2)
        Me.PurchasesTableAdapter.FillByTransferOut(Me.StockInDataset.Purchases, Me.InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"), d1, d2)
        Me.PurchasesTableAdapter.FillBySales(Me.StockInDataset.Purchases, Me.InventoryDataset.ItemsDescription.Rows(itemcombo1.SelectedIndex).Item("ItemNo"), d1, d2)

        If bal = 0 Then
        Else
            Dim rw As DataRow
            rw = Me.StockInDataset.Purchases.NewRow
            rw("RecvDT") = New Date(1200, 1, 1)
            rw("InvNo") = 0
            rw("Supplier") = "Balance Forwarded"
            rw("Qty") = bal
            Me.StockInDataset.Purchases.Rows.Add(rw)
        End If

        Dim dt As New DataTable
        Me.StockInDataset.Purchases.DefaultView.Sort = "RecvDT, InvNo"
        dt = Me.StockInDataset.Purchases.DefaultView.Table
        'Else
        'Me.PurchasesTableAdapter.FillByInvoice(Me.StockInDataset.Purchases, itemcombo1.Text, typecombo2.Text, d1, d2, Val(invtxt.Text))
        'End If

        Dim rc(Me.StockInDataset.Purchases.DefaultView.Count, 10)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString
        For x As Integer = 0 To Me.StockInDataset.Purchases.DefaultView.Count - 1
            With dt.DefaultView.Item(x)
                If x = 0 And bal <> 0 Then
                    rc(x, 0) = ""
                    rc(x, 1) = ""
                    rc(x, 2) = ""
                    rc(x, 3) = "Balance Forwarded"
                    rc(x, 5) = .Item("Qty")
                    rc(x, 6) = ""
                        rc(x, 7) = ""
                    If x = 0 Then
                        rc(x, 8) = "=F8+G8+H8"
                    Else
                        rc(x, 8) = "=I" + (x + 7).ToString + "+F" + (x + 8).ToString + "+G" + (x + 8).ToString + "+H" + (x + 8).ToString
                    End If
                    rc(x, 9) = ""
                Else
                    rc(x, 0) = DateValue(.Item("RecvDT")).ToShortDateString
                    rc(x, 1) = .Item("InvNo")
                    If .Item("remarks") = "Purchase" Then
                        rc(x, 2) = .Item("Supplier")
                    Else
                        rc(x, 2) = ""
                    End If

                    If .Item("remarks") = "Purchase" Then
                        rc(x, 3) = .Item("Idesc")
                    Else
                        rc(x, 3) = .Item("Supplier")
                    End If

                    rc(x, 4) = .Item("IUnit")

                    If .Item("remarks") = "Purchase" Or .Item("remarks") = "TransIN" Then
                        rc(x, 5) = .Item("Qty")
                        rc(x, 6) = ""
                        rc(x, 7) = ""
                    Else
                        If .Item("remarks") = "Sales" Then
                            rc(x, 5) = ""
                            rc(x, 6) = .Item("Qty")
                            rc(x, 7) = ""
                        ElseIf .Item("remarks") = "TransOUT" Then
                            rc(x, 5) = ""
                            rc(x, 6) = ""
                            rc(x, 7) = .Item("Qty")
                        End If
                    End If


                    If x = 0 Then
                        rc(x, 8) = "=F8+G8+H8"
                    Else
                        rc(x, 8) = "=I" + (x + 7).ToString + "+F" + (x + 8).ToString + "+G" + (x + 8).ToString + "+H" + (x + 8).ToString
                    End If

                    rc(x, 9) = .Item("Expiry")
                End If





            End With
        Next


        wsheet.Range("A8", "J" + (Me.StockInDataset.Purchases.DefaultView.Count + 7).ToString).Value = rc
            wsheet.Range("A8", "J" + (Me.StockInDataset.Purchases.DefaultView.Count + 7).ToString).Borders.Weight = 2
            wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString, "J" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString, "J" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
            wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"
        xapp.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class