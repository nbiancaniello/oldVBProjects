<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logueo
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
        Me.lbl_usuario = New System.Windows.Forms.Label
        Me.lbl_clave = New System.Windows.Forms.Label
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_canc = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(13, 27)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(50, 13)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clave.Location = New System.Drawing.Point(13, 63)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(39, 13)
        Me.lbl_clave.TabIndex = 1
        Me.lbl_clave.Text = "Clave"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(68, 24)
        Me.txt_usuario.MaxLength = 6
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(161, 20)
        Me.txt_usuario.TabIndex = 2
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(68, 60)
        Me.txt_clave.MaxLength = 6
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(160, 20)
        Me.txt_clave.TabIndex = 3
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Location = New System.Drawing.Point(34, 98)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(66, 27)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_canc
        '
        Me.btn_canc.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_canc.Location = New System.Drawing.Point(141, 98)
        Me.btn_canc.Name = "btn_canc"
        Me.btn_canc.Size = New System.Drawing.Size(66, 27)
        Me.btn_canc.TabIndex = 5
        Me.btn_canc.Text = "Cancelar"
        Me.btn_canc.UseVisualStyleBackColor = False
        '
        'frm_logueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(241, 156)
        Me.Controls.Add(Me.btn_canc)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Name = "frm_logueo"
        Me.Text = "Acceso al Sistema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_clave As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_canc As System.Windows.Forms.Button

End Class
