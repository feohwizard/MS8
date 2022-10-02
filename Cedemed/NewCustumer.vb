Public Class NewCustumer
    Public frm As Sales
    Private Sub CostumertblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CostumertblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustumerTable)

    End Sub

    Private Sub NewCustumer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustumerTable.Costumertbl' table. You can move, or remove it, as needed.
        'Me.CostumertblTableAdapter.Fill(Me.CustumerTable.Costumertbl)
        Dim dr As DataRow
        dr = Me.CustumerTable.Costumertbl.NewRow
        dr("otcdiscount") = 0
        dr("genericdiscount") = 0
        dr("otcmarkup") = 0
        dr("genericmarkup") = 0
        Me.CustumerTable.Costumertbl.Rows.Add(dr)
        Me.NameTextBox.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.CostumertblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustumerTable)
        frm.id = Me.CustumerTable.Costumertbl.DefaultView.Item(0).Item("idno")
        frm.assigncustomer()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class