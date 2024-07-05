Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.Text <> "" Then
            Call kaydet()

        Else
            MsgBox("Eksik bilgi girdiniz!")
        End If
    End Sub
    Private Sub kaydet()
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\users.mdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "insert into anatablo (ad,soyad,fakulte,bolum) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox3.Text + "')"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        komut1.ExecuteNonQuery()
        baglanti1.Close()
        MsgBox("Veriler Başarıyla Kaydedildi")
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

End Class