Public Class ItemSearch
    Public item As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.ItemsDataGridView.SelectedRows.Count = 0 Then
        Else
            item = Me.ItemsDataGridView.SelectedRows(0).Cells(0).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub FillByDescriptionToolStripButton_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.ItemsTableAdapter.FillByDescription(Me.InventoryDataset.Items, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ItemSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
    End Sub
End Class