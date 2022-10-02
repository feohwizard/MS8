Partial Class InventoryDataset
    Partial Class PurchasesDataTable
        Public total As Decimal = 0

        Private Sub PurchasesDataTable_PurchasesRowDeleted(ByVal sender As Object, ByVal e As PurchasesRowChangeEvent) Handles Me.PurchasesRowDeleted
            Try
                total = Me.Compute("Sum (Amount)", "")
            Catch ex As Exception
                total = 0
            End Try
        End Sub
        Private Sub PurchasesDataTable_RowChanged(sender As Object, e As System.Data.DataRowChangeEventArgs) Handles Me.RowChanged
            Try
                total = Me.Compute("Sum (Amount)", "")
            Catch ex As Exception
                total = 0
            End Try
        End Sub

        Private Sub PurchasesDataTable_PurchasesRowChanging(sender As System.Object, e As PurchasesRowChangeEvent) Handles Me.PurchasesRowChanging
            Try
                total = Me.Compute("Sum (Amount)", "")
            Catch ex As Exception
                total = 0
            End Try
        End Sub


        Private Sub PurchasesDataTable_RowChanging(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles Me.RowChanging
            Try
                total = Me.Compute("Sum (Amount)", "")
            Catch ex As Exception
                total = 0
            End Try
        End Sub
    End Class

End Class
