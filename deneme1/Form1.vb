Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\users.mdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "select * from kullanici where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        Dim veri_okuyucu1 As Data.OleDb.OleDbDataReader
        veri_okuyucu1 = komut1.ExecuteReader
        If veri_okuyucu1.HasRows = True Then
            veri_okuyucu1.Read()
            If veri_okuyucu1("yetki") = "admin" Then
                Form2.Show()
                Me.Hide()
            Else
                If veri_okuyucu1("sayac") = "3" Then
                    MsgBox("Üç kere hatalı giriş yaptınız. Lütfen yönetici ile iletişime geçiniz!")
                Else
                    Form3.Show()
                    Me.Hide()
                End If
            End If
                Else
                MsgBox("Kullanıcı kayıtlı değil.")
        End If
        baglanti1.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
