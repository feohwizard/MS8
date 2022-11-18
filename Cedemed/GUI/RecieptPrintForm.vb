Imports Microsoft.Office.Interop
Public Class RecieptPrintForm
    Public reprint As Boolean = False
    Public transno As Integer
    Private Sub TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionsDataset)

    End Sub

    Private Sub RecieptPrintForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If reprint = True Then
        Else
            salesform.grandlabel.Text = "0.00"
            salesform.grandtotal = 0
            salesform.unitcost = 0
            salesform.totalunitcost = 0
            salesform.itemnotxt.Text = ""
            salesform.quantitytxt.Text = ""
            salesform.unitcosttxt.Text = ""
            salesform.totalcosttxt.Text = ""
            salesform.subtotaltxt.Text = ""
            salesform.totalpaymenttxt.Clear()
            salesform.paymenttxt.Clear()
            salesform.changetxt.Clear()
            salesform.InventoryDataset.Purchases.Clear()
            salesform.ItemsTableAdapter.Fill(salesform.InventoryDataset.Items)
            salesform.Searchbox.Text = " "
            salesform.Searchbox.Text = ""
            salesform.Searchbox.Focus()
        End If


    End Sub

    Private Sub RecieptPrintForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.ItemsDataset.Items)
        Me.TransTableAdapter.FillByTrans(Me.TransactionsDataset.Trans, transno)
        Me.SalesTableAdapter.FillByTrans(Me.TransactionsDataset.Sales, transno)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()
    End Sub

    Private Sub receipt2()
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\SalesOrder.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)
        With wsheet
            .Range("AD10").Value = TransNoTextBox.Text
            .Range("F10").Value = CustNameTextBox.Text
            .Range("AD11").Value = CType(Me.TransDateDateTimePicker.Value, Date).ToShortDateString
            If reprint = True Then
                .Range("AD9").Value = "REPRINTED"
            Else
                .Range("AD9").Value = CType(Me.TransDateDateTimePicker.Value, Date).ToShortDateString + " - " + Now.ToShortTimeString
            End If
        End With
        Dim strt As Integer = 0
        Dim dt As DataTable
back:


        Dim itemss(14, 7) As String
        Dim description(14, 1) As String
        Dim expiry(14, 1) As String
        Dim lot(14, 1) As String
        Dim price(14, 1) As Double
        Dim totals(14, 1) As Double
        Dim counter As Integer = 1
        For x As Integer = 0 To Me.TransactionsDataset.Sales.DefaultView.Count - 1
            With wsheet
                dt = Me.ItemsDataset.Items.Select("ItemNo=" + Me.TransactionsDataset.Sales.DefaultView.Item(x).Item("ItemNo").ToString).CopyToDataTable
                Try
                    itemss(counter - 1, 0) = Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(5).ToString + dt.Rows(0).Item(2).ToString
                Catch ex As Exception
                    itemss(counter - 1, 0) = "-"
                End Try

                Try
                    description(counter - 1, 0) = dt.Rows(0).Item(1).ToString
                Catch ex As Exception
                    description(counter - 1, 0) = "-"
                End Try
                expiry(counter - 1, 0) = CType(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(8).ToString, Date).ToShortDateString
                lot(counter - 1, 0) = Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(9).ToString

                price(counter - 1, 0) = CType(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(10).ToString, Decimal)
                totals(counter - 1, 0) = CType(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(10).ToString, Decimal) * Val(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(5))

            End With
            If counter = 14 Then
                wsheet.Range("A14", "A27").Value = itemss
                wsheet.Range("H14", "H27").Value = description
                wsheet.Range("T14", "T27").Value = expiry
                wsheet.Range("Y14", "Y27").Value = lot
                wsheet.Range("AD14", "AD27").Value = price
                wsheet.Range("AH14", "AH27").Value = totals
                wsheet.Range("A29").Value = "Prepared By: " + user + " - " + Now.Date.ToShortDateString + " " + Now.ToShortTimeString
                wsheet.Range("AH28").Formula = "=SUM(AH14:AH27)"
                wsheet.PrintOutEx(1, 1)
                ReDim itemss(14, 7)
                ReDim price(14, 1)
                ReDim totals(14, 1)
                ReDim description(14, 1)
                ReDim expiry(14, 1)
                ReDim lot(14, 1)
                counter = 1
                GoTo skip
            End If
            If x = Me.TransactionsDataset.Sales.DefaultView.Count - 1 And counter <> 14 Then
                wsheet.Range("A14", "A27").Value = itemss
                wsheet.Range("H14", "H27").Value = description
                wsheet.Range("T14", "T27").Value = expiry
                wsheet.Range("Y14", "Y27").Value = lot
                wsheet.Range("AD14", "AD27").Value = price
                wsheet.Range("AH14", "AH27").Value = totals
                wsheet.Range("A29").Value = "Prepared By: " + user + " - " + Now.Date.ToShortDateString + " " + Now.ToShortTimeString
                wsheet.Range("AH28").Formula = "=SUM(AH14:AH27)"
                wsheet.PrintOutEx(1, 1)
                Exit For
            End If
            counter += 1
