Public Class kayıtol
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "insert into kullanici(adi,sifre,yetki) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        komut1.ExecuteNonQuery()
        baglanti1.Close()
        MsgBox("Veriler Başarıyla Kaydedildi")


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class