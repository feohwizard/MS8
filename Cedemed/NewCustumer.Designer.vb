<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustumer
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
        Dim OtcdiscountLabel As System.Windows.Forms.Label
        Dim GenericdiscountLabel As System.Windows.Forms.Label
        Dim OtcmarkupLabel As System.Windows.Forms.Label
        Dim GenericmarkupLabel As System.Windows.Forms.Label
        Me.CustumerTable = New Cedemed.CustumerTable()
        Me.CostumertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostumertblTableAdapter = New Cedemed.CustumerTableTableAdapters.CostumertblTableAdapter()
        Me.TableAdapterManager = New Cedemed.CustumerTableTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.OtcdiscountTextBox = New System.Windows.Forms.TextBox()
        Me.GenericdiscountTextBox = New System.Windows.Forms.TextBox()
        Me.OtcmarkupTextBox = New System.Windows.Forms.TextBox()
        Me.GenericmarkupTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        OtcdiscountLabel = New System.Windows.Forms.Label()
        GenericdiscountLabel = New System.Windows.Forms.Label()
        OtcmarkupLabel = New System.Windows.Forms.Label()
        GenericmarkupLabel = New System.Windows.Forms.Label()
        CType(Me.CustumerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(21, 26)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(85, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Customer Name:"
        '
        'OtcdiscountLabel
        '
        OtcdiscountLabel.AutoSize = True
        OtcdiscountLabel.Location = New System.Drawing.Point(21, 52)
        OtcdiscountLabel.Name = "OtcdiscountLabel"
        OtcdiscountLabel.Size = New System.Drawing.Size(77, 13)
        OtcdiscountLabel.TabIndex = 5
        OtcdiscountLabel.Text = "OTC Discount:"
        '
        'GenericdiscountLabel
        '
        GenericdiscountLabel.AutoSize = True
        GenericdiscountLabel.Location = New System.Drawing.Point(21, 78)
        GenericdiscountLabel.Name = "GenericdiscountLabel"
        GenericdiscountLabel.Size = New System.Drawing.Size(92, 13)
        GenericdiscountLabel.TabIndex = 7
        GenericdiscountLabel.Text = "Generic Discount:"
        '
        'OtcmarkupLabel
        '
        OtcmarkupLabel.AutoSize = True
        OtcmarkupLabel.Location = New System.Drawing.Point(21, 104)
        OtcmarkupLabel.Name = "OtcmarkupLabel"
        OtcmarkupLabel.Size = New System.Drawing.Size(71, 13)
        OtcmarkupLabel.TabIndex = 9
        OtcmarkupLabel.Text = "OTC Markup:"
        '
        'GenericmarkupLabel
        '
        GenericmarkupLabel.AutoSize = True
        GenericmarkupLabel.Location = New System.Drawing.Point(21, 130)
        GenericmarkupLabel.Name = "GenericmarkupLabel"
        GenericmarkupLabel.Size = New System.Drawing.Size(86, 13)
        GenericmarkupLabel.TabIndex = 11
        GenericmarkupLabel.Text = "Generic Markup:"
        '
        'CustumerTable
        '
        Me.CustumerTable.DataSetName = "CustumerTable"
        Me.CustumerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostumertblBindingSource
        '
        Me.CostumertblBindingSource.DataMember = "Costumertbl"
        Me.CostumertblBindingSource.DataSource = Me.CustumerTable
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
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(113, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(250, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'OtcdiscountTextBox
        '
        Me.OtcdiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "otcdiscount", True))
        Me.OtcdiscountTextBox.Location = New System.Drawing.Point(113, 49)
        Me.OtcdiscountTextBox.Name = "OtcdiscountTextBox"
        Me.OtcdiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OtcdiscountTextBox.TabIndex = 6
        '
        'GenericdiscountTextBox
        '
        Me.GenericdiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "genericdiscount", True))
        Me.GenericdiscountTextBox.Location = New System.Drawing.Point(113, 75)
        Me.GenericdiscountTextBox.Name = "GenericdiscountTextBox"
        Me.GenericdiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenericdiscountTextBox.TabIndex = 8
        '
        'OtcmarkupTextBox
        '
        Me.OtcmarkupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "otcmarkup", True))
        Me.OtcmarkupTextBox.Location = New System.Drawing.Point(113, 101)
        Me.OtcmarkupTextBox.Name = "OtcmarkupTextBox"
        Me.OtcmarkupTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OtcmarkupTextBox.TabIndex = 10
        '
        'GenericmarkupTextBox
        '
        Me.GenericmarkupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumertblBindingSource, "genericmarkup", True))
        Me.GenericmarkupTextBox.Location = New System.Drawing.Point(113, 127)
        Me.GenericmarkupTextBox.Name = "GenericmarkupTextBox"
        Me.GenericmarkupTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenericmarkupTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NewCustumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 174)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(OtcdiscountLabel)
        Me.Controls.Add(Me.OtcdiscountTextBox)
        Me.Controls.Add(GenericdiscountLabel)
        Me.Controls.Add(Me.GenericdiscountTextBox)
        Me.Controls.Add(OtcmarkupLabel)
        Me.Controls.Add(Me.OtcmarkupTextBox)
        Me.Controls.Add(GenericmarkupLabel)
        Me.Controls.Add(Me.GenericmarkupTextBox)
        Me.Name = "NewCustumer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Customer"
        CType(Me.CustumerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostumertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustumerTable As Cedemed.CustumerTable
    Friend WithEvents CostumertblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostumertblTableAdapter As Cedemed.CustumerTableTableAdapters.CostumertblTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.CustumerTableTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtcdiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericdiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtcmarkupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericmarkupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
