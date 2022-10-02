Public Class HistoryTest
    Private Sub FillByDescriptionToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HistoryTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each rw As DataRow In InventoryDataset.Items.Rows
            Dim bal, purchases, sales, transfers As Integer

            Me.BalanceTableAdapter.FillByPurchases(Me.StockInDataset.Balance, rw("ItemNo"), Now.Date)
            purchases = Me.StockInDataset.Balance.Rows(0).Item(0)
            Me.BalanceTableAdapter.FillBySales(Me.StockInDataset.Balance, rw("ItemNo"), Now.Date)
            sales = Me.StockInDataset.Balance.Rows(0).Item(0)
            Me.BalanceTableAdapter.FillByTransferOUT(Me.StockInDataset.Balance, rw("ItemNo"), Now.Date)
            transfers = Me.StockInDataset.Balance.Rows(0).Item(0)
            bal = purchases - sales - transfers
            rw("History") = bal
        Next
    End Sub
End Class