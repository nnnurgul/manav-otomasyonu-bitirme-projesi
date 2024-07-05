Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class Güncelle
    Dim baglanti As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;")
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Sub temizle()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = String.Empty
        ComboBox2.Text = String.Empty
        TextBox5.Clear()
        TextBox6.Clear()


    End Sub
    Sub listele()
        Dim dt As New DataTable
        Dim sql As String = "select * from urunler "
        Dim adtr As New OleDbDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "update urunler set  kategori='" & ComboBox1.Text & "',adi = '" & TextBox2.Text & "',birim='" & ComboBox2.Text & "',afiyat='" & TextBox3.Text & "',sfiyat='" & TextBox5.Text & "',miktar='" & TextBox6.Text & "' where barkod = '" & TextBox1.Text & "'"
        Dim komut As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        komut.ExecuteNonQuery()
        MsgBox("Bilgiler Veritabanında Güncellenmiştir.")
        baglanti1.Close()
        listele()
        temizle()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)
        baglanti1.Open()
        Dim sql1 As String
        sql1 = "insert into urunler(barkod,kategori,adi,birim,afiyat,sfiyat,miktar) values ('" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox2.Text + "','" + ComboBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        komut1.ExecuteNonQuery()
        baglanti1.Close()
        MsgBox("Veriler Başarıyla Kaydedildi")
        listele()
        temizle()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells("barkod").Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells("adi").Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells("afiyat").Value.ToString()
        TextBox5.Text = DataGridView1.CurrentRow.Cells("sfiyat").Value.ToString()
        TextBox6.Text = DataGridView1.CurrentRow.Cells("miktar").Value.ToString()
        ComboBox1.Text = DataGridView1.CurrentRow.Cells("kategori").Value.ToString()
        ComboBox2.Text = DataGridView1.CurrentRow.Cells("birim").Value.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)

        Dim sql1 As String
        sql1 = "DELETE FROM urunler WHERE barkod = '" & Integer.Parse(DataGridView1.CurrentRow.Cells("barkod").Value.ToString()) & "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        baglanti1.Open()
        komut1.ExecuteNonQuery()
        baglanti1.Close()
        MsgBox("Veriler Başarıyla Silindi")
        listele()
        temizle()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim baglanti_metni2 As String
        baglanti_metni2 = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;"
        Dim baglanti1 As New Data.OleDb.OleDbConnection(baglanti_metni2)

        Dim sql1 As String
        sql1 = "DELETE FROM urunler WHERE barkod = '" & Integer.Parse(DataGridView1.CurrentRow.Cells("barkod").Value.ToString()) & "'"
        Dim komut1 As New System.Data.OleDb.OleDbCommand(sql1, baglanti1)
        baglanti1.Open()
        komut1.ExecuteNonQuery()
        baglanti1.Close()
        MsgBox("Veriler Başarıyla Silindi")
        listele()
        temizle()
    End Sub
End Class