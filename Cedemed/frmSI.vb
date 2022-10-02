Public Class frmSI
    Private Sub Trans1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransactionsDataset.Trans1' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Trans1TableAdapter.FillByDate(Me.TransactionsDataset.Trans1, DateValue(DateTimePicker1.Value))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.Trans1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)
        MsgBox("Updated.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TransactionsDataset.Trans1.Rows.Count = 0 Then
        Else
            For Each rw As DataRow In TransactionsDataset.Trans1.Rows
                rw("ref") = True
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TransactionsDataset.Trans1.Rows.Count = 0 Then
        Else
            For Each rw As DataRow In TransactionsDataset.Trans1.Rows
                rw("ref") = False
            Next
        End If
    End Sub
End Class