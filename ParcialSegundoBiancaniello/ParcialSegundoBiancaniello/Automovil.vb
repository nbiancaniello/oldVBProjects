Public Class Automovil

    Inherits Motor
    Private mcompania As String
    Private mpatente As String
    Private mcolor As String

    Public Property compania() As String
        Get
            Return mcompania
        End Get
        Set(ByVal value As String)
            mcompania = value
        End Set
    End Property

    Public Property patente() As String
        Get
            Return mpatente
        End Get
        Set(ByVal value As String)
            mpatente = value
        End Set
    End Property

    Public Property color() As String
        Get
            Return mcolor
        End Get
        Set(ByVal value As String)
            mcolor = value
        End Set
    End Property

    Public Overloads Sub asignar_datos(ByVal xnumero As Int32, ByVal xmarca As String, ByVal xmodelo As String, ByVal xcilindros As Byte, ByVal xtipo As Char, ByVal xcompania As String, ByVal xpatente As String, ByVal xcolor As String)
        numero = xnumero
        marca = xmarca
        modelo = xmodelo
        cilindros = xcilindros
        tipo = xtipo
        compania = xcompania
        patente = xpatente
        color = xcolor
    End Sub

    Public Overloads Sub mostrar_datos()
        MessageBox.Show(numero.ToString & " " & " " & marca & " " & modelo & " " & cilindros.ToString & " " & tipo & compania & " " & patente & " " & color)
    End Sub

    Public Sub dispose()
        MyBase.Finalize()
    End Sub
End Class
