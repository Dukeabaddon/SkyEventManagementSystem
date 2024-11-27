Public Class ManageEvent
    Private Sub Eventsbtn_Click(sender As Object, e As EventArgs) Handles Eventsbtn.Click
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub btnManageEvents2_Click(sender As Object, e As EventArgs) Handles btnManageEvents2.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnLogOut2_Click(sender As Object, e As EventArgs) Handles btnLogOut2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class