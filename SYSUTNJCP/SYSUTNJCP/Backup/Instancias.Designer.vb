<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instancias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instancias))
        Me.lsv_instancias = New System.Windows.Forms.ListView
        Me.col_anio = New System.Windows.Forms.ColumnHeader
        Me.col_numero = New System.Windows.Forms.ColumnHeader
        Me.co_nmes = New System.Windows.Forms.ColumnHeader
        Me.col_mes = New System.Windows.Forms.ColumnHeader
        Me.lbl_instancias = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_baja = New System.Windows.Forms.Button
        Me.btn_alta = New System.Windows.Forms.Button
        Me.grp_instancias = New System.Windows.Forms.GroupBox
        Me.lbl_mes = New System.Windows.Forms.Label
        Me.lbl_num = New System.Windows.Forms.Label
        Me.txt_num = New System.Windows.Forms.TextBox
        Me.cmb_mes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btn_aceptar_alta = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.grp_instancias.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsv_instancias
        '
        Me.lsv_instancias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_instancias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_anio, Me.col_numero, Me.co_nmes, Me.col_mes})
        Me.lsv_instancias.FullRowSelect = True
        Me.lsv_instancias.GridLines = True
        Me.lsv_instancias.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_instancias.HideSelection = False
        Me.lsv_instancias.Location = New System.Drawing.Point(15, 35)
        Me.lsv_instancias.Name = "lsv_instancias"
        Me.lsv_instancias.Size = New System.Drawing.Size(157, 89)
        Me.lsv_instancias.TabIndex = 0
        Me.lsv_instancias.UseCompatibleStateImageBehavior = False
        Me.lsv_instancias.View = System.Windows.Forms.View.Details
        '
        'col_anio
        '
        Me.col_anio.Text = ""
        Me.col_anio.Width = 0
        '
        'col_numero
        '
        Me.col_numero.Text = "Nº"
        Me.col_numero.Width = 30
        '
        'co_nmes
        '
        Me.co_nmes.DisplayIndex = 3
        Me.co_nmes.Text = ""
        Me.co_nmes.Width = 0
        '
        'col_mes
        '
        Me.col_mes.DisplayIndex = 2
        Me.col_mes.Text = "Mes"
        Me.col_mes.Width = 123
        '
        'lbl_instancias
        '
        Me.lbl_instancias.AutoSize = True
        Me.lbl_instancias.Location = New System.Drawing.Point(12, 9)
        Me.lbl_instancias.Name = "lbl_instancias"
        Me.lbl_instancias.Size = New System.Drawing.Size(174, 13)
        Me.lbl_instancias.TabIndex = 1
        Me.lbl_instancias.Text = "Instancias correspondientes al año "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Modificar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Agregar"
        '
        'btn_modificar
        '
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(69, 130)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(51, 51)
        Me.btn_modificar.TabIndex = 85
        Me.btn_modificar.Text = "  "
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_baja
        '
        Me.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baja.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_baja.Image = CType(resources.GetObject("btn_baja.Image"), System.Drawing.Image)
        Me.btn_baja.Location = New System.Drawing.Point(126, 130)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(51, 51)
        Me.btn_baja.TabIndex = 84
        Me.btn_baja.Text = "  "
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'btn_alta
        '
        Me.btn_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_alta.Image = CType(resources.GetObject("btn_alta.Image"), System.Drawing.Image)
        Me.btn_alta.Location = New System.Drawing.Point(12, 130)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(51, 51)
        Me.btn_alta.TabIndex = 83
        Me.btn_alta.Text = "  "
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'grp_instancias
        '
        Me.grp_instancias.Controls.Add(Me.Label1)
        Me.grp_instancias.Controls.Add(Me.lbl_mes)
        Me.grp_instancias.Controls.Add(Me.Label17)
        Me.grp_instancias.Controls.Add(Me.lbl_num)
        Me.grp_instancias.Controls.Add(Me.btn_aceptar_alta)
        Me.grp_instancias.Controls.Add(Me.btn_cancelar)
        Me.grp_instancias.Controls.Add(Me.txt_num)
        Me.grp_instancias.Controls.Add(Me.cmb_mes)
        Me.grp_instancias.Enabled = False
        Me.grp_instancias.Location = New System.Drawing.Point(183, 25)
        Me.grp_instancias.Name = "grp_instancias"
        Me.grp_instancias.Size = New System.Drawing.Size(184, 164)
        Me.grp_instancias.TabIndex = 89
        Me.grp_instancias.TabStop = False
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Location = New System.Drawing.Point(7, 58)
        Me.lbl_mes.Name = "lbl_mes"
        Me.lbl_mes.Size = New System.Drawing.Size(27, 13)
        Me.lbl_mes.TabIndex = 90
        Me.lbl_mes.Text = "Mes"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(15, 22)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(19, 13)
        Me.lbl_num.TabIndex = 90
        Me.lbl_num.Text = "Nº"
        '
        'txt_num
        '
        Me.txt_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num.Enabled = False
        Me.txt_num.Location = New System.Drawing.Point(40, 19)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(43, 20)
        Me.txt_num.TabIndex = 1
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(40, 55)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(138, 21)
        Me.cmb_mes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Cancelar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(53, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Aceptar"
        '
        'btn_aceptar_alta
        '
        Me.btn_aceptar_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar_alta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar_alta.Image = CType(resources.GetObject("btn_aceptar_alta.Image"), System.Drawing.Image)
        Me.btn_aceptar_alta.Location = New System.Drawing.Point(53, 91)
        Me.btn_aceptar_alta.Name = "btn_aceptar_alta"
        Me.btn_aceptar_alta.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar_alta.TabIndex = 90
        Me.btn_aceptar_alta.Text = "  "
        Me.btn_aceptar_alta.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(110, 91)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 91
        Me.btn_cancelar.Text = "  "
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Instancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 205)
        Me.Controls.Add(Me.grp_instancias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.lbl_instancias)
        Me.Controls.Add(Me.lsv_instancias)
        Me.Name = "Instancias"
        Me.Text = "Instancias"
        Me.grp_instancias.ResumeLayout(False)
        Me.grp_instancias.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_instancias As System.Windows.Forms.ListView
    Friend WithEvents lbl_instancias As System.Windows.Forms.Label
    Friend WithEvents col_anio As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_numero As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_mes As System.Windows.Forms.ColumnHeader
    Friend WithEvents co_nmes As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_baja As System.Windows.Forms.Button
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents grp_instancias As System.Windows.Forms.GroupBox
    Friend WithEvents txt_num As System.Windows.Forms.TextBox
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_mes As System.Windows.Forms.Label
    Friend WithEvents lbl_num As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar_alta As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
