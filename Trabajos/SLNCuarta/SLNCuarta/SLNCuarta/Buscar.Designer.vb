<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Me.lbl_legajo = New System.Windows.Forms.Label
        Me.cmb_legajo = New System.Windows.Forms.ComboBox
        Me.cmb_nombre = New System.Windows.Forms.ComboBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_telefono = New System.Windows.Forms.Label
        Me.cmb_telefono = New System.Windows.Forms.ComboBox
        Me.lbl_celular = New System.Windows.Forms.Label
        Me.cmb_celular = New System.Windows.Forms.ComboBox
        Me.lbl_email = New System.Windows.Forms.Label
        Me.cmb_email = New System.Windows.Forms.ComboBox
        Me.lbl_sexo = New System.Windows.Forms.Label
        Me.cmb_sexo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_fecha = New System.Windows.Forms.ComboBox
        Me.txt_legajo1 = New System.Windows.Forms.TextBox
        Me.txt_telefono1 = New System.Windows.Forms.TextBox
        Me.txt_celular1 = New System.Windows.Forms.TextBox
        Me.txt_email1 = New System.Windows.Forms.TextBox
        Me.txt_nombre1 = New System.Windows.Forms.TextBox
        Me.txt_legajo2 = New System.Windows.Forms.TextBox
        Me.dtp_fecha_nacimiento1 = New System.Windows.Forms.DateTimePicker
        Me.dtp_fecha_nacimiento2 = New System.Windows.Forms.DateTimePicker
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(10, 47)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_legajo.TabIndex = 0
        Me.lbl_legajo.Text = "Legajo:"
        '
        'cmb_legajo
        '
        Me.cmb_legajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_legajo.FormattingEnabled = True
        Me.cmb_legajo.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinto de", "Entre"})
        Me.cmb_legajo.Location = New System.Drawing.Point(124, 44)
        Me.cmb_legajo.Name = "cmb_legajo"
        Me.cmb_legajo.Size = New System.Drawing.Size(106, 21)
        Me.cmb_legajo.TabIndex = 0
        '
        'cmb_nombre
        '
        Me.cmb_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nombre.FormattingEnabled = True
        Me.cmb_nombre.Items.AddRange(New Object() {"Igual que", "Comienza con", "Contiene", "Finaliza en"})
        Me.cmb_nombre.Location = New System.Drawing.Point(124, 74)
        Me.cmb_nombre.Name = "cmb_nombre"
        Me.cmb_nombre.Size = New System.Drawing.Size(106, 21)
        Me.cmb_nombre.TabIndex = 3
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(10, 78)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(10, 107)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 5
        Me.lbl_telefono.Text = "Telefono"
        '
        'cmb_telefono
        '
        Me.cmb_telefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_telefono.FormattingEnabled = True
        Me.cmb_telefono.Items.AddRange(New Object() {"Igual que", "Comienza con", "Contiene", "Finaliza en"})
        Me.cmb_telefono.Location = New System.Drawing.Point(124, 104)
        Me.cmb_telefono.Name = "cmb_telefono"
        Me.cmb_telefono.Size = New System.Drawing.Size(106, 21)
        Me.cmb_telefono.TabIndex = 5
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(10, 138)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(42, 13)
        Me.lbl_celular.TabIndex = 7
        Me.lbl_celular.Text = "Celular:"
        '
        'cmb_celular
        '
        Me.cmb_celular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_celular.FormattingEnabled = True
        Me.cmb_celular.Items.AddRange(New Object() {"Igual que", "Comienza con", "Contiene", "Finaliza en"})
        Me.cmb_celular.Location = New System.Drawing.Point(124, 135)
        Me.cmb_celular.Name = "cmb_celular"
        Me.cmb_celular.Size = New System.Drawing.Size(106, 21)
        Me.cmb_celular.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(10, 169)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 9
        Me.lbl_email.Text = "E-mail:"
        '
        'cmb_email
        '
        Me.cmb_email.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_email.FormattingEnabled = True
        Me.cmb_email.Items.AddRange(New Object() {"Igual que", "Comienza con", "Contiene", "Finaliza en"})
        Me.cmb_email.Location = New System.Drawing.Point(124, 166)
        Me.cmb_email.Name = "cmb_email"
        Me.cmb_email.Size = New System.Drawing.Size(106, 21)
        Me.cmb_email.TabIndex = 9
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(10, 201)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(34, 13)
        Me.lbl_sexo.TabIndex = 11
        Me.lbl_sexo.Text = "Sexo:"
        '
        'cmb_sexo
        '
        Me.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Items.AddRange(New Object() {"Ambos", "Masculino", "Femenino"})
        Me.cmb_sexo.Location = New System.Drawing.Point(124, 198)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(106, 21)
        Me.cmb_sexo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha de nacimiento:"
        '
        'cmb_fecha
        '
        Me.cmb_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fecha.FormattingEnabled = True
        Me.cmb_fecha.Items.AddRange(New Object() {"Igual a", "Mayor que", "Menor que", "Distinta que", "Entre"})
        Me.cmb_fecha.Location = New System.Drawing.Point(124, 229)
        Me.cmb_fecha.Name = "cmb_fecha"
        Me.cmb_fecha.Size = New System.Drawing.Size(106, 21)
        Me.cmb_fecha.TabIndex = 12
        '
        'txt_legajo1
        '
        Me.txt_legajo1.Enabled = False
        Me.txt_legajo1.Location = New System.Drawing.Point(348, 45)
        Me.txt_legajo1.MaxLength = 5
        Me.txt_legajo1.Name = "txt_legajo1"
        Me.txt_legajo1.Size = New System.Drawing.Size(40, 20)
        Me.txt_legajo1.TabIndex = 1
        '
        'txt_telefono1
        '
        Me.txt_telefono1.Location = New System.Drawing.Point(236, 104)
        Me.txt_telefono1.MaxLength = 20
        Me.txt_telefono1.Name = "txt_telefono1"
        Me.txt_telefono1.Size = New System.Drawing.Size(152, 20)
        Me.txt_telefono1.TabIndex = 6
        '
        'txt_celular1
        '
        Me.txt_celular1.Location = New System.Drawing.Point(236, 135)
        Me.txt_celular1.Name = "txt_celular1"
        Me.txt_celular1.Size = New System.Drawing.Size(152, 20)
        Me.txt_celular1.TabIndex = 8
        '
        'txt_email1
        '
        Me.txt_email1.Location = New System.Drawing.Point(236, 167)
        Me.txt_email1.Name = "txt_email1"
        Me.txt_email1.Size = New System.Drawing.Size(152, 20)
        Me.txt_email1.TabIndex = 10
        '
        'txt_nombre1
        '
        Me.txt_nombre1.Location = New System.Drawing.Point(236, 75)
        Me.txt_nombre1.MaxLength = 40
        Me.txt_nombre1.Name = "txt_nombre1"
        Me.txt_nombre1.Size = New System.Drawing.Size(152, 20)
        Me.txt_nombre1.TabIndex = 4
        '
        'txt_legajo2
        '
        Me.txt_legajo2.Enabled = False
        Me.txt_legajo2.Location = New System.Drawing.Point(457, 44)
        Me.txt_legajo2.MaxLength = 5
        Me.txt_legajo2.Name = "txt_legajo2"
        Me.txt_legajo2.Size = New System.Drawing.Size(40, 20)
        Me.txt_legajo2.TabIndex = 2
        '
        'dtp_fecha_nacimiento1
        '
        Me.dtp_fecha_nacimiento1.Enabled = False
        Me.dtp_fecha_nacimiento1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nacimiento1.Location = New System.Drawing.Point(296, 230)
        Me.dtp_fecha_nacimiento1.Name = "dtp_fecha_nacimiento1"
        Me.dtp_fecha_nacimiento1.Size = New System.Drawing.Size(92, 20)
        Me.dtp_fecha_nacimiento1.TabIndex = 13
        '
        'dtp_fecha_nacimiento2
        '
        Me.dtp_fecha_nacimiento2.Enabled = False
        Me.dtp_fecha_nacimiento2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nacimiento2.Location = New System.Drawing.Point(405, 229)
        Me.dtp_fecha_nacimiento2.Name = "dtp_fecha_nacimiento2"
        Me.dtp_fecha_nacimiento2.Size = New System.Drawing.Size(92, 20)
        Me.dtp_fecha_nacimiento2.TabIndex = 14
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Image = Global.SLNCuarta.My.Resources.Resources.smallfail
        Me.btn_cancelar.Location = New System.Drawing.Point(296, 255)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(37, 34)
        Me.btn_cancelar.TabIndex = 16
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Image = Global.SLNCuarta.My.Resources.Resources.smallsuccess
        Me.btn_aceptar.Location = New System.Drawing.Point(236, 255)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(37, 34)
        Me.btn_aceptar.TabIndex = 15
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_desde
        '
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.Location = New System.Drawing.Point(299, 9)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(89, 25)
        Me.lbl_desde.TabIndex = 30
        Me.lbl_desde.Text = "DESDE"
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.Location = New System.Drawing.Point(410, 9)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(87, 25)
        Me.lbl_hasta.TabIndex = 31
        Me.lbl_hasta.Text = "HASTA"
        '
        'Buscar
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(515, 302)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.dtp_fecha_nacimiento2)
        Me.Controls.Add(Me.dtp_fecha_nacimiento1)
        Me.Controls.Add(Me.txt_legajo2)
        Me.Controls.Add(Me.txt_legajo1)
        Me.Controls.Add(Me.txt_telefono1)
        Me.Controls.Add(Me.txt_celular1)
        Me.Controls.Add(Me.txt_email1)
        Me.Controls.Add(Me.txt_nombre1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_fecha)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.cmb_sexo)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.cmb_email)
        Me.Controls.Add(Me.lbl_celular)
        Me.Controls.Add(Me.cmb_celular)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.cmb_telefono)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.cmb_nombre)
        Me.Controls.Add(Me.cmb_legajo)
        Me.Controls.Add(Me.lbl_legajo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Buscar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar por:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_legajo As System.Windows.Forms.Label
    Friend WithEvents cmb_legajo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents cmb_telefono As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_celular As System.Windows.Forms.Label
    Friend WithEvents cmb_celular As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents cmb_email As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents cmb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_fecha As System.Windows.Forms.ComboBox
    Friend WithEvents txt_legajo1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_celular1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_email1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_legajo2 As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_nacimiento1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_nacimiento2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
End Class
