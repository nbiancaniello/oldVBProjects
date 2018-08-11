<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ej1
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
        Me.lst_localidades = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lst_localidades
        '
        Me.lst_localidades.FormattingEnabled = True
        Me.lst_localidades.Location = New System.Drawing.Point(12, 12)
        Me.lst_localidades.Name = "lst_localidades"
        Me.lst_localidades.Size = New System.Drawing.Size(202, 186)
        Me.lst_localidades.TabIndex = 0
        '
        'Ej1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 211)
        Me.Controls.Add(Me.lst_localidades)
        Me.Name = "Ej1"
        Me.Text = "Ej1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_localidades As System.Windows.Forms.ListBox
End Class
