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
        For Each rw As DataGridViewRow In DataGridView1.Rows
            If Not rw.Cells(0).Value = "" Then
                Cmd = New SqlCommand("INSERT INTO PERMINTAAN_PEMBELIAN_DETIL (NO_BUKTI, NO_URUT, NAMA_BARANG, NAMA_BARANG_2, NAMA_BARANG_3, NAMA_BARANG_4, NAMA_BARANG_5, NAMA_BARANG_6, NAMA_BARANG_7, NAMA_BARANG_8, NAMA_BARANG_9, NAMA_BARANG_10, JUMLAH, SATUAN, KETERANGAN_1, KETERANGAN_2, KETERANGAN_3, KETERANGAN_4, KETERANGAN_5, KETERANGAN_6, KETERANGAN_7, KETERANGAN_8, KETERANGAN_9, KETERANGAN_10) VALUES('" & TbNoBukti.Text & "','" & rw.Cells(0).Value & "','" & rw.Cells(1).Value & "','" & rw.Cells(2).Value & "','" & rw.Cells(3).Value & "','" & rw.Cells(4).Value & "','" & rw.Cells(5).Value & "','" & rw.Cells(6).Value & "','" & rw.Cells(7).Value & "','" & rw.Cells(8).Value & "','" & rw.Cells(9).Value & "','" & rw.Cells(10).Value & "'," & CDec(rw.Cells(11).Value) & ",'" & rw.Cells(12).Value & "','" & rw.Cells(13).Value & "','" & rw.Cells(14).Value & "','" & rw.Cells(15).Value & "','" & rw.Cells(16).Value & "','" & rw.Cells(17).Value & "','" & rw.Cells(18).Value & "','" & rw.Cells(19).Value & "','" & rw.Cells(20).Value & "','" & rw.Cells(21).Value & "','" & rw.Cells(22).Value & "')", Conn)
                Cmd.ExecuteNonQuery()
            End If
        Next
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
End Class
