Imports Microsoft.Office.Interop
Imports System.IO
Public Class CashierRPT
    Private Sub fixtransno()
        Dim start As Integer
        If Me.TransactionsDS.Trans.Rows.Count = 0 Or Me.TransactionsDS.Trans.Rows.Count = 1 Then
        Else
            start = Me.TransactionsDS.Trans.Rows(0).Item("TransNo")
            Dim xx As Integer
            For xx = 1 To Me.TransactionsDS.Trans.Rows.Count - 1
                start = start - 1
                Me.TransactionsDS.Trans.Rows(xx).Item("TransNo") = start
            Next
        End If
    End Sub
    Private Sub UsersRestrictionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.UsersRestrictionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RistrictionDataSet)

    End Sub

    Private Sub CashierRPT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RistrictionDataSet.UsersRestriction' table. You can move, or remove it, as needed.
        Me.UsersRestrictionTableAdapter.Fill(Me.RistrictionDataSet.UsersRestriction)
        from.Value = Now.Date
        tod.Value = Now.Date
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If File.Exists(Application.StartupPath + "\DSalesCashier.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\DSalesCashier.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If


        If tod.Value < from.Value Then
            MsgBox("Invalid Entry")
            Exit Sub
        End If

        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim si As New DailySalesrpt
        si.fillup(fd, td)
        si.Dispose()

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\DSalesCashier.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        If userlevel = "Administrator" Then
            Me.TransTA.FillByCashier(Me.TransactionsDS.Trans, fd, td, UsernameComboBox.Text)
        Else
            'Me.TransactionsDS.EnforceConstraints = False
            Me.TransTA.FillByCashier_SI(Me.TransactionsDS.Trans, fd, td, UsernameComboBox.Text)
            'fixtransno()
        End If


        'Dim rc(Me.StockInDataset.Purchases.DefaultView.Count, 7)

        Dim rc(Me.TransactionsDS.Trans.DefaultView.Count, 11)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString + " Cashier : " + UsernameComboBox.Text

        For x As Integer = 0 To Me.TransactionsDS.Trans.DefaultView.Count - 1
            With Me.TransactionsDS.Trans.DefaultView.Item(x)

                If userlevel = "Administrator" Then
                    rc(x, 0) = .Item("TransNo")
                Else
                    rc(x, 0) = .Item("intern")
                End If

                rc(x, 1) = .Item("TransDate")
                rc(x, 2) = .Item("CustName")
                rc(x, 3) = .Item("Discount")
                rc(x, 8) = .Item("PayMode")
                If .Item("PayMode") = "CASH" Then
                    rc(x, 4) = .Item("Total")
                ElseIf .Item("PayMode") = "CHARGE" Then
                    rc(x, 6) = .Item("Total")
                ElseIf .Item("Paymode") = "CHECK" Then
                    rc(x, 5) = .Item("Total")
                ElseIf .Item("Paymode") = "GOVT" Then
                    rc(x, 7) = .Item("Total")

                End If
            End With
        Next

        Dim lastrow As Long
        lastrow = Me.TransactionsDS.Trans.DefaultView.Count + 7
        Dim subt As Long
        subt = Me.TransactionsDS.Trans.DefaultView.Count + 8

        Dim style As Excel.Style = wsheet.Application.ActiveWorkbook.Styles.Add("NewStyle")

        'wsheet.Range("A8", "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 7).ToString).Value = rc
        wsheet.Range("A8", "H" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString, "H" + (TransactionsDS.Trans.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString, "H" + (TransactionsDS.Trans.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDS.Trans.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDS.Trans.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"

        wsheet.Range("E" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(E8:E" & lastrow & ")"
        wsheet.Range("F" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(F8:F" & lastrow & ")"
        wsheet.Range("G" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(G8:G" & lastrow & ")"
        wsheet.Range("H" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(H8:H" & lastrow & ")"
        wsheet.Range("D" + (Me.TransactionsDS.Trans.DefaultView.Count + 9).ToString).Value = "Total Sale: "
        wsheet.Range("E" + (Me.TransactionsDS.Trans.DefaultView.Count + 9).ToString).Formula = "=Sum(E" & subt & ":H" & subt & ")"

        wsheet.Range("E" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("F" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("G" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("H" + (Me.TransactionsDS.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("D" + (Me.TransactionsDS.Trans.DefaultView.Count + 9).ToString.ToString).Font.Bold = True
        wsheet.Range("E" + (Me.TransactionsDS.Trans.DefaultView.Count + 9).ToString.ToString).Font.Bold = True
        wsheet.Range("D" + (Me.TransactionsDS.Trans.DefaultView.Count + 9).ToString.ToString).Font.Color = Color.Blue
        wsheet.Range("E" + (Me.TransactionsDS.Trans.DefaultView.Count + 9).ToString.ToString).Font.Color = Color.Blue

        wbook.SaveAs(Application.StartupPath + "\DSalesCashier.xls")
        xapp.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If File.Exists(Application.StartupPath + "\SalesReportCashier.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\SalesReportCashier.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If

        If tod.Value < from.Value Then
            MsgBox("Invalid Entry")
            Exit Sub
        End If

        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim si As New DailySalesrpt
        si.fillup(fd, td)
        si.Dispose()

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\SalesReportCashier.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)

        'Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, dates)
        'Me.SalesTableAdapter.FillBySrpt(TransactionsDataset.Sales, New System.Nullable(Of Date)(CType(from.Value, Date)), New System.Nullable(Of Date)(CType(tod.Value, Date)))
        If userlevel = "Administrator" Then
            Me.SalesTA.FillByCashier(Me.TransactionsDS.Sales, fd, td, UsernameComboBox.Text)
        Else
            'Me.TransactionsDS.EnforceConstraints = False
            Me.SalesTA.FillByCashier_SI(Me.TransactionsDS.Sales, fd, td, UsernameComboBox.Text)
            'fixtransno()
        End If



        Dim rc(Me.TransactionsDS.Sales.DefaultView.Count, 9)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString + " Cachier : " + Me.UsernameComboBox.Text

        For x As Integer = 0 To Me.TransactionsDS.Sales.DefaultView.Count - 1
            With Me.TransactionsDS.Sales.DefaultView.Item(x)
                rc(x, 0) = .Item("TransNo")
                rc(x, 1) = .Item("SalesDT")
                rc(x, 2) = .Item("ItemNo")
                rc(x, 3) = .Item("IDesc")
                rc(x, 4) = .Item("UnitSold")
                rc(x, 5) = .Item("SRP")
                rc(x, 6) = .Item("SRPTotal")
               
            End With
        Next

        Dim lastrow As Long
        lastrow = Me.TransactionsDS.Sales.DefaultView.Count + 8
        Dim subt As Long
        subt = Me.TransactionsDS.Sales.DefaultView.Count + 8

        wsheet.Range("A8", "I" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString, "G" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString, "G" + (Me.TransactionsDS.Sales.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDS.Sales.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"


        wsheet.Range("G" + (Me.TransactionsDS.Sales.DefaultView.Count + 9).ToString).Formula = "=Sum(G8:G" & lastrow & ")"

        wbook.SaveAs(Application.StartupPath + "\SalesReportCashier.xls")
        xapp.Visible = True
    End Sub
End Class