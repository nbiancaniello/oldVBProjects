<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_triangulo
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
        Me.btn_triangulo = New System.Windows.Forms.Button
        Me.lbl_lado1 = New System.Windows.Forms.Label
        Me.lbl_lado2 = New System.Windows.Forms.Label
        Me.lbl_lado3 = New System.Windows.Forms.Label
        Me.txt_lado1 = New System.Windows.Forms.TextBox
        Me.txt_lado2 = New System.Windows.Forms.TextBox
        Me.txt_lado3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn_triangulo
        '
        Me.btn_triangulo.Location = New System.Drawing.Point(15, 124)
        Me.btn_triangulo.Name = "btn_triangulo"
        Me.btn_triangulo.Size = New System.Drawing.Size(102, 21)
        Me.btn_triangulo.TabIndex = 3
        Me.btn_triangulo.Text = "&Obtener triángulo"
        Me.btn_triangulo.UseVisualStyleBackColor = True
        '
        'lbl_lado1
        '
        Me.lbl_lado1.AutoSize = True
        Me.lbl_lado1.Location = New System.Drawing.Point(12, 26)
        Me.lbl_lado1.Name = "lbl_lado1"
        Me.lbl_lado1.Size = New System.Drawing.Size(43, 13)
        Me.lbl_lado1.TabIndex = 1
        Me.lbl_lado1.Text = "Lado 1:"
        '
        'lbl_lado2
        '
        Me.lbl_lado2.AutoSize = True
        Me.lbl_lado2.Location = New System.Drawing.Point(12, 56)
        Me.lbl_lado2.Name = "lbl_lado2"
        Me.lbl_lado2.Size = New System.Drawing.Size(43, 13)
        Me.lbl_lado2.TabIndex = 2
        Me.lbl_lado2.Text = "Lado 2:"
        '
        'lbl_lado3
        '
        Me.lbl_lado3.AutoSize = True
        Me.lbl_lado3.Location = New System.Drawing.Point(12, 90)
        Me.lbl_lado3.Name = "lbl_lado3"
        Me.lbl_lado3.Size = New System.Drawing.Size(43, 13)
        Me.lbl_lado3.TabIndex = 3
        Me.lbl_lado3.Text = "Lado 3:"
        '
        'txt_lado1
        '
        Me.txt_lado1.Location = New System.Drawing.Point(61, 23)
        Me.txt_lado1.MaxLength = 3
        Me.txt_lado1.Name = "txt_lado1"
        Me.txt_lado1.Size = New System.Drawing.Size(56, 20)
        Me.txt_lado1.TabIndex = 0
        '
        'txt_lado2
        '
        Me.txt_lado2.Location = New System.Drawing.Point(61, 53)
        Me.txt_lado2.MaxLength = 3
        Me.txt_lado2.Name = "txt_lado2"
        Me.txt_lado2.Size = New System.Drawing.Size(56, 20)
        Me.txt_lado2.TabIndex = 1
        '
        'txt_lado3
        '
        Me.txt_lado3.Location = New System.Drawing.Point(61, 87)
        Me.txt_lado3.MaxLength = 3
        Me.txt_lado3.Name = "txt_lado3"
        Me.txt_lado3.Size = New System.Drawing.Size(56, 20)
        Me.txt_lado3.TabIndex = 2
        '
        'frm_triangulo
        '
        Me.AcceptButton = Me.btn_triangulo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(134, 157)
        Me.Controls.Add(Me.txt_lado3)
        Me.Controls.Add(Me.txt_lado2)
        Me.Controls.Add(Me.txt_lado1)
        Me.Controls.Add(Me.lbl_lado3)
        Me.Controls.Add(Me.lbl_lado2)
        Me.Controls.Add(Me.lbl_lado1)
        Me.Controls.Add(Me.btn_triangulo)
        Me.Name = "frm_triangulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Triangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_triangulo As System.Windows.Forms.Button
    Friend WithEvents lbl_lado1 As System.Windows.Forms.Label
    Friend WithEvents lbl_lado2 As System.Windows.Forms.Label
    Friend WithEvents lbl_lado3 As System.Windows.Forms.Label
    Friend WithEvents txt_lado1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_lado2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_lado3 As System.Windows.Forms.TextBox

End Class
