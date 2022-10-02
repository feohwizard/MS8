Public Class userpassModule

    Private Sub UsersRestrictionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.UsersRestrictionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RistrictionDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.UsersRestrictionTableAdapter.Fill(Me.RistrictionDataSet.UsersRestriction)

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.UsersRestrictionTableAdapter.FillByUsername(Me.RistrictionDataSet.UsersRestriction, Me.TextBox1.Text)
    End Sub

    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        Dim addnewuser As New AddnewuserModule
        If addnewuser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.UsersRestrictionTableAdapter.Fill(Me.RistrictionDataSet.UsersRestriction)
        End If

    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click
        If URDGV.RowCount = 0 Then
            Exit Sub
        End If

        Dim UserID = URDGV.SelectedRows(0).Cells(0).Value

        Dim EdetUsers As New EditUserModule

        EdetUsers.UserInfo(UserID)

        If EdetUsers.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.UsersRestrictionTableAdapter.Fill(Me.RistrictionDataSet.UsersRestriction)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click


        If URDGV.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim UserID As String = URDGV.SelectedRows(0).Cells(0).Value

        Try

            UsersRestrictionTableAdapter.DeleteUserID(UserID)
            Me.UsersRestrictionTableAdapter.Fill(Me.RistrictionDataSet.UsersRestriction)
        Catch ex As Exception

        End Try

    End Sub
End Class