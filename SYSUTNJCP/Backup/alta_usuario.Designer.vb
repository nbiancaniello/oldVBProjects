<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alta_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta_usuario))
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbl_tipo_permiso = New System.Windows.Forms.Label
        Me.cmb_tipo_permiso = New System.Windows.Forms.ComboBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.lbl_password = New System.Windows.Forms.Label
        Me.lbl_usuario = New System.Windows.Forms.Label
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(236, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Cancelar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(182, 145)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Aceptar"
        '
        'lbl_tipo_permiso
        '
        Me.lbl_tipo_permiso.AutoSize = True
        Me.lbl_tipo_permiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_tipo_permiso.Location = New System.Drawing.Point(20, 67)
        Me.lbl_tipo_permiso.Name = "lbl_tipo_permiso"
        Me.lbl_tipo_permiso.Size = New System.Drawing.Size(83, 13)
        Me.lbl_tipo_permiso.TabIndex = 58
        Me.lbl_tipo_permiso.Text = "Tipo de Permiso"
        '
        'cmb_tipo_permiso
        '
        Me.cmb_tipo_permiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_permiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo_permiso.FormattingEnabled = True
        Me.cmb_tipo_permiso.Items.AddRange(New Object() {"ADMINISTRATIVO", "DOCENTE", "ALUMNO"})
        Me.cmb_tipo_permiso.Location = New System.Drawing.Point(123, 64)
        Me.cmb_tipo_permiso.Name = "cmb_tipo_permiso"
        Me.cmb_tipo_permiso.Size = New System.Drawing.Size(167, 21)
        Me.cmb_tipo_permiso.TabIndex = 53
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(182, 91)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar.TabIndex = 54
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_password.Location = New System.Drawing.Point(12, 40)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(91, 13)
        Me.lbl_password.TabIndex = 57
        Me.lbl_password.Text = "Password anterior"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_usuario.Location = New System.Drawing.Point(60, 15)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 56
        Me.lbl_usuario.Text = "Usuario"
        '
        'txt_clave
        '
        Me.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave.Location = New System.Drawing.Point(123, 38)
        Me.txt_clave.MaxLength = 15
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(167, 20)
        Me.txt_clave.TabIndex = 52
        Me.txt_clave.UseSystemPasswordChar = True
        '
        'txt_usuario
        '
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_usuario.Location = New System.Drawing.Point(123, 12)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(167, 20)
        Me.txt_usuario.TabIndex = 51
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Location = New System.Drawing.Point(239, 91)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 55
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'alta_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 169)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lbl_tipo_permiso)
        Me.Controls.Add(Me.cmb_tipo_permiso)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Name = "alta_usuario"
        Me.Text = "alta_usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_permiso As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_permiso As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
