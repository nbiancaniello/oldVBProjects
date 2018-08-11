<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Me.lv_clientes = New System.Windows.Forms.ListView
        Me.col_cod_cliente = New System.Windows.Forms.ColumnHeader
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.col_nombre = New System.Windows.Forms.ColumnHeader
        Me.col_direccion = New System.Windows.Forms.ColumnHeader
        Me.col_telefono = New System.Windows.Forms.ColumnHeader
        Me.col_cod_postal = New System.Windows.Forms.ColumnHeader
        Me.col_celular = New System.Windows.Forms.ColumnHeader
        Me.col_email = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lv_clientes
        '
        Me.lv_clientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_cod_cliente, Me.col_nombre, Me.col_direccion, Me.col_cod_postal, Me.col_telefono, Me.col_celular, Me.col_email})
        Me.lv_clientes.FullRowSelect = True
        Me.lv_clientes.GridLines = True
        Me.lv_clientes.Location = New System.Drawing.Point(12, 12)
        Me.lv_clientes.MultiSelect = False
        Me.lv_clientes.Name = "lv_clientes"
        Me.lv_clientes.Size = New System.Drawing.Size(912, 140)
        Me.lv_clientes.TabIndex = 3
        Me.lv_clientes.UseCompatibleStateImageBehavior = False
        Me.lv_clientes.View = System.Windows.Forms.View.Details
        '
        'col_cod_cliente
        '
        Me.col_cod_cliente.Text = "cod_cliente"
        Me.col_cod_cliente.Width = 80
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(12, 162)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(76, 25)
        Me.btn_cargar.TabIndex = 2
        Me.btn_cargar.Text = "&Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'col_nombre
        '
        Me.col_nombre.Text = "nombre"
        Me.col_nombre.Width = 150
        '
        'col_direccion
        '
        Me.col_direccion.Text = "direccion"
        Me.col_direccion.Width = 150
        '
        'col_telefono
        '
        Me.col_telefono.DisplayIndex = 3
        Me.col_telefono.Text = "telefono"
        Me.col_telefono.Width = 120
        '
        'col_cod_postal
        '
        Me.col_cod_postal.DisplayIndex = 4
        Me.col_cod_postal.Text = "cod_postal"
        Me.col_cod_postal.Width = 80
        '
        'col_celular
        '
        Me.col_celular.Text = "celular"
        Me.col_celular.Width = 120
        '
        'col_email
        '
        Me.col_email.Text = "email"
        Me.col_email.Width = 200
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 199)
        Me.Controls.Add(Me.lv_clientes)
        Me.Controls.Add(Me.btn_cargar)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_clientes As System.Windows.Forms.ListView
    Friend WithEvents col_cod_cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents col_nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_direccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_telefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_cod_postal As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_celular As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_email As System.Windows.Forms.ColumnHeader
End Class
