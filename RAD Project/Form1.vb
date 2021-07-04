Public Class Welcome
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Registration.Show()
        Me.Hide()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        PublicDetailShow.Show()
        Me.Hide()
    End Sub

    Private Sub lblwelcome_Click(sender As Object, e As EventArgs) Handles lblwelcome.Click

    End Sub
End Class
