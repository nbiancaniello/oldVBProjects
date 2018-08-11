<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtro_v
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
        Me.cbo_h_empresa = New System.Windows.Forms.ComboBox
        Me.cbo_h_tipo_pago = New System.Windows.Forms.ComboBox
        Me.txt_h_cuotas = New System.Windows.Forms.TextBox
        Me.txt_h_num_fac = New System.Windows.Forms.TextBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.cbo_d_empresa = New System.Windows.Forms.ComboBox
        Me.cbo_d_tipo_pago = New System.Windows.Forms.ComboBox
        Me.txt_d_cuotas = New System.Windows.Forms.TextBox
        Me.lbl_numero_cuotas = New System.Windows.Forms.Label
        Me.lbl_empresa = New System.Windows.Forms.Label
        Me.lbl_tipo_pago = New System.Windows.Forms.Label
        Me.lbl_fecha_venta = New System.Windows.Forms.Label
        Me.lbl_estado = New System.Windows.Forms.Label
        Me.lbl_numero_factura = New System.Windows.Forms.Label
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.txt_d_num_fac = New System.Windows.Forms.TextBox
        Me.cbo_cr_estado = New System.Windows.Forms.ComboBox
        Me.cbo_cr_cuotas = New System.Windows.Forms.ComboBox
        Me.cbo_cr_empresa = New System.Windows.Forms.ComboBox
        Me.cbo_cr_tipo_pago = New System.Windows.Forms.ComboBox
        Me.cbo_cr_fecha = New System.Windows.Forms.ComboBox
        Me.cbo_cr_numero_factura = New System.Windows.Forms.ComboBox
        Me.dtp_d_fecha = New System.Windows.Forms.DateTimePicker
        Me.dtp_h_fecha = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'cbo_h_empresa
        '
        Me.cbo_h_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_h_empresa.Enabled = False
        Me.cbo_h_empresa.FormattingEnabled = True
        Me.cbo_h_empresa.Location = New System.Drawing.Point(350, 135)
        Me.cbo_h_empresa.Name = "cbo_h_empresa"
        Me.cbo_h_empresa.Size = New System.Drawing.Size(106, 21)
        Me.cbo_h_empresa.TabIndex = 11
        '
        'cbo_h_tipo_pago
        '
        Me.cbo_h_tipo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_h_tipo_pago.Enabled = False
        Me.cbo_h_tipo_pago.FormattingEnabled = True
        Me.cbo_h_tipo_pago.Items.AddRange(New Object() {"Contado", "Tarjeta Crédito", "Tarjeta Débito"})
        Me.cbo_h_tipo_pago.Location = New System.Drawing.Point(350, 103)
        Me.cbo_h_tipo_pago.Name = "cbo_h_tipo_pago"
        Me.cbo_h_tipo_pago.Size = New System.Drawing.Size(106, 21)
        Me.cbo_h_tipo_pago.TabIndex = 8
        '
        'txt_h_cuotas
        '
        Me.txt_h_cuotas.Enabled = False
        Me.txt_h_cuotas.Location = New System.Drawing.Point(432, 166)
        Me.txt_h_cuotas.MaxLength = 2
        Me.txt_h_cuotas.Name = "txt_h_cuotas"
        Me.txt_h_cuotas.Size = New System.Drawing.Size(24, 20)
        Me.txt_h_cuotas.TabIndex = 14
        '
        'txt_h_num_fac
        '
        Me.txt_h_num_fac.Enabled = False
        Me.txt_h_num_fac.Location = New System.Drawing.Point(350, 45)
        Me.txt_h_num_fac.MaxLength = 8
        Me.txt_h_num_fac.Name = "txt_h_num_fac"
        Me.txt_h_num_fac.Size = New System.Drawing.Size(106, 20)
        Me.txt_h_num_fac.TabIndex = 2
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_cancelar.Location = New System.Drawing.Point(392, 200)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(64, 22)
        Me.btn_cancelar.TabIndex = 17
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_aceptar.Location = New System.Drawing.Point(319, 200)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(64, 22)
        Me.btn_aceptar.TabIndex = 16
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'cbo_d_empresa
        '
        Me.cbo_d_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_d_empresa.FormattingEnabled = True
        Me.cbo_d_empresa.Location = New System.Drawing.Point(238, 135)
        Me.cbo_d_empresa.Name = "cbo_d_empresa"
        Me.cbo_d_empresa.Size = New System.Drawing.Size(106, 21)
        Me.cbo_d_empresa.TabIndex = 10
        '
        'cbo_d_tipo_pago
        '
        Me.cbo_d_tipo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_d_tipo_pago.FormattingEnabled = True
        Me.cbo_d_tipo_pago.Items.AddRange(New Object() {"Contado", "Tarjeta Crédito", "Tarjeta Débito"})
        Me.cbo_d_tipo_pago.Location = New System.Drawing.Point(238, 104)
        Me.cbo_d_tipo_pago.Name = "cbo_d_tipo_pago"
        Me.cbo_d_tipo_pago.Size = New System.Drawing.Size(106, 21)
        Me.cbo_d_tipo_pago.TabIndex = 7
        '
        'txt_d_cuotas
        '
        Me.txt_d_cuotas.Location = New System.Drawing.Point(319, 166)
        Me.txt_d_cuotas.MaxLength = 2
        Me.txt_d_cuotas.Name = "txt_d_cuotas"
        Me.txt_d_cuotas.Size = New System.Drawing.Size(25, 20)
        Me.txt_d_cuotas.TabIndex = 13
        '
        'lbl_numero_cuotas
        '
        Me.lbl_numero_cuotas.AutoSize = True
        Me.lbl_numero_cuotas.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_numero_cuotas.Location = New System.Drawing.Point(64, 168)
        Me.lbl_numero_cuotas.Name = "lbl_numero_cuotas"
        Me.lbl_numero_cuotas.Size = New System.Drawing.Size(43, 13)
        Me.lbl_numero_cuotas.TabIndex = 113
        Me.lbl_numero_cuotas.Text = "Cuotas:"
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_empresa.Location = New System.Drawing.Point(56, 137)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(51, 13)
        Me.lbl_empresa.TabIndex = 112
        Me.lbl_empresa.Text = "Empresa:"
        '
        'lbl_tipo_pago
        '
        Me.lbl_tipo_pago.AutoSize = True
        Me.lbl_tipo_pago.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_tipo_pago.Location = New System.Drawing.Point(48, 107)
        Me.lbl_tipo_pago.Name = "lbl_tipo_pago"
        Me.lbl_tipo_pago.Size = New System.Drawing.Size(59, 13)
        Me.lbl_tipo_pago.TabIndex = 110
        Me.lbl_tipo_pago.Text = "Tipo Pago:"
        '
        'lbl_fecha_venta
        '
        Me.lbl_fecha_venta.AutoSize = True
        Me.lbl_fecha_venta.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_fecha_venta.Location = New System.Drawing.Point(22, 78)
        Me.lbl_fecha_venta.Name = "lbl_fecha_venta"
        Me.lbl_fecha_venta.Size = New System.Drawing.Size(86, 13)
        Me.lbl_fecha_venta.TabIndex = 109
        Me.lbl_fecha_venta.Text = "Fecha de Venta:"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_estado.Location = New System.Drawing.Point(65, 200)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(43, 13)
        Me.lbl_estado.TabIndex = 108
        Me.lbl_estado.Text = "Estado:"
        '
        'lbl_numero_factura
        '
        Me.lbl_numero_factura.AutoSize = True
        Me.lbl_numero_factura.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_numero_factura.Location = New System.Drawing.Point(6, 48)
        Me.lbl_numero_factura.Name = "lbl_numero_factura"
        Me.lbl_numero_factura.Size = New System.Drawing.Size(101, 13)
        Me.lbl_numero_factura.TabIndex = 105
        Me.lbl_numero_factura.Text = "Número de Factura:"
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_hasta.Location = New System.Drawing.Point(366, 9)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(87, 25)
        Me.lbl_hasta.TabIndex = 104
        Me.lbl_hasta.Text = "HASTA"
        '
        'lbl_desde
        '
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_desde.Location = New System.Drawing.Point(255, 9)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(89, 25)
        Me.lbl_desde.TabIndex = 103
        Me.lbl_desde.Text = "DESDE"
        '
        'txt_d_num_fac
        '
        Me.txt_d_num_fac.Location = New System.Drawing.Point(238, 45)
        Me.txt_d_num_fac.MaxLength = 8
        Me.txt_d_num_fac.Name = "txt_d_num_fac"
        Me.txt_d_num_fac.Size = New System.Drawing.Size(106, 20)
        Me.txt_d_num_fac.TabIndex = 1
        '
        'cbo_cr_estado
        '
        Me.cbo_cr_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_estado.FormattingEnabled = True
        Me.cbo_cr_estado.Items.AddRange(New Object() {"Ambos", "Cerrada", "Anulada"})
        Me.cbo_cr_estado.Location = New System.Drawing.Point(113, 197)
        Me.cbo_cr_estado.Name = "cbo_cr_estado"
        Me.cbo_cr_estado.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_estado.TabIndex = 15
        '
        'cbo_cr_cuotas
        '
        Me.cbo_cr_cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_cuotas.FormattingEnabled = True
        Me.cbo_cr_cuotas.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_cuotas.Location = New System.Drawing.Point(113, 165)
        Me.cbo_cr_cuotas.Name = "cbo_cr_cuotas"
        Me.cbo_cr_cuotas.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_cuotas.TabIndex = 12
        '
        'cbo_cr_empresa
        '
        Me.cbo_cr_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_empresa.FormattingEnabled = True
        Me.cbo_cr_empresa.Items.AddRange(New Object() {"Igual que", "Entre"})
        Me.cbo_cr_empresa.Location = New System.Drawing.Point(113, 134)
        Me.cbo_cr_empresa.Name = "cbo_cr_empresa"
        Me.cbo_cr_empresa.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_empresa.TabIndex = 9
        '
        'cbo_cr_tipo_pago
        '
        Me.cbo_cr_tipo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_tipo_pago.FormattingEnabled = True
        Me.cbo_cr_tipo_pago.Items.AddRange(New Object() {"Igual a", "Entre"})
        Me.cbo_cr_tipo_pago.Location = New System.Drawing.Point(113, 103)
        Me.cbo_cr_tipo_pago.Name = "cbo_cr_tipo_pago"
        Me.cbo_cr_tipo_pago.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_tipo_pago.TabIndex = 6
        '
        'cbo_cr_fecha
        '
        Me.cbo_cr_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_fecha.FormattingEnabled = True
        Me.cbo_cr_fecha.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_fecha.Location = New System.Drawing.Point(113, 73)
        Me.cbo_cr_fecha.Name = "cbo_cr_fecha"
        Me.cbo_cr_fecha.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_fecha.TabIndex = 3
        '
        'cbo_cr_numero_factura
        '
        Me.cbo_cr_numero_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cr_numero_factura.FormattingEnabled = True
        Me.cbo_cr_numero_factura.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cbo_cr_numero_factura.Location = New System.Drawing.Point(113, 43)
        Me.cbo_cr_numero_factura.Name = "cbo_cr_numero_factura"
        Me.cbo_cr_numero_factura.Size = New System.Drawing.Size(106, 21)
        Me.cbo_cr_numero_factura.TabIndex = 0
        '
        'dtp_d_fecha
        '
        Me.dtp_d_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_d_fecha.Location = New System.Drawing.Point(260, 74)
        Me.dtp_d_fecha.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtp_d_fecha.Name = "dtp_d_fecha"
        Me.dtp_d_fecha.Size = New System.Drawing.Size(84, 20)
        Me.dtp_d_fecha.TabIndex = 4
        '
        'dtp_h_fecha
        '
        Me.dtp_h_fecha.Enabled = False
        Me.dtp_h_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_h_fecha.Location = New System.Drawing.Point(371, 74)
        Me.dtp_h_fecha.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtp_h_fecha.Name = "dtp_h_fecha"
        Me.dtp_h_fecha.Size = New System.Drawing.Size(85, 20)
        Me.dtp_h_fecha.TabIndex = 5
        '
        'Filtro_v
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(474, 231)
        Me.Controls.Add(Me.dtp_h_fecha)
        Me.Controls.Add(Me.dtp_d_fecha)
        Me.Controls.Add(Me.cbo_h_empresa)
        Me.Controls.Add(Me.cbo_h_tipo_pago)
        Me.Controls.Add(Me.txt_h_cuotas)
        Me.Controls.Add(Me.txt_h_num_fac)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cbo_d_empresa)
        Me.Controls.Add(Me.cbo_d_tipo_pago)
        Me.Controls.Add(Me.txt_d_cuotas)
        Me.Controls.Add(Me.lbl_numero_cuotas)
        Me.Controls.Add(Me.lbl_empresa)
        Me.Controls.Add(Me.lbl_tipo_pago)
        Me.Controls.Add(Me.lbl_fecha_venta)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.lbl_numero_factura)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.txt_d_num_fac)
        Me.Controls.Add(Me.cbo_cr_estado)
        Me.Controls.Add(Me.cbo_cr_cuotas)
        Me.Controls.Add(Me.cbo_cr_empresa)
        Me.Controls.Add(Me.cbo_cr_tipo_pago)
        Me.Controls.Add(Me.cbo_cr_fecha)
        Me.Controls.Add(Me.cbo_cr_numero_factura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Filtro_v"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_h_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_h_tipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents txt_h_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_num_fac As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents cbo_d_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_d_tipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents txt_d_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numero_cuotas As System.Windows.Forms.Label
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_pago As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_venta As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_factura As System.Windows.Forms.Label
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents txt_d_num_fac As System.Windows.Forms.TextBox
    Friend WithEvents cbo_cr_estado As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_cuotas As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_tipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_fecha As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cr_numero_factura As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_d_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_h_fecha As System.Windows.Forms.DateTimePicker
End Class
