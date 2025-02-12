<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prenameInput = New System.Windows.Forms.TextBox()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.serieInput = New System.Windows.Forms.TextBox()
        Me.posteInput = New System.Windows.Forms.TextBox()
        Me.mdpInput = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.init = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ajouter Administrateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numéro de série:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(182, 253)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Poste:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 301)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mot de passe:"
        '
        'prenameInput
        '
        Me.prenameInput.Location = New System.Drawing.Point(346, 88)
        Me.prenameInput.Name = "prenameInput"
        Me.prenameInput.Size = New System.Drawing.Size(230, 26)
        Me.prenameInput.TabIndex = 6
        '
        'nameInput
        '
        Me.nameInput.Location = New System.Drawing.Point(346, 136)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(230, 26)
        Me.nameInput.TabIndex = 7
        '
        'serieInput
        '
        Me.serieInput.Location = New System.Drawing.Point(346, 196)
        Me.serieInput.Name = "serieInput"
        Me.serieInput.Size = New System.Drawing.Size(230, 26)
        Me.serieInput.TabIndex = 8
        '
        'posteInput
        '
        Me.posteInput.Location = New System.Drawing.Point(346, 250)
        Me.posteInput.Name = "posteInput"
        Me.posteInput.Size = New System.Drawing.Size(230, 26)
        Me.posteInput.TabIndex = 9
        '
        'mdpInput
        '
        Me.mdpInput.Location = New System.Drawing.Point(346, 301)
        Me.mdpInput.Name = "mdpInput"
        Me.mdpInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mdpInput.Size = New System.Drawing.Size(230, 26)
        Me.mdpInput.TabIndex = 10
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(214, 395)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(132, 33)
        Me.add.TabIndex = 11
        Me.add.Text = "Ajouter"
        Me.add.UseVisualStyleBackColor = True
        '
        'init
        '
        Me.init.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.init.Location = New System.Drawing.Point(374, 395)
        Me.init.Name = "init"
        Me.init.Size = New System.Drawing.Size(132, 33)
        Me.init.TabIndex = 12
        Me.init.Text = "Initialiser"
        Me.init.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(533, 395)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(132, 33)
        Me.cancel.TabIndex = 13
        Me.cancel.Text = "Annuler"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.init)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.mdpInput)
        Me.Controls.Add(Me.posteInput)
        Me.Controls.Add(Me.serieInput)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.prenameInput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form3"
        Me.Text = "Ajouter Administrateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents prenameInput As TextBox
    Friend WithEvents nameInput As TextBox
    Friend WithEvents serieInput As TextBox
    Friend WithEvents posteInput As TextBox
    Friend WithEvents mdpInput As TextBox
    Friend WithEvents add As Button
    Friend WithEvents init As Button
    Friend WithEvents cancel As Button
End Class
