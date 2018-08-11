<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleCompras
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
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_filtro = New System.Windows.Forms.Button
        Me.lv_detalle_compra = New System.Windows.Forms.ListView
        Me.cod_producto = New System.Windows.Forms.ColumnHeader
        Me.cantida = New System.Windows.Forms.ColumnHeader
        Me.precio_unitario = New System.Windows.Forms.ColumnHeader
        Me.Importe = New System.Windows.Forms.ColumnHeader
        Me.PDetalleCompra = New System.Drawing.Printing.PrintDocument
        Me.lbl_total_compra = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(482, 12)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(75, 35)
        Me.btn_imprimir.TabIndex = 10
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(563, 12)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(78, 35)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_filtro
        '
        Me.btn_filtro.Location = New System.Drawing.Point(401, 12)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Size = New System.Drawing.Size(75, 35)
        Me.btn_filtro.TabIndex = 8
        Me.btn_filtro.Text = "Filtro"
        Me.btn_filtro.UseVisualStyleBackColor = True
        '
        'lv_detalle_compra
        '
        Me.lv_detalle_compra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cod_producto, Me.cantida, Me.precio_unitario, Me.Importe})
        Me.lv_detalle_compra.FullRowSelect = True
        Me.lv_detalle_compra.GridLines = True
        Me.lv_detalle_compra.Location = New System.Drawing.Point(12, 12)
        Me.lv_detalle_compra.MultiSelect = False
        Me.lv_detalle_compra.Name = "lv_detalle_compra"
        Me.lv_detalle_compra.Size = New System.Drawing.Size(374, 209)
        Me.lv_detalle_compra.TabIndex = 7
        Me.lv_detalle_compra.UseCompatibleStateImageBehavior = False
        Me.lv_detalle_compra.View = System.Windows.Forms.View.Details
        '
        'cod_producto
        '
        Me.cod_producto.Text = "Código de Producto"
        Me.cod_producto.Width = 118
        '
        'cantida
        '
        Me.cantida.Text = "Cantidad"
        Me.cantida.Width = 73
        '
        'precio_unitario
        '
        Me.precio_unitario.Text = "Precio Compra"
        Me.precio_unitario.Width = 88
        '
        'Importe
        '
        Me.Importe.Text = "Importe Total"
        Me.Importe.Width = 85
        '
        'PDetalleCompra
        '
        '
        'lbl_total_compra
        '
        Me.lbl_total_compra.AutoSize = True
        Me.lbl_total_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_compra.Location = New System.Drawing.Point(300, 224)
        Me.lbl_total_compra.Name = "lbl_total_compra"
        Me.lbl_total_compra.Size = New System.Drawing.Size(30, 31)
        Me.lbl_total_compra.TabIndex = 13
        Me.lbl_total_compra.Text = "0"
        Me.lbl_total_compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(181, 224)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(113, 31)
        Me.lbl_total.TabIndex = 12
        Me.lbl_total.Text = "Total: $"
        '
        'DetalleCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 288)
        Me.Controls.Add(Me.lbl_total_compra)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_filtro)
        Me.Controls.Add(Me.lv_detalle_compra)
        Me.Name = "DetalleCompras"
        Me.Text = "DetalleCompras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_filtro As System.Windows.Forms.Button
    Friend WithEvents lv_detalle_compra As System.Windows.Forms.ListView
    Friend WithEvents cod_producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents cantida As System.Windows.Forms.ColumnHeader
    Friend WithEvents precio_unitario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Importe As System.Windows.Forms.ColumnHeader
    Friend WithEvents PDetalleCompra As System.Drawing.Printing.PrintDocument
    Friend WithEvents lbl_total_compra As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
End Class
