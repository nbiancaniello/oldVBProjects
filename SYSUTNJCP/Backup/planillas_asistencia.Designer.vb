<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planillas_asistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(planillas_asistencia))
        Me.lbl_lista = New System.Windows.Forms.Label
        Me.lsv_planillas = New System.Windows.Forms.ListView
        Me.col_numero = New System.Windows.Forms.ColumnHeader
        Me.col_anio = New System.Windows.Forms.ColumnHeader
        Me.col_etapa = New System.Windows.Forms.ColumnHeader
        Me.col_materia = New System.Windows.Forms.ColumnHeader
        Me.col_codmateria = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_cerrar = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_baja = New System.Windows.Forms.Button
        Me.btn_alta = New System.Windows.Forms.Button
        Me.grp_alta = New System.Windows.Forms.GroupBox
        Me.chk_asis_obl = New System.Windows.Forms.CheckBox
        Me.chk_segundo = New System.Windows.Forms.CheckBox
        Me.cmb_dia2_alta = New System.Windows.Forms.ComboBox
        Me.cmb_dia1_alta = New System.Windows.Forms.ComboBox
        Me.lbl_anio_alta = New System.Windows.Forms.Label
        Me.txt_comision = New System.Windows.Forms.TextBox
        Me.txt_curso = New System.Windows.Forms.TextBox
        Me.cmb_profesores_alta = New System.Windows.Forms.ComboBox
        Me.lbl_et_materia = New System.Windows.Forms.Label
        Me.lbl_et_instancia = New System.Windows.Forms.Label
        Me.lbl_et_anio = New System.Windows.Forms.Label
        Me.lbl_et_dias = New System.Windows.Forms.Label
        Me.lbl_et_comision = New System.Windows.Forms.Label
        Me.lbl_et_curso = New System.Windows.Forms.Label
        Me.lbl_et_profesor = New System.Windows.Forms.Label
        Me.cmb_materias_alta = New System.Windows.Forms.ComboBox
        Me.btn_aceptar_alta = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.cmb_instancia = New System.Windows.Forms.ComboBox
        Me.grp_alta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_lista
        '
        Me.lbl_lista.AutoSize = True
        Me.lbl_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lista.Location = New System.Drawing.Point(12, 9)
        Me.lbl_lista.Name = "lbl_lista"
        Me.lbl_lista.Size = New System.Drawing.Size(104, 13)
        Me.lbl_lista.TabIndex = 85
        Me.lbl_lista.Text = "Planillas Abiertas"
        '
        'lsv_planillas
        '
        Me.lsv_planillas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_planillas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_numero, Me.col_anio, Me.col_etapa, Me.col_materia, Me.col_codmateria})
        Me.lsv_planillas.FullRowSelect = True
        Me.lsv_planillas.GridLines = True
        Me.lsv_planillas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_planillas.HideSelection = False
        Me.lsv_planillas.Location = New System.Drawing.Point(12, 27)
        Me.lsv_planillas.MultiSelect = False
        Me.lsv_planillas.Name = "lsv_planillas"
        Me.lsv_planillas.Size = New System.Drawing.Size(457, 174)
        Me.lsv_planillas.TabIndex = 84
        Me.lsv_planillas.UseCompatibleStateImageBehavior = False
        Me.lsv_planillas.View = System.Windows.Forms.View.Details
        '
        'col_numero
        '
        Me.col_numero.Text = "Nº Planilla"
        Me.col_numero.Width = 75
        '
        'col_anio
        '
        Me.col_anio.Text = "Año"
        Me.col_anio.Width = 55
        '
        'col_etapa
        '
        Me.col_etapa.Text = "Etapa"
        Me.col_etapa.Width = 55
        '
        'col_materia
        '
        Me.col_materia.Text = "Materia"
        Me.col_materia.Width = 270
        '
        'col_codmateria
        '
        Me.col_codmateria.Text = ""
        Me.col_codmateria.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 510)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Cancelar"
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.Location = New System.Drawing.Point(264, 261)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(41, 13)
        Me.lbl_cerrar.TabIndex = 83
        Me.lbl_cerrar.Text = "Cerrar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(358, 510)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Aceptar"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(257, 207)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cerrar.TabIndex = 80
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Modificar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Agregar"
        '
        'btn_modificar
        '
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(177, 207)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(51, 51)
        Me.btn_modificar.TabIndex = 78
        Me.btn_modificar.Text = "  "
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_baja
        '
        Me.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baja.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_baja.Image = CType(resources.GetObject("btn_baja.Image"), System.Drawing.Image)
        Me.btn_baja.Location = New System.Drawing.Point(331, 207)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(51, 51)
        Me.btn_baja.TabIndex = 77
        Me.btn_baja.Text = "  "
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'btn_alta
        '
        Me.btn_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_alta.Image = CType(resources.GetObject("btn_alta.Image"), System.Drawing.Image)
        Me.btn_alta.Location = New System.Drawing.Point(98, 207)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(51, 51)
        Me.btn_alta.TabIndex = 76
        Me.btn_alta.Text = "  "
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'grp_alta
        '
        Me.grp_alta.Controls.Add(Me.cmb_instancia)
        Me.grp_alta.Controls.Add(Me.chk_asis_obl)
        Me.grp_alta.Controls.Add(Me.chk_segundo)
        Me.grp_alta.Controls.Add(Me.cmb_dia2_alta)
        Me.grp_alta.Controls.Add(Me.cmb_dia1_alta)
        Me.grp_alta.Controls.Add(Me.lbl_anio_alta)
        Me.grp_alta.Controls.Add(Me.txt_comision)
        Me.grp_alta.Controls.Add(Me.txt_curso)
        Me.grp_alta.Controls.Add(Me.cmb_profesores_alta)
        Me.grp_alta.Controls.Add(Me.lbl_et_materia)
        Me.grp_alta.Controls.Add(Me.lbl_et_instancia)
        Me.grp_alta.Controls.Add(Me.lbl_et_anio)
        Me.grp_alta.Controls.Add(Me.lbl_et_dias)
        Me.grp_alta.Controls.Add(Me.lbl_et_comision)
        Me.grp_alta.Controls.Add(Me.lbl_et_curso)
        Me.grp_alta.Controls.Add(Me.lbl_et_profesor)
        Me.grp_alta.Controls.Add(Me.cmb_materias_alta)
        Me.grp_alta.Enabled = False
        Me.grp_alta.Location = New System.Drawing.Point(12, 277)
        Me.grp_alta.Name = "grp_alta"
        Me.grp_alta.Size = New System.Drawing.Size(454, 173)
        Me.grp_alta.TabIndex = 75
        Me.grp_alta.TabStop = False
        '
        'chk_asis_obl
        '
        Me.chk_asis_obl.AutoSize = True
        Me.chk_asis_obl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_asis_obl.Location = New System.Drawing.Point(291, 82)
        Me.chk_asis_obl.Name = "chk_asis_obl"
        Me.chk_asis_obl.Size = New System.Drawing.Size(124, 17)
        Me.chk_asis_obl.TabIndex = 104
        Me.chk_asis_obl.Text = "Asistencia Obligatoria"
        Me.chk_asis_obl.UseVisualStyleBackColor = True
        '
        'chk_segundo
        '
        Me.chk_segundo.AutoSize = True
        Me.chk_segundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_segundo.Location = New System.Drawing.Point(184, 142)
        Me.chk_segundo.Name = "chk_segundo"
        Me.chk_segundo.Size = New System.Drawing.Size(30, 17)
        Me.chk_segundo.TabIndex = 38
        Me.chk_segundo.Text = "Y"
        Me.chk_segundo.UseVisualStyleBackColor = True
        '
        'cmb_dia2_alta
        '
        Me.cmb_dia2_alta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia2_alta.Enabled = False
        Me.cmb_dia2_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_dia2_alta.FormattingEnabled = True
        Me.cmb_dia2_alta.Items.AddRange(New Object() {"LUNES", "MARTES", "MIÉRCOLES", "JUEVES", "VIERNES", "SÁBADO"})
        Me.cmb_dia2_alta.Location = New System.Drawing.Point(223, 140)
        Me.cmb_dia2_alta.Name = "cmb_dia2_alta"
        Me.cmb_dia2_alta.Size = New System.Drawing.Size(115, 21)
        Me.cmb_dia2_alta.TabIndex = 36
        '
        'cmb_dia1_alta
        '
        Me.cmb_dia1_alta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia1_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_dia1_alta.FormattingEnabled = True
        Me.cmb_dia1_alta.Items.AddRange(New Object() {"LUNES", "MARTES", "MIÉRCOLES", "JUEVES", "VIERNES", "SÁBADO"})
        Me.cmb_dia1_alta.Location = New System.Drawing.Point(63, 140)
        Me.cmb_dia1_alta.Name = "cmb_dia1_alta"
        Me.cmb_dia1_alta.Size = New System.Drawing.Size(115, 21)
        Me.cmb_dia1_alta.TabIndex = 35
        '
        'lbl_anio_alta
        '
        Me.lbl_anio_alta.AutoSize = True
        Me.lbl_anio_alta.Location = New System.Drawing.Point(63, 113)
        Me.lbl_anio_alta.Name = "lbl_anio_alta"
        Me.lbl_anio_alta.Size = New System.Drawing.Size(0, 13)
        Me.lbl_anio_alta.TabIndex = 33
        '
        'txt_comision
        '
        Me.txt_comision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comision.Location = New System.Drawing.Point(197, 82)
        Me.txt_comision.MaxLength = 3
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Size = New System.Drawing.Size(66, 20)
        Me.txt_comision.TabIndex = 32
        '
        'txt_curso
        '
        Me.txt_curso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_curso.Location = New System.Drawing.Point(63, 82)
        Me.txt_curso.MaxLength = 6
        Me.txt_curso.Name = "txt_curso"
        Me.txt_curso.Size = New System.Drawing.Size(66, 20)
        Me.txt_curso.TabIndex = 31
        '
        'cmb_profesores_alta
        '
        Me.cmb_profesores_alta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_profesores_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_profesores_alta.FormattingEnabled = True
        Me.cmb_profesores_alta.Location = New System.Drawing.Point(63, 54)
        Me.cmb_profesores_alta.Name = "cmb_profesores_alta"
        Me.cmb_profesores_alta.Size = New System.Drawing.Size(282, 21)
        Me.cmb_profesores_alta.TabIndex = 30
        '
        'lbl_et_materia
        '
        Me.lbl_et_materia.AutoSize = True
        Me.lbl_et_materia.Location = New System.Drawing.Point(15, 28)
        Me.lbl_et_materia.Name = "lbl_et_materia"
        Me.lbl_et_materia.Size = New System.Drawing.Size(42, 13)
        Me.lbl_et_materia.TabIndex = 29
        Me.lbl_et_materia.Text = "Materia"
        '
        'lbl_et_instancia
        '
        Me.lbl_et_instancia.AutoSize = True
        Me.lbl_et_instancia.Location = New System.Drawing.Point(166, 113)
        Me.lbl_et_instancia.Name = "lbl_et_instancia"
        Me.lbl_et_instancia.Size = New System.Drawing.Size(50, 13)
        Me.lbl_et_instancia.TabIndex = 26
        Me.lbl_et_instancia.Text = "Instancia"
        '
        'lbl_et_anio
        '
        Me.lbl_et_anio.AutoSize = True
        Me.lbl_et_anio.Location = New System.Drawing.Point(31, 113)
        Me.lbl_et_anio.Name = "lbl_et_anio"
        Me.lbl_et_anio.Size = New System.Drawing.Size(26, 13)
        Me.lbl_et_anio.TabIndex = 25
        Me.lbl_et_anio.Text = "Año"
        '
        'lbl_et_dias
        '
        Me.lbl_et_dias.AutoSize = True
        Me.lbl_et_dias.Location = New System.Drawing.Point(27, 145)
        Me.lbl_et_dias.Name = "lbl_et_dias"
        Me.lbl_et_dias.Size = New System.Drawing.Size(30, 13)
        Me.lbl_et_dias.TabIndex = 24
        Me.lbl_et_dias.Text = "Días"
        '
        'lbl_et_comision
        '
        Me.lbl_et_comision.AutoSize = True
        Me.lbl_et_comision.Location = New System.Drawing.Point(138, 85)
        Me.lbl_et_comision.Name = "lbl_et_comision"
        Me.lbl_et_comision.Size = New System.Drawing.Size(49, 13)
        Me.lbl_et_comision.TabIndex = 23
        Me.lbl_et_comision.Text = "Comisión"
        '
        'lbl_et_curso
        '
        Me.lbl_et_curso.AutoSize = True
        Me.lbl_et_curso.Location = New System.Drawing.Point(23, 85)
        Me.lbl_et_curso.Name = "lbl_et_curso"
        Me.lbl_et_curso.Size = New System.Drawing.Size(34, 13)
        Me.lbl_et_curso.TabIndex = 22
        Me.lbl_et_curso.Text = "Curso"
        '
        'lbl_et_profesor
        '
        Me.lbl_et_profesor.AutoSize = True
        Me.lbl_et_profesor.Location = New System.Drawing.Point(11, 57)
        Me.lbl_et_profesor.Name = "lbl_et_profesor"
        Me.lbl_et_profesor.Size = New System.Drawing.Size(46, 13)
        Me.lbl_et_profesor.TabIndex = 21
        Me.lbl_et_profesor.Text = "Profesor"
        '
        'cmb_materias_alta
        '
        Me.cmb_materias_alta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_materias_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_materias_alta.FormattingEnabled = True
        Me.cmb_materias_alta.Location = New System.Drawing.Point(63, 25)
        Me.cmb_materias_alta.Name = "cmb_materias_alta"
        Me.cmb_materias_alta.Size = New System.Drawing.Size(385, 21)
        Me.cmb_materias_alta.TabIndex = 0
        '
        'btn_aceptar_alta
        '
        Me.btn_aceptar_alta.Enabled = False
        Me.btn_aceptar_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar_alta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar_alta.Image = CType(resources.GetObject("btn_aceptar_alta.Image"), System.Drawing.Image)
        Me.btn_aceptar_alta.Location = New System.Drawing.Point(358, 456)
        Me.btn_aceptar_alta.Name = "btn_aceptar_alta"
        Me.btn_aceptar_alta.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar_alta.TabIndex = 71
        Me.btn_aceptar_alta.Text = "  "
        Me.btn_aceptar_alta.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(415, 456)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 72
        Me.btn_cancelar.Text = "  "
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmb_instancia
        '
        Me.cmb_instancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_instancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_instancia.FormattingEnabled = True
        Me.cmb_instancia.Location = New System.Drawing.Point(222, 110)
        Me.cmb_instancia.Name = "cmb_instancia"
        Me.cmb_instancia.Size = New System.Drawing.Size(108, 21)
        Me.cmb_instancia.TabIndex = 86
        '
        'planillas_asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 528)
        Me.Controls.Add(Me.lbl_lista)
        Me.Controls.Add(Me.lsv_planillas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.grp_alta)
        Me.Controls.Add(Me.btn_aceptar_alta)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Name = "planillas_asistencia"
        Me.Text = "planillas"
        Me.grp_alta.ResumeLayout(False)
        Me.grp_alta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_lista As System.Windows.Forms.Label
    Friend WithEvents lsv_planillas As System.Windows.Forms.ListView
    Friend WithEvents col_numero As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_anio As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_etapa As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_materia As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_codmateria As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_baja As System.Windows.Forms.Button
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents grp_alta As System.Windows.Forms.GroupBox
    Friend WithEvents chk_segundo As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_dia2_alta As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_dia1_alta As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_anio_alta As System.Windows.Forms.Label
    Friend WithEvents txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents txt_curso As System.Windows.Forms.TextBox
    Friend WithEvents cmb_profesores_alta As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_et_materia As System.Windows.Forms.Label
    Friend WithEvents lbl_et_instancia As System.Windows.Forms.Label
    Friend WithEvents lbl_et_anio As System.Windows.Forms.Label
    Friend WithEvents lbl_et_dias As System.Windows.Forms.Label
    Friend WithEvents lbl_et_comision As System.Windows.Forms.Label
    Friend WithEvents lbl_et_curso As System.Windows.Forms.Label
    Friend WithEvents lbl_et_profesor As System.Windows.Forms.Label
    Friend WithEvents cmb_materias_alta As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar_alta As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents chk_asis_obl As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_instancia As System.Windows.Forms.ComboBox
End Class
