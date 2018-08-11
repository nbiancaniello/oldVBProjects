<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_colores
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
        Me.btn_aceptar2 = New System.Windows.Forms.Button
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.txt_edad = New System.Windows.Forms.TextBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_aceptar2
        '
        Me.btn_aceptar2.Location = New System.Drawing.Point(163, 74)
        Me.btn_aceptar2.Name = "btn_aceptar2"
        Me.btn_aceptar2.Size = New System.Drawing.Size(92, 24)
        Me.btn_aceptar2.TabIndex = 0
        Me.btn_aceptar2.Text = "&Aceptar"
        Me.btn_aceptar2.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(72, 14)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(203, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(72, 45)
        Me.txt_apellido.MaxLength = 30
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(203, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(72, 78)
        Me.txt_edad.MaxLength = 2
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(51, 20)
        Me.txt_edad.TabIndex = 3
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(10, 13)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(10, 48)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 5
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Location = New System.Drawing.Point(15, 83)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(35, 13)
        Me.lbl_edad.TabIndex = 6
        Me.lbl_edad.Text = "Edad:"
        '
        'frm_colores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 119)
        Me.Controls.Add(Me.lbl_edad)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_aceptar2)
        Me.Name = "frm_colores"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar2 As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_edad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
End Class
