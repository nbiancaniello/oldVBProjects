<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleVenta
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
        Me.lv_detalle_venta = New System.Windows.Forms.ListView
        Me.codigo_producto = New System.Windows.Forms.ColumnHeader
        Me.cantidad = New System.Windows.Forms.ColumnHeader
        Me.precio_venta = New System.Windows.Forms.ColumnHeader
        Me.precio_total = New System.Windows.Forms.ColumnHeader
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_comprobante = New System.Windows.Forms.Button
        Me.lbl_total = New System.Windows.Forms.Label
        Me.lbl_total_venta = New System.Windows.Forms.Label
        Me.grp_cliente = New System.Windows.Forms.GroupBox
        Me.txt_comprobante = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_numero_dni = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_celular = New System.Windows.Forms.TextBox
        Me.lbl_celular = New System.Windows.Forms.Label
        Me.lbl_telefono = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_localidad = New System.Windows.Forms.TextBox
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.lbl_direccion = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.txt_numero_cliente = New System.Windows.Forms.TextBox
        Me.lbl_num_cliente = New System.Windows.Forms.Label
        Me.codigo_interno = New System.Windows.Forms.ColumnHeader
        Me.grp_cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_detalle_venta
        '
        Me.lv_detalle_venta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo_producto, Me.cantidad, Me.precio_venta, Me.precio_total, Me.codigo_interno})
        Me.lv_detalle_venta.FullRowSelect = True
        Me.lv_detalle_venta.GridLines = True
        Me.lv_detalle_venta.Location = New System.Drawing.Point(12, 15)
        Me.lv_detalle_venta.MultiSelect = False
        Me.lv_detalle_venta.Name = "lv_detalle_venta"
        Me.lv_detalle_venta.Size = New System.Drawing.Size(420, 197)
        Me.lv_detalle_venta.TabIndex = 2
        Me.lv_detalle_venta.UseCompatibleStateImageBehavior = False
        Me.lv_detalle_venta.View = System.Windows.Forms.View.Details
        '
        'codigo_producto
        '
        Me.codigo_producto.Text = "Código de Producto"
        Me.codigo_producto.Width = 117
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        Me.cantidad.Width = 90
        '
        'precio_venta
        '
        Me.precio_venta.Text = "Precio de Venta"
        Me.precio_venta.Width = 117
        '
        'precio_total
        '
        Me.precio_total.Text = "Precio Total"
        Me.precio_total.Width = 89
        '
        'btn_salir
        '
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_salir.Location = New System.Drawing.Point(12, 245)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(85, 21)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_comprobante
        '
        Me.btn_comprobante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_comprobante.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_comprobante.Location = New System.Drawing.Point(12, 218)
        Me.btn_comprobante.Name = "btn_comprobante"
        Me.btn_comprobante.Size = New System.Drawing.Size(85, 21)
        Me.btn_comprobante.TabIndex = 0
        Me.btn_comprobante.Text = "&Comprobante"
        Me.btn_comprobante.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_total.Location = New System.Drawing.Point(202, 215)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(113, 31)
        Me.lbl_total.TabIndex = 7
        Me.lbl_total.Text = "Total: $"
        '
        'lbl_total_venta
        '
        Me.lbl_total_venta.AutoSize = True
        Me.lbl_total_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_venta.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_total_venta.Location = New System.Drawing.Point(321, 215)
        Me.lbl_total_venta.Name = "lbl_total_venta"
        Me.lbl_total_venta.Size = New System.Drawing.Size(30, 31)
        Me.lbl_total_venta.TabIndex = 8
        Me.lbl_total_venta.Text = "0"
        Me.lbl_total_venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grp_cliente
        '
        Me.grp_cliente.Controls.Add(Me.txt_comprobante)
        Me.grp_cliente.Controls.Add(Me.Label2)
        Me.grp_cliente.Controls.Add(Me.txt_numero_dni)
        Me.grp_cliente.Controls.Add(Me.Label1)
        Me.grp_cliente.Controls.Add(Me.txt_telefono)
        Me.grp_cliente.Controls.Add(Me.txt_email)
        Me.grp_cliente.Controls.Add(Me.txt_celular)
        Me.grp_cliente.Controls.Add(Me.lbl_celular)
        Me.grp_cliente.Controls.Add(Me.lbl_telefono)
        Me.grp_cliente.Controls.Add(Me.lbl_email)
        Me.grp_cliente.Controls.Add(Me.txt_direccion)
        Me.grp_cliente.Controls.Add(Me.txt_nombre)
        Me.grp_cliente.Controls.Add(Me.txt_localidad)
        Me.grp_cliente.Controls.Add(Me.lbl_localidad)
        Me.grp_cliente.Controls.Add(Me.lbl_direccion)
        Me.grp_cliente.Controls.Add(Me.lbl_nombre)
        Me.grp_cliente.Controls.Add(Me.txt_numero_cliente)
        Me.grp_cliente.Controls.Add(Me.lbl_num_cliente)
        Me.grp_cliente.Enabled = False
        Me.grp_cliente.Location = New System.Drawing.Point(438, 12)
        Me.grp_cliente.Name = "grp_cliente"
        Me.grp_cliente.Size = New System.Drawing.Size(365, 248)
        Me.grp_cliente.TabIndex = 27
        Me.grp_cliente.TabStop = False
        Me.grp_cliente.Text = "Cliente"
        '
        'txt_comprobante
        '
        Me.txt_comprobante.Enabled = False
        Me.txt_comprobante.Location = New System.Drawing.Point(249, 23)
        Me.txt_comprobante.MaxLength = 7
        Me.txt_comprobante.Name = "txt_comprobante"
        Me.txt_comprobante.Size = New System.Drawing.Size(107, 20)
        Me.txt_comprobante.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nro. Comprobante:"
        '
        'txt_numero_dni
        '
        Me.txt_numero_dni.Enabled = False
        Me.txt_numero_dni.Location = New System.Drawing.Point(108, 74)
        Me.txt_numero_dni.MaxLength = 7
        Me.txt_numero_dni.Name = "txt_numero_dni"
        Me.txt_numero_dni.Size = New System.Drawing.Size(103, 20)
        Me.txt_numero_dni.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "D.N.I:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(108, 156)
        Me.txt_telefono.MaxLength = 7
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(103, 20)
        Me.txt_telefono.TabIndex = 25
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(108, 208)
        Me.txt_email.MaxLength = 7
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(248, 20)
        Me.txt_email.TabIndex = 24
        '
        'txt_celular
        '
        Me.txt_celular.Enabled = False
        Me.txt_celular.Location = New System.Drawing.Point(108, 182)
        Me.txt_celular.MaxLength = 7
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(103, 20)
        Me.txt_celular.TabIndex = 23
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(59, 187)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(42, 13)
        Me.lbl_celular.TabIndex = 22
        Me.lbl_celular.Text = "Celular:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(50, 159)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 21
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(65, 211)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(37, 13)
        Me.lbl_email.TabIndex = 20
        Me.lbl_email.Text = "e-mail:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Location = New System.Drawing.Point(108, 102)
        Me.txt_direccion.MaxLength = 7
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(159, 20)
        Me.txt_direccion.TabIndex = 19
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(108, 49)
        Me.txt_nombre.MaxLength = 7
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(159, 20)
        Me.txt_nombre.TabIndex = 18
        '
        'txt_localidad
        '
        Me.txt_localidad.Enabled = False
        Me.txt_localidad.Location = New System.Drawing.Point(108, 130)
        Me.txt_localidad.MaxLength = 7
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(159, 20)
        Me.txt_localidad.TabIndex = 17
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(47, 133)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 16
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(47, 106)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(55, 13)
        Me.lbl_direccion.TabIndex = 14
        Me.lbl_direccion.Text = "Dirección:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(7, 55)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(95, 13)
        Me.lbl_nombre.TabIndex = 12
        Me.lbl_nombre.Text = "Nombre y Apellido:"
        '
        'txt_numero_cliente
        '
        Me.txt_numero_cliente.Location = New System.Drawing.Point(108, 23)
        Me.txt_numero_cliente.MaxLength = 7
        Me.txt_numero_cliente.Name = "txt_numero_cliente"
        Me.txt_numero_cliente.Size = New System.Drawing.Size(29, 20)
        Me.txt_numero_cliente.TabIndex = 11
        '
        'lbl_num_cliente
        '
        Me.lbl_num_cliente.AutoSize = True
        Me.lbl_num_cliente.Location = New System.Drawing.Point(6, 26)
        Me.lbl_num_cliente.Name = "lbl_num_cliente"
        Me.lbl_num_cliente.Size = New System.Drawing.Size(96, 13)
        Me.lbl_num_cliente.TabIndex = 10
        Me.lbl_num_cliente.Text = "Numero de cliente:"
        '
        'codigo_interno
        '
        Me.codigo_interno.Text = "codigo_interno"
        '
        'DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 274)
        Me.Controls.Add(Me.grp_cliente)
        Me.Controls.Add(Me.lbl_total_venta)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_comprobante)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lv_detalle_venta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DetalleVenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grp_cliente.ResumeLayout(False)
        Me.grp_cliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_detalle_venta As System.Windows.Forms.ListView
    Friend WithEvents codigo_producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents precio_venta As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_comprobante As System.Windows.Forms.Button
    Friend WithEvents precio_total As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total_venta As System.Windows.Forms.Label
    Friend WithEvents grp_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents lbl_celular As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_numero_cliente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_num_cliente As System.Windows.Forms.Label
    Friend WithEvents txt_comprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codigo_interno As System.Windows.Forms.ColumnHeader
End Class
