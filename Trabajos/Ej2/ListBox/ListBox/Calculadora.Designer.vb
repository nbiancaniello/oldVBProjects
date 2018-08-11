<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Calculadora
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
        Me.txt_num1 = New System.Windows.Forms.TextBox
        Me.txt_num2 = New System.Windows.Forms.TextBox
        Me.lbl_num1 = New System.Windows.Forms.Label
        Me.lbl_num2 = New System.Windows.Forms.Label
        Me.btn_sumar = New System.Windows.Forms.Button
        Me.btn_restar = New System.Windows.Forms.Button
        Me.btn_dividir = New System.Windows.Forms.Button
        Me.btn_multiplicar = New System.Windows.Forms.Button
        Me.lbl_resultado = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(72, 15)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(134, 20)
        Me.txt_num1.TabIndex = 0
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(72, 41)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(134, 20)
        Me.txt_num2.TabIndex = 1
        '
        'lbl_num1
        '
        Me.lbl_num1.AutoSize = True
        Me.lbl_num1.Location = New System.Drawing.Point(5, 15)
        Me.lbl_num1.Name = "lbl_num1"
        Me.lbl_num1.Size = New System.Drawing.Size(53, 13)
        Me.lbl_num1.TabIndex = 2
        Me.lbl_num1.Text = "Número 1"
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(5, 44)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(53, 13)
        Me.lbl_num2.TabIndex = 3
        Me.lbl_num2.Text = "Número 2"
        '
        'btn_sumar
        '
        Me.btn_sumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sumar.Location = New System.Drawing.Point(12, 79)
        Me.btn_sumar.Name = "btn_sumar"
        Me.btn_sumar.Size = New System.Drawing.Size(35, 35)
        Me.btn_sumar.TabIndex = 2
        Me.btn_sumar.Text = "+"
        Me.btn_sumar.UseVisualStyleBackColor = True
        '
        'btn_restar
        '
        Me.btn_restar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restar.Location = New System.Drawing.Point(62, 79)
        Me.btn_restar.Name = "btn_restar"
        Me.btn_restar.Size = New System.Drawing.Size(35, 35)
        Me.btn_restar.TabIndex = 3
        Me.btn_restar.Text = "-"
        Me.btn_restar.UseVisualStyleBackColor = True
        '
        'btn_dividir
        '
        Me.btn_dividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dividir.Location = New System.Drawing.Point(112, 79)
        Me.btn_dividir.Name = "btn_dividir"
        Me.btn_dividir.Size = New System.Drawing.Size(35, 35)
        Me.btn_dividir.TabIndex = 4
        Me.btn_dividir.Text = "/"
        Me.btn_dividir.UseVisualStyleBackColor = True
        '
        'btn_multiplicar
        '
        Me.btn_multiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiplicar.Location = New System.Drawing.Point(162, 79)
        Me.btn_multiplicar.Name = "btn_multiplicar"
        Me.btn_multiplicar.Size = New System.Drawing.Size(35, 35)
        Me.btn_multiplicar.TabIndex = 5
        Me.btn_multiplicar.Text = "x"
        Me.btn_multiplicar.UseVisualStyleBackColor = True
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(9, 125)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_resultado.TabIndex = 8
        '
        'frm_Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 145)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.btn_multiplicar)
        Me.Controls.Add(Me.btn_dividir)
        Me.Controls.Add(Me.btn_restar)
        Me.Controls.Add(Me.btn_sumar)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.lbl_num1)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt_num1)
        Me.Name = "frm_Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_num1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_num2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_num1 As System.Windows.Forms.Label
    Friend WithEvents lbl_num2 As System.Windows.Forms.Label
    Friend WithEvents btn_sumar As System.Windows.Forms.Button
    Friend WithEvents btn_restar As System.Windows.Forms.Button
    Friend WithEvents btn_dividir As System.Windows.Forms.Button
    Friend WithEvents btn_multiplicar As System.Windows.Forms.Button
    Friend WithEvents lbl_resultado As System.Windows.Forms.Label
End Class
