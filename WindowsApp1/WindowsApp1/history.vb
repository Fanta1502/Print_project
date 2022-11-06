Imports System.Data.DataTable
Imports MySql.Data.MySqlClient
Public Class history
    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user id = root ;password= ;database =printdatabase ;")
        con.Open()
        Dim com As String
        com = "SELECT * FROM t_file"
        Dim adapter As New MySqlDataAdapter(com, con)
        Dim aze As New DataTable()
        adapter.Fill(aze)
        For Each donnee In aze.Rows
            dgvFiles.Rows.Add(donnee(1), donnee(2))
        Next
        con.Close()
    End Sub
End Class