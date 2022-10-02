<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecieveStocks
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
        Dim FrombranchLabel As System.Windows.Forms.Label
        Dim TobranchLabel As System.Windows.Forms.Label
        Dim TransactionuserLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecieveStocks))
        Dim CommontransLabel As System.Windows.Forms.Label
        Me.ReceiveDataset = New Cedemed.ReceiveDataset()
        Me.RecevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecevTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter()
        Me.TableAdapterManager = New Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager()
        Me.RecevItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecevItemsTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter()
        Me.TransdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FrombranchTextBox = New System.Windows.Forms.TextBox()
        Me.TobranchTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionuserTextBox = New System.Windows.Forms.TextBox()
        Me.RecevItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CommontransTextBox = New System.Windows.Forms.TextBox()
        TransdateLabel = New System.Windows.Forms.Label()
        FrombranchLabel = New System.Windows.Forms.Label()
        TobranchLabel = New System.Windows.Forms.Label()
        TransactionuserLabel = New System.Windows.Forms.Label()
        CommontransLabel = New System.Windows.Forms.Label()
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransdateLabel
        '
        TransdateLabel.AutoSize = True
        TransdateLabel.Location = New System.Drawing.Point(12, 38)
        TransdateLabel.Name = "TransdateLabel"
        TransdateLabel.Size = New System.Drawing.Size(104, 13)
        TransdateLabel.TabIndex = 0
        TransdateLabel.Text = "Date of Transaction:"
        '
        'FrombranchLabel
        '
        FrombranchLabel.AutoSize = True
        FrombranchLabel.Location = New System.Drawing.Point(329, 39)
        FrombranchLabel.Name = "FrombranchLabel"
        FrombranchLabel.Size = New System.Drawing.Size(33, 13)
        FrombranchLabel.TabIndex = 2
        FrombranchLabel.Text = "From:"
        '
        'TobranchLabel
        '
        TobranchLabel.AutoSize = True
        TobranchLabel.Location = New System.Drawing.Point(339, 65)
        TobranchLabel.Name = "TobranchLabel"
        TobranchLabel.Size = New System.Drawing.Size(23, 13)
        TobranchLabel.TabIndex = 4
        TobranchLabel.Text = "To:"
        '
        'TransactionuserLabel
        '
        TransactionuserLabel.AutoSize = True
        TransactionuserLabel.Location = New System.Drawing.Point(31, 65)
        TransactionuserLabel.Name = "TransactionuserLabel"
        TransactionuserLabel.Size = New System.Drawing.Size(79, 13)
        TransactionuserLabel.TabIndex = 6
        TransactionuserLabel.Text = "Transferred By:"
        '
        'ReceiveDataset
        '
        Me.ReceiveDataset.DataSetName = "ReceiveDataset"
        Me.ReceiveDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecevBindingSource
        '
        Me.RecevBindingSource.DataMember = "Recev"
        Me.RecevBindingSource.DataSource = Me.ReceiveDataset
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
        'RecevItemsBindingSource
        '
        Me.RecevItemsBindingSource.DataMember = "Recev_RecevItems"
        Me.RecevItemsBindingSource.DataSource = Me.RecevBindingSource
        '
        'RecevItemsTableAdapter
        '
        Me.RecevItemsTableAdapter.ClearBeforeFill = True
        '
        'TransdateDateTimePicker
        '
        Me.TransdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecevBindingSource, "transdate", True))
        Me.TransdateDateTimePicker.Location = New System.Drawing.Point(116, 35)
        Me.TransdateDateTimePicker.Name = "TransdateDateTimePicker"
        Me.TransdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransdateDateTimePicker.TabIndex = 1
        '
        'FrombranchTextBox
        '
        Me.FrombranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecevBindingSource, "frombranch", True))
        Me.FrombranchTextBox.Location = New System.Drawing.Point(368, 36)
        Me.FrombranchTextBox.Name = "FrombranchTextBox"
        Me.FrombranchTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FrombranchTextBox.TabIndex = 3
        '
        'TobranchTextBox
        '
        Me.TobranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecevBindingSource, "tobranch", True))
        Me.TobranchTextBox.Location = New System.Drawing.Point(368, 62)
        Me.TobranchTextBox.Name = "TobranchTextBox"
        Me.TobranchTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TobranchTextBox.TabIndex = 5
        '
        'TransactionuserTextBox
        '
        Me.TransactionuserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecevBindingSource, "transactionuser", True))
        Me.TransactionuserTextBox.Location = New System.Drawing.Point(116, 62)
        Me.TransactionuserTextBox.Name = "TransactionuserTextBox"
        Me.TransactionuserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionuserTextBox.TabIndex = 7
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
        Me.RecevItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.RecevItemsDataGridView.DataSource = Me.RecevItemsBindingSource
        Me.RecevItemsDataGridView.Location = New System.Drawing.Point(12, 119)
        Me.RecevItemsDataGridView.Name = "RecevItemsDataGridView"
        Me.RecevItemsDataGridView.ReadOnly = True
        Me.RecevItemsDataGridView.Size = New System.Drawing.Size(741, 386)
        Me.RecevItemsDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDesc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn5.HeaderText = "Expiry Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "lotno"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lot No."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 62
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "invoice"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Invoice No."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.RecevBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(765, 25)
        Me.BindingNavigator1.TabIndex = 9
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(678, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CommontransLabel
        '
        CommontransLabel.AutoSize = True
        CommontransLabel.Location = New System.Drawing.Point(33, 91)
        CommontransLabel.Name = "CommontransLabel"
        CommontransLabel.Size = New System.Drawing.Size(77, 13)
        CommontransLabel.TabIndex = 11
        CommontransLabel.Text = "Reference No:"
        '
        'CommontransTextBox
        '
        Me.CommontransTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecevBindingSource, "commontrans", True))
        Me.CommontransTextBox.Location = New System.Drawing.Point(116, 88)
        Me.CommontransTextBox.Name = "CommontransTextBox"
        Me.CommontransTextBox.Size = New System.Drawing.Size(95, 20)
        Me.CommontransTextBox.TabIndex = 12
        '
        'RecieveStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 517)
        Me.Controls.Add(CommontransLabel)
        Me.Controls.Add(Me.CommontransTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.RecevItemsDataGridView)
        Me.Controls.Add(TransactionuserLabel)
        Me.Controls.Add(Me.TransactionuserTextBox)
        Me.Controls.Add(TobranchLabel)
        Me.Controls.Add(Me.TobranchTextBox)
        Me.Controls.Add(FrombranchLabel)
        Me.Controls.Add(Me.FrombranchTextBox)
        Me.Controls.Add(TransdateLabel)
        Me.Controls.Add(Me.TransdateDateTimePicker)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RecieveStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Received Stocks"
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReceiveDataset As Cedemed.ReceiveDataset
    Friend WithEvents RecevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager
    Friend WithEvents RecevItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevItemsTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter
    Friend WithEvents TransdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FrombranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TobranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionuserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecevItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommontransTextBox As System.Windows.Forms.TextBox
End Class
