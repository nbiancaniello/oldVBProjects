<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.lv_productos = New System.Windows.Forms.ListView
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.marca = New System.Windows.Forms.ColumnHeader
        Me.rubro = New System.Windows.Forms.ColumnHeader
        Me.modelo = New System.Windows.Forms.ColumnHeader
        Me.talle = New System.Windows.Forms.ColumnHeader
        Me.detalle = New System.Windows.Forms.ColumnHeader
        Me.costo = New System.Windows.Forms.ColumnHeader
        Me.precio_unitario = New System.Windows.Forms.ColumnHeader
        Me.stock_actual = New System.Windows.Forms.ColumnHeader
        Me.stock_minimo = New System.Windows.Forms.ColumnHeader
        Me.interno = New System.Windows.Forms.ColumnHeader
        Me.btn_filtro = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_ver_todo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lv_productos
        '
        Me.lv_productos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.marca, Me.rubro, Me.modelo, Me.talle, Me.detalle, Me.costo, Me.precio_unitario, Me.stock_actual, Me.stock_minimo, Me.interno})
        Me.lv_productos.FullRowSelect = True
        Me.lv_productos.GridLines = True
        Me.lv_productos.HideSelection = False
        Me.lv_productos.Location = New System.Drawing.Point(12, 12)
        Me.lv_productos.MultiSelect = False
        Me.lv_productos.Name = "lv_productos"
        Me.lv_productos.Size = New System.Drawing.Size(910, 326)
        Me.lv_productos.TabIndex = 0
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
        'costo
        '
        Me.costo.Text = "Costo"
        Me.costo.Width = 51
        '
        'precio_unitario
        '
        Me.precio_unitario.Text = "Precio Unitario"
        Me.precio_unitario.Width = 94
        '
        'stock_actual
        '
        Me.stock_actual.Text = "Stock Actual"
        Me.stock_actual.Width = 76
        '
        'stock_minimo
        '
        Me.stock_minimo.Text = "Stock Mínimo"
        Me.stock_minimo.Width = 81
        '
        'interno
        '
        Me.interno.Text = "interno"
        '
        'btn_filtro
        '
        Me.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_filtro.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_filtro.Location = New System.Drawing.Point(788, 344)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Size = New System.Drawing.Size(64, 23)
        Me.btn_filtro.TabIndex = 1
        Me.btn_filtro.Text = "&Filtro"
        Me.btn_filtro.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_modificar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_modificar.Location = New System.Drawing.Point(152, 344)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(64, 23)
        Me.btn_modificar.TabIndex = 5
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_eliminar.Location = New System.Drawing.Point(82, 344)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(64, 23)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_agregar.Location = New System.Drawing.Point(12, 344)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(64, 23)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "&Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_salir.Location = New System.Drawing.Point(858, 344)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(64, 23)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_ver_todo
        '
        Me.btn_ver_todo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ver_todo.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_ver_todo.Location = New System.Drawing.Point(711, 344)
        Me.btn_ver_todo.Name = "btn_ver_todo"
        Me.btn_ver_todo.Size = New System.Drawing.Size(71, 23)
        Me.btn_ver_todo.TabIndex = 7
        Me.btn_ver_todo.Text = "Ver &Todo"
        Me.btn_ver_todo.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(934, 376)
        Me.Controls.Add(Me.btn_ver_todo)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_filtro)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lv_productos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Productos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_productos As System.Windows.Forms.ListView
    Friend WithEvents marca As System.Windows.Forms.ColumnHeader
    Friend WithEvents rubro As System.Windows.Forms.ColumnHeader
    Friend WithEvents modelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents talle As System.Windows.Forms.ColumnHeader
    Friend WithEvents detalle As System.Windows.Forms.ColumnHeader
    Friend WithEvents costo As System.Windows.Forms.ColumnHeader
    Friend WithEvents precio_unitario As System.Windows.Forms.ColumnHeader
    Friend WithEvents stock_actual As System.Windows.Forms.ColumnHeader
    Friend WithEvents stock_minimo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_filtro As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents interno As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_ver_todo As System.Windows.Forms.Button
End Class
