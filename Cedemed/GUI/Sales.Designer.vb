<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemnotxt = New System.Windows.Forms.TextBox()
        Me.quantitytxt = New System.Windows.Forms.TextBox()
        Me.unitcosttxt = New System.Windows.Forms.TextBox()
        Me.totalcosttxt = New System.Windows.Forms.TextBox()
        Me.paymenttxt = New System.Windows.Forms.TextBox()
        Me.totalpaymenttxt = New System.Windows.Forms.TextBox()
        Me.subtotaltxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.changetxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grandlabel = New System.Windows.Forms.Label()
        Me.CostumertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustumerTable = New Cedemed.CustumerTable()
        Me.CostumertblTableAdapter = New Cedemed.CustumerTableTableAdapters.CostumertblTableAdapter()
        Me.TableAdapterManager = New Cedemed.CustumerTableTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.newb = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.searchb = New System.Windows.Forms.Button()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.genericnorm = New System.Windows.Forms.RadioButton()
        Me.GenericmarkupLabel1 = New System.Windows.Forms.Label()
        Me.genericdiscountcheck = New System.Windows.Forms.RadioButton()
        Me.genericmarkupcheck = New System.Windows.Forms.RadioButton()
        Me.GenericdiscountLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.otcnorm = New System.Windows.Forms.RadioButton()
        Me.otcdiscountcheck = New System.Windows.Forms.RadioButton()
        Me.OtcmarkupLabel1 = New System.Windows.Forms.Label()
        Me.OtcdiscountLabel1 = New System.Windows.Forms.Label()
        Me.otcmarkupcheck = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lblname = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PurchasesDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discountM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NormalRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Apply2DiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Apply10DiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Apply20DiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyCustomDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyMarkupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyPesoValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataset = New Cedemed.InventoryDataset()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Cedemed.InventoryDatasetTableAdapters.ItemsTableAdapter()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.StockBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustumerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.discountM.SuspendLayout()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(9, 16)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        '
        'Searchbox
        '
        Me.Searchbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Searchbox.Location = New System.Drawing.Point(12, 12)
        Me.Searchbox.Name = "Searchbox"
        Me.Searchbox.Size = New System.Drawing.Size(432, 20)
        Me.Searchbox.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(432, 359)
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
        Me.ColumnHeader7.Text = "    "
        '
        'lotview
        '
        Me.lotview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.lotview.FullRowSelect = True
        Me.lotview.HideSelection = False
        Me.lotview.Location = New System.Drawing.Point(12, 403)
        Me.lotview.Name = "lotview"
        Me.lotview.Size = New System.Drawing.Size(432, 93)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 551)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 578)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unit Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Cost:"
        '
        'itemnotxt
        '
        Me.itemnotxt.Location = New System.Drawing.Point(81, 521)
        Me.itemnotxt.Name = "itemnotxt"
        Me.itemnotxt.Size = New System.Drawing.Size(363, 20)
        Me.itemnotxt.TabIndex = 7
        '
        'quantitytxt
        '
        Me.quantitytxt.Location = New System.Drawing.Point(81, 548)
        Me.quantitytxt.Name = "quantitytxt"
        Me.quantitytxt.Size = New System.Drawing.Size(363, 20)
        Me.quantitytxt.TabIndex = 8
        '
        'unitcosttxt
        '
        Me.unitcosttxt.Location = New System.Drawing.Point(81, 575)
        Me.unitcosttxt.Name = "unitcosttxt"
        Me.unitcosttxt.Size = New System.Drawing.Size(363, 20)
        Me.unitcosttxt.TabIndex = 9
        '
        'totalcosttxt
        '
        Me.totalcosttxt.Location = New System.Drawing.Point(81, 602)
        Me.totalcosttxt.Name = "totalcosttxt"
        Me.totalcosttxt.Size = New System.Drawing.Size(363, 20)
        Me.totalcosttxt.TabIndex = 10
        '
        'paymenttxt
        '
        Me.paymenttxt.Location = New System.Drawing.Point(539, 517)
        Me.paymenttxt.Name = "paymenttxt"
        Me.paymenttxt.Size = New System.Drawing.Size(323, 20)
        Me.paymenttxt.TabIndex = 19
        '
        'totalpaymenttxt
        '
        Me.totalpaymenttxt.Location = New System.Drawing.Point(935, 601)
        Me.totalpaymenttxt.Name = "totalpaymenttxt"
        Me.totalpaymenttxt.Size = New System.Drawing.Size(323, 20)
        Me.totalpaymenttxt.TabIndex = 18
        Me.totalpaymenttxt.Visible = False
        '
        'subtotaltxt
        '
        Me.subtotaltxt.Location = New System.Drawing.Point(935, 575)
        Me.subtotaltxt.Name = "subtotaltxt"
        Me.subtotaltxt.Size = New System.Drawing.Size(323, 20)
        Me.subtotaltxt.TabIndex = 16
        Me.subtotaltxt.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Payment:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(853, 604)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total:"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(853, 578)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sub Total:"
        Me.Label8.Visible = False
        '
        'changetxt
        '
        Me.changetxt.Location = New System.Drawing.Point(539, 543)
        Me.changetxt.Name = "changetxt"
        Me.changetxt.Size = New System.Drawing.Size(323, 20)
        Me.changetxt.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(457, 546)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Change:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 572)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Reprint"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grandlabel
        '
        Me.grandlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandlabel.Location = New System.Drawing.Point(991, 506)
        Me.grandlabel.Name = "grandlabel"
        Me.grandlabel.Size = New System.Drawing.Size(199, 37)
        Me.grandlabel.TabIndex = 24
        Me.grandlabel.Text = "0.00"
        Me.grandlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.newb)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.searchb)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(450, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 44)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'newb
        '
        Me.newb.Location = New System.Drawing.Point(520, 11)
        Me.newb.Name = "newb"
        Me.newb.Size = New System.Drawing.Size(104, 23)
        Me.newb.TabIndex = 16
        Me.newb.Text = "New"
        Me.newb.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(669, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 28)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Trusted Quality Healthcare"
        Me.Label9.Visible = False
        '
        'searchb
        '
        Me.searchb.Location = New System.Drawing.Point(630, 11)
        Me.searchb.Name = "searchb"
        Me.searchb.Size = New System.Drawing.Size(104, 23)
        Me.searchb.TabIndex = 15
        Me.searchb.Text = "Search"
        Me.searchb.UseVisualStyleBackColor = True
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "name", True))
        Me.NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel1.Location = New System.Drawing.Point(51, 16)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(442, 20)
        Me.NameLabel1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.genericnorm)
        Me.GroupBox3.Controls.Add(Me.GenericmarkupLabel1)
        Me.GroupBox3.Controls.Add(Me.genericdiscountcheck)
        Me.GroupBox3.Controls.Add(Me.genericmarkupcheck)
        Me.GroupBox3.Controls.Add(Me.GenericdiscountLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(1225, 325)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 97)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Generic"
        Me.GroupBox3.Visible = False
        '
        'genericnorm
        '
        Me.genericnorm.AutoSize = True
        Me.genericnorm.Location = New System.Drawing.Point(6, 16)
        Me.genericnorm.Name = "genericnorm"
        Me.genericnorm.Size = New System.Drawing.Size(84, 17)
        Me.genericnorm.TabIndex = 15
        Me.genericnorm.TabStop = True
        Me.genericnorm.Text = "Normal Rate"
        Me.genericnorm.UseVisualStyleBackColor = True
        '
        'GenericmarkupLabel1
        '
        Me.GenericmarkupLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "genericmarkup", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.GenericmarkupLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericmarkupLabel1.Location = New System.Drawing.Point(122, 63)
        Me.GenericmarkupLabel1.Name = "GenericmarkupLabel1"
        Me.GenericmarkupLabel1.Size = New System.Drawing.Size(93, 15)
        Me.GenericmarkupLabel1.TabIndex = 9
        Me.GenericmarkupLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'genericdiscountcheck
        '
        Me.genericdiscountcheck.AutoSize = True
        Me.genericdiscountcheck.Location = New System.Drawing.Point(6, 39)
        Me.genericdiscountcheck.Name = "genericdiscountcheck"
        Me.genericdiscountcheck.Size = New System.Drawing.Size(110, 17)
        Me.genericdiscountcheck.TabIndex = 11
        Me.genericdiscountcheck.TabStop = True
        Me.genericdiscountcheck.Text = "Generic Discount:"
        Me.genericdiscountcheck.UseVisualStyleBackColor = True
        '
        'genericmarkupcheck
        '
        Me.genericmarkupcheck.AutoSize = True
        Me.genericmarkupcheck.Location = New System.Drawing.Point(6, 62)
        Me.genericmarkupcheck.Name = "genericmarkupcheck"
        Me.genericmarkupcheck.Size = New System.Drawing.Size(104, 17)
        Me.genericmarkupcheck.TabIndex = 13
        Me.genericmarkupcheck.TabStop = True
        Me.genericmarkupcheck.Text = "Generic Markup:"
        Me.genericmarkupcheck.UseVisualStyleBackColor = True
        '
        'GenericdiscountLabel1
        '
        Me.GenericdiscountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "genericdiscount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.GenericdiscountLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericdiscountLabel1.Location = New System.Drawing.Point(122, 38)
        Me.GenericdiscountLabel1.Name = "GenericdiscountLabel1"
        Me.GenericdiscountLabel1.Size = New System.Drawing.Size(82, 16)
        Me.GenericdiscountLabel1.TabIndex = 5
        Me.GenericdiscountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.otcnorm)
        Me.GroupBox2.Controls.Add(Me.otcdiscountcheck)
        Me.GroupBox2.Controls.Add(Me.OtcmarkupLabel1)
        Me.GroupBox2.Controls.Add(Me.OtcdiscountLabel1)
        Me.GroupBox2.Controls.Add(Me.otcmarkupcheck)
        Me.GroupBox2.Location = New System.Drawing.Point(1221, 428)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 97)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OTC"
        Me.GroupBox2.Visible = False
        '
        'otcnorm
        '
        Me.otcnorm.AutoSize = True
        Me.otcnorm.Location = New System.Drawing.Point(6, 16)
        Me.otcnorm.Name = "otcnorm"
        Me.otcnorm.Size = New System.Drawing.Size(84, 17)
        Me.otcnorm.TabIndex = 14
        Me.otcnorm.TabStop = True
        Me.otcnorm.Text = "Normal Rate"
        Me.otcnorm.UseVisualStyleBackColor = True
        '
        'otcdiscountcheck
        '
        Me.otcdiscountcheck.AutoSize = True
        Me.otcdiscountcheck.Location = New System.Drawing.Point(6, 39)
        Me.otcdiscountcheck.Name = "otcdiscountcheck"
        Me.otcdiscountcheck.Size = New System.Drawing.Size(95, 17)
        Me.otcdiscountcheck.TabIndex = 10
        Me.otcdiscountcheck.TabStop = True
        Me.otcdiscountcheck.Text = "OTC Discount:"
        Me.otcdiscountcheck.UseVisualStyleBackColor = True
        '
        'OtcmarkupLabel1
        '
        Me.OtcmarkupLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "otcmarkup", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.OtcmarkupLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtcmarkupLabel1.Location = New System.Drawing.Point(122, 60)
        Me.OtcmarkupLabel1.Name = "OtcmarkupLabel1"
        Me.OtcmarkupLabel1.Size = New System.Drawing.Size(100, 23)
        Me.OtcmarkupLabel1.TabIndex = 7
        Me.OtcmarkupLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OtcdiscountLabel1
        '
        Me.OtcdiscountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "otcdiscount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "N2"))
        Me.OtcdiscountLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtcdiscountLabel1.Location = New System.Drawing.Point(122, 38)
        Me.OtcdiscountLabel1.Name = "OtcdiscountLabel1"
        Me.OtcdiscountLabel1.Size = New System.Drawing.Size(82, 23)
        Me.OtcdiscountLabel1.TabIndex = 3
        Me.OtcdiscountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'otcmarkupcheck
        '
        Me.otcmarkupcheck.AutoSize = True
        Me.otcmarkupcheck.Location = New System.Drawing.Point(6, 62)
        Me.otcmarkupcheck.Name = "otcmarkupcheck"
        Me.otcmarkupcheck.Size = New System.Drawing.Size(89, 17)
        Me.otcmarkupcheck.TabIndex = 12
        Me.otcmarkupcheck.TabStop = True
        Me.otcmarkupcheck.Text = "OTC Markup:"
        Me.otcmarkupcheck.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1196, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Lblname
        '
        Me.Lblname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lblname.AutoSize = True
        Me.Lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblname.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lblname.Location = New System.Drawing.Point(1120, 89)
        Me.Lblname.Name = "Lblname"
        Me.Lblname.Size = New System.Drawing.Size(261, 24)
        Me.Lblname.TabIndex = 28
        Me.Lblname.Text = "CEDEMED PHARMA DIST."
        Me.Lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lblname.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(622, 572)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PurchasesDataGridView1
        '
        Me.PurchasesDataGridView1.AllowUserToAddRows = False
        Me.PurchasesDataGridView1.AutoGenerateColumns = False
        Me.PurchasesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchasesDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn16, Me.remarks})
        Me.PurchasesDataGridView1.ContextMenuStrip = Me.discountM
        Me.PurchasesDataGridView1.DataSource = Me.PurchasesBindingSource
        Me.PurchasesDataGridView1.Location = New System.Drawing.Point(450, 67)
        Me.PurchasesDataGridView1.Name = "PurchasesDataGridView1"
        Me.PurchasesDataGridView1.Size = New System.Drawing.Size(740, 429)
        Me.PurchasesDataGridView1.TabIndex = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 247
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SRP"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "SRP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 54
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 48
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Amount"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Amount Due"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 91
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Expiry"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Expiry"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NCost"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Normal SRP"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 90
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Cost"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn16.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'remarks
        '
        Me.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.remarks.DataPropertyName = "remarks"
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.Width = 74
        '
        'discountM
        '
        Me.discountM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalRateToolStripMenuItem, Me.Apply2DiscountToolStripMenuItem, Me.Apply10DiscountToolStripMenuItem, Me.Apply20DiscountToolStripMenuItem, Me.ApplyCustomDiscountToolStripMenuItem, Me.ApplyMarkupToolStripMenuItem, Me.ApplyPesoValueToolStripMenuItem})
        Me.discountM.Name = "discountM"
        Me.discountM.Size = New System.Drawing.Size(201, 180)
        '
        'NormalRateToolStripMenuItem
        '
        Me.NormalRateToolStripMenuItem.Name = "NormalRateToolStripMenuItem"
        Me.NormalRateToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NormalRateToolStripMenuItem.Text = "Normal Rate"
        '
        'Apply2DiscountToolStripMenuItem
        '
        Me.Apply2DiscountToolStripMenuItem.Name = "Apply2DiscountToolStripMenuItem"
        Me.Apply2DiscountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.Apply2DiscountToolStripMenuItem.Text = "Apply 2% Discount"
        '
        'Apply10DiscountToolStripMenuItem
        '
        Me.Apply10DiscountToolStripMenuItem.Name = "Apply10DiscountToolStripMenuItem"
        Me.Apply10DiscountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.Apply10DiscountToolStripMenuItem.Text = "Apply 10% Discount"
        '
        'Apply20DiscountToolStripMenuItem
        '
        Me.Apply20DiscountToolStripMenuItem.Name = "Apply20DiscountToolStripMenuItem"
        Me.Apply20DiscountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.Apply20DiscountToolStripMenuItem.Text = "Apply 20% Discount"
        '
        'ApplyCustomDiscountToolStripMenuItem
        '
        Me.ApplyCustomDiscountToolStripMenuItem.Name = "ApplyCustomDiscountToolStripMenuItem"
        Me.ApplyCustomDiscountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ApplyCustomDiscountToolStripMenuItem.Text = "Apply Custom Discount"
        '
        'ApplyMarkupToolStripMenuItem
        '
        Me.ApplyMarkupToolStripMenuItem.Name = "ApplyMarkupToolStripMenuItem"
        Me.ApplyMarkupToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ApplyMarkupToolStripMenuItem.Text = "Apply Custom Markup"
        '
        'ApplyPesoValueToolStripMenuItem
        '
        Me.ApplyPesoValueToolStripMenuItem.Name = "ApplyPesoValueToolStripMenuItem"
        Me.ApplyPesoValueToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ApplyPesoValueToolStripMenuItem.Text = "Apply Peso Value"
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
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 706)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PurchasesDataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Lblname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grandlabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.changetxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.paymenttxt)
        Me.Controls.Add(Me.totalpaymenttxt)
        Me.Controls.Add(Me.subtotaltxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.totalcosttxt)
        Me.Controls.Add(Me.unitcosttxt)
        Me.Controls.Add(Me.quantitytxt)
        Me.Controls.Add(Me.itemnotxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lotview)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Searchbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        CType(Me.StockBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustumerTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.discountM.ResumeLayout(False)
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemnotxt As System.Windows.Forms.TextBox
    Friend WithEvents quantitytxt As System.Windows.Forms.TextBox
    Friend WithEvents unitcosttxt As System.Windows.Forms.TextBox
    Friend WithEvents totalcosttxt As System.Windows.Forms.TextBox
    Friend WithEvents paymenttxt As System.Windows.Forms.TextBox
    Friend WithEvents totalpaymenttxt As System.Windows.Forms.TextBox
    Friend WithEvents subtotaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents changetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grandlabel As System.Windows.Forms.Label
    Friend WithEvents PurchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustumerTable As Cedemed.CustumerTable
    Friend WithEvents CostumertblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostumertblTableAdapter As Cedemed.CustumerTableTableAdapters.CostumertblTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.CustumerTableTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents newb As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents genericnorm As System.Windows.Forms.RadioButton
    Friend WithEvents GenericmarkupLabel1 As System.Windows.Forms.Label
    Friend WithEvents genericdiscountcheck As System.Windows.Forms.RadioButton
    Friend WithEvents genericmarkupcheck As System.Windows.Forms.RadioButton
    Friend WithEvents GenericdiscountLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents otcnorm As System.Windows.Forms.RadioButton
    Friend WithEvents otcdiscountcheck As System.Windows.Forms.RadioButton
    Friend WithEvents OtcmarkupLabel1 As System.Windows.Forms.Label
    Friend WithEvents OtcdiscountLabel1 As System.Windows.Forms.Label
    Friend WithEvents otcmarkupcheck As System.Windows.Forms.RadioButton
    Friend WithEvents searchb As System.Windows.Forms.Button
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lblname As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents PurchasesDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
    Friend WithEvents discountM As ContextMenuStrip
    Friend WithEvents Apply2DiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Apply10DiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Apply20DiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyCustomDiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalRateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyMarkupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyPesoValueToolStripMenuItem As ToolStripMenuItem
End Class
