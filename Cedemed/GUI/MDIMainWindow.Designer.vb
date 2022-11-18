<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIMAINWINDOW
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMAINWINDOW))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.TSMAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemRestrictionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMRPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMISalesRPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyCashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMICasherRPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryRPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockSummaryReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorReportsTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GovtSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTransfersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUnClaimedStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksReceivedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryInitializationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManufacturerDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchCurrentInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TSBSales = New System.Windows.Forms.ToolStripButton()
        Me.TSBStockIn = New System.Windows.Forms.ToolStripButton()
        Me.TSBTransfer = New System.Windows.Forms.ToolStripButton()
        Me.tsbClaim = New System.Windows.Forms.ToolStripButton()
        Me.refbtn = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSuserlevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.UsersRestrictionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RistrictionDataSet = New Cedemed.RistrictionDataSet()
        Me.UsersRestrictionTableAdapter = New Cedemed.RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter()
        Me.TableAdapterManager = New Cedemed.RistrictionDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.UsersRestrictionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RistrictionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMAdmin, Me.TSMRPT, Me.TSMMaintenance, Me.BranchInventoryToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(863, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'TSMAdmin
        '
        Me.TSMAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterFileToolStripMenuItem, Me.PasswordToolStripMenuItem, Me.InventoryLockToolStripMenuItem, Me.InventoryCheckToolStripMenuItem, Me.ItemRestrictionToolStripMenuItem})
        Me.TSMAdmin.Name = "TSMAdmin"
        Me.TSMAdmin.Size = New System.Drawing.Size(92, 20)
        Me.TSMAdmin.Text = "&Administrator"
        '
        'MasterFileToolStripMenuItem
        '
        Me.MasterFileToolStripMenuItem.Name = "MasterFileToolStripMenuItem"
        Me.MasterFileToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.MasterFileToolStripMenuItem.Text = "Master File"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PasswordToolStripMenuItem.Text = "Manage User Password"
        '
        'InventoryLockToolStripMenuItem
        '
        Me.InventoryLockToolStripMenuItem.Name = "InventoryLockToolStripMenuItem"
        Me.InventoryLockToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.InventoryLockToolStripMenuItem.Text = "Inventory Lock"
        Me.InventoryLockToolStripMenuItem.Visible = False
        '
        'InventoryCheckToolStripMenuItem
        '
        Me.InventoryCheckToolStripMenuItem.Name = "InventoryCheckToolStripMenuItem"
        Me.InventoryCheckToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.InventoryCheckToolStripMenuItem.Text = "Inventory Check"
        Me.InventoryCheckToolStripMenuItem.Visible = False
        '
        'ItemRestrictionToolStripMenuItem
        '
        Me.ItemRestrictionToolStripMenuItem.Name = "ItemRestrictionToolStripMenuItem"
        Me.ItemRestrictionToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ItemRestrictionToolStripMenuItem.Text = "Item Restriction"
        Me.ItemRestrictionToolStripMenuItem.Visible = False
        '
        'TSMRPT
        '
        Me.TSMRPT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMISalesRPT, Me.TSMICasherRPT, Me.SummaryRPT, Me.AdministratorReportsTSMI, Me.StockTransfersToolStripMenuItem, Me.ViewUnClaimedStocksToolStripMenuItem, Me.StocksReceivedToolStripMenuItem, Me.ItemHistoryToolStripMenuItem})
        Me.TSMRPT.Name = "TSMRPT"
        Me.TSMRPT.Size = New System.Drawing.Size(59, 20)
        Me.TSMRPT.Text = "&Reports"
        '
        'TSMISalesRPT
        '
        Me.TSMISalesRPT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyCashToolStripMenuItem})
        Me.TSMISalesRPT.Name = "TSMISalesRPT"
        Me.TSMISalesRPT.Size = New System.Drawing.Size(201, 22)
        Me.TSMISalesRPT.Text = "Sales Report"
        '
        'DailyCashToolStripMenuItem
        '
        Me.DailyCashToolStripMenuItem.Name = "DailyCashToolStripMenuItem"
        Me.DailyCashToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DailyCashToolStripMenuItem.Text = "Daily Sales"
        '
        'TSMICasherRPT
        '
        Me.TSMICasherRPT.Name = "TSMICasherRPT"
        Me.TSMICasherRPT.Size = New System.Drawing.Size(201, 22)
        Me.TSMICasherRPT.Text = "Cashers Report"
        '
        'SummaryRPT
        '
        Me.SummaryRPT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockSummaryReportsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.SummaryRPT.Name = "SummaryRPT"
        Me.SummaryRPT.Size = New System.Drawing.Size(201, 22)
        Me.SummaryRPT.Text = "Summary Reports"
        '
        'StockSummaryReportsToolStripMenuItem
        '
        Me.StockSummaryReportsToolStripMenuItem.Name = "StockSummaryReportsToolStripMenuItem"
        Me.StockSummaryReportsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.StockSummaryReportsToolStripMenuItem.Text = "Stock Summary Reports"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem1.Text = "Customers Sales Report"
        '
        'AdministratorReportsTSMI
        '
        Me.AdministratorReportsTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminSalesReportToolStripMenuItem, Me.GovtSalesReportToolStripMenuItem})
        Me.AdministratorReportsTSMI.Name = "AdministratorReportsTSMI"
        Me.AdministratorReportsTSMI.Size = New System.Drawing.Size(201, 22)
        Me.AdministratorReportsTSMI.Text = "Administrator Reports"
        '
        'AdminSalesReportToolStripMenuItem
        '
        Me.AdminSalesReportToolStripMenuItem.Name = "AdminSalesReportToolStripMenuItem"
        Me.AdminSalesReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdminSalesReportToolStripMenuItem.Text = "Admin Sales Report"
        '
        'GovtSalesReportToolStripMenuItem
        '
        Me.GovtSalesReportToolStripMenuItem.Name = "GovtSalesReportToolStripMenuItem"
        Me.GovtSalesReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GovtSalesReportToolStripMenuItem.Text = "Gov't Sales Report"
        '
        'StockTransfersToolStripMenuItem
        '
        Me.StockTransfersToolStripMenuItem.Name = "StockTransfersToolStripMenuItem"
        Me.StockTransfersToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.StockTransfersToolStripMenuItem.Text = "Stock Transfers"
        '
        'ViewUnClaimedStocksToolStripMenuItem
        '
        Me.ViewUnClaimedStocksToolStripMenuItem.Name = "ViewUnClaimedStocksToolStripMenuItem"
        Me.ViewUnClaimedStocksToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ViewUnClaimedStocksToolStripMenuItem.Text = "View Un Claimed Stocks"
        '
        'StocksReceivedToolStripMenuItem
        '
        Me.StocksReceivedToolStripMenuItem.Name = "StocksReceivedToolStripMenuItem"
        Me.StocksReceivedToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.StocksReceivedToolStripMenuItem.Text = "Stocks Received"
        '
        'ItemHistoryToolStripMenuItem
        '
        Me.ItemHistoryToolStripMenuItem.Name = "ItemHistoryToolStripMenuItem"
        Me.ItemHistoryToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ItemHistoryToolStripMenuItem.Text = "Item History"
        '
        'TSMMaintenance
        '
        Me.TSMMaintenance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryInitializationToolStripMenuItem1, Me.ProductDirectoryToolStripMenuItem, Me.SupplierDirectoryToolStripMenuItem, Me.ManufacturerDirectoryToolStripMenuItem})
        Me.TSMMaintenance.Name = "TSMMaintenance"
        Me.TSMMaintenance.Size = New System.Drawing.Size(88, 20)
        Me.TSMMaintenance.Text = "&Maintenance"
        '
        'InventoryInitializationToolStripMenuItem1
        '
        Me.InventoryInitializationToolStripMenuItem1.Name = "InventoryInitializationToolStripMenuItem1"
        Me.InventoryInitializationToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.InventoryInitializationToolStripMenuItem1.Text = "Inventory Initialization"
        '
        'ProductDirectoryToolStripMenuItem
        '
        Me.ProductDirectoryToolStripMenuItem.Name = "ProductDirectoryToolStripMenuItem"
        Me.ProductDirectoryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ProductDirectoryToolStripMenuItem.Text = "Product Directory"
        '
        'SupplierDirectoryToolStripMenuItem
        '
        Me.SupplierDirectoryToolStripMenuItem.Name = "SupplierDirectoryToolStripMenuItem"
        Me.SupplierDirectoryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SupplierDirectoryToolStripMenuItem.Text = "Supplier Directory"
        '
        'ManufacturerDirectoryToolStripMenuItem
        '
        Me.ManufacturerDirectoryToolStripMenuItem.Name = "ManufacturerDirectoryToolStripMenuItem"
        Me.ManufacturerDirectoryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ManufacturerDirectoryToolStripMenuItem.Text = "Manufacturer Directory"
        '
        'BranchInventoryToolStripMenuItem
        '
        Me.BranchInventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BranchCurrentInventoryToolStripMenuItem})
        Me.BranchInventoryToolStripMenuItem.Name = "BranchInventoryToolStripMenuItem"
        Me.BranchInventoryToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.BranchInventoryToolStripMenuItem.Text = "Branch Inventory"
        '
        'BranchCurrentInventoryToolStripMenuItem
        '
        Me.BranchCurrentInventoryToolStripMenuItem.Name = "BranchCurrentInventoryToolStripMenuItem"
        Me.BranchCurrentInventoryToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BranchCurrentInventoryToolStripMenuItem.Text = "Branch Current Inventory"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.LogOutToolStripMenuItem.Text = "&Log-Out"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBSales, Me.TSBStockIn, Me.TSBTransfer, Me.tsbClaim, Me.refbtn})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(863, 90)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'TSBSales
        '
        Me.TSBSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TSBSales.Image = CType(resources.GetObject("TSBSales.Image"), System.Drawing.Image)
        Me.TSBSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBSales.ImageTransparentColor = System.Drawing.Color.Black
        Me.TSBSales.Name = "TSBSales"
        Me.TSBSales.Padding = New System.Windows.Forms.Padding(10)
        Me.TSBSales.Size = New System.Drawing.Size(72, 87)
        Me.TSBSales.Text = "Sales"
        Me.TSBSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBStockIn
        '
        Me.TSBStockIn.Image = CType(resources.GetObject("TSBStockIn.Image"), System.Drawing.Image)
        Me.TSBStockIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBStockIn.ImageTransparentColor = System.Drawing.Color.Black
        Me.TSBStockIn.Name = "TSBStockIn"
        Me.TSBStockIn.Padding = New System.Windows.Forms.Padding(10)
        Me.TSBStockIn.Size = New System.Drawing.Size(73, 87)
        Me.TSBStockIn.Text = "Stock In"
        Me.TSBStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBTransfer
        '
        Me.TSBTransfer.Image = CType(resources.GetObject("TSBTransfer.Image"), System.Drawing.Image)
        Me.TSBTransfer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTransfer.ImageTransparentColor = System.Drawing.Color.Black
        Me.TSBTransfer.Name = "TSBTransfer"
        Me.TSBTransfer.Size = New System.Drawing.Size(84, 87)
        Me.TSBTransfer.Text = "Stock Transfer"
        Me.TSBTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbClaim
        '
        Me.tsbClaim.Image = CType(resources.GetObject("tsbClaim.Image"), System.Drawing.Image)
        Me.tsbClaim.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbClaim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClaim.Name = "tsbClaim"
        Me.tsbClaim.Size = New System.Drawing.Size(79, 87)
        Me.tsbClaim.Text = "Claim Stocks"
        Me.tsbClaim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'refbtn
        '
        Me.refbtn.Image = CType(resources.GetObject("refbtn.Image"), System.Drawing.Image)
        Me.refbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.refbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refbtn.Name = "refbtn"
        Me.refbtn.Size = New System.Drawing.Size(68, 87)
        Me.refbtn.Text = "References"
        Me.refbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.refbtn.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.TSSUsername, Me.TSSUser, Me.ToolStripStatusLabel1, Me.TSSuserlevel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 481)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(863, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'TSSUsername
        '
        Me.TSSUsername.Name = "TSSUsername"
        Me.TSSUsername.Size = New System.Drawing.Size(69, 17)
        Me.TSSUsername.Text = "User name :"
        '
        'TSSUser
        '
        Me.TSSUser.Name = "TSSUser"
        Me.TSSUser.Size = New System.Drawing.Size(41, 17)
        Me.TSSUser.Text = "admin"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel1.Text = "User Level :"
        '
        'TSSuserlevel
        '
        Me.TSSuserlevel.Name = "TSSuserlevel"
        Me.TSSuserlevel.Size = New System.Drawing.Size(0, 17)
        '
        'UsersRestrictionBindingSource
        '
        Me.UsersRestrictionBindingSource.DataMember = "UsersRestriction"
        Me.UsersRestrictionBindingSource.DataSource = Me.RistrictionDataSet
        '
        'RistrictionDataSet
        '
        Me.RistrictionDataSet.DataSetName = "RistrictionDataSet"
        Me.RistrictionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersRestrictionTableAdapter
        '
        Me.UsersRestrictionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Cedemed.RistrictionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersRestrictionTableAdapter = Me.UsersRestrictionTableAdapter
        '
        'MDIMAINWINDOW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(863, 503)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MDIMAINWINDOW"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.UsersRestrictionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RistrictionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents TSBSales As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TSBStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TSMAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMRPT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMISalesRPT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyCashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMICasherRPT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryRPT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSSUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RistrictionDataSet As Cedemed.RistrictionDataSet
    Friend WithEvents UsersRestrictionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersRestrictionTableAdapter As Cedemed.RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
    Friend WithEvents TableAdapterManager As Cedemed.RistrictionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TSMMaintenance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbClaim As System.Windows.Forms.ToolStripButton
    Friend WithEvents InventoryInitializationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockSummaryReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorReportsTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminSalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GovtSalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManufacturerDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockTransfersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewUnClaimedStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchCurrentInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksReceivedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSuserlevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ItemHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents refbtn As ToolStripButton
    Friend WithEvents InventoryLockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryCheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemRestrictionToolStripMenuItem As ToolStripMenuItem
End Class
