Imports Microsoft.Office.Interop
Imports System.IO
Public Class RecieveStocks

    Private Sub UnclaimStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RecevTableAdapter.FillBySuccess(Me.ReceiveDataset.Recev)
    End Sub

    Private Sub RecevBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecevBindingSource.PositionChanged
        Try
            Me.RecevItemsTableAdapter.Fill(Me.ReceiveDataset.RecevItems, Me.ReceiveDataset.Recev.DefaultView.Item(Me.RecevBindingSource.Position).Item("transid"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ReceiveDataset.RecevItems.DefaultView.Count = 0 Then
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
        wsheet.Range("A3").Value = "Stocks Received from " + Me.ReceiveDataset.Recev.DefaultView.Item(Me.RecevBindingSource.Position).Item("frombranch")
        wsheet.Range("A4").Value = "Transfered by " + Me.ReceiveDataset.Recev.DefaultView.Item(Me.RecevBindingSource.Position).Item("transactionuser")
        wsheet.Range("A5").Value = Me.ReceiveDataset.Recev.DefaultView.Item(Me.RecevBindingSource.Position).Item("transdate")
        wsheet.Range("D2").Value = Me.ReceiveDataset.Recev.DefaultView.Item(Me.RecevBindingSource.Position).Item("commontrans")

        For x As Integer = 0 To Me.ReceiveDataset.RecevItems.DefaultView.Count - 1
            With Me.ReceiveDataset.RecevItems.DefaultView.Item(x)
                wsheet.Range("A" + (x + 8).ToString).Value = .Item("Idesc")
                wsheet.Range("B" + (x + 8).ToString).Value = .Item("Qty")
                wsheet.Range("C" + (x + 8).ToString).Value = .Item("Expiry")
                wsheet.Range("D" + (x + 8).ToString).Value = .Item("lotno")
                wsheet.Range("A" + (x + 8).ToString + ":D" + (x + 8).ToString).Borders.Weight = 2
            End With
        Next
        wsheet.Range("A" + (Me.ReceiveDataset.RecevItems.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.ReceiveDataset.RecevItems.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"
        wbook.SaveAs(Application.StartupPath + "\StockReceve.xls")
        xapp.Visible = True
    End Sub

    Private Sub TransdateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles TransdateDateTimePicker.ValueChanged

    End Sub
End Class