Public Class DonnerDetails
    Private Sub DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Donner_detailsDataSet)

    End Sub

    Private Sub DonnerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Donner_detailsDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.Donner_detailsDataSet.Details)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim i As Integer = DetailsDataGridView.CurrentRow.Index
        Dim columnValue As String = DetailsDataGridView.Item(0, i).Value

        Dim m_fname = First_NameTextBox.Text
        Dim m_lname = Last_NameTextBox.Text
        Dim m_age = AgeTextBox.Text
        Dim m_contact = Contact_NoTextBox.Text
        Dim m_bgroup = Blood_GroupTextBox.Text
        Dim m_times = How_Many_TimesTextBox.Text

        Me.DetailsTableAdapter.InsertQuery(m_fname, m_lname, m_age, m_contact, m_bgroup, m_times)

        Me.DetailsDataGridView.Refresh()
        Me.DetailsBindingSource.DataSource = DetailsTableAdapter.GetData()
        Me.DetailsBindingSource.ResetBindings(False)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim i As Integer = DetailsDataGridView.CurrentRow.Index
        Dim columnValue As String = DetailsDataGridView.Item(0, i).Value

        DetailsDataGridView.CurrentCell = DetailsDataGridView.Rows(i).Cells(0)

        Try
            DetailsTableAdapter.UpdateQuery(First_NameTextBox.Text, Last_NameTextBox.Text, AgeTextBox.Text, Contact_NoTextBox.Text, Blood_GroupTextBox.Text, How_Many_TimesTextBox.Text)
            MsgBox("Update Successfull")

        Catch ex As Exception
            MsgBox("Update Failed")
        End Try

        Me.DetailsDataGridView.Refresh()
        Me.DetailsBindingSource.DataSource = DetailsTableAdapter.GetData()
        Me.DetailsBindingSource.ResetBindings(False)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = DetailsDataGridView.CurrentRow.Index
        Dim columnValue As String = DetailsDataGridView.Item(0, i).Value

        DetailsTableAdapter.DeleteQuery(columnValue)
        MsgBox("Row Successfully Deleted")
        Me.DetailsDataGridView.Refresh()
        Me.DetailsBindingSource.DataSource = DetailsTableAdapter.GetData()
        Me.DetailsBindingSource.ResetBindings(False)


    End Sub

    Private Sub Blood_GroupTextBox_TextChanged(sender As Object, e As EventArgs) Handles Blood_GroupTextBox.TextChanged

    End Sub

    Private Sub BackToLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToLoginToolStripMenuItem.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub InformationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationsToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
End Class