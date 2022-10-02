Imports System.Data.SqlClient
Public Class ItemFix
    Dim conn As New SqlConnection(My.Settings.MainBranch)
    Private Sub ItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ItemFixDS)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ItemFix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItemFixDS.ItemsMain' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ItemsMainTableAdapter.Fill(Me.ItemFixDS.ItemsMain, TextBox1.Text)
        Me.ItemsTableAdapter.Fill(Me.ItemFixDS.Items, TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim com As SqlCommand

        For Each rw As DataGridViewRow In ItemsDataGridView.SelectedRows
            Dim itemno As Integer = InputBox("Enter ItemNo", "Input")
            com = New SqlCommand("UPDATE Sales SET ItemNo=" + itemno.ToString + " WHERE ItemNo=" + rw.Cells(0).Value.ToString + ";UPDATE Purchases SET ItemNo=" + itemno.ToString + " WHERE ItemNo=" + rw.Cells(0).Value.ToString + ";UPDATE TranferItems SET ItemNo=" + itemno.ToString + " WHERE ItemNo=" + rw.Cells(0).Value.ToString, conn)
            Try
                conn.Open()
            Catch ex As Exception
                conn.Close()
                conn.Open()
            End Try
            com.ExecuteNonQuery()
            conn.Close()
            Me.ItemsTableAdapter.Fill(Me.ItemFixDS.Items, TextBox1.Text)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim com As SqlCommand

        For Each rw As DataGridViewRow In ItemsDataGridView.SelectedRows
            com = New SqlCommand("DELETE FROM Items WHERE ItemNo=" + rw.Cells(0).Value.ToString + "; DELETE FROM Inv WHERE ItemNo=" + rw.Cells(0).Value.ToString, conn)
            Try
                conn.Open()
            Catch ex As Exception
                conn.Close()
                conn.Open()
            End Try
            com.ExecuteNonQuery()
            conn.Close()
            Me.ItemsTableAdapter.Fill(Me.ItemFixDS.Items, TextBox1.Text)
        Next
    End Sub
End Class