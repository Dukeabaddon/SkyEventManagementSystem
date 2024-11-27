Public Class Users
    Private Sub btnEvents2_Click(sender As Object, e As EventArgs) Handles btnEvents2.Click
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub btnRegisterEvent_Click(sender As Object, e As EventArgs) Handles btnRegisterEvent.Click
        TabControl2.SelectedIndex = 1
    End Sub

    Private Sub btnLogOut2_Click(sender As Object, e As EventArgs) Handles btnLogOut2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class