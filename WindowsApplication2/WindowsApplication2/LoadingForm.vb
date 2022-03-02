Public Class LoadingForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        PBLoading.Value += 1
        If PBLoading.Value > 10 Then
            labelStatus.Text = "Generating witty dialog..."
        End If
        If PBLoading.Value > 35 Then
            labelStatus.Text = "Swapping time and space..."
        End If
        If PBLoading.Value > 65 Then
            labelStatus.Text = "Definitely not a virus..."
        End If
        If PBLoading.Value > 95 Then
            labelStatus.Text = "Launching Application."
        End If
        If PBLoading.Value = 100 Then
            labelStatus.Text = "Launching Application."
            LoginForm.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub
End Class