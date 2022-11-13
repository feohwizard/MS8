Imports System.Data.SqlClient

Public Class Claim
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Private Sub RecevBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RecevBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReceiveDataset)

    End Sub

    Private Sub Claim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceiveDataset.Claimable' table. You can move, or remove it, as needed.
        Me.ClaimableTableAdapter.Fill(Me.ReceiveDataset.Claimable)
        If Me.ReceiveDataset.Claimable.Rows.Count = 0 Then
        Else
            For Each rw As DataRow In Me.ReceiveDataset.Claimable.Rows
                Textbox1.Items.Add(rw("commontrans").ToString)
            Next
        End If

        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.RecevTableAdapter.FillByCode1(Me.ReceiveDataset.Recev, TextBox1.Text)
        If Me.ReceiveDataset.Recev.DefaultView.Count = 0 Then
            MsgBox("The code you entered was invalid or it is already claimed.")
            Exit Sub
        Else
            Me.RecevItemsTableAdapter.Fill(Me.ReceiveDataset.RecevItems, Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("transid"))
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '---
        Dim com As New SqlCommand
        For z As Integer = 0 To Me.ReceiveDataset.RecevItems.DefaultView.Count - 1
            With Me.ReceiveDataset.RecevItems.DefaultView.Item(z)
                'add items to purchases and update its inventory

                Dim xpire As New SqlParameter("@xpire", SqlDbType.Date)
                xpire.Value = DateValue(CType(.Item("Expiry"), Date))
                Dim dt As New SqlParameter("@dt", SqlDbType.Date)
                dt.Value = DateValue(Now)

                If recorded_in_purchases(Val(Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("commontrans").ToString), Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("frombranch").ToString, Val(.Item("ItemNo")), Val(.Item("Qty")), xpire.Value, .Item("lotno").ToString) = True Then
                    GoTo dontinsert
                End If
Inserttopurchases:

                Try
                    com = New SqlCommand("Insert into Purchases(RecvDT,MRRNo,Supplier,ItemNo,Qty,Expiry,encoder,commontrans) values (@dt,'" + .Item("lotno").ToString + "','" + Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("frombranch").ToString + "'," + Val(.Item("ItemNo")).ToString + "," + Val(.Item("Qty")).ToString + ",@xpire,'" + user + "', " + Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("commontrans").ToString + ")", conn)
                    com.Parameters.Add(dt)
                    com.Parameters.Add(xpire)
                    conn.Open()
                    com.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                End Try
                If recorded_in_purchases(Val(Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("commontrans").ToString), Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("frombranch").ToString, Val(.Item("ItemNo")), Val(.Item("Qty")), xpire.Value, .Item("lotno").ToString) = True Then
                Else
                    GoTo Inserttopurchases
                End If
dontinsert:
            End With
        Next
        com = New SqlCommand("update Recev set status=1,parsed=1,success='Successful' where transid=" + Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("transid").ToString, conn)
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()

        MsgBox("Claim Successful! Inventory was added.")
        Me.Close()
    End Sub

    Private Function recorded_in_purchases(common As Integer, supplier As String, itemno As Integer, qty As Integer, xpire As Date, lotno As String) As Boolean
        Dim adap As New SqlDataAdapter("SELECT ItemNo from Purchases WHERE commontrans=" + common.ToString + " AND supplier='" + supplier + "' AND ItemNo=" + itemno.ToString + " AND Qty=" + qty.ToString + " AND YEAR(Expiry)=" + xpire.Year.ToString + " AND MONTH(Expiry)=" + xpire.Month.ToString + " AND DAY(Expiry)=" + xpire.Day.ToString + " AND MRRNo='" + lotno + "'", conn)
        Dim dbset As New DataSet
        dbset.Clear()
        adap.Fill(dbset, "a")
        If dbset.Tables("a").Rows.Count >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.RecevTableAdapter.FillByCode(Me.ReceiveDataset.Recev, TextBox1.Text)
        If Me.ReceiveDataset.Recev.DefaultView.Count = 0 Then
            MsgBox("The code you entered was invalid.")
            Exit Sub
        Else
            Me.RecevItemsTableAdapter.Fill(Me.ReceiveDataset.RecevItems, Me.ReceiveDataset.Recev.DefaultView.Item(0).Item("transid"))
            Button2.Enabled = True
        End If
    End Sub
End Class