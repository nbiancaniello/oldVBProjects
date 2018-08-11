<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CombosListas
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
        Me.cmb_opcion = New System.Windows.Forms.ComboBox
        Me.lbl_cantidad = New System.Windows.Forms.Label
        Me.lbl_contador = New System.Windows.Forms.Label
        Me.lst_contenido = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmb_opcion
        '
        Me.cmb_opcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_opcion.FormattingEnabled = True
        Me.cmb_opcion.Items.AddRange(New Object() {"Localidades", "Partidos", "Provincias", "Países"})
        Me.cmb_opcion.Location = New System.Drawing.Point(15, 13)
        Me.cmb_opcion.Name = "cmb_opcion"
        Me.cmb_opcion.Size = New System.Drawing.Size(161, 21)
        Me.cmb_opcion.TabIndex = 0
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(12, 238)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(55, 13)
        Me.lbl_cantidad.TabIndex = 1
        Me.lbl_cantidad.Text = "Cantidad: "
        '
        'lbl_contador
        '
        Me.lbl_contador.AutoSize = True
        Me.lbl_contador.Location = New System.Drawing.Point(62, 238)
        Me.lbl_contador.Name = "lbl_contador"
        Me.lbl_contador.Size = New System.Drawing.Size(13, 13)
        Me.lbl_contador.TabIndex = 2
        Me.lbl_contador.Text = "0"
        '
        'lst_contenido
        '
        Me.lst_contenido.FormattingEnabled = True
        Me.lst_contenido.Location = New System.Drawing.Point(15, 40)
        Me.lst_contenido.Name = "lst_contenido"
        Me.lst_contenido.Size = New System.Drawing.Size(161, 186)
        Me.lst_contenido.TabIndex = 3
        '
        'frm_CombosListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 257)
        Me.Controls.Add(Me.lst_contenido)
        Me.Controls.Add(Me.lbl_contador)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.cmb_opcion)
        Me.Name = "frm_CombosListas"
        Me.Text = "CombosListas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_opcion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_contador As System.Windows.Forms.Label
    Friend WithEvents lst_contenido As System.Windows.Forms.ListBox
End Class
