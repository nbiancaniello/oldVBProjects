<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asistencias_introductorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(asistencias_introductorio))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_volver_atras = New System.Windows.Forms.Button
        Me.grp_planilla = New System.Windows.Forms.GroupBox
        Me.lbl_et_estado = New System.Windows.Forms.Label
        Me.lbl_estado = New System.Windows.Forms.Label
        Me.grp_nro_clase = New System.Windows.Forms.GroupBox
        Me.txt_nro_clase = New System.Windows.Forms.TextBox
        Me.btn_clase_ok = New System.Windows.Forms.Button
        Me.lbl_nroplanilla = New System.Windows.Forms.Label
        Me.lbl_et_planilla = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.grp_estados = New System.Windows.Forms.GroupBox
        Me.btn_tarde_con_aviso = New System.Windows.Forms.Button
        Me.btn_tarde = New System.Windows.Forms.Button
        Me.btn_ausente = New System.Windows.Forms.Button
        Me.btn_presente = New System.Windows.Forms.Button
        Me.lbl_instancia = New System.Windows.Forms.Label
        Me.lbl_anio = New System.Windows.Forms.Label
        Me.lbl_et_inst = New System.Windows.Forms.Label
        Me.lbl_et_anio = New System.Windows.Forms.Label
        Me.lbl_dias = New System.Windows.Forms.Label
        Me.lbl_et_dias = New System.Windows.Forms.Label
        Me.lbl_comision = New System.Windows.Forms.Label
        Me.lbl_curso = New System.Windows.Forms.Label
        Me.lbl_et_comision = New System.Windows.Forms.Label
        Me.lbl_et_curso = New System.Windows.Forms.Label
        Me.grp_fecha = New System.Windows.Forms.GroupBox
        Me.btn_fecha_ok = New System.Windows.Forms.Button
        Me.dtp_fecha_asistencia = New System.Windows.Forms.DateTimePicker
        Me.lbl_profesor = New System.Windows.Forms.Label
        Me.lbl_et_profesor = New System.Windows.Forms.Label
        Me.lsv_planilla = New System.Windows.Forms.ListView
        Me.col_nroinscripcion = New System.Windows.Forms.ColumnHeader
        Me.col_anioingreso = New System.Windows.Forms.ColumnHeader
        Me.col_alumno = New System.Windows.Forms.ColumnHeader
        Me.grp_cabecera = New System.Windows.Forms.GroupBox
        Me.cmb_instancia = New System.Windows.Forms.ComboBox
        Me.lbl_et_instancia = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_et_anio_2 = New System.Windows.Forms.Label
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.cmb_anios = New System.Windows.Forms.ComboBox
        Me.btn_registrar_asistencias = New System.Windows.Forms.Button
        Me.lsv_materias = New System.Windows.Forms.ListView
        Me.col_nroplanilla = New System.Windows.Forms.ColumnHeader
        Me.col_codmateria = New System.Windows.Forms.ColumnHeader
        Me.col_descripcion = New System.Windows.Forms.ColumnHeader
        Me.col_estado = New System.Windows.Forms.ColumnHeader
        Me.grp_planilla.SuspendLayout()
        Me.grp_nro_clase.SuspendLayout()
        Me.grp_estados.SuspendLayout()
        Me.grp_fecha.SuspendLayout()
        Me.grp_cabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(897, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Regresar"
        '
        'btn_volver_atras
        '
        Me.btn_volver_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver_atras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_volver_atras.Image = CType(resources.GetObject("btn_volver_atras.Image"), System.Drawing.Image)
        Me.btn_volver_atras.Location = New System.Drawing.Point(900, 12)
        Me.btn_volver_atras.Name = "btn_volver_atras"
        Me.btn_volver_atras.Size = New System.Drawing.Size(51, 51)
        Me.btn_volver_atras.TabIndex = 71
        Me.btn_volver_atras.UseVisualStyleBackColor = True
        '
        'grp_planilla
        '
        Me.grp_planilla.Controls.Add(Me.lbl_et_estado)
        Me.grp_planilla.Controls.Add(Me.lbl_estado)
        Me.grp_planilla.Controls.Add(Me.grp_nro_clase)
        Me.grp_planilla.Controls.Add(Me.lbl_nroplanilla)
        Me.grp_planilla.Controls.Add(Me.lbl_et_planilla)
        Me.grp_planilla.Controls.Add(Me.btn_cancelar)
        Me.grp_planilla.Controls.Add(Me.btn_aceptar)
        Me.grp_planilla.Controls.Add(Me.grp_estados)
        Me.grp_planilla.Controls.Add(Me.lbl_instancia)
        Me.grp_planilla.Controls.Add(Me.lbl_anio)
        Me.grp_planilla.Controls.Add(Me.lbl_et_inst)
        Me.grp_planilla.Controls.Add(Me.lbl_et_anio)
        Me.grp_planilla.Controls.Add(Me.lbl_dias)
        Me.grp_planilla.Controls.Add(Me.lbl_et_dias)
        Me.grp_planilla.Controls.Add(Me.lbl_comision)
        Me.grp_planilla.Controls.Add(Me.lbl_curso)
        Me.grp_planilla.Controls.Add(Me.lbl_et_comision)
        Me.grp_planilla.Controls.Add(Me.lbl_et_curso)
        Me.grp_planilla.Controls.Add(Me.grp_fecha)
        Me.grp_planilla.Controls.Add(Me.lbl_profesor)
        Me.grp_planilla.Controls.Add(Me.lbl_et_profesor)
        Me.grp_planilla.Controls.Add(Me.lsv_planilla)
        Me.grp_planilla.Enabled = False
        Me.grp_planilla.Location = New System.Drawing.Point(248, 12)
        Me.grp_planilla.Name = "grp_planilla"
        Me.grp_planilla.Size = New System.Drawing.Size(646, 496)
        Me.grp_planilla.TabIndex = 70
        Me.grp_planilla.TabStop = False
        '
        'lbl_et_estado
        '
        Me.lbl_et_estado.AutoSize = True
        Me.lbl_et_estado.Location = New System.Drawing.Point(487, 40)
        Me.lbl_et_estado.Name = "lbl_et_estado"
        Me.lbl_et_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_et_estado.TabIndex = 24
        Me.lbl_et_estado.Text = "Estado"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(533, 41)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_estado.TabIndex = 23
        '
        'grp_nro_clase
        '
        Me.grp_nro_clase.Controls.Add(Me.txt_nro_clase)
        Me.grp_nro_clase.Controls.Add(Me.btn_clase_ok)
        Me.grp_nro_clase.Enabled = False
        Me.grp_nro_clase.Location = New System.Drawing.Point(171, 414)
        Me.grp_nro_clase.Name = "grp_nro_clase"
        Me.grp_nro_clase.Size = New System.Drawing.Size(122, 73)
        Me.grp_nro_clase.TabIndex = 22
        Me.grp_nro_clase.TabStop = False
        Me.grp_nro_clase.Text = "Modificar Clase"
        '
        'txt_nro_clase
        '
        Me.txt_nro_clase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_clase.Location = New System.Drawing.Point(6, 30)
        Me.txt_nro_clase.MaxLength = 2
        Me.txt_nro_clase.Name = "txt_nro_clase"
        Me.txt_nro_clase.Size = New System.Drawing.Size(52, 20)
        Me.txt_nro_clase.TabIndex = 2
        '
        'btn_clase_ok
        '
        Me.btn_clase_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clase_ok.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clase_ok.Image = CType(resources.GetObject("btn_clase_ok.Image"), System.Drawing.Image)
        Me.btn_clase_ok.Location = New System.Drawing.Point(64, 13)
        Me.btn_clase_ok.Name = "btn_clase_ok"
        Me.btn_clase_ok.Size = New System.Drawing.Size(51, 51)
        Me.btn_clase_ok.TabIndex = 1
        Me.btn_clase_ok.Text = " "
        Me.btn_clase_ok.UseVisualStyleBackColor = True
        '
        'lbl_nroplanilla
        '
        Me.lbl_nroplanilla.AutoSize = True
        Me.lbl_nroplanilla.Location = New System.Drawing.Point(533, 16)
        Me.lbl_nroplanilla.Name = "lbl_nroplanilla"
        Me.lbl_nroplanilla.Size = New System.Drawing.Size(0, 13)
        Me.lbl_nroplanilla.TabIndex = 21
        '
        'lbl_et_planilla
        '
        Me.lbl_et_planilla.AutoSize = True
        Me.lbl_et_planilla.Location = New System.Drawing.Point(472, 16)
        Me.lbl_et_planilla.Name = "lbl_et_planilla"
        Me.lbl_et_planilla.Size = New System.Drawing.Size(55, 13)
        Me.lbl_et_planilla.TabIndex = 20
        Me.lbl_et_planilla.Text = "Planilla Nº"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(589, 58)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 19
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(532, 58)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar.TabIndex = 18
        Me.btn_aceptar.Text = " "
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'grp_estados
        '
        Me.grp_estados.Controls.Add(Me.btn_tarde_con_aviso)
        Me.grp_estados.Controls.Add(Me.btn_tarde)
        Me.grp_estados.Controls.Add(Me.btn_ausente)
        Me.grp_estados.Controls.Add(Me.btn_presente)
        Me.grp_estados.Enabled = False
        Me.grp_estados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_estados.Location = New System.Drawing.Point(299, 414)
        Me.grp_estados.Name = "grp_estados"
        Me.grp_estados.Size = New System.Drawing.Size(333, 73)
        Me.grp_estados.TabIndex = 16
        Me.grp_estados.TabStop = False
        Me.grp_estados.Text = "Asistencia"
        '
        'btn_tarde_con_aviso
        '
        Me.btn_tarde_con_aviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tarde_con_aviso.Location = New System.Drawing.Point(250, 28)
        Me.btn_tarde_con_aviso.Name = "btn_tarde_con_aviso"
        Me.btn_tarde_con_aviso.Size = New System.Drawing.Size(75, 23)
        Me.btn_tarde_con_aviso.TabIndex = 5
        Me.btn_tarde_con_aviso.Text = "T. c/Aviso"
        Me.btn_tarde_con_aviso.UseVisualStyleBackColor = True
        '
        'btn_tarde
        '
        Me.btn_tarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tarde.Location = New System.Drawing.Point(169, 28)
        Me.btn_tarde.Name = "btn_tarde"
        Me.btn_tarde.Size = New System.Drawing.Size(75, 23)
        Me.btn_tarde.TabIndex = 4
        Me.btn_tarde.Text = "Tarde"
        Me.btn_tarde.UseVisualStyleBackColor = True
        '
        'btn_ausente
        '
        Me.btn_ausente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ausente.Location = New System.Drawing.Point(88, 28)
        Me.btn_ausente.Name = "btn_ausente"
        Me.btn_ausente.Size = New System.Drawing.Size(75, 23)
        Me.btn_ausente.TabIndex = 3
        Me.btn_ausente.Text = "Ausente"
        Me.btn_ausente.UseVisualStyleBackColor = True
        '
        'btn_presente
        '
        Me.btn_presente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_presente.Location = New System.Drawing.Point(7, 28)
        Me.btn_presente.Name = "btn_presente"
        Me.btn_presente.Size = New System.Drawing.Size(75, 23)
        Me.btn_presente.TabIndex = 2
        Me.btn_presente.Text = "Presente"
        Me.btn_presente.UseVisualStyleBackColor = True
        '
        'lbl_instancia
        '
        Me.lbl_instancia.AutoSize = True
        Me.lbl_instancia.Location = New System.Drawing.Point(350, 41)
        Me.lbl_instancia.Name = "lbl_instancia"
        Me.lbl_instancia.Size = New System.Drawing.Size(0, 13)
        Me.lbl_instancia.TabIndex = 15
        '
        'lbl_anio
        '
        Me.lbl_anio.AutoSize = True
        Me.lbl_anio.Location = New System.Drawing.Point(350, 15)
        Me.lbl_anio.Name = "lbl_anio"
        Me.lbl_anio.Size = New System.Drawing.Size(0, 13)
        Me.lbl_anio.TabIndex = 14
        '
        'lbl_et_inst
        '
        Me.lbl_et_inst.AutoSize = True
        Me.lbl_et_inst.Location = New System.Drawing.Point(294, 41)
        Me.lbl_et_inst.Name = "lbl_et_inst"
        Me.lbl_et_inst.Size = New System.Drawing.Size(50, 13)
        Me.lbl_et_inst.TabIndex = 13
        Me.lbl_et_inst.Text = "Instancia"
        '
        'lbl_et_anio
        '
        Me.lbl_et_anio.AutoSize = True
        Me.lbl_et_anio.Location = New System.Drawing.Point(318, 16)
        Me.lbl_et_anio.Name = "lbl_et_anio"
        Me.lbl_et_anio.Size = New System.Drawing.Size(26, 13)
        Me.lbl_et_anio.TabIndex = 12
        Me.lbl_et_anio.Text = "Año"
        '
        'lbl_dias
        '
        Me.lbl_dias.AutoSize = True
        Me.lbl_dias.Location = New System.Drawing.Point(350, 66)
        Me.lbl_dias.Name = "lbl_dias"
        Me.lbl_dias.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dias.TabIndex = 11
        '
        'lbl_et_dias
        '
        Me.lbl_et_dias.AutoSize = True
        Me.lbl_et_dias.Location = New System.Drawing.Point(314, 66)
        Me.lbl_et_dias.Name = "lbl_et_dias"
        Me.lbl_et_dias.Size = New System.Drawing.Size(30, 13)
        Me.lbl_et_dias.TabIndex = 10
        Me.lbl_et_dias.Text = "Días"
        '
        'lbl_comision
        '
        Me.lbl_comision.AutoSize = True
        Me.lbl_comision.Location = New System.Drawing.Point(59, 65)
        Me.lbl_comision.Name = "lbl_comision"
        Me.lbl_comision.Size = New System.Drawing.Size(0, 13)
        Me.lbl_comision.TabIndex = 9
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Location = New System.Drawing.Point(59, 40)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(0, 13)
        Me.lbl_curso.TabIndex = 8
        '
        'lbl_et_comision
        '
        Me.lbl_et_comision.AutoSize = True
        Me.lbl_et_comision.Location = New System.Drawing.Point(3, 66)
        Me.lbl_et_comision.Name = "lbl_et_comision"
        Me.lbl_et_comision.Size = New System.Drawing.Size(49, 13)
        Me.lbl_et_comision.TabIndex = 7
        Me.lbl_et_comision.Text = "Comisión"
        '
        'lbl_et_curso
        '
        Me.lbl_et_curso.AutoSize = True
        Me.lbl_et_curso.Location = New System.Drawing.Point(18, 41)
        Me.lbl_et_curso.Name = "lbl_et_curso"
        Me.lbl_et_curso.Size = New System.Drawing.Size(34, 13)
        Me.lbl_et_curso.TabIndex = 6
        Me.lbl_et_curso.Text = "Curso"
        '
        'grp_fecha
        '
        Me.grp_fecha.Controls.Add(Me.btn_fecha_ok)
        Me.grp_fecha.Controls.Add(Me.dtp_fecha_asistencia)
        Me.grp_fecha.Location = New System.Drawing.Point(6, 414)
        Me.grp_fecha.Name = "grp_fecha"
        Me.grp_fecha.Size = New System.Drawing.Size(159, 73)
        Me.grp_fecha.TabIndex = 5
        Me.grp_fecha.TabStop = False
        Me.grp_fecha.Text = "Registrar / Modificar Fecha"
        '
        'btn_fecha_ok
        '
        Me.btn_fecha_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fecha_ok.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_fecha_ok.Image = CType(resources.GetObject("btn_fecha_ok.Image"), System.Drawing.Image)
        Me.btn_fecha_ok.Location = New System.Drawing.Point(103, 14)
        Me.btn_fecha_ok.Name = "btn_fecha_ok"
        Me.btn_fecha_ok.Size = New System.Drawing.Size(51, 51)
        Me.btn_fecha_ok.TabIndex = 1
        Me.btn_fecha_ok.Text = " "
        Me.btn_fecha_ok.UseVisualStyleBackColor = True
        '
        'dtp_fecha_asistencia
        '
        Me.dtp_fecha_asistencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_asistencia.Location = New System.Drawing.Point(6, 29)
        Me.dtp_fecha_asistencia.Name = "dtp_fecha_asistencia"
        Me.dtp_fecha_asistencia.Size = New System.Drawing.Size(91, 20)
        Me.dtp_fecha_asistencia.TabIndex = 0
        '
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(56, 16)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(0, 13)
        Me.lbl_profesor.TabIndex = 3
        '
        'lbl_et_profesor
        '
        Me.lbl_et_profesor.AutoSize = True
        Me.lbl_et_profesor.Location = New System.Drawing.Point(6, 16)
        Me.lbl_et_profesor.Name = "lbl_et_profesor"
        Me.lbl_et_profesor.Size = New System.Drawing.Size(46, 13)
        Me.lbl_et_profesor.TabIndex = 2
        Me.lbl_et_profesor.Text = "Profesor"
        '
        'lsv_planilla
        '
        Me.lsv_planilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_planilla.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_nroinscripcion, Me.col_anioingreso, Me.col_alumno})
        Me.lsv_planilla.Enabled = False
        Me.lsv_planilla.FullRowSelect = True
        Me.lsv_planilla.GridLines = True
        Me.lsv_planilla.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_planilla.Location = New System.Drawing.Point(6, 113)
        Me.lsv_planilla.MultiSelect = False
        Me.lsv_planilla.Name = "lsv_planilla"
        Me.lsv_planilla.Size = New System.Drawing.Size(634, 294)
        Me.lsv_planilla.TabIndex = 1
        Me.lsv_planilla.UseCompatibleStateImageBehavior = False
        Me.lsv_planilla.View = System.Windows.Forms.View.Details
        '
        'col_nroinscripcion
        '
        Me.col_nroinscripcion.Text = ""
        Me.col_nroinscripcion.Width = 0
        '
        'col_anioingreso
        '
        Me.col_anioingreso.Text = ""
        Me.col_anioingreso.Width = 0
        '
        'col_alumno
        '
        Me.col_alumno.Text = "Apellido y Nombre"
        Me.col_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_alumno.Width = 0
        '
        'grp_cabecera
        '
        Me.grp_cabecera.Controls.Add(Me.cmb_instancia)
        Me.grp_cabecera.Controls.Add(Me.lbl_et_instancia)
        Me.grp_cabecera.Controls.Add(Me.Label4)
        Me.grp_cabecera.Controls.Add(Me.Label3)
        Me.grp_cabecera.Controls.Add(Me.Label2)
        Me.grp_cabecera.Controls.Add(Me.lbl_et_anio_2)
        Me.grp_cabecera.Controls.Add(Me.btn_eliminar)
        Me.grp_cabecera.Controls.Add(Me.btn_modificar)
        Me.grp_cabecera.Controls.Add(Me.btn_buscar)
        Me.grp_cabecera.Controls.Add(Me.cmb_anios)
        Me.grp_cabecera.Controls.Add(Me.btn_registrar_asistencias)
        Me.grp_cabecera.Controls.Add(Me.lsv_materias)
        Me.grp_cabecera.Location = New System.Drawing.Point(12, 12)
        Me.grp_cabecera.Name = "grp_cabecera"
        Me.grp_cabecera.Size = New System.Drawing.Size(230, 496)
        Me.grp_cabecera.TabIndex = 69
        Me.grp_cabecera.TabStop = False
        '
        'cmb_instancia
        '
        Me.cmb_instancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_instancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_instancia.FormattingEnabled = True
        Me.cmb_instancia.Location = New System.Drawing.Point(63, 57)
        Me.cmb_instancia.Name = "cmb_instancia"
        Me.cmb_instancia.Size = New System.Drawing.Size(84, 21)
        Me.cmb_instancia.TabIndex = 88
        '
        'lbl_et_instancia
        '
        Me.lbl_et_instancia.AutoSize = True
        Me.lbl_et_instancia.Location = New System.Drawing.Point(7, 60)
        Me.lbl_et_instancia.Name = "lbl_et_instancia"
        Me.lbl_et_instancia.Size = New System.Drawing.Size(50, 13)
        Me.lbl_et_instancia.TabIndex = 87
        Me.lbl_et_instancia.Text = "Instancia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 468)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Modificar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Agregar"
        '
        'lbl_et_anio_2
        '
        Me.lbl_et_anio_2.AutoSize = True
        Me.lbl_et_anio_2.Location = New System.Drawing.Point(31, 35)
        Me.lbl_et_anio_2.Name = "lbl_et_anio_2"
        Me.lbl_et_anio_2.Size = New System.Drawing.Size(26, 13)
        Me.lbl_et_anio_2.TabIndex = 23
        Me.lbl_et_anio_2.Text = "Año"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(148, 413)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(51, 51)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "  "
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(91, 414)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(51, 51)
        Me.btn_modificar.TabIndex = 8
        Me.btn_modificar.Text = "  "
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(153, 27)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(51, 51)
        Me.btn_buscar.TabIndex = 7
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cmb_anios
        '
        Me.cmb_anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_anios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_anios.FormattingEnabled = True
        Me.cmb_anios.Location = New System.Drawing.Point(63, 30)
        Me.cmb_anios.Name = "cmb_anios"
        Me.cmb_anios.Size = New System.Drawing.Size(84, 21)
        Me.cmb_anios.TabIndex = 5
        '
        'btn_registrar_asistencias
        '
        Me.btn_registrar_asistencias.Enabled = False
        Me.btn_registrar_asistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar_asistencias.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_registrar_asistencias.Image = CType(resources.GetObject("btn_registrar_asistencias.Image"), System.Drawing.Image)
        Me.btn_registrar_asistencias.Location = New System.Drawing.Point(34, 413)
        Me.btn_registrar_asistencias.Name = "btn_registrar_asistencias"
        Me.btn_registrar_asistencias.Size = New System.Drawing.Size(51, 51)
        Me.btn_registrar_asistencias.TabIndex = 4
        Me.btn_registrar_asistencias.Text = "  "
        Me.btn_registrar_asistencias.UseVisualStyleBackColor = True
        '
        'lsv_materias
        '
        Me.lsv_materias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_materias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_nroplanilla, Me.col_codmateria, Me.col_descripcion, Me.col_estado})
        Me.lsv_materias.Enabled = False
        Me.lsv_materias.FullRowSelect = True
        Me.lsv_materias.GridLines = True
        Me.lsv_materias.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_materias.Location = New System.Drawing.Point(6, 115)
        Me.lsv_materias.MultiSelect = False
        Me.lsv_materias.Name = "lsv_materias"
        Me.lsv_materias.Size = New System.Drawing.Size(218, 292)
        Me.lsv_materias.TabIndex = 4
        Me.lsv_materias.UseCompatibleStateImageBehavior = False
        Me.lsv_materias.View = System.Windows.Forms.View.Details
        '
        'col_nroplanilla
        '
        Me.col_nroplanilla.Text = ""
        Me.col_nroplanilla.Width = 0
        '
        'col_codmateria
        '
        Me.col_codmateria.Text = ""
        Me.col_codmateria.Width = 0
        '
        'col_descripcion
        '
        Me.col_descripcion.Text = "Materia"
        Me.col_descripcion.Width = 218
        '
        'col_estado
        '
        Me.col_estado.Text = ""
        Me.col_estado.Width = 0
        '
        'asistencias_introductorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_volver_atras)
        Me.Controls.Add(Me.grp_planilla)
        Me.Controls.Add(Me.grp_cabecera)
        Me.Name = "asistencias_introductorio"
        Me.Text = "planilla_asistencia_introductorio"
        Me.grp_planilla.ResumeLayout(False)
        Me.grp_planilla.PerformLayout()
        Me.grp_nro_clase.ResumeLayout(False)
        Me.grp_nro_clase.PerformLayout()
        Me.grp_estados.ResumeLayout(False)
        Me.grp_fecha.ResumeLayout(False)
        Me.grp_cabecera.ResumeLayout(False)
        Me.grp_cabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_volver_atras As System.Windows.Forms.Button
    Friend WithEvents grp_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_et_estado As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents grp_nro_clase As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nro_clase As System.Windows.Forms.TextBox
    Friend WithEvents btn_clase_ok As System.Windows.Forms.Button
    Friend WithEvents lbl_nroplanilla As System.Windows.Forms.Label
    Friend WithEvents lbl_et_planilla As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_estados As System.Windows.Forms.GroupBox
    Friend WithEvents btn_tarde_con_aviso As System.Windows.Forms.Button
    Friend WithEvents btn_tarde As System.Windows.Forms.Button
    Friend WithEvents btn_ausente As System.Windows.Forms.Button
    Friend WithEvents btn_presente As System.Windows.Forms.Button
    Friend WithEvents lbl_instancia As System.Windows.Forms.Label
    Friend WithEvents lbl_anio As System.Windows.Forms.Label
    Friend WithEvents lbl_et_inst As System.Windows.Forms.Label
    Friend WithEvents lbl_et_anio As System.Windows.Forms.Label
    Friend WithEvents lbl_dias As System.Windows.Forms.Label
    Friend WithEvents lbl_et_dias As System.Windows.Forms.Label
    Friend WithEvents lbl_comision As System.Windows.Forms.Label
    Friend WithEvents lbl_curso As System.Windows.Forms.Label
    Friend WithEvents lbl_et_comision As System.Windows.Forms.Label
    Friend WithEvents lbl_et_curso As System.Windows.Forms.Label
    Friend WithEvents grp_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents btn_fecha_ok As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_asistencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_et_profesor As System.Windows.Forms.Label
    Friend WithEvents lsv_planilla As System.Windows.Forms.ListView
    Friend WithEvents col_nroinscripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_anioingreso As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_alumno As System.Windows.Forms.ColumnHeader
    Friend WithEvents grp_cabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_et_anio_2 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents cmb_anios As System.Windows.Forms.ComboBox
    Friend WithEvents btn_registrar_asistencias As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lsv_materias As System.Windows.Forms.ListView
    Friend WithEvents col_nroplanilla As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_codmateria As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_descripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmb_instancia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_et_instancia As System.Windows.Forms.Label
End Class
