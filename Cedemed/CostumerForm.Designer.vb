<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostumerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CostumerForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CostumerDataset = New Cedemed.CostumerDataset()
        Me.CostumertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostumertblTableAdapter = New Cedemed.CostumerDatasetTableAdapters.CostumertblTableAdapter()
        Me.TableAdapterManager = New Cedemed.CostumerDatasetTableAdapters.TableAdapterManager()
        Me.CostumertblBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CostumertblBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CostumertblDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.CostumerDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostumertblBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CostumertblBindingNavigator.SuspendLayout()
        CType(Me.CostumertblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CostumerDataset
        '
        Me.CostumerDataset.DataSetName = "CostumerDataset"
        Me.CostumerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostumertblBindingSource
        '
        Me.CostumertblBindingSource.DataMember = "Costumertbl"
        Me.CostumertblBindingSource.DataSource = Me.CostumerDataset
        '
        'CostumertblTableAdapter
        '
        Me.CostumertblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CostumertblTableAdapter = Me.CostumertblTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cedemed.CostumerDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CostumertblBindingNavigator
        '
        Me.CostumertblBindingNavigator.AddNewItem = Nothing
        Me.CostumertblBindingNavigator.BindingSource = Me.CostumertblBindingSource
        Me.CostumertblBindingNavigator.CountItem = Nothing
        Me.CostumertblBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CostumertblBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CostumertblBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.CostumertblBindingNavigatorSaveItem})
        Me.CostumertblBindingNavigator.Location = New System.Drawing.Point(12, 35)
        Me.CostumertblBindingNavigator.MoveFirstItem = Nothing
        Me.CostumertblBindingNavigator.MoveLastItem = Nothing
        Me.CostumertblBindingNavigator.MoveNextItem = Nothing
        Me.CostumertblBindingNavigator.MovePreviousItem = Nothing
        Me.CostumertblBindingNavigator.Name = "CostumertblBindingNavigator"
        Me.CostumertblBindingNavigator.PositionItem = Nothing
        Me.CostumertblBindingNavigator.Size = New System.Drawing.Size(58, 25)
        Me.CostumertblBindingNavigator.TabIndex = 0
        Me.CostumertblBindingNavigator.Text = "BindingNavigator1"
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
        'CostumertblBindingNavigatorSaveItem
        '
        Me.CostumertblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CostumertblBindingNavigatorSaveItem.Image = CType(resources.GetObject("CostumertblBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CostumertblBindingNavigatorSaveItem.Name = "CostumertblBindingNavigatorSaveItem"
        Me.CostumertblBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CostumertblBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CostumertblDataGridView
        '
        Me.CostumertblDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostumertblDataGridView.AutoGenerateColumns = False
        Me.CostumertblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CostumertblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CostumertblDataGridView.DataSource = Me.CostumertblBindingSource
        Me.CostumertblDataGridView.Location = New System.Drawing.Point(12, 62)
        Me.CostumertblDataGridView.Name = "CostumertblDataGridView"
        Me.CostumertblDataGridView.Size = New System.Drawing.Size(803, 351)
        Me.CostumertblDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Costumer Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 98
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "otcdiscount"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "OTC Discount Rate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 115
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "genericdiscount"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Generic Discount Rate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 107
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "otcmarkup"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "OTC Markup"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 86
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "genericmarkup"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Generic Markup"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fillter:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(46, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(434, 20)
        Me.TextBox1.TabIndex = 3
        '
        'CostumerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 425)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CostumertblDataGridView)
        Me.Controls.Add(Me.CostumertblBindingNavigator)
        Me.Name = "CostumerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costumer Inventory Form"
        CType(Me.CostumerDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostumertblBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CostumertblBindingNavigator.ResumeLayout(False)
        Me.CostumertblBindingNavigator.PerformLayout()
        CType(Me.CostumertblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CostumerDataset As Cedemed.CostumerDataset
    Friend WithEvents CostumertblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostumertblTableAdapter As Cedemed.CostumerDatasetTableAdapters.CostumertblTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.CostumerDatasetTableAdapters.TableAdapterManager
    Friend WithEvents CostumertblBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CostumertblBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CostumertblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
