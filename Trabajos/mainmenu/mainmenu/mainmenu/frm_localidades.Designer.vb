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
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.lv_localidades = New System.Windows.Forms.ListView
        Me.col_cod_postal = New System.Windows.Forms.ColumnHeader
        Me.col_localidad = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(364, 32)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(76, 25)
        Me.btn_cargar.TabIndex = 0
        Me.btn_cargar.Text = "&Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
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
        Me.lv_localidades.TabIndex = 1
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
        'frm_localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 160)
        Me.Controls.Add(Me.lv_localidades)
        Me.Controls.Add(Me.btn_cargar)
        Me.Name = "frm_localidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Localidades"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents lv_localidades As System.Windows.Forms.ListView
    Friend WithEvents col_localidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_cod_postal As System.Windows.Forms.ColumnHeader
End Class
