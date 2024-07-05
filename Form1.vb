Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;"



        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "select * from kullanici where adi='" & TextBox1.Text & "' and sifre='" & TextBox2.Text & "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        Dim veri_okuyucu1 As Data.OleDb.OleDbDataReader
        veri_okuyucu1 = komut1.ExecuteReader
        If veri_okuyucu1.HasRows = True Then
            veri_okuyucu1.Read()
            If veri_okuyucu1("yetki") = "admin" Then
                anaform.Show()
                Me.Hide()

            Else

                Form5.Show()
                Me.Hide()

            End If
        Else

            If Label3.Text >= 3 Then
                MsgBox("Üç kere hatalı giriş yaptınız. Lütfen yönetici ile iletişime geçiniz!")
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                Button1.Enabled = False

            Else
                Label3.Text = Label3.Text + 1
                MsgBox("Kullanıcı kayıtlı değil.")
            End If








        End If
        baglanti1.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
