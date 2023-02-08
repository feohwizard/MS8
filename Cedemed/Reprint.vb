Public Class Reprint
    Public sale As Sales
    Dim objExcel As Microsoft.Office.Interop.Excel.Application
    Private Sub TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)

    End Sub

    Private Sub Reprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DateTimePicker1.Value = Now.Date

        If Me.TransactionsDataset.Trans.DefaultView.Count = 0 Then
        Else
            TransDataGridView.Rows(0).Selected = True
        End If

        If userlevel = "Administrator" Then
            Button2.Enabled = True
            Me.TransTableAdapter.FillByDate(Me.TransactionsDataset.Trans, Now.Date)
        Else
            Button2.Enabled = False
            Me.TransTableAdapter.FillByDateHideTotal(Me.TransactionsDataset.Trans, Now.Date)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New RecieptPrintForm
        Try
            frm.transno = TransDataGridView.SelectedRows(0).Cells(0).Value
            frm.reprint = True
            frm.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If userlevel = "Administrator" Then
            Me.TransTableAdapter.FillByDate(Me.TransactionsDataset.Trans, Now.Date)
        Else
            Me.TransTableAdapter.FillByDateHideTotal(Me.TransactionsDataset.Trans, Now.Date)
        End If
        If Me.TransactionsDataset.Trans.DefaultView.Count = 0 Then
        Else
            TransDataGridView.Rows(0).Selected = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New ReturnItem
        Try
            frm.TransNoTextBox.Text = TransDataGridView.SelectedRows(0).Cells(0).Value
            frm.retrieve()
            frm.sale = sale
            frm.Show()
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class