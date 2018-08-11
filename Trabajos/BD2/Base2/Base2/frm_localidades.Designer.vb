<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_localidades
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
        Me.lv_localidades = New System.Windows.Forms.ListView
        Me.col_cod_postal = New System.Windows.Forms.ColumnHeader
        Me.col_localidad = New System.Windows.Forms.ColumnHeader
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.PDocumento = New System.Drawing.Printing.PrintDocument
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lv_localidades
        '
        Me.lv_localidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_cod_postal, Me.col_localidad})
        Me.lv_localidades.FullRowSelect = True
        Me.lv_localidades.GridLines = True
        Me.lv_localidades.Location = New System.Drawing.Point(12, 12)
        Me.lv_localidades.MultiSelect = False
        Me.lv_localidades.Name = "lv_localidades"
        Me.lv_localidades.Size = New System.Drawing.Size(295, 140)
        Me.lv_localidades.TabIndex = 3
        Me.lv_localidades.UseCompatibleStateImageBehavior = False
        Me.lv_localidades.View = System.Windows.Forms.View.Details
        '
        'col_cod_postal
        '
        Me.col_cod_postal.Text = "cod_postal"
        Me.col_cod_postal.Width = 80
        '
        'col_localidad
        '
        Me.col_localidad.Text = "Localidad"
        Me.col_localidad.Width = 200
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(313, 98)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 26)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(313, 66)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(99, 26)
        Me.btn_modificar.TabIndex = 5
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(313, 34)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(99, 26)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "&Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(317, 130)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(94, 21)
        Me.btn_imprimir.TabIndex = 7
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'frm_localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 164)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.lv_localidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_localidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localidades"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_localidades As System.Windows.Forms.ListView
    Friend WithEvents col_cod_postal As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_localidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents PDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button

End Class
