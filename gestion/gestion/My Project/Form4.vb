Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "SELECT * FROM stagiares"
        Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim dataSet As New DataSet()
            dr.Close()
            dataAdapter.Fill(dataSet, "stagiaire")
            Me.dataGrid.DataSource = dataSet.Tables("stagiaire")
            'MessageBox.Show("Administrateur déja existe", "Alerte", MessageBoxButtons.OK)
            'Me.Close()
        Else
            MessageBox.Show("Ya pas des stagiaires!", "Alerte", MessageBoxButtons.OK)
        End If
    End Sub
End Class