skip:
        Next
        xapp.Workbooks.Item(1).Close(False)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'DRReceipt.xls
        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet


        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\SalesOrder.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        With wsheet
            .Range("AD10").Value = TransNoTextBox.Text
            .Range("F10").Value = CustNameTextBox.Text
            .Range("AD11").Value = CType(Me.TransDateDateTimePicker.Value, Date).ToShortDateString
            If reprint = True Then
                .Range("AD9").Value = "REPRINTED"
            Else
                .Range("AD9").Value = CType(Me.TransDateDateTimePicker.Value, Date).ToShortDateString + " - " + Now.ToShortTimeString
            End If
        End With
        Dim strt As Integer = 0
        Dim dt As DataTable
back:


        Dim itemss(14, 7) As String
        Dim description(14, 1) As String
        Dim expiry(14, 1) As String
        Dim lot(14, 1) As String
        Dim price(14, 1) As Double
        Dim totals(14, 1) As Double
        Dim counter As Integer = 1
        For x As Integer = 0 To Me.TransactionsDataset.Sales.DefaultView.Count - 1
            With wsheet
                dt = Me.ItemsDataset.Items.Select("ItemNo=" + Me.TransactionsDataset.Sales.DefaultView.Item(x).Item("ItemNo").ToString).CopyToDataTable
                Try
                    itemss(counter - 1, 0) = Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(5).ToString + dt.Rows(0).Item(2).ToString
                Catch ex As Exception
                    itemss(counter - 1, 0) = "-"
                End Try

                Try
                    description(counter - 1, 0) = dt.Rows(0).Item(1).ToString
                Catch ex As Exception
                    description(counter - 1, 0) = "-"
                End Try
                expiry(counter - 1, 0) = CType(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(8).ToString, Date).ToShortDateString
                lot(counter - 1, 0) = Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(9).ToString

                price(counter - 1, 0) = CType(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(7).ToString, Decimal)
                totals(counter - 1, 0) = CType(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(7).ToString, Decimal) * Val(Me.TransactionsDataset.Sales.DefaultView.Item(x).Item(5))

            End With
            If counter = 14 Then
                wsheet.Range("A14", "A27").Value = itemss
                wsheet.Range("H14", "H27").Value = description
                wsheet.Range("T14", "T27").Value = expiry
                wsheet.Range("Y14", "Y27").Value = lot
                wsheet.Range("AD14", "AD27").Value = price
                wsheet.Range("AH14", "AH27").Value = totals
                wsheet.Range("A29").Value = "Prepared By: " + user + " - " + Now.Date.ToShortDateString + " " + Now.ToShortTimeString
                wsheet.Range("AH28").Formula = "=SUM(AH14:AH27)"
                wsheet.PrintOutEx(1, 1)
                ReDim itemss(14, 7)
                ReDim price(14, 1)
                ReDim totals(14, 1)
                ReDim description(14, 1)
                ReDim expiry(14, 1)
                ReDim lot(14, 1)
                counter = 1
                GoTo skip
            End If
            If x = Me.TransactionsDataset.Sales.DefaultView.Count - 1 And counter <> 14 Then
                wsheet.Range("A14", "A27").Value = itemss
                wsheet.Range("H14", "H27").Value = description
                wsheet.Range("T14", "T27").Value = expiry
                wsheet.Range("Y14", "Y27").Value = lot
                wsheet.Range("AD14", "AD27").Value = price
                wsheet.Range("AH14", "AH27").Value = totals
                wsheet.Range("A29").Value = "Prepared By: " + user + " - " + Now.Date.ToShortDateString + " " + Now.ToShortTimeString
                wsheet.Range("AH28").Formula = "=SUM(AH14:AH27)"
                wsheet.PrintOutEx(1, 1)
                Exit For
            End If
            counter += 1
skip:
        Next
        xapp.Workbooks.Item(1).Close(False)

        If Me.TransactionsDataset.Trans.Rows(0).Item("PAYMODE") = "GOVT" Then
            'receipt2()
        End If
    End Sub
End Class