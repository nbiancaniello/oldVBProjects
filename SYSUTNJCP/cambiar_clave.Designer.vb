<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiar_clave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cambiar_clave))
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.lbl_clave_nueva_repetir = New System.Windows.Forms.Label
        Me.lbl_clave_nueva = New System.Windows.Forms.Label
        Me.lbl_password = New System.Windows.Forms.Label
        Me.lbl_usuario = New System.Windows.Forms.Label
        Me.txt_clave_nueva_repetir = New System.Windows.Forms.TextBox
        Me.txt_clave_nueva = New System.Windows.Forms.TextBox
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(268, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Cancelar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(214, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 114
        Me.Label20.Text = "Aceptar"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(214, 117)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar.TabIndex = 108
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_clave_nueva_repetir
        '
        Me.lbl_clave_nueva_repetir.AutoSize = True
        Me.lbl_clave_nueva_repetir.Location = New System.Drawing.Point(12, 93)
        Me.lbl_clave_nueva_repetir.Name = "lbl_clave_nueva_repetir"
        Me.lbl_clave_nueva_repetir.Size = New System.Drawing.Size(137, 13)
        Me.lbl_clave_nueva_repetir.TabIndex = 113
        Me.lbl_clave_nueva_repetir.Text = "Reingrese Password nuevo"
        '
        'lbl_clave_nueva
        '
        Me.lbl_clave_nueva.AutoSize = True
        Me.lbl_clave_nueva.Location = New System.Drawing.Point(63, 67)
        Me.lbl_clave_nueva.Name = "lbl_clave_nueva"
        Me.lbl_clave_nueva.Size = New System.Drawing.Size(86, 13)
        Me.lbl_clave_nueva.TabIndex = 112
        Me.lbl_clave_nueva.Text = "Password nuevo"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(58, 41)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(91, 13)
        Me.lbl_password.TabIndex = 111
        Me.lbl_password.Text = "Password anterior"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(106, 15)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 110
        Me.lbl_usuario.Text = "Usuario"
        '
        'txt_clave_nueva_repetir
        '
        Me.txt_clave_nueva_repetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave_nueva_repetir.Location = New System.Drawing.Point(155, 91)
        Me.txt_clave_nueva_repetir.MaxLength = 15
        Me.txt_clave_nueva_repetir.Name = "txt_clave_nueva_repetir"
        Me.txt_clave_nueva_repetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave_nueva_repetir.Size = New System.Drawing.Size(167, 20)
        Me.txt_clave_nueva_repetir.TabIndex = 107
        Me.txt_clave_nueva_repetir.UseSystemPasswordChar = True
        '
        'txt_clave_nueva
        '
        Me.txt_clave_nueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave_nueva.Location = New System.Drawing.Point(155, 65)
        Me.txt_clave_nueva.MaxLength = 15
        Me.txt_clave_nueva.Name = "txt_clave_nueva"
        Me.txt_clave_nueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave_nueva.Size = New System.Drawing.Size(167, 20)
        Me.txt_clave_nueva.TabIndex = 106
        Me.txt_clave_nueva.UseSystemPasswordChar = True
        '
        'txt_clave
        '
        Me.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave.Location = New System.Drawing.Point(155, 39)
        Me.txt_clave.MaxLength = 15
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(167, 20)
        Me.txt_clave.TabIndex = 105
        Me.txt_clave.UseSystemPasswordChar = True
        '
        'txt_usuario
        '
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_usuario.Location = New System.Drawing.Point(155, 13)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(167, 20)
        Me.txt_usuario.TabIndex = 104
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(271, 117)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 109
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cambiar_clave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 194)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_clave_nueva_repetir)
        Me.Controls.Add(Me.lbl_clave_nueva)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_clave_nueva_repetir)
        Me.Controls.Add(Me.txt_clave_nueva)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Name = "cambiar_clave"
        Me.Text = "cambiar_clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_clave_nueva_repetir As System.Windows.Forms.Label
    Friend WithEvents lbl_clave_nueva As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txt_clave_nueva_repetir As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave_nueva As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
