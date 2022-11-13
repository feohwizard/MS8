Imports System.Threading
Imports System.Globalization
Public Class StockTransfer
    Dim dbl As New Double
    Public totalunitcost, unitcost, grandtotal As Decimal
    Public id As Integer
    Dim add As Boolean = False
    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustumerTable.Costumertbl' table. You can move, or remove it, as needed.
        'Me.CostumertblTableAdapter.Fill(Me.CustumerTable.Costumertbl)
        'salesform = Me
        totalunitcost = 0
        unitcost = 0
        grandtotal = 0

        Try
            Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        Catch ex As Exception
            Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        End Try

        Dim itm As New ListViewItem
        transferfrm = Me
        For x As Integer = 0 To Me.InventoryDataset.Items.DefaultView.Count - 1
            Dim str(3) As String
            str(0) = Me.InventoryDataset.Items.DefaultView.Item(x).Item("IDesc").ToString
            dbl = Me.InventoryDataset.Items.DefaultView.Item(x).Item("SRP")
            str(1) = dbl.ToString("N")
            str(2) = Me.InventoryDataset.Items.DefaultView.Item(x).Item("Qty").ToString
            Try
                If Me.InventoryDataset.Items.DefaultView.Item(x).Item("inventory") = True Then
                    str(3) = "✪"
                Else
                    str(3) = ""
                End If
            Catch ex As Exception
                str(3) = ""
            End Try
            itm = New ListViewItem(str)
            Me.ListView1.Items.Add(itm)
        Next
        ComboBox1.Items.Clear()
        If branchname = "Main" Then
        Else
            ComboBox1.Items.Add("Main")
        End If
        If branchname = "Tanedo" Then
        Else
            ComboBox1.Items.Add("Tanedo")
        End If
        If branchname = "San Vicente" Then
        Else
            ComboBox1.Items.Add("San Vicente")
        End If

    End Sub

    Private Sub Searchbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Searchbox.KeyPress
        If e.KeyChar = ChrW(13) Then
            If Me.ListView1.Items.Count = 0 Then
            Else
                Me.ListView1.Select()
                Me.ListView1.Items(0).Selected = True

            End If
        End If
    End Sub

    Private Sub Searchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbox.TextChanged
        Try
            If Searchbox.Text = "" Then
                Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
            Else
                Me.ItemsTableAdapter.FillByDescription(Me.InventoryDataset.Items, Searchbox.Text)
            End If
            Me.ListView1.Items.Clear()
            Dim itm As New ListViewItem
            For x As Integer = 0 To Me.InventoryDataset.Items.DefaultView.Count - 1
                Dim str(3) As String
                str(0) = Me.InventoryDataset.Items.DefaultView.Item(x).Item("IDesc").ToString
                dbl = Me.InventoryDataset.Items.DefaultView.Item(x).Item("SRP")
                str(1) = dbl.ToString("N")
                str(2) = Me.InventoryDataset.Items.DefaultView.Item(x).Item("Qty").ToString
                itm = New ListViewItem(str)
                Me.ListView1.Items.Add(itm)
            Next
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        If e.KeyChar = ChrW(13) Then
            If Me.ListView1.Items(Me.ListView1.SelectedItems(0).Index).SubItems(2).Text = 0 Then
                MsgBox("Cannot continue if quantity is zero (0).")
                Me.lotview.Items.Clear()
            Else
                Me.lotview.Items.Clear()
                If ListView1.SelectedItems.Count = 0 Then
                Else
                    Dim itm As New ListViewItem
                    Me.PurchasesTableAdapter.FillByItemNo(Me.StockDataset.Purchases, Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo"))
                    If Me.StockDataset.Purchases.DefaultView.Count = 0 Then
                        MsgBox("No Stock")
                    Else
                        For x As Integer = 0 To Me.StockDataset.Purchases.DefaultView.Count - 1
                            With Me.StockDataset.Purchases.DefaultView.Item(x)
                                If Val(.Item("stock")) = 0 Then
                                Else
                                    Dim str(3) As String
                                    str(0) = CType(.Item("Expiry"), Date).ToShortDateString
                                    str(1) = .Item("Stock")
                                    str(2) = .Item("lotno")
                                    itm = New ListViewItem(str)
                                    Me.lotview.Items.Add(itm)
                                End If

                            End With
                        Next
                        Me.lotview.Focus()
                        Me.lotview.Items(0).Selected = True
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub lotview_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lotview.KeyPress
        If e.KeyChar = ChrW(13) Then
            quantitytxt.Focus()
        End If
    End Sub

    Private Sub lotview_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lotview.SelectedIndexChanged

    End Sub
    Private Function finduplicate(expire As Date, lotno As String, inventory As Integer, out As Integer, itemno As Integer)
        For Each rw As DataRow In Me.InventoryDataset.Purchases.Rows
            If rw("Expiry") = expire And lotno = rw("lotno") And itemno = rw("itemno") Then
                If (Val(rw("Qty")) + out) <= inventory Then
                    rw("Qty") = Val(rw("Qty")) + out
                    add = True
                Else
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub quantitytxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles quantitytxt.KeyPress
        If e.KeyChar = ChrW(13) Then
            If Val(quantitytxt.Text) <= 0 Then
                Exit Sub
            End If
            If Val(quantitytxt.Text) > Val(lotview.SelectedItems(0).SubItems(1).Text) Then
                MsgBox("Please enter lower quantity")
                Exit Sub
            End If
            If finduplicate(CType(lotview.SelectedItems(0).SubItems(0).Text, Date), lotview.SelectedItems(0).SubItems(2).Text, lotview.SelectedItems(0).SubItems(1).Text, Val(quantitytxt.Text), Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo")) = True Then
            Else
                MsgBox("Maximum quantity reached. Please select another Lot No.")
                Exit Sub
            End If

            If add = False Then
                Dim dr As DataRow
                dr = Me.InventoryDataset.Purchases.NewRow
                dr("Description") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("IDesc").ToString
                dr("NCost") = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double)
                dr("Cost") = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("Cost"), Double)
                dr("Qty") = Me.quantitytxt.Text
                dr("Expiry") = CType(Me.StockDataset.Purchases.DefaultView.Item(Me.lotview.SelectedItems(0).Index).Item("expiry"), Date).ToShortDateString
                dr("lotno") = Me.StockDataset.Purchases.DefaultView.Item(Me.lotview.SelectedItems(0).Index).Item("lotno").ToString
                dr("ItemNo") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo")
                dr("type") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("type")
                dr("discount") = 0
                dr("markup") = 0
                Me.InventoryDataset.Purchases.Rows.Add(dr)
                Searchbox.Text = ""
                unitcost = 0
                totalunitcost = 0
                grandtotal = Me.InventoryDataset.Purchases.total
                quantitytxt.Text = ""
                lotview.Items.Clear()
                Searchbox.Focus()
            Else
                add = False
                Searchbox.Text = ""
                unitcost = 0
                totalunitcost = 0
                grandtotal = Me.InventoryDataset.Purchases.total
                quantitytxt.Text = ""
                lotview.Items.Clear()
                Searchbox.Focus()
            End If

        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If reprintform Is Nothing Then
        Else
            reprintform.Close()
        End If
        reprintform = New Reprint
        reprintform.Show()
    End Sub

    Private Sub PurchasesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchasesDataGridView.CellContentClick

    End Sub

    Private Sub newb_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub searchb_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub genericmarkupcheck_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If transferpost Is Nothing Then
        Else
            transferpost.Close()
        End If
        transferpost = New StockTransferPosting
        transferpost.branch = ComboBox1.Text
        transferpost.Show()
    End Sub

    Private Sub quantitytxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles quantitytxt.TextChanged

    End Sub
End Class
