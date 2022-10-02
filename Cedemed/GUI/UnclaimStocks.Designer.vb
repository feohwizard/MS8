<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnclaimStocks
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
        Me.ReceiveDataset = New Cedemed.ReceiveDataset()
        Me.RecevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecevTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter()
        Me.TableAdapterManager = New Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager()
        Me.RecevDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecevItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecevItemsTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter()
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.RecevItemsTableAdapter = Nothing
        'Me.TableAdapterManager.RecevTableAdapter = Me.RecevTableAdapter
        'Me.TableAdapterManager.UpdateOrder = Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecevDataGridView
        '
        Me.RecevDataGridView.AllowUserToAddRows = False
        Me.RecevDataGridView.AllowUserToDeleteRows = False
        Me.RecevDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecevDataGridView.AutoGenerateColumns = False
        Me.RecevDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecevDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.RecevDataGridView.DataSource = Me.RecevBindingSource
        Me.RecevDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.RecevDataGridView.Name = "RecevDataGridView"
        Me.RecevDataGridView.ReadOnly = True
        Me.RecevDataGridView.RowTemplate.Height = 24
        Me.RecevDataGridView.Size = New System.Drawing.Size(890, 602)
        Me.RecevDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "commontrans"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reference No."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 115
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "transdate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Transaction Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "transactionuser"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Transaction User"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "frombranch"
        Me.DataGridViewTextBoxColumn5.HeaderText = "From Branch"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 105
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tobranch"
        Me.DataGridViewTextBoxColumn6.HeaderText = "To Branch"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 91
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
        'UnclaimStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 626)
        Me.Controls.Add(Me.RecevDataGridView)
        Me.Name = "UnclaimStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Unclaim Reference "
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReceiveDataset As Cedemed.ReceiveDataset
    Friend WithEvents RecevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager
    Friend WithEvents RecevDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecevItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevItemsTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter
End Class
