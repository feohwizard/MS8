Imports System.Threading
Imports System.Globalization
Imports System.Data.SqlClient
Public Class Sales


    Dim dbl As New Double
    Public totalunitcost, unitcost, grandtotal As Decimal
    Public id As Integer
    Dim br As New BranchDataSetTableAdapters.BranchTableAdapter
    Dim add As Boolean = False
    Public Sub assigncustomer()
        Me.CostumertblTableAdapter.FillByID(Me.CustumerTable.Costumertbl, id)
        otcnorm.Checked = True
        genericnorm.Checked = True
        recompute()
    End Sub

    Public Sub recompute()
        If Me.InventoryDataset.Purchases.DefaultView.Count = 0 Then
        Else
            Dim dr As DataRow
            For Each dr In Me.InventoryDataset.Purchases.Rows
                If dr("type") = "gen" Then
                    If genericdiscountcheck.Checked = True Then
                        dr("discount") = CType(GenericdiscountLabel1.Text, Decimal)
                        dr("markup") = 0
                    ElseIf genericmarkupcheck.Checked = True Then
                        dr("markup") = CType(GenericmarkupLabel1.Text, Decimal)
                        dr("discount") = 0
                    Else
                        dr("discount") = 0
                        dr("markup") = 0
                    End If
                ElseIf dr("type") = "otc" Then
                    If otcdiscountcheck.Checked = True Then
                        dr("discount") = CType(OtcdiscountLabel1.Text, Decimal)
                        dr("markup") = 0
                    ElseIf otcmarkupcheck.Checked = True Then
                        dr("markup") = CType(OtcmarkupLabel1.Text, Decimal)
                        dr("discount") = 0
                    Else
                        dr("discount") = 0
                        dr("markup") = 0
                    End If
                End If
            Next
        End If
        Me.InventoryDataset.Purchases.AcceptChanges()
        grandtotal = Me.InventoryDataset.Purchases.total
        grandlabel.Text = grandtotal.ToString("N")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If user = "daisy" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
        id = 1
        salesform = Me
        totalunitcost = 0
        unitcost = 0
        grandtotal = 0
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-us")
        Me.Lblname.Text = "Main"


        Try
            Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        Catch ex As Exception
            Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        End Try

        Dim itm As New ListViewItem

        For x As Integer = 0 To Me.InventoryDataset.Items.DefaultView.Count - 1
            Dim str(4) As String
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
        assigncustomer()
    End Sub

    Private Sub Searchbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Searchbox.KeyPress
        If e.KeyChar = ChrW(13) Then

            If Searchbox.Text = "" Then

                ListView1.Items(0).Selected = True
                'Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
            Else

                For x As Integer = 0 To ListView1.Items.Count - 1

                    If ListView1.Items(x).SubItems(0).Text.IndexOf(Searchbox.Text) = 0 Then
                        ListView1.SelectedItems.Clear()
                        ListView1.Select()
                        ListView1.Items(x).Selected = True
                        ListView1.EnsureVisible(x)
                        Exit Sub
                    End If
                Next
                'Me.ItemsTableAdapter.FillByDescription(Me.InventoryDataset.Items, Searchbox.Text)
            End If
        End If
    End Sub

    Private Sub Searchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbox.TextChanged
        Try

            'Me.ListView1.Items.Clear()
            'Dim itm As New ListViewItem
            'For x As Integer = 0 To Me.InventoryDataset.Items.DefaultView.Count - 1
            'Dim str(3) As String
            'Str(0) = Me.InventoryDataset.Items.DefaultView.Item(x).Item("IDesc").ToString
            'dbl = Me.InventoryDataset.Items.DefaultView.Item(x).Item("SRP")
            'Str(1) = dbl.ToString("N")
            'Str(2) = Me.InventoryDataset.Items.DefaultView.Item(x).Item("Qty").ToString
            'itm = New ListViewItem(str)
            'Me.ListView1.Items.Add(itm)
            'Next
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        If e.KeyChar = ChrW(13) Then
            If Me.ListView1.Items(Me.ListView1.SelectedItems(0).Index).SubItems(2).Text <= 0 Then

                Me.lotview.Items.Clear()
                If Me.InventoryDataset.Items.Rows(ListView1.SelectedItems(0).Index).Item("restricted") = True Then
                Else
                    MsgBox("Cannot continue if quantity is zero (0) or negative. Please inform admin to remove restriction.")
                    Exit Sub
                End If

                If ListView1.SelectedItems.Count = 0 Then
                Else
                    Dim itm As New ListViewItem
                    Me.PurchasesTableAdapter.FillByItemNo(Me.StockDataset.Purchases, Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo"))

                    For x As Integer = 0 To Me.StockDataset.Purchases.DefaultView.Count - 1
                            With Me.StockDataset.Purchases.DefaultView.Item(x)
                            If Val(.Item("stock")) <= 0 Then
                                If Me.InventoryDataset.Items.Rows(ListView1.SelectedItems(0).Index).Item("restricted") = True Then
                                    Dim str(2) As String
                                    str(0) = CType(.Item("Expiry"), Date).ToShortDateString
                                    str(1) = .Item("Stock")
                                    str(2) = .Item("lotno")
                                    itm = New ListViewItem(str)
                                    Me.lotview.Items.Add(itm)
                                End If
                            Else
                                Dim str(2) As String
                                str(0) = CType(.Item("Expiry"), Date).ToShortDateString
                                str(1) = .Item("Stock")
                                str(2) = .Item("lotno")
                                itm = New ListViewItem(str)
                                Me.lotview.Items.Add(itm)
                            End If
                        End With
                        Next
                    Me.lotview.Focus()
                    Try
                        Me.lotview.Items(0).Selected = True
                    Catch ex As Exception
                        MsgBox("No Stock")
                    End Try


                End If
                itemnotxt.Text = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo").ToString
                unitcosttxt.Text = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double).ToString("N")
                unitcost = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Decimal).ToString("N")
                totalcosttxt.Text = ""
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
                                If Val(.Item("stock")) <= 0 Then
                                Else
                                    Dim str(2) As String
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
                itemnotxt.Text = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo").ToString
                unitcosttxt.Text = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double).ToString("N")
                unitcost = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Decimal).ToString("N")
                totalcosttxt.Text = ""
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

    Private Sub quantitytxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles quantitytxt.KeyPress
        If e.KeyChar = ChrW(13) Then
            If Val(quantitytxt.Text) <= 0 Then
                Exit Sub
            End If
            If Me.CustumerTable.Costumertbl.DefaultView.Count = 0 Then
                MsgBox("Please select customer.")
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
                Dim itm As New ListViewItem
                If totalcosttxt.Text = "" Then
                Else
                    Dim dr As DataRow
                    dr = Me.InventoryDataset.Purchases.NewRow
                    dr("Description") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("IDesc").ToString
                    dr("NCost") = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double)
                    dr("Qty") = Me.quantitytxt.Text
                    dr("Expiry") = CType(lotview.SelectedItems(0).SubItems(0).Text, Date).ToShortDateString
                    dr("lotno") = lotview.SelectedItems(0).SubItems(2).Text
                    dr("ItemNo") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("ItemNo")
                    dr("type") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("type")
                    dr("Cost") = Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("Cost")
                    dr("discount") = 0
                    dr("markup") = 0
                    If Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("type") = "gen" Then
                        'Generic
                        If genericdiscountcheck.Checked = True Then
                            dr("discount") = CType(GenericdiscountLabel1.Text, Decimal)
                        ElseIf genericmarkupcheck.Checked = True Then
                            dr("markup") = CType(GenericmarkupLabel1.Text, Decimal)
                        Else
                        End If
                    ElseIf Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("type") = "otc" Then
                        'OTC
                        If otcdiscountcheck.Checked = True Then
                            dr("discount") = CType(OtcdiscountLabel1.Text, Decimal)
                        ElseIf otcmarkupcheck.Checked = True Then
                            dr("markup") = CType(OtcmarkupLabel1.Text, Decimal)
                        Else
                        End If
                    Else
                        'Normal will apply
                    End If
                    Dim srp As Decimal
                    srp = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double)
                    srp = srp - (srp * (dr("discount") / 100)) + (srp * (dr("markup") / 100))
                    dr("SRP") = srp
                    Me.InventoryDataset.Purchases.Rows.Add(dr)

                    Searchbox.Text = ""
                    unitcost = 0
                    totalunitcost = 0
                    grandtotal = Me.InventoryDataset.Purchases.total
                    grandlabel.Text = grandtotal.ToString("N")
                    itemnotxt.Text = ""
                    unitcosttxt.Text = ""
                    quantitytxt.Text = ""
                    totalcosttxt.Text = ""
                    subtotaltxt.Text = grandtotal.ToString("N")
                    totalpaymenttxt.Text = grandtotal.ToString("N")
                    lotview.Items.Clear()
                    ListView1.Focus()
                End If
            Else
                add = False
                Searchbox.Text = ""
                unitcost = 0
                totalunitcost = 0
                grandtotal = Me.InventoryDataset.Purchases.total
                grandlabel.Text = grandtotal.ToString("N")
                itemnotxt.Text = ""
                unitcosttxt.Text = ""
                quantitytxt.Text = ""
                totalcosttxt.Text = ""
                subtotaltxt.Text = grandtotal.ToString("N")
                totalpaymenttxt.Text = grandtotal.ToString("N")
                lotview.Items.Clear()
                ListView1.Focus()
            End If
        End If
    End Sub

    Private Sub quantitytxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quantitytxt.TextChanged
        Dim qty As Integer = Val(quantitytxt.Text)
        If qty = 0 Then
            quantitytxt.Text = ""
            totalcosttxt.Text = ""
        Else

            totalunitcost = qty * unitcost
            totalcosttxt.Text = totalunitcost.ToString("N")
            grandlabel.Text = totalcosttxt.Text
        End If

    End Sub


    Private Sub paymenttxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles paymenttxt.KeyPress
        If e.KeyChar = ChrW(13) Then
            Try
                Dim p As Decimal = paymenttxt.Text

                changetxt.Text = (p - grandtotal).ToString("N")
                Dim s As String = MsgBox("Are you sure you want to save this transaction?", vbYesNo, "Confirmation")
                If s = vbYes Then

                Else
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
            Dim frm As New SalesRecieptForm
            frm.customer = NameLabel1.Text
            frm.discount = 0 'For the mean time, discount is set to zero.
            frm.total = CType(subtotaltxt.Text, Decimal)
            frm.Show()

        End If
    End Sub

    Private Sub paymenttxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paymenttxt.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If reprintform Is Nothing Then
        Else
            reprintform.Close()
        End If
        reprintform = New Reprint
        reprintform.sale = Me
        reprintform.Show()
    End Sub

    Private Sub PurchasesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub PurchasesDataGridView_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub newb_Click(sender As System.Object, e As System.EventArgs) Handles newb.Click
        Dim frm As New NewCustumer
        frm.frm = Me
        frm.ShowDialog()
    End Sub

    Private Sub searchb_Click(sender As System.Object, e As System.EventArgs) Handles searchb.Click
        Dim frm As New CostumerForm
        frm.srchmode = True
        frm.frm = Me
        frm.ShowDialog()
    End Sub

    Private Sub otcnorm_Click(sender As Object, e As System.EventArgs) Handles otcnorm.Click
        If Me.CustumerTable.Costumertbl.DefaultView.Count <> 0 Then
            recompute()
        End If
    End Sub

    Private Sub otcdiscountcheck_Click(sender As Object, e As System.EventArgs) Handles otcdiscountcheck.Click
        If Me.CustumerTable.Costumertbl.DefaultView.Count <> 0 Then
            recompute()
        End If
    End Sub


    Private Sub otcmarkupcheck_Click(sender As Object, e As System.EventArgs) Handles otcmarkupcheck.Click
        If Me.CustumerTable.Costumertbl.DefaultView.Count <> 0 Then
            recompute()
        End If
    End Sub


    Private Sub genericnorm_Click(sender As Object, e As System.EventArgs) Handles genericnorm.Click
        If Me.CustumerTable.Costumertbl.DefaultView.Count <> 0 Then
            recompute()
        End If
    End Sub

    Private Sub genericdiscountcheck_Click(sender As Object, e As System.EventArgs) Handles genericdiscountcheck.Click
        If Me.CustumerTable.Costumertbl.DefaultView.Count <> 0 Then
            recompute()
        End If
    End Sub

    Private Sub genericmarkupcheck_Click(sender As Object, e As System.EventArgs) Handles genericmarkupcheck.Click
        If Me.CustumerTable.Costumertbl.DefaultView.Count <> 0 Then
            recompute()
        End If
    End Sub

    Private Sub genericmarkupcheck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles genericmarkupcheck.CheckedChanged

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

    Private Sub PurchasesDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchasesDataGridView1.CellContentClick

    End Sub

    Private Sub genericdiscountcheck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles genericdiscountcheck.CheckedChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New ReturnItem
        frm.sale = Me
        frm.Show()
    End Sub

    Private Sub PurchasesDataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PurchasesDataGridView1.CellEndEdit
        Me.InventoryDataset.Purchases.AcceptChanges()
        Me.grandlabel.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        subtotaltxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        totalpaymenttxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
    End Sub

    Private Sub PurchasesDataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PurchasesDataGridView1.RowsRemoved
        Me.InventoryDataset.Purchases.AcceptChanges()
        Me.grandlabel.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        subtotaltxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        totalpaymenttxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
    End Sub
End Class
