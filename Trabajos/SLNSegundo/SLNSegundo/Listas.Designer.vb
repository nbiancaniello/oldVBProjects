<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listas
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
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.lst_nombres = New System.Windows.Forms.ListBox
        Me.btn_cantidad = New System.Windows.Forms.Button
        Me.btn_eliminaritem = New System.Windows.Forms.Button
        Me.btn_eliminarlista = New System.Windows.Forms.Button
        Me.btn_caracteres = New System.Windows.Forms.Button
        Me.btn_mayorlong = New System.Windows.Forms.Button
        Me.btn_menorlong = New System.Windows.Forms.Button
        Me.txt_letra = New System.Windows.Forms.TextBox
        Me.btn_cant2 = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 21)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(65, 15)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(173, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(244, 15)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(67, 24)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "&Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lst_nombres
        '
        Me.lst_nombres.FormattingEnabled = True
        Me.lst_nombres.Location = New System.Drawing.Point(16, 50)
        Me.lst_nombres.Name = "lst_nombres"
        Me.lst_nombres.Size = New System.Drawing.Size(294, 238)
        Me.lst_nombres.TabIndex = 3
        '
        'btn_cantidad
        '
        Me.btn_cantidad.Location = New System.Drawing.Point(328, 50)
        Me.btn_cantidad.Name = "btn_cantidad"
        Me.btn_cantidad.Size = New System.Drawing.Size(97, 23)
        Me.btn_cantidad.TabIndex = 4
        Me.btn_cantidad.Text = "&Cantidad"
        Me.btn_cantidad.UseVisualStyleBackColor = True
        '
        'btn_eliminaritem
        '
        Me.btn_eliminaritem.Location = New System.Drawing.Point(328, 79)
        Me.btn_eliminaritem.Name = "btn_eliminaritem"
        Me.btn_eliminaritem.Size = New System.Drawing.Size(97, 23)
        Me.btn_eliminaritem.TabIndex = 5
        Me.btn_eliminaritem.Text = "Eliminar &Item"
        Me.btn_eliminaritem.UseVisualStyleBackColor = True
        '
        'btn_eliminarlista
        '
        Me.btn_eliminarlista.Location = New System.Drawing.Point(328, 108)
        Me.btn_eliminarlista.Name = "btn_eliminarlista"
        Me.btn_eliminarlista.Size = New System.Drawing.Size(97, 23)
        Me.btn_eliminarlista.TabIndex = 6
        Me.btn_eliminarlista.Text = "Elimi&nar Lista "
        Me.btn_eliminarlista.UseVisualStyleBackColor = True
        '
        'btn_caracteres
        '
        Me.btn_caracteres.Location = New System.Drawing.Point(328, 137)
        Me.btn_caracteres.Name = "btn_caracteres"
        Me.btn_caracteres.Size = New System.Drawing.Size(97, 23)
        Me.btn_caracteres.TabIndex = 7
        Me.btn_caracteres.Text = "Carac&teres"
        Me.btn_caracteres.UseVisualStyleBackColor = True
        '
        'btn_mayorlong
        '
        Me.btn_mayorlong.Location = New System.Drawing.Point(329, 166)
        Me.btn_mayorlong.Name = "btn_mayorlong"
        Me.btn_mayorlong.Size = New System.Drawing.Size(96, 23)
        Me.btn_mayorlong.TabIndex = 8
        Me.btn_mayorlong.Text = "Ma&yor Longitud"
        Me.btn_mayorlong.UseVisualStyleBackColor = True
        '
        'btn_menorlong
        '
        Me.btn_menorlong.Location = New System.Drawing.Point(329, 195)
        Me.btn_menorlong.Name = "btn_menorlong"
        Me.btn_menorlong.Size = New System.Drawing.Size(96, 23)
        Me.btn_menorlong.TabIndex = 9
        Me.btn_menorlong.Text = "M&enor Longitud"
        Me.btn_menorlong.UseVisualStyleBackColor = True
        '
        'txt_letra
        '
        Me.txt_letra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_letra.Location = New System.Drawing.Point(328, 231)
        Me.txt_letra.MaxLength = 1
        Me.txt_letra.Name = "txt_letra"
        Me.txt_letra.Size = New System.Drawing.Size(25, 20)
        Me.txt_letra.TabIndex = 10
        '
        'btn_cant2
        '
        Me.btn_cant2.Location = New System.Drawing.Point(359, 229)
        Me.btn_cant2.Name = "btn_cant2"
        Me.btn_cant2.Size = New System.Drawing.Size(62, 23)
        Me.btn_cant2.TabIndex = 11
        Me.btn_cant2.Text = "Cant&idad:"
        Me.btn_cant2.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(328, 267)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(96, 21)
        Me.btn_salir.TabIndex = 12
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'frm_listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 301)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cant2)
        Me.Controls.Add(Me.txt_letra)
        Me.Controls.Add(Me.btn_menorlong)
        Me.Controls.Add(Me.btn_mayorlong)
        Me.Controls.Add(Me.btn_caracteres)
        Me.Controls.Add(Me.btn_eliminarlista)
        Me.Controls.Add(Me.btn_eliminaritem)
        Me.Controls.Add(Me.btn_cantidad)
        Me.Controls.Add(Me.lst_nombres)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "frm_listas"
        Me.Text = "Listas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lst_nombres As System.Windows.Forms.ListBox
    Friend WithEvents btn_cantidad As System.Windows.Forms.Button
    Friend WithEvents btn_eliminaritem As System.Windows.Forms.Button
    Friend WithEvents btn_eliminarlista As System.Windows.Forms.Button
    Friend WithEvents btn_caracteres As System.Windows.Forms.Button
    Friend WithEvents btn_mayorlong As System.Windows.Forms.Button
    Friend WithEvents btn_menorlong As System.Windows.Forms.Button
    Friend WithEvents txt_letra As System.Windows.Forms.TextBox
    Friend WithEvents btn_cant2 As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button

End Class
