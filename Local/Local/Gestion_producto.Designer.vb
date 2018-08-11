<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_producto
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
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.txt_costo = New System.Windows.Forms.TextBox
        Me.lbl_costo = New System.Windows.Forms.Label
        Me.txt_stock_actual = New System.Windows.Forms.TextBox
        Me.txt_precio_unitario = New System.Windows.Forms.TextBox
        Me.txt_detalle = New System.Windows.Forms.TextBox
        Me.txt_stock_minimo = New System.Windows.Forms.TextBox
        Me.lbl_stock_minimo = New System.Windows.Forms.Label
        Me.lbl_precio_unitario = New System.Windows.Forms.Label
        Me.lbl_detalle = New System.Windows.Forms.Label
        Me.txt_codigo_anio = New System.Windows.Forms.TextBox
        Me.lbl_codigo_anio = New System.Windows.Forms.Label
        Me.lbl_codigo_rubro = New System.Windows.Forms.Label
        Me.lbl_codigo_modelo = New System.Windows.Forms.Label
        Me.txt_codigo_rubro = New System.Windows.Forms.TextBox
        Me.txt_codigo_modelo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_talle = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_marca = New System.Windows.Forms.Label
        Me.cbo_marca = New System.Windows.Forms.ComboBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.txt_ant_anio = New System.Windows.Forms.TextBox
        Me.txt_ant_rub = New System.Windows.Forms.TextBox
        Me.txt_ant_mod = New System.Windows.Forms.TextBox
        Me.txt_ant_tll = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_aceptar.Location = New System.Drawing.Point(204, 180)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(57, 23)
        Me.btn_aceptar.TabIndex = 10
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(112, 102)
        Me.txt_costo.MaxLength = 7
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(61, 20)
        Me.txt_costo.TabIndex = 5
        '
        'lbl_costo
        '
        Me.lbl_costo.AutoSize = True
        Me.lbl_costo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_costo.Location = New System.Drawing.Point(69, 105)
        Me.lbl_costo.Name = "lbl_costo"
        Me.lbl_costo.Size = New System.Drawing.Size(37, 13)
        Me.lbl_costo.TabIndex = 43
        Me.lbl_costo.Text = "Costo:"
        '
        'txt_stock_actual
        '
        Me.txt_stock_actual.Location = New System.Drawing.Point(259, 128)
        Me.txt_stock_actual.MaxLength = 3
        Me.txt_stock_actual.Name = "txt_stock_actual"
        Me.txt_stock_actual.Size = New System.Drawing.Size(35, 20)
        Me.txt_stock_actual.TabIndex = 8
        '
        'txt_precio_unitario
        '
        Me.txt_precio_unitario.Location = New System.Drawing.Point(112, 128)
        Me.txt_precio_unitario.MaxLength = 7
        Me.txt_precio_unitario.Name = "txt_precio_unitario"
        Me.txt_precio_unitario.Size = New System.Drawing.Size(61, 20)
        Me.txt_precio_unitario.TabIndex = 7
        '
        'txt_detalle
        '
        Me.txt_detalle.Location = New System.Drawing.Point(112, 154)
        Me.txt_detalle.MaxLength = 50
        Me.txt_detalle.Name = "txt_detalle"
        Me.txt_detalle.Size = New System.Drawing.Size(182, 20)
        Me.txt_detalle.TabIndex = 9
        '
        'txt_stock_minimo
        '
        Me.txt_stock_minimo.Location = New System.Drawing.Point(259, 102)
        Me.txt_stock_minimo.MaxLength = 3
        Me.txt_stock_minimo.Name = "txt_stock_minimo"
        Me.txt_stock_minimo.Size = New System.Drawing.Size(35, 20)
        Me.txt_stock_minimo.TabIndex = 6
        '
        'lbl_stock_minimo
        '
        Me.lbl_stock_minimo.AutoSize = True
        Me.lbl_stock_minimo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_stock_minimo.Location = New System.Drawing.Point(179, 105)
        Me.lbl_stock_minimo.Name = "lbl_stock_minimo"
        Me.lbl_stock_minimo.Size = New System.Drawing.Size(76, 13)
        Me.lbl_stock_minimo.TabIndex = 33
        Me.lbl_stock_minimo.Text = "Stock Mínimo:"
        '
        'lbl_precio_unitario
        '
        Me.lbl_precio_unitario.AutoSize = True
        Me.lbl_precio_unitario.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_precio_unitario.Location = New System.Drawing.Point(27, 131)
        Me.lbl_precio_unitario.Name = "lbl_precio_unitario"
        Me.lbl_precio_unitario.Size = New System.Drawing.Size(79, 13)
        Me.lbl_precio_unitario.TabIndex = 32
        Me.lbl_precio_unitario.Text = "Precio Unitario:"
        '
        'lbl_detalle
        '
        Me.lbl_detalle.AutoSize = True
        Me.lbl_detalle.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_detalle.Location = New System.Drawing.Point(63, 157)
        Me.lbl_detalle.Name = "lbl_detalle"
        Me.lbl_detalle.Size = New System.Drawing.Size(43, 13)
        Me.lbl_detalle.TabIndex = 31
        Me.lbl_detalle.Text = "Detalle:"
        '
        'txt_codigo_anio
        '
        Me.txt_codigo_anio.Location = New System.Drawing.Point(112, 15)
        Me.txt_codigo_anio.MaxLength = 3
        Me.txt_codigo_anio.Name = "txt_codigo_anio"
        Me.txt_codigo_anio.Size = New System.Drawing.Size(35, 20)
        Me.txt_codigo_anio.TabIndex = 0
        '
        'lbl_codigo_anio
        '
        Me.lbl_codigo_anio.AutoSize = True
        Me.lbl_codigo_anio.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo_anio.Location = New System.Drawing.Point(28, 19)
        Me.lbl_codigo_anio.Name = "lbl_codigo_anio"
        Me.lbl_codigo_anio.Size = New System.Drawing.Size(79, 13)
        Me.lbl_codigo_anio.TabIndex = 29
        Me.lbl_codigo_anio.Text = "Código de año:"
        '
        'lbl_codigo_rubro
        '
        Me.lbl_codigo_rubro.AutoSize = True
        Me.lbl_codigo_rubro.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo_rubro.Location = New System.Drawing.Point(22, 49)
        Me.lbl_codigo_rubro.Name = "lbl_codigo_rubro"
        Me.lbl_codigo_rubro.Size = New System.Drawing.Size(85, 13)
        Me.lbl_codigo_rubro.TabIndex = 45
        Me.lbl_codigo_rubro.Text = "Código de rubro:"
        '
        'lbl_codigo_modelo
        '
        Me.lbl_codigo_modelo.AutoSize = True
        Me.lbl_codigo_modelo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo_modelo.Location = New System.Drawing.Point(13, 79)
        Me.lbl_codigo_modelo.Name = "lbl_codigo_modelo"
        Me.lbl_codigo_modelo.Size = New System.Drawing.Size(95, 13)
        Me.lbl_codigo_modelo.TabIndex = 46
        Me.lbl_codigo_modelo.Text = "Código de modelo:"
        '
        'txt_codigo_rubro
        '
        Me.txt_codigo_rubro.Location = New System.Drawing.Point(112, 46)
        Me.txt_codigo_rubro.MaxLength = 3
        Me.txt_codigo_rubro.Name = "txt_codigo_rubro"
        Me.txt_codigo_rubro.Size = New System.Drawing.Size(35, 20)
        Me.txt_codigo_rubro.TabIndex = 2
        '
        'txt_codigo_modelo
        '
        Me.txt_codigo_modelo.Location = New System.Drawing.Point(112, 76)
        Me.txt_codigo_modelo.MaxLength = 3
        Me.txt_codigo_modelo.Name = "txt_codigo_modelo"
        Me.txt_codigo_modelo.Size = New System.Drawing.Size(35, 20)
        Me.txt_codigo_modelo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(184, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Stock Actual:"
        '
        'cbo_talle
        '
        Me.cbo_talle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_talle.FormattingEnabled = True
        Me.cbo_talle.Location = New System.Drawing.Point(199, 15)
        Me.cbo_talle.Name = "cbo_talle"
        Me.cbo_talle.Size = New System.Drawing.Size(78, 21)
        Me.cbo_talle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Talle:"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_marca.Location = New System.Drawing.Point(153, 49)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(40, 13)
        Me.lbl_marca.TabIndex = 53
        Me.lbl_marca.Text = "Marca:"
        '
        'cbo_marca
        '
        Me.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marca.FormattingEnabled = True
        Me.cbo_marca.Location = New System.Drawing.Point(199, 45)
        Me.cbo_marca.Name = "cbo_marca"
        Me.cbo_marca.Size = New System.Drawing.Size(125, 21)
        Me.cbo_marca.TabIndex = 3
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_cancelar.Location = New System.Drawing.Point(267, 180)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(57, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_ant_anio
        '
        Me.txt_ant_anio.Location = New System.Drawing.Point(12, 183)
        Me.txt_ant_anio.Name = "txt_ant_anio"
        Me.txt_ant_anio.Size = New System.Drawing.Size(8, 20)
        Me.txt_ant_anio.TabIndex = 54
        Me.txt_ant_anio.Visible = False
        '
        'txt_ant_rub
        '
        Me.txt_ant_rub.Location = New System.Drawing.Point(25, 182)
        Me.txt_ant_rub.Name = "txt_ant_rub"
        Me.txt_ant_rub.Size = New System.Drawing.Size(8, 20)
        Me.txt_ant_rub.TabIndex = 55
        Me.txt_ant_rub.Visible = False
        '
        'txt_ant_mod
        '
        Me.txt_ant_mod.Location = New System.Drawing.Point(39, 183)
        Me.txt_ant_mod.Name = "txt_ant_mod"
        Me.txt_ant_mod.Size = New System.Drawing.Size(8, 20)
        Me.txt_ant_mod.TabIndex = 56
        Me.txt_ant_mod.Visible = False
        '
        'txt_ant_tll
        '
        Me.txt_ant_tll.Location = New System.Drawing.Point(53, 183)
        Me.txt_ant_tll.Name = "txt_ant_tll"
        Me.txt_ant_tll.Size = New System.Drawing.Size(8, 20)
        Me.txt_ant_tll.TabIndex = 57
        Me.txt_ant_tll.Visible = False
        '
        'Gestion_producto
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(335, 214)
        Me.Controls.Add(Me.txt_ant_tll)
        Me.Controls.Add(Me.txt_ant_mod)
        Me.Controls.Add(Me.txt_ant_rub)
        Me.Controls.Add(Me.txt_ant_anio)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_marca)
        Me.Controls.Add(Me.cbo_marca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_talle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_codigo_modelo)
        Me.Controls.Add(Me.txt_codigo_rubro)
        Me.Controls.Add(Me.lbl_codigo_modelo)
        Me.Controls.Add(Me.lbl_codigo_rubro)
        Me.Controls.Add(Me.txt_costo)
        Me.Controls.Add(Me.lbl_costo)
        Me.Controls.Add(Me.txt_stock_actual)
        Me.Controls.Add(Me.txt_precio_unitario)
        Me.Controls.Add(Me.txt_detalle)
        Me.Controls.Add(Me.txt_stock_minimo)
        Me.Controls.Add(Me.lbl_stock_minimo)
        Me.Controls.Add(Me.lbl_precio_unitario)
        Me.Controls.Add(Me.lbl_detalle)
        Me.Controls.Add(Me.txt_codigo_anio)
        Me.Controls.Add(Me.lbl_codigo_anio)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gestion_producto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_costo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_costo As System.Windows.Forms.Label
    Friend WithEvents txt_stock_actual As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents txt_detalle As System.Windows.Forms.TextBox
    Friend WithEvents txt_stock_minimo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_stock_minimo As System.Windows.Forms.Label
    Friend WithEvents lbl_precio_unitario As System.Windows.Forms.Label
    Friend WithEvents lbl_detalle As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_anio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codigo_anio As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_rubro As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_modelo As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_rubro As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_talle As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents cbo_marca As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_ant_anio As System.Windows.Forms.TextBox
    Friend WithEvents txt_ant_rub As System.Windows.Forms.TextBox
    Friend WithEvents txt_ant_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_ant_tll As System.Windows.Forms.TextBox
End Class
