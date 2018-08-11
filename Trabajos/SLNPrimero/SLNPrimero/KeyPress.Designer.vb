<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_key
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
        Me.lbl_letras = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.btn_totalizar = New System.Windows.Forms.Button
        Me.txt_letras = New System.Windows.Forms.TextBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.lbl_clet = New System.Windows.Forms.Label
        Me.lbl_cnum = New System.Windows.Forms.Label
        Me.lbl_tlet = New System.Windows.Forms.Label
        Me.lbl_tnum = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_letras
        '
        Me.lbl_letras.AutoSize = True
        Me.lbl_letras.Location = New System.Drawing.Point(14, 22)
        Me.lbl_letras.Name = "lbl_letras"
        Me.lbl_letras.Size = New System.Drawing.Size(36, 13)
        Me.lbl_letras.TabIndex = 0
        Me.lbl_letras.Text = "Letras"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(14, 60)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 1
        Me.lbl_numero.Text = "Número"
        '
        'btn_totalizar
        '
        Me.btn_totalizar.Location = New System.Drawing.Point(78, 81)
        Me.btn_totalizar.Name = "btn_totalizar"
        Me.btn_totalizar.Size = New System.Drawing.Size(97, 30)
        Me.btn_totalizar.TabIndex = 2
        Me.btn_totalizar.Text = "Totalizar"
        Me.btn_totalizar.UseVisualStyleBackColor = True
        '
        'txt_letras
        '
        Me.txt_letras.Location = New System.Drawing.Point(66, 19)
        Me.txt_letras.Name = "txt_letras"
        Me.txt_letras.Size = New System.Drawing.Size(144, 20)
        Me.txt_letras.TabIndex = 3
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(66, 55)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(144, 20)
        Me.txt_numero.TabIndex = 4
        '
        'lbl_clet
        '
        Me.lbl_clet.AutoSize = True
        Me.lbl_clet.Location = New System.Drawing.Point(33, 123)
        Me.lbl_clet.Name = "lbl_clet"
        Me.lbl_clet.Size = New System.Drawing.Size(102, 13)
        Me.lbl_clet.TabIndex = 5
        Me.lbl_clet.Text = "Cantidad de Letras: "
        '
        'lbl_cnum
        '
        Me.lbl_cnum.AutoSize = True
        Me.lbl_cnum.Location = New System.Drawing.Point(22, 153)
        Me.lbl_cnum.Name = "lbl_cnum"
        Me.lbl_cnum.Size = New System.Drawing.Size(113, 13)
        Me.lbl_cnum.TabIndex = 6
        Me.lbl_cnum.Text = "Cantidad de números: "
        '
        'lbl_tlet
        '
        Me.lbl_tlet.AutoSize = True
        Me.lbl_tlet.Location = New System.Drawing.Point(141, 123)
        Me.lbl_tlet.Name = "lbl_tlet"
        Me.lbl_tlet.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tlet.TabIndex = 7
        '
        'lbl_tnum
        '
        Me.lbl_tnum.AutoSize = True
        Me.lbl_tnum.Location = New System.Drawing.Point(139, 153)
        Me.lbl_tnum.Name = "lbl_tnum"
        Me.lbl_tnum.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tnum.TabIndex = 8
        '
        'frm_key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 208)
        Me.Controls.Add(Me.lbl_tnum)
        Me.Controls.Add(Me.lbl_tlet)
        Me.Controls.Add(Me.lbl_cnum)
        Me.Controls.Add(Me.lbl_clet)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.txt_letras)
        Me.Controls.Add(Me.btn_totalizar)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.lbl_letras)
        Me.Name = "frm_key"
        Me.Text = "KeyPress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_letras As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents btn_totalizar As System.Windows.Forms.Button
    Friend WithEvents txt_letras As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_clet As System.Windows.Forms.Label
    Friend WithEvents lbl_cnum As System.Windows.Forms.Label
    Friend WithEvents lbl_tlet As System.Windows.Forms.Label
    Friend WithEvents lbl_tnum As System.Windows.Forms.Label
End Class
