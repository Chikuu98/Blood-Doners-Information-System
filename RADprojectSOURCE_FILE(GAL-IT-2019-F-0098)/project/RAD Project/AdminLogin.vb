Public Class AdminLogin

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtUserName.Text = "Admin" And txtPassword.Text = "12345" Then
            DonnerDetails.Show()
            Me.Hide()
        Else
            MsgBox("Invalid UserName or Password ? Try Again..!")
        End If
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub InformatinsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformatinsToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
End Class