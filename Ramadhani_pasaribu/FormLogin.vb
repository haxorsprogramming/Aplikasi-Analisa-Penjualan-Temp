Imports System.Data.OleDb
Public Class FormLogin
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bukadatabase()
    End Sub
   
    Private Sub TextBox_username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_username.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TextBox_username.Text <> "" Then
                TextBox_password.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TextBox_password.Text <> "" Then
                Button_login.Focus()
            End If
        End If
    End Sub

    

    
    Private Sub Button_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_login.Click
        SQL = "Select * from tabel_login where username='" & TextBox_username.Text & "' and password='" & TextBox_password.Text & "'"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Pembaca.Read()
        If Pembaca.HasRows = True Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Login")

            Form_Utama.Show()

            Me.Hide()
        Else
            MsgBox("Maaf username atau password anda salah!")
            TextBox_username.Clear()
            TextBox_password.Clear()
            TextBox_username.Focus()
        End If
    End Sub

   

    Private Sub Button_Batal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        End
    End Sub
End Class
