Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data


Public Class Pivot
    Private _SourceTable As New DataTable()

    Public Sub New(ByVal SourceTable As DataTable)
        _SourceTable = SourceTable
    End Sub

    Public Function PivotData(ByVal RowField As String, ByVal DataField As String, ByVal Aggregate As AggregateFunction, ByVal ParamArray ColumnFields As String()) As DataTable
        Dim dt As New DataTable()
        Dim Separator As String = "."
        Dim RawRowList = (From x In _SourceTable.AsEnumerable() Select New With {.Name = x.Field(Of Object)(RowField).ToString()}).Distinct()
        Dim RowListParam As String() = (From s In RawRowList Select s.Name).ToArray()
        Dim RowList = GetDistinct(RowListParam)

        Dim RawColList = (From x In _SourceTable.AsEnumerable() _
                       Select New With {.Name = ColumnFields.Select(Function(n) x.Field(Of Object)(n).ToString()) _
                                                 .Aggregate(Function(a, b) (a & Separator & b.ToString()))}).Distinct() _
                                                 .OrderBy(Function(x) x.Name)

        Dim ColListParam As String() = (From s In RawColList Select s.Name).ToArray()
        Dim ColList = GetDistinct(ColListParam)

        dt.Columns.Add(RowField)
        For Each col In ColList
            If Not dt.Columns.Contains(col.ToString()) Then
                dt.Columns.Add(col.ToString())
            End If
        Next

        For Each RowName In RowList
            Dim row As DataRow = dt.NewRow()
            row(RowField) = RowName.ToString()
            For Each col In ColList
                Dim strFilter As String = (RowField & " = '") + Replace(RowName, "'", "''") & "'"
                Dim strColValues As String() = col.ToString().Split(Separator.ToCharArray(), StringSplitOptions.None)
                For i As Integer = 0 To (ColumnFields.Length - 1)
                    strFilter = strFilter & " and " & ColumnFields(i) & " = '" & Replace(strColValues(i), "'", "''") & "'"
                Next
                row(col.ToString()) = GetData(strFilter, DataField, Aggregate)
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

    Private Function GetDistinct(ByVal strList As String()) As String()
        Dim NewList As List(Of String) = New List(Of String)()
        For Each myStr In strList
            If Not NewList.Contains(myStr) Then
                NewList.Add(myStr)
            End If
        Next
        GetDistinct = NewList.ToArray()
    End Function

   
    Private Function GetData(ByVal Filter As String, ByVal DataField As String, ByVal Aggregate As AggregateFunction) As Object
        Try
            Dim FilteredRows As DataRow() = _SourceTable.[Select](Filter)
            Dim objList As Object() = FilteredRows.[Select](Function(x) x.Field(Of Object)(DataField)).ToArray()

            Select Case Aggregate
                Case AggregateFunction.Average
                    Return GetAverage(objList)
                Case AggregateFunction.Count
                    Return objList.Count()
                Case AggregateFunction.Exists
                    Return If((objList.Count() = 0), "False", "True")
                Case AggregateFunction.First
                    Return GetFirst(objList)
                Case AggregateFunction.Last
                    Return GetLast(objList)
                Case AggregateFunction.Max
                    Return GetMax(objList)
                Case AggregateFunction.Min
                    Return GetMin(objList)
                Case AggregateFunction.Sum
                    Return GetSum(objList)
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return "#Error"
        End Try

        Return Nothing
    End Function

    Private Function GetAverage(ByVal objList As Object()) As Object
        Return If(objList.Count() = 0, Nothing, DirectCast((Convert.ToDecimal(GetSum(objList)) / objList.Count()), Object))
    End Function

    Private Function GetSum(ByVal objList As Object()) As Object
        Return If(objList.Count() = 0, Nothing, DirectCast((objList.Aggregate(New Decimal(), Function(x, y) x + Convert.ToDecimal(y))), Object))
    End Function

    Private Function GetFirst(ByVal objList As Object()) As Object
        Return If((objList.Count() = 0), Nothing, objList.First())
    End Function

    Private Function GetLast(ByVal objList As Object()) As Object
        Return If((objList.Count() = 0), Nothing, objList.Last())
    End Function

    Private Function GetMax(ByVal objList As Object()) As Object
        Return If((objList.Count() = 0), Nothing, objList.Max())
    End Function

    Private Function GetMin(ByVal objList As Object()) As Object
        Return If((objList.Count() = 0), Nothing, objList.Min())
    End Function
End Class

Public Enum AggregateFunction
    Count = 1
    Sum = 2
    First = 3
    Last = 4
    Average = 5
    Max = 6
    Min = 7
    Exists = 8
End Enum