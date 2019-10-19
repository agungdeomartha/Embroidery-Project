Imports System.Data.SqlClient
Public Class FormCari
    Public Sub New()
        ' required by form designer
        InitializeComponent()
        ' refresh grid data

    End Sub
    Private Sub RefreshGrid()
        Call koneksi_master()
        Call koneksi_transaksi()
        ' siapkan koneksi database
        ' siapkan data adapter untuk data retrieval
        Da = New SqlDataAdapter("SELECT  B.NO_BUKTI, B.TANGGAL,A.NAMA_AKUN, B.KETERANGAN " & _
                                     "FROM [D:\LKMBENANGEMBROMISDATA\DATAMASTER.MDF].[dbo].[AKUN] A JOIN [D:\LKMBENANGEMBROMISDATA\TRANSAKSI.MDF].[dbo].[PERMINTAAN_PEMBELIAN] B ON A.KODE_AKUN=B.KODE_AKUN_MUTASI " & _
                                     "WHERE B.TANGGAL BETWEEN @d1 AND @d2 ", Conn)

        Da.SelectCommand.Parameters.AddWithValue("@d1", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
        Da.SelectCommand.Parameters.AddWithValue("@d2", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
        ' siapkan datatable untuk menampung data dari database
        Dt = New DataTable
        ' enclose di dalam try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            Da.Fill(Dt)
            ' bind data ke combobox
            DataGridView1.DataSource = Dt
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' refresh grid data
        RefreshGrid()
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Clipboard.SetText(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        Me.Close()
    End Sub
End Class