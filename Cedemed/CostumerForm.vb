Public Class CostumerForm
    Public srchmode As Boolean = False
    Public frm As Sales
    Private Sub CostumertblBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostumertblBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CostumertblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CostumerDataset)

    End Sub

    Private Sub CostumerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CostumertblTableAdapter.Fill(Me.CostumerDataset.Costumertbl)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            If srchmode = True Then
                If Me.CostumerDataset.Costumertbl.DefaultView.Count = 0 Then
                Else
                    frm.id = Me.CostumerDataset.Costumertbl.DefaultView.Item(0).Item("idno")
                    frm.assigncustomer()
                    Me.Close()
                End If
            Else
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.CostumertblTableAdapter.Fill(Me.CostumerDataset.Costumertbl)
        Else
            Me.CostumertblTableAdapter.FillByName(Me.CostumerDataset.Costumertbl, TextBox1.Text)
        End If
    End Sub

    Private Sub CostumertblDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CostumertblDataGridView.CellContentClick

    End Sub

    Private Sub CostumertblDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CostumertblDataGridView.CellEnter
        SendKeys.Send("{F2}")
    End Sub

    Private Sub CostumertblDataGridView_RowHeaderMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CostumertblDataGridView.RowHeaderMouseDoubleClick

        If srchmode = True Then
            If Me.CostumerDataset.Costumertbl.DefaultView.Count = 0 Then
            Else
                Try
                    frm.id = Me.CostumerDataset.Costumertbl.DefaultView.Item(Me.CostumertblDataGridView.CurrentRow.Index).Item("idno")
                    frm.assigncustomer()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Select Row")
                End Try

            End If
        Else
        End If
    End Sub
End Class