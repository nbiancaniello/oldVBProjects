<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVenta
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
        Me.lbl_codigo = New System.Windows.Forms.Label
        Me.txt_cod_anio = New System.Windows.Forms.TextBox
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.lbl_cantidad = New System.Windows.Forms.Label
        Me.txt_marca = New System.Windows.Forms.TextBox
        Me.lbl_marca = New System.Windows.Forms.Label
        Me.txt_modelo = New System.Windows.Forms.TextBox
        Me.lbl_modelo = New System.Windows.Forms.Label
        Me.txt_rubro = New System.Windows.Forms.TextBox
        Me.lbl_rubro = New System.Windows.Forms.Label
        Me.txt_stock = New System.Windows.Forms.TextBox
        Me.lbl_stock = New System.Windows.Forms.Label
        Me.btn_lista = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_borrar = New System.Windows.Forms.Button
        Me.txt_detalle = New System.Windows.Forms.TextBox
        Me.lb_detalle = New System.Windows.Forms.Label
        Me.txt_talle = New System.Windows.Forms.TextBox
        Me.lbl_talle = New System.Windows.Forms.Label
        Me.txt_cod_rubro = New System.Windows.Forms.TextBox
        Me.txt_cod_modelo = New System.Windows.Forms.TextBox
        Me.btn_traer = New System.Windows.Forms.Button
        Me.lv_productos = New System.Windows.Forms.ListView
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.marca = New System.Windows.Forms.ColumnHeader
        Me.rubro = New System.Windows.Forms.ColumnHeader
        Me.modelo = New System.Windows.Forms.ColumnHeader
        Me.talle = New System.Windows.Forms.ColumnHeader
        Me.detalle = New System.Windows.Forms.ColumnHeader
        Me.cantidad = New System.Windows.Forms.ColumnHeader
        Me.subtotal = New System.Windows.Forms.ColumnHeader
        Me.interno = New System.Windows.Forms.ColumnHeader
        Me.stock = New System.Windows.Forms.ColumnHeader
        Me.costo = New System.Windows.Forms.ColumnHeader
        Me.precio_venta = New System.Windows.Forms.ColumnHeader
        Me.stock_min = New System.Windows.Forms.ColumnHeader
        Me.lbl_total_venta = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.grp_factura = New System.Windows.Forms.GroupBox
        Me.btn_cancelar_venta = New System.Windows.Forms.Button
        Me.btn_concretar = New System.Windows.Forms.Button
        Me.txt_cuotas = New System.Windows.Forms.TextBox
        Me.lbl_cuotas = New System.Windows.Forms.Label
        Me.cbo_empresa = New System.Windows.Forms.ComboBox
        Me.lbl_empresa = New System.Windows.Forms.Label
        Me.cbo_tipo_pago = New System.Windows.Forms.ComboBox
        Me.lbl_tipo_pago = New System.Windows.Forms.Label
        Me.txt_numero_factura = New System.Windows.Forms.TextBox
        Me.lbl_num_fact = New System.Windows.Forms.Label
        Me.grp_cliente = New System.Windows.Forms.GroupBox
        Me.btn_traer_cliente = New System.Windows.Forms.Button
        Me.txt_numero_dni = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_agregar_cliente = New System.Windows.Forms.Button
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
        Me.grp_detalle = New System.Windows.Forms.GroupBox
        Me.btn_eliminar_producto = New System.Windows.Forms.Button
        Me.btn_agregar_producto = New System.Windows.Forms.Button
        Me.txt_stock_min = New System.Windows.Forms.TextBox
        Me.txt_cod_interno = New System.Windows.Forms.TextBox
        Me.txt_costo = New System.Windows.Forms.TextBox
        Me.txt_precio_unitario = New System.Windows.Forms.TextBox
        Me.grp_factura.SuspendLayout()
        Me.grp_cliente.SuspendLayout()
        Me.grp_detalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo.Location = New System.Drawing.Point(65, 22)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_codigo.TabIndex = 0
        Me.lbl_codigo.Text = "Código:"
        '
        'txt_cod_anio
        '
        Me.txt_cod_anio.Location = New System.Drawing.Point(114, 19)
        Me.txt_cod_anio.MaxLength = 3
        Me.txt_cod_anio.Name = "txt_cod_anio"
        Me.txt_cod_anio.Size = New System.Drawing.Size(32, 20)
        Me.txt_cod_anio.TabIndex = 0
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(475, 19)
        Me.txt_cantidad.MaxLength = 3
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(32, 20)
        Me.txt_cantidad.TabIndex = 4
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_cantidad.Location = New System.Drawing.Point(417, 22)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(52, 13)
        Me.lbl_cantidad.TabIndex = 2
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'txt_marca
        '
        Me.txt_marca.Enabled = False
        Me.txt_marca.Location = New System.Drawing.Point(76, 55)
        Me.txt_marca.MaxLength = 7
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(146, 20)
        Me.txt_marca.TabIndex = 5
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_marca.Location = New System.Drawing.Point(30, 58)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(40, 13)
        Me.lbl_marca.TabIndex = 4
        Me.lbl_marca.Text = "Marca:"
        '
        'txt_modelo
        '
        Me.txt_modelo.Enabled = False
        Me.txt_modelo.Location = New System.Drawing.Point(76, 81)
        Me.txt_modelo.MaxLength = 7
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(146, 20)
        Me.txt_modelo.TabIndex = 9
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_modelo.Location = New System.Drawing.Point(25, 84)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_modelo.TabIndex = 8
        Me.lbl_modelo.Text = "Modelo:"
        '
        'txt_rubro
        '
        Me.txt_rubro.Enabled = False
        Me.txt_rubro.Location = New System.Drawing.Point(279, 55)
        Me.txt_rubro.MaxLength = 7
        Me.txt_rubro.Name = "txt_rubro"
        Me.txt_rubro.Size = New System.Drawing.Size(146, 20)
        Me.txt_rubro.TabIndex = 7
        '
        'lbl_rubro
        '
        Me.lbl_rubro.AutoSize = True
        Me.lbl_rubro.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_rubro.Location = New System.Drawing.Point(232, 58)
        Me.lbl_rubro.Name = "lbl_rubro"
        Me.lbl_rubro.Size = New System.Drawing.Size(39, 13)
        Me.lbl_rubro.TabIndex = 6
        Me.lbl_rubro.Text = "Rubro:"
        '
        'txt_stock
        '
        Me.txt_stock.Enabled = False
        Me.txt_stock.Location = New System.Drawing.Point(475, 81)
        Me.txt_stock.MaxLength = 7
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(32, 20)
        Me.txt_stock.TabIndex = 11
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_stock.Location = New System.Drawing.Point(431, 84)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(38, 13)
        Me.lbl_stock.TabIndex = 10
        Me.lbl_stock.Text = "Stock:"
        '
        'btn_lista
        '
        Me.btn_lista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_lista.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_lista.Location = New System.Drawing.Point(704, 70)
        Me.btn_lista.Name = "btn_lista"
        Me.btn_lista.Size = New System.Drawing.Size(65, 22)
        Me.btn_lista.TabIndex = 9
        Me.btn_lista.Text = "&Lista"
        Me.btn_lista.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_aceptar.Location = New System.Drawing.Point(704, 13)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(65, 22)
        Me.btn_aceptar.TabIndex = 7
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_borrar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_borrar.Location = New System.Drawing.Point(704, 41)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(65, 23)
        Me.btn_borrar.TabIndex = 8
        Me.btn_borrar.Text = "&Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'txt_detalle
        '
        Me.txt_detalle.Enabled = False
        Me.txt_detalle.Location = New System.Drawing.Point(279, 81)
        Me.txt_detalle.MaxLength = 7
        Me.txt_detalle.Name = "txt_detalle"
        Me.txt_detalle.Size = New System.Drawing.Size(146, 20)
        Me.txt_detalle.TabIndex = 16
        '
        'lb_detalle
        '
        Me.lb_detalle.AutoSize = True
        Me.lb_detalle.ForeColor = System.Drawing.Color.Firebrick
        Me.lb_detalle.Location = New System.Drawing.Point(228, 84)
        Me.lb_detalle.Name = "lb_detalle"
        Me.lb_detalle.Size = New System.Drawing.Size(43, 13)
        Me.lb_detalle.TabIndex = 15
        Me.lb_detalle.Text = "Detalle:"
        '
        'txt_talle
        '
        Me.txt_talle.Enabled = False
        Me.txt_talle.Location = New System.Drawing.Point(475, 55)
        Me.txt_talle.MaxLength = 7
        Me.txt_talle.Name = "txt_talle"
        Me.txt_talle.Size = New System.Drawing.Size(32, 20)
        Me.txt_talle.TabIndex = 18
        '
        'lbl_talle
        '
        Me.lbl_talle.AutoSize = True
        Me.lbl_talle.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_talle.Location = New System.Drawing.Point(436, 58)
        Me.lbl_talle.Name = "lbl_talle"
        Me.lbl_talle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_talle.TabIndex = 17
        Me.lbl_talle.Text = "Talle:"
        '
        'txt_cod_rubro
        '
        Me.txt_cod_rubro.Location = New System.Drawing.Point(152, 19)
        Me.txt_cod_rubro.MaxLength = 3
        Me.txt_cod_rubro.Name = "txt_cod_rubro"
        Me.txt_cod_rubro.Size = New System.Drawing.Size(32, 20)
        Me.txt_cod_rubro.TabIndex = 1
        '
        'txt_cod_modelo
        '
        Me.txt_cod_modelo.Location = New System.Drawing.Point(190, 19)
        Me.txt_cod_modelo.MaxLength = 3
        Me.txt_cod_modelo.Name = "txt_cod_modelo"
        Me.txt_cod_modelo.Size = New System.Drawing.Size(32, 20)
        Me.txt_cod_modelo.TabIndex = 2
        '
        'btn_traer
        '
        Me.btn_traer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_traer.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_traer.Location = New System.Drawing.Point(235, 17)
        Me.btn_traer.Name = "btn_traer"
        Me.btn_traer.Size = New System.Drawing.Size(53, 22)
        Me.btn_traer.TabIndex = 3
        Me.btn_traer.Text = "&Traer"
        Me.btn_traer.UseVisualStyleBackColor = True
        '
        'lv_productos
        '
        Me.lv_productos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.marca, Me.rubro, Me.modelo, Me.talle, Me.detalle, Me.cantidad, Me.subtotal, Me.interno, Me.stock, Me.costo, Me.precio_venta, Me.stock_min})
        Me.lv_productos.FullRowSelect = True
        Me.lv_productos.GridLines = True
        Me.lv_productos.Location = New System.Drawing.Point(9, 119)
        Me.lv_productos.MultiSelect = False
        Me.lv_productos.Name = "lv_productos"
        Me.lv_productos.Size = New System.Drawing.Size(760, 233)
        Me.lv_productos.TabIndex = 10
        Me.lv_productos.UseCompatibleStateImageBehavior = False
        Me.lv_productos.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Código"
        Me.codigo.Width = 52
        '
        'marca
        '
        Me.marca.Text = "Marca"
        Me.marca.Width = 121
        '
        'rubro
        '
        Me.rubro.Text = "Rubro"
        Me.rubro.Width = 87
        '
        'modelo
        '
        Me.modelo.Text = "Modelo"
        Me.modelo.Width = 108
        '
        'talle
        '
        Me.talle.Text = "Talle"
        Me.talle.Width = 37
        '
        'detalle
        '
        Me.detalle.Text = "Detalle"
        Me.detalle.Width = 199
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        '
        'subtotal
        '
        Me.subtotal.Text = "Subtotal"
        Me.subtotal.Width = 90
        '
        'interno
        '
        Me.interno.Text = "interno"
        '
        'lbl_total_venta
        '
        Me.lbl_total_venta.AutoSize = True
        Me.lbl_total_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_venta.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_total_venta.Location = New System.Drawing.Point(664, 355)
        Me.lbl_total_venta.Name = "lbl_total_venta"
        Me.lbl_total_venta.Size = New System.Drawing.Size(30, 31)
        Me.lbl_total_venta.TabIndex = 24
        Me.lbl_total_venta.Text = "0"
        Me.lbl_total_venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_total.Location = New System.Drawing.Point(545, 355)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(113, 31)
        Me.lbl_total.TabIndex = 23
        Me.lbl_total.Text = "Total: $"
        '
        'grp_factura
        '
        Me.grp_factura.Controls.Add(Me.btn_cancelar_venta)
        Me.grp_factura.Controls.Add(Me.btn_concretar)
        Me.grp_factura.Controls.Add(Me.txt_cuotas)
        Me.grp_factura.Controls.Add(Me.lbl_cuotas)
        Me.grp_factura.Controls.Add(Me.cbo_empresa)
        Me.grp_factura.Controls.Add(Me.lbl_empresa)
        Me.grp_factura.Controls.Add(Me.cbo_tipo_pago)
        Me.grp_factura.Controls.Add(Me.lbl_tipo_pago)
        Me.grp_factura.Controls.Add(Me.txt_numero_factura)
        Me.grp_factura.Controls.Add(Me.lbl_num_fact)
        Me.grp_factura.Location = New System.Drawing.Point(12, 12)
        Me.grp_factura.Name = "grp_factura"
        Me.grp_factura.Size = New System.Drawing.Size(278, 145)
        Me.grp_factura.TabIndex = 25
        Me.grp_factura.TabStop = False
        Me.grp_factura.Text = "Factura"
        '
        'btn_cancelar_venta
        '
        Me.btn_cancelar_venta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar_venta.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_cancelar_venta.Location = New System.Drawing.Point(207, 106)
        Me.btn_cancelar_venta.Name = "btn_cancelar_venta"
        Me.btn_cancelar_venta.Size = New System.Drawing.Size(62, 22)
        Me.btn_cancelar_venta.TabIndex = 4
        Me.btn_cancelar_venta.Text = "Ca&ncelar"
        Me.btn_cancelar_venta.UseVisualStyleBackColor = True
        '
        'btn_concretar
        '
        Me.btn_concretar.Enabled = False
        Me.btn_concretar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_concretar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_concretar.Location = New System.Drawing.Point(139, 106)
        Me.btn_concretar.Name = "btn_concretar"
        Me.btn_concretar.Size = New System.Drawing.Size(62, 22)
        Me.btn_concretar.TabIndex = 3
        Me.btn_concretar.Text = "&Concretar"
        Me.btn_concretar.UseVisualStyleBackColor = True
        '
        'txt_cuotas
        '
        Me.txt_cuotas.Enabled = False
        Me.txt_cuotas.Location = New System.Drawing.Point(110, 106)
        Me.txt_cuotas.MaxLength = 2
        Me.txt_cuotas.Name = "txt_cuotas"
        Me.txt_cuotas.Size = New System.Drawing.Size(23, 20)
        Me.txt_cuotas.TabIndex = 2
        '
        'lbl_cuotas
        '
        Me.lbl_cuotas.AutoSize = True
        Me.lbl_cuotas.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_cuotas.Location = New System.Drawing.Point(61, 109)
        Me.lbl_cuotas.Name = "lbl_cuotas"
        Me.lbl_cuotas.Size = New System.Drawing.Size(43, 13)
        Me.lbl_cuotas.TabIndex = 16
        Me.lbl_cuotas.Text = "Cuotas:"
        '
        'cbo_empresa
        '
        Me.cbo_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_empresa.Enabled = False
        Me.cbo_empresa.FormattingEnabled = True
        Me.cbo_empresa.Items.AddRange(New Object() {"Contado", "MasterCard", "American Express", "Maestro", "Visa"})
        Me.cbo_empresa.Location = New System.Drawing.Point(110, 78)
        Me.cbo_empresa.Name = "cbo_empresa"
        Me.cbo_empresa.Size = New System.Drawing.Size(109, 21)
        Me.cbo_empresa.TabIndex = 1
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_empresa.Location = New System.Drawing.Point(53, 82)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(51, 13)
        Me.lbl_empresa.TabIndex = 14
        Me.lbl_empresa.Text = "Empresa:"
        '
        'cbo_tipo_pago
        '
        Me.cbo_tipo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_pago.Enabled = False
        Me.cbo_tipo_pago.FormattingEnabled = True
        Me.cbo_tipo_pago.Items.AddRange(New Object() {"Contado", "T. Crédito", "T. Débito"})
        Me.cbo_tipo_pago.Location = New System.Drawing.Point(110, 52)
        Me.cbo_tipo_pago.Name = "cbo_tipo_pago"
        Me.cbo_tipo_pago.Size = New System.Drawing.Size(109, 21)
        Me.cbo_tipo_pago.TabIndex = 0
        '
        'lbl_tipo_pago
        '
        Me.lbl_tipo_pago.AutoSize = True
        Me.lbl_tipo_pago.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_tipo_pago.Location = New System.Drawing.Point(31, 54)
        Me.lbl_tipo_pago.Name = "lbl_tipo_pago"
        Me.lbl_tipo_pago.Size = New System.Drawing.Size(73, 13)
        Me.lbl_tipo_pago.TabIndex = 12
        Me.lbl_tipo_pago.Text = "Tipo de pago:"
        '
        'txt_numero_factura
        '
        Me.txt_numero_factura.Enabled = False
        Me.txt_numero_factura.Location = New System.Drawing.Point(110, 23)
        Me.txt_numero_factura.MaxLength = 7
        Me.txt_numero_factura.Name = "txt_numero_factura"
        Me.txt_numero_factura.Size = New System.Drawing.Size(109, 20)
        Me.txt_numero_factura.TabIndex = 6
        '
        'lbl_num_fact
        '
        Me.lbl_num_fact.AutoSize = True
        Me.lbl_num_fact.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_num_fact.Location = New System.Drawing.Point(6, 26)
        Me.lbl_num_fact.Name = "lbl_num_fact"
        Me.lbl_num_fact.Size = New System.Drawing.Size(98, 13)
        Me.lbl_num_fact.TabIndex = 10
        Me.lbl_num_fact.Text = "Numero de factura:"
        '
        'grp_cliente
        '
        Me.grp_cliente.Controls.Add(Me.btn_traer_cliente)
        Me.grp_cliente.Controls.Add(Me.txt_numero_dni)
        Me.grp_cliente.Controls.Add(Me.Label1)
        Me.grp_cliente.Controls.Add(Me.btn_agregar_cliente)
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
        Me.grp_cliente.Location = New System.Drawing.Point(296, 12)
        Me.grp_cliente.Name = "grp_cliente"
        Me.grp_cliente.Size = New System.Drawing.Size(499, 145)
        Me.grp_cliente.TabIndex = 26
        Me.grp_cliente.TabStop = False
        Me.grp_cliente.Text = "Cliente"
        '
        'btn_traer_cliente
        '
        Me.btn_traer_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_traer_cliente.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_traer_cliente.Location = New System.Drawing.Point(440, 50)
        Me.btn_traer_cliente.Name = "btn_traer_cliente"
        Me.btn_traer_cliente.Size = New System.Drawing.Size(53, 22)
        Me.btn_traer_cliente.TabIndex = 2
        Me.btn_traer_cliente.Text = "&Traer"
        Me.btn_traer_cliente.UseVisualStyleBackColor = True
        '
        'txt_numero_dni
        '
        Me.txt_numero_dni.Enabled = False
        Me.txt_numero_dni.Location = New System.Drawing.Point(331, 49)
        Me.txt_numero_dni.MaxLength = 7
        Me.txt_numero_dni.Name = "txt_numero_dni"
        Me.txt_numero_dni.Size = New System.Drawing.Size(103, 20)
        Me.txt_numero_dni.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "D.N.I:"
        '
        'btn_agregar_cliente
        '
        Me.btn_agregar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar_cliente.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_agregar_cliente.Location = New System.Drawing.Point(440, 21)
        Me.btn_agregar_cliente.Name = "btn_agregar_cliente"
        Me.btn_agregar_cliente.Size = New System.Drawing.Size(53, 22)
        Me.btn_agregar_cliente.TabIndex = 26
        Me.btn_agregar_cliente.Text = "&Agregar"
        Me.btn_agregar_cliente.UseVisualStyleBackColor = True
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(331, 78)
        Me.txt_telefono.MaxLength = 7
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(103, 20)
        Me.txt_telefono.TabIndex = 25
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(186, 23)
        Me.txt_email.MaxLength = 7
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(248, 20)
        Me.txt_email.TabIndex = 24
        '
        'txt_celular
        '
        Me.txt_celular.Enabled = False
        Me.txt_celular.Location = New System.Drawing.Point(331, 104)
        Me.txt_celular.MaxLength = 7
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(103, 20)
        Me.txt_celular.TabIndex = 23
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(282, 109)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(42, 13)
        Me.lbl_celular.TabIndex = 22
        Me.lbl_celular.Text = "Celular:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(273, 81)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 21
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(143, 26)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(37, 13)
        Me.lbl_email.TabIndex = 1
        Me.lbl_email.Text = "e-mail:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Location = New System.Drawing.Point(108, 78)
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
        Me.txt_localidad.Location = New System.Drawing.Point(108, 106)
        Me.txt_localidad.MaxLength = 7
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(159, 20)
        Me.txt_localidad.TabIndex = 17
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(47, 109)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 16
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(47, 82)
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
        Me.txt_numero_cliente.TabIndex = 0
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
        'grp_detalle
        '
        Me.grp_detalle.Controls.Add(Me.btn_eliminar_producto)
        Me.grp_detalle.Controls.Add(Me.btn_agregar_producto)
        Me.grp_detalle.Controls.Add(Me.lv_productos)
        Me.grp_detalle.Controls.Add(Me.lbl_codigo)
        Me.grp_detalle.Controls.Add(Me.txt_cod_anio)
        Me.grp_detalle.Controls.Add(Me.lbl_total_venta)
        Me.grp_detalle.Controls.Add(Me.lbl_cantidad)
        Me.grp_detalle.Controls.Add(Me.lbl_total)
        Me.grp_detalle.Controls.Add(Me.txt_cantidad)
        Me.grp_detalle.Controls.Add(Me.lbl_marca)
        Me.grp_detalle.Controls.Add(Me.btn_traer)
        Me.grp_detalle.Controls.Add(Me.txt_marca)
        Me.grp_detalle.Controls.Add(Me.txt_cod_modelo)
        Me.grp_detalle.Controls.Add(Me.lbl_rubro)
        Me.grp_detalle.Controls.Add(Me.txt_cod_rubro)
        Me.grp_detalle.Controls.Add(Me.txt_rubro)
        Me.grp_detalle.Controls.Add(Me.txt_talle)
        Me.grp_detalle.Controls.Add(Me.lbl_modelo)
        Me.grp_detalle.Controls.Add(Me.txt_modelo)
        Me.grp_detalle.Controls.Add(Me.lbl_talle)
        Me.grp_detalle.Controls.Add(Me.lbl_stock)
        Me.grp_detalle.Controls.Add(Me.txt_detalle)
        Me.grp_detalle.Controls.Add(Me.txt_stock)
        Me.grp_detalle.Controls.Add(Me.lb_detalle)
        Me.grp_detalle.Controls.Add(Me.btn_lista)
        Me.grp_detalle.Controls.Add(Me.btn_borrar)
        Me.grp_detalle.Controls.Add(Me.btn_aceptar)
        Me.grp_detalle.Location = New System.Drawing.Point(12, 169)
        Me.grp_detalle.Name = "grp_detalle"
        Me.grp_detalle.Size = New System.Drawing.Size(783, 395)
        Me.grp_detalle.TabIndex = 27
        Me.grp_detalle.TabStop = False
        Me.grp_detalle.Text = "Detalle de Factura:"
        '
        'btn_eliminar_producto
        '
        Me.btn_eliminar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar_producto.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_eliminar_producto.Location = New System.Drawing.Point(572, 17)
        Me.btn_eliminar_producto.Name = "btn_eliminar_producto"
        Me.btn_eliminar_producto.Size = New System.Drawing.Size(53, 22)
        Me.btn_eliminar_producto.TabIndex = 6
        Me.btn_eliminar_producto.Text = "&Eliminar:"
        Me.btn_eliminar_producto.UseVisualStyleBackColor = True
        '
        'btn_agregar_producto
        '
        Me.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar_producto.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_agregar_producto.Location = New System.Drawing.Point(513, 17)
        Me.btn_agregar_producto.Name = "btn_agregar_producto"
        Me.btn_agregar_producto.Size = New System.Drawing.Size(53, 22)
        Me.btn_agregar_producto.TabIndex = 5
        Me.btn_agregar_producto.Text = "A&gregar:"
        Me.btn_agregar_producto.UseVisualStyleBackColor = True
        '
        'txt_stock_min
        '
        Me.txt_stock_min.Location = New System.Drawing.Point(833, 184)
        Me.txt_stock_min.Name = "txt_stock_min"
        Me.txt_stock_min.Size = New System.Drawing.Size(13, 20)
        Me.txt_stock_min.TabIndex = 33
        Me.txt_stock_min.Visible = False
        '
        'txt_cod_interno
        '
        Me.txt_cod_interno.Location = New System.Drawing.Point(834, 211)
        Me.txt_cod_interno.Name = "txt_cod_interno"
        Me.txt_cod_interno.Size = New System.Drawing.Size(12, 20)
        Me.txt_cod_interno.TabIndex = 32
        Me.txt_cod_interno.Visible = False
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(834, 234)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(12, 20)
        Me.txt_costo.TabIndex = 31
        Me.txt_costo.Visible = False
        '
        'txt_precio_unitario
        '
        Me.txt_precio_unitario.Location = New System.Drawing.Point(833, 260)
        Me.txt_precio_unitario.Name = "txt_precio_unitario"
        Me.txt_precio_unitario.Size = New System.Drawing.Size(13, 20)
        Me.txt_precio_unitario.TabIndex = 29
        Me.txt_precio_unitario.Visible = False
        '
        'RegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar_venta
        Me.ClientSize = New System.Drawing.Size(806, 573)
        Me.Controls.Add(Me.txt_cod_interno)
        Me.Controls.Add(Me.txt_costo)
        Me.Controls.Add(Me.txt_stock_min)
        Me.Controls.Add(Me.txt_precio_unitario)
        Me.Controls.Add(Me.grp_detalle)
        Me.Controls.Add(Me.grp_cliente)
        Me.Controls.Add(Me.grp_factura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrarVenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarVenta"
        Me.grp_factura.ResumeLayout(False)
        Me.grp_factura.PerformLayout()
        Me.grp_cliente.ResumeLayout(False)
        Me.grp_cliente.PerformLayout()
        Me.grp_detalle.ResumeLayout(False)
        Me.grp_detalle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents txt_cod_anio As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents txt_rubro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rubro As System.Windows.Forms.Label
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents btn_lista As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents txt_detalle As System.Windows.Forms.TextBox
    Friend WithEvents lb_detalle As System.Windows.Forms.Label
    Friend WithEvents txt_talle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_talle As System.Windows.Forms.Label
    Friend WithEvents txt_cod_rubro As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_modelo As System.Windows.Forms.TextBox
    Friend WithEvents btn_traer As System.Windows.Forms.Button
    Friend WithEvents lv_productos As System.Windows.Forms.ListView
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents marca As System.Windows.Forms.ColumnHeader
    Friend WithEvents rubro As System.Windows.Forms.ColumnHeader
    Friend WithEvents modelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents talle As System.Windows.Forms.ColumnHeader
    Friend WithEvents detalle As System.Windows.Forms.ColumnHeader
    Friend WithEvents subtotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents interno As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_total_venta As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents grp_factura As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_tipo_pago As System.Windows.Forms.Label
    Friend WithEvents txt_numero_factura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_num_fact As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents txt_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuotas As System.Windows.Forms.Label
    Friend WithEvents grp_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_numero_cliente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_num_cliente As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents grp_detalle As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents lbl_celular As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents btn_concretar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar_venta As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_producto As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_producto As System.Windows.Forms.Button
    Friend WithEvents cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_precio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents txt_costo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_interno As System.Windows.Forms.TextBox
    Friend WithEvents stock As System.Windows.Forms.ColumnHeader
    Friend WithEvents costo As System.Windows.Forms.ColumnHeader
    Friend WithEvents precio_venta As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_numero_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_traer_cliente As System.Windows.Forms.Button
    Friend WithEvents stock_min As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_stock_min As System.Windows.Forms.TextBox
End Class
