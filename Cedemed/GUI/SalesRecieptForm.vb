﻿Imports System.Data.SqlClient
Public Class SalesRecieptForm
    Public total, discount As Decimal
    Public customer As String
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)

    Private Sub TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)

    End Sub

    Private Sub SalesRecieptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransactionsDataset.Sales' table. You can move, or remove it, as needed.
        'Me.SalesTableAdapter.Fill(Me.TransactionsDataset.Sales)
        'TODO: This line of code loads data into the 'TransactionsDataset.Trans' table. You can move, or remove it, as needed.
        'Me.TransTableAdapter.Fill(Me.TransactionsDataset.Trans)
        'MsgBox("Total before processing " + total.ToString)
        Dim rw As DataRow
        rw = Me.TransactionsDataset.Trans.NewRow
        rw("TransDate") = Now.Date
        rw("Total") = total
        rw("Discount") = discount
        rw("SoldBy") = user
        rw("PayMode") = "CASH"
        rw("CustName") = customer
        rw("ref") = 1
        rw("serverdate") = Now
        'MsgBox("total after assigning " + rw("Total").ToString)

        Me.TransactionsDataset.Trans.Rows.Add(rw)
        'MsgBox("Total after added to the row " + Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("Total").ToString)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)
        Me.TransBindingSource.Position = 0
        'MsgBox("total after after saving " + Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("Total").ToString)
        For x = 0 To salesform.InventoryDataset.Purchases.Rows.Count - 1
            rw = Me.TransactionsDataset.Sales.NewRow
            rw("TransNo") = Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo")
            rw("SalesDT") = Me.TransDateDateTimePicker.Value.ToShortDateString
            rw("ItemNo") = salesform.InventoryDataset.Purchases.Item(x).Item("ItemNo")
            rw("Ucost") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("Cost"), Decimal)
            rw("SRP") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("SRP"), Decimal)
            rw("Ncost") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("NCost"), Decimal)
            rw("UnitSold") = salesform.InventoryDataset.Purchases.Item(x).Item("Qty")
            rw("PS") = 0
            rw("expiry") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("Expiry"), Date)
            rw("lotno") = salesform.InventoryDataset.Purchases.Item(x).Item("LotNo")
            Me.TransactionsDataset.Sales.Rows.Add(rw)
        Next

        Me.TransBindingSource.EndEdit()
        Me.SalesBindingSource.EndEdit()
        Me.SalesTableAdapter.Update(Me.TransactionsDataset.Sales)
        Me.TransTableAdapter.Update(Me.TransactionsDataset)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TransBindingSource.RemoveCurrent()
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
recheck:
        If Me.TransactionsDataset.Sales.Rows.Count = 0 Then
            Dim xx As String = MsgBox("Unable to retrieve items from Sales Form. Do you want to retry retrieving?", vbYesNo, "Confirmation")
            If xx = vbYes Then
                Try
                    Dim rw As DataRow
                    For x = 0 To salesform.InventoryDataset.Purchases.Rows.Count - 1
                        rw = Me.TransactionsDataset.Sales.NewRow
                        rw("TransNo") = Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo")
                        rw("SalesDT") = Me.TransDateDateTimePicker.Value.ToShortDateString
                        rw("ItemNo") = salesform.InventoryDataset.Purchases.Item(x).Item("ItemNo")
                        rw("Ucost") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("Cost"), Decimal)
                        rw("SRP") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("SRP"), Decimal)
                        rw("Ncost") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("NCost"), Decimal)
                        rw("UnitSold") = salesform.InventoryDataset.Purchases.Item(x).Item("Qty")
                        rw("PS") = 0
                        rw("expiry") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("Expiry"), Date)
                        rw("lotno") = salesform.InventoryDataset.Purchases.Item(x).Item("LotNo")
                        Me.TransactionsDataset.Sales.Rows.Add(rw)
                    Next
                    GoTo recheck
                Catch ex As Exception
                    MsgBox("Error retrieving items from sales form. Consider cancelling the transaction by clicking on the Cancel Button and write down the reference no." + vbCrLf + ex.Message, vbOKOnly, "Message")
                    Exit Sub
                End Try
            Else
                MsgBox("Posting Cancelled", vbOKOnly, "Message")
                Exit Sub
            End If
        End If

recheck2:
        If salesform.InventoryDataset.Purchases.Rows.Count = Me.TransactionsDataset.Sales.Count Then
        Else
            Dim xx As String = MsgBox("Item mismatch from Sales Form. Do you want to retry retrieving?", vbYesNo, "Confirmation")
            If xx = vbYes Then
                Me.TransactionsDataset.Sales.Clear()
                Try
                    Dim rw As DataRow
                    For x = 0 To salesform.InventoryDataset.Purchases.Rows.Count - 1
                        rw = Me.TransactionsDataset.Sales.NewRow
                        rw("TransNo") = Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo")
                        rw("SalesDT") = Me.TransDateDateTimePicker.Value.ToShortDateString
                        rw("ItemNo") = salesform.InventoryDataset.Purchases.Item(x).Item("ItemNo")
                        rw("Ucost") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("Cost"), Decimal)
                        rw("SRP") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("SRP"), Decimal)
                        rw("Ncost") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("NCost"), Decimal)
                        rw("UnitSold") = salesform.InventoryDataset.Purchases.Item(x).Item("Qty")
                        rw("PS") = 0
                        rw("expiry") = CType(salesform.InventoryDataset.Purchases.Item(x).Item("Expiry"), Date)
                        rw("lotno") = salesform.InventoryDataset.Purchases.Item(x).Item("LotNo")
                        Me.TransactionsDataset.Sales.Rows.Add(rw)
                    Next
                    GoTo recheck2
                Catch ex As Exception
                    MsgBox("Error retrieving items from sales form. Consider cancelling the transaction by clicking on the Cancel Button and write down the reference no." + vbCrLf + ex.Message, vbOKOnly, "Message")
                    Exit Sub
                End Try
            Else
                MsgBox("Posting Cancelled", vbOKOnly, "Message")
                Exit Sub
            End If
        End If

        For Each rw As DataRow In Me.TransactionsDataset.Sales.Rows
            If rw("TransNo") = Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo") Then
            Else
                MsgBox("Posting Cancelled. Some items has invalid Data. Consider cancelling the transaction by clicking on the Cancel Button and write down the reference no.", vbOKOnly, "Message")
                Exit Sub
            End If
        Next


        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)
        Dim com As New SqlCommand
        com = New SqlCommand("Insert into Process (TransNo,status,error) values (" + Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo").ToString + ",1,0)", conn)
        conn.Open()
        com.ExecuteReader()
        conn.Close()
        Dim frm As New Posting
        frm.transno = Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo")
        frm.Show()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs) Handles RadioButton1.Click
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "CASH"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "CHECK"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As System.EventArgs) Handles RadioButton3.Click
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "CHARGE"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As System.EventArgs) Handles RadioButton4.Click
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "GOVT"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub
End Class