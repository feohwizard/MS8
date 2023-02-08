Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Public Class TranferRecord

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TransferBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TransferBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransferDataset)

    End Sub

    Private Sub TranferRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItemsDataset.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        Me.TransferTableAdapter.FillByDate(Me.TransferDataset.Transfer, DateValue(Now.Date))
        If Me.TransferDataset.Transfer.DefaultView.Count = 0 Then
        Else
            Me.TranferItemsTableAdapter.Fill(Me.TransferDataset.TranferItems, Me.TransferDataset.Transfer.Rows(0).Item("transid"))
            furnish()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As String = MsgBox("Are you sure you want to cancel this transaction?", vbYesNo, "Confirmation")
        If a = vbYes Then
            Dim branch As String = Me.TransferBindingSource.Current.Item("tobranch")
            Dim connstring As String = ""
            If branch = "Main" Then
                connstring = My.Settings.MainBranch
            ElseIf branch = "Tanedo" Then
                connstring = My.Settings.Branch1
            ElseIf branch = "San Vicente" Then
                connstring = My.Settings.Branch2
            End If
            Dim tconn As New SqlConnection(connstring)
            Dim ad As New SqlDataAdapter("select status,transid from Recev where frombranch='" + branchname + "' and commontrans=" + Me.TransferBindingSource.Current.Item("transid").ToString, tconn)
            Dim dset As New DataSet
            ad.Fill(dset, "a")
            If dset.Tables("a").DefaultView.Count = 0 Then
            Else
                If dset.Tables("a").DefaultView.Item(0).Item("status") = True Then
                    MsgBox("You cannot cancel this transaction because the items contained in this transaction was already claimed by the receipient. You can ask them to send it back.")
                    Exit Sub
                Else
                    Dim com As New SqlCommand("delete from Recev where transid=" + dset.Tables("a").DefaultView.Item(0).Item("transid").ToString + "; delete from RecevItems where transid=" + dset.Tables("a").DefaultView.Item(0).Item("transid").ToString, tconn)
                    tconn.Open()
                    com.ExecuteNonQuery()
                    tconn.Close()
                End If
            End If

            Dim comm As SqlCommand
            comm = New SqlCommand("Delete from transfer where transid=" + Me.TransferBindingSource.Current.Item("transid").ToString + "; delete from tranferitems where transid=" + Me.TransferBindingSource.Current.Item("transid").ToString, conn)
            conn.Open()
            comm.ExecuteNonQuery()
            conn.Close()

            Me.TransferDataset.Transfer.Clear()
            Me.TransferDataset.TranferItems.Clear()

            Button1.Enabled = False
            Me.TransferTableAdapter.FillByDate(Me.TransferDataset.Transfer, DateTimePicker1.Value)
            If Me.TransferDataset.Transfer.DefaultView.Count = 0 Then
            Else
                Me.TranferItemsTableAdapter.Fill(Me.TransferDataset.TranferItems, Me.TransferBindingSource.Current.Item("transid").ToString)
                Button1.Enabled = True
            End If
            MsgBox("Transfer is canceled. All Items has been re-entered in the inventory.")
        End If
    End Sub

    Private Sub TransferBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles TransferBindingSource.CurrentChanged
      

    End Sub

    Private Sub TransdateDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles TransdateDateTimePicker.ValueChanged
        'Try
        'Me.TransferDataset.Transfer.Clear()
        'Me.TransferDataset.TranferItems.Clear()
        'Me.TransferTableAdapter.FillByDate(Me.TransferDataset.Transfer, DateTimePicker1.Value)
        'If Me.TransferDataset.Transfer.DefaultView.Count = 0 Then
        'Else
        'Me.TranferItemsTableAdapter.Fill(Me.TransferDataset.TranferItems, Me.TransferDataset.Transfer.DefaultView.Item(0).Item("transid"))
        'Button1.Enabled = True
        'End If
        ' Catch ex As Exception

        'End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.TransferTableAdapter.FillByBetween(Me.TransferDataset.Transfer, DateValue(DateTimePicker2.Value), DateValue(DateTimePicker3.Value))
        If Me.TransferDataset.Transfer.DefaultView.Count = 0 Then
        Else
            Me.TranferItemsTableAdapter.Fill(Me.TransferDataset.TranferItems, Me.TransferDataset.Transfer.Rows(0).Item("transid"))
            Button1.Enabled = True
        End If
    End Sub

    Private Sub TranferItemsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TranferItemsDataGridView.DataError
        Dim bCancel As Boolean = e.Exception.GetType.Equals(GetType(System.ArgumentException))
        e.Cancel = bCancel
    End Sub

    Private Sub TranferItemsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranferItemsBindingSource.CurrentChanged

    End Sub

    Private Sub TransferBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TransferBindingSource.PositionChanged
        furnish()
    End Sub

    Private Sub furnish()
        Try
            Me.TranferItemsTableAdapter.Fill(Me.TransferDataset.TranferItems, Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transid"))
            Button1.Enabled = True
            Dim branch As String = Me.TransferBindingSource.Current.Item("tobranch")
            Dim connstring As String = ""
            If branch = "Main" Then
                connstring = My.Settings.MainBranch
            ElseIf branch = "Tanedo" Then
                connstring = My.Settings.Branch1
            ElseIf branch = "San Vicente" Then
                connstring = My.Settings.Branch2
            End If
            Dim tconn As New SqlConnection(connstring)
            'MsgBox("select status,transid from Recev where frombranch='" + branchname + "' and commontrans=" + Me.TransferBindingSource.Current.Item("transid").ToString)
            Dim ad As New SqlDataAdapter("select status,transid from Recev where frombranch='" + branchname + "' and commontrans=" + Me.TransferBindingSource.Current.Item("transid").ToString, tconn)
            Dim dset As New DataSet
            dset.Clear()
            ad.Fill(dset, "a")
            If dset.Tables("a").DefaultView.Count = 0 Then
                TransidTextBox.BackColor = Color.Green
                Button1.Enabled = False
            Else
                'MsgBox(dset.Tables("a").DefaultView.Item(0).Item("status").ToString + " " + connstring)
                If dset.Tables("a").DefaultView.Item(0).Item("status") = True Then
                    TransidTextBox.BackColor = Color.Green
                    Button1.Enabled = False
                Else
                    TransidTextBox.BackColor = Color.White
                    Button1.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Button1.Enabled = False
            TransidTextBox.BackColor = Color.Green
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.TransferDataset.TranferItems.DefaultView.Count = 0 Then
            MsgBox("No Stocks to Print.")
            Exit Sub
        End If

        If File.Exists(Application.StartupPath + "\StockReceve.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\StockReceve.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If


        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\StockReceve.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        wsheet.Range("A3").Value = "Stocks transfered to " + Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("tobranch")
        wsheet.Range("A4").Value = "Transfered by " + Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transactionuser")
        wsheet.Range("A5").Value = Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transdate")
        wsheet.Range("D2").Value = Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transid")

        For x As Integer = 0 To Me.TransferDataset.TranferItems.DefaultView.Count - 1
            With Me.TransferDataset.TranferItems.DefaultView.Item(x)
                wsheet.Range("A" + (x + 8).ToString).Value = getitem(.Item("Itemno"))
                wsheet.Range("B" + (x + 8).ToString).Value = .Item("Qty")
                wsheet.Range("C" + (x + 8).ToString).Value = .Item("Expiry")
                wsheet.Range("D" + (x + 8).ToString).Value = .Item("lotno")
                wsheet.Range("A" + (x + 8).ToString + ":D" + (x + 8).ToString).Borders.Weight = 2
            End With
        Next

        wsheet.Range("A" + (Me.TransferDataset.TranferItems.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransferDataset.TranferItems.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"
        wbook.SaveAs(Application.StartupPath + "\StockReceve.xls")
        xapp.Visible = True
    End Sub
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Private Function getitem(ByVal x As Integer) As String
        Dim adap As New SqlDataAdapter("select idesc from items where itemno=" + x.ToString, conn)
        Dim dbset As New DataSet
        adap.Fill(dbset, "a")
        Try
            Return dbset.Tables("a").DefaultView.Item(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.TransferDataset.TranferItems.DefaultView.Count = 0 Then
            MsgBox("No Stocks to Print.")
            Exit Sub
        End If

        If File.Exists(Application.StartupPath + "\StockReceve.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\StockReceve.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\StockReceve.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        wsheet.Range("A3").Value = "Stocks transfered to " + Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("tobranch")
        wsheet.Range("A4").Value = "Transfered by " + Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transactionuser")
        wsheet.Range("A5").Value = Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transdate")
        wsheet.Range("D2").Value = Me.TransferDataset.Transfer.DefaultView.Item(Me.TransferBindingSource.Position).Item("transid")
        wsheet.Range("E7").Value = "SRP"
        wsheet.Range("F7").Value = "Cost"
        wsheet.Range("E7:F7").Borders.Weight = 2

        For x As Integer = 0 To Me.TransferDataset.TranferItems.DefaultView.Count - 1
            With Me.TransferDataset.TranferItems.DefaultView.Item(x)
                wsheet.Range("A" + (x + 8).ToString).Value = getitem(.Item("Itemno"))
                wsheet.Range("B" + (x + 8).ToString).Value = .Item("Qty")
                wsheet.Range("C" + (x + 8).ToString).Value = .Item("Expiry")
                wsheet.Range("D" + (x + 8).ToString).Value = .Item("lotno")
                wsheet.Range("E" + (x + 8).ToString).Value = .Item("SRP")
                wsheet.Range("F" + (x + 8).ToString).Value = .Item("Cost")
                wsheet.Range("A" + (x + 8).ToString + ":F" + (x + 8).ToString).Borders.Weight = 2
            End With
        Next

        wsheet.Range("A" + (Me.TransferDataset.TranferItems.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransferDataset.TranferItems.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"
        wbook.SaveAs(Application.StartupPath + "\StockReceve.xls")
        xapp.Visible = True
    End Sub

    Private Sub TranferItemsBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles TranferItemsBindingSource.PositionChanged

    End Sub

    Private Sub TranferItemsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TranferItemsDataGridView.CellContentClick

    End Sub

    Private Sub TranferItemsDataGridView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TranferItemsDataGridView.CellMouseUp
        If TranferItemsDataGridView.SelectedRows.Count = 1 Then
            menuu.Items(0).Enabled = True
        Else
            menuu.Items(0).Enabled = True
        End If
    End Sub

    Private Sub ChangeQuantityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeQuantityToolStripMenuItem.Click
        Dim itemno As Integer = Me.TranferItemsDataGridView.CurrentRow.Cells(0).Value
        Dim oldqty As Integer = Me.TranferItemsDataGridView.CurrentRow.Cells(1).Value
        Dim expiry As Date = CType(Me.TranferItemsDataGridView.CurrentRow.Cells(2).Value, Date).ToShortDateString
        Dim lotno As String = Me.TranferItemsDataGridView.CurrentRow.Cells(3).Value
        Dim qty As Integer = 0
        Dim qtyinput = InputBox("Enter New Quantity:", "Change Quantity")
        If IsNumeric(qtyinput) Then
        Else
            MsgBox("Invalid Quantity", vbOKOnly, "Message")
            Exit Sub
        End If
        qty = Val(qtyinput)
        Dim branch As String = Me.TransferBindingSource.Current.Item("tobranch")
        Dim connstring As String = ""
        If branch = "Main" Then
            connstring = My.Settings.MainBranch
        ElseIf branch = "Tanedo" Then
            connstring = My.Settings.Branch1
        ElseIf branch = "San Vicente" Then
            connstring = My.Settings.Branch2
        End If
        Dim tconn As New SqlConnection(connstring)
        Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
        Dim ad As New SqlDataAdapter("select status,transid from Recev where frombranch='" + branchname + "' and commontrans=" + Me.TransferBindingSource.Current.Item("transid").ToString, tconn)
        Dim dset As New DataSet
        ad.Fill(dset, "a")
        If dset.Tables("a").DefaultView.Count = 0 Then
        Else
            If dset.Tables("a").DefaultView.Item(0).Item("status") = True Then
                MsgBox("You cannot edit the quantity. The item was already claimed by the receipient.", vbOKOnly, "Message")
                Exit Sub
            Else
                Dim xpire As SqlParameter
                Dim com As SqlCommand
                Try
                    com = New SqlCommand("UPDATE RecevItems SET Qty=" + qty.ToString + " where transid=" + dset.Tables("a").DefaultView.Item(0).Item("transid").ToString + " and ItemNo=" + itemno.ToString + " and Qty=" + oldqty.ToString + " and Expiry=@expiry and lotno='" + lotno + "'", tconn)
                    xpire = New SqlParameter("@expiry", SqlDbType.DateTime)
                    xpire.Value = expiry
                    com.Parameters.Add(xpire)
                    Try
                        tconn.Open()
                    Catch ex As Exception
                    End Try
                    com.ExecuteNonQuery()
                    tconn.Close()
                Catch ex As Exception
                    MsgBox("An error occured. Please make sure that the Receipient is online.", vbOKOnly, "Message")
                    Exit Sub
                End Try

                com = New SqlCommand("UPDATE TranferItems SET Qty=" + qty.ToString + " where transid=" + Me.TransferBindingSource.Current.Item("transid").ToString + " and ItemNo=" + itemno.ToString + " and Qty=" + oldqty.ToString + " and Expiry=@expiry and lotno='" + lotno + "'", conn)
                xpire = New SqlParameter("@expiry", SqlDbType.DateTime)
                xpire.Value = expiry
                com.Parameters.Add(xpire)
                Try
                    conn.Open()
                Catch ex As Exception
                End Try

                com.ExecuteNonQuery()
                conn.Close()
                Me.TranferItemsDataGridView.CurrentRow.Cells(1).Value = qty
                MsgBox("Edit Completed", vbOK, "Message")
            End If
        End If
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        Dim itemno As Integer = Me.TranferItemsDataGridView.CurrentRow.Cells(0).Value
        Dim oldqty As Integer = Me.TranferItemsDataGridView.CurrentRow.Cells(1).Value
        Dim expiry As Date = CType(Me.TranferItemsDataGridView.CurrentRow.Cells(2).Value, Date).ToShortDateString
        Dim lotno As String = Me.TranferItemsDataGridView.CurrentRow.Cells(3).Value
        Dim validate As String = MsgBox("Are you sure you want to delete selected item?", vbYesNo, "Confirmation")
        If validate = vbYes Then
        Else
            Exit Sub
        End If

        Dim branch As String = Me.TransferBindingSource.Current.Item("tobranch")
        Dim connstring As String = ""
        If branch = "Main" Then
            connstring = My.Settings.MainBranch
        ElseIf branch = "Tanedo" Then
            connstring = My.Settings.Branch1
        ElseIf branch = "San Vicente" Then
            connstring = My.Settings.Branch2
        End If
        Dim tconn As New SqlConnection(connstring)
        Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
        Dim ad As New SqlDataAdapter("select status,transid from Recev where frombranch='" + branchname + "' and commontrans=" + Me.TransferBindingSource.Current.Item("transid").ToString, tconn)
        Dim dset As New DataSet
        ad.Fill(dset, "a")
        If dset.Tables("a").DefaultView.Count = 0 Then
        Else
            If dset.Tables("a").DefaultView.Item(0).Item("status") = True Then
                MsgBox("You cannot delete the item. It was already claimed by the receipient.", vbOKOnly, "Message")
                Exit Sub
            Else
                Dim xpire As SqlParameter
                Dim com As SqlCommand
                Try
                    com = New SqlCommand("DELETE FROM RecevItems where transid=" + dset.Tables("a").DefaultView.Item(0).Item("transid").ToString + " and ItemNo=" + itemno.ToString + " and Qty=" + oldqty.ToString + " and Expiry=@expiry and lotno='" + lotno + "'", tconn)
                    xpire = New SqlParameter("@expiry", SqlDbType.DateTime)
                    xpire.Value = expiry
                    com.Parameters.Add(xpire)
                    Try
                        tconn.Open()
                    Catch ex As Exception
                    End Try
                    com.ExecuteNonQuery()
                    tconn.Close()
                Catch ex As Exception
                    MsgBox("An error occured. Please make sure that the Receipient is online.", vbOKOnly, "Message")
                    Exit Sub
                End Try

                com = New SqlCommand("DELETE FROM TranferItems where transid=" + Me.TransferBindingSource.Current.Item("transid").ToString + " and ItemNo=" + itemno.ToString + " and Qty=" + oldqty.ToString + " and Expiry=@expiry and lotno='" + lotno + "'", conn)
                xpire = New SqlParameter("@expiry", SqlDbType.DateTime)
                xpire.Value = expiry
                com.Parameters.Add(xpire)
                Try
                    conn.Open()
                Catch ex As Exception
                End Try

                com.ExecuteNonQuery()
                conn.Close()
                furnish()
                MsgBox("Item Deleted Successfully", vbOK, "Message")
            End If
        End If
    End Sub
End Class