Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim row As New DataGridViewRow()
        row.Cells.AddRange(New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell(), New DataGridViewTextBoxCell())
        row.Cells(0).Value = TbNoUrut.Text
        row.Cells(1).Value = TbNamaBarang1.Text
        row.Cells(2).Value = TbNamaBarang2.Text
        row.Cells(3).Value = TbNamaBarang3.Text
        row.Cells(4).Value = TbNamaBarang4.Text
        row.Cells(5).Value = TbNamaBarang5.Text
        row.Cells(6).Value = TbNamaBarang6.Text
        row.Cells(7).Value = TbNamaBarang7.Text
        row.Cells(8).Value = TbNamaBarang8.Text
        row.Cells(9).Value = TbNamaBarang9.Text
        row.Cells(10).Value = TbNamaBarang10.Text
        row.Cells(11).Value = TbJumlah.Text
        row.Cells(12).Value = TbSatuan.Text
        row.Cells(13).Value = TbKeterangan1.Text
        row.Cells(14).Value = TbKeterangan2.Text
        row.Cells(15).Value = TbKeterangan3.Text
        row.Cells(16).Value = TbKeterangan4.Text
        row.Cells(17).Value = TbKeterangan5.Text
        row.Cells(18).Value = TbKeterangan6.Text
        row.Cells(19).Value = TbKeterangan7.Text
        row.Cells(20).Value = TbKeterangan8.Text
        row.Cells(21).Value = TbKeterangan9.Text
        row.Cells(22).Value = TbKeterangan10.Text
        Form1.DataGridView1.Rows.Add(row)
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TbNoUrut.Enabled = False
        Form1.Show()
        Dim max As Integer
        For i As Integer = 0 To Form1.DataGridView1.Rows.Count() - 1 Step 1
            If i = 0 Then
                max = Form1.DataGridView1.Rows(i).Cells(0).Value + 1
            End If
            If max < Form1.DataGridView1.Rows(i).Cells(0).Value + 1 Then
                max = Form1.DataGridView1.Rows(i).Cells(0).Value + 1
            End If
        Next
        TbNoUrut.Text = max.ToString().PadLeft(3, "0"c)
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbKeterangan6.TextChanged

    End Sub
    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class