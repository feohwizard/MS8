Public Class UnclaimStocks

    Private Sub UnclaimStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RecevTableAdapter.FillByNull(Me.ReceiveDataset.Recev)
    End Sub

   
End Class