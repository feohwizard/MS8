Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Imports System.IO
Public Class DailySalesrpt
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Private Sub fixtransno()
        Dim start As Integer = getyesterday_lastref()
        MsgBox(start)
        If Me.TransactionsDataset.Trans.Rows.Count = 0 Then
        Else
            Dim xx As Integer
            For xx = Me.TransactionsDataset.Trans.Rows.Count - 1 To 0 Step -1
                If Me.TransactionsDataset.Trans.Rows(xx).Item("ref") = True Then
                    start = start + 1
                    Me.TransactionsDataset.Trans.Rows(xx).Item("intern") = start
                End If

            Next
        End If
        Me.Validate()
        TransBS.EndEdit()
        TransTableAdapter.Update(Me.TransactionsDataset.Trans)
    End Sub

    Public Function getyesterday_lastref() As Integer
        Dim adap As New SqlDataAdapter("Select max(intern) from Trans where transdate between @dt2 and @dt", conn)
        Dim dbset As New DataSet
        Dim dt As New SqlParameter("@dt", SqlDbType.DateTime)
        Dim dt2 As New SqlParameter("@dt2", SqlDbType.DateTime)
        dt.Value = DateAdd(DateInterval.Day, -1, DateValue(from.Value))
        dt2.Value = DateAdd(DateInterval.Day, -10, DateValue(from.Value))
        adap.SelectCommand.Parameters.Add(dt)
        adap.SelectCommand.Parameters.Add(dt2)
        adap.Fill(dbset, "a")
        'MsgBox(dbset.Tables("a").Rows(0).Item(0))
        If dbset.Tables("a").Rows.Count = 0 Then
            Return 0
        Else
            Try
                Return Val(dbset.Tables("a").Rows(0).Item(0))
            Catch ex As Exception
                Return 0
            End Try
        End If
    End Function

    Public Sub clearintern()
        Dim com As New SqlCommand("update Trans set intern=0 where ref=0", conn)
        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            conn.Open()
        End Try
        com.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub fillup(fd As DateTime, td As DateTime)
        from.Value = fd
        tod.Value = td
        If userlevel = "Administrator" Then
            Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, fd, td)
        Else
            Me.TransactionsDataset.EnforceConstraints = False
            Me.TransTableAdapter.FillBy_SI(Me.TransactionsDataset.Trans, fd, td)
            clearintern()
            fixtransno()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        If File.Exists(Application.StartupPath + "\DSales1.xls") = True Then
            Try
                System.IO.File.Delete(Application.StartupPath + "\DSales1.xls")
            Catch ex As Exception
                MsgBox("File in use. Please try again.")
                Exit Sub
            End Try
        Else
        End If





        'On Error Resume Next



        If tod.Value < from.Value Then
            MsgBox("Invalid Entry")
            Exit Sub
        End If

        Dim fd = from.Value.Date
        Dim td = tod.Value.Date

        Dim xapp As New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wsheet As Excel.Worksheet

        xapp.Workbooks.Open(Application.StartupPath + "\ReportTemplates\DSales1.xls")
        wbook = xapp.Workbooks.Item(1)
        wsheet = wbook.Worksheets.Item(1)


        Me.TransTableAdapter.FillBy(Me.TransactionsDataset.Trans, fd, td)


        'Dim rc(Me.StockInDataset.Purchases.DefaultView.Count, 7)

        Dim rc(Me.TransactionsDataset.Trans.DefaultView.Count, 11)

        wsheet.Range("A4").Value = branchname
        wsheet.Range("A5").Value = "From " + from.Value.ToShortDateString + " to " + tod.Value.ToShortDateString

        For x As Integer = 0 To Me.TransactionsDataset.Trans.DefaultView.Count - 1
            With Me.TransactionsDataset.Trans.DefaultView.Item(x)
                rc(x, 0) = .Item("TransNo")
                rc(x, 1) = .Item("serverdate")
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
        lastrow = Me.TransactionsDataset.Trans.DefaultView.Count + 7
        Dim subt As Long
        subt = Me.TransactionsDataset.Trans.DefaultView.Count + 8

        'Dim style As Excel.Style = wsheet.Application.ActiveWorkbook.Styles.Add("NewStyle")

        'wsheet.Range("A8", "G" + (Me.StockInDataset.Purchases.DefaultView.Count + 7).ToString).Value = rc
        wsheet.Range("A8", "H" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Value = rc
        wsheet.Range("A" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString, "H" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        wsheet.Range("A" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString, "H" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        wsheet.Range("A" + (Me.TransactionsDataset.Trans.DefaultView.Count + 10).ToString).Value = "Prepared By: " + user
        wsheet.Range("A" + (Me.TransactionsDataset.Trans.DefaultView.Count + 12).ToString).Value = "Verified By:_________________"

        wsheet.Range("E" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(E8:E" & lastrow & ")"
        wsheet.Range("F" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(F8:F" & lastrow & ")"
        wsheet.Range("G" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(G8:G" & lastrow & ")"
        wsheet.Range("H" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Formula = "=Sum(H8:H" & lastrow & ")"
        wsheet.Range("D" + (Me.TransactionsDataset.Trans.DefaultView.Count + 9).ToString).Value = "Total Sale: "
        wsheet.Range("E" + (Me.TransactionsDataset.Trans.DefaultView.Count + 9).ToString).Formula = "=Sum(E" & subt & ":H" & subt & ")"

        wsheet.Range("E" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("F" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("G" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("H" + (Me.TransactionsDataset.Trans.DefaultView.Count + 8).ToString).Font.Bold = True
        wsheet.Range("D" + (Me.TransactionsDataset.Trans.DefaultView.Count + 9).ToString.ToString).Font.Bold = True
        wsheet.Range("E" + (Me.TransactionsDataset.Trans.DefaultView.Count + 9).ToString.ToString).Font.Bold = True
        wsheet.Range("D" + (Me.TransactionsDataset.Trans.DefaultView.Count + 9).ToString.ToString).Font.Color = Color.Blue
        wsheet.Range("E" + (Me.TransactionsDataset.Trans.DefaultView.Count + 9).ToString.ToString).Font.Color = Color.Blue

        wbook.SaveAs(Application.StartupPath + "\DSales1.xls")
        xapp.Visible = True



    End Sub

    Private Sub DailySalesrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tod.Value = Now.Date
        from.Value = Now.Date
    End Sub
End Class