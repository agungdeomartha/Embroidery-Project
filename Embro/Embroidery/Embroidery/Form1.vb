Imports System.Data.SqlClient
Public Class Form1
    Sub KosongkanData()
        TbNoBukti.Text = ""
        DateTimePicker1.Text = ""
        TbNamaAkun.Text = ""
        TbKodeAkun.Text = ""
        TbKeterangan.Text = ""
    End Sub
    Public Sub New()
        ' required by form designer
        InitializeComponent()
    End Sub
    Sub KondisiAwal()
        'Call buka2()

        'Da = New SqlDataAdapter("Select * from dbo.PERMINTAAN_PEMBELIAN_DETIL", Conn)
        'Da = New SqlDataAdapter("Select * from PEMBELIAN", Conn)
        'Ds = New DataSet
        'Ds.Clear()
        'Da.Fill(Ds, "dbo.PERMINTAAN_PEMBELIAN_DETIL")
        'DataGridView1.DataSource = (Ds.Tables("dbo.PERMINTAAN_PEMBELIAN_DETIL"))

        'TextBox1.MaxLength = 17
        'TextBox2.MaxLength = 50
        'TextBox3.MaxLength = 100
        'TextBox4.MaxLength = 20

        'kondisi awal button
        ButtonTambah.Enabled = True
        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = False

        'kondisi awal textbox
        TbNoBukti.Enabled = False
        DateTimePicker1.Enabled = False
        TbKodeAkun.Enabled = False
        TbNamaAkun.Enabled = False
        TbKeterangan.Enabled = False
        ButtonSimpan.Text = "Simpan"

        'hide button cari dan ok
        BtnCari.Visible = False
        BtnOK.Visible = False

    End Sub
    Sub SiapTambah()
        'rubah status button
        ButtonTambah.Enabled = False
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True

        'rubah status textbox
        TbNoBukti.Enabled = True
        DateTimePicker1.Enabled = True
        TbKodeAkun.Enabled = True
        TbNamaAkun.Enabled = True
        TbKeterangan.Enabled = True
    End Sub
    Sub SiapUbah()
        'rubah status button
        ButtonTambah.Enabled = False
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True

        'rubah status textbox
        TbNoBukti.Enabled = True
        DateTimePicker1.Enabled = True
        TbKodeAkun.Enabled = True
        TbNamaAkun.Enabled = True
        TbKeterangan.Enabled = True

        ButtonSimpan.Text = "Ubah"

        'Tampilkan btn cari dan OK
        BtnCari.Visible = True
        BtnOK.Visible = True
    End Sub
    Sub SiapHapus()
        'rubah status button
        ButtonTambah.Enabled = False
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True

        'rubah status textbox
        TbNoBukti.Enabled = True
        DateTimePicker1.Enabled = True
        TbKodeAkun.Enabled = True
        TbNamaAkun.Enabled = True
        TbKeterangan.Enabled = True
        ButtonSimpan.Text = "Hapus"
        'Tampilkan btn cari dan OK
        BtnCari.Visible = True
        BtnOK.Visible = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Me.KeyPreview = True
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Call SiapTambah()
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Call SiapUbah()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Call SiapHapus()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Call KondisiAwal()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call koneksi_transaksi()
        Cmd = New SqlCommand("Select * from PERMINTAAN_PEMBELIAN_DETIL where NO_BUKTI in (select max(NO_BUKTI) from PERMINTAAN_PEMBELIAN_DETIL)", Conn)
        Dim urutan As String
        Dim hitung As Long
        Dim MyDateTime As DateTime = Now()
        Dim MyString As String
        Dim MyString2 As String
        MyString = MyDateTime.ToString("yyyy/MM/")
        MyString2 = MyDateTime.ToString("yyyy-MM-dd hh:mm:ss")
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            urutan = "EBL" + MyString + "000001"

            For Each rw As DataGridViewRow In DataGridView1.Rows
                If Not rw.Cells(0).Value = "" Then
                    Cmd = New SqlCommand("INSERT INTO PERMINTAAN_PEMBELIAN_DETIL (NO_BUKTI, NO_URUT, NAMA_BARANG, NAMA_BARANG_2, NAMA_BARANG_3, NAMA_BARANG_4, NAMA_BARANG_5, NAMA_BARANG_6, NAMA_BARANG_7, NAMA_BARANG_8, NAMA_BARANG_9, NAMA_BARANG_10, JUMLAH, SATUAN, KETERANGAN_1, KETERANGAN_2, KETERANGAN_3, KETERANGAN_4, KETERANGAN_5, KETERANGAN_6, KETERANGAN_7, KETERANGAN_8, KETERANGAN_9, KETERANGAN_10) VALUES('" & urutan & "','" & rw.Cells(0).Value & "','" & rw.Cells(1).Value & "','" & rw.Cells(2).Value & "','" & rw.Cells(3).Value & "','" & rw.Cells(4).Value & "','" & rw.Cells(5).Value & "','" & rw.Cells(6).Value & "','" & rw.Cells(7).Value & "','" & rw.Cells(8).Value & "','" & rw.Cells(9).Value & "','" & rw.Cells(10).Value & "'," & CDec(rw.Cells(11).Value) & ",'" & rw.Cells(12).Value & "','" & rw.Cells(13).Value & "','" & rw.Cells(14).Value & "','" & rw.Cells(15).Value & "','" & rw.Cells(16).Value & "','" & rw.Cells(17).Value & "','" & rw.Cells(18).Value & "','" & rw.Cells(19).Value & "','" & rw.Cells(20).Value & "','" & rw.Cells(21).Value & "','" & rw.Cells(22).Value & "')", Conn)
                    Cmd.ExecuteNonQuery()
                End If
            Next
            MsgBox("Data Berhasil Diinput")
        Else

            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "EBL" + MyString + Microsoft.VisualBasic.Right("000000" & hitung, 6)

            For Each rw As DataGridViewRow In DataGridView1.Rows
                If Not rw.Cells(0).Value = "" Then
                    Cmd = New SqlCommand("INSERT INTO PERMINTAAN_PEMBELIAN_DETIL (NO_BUKTI, NO_URUT, NAMA_BARANG, NAMA_BARANG_2, NAMA_BARANG_3, NAMA_BARANG_4, NAMA_BARANG_5, NAMA_BARANG_6, NAMA_BARANG_7, NAMA_BARANG_8, NAMA_BARANG_9, NAMA_BARANG_10, JUMLAH, SATUAN, KETERANGAN_1, KETERANGAN_2, KETERANGAN_3, KETERANGAN_4, KETERANGAN_5, KETERANGAN_6, KETERANGAN_7, KETERANGAN_8, KETERANGAN_9, KETERANGAN_10) VALUES('" & urutan & "','" & rw.Cells(0).Value & "','" & rw.Cells(1).Value & "','" & rw.Cells(2).Value & "','" & rw.Cells(3).Value & "','" & rw.Cells(4).Value & "','" & rw.Cells(5).Value & "','" & rw.Cells(6).Value & "','" & rw.Cells(7).Value & "','" & rw.Cells(8).Value & "','" & rw.Cells(9).Value & "','" & rw.Cells(10).Value & "'," & CDec(rw.Cells(11).Value) & ",'" & rw.Cells(12).Value & "','" & rw.Cells(13).Value & "','" & rw.Cells(14).Value & "','" & rw.Cells(15).Value & "','" & rw.Cells(16).Value & "','" & rw.Cells(17).Value & "','" & rw.Cells(18).Value & "','" & rw.Cells(19).Value & "','" & rw.Cells(20).Value & "','" & rw.Cells(21).Value & "','" & rw.Cells(22).Value & "')", Conn)
                    Rd.Close()
                    Cmd.ExecuteNonQuery()
                End If
                
            Next
            Cmd = New SqlCommand("INSERT INTO PERMINTAAN_PEMBELIAN (NO_BUKTI, TANGGAL, KODE_AKUN_MUTASI, KETERANGAN,TGLTAMBAH) VALUES('" & urutan & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & TbKodeAkun.Text & "','" & TbKeterangan.Text & "','" & MyString2 & "')", Conn)
            Rd.Close()
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput")
        End If
        Conn.Close()
        'Cmd = New SqlCommand("INSERT INTO PERMINTAAN_PEMBELIAN VALUES('" & TbNoBukti.Text & "','" & rw.Cells(0).Value & "','" & rw.Cells(1).Value & "','" & rw.Cells(2).Value & "','" & rw.Cells(3).Value & "','" & rw.Cells(4).Value & "','" & rw.Cells(5).Value & "','" & rw.Cells(6).Value & "','" & rw.Cells(7).Value & "','" & rw.Cells(8).Value & "','" & rw.Cells(9).Value & "','" & rw.Cells(10).Value & "'," & CDec(rw.Cells(11).Value) & ",'" & rw.Cells(12).Value & "','" & rw.Cells(13).Value & "','" & rw.Cells(14).Value & "','" & rw.Cells(15).Value & "','" & rw.Cells(16).Value & "','" & rw.Cells(17).Value & "','" & rw.Cells(18).Value & "','" & rw.Cells(19).Value & "','" & rw.Cells(20).Value & "','" & rw.Cells(21).Value & "','" & rw.Cells(22).Value & "')", Conn)
        'Cmd.Execu teNonQuery()
        DataGridView1.Rows.Clear()
        Call KondisiAwal()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'jika ke-4 button dibawah ini aktif
        If ButtonUbah.Enabled = False Or ButtonTambah.Enabled = False Or ButtonHapus.Enabled = False Then
            'maka shorcut delete akan aktif
            Select Case e.KeyCode
                Case Keys.Insert
                    Form2.Show()
               
            End Select
        End If
    End Sub

    Private Sub TbKodeAkun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKodeAkun.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi_master()
            ' siapkan koneksi database
            ' siapkan data adapter untuk data retrieval
            Da = New SqlDataAdapter("SELECT * From AKUN WHERE KODE_AKUN LIKE  '" & TbKodeAkun.Text & "%'", Conn)
            ' siapkan datatable untuk menampung data dari database
            Dt = New DataTable
            ' enclose di dalam try-catch block
            ' untuk menghindari crash jika terjadi kesalahan database
            Try
                'Hide kolom 1 dan 2
                Me.DataGridView2.Columns("KodeAkun").Visible = False
                Me.DataGridView2.Columns("NamaAkun").Visible = False
                ' ambil data dari database
                Da.Fill(Dt)
                ' bind data ke combobox
                DataGridView2.DataSource = Dt
                ' DONE!!!
            Catch ex As Exception
                ' tampilkan pesan error
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    
    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            'Cells 0 and 1 is Hidden
            TbKodeAkun.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            TbNamaAkun.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub
End Class
