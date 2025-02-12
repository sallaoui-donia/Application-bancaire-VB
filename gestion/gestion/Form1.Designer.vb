<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.serie = New System.Windows.Forms.Label()
        Me.serieInput = New System.Windows.Forms.TextBox()
        Me.mdp = New System.Windows.Forms.Label()
        Me.mdpInput = New System.Windows.Forms.TextBox()
        Me.coButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'serie
        '
        Me.serie.AutoSize = True
        Me.serie.Font = New System.Drawing.Font("Lucida Sans Typewriter", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serie.Location = New System.Drawing.Point(152, 199)
        Me.serie.Name = "serie"
        Me.serie.Size = New System.Drawing.Size(236, 33)
        Me.serie.TabIndex = 1
        Me.serie.Text = "Num de série:"
        '
        'serieInput
        '
        Me.serieInput.Font = New System.Drawing.Font("Lucida Sans Typewriter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serieInput.Location = New System.Drawing.Point(394, 199)
        Me.serieInput.Name = "serieInput"
        Me.serieInput.Size = New System.Drawing.Size(215, 36)
        Me.serieInput.TabIndex = 2
        '
        'mdp
        '
        Me.mdp.AutoSize = True
        Me.mdp.Font = New System.Drawing.Font("Lucida Sans Typewriter", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdp.Location = New System.Drawing.Point(152, 267)
        Me.mdp.Name = "mdp"
        Me.mdp.Size = New System.Drawing.Size(236, 33)
        Me.mdp.TabIndex = 3
        Me.mdp.Text = "Mot de Passe:"
        '
        'mdpInput
        '
        Me.mdpInput.Font = New System.Drawing.Font("Lucida Sans Typewriter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdpInput.Location = New System.Drawing.Point(394, 269)
        Me.mdpInput.Name = "mdpInput"
        Me.mdpInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mdpInput.Size = New System.Drawing.Size(215, 36)
        Me.mdpInput.TabIndex = 4
        '
        'coButton
        '
        Me.coButton.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coButton.Location = New System.Drawing.Point(394, 357)
        Me.coButton.Name = "coButton"
        Me.coButton.Size = New System.Drawing.Size(148, 36)
        Me.coButton.TabIndex = 5
        Me.coButton.Text = "Connecter"
        Me.coButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.gestion.My.Resources.Resources.logo1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(283, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 124)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 414)
        Me.Controls.Add(Me.coButton)
        Me.Controls.Add(Me.mdpInput)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.serieInput)
        Me.Controls.Add(Me.serie)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents serie As Label
    Friend WithEvents serieInput As TextBox
    Friend WithEvents mdp As Label
    Friend WithEvents mdpInput As TextBox
    Friend WithEvents coButton As Button
End Class
