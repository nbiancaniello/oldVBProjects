<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pantalla_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantalla_principal))
        Me.lbl_utn_system = New System.Windows.Forms.Label
        Me.tab_principal = New System.Windows.Forms.TabControl
        Me.tp_inscripciones = New System.Windows.Forms.TabPage
        Me.grp_alumnos = New System.Windows.Forms.GroupBox
        Me.lbl_planillas_asistencia_in = New System.Windows.Forms.Label
        Me.btn_plan_carrera = New System.Windows.Forms.Button
        Me.btn_asistencia_por_materia = New System.Windows.Forms.Button
        Me.Label47 = New System.Windows.Forms.Label
        Me.lbl_estado_mat_alu = New System.Windows.Forms.Label
        Me.btn_status_materias = New System.Windows.Forms.Button
        Me.lbl_baja_alu = New System.Windows.Forms.Label
        Me.lbl_datos_alu = New System.Windows.Forms.Label
        Me.lbl_inscripciones_alu = New System.Windows.Forms.Label
        Me.btn_baja_alu = New System.Windows.Forms.Button
        Me.btn_inscripciones_alu = New System.Windows.Forms.Button
        Me.btn_datos_alu = New System.Windows.Forms.Button
        Me.tp_docentes = New System.Windows.Forms.TabPage
        Me.btn_baja_docente = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.btn_dp_docente = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.btn_nuevo_docente = New System.Windows.Forms.Button
        Me.tp_tsp = New System.Windows.Forms.TabPage
        Me.tab_tsp = New System.Windows.Forms.TabControl
        Me.tp_tsp_alumnos = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.tp_tsp_materias = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_observaciones_docente = New System.Windows.Forms.Button
        Me.btn_bitacora = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_bibliografia = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.btn_correlatividades = New System.Windows.Forms.Button
        Me.btn_materias = New System.Windows.Forms.Button
        Me.tp_tssi = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tp_tssi_alumnos = New System.Windows.Forms.TabPage
        Me.tp_tssi_materias = New System.Windows.Forms.TabPage
        Me.tp_mantenimiento = New System.Windows.Forms.TabPage
        Me.grp_mantenimiento = New System.Windows.Forms.GroupBox
        Me.grp_mantenimiento3 = New System.Windows.Forms.GroupBox
        Me.btn_definiciones = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.grp_mantenimiento1 = New System.Windows.Forms.GroupBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.btn_cambio_clave = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.btn_permisos = New System.Windows.Forms.Button
        Me.grp_mantenimiento2 = New System.Windows.Forms.GroupBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.btn_baja_usuario = New System.Windows.Forms.Button
        Me.Label52 = New System.Windows.Forms.Label
        Me.btn_alta_usuario = New System.Windows.Forms.Button
        Me.lbl_acerca_de = New System.Windows.Forms.Label
        Me.btnacerca = New System.Windows.Forms.Button
        Me.lbl_ayuda = New System.Windows.Forms.Label
        Me.lbl_salir = New System.Windows.Forms.Label
        Me.btn_ayuda = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.tab_principal.SuspendLayout()
        Me.tp_inscripciones.SuspendLayout()
        Me.grp_alumnos.SuspendLayout()
        Me.tp_docentes.SuspendLayout()
        Me.tp_tsp.SuspendLayout()
        Me.tab_tsp.SuspendLayout()
        Me.tp_tsp_alumnos.SuspendLayout()
        Me.tp_tsp_materias.SuspendLayout()
        Me.tp_tssi.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tp_mantenimiento.SuspendLayout()
        Me.grp_mantenimiento.SuspendLayout()
        Me.grp_mantenimiento3.SuspendLayout()
        Me.grp_mantenimiento1.SuspendLayout()
        Me.grp_mantenimiento2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_utn_system
        '
        Me.lbl_utn_system.AutoSize = True
        Me.lbl_utn_system.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_utn_system.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_utn_system.Location = New System.Drawing.Point(64, 30)
        Me.lbl_utn_system.Name = "lbl_utn_system"
        Me.lbl_utn_system.Size = New System.Drawing.Size(240, 33)
        Me.lbl_utn_system.TabIndex = 50
        Me.lbl_utn_system.Text = "UTN José C. Paz"
        '
        'tab_principal
        '
        Me.tab_principal.Controls.Add(Me.tp_inscripciones)
        Me.tab_principal.Controls.Add(Me.tp_docentes)
        Me.tab_principal.Controls.Add(Me.tp_tsp)
        Me.tab_principal.Controls.Add(Me.tp_tssi)
        Me.tab_principal.Controls.Add(Me.tp_mantenimiento)
        Me.tab_principal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tab_principal.Location = New System.Drawing.Point(12, 97)
        Me.tab_principal.Multiline = True
        Me.tab_principal.Name = "tab_principal"
        Me.tab_principal.SelectedIndex = 0
        Me.tab_principal.Size = New System.Drawing.Size(678, 315)
        Me.tab_principal.TabIndex = 51
        '
        'tp_inscripciones
        '
        Me.tp_inscripciones.Controls.Add(Me.grp_alumnos)
        Me.tp_inscripciones.Location = New System.Drawing.Point(4, 26)
        Me.tp_inscripciones.Name = "tp_inscripciones"
        Me.tp_inscripciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_inscripciones.Size = New System.Drawing.Size(670, 285)
        Me.tp_inscripciones.TabIndex = 9
        Me.tp_inscripciones.Text = "Ingreso"
        Me.tp_inscripciones.UseVisualStyleBackColor = True
        '
        'grp_alumnos
        '
        Me.grp_alumnos.Controls.Add(Me.lbl_planillas_asistencia_in)
        Me.grp_alumnos.Controls.Add(Me.btn_plan_carrera)
        Me.grp_alumnos.Controls.Add(Me.btn_asistencia_por_materia)
        Me.grp_alumnos.Controls.Add(Me.Label47)
        Me.grp_alumnos.Controls.Add(Me.lbl_estado_mat_alu)
        Me.grp_alumnos.Controls.Add(Me.btn_status_materias)
        Me.grp_alumnos.Controls.Add(Me.lbl_baja_alu)
        Me.grp_alumnos.Controls.Add(Me.lbl_datos_alu)
        Me.grp_alumnos.Controls.Add(Me.lbl_inscripciones_alu)
        Me.grp_alumnos.Controls.Add(Me.btn_baja_alu)
        Me.grp_alumnos.Controls.Add(Me.btn_inscripciones_alu)
        Me.grp_alumnos.Controls.Add(Me.btn_datos_alu)
        Me.grp_alumnos.Location = New System.Drawing.Point(6, 7)
        Me.grp_alumnos.Name = "grp_alumnos"
        Me.grp_alumnos.Size = New System.Drawing.Size(658, 272)
        Me.grp_alumnos.TabIndex = 33
        Me.grp_alumnos.TabStop = False
        '
        'lbl_planillas_asistencia_in
        '
        Me.lbl_planillas_asistencia_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_planillas_asistencia_in.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_planillas_asistencia_in.Location = New System.Drawing.Point(382, 132)
        Me.lbl_planillas_asistencia_in.Name = "lbl_planillas_asistencia_in"
        Me.lbl_planillas_asistencia_in.Size = New System.Drawing.Size(258, 29)
        Me.lbl_planillas_asistencia_in.TabIndex = 44
        Me.lbl_planillas_asistencia_in.Text = "Planillas de Asistencia"
        '
        'btn_plan_carrera
        '
        Me.btn_plan_carrera.AutoSize = True
        Me.btn_plan_carrera.BackgroundImage = CType(resources.GetObject("btn_plan_carrera.BackgroundImage"), System.Drawing.Image)
        Me.btn_plan_carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_plan_carrera.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_plan_carrera.Location = New System.Drawing.Point(325, 119)
        Me.btn_plan_carrera.Name = "btn_plan_carrera"
        Me.btn_plan_carrera.Size = New System.Drawing.Size(51, 51)
        Me.btn_plan_carrera.TabIndex = 43
        Me.btn_plan_carrera.UseVisualStyleBackColor = True
        '
        'btn_asistencia_por_materia
        '
        Me.btn_asistencia_por_materia.BackgroundImage = CType(resources.GetObject("btn_asistencia_por_materia.BackgroundImage"), System.Drawing.Image)
        Me.btn_asistencia_por_materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_asistencia_por_materia.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_asistencia_por_materia.Location = New System.Drawing.Point(18, 200)
        Me.btn_asistencia_por_materia.Name = "btn_asistencia_por_materia"
        Me.btn_asistencia_por_materia.Size = New System.Drawing.Size(51, 51)
        Me.btn_asistencia_por_materia.TabIndex = 41
        Me.btn_asistencia_por_materia.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(75, 213)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(135, 29)
        Me.Label47.TabIndex = 42
        Me.Label47.Text = "Asistencias"
        '
        'lbl_estado_mat_alu
        '
        Me.lbl_estado_mat_alu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado_mat_alu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_estado_mat_alu.Location = New System.Drawing.Point(382, 213)
        Me.lbl_estado_mat_alu.Name = "lbl_estado_mat_alu"
        Me.lbl_estado_mat_alu.Size = New System.Drawing.Size(78, 29)
        Me.lbl_estado_mat_alu.TabIndex = 40
        Me.lbl_estado_mat_alu.Text = "Notas"
        '
        'btn_status_materias
        '
        Me.btn_status_materias.BackgroundImage = CType(resources.GetObject("btn_status_materias.BackgroundImage"), System.Drawing.Image)
        Me.btn_status_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_status_materias.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_status_materias.Location = New System.Drawing.Point(325, 205)
        Me.btn_status_materias.Name = "btn_status_materias"
        Me.btn_status_materias.Size = New System.Drawing.Size(51, 51)
        Me.btn_status_materias.TabIndex = 39
        Me.btn_status_materias.UseVisualStyleBackColor = True
        '
        'lbl_baja_alu
        '
        Me.lbl_baja_alu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baja_alu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_baja_alu.Location = New System.Drawing.Point(382, 49)
        Me.lbl_baja_alu.Name = "lbl_baja_alu"
        Me.lbl_baja_alu.Size = New System.Drawing.Size(83, 29)
        Me.lbl_baja_alu.TabIndex = 29
        Me.lbl_baja_alu.Text = "Baja"
        '
        'lbl_datos_alu
        '
        Me.lbl_datos_alu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datos_alu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_datos_alu.Location = New System.Drawing.Point(75, 132)
        Me.lbl_datos_alu.Name = "lbl_datos_alu"
        Me.lbl_datos_alu.Size = New System.Drawing.Size(207, 29)
        Me.lbl_datos_alu.TabIndex = 29
        Me.lbl_datos_alu.Text = "Datos Personales"
        '
        'lbl_inscripciones_alu
        '
        Me.lbl_inscripciones_alu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inscripciones_alu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_inscripciones_alu.Location = New System.Drawing.Point(75, 49)
        Me.lbl_inscripciones_alu.Name = "lbl_inscripciones_alu"
        Me.lbl_inscripciones_alu.Size = New System.Drawing.Size(163, 29)
        Me.lbl_inscripciones_alu.TabIndex = 30
        Me.lbl_inscripciones_alu.Text = "Inscripcion"
        '
        'btn_baja_alu
        '
        Me.btn_baja_alu.BackgroundImage = CType(resources.GetObject("btn_baja_alu.BackgroundImage"), System.Drawing.Image)
        Me.btn_baja_alu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baja_alu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_baja_alu.Location = New System.Drawing.Point(325, 36)
        Me.btn_baja_alu.Name = "btn_baja_alu"
        Me.btn_baja_alu.Size = New System.Drawing.Size(51, 51)
        Me.btn_baja_alu.TabIndex = 6
        Me.btn_baja_alu.UseVisualStyleBackColor = True
        '
        'btn_inscripciones_alu
        '
        Me.btn_inscripciones_alu.AutoSize = True
        Me.btn_inscripciones_alu.BackgroundImage = CType(resources.GetObject("btn_inscripciones_alu.BackgroundImage"), System.Drawing.Image)
        Me.btn_inscripciones_alu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inscripciones_alu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_inscripciones_alu.Location = New System.Drawing.Point(18, 36)
        Me.btn_inscripciones_alu.Name = "btn_inscripciones_alu"
        Me.btn_inscripciones_alu.Size = New System.Drawing.Size(51, 51)
        Me.btn_inscripciones_alu.TabIndex = 6
        Me.btn_inscripciones_alu.UseVisualStyleBackColor = True
        '
        'btn_datos_alu
        '
        Me.btn_datos_alu.BackgroundImage = CType(resources.GetObject("btn_datos_alu.BackgroundImage"), System.Drawing.Image)
        Me.btn_datos_alu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datos_alu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_datos_alu.Location = New System.Drawing.Point(18, 119)
        Me.btn_datos_alu.Name = "btn_datos_alu"
        Me.btn_datos_alu.Size = New System.Drawing.Size(51, 51)
        Me.btn_datos_alu.TabIndex = 6
        Me.btn_datos_alu.UseVisualStyleBackColor = True
        '
        'tp_docentes
        '
        Me.tp_docentes.Controls.Add(Me.btn_baja_docente)
        Me.tp_docentes.Controls.Add(Me.Label28)
        Me.tp_docentes.Controls.Add(Me.Label26)
        Me.tp_docentes.Controls.Add(Me.btn_dp_docente)
        Me.tp_docentes.Controls.Add(Me.Label27)
        Me.tp_docentes.Controls.Add(Me.btn_nuevo_docente)
        Me.tp_docentes.Location = New System.Drawing.Point(4, 26)
        Me.tp_docentes.Name = "tp_docentes"
        Me.tp_docentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_docentes.Size = New System.Drawing.Size(670, 285)
        Me.tp_docentes.TabIndex = 10
        Me.tp_docentes.Text = "Docentes"
        Me.tp_docentes.UseVisualStyleBackColor = True
        '
        'btn_baja_docente
        '
        Me.btn_baja_docente.BackgroundImage = CType(resources.GetObject("btn_baja_docente.BackgroundImage"), System.Drawing.Image)
        Me.btn_baja_docente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baja_docente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_baja_docente.Location = New System.Drawing.Point(359, 35)
        Me.btn_baja_docente.Name = "btn_baja_docente"
        Me.btn_baja_docente.Size = New System.Drawing.Size(51, 51)
        Me.btn_baja_docente.TabIndex = 35
        Me.btn_baja_docente.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(416, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 29)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Bajas"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(105, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(212, 29)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Datos Personales"
        '
        'btn_dp_docente
        '
        Me.btn_dp_docente.BackgroundImage = CType(resources.GetObject("btn_dp_docente.BackgroundImage"), System.Drawing.Image)
        Me.btn_dp_docente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dp_docente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_dp_docente.Location = New System.Drawing.Point(48, 118)
        Me.btn_dp_docente.Name = "btn_dp_docente"
        Me.btn_dp_docente.Size = New System.Drawing.Size(51, 51)
        Me.btn_dp_docente.TabIndex = 33
        Me.btn_dp_docente.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(105, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(182, 29)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Nuevo Docente"
        '
        'btn_nuevo_docente
        '
        Me.btn_nuevo_docente.BackgroundImage = CType(resources.GetObject("btn_nuevo_docente.BackgroundImage"), System.Drawing.Image)
        Me.btn_nuevo_docente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_docente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_nuevo_docente.Location = New System.Drawing.Point(48, 35)
        Me.btn_nuevo_docente.Name = "btn_nuevo_docente"
        Me.btn_nuevo_docente.Size = New System.Drawing.Size(51, 51)
        Me.btn_nuevo_docente.TabIndex = 31
        Me.btn_nuevo_docente.UseVisualStyleBackColor = True
        '
        'tp_tsp
        '
        Me.tp_tsp.Controls.Add(Me.tab_tsp)
        Me.tp_tsp.Location = New System.Drawing.Point(4, 26)
        Me.tp_tsp.Name = "tp_tsp"
        Me.tp_tsp.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_tsp.Size = New System.Drawing.Size(670, 285)
        Me.tp_tsp.TabIndex = 0
        Me.tp_tsp.Text = "TSP"
        Me.tp_tsp.UseVisualStyleBackColor = True
        '
        'tab_tsp
        '
        Me.tab_tsp.Controls.Add(Me.tp_tsp_alumnos)
        Me.tab_tsp.Controls.Add(Me.tp_tsp_materias)
        Me.tab_tsp.Location = New System.Drawing.Point(6, 6)
        Me.tab_tsp.Name = "tab_tsp"
        Me.tab_tsp.SelectedIndex = 0
        Me.tab_tsp.Size = New System.Drawing.Size(658, 273)
        Me.tab_tsp.TabIndex = 0
        '
        'tp_tsp_alumnos
        '
        Me.tp_tsp_alumnos.Controls.Add(Me.Label6)
        Me.tp_tsp_alumnos.Controls.Add(Me.Button4)
        Me.tp_tsp_alumnos.Controls.Add(Me.Button3)
        Me.tp_tsp_alumnos.Controls.Add(Me.Label5)
        Me.tp_tsp_alumnos.Controls.Add(Me.Label3)
        Me.tp_tsp_alumnos.Controls.Add(Me.Label4)
        Me.tp_tsp_alumnos.Controls.Add(Me.Button1)
        Me.tp_tsp_alumnos.Controls.Add(Me.Button2)
        Me.tp_tsp_alumnos.Location = New System.Drawing.Point(4, 26)
        Me.tp_tsp_alumnos.Name = "tp_tsp_alumnos"
        Me.tp_tsp_alumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_tsp_alumnos.Size = New System.Drawing.Size(650, 243)
        Me.tp_tsp_alumnos.TabIndex = 0
        Me.tp_tsp_alumnos.Text = "Alumnos"
        Me.tp_tsp_alumnos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(444, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 29)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Baja"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(74, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 29)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Datos Personales"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(387, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 51)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(17, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 51)
        Me.Button2.TabIndex = 31
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tp_tsp_materias
        '
        Me.tp_tsp_materias.Controls.Add(Me.Label1)
        Me.tp_tsp_materias.Controls.Add(Me.btn_observaciones_docente)
        Me.tp_tsp_materias.Controls.Add(Me.btn_bitacora)
        Me.tp_tsp_materias.Controls.Add(Me.Label2)
        Me.tp_tsp_materias.Controls.Add(Me.btn_bibliografia)
        Me.tp_tsp_materias.Controls.Add(Me.Label32)
        Me.tp_tsp_materias.Controls.Add(Me.Label40)
        Me.tp_tsp_materias.Controls.Add(Me.Label37)
        Me.tp_tsp_materias.Controls.Add(Me.btn_correlatividades)
        Me.tp_tsp_materias.Controls.Add(Me.btn_materias)
        Me.tp_tsp_materias.Location = New System.Drawing.Point(4, 26)
        Me.tp_tsp_materias.Name = "tp_tsp_materias"
        Me.tp_tsp_materias.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_tsp_materias.Size = New System.Drawing.Size(650, 243)
        Me.tp_tsp_materias.TabIndex = 1
        Me.tp_tsp_materias.Text = "Materias"
        Me.tp_tsp_materias.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(89, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 29)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Planillas de Asistencia"
        '
        'btn_observaciones_docente
        '
        Me.btn_observaciones_docente.BackgroundImage = CType(resources.GetObject("btn_observaciones_docente.BackgroundImage"), System.Drawing.Image)
        Me.btn_observaciones_docente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_observaciones_docente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_observaciones_docente.Location = New System.Drawing.Point(32, 148)
        Me.btn_observaciones_docente.Name = "btn_observaciones_docente"
        Me.btn_observaciones_docente.Size = New System.Drawing.Size(51, 51)
        Me.btn_observaciones_docente.TabIndex = 39
        Me.btn_observaciones_docente.UseVisualStyleBackColor = True
        '
        'btn_bitacora
        '
        Me.btn_bitacora.BackgroundImage = CType(resources.GetObject("btn_bitacora.BackgroundImage"), System.Drawing.Image)
        Me.btn_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bitacora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_bitacora.Location = New System.Drawing.Point(329, 82)
        Me.btn_bitacora.Name = "btn_bitacora"
        Me.btn_bitacora.Size = New System.Drawing.Size(51, 51)
        Me.btn_bitacora.TabIndex = 36
        Me.btn_bitacora.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(99, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 29)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Bibliografía"
        '
        'btn_bibliografia
        '
        Me.btn_bibliografia.BackgroundImage = CType(resources.GetObject("btn_bibliografia.BackgroundImage"), System.Drawing.Image)
        Me.btn_bibliografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bibliografia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_bibliografia.Location = New System.Drawing.Point(32, 90)
        Me.btn_bibliografia.Name = "btn_bibliografia"
        Me.btn_bibliografia.Size = New System.Drawing.Size(51, 51)
        Me.btn_bibliografia.TabIndex = 35
        Me.btn_bibliografia.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(387, 90)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(212, 29)
        Me.Label32.TabIndex = 37
        Me.Label32.Text = "Bitácora de clases"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(386, 33)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(212, 29)
        Me.Label40.TabIndex = 33
        Me.Label40.Text = "Correlatividades"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(89, 33)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(131, 29)
        Me.Label37.TabIndex = 34
        Me.Label37.Text = "Materias"
        '
        'btn_correlatividades
        '
        Me.btn_correlatividades.BackgroundImage = CType(resources.GetObject("btn_correlatividades.BackgroundImage"), System.Drawing.Image)
        Me.btn_correlatividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_correlatividades.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_correlatividades.Location = New System.Drawing.Point(329, 20)
        Me.btn_correlatividades.Name = "btn_correlatividades"
        Me.btn_correlatividades.Size = New System.Drawing.Size(51, 51)
        Me.btn_correlatividades.TabIndex = 31
        Me.btn_correlatividades.UseVisualStyleBackColor = True
        '
        'btn_materias
        '
        Me.btn_materias.BackgroundImage = CType(resources.GetObject("btn_materias.BackgroundImage"), System.Drawing.Image)
        Me.btn_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_materias.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_materias.Location = New System.Drawing.Point(32, 20)
        Me.btn_materias.Name = "btn_materias"
        Me.btn_materias.Size = New System.Drawing.Size(51, 51)
        Me.btn_materias.TabIndex = 32
        Me.btn_materias.UseVisualStyleBackColor = True
        '
        'tp_tssi
        '
        Me.tp_tssi.Controls.Add(Me.TabControl1)
        Me.tp_tssi.Location = New System.Drawing.Point(4, 26)
        Me.tp_tssi.Name = "tp_tssi"
        Me.tp_tssi.Size = New System.Drawing.Size(670, 285)
        Me.tp_tssi.TabIndex = 11
        Me.tp_tssi.Text = "TSSI"
        Me.tp_tssi.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp_tssi_alumnos)
        Me.TabControl1.Controls.Add(Me.tp_tssi_materias)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(658, 273)
        Me.TabControl1.TabIndex = 1
        '
        'tp_tssi_alumnos
        '
        Me.tp_tssi_alumnos.Location = New System.Drawing.Point(4, 26)
        Me.tp_tssi_alumnos.Name = "tp_tssi_alumnos"
        Me.tp_tssi_alumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_tssi_alumnos.Size = New System.Drawing.Size(650, 243)
        Me.tp_tssi_alumnos.TabIndex = 0
        Me.tp_tssi_alumnos.Text = "Alumnos"
        Me.tp_tssi_alumnos.UseVisualStyleBackColor = True
        '
        'tp_tssi_materias
        '
        Me.tp_tssi_materias.Location = New System.Drawing.Point(4, 26)
        Me.tp_tssi_materias.Name = "tp_tssi_materias"
        Me.tp_tssi_materias.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_tssi_materias.Size = New System.Drawing.Size(650, 243)
        Me.tp_tssi_materias.TabIndex = 1
        Me.tp_tssi_materias.Text = "Materias"
        Me.tp_tssi_materias.UseVisualStyleBackColor = True
        '
        'tp_mantenimiento
        '
        Me.tp_mantenimiento.Controls.Add(Me.grp_mantenimiento)
        Me.tp_mantenimiento.Location = New System.Drawing.Point(4, 26)
        Me.tp_mantenimiento.Name = "tp_mantenimiento"
        Me.tp_mantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_mantenimiento.Size = New System.Drawing.Size(670, 285)
        Me.tp_mantenimiento.TabIndex = 8
        Me.tp_mantenimiento.Text = "Mantenimiento"
        Me.tp_mantenimiento.UseVisualStyleBackColor = True
        '
        'grp_mantenimiento
        '
        Me.grp_mantenimiento.Controls.Add(Me.grp_mantenimiento3)
        Me.grp_mantenimiento.Controls.Add(Me.grp_mantenimiento1)
        Me.grp_mantenimiento.Controls.Add(Me.grp_mantenimiento2)
        Me.grp_mantenimiento.Location = New System.Drawing.Point(6, 6)
        Me.grp_mantenimiento.Name = "grp_mantenimiento"
        Me.grp_mantenimiento.Size = New System.Drawing.Size(661, 290)
        Me.grp_mantenimiento.TabIndex = 43
        Me.grp_mantenimiento.TabStop = False
        '
        'grp_mantenimiento3
        '
        Me.grp_mantenimiento3.Controls.Add(Me.btn_definiciones)
        Me.grp_mantenimiento3.Controls.Add(Me.Label33)
        Me.grp_mantenimiento3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_mantenimiento3.Location = New System.Drawing.Point(6, 193)
        Me.grp_mantenimiento3.Name = "grp_mantenimiento3"
        Me.grp_mantenimiento3.Size = New System.Drawing.Size(649, 83)
        Me.grp_mantenimiento3.TabIndex = 41
        Me.grp_mantenimiento3.TabStop = False
        '
        'btn_definiciones
        '
        Me.btn_definiciones.BackgroundImage = CType(resources.GetObject("btn_definiciones.BackgroundImage"), System.Drawing.Image)
        Me.btn_definiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_definiciones.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_definiciones.Location = New System.Drawing.Point(16, 19)
        Me.btn_definiciones.Name = "btn_definiciones"
        Me.btn_definiciones.Size = New System.Drawing.Size(51, 51)
        Me.btn_definiciones.TabIndex = 6
        Me.btn_definiciones.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(73, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(212, 29)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "Definiciones"
        '
        'grp_mantenimiento1
        '
        Me.grp_mantenimiento1.Controls.Add(Me.Label54)
        Me.grp_mantenimiento1.Controls.Add(Me.btn_cambio_clave)
        Me.grp_mantenimiento1.Controls.Add(Me.Label13)
        Me.grp_mantenimiento1.Controls.Add(Me.btn_permisos)
        Me.grp_mantenimiento1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_mantenimiento1.Location = New System.Drawing.Point(6, 15)
        Me.grp_mantenimiento1.Name = "grp_mantenimiento1"
        Me.grp_mantenimiento1.Size = New System.Drawing.Size(649, 83)
        Me.grp_mantenimiento1.TabIndex = 40
        Me.grp_mantenimiento1.TabStop = False
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(370, 32)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(122, 29)
        Me.Label54.TabIndex = 33
        Me.Label54.Text = "Permisos"
        '
        'btn_cambio_clave
        '
        Me.btn_cambio_clave.BackgroundImage = CType(resources.GetObject("btn_cambio_clave.BackgroundImage"), System.Drawing.Image)
        Me.btn_cambio_clave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambio_clave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cambio_clave.Location = New System.Drawing.Point(16, 19)
        Me.btn_cambio_clave.Name = "btn_cambio_clave"
        Me.btn_cambio_clave.Size = New System.Drawing.Size(51, 51)
        Me.btn_cambio_clave.TabIndex = 6
        Me.btn_cambio_clave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(73, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(212, 29)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Cambio de Clave"
        '
        'btn_permisos
        '
        Me.btn_permisos.BackgroundImage = CType(resources.GetObject("btn_permisos.BackgroundImage"), System.Drawing.Image)
        Me.btn_permisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_permisos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_permisos.Location = New System.Drawing.Point(313, 19)
        Me.btn_permisos.Name = "btn_permisos"
        Me.btn_permisos.Size = New System.Drawing.Size(51, 51)
        Me.btn_permisos.TabIndex = 32
        Me.btn_permisos.UseVisualStyleBackColor = True
        '
        'grp_mantenimiento2
        '
        Me.grp_mantenimiento2.Controls.Add(Me.Label53)
        Me.grp_mantenimiento2.Controls.Add(Me.btn_baja_usuario)
        Me.grp_mantenimiento2.Controls.Add(Me.Label52)
        Me.grp_mantenimiento2.Controls.Add(Me.btn_alta_usuario)
        Me.grp_mantenimiento2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_mantenimiento2.Location = New System.Drawing.Point(6, 104)
        Me.grp_mantenimiento2.Name = "grp_mantenimiento2"
        Me.grp_mantenimiento2.Size = New System.Drawing.Size(649, 83)
        Me.grp_mantenimiento2.TabIndex = 19
        Me.grp_mantenimiento2.TabStop = False
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(370, 32)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(89, 29)
        Me.Label53.TabIndex = 31
        Me.Label53.Text = "Bajas"
        '
        'btn_baja_usuario
        '
        Me.btn_baja_usuario.BackgroundImage = CType(resources.GetObject("btn_baja_usuario.BackgroundImage"), System.Drawing.Image)
        Me.btn_baja_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baja_usuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_baja_usuario.Location = New System.Drawing.Point(313, 19)
        Me.btn_baja_usuario.Name = "btn_baja_usuario"
        Me.btn_baja_usuario.Size = New System.Drawing.Size(51, 51)
        Me.btn_baja_usuario.TabIndex = 30
        Me.btn_baja_usuario.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Location = New System.Drawing.Point(73, 32)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(89, 29)
        Me.Label52.TabIndex = 29
        Me.Label52.Text = "Altas"
        '
        'btn_alta_usuario
        '
        Me.btn_alta_usuario.BackgroundImage = CType(resources.GetObject("btn_alta_usuario.BackgroundImage"), System.Drawing.Image)
        Me.btn_alta_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alta_usuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_alta_usuario.Location = New System.Drawing.Point(16, 19)
        Me.btn_alta_usuario.Name = "btn_alta_usuario"
        Me.btn_alta_usuario.Size = New System.Drawing.Size(51, 51)
        Me.btn_alta_usuario.TabIndex = 6
        Me.btn_alta_usuario.UseVisualStyleBackColor = True
        '
        'lbl_acerca_de
        '
        Me.lbl_acerca_de.AutoSize = True
        Me.lbl_acerca_de.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_acerca_de.Location = New System.Drawing.Point(541, 78)
        Me.lbl_acerca_de.Name = "lbl_acerca_de"
        Me.lbl_acerca_de.Size = New System.Drawing.Size(84, 16)
        Me.lbl_acerca_de.TabIndex = 65
        Me.lbl_acerca_de.Text = "Acerca de..."
        '
        'btnacerca
        '
        Me.btnacerca.BackgroundImage = CType(resources.GetObject("btnacerca.BackgroundImage"), System.Drawing.Image)
        Me.btnacerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnacerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnacerca.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnacerca.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnacerca.Location = New System.Drawing.Point(554, 20)
        Me.btnacerca.Name = "btnacerca"
        Me.btnacerca.Size = New System.Drawing.Size(48, 43)
        Me.btnacerca.TabIndex = 64
        Me.btnacerca.UseVisualStyleBackColor = True
        '
        'lbl_ayuda
        '
        Me.lbl_ayuda.AutoSize = True
        Me.lbl_ayuda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ayuda.Location = New System.Drawing.Point(487, 78)
        Me.lbl_ayuda.Name = "lbl_ayuda"
        Me.lbl_ayuda.Size = New System.Drawing.Size(48, 16)
        Me.lbl_ayuda.TabIndex = 63
        Me.lbl_ayuda.Text = "Ayuda"
        '
        'lbl_salir
        '
        Me.lbl_salir.AutoSize = True
        Me.lbl_salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salir.Location = New System.Drawing.Point(642, 78)
        Me.lbl_salir.Name = "lbl_salir"
        Me.lbl_salir.Size = New System.Drawing.Size(38, 16)
        Me.lbl_salir.TabIndex = 62
        Me.lbl_salir.Text = "Salir"
        '
        'btn_ayuda
        '
        Me.btn_ayuda.BackgroundImage = CType(resources.GetObject("btn_ayuda.BackgroundImage"), System.Drawing.Image)
        Me.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ayuda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ayuda.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_ayuda.Location = New System.Drawing.Point(487, 20)
        Me.btn_ayuda.Name = "btn_ayuda"
        Me.btn_ayuda.Size = New System.Drawing.Size(48, 43)
        Me.btn_ayuda.TabIndex = 61
        Me.btn_ayuda.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = CType(resources.GetObject("btn_salir.BackgroundImage"), System.Drawing.Image)
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_salir.Location = New System.Drawing.Point(623, 10)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(70, 64)
        Me.btn_salir.TabIndex = 60
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(17, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 51)
        Me.Button3.TabIndex = 43
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(74, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 29)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Asistencias"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(444, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 29)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Notas"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(387, 95)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 51)
        Me.Button4.TabIndex = 45
        Me.Button4.UseVisualStyleBackColor = True
        '
        'pantalla_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 440)
        Me.Controls.Add(Me.lbl_acerca_de)
        Me.Controls.Add(Me.tab_principal)
        Me.Controls.Add(Me.lbl_utn_system)
        Me.Controls.Add(Me.btnacerca)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_salir)
        Me.Controls.Add(Me.lbl_ayuda)
        Me.Controls.Add(Me.btn_ayuda)
        Me.Name = "pantalla_principal"
        Me.tab_principal.ResumeLayout(False)
        Me.tp_inscripciones.ResumeLayout(False)
        Me.grp_alumnos.ResumeLayout(False)
        Me.grp_alumnos.PerformLayout()
        Me.tp_docentes.ResumeLayout(False)
        Me.tp_tsp.ResumeLayout(False)
        Me.tab_tsp.ResumeLayout(False)
        Me.tp_tsp_alumnos.ResumeLayout(False)
        Me.tp_tsp_materias.ResumeLayout(False)
        Me.tp_tssi.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tp_mantenimiento.ResumeLayout(False)
        Me.grp_mantenimiento.ResumeLayout(False)
        Me.grp_mantenimiento3.ResumeLayout(False)
        Me.grp_mantenimiento1.ResumeLayout(False)
        Me.grp_mantenimiento2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_utn_system As System.Windows.Forms.Label
    Friend WithEvents tab_principal As System.Windows.Forms.TabControl
    Friend WithEvents tp_tsp As System.Windows.Forms.TabPage
    Friend WithEvents tp_mantenimiento As System.Windows.Forms.TabPage
    Friend WithEvents grp_mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents grp_mantenimiento3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_definiciones As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents grp_mantenimiento1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents btn_cambio_clave As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_permisos As System.Windows.Forms.Button
    Friend WithEvents grp_mantenimiento2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents btn_baja_usuario As System.Windows.Forms.Button
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents btn_alta_usuario As System.Windows.Forms.Button
    Friend WithEvents tp_inscripciones As System.Windows.Forms.TabPage
    Friend WithEvents grp_alumnos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_baja_alu As System.Windows.Forms.Label
    Friend WithEvents lbl_inscripciones_alu As System.Windows.Forms.Label
    Friend WithEvents btn_baja_alu As System.Windows.Forms.Button
    Friend WithEvents btn_inscripciones_alu As System.Windows.Forms.Button
    Friend WithEvents lbl_datos_alu As System.Windows.Forms.Label
    Friend WithEvents btn_datos_alu As System.Windows.Forms.Button
    Friend WithEvents btn_asistencia_por_materia As System.Windows.Forms.Button
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents lbl_estado_mat_alu As System.Windows.Forms.Label
    Friend WithEvents btn_status_materias As System.Windows.Forms.Button
    Friend WithEvents btn_plan_carrera As System.Windows.Forms.Button
    Friend WithEvents lbl_planillas_asistencia_in As System.Windows.Forms.Label
    Friend WithEvents tp_docentes As System.Windows.Forms.TabPage
    Friend WithEvents btn_baja_docente As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btn_dp_docente As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo_docente As System.Windows.Forms.Button
    Friend WithEvents lbl_acerca_de As System.Windows.Forms.Label
    Friend WithEvents btnacerca As System.Windows.Forms.Button
    Friend WithEvents lbl_ayuda As System.Windows.Forms.Label
    Friend WithEvents lbl_salir As System.Windows.Forms.Label
    Friend WithEvents btn_ayuda As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents tp_tssi As System.Windows.Forms.TabPage
    Friend WithEvents tab_tsp As System.Windows.Forms.TabControl
    Friend WithEvents tp_tsp_alumnos As System.Windows.Forms.TabPage
    Friend WithEvents tp_tsp_materias As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tp_tssi_alumnos As System.Windows.Forms.TabPage
    Friend WithEvents tp_tssi_materias As System.Windows.Forms.TabPage
    Friend WithEvents btn_bitacora As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_bibliografia As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btn_correlatividades As System.Windows.Forms.Button
    Friend WithEvents btn_materias As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_observaciones_docente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
