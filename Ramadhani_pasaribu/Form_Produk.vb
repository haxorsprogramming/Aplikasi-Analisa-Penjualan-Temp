Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class Form_Produk

    Private Sub FormProduk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bukadatabase()
        awal()
    End Sub
    Sub awal()
        bersih(Me)
        Rubah_Tombol(True, False, False, False, True, False)
        tidak_aktif(Me)
        '        Button_ubah.Text = "Simpan"
        Isi_Tabel()
    End Sub
    Sub Rubah_Tombol(ByVal l0 As Boolean, ByVal l1 As Boolean, ByVal l2 As Boolean, ByVal l3 As Boolean, ByVal l4 As Boolean, ByVal l5 As Boolean)
        Button_Baru.Enabled = l0
        Button_ubah.Enabled = l1
        Button_Hapus.Enabled = l2
        Button_simpan.Enabled = l3
        Button_Keluar.Enabled = l4
        Button5.Enabled = l5
    End Sub
    Sub Isi_Tabel()
        Lv.Items.Clear()
        SQL = "Select*From Tabel_Produk "
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim x As Integer
        While Pembaca.Read
            Lv.Items.Add(Pembaca("kode_produk"))
            Lv.Items(x).SubItems.Add(Pembaca("nama_produk"))
            x = x + 1
        End While
        Pembaca.Close()
    End Sub

    Private Sub Button_Baru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baru.Click
        Call bersih(Me)
        Call Rubah_Tombol(False, True, True, True, True, True)
        Call aktif(Me)
        'TextBox_kode.Enabled = False
        'Textbox_nama.Focus()

    End Sub

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ubah.Click
        cek(Me)
        If SQL = "kosong" Then
            MsgBox("Data belum lengkap!", MsgBoxStyle.Critical, "Periksa Kembali")
        Else

            SQL = "Update Tabel_Produk set nama_produk ='" & Textbox_kunci.Text & _
                   "' where kode_produk='" & TextBox_id.Text & "'"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Rubah data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
            If pesan = MsgBoxResult.Yes Then
                Perintah.ExecuteNonQuery()
                MsgBox("Data Berhasil TerUpdate", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                awal()
            End If
        End If

    End Sub

    Private Sub Button_simpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_simpan.Click
        cek(Me)
        If SQL = "kosong" Then
            MsgBox("Data belum lengkap!", MsgBoxStyle.Critical, "Periksa Kembali")
        Else

            SQL = "Insert Into Tabel_Produk values('" & TextBox_id.Text & "','" & _
            Textbox_kunci.Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Dim pesan As MsgBoxResult
            pesan = MsgBox("Simpan data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
            If pesan = MsgBoxResult.Yes Then
                Perintah.ExecuteNonQuery()
                MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                awal()
            End If
        End If

    End Sub

    Private Sub Button_Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Hapus.Click
        SQL = "Delete from Tabel_Produk where kode_produk='" & TextBox_id.Text & "'"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Hapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
        If pesan = MsgBoxResult.Yes Then
            Perintah.ExecuteNonQuery()
            MsgBox("Data Berhasil Terhapus", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            awal()
        End If
    End Sub
    Sub Cek_Data()
        SQL = "Select*from Tabel_Produk where kode_produk='" & TextBox_id.Text & "'"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Try
            Pembaca.Read()
            Textbox_kunci.Text = Pembaca("nama_produk")
            ' MsgBox("Data Sudah Ada!")
            Button_Simpan.Text = "Edit"
            Rubah_Tombol(False, True, True, True, True, True)
        Catch ex As Exception
            MsgBox("Data Belum Ada, Silahkan isi datanya!")
            Rubah_Tombol(False, True, False, True, True, True)
        Finally
            aktif(Me)
            TextBox_id.Enabled = False
            Pembaca.Close()
        End Try
    End Sub

    Private Sub Button_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Keluar.Click
        Me.Close()

    End Sub

    Private Sub Lv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv.Click
        TextBox_id.Text = Lv.SelectedItems(0).SubItems(0).Text
        Cek_Data()
    End Sub

    Private Sub Lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Lv.Items.Clear()
        Try
            Using Koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("delete * from tabel_produk", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Dim xlApp As Excel.Application
        Dim xlWorkbook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range

        Dim xlCol As Integer
        Dim xlRow As Integer

        Dim strDestination As String
        Dim Data(0 To 100) As String

        Lv.Visible = True

        Try
            With OpenFileDialog1
                .Filter = "Excel Office|*.xls;*.xlsx"
                .FileName = ""
                .ShowDialog()
                strDestination = .FileName

            End With

            With Lv
                .View = View.Details
                .FullRowSelect = True
                .GridLines = True
                .Items.Clear()


                If strDestination <> "" Then


                    xlApp = New Excel.Application

                    xlWorkbook = xlApp.Workbooks.Open(strDestination)
                    xlWorkSheet = xlWorkbook.Worksheets("Sheet1") ' Nama Sheet di Excel yang datanya akan dimasukkan
                    xlRange = xlWorkSheet.UsedRange
                    If xlRange.Columns.Count > 0 Then
                        If xlRange.Rows.Count > 0 Then

                            For xlRow = 1 To xlRange.Rows.Count - 1

                                For xlCol = 1 To xlRange.Columns.Count

                                    Data(xlCol) = xlRange.Cells(xlRow + 1, xlCol).text

                                    If xlCol = 1 Then
                                        .Items.Add(Data(xlCol).ToString)
                                    Else
                                        .Items(xlRow - 1).SubItems.Add(Data(xlCol).ToString)
                                    End If

                                Next

                            Next
                            xlWorkbook.Close()
                            xlApp.Quit()

                        End If
                    End If

                    ' MsgBox("Proses Tampil Data Selesai")



                    For i = 0 To Lv.Items.Count - 1
                        Using koneksi As New OleDbConnection(Database)
                            Using Cmd As New OleDbCommand("insert into tabel_produk values('" & _
                                                          Lv.Items(i).SubItems(0).Text & "','" & _
                                                         Lv.Items(i).SubItems(1).Text & "')", koneksi)
                                koneksi.Open()
                                Cmd.CommandType = CommandType.Text
                                Cmd.ExecuteNonQuery()
                            End Using
                        End Using

                    Next
                    ' TextBox1.Clear()
                    MsgBox("Data Produk Berhasil di Simpan")
                    Lv.Items.Clear()
                    Call Isi_Tabel()

                Else
                    MessageBox.Show("Silahkan Masukkan Data Yang Benar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class