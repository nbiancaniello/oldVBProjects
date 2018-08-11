<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_principal
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
        Me.btn_ventas = New System.Windows.Forms.Button
        Me.btn_productos = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_proveedores = New System.Windows.Forms.Button
        Me.btnCompras = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_ventas
        '
        Me.btn_ventas.BackColor = System.Drawing.Color.Transparent
        Me.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ventas.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_ventas.Location = New System.Drawing.Point(91, 33)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(212, 47)
        Me.btn_ventas.TabIndex = 0
        Me.btn_ventas.Text = "Ventas"
        Me.btn_ventas.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.Transparent
        Me.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_productos.Location = New System.Drawing.Point(91, 227)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(212, 47)
        Me.btn_productos.TabIndex = 3
        Me.btn_productos.Text = "Productos"
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_salir.Location = New System.Drawing.Point(91, 320)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(212, 47)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackColor = System.Drawing.Color.Transparent
        Me.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedores.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_proveedores.Location = New System.Drawing.Point(91, 161)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(212, 47)
        Me.btn_proveedores.TabIndex = 2
        Me.btn_proveedores.Text = "Proveedores"
        Me.btn_proveedores.UseVisualStyleBackColor = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.Transparent
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCompras.Location = New System.Drawing.Point(91, 97)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(212, 47)
        Me.btnCompras.TabIndex = 1
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'Ventana_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(393, 408)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.btn_proveedores)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_productos)
        Me.Controls.Add(Me.btn_ventas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ventana_principal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana_principal"
        Me.TransparencyKey = System.Drawing.Color.DarkOrange
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ventas As System.Windows.Forms.Button
    Friend WithEvents btn_productos As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_proveedores As System.Windows.Forms.Button
    Friend WithEvents btnCompras As System.Windows.Forms.Button
End Class
