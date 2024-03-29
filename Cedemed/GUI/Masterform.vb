﻿Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel.XlFormControl
Imports System.IO
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

        If branchname = "Main" Then
            Button2.Enabled = True
        ElseIf branchname = "Tanedo" Then
            Button2.Enabled = False
            ComboBox1.SelectedIndex = 1
        ElseIf branchname = "San Vicente" Then
            Button2.Enabled = False
            ComboBox1.SelectedIndex = 2
        Else
            Button2.Enabled = False
            ComboBox1.SelectedIndex = 0
        End If
        reload()
    End Sub

    Private Sub savecurrentrow(rowonedit As Integer)
        com = New SqlCommand("UPDATE Inv SET SRP=@SRP, OldSRP=@OldSRP, updated=@updated, Cost=@Cost, OldCost=@OldCost, CLevel=@CLevel WHERE ItemNo=@ItemNo", conn)
        srp = New SqlParameter("@SRP", SqlDbType.Decimal)
        srpold = New SqlParameter("@OldSRP", SqlDbType.Decimal)
        cost = New SqlParameter("@Cost", SqlDbType.Decimal)
        oldcost = New SqlParameter("@OldCost", SqlDbType.Decimal)
        clevel = New SqlParameter("@CLevel", SqlDbType.Int)
        dt = New SqlParameter("@updated", SqlDbType.Date)
        itemno = New SqlParameter("@ItemNo", SqlDbType.Int)
        srp.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(3).Value
        srpold.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(4).Value
        cost.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(5).Value
        oldcost.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(6).Value
        clevel.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(9).Value
        itemno.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(0).Value
        dt.Value = DateValue(Now)
        com.Parameters.Add(srp)
        com.Parameters.Add(srpold)
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
        conn.Close()
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
        Dim adap As New SqlDataAdapter("SELECT '" + b + "' as Branch, Items.ItemNo, Items.IDesc, Inv.Qty, Inv.SRP, Items.type, Inv.Cost, Inv.Clevel FROM  Items INNER JOIN Inv ON Items.ItemNo = Inv.ItemNo ORDER BY Items.IDesc", conn)
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
        If ItemsDataGridView.SelectedRows.Count = 0 Or ItemsDataGridView.SelectedRows.Count > 1 Then
            menus.Items(0).Enabled = False
            menus.Items(1).Enabled = False
        Else
            menus.Items(0).Enabled = True
            menus.Items(1).Enabled = True
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim inn As String = InputBox("Enter New SRP", "Suggested Retail Price")
        If IsNumeric(inn) Then
            With Me.ItemsDataGridView.CurrentRow
                .Cells(4).Value = .Cells(3).Value
                .Cells(3).Value = inn
            End With
            savecurrentrow(Me.ItemsDataGridView.CurrentRow.Index)
            MsgBox("Item Updated", vbOKOnly, "Message")
        Else
            MsgBox("Invalid Input", vbOKOnly, "Message")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        analysis = New DataSet
        analysis.Clear()
        getbranch(My.Settings.CedemedConnectionString, "_Main")
        Dim x As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            Try
                getbranch(My.Settings.Branch1, "Tanedo")
            Catch ex As Exception
                x = x + "Tanedo" + vbCrLf
            End Try
            Try
                getbranch(My.Settings.Branch2, "San Vicente")
            Catch ex As Exception
                x = x + "San Vicente" + vbCrLf
            End Try
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Try
                getbranch(My.Settings.Branch1, "Tanedo")
            Catch ex As Exception
                x = "Tanedo"
            End Try

        ElseIf ComboBox1.SelectedIndex = 2 Then
            Try
                getbranch(My.Settings.Branch2, "San Vicente")
            Catch ex As Exception
                x = "San Vicente"
            End Try
        End If
        Dim pvot As New Pivot(analysis.Tables("a"))

        Dim ppvot As DataTable
        ppvot = pvot.PivotData("Idesc", "Qty", AggregateFunction.Sum, "Branch")

        ppvot.Columns.Add("CLevel", GetType(Integer))


        Dim res() As DataRow
        For Each rw As DataRow In ppvot.Rows
            res = Me.MasterFileDataset.Items.Select("Idesc='" + Replace(rw("Idesc").ToString, "'", "''") + "'")

            If res.Length > 0 Then
                rw("CLevel") = Val(res(0).Item("CLevel"))
            End If
        Next

        get_branches_columns(ppvot.Columns.Count)
        views.DataSource = Nothing
        views.DataSource = ppvot
        'views.DataSource = pvot.PivotData("Idesc", "Qty", AggregateFunction.Sum, "Branch")
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
            If Val(dr.Cells(10).Value) <= Val(dr.Cells(9).Value) Then
                dr.DefaultCellStyle.BackColor = Color.Yellow
            Else
                dr.DefaultCellStyle.BackColor = Color.White
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
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

        If File.Exists(Application.StartupPath + "\Purchase Order.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\Purchase Order.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If




        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\Purchase Order.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        Dim rc(Me.MasterFileDataset.Items.DefaultView.Count, 6)

        For x As Integer = 0 To Me.MasterFileDataset.Items.DefaultView.Count - 1
            With Me.MasterFileDataset.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("IDesc")
                rc(x, 1) = .Item("IUnit")
                rc(x, 2) = 0
                rc(x, 3) = .Item("Clevel")
                rc(x, 4) = .Item("Cost")
                rc(x, 5) = .Item("lastsupplier")
            End With
        Next
        wsheet.Range("A3").Value = DateTimePicker1.Value.ToShortDateString
        wsheet.Range("A6", "F" + (Me.MasterFileDataset.Items.DefaultView.Count + 6).ToString).Value = rc
        wsheet.Range("A5", "F" + (Me.MasterFileDataset.Items.DefaultView.Count + 6).ToString).Borders.Weight = 2

        wbook.SaveAs(Application.StartupPath + "\Purchase Order.xls")
        xapp.Visible = True

    End Sub
    Dim srp As New SqlParameter("@SRP", SqlDbType.Money)
    Dim srpold As New SqlParameter("@OldSRP", SqlDbType.Money)
    Dim cost As New SqlParameter("@Cost", SqlDbType.Money)
    Dim oldcost As New SqlParameter("@OldCost", SqlDbType.Money)
    Dim clevel As New SqlParameter("@CLevel", SqlDbType.Int)
    Dim itemno As New SqlParameter("@ItemNo", SqlDbType.Int)
    Dim dt As New SqlParameter("@updated", SqlDbType.Date)
    Dim com As SqlCommand

    Dim rowonedit As Integer = 0
    Dim colonedit As Integer = 0

    Private Sub ItemsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellEndEdit
        rowonedit = Me.ItemsDataGridView.CurrentCell.RowIndex
        colonedit = Me.ItemsDataGridView.CurrentCell.ColumnIndex
        'Me.ItemsDataGridView.CurrentRow.Cells(8).Value = DateValue(Now).ToShortDateString
        worker.RunWorkerAsync()


        'MsgBox(Me.ItemsDataGridView.CurrentRow.Cells(9).Value)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.ItemsDataGridView.SelectedRows.Count = 0 Then
            MsgBox("No Item Selection")
            Exit Sub
        End If
        Dim query As String = ""
        Dim srp As Decimal = 0
        Dim oldsrp As Decimal = 0
        Dim cost As Decimal = 0
        Dim oldcost As Decimal = 0
        Dim clevel As Decimal = 0
        Dim updated As String = Now.Year.ToString + "-" + Now.Month.ToString + "-" + Now.Day.ToString
        Dim itemno As Integer

        For Each rw As DataGridViewRow In Me.ItemsDataGridView.SelectedRows
            Try
                srp = CType(rw.Cells(3).Value, Decimal)
            Catch ex As Exception
                srp = 0
            End Try
            Try
                oldsrp = CType(rw.Cells(4).Value, Decimal)
            Catch ex As Exception
                oldsrp = 0
            End Try
            Try
                cost = CType(rw.Cells(5).Value, Decimal)
            Catch ex As Exception
                cost = 0
            End Try
            Try
                oldcost = CType(rw.Cells(6).Value, Decimal)
            Catch ex As Exception
                oldcost = 0
            End Try
            Try
                clevel = CType(rw.Cells(9).Value, Decimal)
            Catch ex As Exception
                clevel = 0
            End Try
            itemno = rw.Cells(16).Value
            query = query + "Update Inv set SRP=$" + srp.ToString + ", OldSRP=$" + oldsrp.ToString + ", Cost=$" + cost.ToString + ", OldCost=$" + oldcost.ToString + ", Clevel=" + clevel.ToString + ", Date='" + updated + "' where ItemNo=" + itemno.ToString + ";"
        Next


        Dim conn As New SqlConnection(My.Settings.Branch1)
        Dim com As New SqlCommand(query, conn)
        Dim ms As String = ""

        If tanedo.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch1)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "Tanedo"
            End Try
        End If

        If sanvicente.Checked = True Then
            conn = New SqlConnection(My.Settings.Branch2)
            com = New SqlCommand(query, conn)
            com.CommandTimeout = 0
            Try
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                ms = ms + "San Vicente"
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

    Private Sub views_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles views.CellContentClick

    End Sub


    Private Sub get_branches_columns(xx As Integer)
        colcount = xx
        ReDim cols(colcount - 3)
        Dim c As Integer = 0

        For x As Integer = 2 To colcount - 2
            cols(c) = x
            c += 1
        Next
    End Sub

    Dim cols() As Integer
    Dim colcount As Integer
    Dim wless As Boolean = False
    Dim dr As DataGridViewRow

    Private Sub views_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles views.RowPostPaint
        Try
            dr = Me.views.Rows(e.RowIndex)

            wless = False
            For Each v As Integer In cols
                If Val(dr.Cells(colcount - 1).Value) <= Val(dr.Cells(v).Value) Then
                    wless= True
                End If
            Next
            If wless = True Then
                dr.DefaultCellStyle.BackColor = Color.Yellow
            Else
                dr.DefaultCellStyle.BackColor = Color.White
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ChangeCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCostToolStripMenuItem.Click
        Dim inn As String = InputBox("Enter New Cost", "Item Latest Cost")
        If IsNumeric(inn) Then
            With Me.ItemsDataGridView.CurrentRow
                .Cells(6).Value = .Cells(5).Value
                .Cells(5).Value = inn
            End With
            savecurrentrow(Me.ItemsDataGridView.CurrentRow.Index)
            MsgBox("Item Updated", vbOKOnly, "Message")
        Else
            MsgBox("Invalid Input", vbOKOnly, "Message")
        End If
    End Sub

    Dim currentSRP As Decimal = 0
    Dim currentCost As Decimal = 0
    Private Sub ItemsDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellEnter
        If Me.ItemsDataGridView.CurrentCell.ColumnIndex = 3 Then
            currentSRP = Me.ItemsDataGridView.CurrentCell.Value
        ElseIf Me.ItemsDataGridView.CurrentCell.ColumnIndex = 5 Then
            currentCost = Me.ItemsDataGridView.CurrentCell.Value
        End If
    End Sub

    Private Sub worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork
        If colonedit = 3 Then
            If currentSRP = Me.ItemsDataGridView.Rows(rowonedit).Cells(colonedit).Value Then
            Else
                Me.ItemsDataGridView.Rows(rowonedit).Cells(4).Value = currentSRP
            End If
        ElseIf colonedit = 5 Then
            If currentCost = Me.ItemsDataGridView.Rows(rowonedit).Cells(colonedit).Value Then
            Else
                Me.ItemsDataGridView.Rows(rowonedit).Cells(6).Value = currentCost
            End If
        End If
        com = New SqlCommand("UPDATE Inv SET SRP=@SRP, OldSRP=@OldSRP, updated=@updated, Cost=@Cost, OldCost=@OldCost, CLevel=@CLevel WHERE ItemNo=@ItemNo", conn)
        srp = New SqlParameter("@SRP", SqlDbType.Decimal)
        srpold = New SqlParameter("@OldSRP", SqlDbType.Decimal)
        cost = New SqlParameter("@Cost", SqlDbType.Decimal)
        oldcost = New SqlParameter("@OldCost", SqlDbType.Decimal)
        clevel = New SqlParameter("@CLevel", SqlDbType.Int)
        dt = New SqlParameter("@updated", SqlDbType.Date)
        itemno = New SqlParameter("@ItemNo", SqlDbType.Int)
        srp.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(3).Value
        srpold.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(4).Value
        cost.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(5).Value
        oldcost.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(6).Value
        clevel.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(9).Value
        itemno.Value = Me.ItemsDataGridView.Rows(rowonedit).Cells(0).Value
        dt.Value = DateValue(Now)
        com.Parameters.Add(srp)
        com.Parameters.Add(srpold)
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
        conn.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If File.Exists(Application.StartupPath + "\Total Cost.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\Total Cost.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If




        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\Total Cost.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        Dim rc(Me.MasterFileDataset.Items.DefaultView.Count, 5)
        Dim stock As Integer
        Dim cost As Decimal
        For x As Integer = 0 To Me.MasterFileDataset.Items.DefaultView.Count - 1
            With Me.MasterFileDataset.Items.DefaultView.Item(x)
                rc(x, 0) = .Item("IDesc")
                rc(x, 1) = .Item("IUnit")
                rc(x, 2) = .Item("Qty")
                Try
                    stock = .Item("Qty")
                Catch ex As Exception
                    stock = 0
                End Try
                rc(x, 3) = .Item("Cost")
                Try
                    cost = .Item("Cost")
                Catch ex As Exception
                    cost = 0
                End Try

                rc(x, 4) = cost * stock

            End With
        Next
        wsheet.Range("A3").Value = DateTimePicker1.Value.ToShortDateString
        wsheet.Range("A6", "E" + (Me.MasterFileDataset.Items.DefaultView.Count + 5).ToString).Value = rc
        wsheet.Range("A5", "E" + (Me.MasterFileDataset.Items.DefaultView.Count + 5).ToString).Borders.Weight = 2

        wbook.SaveAs(Application.StartupPath + "\Total Cost.xls")
        xapp.Visible = True
    End Sub
End Class