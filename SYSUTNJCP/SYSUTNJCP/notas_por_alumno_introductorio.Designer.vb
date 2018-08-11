<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notas_por_alumno_introductorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notas_por_alumno_introductorio))
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.lsv_diagnostico = New System.Windows.Forms.ListView
        Me.col_fecha = New System.Windows.Forms.ColumnHeader
        Me.col_nota_final = New System.Windows.Forms.ColumnHeader
        Me.lsv_materias_por_alumno = New System.Windows.Forms.ListView
        Me.col_codmateria = New System.Windows.Forms.ColumnHeader
        Me.col_materia = New System.Windows.Forms.ColumnHeader
        Me.col_instancia = New System.Windows.Forms.ColumnHeader
        Me.col_anio = New System.Windows.Forms.ColumnHeader
        Me.col_estado = New System.Windows.Forms.ColumnHeader
        Me.lsv_alumnos_inscriptos = New System.Windows.Forms.ListView
        Me.col_nro_inscripcion = New System.Windows.Forms.ColumnHeader
        Me.col_anioinscripcion = New System.Windows.Forms.ColumnHeader
        Me.col_apellido_nombre = New System.Windows.Forms.ColumnHeader
        Me.col_carrera = New System.Windows.Forms.ColumnHeader
        Me.btn_diag_desaprobado = New System.Windows.Forms.Button
        Me.btn_diag_aprobado = New System.Windows.Forms.Button
        Me.lsv_final = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lsv_recuperatorio = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.btn_final_desaprobado = New System.Windows.Forms.Button
        Me.btn_final_aprobado = New System.Windows.Forms.Button
        Me.btn_rec_desaprobado = New System.Windows.Forms.Button
        Me.btn_rec_aprobado = New System.Windows.Forms.Button
        Me.lbl_anio = New System.Windows.Forms.Label
        Me.cmb_anios = New System.Windows.Forms.ComboBox
        Me.lbl_diagnostico = New System.Windows.Forms.Label
        Me.lbl_final = New System.Windows.Forms.Label
        Me.lbl_recuperatorio = New System.Windows.Forms.Label
        Me.cmb_instancia = New System.Windows.Forms.ComboBox
        Me.lbl_instancia = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(314, 8)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(51, 51)
        Me.btn_buscar.TabIndex = 61
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lsv_diagnostico
        '
        Me.lsv_diagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_diagnostico.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_fecha, Me.col_nota_final})
        Me.lsv_diagnostico.Enabled = False
        Me.lsv_diagnostico.FullRowSelect = True
        Me.lsv_diagnostico.GridLines = True
        Me.lsv_diagnostico.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_diagnostico.Location = New System.Drawing.Point(117, 374)
        Me.lsv_diagnostico.MultiSelect = False
        Me.lsv_diagnostico.Name = "lsv_diagnostico"
        Me.lsv_diagnostico.Size = New System.Drawing.Size(154, 34)
        Me.lsv_diagnostico.TabIndex = 86
        Me.lsv_diagnostico.UseCompatibleStateImageBehavior = False
        Me.lsv_diagnostico.View = System.Windows.Forms.View.Details
        '
        'col_fecha
        '
        Me.col_fecha.Text = "Fecha"
        Me.col_fecha.Width = 70
        '
        'col_nota_final
        '
        Me.col_nota_final.Text = "Nota"
        Me.col_nota_final.Width = 83
        '
        'lsv_materias_por_alumno
        '
        Me.lsv_materias_por_alumno.AutoArrange = False
        Me.lsv_materias_por_alumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_materias_por_alumno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_codmateria, Me.col_materia, Me.col_instancia, Me.col_anio, Me.col_estado})
        Me.lsv_materias_por_alumno.FullRowSelect = True
        Me.lsv_materias_por_alumno.GridLines = True
        Me.lsv_materias_por_alumno.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_materias_por_alumno.HideSelection = False
        Me.lsv_materias_por_alumno.Location = New System.Drawing.Point(15, 264)
        Me.lsv_materias_por_alumno.MultiSelect = False
        Me.lsv_materias_por_alumno.Name = "lsv_materias_por_alumno"
        Me.lsv_materias_por_alumno.Size = New System.Drawing.Size(432, 104)
        Me.lsv_materias_por_alumno.TabIndex = 90
        Me.lsv_materias_por_alumno.UseCompatibleStateImageBehavior = False
        Me.lsv_materias_por_alumno.View = System.Windows.Forms.View.Details
        '
        'col_codmateria
        '
        Me.col_codmateria.Width = 0
        '
        'col_materia
        '
        Me.col_materia.Text = "Materia"
        Me.col_materia.Width = 317
        '
        'col_instancia
        '
        Me.col_instancia.DisplayIndex = 3
        Me.col_instancia.Text = ""
        Me.col_instancia.Width = 0
        '
        'col_anio
        '
        Me.col_anio.DisplayIndex = 4
        Me.col_anio.Text = ""
        Me.col_anio.Width = 0
        '
        'col_estado
        '
        Me.col_estado.DisplayIndex = 2
        Me.col_estado.Text = "Estado"
        Me.col_estado.Width = 112
        '
        'lsv_alumnos_inscriptos
        '
        Me.lsv_alumnos_inscriptos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_alumnos_inscriptos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_nro_inscripcion, Me.col_anioinscripcion, Me.col_apellido_nombre, Me.col_carrera})
        Me.lsv_alumnos_inscriptos.FullRowSelect = True
        Me.lsv_alumnos_inscriptos.GridLines = True
        Me.lsv_alumnos_inscriptos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_alumnos_inscriptos.HideSelection = False
        Me.lsv_alumnos_inscriptos.Location = New System.Drawing.Point(15, 69)
        Me.lsv_alumnos_inscriptos.MultiSelect = False
        Me.lsv_alumnos_inscriptos.Name = "lsv_alumnos_inscriptos"
        Me.lsv_alumnos_inscriptos.Size = New System.Drawing.Size(432, 189)
        Me.lsv_alumnos_inscriptos.TabIndex = 91
        Me.lsv_alumnos_inscriptos.UseCompatibleStateImageBehavior = False
        Me.lsv_alumnos_inscriptos.View = System.Windows.Forms.View.Details
        '
        'col_nro_inscripcion
        '
        Me.col_nro_inscripcion.Text = "Nº Insc."
        Me.col_nro_inscripcion.Width = 54
        '
        'col_anioinscripcion
        '
        Me.col_anioinscripcion.Text = "Año Inscr."
        '
        'col_apellido_nombre
        '
        Me.col_apellido_nombre.Text = "Apellido, Nombre"
        Me.col_apellido_nombre.Width = 315
        '
        'col_carrera
        '
        Me.col_carrera.Text = ""
        Me.col_carrera.Width = 0
        '
        'btn_diag_desaprobado
        '
        Me.btn_diag_desaprobado.Enabled = False
        Me.btn_diag_desaprobado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_diag_desaprobado.Location = New System.Drawing.Point(365, 374)
        Me.btn_diag_desaprobado.Name = "btn_diag_desaprobado"
        Me.btn_diag_desaprobado.Size = New System.Drawing.Size(82, 34)
        Me.btn_diag_desaprobado.TabIndex = 66
        Me.btn_diag_desaprobado.Text = "Desaprobado"
        Me.btn_diag_desaprobado.UseVisualStyleBackColor = True
        '
        'btn_diag_aprobado
        '
        Me.btn_diag_aprobado.Enabled = False
        Me.btn_diag_aprobado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_diag_aprobado.Location = New System.Drawing.Point(277, 374)
        Me.btn_diag_aprobado.Name = "btn_diag_aprobado"
        Me.btn_diag_aprobado.Size = New System.Drawing.Size(82, 34)
        Me.btn_diag_aprobado.TabIndex = 2
        Me.btn_diag_aprobado.Text = "Aprobado"
        Me.btn_diag_aprobado.UseVisualStyleBackColor = True
        '
        'lsv_final
        '
        Me.lsv_final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_final.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lsv_final.Enabled = False
        Me.lsv_final.FullRowSelect = True
        Me.lsv_final.GridLines = True
        Me.lsv_final.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_final.Location = New System.Drawing.Point(117, 414)
        Me.lsv_final.MultiSelect = False
        Me.lsv_final.Name = "lsv_final"
        Me.lsv_final.Size = New System.Drawing.Size(154, 34)
        Me.lsv_final.TabIndex = 92
        Me.lsv_final.UseCompatibleStateImageBehavior = False
        Me.lsv_final.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Fecha"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nota"
        Me.ColumnHeader2.Width = 81
        '
        'lsv_recuperatorio
        '
        Me.lsv_recuperatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_recuperatorio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsv_recuperatorio.Enabled = False
        Me.lsv_recuperatorio.FullRowSelect = True
        Me.lsv_recuperatorio.GridLines = True
        Me.lsv_recuperatorio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_recuperatorio.Location = New System.Drawing.Point(117, 454)
        Me.lsv_recuperatorio.MultiSelect = False
        Me.lsv_recuperatorio.Name = "lsv_recuperatorio"
        Me.lsv_recuperatorio.Size = New System.Drawing.Size(154, 34)
        Me.lsv_recuperatorio.TabIndex = 93
        Me.lsv_recuperatorio.UseCompatibleStateImageBehavior = False
        Me.lsv_recuperatorio.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nota"
        Me.ColumnHeader5.Width = 82
        '
        'btn_final_desaprobado
        '
        Me.btn_final_desaprobado.Enabled = False
        Me.btn_final_desaprobado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_final_desaprobado.Location = New System.Drawing.Point(365, 414)
        Me.btn_final_desaprobado.Name = "btn_final_desaprobado"
        Me.btn_final_desaprobado.Size = New System.Drawing.Size(82, 34)
        Me.btn_final_desaprobado.TabIndex = 95
        Me.btn_final_desaprobado.Text = "Desaprobado"
        Me.btn_final_desaprobado.UseVisualStyleBackColor = True
        '
        'btn_final_aprobado
        '
        Me.btn_final_aprobado.Enabled = False
        Me.btn_final_aprobado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_final_aprobado.Location = New System.Drawing.Point(277, 414)
        Me.btn_final_aprobado.Name = "btn_final_aprobado"
        Me.btn_final_aprobado.Size = New System.Drawing.Size(82, 34)
        Me.btn_final_aprobado.TabIndex = 94
        Me.btn_final_aprobado.Text = "Aprobado"
        Me.btn_final_aprobado.UseVisualStyleBackColor = True
        '
        'btn_rec_desaprobado
        '
        Me.btn_rec_desaprobado.Enabled = False
        Me.btn_rec_desaprobado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rec_desaprobado.Location = New System.Drawing.Point(365, 454)
        Me.btn_rec_desaprobado.Name = "btn_rec_desaprobado"
        Me.btn_rec_desaprobado.Size = New System.Drawing.Size(82, 34)
        Me.btn_rec_desaprobado.TabIndex = 97
        Me.btn_rec_desaprobado.Text = "Desaprobado"
        Me.btn_rec_desaprobado.UseVisualStyleBackColor = True
        '
        'btn_rec_aprobado
        '
        Me.btn_rec_aprobado.Enabled = False
        Me.btn_rec_aprobado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rec_aprobado.Location = New System.Drawing.Point(277, 454)
        Me.btn_rec_aprobado.Name = "btn_rec_aprobado"
        Me.btn_rec_aprobado.Size = New System.Drawing.Size(82, 34)
        Me.btn_rec_aprobado.TabIndex = 96
        Me.btn_rec_aprobado.Text = "Aprobado"
        Me.btn_rec_aprobado.UseVisualStyleBackColor = True
        '
        'lbl_anio
        '
        Me.lbl_anio.AutoSize = True
        Me.lbl_anio.Location = New System.Drawing.Point(12, 27)
        Me.lbl_anio.Name = "lbl_anio"
        Me.lbl_anio.Size = New System.Drawing.Size(26, 13)
        Me.lbl_anio.TabIndex = 99
        Me.lbl_anio.Text = "Año"
        '
        'cmb_anios
        '
        Me.cmb_anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_anios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_anios.FormattingEnabled = True
        Me.cmb_anios.Location = New System.Drawing.Point(44, 24)
        Me.cmb_anios.Name = "cmb_anios"
        Me.cmb_anios.Size = New System.Drawing.Size(71, 21)
        Me.cmb_anios.TabIndex = 100
        '
        'lbl_diagnostico
        '
        Me.lbl_diagnostico.AutoSize = True
        Me.lbl_diagnostico.Location = New System.Drawing.Point(30, 374)
        Me.lbl_diagnostico.Name = "lbl_diagnostico"
        Me.lbl_diagnostico.Size = New System.Drawing.Size(81, 13)
        Me.lbl_diagnostico.TabIndex = 102
        Me.lbl_diagnostico.Text = "DIAGNÓSTICO"
        '
        'lbl_final
        '
        Me.lbl_final.AutoSize = True
        Me.lbl_final.Location = New System.Drawing.Point(74, 414)
        Me.lbl_final.Name = "lbl_final"
        Me.lbl_final.Size = New System.Drawing.Size(37, 13)
        Me.lbl_final.TabIndex = 103
        Me.lbl_final.Text = "FINAL"
        '
        'lbl_recuperatorio
        '
        Me.lbl_recuperatorio.AutoSize = True
        Me.lbl_recuperatorio.Location = New System.Drawing.Point(11, 454)
        Me.lbl_recuperatorio.Name = "lbl_recuperatorio"
        Me.lbl_recuperatorio.Size = New System.Drawing.Size(100, 13)
        Me.lbl_recuperatorio.TabIndex = 104
        Me.lbl_recuperatorio.Text = "RECUPERATORIO"
        '
        'cmb_instancia
        '
        Me.cmb_instancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_instancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_instancia.FormattingEnabled = True
        Me.cmb_instancia.Location = New System.Drawing.Point(186, 24)
        Me.cmb_instancia.Name = "cmb_instancia"
        Me.cmb_instancia.Size = New System.Drawing.Size(108, 21)
        Me.cmb_instancia.TabIndex = 105
        '
        'lbl_instancia
        '
        Me.lbl_instancia.AutoSize = True
        Me.lbl_instancia.Location = New System.Drawing.Point(130, 27)
        Me.lbl_instancia.Name = "lbl_instancia"
        Me.lbl_instancia.Size = New System.Drawing.Size(50, 13)
        Me.lbl_instancia.TabIndex = 106
        Me.lbl_instancia.Text = "Instancia"
        '
        'notas_por_alumno_introductorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 501)
        Me.Controls.Add(Me.cmb_instancia)
        Me.Controls.Add(Me.lbl_instancia)
        Me.Controls.Add(Me.lbl_recuperatorio)
        Me.Controls.Add(Me.lbl_final)
        Me.Controls.Add(Me.lbl_diagnostico)
        Me.Controls.Add(Me.cmb_anios)
        Me.Controls.Add(Me.lbl_anio)
        Me.Controls.Add(Me.btn_rec_desaprobado)
        Me.Controls.Add(Me.btn_rec_aprobado)
        Me.Controls.Add(Me.btn_final_desaprobado)
        Me.Controls.Add(Me.btn_final_aprobado)
        Me.Controls.Add(Me.lsv_recuperatorio)
        Me.Controls.Add(Me.lsv_final)
        Me.Controls.Add(Me.btn_diag_desaprobado)
        Me.Controls.Add(Me.btn_diag_aprobado)
        Me.Controls.Add(Me.lsv_alumnos_inscriptos)
        Me.Controls.Add(Me.lsv_materias_por_alumno)
        Me.Controls.Add(Me.lsv_diagnostico)
        Me.Controls.Add(Me.btn_buscar)
        Me.Name = "notas_por_alumno_introductorio"
        Me.Text = "notas_por_alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lsv_diagnostico As System.Windows.Forms.ListView
    Friend WithEvents col_fecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_nota_final As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_materias_por_alumno As System.Windows.Forms.ListView
    Friend WithEvents col_codmateria As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_materia As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_alumnos_inscriptos As System.Windows.Forms.ListView
    Friend WithEvents col_nro_inscripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_anioinscripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_apellido_nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_carrera As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_diag_desaprobado As System.Windows.Forms.Button
    Friend WithEvents btn_diag_aprobado As System.Windows.Forms.Button
    Friend WithEvents lsv_final As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_recuperatorio As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_final_desaprobado As System.Windows.Forms.Button
    Friend WithEvents btn_final_aprobado As System.Windows.Forms.Button
    Friend WithEvents btn_rec_desaprobado As System.Windows.Forms.Button
    Friend WithEvents btn_rec_aprobado As System.Windows.Forms.Button
    Friend WithEvents lbl_anio As System.Windows.Forms.Label
    Friend WithEvents cmb_anios As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_diagnostico As System.Windows.Forms.Label
    Friend WithEvents lbl_final As System.Windows.Forms.Label
    Friend WithEvents lbl_recuperatorio As System.Windows.Forms.Label
    Friend WithEvents cmb_instancia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_instancia As System.Windows.Forms.Label
    Friend WithEvents col_instancia As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_anio As System.Windows.Forms.ColumnHeader
End Class
