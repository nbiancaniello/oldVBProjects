<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rutinas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_longitud = New System.Windows.Forms.Button
        Me.btn_espacios = New System.Windows.Forms.Button
        Me.btn_cantidad = New System.Windows.Forms.Button
        Me.txt_caja = New System.Windows.Forms.TextBox
        Me.txt_caracter = New System.Windows.Forms.TextBox
        Me.btn_borrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_longitud
        '
        Me.btn_longitud.Location = New System.Drawing.Point(15, 105)
        Me.btn_longitud.Name = "btn_longitud"
        Me.btn_longitud.Size = New System.Drawing.Size(69, 27)
        Me.btn_longitud.TabIndex = 0
        Me.btn_longitud.Text = "Longitud"
        Me.btn_longitud.UseVisualStyleBackColor = True
        '
        'btn_espacios
        '
        Me.btn_espacios.Location = New System.Drawing.Point(98, 105)
        Me.btn_espacios.Name = "btn_espacios"
        Me.btn_espacios.Size = New System.Drawing.Size(69, 27)
        Me.btn_espacios.TabIndex = 1
        Me.btn_espacios.Text = "Espacios"
        Me.btn_espacios.UseVisualStyleBackColor = True
        '
        'btn_cantidad
        '
        Me.btn_cantidad.Enabled = False
        Me.btn_cantidad.Location = New System.Drawing.Point(183, 105)
        Me.btn_cantidad.Name = "btn_cantidad"
        Me.btn_cantidad.Size = New System.Drawing.Size(69, 27)
        Me.btn_cantidad.TabIndex = 2
        Me.btn_cantidad.Text = "Cantidad"
        Me.btn_cantidad.UseVisualStyleBackColor = True
        '
        'txt_caja
        '
        Me.txt_caja.Location = New System.Drawing.Point(15, 53)
        Me.txt_caja.MaxLength = 40
        Me.txt_caja.Name = "txt_caja"
        Me.txt_caja.Size = New System.Drawing.Size(237, 20)
        Me.txt_caja.TabIndex = 3
        '
        'txt_caracter
        '
        Me.txt_caracter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_caracter.Location = New System.Drawing.Point(216, 79)
        Me.txt_caracter.MaxLength = 1
        Me.txt_caracter.Name = "txt_caracter"
        Me.txt_caracter.Size = New System.Drawing.Size(36, 20)
        Me.txt_caracter.TabIndex = 4
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(168, 20)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(84, 27)
        Me.btn_borrar.TabIndex = 5
        Me.btn_borrar.Text = "Limpiar Cajas"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Caracter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Texto"
        '
        'Rutinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 150)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.txt_caracter)
        Me.Controls.Add(Me.txt_caja)
        Me.Controls.Add(Me.btn_cantidad)
        Me.Controls.Add(Me.btn_espacios)
        Me.Controls.Add(Me.btn_longitud)
        Me.Name = "Rutinas"
        Me.Text = "Rutinas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_longitud As System.Windows.Forms.Button
    Friend WithEvents btn_espacios As System.Windows.Forms.Button
    Friend WithEvents btn_cantidad As System.Windows.Forms.Button
    Friend WithEvents txt_caja As System.Windows.Forms.TextBox
    Friend WithEvents txt_caracter As System.Windows.Forms.TextBox
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
