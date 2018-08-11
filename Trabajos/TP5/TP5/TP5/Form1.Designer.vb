<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbo_campos = New System.Windows.Forms.ComboBox
        Me.cbo_requisitos = New System.Windows.Forms.ComboBox
        Me.txt_dato = New System.Windows.Forms.TextBox
        Me.lv_datos = New System.Windows.Forms.ListView
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.nombre = New System.Windows.Forms.ColumnHeader
        Me.fecha_nac = New System.Windows.Forms.ColumnHeader
        Me.estado = New System.Windows.Forms.ColumnHeader
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_agregar = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.stp_estado = New System.Windows.Forms.StatusStrip
        Me.SuspendLayout()
        '
        'cbo_campos
        '
        Me.cbo_campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_campos.FormattingEnabled = True
        Me.cbo_campos.Items.AddRange(New Object() {"Codigo", "Nombre", "Fecha de nacimiento", "Estado"})
        Me.cbo_campos.Location = New System.Drawing.Point(13, 26)
        Me.cbo_campos.Name = "cbo_campos"
        Me.cbo_campos.Size = New System.Drawing.Size(112, 21)
        Me.cbo_campos.TabIndex = 0
        '
        'cbo_requisitos
        '
        Me.cbo_requisitos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_requisitos.FormattingEnabled = True
        Me.cbo_requisitos.Location = New System.Drawing.Point(155, 27)
        Me.cbo_requisitos.Name = "cbo_requisitos"
        Me.cbo_requisitos.Size = New System.Drawing.Size(109, 21)
        Me.cbo_requisitos.TabIndex = 1
        '
        'txt_dato
        '
        Me.txt_dato.Location = New System.Drawing.Point(295, 27)
        Me.txt_dato.Name = "txt_dato"
        Me.txt_dato.Size = New System.Drawing.Size(92, 20)
        Me.txt_dato.TabIndex = 2
        '
        'lv_datos
        '
        Me.lv_datos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nombre, Me.fecha_nac, Me.estado})
        Me.lv_datos.FullRowSelect = True
        Me.lv_datos.GridLines = True
        Me.lv_datos.HideSelection = False
        Me.lv_datos.Location = New System.Drawing.Point(15, 81)
        Me.lv_datos.MultiSelect = False
        Me.lv_datos.Name = "lv_datos"
        Me.lv_datos.Size = New System.Drawing.Size(412, 160)
        Me.lv_datos.TabIndex = 3
        Me.lv_datos.UseCompatibleStateImageBehavior = False
        Me.lv_datos.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "codigo"
        Me.codigo.Width = 50
        '
        'nombre
        '
        Me.nombre.Text = "nombre"
        Me.nombre.Width = 150
        '
        'fecha_nac
        '
        Me.fecha_nac.Text = "fecha_nac"
        Me.fecha_nac.Width = 100
        '
        'estado
        '
        Me.estado.Text = "estado"
        Me.estado.Width = 100
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(418, 28)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(70, 29)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(433, 81)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(70, 29)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "&Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(433, 126)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(70, 29)
        Me.btn_modificar.TabIndex = 6
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(433, 172)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(70, 29)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(211, 28)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(106, 20)
        Me.dtp_fecha.TabIndex = 8
        Me.dtp_fecha.Visible = False
        '
        'stp_estado
        '
        Me.stp_estado.Location = New System.Drawing.Point(0, 251)
        Me.stp_estado.Name = "stp_estado"
        Me.stp_estado.Size = New System.Drawing.Size(527, 22)
        Me.stp_estado.TabIndex = 9
        Me.stp_estado.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 273)
        Me.Controls.Add(Me.stp_estado)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lv_datos)
        Me.Controls.Add(Me.txt_dato)
        Me.Controls.Add(Me.cbo_requisitos)
        Me.Controls.Add(Me.cbo_campos)
        Me.Name = "Form1"
        Me.Text = "Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_campos As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_requisitos As System.Windows.Forms.ComboBox
    Friend WithEvents txt_dato As System.Windows.Forms.TextBox
    Friend WithEvents lv_datos As System.Windows.Forms.ListView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecha_nac As System.Windows.Forms.ColumnHeader
    Friend WithEvents estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents stp_estado As System.Windows.Forms.StatusStrip

End Class
