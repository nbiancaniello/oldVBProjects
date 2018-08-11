<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_asignar = New System.Windows.Forms.Button
        Me.btn_mostrar = New System.Windows.Forms.Button
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.txt_marca = New System.Windows.Forms.TextBox
        Me.txt_modelo = New System.Windows.Forms.TextBox
        Me.txt_cilindros = New System.Windows.Forms.TextBox
        Me.txt_tipo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_asignar
        '
        Me.btn_asignar.Location = New System.Drawing.Point(230, 17)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(125, 28)
        Me.btn_asignar.TabIndex = 0
        Me.btn_asignar.Text = "&Asignar motor"
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Location = New System.Drawing.Point(230, 51)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(125, 28)
        Me.btn_mostrar.TabIndex = 1
        Me.btn_mostrar.Text = "&Mostrar motor"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(94, 17)
        Me.txt_numero.MaxLength = 12
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(111, 20)
        Me.txt_numero.TabIndex = 2
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(94, 43)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(111, 20)
        Me.txt_marca.TabIndex = 3
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(94, 69)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(111, 20)
        Me.txt_modelo.TabIndex = 4
        '
        'txt_cilindros
        '
        Me.txt_cilindros.Location = New System.Drawing.Point(94, 95)
        Me.txt_cilindros.MaxLength = 2
        Me.txt_cilindros.Name = "txt_cilindros"
        Me.txt_cilindros.Size = New System.Drawing.Size(26, 20)
        Me.txt_cilindros.TabIndex = 5
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(94, 121)
        Me.txt_tipo.MaxLength = 1
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(26, 20)
        Me.txt_tipo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "cilindros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "patente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "compania"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 209)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 183)
        Me.TextBox2.MaxLength = 6
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(94, 157)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(111, 20)
        Me.TextBox3.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 28)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Mostrar automovil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 28)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "&Asignar automovil"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Clase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 256)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.txt_cilindros)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.btn_asignar)
        Me.Name = "Clase"
        Me.Text = "Clase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cilindros As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
