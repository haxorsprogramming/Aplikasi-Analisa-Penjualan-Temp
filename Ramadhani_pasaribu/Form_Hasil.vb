Imports System.Data.OleDb
Public Class Form_Hasil

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bukadatabase()
        SQL = "Delete from tabel_itemset2"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Perintah.ExecuteNonQuery()
        SQL = "Delete from tabel_itemset2_1"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Perintah.ExecuteNonQuery()
        SQL = "Delete from hasil"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Perintah.ExecuteNonQuery()
        TextBox2.Text = Form_Proses.ComboBox_support.Text
        TextBox3.Text = Form_Proses.ComboBox1.Text
        isitabel()
    End Sub
    'Sub isisupport()
    '    For i = 100 To 0 Step -5
    '        ComboBox_support.Items.Add(i)

    '    Next
    'End Sub
    Sub isitabel()
        SQL = "select count(kode_produk)as jumlah from tabel_itemset1_1"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Pembaca.Read()
        Dim jumlah As String
        jumlah = Pembaca("jumlah")
        Pembaca.Close()

        SQL = "select*from tabel_itemset1_1 "
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim x, n As Integer
        n = 0
        Dim top As Integer
        top = 2
        While Pembaca.Read
            x = 0
            jumlah = jumlah - 1
            Dim top2 As Integer
            top2 = top
            For i = x To jumlah - 1

                SQL2 = "select top " & top2 & " kode_produk,nama_produk from tabel_itemset1_1 "
                Perintah2 = New OleDbCommand(SQL2, Koneksi)
                Pembaca2 = Perintah2.ExecuteReader
                Dim id2, nama2 As String
                id2 = "'"
                nama2 = "'"

                While Pembaca2.Read
                    id2 = Pembaca2("kode_produk")
                    nama2 = Pembaca2("nama_produk")
                End While
                Pembaca2.Close()

                lv2.Items.Add(n + 1)
                lv2.Items(n).SubItems.Add(Pembaca("nama_produk") & "," & nama2)
                lv2.Items(n).SubItems.Add(Pembaca("kode_produk"))
                lv2.Items(n).SubItems.Add(id2)
                lv2.Items(n).SubItems.Add("")
                lv2.Items(n).SubItems.Add("")
                lv2.Items(n).SubItems.Add("")
                lv2.Items(n).SubItems.Add("")

                x += 1
                n += 1
                top2 += 1
            Next
            top = top + 1
        End While
        Pembaca.Close()

        For i = 0 To lv2.Items.Count - 1
            lv2.Items.Add(n + 1)
            Dim sql As String


            sql = "select nama_produk from tabel_itemset1_1 where kode_produk='" & lv2.Items(i).SubItems(3).Text & "'"
            Perintah = New OleDbCommand(sql, Koneksi)
            Pembaca = Perintah.ExecuteReader
            Pembaca.Read()
            Dim k1, k2 As String
            k1 = Pembaca("nama_produk")
            Pembaca.Close()
            sql = "select nama_produk from tabel_itemset1_1 where kode_produk='" & lv2.Items(i).SubItems(2).Text & "'"
            Perintah = New OleDbCommand(sql, Koneksi)
            Pembaca = Perintah.ExecuteReader
            Pembaca.Read()
            k2 = Pembaca("nama_produk")
            Pembaca.Close()
            lv2.Items(n).SubItems.Add(k1 & ", " & k2)
            lv2.Items(n).SubItems.Add(lv2.Items(i).SubItems(3).Text)
            lv2.Items(n).SubItems.Add(lv2.Items(i).SubItems(2).Text)
            lv2.Items(n).SubItems.Add("")
            lv2.Items(n).SubItems.Add("")
            lv2.Items(n).SubItems.Add("")
            lv2.Items(n).SubItems.Add("")
            n += 1
        Next


        For i = 0 To lv2.Items.Count - 1
            Dim k As Integer
            k = 0
            SQL = "select kode_transaksi from Tabel_Transaksi where kode_produk='" & lv2.Items(i).SubItems(2).Text & "'"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            While Pembaca.Read
                SQL2 = "select count(kode_produk) as j from Tabel_Transaksi where kode_transaksi='" & Pembaca("kode_transaksi") & "' and kode_produk='" & lv2.Items(i).SubItems(3).Text & "'"
                Perintah2 = New OleDbCommand(SQL2, Koneksi)
                Pembaca2 = Perintah2.ExecuteReader
                Pembaca2.Read()
                If Pembaca2("j") = 1 Then
                    k += 1
                End If
                Pembaca2.Close()
            End While
            Pembaca.Close()

            lv2.Items(i).SubItems(4).Text = k
            SQL = "select distinct(kode_transaksi) as jtransaksi from Tabel_Transaksi"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            Dim hitung As Integer
            hitung = 0
            While Pembaca.Read
                hitung += 1
            End While
            Pembaca.Close()

            lv2.Items(i).SubItems(5).Text = FormatNumber((k / hitung) * 100, 2)

            SQL = "select count(kode_produk)as jumlah2 from Tabel_Transaksi where kode_produk='" & lv2.Items(i).SubItems(2).Text & "'"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            Pembaca.Read()

            lv2.Items(i).SubItems(6).Text = FormatNumber(k / Pembaca("jumlah2"), 4) * 100
            lv2.Items(i).SubItems(7).Text = FormatNumber(k / Pembaca("jumlah2"), 4) * 100 & "%"

        Next
        For i = 0 To lv2.Items.Count - 1
            isi = ListView1.Items.Add(lv2.Items(i).SubItems(0).Text)
            isi.SubItems.Add(lv2.Items(i).SubItems(1).Text)
            isi.SubItems.Add(lv2.Items(i).SubItems(2).Text)
            isi.SubItems.Add(lv2.Items(i).SubItems(3).Text)
            isi.SubItems.Add(lv2.Items(i).SubItems(4).Text)
            isi.SubItems.Add(lv2.Items(i).SubItems(5).Text)
            isi.SubItems.Add(lv2.Items(i).SubItems(6).Text)
            isi.SubItems.Add("")
            If lv2.Items(i).SubItems(5).Text < Val(TextBox2.Text) Then
                ListView1.Items(i).SubItems(7).Text = 0
            ElseIf lv2.Items(i).SubItems(6).Text < Val(TextBox3.Text) Then
                ListView1.Items(i).SubItems(7).Text = 0
            Else
                ListView1.Items(i).SubItems(7).Text = 1
            End If
          

            SQL = "Insert Into tabel_itemset2 values('" & _
                  ListView1.Items(i).SubItems(0).Text & "','" & _
                ListView1.Items(i).SubItems(1).Text & "','" & _
                ListView1.Items(i).SubItems(2).Text & "','" & _
                 ListView1.Items(i).SubItems(3).Text & "','" & _
                 ListView1.Items(i).SubItems(4).Text & "','" & _
                 ListView1.Items(i).SubItems(5).Text & "','" & _
                 ListView1.Items(i).SubItems(6).Text & "','" & _
                   ListView1.Items(i).SubItems(7).Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
        Next
        ListView1.Items.Clear()
        SQL = "select * from tabel_itemset2"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim z As Integer
        While Pembaca.Read
            ListView1.Items.Add(Pembaca("no"))
            ListView1.Items(z).SubItems.Add(Pembaca("pola"))
            ListView1.Items(z).SubItems.Add(Pembaca("id1"))
            ListView1.Items(z).SubItems.Add(Pembaca("id2"))
            ListView1.Items(z).SubItems.Add(Pembaca("qty"))
            ListView1.Items(z).SubItems.Add(Pembaca("support"))
            ListView1.Items(z).SubItems.Add(Pembaca("confidence"))
            ListView1.Items(z).SubItems.Add(Pembaca("nilai"))
            Pembaca2.Close()
            z = z + 1
        End While
        SQL = "select * from tabel_itemset2 where nilai like '%" & TextBox1.Text & "%'"
        Perintah = New OleDbCommand(SQL, Koneksi)
        Pembaca = Perintah.ExecuteReader
        Dim y As Integer
        While Pembaca.Read
            ListView2.Items.Add(Pembaca("no"))
            ListView2.Items(y).SubItems.Add(Pembaca("pola"))
            ListView2.Items(y).SubItems.Add(Pembaca("id1"))
            ListView2.Items(y).SubItems.Add(Pembaca("id2"))
            ListView2.Items(y).SubItems.Add(Pembaca("qty"))
            ListView2.Items(y).SubItems.Add(Pembaca("support"))
            ListView2.Items(y).SubItems.Add(Pembaca("confidence"))
            Pembaca2.Close()
            y = y + 1
        End While
        For j = 0 To ListView2.Items.Count - 1
            SQL = "Insert Into tabel_itemset2_1 values('" & _
                                ListView2.Items(j).SubItems(0).Text & "','" & _
                                ListView2.Items(j).SubItems(1).Text & "','" & _
                                ListView2.Items(j).SubItems(2).Text & "','" & _
                                 ListView2.Items(j).SubItems(3).Text & "','" & _
                                ListView2.Items(j).SubItems(4).Text & "','" & _
                                ListView2.Items(j).SubItems(5).Text & "','" & _
                                 ListView2.Items(j).SubItems(6).Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
        Next
        kesimpulan()
        MsgBox("Proses Perhitungan Selesai", MsgBoxStyle.Critical, "Perhitungan")
        Form_Proses.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox(" Support dan COnfidence Belum Dipilih")
            SQL = "Delete from tabel_itemset1"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
            SQL = "Delete from tabel_itemset1_1"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
            Form_Proses.Show()
            Me.Close()
        Else
            isitabel()
            'If ComboBox_support.Text <> "" Then
            '    lv3.Items.Clear()

            '    SQL = "delete * from tabel_apriori"
            '    Perintah = New OleDbCommand(SQL, Koneksi)
            '    Perintah.ExecuteNonQuery()
            '    For i = 0 To lv2.Items.Count - 1

            '        If Val(lv2.Items(i).SubItems(7).Text) >= ComboBox_support.Text And (lv2.Items(i).SubItems(5).Text) >= ComboBox_support.Text And (lv2.Items(i).SubItems(4).Text) >= 4 Then

            '            Dim support, confidence, persen, sXc As Single

            '            support = CDbl(lv2.Items(i).SubItems(5).Text)
            '            confidence = CDbl(lv2.Items(i).SubItems(6).Text)
            '            persen = Val(lv2.Items(i).SubItems(7).Text)
            '            sXc = (support * confidence)
            '            SQL = "Insert Into tabel_apriori (kode,pola,qty,support,confident,persen,supportxconfident) values('" & _
            '            lv2.Items(i).SubItems(0).Text & "','" & _
            '            lv2.Items(i).SubItems(1).Text & "','" & _
            '             lv2.Items(i).SubItems(4).Text & "','" & _
            '             support & "','" & _
            '             confidence & "','" & _
            '             persen & "','" & _
            '             sXc & "')"

            '            Perintah = New OleDbCommand(SQL, Koneksi)
            '            Perintah.ExecuteNonQuery()

            '        End If
            '    Next

            '    SQL = "select*from tabel_apriori order by persen desc"
            '    Perintah = New OleDbCommand(SQL, Koneksi)
            '    Pembaca = Perintah.ExecuteReader
            '    Dim x As Integer
            '    While Pembaca.Read
            '        lv3.Items.Add(x + 1)
            '        lv3.Items(x).SubItems.Add(Pembaca("pola"))
            '        lv3.Items(x).SubItems.Add(Pembaca("qty"))
            '        lv3.Items(x).SubItems.Add(Pembaca("support"))
            '        lv3.Items(x).SubItems.Add(Pembaca("confident"))
            '        lv3.Items(x).SubItems.Add(Pembaca("persen"))
            '        lv3.Items(x).SubItems.Add(Pembaca("supportxconfident"))
            '        x += 1

            '    End While
            'End If
        End If
    End Sub

    Sub kesimpulan()
        For i = 0 To ListView2.Items.Count - 1
            
            SQL = "select nama_produk from tabel_produk where kode_produk='" & ListView2.Items(i).SubItems(2).Text & "'"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            Pembaca.Read()
            Dim p1, p2 As String
            p1 = Pembaca("nama_produk")
            Pembaca.Close()
            SQL = "select nama_produk from tabel_produk where kode_produk='" & ListView2.Items(i).SubItems(3).Text & "'"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Pembaca = Perintah.ExecuteReader
            Pembaca.Read()
            p2 = Pembaca("nama_produk")
            Pembaca.Close()
            isi = ListView3.Items.Add(i + 1)
            isi.SubItems.Add("Jika Pelanggan membeli Produk" & " " & p1 & " " & "maka Pelanggan juga membeli" & " " & p2)
            isi.SubItems.Add(ListView2.Items(i).SubItems(5).Text)
            isi.SubItems.Add(ListView2.Items(i).SubItems(6).Text)
        Next
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For i = 0 To ListView3.Items.Count - 1
            SQL = "Insert Into hasil values('" & _
                 ListView3.Items(i).SubItems(0).Text & "','" & _
               ListView3.Items(i).SubItems(1).Text & "','" & _
               ListView3.Items(i).SubItems(2).Text & "','" & _
                  ListView3.Items(i).SubItems(3).Text & "')"
            Perintah = New OleDbCommand(SQL, Koneksi)
            Perintah.ExecuteNonQuery()
        Next
        MsgBox("Hasil Perhitungan Berhasil Disimpan", MsgBoxStyle.Critical, "hasil Perhitungan")
    End Sub
End Class