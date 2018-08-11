Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'Para el formulario de inicio, la primera instancia creada es la instancia predeterminada.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
	End Sub
	'Form reemplaza a Dispose para limpiar la lista de componentes.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents MSComm1 As AxMSCommLib.AxMSComm
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonConectar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MSComm1 = New AxMSCommLib.AxMSComm
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ButtonConectar = New System.Windows.Forms.Button
        CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSComm1
        '
        Me.MSComm1.Enabled = True
        Me.MSComm1.Location = New System.Drawing.Point(16, 16)
        Me.MSComm1.Name = "MSComm1"
        Me.MSComm1.OcxState = CType(resources.GetObject("MSComm1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSComm1.Size = New System.Drawing.Size(38, 38)
        Me.MSComm1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Location = New System.Drawing.Point(80, 248)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(104, 32)
        Me.ButtonConectar.TabIndex = 2
        Me.ButtonConectar.Text = "Conectar"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 315)
        Me.Controls.Add(Me.ButtonConectar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MSComm1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Soporte para la actualización "
	Private Shared m_vb6FormDefInstance As Form1
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form1
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form1()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 

    Private Sub MSComm1_OnComm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSComm1.OnComm
        Dim leido As String
        If MSComm1.InputLen Then
            leido = MSComm1.Input
            TextBox1.Text = leido
        End If
    End Sub

    Private Sub ButtonConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConectar.Click
        If MSComm1.PortOpen Then
            MsgBox("El puerto ya estaba abierto")
        Else
            MSComm1.PortOpen = True
        End If
    End Sub
End Class