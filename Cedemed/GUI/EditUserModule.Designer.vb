<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUserModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FNameLabel As System.Windows.Forms.Label
        Dim UserLevelLabel As System.Windows.Forms.Label
        Dim LNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUserModule))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaintenanceCheckBox = New System.Windows.Forms.CheckBox()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.RistrictionDS = New Cedemed.RistrictionDataSet()
        Me.StocktranCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustSaleRPTCheckBox = New System.Windows.Forms.CheckBox()
        Me.MFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.MISRPTCheckBox = New System.Windows.Forms.CheckBox()
        Me.InventoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsersRTA = New Cedemed.RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter()
        Me.TAM = New Cedemed.StockDatasetTableAdapters.TableAdapterManager()
        FNameLabel = New System.Windows.Forms.Label()
        UserLevelLabel = New System.Windows.Forms.Label()
        LNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RistrictionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FNameLabel
        '
        FNameLabel.AutoSize = True
        FNameLabel.Location = New System.Drawing.Point(24, 31)
        FNameLabel.Name = "FNameLabel"
        FNameLabel.Size = New System.Drawing.Size(60, 13)
        FNameLabel.TabIndex = 1
        FNameLabel.Text = "First Name:"
        '
        'UserLevelLabel
        '
        UserLevelLabel.AutoSize = True
        UserLevelLabel.Location = New System.Drawing.Point(24, 166)
        UserLevelLabel.Name = "UserLevelLabel"
        UserLevelLabel.Size = New System.Drawing.Size(61, 13)
        UserLevelLabel.TabIndex = 9
        UserLevelLabel.Text = "User Level:"
        '
        'LNameLabel
        '
        LNameLabel.AutoSize = True
        LNameLabel.Location = New System.Drawing.Point(24, 57)
        LNameLabel.Name = "LNameLabel"
        LNameLabel.Size = New System.Drawing.Size(61, 13)
        LNameLabel.TabIndex = 3
        LNameLabel.Text = "Last Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(24, 110)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(24, 83)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 5
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(24, 140)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(94, 13)
        PasswordLabel1.TabIndex = 11
        PasswordLabel1.Text = "Confirm Password:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(471, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 226)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control Button"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.MaintenanceCheckBox)
        Me.GroupBox2.Controls.Add(Me.StocktranCheckBox)
        Me.GroupBox2.Controls.Add(Me.AdminCheckBox)
        Me.GroupBox2.Controls.Add(Me.CustSaleRPTCheckBox)
        Me.GroupBox2.Controls.Add(Me.MFileCheckBox)
        Me.GroupBox2.Controls.Add(Me.MISRPTCheckBox)
        Me.GroupBox2.Controls.Add(Me.InventoryCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 226)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Ristrictions"
        '
        'MaintenanceCheckBox
        '
        Me.MaintenanceCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "Maintenance", True))
        Me.MaintenanceCheckBox.Location = New System.Drawing.Point(32, 76)
        Me.MaintenanceCheckBox.Name = "MaintenanceCheckBox"
        Me.MaintenanceCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.MaintenanceCheckBox.TabIndex = 9
        Me.MaintenanceCheckBox.Text = "Maintenance"
        Me.MaintenanceCheckBox.UseVisualStyleBackColor = True
        '
        'BS
        '
        Me.BS.DataMember = "UsersRestriction"
        Me.BS.DataSource = Me.RistrictionDS
        '
        'RistrictionDS
        '
        Me.RistrictionDS.DataSetName = "RistrictionDataSet"
        Me.RistrictionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocktranCheckBox
        '
        Me.StocktranCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "Stocktran", True))
        Me.StocktranCheckBox.Location = New System.Drawing.Point(32, 196)
        Me.StocktranCheckBox.Name = "StocktranCheckBox"
        Me.StocktranCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.StocktranCheckBox.TabIndex = 13
        Me.StocktranCheckBox.Text = "Stock Transfers"
        Me.StocktranCheckBox.UseVisualStyleBackColor = True
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "Admin", True))
        Me.AdminCheckBox.Location = New System.Drawing.Point(32, 16)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.AdminCheckBox.TabIndex = 7
        Me.AdminCheckBox.Text = "Administrator"
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'CustSaleRPTCheckBox
        '
        Me.CustSaleRPTCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "CustSaleRPT", True))
        Me.CustSaleRPTCheckBox.Location = New System.Drawing.Point(32, 166)
        Me.CustSaleRPTCheckBox.Name = "CustSaleRPTCheckBox"
        Me.CustSaleRPTCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.CustSaleRPTCheckBox.TabIndex = 12
        Me.CustSaleRPTCheckBox.Text = "Cashier Report"
        Me.CustSaleRPTCheckBox.UseVisualStyleBackColor = True
        '
        'MFileCheckBox
        '
        Me.MFileCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "MFile", True))
        Me.MFileCheckBox.Location = New System.Drawing.Point(32, 46)
        Me.MFileCheckBox.Name = "MFileCheckBox"
        Me.MFileCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.MFileCheckBox.TabIndex = 8
        Me.MFileCheckBox.Text = "Sales"
        Me.MFileCheckBox.UseVisualStyleBackColor = True
        '
        'MISRPTCheckBox
        '
        Me.MISRPTCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "MISRPT", True))
        Me.MISRPTCheckBox.Location = New System.Drawing.Point(32, 136)
        Me.MISRPTCheckBox.Name = "MISRPTCheckBox"
        Me.MISRPTCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.MISRPTCheckBox.TabIndex = 11
        Me.MISRPTCheckBox.Text = "Summary Report"
        Me.MISRPTCheckBox.UseVisualStyleBackColor = True
        '
        'InventoryCheckBox
        '
        Me.InventoryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS, "Inventory", True))
        Me.InventoryCheckBox.Location = New System.Drawing.Point(32, 106)
        Me.InventoryCheckBox.Name = "InventoryCheckBox"
        Me.InventoryCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.InventoryCheckBox.TabIndex = 10
        Me.InventoryCheckBox.Text = "Incoming Stocks"
        Me.InventoryCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(PasswordLabel1)
        Me.GroupBox1.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Me.LNameTextBox)
        Me.GroupBox1.Controls.Add(FNameLabel)
        Me.GroupBox1.Controls.Add(Me.UserLevelComboBox)
        Me.GroupBox1.Controls.Add(Me.FNameTextBox)
        Me.GroupBox1.Controls.Add(UserLevelLabel)
        Me.GroupBox1.Controls.Add(LNameLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 226)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Detail"
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(119, 137)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(154, 20)
        Me.ConfirmPasswordTextBox.TabIndex = 5
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(119, 80)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.UsernameTextBox.TabIndex = 3
        '
        'LNameTextBox
        '
        Me.LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "LName", True))
        Me.LNameTextBox.Location = New System.Drawing.Point(119, 54)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.LNameTextBox.TabIndex = 2
        '
        'UserLevelComboBox
        '
        Me.UserLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "UserLevel", True))
        Me.UserLevelComboBox.FormattingEnabled = True
        Me.UserLevelComboBox.Items.AddRange(New Object() {"Administrator", "Cashier", "User"})
        Me.UserLevelComboBox.Location = New System.Drawing.Point(119, 163)
        Me.UserLevelComboBox.Name = "UserLevelComboBox"
        Me.UserLevelComboBox.Size = New System.Drawing.Size(154, 21)
        Me.UserLevelComboBox.TabIndex = 6
        '
        'FNameTextBox
        '
        Me.FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "FName", True))
        Me.FNameTextBox.Location = New System.Drawing.Point(119, 28)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.FNameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(119, 107)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(154, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'UsersRTA
        '
        Me.UsersRTA.ClearBeforeFill = True
        '
        'TAM
        '
        Me.TAM.BackupDataSetBeforeUpdate = False
        Me.TAM.Connection = Nothing
        Me.TAM.UpdateOrder = Cedemed.StockDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EditUserModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(597, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EditUserModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User Detail"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RistrictionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MaintenanceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StocktranCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdminCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CustSaleRPTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MFileCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MISRPTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InventoryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsersRTA As Cedemed.RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
    Friend WithEvents RistrictionDS As Cedemed.RistrictionDataSet
    Friend WithEvents TAM As Cedemed.StockDatasetTableAdapters.TableAdapterManager
    Friend WithEvents BS As System.Windows.Forms.BindingSource
    Friend WithEvents ConfirmPasswordTextBox As System.Windows.Forms.TextBox
End Class
