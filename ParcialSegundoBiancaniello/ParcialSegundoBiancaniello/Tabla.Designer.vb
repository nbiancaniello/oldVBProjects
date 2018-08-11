<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabla
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
        Me.lv_datos = New System.Windows.Forms.ListView
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.nombreapellido = New System.Windows.Forms.ColumnHeader
        Me.fecha_nac = New System.Windows.Forms.ColumnHeader
        Me.telefono = New System.Windows.Forms.ColumnHeader
        Me.celular = New System.Windows.Forms.ColumnHeader
        Me.email = New System.Windows.Forms.ColumnHeader
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lv_datos
        '
        Me.lv_datos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nombreapellido, Me.fecha_nac, Me.telefono, Me.celular, Me.email})
        Me.lv_datos.FullRowSelect = True
        Me.lv_datos.GridLines = True
        Me.lv_datos.Location = New System.Drawing.Point(12, 20)
        Me.lv_datos.MultiSelect = False
        Me.lv_datos.Name = "lv_datos"
        Me.lv_datos.Size = New System.Drawing.Size(706, 190)
        Me.lv_datos.TabIndex = 0
        Me.lv_datos.UseCompatibleStateImageBehavior = False
        Me.lv_datos.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "codigo"
        '
        'nombreapellido
        '
        Me.nombreapellido.Text = "nombre y apellido"
        Me.nombreapellido.Width = 122
        '
        'fecha_nac
        '
        Me.fecha_nac.Text = "Fecha Nac."
        Me.fecha_nac.Width = 88
        '
        'telefono
        '
        Me.telefono.Text = "telefono"
        Me.telefono.Width = 121
        '
        'celular
        '
        Me.celular.Text = "celular"
        Me.celular.Width = 112
        '
        'email
        '
        Me.email.Text = "email"
        Me.email.Width = 192
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(632, 216)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(86, 25)
        Me.btn_cerrar.TabIndex = 1
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(540, 216)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(86, 25)
        Me.btn_modificar.TabIndex = 2
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'Tabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 257)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lv_datos)
        Me.Name = "Tabla"
        Me.Text = "Tabla"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_datos As System.Windows.Forms.ListView
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents nombreapellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecha_nac As System.Windows.Forms.ColumnHeader
    Friend WithEvents telefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents celular As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
End Class
