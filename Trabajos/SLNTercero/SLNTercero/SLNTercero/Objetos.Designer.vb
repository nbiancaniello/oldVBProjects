<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Objetos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Objetos))
        Me.btn_der = New System.Windows.Forms.Button
        Me.btn_ab = New System.Windows.Forms.Button
        Me.btn_arr = New System.Windows.Forms.Button
        Me.btn_izq = New System.Windows.Forms.Button
        Me.lbl_cant = New System.Windows.Forms.Label
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.pcb_imagen = New System.Windows.Forms.PictureBox
        CType(Me.pcb_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_der
        '
        Me.btn_der.Location = New System.Drawing.Point(425, 434)
        Me.btn_der.Name = "btn_der"
        Me.btn_der.Size = New System.Drawing.Size(49, 27)
        Me.btn_der.TabIndex = 8
        Me.btn_der.Text = "DER"
        Me.btn_der.UseVisualStyleBackColor = True
        '
        'btn_ab
        '
        Me.btn_ab.Location = New System.Drawing.Point(369, 434)
        Me.btn_ab.Name = "btn_ab"
        Me.btn_ab.Size = New System.Drawing.Size(50, 27)
        Me.btn_ab.TabIndex = 7
        Me.btn_ab.Text = "AB"
        Me.btn_ab.UseVisualStyleBackColor = True
        '
        'btn_arr
        '
        Me.btn_arr.Location = New System.Drawing.Point(312, 434)
        Me.btn_arr.Name = "btn_arr"
        Me.btn_arr.Size = New System.Drawing.Size(51, 27)
        Me.btn_arr.TabIndex = 6
        Me.btn_arr.Text = "ARR"
        Me.btn_arr.UseVisualStyleBackColor = True
        '
        'btn_izq
        '
        Me.btn_izq.Location = New System.Drawing.Point(255, 434)
        Me.btn_izq.Name = "btn_izq"
        Me.btn_izq.Size = New System.Drawing.Size(51, 27)
        Me.btn_izq.TabIndex = 5
        Me.btn_izq.Text = "IZ"
        Me.btn_izq.UseVisualStyleBackColor = True
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Location = New System.Drawing.Point(482, 438)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(52, 13)
        Me.lbl_cant.TabIndex = 9
        Me.lbl_cant.Text = "Cantidad:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(540, 435)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(43, 20)
        Me.txt_cantidad.TabIndex = 10
        '
        'pcb_imagen
        '
        Me.pcb_imagen.Image = CType(resources.GetObject("pcb_imagen.Image"), System.Drawing.Image)
        Me.pcb_imagen.Location = New System.Drawing.Point(230, 124)
        Me.pcb_imagen.Name = "pcb_imagen"
        Me.pcb_imagen.Size = New System.Drawing.Size(166, 126)
        Me.pcb_imagen.TabIndex = 11
        Me.pcb_imagen.TabStop = False
        '
        'Objetos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 473)
        Me.Controls.Add(Me.pcb_imagen)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lbl_cant)
        Me.Controls.Add(Me.btn_der)
        Me.Controls.Add(Me.btn_ab)
        Me.Controls.Add(Me.btn_arr)
        Me.Controls.Add(Me.btn_izq)
        Me.Name = "Objetos"
        Me.Text = "Objetos"
        CType(Me.pcb_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_der As System.Windows.Forms.Button
    Friend WithEvents btn_ab As System.Windows.Forms.Button
    Friend WithEvents btn_arr As System.Windows.Forms.Button
    Friend WithEvents btn_izq As System.Windows.Forms.Button
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents pcb_imagen As System.Windows.Forms.PictureBox
End Class
