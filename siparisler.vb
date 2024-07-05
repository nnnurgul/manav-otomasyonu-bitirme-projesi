Imports System.Data.OleDb

Public Class siparisler
    Dim baglanti As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\manav.accdb; Persist Security Info=False;")
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub siparisler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        siparisler()
    End Sub
    Private Sub siparisler()
        Dim query As String = "SELECT * FROM satisler"
        Dim adapter As New OleDbDataAdapter(query, baglanti)
        Dim ds As New DataSet()


        adapter.Fill(ds, "satisler")

        DataGridView1.DataSource = ds.Tables("satisler")


        baglanti.Close()
    End Sub

End Class