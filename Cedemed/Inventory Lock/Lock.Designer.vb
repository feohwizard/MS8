<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lock
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
        Me.LockBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.LockDS = New Cedemed.LockDS()
        Me.HoldTableAdapter = New Cedemed.LockDSTableAdapters.HoldTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.LockBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LockDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LockBS
        '
        Me.LockBS.DataMember = "Hold"
        Me.LockBS.DataSource = Me.LockDS
        '
        'LockDS
        '
        Me.LockDS.DataSetName = "LockDS"
        Me.LockDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldTableAdapter
        '
        Me.HoldTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Lock Inventory"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Unlock Inventory"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 122)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Lock"
        Me.Text = "Inventory Lock"
        CType(Me.LockBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LockDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LockBS As BindingSource
    Friend WithEvents LockDS As LockDS
    Friend WithEvents HoldTableAdapter As LockDSTableAdapters.HoldTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
