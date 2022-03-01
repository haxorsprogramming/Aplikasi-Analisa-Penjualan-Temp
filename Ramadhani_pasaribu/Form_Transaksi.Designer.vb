<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFILE = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button_Keluar = New System.Windows.Forms.Button()
        Me.Button_Baru = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Batal = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.Lv = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LVImpor = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1238, 61)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 60)
        Me.Button3.TabIndex = 123
        Me.Button3.Text = "Import"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFILE
        '
        Me.OpenFILE.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 573)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 60)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Kode Produk"
        Me.ColumnHeader2.Width = 76
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(650, 45)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(178, 104)
        Me.ListBox1.TabIndex = 121
        '
        'Button_Keluar
        '
        Me.Button_Keluar.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Keluar.Location = New System.Drawing.Point(450, 573)
        Me.Button_Keluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Keluar.Name = "Button_Keluar"
        Me.Button_Keluar.Size = New System.Drawing.Size(112, 60)
        Me.Button_Keluar.TabIndex = 115
        Me.Button_Keluar.Text = "Keluar"
        Me.Button_Keluar.UseVisualStyleBackColor = False
        '
        'Button_Baru
        '
        Me.Button_Baru.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Baru.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Baru.Location = New System.Drawing.Point(520, 78)
        Me.Button_Baru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Baru.Name = "Button_Baru"
        Me.Button_Baru.Size = New System.Drawing.Size(112, 60)
        Me.Button_Baru.TabIndex = 112
        Me.Button_Baru.Text = "Baru"
        Me.Button_Baru.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Tanggal Transaksi"
        '
        'Button_Batal
        '
        Me.Button_Batal.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Batal.Location = New System.Drawing.Point(330, 573)
        Me.Button_Batal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Batal.Name = "Button_Batal"
        Me.Button_Batal.Size = New System.Drawing.Size(112, 60)
        Me.Button_Batal.TabIndex = 114
        Me.Button_Batal.Text = "Batal"
        Me.Button_Batal.UseVisualStyleBackColor = False
        '
        'Button_Simpan
        '
        Me.Button_Simpan.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Simpan.Location = New System.Drawing.Point(1209, 466)
        Me.Button_Simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(112, 60)
        Me.Button_Simpan.TabIndex = 113
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Produk"
        Me.ColumnHeader3.Width = 276
        '
        'Dtp_tanggal
        '
        Me.Dtp_tanggal.Location = New System.Drawing.Point(249, 112)
        Me.Dtp_tanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_tanggal.Name = "Dtp_tanggal"
        Me.Dtp_tanggal.Size = New System.Drawing.Size(263, 26)
        Me.Dtp_tanggal.TabIndex = 118
        Me.Dtp_tanggal.UseWaitCursor = True
        Me.Dtp_tanggal.Value = New Date(2021, 8, 28, 0, 0, 0, 0)
        '
        'TextBox_id
        '
        Me.TextBox_id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_id.Location = New System.Drawing.Point(249, 60)
        Me.TextBox_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(152, 31)
        Me.TextBox_id.TabIndex = 117
        '
        'Lv
        '
        Me.Lv.CheckBoxes = True
        Me.Lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Lv.GridLines = True
        Me.Lv.Location = New System.Drawing.Point(1209, 159)
        Me.Lv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Lv.Name = "Lv"
        Me.Lv.Size = New System.Drawing.Size(141, 104)
        Me.Lv.TabIndex = 116
        Me.Lv.UseCompatibleStateImageBehavior = False
        Me.Lv.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Kode Transaksi"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(824, 25)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "DATA TRANSAKSI PENJUALAN ALAT DAN BAHAN BANGUNAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Location = New System.Drawing.Point(413, 59)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 120
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(22, 159)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(806, 404)
        Me.ListView1.TabIndex = 126
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Kode Transaksi"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Transaksi"
        Me.ColumnHeader6.Width = 600
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LimeGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(22, 573)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 60)
        Me.Button5.TabIndex = 127
        Me.Button5.Text = "Import Data"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'LVImpor
        '
        Me.LVImpor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader9})
        Me.LVImpor.GridLines = True
        Me.LVImpor.Location = New System.Drawing.Point(1209, 301)
        Me.LVImpor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LVImpor.Name = "LVImpor"
        Me.LVImpor.Size = New System.Drawing.Size(130, 104)
        Me.LVImpor.TabIndex = 128
        Me.LVImpor.UseCompatibleStateImageBehavior = False
        Me.LVImpor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "id_transaksi"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Tanggal"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "id produk"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 120
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(1127, 28)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(71, 83)
        Me.ListView2.TabIndex = 129
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id_transaksi"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "id_produk"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "nama_produk"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "tanggal"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "nama produk"
        Me.ColumnHeader9.Width = 100
        '
        'Form_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(855, 679)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.LVImpor)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button_Keluar)
        Me.Controls.Add(Me.Button_Baru)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Batal)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dtp_tanggal)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.Lv)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form_Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFILE As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button_Keluar As System.Windows.Forms.Button
    Friend WithEvents Button_Baru As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button_Batal As System.Windows.Forms.Button
    Friend WithEvents Button_Simpan As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dtp_tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox_id As System.Windows.Forms.TextBox
    Friend WithEvents Lv As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LVImpor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
