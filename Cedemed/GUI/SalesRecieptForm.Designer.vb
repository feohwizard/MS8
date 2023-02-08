<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesRecieptForm
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
        Dim TotalLabel As System.Windows.Forms.Label
        Dim CustNameLabel As System.Windows.Forms.Label
        Dim TransDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesRecieptForm))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TransactionsDataset = New Cedemed.TransactionsDataset()
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter()
        Me.TableAdapterManager = New Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager()
        Me.SalesTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter()
        Me.TransNoTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.CustNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TransDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TransNoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CustNameLabel = New System.Windows.Forms.Label()
        TransDateLabel = New System.Windows.Forms.Label()
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransNoLabel
        '
        TransNoLabel.AutoSize = True
        TransNoLabel.Location = New System.Drawing.Point(15, 65)
        TransNoLabel.Name = "TransNoLabel"
        TransNoLabel.Size = New System.Drawing.Size(77, 13)
        TransNoLabel.TabIndex = 5
        TransNoLabel.Text = "Reference No:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(58, 143)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 9
        TotalLabel.Text = "Total:"
        '
        'CustNameLabel
        '
        CustNameLabel.AutoSize = True
        CustNameLabel.Location = New System.Drawing.Point(38, 117)
        CustNameLabel.Name = "CustNameLabel"
        CustNameLabel.Size = New System.Drawing.Size(54, 13)
        CustNameLabel.TabIndex = 11
        CustNameLabel.Text = "Customer:"
        '
        'TransDateLabel
        '
        TransDateLabel.AutoSize = True
        TransDateLabel.Location = New System.Drawing.Point(59, 94)
        TransDateLabel.Name = "TransDateLabel"
        TransDateLabel.Size = New System.Drawing.Size(33, 13)
        TransDateLabel.TabIndex = 14
        TransDateLabel.Text = "Date:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(22, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CASH"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(107, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "CHECK"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(208, 26)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "CHARGE"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(298, 26)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "GOV'T"
        Me.RadioButton4.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.Trans1TableAdapter = Nothing
        Me.TableAdapterManager.TransTableAdapter = Me.TransTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TransNoTextBox
        '
        Me.TransNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransBindingSource, "TransNo", True))
        Me.TransNoTextBox.Location = New System.Drawing.Point(98, 62)
        Me.TransNoTextBox.Name = "TransNoTextBox"
        Me.TransNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransNoTextBox.TabIndex = 6
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(98, 140)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 10
        '
        'CustNameTextBox
        '
        Me.CustNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransBindingSource, "CustName", True))
        Me.CustNameTextBox.Location = New System.Drawing.Point(98, 114)
        Me.CustNameTextBox.Name = "CustNameTextBox"
        Me.CustNameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.CustNameTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(304, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(304, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 45)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Post"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TransDateDateTimePicker
        '
        Me.TransDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransBindingSource, "TransDate", True))
        Me.TransDateDateTimePicker.Enabled = False
        Me.TransDateDateTimePicker.Location = New System.Drawing.Point(98, 88)
        Me.TransDateDateTimePicker.Name = "TransDateDateTimePicker"
        Me.TransDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransDateDateTimePicker.TabIndex = 15
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "FK_Trans_Sales"
        Me.SalesBindingSource.DataSource = Me.TransBindingSource
        '
        'SalesDataGridView
        '
        Me.SalesDataGridView.AllowUserToAddRows = False
        Me.SalesDataGridView.AllowUserToDeleteRows = False
        Me.SalesDataGridView.AutoGenerateColumns = False
        Me.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SalesDataGridView.DataSource = Me.SalesBindingSource
        Me.SalesDataGridView.Location = New System.Drawing.Point(18, 182)
        Me.SalesDataGridView.Name = "SalesDataGridView"
        Me.SalesDataGridView.ReadOnly = True
        Me.SalesDataGridView.RowTemplate.Height = 24
        Me.SalesDataGridView.Size = New System.Drawing.Size(699, 241)
        Me.SalesDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SalesNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SalesNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TransNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TransNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SalesDT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SalesDT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ItemNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ItemNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UCost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UCost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitSold"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UnitSold"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PS"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "PS"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SRP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SRP"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "expiry"
        Me.DataGridViewTextBoxColumn8.HeaderText = "expiry"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "lotno"
        Me.DataGridViewTextBoxColumn9.HeaderText = "lotno"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn10.HeaderText = "total"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'SalesRecieptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.SalesDataGridView)
        Me.Controls.Add(TransDateLabel)
        Me.Controls.Add(Me.TransDateDateTimePicker)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CustNameLabel)
        Me.Controls.Add(Me.CustNameTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(TransNoLabel)
        Me.Controls.Add(Me.TransNoTextBox)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesRecieptForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Receipt"
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents TransactionsDataset As Cedemed.TransactionsDataset
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransTableAdapter As Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager
    Friend WithEvents TransNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TransDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter
    Friend WithEvents SalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
