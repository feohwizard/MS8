Public Class EditUserModule


    Public Sub UserInfo(ByVal UserID As String)
        UsersRTA.FillByUserID(RistrictionDS.UsersRestriction, UserID)
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If LNameTextBox.Text.Trim = "" Then
            MsgBox("Please Enter your Last Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            LNameTextBox.Focus()


        ElseIf FNameTextBox.Text.Trim = "" Then
            MsgBox("Please Enter your First Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            FNameTextBox.Focus()

        ElseIf UsernameTextBox.Text.Trim = "" Then
            MsgBox("Please Enter your User Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            UsernameTextBox.Focus()

        ElseIf PasswordTextBox.Text.Trim = "" Then
            MsgBox("Please Enter your First Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            PasswordTextBox.Focus()
        ElseIf PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MsgBox("Password Did not Match its Confirmation", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            ConfirmPasswordTextBox.Focus()

        ElseIf UserLevelComboBox.Text.Trim = "" Then
            MsgBox("Please Enter your User Level", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            UserLevelComboBox.Focus()
        Else
            Try

                Dim UserDS As New RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter

                BS.EndEdit()
                UserDS.Update(RistrictionDS.UsersRestriction)


                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            End Try
 End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub UserLevelComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles UserLevelComboBox.SelectedIndexChanged
       
    End Sub

    Private Sub UserLevelComboBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles UserLevelComboBox.SelectedValueChanged
        If Me.UserLevelComboBox.Text = "Administrator" Then
            Me.AdminCheckBox.Checked = True
            Me.MFileCheckBox.Checked = True
            Me.MaintenanceCheckBox.Checked = True
            Me.InventoryCheckBox.Checked = True
            Me.MISRPTCheckBox.Checked = True
            Me.CustSaleRPTCheckBox.Checked = True
            Me.StocktranCheckBox.Checked = True
        End If
        If Me.UserLevelComboBox.Text = "Cashier" Then
            Me.AdminCheckBox.Checked = False
            Me.MFileCheckBox.Checked = True
            Me.MaintenanceCheckBox.Checked = False
            Me.InventoryCheckBox.Checked = True
            Me.MISRPTCheckBox.Checked = False
            Me.CustSaleRPTCheckBox.Checked = True
            Me.StocktranCheckBox.Checked = True
        End If

        If Me.UserLevelComboBox.Text = "User" Then
            Me.AdminCheckBox.Checked = False
            Me.MFileCheckBox.Checked = False
            Me.MaintenanceCheckBox.Checked = True
            Me.InventoryCheckBox.Checked = True
            Me.MISRPTCheckBox.Checked = True
            Me.CustSaleRPTCheckBox.Checked = True
            Me.StocktranCheckBox.Checked = True
        End If
    End Sub
End Class