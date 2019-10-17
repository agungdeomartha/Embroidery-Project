Imports System.Data.Sql
Imports System.Data.SqlClient
Module Module_Koneksi
    Public Conn As SqlConnection
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Da As SqlDataAdapter
    Public Cmd As SqlCommand
    Public Dt As DataTable
    Public sql As String

    Public Sub koneksi_master()

        sql = "Data Source=Computer_Server3,1433;Network Library=DBMSSOCN;Initial Catalog=D:\LKMBENANGEMBROMISDATA\DATAMASTER.MDF;User ID=sa;Password=ilyvm;"
        Conn = New SqlConnection(sql)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub koneksi_transaksi()

        sql = "Data Source=Computer_Server3,1433;Network Library=DBMSSOCN;Initial Catalog=D:\LKMBENANGEMBROMISDATA\TRANSAKSI.MDF;User ID=sa;Password=ilyvm;"
        Conn = New SqlConnection(sql)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
