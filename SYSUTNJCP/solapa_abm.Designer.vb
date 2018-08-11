<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class solapa_abm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(solapa_abm))
        Me.Label16 = New System.Windows.Forms.Label
        Me.grp_alumnos2 = New System.Windows.Forms.GroupBox
        Me.lbl_titulos = New System.Windows.Forms.Label
        Me.lbl_lugares_nac = New System.Windows.Forms.Label
        Me.btn_titulos = New System.Windows.Forms.Button
        Me.btn_lugares_nac = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.grp_alumnos1 = New System.Windows.Forms.GroupBox
        Me.lbl_nacionalidades = New System.Windows.Forms.Label
        Me.btn_nacionalidades = New System.Windows.Forms.Button
        Me.lbl_localidades = New System.Windows.Forms.Label
        Me.btn_localidad = New System.Windows.Forms.Button
        Me.grp_alumnos2.SuspendLayout()
        Me.grp_alumnos1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(604, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Regresar"
        '
        'grp_alumnos2
        '
        Me.grp_alumnos2.Controls.Add(Me.lbl_titulos)
        Me.grp_alumnos2.Controls.Add(Me.lbl_lugares_nac)
        Me.grp_alumnos2.Controls.Add(Me.btn_titulos)
        Me.grp_alumnos2.Controls.Add(Me.btn_lugares_nac)
        Me.grp_alumnos2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_alumnos2.Location = New System.Drawing.Point(12, 101)
        Me.grp_alumnos2.Name = "grp_alumnos2"
        Me.grp_alumnos2.Size = New System.Drawing.Size(585, 83)
        Me.grp_alumnos2.TabIndex = 55
        Me.grp_alumnos2.TabStop = False
        '
        'lbl_titulos
        '
        Me.lbl_titulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_titulos.Location = New System.Drawing.Point(76, 26)
        Me.lbl_titulos.Name = "lbl_titulos"
        Me.lbl_titulos.Size = New System.Drawing.Size(109, 29)
        Me.lbl_titulos.TabIndex = 31
        Me.lbl_titulos.Text = "Títulos"
        '
        'lbl_lugares_nac
        '
        Me.lbl_lugares_nac.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lugares_nac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_lugares_nac.Location = New System.Drawing.Point(314, 26)
        Me.lbl_lugares_nac.Name = "lbl_lugares_nac"
        Me.lbl_lugares_nac.Size = New System.Drawing.Size(265, 29)
        Me.lbl_lugares_nac.TabIndex = 31
        Me.lbl_lugares_nac.Text = "Lugares de Nacimiento"
        '
        'btn_titulos
        '
        Me.btn_titulos.BackgroundImage = CType(resources.GetObject("btn_titulos.BackgroundImage"), System.Drawing.Image)
        Me.btn_titulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_titulos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_titulos.Location = New System.Drawing.Point(19, 19)
        Me.btn_titulos.Name = "btn_titulos"
        Me.btn_titulos.Size = New System.Drawing.Size(51, 51)
        Me.btn_titulos.TabIndex = 6
        Me.btn_titulos.UseVisualStyleBackColor = True
        '
        'btn_lugares_nac
        '
        Me.btn_lugares_nac.BackgroundImage = CType(resources.GetObject("btn_lugares_nac.BackgroundImage"), System.Drawing.Image)
        Me.btn_lugares_nac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_lugares_nac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_lugares_nac.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_lugares_nac.Location = New System.Drawing.Point(257, 19)
        Me.btn_lugares_nac.Name = "btn_lugares_nac"
        Me.btn_lugares_nac.Size = New System.Drawing.Size(51, 51)
        Me.btn_lugares_nac.TabIndex = 30
        Me.btn_lugares_nac.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(603, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 51)
        Me.Button1.TabIndex = 56
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grp_alumnos1
        '
        Me.grp_alumnos1.Controls.Add(Me.lbl_nacionalidades)
        Me.grp_alumnos1.Controls.Add(Me.btn_nacionalidades)
        Me.grp_alumnos1.Controls.Add(Me.lbl_localidades)
        Me.grp_alumnos1.Controls.Add(Me.btn_localidad)
        Me.grp_alumnos1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_alumnos1.Location = New System.Drawing.Point(12, 12)
        Me.grp_alumnos1.Name = "grp_alumnos1"
        Me.grp_alumnos1.Size = New System.Drawing.Size(585, 83)
        Me.grp_alumnos1.TabIndex = 54
        Me.grp_alumnos1.TabStop = False
        '
        'lbl_nacionalidades
        '
        Me.lbl_nacionalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nacionalidades.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_nacionalidades.Location = New System.Drawing.Point(314, 26)
        Me.lbl_nacionalidades.Name = "lbl_nacionalidades"
        Me.lbl_nacionalidades.Size = New System.Drawing.Size(195, 29)
        Me.lbl_nacionalidades.TabIndex = 31
        Me.lbl_nacionalidades.Text = "Nacionalidades"
        '
        'btn_nacionalidades
        '
        Me.btn_nacionalidades.BackgroundImage = CType(resources.GetObject("btn_nacionalidades.BackgroundImage"), System.Drawing.Image)
        Me.btn_nacionalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nacionalidades.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_nacionalidades.Location = New System.Drawing.Point(257, 19)
        Me.btn_nacionalidades.Name = "btn_nacionalidades"
        Me.btn_nacionalidades.Size = New System.Drawing.Size(51, 51)
        Me.btn_nacionalidades.TabIndex = 30
        Me.btn_nacionalidades.UseVisualStyleBackColor = True
        '
        'lbl_localidades
        '
        Me.lbl_localidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidades.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_localidades.Location = New System.Drawing.Point(76, 26)
        Me.lbl_localidades.Name = "lbl_localidades"
        Me.lbl_localidades.Size = New System.Drawing.Size(157, 29)
        Me.lbl_localidades.TabIndex = 29
        Me.lbl_localidades.Text = "Localidades"
        '
        'btn_localidad
        '
        Me.btn_localidad.BackgroundImage = CType(resources.GetObject("btn_localidad.BackgroundImage"), System.Drawing.Image)
        Me.btn_localidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_localidad.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_localidad.Location = New System.Drawing.Point(19, 19)
        Me.btn_localidad.Name = "btn_localidad"
        Me.btn_localidad.Size = New System.Drawing.Size(51, 51)
        Me.btn_localidad.TabIndex = 6
        Me.btn_localidad.UseVisualStyleBackColor = True
        '
        'solapa_abm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 195)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grp_alumnos2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grp_alumnos1)
        Me.Name = "solapa_abm"
        Me.Text = "solapa_abm"
        Me.grp_alumnos2.ResumeLayout(False)
        Me.grp_alumnos1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grp_alumnos2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_titulos As System.Windows.Forms.Label
    Friend WithEvents lbl_lugares_nac As System.Windows.Forms.Label
    Friend WithEvents btn_titulos As System.Windows.Forms.Button
    Friend WithEvents btn_lugares_nac As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grp_alumnos1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nacionalidades As System.Windows.Forms.Label
    Friend WithEvents btn_nacionalidades As System.Windows.Forms.Button
    Friend WithEvents lbl_localidades As System.Windows.Forms.Label
    Friend WithEvents btn_localidad As System.Windows.Forms.Button
End Class
