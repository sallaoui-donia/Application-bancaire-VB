Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form8
    Public id As Integer
    Private Sub recherch_Click(sender As Object, e As EventArgs) Handles recherch.Click
        If (Me.cin_Input.Text.Length() <> 8 Or Not IsNumeric(Me.cin_Input.Text)) Then
            MessageBox.Show("Verifier le numéro de CIN", "Alerte", MessageBoxButtons.OK)
        Else
            Dim str As String
            str = "SELECT * FROM stagiares WHERE CIN=@cin "
            Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
            cmd.Parameters.AddWithValue("@cin", Convert.ToInt32(Me.cin_Input.Text))
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If Not dr.HasRows Then
                MessageBox.Show("Stagiare n'existe pas!", "Alerte", MessageBoxButtons.OK)
                Me.cin_Input.Text = ""
            Else
                ' Dim ds As New DataSet
                Dim dt As New DataTable
                'ds.Tables.Add(dt)
                ' Dim da As New OleDbDataAdapter
                'da = New OleDbDataAdapter("SELECT * FROM stagiares WHERE CIN=" + Me.cin_Input.Text)
                ' da.Fill(dt)
                dt.Load(dr)
                id = dt.Rows(0).Item(0)
                Me.nameInput.Text = dt.Rows(0).Item(1)
                Me.prenameInput.Text = dt.Rows(0).Item(2)
                Me.cinInput.Text = dt.Rows(0).Item(3)
                Me.unInput.Text = dt.Rows(0).Item(4)
                Me.beginInput.Value = dt.Rows(0).Item(5)
                Me.endInput.Value = dt.Rows(0).Item(6)
            End If
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub init_Click(sender As Object, e As EventArgs) Handles init.Click
        Me.nameInput.Text = Nothing
        Me.prenameInput.Text = Nothing
        Me.unInput.Text = Nothing
        Me.beginInput.Value = Now
        Me.endInput.Value = Now
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If (Me.beginInput.Value > Me.endInput.Value) Then
            MessageBox.Show("Vérrifier la dates du stage", "Alerte", MessageBoxButtons.OK)
        ElseIf (Verification() = False) Then
            MessageBox.Show("Vérifier vos informations", "Alerte", MessageBoxButtons.OK)
        Else
            Dim str As String
            str = "DELETE FROM stagiares WHERE CIN=@cin "
            Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
            cmd.Parameters.AddWithValue("@cin", Convert.ToInt32(cin_Input.Text))
            cmd.ExecuteNonQuery()
            Dim sql As String = "INSERT INTO stagiares (nom, prenom, CIN, universite, date_debut, date_fin) VALUES(@name, @prename, @cin, @universite, @dateDb, @dateFn)"
            Dim cmd2 As OleDbCommand = New OleDbCommand(sql, Form1.myConnection)
            cmd2.Parameters.AddWithValue("@name", Me.nameInput.Text)
            cmd2.Parameters.AddWithValue("@prename", Me.prenameInput.Text)
            cmd2.Parameters.AddWithValue("@cin", Me.cinInput.Text)
            cmd2.Parameters.AddWithValue("@universite", Me.unInput.Text)
            cmd2.Parameters.AddWithValue("@dateDb", Me.beginInput.Text)
            cmd2.Parameters.AddWithValue("@dateFn", Me.endInput.Text)
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Stagiaire modifié!", "Succés", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub
    Private Function Verification() As Boolean
        If (Me.nameInput.Text Is Nothing Or Me.prenameInput.Text Is Nothing Or Me.cin_Input.Text Is Nothing Or Me.unInput.Text Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function

End Class