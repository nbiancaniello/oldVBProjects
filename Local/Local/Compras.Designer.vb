<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_filtro = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.lv_compras = New System.Windows.Forms.ListView
        Me.num_factura = New System.Windows.Forms.ColumnHeader
        Me.cod_proveedor = New System.Windows.Forms.ColumnHeader
        Me.Fecha_compra = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_salir.Location = New System.Drawing.Point(12, 280)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(98, 36)
        Me.btn_salir.TabIndex = 15
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(596, 376)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(57, 23)
        Me.btn_imprimir.TabIndex = 25
        Me.btn_imprimir.Text = "imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_filtro
        '
        Me.btn_filtro.Location = New System.Drawing.Point(507, 376)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Size = New System.Drawing.Size(57, 23)
        Me.btn_filtro.TabIndex = 24
        Me.btn_filtro.Text = "filtro"
        Me.btn_filtro.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(416, 376)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(57, 23)
        Me.btn_modificar.TabIndex = 23
        Me.btn_modificar.Text = "modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(324, 376)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(57, 23)
        Me.btn_eliminar.TabIndex = 22
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(232, 376)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(57, 23)
        Me.btn_agregar.TabIndex = 21
        Me.btn_agregar.Text = "agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lv_compras
        '
        Me.lv_compras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.num_factura, Me.cod_proveedor, Me.Fecha_compra})
        Me.lv_compras.FullRowSelect = True
        Me.lv_compras.GridLines = True
        Me.lv_compras.Location = New System.Drawing.Point(12, 12)
        Me.lv_compras.MultiSelect = False
        Me.lv_compras.Name = "lv_compras"
        Me.lv_compras.Size = New System.Drawing.Size(356, 248)
        Me.lv_compras.TabIndex = 20
        Me.lv_compras.UseCompatibleStateImageBehavior = False
        Me.lv_compras.View = System.Windows.Forms.View.Details
        '
        'num_factura
        '
        Me.num_factura.Text = "Numero de Factura"
        Me.num_factura.Width = 103
        '
        'cod_proveedor
        '
        Me.cod_proveedor.Text = "Código de Proveedor"
        Me.cod_proveedor.Width = 122
        '
        'Fecha_compra
        '
        Me.Fecha_compra.Text = "Fechas de compra"
        Me.Fecha_compra.Width = 122
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 425)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_filtro)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lv_compras)
        Me.Controls.Add(Me.btn_salir)
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_filtro As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lv_compras As System.Windows.Forms.ListView
    Friend WithEvents num_factura As System.Windows.Forms.ColumnHeader
    Friend WithEvents cod_proveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fecha_compra As System.Windows.Forms.ColumnHeader
End Class
