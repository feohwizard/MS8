Imports System.Data.SqlClient
Public Class Posting
    Public transno As Integer
    Public loader As Boolean
    Dim conn As New SqlConnection(My.Settings.CedemedConnectionString)
    Dim com As New SqlCommand
    Dim dbset As New DataSet
    Dim adap As New SqlDataAdapter
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        adap = New SqlDataAdapter("Select status,error,remarks from Process where TransNo=" + transno.ToString, conn)
        dbset = New DataSet
        adap.Fill(dbset, "a")
        With dbset.Tables("a").DefaultView.Item(0)
            If .Item(0) = True And .Item(1) = False Then
                'Continue
                Dim frm As New RecieptPrintForm
                frm.transno = transno
                frm.Show()
                Timer1.Enabled = False
                Me.Close()
            Else
                If .Item(0) = False And .Item(1) = False Then
                    'Not yet prcessed
                ElseIf .Item(0) = True And .Item(1) = True Then
                    Me.Timer1.Enabled = False
                    MsgBox("This transaction has been removed due to: " + .Item(2).ToString)
                    Me.Close()
                End If
            End If
        End With

    End Sub

    Private Sub Posting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If loader = True Then
        Else
            Timer1.Enabled = True
        End If

    End Sub
End Class