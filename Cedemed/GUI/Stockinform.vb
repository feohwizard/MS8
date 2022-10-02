Imports System.Data.SqlClient
Public Class Stockinform
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Private Sub ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ItemsDataset)

    End Sub

    Private Sub Stockinform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItemStockin._ItemStockIn' table. You can move, or remove it, as needed.
        Me.ItemStockInTableAdapter.Fill(Me.ItemStockin._ItemStockIn)
        'TODO: This line of code loads data into the 'SupplierDataset.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.SupplierDataset.Supplier)
        'TODO: This line of code loads data into the 'PurchasesDataset.Purchases' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ItemsDataset.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        Dim year = MonthCalendar1.SelectionStart.Year
        Dim month = MonthCalendar1.SelectionStart.Month
        Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        Else
            Me.ItemsTableAdapter.FillByDescription(Me.ItemsDataset.Items, TextBox1.Text)
        End If
    End Sub

    Private Sub ItemsDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellClick
        Try
            itemnotxt.Text = ItemsDataGridView.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ItemsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rw As DataRow
        rw = Me.PurchasesDataset.Purchases.NewRow
        Try
            rw("RecvDT") = DateValue(CType(recievedtxt.Text, Date))
        Catch ex As Exception
            rw("RecvDT") = DateValue(Now)
        End Try

        Try
            rw("CheckDT") = DateValue(CType(checkdatetxt.Text, Date))
        Catch ex As Exception
            rw("CheckDT") = DateValue(Now)
        End Try

        rw("MRRNo") = lotnotxt.Text
        rw("Supplier") = suppliercombotxt.Text
        rw("ItemNo") = itemnotxt.Text
        rw("Qty") = Val(quantitytxt.Text)
        rw("UCost") = 0
        rw("Expiry") = expirydate.Value.Date
        rw("encoder") = user
        rw("CheckNo") = checknotxt.Text
        rw("TotalCost") = 0
        rw("InvNo") = invoicetxt.Text
        Me.PurchasesDataset.Purchases.Rows.Add(rw)
        Me.PurchasesBindingSource.EndEdit()
        Me.PurchasesTableAdapter.Update(Me.PurchasesDataset.Purchases)
        Dim com As New SqlCommand("UPDATE Items SET restricted=0 WHERE ItemNo=" + itemnotxt.Text, conn)
        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            conn.Open()
        End Try
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim year = MonthCalendar1.SelectionStart.Year
        Dim month = MonthCalendar1.SelectionStart.Month
        Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

        MsgBox("Deleting Stock In record will affect the accuracy of the Item History Report. It is no longer permitted.", vbOK, "Important Notice")
        'del()
    End Sub

    Private Sub del()
        Dim x As String = MsgBox("Are you sure you want to delete?", vbYesNo, "Confirmation")
        If x = vbYes Then
            Dim itemno As Integer = PurchasesDataGridView.CurrentRow.Cells(5).Value
            Dim qty As Integer = PurchasesDataGridView.CurrentRow.Cells(6).Value
            Dim com As New SqlCommand("Insert into TrashIn (ItemNo, Qty) values (" + itemno.ToString + "," + qty.ToString + ")", conn)
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
            com = New SqlCommand("delete from Purchases where PONo=" + Me.PurchasesDataset.Purchases.DefaultView.Item(Me.PurchasesDataGridView.CurrentRow.Index).Item("PONo").ToString, conn)
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
            Dim year = MonthCalendar1.SelectionStart.Year
            Dim month = MonthCalendar1.SelectionStart.Month
            Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
            MsgBox("Deleted")
        End If
    End Sub


    Private Sub PurchasesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub PurchasesDataGridView_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If PurchasesDataGridView.SelectedRows.Count = 0 Then
            mennu.Items(0).Enabled = False
        Else
            mennu.Items(0).Enabled = True
        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PurchasesDataGridView_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchasesDataGridView.CellContentClick

    End Sub

    Private Sub PurchasesDataGridView_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles PurchasesDataGridView.DataError
        Dim bCancel As Boolean = e.Exception.GetType.Equals(GetType(System.ArgumentException))
        e.Cancel = bCancel
    End Sub
End Class