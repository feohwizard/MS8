<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranferRecord
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
        Dim TransdateLabel As System.Windows.Forms.Label
        Dim TransactionuserLabel As System.Windows.Forms.Label
        Dim TobranchLabel As System.Windows.Forms.Label
        Dim TransidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TranferRecord))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransferBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransferDataset = New Cedemed.TransferDataset()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransferBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TransdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TransactionuserTextBox = New System.Windows.Forms.TextBox()
        Me.TobranchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TransidTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TranferItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsDataset = New Cedemed.ItemsDataset()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menuu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranferItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TransferTableAdapter = New Cedemed.TransferDatasetTableAdapters.TransferTableAdapter()
        Me.TranferItemsTableAdapter = New Cedemed.TransferDatasetTableAdapters.TranferItemsTableAdapter()
        Me.TableAdapterManager = New Cedemed.TransferDatasetTableAdapters.TableAdapterManager()
        Me.ItemsTableAdapter = New Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        TransdateLabel = New System.Windows.Forms.Label()
        TransactionuserLabel = New System.Windows.Forms.Label()
        TobranchLabel = New System.Windows.Forms.Label()
        TransidLabel = New System.Windows.Forms.Label()
        CType(Me.TransferBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransferBindingNavigator.SuspendLayout()
        CType(Me.TransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TranferItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuu.SuspendLayout()
        CType(Me.TranferItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransdateLabel
        '
        TransdateLabel.AutoSize = True
        TransdateLabel.Location = New System.Drawing.Point(12, 23)
        TransdateLabel.Name = "TransdateLabel"
        TransdateLabel.Size = New System.Drawing.Size(87, 13)
        TransdateLabel.TabIndex = 5
        TransdateLabel.Text = "Date of Transfer:"
        '
        'TransactionuserLabel
        '
        TransactionuserLabel.AutoSize = True
        TransactionuserLabel.Location = New System.Drawing.Point(12, 48)
        TransactionuserLabel.Name = "TransactionuserLabel"
        TransactionuserLabel.Size = New System.Drawing.Size(78, 13)
        TransactionuserLabel.TabIndex = 11
        TransactionuserLabel.Text = "Transferred by:"
        '
        'TobranchLabel
        '
        TobranchLabel.AutoSize = True
        TobranchLabel.Location = New System.Drawing.Point(12, 74)
        TobranchLabel.Name = "TobranchLabel"
        TobranchLabel.Size = New System.Drawing.Size(80, 13)
        TobranchLabel.TabIndex = 15
        TobranchLabel.Text = "Transferred To:"
        '
        'TransidLabel
        '
        TransidLabel.AutoSize = True
        TransidLabel.Location = New System.Drawing.Point(17, 100)
        TransidLabel.Name = "TransidLabel"
        TransidLabel.Size = New System.Drawing.Size(77, 13)
        TransidLabel.TabIndex = 22
        TransidLabel.Text = "Reference No:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Date"
        '
        'TransferBindingNavigator
        '
        Me.TransferBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransferBindingNavigator.BindingSource = Me.TransferBindingSource
        Me.TransferBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransferBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransferBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransferBindingNavigatorSaveItem})
        Me.TransferBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransferBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransferBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransferBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransferBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransferBindingNavigator.Name = "TransferBindingNavigator"
        Me.TransferBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransferBindingNavigator.Size = New System.Drawing.Size(773, 25)
        Me.TransferBindingNavigator.TabIndex = 2
        Me.TransferBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TransferBindingSource
        '
        Me.TransferBindingSource.DataMember = "Transfer"
        Me.TransferBindingSource.DataSource = Me.TransferDataset
        '
        'TransferDataset
        '
        Me.TransferDataset.DataSetName = "TransferDataset"
        Me.TransferDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TransferBindingNavigatorSaveItem
        '
        Me.TransferBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransferBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransferBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransferBindingNavigatorSaveItem.Name = "TransferBindingNavigatorSaveItem"
        Me.TransferBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TransferBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TransdateDateTimePicker
        '
        Me.TransdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransferBindingSource, "transdate", True))
        Me.TransdateDateTimePicker.Enabled = False
        Me.TransdateDateTimePicker.Location = New System.Drawing.Point(100, 19)
        Me.TransdateDateTimePicker.Name = "TransdateDateTimePicker"
        Me.TransdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransdateDateTimePicker.TabIndex = 6
        '
        'TransactionuserTextBox
        '
        Me.TransactionuserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransferBindingSource, "transactionuser", True))
        Me.TransactionuserTextBox.Enabled = False
        Me.TransactionuserTextBox.Location = New System.Drawing.Point(100, 45)
        Me.TransactionuserTextBox.Name = "TransactionuserTextBox"
        Me.TransactionuserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionuserTextBox.TabIndex = 12
        '
        'TobranchTextBox
        '
        Me.TobranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransferBindingSource, "tobranch", True))
        Me.TobranchTextBox.Enabled = False
        Me.TobranchTextBox.Location = New System.Drawing.Point(100, 71)
        Me.TobranchTextBox.Name = "TobranchTextBox"
        Me.TobranchTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TobranchTextBox.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(TransidLabel)
        Me.GroupBox1.Controls.Add(Me.TransidTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TranferItemsDataGridView)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TransdateDateTimePicker)
        Me.GroupBox1.Controls.Add(TransdateLabel)
        Me.GroupBox1.Controls.Add(Me.TobranchTextBox)
        Me.GroupBox1.Controls.Add(TobranchLabel)
        Me.GroupBox1.Controls.Add(TransactionuserLabel)
        Me.GroupBox1.Controls.Add(Me.TransactionuserTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 460)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(640, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Print with SRP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(559, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TransidTextBox
        '
        Me.TransidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransferBindingSource, "transid", True))
        Me.TransidTextBox.Location = New System.Drawing.Point(99, 97)
        Me.TransidTextBox.Name = "TransidTextBox"
        Me.TransidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransidTextBox.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 72)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "View Transfers Made Between Date Range"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 49)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(6, 46)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(478, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TranferItemsDataGridView
        '
        Me.TranferItemsDataGridView.AllowUserToAddRows = False
        Me.TranferItemsDataGridView.AllowUserToDeleteRows = False
        Me.TranferItemsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TranferItemsDataGridView.AutoGenerateColumns = False
        Me.TranferItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TranferItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TranferItemsDataGridView.ContextMenuStrip = Me.menuu
        Me.TranferItemsDataGridView.DataSource = Me.TranferItemsBindingSource
        Me.TranferItemsDataGridView.Location = New System.Drawing.Point(15, 145)
        Me.TranferItemsDataGridView.Name = "TranferItemsDataGridView"
        Me.TranferItemsDataGridView.ReadOnly = True
        Me.TranferItemsDataGridView.RowTemplate.Height = 24
        Me.TranferItemsDataGridView.Size = New System.Drawing.Size(721, 300)
        Me.TranferItemsDataGridView.TabIndex = 17
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
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.ItemsDatasetBindingSource
        '
        'ItemsDatasetBindingSource
        '
        Me.ItemsDatasetBindingSource.DataSource = Me.ItemsDataset
        Me.ItemsDatasetBindingSource.Position = 0
        '
        'ItemsDataset
        '
        Me.ItemsDataset.DataSetName = "ItemsDataset"
        Me.ItemsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'menuu
        '
        Me.menuu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeQuantityToolStripMenuItem, Me.DeleteItemToolStripMenuItem})
        Me.menuu.Name = "menuu"
        Me.menuu.Size = New System.Drawing.Size(181, 70)
        '
        'ChangeQuantityToolStripMenuItem
        '
        Me.ChangeQuantityToolStripMenuItem.Name = "ChangeQuantityToolStripMenuItem"
        Me.ChangeQuantityToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangeQuantityToolStripMenuItem.Text = "Change Quantity"
        '
        'TranferItemsBindingSource
        '
        Me.TranferItemsBindingSource.DataMember = "TranferItems"
        Me.TranferItemsBindingSource.DataSource = Me.TransferDataset
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Items Contained"
        '
        'TransferTableAdapter
        '
        Me.TransferTableAdapter.ClearBeforeFill = True
        '
        'TranferItemsTableAdapter
        '
        Me.TranferItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.TranferItemsTableAdapter = Nothing
        Me.TableAdapterManager.TransferTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cedemed.TransferDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Item"
        '
        'TranferRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TransferBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "TranferRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Record"
        CType(Me.TransferBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransferBindingNavigator.ResumeLayout(False)
        Me.TransferBindingNavigator.PerformLayout()
        CType(Me.TransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TranferItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuu.ResumeLayout(False)
        CType(Me.TranferItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransferDataset As Cedemed.TransferDataset
    Friend WithEvents TransferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransferTableAdapter As Cedemed.TransferDatasetTableAdapters.TransferTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.TransferDatasetTableAdapters.TableAdapterManager
    Friend WithEvents TransferBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransferBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransactionuserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TobranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TranferItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TranferItemsTableAdapter As Cedemed.TransferDatasetTableAdapters.TranferItemsTableAdapter
    Friend WithEvents TranferItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemsDataset As Cedemed.ItemsDataset
    Friend WithEvents ItemsDatasetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Cedemed.ItemsDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
    Friend WithEvents menuu As ContextMenuStrip
    Friend WithEvents ChangeQuantityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
End Class
