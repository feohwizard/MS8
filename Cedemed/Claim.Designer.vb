<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Claim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TransdateLabel As System.Windows.Forms.Label
        Dim TransactionuserLabel As System.Windows.Forms.Label
        Dim FrombranchLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TransdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TransactionuserTextBox = New System.Windows.Forms.TextBox()
        Me.FrombranchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RecevItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsDataset = New Cedemed.ItemsDataset()
        Me.invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecevItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemsTableAdapter = New Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager1 = New Cedemed.ItemsDatasetTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveDataset = New Cedemed.ReceiveDataset()
        Me.RecevTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter()
        Me.TableAdapterManager = New Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager()
        Me.RecevItemsTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter()
        TransdateLabel = New System.Windows.Forms.Label()
        TransactionuserLabel = New System.Windows.Forms.Label()
        FrombranchLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RecevItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransdateLabel
        '
        TransdateLabel.AutoSize = True
        TransdateLabel.Location = New System.Drawing.Point(10, 25)
        TransdateLabel.Name = "TransdateLabel"
        TransdateLabel.Size = New System.Drawing.Size(92, 13)
        TransdateLabel.TabIndex = 6
        TransdateLabel.Text = "Transaction Date:"
        '
        'TransactionuserLabel
        '
        TransactionuserLabel.AutoSize = True
        TransactionuserLabel.Location = New System.Drawing.Point(55, 74)
        TransactionuserLabel.Name = "TransactionuserLabel"
        TransactionuserLabel.Size = New System.Drawing.Size(47, 13)
        TransactionuserLabel.TabIndex = 12
        TransactionuserLabel.Text = "Sent By:"
        '
        'FrombranchLabel
        '
        FrombranchLabel.AutoSize = True
        FrombranchLabel.Location = New System.Drawing.Point(69, 48)
        FrombranchLabel.Name = "FrombranchLabel"
        FrombranchLabel.Size = New System.Drawing.Size(33, 13)
        FrombranchLabel.TabIndex = 14
        FrombranchLabel.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Claiming Code:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TransdateDateTimePicker
        '
        Me.TransdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecevBindingSource, "transdate", True))
        Me.TransdateDateTimePicker.Enabled = False
        Me.TransdateDateTimePicker.Location = New System.Drawing.Point(108, 19)
        Me.TransdateDateTimePicker.Name = "TransdateDateTimePicker"
        Me.TransdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransdateDateTimePicker.TabIndex = 7
        '
        'TransactionuserTextBox
        '
        Me.TransactionuserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecevBindingSource, "transactionuser", True))
        Me.TransactionuserTextBox.Enabled = False
        Me.TransactionuserTextBox.Location = New System.Drawing.Point(108, 71)
        Me.TransactionuserTextBox.Name = "TransactionuserTextBox"
        Me.TransactionuserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionuserTextBox.TabIndex = 13
        '
        'FrombranchTextBox
        '
        Me.FrombranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecevBindingSource, "frombranch", True))
        Me.FrombranchTextBox.Enabled = False
        Me.FrombranchTextBox.Location = New System.Drawing.Point(108, 45)
        Me.FrombranchTextBox.Name = "FrombranchTextBox"
        Me.FrombranchTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FrombranchTextBox.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.RecevItemsDataGridView)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TransdateDateTimePicker)
        Me.GroupBox1.Controls.Add(TransdateLabel)
        Me.GroupBox1.Controls.Add(Me.FrombranchTextBox)
        Me.GroupBox1.Controls.Add(FrombranchLabel)
        Me.GroupBox1.Controls.Add(TransactionuserLabel)
        Me.GroupBox1.Controls.Add(Me.TransactionuserTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 407)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(692, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Claim"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RecevItemsDataGridView
        '
        Me.RecevItemsDataGridView.AllowUserToAddRows = False
        Me.RecevItemsDataGridView.AllowUserToDeleteRows = False
        Me.RecevItemsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecevItemsDataGridView.AutoGenerateColumns = False
        Me.RecevItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecevItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.invoice})
        Me.RecevItemsDataGridView.DataSource = Me.RecevItemsBindingSource
        Me.RecevItemsDataGridView.Location = New System.Drawing.Point(22, 138)
        Me.RecevItemsDataGridView.Name = "RecevItemsDataGridView"
        Me.RecevItemsDataGridView.ReadOnly = True
        Me.RecevItemsDataGridView.Size = New System.Drawing.Size(745, 263)
        Me.RecevItemsDataGridView.TabIndex = 16
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.ItemsDataset
        '
        'ItemsDataset
        '
        Me.ItemsDataset.DataSetName = "ItemsDataset"
        Me.ItemsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'invoice
        '
        Me.invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoice.DataPropertyName = "invoice"
        Me.invoice.HeaderText = "Invoice"
        Me.invoice.Name = "invoice"
        Me.invoice.ReadOnly = True
        Me.invoice.Width = 67
        '
        'RecevItemsBindingSource
        '
        Me.RecevItemsBindingSource.DataMember = "Recev_RecevItems"
        Me.RecevItemsBindingSource.DataSource = Me.RecevBindingSource
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Items"
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Cedemed.ItemsDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(673, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Retrieve Old Transfer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ItemNo"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ItemsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "IDesc"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ItemNo"
        Me.DataGridViewTextBoxColumn3.Width = 99
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 71
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Expiry"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Expiry"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "lotno"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lot No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 47
        '
        'RecevBindingSource
        '
        Me.RecevBindingSource.DataMember = "Recev"
        Me.RecevBindingSource.DataSource = Me.ReceiveDataset
        '
        'ReceiveDataset
        '
        Me.ReceiveDataset.DataSetName = "ReceiveDataset"
        Me.ReceiveDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecevTableAdapter
        '
        Me.RecevTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.RecevTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecevItemsTableAdapter
        '
        Me.RecevItemsTableAdapter.ClearBeforeFill = True
        '
        'Claim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 464)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Claim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Claim Stock From Branch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RecevItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReceiveDataset As Cedemed.ReceiveDataset
    Friend WithEvents RecevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager
    Friend WithEvents TransdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransactionuserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FrombranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RecevItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevItemsTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter
    Friend WithEvents RecevItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemsDataset As Cedemed.ItemsDataset
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager1 As Cedemed.ItemsDatasetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
