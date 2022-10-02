Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel.XlFormControl
Public Class Masterform2
    Dim inx As Integer = 0
    Dim selection As String
    Dim analysis As DataSet
    Dim purchaseorder As DataSet
    Private Sub Masterform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterFileDataset.Items' table. You can move, or remove it, as needed.

        Me.ComboBox1.SelectedIndex = 0
        inx = 0
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Main")
        ComboBox1.Items.Add("Residence")
        ComboBox1.Items.Add("Urdaneta")
        ComboBox1.Items.Add("La Union")
        ComboBox1.Items.Add("Baguio")
        ComboBox1.Items.Add("Pampanga")
        ComboBox1.Items.Add("All Branches")
        ComboBox1.SelectedIndex = 6
        'reload()
    End Sub

    Private Sub getbranch(ByVal x As String, ByVal b As String)
        Dim conn As New SqlConnection(x)
        Dim cnn As New SqlConnection(x)
        Try
            cnn.Open()
        Catch ex As Exception
            Dim c As Integer = 1
            c = c / 0
        End Try
        Dim adap As New SqlDataAdapter("SELECT '" + b + "' as Branch, Items.ItemNo, Items.IDesc, isnull((select sum(inventory - stockout - transfer)  from (SELECT DISTINCT  Expiry, MRRNo AS lotno, ISNULL((SELECT SUM(UnitSold) AS soldsum FROM  Sales WHERE (ItemNo = Purchases.ItemNo) AND (expiry = Purchases.Expiry) AND (lotno = Purchases.MRRNo) AND (hold=0)), 0) AS stockout, ISNULL((SELECT  SUM(Qty) AS invsum FROM Purchases AS Purchases_1 WHERE (ItemNo = Purchases.ItemNo) AND (Expiry = Purchases.Expiry) AND (MRRNo = Purchases.MRRNo) AND (hold=0)), 0) AS inventory, ISNULL((SELECT  SUM(Qty) AS transum FROM TranferItems AS trantran WHERE (ItemNo = Purchases.ItemNo) AND (Expiry = Purchases.Expiry) AND (lotno = Purchases.MRRNo) AND (hold=0)), 0) AS transfer FROM Purchases WHERE (ItemNo = Items.ItemNo)) as tbl),0) as Qty, Inv.SRP, Items.type, Inv.Cost FROM  Items INNER JOIN Inv ON Items.ItemNo = Inv.ItemNo ORDER BY Items.IDesc", conn)
        adap.Fill(analysis, "a")
    End Sub

    Private Sub reload()

        If TextBox1.Text = "" Then
            If CheckBox1.Checked = True Then
                Me.ItemsTableAdapter.FillCritical(Me.MasterFileDataset.Items)
            Else
                Me.ItemsTableAdapter.Fill(Me.MasterFileDataset.Items)
            End If
        Else
            If CheckBox1.Checked = True Then
                Me.ItemsTableAdapter.FillByItemCritical(Me.MasterFileDataset.Items, TextBox1.Text)
            Else
                Me.ItemsTableAdapter.FillByItem(Me.MasterFileDataset.Items, TextBox1.Text)
            End If
        End If



    End Sub

    Private Sub ItemsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ItemsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        Dim bCancel As Boolean = e.Exception.GetType.Equals(GetType(System.ArgumentException))
        e.Cancel = bCancel
    End Sub

    

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        analysis = New DataSet
        analysis.Clear()
        Dim x As String = ""
        If ComboBox1.Text = "Main" Then
            Try
                getbranch(My.Settings.MainBranch, "Main Branch")
            Catch ex As Exception
                x = "Main Branch"
            End Try
        ElseIf ComboBox1.Text = "Residence" Then
            Try
                getbranch(My.Settings.Branch1, "Residence")
            Catch ex As Exception
                x = "Residence"
            End Try
        ElseIf ComboBox1.Text = "Urdaneta" Then
            Try
                getbranch(My.Settings.Branch2, "Urdaneta")
            Catch ex As Exception
                x = "Urdaneta"
            End Try
        ElseIf ComboBox1.Text = "La Union" Then
            Try
                getbranch(My.Settings.Branch3, "La Union")
            Catch ex As Exception
                x = "La Union"
            End Try
        ElseIf ComboBox1.Text = "Baguio" Then
            Try
                getbranch(My.Settings.Branch4, "Baguio")
            Catch ex As Exception
                x = "Baguio"
            End Try

        ElseIf ComboBox1.Text = "Pampanga" Then
            Try
                getbranch(My.Settings.Branch5, "Pampanga")
            Catch ex As Exception
                x = "Pampanga"
            End Try
        ElseIf ComboBox1.Text = "All Branches" Then
            Try
                getbranch(My.Settings.MainBranch, "Main Branch")
            Catch ex As Exception
                x = x + "Main Branch" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch1, "Residence")
            Catch ex As Exception
                x = x + "Residence" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch2, "Urdaneta")
            Catch ex As Exception
                x = x + "Urdaneta" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch3, "La Union")
            Catch ex As Exception
                x = x + "La Union" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch4, "Baguio")
            Catch ex As Exception
                x = x + "Baguio" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch5, "Pampanga")
            Catch ex As Exception
                x = x + "Pampanga" + vbCrLf
            End Try

        End If
        
     

        Dim pvot As New Pivot(analysis.Tables("a"))

        Try
            views.DataSource = pvot.PivotData("Idesc", "Qty", AggregateFunction.Sum, "Branch")
            If views.Columns(0).HeaderText = "" Then
            Else
                Dim chk As New DataGridViewCheckBoxColumn
                chk.FlatStyle = FlatStyle.Standard
                chk.HeaderText = ""
                chk.ReadOnly = False
                views.Columns.Insert(0, chk)
            End If

            views.Columns(1).HeaderText = "Description"
            For Each c As DataGridViewColumn In views.Columns
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                c.ReadOnly = True
            Next

            views.Columns(0).ReadOnly = False
            views.Refresh()

            If x = "" Then
            Else
                MsgBox("Unable to retrieve Inventory from the following:" + vbCrLf + x + vbCrLf + "Please check if they are connected to the network.")
            End If
        Catch ex As Exception

        End Try


        
        'worker.CancelAsync()
        'worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork
        'retreive1()
        worker.ReportProgress(0, "")
    End Sub

    Private Sub worker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles worker.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.Status.Text = e.UserState
    End Sub

   

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        reload()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            reload()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        inx = ComboBox1.SelectedIndex
        selection = ComboBox1.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet
        Dim wsheet2 As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\Purchase Order.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        wsheet2 = wbook.Worksheets.Item(2)
        Me.ItemsTableAdapter.Fill(Me.MasterFileDataset.Items)
        Dim rc(Me.MasterFileDataset.Items.DefaultView.Count, 4)

        For x As Integer = 0 To Me.MasterFileDataset.Items.DefaultView.Count - 1
            With Me.MasterFileDataset.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("IDesc")
                rc(x, 1) = .Item("IUnit")
                rc(x, 2) = .Item("Clevel")
                rc(x, 3) = .Item("Cost")
            End With
        Next
        wsheet2.Range("A1", "D" + (Me.MasterFileDataset.Items.DefaultView.Count).ToString).Value = rc

        Dim xx As Integer = 0
        For y As Integer = 0 To views.Rows.Count - 1
            If views.Rows(y).Cells(0).Value = True Then
                xx += 1
            End If
        Next

        If xx = 0 Then
            MsgBox("No Selection")
            Exit Sub
        Else
            Dim rcc(xx, 1)
            Dim cc As Integer = 0
            For y As Integer = 0 To views.Rows.Count - 1
                If views.Rows(y).Cells(0).Value = True Then
                    rcc(cc, 0) = views.Rows(y).Cells(1).Value
                    cc += 1
                End If
            Next
            wsheet.Range("A6", "A" + (xx + 5).ToString).Value = rcc

            'For Branches
            Dim branch As Integer = views.Columns.Count - 3
            If branch = 0 Then
            Else
                For z = 1 To branch
                    Dim rb(xx, 1)
                    Dim cb As Integer = 0
                    For y As Integer = 0 To views.Rows.Count - 1
                        If views.Rows(y).Cells(0).Value = True Then
                            rb(cb, 0) = views.Rows(y).Cells(2 + z).Value
                            cb += 1
                        End If
                    Next
                    Dim position As String = ""
                    If views.Columns(2 + z).HeaderText = "Residence" Then
                        position = "D"
                    ElseIf views.Columns(2 + z).HeaderText = "Urdaneta" Then
                        position = "E"
                    ElseIf views.Columns(2 + z).HeaderText = "La Union" Then
                        position = "F"
                    ElseIf views.Columns(2 + z).HeaderText = "Baguio" Then
                        position = "G"
                    ElseIf views.Columns(2 + z).HeaderText = "Pampanga" Then
                        position = "H"
                    End If
                    If position = "" Then
                    Else
                        wsheet.Range(position + "6", position + (xx + 5).ToString).Value = rb
                    End If

                Next

                Dim rb1(xx, 1)
                Dim cb1 As Integer = 0
                For y As Integer = 0 To views.Rows.Count - 1
                    If views.Rows(y).Cells(0).Value = True Then
                        rb1(cb1, 0) = views.Rows(y).Cells(2).Value
                        cb1 += 1
                    End If
                Next

                wsheet.Range("C6", "C" + (xx + 5).ToString).Value = rb1
                xapp.Visible = True
            End If


        End If
    End Sub
End Class