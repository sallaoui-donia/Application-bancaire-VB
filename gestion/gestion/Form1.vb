Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Public serieText As Integer
    Private mdpText As String
    'Public myConnection As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dhiae\Documents\Database1.accdb;")
    Public myConnection As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|D.accdb;")
    Private Sub coButton_Click(sender As Object, e As EventArgs) Handles coButton.Click
        myConnection.Open()
        If (Verification() = True) Then
            serieText = Convert.ToInt32(Me.serieInput.Text)
            mdpText = Me.mdpInput.Text
            Dim str As String
            'Dim str2 As String
            str = "SELECT * FROM Personel WHERE num_serie=@USER "
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.Parameters.AddWithValue("@USER", serieText)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If serieText = dr("num_serie") Then
                    'str2 = "SELECT * FROM Personel WHERE pwd=@PWD "
                    'cmd.Parameters.AddWithValue("@PWD", mdpText)
                    If mdpText = dr("mdp") Then
                        Form2.Show()
                        Me.Hide()
                        Me.mdpInput.Text = ""
                        Me.serieInput.Text = ""
                    Else
                        Me.mdpInput.Text = ""
                        Me.serieInput.Text = ""
                        MessageBox.Show("Mot de Passe Incorrect", "Alerte", MessageBoxButtons.OK)
                    End If
                End If
            Else
                Me.mdpInput.Text = ""
                Me.serieInput.Text = ""
                MessageBox.Show("Vérifier votre numéro de série", "Alerte", MessageBoxButtons.OK)
                'Dim Welcome As String = "SELECT * FROM Personel WHERE Real_Name=" & "Username"
                'MsgBox("Welcome back " & dr("Real_Name") & "!")
                'Else
                'MsgBox("Login Failure")
                'End If
            End If
        Else
            MessageBox.Show("Veuillez vérifier votre informations", "Alerte", MessageBoxButtons.OK)
        End If
    End Sub
    'Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Me.coButton.Enabled = False
    'End Sub
    Private Function Verification() As Boolean
        If (Me.serieInput.Text Is Nothing Or Me.mdpInput.Text Is Nothing Or Not IsNumeric(Me.serieInput.Text)) Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
