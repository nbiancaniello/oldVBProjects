<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agrmodlocalidades
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
        Me.lbl_cod = New System.Windows.Forms.Label
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.txt_cp = New System.Windows.Forms.TextBox
        Me.txt_localidad = New System.Windows.Forms.TextBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.Location = New System.Drawing.Point(37, 22)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(24, 13)
        Me.lbl_cod.TabIndex = 0
        Me.lbl_cod.Text = "CP:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(5, 54)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 1
        Me.lbl_localidad.Text = "Localidad:"
        '
        'txt_cp
        '
        Me.txt_cp.Location = New System.Drawing.Point(67, 22)
        Me.txt_cp.MaxLength = 4
        Me.txt_cp.Name = "txt_cp"
        Me.txt_cp.Size = New System.Drawing.Size(46, 20)
        Me.txt_cp.TabIndex = 2
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(67, 51)
        Me.txt_localidad.MaxLength = 20
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(145, 20)
        Me.txt_localidad.TabIndex = 3
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(86, 89)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(60, 25)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(152, 89)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(60, 25)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_agrmodlocalidades
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(225, 124)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_localidad)
        Me.Controls.Add(Me.txt_cp)
        Me.Controls.Add(Me.lbl_localidad)
        Me.Controls.Add(Me.lbl_cod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_agrmodlocalidades"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cod As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents txt_cp As System.Windows.Forms.TextBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
