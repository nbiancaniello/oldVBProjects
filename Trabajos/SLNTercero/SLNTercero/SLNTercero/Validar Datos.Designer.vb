<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validar_Datos
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
        Me.cmb_localidad = New System.Windows.Forms.ComboBox
        Me.txt_domicilio = New System.Windows.Forms.TextBox
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.lbl_domicilio = New System.Windows.Forms.Label
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker
        Me.lbl_fec_nac = New System.Windows.Forms.Label
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.grb_sexo = New System.Windows.Forms.GroupBox
        Me.rdb_masculino = New System.Windows.Forms.RadioButton
        Me.rdb_femenino = New System.Windows.Forms.RadioButton
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.lbl_telefono = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_cuil = New System.Windows.Forms.Label
        Me.btn_buscarfoto = New System.Windows.Forms.Button
        Me.chk_box1 = New System.Windows.Forms.CheckBox
        Me.chk_box2 = New System.Windows.Forms.CheckBox
        Me.chk_box3 = New System.Windows.Forms.CheckBox
        Me.chk_box4 = New System.Windows.Forms.CheckBox
        Me.chk_box5 = New System.Windows.Forms.CheckBox
        Me.chk_box6 = New System.Windows.Forms.CheckBox
        Me.grb_intereses = New System.Windows.Forms.GroupBox
        Me.txt_numero_domicilio = New System.Windows.Forms.TextBox
        Me.lbl_numero_domicilio = New System.Windows.Forms.Label
        Me.pcb_foto = New System.Windows.Forms.PictureBox
        Me.opf_Foto = New System.Windows.Forms.OpenFileDialog
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.msk_cuil = New System.Windows.Forms.MaskedTextBox
        Me.grb_sexo.SuspendLayout()
        Me.grb_intereses.SuspendLayout()
        CType(Me.pcb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_localidad
        '
        Me.cmb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Items.AddRange(New Object() {"Bella Vista", "Don Torcuato", "El Talar", "Garín", "General Pacheco", "Hurlingham", "José C. Paz", "Moreno", "San Miguel", "Tortuguitas"})
        Me.cmb_localidad.Location = New System.Drawing.Point(71, 128)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(178, 21)
        Me.cmb_localidad.Sorted = True
        Me.cmb_localidad.TabIndex = 4
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(71, 70)
        Me.txt_domicilio.MaxLength = 30
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(178, 20)
        Me.txt_domicilio.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(71, 41)
        Me.txt_apellido.MaxLength = 30
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(178, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(71, 12)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(178, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(5, 73)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(52, 13)
        Me.lbl_domicilio.TabIndex = 13
        Me.lbl_domicilio.Text = "Domicilio:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(10, 44)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 12
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(10, 15)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 11
        Me.lbl_nombre.Text = "Nombre:"
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(143, 225)
        Me.dtp_fecha_nac.MaxDate = New Date(2007, 10, 14, 0, 0, 0, 0)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(106, 20)
        Me.dtp_fecha_nac.TabIndex = 7
        Me.dtp_fecha_nac.Value = New Date(2007, 4, 28, 0, 0, 0, 0)
        '
        'lbl_fec_nac
        '
        Me.lbl_fec_nac.AutoSize = True
        Me.lbl_fec_nac.Location = New System.Drawing.Point(5, 226)
        Me.lbl_fec_nac.Name = "lbl_fec_nac"
        Me.lbl_fec_nac.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fec_nac.TabIndex = 20
        Me.lbl_fec_nac.Text = "Fecha de nacimiento:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(1, 131)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 22
        Me.lbl_localidad.Text = "Localidad:"
        '
        'grb_sexo
        '
        Me.grb_sexo.Controls.Add(Me.rdb_masculino)
        Me.grb_sexo.Controls.Add(Me.rdb_femenino)
        Me.grb_sexo.Location = New System.Drawing.Point(56, 260)
        Me.grb_sexo.Name = "grb_sexo"
        Me.grb_sexo.Size = New System.Drawing.Size(193, 49)
        Me.grb_sexo.TabIndex = 8
        Me.grb_sexo.TabStop = False
        Me.grb_sexo.Text = "Sexo"
        '
        'rdb_masculino
        '
        Me.rdb_masculino.AutoSize = True
        Me.rdb_masculino.Location = New System.Drawing.Point(100, 19)
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
        Me.rdb_femenino.Location = New System.Drawing.Point(23, 19)
        Me.rdb_femenino.Name = "rdb_femenino"
        Me.rdb_femenino.Size = New System.Drawing.Size(71, 17)
        Me.rdb_femenino.TabIndex = 0
        Me.rdb_femenino.TabStop = True
        Me.rdb_femenino.Text = "Femenino"
        Me.rdb_femenino.UseVisualStyleBackColor = True
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(71, 158)
        Me.txt_telefono.MaxLength = 20
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(178, 20)
        Me.txt_telefono.TabIndex = 5
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(5, 161)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 24
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(71, 187)
        Me.txt_email.MaxLength = 60
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(178, 20)
        Me.txt_email.TabIndex = 6
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(19, 190)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 26
        Me.lbl_email.Text = "E-mail:"
        '
        'lbl_cuil
        '
        Me.lbl_cuil.AutoSize = True
        Me.lbl_cuil.Location = New System.Drawing.Point(19, 329)
        Me.lbl_cuil.Name = "lbl_cuil"
        Me.lbl_cuil.Size = New System.Drawing.Size(34, 13)
        Me.lbl_cuil.TabIndex = 28
        Me.lbl_cuil.Text = "CUIL:"
        '
        'btn_buscarfoto
        '
        Me.btn_buscarfoto.Location = New System.Drawing.Point(317, 11)
        Me.btn_buscarfoto.Name = "btn_buscarfoto"
        Me.btn_buscarfoto.Size = New System.Drawing.Size(80, 21)
        Me.btn_buscarfoto.TabIndex = 10
        Me.btn_buscarfoto.Text = "&Buscar"
        Me.btn_buscarfoto.UseVisualStyleBackColor = True
        '
        'chk_box1
        '
        Me.chk_box1.AutoSize = True
        Me.chk_box1.Location = New System.Drawing.Point(6, 19)
        Me.chk_box1.Name = "chk_box1"
        Me.chk_box1.Size = New System.Drawing.Size(69, 17)
        Me.chk_box1.TabIndex = 0
        Me.chk_box1.Text = "Deportes"
        Me.chk_box1.UseVisualStyleBackColor = True
        '
        'chk_box2
        '
        Me.chk_box2.AutoSize = True
        Me.chk_box2.Location = New System.Drawing.Point(6, 42)
        Me.chk_box2.Name = "chk_box2"
        Me.chk_box2.Size = New System.Drawing.Size(88, 17)
        Me.chk_box2.TabIndex = 1
        Me.chk_box2.Text = "Computación"
        Me.chk_box2.UseVisualStyleBackColor = True
        '
        'chk_box3
        '
        Me.chk_box3.AutoSize = True
        Me.chk_box3.Location = New System.Drawing.Point(6, 65)
        Me.chk_box3.Name = "chk_box3"
        Me.chk_box3.Size = New System.Drawing.Size(75, 17)
        Me.chk_box3.TabIndex = 2
        Me.chk_box3.Text = "Economía"
        Me.chk_box3.UseVisualStyleBackColor = True
        '
        'chk_box4
        '
        Me.chk_box4.AutoSize = True
        Me.chk_box4.Location = New System.Drawing.Point(6, 88)
        Me.chk_box4.Name = "chk_box4"
        Me.chk_box4.Size = New System.Drawing.Size(45, 17)
        Me.chk_box4.TabIndex = 3
        Me.chk_box4.Text = "Arte"
        Me.chk_box4.UseVisualStyleBackColor = True
        '
        'chk_box5
        '
        Me.chk_box5.AutoSize = True
        Me.chk_box5.Location = New System.Drawing.Point(6, 111)
        Me.chk_box5.Name = "chk_box5"
        Me.chk_box5.Size = New System.Drawing.Size(69, 17)
        Me.chk_box5.TabIndex = 4
        Me.chk_box5.Text = "Ecología"
        Me.chk_box5.UseVisualStyleBackColor = True
        '
        'chk_box6
        '
        Me.chk_box6.AutoSize = True
        Me.chk_box6.Location = New System.Drawing.Point(6, 134)
        Me.chk_box6.Name = "chk_box6"
        Me.chk_box6.Size = New System.Drawing.Size(71, 17)
        Me.chk_box6.TabIndex = 5
        Me.chk_box6.Text = "Sociedad"
        Me.chk_box6.UseVisualStyleBackColor = True
        '
        'grb_intereses
        '
        Me.grb_intereses.Controls.Add(Me.chk_box1)
        Me.grb_intereses.Controls.Add(Me.chk_box6)
        Me.grb_intereses.Controls.Add(Me.chk_box2)
        Me.grb_intereses.Controls.Add(Me.chk_box5)
        Me.grb_intereses.Controls.Add(Me.chk_box3)
        Me.grb_intereses.Controls.Add(Me.chk_box4)
        Me.grb_intereses.Location = New System.Drawing.Point(283, 184)
        Me.grb_intereses.Name = "grb_intereses"
        Me.grb_intereses.Size = New System.Drawing.Size(114, 158)
        Me.grb_intereses.TabIndex = 11
        Me.grb_intereses.TabStop = False
        Me.grb_intereses.Text = "Intereses"
        '
        'txt_numero_domicilio
        '
        Me.txt_numero_domicilio.Location = New System.Drawing.Point(71, 99)
        Me.txt_numero_domicilio.MaxLength = 5
        Me.txt_numero_domicilio.Name = "txt_numero_domicilio"
        Me.txt_numero_domicilio.Size = New System.Drawing.Size(57, 20)
        Me.txt_numero_domicilio.TabIndex = 3
        '
        'lbl_numero_domicilio
        '
        Me.lbl_numero_domicilio.AutoSize = True
        Me.lbl_numero_domicilio.Location = New System.Drawing.Point(5, 102)
        Me.lbl_numero_domicilio.Name = "lbl_numero_domicilio"
        Me.lbl_numero_domicilio.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero_domicilio.TabIndex = 38
        Me.lbl_numero_domicilio.Text = "Número:"
        '
        'pcb_foto
        '
        Me.pcb_foto.Location = New System.Drawing.Point(283, 44)
        Me.pcb_foto.Name = "pcb_foto"
        Me.pcb_foto.Size = New System.Drawing.Size(113, 113)
        Me.pcb_foto.TabIndex = 40
        Me.pcb_foto.TabStop = False
        '
        'opf_Foto
        '
        Me.opf_Foto.DefaultExt = "*.jpg, *.gif"
        Me.opf_Foto.FileName = "*.jpg"
        Me.opf_Foto.Filter = "Imagenes (*.jpg),(*.gif) |.jpg, .gif"
        Me.opf_Foto.ReadOnlyChecked = True
        Me.opf_Foto.RestoreDirectory = True
        Me.opf_Foto.Title = "Seleccionar Foto"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(252, 361)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(69, 21)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(327, 361)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(69, 21)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'msk_cuil
        '
        Me.msk_cuil.Location = New System.Drawing.Point(71, 326)
        Me.msk_cuil.Mask = "00-00000000-0"
        Me.msk_cuil.Name = "msk_cuil"
        Me.msk_cuil.Size = New System.Drawing.Size(89, 20)
        Me.msk_cuil.TabIndex = 41
        Me.msk_cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Validar_Datos
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(409, 394)
        Me.Controls.Add(Me.msk_cuil)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.pcb_foto)
        Me.Controls.Add(Me.txt_numero_domicilio)
        Me.Controls.Add(Me.lbl_numero_domicilio)
        Me.Controls.Add(Me.grb_intereses)
        Me.Controls.Add(Me.btn_buscarfoto)
        Me.Controls.Add(Me.lbl_cuil)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.grb_sexo)
        Me.Controls.Add(Me.lbl_localidad)
        Me.Controls.Add(Me.dtp_fecha_nac)
        Me.Controls.Add(Me.lbl_fec_nac)
        Me.Controls.Add(Me.cmb_localidad)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_domicilio)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "Validar_Datos"
        Me.Text = "Validar_Datos"
        Me.grb_sexo.ResumeLayout(False)
        Me.grb_sexo.PerformLayout()
        Me.grb_intereses.ResumeLayout(False)
        Me.grb_intereses.PerformLayout()
        CType(Me.pcb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fec_nac As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents grb_sexo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_cuil As System.Windows.Forms.Label
    Friend WithEvents btn_buscarfoto As System.Windows.Forms.Button
    Friend WithEvents chk_box1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_box2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_box3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_box4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_box5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_box6 As System.Windows.Forms.CheckBox
    Friend WithEvents grb_intereses As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numero_domicilio As System.Windows.Forms.Label
    Friend WithEvents pcb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents opf_Foto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents msk_cuil As System.Windows.Forms.MaskedTextBox
End Class
