Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ProductDirectory
    Dim go As Boolean = False
    Dim frm As Posting
    Dim ms As String = ""
    Dim conn As New SqlConnection
    Dim adap As New SqlDataAdapter
    Dim dbset As New DataSet
    Dim com As New SqlCommand
    Dim itemno As Integer
    Dim query As String
    Dim sup As New SqlParameter("@sup", SqlDbType.NVarChar)
    Dim desc As New SqlParameter("@desc", SqlDbType.NVarChar)
    Dim unit As New SqlParameter("@unit", SqlDbType.NVarChar)
    Dim manu As New SqlParameter("@manu", SqlDbType.NVarChar)
    Dim dt As New SqlParameter("@dd", SqlDbType.Date)

    Private Sub ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ItemsDataset)

    End Sub

    Private Sub ProductDirectory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManufacturerDataset.Manufacturer' table. You can move, or remove it, as needed.
        Me.ManufacturerTableAdapter.Fill(Me.ManufacturerDataset.Manufacturer)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataset.Supplier)
        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)

        For Each rw As DataRow In Me.ManufacturerDataset.Manufacturer.Rows
            manufacturercombo.Items.Add(rw.Item(1).ToString)
        Next
        For Each rw As DataRow In Me.SupplierDataset.Supplier.Rows
            suppliercombo.Items.Add(rw.Item(0).ToString)
        Next
        Me.ItemsDataGridView.FirstDisplayedScrollingRowIndex = Me.ItemsDataGridView.RowCount - 1
        Me.ItemsDataGridView.Rows(Me.ItemsDataGridView.RowCount - 1).Selected = True
        itype.SelectedIndex = 0
    End Sub

    Private Sub ItemsDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellEnter
        Try
            SendKeys.Send("{F2}")
        Catch ex As Exception
        End Try
        If ItemsDataGridView.CurrentRow.IsNewRow Then
            Try
                ItemsDataGridView.CurrentRow.Cells(0).Value = Val(ItemsDataGridView.Rows(ItemsDataGridView.CurrentRow.Index - 1).Cells(0).Value) + 1
            Catch ex As Exception
                ItemsDataGridView.CurrentRow.Cells(0).Value = 1
            End Try

        End If
    End Sub

    Private Sub ItemsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ItemsDataGridView.DataError
        Dim bCancel As Boolean = e.Exception.GetType.Equals(GetType(System.ArgumentException))
        e.Cancel = bCancel
    End Sub

    Private Sub ItemsDataGridView_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ItemsDataGridView.MouseUp

    End Sub

    Private Sub UpdateBranchesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub closeform()
        frm.Close()
    End Sub
    Private Sub ItemsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellContentClick

    End Sub

    Private Sub updatesv2(ByVal sql As String)
        Dim conn As New SqlConnection(sql)
        query = ""
        Dim cc As Integer = 0
        Dim com As New SqlCommand("", conn)
        For Each rw As DataGridViewRow In Me.ItemsDataGridView.SelectedRows
            cc = cc + 1
            itemno = rw.Cells(0).Value
            'check Items Table
            adap = New SqlDataAdapter("select itemno from Items where ItemNo=" + itemno.ToString, conn)
            dbset = New DataSet
            dbset.Clear()
            adap.Fill(dbset, "a")

            If Me.dbset.Tables("a").DefaultView.Count = 0 Then
                query = query + "Insert into Items (ItemNo,Idesc,IUnit,ProdType,VendCode,Supplier,Manufacturer,type) values (" + itemno.ToString + ",@desc" + cc.ToString + ",@unit" + cc.ToString + ",'" + rw.Cells(3).Value.ToString + "'," + Val(rw.Cells(4).Value).ToString + ",@sup" + cc.ToString + ",@manu" + cc.ToString + ",'" + rw.Cells(7).Value.ToString + "');"
                query = query + "Insert into Inv(ItemNo,Qty,SRP,updated,Clevel,Cost,OldCost) values (" + itemno.ToString + ",0,$0,@dd" + cc.ToString + ",0,$0,$0);"
                sup = New SqlParameter("@sup" + cc.ToString, SqlDbType.NVarChar)
                desc = New SqlParameter("@desc" + cc.ToString, SqlDbType.NVarChar)
                unit = New SqlParameter("@unit" + cc.ToString, SqlDbType.NVarChar)
                manu = New SqlParameter("@manu" + cc.ToString, SqlDbType.NVarChar)
                dt = New SqlParameter("@dd" + cc.ToString, SqlDbType.Date)
                sup.Value = rw.Cells(5).Value
                desc.Value = rw.Cells(1).Value
                unit.Value = rw.Cells(2).Value
                manu.Value = rw.Cells(6).Value
                dt.Value = Now

                com.Parameters.Add(sup)
                com.Parameters.Add(desc)
                com.Parameters.Add(unit)
                com.Parameters.Add(manu)
                com.Parameters.Add(dt)
            Else
                query = query + "UPDATE Items SET Idesc=@desc" + cc.ToString + ", IUnit=@unit" + cc.ToString + ", ProdType='" + rw.Cells(3).Value.ToString + "', VendCode=" + Val(rw.Cells(4).Value).ToString + ", Supplier=@sup" + cc.ToString + ", Manufacturer=@manu" + cc.ToString + ", type='" + rw.Cells(7).Value.ToString + "' WHERE ItemNo=" + rw.Cells(0).Value.ToString + ";"
                sup = New SqlParameter("@sup" + cc.ToString, SqlDbType.NVarChar)
                desc = New SqlParameter("@desc" + cc.ToString, SqlDbType.NVarChar)
                unit = New SqlParameter("@unit" + cc.ToString, SqlDbType.NVarChar)
                manu = New SqlParameter("@manu" + cc.ToString, SqlDbType.NVarChar)
                sup.Value = rw.Cells(5).Value
                desc.Value = rw.Cells(1).Value
                unit.Value = rw.Cells(2).Value
                manu.Value = rw.Cells(6).Value
                com.Parameters.Add(sup)
                com.Parameters.Add(desc)
                com.Parameters.Add(unit)
                com.Parameters.Add(manu)

                adap = New SqlDataAdapter("Select Itemno from Inv where Itemno=" + itemno.ToString, conn)
                dbset = New DataSet
                dbset.Clear()
                adap.Fill(dbset, "a")
                If dbset.Tables("a").DefaultView.Count = 0 Then
                    query = query + "Insert into Inv(ItemNo,Qty,SRP,updated,Clevel,Cost,OldCost) values (" + itemno.ToString + ",0,$0,@dd" + cc.ToString + ",0,$0,$0);"
                    dt = New SqlParameter("@dd" + cc.ToString, SqlDbType.Date)
                    dt.Value = Now
                    com.Parameters.Add(dt)

                End If
            End If
        Next

        com.CommandText = query
        com.CommandTimeout = 0
        'Clipboard.SetText(query)


        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            conn.Open()
        End Try

        com.ExecuteNonQuery()
        conn.Close()




    End Sub

    Private Sub updates(ByVal sql As String)
        query = ""
        itemno = Me.ItemsDataGridView.CurrentRow.Cells(0).Value
        conn = New SqlConnection(sql)
        'check Items Table
        adap = New SqlDataAdapter("Select itemno from Items where ItemNo=" + itemno.ToString, conn)
        dbset = New DataSet
        dbset.Clear()
        adap.Fill(dbset, "a")
        If Me.dbset.Tables("a").DefaultView.Count = 0 Then
            'Insert to Items and Inv Table
            With Me.ItemsDataGridView.CurrentRow
                query = query + "Insert into Items (ItemNo,Idesc,IUnit,ProdType,VendCode,Supplier,Manufacturer,type) values (" + .Cells(0).Value.ToString + ",@desc,@unit,'" + .Cells(2).Value.ToString + "'," + Val(.Cells(4).Value).ToString + ",@sup,@manu,'" + .Cells(7).Value.ToString + "');"
                query = query + "Insert into Inv(ItemNo,Qty,SRP,Date,Clevel,Cost,OldCost) values (" + itemno.ToString + ",0,$0,@dd,0,$0,$0);"
                sup = New SqlParameter("@sup", SqlDbType.NVarChar)
                desc = New SqlParameter("@desc", SqlDbType.NVarChar)
                unit = New SqlParameter("@unit", SqlDbType.NVarChar)
                manu = New SqlParameter("@manu", SqlDbType.NVarChar)
                dt = New SqlParameter("@dd", SqlDbType.Date)
                sup.Value = .Cells(5).Value
                desc.Value = .Cells(1).Value
                unit.Value = .Cells(2).Value
                manu.Value = .Cells(6).Value
                dt.Value = Now

                com = New SqlCommand(query, conn)
                com.Parameters.Add(sup)
                com.Parameters.Add(desc)
                com.Parameters.Add(unit)
                com.Parameters.Add(manu)
                com.Parameters.Add(dt)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            End With
        Else
            query = ""
            With Me.ItemsDataGridView.CurrentRow
                'Before you check the Inv, Update first the Items
                query = "UPDATE Items SET Idesc=@desc, IUnit=@unit, ProdType='" + .Cells(2).Value.ToString + "', VendCode=" + Val(.Cells(4).Value).ToString + ", Supplier=@sup, Manufacturer=@manu, type='" + .Cells(7).Value.ToString + "' WHERE ItemNo=" + .Cells(0).Value.ToString + ";"

                sup = New SqlParameter("@sup", SqlDbType.NVarChar)
                desc = New SqlParameter("@desc", SqlDbType.NVarChar)
                unit = New SqlParameter("@unit", SqlDbType.NVarChar)
                manu = New SqlParameter("@manu", SqlDbType.NVarChar)
                dt = New SqlParameter("@dd", SqlDbType.Date)
                sup.Value = .Cells(5).Value
                desc.Value = .Cells(1).Value
                unit.Value = .Cells(2).Value
                manu.Value = .Cells(6).Value
                dt.Value = Now

                com = New SqlCommand(query, conn)
                com.Parameters.Add(sup)
                com.Parameters.Add(desc)
                com.Parameters.Add(unit)
                com.Parameters.Add(manu)
                com.Parameters.Add(dt)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()


                'End
                query = ""
                adap = New SqlDataAdapter("Select Itemno from Inv where Itemno=" + itemno.ToString, conn)
                dbset = New DataSet
                dbset.Clear()
                adap.Fill(dbset, "a")
                If dbset.Tables("a").DefaultView.Count = 0 Then
                    query = "Insert into Inv(ItemNo,Qty,SRP,Date,Clevel,Cost,OldCost) values (" + itemno.ToString + ",0,$0,@dd,0,$0,$0);"
                    dt = New SqlParameter("@dd", SqlDbType.Date)
                    dt.Value = Now

                    com = New SqlCommand(query, conn)
                    com.Parameters.Add(dt)
                    conn.Open()
                    com.ExecuteNonQuery()
                    conn.Close()
                End If
            End With

        End If

    End Sub

    Private Sub savee()
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(Me.ItemsDataset.Items)
    End Sub

    Private Sub worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork

        updatesv2(My.Settings.CedemedConnectionString)

        If tanedo.Checked = True Then
            Try
                updatesv2(My.Settings.Branch1)
            Catch ex As Exception
                ms = ms + "Tanedo" + vbCrLf
            End Try

        End If

        If sanvicente.Checked = True Then
            Try
                updatesv2(My.Settings.Branch2)
            Catch ex As Exception
                ms = ms + "San Vicente" + vbCrLf
            End Try
        End If



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If idescription.Text = "" Or idescription.Text.Contains("'") Then
            MsgBox("Invalid Entry")
            Exit Sub
        End If

        Dim price As Decimal
        Try
            price = CType(iprice.Text, Decimal)
        Catch ex As Exception
            MsgBox("Invalid Price")
            Exit Sub
        End Try

        conn = New SqlConnection(My.Settings.CedemedConnectionString)
        Dim dbset As New DataSet
        Dim adap As New SqlDataAdapter("select max(ITEMNO)+1 FROM Items", conn)
        adap.Fill(dbset, "maxitem")
        Dim mx As Integer = dbset.Tables("maxitem").Rows(0).Item(0)

        adap = New SqlDataAdapter("select itemno from Items where IDesc='" + idescription.Text + "'", conn)
        dbset.Clear()
        adap.Fill(dbset, "duplicate")
        Dim yy As String
        If dbset.Tables("duplicate").Rows.Count = 0 Then
        Else
            yy = MsgBox("You have similar item in the database. It may result into duplicate item. Do you want to continue?", vbYesNo, "Confirmation")
            If yy = vbYes Then
            Else
                Exit Sub
            End If
        End If

        query = ""
        query = query + "Insert into Items (ItemNo,Idesc,IUnit,ProdType,Supplier,Manufacturer,type,BarCode,Vendcode) values (" + mx.ToString + ",@desc,@unit,'" + itype.Text + "',@sup,@manu,'" + TextBox4.Text + "','',0);"
        query = query + "Insert into Inv(ItemNo,Qty,SRP,Date,Clevel,Cost,OldCost) values (" + mx.ToString + ",0,$" + price.ToString + ",@dd,0,$0,$0);"
        sup = New SqlParameter("@sup", SqlDbType.NVarChar)
        desc = New SqlParameter("@desc", SqlDbType.NVarChar)
        unit = New SqlParameter("@unit", SqlDbType.NVarChar)
        manu = New SqlParameter("@manu", SqlDbType.NVarChar)
        dt = New SqlParameter("@dd", SqlDbType.Date)
        sup.Value = suppliercombo.Text
        desc.Value = idescription.Text
        unit.Value = iunit.Text
        manu.Value = manufacturercombo.Text
        dt.Value = Now

        com = New SqlCommand(query, conn)
        com.Parameters.Add(sup)
        com.Parameters.Add(desc)
        com.Parameters.Add(unit)
        com.Parameters.Add(manu)
        com.Parameters.Add(dt)
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()

        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        Me.ItemsDataGridView.FirstDisplayedScrollingRowIndex = Me.ItemsDataGridView.RowCount - 1
        Me.ItemsDataGridView.Rows(Me.ItemsDataGridView.RowCount - 1).Selected = True

        MsgBox("New Item Added Successfuly")
        idescription.Text = ""
        iprice.Text = "0.00"
        iunit.Text = ""
        itype.Text = ""
        suppliercombo.Text = ""
        manufacturercombo.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If frm Is Nothing Then
        Else
            frm.Close()
        End If
        frm = New Posting
        frm.loader = True
        frm.Show()
        ms = ""

        'updatesv2("wehh")
        Button2.Enabled = False
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles worker.RunWorkerCompleted
        If ms.Length = 0 Then
            MsgBox("Updated.")
        Else
            MsgBox("Unable to update the following branch(es):" + vbCrLf + ms + "Please check the network and Re-Update again to ensure the accurateness of Items across the Branches.")
        End If
        Try
            frm.Close()
        Catch ex As Exception

        End Try
        Button2.Enabled = True
    End Sub
End Class