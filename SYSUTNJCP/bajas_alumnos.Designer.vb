<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajas_alumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bajas_alumnos))
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lsv_alumnos_inscriptos = New System.Windows.Forms.ListView
        Me.col_nro_inscripcion = New System.Windows.Forms.ColumnHeader
        Me.col_anioinscripcion = New System.Windows.Forms.ColumnHeader
        Me.col_apellido_nombre = New System.Windows.Forms.ColumnHeader
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.tp_datos_personales = New System.Windows.Forms.TabControl
        Me.tp_datos = New System.Windows.Forms.TabPage
        Me.grp_datos_alumno = New System.Windows.Forms.GroupBox
        Me.txt_nacionalidad = New System.Windows.Forms.TextBox
        Me.txt_tipo_documento = New System.Windows.Forms.TextBox
        Me.txt_localidad = New System.Windows.Forms.TextBox
        Me.lbl_nacionalidad = New System.Windows.Forms.Label
        Me.txt_nro_documento = New System.Windows.Forms.TextBox
        Me.lbl_nro_documento = New System.Windows.Forms.Label
        Me.lbl_nro_legajo = New System.Windows.Forms.Label
        Me.lbl_tipo_documento = New System.Windows.Forms.Label
        Me.txt_nro_legajo = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.txt_domicilio = New System.Windows.Forms.TextBox
        Me.lbl_domicilio = New System.Windows.Forms.Label
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.tp_motivo = New System.Windows.Forms.TabPage
        Me.grp_baja = New System.Windows.Forms.GroupBox
        Me.cbx_motivo1 = New System.Windows.Forms.CheckBox
        Me.txt_motivo = New System.Windows.Forms.TextBox
        Me.cbx_motivo3 = New System.Windows.Forms.CheckBox
        Me.cbx_motivo4 = New System.Windows.Forms.CheckBox
        Me.cbx_motivo5 = New System.Windows.Forms.CheckBox
        Me.cbx_motivo2 = New System.Windows.Forms.CheckBox
        Me.tp_datos_personales.SuspendLayout()
        Me.tp_datos.SuspendLayout()
        Me.grp_datos_alumno.SuspendLayout()
        Me.tp_motivo.SuspendLayout()
        Me.grp_baja.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(694, 314)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 107
        Me.Label19.Text = "Cancelar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(628, 314)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "Aceptar"
        '
        'lsv_alumnos_inscriptos
        '
        Me.lsv_alumnos_inscriptos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_alumnos_inscriptos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_nro_inscripcion, Me.col_anioinscripcion, Me.col_apellido_nombre})
        Me.lsv_alumnos_inscriptos.FullRowSelect = True
        Me.lsv_alumnos_inscriptos.GridLines = True
        Me.lsv_alumnos_inscriptos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_alumnos_inscriptos.HideSelection = False
        Me.lsv_alumnos_inscriptos.Location = New System.Drawing.Point(12, 12)
        Me.lsv_alumnos_inscriptos.MultiSelect = False
        Me.lsv_alumnos_inscriptos.Name = "lsv_alumnos_inscriptos"
        Me.lsv_alumnos_inscriptos.Size = New System.Drawing.Size(402, 315)
        Me.lsv_alumnos_inscriptos.TabIndex = 103
        Me.lsv_alumnos_inscriptos.UseCompatibleStateImageBehavior = False
        Me.lsv_alumnos_inscriptos.View = System.Windows.Forms.View.Details
        '
        'col_nro_inscripcion
        '
        Me.col_nro_inscripcion.Text = "Nº Insc."
        '
        'col_anioinscripcion
        '
        Me.col_anioinscripcion.Text = "Año Insc."
        '
        'col_apellido_nombre
        '
        Me.col_apellido_nombre.Text = "Apellido, Nombre"
        Me.col_apellido_nombre.Width = 280
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(697, 260)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 105
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(628, 260)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar.TabIndex = 104
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'tp_datos_personales
        '
        Me.tp_datos_personales.Controls.Add(Me.tp_datos)
        Me.tp_datos_personales.Controls.Add(Me.tp_motivo)
        Me.tp_datos_personales.Location = New System.Drawing.Point(420, 12)
        Me.tp_datos_personales.Name = "tp_datos_personales"
        Me.tp_datos_personales.SelectedIndex = 0
        Me.tp_datos_personales.Size = New System.Drawing.Size(328, 242)
        Me.tp_datos_personales.TabIndex = 102
        '
        'tp_datos
        '
        Me.tp_datos.Controls.Add(Me.grp_datos_alumno)
        Me.tp_datos.Location = New System.Drawing.Point(4, 22)
        Me.tp_datos.Name = "tp_datos"
        Me.tp_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_datos.Size = New System.Drawing.Size(320, 216)
        Me.tp_datos.TabIndex = 0
        Me.tp_datos.Text = "Datos"
        Me.tp_datos.UseVisualStyleBackColor = True
        '
        'grp_datos_alumno
        '
        Me.grp_datos_alumno.Controls.Add(Me.txt_nacionalidad)
        Me.grp_datos_alumno.Controls.Add(Me.txt_tipo_documento)
        Me.grp_datos_alumno.Controls.Add(Me.txt_localidad)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_nacionalidad)
        Me.grp_datos_alumno.Controls.Add(Me.txt_nro_documento)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_nro_documento)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_nro_legajo)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_tipo_documento)
        Me.grp_datos_alumno.Controls.Add(Me.txt_nro_legajo)
        Me.grp_datos_alumno.Controls.Add(Me.txt_nombre)
        Me.grp_datos_alumno.Controls.Add(Me.txt_apellido)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_alumno.Controls.Add(Me.txt_domicilio)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_domicilio)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_apellido)
        Me.grp_datos_alumno.Controls.Add(Me.lbl_nombre)
        Me.grp_datos_alumno.Enabled = False
        Me.grp_datos_alumno.Location = New System.Drawing.Point(8, 6)
        Me.grp_datos_alumno.Name = "grp_datos_alumno"
        Me.grp_datos_alumno.Size = New System.Drawing.Size(306, 203)
        Me.grp_datos_alumno.TabIndex = 19
        Me.grp_datos_alumno.TabStop = False
        Me.grp_datos_alumno.Text = "Datos Alumno"
        '
        'txt_nacionalidad
        '
        Me.txt_nacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nacionalidad.Location = New System.Drawing.Point(109, 174)
        Me.txt_nacionalidad.Name = "txt_nacionalidad"
        Me.txt_nacionalidad.Size = New System.Drawing.Size(186, 20)
        Me.txt_nacionalidad.TabIndex = 24
        '
        'txt_tipo_documento
        '
        Me.txt_tipo_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_documento.Location = New System.Drawing.Point(65, 148)
        Me.txt_tipo_documento.Name = "txt_tipo_documento"
        Me.txt_tipo_documento.Size = New System.Drawing.Size(40, 20)
        Me.txt_tipo_documento.TabIndex = 23
        '
        'txt_localidad
        '
        Me.txt_localidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_localidad.Location = New System.Drawing.Point(109, 121)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(186, 20)
        Me.txt_localidad.TabIndex = 22
        '
        'lbl_nacionalidad
        '
        Me.lbl_nacionalidad.AutoSize = True
        Me.lbl_nacionalidad.Location = New System.Drawing.Point(25, 181)
        Me.lbl_nacionalidad.Name = "lbl_nacionalidad"
        Me.lbl_nacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lbl_nacionalidad.TabIndex = 19
        Me.lbl_nacionalidad.Text = "Nacionalidad"
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_documento.Location = New System.Drawing.Point(136, 148)
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(159, 20)
        Me.txt_nro_documento.TabIndex = 9
        '
        'lbl_nro_documento
        '
        Me.lbl_nro_documento.AutoSize = True
        Me.lbl_nro_documento.Location = New System.Drawing.Point(111, 151)
        Me.lbl_nro_documento.Name = "lbl_nro_documento"
        Me.lbl_nro_documento.Size = New System.Drawing.Size(19, 13)
        Me.lbl_nro_documento.TabIndex = 21
        Me.lbl_nro_documento.Text = "Nº"
        '
        'lbl_nro_legajo
        '
        Me.lbl_nro_legajo.AutoSize = True
        Me.lbl_nro_legajo.Location = New System.Drawing.Point(25, 20)
        Me.lbl_nro_legajo.Name = "lbl_nro_legajo"
        Me.lbl_nro_legajo.Size = New System.Drawing.Size(69, 13)
        Me.lbl_nro_legajo.TabIndex = 7
        Me.lbl_nro_legajo.Text = "Nº de Legajo"
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(8, 151)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(51, 13)
        Me.lbl_tipo_documento.TabIndex = 14
        Me.lbl_tipo_documento.Text = "Tipo Doc"
        '
        'txt_nro_legajo
        '
        Me.txt_nro_legajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_legajo.Enabled = False
        Me.txt_nro_legajo.Location = New System.Drawing.Point(109, 17)
        Me.txt_nro_legajo.Name = "txt_nro_legajo"
        Me.txt_nro_legajo.Size = New System.Drawing.Size(186, 20)
        Me.txt_nro_legajo.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Location = New System.Drawing.Point(109, 43)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(186, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Location = New System.Drawing.Point(109, 69)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(186, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(41, 124)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 11
        Me.lbl_localidad.Text = "Localidad"
        '
        'txt_domicilio
        '
        Me.txt_domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_domicilio.Location = New System.Drawing.Point(109, 95)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(186, 20)
        Me.txt_domicilio.TabIndex = 3
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(45, 98)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_domicilio.TabIndex = 10
        Me.lbl_domicilio.Text = "Domicilio"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(50, 72)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 9
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(50, 46)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 8
        Me.lbl_nombre.Text = "Nombre"
        '
        'tp_motivo
        '
        Me.tp_motivo.Controls.Add(Me.grp_baja)
        Me.tp_motivo.Location = New System.Drawing.Point(4, 22)
        Me.tp_motivo.Name = "tp_motivo"
        Me.tp_motivo.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_motivo.Size = New System.Drawing.Size(320, 216)
        Me.tp_motivo.TabIndex = 1
        Me.tp_motivo.Text = "Motivos"
        Me.tp_motivo.UseVisualStyleBackColor = True
        '
        'grp_baja
        '
        Me.grp_baja.Controls.Add(Me.cbx_motivo1)
        Me.grp_baja.Controls.Add(Me.txt_motivo)
        Me.grp_baja.Controls.Add(Me.cbx_motivo3)
        Me.grp_baja.Controls.Add(Me.cbx_motivo4)
        Me.grp_baja.Controls.Add(Me.cbx_motivo5)
        Me.grp_baja.Controls.Add(Me.cbx_motivo2)
        Me.grp_baja.Location = New System.Drawing.Point(6, 6)
        Me.grp_baja.Name = "grp_baja"
        Me.grp_baja.Size = New System.Drawing.Size(308, 204)
        Me.grp_baja.TabIndex = 34
        Me.grp_baja.TabStop = False
        '
        'cbx_motivo1
        '
        Me.cbx_motivo1.AutoSize = True
        Me.cbx_motivo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_motivo1.Location = New System.Drawing.Point(6, 19)
        Me.cbx_motivo1.Name = "cbx_motivo1"
        Me.cbx_motivo1.Size = New System.Drawing.Size(94, 17)
        Me.cbx_motivo1.TabIndex = 21
        Me.cbx_motivo1.Text = "P. Económicos"
        Me.cbx_motivo1.UseVisualStyleBackColor = True
        '
        'txt_motivo
        '
        Me.txt_motivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_motivo.Location = New System.Drawing.Point(6, 65)
        Me.txt_motivo.MaxLength = 512
        Me.txt_motivo.Multiline = True
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(296, 133)
        Me.txt_motivo.TabIndex = 20
        '
        'cbx_motivo3
        '
        Me.cbx_motivo3.AutoSize = True
        Me.cbx_motivo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_motivo3.Location = New System.Drawing.Point(205, 19)
        Me.cbx_motivo3.Name = "cbx_motivo3"
        Me.cbx_motivo3.Size = New System.Drawing.Size(59, 17)
        Me.cbx_motivo3.TabIndex = 25
        Me.cbx_motivo3.Text = "Trabajo"
        Me.cbx_motivo3.UseVisualStyleBackColor = True
        '
        'cbx_motivo4
        '
        Me.cbx_motivo4.AutoSize = True
        Me.cbx_motivo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_motivo4.Location = New System.Drawing.Point(6, 42)
        Me.cbx_motivo4.Name = "cbx_motivo4"
        Me.cbx_motivo4.Size = New System.Drawing.Size(141, 17)
        Me.cbx_motivo4.TabIndex = 22
        Me.cbx_motivo4.Text = "Dificultad En Aprendizaje"
        Me.cbx_motivo4.UseVisualStyleBackColor = True
        '
        'cbx_motivo5
        '
        Me.cbx_motivo5.AutoSize = True
        Me.cbx_motivo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_motivo5.Location = New System.Drawing.Point(156, 42)
        Me.cbx_motivo5.Name = "cbx_motivo5"
        Me.cbx_motivo5.Size = New System.Drawing.Size(48, 17)
        Me.cbx_motivo5.TabIndex = 24
        Me.cbx_motivo5.Text = "Otros"
        Me.cbx_motivo5.UseVisualStyleBackColor = True
        '
        'cbx_motivo2
        '
        Me.cbx_motivo2.AutoSize = True
        Me.cbx_motivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_motivo2.Location = New System.Drawing.Point(112, 19)
        Me.cbx_motivo2.Name = "cbx_motivo2"
        Me.cbx_motivo2.Size = New System.Drawing.Size(84, 17)
        Me.cbx_motivo2.TabIndex = 23
        Me.cbx_motivo2.Text = "M. Familiares"
        Me.cbx_motivo2.UseVisualStyleBackColor = True
        '
        'bajas_alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 339)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lsv_alumnos_inscriptos)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.tp_datos_personales)
        Me.Name = "bajas_alumnos"
        Me.Text = "bajas_alumnos"
        Me.tp_datos_personales.ResumeLayout(False)
        Me.tp_datos.ResumeLayout(False)
        Me.grp_datos_alumno.ResumeLayout(False)
        Me.grp_datos_alumno.PerformLayout()
        Me.tp_motivo.ResumeLayout(False)
        Me.grp_baja.ResumeLayout(False)
        Me.grp_baja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lsv_alumnos_inscriptos As System.Windows.Forms.ListView
    Friend WithEvents col_nro_inscripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_anioinscripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_apellido_nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents tp_datos_personales As System.Windows.Forms.TabControl
    Friend WithEvents tp_datos As System.Windows.Forms.TabPage
    Friend WithEvents grp_datos_alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_documento As System.Windows.Forms.TextBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nacionalidad As System.Windows.Forms.Label
    Friend WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_legajo As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents txt_nro_legajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents tp_motivo As System.Windows.Forms.TabPage
    Friend WithEvents grp_baja As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_motivo1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents cbx_motivo3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_motivo4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_motivo5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_motivo2 As System.Windows.Forms.CheckBox
End Class
