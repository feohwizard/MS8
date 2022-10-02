Imports System.Data.SqlClient
Public Class Parser
    Dim trans As SqlTransaction
    Dim work As Boolean = True
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Dim dap As New SqlDataAdapter
    Dim sett As New DataSet
    Dim comm As New SqlCommand
    Dim dapp As New SqlDataAdapter
    Dim set2 As New DataSet

    Private Sub process()
        


    End Sub


    Private Sub time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.Tick
        
    End Sub

    Private Sub TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)

    End Sub

    Private Sub Parser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork
        Do
            process()
        Loop
    End Sub
End Class