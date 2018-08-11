<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Lista_cruce
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
        Me.lst_izquierda = New System.Windows.Forms.ListBox
        Me.lst_derecha = New System.Windows.Forms.ListBox
        Me.btn_agregaruno = New System.Windows.Forms.Button
        Me.btn_agregartodos = New System.Windows.Forms.Button
        Me.btn_sacaruno = New System.Windows.Forms.Button
        Me.btn_sacartodos = New System.Windows.Forms.Button
        Me.lbl_cantidad1 = New System.Windows.Forms.Label
        Me.lbl_cantidad2 = New System.Windows.Forms.Label
        Me.lbl_cantidadderecha = New System.Windows.Forms.Label
        Me.lbl_cantidadizquierda = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lst_izquierda
        '
        Me.lst_izquierda.FormattingEnabled = True
        Me.lst_izquierda.Items.AddRange(New Object() {"Bella Vista", "Don Torcuato", "Escobar", "Hurlingham", "José C. Paz", "Los Polvorines", "San Miguel", "Villa Tesei"})
        Me.lst_izquierda.Location = New System.Drawing.Point(12, 12)
        Me.lst_izquierda.Name = "lst_izquierda"
        Me.lst_izquierda.Size = New System.Drawing.Size(155, 290)
        Me.lst_izquierda.Sorted = True
        Me.lst_izquierda.TabIndex = 0
        '
        'lst_derecha
        '
        Me.lst_derecha.FormattingEnabled = True
        Me.lst_derecha.Location = New System.Drawing.Point(257, 12)
        Me.lst_derecha.Name = "lst_derecha"
        Me.lst_derecha.Size = New System.Drawing.Size(155, 290)
        Me.lst_derecha.Sorted = True
        Me.lst_derecha.TabIndex = 1
        '
        'btn_agregaruno
        '
        Me.btn_agregaruno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregaruno.Location = New System.Drawing.Point(183, 50)
        Me.btn_agregaruno.Name = "btn_agregaruno"
        Me.btn_agregaruno.Size = New System.Drawing.Size(56, 30)
        Me.btn_agregaruno.TabIndex = 2
        Me.btn_agregaruno.Text = ">"
        Me.btn_agregaruno.UseVisualStyleBackColor = True
        '
        'btn_agregartodos
        '
        Me.btn_agregartodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregartodos.Location = New System.Drawing.Point(183, 102)
        Me.btn_agregartodos.Name = "btn_agregartodos"
        Me.btn_agregartodos.Size = New System.Drawing.Size(56, 30)
        Me.btn_agregartodos.TabIndex = 3
        Me.btn_agregartodos.Text = ">>"
        Me.btn_agregartodos.UseVisualStyleBackColor = True
        '
        'btn_sacaruno
        '
        Me.btn_sacaruno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sacaruno.Location = New System.Drawing.Point(183, 153)
        Me.btn_sacaruno.Name = "btn_sacaruno"
        Me.btn_sacaruno.Size = New System.Drawing.Size(56, 30)
        Me.btn_sacaruno.TabIndex = 4
        Me.btn_sacaruno.Text = "<"
        Me.btn_sacaruno.UseVisualStyleBackColor = True
        '
        'btn_sacartodos
        '
        Me.btn_sacartodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sacartodos.Location = New System.Drawing.Point(183, 209)
        Me.btn_sacartodos.Name = "btn_sacartodos"
        Me.btn_sacartodos.Size = New System.Drawing.Size(56, 30)
        Me.btn_sacartodos.TabIndex = 5
        Me.btn_sacartodos.Text = "<<"
        Me.btn_sacartodos.UseVisualStyleBackColor = True
        '
        'lbl_cantidad1
        '
        Me.lbl_cantidad1.AutoSize = True
        Me.lbl_cantidad1.Location = New System.Drawing.Point(15, 311)
        Me.lbl_cantidad1.Name = "lbl_cantidad1"
        Me.lbl_cantidad1.Size = New System.Drawing.Size(55, 13)
        Me.lbl_cantidad1.TabIndex = 6
        Me.lbl_cantidad1.Text = "Cantidad: "
        '
        'lbl_cantidad2
        '
        Me.lbl_cantidad2.AutoSize = True
        Me.lbl_cantidad2.Location = New System.Drawing.Point(254, 311)
        Me.lbl_cantidad2.Name = "lbl_cantidad2"
        Me.lbl_cantidad2.Size = New System.Drawing.Size(55, 13)
        Me.lbl_cantidad2.TabIndex = 7
        Me.lbl_cantidad2.Text = "Cantidad: "
        '
        'lbl_cantidadderecha
        '
        Me.lbl_cantidadderecha.AutoSize = True
        Me.lbl_cantidadderecha.Location = New System.Drawing.Point(306, 311)
        Me.lbl_cantidadderecha.Name = "lbl_cantidadderecha"
        Me.lbl_cantidadderecha.Size = New System.Drawing.Size(13, 13)
        Me.lbl_cantidadderecha.TabIndex = 10
        Me.lbl_cantidadderecha.Text = "0"
        '
        'lbl_cantidadizquierda
        '
        Me.lbl_cantidadizquierda.AutoSize = True
        Me.lbl_cantidadizquierda.Location = New System.Drawing.Point(70, 312)
        Me.lbl_cantidadizquierda.Name = "lbl_cantidadizquierda"
        Me.lbl_cantidadizquierda.Size = New System.Drawing.Size(13, 13)
        Me.lbl_cantidadizquierda.TabIndex = 11
        Me.lbl_cantidadizquierda.Text = "0"
        '
        'frm_Lista_cruce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 339)
        Me.Controls.Add(Me.lbl_cantidadizquierda)
        Me.Controls.Add(Me.lbl_cantidadderecha)
        Me.Controls.Add(Me.lbl_cantidad2)
        Me.Controls.Add(Me.lbl_cantidad1)
        Me.Controls.Add(Me.btn_sacartodos)
        Me.Controls.Add(Me.btn_sacaruno)
        Me.Controls.Add(Me.btn_agregartodos)
        Me.Controls.Add(Me.btn_agregaruno)
        Me.Controls.Add(Me.lst_derecha)
        Me.Controls.Add(Me.lst_izquierda)
        Me.Name = "frm_Lista_cruce"
        Me.Text = "Listas: Cruce de datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_izquierda As System.Windows.Forms.ListBox
    Friend WithEvents lst_derecha As System.Windows.Forms.ListBox
    Friend WithEvents btn_agregaruno As System.Windows.Forms.Button
    Friend WithEvents btn_agregartodos As System.Windows.Forms.Button
    Friend WithEvents btn_sacaruno As System.Windows.Forms.Button
    Friend WithEvents btn_sacartodos As System.Windows.Forms.Button
    Friend WithEvents lbl_cantidad1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidadderecha As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidadizquierda As System.Windows.Forms.Label
End Class
