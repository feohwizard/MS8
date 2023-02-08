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
        id = 1
        salesform = Me
        totalunitcost = 0
        unitcost = 0
        grandtotal = 0

        Me.Lblname.Text = "Main"
        Try
            Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        Catch ex As Exception
            Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
        End Try

        populatelist()
        assigncustomer()
        If userlevel = "Administrator" Then
            Me.PurchasesDataGridView1.Columns(1).ReadOnly = False
            Button2.Enabled = True
        Else
            Me.PurchasesDataGridView1.Columns(1).ReadOnly = True
            Button2.Enabled = False
        End If

    End Sub

    Private Sub populatelist()
        Dim itm As New ListViewItem
        ListView1.Items.Clear()
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
    End Sub

    Private Sub Searchbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Searchbox.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            If Searchbox.Text = "" Then
                Me.ItemsTableAdapter.Fill(Me.InventoryDataset.Items)
                populatelist()
                ListView1.Items(0).Selected = True
            Else
                Me.ItemsTableAdapter.FillByDescription(Me.InventoryDataset.Items, Searchbox.Text)
                populatelist()
                For x As Integer = 0 To ListView1.Items.Count - 1

                    If ListView1.Items(x).SubItems(0).Text.Contains(Searchbox.Text) Then
                        ListView1.SelectedItems.Clear()
                        ListView1.Select()
                        ListView1.Items(x).Selected = True
                        ListView1.EnsureVisible(x)
                        ListView1.Focus()
                        Exit Sub
                    End If
                Next

            End If
        End If
    End Sub

    Private Sub Searchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbox.TextChanged

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
                    'FOR SRP WITH GENERIC OR OTC MARKUP AND DISCOUNT
                    'If Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("type") = "gen" Then
                    '    'Generic
                    '    If genericdiscountcheck.Checked = True Then
                    '        dr("discount") = CType(GenericdiscountLabel1.Text, Decimal)
                    '    ElseIf genericmarkupcheck.Checked = True Then
                    '        dr("markup") = CType(GenericmarkupLabel1.Text, Decimal)
                    '    Else
                    '    End If
                    'ElseIf Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("type") = "otc" Then
                    '    'OTC
                    '    If otcdiscountcheck.Checked = True Then
                    '        dr("discount") = CType(OtcdiscountLabel1.Text, Decimal)
                    '    ElseIf otcmarkupcheck.Checked = True Then
                    '        dr("markup") = CType(OtcmarkupLabel1.Text, Decimal)
                    '    Else
                    '    End If
                    'Else
                    '    'Normal will apply
                    'End If
                    'Dim srp As Decimal
                    'srp = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double)
                    'srp = srp - (srp * (dr("discount") / 100)) + (srp * (dr("markup") / 100))
                    dr("SRP") = CType(Me.InventoryDataset.Items.DefaultView.Item(Me.ListView1.SelectedItems(0).Index).Item("SRP"), Double)
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
                grandtotal = CType(grandlabel.Text, Decimal)
                Dim p As Decimal = 0

                Try
                    p = paymenttxt.Text
                Catch ex As Exception
                    MsgBox("Invalid Payment Amount", vbOKOnly, "Error")
                    Exit Sub
                End Try

                changetxt.Text = (p - grandtotal).ToString("N")
                Dim s As String = MsgBox("Are you sure you want to save this transaction?", vbYesNo, "Confirmation")
                If s = vbYes Then
                    If Me.InventoryDataset.Purchases.Rows.Count = 0 Then
                        MsgBox("No Items to transact. Please add Items first before proceeding with payment.", vbOKOnly, "Message")
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
            Dim frm As New SalesRecieptForm
            frm.customer = NameLabel1.Text
            frm.discount = compute_discount()
            frm.total = grandtotal
            frm.Show()

        End If
    End Sub

    Private Function compute_discount() As Decimal
        Dim disc As Decimal = 0
        Dim normalsrp As Decimal
        Dim srp As Decimal = 0
        Dim qty As Integer = 0


        For Each rw As DataRow In Me.InventoryDataset.Purchases.Rows
            normalsrp = rw.Item("Ncost")
            srp = rw.Item("SRP")
            qty = rw.Item("Qty")
            If srp < normalsrp Then
                disc = disc + ((normalsrp - srp) * qty)
            End If
        Next
        Return disc
    End Function

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
        grandtotal = Me.InventoryDataset.Purchases.total
        subtotaltxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        totalpaymenttxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
    End Sub

    Private Sub refreshgrid()
        Me.InventoryDataset.Purchases.AcceptChanges()
        Me.grandlabel.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        subtotaltxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        totalpaymenttxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
    End Sub

    Private Sub Apply2DiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Apply2DiscountToolStripMenuItem.Click
        Dim normalSRP As Decimal = 0
        For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
            Try
                normalSRP = rw.Cells(5).Value
            Catch ex As Exception
            End Try
            rw.Cells(1).Value = normalSRP - Math.Round(normalSRP * 0.02, 2, MidpointRounding.AwayFromZero)
            rw.Cells(7).Value = "2% Discount"
        Next
        refreshgrid()
    End Sub

    Private Sub Apply10DiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Apply10DiscountToolStripMenuItem.Click
        Dim normalSRP As Decimal = 0
        For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
            Try
                normalSRP = rw.Cells(5).Value
            Catch ex As Exception
            End Try
            rw.Cells(1).Value = normalSRP - Math.Round(normalSRP * 0.1, 2, MidpointRounding.AwayFromZero)
            rw.Cells(7).Value = "10% Discount"
        Next
        refreshgrid()
    End Sub

    Private Sub Apply20DiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Apply20DiscountToolStripMenuItem.Click
        Dim normalSRP As Decimal = 0
        For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
            Try
                normalSRP = rw.Cells(5).Value
            Catch ex As Exception
            End Try
            rw.Cells(1).Value = normalSRP - Math.Round(normalSRP * 0.2, 2, MidpointRounding.AwayFromZero)
            rw.Cells(7).Value = "20% Discount"
            refreshgrid()
        Next
    End Sub

    Private Sub ApplyCustomDiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyCustomDiscountToolStripMenuItem.Click
        Dim x As String = InputBox("Discount:", "Enter Discount Percentage (%)")
        Dim disc As Decimal
        If IsNumeric(x) Then
            disc = x / 100
            Dim normalSRP As Decimal = 0
            For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
                Try
                    normalSRP = rw.Cells(5).Value
                Catch ex As Exception
                End Try
                rw.Cells(1).Value = normalSRP - Math.Round(normalSRP * disc, 2, MidpointRounding.AwayFromZero)
                rw.Cells(7).Value = x + "% Discount"
            Next
        End If
        refreshgrid()
    End Sub

    Private Sub otcnorm_CheckedChanged(sender As Object, e As EventArgs) Handles otcnorm.CheckedChanged

    End Sub

    Private Sub ApplyMarkupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyMarkupToolStripMenuItem.Click
        Dim x As String = InputBox("Mark UP:", "Enter Mark UP Percentage (%)")
        Dim disc As Decimal
        If IsNumeric(x) Then
            disc = x / 100
            Dim normalSRP As Decimal = 0
            For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
                Try
                    normalSRP = rw.Cells(5).Value
                Catch ex As Exception
                End Try
                rw.Cells(1).Value = normalSRP + Math.Round(normalSRP * disc, 2, MidpointRounding.AwayFromZero)
                rw.Cells(7).Value = x + "% Mark UP"
            Next
        End If
        refreshgrid()
    End Sub

    Private Sub NormalRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalRateToolStripMenuItem.Click
        Dim normalSRP As Decimal = 0
        For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
            Try
                normalSRP = rw.Cells(5).Value
            Catch ex As Exception
            End Try
            rw.Cells(1).Value = normalSRP
            rw.Cells(7).Value = ""
        Next
        refreshgrid()
    End Sub

    Private Sub PurchasesDataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PurchasesDataGridView1.RowsRemoved
        Me.InventoryDataset.Purchases.AcceptChanges()
        Me.grandlabel.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        subtotaltxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
        totalpaymenttxt.Text = Me.InventoryDataset.Purchases.total.ToString("N")
    End Sub

    Private Sub ApplyPesoValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyPesoValueToolStripMenuItem.Click

        Dim vv As String = "0"
        Try
            vv = InputBox("Enter Custom SRP:", "Suggested Retail Price")
            If IsNumeric(vv) Then
            Else
                MsgBox("Invalid Price", vbOKOnly, "Message")
            End If

        Catch ex As Exception
        End Try
        For Each rw As DataGridViewRow In Me.PurchasesDataGridView1.SelectedRows
            rw.Cells(1).Value = CType(vv, Decimal)
            rw.Cells(7).Value = "Custom Peso"

        Next
        refreshgrid()
    End Sub

    Private Sub PurchasesDataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PurchasesDataGridView1.CellMouseUp
        If PurchasesDataGridView1.SelectedRows.Count = 0 Then
            discountM.Items(0).Enabled = False
            discountM.Items(1).Enabled = False
            discountM.Items(2).Enabled = False
            discountM.Items(3).Enabled = False
            discountM.Items(4).Enabled = False
            discountM.Items(5).Enabled = False
        Else
            discountM.Items(0).Enabled = True
            discountM.Items(1).Enabled = True
            discountM.Items(2).Enabled = True
            discountM.Items(3).Enabled = True
            discountM.Items(4).Enabled = True
            discountM.Items(5).Enabled = True
        End If
    End Sub

    Private Sub Searchbox_QueryAccessibilityHelp(sender As Object, e As QueryAccessibilityHelpEventArgs) Handles Searchbox.QueryAccessibilityHelp

    End Sub
End Class
