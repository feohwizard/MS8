Public Class Manufacturer

    Private Sub ManufacturerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ManufacturerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ManufacturerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ManufacturerDataset)

    End Sub

    Private Sub Manufacturer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManufacturerDataset.Manufacturer' table. You can move, or remove it, as needed.
        Me.ManufacturerTableAdapter.Fill(Me.ManufacturerDataset.Manufacturer)

    End Sub

    Private Sub ManufacturerDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ManufacturerDataGridView.CellContentClick

    End Sub

    Private Sub ManufacturerDataGridView_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ManufacturerDataGridView.CellEnter
        Try
            SendKeys.Send("{F2}")
        Catch ex As Exception

        End Try
    End Sub
End Class