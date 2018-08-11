<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altas_profesores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altas_profesores))
        Me.lbl_mantenimiento = New System.Windows.Forms.Label
        Me.btn_mantenimiento = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbl_tipo_docente = New System.Windows.Forms.Label
        Me.cmb_tipo_docente = New System.Windows.Forms.ComboBox
        Me.cmb_titulo = New System.Windows.Forms.ComboBox
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.txt_celular = New System.Windows.Forms.TextBox
        Me.cmb_nacionalidad = New System.Windows.Forms.ComboBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.lbl_nacionalidad = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.txt_nro_documento = New System.Windows.Forms.TextBox
        Me.lbl_celular = New System.Windows.Forms.Label
        Me.lbl_nro_documento = New System.Windows.Forms.Label
        Me.lbl_telefono = New System.Windows.Forms.Label
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox
        Me.cmb_localidad = New System.Windows.Forms.ComboBox
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker
        Me.rdb_masculino = New System.Windows.Forms.RadioButton
        Me.rdb_femenino = New System.Windows.Forms.RadioButton
        Me.lbl_tipo_documento = New System.Windows.Forms.Label
        Me.lbl_sexo = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.lbl_fecha_nacimiento = New System.Windows.Forms.Label
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.txt_domicilio = New System.Windows.Forms.TextBox
        Me.lbl_domicilio = New System.Windows.Forms.Label
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.tp_datos_personales = New System.Windows.Forms.TabControl
        Me.tp_datos = New System.Windows.Forms.TabPage
        Me.tp_datos_personales.SuspendLayout()
        Me.tp_datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_mantenimiento
        '
        Me.lbl_mantenimiento.AutoSize = True
        Me.lbl_mantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mantenimiento.Location = New System.Drawing.Point(143, 475)
        Me.lbl_mantenimiento.Name = "lbl_mantenimiento"
        Me.lbl_mantenimiento.Size = New System.Drawing.Size(89, 13)
        Me.lbl_mantenimiento.TabIndex = 130
        Me.lbl_mantenimiento.Text = "Mantenimiento"
        '
        'btn_mantenimiento
        '
        Me.btn_mantenimiento.BackgroundImage = CType(resources.GetObject("btn_mantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btn_mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mantenimiento.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_mantenimiento.Location = New System.Drawing.Point(161, 421)
        Me.btn_mantenimiento.Name = "btn_mantenimiento"
        Me.btn_mantenimiento.Size = New System.Drawing.Size(51, 51)
        Me.btn_mantenimiento.TabIndex = 113
        Me.btn_mantenimiento.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(298, 475)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "Cancelar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(240, 475)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 128
        Me.Label20.Text = "Aceptar"
        '
        'lbl_tipo_docente
        '
        Me.lbl_tipo_docente.AutoSize = True
        Me.lbl_tipo_docente.Location = New System.Drawing.Point(66, 9)
        Me.lbl_tipo_docente.Name = "lbl_tipo_docente"
        Me.lbl_tipo_docente.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo_docente.TabIndex = 127
        Me.lbl_tipo_docente.Text = "Tipo"
        '
        'cmb_tipo_docente
        '
        Me.cmb_tipo_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_docente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo_docente.FormattingEnabled = True
        Me.cmb_tipo_docente.Items.AddRange(New Object() {"PROFESOR", "AYUDANTE"})
        Me.cmb_tipo_docente.Location = New System.Drawing.Point(109, 6)
        Me.cmb_tipo_docente.Name = "cmb_tipo_docente"
        Me.cmb_tipo_docente.Size = New System.Drawing.Size(150, 21)
        Me.cmb_tipo_docente.TabIndex = 96
        '
        'cmb_titulo
        '
        Me.cmb_titulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_titulo.FormattingEnabled = True
        Me.cmb_titulo.Location = New System.Drawing.Point(109, 345)
        Me.cmb_titulo.Name = "cmb_titulo"
        Me.cmb_titulo.Size = New System.Drawing.Size(210, 21)
        Me.cmb_titulo.TabIndex = 110
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(59, 348)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_titulo.TabIndex = 126
        Me.lbl_titulo.Text = "Título"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(301, 421)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 112
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(240, 421)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar.TabIndex = 111
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(109, 267)
        Me.txt_telefono.MaxLength = 20
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(210, 20)
        Me.txt_telefono.TabIndex = 107
        '
        'txt_celular
        '
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_celular.Location = New System.Drawing.Point(109, 293)
        Me.txt_celular.MaxLength = 20
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(210, 20)
        Me.txt_celular.TabIndex = 108
        '
        'cmb_nacionalidad
        '
        Me.cmb_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nacionalidad.Enabled = False
        Me.cmb_nacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_nacionalidad.FormattingEnabled = True
        Me.cmb_nacionalidad.Location = New System.Drawing.Point(109, 138)
        Me.cmb_nacionalidad.Name = "cmb_nacionalidad"
        Me.cmb_nacionalidad.Size = New System.Drawing.Size(210, 21)
        Me.cmb_nacionalidad.TabIndex = 101
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Location = New System.Drawing.Point(109, 319)
        Me.txt_email.MaxLength = 60
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(210, 20)
        Me.txt_email.TabIndex = 109
        '
        'lbl_nacionalidad
        '
        Me.lbl_nacionalidad.AutoSize = True
        Me.lbl_nacionalidad.Location = New System.Drawing.Point(25, 141)
        Me.lbl_nacionalidad.Name = "lbl_nacionalidad"
        Me.lbl_nacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lbl_nacionalidad.TabIndex = 121
        Me.lbl_nacionalidad.Text = "Nacionalidad"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(62, 322)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 124
        Me.lbl_email.Text = "Email"
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_documento.Enabled = False
        Me.txt_nro_documento.Location = New System.Drawing.Point(109, 241)
        Me.txt_nro_documento.MaxLength = 8
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(210, 20)
        Me.txt_nro_documento.TabIndex = 106
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(55, 296)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(39, 13)
        Me.lbl_celular.TabIndex = 123
        Me.lbl_celular.Text = "Celular"
        '
        'lbl_nro_documento
        '
        Me.lbl_nro_documento.AutoSize = True
        Me.lbl_nro_documento.Location = New System.Drawing.Point(17, 244)
        Me.lbl_nro_documento.Name = "lbl_nro_documento"
        Me.lbl_nro_documento.Size = New System.Drawing.Size(77, 13)
        Me.lbl_nro_documento.TabIndex = 125
        Me.lbl_nro_documento.Text = "Nº Documento"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(45, 270)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 122
        Me.lbl_telefono.Text = "Telefono"
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(109, 214)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(89, 21)
        Me.cmb_tipo_documento.TabIndex = 105
        '
        'cmb_localidad
        '
        Me.cmb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_localidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(109, 111)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(210, 21)
        Me.cmb_localidad.TabIndex = 100
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(109, 165)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(89, 20)
        Me.dtp_fecha_nac.TabIndex = 102
        '
        'rdb_masculino
        '
        Me.rdb_masculino.AutoSize = True
        Me.rdb_masculino.Checked = True
        Me.rdb_masculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdb_masculino.Location = New System.Drawing.Point(109, 191)
        Me.rdb_masculino.Name = "rdb_masculino"
        Me.rdb_masculino.Size = New System.Drawing.Size(72, 17)
        Me.rdb_masculino.TabIndex = 104
        Me.rdb_masculino.TabStop = True
        Me.rdb_masculino.Text = "Masculino"
        Me.rdb_masculino.UseVisualStyleBackColor = True
        '
        'rdb_femenino
        '
        Me.rdb_femenino.AutoSize = True
        Me.rdb_femenino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdb_femenino.Location = New System.Drawing.Point(187, 191)
        Me.rdb_femenino.Name = "rdb_femenino"
        Me.rdb_femenino.Size = New System.Drawing.Size(70, 17)
        Me.rdb_femenino.TabIndex = 103
        Me.rdb_femenino.TabStop = True
        Me.rdb_femenino.Text = "Femenino"
        Me.rdb_femenino.UseVisualStyleBackColor = True
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(8, 217)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipo_documento.TabIndex = 120
        Me.lbl_tipo_documento.Text = "Tipo Documento"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(63, 193)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_sexo.TabIndex = 119
        Me.lbl_sexo.Text = "Sexo"
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Location = New System.Drawing.Point(109, 33)
        Me.txt_nombre.MaxLength = 20
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(210, 20)
        Me.txt_nombre.TabIndex = 97
        '
        'lbl_fecha_nacimiento
        '
        Me.lbl_fecha_nacimiento.AutoSize = True
        Me.lbl_fecha_nacimiento.Location = New System.Drawing.Point(16, 169)
        Me.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento"
        Me.lbl_fecha_nacimiento.Size = New System.Drawing.Size(78, 13)
        Me.lbl_fecha_nacimiento.TabIndex = 118
        Me.lbl_fecha_nacimiento.Text = "Fecha de Nac."
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido.Location = New System.Drawing.Point(109, 59)
        Me.txt_apellido.MaxLength = 30
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(210, 20)
        Me.txt_apellido.TabIndex = 98
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(41, 114)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 117
        Me.lbl_localidad.Text = "Localidad"
        '
        'txt_domicilio
        '
        Me.txt_domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_domicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_domicilio.Location = New System.Drawing.Point(109, 85)
        Me.txt_domicilio.MaxLength = 50
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(210, 20)
        Me.txt_domicilio.TabIndex = 99
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(45, 88)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_domicilio.TabIndex = 116
        Me.lbl_domicilio.Text = "Domicilio"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(50, 62)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 115
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(50, 36)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 114
        Me.lbl_nombre.Text = "Nombre"
        '
        'tp_datos_personales
        '
        Me.tp_datos_personales.Controls.Add(Me.tp_datos)
        Me.tp_datos_personales.Location = New System.Drawing.Point(12, 12)
        Me.tp_datos_personales.Name = "tp_datos_personales"
        Me.tp_datos_personales.SelectedIndex = 0
        Me.tp_datos_personales.Size = New System.Drawing.Size(340, 403)
        Me.tp_datos_personales.TabIndex = 131
        '
        'tp_datos
        '
        Me.tp_datos.Controls.Add(Me.cmb_tipo_docente)
        Me.tp_datos.Controls.Add(Me.lbl_nombre)
        Me.tp_datos.Controls.Add(Me.lbl_apellido)
        Me.tp_datos.Controls.Add(Me.lbl_domicilio)
        Me.tp_datos.Controls.Add(Me.txt_domicilio)
        Me.tp_datos.Controls.Add(Me.lbl_tipo_docente)
        Me.tp_datos.Controls.Add(Me.lbl_localidad)
        Me.tp_datos.Controls.Add(Me.txt_apellido)
        Me.tp_datos.Controls.Add(Me.cmb_titulo)
        Me.tp_datos.Controls.Add(Me.lbl_fecha_nacimiento)
        Me.tp_datos.Controls.Add(Me.lbl_titulo)
        Me.tp_datos.Controls.Add(Me.txt_nombre)
        Me.tp_datos.Controls.Add(Me.lbl_sexo)
        Me.tp_datos.Controls.Add(Me.lbl_tipo_documento)
        Me.tp_datos.Controls.Add(Me.txt_telefono)
        Me.tp_datos.Controls.Add(Me.rdb_femenino)
        Me.tp_datos.Controls.Add(Me.txt_celular)
        Me.tp_datos.Controls.Add(Me.rdb_masculino)
        Me.tp_datos.Controls.Add(Me.cmb_nacionalidad)
        Me.tp_datos.Controls.Add(Me.dtp_fecha_nac)
        Me.tp_datos.Controls.Add(Me.txt_email)
        Me.tp_datos.Controls.Add(Me.cmb_localidad)
        Me.tp_datos.Controls.Add(Me.lbl_nacionalidad)
        Me.tp_datos.Controls.Add(Me.cmb_tipo_documento)
        Me.tp_datos.Controls.Add(Me.lbl_email)
        Me.tp_datos.Controls.Add(Me.lbl_telefono)
        Me.tp_datos.Controls.Add(Me.txt_nro_documento)
        Me.tp_datos.Controls.Add(Me.lbl_nro_documento)
        Me.tp_datos.Controls.Add(Me.lbl_celular)
        Me.tp_datos.Location = New System.Drawing.Point(4, 22)
        Me.tp_datos.Name = "tp_datos"
        Me.tp_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_datos.Size = New System.Drawing.Size(332, 377)
        Me.tp_datos.TabIndex = 0
        Me.tp_datos.Text = "Datos"
        Me.tp_datos.UseVisualStyleBackColor = True
        '
        'altas_profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 496)
        Me.Controls.Add(Me.tp_datos_personales)
        Me.Controls.Add(Me.lbl_mantenimiento)
        Me.Controls.Add(Me.btn_mantenimiento)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "altas_profesores"
        Me.Text = "altas_profesores"
        Me.tp_datos_personales.ResumeLayout(False)
        Me.tp_datos.ResumeLayout(False)
        Me.tp_datos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_mantenimiento As System.Windows.Forms.Label
    Friend WithEvents btn_mantenimiento As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_docente As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_docente As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_titulo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents cmb_nacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nacionalidad As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_celular As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdb_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha_nacimiento As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents tp_datos_personales As System.Windows.Forms.TabControl
    Friend WithEvents tp_datos As System.Windows.Forms.TabPage
End Class
