Public Class AdminLogin
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtUserName.Text = "Admin" And txtPassword.Text = "12345" Then
            Welcome.Show()
            Me.Hide()
        Else
            MsgBox("Invalid UserName or Password ? Try Again..!")
        End If
    End Sub
End Class