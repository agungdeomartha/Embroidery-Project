﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TbNoBukti = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TbKodeAkun = New System.Windows.Forms.TextBox
        Me.TbNamaAkun = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TbKeterangan = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NoUrut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaBarang10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonSimpan = New System.Windows.Forms.Button
        Me.ButtonBatal = New System.Windows.Forms.Button
        Me.ButtonTambah = New System.Windows.Forms.Button
        Me.ButtonUbah = New System.Windows.Forms.Button
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonKeluar = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.KodeAkun = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaAkun = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Bukti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'TbNoBukti
        '
        Me.TbNoBukti.Location = New System.Drawing.Point(114, 42)
        Me.TbNoBukti.Name = "TbNoBukti"
        Me.TbNoBukti.Size = New System.Drawing.Size(145, 20)
        Me.TbNoBukti.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(114, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(996, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Akun Mutasi"
        '
        'TbKodeAkun
        '
        Me.TbKodeAkun.Location = New System.Drawing.Point(1068, 44)
        Me.TbKodeAkun.Name = "TbKodeAkun"
        Me.TbKodeAkun.Size = New System.Drawing.Size(85, 20)
        Me.TbKodeAkun.TabIndex = 5
        '
        'TbNamaAkun
        '
        Me.TbNamaAkun.Location = New System.Drawing.Point(1159, 44)
        Me.TbNamaAkun.Name = "TbNamaAkun"
        Me.TbNamaAkun.Size = New System.Drawing.Size(195, 20)
        Me.TbNamaAkun.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(996, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Keterangan"
        '
        'TbKeterangan
        '
        Me.TbKeterangan.Location = New System.Drawing.Point(1068, 70)
        Me.TbKeterangan.Name = "TbKeterangan"
        Me.TbKeterangan.Size = New System.Drawing.Size(286, 20)
        Me.TbKeterangan.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoUrut, Me.NamaBarang1, Me.NamaBarang2, Me.NamaBarang3, Me.NamaBarang4, Me.NamaBarang5, Me.NamaBarang6, Me.NamaBarang7, Me.NamaBarang8, Me.NamaBarang9, Me.NamaBarang10, Me.Jumlah, Me.Satuan, Me.Keterangan1, Me.Keterangan2, Me.Keterangan3, Me.Keterangan4, Me.Keterangan5, Me.Keterangan6, Me.Keterangan7, Me.Keterangan8, Me.Keterangan9, Me.Keterangan10})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1052, 354)
        Me.DataGridView1.TabIndex = 9
        '
        'NoUrut
        '
        Me.NoUrut.HeaderText = "No. Urut"
        Me.NoUrut.Name = "NoUrut"
        '
        'NamaBarang1
        '
        Me.NamaBarang1.HeaderText = "Nama Barang 1"
        Me.NamaBarang1.Name = "NamaBarang1"
        '
        'NamaBarang2
        '
        Me.NamaBarang2.HeaderText = "Nama Barang 2"
        Me.NamaBarang2.Name = "NamaBarang2"
        '
        'NamaBarang3
        '
        Me.NamaBarang3.HeaderText = "Nama Barang 3"
        Me.NamaBarang3.Name = "NamaBarang3"
        '
        'NamaBarang4
        '
        Me.NamaBarang4.HeaderText = "Nama Barang 4"
        Me.NamaBarang4.Name = "NamaBarang4"
        '
        'NamaBarang5
        '
        Me.NamaBarang5.HeaderText = "Nama Barang 5"
        Me.NamaBarang5.Name = "NamaBarang5"
        '
        'NamaBarang6
        '
        Me.NamaBarang6.HeaderText = "Nama Barang 6"
        Me.NamaBarang6.Name = "NamaBarang6"
        '
        'NamaBarang7
        '
        Me.NamaBarang7.HeaderText = "Nama Barang 7"
        Me.NamaBarang7.Name = "NamaBarang7"
        '
        'NamaBarang8
        '
        Me.NamaBarang8.HeaderText = "Nama Barang 8"
        Me.NamaBarang8.Name = "NamaBarang8"
        '
        'NamaBarang9
        '
        Me.NamaBarang9.HeaderText = "Nama Barang 9"
        Me.NamaBarang9.Name = "NamaBarang9"
        '
        'NamaBarang10
        '
        Me.NamaBarang10.HeaderText = "Nama Barang 10"
        Me.NamaBarang10.Name = "NamaBarang10"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'Satuan
        '
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.Name = "Satuan"
        '
        'Keterangan1
        '
        Me.Keterangan1.HeaderText = "Keterangan1"
        Me.Keterangan1.Name = "Keterangan1"
        '
        'Keterangan2
        '
        Me.Keterangan2.HeaderText = "Keterangan 2"
        Me.Keterangan2.Name = "Keterangan2"
        '
        'Keterangan3
        '
        Me.Keterangan3.HeaderText = "Keterangan 3"
        Me.Keterangan3.Name = "Keterangan3"
        '
        'Keterangan4
        '
        Me.Keterangan4.HeaderText = "Keterangan 4"
        Me.Keterangan4.Name = "Keterangan4"
        '
        'Keterangan5
        '
        Me.Keterangan5.HeaderText = "Keterangan 5"
        Me.Keterangan5.Name = "Keterangan5"
        '
        'Keterangan6
        '
        Me.Keterangan6.HeaderText = "Keterangan6"
        Me.Keterangan6.Name = "Keterangan6"
        '
        'Keterangan7
        '
        Me.Keterangan7.HeaderText = "Keterangan 7"
        Me.Keterangan7.Name = "Keterangan7"
        '
        'Keterangan8
        '
        Me.Keterangan8.HeaderText = "Keterangan 8"
        Me.Keterangan8.Name = "Keterangan8"
        '
        'Keterangan9
        '
        Me.Keterangan9.HeaderText = "Keterangan 9"
        Me.Keterangan9.Name = "Keterangan9"
        '
        'Keterangan10
        '
        Me.Keterangan10.HeaderText = "Keterangan 10"
        Me.Keterangan10.Name = "Keterangan10"
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(578, 481)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(71, 33)
        Me.ButtonSimpan.TabIndex = 10
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(655, 481)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(71, 33)
        Me.ButtonBatal.TabIndex = 11
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(28, 618)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(66, 33)
        Me.ButtonTambah.TabIndex = 12
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(100, 618)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(66, 33)
        Me.ButtonUbah.TabIndex = 13
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(172, 618)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(66, 33)
        Me.ButtonHapus.TabIndex = 14
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(1279, 618)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(66, 33)
        Me.ButtonKeluar.TabIndex = 15
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeAkun, Me.NamaAkun})
        Me.DataGridView2.Location = New System.Drawing.Point(1089, 121)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(265, 354)
        Me.DataGridView2.TabIndex = 16
        '
        'KodeAkun
        '
        Me.KodeAkun.HeaderText = "Kode Akun"
        Me.KodeAkun.Name = "KodeAkun"
        '
        'NamaAkun
        '
        Me.NamaAkun.HeaderText = "Nama Akun"
        Me.NamaAkun.Name = "NamaAkun"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1366, 669)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TbKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbNamaAkun)
        Me.Controls.Add(Me.TbKodeAkun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TbNoBukti)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbNoBukti As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbKodeAkun As System.Windows.Forms.TextBox
    Friend WithEvents TbNamaAkun As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents NoUrut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents KodeAkun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAkun As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
