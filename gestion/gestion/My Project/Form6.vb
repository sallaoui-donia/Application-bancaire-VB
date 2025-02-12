Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form6
    Private cin As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.cinInput.Text Is Nothing Or Not IsNumeric(Me.cinInput.Text) Or Me.cinInput.Text.Length() <> 8) Then
            MessageBox.Show("Vérifier le numéro de CIN", "Alerte", MessageBoxButtons.OK)
        Else
            cin = Convert.ToInt32(Me.cinInput.Text)
            Dim str As String
            str = "SELECT * FROM stagiares WHERE CIN=@cin "
            Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
            cmd.Parameters.AddWithValue("@cin", cin)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dataSet As New DataSet()
                dr.Close()
                dataAdapter.Fill(dataSet, "stagiare")
                Me.dataGrid.DataSource = dataSet.Tables("stagiare")
                Me.deleteIntern.Enabled = True
                'MessageBox.Show("Administrateur déja existe", "Alerte", MessageBoxButtons.OK)
                'Me.Close()
            Else
                MessageBox.Show("Stagiare n'existe pas!", "Alerte", MessageBoxButtons.OK)
                Me.cinInput.Text = Nothing
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub deleteIntern_Click(sender As Object, e As EventArgs) Handles deleteIntern.Click
        Try
            Dim str As String
            str = "DELETE FROM stagiares WHERE CIN=@cin "
            Dim cmd As OleDbCommand = New OleDbCommand(str, Form1.myConnection)
            cmd.Parameters.AddWithValue("@cin", cin)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Stagiare Supprimé", "Succés", MessageBoxButtons.OK)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.deleteIntern.Enabled = False
    End Sub
End Class