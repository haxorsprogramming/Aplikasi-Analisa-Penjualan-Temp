Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Public Class Form_Transaksi

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bukadatabase()
        Awal()
        tampil_data()
        Dtp_tanggal.Format = DateTimePickerFormat.Custom
        Dtp_tanggal.CustomFormat = "dd MMMM yyyy"
    End Sub
    Sub tampil_data()
        'ListView1.Items.Clear()
        'SQL = "Select*From Tabel_transaksi"
        'Perintah = New OleDbCommand(SQL, Koneksi)
        'Pembaca = Perintah.ExecuteReader
        'Dim z As Integer
        'While Pembaca.Read
        '    ListView1.Items.Add(Pembaca("kode_transaksi"))
        '    ListView1.Items(z).SubItems.Add(Pembaca("tanggal_transaksi"))
        '    ListView1.Items(z).SubItems.Add(Pembaca("Kode_produk"))
        '    z = z + 1
        'End While
        'Pembaca.Close()
        SQL = "select DISTINCT (kode_transaksi) from Tabel_Transaksi"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim x As Integer
        While Pembaca.Read
            ListView1.Items.Add(Pembaca("kode_transaksi"))
            SQL2 = "select a.kode_produk,b.kode_produk, " & _
            "b.nama_produk  from Tabel_Transaksi as a,tabel_produk  as b " & _
            "where a.kode_produk=b.kode_produk and a.kode_transaksi='" & Pembaca("kode_transaksi") & "'"
            Perintah2 = New OleDbCommand(SQL2, Koneksi)
            Pembaca2 = Perintah2.ExecuteReader
            Dim barang As String
            barang = ""
            While Pembaca2.Read
                barang = barang & Pembaca2("nama_produk") & " " & ","
            End While
            ListView1.Items(x).SubItems.Add(barang)
            x = x + 1
        End While
    End Sub
    Sub Isi_Tabel()
        Lv.Items.Clear()
        'ListView3.Items.Clear()
        SQL = "Select*From Tabel_Produk"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim x As Integer
        While Pembaca.Read
            Lv.Items.Add(Pembaca("kode_produk"))
            Lv.Items(x).SubItems.Add(Pembaca("nama_produk"))
            x = x + 1
        End While
       
    End Sub
    Sub Awal()
        bersih(Me)
        Rubah_Tombol(True, False, False, False, True, False)
        tidak_aktif(Me)
        Button_Simpan.Text = "Simpan"
        Isi_Tabel()
        ListBox1.Visible = False
    End Sub
    Sub Rubah_Tombol(ByVal l0 As Boolean, ByVal l1 As Boolean, ByVal l2 As Boolean, ByVal l3 As Boolean, ByVal l4 As Boolean, ByVal l5 As Boolean)
        Button_Baru.Enabled = l0
        Button_Simpan.Enabled = l1
        Button_Batal.Enabled = l3
        Button_Keluar.Enabled = l4
        Button5.Enabled = l5
    End Sub

    Private Sub Button_Baru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baru.Click
        Button_Simpan.Text = "Simpan"
        Call bersih(Me)
        SQL = "select max(kode_transaksi) as xkode from tabel_transaksi "
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Try
            Pembaca.Read()
            TextBox_id.Text = Pembaca("xkode") + 1
        Catch ex As Exception
            TextBox_id.Text = 1
            TextBox_id.Enabled = True
        End Try
        Rubah_Tombol(False, True, False, True, True, True)
        Dtp_tanggal.Enabled = True

        TextBox_id.Enabled = True

    End Sub

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        cek(Me)
        If SQL = "kosong" Then
            MsgBox("Data belum lengkap!", MsgBoxStyle.Critical, "Periksa Kembali")
        Else
            If Button_Simpan.Text = "Simpan" Then
                For i = 0 To Lv.Items.Count - 1
                    If Lv.Items(i).Checked = True Then
                        SQL = "Insert Into tabel_transaksi values('" & _
                   TextBox_id.Text & "','" & _
                   Dtp_tanggal.Text & "','" & _
                     Lv.Items(i).Text & "')"
                        Perintah = New OleDbCommand(SQL, Koneksi)
                        Perintah.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Awal()
                ListView1.Items.Clear()
                tampil_data()
                'Else
                '    SQL = "delete from tabel_transaksi where kode_transaksi=" & TextBox_id.Text & ""
                '    Perintah = New OleDbCommand(SQL, Koneksi)
                '    Perintah.ExecuteNonQuery()
                '    For i = 0 To Lv.Items.Count - 1
                '        If Lv.Items(i).Checked = True Then
                '            SQL = "Insert Into tabel_transaksi values('" & _
                '       TextBox_id.Text & ",'" & _
                '       Dtp_tanggal.Value & "'," & _
                '         Lv.Items(i).Text & "')"
                '            Perintah = New OleDbCommand(SQL, Koneksi)
                '            Perintah.ExecuteNonQuery()
                '        End If

                '    Next
                '    MsgBox("Data Berhasil TerUpdate", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                '    Awal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SQL = "Delete from Tabel_transaksi where kode_transaksi='" & TextBox_id.Text & "'"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Dim pesan As MsgBoxResult
        pesan = MsgBox("Hapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
        If pesan = MsgBoxResult.Yes Then
            Perintah.ExecuteNonQuery()
            MsgBox("Data Berhasil Terhapus", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            Awal()
            ListView1.Items.Clear()
            tampil_data()
            SQL = "select DISTINCT kode_transaksi from tabel_transaksi"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            While Pembaca.Read
                ListBox1.Items.Add(Pembaca("kode_transaksi"))
            End While
        End If
        'Dim pesan As MsgBoxResult
        'pesan = MsgBox("Yakin mau hapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Informasi")
        'If pesan = MsgBoxResult.Yes Then
        '    SQL = "Delete from tabel_transaksi where kode_transaksi=" & TextBox_id.Text & ""
        '    Perintah = New OleDbCommand(SQL, Koneksi)
        '    Perintah.ExecuteNonQuery()
        '    MsgBox("Data Berhasil Terhapus", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        '    Awal()
        '    ListBox1.Items.Clear()
        '    SQL = "select DISTINCT kode_transaksi from tabel_transaksi"
        '    Perintah = New OleDbCommand(SQL, Koneksi)
        '    Pembaca = Perintah.ExecuteReader
        '    While Pembaca.Read
        '        ListBox1.Items.Add(Pembaca("kode_transaksi"))
        '    End While

        'End If
    End Sub

    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        Awal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.Visible = True Then
            ListBox1.Visible = False
        Else
            ListBox1.Visible = True
            ListBox1.Items.Clear()
            SQL = "select DISTINCT kode_transaksi from tabel_transaksi"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            While Pembaca.Read
                ListBox1.Items.Add(Pembaca("kode_transaksi"))
            End While
        End If
    End Sub
    Sub Cek_Data()
        SQL = "Select a.kode_produk,a.nama_produk from tabel_produk as a, tabel_transaksi as b " & _
        "where a.kode_produk=b.kode_produk and b.kode_transaksi=" & TextBox_id.Text & ""
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        If Pembaca.HasRows = True Then
            Button_Simpan.Text = "Edit"
            Rubah_Tombol(False, True, True, True, True, True)
            hilangcek()
            While Pembaca.Read
                Dim x As String
                x = Pembaca("kode_produk")
                For i = 0 To Lv.Items.Count - 1
                    If x = Lv.Items(i).Text Then
                        Lv.Items(i).Checked = True
                    End If
                Next
            End While
            Pembaca.Close()
        End If

    End Sub
    Sub hilangcek()
        For i = 0 To Lv.Items.Count - 1

            Lv.Items(i).Checked = False
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        TextBox_id.Text = ListBox1.SelectedItems(0).ToString
        Cek_Data()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListView1.Items.Clear()
        Try
            Using Koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("delete * from tabel_transaksi ", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                End Using
                Using Cmd As New OleDbCommand("delete * from tabel_transaksi2 ", Koneksi)
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

        LVImpor.Visible = True

        Try
            With OpenFileDialog1
                .Filter = "Excel Office|*.xls;*.xlsx"
                .FileName = ""
                .ShowDialog()
                strDestination = .FileName

            End With

            With LVImpor
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



                    For i = 0 To LVImpor.Items.Count - 1
                        Using koneksi As New OleDbConnection(Database)
                            Using Cmd As New OleDbCommand("insert into tabel_Transaksi values('" & _
                                                          LVImpor.Items(i).SubItems(0).Text & "','" & _
                                                          LVImpor.Items(i).SubItems(1).Text & "','" & _
                                                         LVImpor.Items(i).SubItems(2).Text & "')", koneksi)
                                koneksi.Open()
                                Cmd.CommandType = CommandType.Text
                                Cmd.ExecuteNonQuery()
                            End Using
                        End Using

                    Next
                    ' TextBox1.Clear()
                    MsgBox("Transaksi Berhasil di Simpan")

                    Call tampil_data()
                    'For j = 0 To LVImpor.Items.Count - 1
                    '    isi = ListView2.Items.Add(LVImpor.Items(j).SubItems(0).Text)
                    '    isi.SubItems.Add(LVImpor.Items(j).SubItems(1).Text)
                    '    isi.SubItems.Add(LVImpor.Items(j).SubItems(2).Text)
                    '    Dim k As String
                    '    SQL = "select nama_produk from tabel_produk where kode_produk='" & LVImpor.Items(j).SubItems(2).Text & "'"
                    '    Perintah = New OleDbCommand(SQL, Koneksi)
                    '    Pembaca = Perintah.ExecuteReader
                    '    Pembaca.Read()
                    '    k = Pembaca("nama_produk")
                    '    Pembaca.Close()
                    '    isi.SubItems.Add(k)

                    'Next
                    'For l = 0 To ListView2.Items.Count - 1
                    '    Using koneksi As New OleDbConnection(Database)
                    '        Using Cmd As New OleDbCommand("insert into tabel_Transaksi2 values('" & _
                    '                                      ListView2.Items(l).SubItems(0).Text & "','" & _
                    '                                       ListView2.Items(l).SubItems(1).Text & "','" & _
                    '                                       ListView2.Items(l).SubItems(2).Text & "','" & _
                    '                                      ListView2.Items(l).SubItems(3).Text & "')", koneksi)
                    '            koneksi.Open()
                    '            Cmd.CommandType = CommandType.Text
                    '            Cmd.ExecuteNonQuery()
                    '        End Using
                    '    End Using
                    'Next
                Else
                    MessageBox.Show("Silahkan Masukkan Data Yang Benar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        ' Button2.Enabled = True
    End Sub

End Class