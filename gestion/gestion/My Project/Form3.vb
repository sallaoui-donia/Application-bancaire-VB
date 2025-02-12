Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Private Sub init_Click(sender As Object, e As EventArgs) Handles init.Click
        Me.prenameInput.Text = ""
        Me.nameInput.Text = ""
        Me.mdpInput.Text = ""
        Me.serieInput.Text = ""
        Me.posteInput.Text = ""
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If (Not IsNumeric(Me.serieInput.Text)) Then
            MessageBox.Show("Numéro de serie doit etre un numéro", "Alerte", MessageBoxButtons.OK)
        ElseIf (verification() = False) Then
            MessageBox.Show("Vérifier votre informations", "Alerte", MessageBoxButtons.OK)
        ElseIf (Verification() = True) Then
            Dim str As String
            str = "SELECT * FROM Personel WHERE num_serie=@serie "
            Dim cmd1 As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
            cmd1.Parameters.AddWithValue("@serie", Convert.ToInt32(Me.serieInput.Text))
            Dim dr As OleDbDataReader = cmd1.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Administrateur déja existe", "Alerte", MessageBoxButtons.OK)
                Me.Close()
            Else
                Dim sql As String = "INSERT INTO Personel (nom, prenom, num_serie, poste, mdp) VALUES(@name, @prename, @serie, @poste, @psw)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, Form1.myConnection)
                cmd.Parameters.AddWithValue("@name", Me.nameInput.Text)
                cmd.Parameters.AddWithValue("@prename", Me.prenameInput.Text)
                cmd.Parameters.AddWithValue("@serie", Me.serieInput.Text)
                cmd.Parameters.AddWithValue("@poste", Me.posteInput.Text)
                cmd.Parameters.AddWithValue("@psw", Me.mdpInput.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Administrateur ajouté", "Succés", MessageBoxButtons.OK)
                Me.Close()
            End If
        End If
    End Sub
    Private Function Verification() As Boolean
        If (Me.serieInput.Text Is Nothing Or Me.mdpInput.Text Is Nothing Or Me.posteInput.Text Is Nothing Or Me.nameInput.Text Is Nothing Or Me.prenameInput.Text Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function


End Class