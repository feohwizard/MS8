<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockInSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockInSummary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.from = New System.Windows.Forms.DateTimePicker()
        Me.tod = New System.Windows.Forms.DateTimePicker()
        Me.itemcombo1 = New System.Windows.Forms.ComboBox()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataset = New Cedemed.InventoryDataset()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ItemsTableAdapter = New Cedemed.InventoryDatasetTableAdapters.ItemsTableAdapter()
        Me.StockInDataset = New Cedemed.StockInDataset()
        Me.PurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasesTableAdapter = New Cedemed.StockInDatasetTableAdapters.PurchasesTableAdapter()
        Me.TableAdapterManager = New Cedemed.StockInDatasetTableAdapters.TableAdapterManager()
        Me.invtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New Cedemed.InventoryDatasetTableAdapters.TableAdapterManager()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NearExpiry = New Cedemed.NearExpiry()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter1 = New Cedemed.NearExpiryTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager2 = New Cedemed.NearExpiryTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.typecombo2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.typecombo1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.typecombo3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockInDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NearExpiry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Item Type:"
        '
        'from
        '
        Me.from.Location = New System.Drawing.Point(79, 19)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(281, 20)
        Me.from.TabIndex = 4
        '
        'tod
        '
        Me.tod.Location = New System.Drawing.Point(79, 45)
        Me.tod.Name = "tod"
        Me.tod.Size = New System.Drawing.Size(281, 20)
        Me.tod.TabIndex = 5
        '
        'itemcombo1
        '
        Me.itemcombo1.DataSource = Me.ItemsBindingSource
        Me.itemcombo1.DisplayMember = "IDesc"
        Me.itemcombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemcombo1.FormattingEnabled = True
        Me.itemcombo1.Location = New System.Drawing.Point(79, 19)
        Me.itemcombo1.Name = "itemcombo1"
        Me.itemcombo1.Size = New System.Drawing.Size(281, 21)
        Me.itemcombo1.TabIndex = 6
        Me.itemcombo1.ValueMember = "ItemNo"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.InventoryDataset
        '
        'InventoryDataset
        '
        Me.InventoryDataset.DataSetName = "InventoryDataset"
        Me.InventoryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(381, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 81)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'StockInDataset
        '
        Me.StockInDataset.DataSetName = "StockInDataset"
        Me.StockInDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchasesBindingSource
        '
        Me.PurchasesBindingSource.DataMember = "Purchases"
        Me.PurchasesBindingSource.DataSource = Me.StockInDataset
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Cedemed.StockInDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'invtxt
        '
        Me.invtxt.Location = New System.Drawing.Point(82, 22)
        Me.invtxt.Name = "invtxt"
        Me.invtxt.Size = New System.Drawing.Size(100, 20)
        Me.invtxt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Invoice No.:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(381, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Generate"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Cedemed.InventoryDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(384, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Generate"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 319)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 53)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generate / Near Expiry"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(384, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Generate"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Generate Items that will expire in "
        '
        'NearExpiry
        '
        Me.NearExpiry.DataSetName = "NearExpiry"
        Me.NearExpiry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.NearExpiry
        '
        'ItemsTableAdapter1
        '
        Me.ItemsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = Cedemed.NearExpiryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.from)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tod)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 81)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Dates"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PowderBlue
        Me.GroupBox3.Controls.Add(Me.typecombo2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 57)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Generate Current Stocks"
        '
        'typecombo2
        '
        Me.typecombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typecombo2.FormattingEnabled = True
        Me.typecombo2.Items.AddRange(New Object() {"", "AV", "CT", "OE", "SU", "SY"})
        Me.typecombo2.Location = New System.Drawing.Point(79, 19)
        Me.typecombo2.Name = "typecombo2"
        Me.typecombo2.Size = New System.Drawing.Size(281, 21)
        Me.typecombo2.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox4.Controls.Add(Me.typecombo1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.itemcombo1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(482, 80)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Generate Stock In by Item Type and Product Type"
        '
        'typecombo1
        '
        Me.typecombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typecombo1.FormattingEnabled = True
        Me.typecombo1.Items.AddRange(New Object() {"AV", "CT", "OE", "SU", "SY"})
        Me.typecombo1.Location = New System.Drawing.Point(79, 46)
        Me.typecombo1.Name = "typecombo1"
        Me.typecombo1.Size = New System.Drawing.Size(281, 21)
        Me.typecombo1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Item Type:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.invtxt)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 252)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(482, 57)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Generate incoming Stock / Supplier Invioce No."
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(384, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Generate"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox6.Controls.Add(Me.typecombo3)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(482, 52)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Generate Price List / Item Type"
        '
        'typecombo3
        '
        Me.typecombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typecombo3.FormattingEnabled = True
        Me.typecombo3.Items.AddRange(New Object() {"AV", "CT", "OE", "SU", "SY"})
        Me.typecombo3.Location = New System.Drawing.Point(82, 19)
        Me.typecombo3.Name = "typecombo3"
        Me.typecombo3.Size = New System.Drawing.Size(281, 21)
        Me.typecombo3.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Item Type:"
        '
        'StockInSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 444)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "StockInSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Summary Report"
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockInDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NearExpiry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents from As System.Windows.Forms.DateTimePicker
    Friend WithEvents tod As System.Windows.Forms.DateTimePicker
    Friend WithEvents itemcombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryDataset As Cedemed.InventoryDataset
    Friend WithEvents ItemsTableAdapter As Cedemed.InventoryDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents StockInDataset As Cedemed.StockInDataset
    Friend WithEvents PurchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchasesTableAdapter As Cedemed.StockInDatasetTableAdapters.PurchasesTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.StockInDatasetTableAdapters.TableAdapterManager
    Friend WithEvents invtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager1 As Cedemed.InventoryDatasetTableAdapters.TableAdapterManager
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NearExpiry As Cedemed.NearExpiry
    Friend WithEvents ItemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter1 As Cedemed.NearExpiryTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager2 As Cedemed.NearExpiryTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents typecombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents typecombo2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents typecombo3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
