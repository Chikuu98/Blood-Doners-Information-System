Public Class PublicDetailShow
    Private Sub DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Donner_detailsDataSet)

    End Sub

    Private Sub PublicDetailShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Donner_detailsDataSet1.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter1.Fill(Me.Donner_detailsDataSet1.Details)
        'TODO: This line of code loads data into the 'Donner_detailsDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsDataGridView.Refresh()
        Me.DetailsBindingSource.DataSource = DetailsTableAdapter.GetData()
        Me.DetailsBindingSource.ResetBindings(False)
        Me.DetailsTableAdapter.Fill(Me.Donner_detailsDataSet.Details)

    End Sub

    Private Sub DetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub See_DonnersToolStripButton_Click(sender As Object, e As EventArgs) Handles See_DonnersToolStripButton.Click
        Try
            Me.DetailsTableAdapter1.See_Donners(Me.Donner_detailsDataSet1.Details, BloodTypeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
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