Public Class Form_Utama


    
    Private Sub DATAPRODUKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAPRODUKToolStripMenuItem.Click
        Form_Produk.Show()
    End Sub

    Private Sub DATATRANSAKSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATATRANSAKSIToolStripMenuItem.Click
        Form_Transaksi.Show()
    End Sub

    Private Sub PERHITUNGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PERHITUNGANToolStripMenuItem.Click
        Form_Proses.Show()
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub Form_Utama_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class