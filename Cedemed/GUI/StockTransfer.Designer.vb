<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockTransfer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockTransfer))
        Me.Searchbox = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotview = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StockBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataset = New Cedemed.StockDataset()
        Me.PurchasesTableAdapter = New Cedemed.StockDatasetTableAdapters.PurchasesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.quantitytxt = New System.Windows.Forms.TextBox()
        Me.PurchasesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataset = New Cedemed.InventoryDataset()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Cedemed.InventoryDatasetTableAdapters.ItemsTableAdapter()
        Me.CostumertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustumerTable = New Cedemed.CustumerTable()
        Me.CostumertblTableAdapter = New Cedemed.CustumerTableTableAdapters.CostumertblTableAdapter()
        Me.TableAdapterManager = New Cedemed.CustumerTableTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.StockBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustumerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Searchbox
        '
        Me.Searchbox.Location = New System.Drawing.Point(12, 12)
        Me.Searchbox.Name = "Searchbox"
        Me.Searchbox.Size = New System.Drawing.Size(444, 20)
        Me.Searchbox.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(444, 345)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Description"
        Me.ColumnHeader1.Width = 257
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SRP"
        Me.ColumnHeader2.Width = 84
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTY"
        Me.ColumnHeader3.Width = 44
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "         "
        '
        'lotview
        '
        Me.lotview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.lotview.FullRowSelect = True
        Me.lotview.HideSelection = False
        Me.lotview.Location = New System.Drawing.Point(12, 389)
        Me.lotview.Name = "lotview"
        Me.lotview.Size = New System.Drawing.Size(444, 93)
        Me.lotview.TabIndex = 2
        Me.lotview.UseCompatibleStateImageBehavior = False
        Me.lotview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Expiry Date"
        Me.ColumnHeader4.Width = 141
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Stock"
        Me.ColumnHeader6.Width = 53
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lot No."
        Me.ColumnHeader5.Width = 191
        '
        'StockBS
        '
        Me.StockBS.DataMember = "Purchases"
        Me.StockBS.DataSource = Me.StockDataset
        '
        'StockDataset
        '
        Me.StockDataset.DataSetName = "StockDataset"
        Me.StockDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity:"
        '
        'quantitytxt
        '
        Me.quantitytxt.Location = New System.Drawing.Point(85, 488)
        Me.quantitytxt.Name = "quantitytxt"
        Me.quantitytxt.Size = New System.Drawing.Size(371, 20)
        Me.quantitytxt.TabIndex = 8
        '
        'PurchasesDataGridView
        '
        Me.PurchasesDataGridView.AllowUserToAddRows = False
        Me.PurchasesDataGridView.AutoGenerateColumns = False
        Me.PurchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchasesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.NCost, Me.lotno, Me.invoice})
        Me.PurchasesDataGridView.DataSource = Me.PurchasesBindingSource
        Me.PurchasesDataGridView.Location = New System.Drawing.Point(462, 12)
        Me.PurchasesDataGridView.Name = "PurchasesDataGridView"
        Me.PurchasesDataGridView.Size = New System.Drawing.Size(583, 470)
        Me.PurchasesDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 247
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 41
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Amount"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 75
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
        'NCost
        '
        Me.NCost.DataPropertyName = "NCost"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.NCost.DefaultCellStyle = DataGridViewCellStyle2
        Me.NCost.HeaderText = "Normal Cost"
        Me.NCost.Name = "NCost"
        Me.NCost.ReadOnly = True
        Me.NCost.Visible = False
        Me.NCost.Width = 69
        '
        'lotno
        '
        Me.lotno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.lotno.DataPropertyName = "lotno"
        Me.lotno.HeaderText = "Lot No"
        Me.lotno.Name = "lotno"
        Me.lotno.Width = 64
        '
        'invoice
        '
        Me.invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoice.DataPropertyName = "invoice"
        Me.invoice.HeaderText = "Invoice"
        Me.invoice.Name = "invoice"
        Me.invoice.Width = 67
        '
        'PurchasesBindingSource
        '
        Me.PurchasesBindingSource.DataMember = "Purchases"
        Me.PurchasesBindingSource.DataSource = Me.InventoryDataset
        '
        'InventoryDataset
        '
        Me.InventoryDataset.DataSetName = "InventoryDataset"
        Me.InventoryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.InventoryDataset
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'CostumertblBindingSource
        '
        Me.CostumertblBindingSource.DataMember = "Costumertbl"
        Me.CostumertblBindingSource.DataSource = Me.CustumerTable
        '
        'CustumerTable
        '
        Me.CustumerTable.DataSetName = "CustumerTable"
        Me.CustumerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostumertblTableAdapter
        '
        Me.CostumertblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CostumertblTableAdapter = Me.CostumertblTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cedemed.CustumerTableTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(953, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Transfer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(743, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Select Branch:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Main Branch", "Residence", "Urdaneta", "Tarlac", "Zambales", "Pampanga"})
        Me.ComboBox1.Location = New System.Drawing.Point(826, 489)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'StockTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 528)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PurchasesDataGridView)
        Me.Controls.Add(Me.quantitytxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lotview)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Searchbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        CType(Me.StockBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustumerTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Searchbox As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents InventoryDataset As Cedemed.InventoryDataset
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Cedemed.InventoryDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents lotview As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StockBS As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataset As Cedemed.StockDataset
    Friend WithEvents PurchasesTableAdapter As Cedemed.StockDatasetTableAdapters.PurchasesTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents quantitytxt As System.Windows.Forms.TextBox
    Friend WithEvents PurchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchasesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustumerTable As Cedemed.CustumerTable
    Friend WithEvents CostumertblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostumertblTableAdapter As Cedemed.CustumerTableTableAdapters.CostumertblTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.CustumerTableTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
