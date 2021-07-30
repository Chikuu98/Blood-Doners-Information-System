Imports System.Data
Imports System.Data.SqlClient
Public Class Registration


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-IA4SIGM;Initial Catalog=Donner_details;Integrated Security=True")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("insert into Details(First_Name,Last_Name,Age,Contact_no,Blood_Group,How_Many_Times) values('" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtAge.Text & "','" & txtContact.Text & "','" & ComboBloodG.Text & "','" & txtHowManyTimes.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Data is inserted")
        con.Close()
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub ComboBloodG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBloodG.SelectedIndexChanged

    End Sub
    Private Sub ComboBloodG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBloodG.KeyPress
        e.Handled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAge.Clear()
        txtContact.Clear()
        txtHowManyTimes.Clear()
        ComboBloodG.SelectedIndex = -1
    End Sub

    Private Sub lblBloodGroup_Click(sender As Object, e As EventArgs) Handles lblBloodGroup.Click

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
End Class