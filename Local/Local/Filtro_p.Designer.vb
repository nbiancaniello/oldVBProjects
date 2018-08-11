<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtro_p
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
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.txt_d_cod_anio = New System.Windows.Forms.TextBox
        Me.txt_d_costo = New System.Windows.Forms.TextBox
        Me.txt_d_precio_unitario = New System.Windows.Forms.TextBox
        Me.txt_d_cod_rubro = New System.Windows.Forms.TextBox
        Me.cbo_cr_precio_unitario = New System.Windows.Forms.ComboBox
        Me.cbo_cr_costo = New System.Windows.Forms.ComboBox
        Me.cbo_cr_marca = New System.Windows.Forms.ComboBox
        Me.cbo_cr_talle = New System.Windows.Forms.ComboBox
        Me.cbo_cr_codigo_modelo = New System.Windows.Forms.ComboBox
        Me.cbo_cr_codigo_rubro = New System.Windows.Forms.ComboBox
        Me.cbo_cr_codigo_anio = New System.Windows.Forms.ComboBox
        Me.lbl_marca = New System.Windows.Forms.Label
        Me.lbl_talle = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_codigo_modelo = New System.Windows.Forms.Label
        Me.lbl_codigo_rubro = New System.Windows.Forms.Label
        Me.lbl_costo = New System.Windows.Forms.Label
        Me.lbl_stock_minimo = New System.Windows.Forms.Label
        Me.lbl_precio_unitario = New System.Windows.Forms.Label
        Me.lbl_codigo_anio = New System.Windows.Forms.Label
        Me.cbo_cr_stock_actual = New System.Windows.Forms.ComboBox
        Me.cbo_cr_stock_minimo = New System.Windows.Forms.ComboBox
        Me.txt_d_cod_modelo = New System.Windows.Forms.TextBox
        Me.txt_d_stock_min = New System.Windows.Forms.TextBox
        Me.txt_d_stock_ac = New System.Windows.Forms.TextBox
        Me.cbo_d_marca = New System.Windows.Forms.ComboBox
        Me.cbo_d_talle = New System.Windows.Forms.ComboBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.cbo_h_marca = New System.Windows.Forms.ComboBox
        Me.cbo_h_talle = New System.Windows.Forms.ComboBox
        Me.txt_h_stock_min = New System.Windows.Forms.TextBox
        Me.txt_h_stock_ac = New System.Windows.Forms.TextBox
        Me.txt_h_cod_anio = New System.Windows.Forms.TextBox
        Me.txt_h_cod_modelo = New System.Windows.Forms.TextBox
        Me.txt_h_costo = New System.Windows.Forms.TextBox
        Me.txt_h_precio_unitario = New System.Windows.Forms.TextBox
        Me.txt_h_cod_rubro = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_hasta.Location = New System.Drawing.Point(360, 9)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(87, 25)
        Me.lbl_hasta.TabIndex = 55
        Me.lbl_hasta.Text = "HASTA"
        '
        'lbl_desde
        '
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_desde.Location = New System.Drawing.Point(249, 9)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(89, 25)
        Me.lbl_desde.TabIndex = 54
        Me.lbl_desde.Text = "DESDE"
        '
        'txt_d_cod_anio
        '
        Me.txt_d_cod_anio.Location = New System.Drawing.Point(298, 45)
        Me.txt_d_cod_anio.MaxLength = 3
        Me.txt_d_cod_anio.Name = "txt_d_cod_anio"
        Me.txt_d_cod_anio.Size = New System.Drawing.Size(40, 20)
        Me.txt_d_cod_anio.TabIndex = 1
        '
        'txt_d_costo
        '
        Me.txt_d_costo.Location = New System.Drawing.Point(277, 197)
        Me.txt_d_costo.MaxLength = 6
        Me.txt_d_costo.Name = "txt_d_costo"
        Me.txt_d_costo.Size = New System.Drawing.Size(61, 20)
        Me.txt_d_costo.TabIndex = 16
        '
        'txt_d_precio_unitario
        '
        Me.txt_d_precio_unitario.Location = New System.Drawing.Point(277, 229)
        Me.txt_d_precio_unitario.MaxLength = 6
        Me.txt_d_precio_unitario.Name = "txt_d_precio_unitario"
        Me.txt_d_precio_unitario.Size = New System.Drawing.Size(61, 20)
        Me.txt_d_precio_unitario.TabIndex = 19
        '
        'txt_d_cod_rubro
        '
        Me.txt_d_cod_rubro.Location = New System.Drawing.Point(298, 75)
        Me.txt_d_cod_rubro.MaxLength = 3
        Me.txt_d_cod_rubro.Name = "txt_d_cod_rubro"
        Me.txt_d_cod_rubro.Size = New System.Drawing.Size(40, 20)
        Me.txt_d_cod_rubro.TabIndex = 4
        '
        'cbo_cr_precio_unitario
        '
        Me.cbo_cr_precio_unitario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_precio_unitario.FormattingEnabled = True
        Me.cbo_cr_precio_unitario.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_precio_unitario.Location = New System.Drawing.Point(107, 228)
        Me.cbo_cr_precio_unitario.Name = "cbo_cr_precio_unitario"
        Me.cbo_cr_precio_unitario.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_precio_unitario.TabIndex = 18
        '
        'cbo_cr_costo
        '
        Me.cbo_cr_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_costo.FormattingEnabled = True
        Me.cbo_cr_costo.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_costo.Location = New System.Drawing.Point(107, 197)
        Me.cbo_cr_costo.Name = "cbo_cr_costo"
        Me.cbo_cr_costo.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_costo.TabIndex = 15
        '
        'cbo_cr_marca
        '
        Me.cbo_cr_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_marca.FormattingEnabled = True
        Me.cbo_cr_marca.Items.AddRange(New Object() {"Igual que", "Entre"})
        Me.cbo_cr_marca.Location = New System.Drawing.Point(107, 165)
        Me.cbo_cr_marca.Name = "cbo_cr_marca"
        Me.cbo_cr_marca.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_marca.TabIndex = 12
        '
        'cbo_cr_talle
        '
        Me.cbo_cr_talle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_talle.FormattingEnabled = True
        Me.cbo_cr_talle.Items.AddRange(New Object() {"Igual que", "Entre"})
        Me.cbo_cr_talle.Location = New System.Drawing.Point(107, 134)
        Me.cbo_cr_talle.Name = "cbo_cr_talle"
        Me.cbo_cr_talle.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_talle.TabIndex = 9
        '
        'cbo_cr_codigo_modelo
        '
        Me.cbo_cr_codigo_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_codigo_modelo.FormattingEnabled = True
        Me.cbo_cr_codigo_modelo.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_codigo_modelo.Location = New System.Drawing.Point(107, 103)
        Me.cbo_cr_codigo_modelo.Name = "cbo_cr_codigo_modelo"
        Me.cbo_cr_codigo_modelo.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_codigo_modelo.TabIndex = 6
        '
        'cbo_cr_codigo_rubro
        '
        Me.cbo_cr_codigo_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_codigo_rubro.FormattingEnabled = True
        Me.cbo_cr_codigo_rubro.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_codigo_rubro.Location = New System.Drawing.Point(107, 73)
        Me.cbo_cr_codigo_rubro.Name = "cbo_cr_codigo_rubro"
        Me.cbo_cr_codigo_rubro.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_codigo_rubro.TabIndex = 3
        '
        'cbo_cr_codigo_anio
        '
        Me.cbo_cr_codigo_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_codigo_anio.FormattingEnabled = True
        Me.cbo_cr_codigo_anio.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_codigo_anio.Location = New System.Drawing.Point(107, 43)
        Me.cbo_cr_codigo_anio.Name = "cbo_cr_codigo_anio"
        Me.cbo_cr_codigo_anio.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_codigo_anio.TabIndex = 0
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_marca.Location = New System.Drawing.Point(61, 168)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(40, 13)
        Me.lbl_marca.TabIndex = 65
        Me.lbl_marca.Text = "Marca:"
        '
        'lbl_talle
        '
        Me.lbl_talle.AutoSize = True
        Me.lbl_talle.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_talle.Location = New System.Drawing.Point(68, 138)
        Me.lbl_talle.Name = "lbl_talle"
        Me.lbl_talle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_talle.TabIndex = 64
        Me.lbl_talle.Text = "Talle:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(30, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Stock Actual:"
        '
        'lbl_codigo_modelo
        '
        Me.lbl_codigo_modelo.AutoSize = True
        Me.lbl_codigo_modelo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo_modelo.Location = New System.Drawing.Point(6, 107)
        Me.lbl_codigo_modelo.Name = "lbl_codigo_modelo"
        Me.lbl_codigo_modelo.Size = New System.Drawing.Size(95, 13)
        Me.lbl_codigo_modelo.TabIndex = 62
        Me.lbl_codigo_modelo.Text = "Código de modelo:"
        '
        'lbl_codigo_rubro
        '
        Me.lbl_codigo_rubro.AutoSize = True
        Me.lbl_codigo_rubro.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo_rubro.Location = New System.Drawing.Point(16, 78)
        Me.lbl_codigo_rubro.Name = "lbl_codigo_rubro"
        Me.lbl_codigo_rubro.Size = New System.Drawing.Size(85, 13)
        Me.lbl_codigo_rubro.TabIndex = 61
        Me.lbl_codigo_rubro.Text = "Código de rubro:"
        '
        'lbl_costo
        '
        Me.lbl_costo.AutoSize = True
        Me.lbl_costo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_costo.Location = New System.Drawing.Point(64, 200)
        Me.lbl_costo.Name = "lbl_costo"
        Me.lbl_costo.Size = New System.Drawing.Size(37, 13)
        Me.lbl_costo.TabIndex = 60
        Me.lbl_costo.Text = "Costo:"
        '
        'lbl_stock_minimo
        '
        Me.lbl_stock_minimo.AutoSize = True
        Me.lbl_stock_minimo.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_stock_minimo.Location = New System.Drawing.Point(25, 261)
        Me.lbl_stock_minimo.Name = "lbl_stock_minimo"
        Me.lbl_stock_minimo.Size = New System.Drawing.Size(76, 13)
        Me.lbl_stock_minimo.TabIndex = 59
        Me.lbl_stock_minimo.Text = "Stock Mínimo:"
        '
        'lbl_precio_unitario
        '
        Me.lbl_precio_unitario.AutoSize = True
        Me.lbl_precio_unitario.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_precio_unitario.Location = New System.Drawing.Point(22, 233)
        Me.lbl_precio_unitario.Name = "lbl_precio_unitario"
        Me.lbl_precio_unitario.Size = New System.Drawing.Size(79, 13)
        Me.lbl_precio_unitario.TabIndex = 58
        Me.lbl_precio_unitario.Text = "Precio Unitario:"
        '
        'lbl_codigo_anio
        '
        Me.lbl_codigo_anio.AutoSize = True
        Me.lbl_codigo_anio.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_codigo_anio.Location = New System.Drawing.Point(22, 48)
        Me.lbl_codigo_anio.Name = "lbl_codigo_anio"
        Me.lbl_codigo_anio.Size = New System.Drawing.Size(79, 13)
        Me.lbl_codigo_anio.TabIndex = 56
        Me.lbl_codigo_anio.Text = "Código de año:"
        '
        'cbo_cr_stock_actual
        '
        Me.cbo_cr_stock_actual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_stock_actual.FormattingEnabled = True
        Me.cbo_cr_stock_actual.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_stock_actual.Location = New System.Drawing.Point(107, 286)
        Me.cbo_cr_stock_actual.Name = "cbo_cr_stock_actual"
        Me.cbo_cr_stock_actual.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_stock_actual.TabIndex = 24
        '
        'cbo_cr_stock_minimo
        '
        Me.cbo_cr_stock_minimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_stock_minimo.FormattingEnabled = True
        Me.cbo_cr_stock_minimo.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_stock_minimo.Location = New System.Drawing.Point(107, 255)
        Me.cbo_cr_stock_minimo.Name = "cbo_cr_stock_minimo"
        Me.cbo_cr_stock_minimo.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_stock_minimo.TabIndex = 21
        '
        'txt_d_cod_modelo
        '
        Me.txt_d_cod_modelo.Location = New System.Drawing.Point(298, 104)
        Me.txt_d_cod_modelo.MaxLength = 3
        Me.txt_d_cod_modelo.Name = "txt_d_cod_modelo"
        Me.txt_d_cod_modelo.Size = New System.Drawing.Size(40, 20)
        Me.txt_d_cod_modelo.TabIndex = 7
        '
        'txt_d_stock_min
        '
        Me.txt_d_stock_min.Location = New System.Drawing.Point(298, 258)
        Me.txt_d_stock_min.MaxLength = 3
        Me.txt_d_stock_min.Name = "txt_d_stock_min"
        Me.txt_d_stock_min.Size = New System.Drawing.Size(40, 20)
        Me.txt_d_stock_min.TabIndex = 22
        '
        'txt_d_stock_ac
        '
        Me.txt_d_stock_ac.Location = New System.Drawing.Point(298, 290)
        Me.txt_d_stock_ac.MaxLength = 3
        Me.txt_d_stock_ac.Name = "txt_d_stock_ac"
        Me.txt_d_stock_ac.Size = New System.Drawing.Size(40, 20)
        Me.txt_d_stock_ac.TabIndex = 25
        '
        'cbo_d_marca
        '
        Me.cbo_d_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_d_marca.FormattingEnabled = True
        Me.cbo_d_marca.Location = New System.Drawing.Point(232, 166)
        Me.cbo_d_marca.Name = "cbo_d_marca"
        Me.cbo_d_marca.Size = New System.Drawing.Size(106, 21)
        Me.cbo_d_marca.TabIndex = 13
        '
        'cbo_d_talle
        '
        Me.cbo_d_talle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_d_talle.FormattingEnabled = True
        Me.cbo_d_talle.Location = New System.Drawing.Point(232, 135)
        Me.cbo_d_talle.Name = "cbo_d_talle"
        Me.cbo_d_talle.Size = New System.Drawing.Size(106, 21)
        Me.cbo_d_talle.TabIndex = 10
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_aceptar.Location = New System.Drawing.Point(313, 328)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(64, 22)
        Me.btn_aceptar.TabIndex = 27
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_cancelar.Location = New System.Drawing.Point(383, 328)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(64, 22)
        Me.btn_cancelar.TabIndex = 28
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cbo_h_marca
        '
        Me.cbo_h_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_h_marca.Enabled = False
        Me.cbo_h_marca.FormattingEnabled = True
        Me.cbo_h_marca.Location = New System.Drawing.Point(341, 166)
        Me.cbo_h_marca.Name = "cbo_h_marca"
        Me.cbo_h_marca.Size = New System.Drawing.Size(106, 21)
        Me.cbo_h_marca.TabIndex = 14
        '
        'cbo_h_talle
        '
        Me.cbo_h_talle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_h_talle.Enabled = False
        Me.cbo_h_talle.FormattingEnabled = True
        Me.cbo_h_talle.Location = New System.Drawing.Point(341, 135)
        Me.cbo_h_talle.Name = "cbo_h_talle"
        Me.cbo_h_talle.Size = New System.Drawing.Size(106, 21)
        Me.cbo_h_talle.TabIndex = 11
        '
        'txt_h_stock_min
        '
        Me.txt_h_stock_min.Enabled = False
        Me.txt_h_stock_min.Location = New System.Drawing.Point(407, 258)
        Me.txt_h_stock_min.MaxLength = 3
        Me.txt_h_stock_min.Name = "txt_h_stock_min"
        Me.txt_h_stock_min.Size = New System.Drawing.Size(40, 20)
        Me.txt_h_stock_min.TabIndex = 23
        '
        'txt_h_stock_ac
        '
        Me.txt_h_stock_ac.Enabled = False
        Me.txt_h_stock_ac.Location = New System.Drawing.Point(407, 290)
        Me.txt_h_stock_ac.MaxLength = 3
        Me.txt_h_stock_ac.Name = "txt_h_stock_ac"
        Me.txt_h_stock_ac.Size = New System.Drawing.Size(40, 20)
        Me.txt_h_stock_ac.TabIndex = 26
        '
        'txt_h_cod_anio
        '
        Me.txt_h_cod_anio.Enabled = False
        Me.txt_h_cod_anio.Location = New System.Drawing.Point(407, 45)
        Me.txt_h_cod_anio.MaxLength = 3
        Me.txt_h_cod_anio.Name = "txt_h_cod_anio"
        Me.txt_h_cod_anio.Size = New System.Drawing.Size(40, 20)
        Me.txt_h_cod_anio.TabIndex = 2
        '
        'txt_h_cod_modelo
        '
        Me.txt_h_cod_modelo.Enabled = False
        Me.txt_h_cod_modelo.Location = New System.Drawing.Point(407, 104)
        Me.txt_h_cod_modelo.MaxLength = 3
        Me.txt_h_cod_modelo.Name = "txt_h_cod_modelo"
        Me.txt_h_cod_modelo.Size = New System.Drawing.Size(40, 20)
        Me.txt_h_cod_modelo.TabIndex = 8
        '
        'txt_h_costo
        '
        Me.txt_h_costo.Enabled = False
        Me.txt_h_costo.Location = New System.Drawing.Point(386, 197)
        Me.txt_h_costo.MaxLength = 6
        Me.txt_h_costo.Name = "txt_h_costo"
        Me.txt_h_costo.Size = New System.Drawing.Size(61, 20)
        Me.txt_h_costo.TabIndex = 17
        '
        'txt_h_precio_unitario
        '
        Me.txt_h_precio_unitario.Enabled = False
        Me.txt_h_precio_unitario.Location = New System.Drawing.Point(386, 229)
        Me.txt_h_precio_unitario.MaxLength = 6
        Me.txt_h_precio_unitario.Name = "txt_h_precio_unitario"
        Me.txt_h_precio_unitario.Size = New System.Drawing.Size(61, 20)
        Me.txt_h_precio_unitario.TabIndex = 20
        '
        'txt_h_cod_rubro
        '
        Me.txt_h_cod_rubro.Enabled = False
        Me.txt_h_cod_rubro.Location = New System.Drawing.Point(407, 75)
        Me.txt_h_cod_rubro.MaxLength = 3
        Me.txt_h_cod_rubro.Name = "txt_h_cod_rubro"
        Me.txt_h_cod_rubro.Size = New System.Drawing.Size(40, 20)
        Me.txt_h_cod_rubro.TabIndex = 5
        '
        'Filtro_p
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(471, 362)
        Me.Controls.Add(Me.cbo_h_marca)
        Me.Controls.Add(Me.cbo_h_talle)
        Me.Controls.Add(Me.txt_h_stock_min)
        Me.Controls.Add(Me.txt_h_stock_ac)
        Me.Controls.Add(Me.txt_h_cod_anio)
        Me.Controls.Add(Me.txt_h_cod_modelo)
        Me.Controls.Add(Me.txt_h_costo)
        Me.Controls.Add(Me.txt_h_precio_unitario)
        Me.Controls.Add(Me.txt_h_cod_rubro)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cbo_d_marca)
        Me.Controls.Add(Me.cbo_d_talle)
        Me.Controls.Add(Me.txt_d_stock_min)
        Me.Controls.Add(Me.txt_d_stock_ac)
        Me.Controls.Add(Me.cbo_cr_stock_actual)
        Me.Controls.Add(Me.cbo_cr_stock_minimo)
        Me.Controls.Add(Me.lbl_marca)
        Me.Controls.Add(Me.lbl_talle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_codigo_modelo)
        Me.Controls.Add(Me.lbl_codigo_rubro)
        Me.Controls.Add(Me.lbl_costo)
        Me.Controls.Add(Me.lbl_stock_minimo)
        Me.Controls.Add(Me.lbl_precio_unitario)
        Me.Controls.Add(Me.lbl_codigo_anio)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.txt_d_cod_anio)
        Me.Controls.Add(Me.txt_d_cod_modelo)
        Me.Controls.Add(Me.txt_d_costo)
        Me.Controls.Add(Me.txt_d_precio_unitario)
        Me.Controls.Add(Me.txt_d_cod_rubro)
        Me.Controls.Add(Me.cbo_cr_precio_unitario)
        Me.Controls.Add(Me.cbo_cr_costo)
        Me.Controls.Add(Me.cbo_cr_marca)
        Me.Controls.Add(Me.cbo_cr_talle)
        Me.Controls.Add(Me.cbo_cr_codigo_modelo)
        Me.Controls.Add(Me.cbo_cr_codigo_rubro)
        Me.Controls.Add(Me.cbo_cr_codigo_anio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Filtro_p"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents txt_d_cod_anio As System.Windows.Forms.TextBox
    Friend WithEvents txt_d_costo As System.Windows.Forms.TextBox
    Friend WithEvents txt_d_precio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents txt_d_cod_rubro As System.Windows.Forms.TextBox
    Friend WithEvents cbo_cr_precio_unitario As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_costo As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_marca As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_talle As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_codigo_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_codigo_rubro As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_codigo_anio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents lbl_talle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_modelo As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_rubro As System.Windows.Forms.Label
    Friend WithEvents lbl_costo As System.Windows.Forms.Label
    Friend WithEvents lbl_stock_minimo As System.Windows.Forms.Label
    Friend WithEvents lbl_precio_unitario As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_anio As System.Windows.Forms.Label
    Friend WithEvents cbo_cr_stock_actual As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_stock_minimo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_d_cod_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_d_stock_min As System.Windows.Forms.TextBox
    Friend WithEvents txt_d_stock_ac As System.Windows.Forms.TextBox
    Friend WithEvents cbo_d_marca As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_d_talle As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cbo_h_marca As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_h_talle As System.Windows.Forms.ComboBox
    Friend WithEvents txt_h_stock_min As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_stock_ac As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_cod_anio As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_cod_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_costo As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_precio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_cod_rubro As System.Windows.Forms.TextBox
End Class
