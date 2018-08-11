<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btn_traer = New System.Windows.Forms.Button
        Me.txt_cod_postal = New System.Windows.Forms.TextBox
        Me.lbl_cod_postal = New System.Windows.Forms.Label
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.lbl_nombre_localidad = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_traer
        '
        Me.btn_traer.Location = New System.Drawing.Point(132, 105)
        Me.btn_traer.Name = "btn_traer"
        Me.btn_traer.Size = New System.Drawing.Size(78, 30)
        Me.btn_traer.TabIndex = 1
        Me.btn_traer.Text = "Traer"
        Me.btn_traer.UseVisualStyleBackColor = True
        '
        'txt_cod_postal
        '
        Me.txt_cod_postal.Location = New System.Drawing.Point(109, 28)
        Me.txt_cod_postal.Name = "txt_cod_postal"
        Me.txt_cod_postal.Size = New System.Drawing.Size(102, 20)
        Me.txt_cod_postal.TabIndex = 0
        '
        'lbl_cod_postal
        '
        Me.lbl_cod_postal.AutoSize = True
        Me.lbl_cod_postal.Location = New System.Drawing.Point(22, 31)
        Me.lbl_cod_postal.Name = "lbl_cod_postal"
        Me.lbl_cod_postal.Size = New System.Drawing.Size(71, 13)
        Me.lbl_cod_postal.TabIndex = 2
        Me.lbl_cod_postal.Text = "Código postal"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(22, 65)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 4
        Me.lbl_localidad.Text = "Localidad"
        '
        'lbl_nombre_localidad
        '
        Me.lbl_nombre_localidad.AutoSize = True
        Me.lbl_nombre_localidad.Location = New System.Drawing.Point(106, 65)
        Me.lbl_nombre_localidad.Name = "lbl_nombre_localidad"
        Me.lbl_nombre_localidad.Size = New System.Drawing.Size(0, 13)
        Me.lbl_nombre_localidad.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 161)
        Me.Controls.Add(Me.lbl_nombre_localidad)
        Me.Controls.Add(Me.lbl_localidad)
        Me.Controls.Add(Me.lbl_cod_postal)
        Me.Controls.Add(Me.txt_cod_postal)
        Me.Controls.Add(Me.btn_traer)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_traer As System.Windows.Forms.Button
    Friend WithEvents txt_cod_postal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cod_postal As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_localidad As System.Windows.Forms.Label
End Class
