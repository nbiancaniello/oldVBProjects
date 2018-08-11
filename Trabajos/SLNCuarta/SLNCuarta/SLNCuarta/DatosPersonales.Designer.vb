<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosPersonales
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
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_celular = New System.Windows.Forms.TextBox
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.msk_legajo = New System.Windows.Forms.MaskedTextBox
        Me.lbl_legajo = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.lbl_celular = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.grp_sexo = New System.Windows.Forms.GroupBox
        Me.rdb_masculino = New System.Windows.Forms.RadioButton
        Me.rdb_femenino = New System.Windows.Forms.RadioButton
        Me.dtp_fecha_nacimiento = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.lbl_separador = New System.Windows.Forms.Label
        Me.txt_legajo = New System.Windows.Forms.TextBox
        Me.grp_sexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(111, 46)
        Me.txt_nombre.MaxLength = 40
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(152, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(111, 124)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(152, 20)
        Me.txt_email.TabIndex = 4
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(111, 98)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(152, 20)
        Me.txt_celular.TabIndex = 3
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(111, 72)
        Me.txt_telefono.MaxLength = 20
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(152, 20)
        Me.txt_telefono.TabIndex = 2
        '
        'msk_legajo
        '
        Me.msk_legajo.Location = New System.Drawing.Point(111, 20)
        Me.msk_legajo.Mask = "18"
        Me.msk_legajo.Name = "msk_legajo"
        Me.msk_legajo.Size = New System.Drawing.Size(21, 20)
        Me.msk_legajo.TabIndex = 15
        Me.msk_legajo.TabStop = False
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(14, 23)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_legajo.TabIndex = 5
        Me.lbl_legajo.Text = "Legajo"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(14, 49)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(91, 13)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "Nombre y apellido"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(14, 75)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(49, 13)
        Me.lbl_apellido.TabIndex = 7
        Me.lbl_apellido.Text = "Teléfono"
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(14, 101)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(39, 13)
        Me.lbl_celular.TabIndex = 8
        Me.lbl_celular.Text = "Celular"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(14, 127)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(34, 13)
        Me.lbl_email.TabIndex = 9
        Me.lbl_email.Text = "e-mail"
        '
        'grp_sexo
        '
        Me.grp_sexo.Controls.Add(Me.rdb_masculino)
        Me.grp_sexo.Controls.Add(Me.rdb_femenino)
        Me.grp_sexo.Location = New System.Drawing.Point(289, 20)
        Me.grp_sexo.Name = "grp_sexo"
        Me.grp_sexo.Size = New System.Drawing.Size(92, 75)
        Me.grp_sexo.TabIndex = 5
        Me.grp_sexo.TabStop = False
        Me.grp_sexo.Text = "Sexo"
        '
        'rdb_masculino
        '
        Me.rdb_masculino.AutoSize = True
        Me.rdb_masculino.Location = New System.Drawing.Point(11, 45)
        Me.rdb_masculino.Name = "rdb_masculino"
        Me.rdb_masculino.Size = New System.Drawing.Size(73, 17)
        Me.rdb_masculino.TabIndex = 1
        Me.rdb_masculino.TabStop = True
        Me.rdb_masculino.Text = "Masculino"
        Me.rdb_masculino.UseVisualStyleBackColor = True
        '
        'rdb_femenino
        '
        Me.rdb_femenino.AutoSize = True
        Me.rdb_femenino.Location = New System.Drawing.Point(11, 18)
        Me.rdb_femenino.Name = "rdb_femenino"
        Me.rdb_femenino.Size = New System.Drawing.Size(71, 17)
        Me.rdb_femenino.TabIndex = 0
        Me.rdb_femenino.TabStop = True
        Me.rdb_femenino.Text = "Femenino"
        Me.rdb_femenino.UseVisualStyleBackColor = True
        '
        'dtp_fecha_nacimiento
        '
        Me.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nacimiento.Location = New System.Drawing.Point(289, 124)
        Me.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento"
        Me.dtp_fecha_nacimiento.Size = New System.Drawing.Size(92, 20)
        Me.dtp_fecha_nacimiento.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha de Nacimiento"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Image = Global.SLNCuarta.My.Resources.Resources.smallfail
        Me.btn_cancelar.Location = New System.Drawing.Point(400, 78)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(37, 34)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Image = Global.SLNCuarta.My.Resources.Resources.smallsuccess
        Me.btn_aceptar.Location = New System.Drawing.Point(400, 38)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(37, 34)
        Me.btn_aceptar.TabIndex = 13
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_separador
        '
        Me.lbl_separador.AutoSize = True
        Me.lbl_separador.Location = New System.Drawing.Point(135, 23)
        Me.lbl_separador.Name = "lbl_separador"
        Me.lbl_separador.Size = New System.Drawing.Size(10, 13)
        Me.lbl_separador.TabIndex = 15
        Me.lbl_separador.Text = "-"
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(151, 20)
        Me.txt_legajo.MaxLength = 5
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(40, 20)
        Me.txt_legajo.TabIndex = 0
        '
        'DatosPersonales
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(448, 162)
        Me.Controls.Add(Me.txt_legajo)
        Me.Controls.Add(Me.lbl_separador)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_fecha_nacimiento)
        Me.Controls.Add(Me.grp_sexo)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_celular)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_legajo)
        Me.Controls.Add(Me.msk_legajo)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatosPersonales"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grp_sexo.ResumeLayout(False)
        Me.grp_sexo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents msk_legajo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_legajo As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_celular As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents grp_sexo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_fecha_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_separador As System.Windows.Forms.Label
    Friend WithEvents txt_legajo As System.Windows.Forms.TextBox
End Class
