Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel.XlFormControl
Public Class Masterform
    Dim inx As Integer = 0
    Dim selection As String
    Dim analysis As DataSet
    Dim purchaseorder As DataSet
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Private Sub Masterform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.ComboBox1.SelectedIndex = 0
        'inx = 0
        'ComboBox1.Items.Clear()
        'ComboBox1.Items.Add("All Branches")

        If branchname = "Main_V2" Then
        Else
            ComboBox1.SelectedIndex = 0
        End If
        If branchname = "Residence" Then
        Else
            ComboBox1.SelectedIndex = 1
        End If
        If branchname = "Urdaneta" Then
        Else
            ComboBox1.SelectedIndex = 2
        End If
        If branchname = "Tarlac" Then
        Else
            ComboBox1.SelectedIndex = 3
        End If
        If branchname = "Zambales" Then
        Else
            ComboBox1.SelectedIndex = 4
        End If
        If branchname = "Pampanga" Then
        Else
            ComboBox1.SelectedIndex = 5
        End If

        reload()
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

    Private Sub ItemsDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellContentClick

    End Sub

    Private Sub ItemsDataGridView_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ItemsDataGridView.DataError
        Dim bCancel As Boolean = e.Exception.GetType.Equals(GetType(System.ArgumentException))
        e.Cancel = bCancel
    End Sub

    Private Sub ItemsDataGridView_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ItemsDataGridView.MouseUp
        If ItemsDataGridView.SelectedRows.Count = 0 Then
            menus.Items(0).Enabled = False
        Else
            menus.Items(0).Enabled = True
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        With Me.ItemsDataGridView.CurrentRow
            Dim description As String = .Cells(1).Value
            Dim desc As New SqlParameter("@desc", SqlDbType.NVarChar)
            desc.Value = description
            Dim unit As String = .Cells(2).Value
            Dim srp As Decimal
            Try
                srp = CType(.Cells(3).Value, Decimal)
            Catch ex As Exception
                srp = 0
            End Try
            Dim cost As Decimal
            Try
                cost = CType(.Cells(4).Value, Decimal)
            Catch ex As Exception
                cost = 0
            End Try
            Dim oldcost As Decimal
            Try
                oldcost = CType(.Cells(5).Value, Decimal)
            Catch ex As Exception
                oldcost = 0
            End Try
            Dim clevel As Integer = Val(.Cells(7).Value)
            Dim dd As New SqlParameter("@dd", SqlDbType.DateTime)
            dd.Value = Now
            Dim query As String = "Update Items set IDesc=@desc, IUnit='" + unit + "' where ItemNo=" + Val(.Cells(0).Value).ToString + ";Update Inv set SRP=$" + srp.ToString + ", Cost=$" + cost.ToString + ", OldCost=$" + oldcost.ToString + ", Clevel=" + clevel.ToString + ", Date=@dd  where ItemNo=" + Val(.Cells(0).Value).ToString + ";"
            Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)

            Dim com As New SqlCommand(query, conn)
            com.Parameters.Add(dd)
            com.Parameters.Add(desc)
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
            Dim ms As String = ""

            conn = New SqlConnection(My.Settings.Branch1)
            com = New SqlCommand(query, conn)
            dd = New SqlParameter("@dd", SqlDbType.DateTime)
            dd.Value = Now
            desc = New SqlParameter("@desc", SqlDbType.NVarChar)
            desc.Value = description
            com.Parameters.Add(desc)
            com.Parameters.Add(dd)
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Residence"
            End Try



            conn = New SqlConnection(My.Settings.Branch2)
            com = New SqlCommand(query, conn)
            dd = New SqlParameter("@dd", SqlDbType.DateTime)
            dd.Value = Now
            desc = New SqlParameter("@desc", SqlDbType.NVarChar)
            desc.Value = description
            com.Parameters.Add(desc)
            com.Parameters.Add(dd)
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Urdaneta"
            End Try

            conn = New SqlConnection(My.Settings.Branch3)
            com = New SqlCommand(query, conn)
            dd = New SqlParameter("@dd", SqlDbType.DateTime)
            dd.Value = Now
            desc = New SqlParameter("@desc", SqlDbType.NVarChar)
            desc.Value = description
            com.Parameters.Add(desc)
            com.Parameters.Add(dd)
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "La Union"
            End Try

            conn = New SqlConnection(My.Settings.Branch4)
            com = New SqlCommand(query, conn)
            dd = New SqlParameter("@dd", SqlDbType.DateTime)
            dd.Value = Now
            desc = New SqlParameter("@desc", SqlDbType.NVarChar)
            desc.Value = description
            com.Parameters.Add(desc)
            com.Parameters.Add(dd)
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Baguio"
            End Try

            conn = New SqlConnection(My.Settings.Branch5)
            com = New SqlCommand(query, conn)
            dd = New SqlParameter("@dd", SqlDbType.DateTime)
            dd.Value = Now
            desc = New SqlParameter("@desc", SqlDbType.NVarChar)
            desc.Value = description
            com.Parameters.Add(desc)
            com.Parameters.Add(dd)
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Pampanga"
            End Try

            If ms.Length = 0 Then
                MsgBox("Updated.")
            Else
                MsgBox("Unable to update the following branch(es):" + vbCrLf + ms + "Please check the network and Re-Update again to ensure the accurateness of Items across the Branches.")
            End If

        End With

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        analysis = New DataSet
        analysis.Clear()
        getbranch(My.Settings.CedemedConnectionString, "_Main")
        Dim x As String = ""
        If ComboBox1.SelectedIndex = 0 Then
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
                getbranch(My.Settings.Branch3, "Tarlac")
            Catch ex As Exception
                x = x + "La Union" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch4, "Zambales")
            Catch ex As Exception
                x = x + "Baguio" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch5, "Pampanga")
            Catch ex As Exception
                x = x + "Pampanga" + vbCrLf
            End Try

        ElseIf ComboBox1.SelectedIndex = 1 Then
            Try
                getbranch(My.Settings.Branch1, "Residence")
            Catch ex As Exception
                x = "Residence"
            End Try

        ElseIf ComboBox1.SelectedIndex = 2 Then
            Try
                getbranch(My.Settings.Branch2, "Urdaneta")
            Catch ex As Exception
                x = "Urdaneta"
            End Try

        ElseIf ComboBox1.SelectedIndex = 3 Then
            Try
                getbranch(My.Settings.Branch3, "Tarlac")
            Catch ex As Exception
                x = "La Union"
            End Try


        ElseIf ComboBox1.SelectedIndex = 4 Then
            Try
                getbranch(My.Settings.Branch4, "Zambales")
            Catch ex As Exception
                x = "Baguio"
            End Try

        ElseIf ComboBox1.SelectedIndex = 5 Then
            Try
                getbranch(My.Settings.Branch5, "Pampanga")
            Catch ex As Exception
                x = "Pampanga"
            End Try
        End If
        Dim pvot As New Pivot(analysis.Tables("a"))

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
    End Sub



    Private Sub worker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles worker.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.Status.Text = e.UserState
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As System.EventArgs) Handles CheckBox1.Click
        reload()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            reload()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        inx = ComboBox1.SelectedIndex
        selection = ComboBox1.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub ItemsDataGridView_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles ItemsDataGridView.RowPostPaint
        Try
            Dim dr As DataGridViewRow = ItemsDataGridView.Rows(e.RowIndex)
            If Val(dr.Cells(8).Value) <= Val(dr.Cells(7).Value) Then
                dr.DefaultCellStyle.BackColor = Color.Yellow
            Else
                dr.DefaultCellStyle.BackColor = Color.White
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.InventoryTableAdapter.Fill(Me.MasterFileDataset.Inventory)
        Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
        Dim query As String = ""
        Dim supplier As String
        Dim qty, lastin As Integer

        For Each rw As DataRow In Me.MasterFileDataset.Inventory.Rows
            qty = Val(rw.Item("Qty"))
            Try
                lastin = Val(rw.Item("lastin"))
            Catch ex As Exception
                lastin = 0
            End Try

            If rw.Item("lastsupplier").ToString.Contains("'") Then
                supplier = Replace(rw.Item("lastsupplier").ToString, "'", "`")
            Else
                supplier = rw.Item("lastsupplier").ToString
            End If
            query = query + "UPDATE Inv SET qty=" + qty.ToString + ", lastin=" + lastin.ToString + ", lastsupplier='" + supplier + "' WHERE ItemNo=" + rw.Item("ItemNo").ToString + ";"
        Next

        Dim com As New SqlCommand("ALTER TABLE Inv DISABLE TRIGGER updatelastedit", conn)
        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            conn.Open()
        End Try


        'com.ExecuteNonQuery() 'disable trigger
        com = New SqlCommand(query, conn)
        com.ExecuteNonQuery() 'update inventory, Last in and supplier
        com = New SqlCommand("ALTER TABLE Inv ENABLE TRIGGER updatelastedit", conn)
        'com.ExecuteNonQuery() 'enable trigger
        reload()
        MsgBox("Inventory Updated.")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ItemsTableAdapter.FillByDate(Me.MasterFileDataset.Items, DateValue(DateTimePicker1.Value))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reload()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\Price Updates.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        Dim rc(Me.MasterFileDataset.Items.DefaultView.Count, 5)

        For x As Integer = 0 To Me.MasterFileDataset.Items.DefaultView.Count - 1
            With Me.MasterFileDataset.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("IDesc")
                rc(x, 1) = .Item("IUnit")
                rc(x, 2) = .Item("Clevel")
                rc(x, 3) = .Item("Cost")
                rc(x, 4) = .Item("SRP")
            End With
        Next
        wsheet.Range("A3").Value = DateTimePicker1.Value.ToShortDateString
        wsheet.Range("A6", "E" + (Me.MasterFileDataset.Items.DefaultView.Count + 5).ToString).Value = rc
        wsheet.Range("A5", "E" + (Me.MasterFileDataset.Items.DefaultView.Count + 5).ToString).Borders.Weight = 2
        xapp.Visible = True

    End Sub
    Dim srp As New SqlParameter("@SRP", SqlDbType.Money)
    Dim cost As New SqlParameter("@Cost", SqlDbType.Money)
    Dim oldcost As New SqlParameter("@OldCost", SqlDbType.Money)
    Dim clevel As New SqlParameter("@CLevel", SqlDbType.Int)
    Dim itemno As New SqlParameter("@ItemNo", SqlDbType.Int)
    Dim dt As New SqlParameter("@updated", SqlDbType.Date)
    Dim com As SqlCommand
    Private Sub ItemsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellEndEdit
        'MsgBox(Me.ItemsDataGridView.CurrentRow.Index)
        com = New SqlCommand("UPDATE Inv SET SRP=@SRP, updated=@updated, Cost=@Cost, OldCost=@OldCost, CLevel=@CLevel WHERE ItemNo=@ItemNo", conn)
        srp = New SqlParameter("@SRP", SqlDbType.Decimal)
        cost = New SqlParameter("@Cost", SqlDbType.Decimal)
        oldcost = New SqlParameter("@OldCost", SqlDbType.Decimal)
        clevel = New SqlParameter("@CLevel", SqlDbType.Int)
        dt = New SqlParameter("@updated", SqlDbType.Date)
        itemno = New SqlParameter("@ItemNo", SqlDbType.Int)
        srp.Value = Me.ItemsDataGridView.CurrentRow.Cells(3).Value
        cost.Value = Me.ItemsDataGridView.CurrentRow.Cells(4).Value
        oldcost.Value = Me.ItemsDataGridView.CurrentRow.Cells(5).Value
        clevel.Value = Me.ItemsDataGridView.CurrentRow.Cells(7).Value
        itemno.Value = Me.ItemsDataGridView.CurrentRow.Cells(0).Value
        dt.Value = DateValue(Now)
        Me.ItemsDataGridView.CurrentRow.Cells(6).Value = DateValue(Now).ToShortDateString
        com.Parameters.Add(srp)
        com.Parameters.Add(cost)
        com.Parameters.Add(oldcost)
        com.Parameters.Add(clevel)
        com.Parameters.Add(dt)
        com.Parameters.Add(itemno)

        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            conn.Open()
        End Try
        com.ExecuteNonQuery()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = ""
        Dim srp As Decimal = 0
        Dim cost As Decimal = 0
        Dim oldcost As Decimal = 0
        Dim clevel As Decimal = 0
        Dim updated As String = Now.Year.ToString + "-" + Now.Month.ToString + "-" + Now.Day.ToString
        Dim itemno As Integer

        For x As Integer = 0 To Me.MasterFileDataset.Items.Rows.Count - 1
            With Me.MasterFileDataset.Items.Rows(x)
                Try
                    srp = CType(.Item("SRP"), Decimal)
                Catch ex As Exception
                    srp = 0
                End Try
                Try
                    cost = CType(.Item("Cost"), Decimal)
                Catch ex As Exception
                    cost = 0
                End Try
                Try
                    oldcost = CType(.Item("OldCost"), Decimal)
                Catch ex As Exception
                    oldcost = 0
                End Try
                Try
                    clevel = CType(.Item("Clevel"), Decimal)
                Catch ex As Exception
                    clevel = 0
                End Try
                itemno = .Item("ItemNo")
            End With
            query = query + "Update Inv set SRP=$" + srp.ToString + ", Cost=$" + cost.ToString + ", OldCost=$" + oldcost.ToString + ", Clevel=" + clevel.ToString + ", Date='" + updated + "' where ItemNo=" + itemno.ToString + ";"
        Next

        Dim conn As New SqlConnection(My.Settings.Branch1)
        Dim com As New SqlCommand(query, conn)
        Dim ms As String = ""

        If residence.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch1)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Residence"
            End Try
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
        End If

        If urdaneta.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch2)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Urdaneta"
            End Try
        End If

        If tarlac.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch3)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Tarlac"
            End Try
        End If

        If zambales.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch4)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Zambales"
            End Try
        End If

        If pampanga.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch5)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Pampanga"
            End Try
        End If

        If ms.Length = 0 Then
            MsgBox("Updated.")
        Else
            MsgBox("Unable to update the following branch(es):" + vbCrLf + ms + "Please check the network and Re-Update again to ensure the accurateness of Items across the Branches.")
        End If
    End Sub

    Private Sub supplier_TextChanged(sender As Object, e As EventArgs) Handles supplier.TextChanged

    End Sub

    Private Sub supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles supplier.KeyPress
        If e.KeyChar = ChrW(13) Then
            If supplier.Text = "" Then
            Else
                Me.ItemsTableAdapter.FillBySupplier(Me.MasterFileDataset.Items, supplier.Text)
            End If

        End If
    End Sub
End Class