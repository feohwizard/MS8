Imports System.Data.SqlClient
Public Class StockTransferPosting
    Public total, discount As Decimal
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Public branch As String = ""
    Private Sub TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)

    End Sub

    Private Sub SalesRecieptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.sendbranch.Text = "Send to: " + branch
        Dim rw As DataRow
        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        For x = 0 To transferfrm.InventoryDataset.Purchases.Rows.Count - 1
            rw = Me.TransactionsDataset.Tranferre.NewRow
            rw("Description") = transferfrm.InventoryDataset.Purchases.Item(x).Item("ItemNo")
            rw("Quantity") = transferfrm.InventoryDataset.Purchases.Item(x).Item("Qty")
            rw("Expiry") = CType(transferfrm.InventoryDataset.Purchases.Item(x).Item("Expiry"), Date)
            rw("Lotno") = transferfrm.InventoryDataset.Purchases.Item(x).Item("LotNo")
            rw("invoice") = transferfrm.InventoryDataset.Purchases.Item(x).Item("invoice")
            rw("SRP") = transferfrm.InventoryDataset.Purchases.Item(x).Item("NCost")
            rw("Cost") = transferfrm.InventoryDataset.Purchases.Item(x).Item("Cost")
            Me.TransactionsDataset.Tranferre.Rows.Add(rw)
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TransBindingSource.RemoveCurrent()
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'The prcoess is done similar to the process of Sales Module
        'Unlocking code is encoded by the user and will be required upon claiming in the destination branch
        'status is initially have zero value
        'A new record will be inserted into the 'Recev' table in the destination branch, containing the information of branches involved as well as the user
        'Upon insertion, an ID will be generated from the destination's Recev table
        'Items will be inserted into the destination's 'RecevItems' table with transaction ID value equal to the ID generated from the previous process.
        '

        Dim connstring As String = ""
        MsgBox("Warning: This is a long process. Please do not close this window. When the process is done it will automatically close.")
        If branch = "Main" Then
            connstring = My.Settings.MainBranch
        ElseIf branch = "Tanedo" Then
            connstring = My.Settings.Branch1
        ElseIf branch = "San Vicente" Then
            connstring = My.Settings.Branch2
        End If
        Dim tconn As New SqlConnection(connstring)

        Dim com As New SqlCommand("Insert into Recev (unlockcode,status,transactionuser,frombranch,tobranch) values ('" + TextBox1.Text + "',0,'" + user + "','" + branchname + "','" + branch + "') select scope_identity()", tconn)
        Dim transId As Integer = -1
        tconn.Open()
        transId = Integer.Parse(com.ExecuteScalar.ToString())
        tconn.Close()

        Dim items As String = ""
        For x As Integer = 0 To Me.TransactionsDataset.Tranferre.DefaultView.Count - 1
            items = items + "Insert into RecevItems (transid, ItemNo, Qty, Expiry, lotno,SRP,Cost) values (" + transId.ToString + "," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Description").ToString + "," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Quantity").ToString + ",'" + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Expiry").ToString + "','" + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("lotno").ToString + "'," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("SRP").ToString + "," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Cost").ToString + ");"
        Next

        com = New SqlCommand(items, tconn)
        tconn.Open()
        com.ExecuteNonQuery()
        tconn.Close()

        'Process No.2
        'The System will create a record into the Transfer table similar to the record that was inserted into the Recev table in the destination branch.
        'After inserting new record a new ID will be generated in the Origin branch
        'The new ID will be inserted the Recev table of the destination branch and serve as 'Commontransaction ID'


        com = New SqlCommand("Insert into Transfer (unlockcode,status,transactionuser,frombranch,tobranch,parsed,success) values ('" + TextBox1.Text + "',0,'" + user + "','" + branchname + "','" + branch + "',0,'Successful') select scope_identity()", conn)
        Dim transId2 As Integer = -1
        conn.Open()
        transId2 = Integer.Parse(com.ExecuteScalar.ToString())
        conn.Close()

        items = ""
        For x As Integer = 0 To Me.TransactionsDataset.Tranferre.DefaultView.Count - 1
            items = items + "Insert into TranferItems (transid, ItemNo, Qty, Expiry, lotno,SRP,Cost) values (" + transId2.ToString + "," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Description").ToString + "," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Quantity").ToString + ",'" + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Expiry").ToString + "','" + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("lotno").ToString + "'," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("SRP").ToString + "," + Me.TransactionsDataset.Tranferre.DefaultView.Item(x).Item("Cost").ToString + ");"
        Next

        com = New SqlCommand(items, conn)
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()

        com = New SqlCommand("Update Recev set commontrans=" + transId2.ToString + " where transid=" + transId.ToString, tconn)
        tconn.Open()
        com.ExecuteNonQuery()
        tconn.Close()

        TextBox1.Text = transId2.ToString
        MsgBox("Transfer Complete")
        transferfrm.InventoryDataset.Purchases.Rows.Clear()
        transferfrm.ItemsTableAdapter.Fill(transferfrm.InventoryDataset.Items)
        MsgBox("Transfer Compelete. Please Take down your Reference Number: " + transId2.ToString)
        Me.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs)
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "CASH"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs)
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "CHECK"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As System.EventArgs)
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "CHARGE"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As System.EventArgs)
        Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("PayMode") = "GOVT"
        Me.TransBindingSource.EndEdit()
        Me.TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub
End Class