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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_der = New System.Windows.Forms.Button
        Me.btn_ab = New System.Windows.Forms.Button
        Me.btn_arr = New System.Windows.Forms.Button
        Me.btn_izq = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_der
        '
        Me.btn_der.Image = Global.Ejerc1.My.Resources.Resources.ARW05RT
        Me.btn_der.Location = New System.Drawing.Point(229, 255)
        Me.btn_der.Name = "btn_der"
        Me.btn_der.Size = New System.Drawing.Size(49, 27)
        Me.btn_der.TabIndex = 4
        Me.btn_der.UseVisualStyleBackColor = True
        '
        'btn_ab
        '
        Me.btn_ab.Image = Global.Ejerc1.My.Resources.Resources.ARW05DN
        Me.btn_ab.Location = New System.Drawing.Point(173, 255)
        Me.btn_ab.Name = "btn_ab"
        Me.btn_ab.Size = New System.Drawing.Size(50, 27)
        Me.btn_ab.TabIndex = 3
        Me.btn_ab.UseVisualStyleBackColor = True
        '
        'btn_arr
        '
        Me.btn_arr.Image = Global.Ejerc1.My.Resources.Resources.ARW05UP
        Me.btn_arr.Location = New System.Drawing.Point(116, 255)
        Me.btn_arr.Name = "btn_arr"
        Me.btn_arr.Size = New System.Drawing.Size(51, 27)
        Me.btn_arr.TabIndex = 2
        Me.btn_arr.UseVisualStyleBackColor = True
        '
        'btn_izq
        '
        Me.btn_izq.Image = Global.Ejerc1.My.Resources.Resources.ARW05LT
        Me.btn_izq.Location = New System.Drawing.Point(59, 255)
        Me.btn_izq.Name = "btn_izq"
        Me.btn_izq.Size = New System.Drawing.Size(51, 27)
        Me.btn_izq.TabIndex = 1
        Me.btn_izq.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 303)
        Me.Controls.Add(Me.btn_der)
        Me.Controls.Add(Me.btn_ab)
        Me.Controls.Add(Me.btn_arr)
        Me.Controls.Add(Me.btn_izq)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_izq As System.Windows.Forms.Button
    Friend WithEvents btn_arr As System.Windows.Forms.Button
    Friend WithEvents btn_ab As System.Windows.Forms.Button
    Friend WithEvents btn_der As System.Windows.Forms.Button

End Class
