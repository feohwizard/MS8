Imports System.Data.SqlClient
Public Class Lock
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Private Sub Lock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HoldTableAdapter.Fill(Me.LockDS.Hold)
        If Me.LockDS.Hold.Rows(0).Item("hold") = False Then
            Button1.Enabled = True
            Button2.Enabled = False
        Else
            Button1.Enabled = False
            Button2.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String = MsgBox("Are you sure want to lock the inventory?", vbYesNo, "Confirmation")
        If x = vbYes Then
            Me.LockDS.Hold.Rows(0).Item("hold") = True
            Validate()
            LockBS.EndEdit()
            HoldTableAdapter.Update(LockDS.Hold)
            MsgBox("Inventory successfully locked.")
            Button1.Enabled = False
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As String = MsgBox("Are you sure want to unlock the inventory?", vbYesNo, "Confirmation")
        If x = vbYes Then
            Me.LockDS.Hold.Rows(0).Item("hold") = False

            Dim com As New SqlCommand("UPDATE Sales set hold=0;UPDATE TranferItems set hold=0;UPDATE Purchases set hold=0;", conn)
            Try
                conn.Open()
            Catch ex As Exception
                conn.Close()
                conn.Open()
            End Try

            com.ExecuteNonQuery()
            conn.Close()

            Validate()
            LockBS.EndEdit()
            HoldTableAdapter.Update(LockDS.Hold)
            MsgBox("Inventory successfully unlocked.")
            Button1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub
End Class