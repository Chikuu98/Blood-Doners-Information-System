Public Class FrmLoading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblReportProgress.Text = PBLoading1.Value & "%"

        PBLoading1.Value += 1

        If PBLoading1.Value > 10 Then
            lblStatusText.Text = "Loading.... Please wait"
        End If
        If PBLoading1.Value > 35 Then
            lblStatusText.Text = "Blood donners information System"
        End If
        If PBLoading1.Value > 65 Then
            lblStatusText.Text = "100% of our donners are voluntory,"
        End If
        If PBLoading1.Value > 75 Then
            lblStatusText.Text = "and non remunerated donors."
        End If
        If PBLoading1.Value > 95 Then
            lblStatusText.Text = "Thanks..."
        End If
        If PBLoading1.Value = 100 Then
            lblStatusText.Text = "Launching Application"
            Welcome.Show()
            Me.Hide()
            Timer1.Dispose()

        End If
    End Sub
End Class