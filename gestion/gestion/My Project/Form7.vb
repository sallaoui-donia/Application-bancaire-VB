Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "SELECT * FROM stagiares "
        Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
        'cmd.Parameters.AddWithValue("@cin", cin)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim dataSet As New DataSet()
            dr.Close()
            dataAdapter.Fill(dataSet, "stagiare")

            Me.dataGrid.DataSource = dataSet.Tables("stagiare")

            'MessageBox.Show("Administrateur déja existe", "Alerte", MessageBoxButtons.OK)
            'Me.Close()
        Else
            MessageBox.Show("y'a pas aucun stagiare!", "Alerte", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Me.Close()
    End Sub
End Class