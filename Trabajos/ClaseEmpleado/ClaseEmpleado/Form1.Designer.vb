<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_calcular = New System.Windows.Forms.Button
        Me.btn_edad = New System.Windows.Forms.Button
        Me.btn_obtener = New System.Windows.Forms.Button
        Me.btn_asignar = New System.Windows.Forms.Button
        Me.txt_legajo = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_sueldo = New System.Windows.Forms.TextBox
        Me.txt_comision = New System.Windows.Forms.TextBox
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker
        Me.lbl_legajo = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_sueldo = New System.Windows.Forms.Label
        Me.lbl_comision = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(244, 16)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(90, 25)
        Me.btn_calcular.TabIndex = 0
        Me.btn_calcular.Text = "&Calcular Sueldo"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_edad
        '
        Me.btn_edad.Location = New System.Drawing.Point(244, 53)
        Me.btn_edad.Name = "btn_edad"
        Me.btn_edad.Size = New System.Drawing.Size(90, 25)
        Me.btn_edad.TabIndex = 1
        Me.btn_edad.Text = "&Edad"
        Me.btn_edad.UseVisualStyleBackColor = True
        '
        'btn_obtener
        '
        Me.btn_obtener.Location = New System.Drawing.Point(244, 90)
        Me.btn_obtener.Name = "btn_obtener"
        Me.btn_obtener.Size = New System.Drawing.Size(90, 25)
        Me.btn_obtener.TabIndex = 2
        Me.btn_obtener.Text = "&Obtener Datos"
        Me.btn_obtener.UseVisualStyleBackColor = True
        '
        'btn_asignar
        '
        Me.btn_asignar.Location = New System.Drawing.Point(244, 125)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(90, 25)
        Me.btn_asignar.TabIndex = 3
        Me.btn_asignar.Text = "&Asignar Datos"
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(163, 21)
        Me.txt_legajo.MaxLength = 5
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(55, 20)
        Me.txt_legajo.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(71, 47)
        Me.txt_nombre.MaxLength = 40
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(147, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_sueldo
        '
        Me.txt_sueldo.Location = New System.Drawing.Point(163, 99)
        Me.txt_sueldo.MaxLength = 6
        Me.txt_sueldo.Name = "txt_sueldo"
        Me.txt_sueldo.Size = New System.Drawing.Size(55, 20)
        Me.txt_sueldo.TabIndex = 7
        '
        'txt_comision
        '
        Me.txt_comision.Location = New System.Drawing.Point(163, 125)
        Me.txt_comision.MaxLength = 2
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Size = New System.Drawing.Size(55, 20)
        Me.txt_comision.TabIndex = 8
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(130, 73)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fecha_nac.TabIndex = 9
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(16, 24)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_legajo.TabIndex = 10
        Me.lbl_legajo.Text = "Legajo"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(16, 53)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 11
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(16, 77)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(108, 13)
        Me.lbl_fecha.TabIndex = 12
        Me.lbl_fecha.Text = "Fecha de Nacimiento"
        '
        'lbl_sueldo
        '
        Me.lbl_sueldo.AutoSize = True
        Me.lbl_sueldo.Location = New System.Drawing.Point(16, 99)
        Me.lbl_sueldo.Name = "lbl_sueldo"
        Me.lbl_sueldo.Size = New System.Drawing.Size(40, 13)
        Me.lbl_sueldo.TabIndex = 13
        Me.lbl_sueldo.Text = "Sueldo"
        '
        'lbl_comision
        '
        Me.lbl_comision.AutoSize = True
        Me.lbl_comision.Location = New System.Drawing.Point(16, 128)
        Me.lbl_comision.Name = "lbl_comision"
        Me.lbl_comision.Size = New System.Drawing.Size(49, 13)
        Me.lbl_comision.TabIndex = 14
        Me.lbl_comision.Text = "Comision"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 172)
        Me.Controls.Add(Me.lbl_comision)
        Me.Controls.Add(Me.lbl_sueldo)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_legajo)
        Me.Controls.Add(Me.dtp_fecha_nac)
        Me.Controls.Add(Me.txt_comision)
        Me.Controls.Add(Me.txt_sueldo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_legajo)
        Me.Controls.Add(Me.btn_asignar)
        Me.Controls.Add(Me.btn_obtener)
        Me.Controls.Add(Me.btn_edad)
        Me.Controls.Add(Me.btn_calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_edad As System.Windows.Forms.Button
    Friend WithEvents btn_obtener As System.Windows.Forms.Button
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents txt_legajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_sueldo As System.Windows.Forms.TextBox
    Friend WithEvents txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_legajo As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_sueldo As System.Windows.Forms.Label
    Friend WithEvents lbl_comision As System.Windows.Forms.Label

End Class
