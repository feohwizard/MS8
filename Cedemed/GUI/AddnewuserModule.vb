Public Class AddnewuserModule

    Private Sub UsersRestrictionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.UsersRestrictionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RistrictionDataSet)

    End Sub


    Private Sub UsersRestrictionBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.UsersRestrictionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RistrictionDataSet)

    End Sub

    Private Sub AddnewuserModule_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RistrictionDataSet.UsersRestriction' table. You can move, or remove it, as needed.
        Me.UsersRestrictionTableAdapter.Fill(Me.RistrictionDataSet.UsersRestriction)

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

            

            Dim AdminCheck As Boolean = Me.AdminCheckBox.Checked
            Dim MfileCheck As Boolean = Me.MFileCheckBox.Checked
            Dim MaintenanceCheck As Boolean = Me.MaintenanceCheckBox.Checked
            Dim InvenroyChech As Boolean = Me.InventoryCheckBox.Checked
            Dim MISRPTChech As Boolean = Me.MISRPTCheckBox.Checked
            Dim CustSalesCheck As Boolean = Me.CustSaleRPTCheckBox.Checked
            Dim StocktranCheck As Boolean = Me.StocktranCheckBox.Checked

            Dim UserDS As New RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter


            UserDS.Insert(FNameTextBox.Text, LNameTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text, UserLevelComboBox.Text, AdminCheck, MfileCheck, MaintenanceCheck, InvenroyChech, MISRPTChech, CustSalesCheck, StocktranCheck)
            Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
            End Try

End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
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