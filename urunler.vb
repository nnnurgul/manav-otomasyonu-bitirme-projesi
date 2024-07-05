Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class urunler
    Dim baglanti As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;")
    Dim TUTAR As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TUTAR As Double

        Form5.ListBox1.Items.Add(TextBox4.Text)
        Form5.ListBox2.Items.Add(TextBox2.Text)
        Form5.ListBox3.Items.Add(NumericUpDown1.Value)
        Form5.ListBox4.Items.Add(TextBox5.Text)
        If TextBox5.Text <> "" Then
            TUTAR = CDbl(NumericUpDown1.Value) * CDbl(TextBox5.Text)
            Form5.ListBox5.Items.Add(TUTAR)

            TextBox2.Clear()
            TextBox4.Clear()
            TextBox5.Clear()





            MsgBox("Ürün Sepete Eklenmiştir")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Sub listele2()
        baglanti.Open()
        Dim sql1 As String
        sql1 = "select adi from urunler where kategori='" + ListBox4.Text + "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti)
        Dim veri_okuyucu As Data.OleDb.OleDbDataReader
        veri_okuyucu = komut1.ExecuteReader
        While (veri_okuyucu.Read())
            ListBox5.Items.Add(veri_okuyucu("adi"))
        End While
        baglanti.Close()
    End Sub
    Sub listele3()
        Dim barkodu, satisfiyat As Double
        Dim urunadi, urunbrim As String

        baglanti.Open()
        Dim sql1 As String
        sql1 = "select * from urunler where adi='" + ListBox5.Text + "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti)
        Dim dr As OleDbDataReader = komut1.ExecuteReader
        While dr.Read


            barkodu = dr("barkod")
            urunadi = dr("adi")
            urunbrim = dr("birim")
            satisfiyat = dr("sfiyat")

        End While

        baglanti.Close()
        TextBox4.Text = barkodu
        TextBox2.Text = urunadi
        ComboBox2.Text = urunbrim
        TextBox5.Text = satisfiyat

    End Sub
    Sub listele1()
        baglanti.Open()
        Dim sql1 As String
        sql1 = "select kategoriler from kategori"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti)
        Dim veri_okuyucu As Data.OleDb.OleDbDataReader
        veri_okuyucu = komut1.ExecuteReader
        While (veri_okuyucu.Read())
            ListBox4.Items.Add(veri_okuyucu("kategoriler"))
        End While
        baglanti.Close()
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If TextBox5.Text <> "" Then
            TUTAR = CDbl(NumericUpDown1.Value) * CDbl(TextBox5.Text)
            Label4.Text = TUTAR
        End If
    End Sub

    Private Sub urunler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele1()



    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        ListBox5.Items.Clear()

        listele2()
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        TextBox4.Clear()
        TextBox2.Clear()
        ComboBox2.Items.Clear()
        TextBox5.Clear()

        listele3()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class