<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Me.mnu_principal = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_archivo_ = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_abrir_localidades = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_abrir_clientes = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnu_archivo_salir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_principal
        '
        Me.mnu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.mnu_principal.Location = New System.Drawing.Point(0, 0)
        Me.mnu_principal.Name = "mnu_principal"
        Me.mnu_principal.Size = New System.Drawing.Size(817, 24)
        Me.mnu_principal.TabIndex = 0
        Me.mnu_principal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_archivo_, Me.ToolStripMenuItem1, Me.mnu_archivo_salir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'mnu_archivo_
        '
        Me.mnu_archivo_.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_abrir_localidades, Me.mnu_abrir_clientes})
        Me.mnu_archivo_.Name = "mnu_archivo_"
        Me.mnu_archivo_.Size = New System.Drawing.Size(152, 22)
        Me.mnu_archivo_.Text = "A&brir"
        '
        'mnu_abrir_localidades
        '
        Me.mnu_abrir_localidades.Name = "mnu_abrir_localidades"
        Me.mnu_abrir_localidades.Size = New System.Drawing.Size(152, 22)
        Me.mnu_abrir_localidades.Text = "Localidades"
        '
        'mnu_abrir_clientes
        '
        Me.mnu_abrir_clientes.Name = "mnu_abrir_clientes"
        Me.mnu_abrir_clientes.Size = New System.Drawing.Size(152, 22)
        Me.mnu_abrir_clientes.Text = "Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnu_archivo_salir
        '
        Me.mnu_archivo_salir.Name = "mnu_archivo_salir"
        Me.mnu_archivo_salir.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnu_archivo_salir.Size = New System.Drawing.Size(152, 22)
        Me.mnu_archivo_salir.Text = "&Salir"
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 323)
        Me.Controls.Add(Me.mnu_principal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnu_principal
        Me.Name = "mainmenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnu_principal.ResumeLayout(False)
        Me.mnu_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_archivo_ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_abrir_localidades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_abrir_clientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_archivo_salir As System.Windows.Forms.ToolStripMenuItem

End Class
