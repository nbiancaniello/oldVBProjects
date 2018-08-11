<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Geometria
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
        Me.btn_perim_rect = New System.Windows.Forms.Button
        Me.btn_area_triangulo = New System.Windows.Forms.Button
        Me.btn_area_parale = New System.Windows.Forms.Button
        Me.btn_area_rectangulo = New System.Windows.Forms.Button
        Me.txt_lado3 = New System.Windows.Forms.TextBox
        Me.txt_lado2 = New System.Windows.Forms.TextBox
        Me.txt_lado1 = New System.Windows.Forms.TextBox
        Me.lbl_lado1 = New System.Windows.Forms.Label
        Me.lbl_lado2 = New System.Windows.Forms.Label
        Me.lbl_lado3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_perim_rect
        '
        Me.btn_perim_rect.Location = New System.Drawing.Point(12, 118)
        Me.btn_perim_rect.Name = "btn_perim_rect"
        Me.btn_perim_rect.Size = New System.Drawing.Size(92, 24)
        Me.btn_perim_rect.TabIndex = 0
        Me.btn_perim_rect.Text = "Perìmetro Rect."
        Me.btn_perim_rect.UseVisualStyleBackColor = True
        '
        'btn_area_triangulo
        '
        Me.btn_area_triangulo.Location = New System.Drawing.Point(12, 158)
        Me.btn_area_triangulo.Name = "btn_area_triangulo"
        Me.btn_area_triangulo.Size = New System.Drawing.Size(92, 24)
        Me.btn_area_triangulo.TabIndex = 1
        Me.btn_area_triangulo.Text = "Área triángulo"
        Me.btn_area_triangulo.UseVisualStyleBackColor = True
        '
        'btn_area_parale
        '
        Me.btn_area_parale.Location = New System.Drawing.Point(122, 118)
        Me.btn_area_parale.Name = "btn_area_parale"
        Me.btn_area_parale.Size = New System.Drawing.Size(92, 24)
        Me.btn_area_parale.TabIndex = 2
        Me.btn_area_parale.Text = "Área parale."
        Me.btn_area_parale.UseVisualStyleBackColor = True
        '
        'btn_area_rectangulo
        '
        Me.btn_area_rectangulo.Location = New System.Drawing.Point(122, 158)
        Me.btn_area_rectangulo.Name = "btn_area_rectangulo"
        Me.btn_area_rectangulo.Size = New System.Drawing.Size(92, 24)
        Me.btn_area_rectangulo.TabIndex = 3
        Me.btn_area_rectangulo.Text = "Área rectángulo"
        Me.btn_area_rectangulo.UseVisualStyleBackColor = True
        '
        'txt_lado3
        '
        Me.txt_lado3.Location = New System.Drawing.Point(88, 75)
        Me.txt_lado3.Name = "txt_lado3"
        Me.txt_lado3.Size = New System.Drawing.Size(126, 20)
        Me.txt_lado3.TabIndex = 4
        '
        'txt_lado2
        '
        Me.txt_lado2.Location = New System.Drawing.Point(88, 49)
        Me.txt_lado2.Name = "txt_lado2"
        Me.txt_lado2.Size = New System.Drawing.Size(126, 20)
        Me.txt_lado2.TabIndex = 5
        '
        'txt_lado1
        '
        Me.txt_lado1.Location = New System.Drawing.Point(89, 23)
        Me.txt_lado1.Name = "txt_lado1"
        Me.txt_lado1.Size = New System.Drawing.Size(126, 20)
        Me.txt_lado1.TabIndex = 6
        '
        'lbl_lado1
        '
        Me.lbl_lado1.AutoSize = True
        Me.lbl_lado1.Location = New System.Drawing.Point(30, 30)
        Me.lbl_lado1.Name = "lbl_lado1"
        Me.lbl_lado1.Size = New System.Drawing.Size(40, 13)
        Me.lbl_lado1.TabIndex = 7
        Me.lbl_lado1.Text = "Lado 1"
        '
        'lbl_lado2
        '
        Me.lbl_lado2.AutoSize = True
        Me.lbl_lado2.Location = New System.Drawing.Point(30, 56)
        Me.lbl_lado2.Name = "lbl_lado2"
        Me.lbl_lado2.Size = New System.Drawing.Size(40, 13)
        Me.lbl_lado2.TabIndex = 8
        Me.lbl_lado2.Text = "Lado 2"
        '
        'lbl_lado3
        '
        Me.lbl_lado3.AutoSize = True
        Me.lbl_lado3.Location = New System.Drawing.Point(30, 82)
        Me.lbl_lado3.Name = "lbl_lado3"
        Me.lbl_lado3.Size = New System.Drawing.Size(40, 13)
        Me.lbl_lado3.TabIndex = 9
        Me.lbl_lado3.Text = "Lado 3"
        '
        'Geometria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 193)
        Me.Controls.Add(Me.lbl_lado3)
        Me.Controls.Add(Me.lbl_lado2)
        Me.Controls.Add(Me.lbl_lado1)
        Me.Controls.Add(Me.txt_lado1)
        Me.Controls.Add(Me.txt_lado2)
        Me.Controls.Add(Me.txt_lado3)
        Me.Controls.Add(Me.btn_area_rectangulo)
        Me.Controls.Add(Me.btn_area_parale)
        Me.Controls.Add(Me.btn_area_triangulo)
        Me.Controls.Add(Me.btn_perim_rect)
        Me.Name = "Geometria"
        Me.Text = "Geometria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_perim_rect As System.Windows.Forms.Button
    Friend WithEvents btn_area_triangulo As System.Windows.Forms.Button
    Friend WithEvents btn_area_parale As System.Windows.Forms.Button
    Friend WithEvents btn_area_rectangulo As System.Windows.Forms.Button
    Friend WithEvents txt_lado3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_lado2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_lado1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_lado1 As System.Windows.Forms.Label
    Friend WithEvents lbl_lado2 As System.Windows.Forms.Label
    Friend WithEvents lbl_lado3 As System.Windows.Forms.Label

End Class
