<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stockinform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stockinform))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.expirydate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.suppliercombotxt = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataset = New Cedemed.SupplierDataset()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lotnotxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.invoicetxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.recievedtxt = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkdatetxt = New System.Windows.Forms.DateTimePicker()
        Me.checknotxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vouchertxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsDataset = New Cedemed.ItemsDataset()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ucost = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.quantitytxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.itemnotxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemsTableAdapter = New Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New Cedemed.ItemsDatasetTableAdapters.TableAdapterManager()
        Me.mennu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasesDataset = New Cedemed.PurchasesDataset()
        Me.PurchasesTableAdapter = New Cedemed.PurchasesDatasetTableAdapters.PurchasesTableAdapter()
        Me.TableAdapterManager1 = New Cedemed.PurchasesDatasetTableAdapters.TableAdapterManager()
        Me.SupplierTableAdapter = New Cedemed.SupplierDatasetTableAdapters.SupplierTableAdapter()
        Me.PurchasesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ItemStockInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemStockin = New Cedemed.ItemStockin()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemStockInTableAdapter = New Cedemed.ItemStockinTableAdapters.ItemStockInTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.mennu.SuspendLayout()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStockInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStockin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 25)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchases For The Month of:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(321, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(335, 20)
        Me.TextBox1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.expirydate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.suppliercombotxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lotnotxt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.invoicetxt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 161)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'expirydate
        '
        Me.expirydate.Location = New System.Drawing.Point(101, 125)
        Me.expirydate.Name = "expirydate"
        Me.expirydate.Size = New System.Drawing.Size(138, 20)
        Me.expirydate.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date Recieved:"
        '
        'suppliercombotxt
        '
        Me.suppliercombotxt.DataSource = Me.SupplierBindingSource
        Me.suppliercombotxt.DisplayMember = "Sup_Name"
        Me.suppliercombotxt.FormattingEnabled = True
        Me.suppliercombotxt.Location = New System.Drawing.Point(101, 97)
        Me.suppliercombotxt.Name = "suppliercombotxt"
        Me.suppliercombotxt.Size = New System.Drawing.Size(138, 21)
        Me.suppliercombotxt.TabIndex = 14
        Me.suppliercombotxt.ValueMember = "Sup_Name"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataset
        '
        'SupplierDataset
        '
        Me.SupplierDataset.DataSetName = "SupplierDataset"
        Me.SupplierDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Expiry Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Supplier:"
        '
        'lotnotxt
        '
        Me.lotnotxt.Location = New System.Drawing.Point(101, 71)
        Me.lotnotxt.Name = "lotnotxt"
        Me.lotnotxt.Size = New System.Drawing.Size(138, 20)
        Me.lotnotxt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lot No.:"
        '
        'invoicetxt
        '
        Me.invoicetxt.Location = New System.Drawing.Point(101, 45)
        Me.invoicetxt.Name = "invoicetxt"
        Me.invoicetxt.Size = New System.Drawing.Size(138, 20)
        Me.invoicetxt.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Invoice No.:"
        '
        'recievedtxt
        '
        Me.recievedtxt.Location = New System.Drawing.Point(113, 239)
        Me.recievedtxt.Name = "recievedtxt"
        Me.recievedtxt.Size = New System.Drawing.Size(138, 20)
        Me.recievedtxt.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkdatetxt)
        Me.GroupBox3.Controls.Add(Me.checknotxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.vouchertxt)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(252, 106)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'checkdatetxt
        '
        Me.checkdatetxt.Location = New System.Drawing.Point(101, 45)
        Me.checkdatetxt.Name = "checkdatetxt"
        Me.checkdatetxt.Size = New System.Drawing.Size(138, 20)
        Me.checkdatetxt.TabIndex = 21
        '
        'checknotxt
        '
        Me.checknotxt.Location = New System.Drawing.Point(101, 72)
        Me.checknotxt.Name = "checknotxt"
        Me.checknotxt.Size = New System.Drawing.Size(138, 20)
        Me.checknotxt.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Check No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Check Date:"
        '
        'vouchertxt
        '
        Me.vouchertxt.Location = New System.Drawing.Point(101, 19)
        Me.vouchertxt.Name = "vouchertxt"
        Me.vouchertxt.Size = New System.Drawing.Size(138, 20)
        Me.vouchertxt.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Voucher No.:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ItemsDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(288, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(368, 263)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.AutoGenerateColumns = False
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ItemsDataGridView.DataSource = Me.ItemsBindingSource
        Me.ItemsDataGridView.Location = New System.Drawing.Point(11, 15)
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsDataGridView.Size = New System.Drawing.Size(347, 238)
        Me.ItemsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ItemNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 72
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDesc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 85
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ucost)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.quantitytxt)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.itemnotxt)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(288, 320)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(265, 128)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'ucost
        '
        Me.ucost.Location = New System.Drawing.Point(82, 71)
        Me.ucost.Name = "ucost"
        Me.ucost.Size = New System.Drawing.Size(169, 20)
        Me.ucost.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Unit Cost:"
        '
        'quantitytxt
        '
        Me.quantitytxt.Location = New System.Drawing.Point(82, 45)
        Me.quantitytxt.Name = "quantitytxt"
        Me.quantitytxt.Size = New System.Drawing.Size(169, 20)
        Me.quantitytxt.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Quantity:"
        '
        'itemnotxt
        '
        Me.itemnotxt.Enabled = False
        Me.itemnotxt.Location = New System.Drawing.Point(82, 19)
        Me.itemnotxt.Name = "itemnotxt"
        Me.itemnotxt.Size = New System.Drawing.Size(169, 20)
        Me.itemnotxt.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Item No.:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 39)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cedemed.ItemsDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'mennu
        '
        Me.mennu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.mennu.Name = "mennu"
        Me.mennu.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'PurchasesBindingSource
        '
        Me.PurchasesBindingSource.DataMember = "Purchases"
        Me.PurchasesBindingSource.DataSource = Me.PurchasesDataset
        '
        'PurchasesDataset
        '
        Me.PurchasesDataset.DataSetName = "PurchasesDataset"
        Me.PurchasesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PurchasesTableAdapter = Me.PurchasesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Cedemed.PurchasesDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'PurchasesDataGridView
        '
        Me.PurchasesDataGridView.AllowUserToAddRows = False
        Me.PurchasesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurchasesDataGridView.AutoGenerateColumns = False
        Me.PurchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchasesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.CheckNo, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PurchasesDataGridView.ContextMenuStrip = Me.mennu
        Me.PurchasesDataGridView.DataSource = Me.PurchasesBindingSource
        Me.PurchasesDataGridView.Location = New System.Drawing.Point(12, 508)
        Me.PurchasesDataGridView.Name = "PurchasesDataGridView"
        Me.PurchasesDataGridView.ReadOnly = True
        Me.PurchasesDataGridView.Size = New System.Drawing.Size(825, 230)
        Me.PurchasesDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RecvDT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Receive Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 79
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "InvNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "InvoiceNo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 62
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CheckDT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CheckDT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 59
        '
        'CheckNo
        '
        Me.CheckNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CheckNo.DataPropertyName = "CheckNo"
        Me.CheckNo.HeaderText = "CheckNo"
        Me.CheckNo.Name = "CheckNo"
        Me.CheckNo.ReadOnly = True
        Me.CheckNo.Width = 77
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VoucherNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "VoucherNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 67
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MRRNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lot No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 45
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Supplier"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 51
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Expiry"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Expiry"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Width = 41
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ItemNo"
        Me.DataGridViewTextBoxColumn9.DataSource = Me.ItemStockInBindingSource
        Me.DataGridViewTextBoxColumn9.DisplayMember = "IDesc"
        Me.DataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn9.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.ValueMember = "ItemNo"
        Me.DataGridViewTextBoxColumn9.Width = 66
        '
        'ItemStockInBindingSource
        '
        Me.ItemStockInBindingSource.DataMember = "ItemStockIn"
        Me.ItemStockInBindingSource.DataSource = Me.ItemStockin
        '
        'ItemStockin
        '
        Me.ItemStockin.DataSetName = "ItemStockin"
        Me.ItemStockin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 29
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "UCost"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn11.HeaderText = "UnitCost"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 72
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.ItemsDataset
        '
        'ItemStockInTableAdapter
        '
        Me.ItemStockInTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(391, 454)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 39)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cancel Edit"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Stockinform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(849, 750)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PurchasesDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.recievedtxt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stockinform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock In"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.mennu.ResumeLayout(False)
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStockInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStockin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents expirydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents suppliercombotxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lotnotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents invoicetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents recievedtxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents checkdatetxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents checknotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents vouchertxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents quantitytxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents itemnotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ItemsDataset As Cedemed.ItemsDataset
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.ItemsDatasetTableAdapters.TableAdapterManager
    Friend WithEvents ItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchasesDataset As Cedemed.PurchasesDataset
    Friend WithEvents PurchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchasesTableAdapter As Cedemed.PurchasesDatasetTableAdapters.PurchasesTableAdapter
    Friend WithEvents TableAdapterManager1 As Cedemed.PurchasesDatasetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierDataset As Cedemed.SupplierDataset
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As Cedemed.SupplierDatasetTableAdapters.SupplierTableAdapter
    Friend WithEvents mennu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemStockin As Cedemed.ItemStockin
    Friend WithEvents ItemStockInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemStockInTableAdapter As Cedemed.ItemStockinTableAdapters.ItemStockInTableAdapter
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ucost As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CheckNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
