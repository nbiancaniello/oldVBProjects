Public Class Motor
    Private mnumero As Int32
    Private mmarca As String
    Private mmodelo As String
    Private mcilindros As Byte
    Private mtipo As Char

    Public Property numero() As Int32
        Get
            Return mnumero
        End Get
        Set(ByVal value As Int32)
            mnumero = value
        End Set
    End Property

    Public Property marca() As String
        Get
            Return mmarca
        End Get
        Set(ByVal value As String)
            mmarca = value
        End Set
    End Property

    Public Property modelo() As String
        Get
            Return mmodelo
        End Get
        Set(ByVal value As String)
            mmodelo = value
        End Set
    End Property

    Public Property cilindros() As Byte
        Get
            Return cilindros
        End Get
        Set(ByVal value As Byte)
            If value = 1 Or value = 2 Or value = 3 Or value = 4 Or value = 5 Or value = 6 Or value = 8 Or value = 12 Then
                mcilindros = value
            Else
                Throw New Exception("VAlor incorrecto de cilindros!!")
            End If
        End Set
    End Property
    Public Property tipo() As Char
        Get
            Return mtipo
        End Get
        Set(ByVal value As Char)
            If value = "V" Or value = "L" Then
                mtipo = value
            Else
                Throw New Exception("Tipo de motor incorrecto!!")
            End If

        End Set
    End Property

    Public Sub asignar_datos(ByVal xnumero As Int32, ByVal xmarca As String, ByVal xmodelo As String, ByVal xcilindros As Byte, ByVal xtipo As Char)
        numero = xnumero
        marca = xmarca
        modelo = xmodelo
        cilindros = xcilindros
        tipo = xtipo
    End Sub

    Public Sub mostrar_datos()
        MessageBox.Show(numero.ToString & " " & " " & marca & " " & modelo & " " & cilindros.ToString & " " & tipo)
    End Sub

    Public Sub dispose()
        MyBase.Finalize()
    End Sub
End Class
