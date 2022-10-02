Public Class Supplier

    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SupplierDataset)

    End Sub

    Private Sub Supplier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupplierDataset.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.SupplierDataset.Supplier)

    End Sub

    Private Sub SupplierDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SupplierDataGridView.CellContentClick

    End Sub

    Private Sub SupplierDataGridView_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SupplierDataGridView.CellEnter
        Try
            SendKeys.Send("{F2}")
        Catch ex As Exception
        End Try
    End Sub
End Class