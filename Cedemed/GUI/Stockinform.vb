Imports System.Data.SqlClient
Public Class Stockinform
    Dim onEdit As Boolean = False
    Dim PONO As Integer = 0
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
            If onEdit = True Then
            Else
                itemnotxt.Text = ItemsDataGridView.CurrentRow.Cells(0).Value
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ItemsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellContentClick

    End Sub

    Private Sub updatepurchase(x As Integer)

        For Each rw As DataRow In Me.PurchasesDataset.Purchases
            If rw("PONO") = x Then
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
                If IsNumeric(ucost.Text) Then
                    rw("UCost") = CType(ucost.Text, Decimal)
                Else
                    rw("UCost") = 0
                End If
                rw("Expiry") = expirydate.Value.Date
                rw("encoder") = user
                rw("CheckNo") = checknotxt.Text
                rw("VoucherNo") = vouchertxt.Text
                rw("TotalCost") = 0
                rw("InvNo") = invoicetxt.Text
                Dim com As New SqlCommand("UPDATE Items SET restricted=0 WHERE ItemNo=" + itemnotxt.Text + "; UPDATE Inv SET OldCost=Cost, Cost=" + rw("UCost").ToString + ", lastin=" + rw("Qty").ToString + ", lastsupplier='" + rw("Supplier").ToString + "' WHERE ItemNo=" + itemnotxt.Text, conn)
                Try
                    conn.Open()
                Catch ex As Exception
                    conn.Close()
                    conn.Open()
                End Try
                com.ExecuteNonQuery()
                conn.Close()
            End If
        Next
        Me.PurchasesBindingSource.EndEdit()
        Me.PurchasesTableAdapter.Update(Me.PurchasesDataset.Purchases)
        onEdit = False

        Dim year = MonthCalendar1.SelectionStart.Year
        Dim month = MonthCalendar1.SelectionStart.Month
        If TextBox2.Text = "" Then
            Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
        Else
            Me.PurchasesTableAdapter.FillByDescription(Me.PurchasesDataset.Purchases, year, month, TextBox2.Text)
        End If
        For xx As Integer = 0 To Me.PurchasesDataset.Purchases.Rows.Count - 1
            With Me.PurchasesDataset.Purchases.Rows(xx)
                If .Item("PONO") = PONO Then
                    Me.PurchasesDataGridView.CurrentCell = Me.PurchasesDataGridView.Rows(xx).Cells(0)
                    Exit For
                End If
            End With
        Next
        PONO = 0
        Button2.Visible = False

        MsgBox("Record Updated")

    End Sub

    Private Sub clearentry()
        'recievedtxt.Text = Now.ToShortDateString
        'checkdatetxt.Text = Now.ToShortDateString
        lotnotxt.Text = ""
        'suppliercombotxt.Text = ""
        itemnotxt.Text = ""
        quantitytxt.Text = 0
        ucost.Text = 0
        expirydate.Value = Now.ToShortDateString
        checknotxt.Text = ""
        'invoicetxt.Text = ""
        vouchertxt.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If onEdit = True Then
            updatepurchase(PONO)
            clearentry()
        Else
            If itemnotxt.Text = "" Then
            Else
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
                If IsNumeric(ucost.Text) Then
                    rw("UCost") = CType(ucost.Text, Decimal)
                Else
                    rw("UCost") = 0
                End If
                rw("Expiry") = expirydate.Value.Date
                rw("encoder") = user
                rw("CheckNo") = checknotxt.Text
                rw("TotalCost") = 0
                rw("InvNo") = invoicetxt.Text
                rw("VoucherNo") = vouchertxt.Text
                Me.PurchasesDataset.Purchases.Rows.Add(rw)
                Me.PurchasesBindingSource.EndEdit()
                Me.PurchasesTableAdapter.Update(Me.PurchasesDataset.Purchases)
                Dim com As New SqlCommand("UPDATE Items SET restricted=0 WHERE ItemNo=" + itemnotxt.Text + "; UPDATE Inv SET OldCost=Cost, Cost=" + rw("UCost").ToString + ", lastin=" + rw("Qty").ToString + ", lastsupplier='" + rw("Supplier").ToString + "' WHERE ItemNo=" + itemnotxt.Text, conn)
                Try
                    conn.Open()
                Catch ex As Exception
                    conn.Close()
                    conn.Open()
                End Try
                com.ExecuteNonQuery()
                conn.Close()
                clearentry()
            End If

        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim year = MonthCalendar1.SelectionStart.Year
        Dim month = MonthCalendar1.SelectionStart.Month
        Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim x As String = MsgBox("It will affect the current inventory which may result into negative stocks. Are you sure you want to delete?", vbYesNo, "Confirmation")
        If x = vbYes Then
            Dim itemno As Integer = PurchasesDataGridView.CurrentRow.Cells(8).Value
            Dim qty As Integer = PurchasesDataGridView.CurrentRow.Cells(9).Value
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

    Private Sub del()
        Dim x As String = MsgBox("Are you sure you want to delete?", vbYesNo, "Confirmation")
        If x = vbYes Then

        End If
    End Sub


    Private Sub PurchasesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub PurchasesDataGridView_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles PurchasesDataGridView.DataError
        Dim bCancel As Boolean = e.Exception.GetType.Equals(GetType(System.ArgumentException))
        e.Cancel = bCancel
    End Sub

    Private Sub PurchasesDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles PurchasesDataGridView.CellContentClick

    End Sub

    Private Sub PurchasesDataGridView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PurchasesDataGridView.CellMouseUp
        If PurchasesDataGridView.SelectedRows.Count = 0 Then
            mennu.Items(0).Enabled = False
            mennu.Items(1).Enabled = False
        Else
            mennu.Items(0).Enabled = True
            mennu.Items(1).Enabled = True
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        On Error Resume Next
        recievedtxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(0).Value
        checkdatetxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(2).Value
        lotnotxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(5).Value
        suppliercombotxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(6).Value
        itemnotxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(8).Value
        quantitytxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(9).Value
        ucost.Text = Me.PurchasesDataGridView.CurrentRow.Cells(10).Value
        expirydate.Value = Me.PurchasesDataGridView.CurrentRow.Cells(7).Value
        checknotxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(3).Value
        invoicetxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(1).Value
        vouchertxt.Text = Me.PurchasesDataGridView.CurrentRow.Cells(4).Value
        Me.itemnotxt.Enabled = False
        onEdit = True
        Button2.Visible = True
        PONO = Me.PurchasesDataset.Purchases.Rows(Me.PurchasesBindingSource.Position).Item("PONO")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        onEdit = False
        Button2.Visible = False
        clearentry()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim year = MonthCalendar1.SelectionStart.Year
        Dim month = MonthCalendar1.SelectionStart.Month
        If TextBox2.Text = "" Then
            Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
        Else
            Me.PurchasesTableAdapter.FillByDescription(Me.PurchasesDataset.Purchases, year, month, TextBox2.Text)
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(13) Then
            Dim year = MonthCalendar1.SelectionStart.Year
            Dim month = MonthCalendar1.SelectionStart.Month
            If TextBox2.Text = "" Then
                Me.PurchasesTableAdapter.FillByMonth(Me.PurchasesDataset.Purchases, year, month)
            Else
                Me.PurchasesTableAdapter.FillByDescription(Me.PurchasesDataset.Purchases, year, month, TextBox2.Text)
            End If
        End If
    End Sub
End Class