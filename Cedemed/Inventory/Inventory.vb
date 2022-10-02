Imports Microsoft.Office.Interop
Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ItemsTableAdapter.Fill(Me.InventoryDS.Items)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub updateitemno(itemno As String, qty As Integer)
        For Each rw In InventoryDS.Items.Rows
            If rw("ItemNo") = itemno Then
                rw("Qty") = qty
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Validate()
        ItemsBindingSource.EndEdit()
        ItemsTableAdapter.Update(InventoryDS.Items)
        MsgBox("Inventory Updated")
        Me.ItemsTableAdapter.Fill(Me.InventoryDS.Items)
    End Sub

    Private Sub ItemsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        If ItemsDataGridView.SelectedRows.Count = 0 Then
            MsgBox("Please Select an Item")
        Else
            Dim frm As New ItemSummary
            frm.Show()
            frm.itemcombo1.Text = ItemsDataGridView.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\InventoryCheck.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)


        wsheet.Range("A4").Value = branchname
        wsheet.Range("A6").Value = Now.ToShortDateString



        Dim rc(Me.InventoryDS.Items.DefaultView.Count, 5)

        For x As Integer = 0 To Me.InventoryDS.Items.DefaultView.Count - 1
            With Me.InventoryDS.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("ItemNo")
                rc(x, 1) = .Item("IDesc")
                rc(x, 2) = .Item("IUnit")
                rc(x, 3) = .Item("Qty")
                If .Item("inventory") = True Then
                    rc(x, 4) = "✪"
                Else
                    rc(x, 4) = ""
                End If

            End With
        Next
        wsheet.Range("A9", "E" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A9", "E" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A9", "E" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A9", "E" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A9", "E" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        'wsheet.Range("A" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString, "E" + (Me.InventoryDS.Items.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        xapp.Visible = True
    End Sub
End Class