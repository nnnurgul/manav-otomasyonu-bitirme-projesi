Imports System.Data.OleDb

Public Class Form5
    Dim baglanti As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;")

    Private Sub ListBox1_SelectedIndeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)










    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        urunler.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        urunler.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim toplam As Double

        For i = 0 To ListBox5.Items.Count - 1
            toplam = toplam + CDbl(ListBox5.Items.Item(i))
        Next
        Label7.Text = toplam
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Today()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

End Class