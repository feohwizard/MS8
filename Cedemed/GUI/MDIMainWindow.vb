Imports System.Windows.Forms
Public Class MDIMAINWINDOW
    Dim BR As New BranchDataSetTableAdapters.BranchTableAdapter
    Dim oper As Integer

    Private Sub MDIMAINWINDOW_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If My.Settings.BranchSelect = True Then
            Dim bselect As New BranchSelect

            If bselect.ShowDialog <> Windows.Forms.DialogResult.OK Then
                End
            Else
                GoTo okk
            End If
        Else
okk:
            Try
                Me.Text = BR.GetData.Rows(0).Item(0) + " " + "Normal"
                branchname = BR.GetData.Rows(0).Item(0)
                Dim loginpass As New LoginForm1

                If loginpass.ShowDialog <> Windows.Forms.DialogResult.OK Then
                    End
                End If

                Dim username = loginpass.UsernameTextBox.Text
                Dim password = loginpass.PasswordTextBox.Text

                Dim ristrict As New RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
                Dim ruser As New RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
                Dim login As String


                login = ristrict.UserGetby(username, password)
                Me.TSSUser.Text = username
                Dim UR = ruser.GetDataBy1(username)
                user = username
                Dim admin = UR.Rows(0).Item(6)
                Dim Sales = UR.Rows(0).Item(7)
                Dim maintenance = UR.Rows(0).Item(8)
                Dim instock = UR.Rows(0).Item(9)
                Dim Summary = UR.Rows(0).Item(10)
                Dim CashietRPT = UR.Rows(0).Item(11)
                Dim stocktran = UR.Rows(0).Item(12)
                userlevel = UR.Rows(0).Item("UserLevel")
                If UR.Rows(0).Item("UserLevel") = "Administrator" Then
                Else
                    ViewUnClaimedStocksToolStripMenuItem.Visible = False
                    tsbClaim.Visible = False
                End If

                If admin = 0 Then
                    TSMAdmin.Enabled = False
                    AdministratorReportsTSMI.Enabled = False
                Else
                    TSMAdmin.Enabled = True
                    AdministratorReportsTSMI.Enabled = True
                End If

                If user = "daisy" Then
                    AdministratorReportsTSMI.Visible = True
                Else
                    AdministratorReportsTSMI.Visible = False
                End If

                If Sales = 0 Then
                    TSBSales.Enabled = False
                    TSMISalesRPT.Enabled = False
                    tsbClaim.Enabled = False
                Else
                    TSBSales.Enabled = True
                    TSMISalesRPT.Enabled = True
                    tsbClaim.Enabled = True
                End If

                If maintenance = 0 Then
                    TSMMaintenance.Enabled = False
                Else
                    TSMMaintenance.Enabled = True
                End If

                If instock = 0 Then
                    TSBStockIn.Enabled = False
                Else
                    TSBStockIn.Enabled = True
                End If

                If Summary = 0 Then
                    SummaryRPT.Enabled = False
                Else
                    SummaryRPT.Enabled = True
                End If

                If CashietRPT = 0 Then
                    TSMICasherRPT.Enabled = False
                Else
                    TSMICasherRPT.Enabled = True
                End If

                If stocktran = 0 Then
                    TSBTransfer.Enabled = False

                Else
                    TSBTransfer.Enabled = True

                End If

                If TSSuserlevel.Text = "Administrator" Then
                    Me.tsbClaim.Visible = True
                ElseIf TSSuserlevel.Text = "Cashier" Then
                    Me.tsbClaim.Visible = False
                ElseIf TSSuserlevel.Text = "User" Then
                    Me.tsbClaim.Visible = False
                End If

                'If userlevel = "Administrator" Then
                'refbtn.Visible = True
                'Else
                refbtn.Visible = False
                'End If


                If login Is Nothing Then
                    MsgBox("Invalid User Name Password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                    End
                End If

            Catch ex As Exception
                MsgBox("Invalid User Name Password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                End
            End Try
        End If


    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBSales.Click
        Dim sale As New Sales
        sale.ShowDialog()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBStockIn.Click
        Dim stockin As New Stockinform
        stockin.ShowDialog()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBTransfer.Click
        If transferfrm Is Nothing Then
        Else
            transferfrm.Close()
        End If
        transferfrm = New StockTransfer
        transferfrm.Show()
    End Sub

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Posting As New StockTransferPosting
        Posting.ShowDialog()
    End Sub

    Private Sub UsersRestrictionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsersRestrictionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RistrictionDataSet)

    End Sub

    Private Sub MasterFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterFileToolStripMenuItem.Click
        Dim master As New Masterform
        master.Show()
    End Sub

    Private Sub ParserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New Parser
        f.Show()
    End Sub

    Private Sub InventoryInitializationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ParserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub DailySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim g As New DailySalesrpt
        g.Show()
    End Sub

    Private Sub PasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordToolStripMenuItem.Click
        Dim pass As New userpassModule
        pass.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Try
            Me.Text = BR.GetData.Rows(0).Item(0)

            Dim loginpass As New LoginForm1

            If loginpass.ShowDialog <> Windows.Forms.DialogResult.OK Then
                End
                loginpass.ShowDialog()
            End If

            Dim username = loginpass.UsernameTextBox.Text
            Dim password = loginpass.PasswordTextBox.Text

            Dim ristrict As New RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
            Dim ruser As New RistrictionDataSetTableAdapters.UsersRestrictionTableAdapter
            Dim login As String


            login = ristrict.UserGetby(username, password)
            Me.TSSUser.Text = username
            Dim UR = ruser.GetDataBy1(username)
            user = username
            Dim admin = UR.Rows(0).Item(6)
            Dim Sales = UR.Rows(0).Item(7)
            Dim maintenance = UR.Rows(0).Item(8)
            Dim instock = UR.Rows(0).Item(9)
            Dim Summary = UR.Rows(0).Item(10)
            Dim CashietRPT = UR.Rows(0).Item(11)
            Dim stocktran = UR.Rows(0).Item(12)

            userlevel = UR.Rows(0).Item("UserLevel")
            If UR.Rows(0).Item("UserLevel") = "Administrator" Then
            Else
                ViewUnClaimedStocksToolStripMenuItem.Visible = False
                tsbClaim.Visible = False
            End If

            If admin = 0 Then
                TSMAdmin.Enabled = False
                AdministratorReportsTSMI.Enabled = False
            Else
                TSMAdmin.Enabled = True
                AdministratorReportsTSMI.Enabled = True
            End If

            If user = "daisy" Then
                AdministratorReportsTSMI.Visible = True
            Else
                AdministratorReportsTSMI.Visible = False
            End If

            If Sales = 0 Then
                TSBSales.Enabled = False
                TSMISalesRPT.Enabled = False
            Else
                TSBSales.Enabled = True
                TSMISalesRPT.Enabled = True
            End If

            If maintenance = 0 Then
                TSMMaintenance.Enabled = False
            Else
                TSMMaintenance.Enabled = True
            End If

            If instock = 0 Then
                TSBStockIn.Enabled = False
            Else
                TSBStockIn.Enabled = True
            End If

            If Summary = 0 Then
                SummaryRPT.Enabled = False
            Else
                SummaryRPT.Enabled = True
            End If

            If CashietRPT = 0 Then
                TSMICasherRPT.Enabled = False
            Else
                TSMICasherRPT.Enabled = True
            End If

            If stocktran = 0 Then
                TSBTransfer.Enabled = False
                tsbClaim.Enabled = False
            Else
                TSBTransfer.Enabled = True
                tsbClaim.Enabled = True
            End If

            If userlevel = "Administrator" Then
                refbtn.Visible = True
            Else
                refbtn.Visible = False
            End If


            If login Is Nothing Then
                MsgBox("Invalid User Name Password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                End
            End If
            
        Catch ex As Exception
            MsgBox("Invalid User Name Password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClaim.Click
        Dim cstock As New Claim
        cstock.ShowDialog()
    End Sub


    Private Sub StockSummaryReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockSummaryReportsToolStripMenuItem.Click
        Dim summary As New StockInSummary
        summary.ShowDialog()
    End Sub

    Private Sub DailyCashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCashToolStripMenuItem.Click
        Dim daily As New DailySalesrpt
        daily.ShowDialog()
    End Sub

    Private Sub TSMICasherRPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMICasherRPT.Click
        Dim Cashier As New CashierRPT
        Cashier.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim Custr As New CustomersSalesReport
        Custr.ShowDialog()
    End Sub

    Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub AdminSalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminSalesReportToolStripMenuItem.Click
        Dim frm As New AdminSalesrpt
        frm.Show()
    End Sub

    Private Sub SupplierDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDirectoryToolStripMenuItem.Click
        Dim frm As New Supplier
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ManufacturerDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManufacturerDirectoryToolStripMenuItem.Click
        Dim frm As New Manufacturer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProductDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductDirectoryToolStripMenuItem.Click
        Dim frm As New ProductDirectory
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GovtSalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GovtSalesReportToolStripMenuItem.Click
        Dim frm As New GovernmentRPT
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockTransfersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockTransfersToolStripMenuItem.Click
        Dim frm As New TranferRecord
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ViewUnClaimedStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewUnClaimedStocksToolStripMenuItem.Click
        Dim Unclaim As New UnclaimStocks
        Unclaim.ShowDialog()
    End Sub

    Private Sub BranchInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchInventoryToolStripMenuItem.Click

    End Sub

    Private Sub BranchCurrentInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchCurrentInventoryToolStripMenuItem.Click
        Dim master As New Masterform2
        master.Show()
    End Sub

    Private Sub StocksReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksReceivedToolStripMenuItem.Click
        Dim Unclaim As New RecieveStocks
        Unclaim.ShowDialog()
    End Sub

    Private Sub ItemHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemHistoryToolStripMenuItem.Click
        Dim history As New ItemSummary
        history.ShowDialog()
    End Sub

    Private Sub refbtn_Click(sender As Object, e As EventArgs) Handles refbtn.Click
        Dim ref As New frmSI
        ref.Show()
    End Sub

    Private Sub InventoryLockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryLockToolStripMenuItem.Click
        Dim invlock As New Lock
        invlock.Show()
    End Sub

    Private Sub InventoryCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryCheckToolStripMenuItem.Click
        Dim invcheck As New Inventory
        invcheck.Show()
    End Sub

    Private Sub ItemRestrictionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemRestrictionToolStripMenuItem.Click
        Dim restrict As New ItemRestriction
        restrict.Show()
    End Sub
End Class
