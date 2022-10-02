<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GovernmentRPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GovernmentRPT))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tod = New System.Windows.Forms.DateTimePicker()
        Me.from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransactionsDataset = New Cedemed.TransactionsDataset()
        Me.TransTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter()
        Me.SalesTableAdapter = New Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter()
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Generate  Gov't Sales Report"
        '
        'tod
        '
        Me.tod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tod.Location = New System.Drawing.Point(83, 79)
        Me.tod.Name = "tod"
        Me.tod.Size = New System.Drawing.Size(126, 20)
        Me.tod.TabIndex = 21
        '
        'from
        '
        Me.from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from.Location = New System.Drawing.Point(83, 53)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(126, 20)
        Me.from.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "From:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 46)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransactionsDataset
        '
        Me.TransactionsDataset.DataSetName = "TransactionsDataset"
        Me.TransactionsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransTableAdapter
        '
        Me.TransTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'GovernmentRPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(310, 111)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tod)
        Me.Controls.Add(Me.from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GovernmentRPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GovernmentRPT"
        CType(Me.TransactionsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tod As System.Windows.Forms.DateTimePicker
    Friend WithEvents from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TransactionsDataset As Cedemed.TransactionsDataset
    Friend WithEvents TransTableAdapter As Cedemed.TransactionsDatasetTableAdapters.TransTableAdapter
    Friend WithEvents SalesTableAdapter As Cedemed.TransactionsDatasetTableAdapters.SalesTableAdapter
End Class
