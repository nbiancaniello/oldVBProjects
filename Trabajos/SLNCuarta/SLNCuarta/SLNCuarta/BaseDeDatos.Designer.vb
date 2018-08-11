<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseDeDatos
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
        Me.lv_datos = New System.Windows.Forms.ListView
        Me.legajo = New System.Windows.Forms.ColumnHeader
        Me.nombre = New System.Windows.Forms.ColumnHeader
        Me.telefono = New System.Windows.Forms.ColumnHeader
        Me.email = New System.Windows.Forms.ColumnHeader
        Me.celular = New System.Windows.Forms.ColumnHeader
        Me.fecha = New System.Windows.Forms.ColumnHeader
        Me.sexo = New System.Windows.Forms.ColumnHeader
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lv_datos
        '
        Me.lv_datos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.legajo, Me.nombre, Me.telefono, Me.email, Me.celular, Me.fecha, Me.sexo})
        Me.lv_datos.FullRowSelect = True
        Me.lv_datos.GridLines = True
        Me.lv_datos.Location = New System.Drawing.Point(12, 12)
        Me.lv_datos.MultiSelect = False
        Me.lv_datos.Name = "lv_datos"
        Me.lv_datos.Size = New System.Drawing.Size(675, 354)
        Me.lv_datos.TabIndex = 0
        Me.lv_datos.UseCompatibleStateImageBehavior = False
        Me.lv_datos.View = System.Windows.Forms.View.Details
        '
        'legajo
        '
        Me.legajo.Text = "legajo"
        '
        'nombre
        '
        Me.nombre.Text = "nombre_apellido"
        Me.nombre.Width = 120
        '
        'telefono
        '
        Me.telefono.Text = "telefono"
        Me.telefono.Width = 100
        '
        'email
        '
        Me.email.Text = "email"
        Me.email.Width = 150
        '
        'celular
        '
        Me.celular.Text = "celular"
        Me.celular.Width = 100
        '
        'fecha
        '
        Me.fecha.Text = "fecha_nacimiento"
        Me.fecha.Width = 100
        '
        'sexo
        '
        Me.sexo.Text = "sexo"
        Me.sexo.Width = 39
        '
        'btn_cerrar
        '
        Me.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cerrar.Location = New System.Drawing.Point(610, 384)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(76, 30)
        Me.btn_cerrar.TabIndex = 1
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(528, 384)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(76, 30)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(446, 384)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(76, 30)
        Me.btn_modificar.TabIndex = 3
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(364, 384)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(76, 30)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "&Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(282, 384)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(76, 30)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'BaseDeDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cerrar
        Me.ClientSize = New System.Drawing.Size(699, 424)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lv_datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BaseDeDatos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Base de Datos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_datos As System.Windows.Forms.ListView
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents legajo As System.Windows.Forms.ColumnHeader
    Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents telefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents celular As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents sexo As System.Windows.Forms.ColumnHeader
End Class
