<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parser
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
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.TransactionsDataset = New Cedemed.TransactionsDataset()
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter()
        Me.TableAdapterManager = New Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager()
        Me.SalesTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProcessDataset = New Cedemed.ProcessDataset()
        Me.ProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProcessTableAdapter = New Cedemed.ProcessDatasetTableAdapters.ProcessTableAdapter()
        Me.TableAdapterManager1 = New Cedemed.ProcessDatasetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransferDataset = New Cedemed.TransferDataset()
        Me.TranferItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranferItemsTableAdapter = New Cedemed.TransferDatasetTableAdapters.TranferItemsTableAdapter()
        Me.TableAdapterManager2 = New Cedemed.TransferDatasetTableAdapters.TableAdapterManager()
        Me.TransferTableAdapter = New Cedemed.TransferDatasetTableAdapters.TransferTableAdapter()
        Me.TransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveDataset = New Cedemed.ReceiveDataset()
        Me.RecevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecevTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter()
        Me.TableAdapterManager3 = New Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager()
        Me.RecevItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecevItemsTableAdapter = New Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter()
        Me.worker = New System.ComponentModel.BackgroundWorker()
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcessDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranferItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'time
        '
        Me.time.Interval = 600
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
        Me.TableAdapterManager.TransTableAdapter = Me.TransTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.TransactionsDataset
        '
        'ProcessDataset
        '
        Me.ProcessDataset.DataSetName = "ProcessDataset"
        Me.ProcessDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProcessBindingSource
        '
        Me.ProcessBindingSource.DataMember = "Process"
        Me.ProcessBindingSource.DataSource = Me.ProcessDataset
        '
        'ProcessTableAdapter
        '
        Me.ProcessTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ProcessTableAdapter = Me.ProcessTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Cedemed.ProcessDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please keep this window open."
        '
        'TransferDataset
        '
        Me.TransferDataset.DataSetName = "TransferDataset"
        Me.TransferDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TranferItemsBindingSource
        '
        Me.TranferItemsBindingSource.DataMember = "TranferItems"
        Me.TranferItemsBindingSource.DataSource = Me.TransferDataset
        '
        'TranferItemsTableAdapter
        '
        Me.TranferItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.TranferItemsTableAdapter = Me.TranferItemsTableAdapter
        Me.TableAdapterManager2.TransferTableAdapter = Me.TransferTableAdapter
        Me.TableAdapterManager2.UpdateOrder = Cedemed.TransferDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransferTableAdapter
        '
        Me.TransferTableAdapter.ClearBeforeFill = True
        '
        'TransferBindingSource
        '
        Me.TransferBindingSource.DataMember = "Transfer"
        Me.TransferBindingSource.DataSource = Me.TransferDataset
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
        'TableAdapterManager3
        '
        'Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager3.RecevItemsTableAdapter = Nothing
        'Me.TableAdapterManager3.RecevTableAdapter = Me.RecevTableAdapter
        'Me.TableAdapterManager3.UpdateOrder = Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecevItemsBindingSource
        '
        Me.RecevItemsBindingSource.DataMember = "RecevItems"
        Me.RecevItemsBindingSource.DataSource = Me.ReceiveDataset
        '
        'RecevItemsTableAdapter
        '
        Me.RecevItemsTableAdapter.ClearBeforeFill = True
        '
        'worker
        '
        '
        'Parser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 406)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Parser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parser"
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcessDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranferItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecevItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents time As System.Windows.Forms.Timer
    Friend WithEvents TransactionsDataset As Cedemed.TransactionsDataset
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransTableAdapter As Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.TransactionsDatasetTableAdapters.TableAdapterManager
    Friend WithEvents SalesTableAdapter As Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProcessDataset As Cedemed.ProcessDataset
    Friend WithEvents ProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProcessTableAdapter As Cedemed.ProcessDatasetTableAdapters.ProcessTableAdapter
    Friend WithEvents TableAdapterManager1 As Cedemed.ProcessDatasetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransferDataset As Cedemed.TransferDataset
    Friend WithEvents TranferItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TranferItemsTableAdapter As Cedemed.TransferDatasetTableAdapters.TranferItemsTableAdapter
    Friend WithEvents TableAdapterManager2 As Cedemed.TransferDatasetTableAdapters.TableAdapterManager
    Friend WithEvents TransferTableAdapter As Cedemed.TransferDatasetTableAdapters.TransferTableAdapter
    Friend WithEvents TransferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiveDataset As Cedemed.ReceiveDataset
    Friend WithEvents RecevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevTableAdapter
    Friend WithEvents TableAdapterManager3 As Cedemed.ReceiveDatasetTableAdapters.TableAdapterManager
    Friend WithEvents RecevItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecevItemsTableAdapter As Cedemed.ReceiveDatasetTableAdapters.RecevItemsTableAdapter
    Friend WithEvents worker As System.ComponentModel.BackgroundWorker
End Class
