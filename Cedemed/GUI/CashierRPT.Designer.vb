<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierRPT
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashierRPT))
        Me.RistrictionDataSet = New Cedemed.RistrictionDataSet()
        Me.UsersRestrictionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersRestrictionTableAdapter = New Cedemed.RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter()
        Me.TableAdapterManager = New Cedemed.RistrictionDataSetTableAdapters.TableAdapterManager()
        Me.UsernameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tod = New System.Windows.Forms.DateTimePicker()
        Me.from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TransTA = New Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter()
        Me.TransactionsDS = New Cedemed.TransactionsDataset()
        Me.SalesTA = New Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter()
        UsernameLabel = New System.Windows.Forms.Label()
        CType(Me.RistrictionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersRestrictionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Location = New System.Drawing.Point(13, 38)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(76, 13)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Cashier Name:"
        '
        'RistrictionDataSet
        '
        Me.RistrictionDataSet.DataSetName = "RistrictionDataSet"
        Me.RistrictionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersRestrictionBindingSource
        '
        Me.UsersRestrictionBindingSource.DataMember = "UsersRestriction"
        Me.UsersRestrictionBindingSource.DataSource = Me.RistrictionDataSet
        '
        'UsersRestrictionTableAdapter
        '
        Me.UsersRestrictionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Cedemed.RistrictionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersRestrictionTableAdapter = Me.UsersRestrictionTableAdapter
        '
        'UsernameComboBox
        '
        Me.UsernameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersRestrictionBindingSource, "Username", True))
        Me.UsernameComboBox.DataSource = Me.RistrictionDataSet
        Me.UsernameComboBox.DisplayMember = "UsersRestriction.Username"
        Me.UsernameComboBox.FormattingEnabled = True
        Me.UsernameComboBox.Location = New System.Drawing.Point(95, 35)
        Me.UsernameComboBox.Name = "UsernameComboBox"
        Me.UsernameComboBox.Size = New System.Drawing.Size(236, 21)
        Me.UsernameComboBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Generate Cashier Sales Report"
        '
        'tod
        '
        Me.tod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tod.Location = New System.Drawing.Point(95, 93)
        Me.tod.Name = "tod"
        Me.tod.Size = New System.Drawing.Size(126, 20)
        Me.tod.TabIndex = 26
        '
        'from
        '
        Me.from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from.Location = New System.Drawing.Point(95, 62)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(126, 20)
        Me.from.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "From:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 22)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Per Customer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 22)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Per Item"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TransTA
        '
        Me.TransTA.ClearBeforeFill = True
        '
        'TransactionsDS
        '
        Me.TransactionsDS.DataSetName = "TransactionsDataset"
        Me.TransactionsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesTA
        '
        Me.SalesTA.ClearBeforeFill = True
        '
        'CashierRPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(343, 125)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tod)
        Me.Controls.Add(Me.from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "CashierRPT"
        Me.Text = "Form1"
        CType(Me.RistrictionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersRestrictionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RistrictionDataSet As Cedemed.RistrictionDataSet
    Friend WithEvents UsersRestrictionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersRestrictionTableAdapter As Cedemed.RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.RistrictionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tod As System.Windows.Forms.DateTimePicker
    Friend WithEvents from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TransTA As Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter
    Friend WithEvents TransactionsDS As Cedemed.TransactionsDataset
    Friend WithEvents SalesTA As Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter
End Class
