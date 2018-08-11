<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ej4
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
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.txt_cod_postal = New System.Windows.Forms.TextBox
        Me.lbl_cod_postal = New System.Windows.Forms.Label
        Me.lst_localidades = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(142, 18)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(62, 25)
        Me.btn_buscar.TabIndex = 0
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_cod_postal
        '
        Me.txt_cod_postal.Location = New System.Drawing.Point(93, 21)
        Me.txt_cod_postal.MaxLength = 4
        Me.txt_cod_postal.Name = "txt_cod_postal"
        Me.txt_cod_postal.Size = New System.Drawing.Size(33, 20)
        Me.txt_cod_postal.TabIndex = 1
        '
        'lbl_cod_postal
        '
        Me.lbl_cod_postal.AutoSize = True
        Me.lbl_cod_postal.Location = New System.Drawing.Point(12, 24)
        Me.lbl_cod_postal.Name = "lbl_cod_postal"
        Me.lbl_cod_postal.Size = New System.Drawing.Size(75, 13)
        Me.lbl_cod_postal.TabIndex = 2
        Me.lbl_cod_postal.Text = "Código Postal:"
        '
        'lst_localidades
        '
        Me.lst_localidades.FormattingEnabled = True
        Me.lst_localidades.Location = New System.Drawing.Point(15, 61)
        Me.lst_localidades.Name = "lst_localidades"
        Me.lst_localidades.Size = New System.Drawing.Size(143, 30)
        Me.lst_localidades.TabIndex = 3
        '
        'Ej4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 104)
        Me.Controls.Add(Me.lst_localidades)
        Me.Controls.Add(Me.lbl_cod_postal)
        Me.Controls.Add(Me.txt_cod_postal)
        Me.Controls.Add(Me.btn_buscar)
        Me.Name = "Ej4"
        Me.Text = "Ej4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_cod_postal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cod_postal As System.Windows.Forms.Label
    Friend WithEvents lst_localidades As System.Windows.Forms.ListBox
End Class
