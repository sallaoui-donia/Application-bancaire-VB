<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.accMsg = New System.Windows.Forms.Label()
        Me.deco = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.addAdmin = New System.Windows.Forms.Button()
        Me.addIntern = New System.Windows.Forms.Button()
        Me.deleIntern = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.updaIntern = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'accMsg
        '
        Me.accMsg.AutoSize = True
        Me.accMsg.Font = New System.Drawing.Font("Lucida Sans Typewriter", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accMsg.Location = New System.Drawing.Point(444, 63)
        Me.accMsg.Name = "accMsg"
        Me.accMsg.Size = New System.Drawing.Size(110, 31)
        Me.accMsg.TabIndex = 0
        Me.accMsg.Text = "Label1"
        '
        'deco
        '
        Me.deco.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deco.Location = New System.Drawing.Point(751, 12)
        Me.deco.Name = "deco"
        Me.deco.Size = New System.Drawing.Size(144, 43)
        Me.deco.TabIndex = 2
        Me.deco.Text = "Déconnecter"
        Me.deco.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.Location = New System.Drawing.Point(751, 70)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(144, 43)
        Me.quit.TabIndex = 3
        Me.quit.Text = "Quitter"
        Me.quit.UseVisualStyleBackColor = True
        '
        'addAdmin
        '
        Me.addAdmin.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAdmin.Location = New System.Drawing.Point(319, 163)
        Me.addAdmin.Name = "addAdmin"
        Me.addAdmin.Size = New System.Drawing.Size(262, 39)
        Me.addAdmin.TabIndex = 4
        Me.addAdmin.Text = "Ajouter administrateur"
        Me.addAdmin.UseVisualStyleBackColor = True
        '
        'addIntern
        '
        Me.addIntern.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addIntern.Location = New System.Drawing.Point(319, 225)
        Me.addIntern.Name = "addIntern"
        Me.addIntern.Size = New System.Drawing.Size(262, 39)
        Me.addIntern.TabIndex = 5
        Me.addIntern.Text = "Ajouter stagiaire"
        Me.addIntern.UseVisualStyleBackColor = True
        '
        'deleIntern
        '
        Me.deleIntern.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleIntern.Location = New System.Drawing.Point(319, 284)
        Me.deleIntern.Name = "deleIntern"
        Me.deleIntern.Size = New System.Drawing.Size(262, 39)
        Me.deleIntern.TabIndex = 6
        Me.deleIntern.Text = "Supprimer stagiaire"
        Me.deleIntern.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Afficher les stagiaires"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'updaIntern
        '
        Me.updaIntern.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updaIntern.Location = New System.Drawing.Point(319, 402)
        Me.updaIntern.Name = "updaIntern"
        Me.updaIntern.Size = New System.Drawing.Size(262, 39)
        Me.updaIntern.TabIndex = 9
        Me.updaIntern.Text = "Modifier stagiaire"
        Me.updaIntern.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.gestion.My.Resources.Resources.logo1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 124)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 453)
        Me.Controls.Add(Me.updaIntern)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.deleIntern)
        Me.Controls.Add(Me.addIntern)
        Me.Controls.Add(Me.addAdmin)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.deco)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.accMsg)
        Me.Name = "Form2"
        Me.Text = "Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents accMsg As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents deco As Button
    Friend WithEvents quit As Button
    Friend WithEvents addAdmin As Button
    Friend WithEvents addIntern As Button
    Friend WithEvents deleIntern As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents updaIntern As Button
End Class
