<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListBox
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
        Me.lst_provincias = New System.Windows.Forms.ListBox
        Me.btn_add = New System.Windows.Forms.Button
        Me.btn_bsel = New System.Windows.Forms.Button
        Me.btn_cant = New System.Windows.Forms.Button
        Me.btn_vaciar = New System.Windows.Forms.Button
        Me.txt_provincia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lst_provincias
        '
        Me.lst_provincias.FormattingEnabled = True
        Me.lst_provincias.Location = New System.Drawing.Point(12, 61)
        Me.lst_provincias.Name = "lst_provincias"
        Me.lst_provincias.Size = New System.Drawing.Size(120, 121)
        Me.lst_provincias.Sorted = True
        Me.lst_provincias.TabIndex = 2
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(193, 10)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(33, 23)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = ">>"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_bsel
        '
        Me.btn_bsel.Location = New System.Drawing.Point(138, 61)
        Me.btn_bsel.Name = "btn_bsel"
        Me.btn_bsel.Size = New System.Drawing.Size(86, 43)
        Me.btn_bsel.TabIndex = 3
        Me.btn_bsel.Text = "Borrar Selección"
        Me.btn_bsel.UseVisualStyleBackColor = True
        '
        'btn_cant
        '
        Me.btn_cant.Location = New System.Drawing.Point(138, 136)
        Me.btn_cant.Name = "btn_cant"
        Me.btn_cant.Size = New System.Drawing.Size(88, 46)
        Me.btn_cant.TabIndex = 5
        Me.btn_cant.Text = "Contar Cantidad"
        Me.btn_cant.UseVisualStyleBackColor = True
        '
        'btn_vaciar
        '
        Me.btn_vaciar.Location = New System.Drawing.Point(138, 110)
        Me.btn_vaciar.Name = "btn_vaciar"
        Me.btn_vaciar.Size = New System.Drawing.Size(88, 20)
        Me.btn_vaciar.TabIndex = 4
        Me.btn_vaciar.Text = "Limpiar Lista"
        Me.btn_vaciar.UseVisualStyleBackColor = True
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(67, 12)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(120, 20)
        Me.txt_provincia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Provincia"
        '
        'frm_ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 200)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_provincia)
        Me.Controls.Add(Me.btn_vaciar)
        Me.Controls.Add(Me.btn_cant)
        Me.Controls.Add(Me.btn_bsel)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lst_provincias)
        Me.Name = "frm_ListBox"
        Me.Text = "ListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_provincias As System.Windows.Forms.ListBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_bsel As System.Windows.Forms.Button
    Friend WithEvents btn_cant As System.Windows.Forms.Button
    Friend WithEvents btn_vaciar As System.Windows.Forms.Button
    Friend WithEvents txt_provincia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
