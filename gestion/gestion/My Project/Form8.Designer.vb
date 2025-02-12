<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.recherch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cin_Input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.init = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.endInput = New System.Windows.Forms.DateTimePicker()
        Me.beginInput = New System.Windows.Forms.DateTimePicker()
        Me.unInput = New System.Windows.Forms.TextBox()
        Me.prenameInput = New System.Windows.Forms.TextBox()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cinInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'recherch
        '
        Me.recherch.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recherch.Location = New System.Drawing.Point(431, 65)
        Me.recherch.Name = "recherch"
        Me.recherch.Size = New System.Drawing.Size(132, 26)
        Me.recherch.TabIndex = 9
        Me.recherch.Text = "Rechercher"
        Me.recherch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CIN:"
        '
        'cin_Input
        '
        Me.cin_Input.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.cin_Input.Location = New System.Drawing.Point(252, 65)
        Me.cin_Input.Name = "cin_Input"
        Me.cin_Input.Size = New System.Drawing.Size(156, 26)
        Me.cin_Input.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Modifier stagiaire"
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(577, 384)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(132, 33)
        Me.cancel.TabIndex = 36
        Me.cancel.Text = "Annuler"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'init
        '
        Me.init.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.init.Location = New System.Drawing.Point(388, 384)
        Me.init.Name = "init"
        Me.init.Size = New System.Drawing.Size(132, 33)
        Me.init.TabIndex = 35
        Me.init.Text = "Initialiser"
        Me.init.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(191, 384)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(132, 33)
        Me.add.TabIndex = 34
        Me.add.Text = "Modifier"
        Me.add.UseVisualStyleBackColor = True
        '
        'endInput
        '
        Me.endInput.CustomFormat = "yyyy-MM-dd"
        Me.endInput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endInput.Location = New System.Drawing.Point(431, 325)
        Me.endInput.Name = "endInput"
        Me.endInput.Size = New System.Drawing.Size(230, 26)
        Me.endInput.TabIndex = 33
        '
        'beginInput
        '
        Me.beginInput.CustomFormat = "yyyy-MM-dd"
        Me.beginInput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beginInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.beginInput.Location = New System.Drawing.Point(431, 279)
        Me.beginInput.Name = "beginInput"
        Me.beginInput.Size = New System.Drawing.Size(230, 26)
        Me.beginInput.TabIndex = 32
        '
        'unInput
        '
        Me.unInput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unInput.Location = New System.Drawing.Point(431, 240)
        Me.unInput.Name = "unInput"
        Me.unInput.Size = New System.Drawing.Size(230, 26)
        Me.unInput.TabIndex = 31
        '
        'prenameInput
        '
        Me.prenameInput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenameInput.Location = New System.Drawing.Point(431, 156)
        Me.prenameInput.Name = "prenameInput"
        Me.prenameInput.Size = New System.Drawing.Size(230, 26)
        Me.prenameInput.TabIndex = 29
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.Location = New System.Drawing.Point(431, 110)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(230, 26)
        Me.nameInput.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(226, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Date de fin de stage:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Date de début de stage:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Université:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Prénom:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(226, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Nom:"
        '
        'cinInput
        '
        Me.cinInput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinInput.Location = New System.Drawing.Point(431, 199)
        Me.cinInput.Name = "cinInput"
        Me.cinInput.Size = New System.Drawing.Size(230, 26)
        Me.cinInput.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(226, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "CIN:"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 453)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cinInput)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.init)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.endInput)
        Me.Controls.Add(Me.beginInput)
        Me.Controls.Add(Me.unInput)
        Me.Controls.Add(Me.prenameInput)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.recherch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cin_Input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Modifier stagiaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents recherch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cin_Input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cancel As Button
    Friend WithEvents init As Button
    Friend WithEvents add As Button
    Friend WithEvents endInput As DateTimePicker
    Friend WithEvents beginInput As DateTimePicker
    Friend WithEvents unInput As TextBox
    Friend WithEvents prenameInput As TextBox
    Friend WithEvents nameInput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cinInput As TextBox
    Friend WithEvents Label4 As Label
End Class
