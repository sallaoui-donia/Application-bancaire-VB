Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Private Sub Form1_load(ByVal sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "SELECT * FROM Personel WHERE num_serie=@USER "
        Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
        cmd.Parameters.AddWithValue("@USER", Form1.serieText)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        Dim nom As String = dr("prenom").ToString
        Me.accMsg.Text = "Bienvenu " & nom
    End Sub

    Private Sub deco_Click(sender As Object, e As EventArgs) Handles deco.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click

        End
    End Sub

    Private Sub addAdmin_Click(sender As Object, e As EventArgs) Handles addAdmin.Click
        Form3.Show()
    End Sub

    Private Sub addIntern_Click(sender As Object, e As EventArgs) Handles addIntern.Click
        Form5.Show()
    End Sub

    Private Sub deleIntern_Click(sender As Object, e As EventArgs) Handles deleIntern.Click
        Form6.Show()
    End Sub

    Private Sub showInterns_Click(sender As Object, e As EventArgs)
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles updaIntern.Click
        Form8.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub
End Class