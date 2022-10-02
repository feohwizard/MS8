<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnItem
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
        Dim TransNoLabel As System.Windows.Forms.Label
        Dim TransDateLabel As System.Windows.Forms.Label
        Dim CustNameLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnItem))
        Me.TransactionsDataset = New Cedemed.TransactionsDataset()
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter()
        Me.TableAdapterManager = New Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager()
        Me.TransNoTextBox = New System.Windows.Forms.TextBox()
        Me.TransDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustNameTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ItemsBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsDataset = New Cedemed.ItemsDataset()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitreturn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expiry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter()
        Me.ItemsTableAdapter = New Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        TransNoLabel = New System.Windows.Forms.Label()
        TransDateLabel = New System.Windows.Forms.Label()
        CustNameLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransNoLabel
        '
        TransNoLabel.AutoSize = True
        TransNoLabel.Location = New System.Drawing.Point(19, 15)
        TransNoLabel.Name = "TransNoLabel"
        TransNoLabel.Size = New System.Drawing.Size(46, 13)
        TransNoLabel.TabIndex = 1
        TransNoLabel.Text = "OR No.:"
        '
        'TransDateLabel
        '
        TransDateLabel.AutoSize = True
        TransDateLabel.Location = New System.Drawing.Point(32, 44)
        TransDateLabel.Name = "TransDateLabel"
        TransDateLabel.Size = New System.Drawing.Size(33, 13)
        TransDateLabel.TabIndex = 3
        TransDateLabel.Text = "Date:"
        '
        'CustNameLabel
        '
        CustNameLabel.AutoSize = True
        CustNameLabel.Location = New System.Drawing.Point(11, 67)
        CustNameLabel.Name = "CustNameLabel"
        CustNameLabel.Size = New System.Drawing.Size(54, 13)
        CustNameLabel.TabIndex = 5
        CustNameLabel.Text = "Customer:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(31, 93)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 7
        TotalLabel.Text = "Total:"
        '
        'TransactionsDataset
        '
        Me.TransactionsDataset.DataSetName = "TransactionsDataset"
        Me.TransactionsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransBindingSource
        '
        Me.TransBindingSource.DataMember = "Trans"
        Me.TransBindingSource.DataSource = Me.TransactionsDataset
        '
        'TransTableAdapter
        '
        Me.TransTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.TransTableAdapter = Me.TransTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransNoTextBox
        '
        Me.TransNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransBindingSource, "TransNo", True))
        Me.TransNoTextBox.Location = New System.Drawing.Point(71, 12)
        Me.TransNoTextBox.Name = "TransNoTextBox"
        Me.TransNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransNoTextBox.TabIndex = 2
        '
        'TransDateDateTimePicker
        '
        Me.TransDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransBindingSource, "TransDate", True))
        Me.TransDateDateTimePicker.Location = New System.Drawing.Point(71, 38)
        Me.TransDateDateTimePicker.Name = "TransDateDateTimePicker"
        Me.TransDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransDateDateTimePicker.TabIndex = 4
        '
        'CustNameTextBox
        '
        Me.CustNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransBindingSource, "CustName", True))
        Me.CustNameTextBox.Location = New System.Drawing.Point(71, 64)
        Me.CustNameTextBox.Name = "CustNameTextBox"
        Me.CustNameTextBox.Size = New System.Drawing.Size(371, 20)
        Me.CustNameTextBox.TabIndex = 6
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(71, 90)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(357, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.SalesDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 279)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(551, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Process Return"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SalesDataGridView
        '
        Me.SalesDataGridView.AllowUserToAddRows = False
        Me.SalesDataGridView.AllowUserToDeleteRows = False
        Me.SalesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalesDataGridView.AutoGenerateColumns = False
        Me.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.unitreturn, Me.total, Me.expiry})
        Me.SalesDataGridView.DataSource = Me.SalesBindingSource
        Me.SalesDataGridView.Location = New System.Drawing.Point(7, 17)
        Me.SalesDataGridView.Name = "SalesDataGridView"
        Me.SalesDataGridView.Size = New System.Drawing.Size(640, 227)
        Me.SalesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ItemNo"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.ItemsBS
        Me.DataGridViewTextBoxColumn4.DisplayMember = "IDesc"
        Me.DataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ItemNo"
        Me.DataGridViewTextBoxColumn4.Width = 52
        '
        'ItemsBS
        '
        Me.ItemsBS.DataMember = "Items"
        Me.ItemsBS.DataSource = Me.ItemsDataset
        '
        'ItemsDataset
        '
        Me.ItemsDataset.DataSetName = "ItemsDataset"
        Me.ItemsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SRP"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Cost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitSold"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit Sold"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'unitreturn
        '
        Me.unitreturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.unitreturn.DataPropertyName = "returntotal"
        Me.unitreturn.HeaderText = "Unit Return"
        Me.unitreturn.Name = "unitreturn"
        Me.unitreturn.Width = 86
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.total.DefaultCellStyle = DataGridViewCellStyle3
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 56
        '
        'expiry
        '
        Me.expiry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.expiry.DataPropertyName = "expiry"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.expiry.DefaultCellStyle = DataGridViewCellStyle4
        Me.expiry.HeaderText = "Expiry"
        Me.expiry.Name = "expiry"
        Me.expiry.ReadOnly = True
        Me.expiry.Width = 60
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "FK_Trans_Sales"
        Me.SalesBindingSource.DataSource = Me.TransBindingSource
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Retrieve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReturnItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(CustNameLabel)
        Me.Controls.Add(Me.CustNameTextBox)
        Me.Controls.Add(TransDateLabel)
        Me.Controls.Add(Me.TransDateDateTimePicker)
        Me.Controls.Add(TransNoLabel)
        Me.Controls.Add(Me.TransNoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReturnItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Item"
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransactionsDataset As Cedemed.TransactionsDataset
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransTableAdapter As Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager
    Friend WithEvents TransNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter
    Friend WithEvents SalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemsBS As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsDataset As Cedemed.ItemsDataset
    Friend WithEvents ItemsTableAdapter As Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitreturn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expiry As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
