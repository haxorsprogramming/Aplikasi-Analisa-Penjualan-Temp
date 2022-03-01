<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Produk
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
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.Textbox_kunci = New System.Windows.Forms.TextBox()
        Me.Lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button_Keluar = New System.Windows.Forms.Button()
        Me.Button_Baru = New System.Windows.Forms.Button()
        Me.Button_ubah = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_simpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'TextBox_id
        '
        Me.TextBox_id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_id.Location = New System.Drawing.Point(215, 67)
        Me.TextBox_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(152, 31)
        Me.TextBox_id.TabIndex = 87
        '
        'Textbox_kunci
        '
        Me.Textbox_kunci.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_kunci.Location = New System.Drawing.Point(215, 112)
        Me.Textbox_kunci.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Textbox_kunci.Name = "Textbox_kunci"
        Me.Textbox_kunci.Size = New System.Drawing.Size(376, 31)
        Me.Textbox_kunci.TabIndex = 88
        '
        'Lv
        '
        Me.Lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Lv.FullRowSelect = True
        Me.Lv.GridLines = True
        Me.Lv.Location = New System.Drawing.Point(18, 168)
        Me.Lv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Lv.Name = "Lv"
        Me.Lv.Size = New System.Drawing.Size(787, 333)
        Me.Lv.TabIndex = 86
        Me.Lv.UseCompatibleStateImageBehavior = False
        Me.Lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Kode Produk"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Produk"
        Me.ColumnHeader3.Width = 276
        '
        'Button_Keluar
        '
        Me.Button_Keluar.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Keluar.ForeColor = System.Drawing.Color.White
        Me.Button_Keluar.Location = New System.Drawing.Point(432, 526)
        Me.Button_Keluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Keluar.Name = "Button_Keluar"
        Me.Button_Keluar.Size = New System.Drawing.Size(112, 60)
        Me.Button_Keluar.TabIndex = 85
        Me.Button_Keluar.Text = "Keluar"
        Me.Button_Keluar.UseVisualStyleBackColor = False
        '
        'Button_Baru
        '
        Me.Button_Baru.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Baru.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Baru.ForeColor = System.Drawing.Color.White
        Me.Button_Baru.Location = New System.Drawing.Point(378, 60)
        Me.Button_Baru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Baru.Name = "Button_Baru"
        Me.Button_Baru.Size = New System.Drawing.Size(112, 45)
        Me.Button_Baru.TabIndex = 81
        Me.Button_Baru.Text = "Baru"
        Me.Button_Baru.UseVisualStyleBackColor = False
        '
        'Button_ubah
        '
        Me.Button_ubah.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_ubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ubah.ForeColor = System.Drawing.Color.White
        Me.Button_ubah.Location = New System.Drawing.Point(186, 526)
        Me.Button_ubah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_ubah.Name = "Button_ubah"
        Me.Button_ubah.Size = New System.Drawing.Size(112, 60)
        Me.Button_ubah.TabIndex = 82
        Me.Button_ubah.Text = "Ubah"
        Me.Button_ubah.UseVisualStyleBackColor = False
        '
        'Button_Hapus
        '
        Me.Button_Hapus.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Hapus.ForeColor = System.Drawing.Color.White
        Me.Button_Hapus.Location = New System.Drawing.Point(306, 526)
        Me.Button_Hapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(112, 60)
        Me.Button_Hapus.TabIndex = 83
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = False
        '
        'Button_simpan
        '
        Me.Button_simpan.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_simpan.ForeColor = System.Drawing.Color.White
        Me.Button_simpan.Location = New System.Drawing.Point(1106, 282)
        Me.Button_simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_simpan.Name = "Button_simpan"
        Me.Button_simpan.Size = New System.Drawing.Size(112, 60)
        Me.Button_simpan.TabIndex = 84
        Me.Button_simpan.Text = "Simpan"
        Me.Button_simpan.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 25)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Nama Produk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Kode Produk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(64, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(731, 34)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "DATA PRODUK ALAT DAN BAHAN BANGUNAN"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LimeGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(23, 526)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 60)
        Me.Button5.TabIndex = 128
        Me.Button5.Text = "Import Data"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form_Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(834, 611)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.Textbox_kunci)
        Me.Controls.Add(Me.Lv)
        Me.Controls.Add(Me.Button_Keluar)
        Me.Controls.Add(Me.Button_Baru)
        Me.Controls.Add(Me.Button_ubah)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_simpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_id As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_kunci As System.Windows.Forms.TextBox
    Friend WithEvents Lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button_Keluar As System.Windows.Forms.Button
    Friend WithEvents Button_Baru As System.Windows.Forms.Button
    Friend WithEvents Button_ubah As System.Windows.Forms.Button
    Friend WithEvents Button_Hapus As System.Windows.Forms.Button
    Friend WithEvents Button_simpan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
