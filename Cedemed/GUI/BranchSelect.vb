Public Class BranchSelect
    Private Sub BranchSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            My.Settings.Item("CedemedConnectionString") = My.Settings.MainBranch
        ElseIf ComboBox1.SelectedIndex = 1 Then
            My.Settings.Item("CedemedConnectionString") = My.Settings.Branch1
        ElseIf ComboBox1.SelectedIndex = 2 Then
            My.Settings.Item("CedemedConnectionString") = My.Settings.Branch2
        ElseIf ComboBox1.SelectedIndex = 3 Then
            My.Settings.Item("CedemedConnectionString") = My.Settings.Branch3
        ElseIf ComboBox1.SelectedIndex = 4 Then
            My.Settings.Item("CedemedConnectionString") = My.Settings.Branch4
        ElseIf ComboBox1.SelectedIndex = 5 Then
            My.Settings.Item("CedemedConnectionString") = My.Settings.Branch5
        End If
        Me.DialogResult = DialogResult.OK
    End Sub


End Class