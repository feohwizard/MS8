Imports Microsoft.Office.Interop
Public Class StockInSummary

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New ItemSearch
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            itemcombo1.SelectedValue = frm.item
        End If

    End Sub

    Private Sub StockInSummary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        itemcombo1.SelectedIndex = -1
        typecombo2.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet
        Dim d1 As Date = DateValue(from.Value)
        Dim d2 As Date = DateValue(tod.Value)
        xapp.Workbooks.Open(Application.StartupPath + "\StockIn.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'If Val(invtxt.Text) = 0 Then
        Me.PurchasesTableAdapter.Fill(Me.StockInDataset.Purchases, itemcombo1.Text, typecombo1.Text, d1, d2)
        'Else
        'Me.PurchasesTableAdapter.FillByInvoice(Me.StockInDataset.Purchases, itemcombo1.Text, typecombo2.Text, d1, d2, Val(invtxt.Text))
        'End If

        Dim rc(Me.StockInDataset.Purchases.DefaultView.Count, 7)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString
        For x As Integer = 0 To Me.StockInDataset.Purchases.DefaultView.Count - 1
            With Me.StockInDataset.Purchases.DefaultView.Item(x)

                rc(x, 0) = .Item("RecvDT")
                rc(x, 1) = .Item("InvNo")
                rc(x, 2) = .Item("Supplier")
                rc(x, 3) = .Item("Idesc")
                rc(x, 4) = .Item("IUnit")
                rc(x, 5) = .Item("Qty")
                rc(x, 6) = .Item("Expiry")

            End With
        Next


        wsheet.Range("A8", "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 7).ToString).Value = rc
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString, "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString, "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"
        xapp.Visible = True
    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs)




    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\PriceList.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        Me.ItemsTableAdapter.FillByType(Me.InventoryDataset.Items, typecombo2.Text)

        wsheet.Range("A2").Value = "Ending Inventory"
        wsheet.Range("A3").Value = "As Of " + Now.ToShortDateString
        wsheet.Range("A4").Value = branchname

        If typecombo2.SelectedIndex = -1 Then
            wsheet.Range("A5").Value = "Category: All"
        Else
            wsheet.Range("A5").Value = "Category: " + typecombo2.Text
        End If

        wsheet.Range("A2").Value = "Ending Inventory"

        Dim rc(Me.InventoryDataset.Items.DefaultView.Count, 3)

        For x As Integer = 0 To Me.InventoryDataset.Items.DefaultView.Count - 1
            With Me.InventoryDataset.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("IDesc")
                rc(x, 1) = .Item("ProdType")
                rc(x, 2) = .Item("Qty")
            End With
        Next
        wsheet.Range("A6", "C" + (Me.InventoryDataset.Items.DefaultView.Count + 5).ToString).Value = rc
        wsheet.Range("A" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString, "C" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString, "C" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        xapp.Visible = True
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\PriceList.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        Me.ItemsTableAdapter.FillByType(Me.InventoryDataset.Items, typecombo3.Text)
        wsheet.Range("A2").Value = "Price List"
        wsheet.Range("A3").Value = "As Of " + Now.ToShortDateString
        wsheet.Range("A4").Value = branchname
        If typecombo2.SelectedIndex = -1 Then
            wsheet.Range("A5").Value = "Category: All"
        Else
            wsheet.Range("A5").Value = "Category: " + typecombo2.Text
        End If
        wsheet.Range("A2").Value = "Ending Inventory"
        Dim rc(Me.InventoryDataset.Items.DefaultView.Count, 5)
        For x As Integer = 0 To Me.InventoryDataset.Items.DefaultView.Count - 1
            With Me.InventoryDataset.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("IDesc")
                rc(x, 1) = .Item("ProdType")
                rc(x, 2) = .Item("Qty")
                rc(x, 4) = .Item("SRP")
            End With
        Next
        wsheet.Range("A6", "E" + (Me.InventoryDataset.Items.DefaultView.Count + 5).ToString).Value = rc
        wsheet.Range("A" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString, "E" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString, "E" + (Me.InventoryDataset.Items.DefaultView.Count + 6).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        xapp.Visible = True
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\NearExpiry.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        Me.ItemsTableAdapter1.Fill(Me.NearExpiry.Items, CType(TextBox1.Text, Decimal))

        For Each dr As DataRow In Me.NearExpiry.Items.Rows
            If Val(dr("remaining")) <= 0 Then
                dr.Delete()
            End If
        Next

        Dim cr(Me.NearExpiry.Items.DefaultView.Count, 5)
        For x As Integer = 0 To Me.NearExpiry.Items.DefaultView.Count - 1
            With Me.NearExpiry.Items.DefaultView.Item(x)
                cr(x, 0) = .Item("Idesc")
                cr(x, 1) = .Item("remaining")
                cr(x, 2) = .Item("IUnit")
                cr(x, 4) = .Item("lotno")
                cr(x, 3) = CType(.Item("Expiry"), Date).ToShortDateString
            End With
        Next
        wsheet.Range("A2").Value = "Items that will expire in the year"
        wsheet.Range("A3").Value = TextBox1.Text
        wsheet.Range("A7", "E" + (Me.NearExpiry.Items.DefaultView.Count + 6).ToString).Value = cr
        xapp.Visible = True
    End Sub

    Private Sub FillToolStripButton_Click_1(sender As System.Object, e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet
        
        xapp.Workbooks.Open(Application.StartupPath + "\StockIn.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'If Val(invtxt.Text) = 0 Then
        'Me.PurchasesTableAdapter.Fill(Me.StockInDataset.Purchases, itemcombo1.Text, typecombo1.Text, d1, d2)
        'Else
        Me.PurchasesTableAdapter.FillByInvoice(Me.StockInDataset.Purchases, Val(invtxt.Text))        'End If

        Dim rc(Me.StockInDataset.Purchases.DefaultView.Count, 7)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString
        For x As Integer = 0 To Me.StockInDataset.Purchases.DefaultView.Count - 1
            With Me.StockInDataset.Purchases.DefaultView.Item(x)

                rc(x, 0) = .Item("RecvDT")
                rc(x, 1) = .Item("InvNo")
                rc(x, 2) = .Item("Supplier")
                rc(x, 3) = .Item("Idesc")
                rc(x, 4) = .Item("IUnit")
                rc(x, 5) = .Item("Qty")
                rc(x, 6) = .Item("Expiry")

            End With
        Next


        wsheet.Range("A8", "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 7).ToString).Value = rc
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString, "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString, "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.StockInDataset.Purchases.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"
        xapp.Visible = True
    End Sub

End Class