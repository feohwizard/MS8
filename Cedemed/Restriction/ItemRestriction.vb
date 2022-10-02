Public Class ItemRestriction
    Private Sub ItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RestrictionDS)
        MsgBox("Updated")
    End Sub

    Private Sub ItemRestriction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ItemsTableAdapter.Fill(Me.RestrictionDS.Items)

    End Sub


End Class