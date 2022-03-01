Public Class FrmKonfirmasi

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form_Hasil.Show()
            Me.Close()
            'FrmLogin.Close()
        End If
        Label2.Text = FormatPercent((ProgressBar1.Value / 100), 0)
    End Sub

    Private Sub FrmKonfirmasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class