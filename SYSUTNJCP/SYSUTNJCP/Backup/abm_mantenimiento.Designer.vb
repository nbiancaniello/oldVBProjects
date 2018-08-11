<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_mantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_mantenimiento))
        Me.lsv_items = New System.Windows.Forms.ListView
        Me.col_pk = New System.Windows.Forms.ColumnHeader
        Me.col_descripcion = New System.Windows.Forms.ColumnHeader
        Me.Label16 = New System.Windows.Forms.Label
        Me.btn_volver = New System.Windows.Forms.Button
        Me.grp_ac = New System.Windows.Forms.GroupBox
        Me.lbl_cancelar = New System.Windows.Forms.Label
        Me.lbl_aceptar = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.grp_botones = New System.Windows.Forms.GroupBox
        Me.btn_alta = New System.Windows.Forms.Button
        Me.btn_baja = New System.Windows.Forms.Button
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.lbl_agregar = New System.Windows.Forms.Label
        Me.lbl_eliminar = New System.Windows.Forms.Label
        Me.lbl_modificar = New System.Windows.Forms.Label
        Me.grp_agregar = New System.Windows.Forms.GroupBox
        Me.lbl_et_agregar_desc = New System.Windows.Forms.Label
        Me.lbl_et_agregar_pk = New System.Windows.Forms.Label
        Me.txt_descripcion1 = New System.Windows.Forms.TextBox
        Me.txt_pk = New System.Windows.Forms.TextBox
        Me.grp_ac.SuspendLayout()
        Me.grp_botones.SuspendLayout()
        Me.grp_agregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsv_items
        '
        Me.lsv_items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsv_items.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_pk, Me.col_descripcion})
        Me.lsv_items.FullRowSelect = True
        Me.lsv_items.GridLines = True
        Me.lsv_items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_items.HideSelection = False
        Me.lsv_items.Location = New System.Drawing.Point(12, 12)
        Me.lsv_items.MultiSelect = False
        Me.lsv_items.Name = "lsv_items"
        Me.lsv_items.Size = New System.Drawing.Size(358, 151)
        Me.lsv_items.TabIndex = 85
        Me.lsv_items.UseCompatibleStateImageBehavior = False
        Me.lsv_items.View = System.Windows.Forms.View.Details
        '
        'col_pk
        '
        Me.col_pk.Text = ""
        '
        'col_descripcion
        '
        Me.col_descripcion.Text = ""
        Me.col_descripcion.Width = 294
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(377, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "Regresar"
        '
        'btn_volver
        '
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_volver.Image = CType(resources.GetObject("btn_volver.Image"), System.Drawing.Image)
        Me.btn_volver.Location = New System.Drawing.Point(376, 12)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(51, 51)
        Me.btn_volver.TabIndex = 83
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'grp_ac
        '
        Me.grp_ac.Controls.Add(Me.lbl_cancelar)
        Me.grp_ac.Controls.Add(Me.lbl_aceptar)
        Me.grp_ac.Controls.Add(Me.btn_cancelar)
        Me.grp_ac.Controls.Add(Me.btn_aceptar)
        Me.grp_ac.Enabled = False
        Me.grp_ac.Location = New System.Drawing.Point(226, 238)
        Me.grp_ac.Name = "grp_ac"
        Me.grp_ac.Size = New System.Drawing.Size(130, 96)
        Me.grp_ac.TabIndex = 82
        Me.grp_ac.TabStop = False
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cancelar.Location = New System.Drawing.Point(69, 73)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(57, 13)
        Me.lbl_cancelar.TabIndex = 58
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_aceptar
        '
        Me.lbl_aceptar.AutoSize = True
        Me.lbl_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aceptar.Location = New System.Drawing.Point(6, 73)
        Me.lbl_aceptar.Name = "lbl_aceptar"
        Me.lbl_aceptar.Size = New System.Drawing.Size(51, 13)
        Me.lbl_aceptar.TabIndex = 57
        Me.lbl_aceptar.Text = "Aceptar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(72, 19)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 56
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(6, 19)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(51, 51)
        Me.btn_aceptar.TabIndex = 55
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'grp_botones
        '
        Me.grp_botones.Controls.Add(Me.btn_alta)
        Me.grp_botones.Controls.Add(Me.btn_baja)
        Me.grp_botones.Controls.Add(Me.btn_modificar)
        Me.grp_botones.Controls.Add(Me.lbl_agregar)
        Me.grp_botones.Controls.Add(Me.lbl_eliminar)
        Me.grp_botones.Controls.Add(Me.lbl_modificar)
        Me.grp_botones.Location = New System.Drawing.Point(40, 238)
        Me.grp_botones.Name = "grp_botones"
        Me.grp_botones.Size = New System.Drawing.Size(180, 96)
        Me.grp_botones.TabIndex = 81
        Me.grp_botones.TabStop = False
        '
        'btn_alta
        '
        Me.btn_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_alta.Image = CType(resources.GetObject("btn_alta.Image"), System.Drawing.Image)
        Me.btn_alta.Location = New System.Drawing.Point(6, 19)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(51, 51)
        Me.btn_alta.TabIndex = 66
        Me.btn_alta.Text = "  "
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'btn_baja
        '
        Me.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_baja.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_baja.Image = CType(resources.GetObject("btn_baja.Image"), System.Drawing.Image)
        Me.btn_baja.Location = New System.Drawing.Point(120, 19)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(51, 51)
        Me.btn_baja.TabIndex = 67
        Me.btn_baja.Text = "  "
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(63, 19)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(51, 51)
        Me.btn_modificar.TabIndex = 68
        Me.btn_modificar.Text = "  "
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'lbl_agregar
        '
        Me.lbl_agregar.AutoSize = True
        Me.lbl_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agregar.Location = New System.Drawing.Point(6, 73)
        Me.lbl_agregar.Name = "lbl_agregar"
        Me.lbl_agregar.Size = New System.Drawing.Size(51, 13)
        Me.lbl_agregar.TabIndex = 69
        Me.lbl_agregar.Text = "Agregar"
        '
        'lbl_eliminar
        '
        Me.lbl_eliminar.AutoSize = True
        Me.lbl_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_eliminar.Location = New System.Drawing.Point(120, 73)
        Me.lbl_eliminar.Name = "lbl_eliminar"
        Me.lbl_eliminar.Size = New System.Drawing.Size(51, 13)
        Me.lbl_eliminar.TabIndex = 71
        Me.lbl_eliminar.Text = "Eliminar"
        '
        'lbl_modificar
        '
        Me.lbl_modificar.AutoSize = True
        Me.lbl_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modificar.Location = New System.Drawing.Point(60, 73)
        Me.lbl_modificar.Name = "lbl_modificar"
        Me.lbl_modificar.Size = New System.Drawing.Size(59, 13)
        Me.lbl_modificar.TabIndex = 70
        Me.lbl_modificar.Text = "Modificar"
        '
        'grp_agregar
        '
        Me.grp_agregar.Controls.Add(Me.lbl_et_agregar_desc)
        Me.grp_agregar.Controls.Add(Me.lbl_et_agregar_pk)
        Me.grp_agregar.Controls.Add(Me.txt_descripcion1)
        Me.grp_agregar.Controls.Add(Me.txt_pk)
        Me.grp_agregar.Enabled = False
        Me.grp_agregar.Location = New System.Drawing.Point(12, 169)
        Me.grp_agregar.Name = "grp_agregar"
        Me.grp_agregar.Size = New System.Drawing.Size(358, 63)
        Me.grp_agregar.TabIndex = 80
        Me.grp_agregar.TabStop = False
        '
        'lbl_et_agregar_desc
        '
        Me.lbl_et_agregar_desc.AutoSize = True
        Me.lbl_et_agregar_desc.Location = New System.Drawing.Point(102, 16)
        Me.lbl_et_agregar_desc.Name = "lbl_et_agregar_desc"
        Me.lbl_et_agregar_desc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_et_agregar_desc.TabIndex = 3
        Me.lbl_et_agregar_desc.Text = "Descripcion"
        '
        'lbl_et_agregar_pk
        '
        Me.lbl_et_agregar_pk.AutoSize = True
        Me.lbl_et_agregar_pk.Location = New System.Drawing.Point(6, 16)
        Me.lbl_et_agregar_pk.Name = "lbl_et_agregar_pk"
        Me.lbl_et_agregar_pk.Size = New System.Drawing.Size(21, 13)
        Me.lbl_et_agregar_pk.TabIndex = 2
        Me.lbl_et_agregar_pk.Text = "PK"
        '
        'txt_descripcion1
        '
        Me.txt_descripcion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion1.Location = New System.Drawing.Point(105, 32)
        Me.txt_descripcion1.Name = "txt_descripcion1"
        Me.txt_descripcion1.Size = New System.Drawing.Size(241, 20)
        Me.txt_descripcion1.TabIndex = 1
        '
        'txt_pk
        '
        Me.txt_pk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pk.Location = New System.Drawing.Point(9, 32)
        Me.txt_pk.Name = "txt_pk"
        Me.txt_pk.Size = New System.Drawing.Size(79, 20)
        Me.txt_pk.TabIndex = 0
        '
        'abm_mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 346)
        Me.Controls.Add(Me.lsv_items)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.grp_ac)
        Me.Controls.Add(Me.grp_botones)
        Me.Controls.Add(Me.grp_agregar)
        Me.Name = "abm_mantenimiento"
        Me.Text = "abm_mantenimiento"
        Me.grp_ac.ResumeLayout(False)
        Me.grp_ac.PerformLayout()
        Me.grp_botones.ResumeLayout(False)
        Me.grp_botones.PerformLayout()
        Me.grp_agregar.ResumeLayout(False)
        Me.grp_agregar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_items As System.Windows.Forms.ListView
    Friend WithEvents col_pk As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_descripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents grp_ac As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cancelar As System.Windows.Forms.Label
    Friend WithEvents lbl_aceptar As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents btn_baja As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_agregar As System.Windows.Forms.Label
    Friend WithEvents lbl_eliminar As System.Windows.Forms.Label
    Friend WithEvents lbl_modificar As System.Windows.Forms.Label
    Friend WithEvents grp_agregar As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_et_agregar_desc As System.Windows.Forms.Label
    Friend WithEvents lbl_et_agregar_pk As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pk As System.Windows.Forms.TextBox
End Class
