Public Class PublicDetailShow
    Private Sub DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Donner_detailsDataSet)

    End Sub

    Private Sub PublicDetailShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Donner_detailsDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsDataGridView.Refresh()
        Me.DetailsBindingSource.DataSource = DetailsTableAdapter.GetData()
        Me.DetailsBindingSource.ResetBindings(False)
        Me.DetailsTableAdapter.Fill(Me.Donner_detailsDataSet.Details)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Welcome.Show()
        Me.Hide()
    End Sub





    Private Sub DetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetailsDataGridView.CellContentClick

    End Sub

    Private Sub SeeResultToolStripButton_Click(sender As Object, e As EventArgs) Handles SeeResultToolStripButton.Click
        Try
            Me.DetailsTableAdapter.SeeResult(Me.Donner_detailsDataSet.Details, BloodTypeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class