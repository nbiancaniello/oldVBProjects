<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.lv_ventas = New System.Windows.Forms.ListView
        Me.num_factura = New System.Windows.Forms.ColumnHeader
        Me.fecha_venta = New System.Windows.Forms.ColumnHeader
        Me.tipo_pago = New System.Windows.Forms.ColumnHeader
        Me.empresa = New System.Windows.Forms.ColumnHeader
        Me.cuotas = New System.Windows.Forms.ColumnHeader
        Me.estado = New System.Windows.Forms.ColumnHeader
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.btn_anular = New System.Windows.Forms.Button
        Me.btn_filtro = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_ver_todo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lv_ventas
        '
        Me.lv_ventas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.num_factura, Me.fecha_venta, Me.tipo_pago, Me.empresa, Me.cuotas, Me.estado})
        Me.lv_ventas.FullRowSelect = True
        Me.lv_ventas.GridLines = True
        Me.lv_ventas.HideSelection = False
        Me.lv_ventas.Location = New System.Drawing.Point(12, 12)
        Me.lv_ventas.MultiSelect = False
        Me.lv_ventas.Name = "lv_ventas"
        Me.lv_ventas.Size = New System.Drawing.Size(620, 328)
        Me.lv_ventas.TabIndex = 0
        Me.lv_ventas.UseCompatibleStateImageBehavior = False
        Me.lv_ventas.View = System.Windows.Forms.View.Details
        '
        'num_factura
        '
        Me.num_factura.Text = "Numero de Factura"
        Me.num_factura.Width = 103
        '
        'fecha_venta
        '
        Me.fecha_venta.Text = "Fecha de Venta"
        Me.fecha_venta.Width = 122
        '
        'tipo_pago
        '
        Me.tipo_pago.Text = "Tipo de Pago"
        Me.tipo_pago.Width = 135
        '
        'empresa
        '
        Me.empresa.Text = "Empresa"
        '
        'cuotas
        '
        Me.cuotas.Text = "Número de cuotas"
        Me.cuotas.Width = 112
        '
        'estado
        '
        Me.estado.Text = "Estado"
        Me.estado.Width = 84
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_agregar.Location = New System.Drawing.Point(12, 346)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(57, 23)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "&Vender"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_anular
        '
        Me.btn_anular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_anular.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_anular.Location = New System.Drawing.Point(75, 346)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(57, 23)
        Me.btn_anular.TabIndex = 4
        Me.btn_anular.Text = "&Anular"
        Me.btn_anular.UseVisualStyleBackColor = True
        '
        'btn_filtro
        '
        Me.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_filtro.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_filtro.Location = New System.Drawing.Point(512, 346)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Size = New System.Drawing.Size(57, 23)
        Me.btn_filtro.TabIndex = 1
        Me.btn_filtro.Text = "&Filtro"
        Me.btn_filtro.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_salir.Location = New System.Drawing.Point(575, 346)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(57, 23)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_ver_todo
        '
        Me.btn_ver_todo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ver_todo.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_ver_todo.Location = New System.Drawing.Point(435, 346)
        Me.btn_ver_todo.Name = "btn_ver_todo"
        Me.btn_ver_todo.Size = New System.Drawing.Size(71, 23)
        Me.btn_ver_todo.TabIndex = 5
        Me.btn_ver_todo.Text = "Ver &Todo"
        Me.btn_ver_todo.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 390)
        Me.Controls.Add(Me.btn_ver_todo)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_filtro)
        Me.Controls.Add(Me.btn_anular)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lv_ventas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ventas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_ventas As System.Windows.Forms.ListView
    Friend WithEvents num_factura As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecha_venta As System.Windows.Forms.ColumnHeader
    Friend WithEvents tipo_pago As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents btn_filtro As System.Windows.Forms.Button
    Friend WithEvents empresa As System.Windows.Forms.ColumnHeader
    Friend WithEvents cuotas As System.Windows.Forms.ColumnHeader
    Friend WithEvents estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_ver_todo As System.Windows.Forms.Button
End Class
