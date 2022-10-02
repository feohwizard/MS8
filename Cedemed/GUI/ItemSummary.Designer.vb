<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemSummary
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.from = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tod = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.itemcombo1 = New System.Windows.Forms.ComboBox()
        Me.ItemsDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataset = New Cedemed.InventoryDataset()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockInDataset = New Cedemed.StockInDataset()
        Me.PurchasesTableAdapter = New Cedemed.StockInDatasetTableAdapters.PurchasesTableAdapter()
        Me.ItemsTableAdapter = New Cedemed.InventoryDatasetTableAdapters.ItemsTableAdapter()
        Me.ItemsDescriptionTableAdapter = New Cedemed.InventoryDatasetTableAdapters.ItemsDescriptionTableAdapter()
        Me.BalanceBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalanceTableAdapter = New Cedemed.StockInDatasetTableAdapters.BalanceTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ItemsDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockInDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.from)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tod)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 81)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Dates"
        '
        'from
        '
        Me.from.Location = New System.Drawing.Point(79, 19)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(281, 20)
        Me.from.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To:"
        '
        'tod
        '
        Me.tod.Location = New System.Drawing.Point(79, 45)
        Me.tod.Name = "tod"
        Me.tod.Size = New System.Drawing.Size(281, 20)
        Me.tod.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 76)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.itemcombo1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(482, 60)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Generate Stock In by Item Type and Product Type"
        '
        'itemcombo1
        '
        Me.itemcombo1.DataSource = Me.ItemsDescriptionBindingSource
        Me.itemcombo1.DisplayMember = "IDesc"
        Me.itemcombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemcombo1.FormattingEnabled = True
        Me.itemcombo1.Location = New System.Drawing.Point(79, 19)
        Me.itemcombo1.Name = "itemcombo1"
        Me.itemcombo1.Size = New System.Drawing.Size(281, 21)
        Me.itemcombo1.TabIndex = 6
        Me.itemcombo1.ValueMember = "IDesc"
        '
        'ItemsDescriptionBindingSource
        '
        Me.ItemsDescriptionBindingSource.DataMember = "ItemsDescription"
        Me.ItemsDescriptionBindingSource.DataSource = Me.InventoryDataset
        '
        'InventoryDataset
        '
        Me.InventoryDataset.DataSetName = "InventoryDataset"
        Me.InventoryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(391, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.InventoryDatasetBindingSource
        '
        'InventoryDatasetBindingSource
        '
        Me.InventoryDatasetBindingSource.DataSource = Me.InventoryDataset
        Me.InventoryDatasetBindingSource.Position = 0
        '
        'PurchaseBS
        '
        Me.PurchaseBS.DataMember = "Purchases"
        Me.PurchaseBS.DataSource = Me.StockInDataset
        '
        'StockInDataset
        '
        Me.StockInDataset.DataSetName = "StockInDataset"
        Me.StockInDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ItemsDescriptionTableAdapter
        '
        Me.ItemsDescriptionTableAdapter.ClearBeforeFill = True
        '
        'BalanceBS
        '
        Me.BalanceBS.DataMember = "Balance"
        Me.BalanceBS.DataSource = Me.StockInDataset
        '
        'BalanceTableAdapter
        '
        Me.BalanceTableAdapter.ClearBeforeFill = True
        '
        'ItemSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 174)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ItemSummary"
        Me.Text = "Item History"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ItemsDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockInDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents from As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tod As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents itemcombo1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PurchaseBS As BindingSource
    Friend WithEvents StockInDataset As StockInDataset
    Friend WithEvents PurchasesTableAdapter As StockInDatasetTableAdapters.PurchasesTableAdapter
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents InventoryDatasetBindingSource As BindingSource
    Friend WithEvents InventoryDataset As InventoryDataset
    Friend WithEvents ItemsTableAdapter As InventoryDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents ItemsDescriptionBindingSource As BindingSource
    Friend WithEvents ItemsDescriptionTableAdapter As InventoryDatasetTableAdapters.ItemsDescriptionTableAdapter
    Friend WithEvents BalanceBS As BindingSource
    Friend WithEvents BalanceTableAdapter As StockInDatasetTableAdapters.BalanceTableAdapter
End Class
