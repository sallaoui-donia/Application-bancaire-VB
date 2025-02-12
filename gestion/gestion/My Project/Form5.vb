Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form5


    Private Sub init_Click(sender As Object, e As EventArgs) Handles init.Click
        Me.nameInput.Text = Nothing
        Me.prenameInput.Text = Nothing
        Me.cinInput.Text = Nothing
        Me.unInput.Text = Nothing
        Me.beginInput.Value = Now
        Me.endInput.Value = Now
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If (Me.cinInput.Text.Length() <> 8 Or Not IsNumeric(Me.cinInput.Text)) Then
            MessageBox.Show("Verifier le numéro de CIN", "Alerte", MessageBoxButtons.OK)
        ElseIf (Me.beginInput.Value > Me.endInput.Value) Then
            MessageBox.Show("Vérrifier la dates du stage", "Alerte", MessageBoxButtons.OK)
        ElseIf (Verification() = False) Then
            MessageBox.Show("Vérifier vos informations", "Alerte", MessageBoxButtons.OK)
        ElseIf (Verification() = True) Then
            Dim str As String
            str = "SELECT * FROM stagiares WHERE CIN=@cin "
            Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
            cmd.Parameters.AddWithValue("@cin", Convert.ToInt32(Me.cinInput.Text))
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Stagiare déja existe", "Alerte", MessageBoxButtons.OK)
                Me.Close()
            Else
                Dim sql As String = "INSERT INTO stagiares (nom, prenom, CIN, universite, date_debut, date_fin) VALUES(@name, @prename, @cin, @universite, @dateDb, @dateFn)"
                Dim cmd2 As OleDbCommand = New OleDbCommand(sql, Form1.myConnection)
                cmd2.Parameters.AddWithValue("@name", Me.nameInput.Text)
                cmd2.Parameters.AddWithValue("@prename", Me.prenameInput.Text)
                cmd2.Parameters.AddWithValue("@cin", Me.cinInput.Text)
                cmd2.Parameters.AddWithValue("@universite", Me.unInput.Text)
                cmd2.Parameters.AddWithValue("@dateDb", Me.beginInput.Text)
                cmd2.Parameters.AddWithValue("@dateFn", Me.endInput.Text)
                cmd2.ExecuteNonQuery()
                MessageBox.Show("Stagiare ajouté", "Succés", MessageBoxButtons.OK)
                Me.Close()
            End If
        End If
    End Sub
    Private Function Verification() As Boolean
        If (Me.nameInput.Text Is Nothing Or Me.prenameInput.Text Is Nothing Or Me.cinInput.Text Is Nothing Or Me.unInput.Text Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function
End Class