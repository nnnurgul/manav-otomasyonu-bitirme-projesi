Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.Text <> "" Then
            Call kaydet()
            yukle()

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
        sql1 = "insert into kullanici (adi,sifre,yetki) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        komut1.ExecuteNonQuery()
        baglanti1.Close()
        MsgBox("Veriler Başarıyla Kaydedildi")
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""

    End Sub
    Private Sub yukle()
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\users.mdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "select adi from kullanici"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        Dim veri_okuyucu As Data.OleDb.OleDbDataReader
        veri_okuyucu = komut1.ExecuteReader
        ListBox1.Items.Clear()
        While (veri_okuyucu.Read())
            ListBox1.Items.Add(veri_okuyucu("adi"))
        End While
        baglanti1.Close()

    End Sub
    Private Sub listele()
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\users.mdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "select * from kullanici where adi = '" & ListBox1.Text & "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        Dim veri_okuyucu As Data.OleDb.OleDbDataReader
        veri_okuyucu = komut1.ExecuteReader

        While (veri_okuyucu.Read())
            TextBox1.Text = veri_okuyucu("adi")
            TextBox2.Text = veri_okuyucu("sifre")
            ComboBox1.Text = veri_okuyucu("yetki")
        End While
        baglanti1.Close()
    End Sub
    Private Sub guncelle()
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\users.mdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = " Update kullanici set adi='" & TextBox1.Text & "', sifre='" & TextBox2.Text & "',yetki = '" & ComboBox1.Text & " ' where adi = '" & TextBox1.Text & "'"
        Dim komut As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        Dim unused = komut.ExecuteNonQuery()
        MsgBox("Bilgiler Veritabanında Güncellenmiştir.")
        baglanti1.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yukle()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        listele()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        guncelle()

        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.Text <> "" Then
            Dim baglanti_metni2 As String
            baglanti_metni2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\users.mdb; Persist Security Info=False;"
            Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
            baglanti1.Open()
            Dim sql1 As String
            sql1 = "delete from kullanici where adi='" & TextBox1.Text & "' "
            Dim komut As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
            komut.ExecuteNonQuery()

            MsgBox("Bilgiler Veritabanından Silinmiştir.")
            baglanti1.Close()
            yukle()
        Else
            MsgBox("Sileceğiniz Veriyi seçmediniz!")
        End If
    End Sub
End Class