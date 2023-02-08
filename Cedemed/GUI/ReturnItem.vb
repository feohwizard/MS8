Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Public Class ReturnItem
    Public sale As Sales
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Public reprint As Boolean = False
    Public transno As Integer
    Private Sub TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        retrieve()
    End Sub

    Public Sub retrieve()
        If Me.ItemsDataset.Items.DefaultView.Count = 0 Then
            Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        End If
        Me.TransactionsDataset.EnforceConstraints = False
        Me.TransTableAdapter.FillByTrans(Me.TransactionsDataset.Trans, TransNoTextBox.Text)
        Me.SalesTableAdapter.FillByTrans(Me.TransactionsDataset.Sales, TransNoTextBox.Text)
        Me.TransactionsDataset.EnforceConstraints = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim com As New SqlCommand
        Dim total As Decimal = 0
        For x As Integer = 0 To Me.TransactionsDataset.Sales.DefaultView.Count - 1
            With Me.TransactionsDataset.Sales.DefaultView.Item(x)
                If Val(.Item("returntotal")) = 0 Then
                Else
                    If Val(.Item("UnitSold")) < Val(.Item("returntotal")) Then
                        MsgBox("Invalid Values.")
                        Exit Sub
                    End If
                End If
            End With
        Next

        For x As Integer = 0 To Me.TransactionsDataset.Sales.DefaultView.Count - 1
            With Me.TransactionsDataset.Sales.DefaultView.Item(x)
                total = total + (CType(.Item("SRP"), Decimal) * (Val(.Item("UnitSold") - Val(.Item("returntotal")))))
                If Val(.Item("returntotal")) = 0 Then
                Else
                    com = New SqlCommand("Insert Into Returns (transno,itemno,quantity,users) values (" + TransNoTextBox.Text + "," + .Item("ItemNo").ToString + "," + Val(.Item("returntotal")).ToString + ",'" + user + "')", conn)
                    conn.Open()
                    com.ExecuteNonQuery()
                    conn.Close()
                    .Item("UnitSold") = Val(.Item("UnitSold")) - Val(.Item("returntotal"))
                    .Item("returntotal") = 0
                End If
            End With
        Next
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.SalesTableAdapter.Update(Me.TransactionsDataset.Sales)


        com = New SqlCommand("UPDATE Trans SET Total=" + total.ToString + " WHERE TransNo=" + Me.TransactionsDataset.Trans.DefaultView.Item(0).Item("TransNo").ToString, conn)
        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            conn.Open()
        End Try
        com.ExecuteNonQuery()
        conn.Close()

        MsgBox("Transaction Completed")
        retrieve()
        sale.Searchbox.Text = " "
        sale.Searchbox.Text = ""

    End Sub

    Private Sub SalesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalesDataGridView.CellContentClick

    End Sub

    Private Sub SalesDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalesDataGridView.CellEnter
        SendKeys.Send("{F2}")
        SendKeys.Send("^A")
    End Sub

    Private Sub ReturnItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class