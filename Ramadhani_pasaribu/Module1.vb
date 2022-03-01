Imports System.Data.OleDb
Module Module1
    Public Koneksi As OleDbConnection
    Public Perintah, Perintah1, Perintah2, Perintah3 As OleDbCommand
    Public Pembaca, Pembaca1, Pembaca2, Pembaca3 As OleDbDataReader
    Public SQL, SQL1, SQL2, SQL3 As String
    Public Database As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Database2.mdb;"

    Public AlamatDatabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
     Application.StartupPath & "\Database2.mdb;"
    Public isi As ListViewItem
    Sub Bukadatabase()
        Koneksi = New OleDbConnection(AlamatDatabase)
        If Koneksi.State <> ConnectionState.Closed Then Koneksi.Close()
        Try
            Koneksi.Open()
            'MsgBox("Database berhasil terkoneksi")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Database gagal terkoneksi")
        End Try
    End Sub
    Sub bersih(ByVal f As Form)
        On Error Resume Next
        Dim x As Object
        For Each x In f.Controls
            If TypeOf x Is TextBox Then x.text = ""
            If TypeOf x Is ComboBox Then x.text = ""
            If TypeOf x Is DateTimePicker Then x.text = ""
        Next
    End Sub
    Sub tidak_aktif(ByVal f As Form)
        Dim x As Object
        For Each x In f.Controls
            If TypeOf x Is TextBox Then x.enabled = False
            If TypeOf x Is ComboBox Then x.enabled = False
            If TypeOf x Is DateTimePicker Then x.enabled = False
        Next
    End Sub

    Sub aktif(ByVal f As Form)
        Dim x As Object
        For Each x In f.Controls
            If TypeOf x Is TextBox Then x.enabled = True
            If TypeOf x Is ComboBox Then x.enabled = True
            If TypeOf x Is DateTimePicker Then x.enabled = True
        Next
    End Sub
    Sub cek(ByVal f As Form)
        Dim x As Object
        For Each x In f.Controls
            If TypeOf x Is TextBox Then
                If x.text = "" Then
                    SQL = "kosong"
                Else
                    SQL = ""
                End If
            End If
            If TypeOf x Is ComboBox Then
                If x.text = "" Then
                    SQL = "kosong"
                Else
                    SQL = ""
                End If
            End If
        Next
    End Sub
End Module
