Imports System.Data.OleDb
Public Class Form_Proses

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bukadatabase()
        SQL = "Delete from tabel_itemset1"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Perintah.ExecuteNonQuery()
        SQL = "Delete from tabel_itemset1_1"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Perintah.ExecuteNonQuery()
        Awal()
    End Sub
    Sub Awal()
        Lv.Items.Clear()
        isitabel()
        ' isitabel2()
    End Sub
    Sub isitabel()
        SQL = "select DISTINCT (kode_transaksi) from Tabel_Transaksi"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim x As Integer
        While Pembaca.Read
            Lv.Items.Add(Pembaca("kode_transaksi"))
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
            Lv.Items(x).SubItems.Add(barang)
            x = x + 1
        End While
        SQL = "select * from tabel_produk"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim x1 As Integer
        Dim a As Double
        Dim b As Integer
        While Pembaca.Read
            lv1.Items.Add(Pembaca("kode_produk"))
            lv1.Items(x1).SubItems.Add(Pembaca("nama_produk"))
            SQL2 = "select count(kode_transaksi)  as jumlah from tabel_transaksi where kode_produk='" & Pembaca("kode_produk") & "'"
            Perintah2 = New OleDbCommand(SQL2, Koneksi)
            Pembaca2 = Perintah2.ExecuteReader
            Pembaca2.Read()
            lv1.Items(x1).SubItems.Add(Pembaca2("jumlah"))
            b = (Lv.Items.Count - 1) + 1
            a = FormatNumber((Pembaca2("jumlah") / b) * 100, 2)
            lv1.Items(x1).SubItems.Add(a)
            Pembaca2.Close()
            x1 = x1 + 1
        End While
        Pembaca.Close()
    End Sub
    Sub isitabel2()
        'SQL = "select * from tabel_produk"
        'Perintah = New OleDbCommand(SQL, Koneksi)
        'Pembaca = Perintah.ExecuteReader
        'Dim x As Integer
        'Dim a As Double
        'Dim b As Integer
        'While Pembaca.Read
        '    lv1.Items.Add(Pembaca("kode_produk"))
        '    lv1.Items(x).SubItems.Add(Pembaca("nama_produk"))
        '    SQL2 = "select count(kode_transaksi)  as jumlah from tabel_transaksi where kode_produk='" & Pembaca("kode_produk") & "'"
        '    Perintah2 = New OleDbCommand(SQL2, Koneksi)
        '    Pembaca2 = Perintah2.ExecuteReader
        '    Pembaca2.Read()
        '    lv1.Items(x).SubItems.Add(Pembaca2("jumlah"))
        '    b = (Lv.Items.Count - 1) + 1
        '    a = FormatNumber((Pembaca2("jumlah") / b) * 100, 2)
        '    lv1.Items(x).SubItems.Add(a)
        '    Pembaca2.Close()
        '    x = x + 1
        'End While
        For i = 0 To lv1.Items.Count - 1
            isi = ListView1.Items.Add(lv1.Items(i).SubItems(0).Text)
            isi.SubItems.Add(lv1.Items(i).SubItems(1).Text)
            isi.SubItems.Add(lv1.Items(i).SubItems(2).Text)
            isi.SubItems.Add("")
            If lv1.Items(i).SubItems(3).Text < Val(ComboBox_support.Text) Then
                ListView1.Items(i).SubItems(3).Text = 0
            Else
                ListView1.Items(i).SubItems(3).Text = 1
            End If

            SQL = "Insert Into tabel_itemset1 values('" & _
                    ListView1.Items(i).SubItems(0).Text & "','" & _
                  ListView1.Items(i).SubItems(1).Text & "','" & _
                  ListView1.Items(i).SubItems(2).Text & "','" & _
                     ListView1.Items(i).SubItems(3).Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
        Next
        ListView1.Items.Clear()
        SQL = "select * from tabel_itemset1 order by nilai2 desc"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim z As Integer
        While Pembaca.Read
            ListView1.Items.Add(Pembaca("kode_produk"))
            ListView1.Items(z).SubItems.Add(Pembaca("nama_produk"))
            ListView1.Items(z).SubItems.Add(Pembaca("nilai1"))
            ListView1.Items(z).SubItems.Add(Pembaca("nilai2"))
            Pembaca2.Close()
            z = z + 1
        End While


        SQL = "select * from tabel_itemset1 where nilai2 like '%" & TextBox1.Text & "%'"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim y As Integer = 0
        ListView1.Items.Clear()
        While Pembaca.Read
            ListView1.Items.Add(Pembaca("kode_produk"))
            ListView1.Items(y).SubItems.Add(Pembaca("nama_produk"))
            ListView1.Items(y).SubItems.Add(Pembaca("nilai1"))
            ListView1.Items(y).SubItems.Add(Pembaca("nilai2"))
            Pembaca2.Close()
            y = y + 1
        End While
        For j = 0 To ListView1.Items.Count - 1
            SQL = "Insert Into tabel_itemset1_1 values('" & _
                                ListView1.Items(j).SubItems(0).Text & "','" & _
                                 ListView1.Items(j).SubItems(1).Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        isitabel2()
        FrmKonfirmasi.Show()
        'Form_Hasil.Show()
        'Me.Hide()
        For i = 0 To lv1.Items.Count - 1
            SQL = "Insert Into frekuensi values('" & _
                 lv1.Items(i).SubItems(0).Text & "','" & _
               lv1.Items(i).SubItems(1).Text & "','" & _
               lv1.Items(i).SubItems(2).Text & "','" & _
                  lv1.Items(i).SubItems(3).Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
        Next
    End Sub
End Class
