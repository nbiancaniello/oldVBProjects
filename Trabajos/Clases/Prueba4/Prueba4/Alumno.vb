Public Class Alumno
    Private mlegajo As Int16
    Private mnombre As String
    Private mapellido As String
    Private mdni As Int32
    Private mfecha_nac As Date
    Private mtelefono As String
    Private memail As String

    Public Property legajo() As Int16
        Get
            Return mlegajo
        End Get
        Set(ByVal value As Int16)
            mlegajo = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return mnombre
        End Get
        Set(ByVal value As String)
            mnombre = value
        End Set
    End Property

    Public Property apellido() As String
        Get
            Return mapellido
        End Get
        Set(ByVal value As String)
            mapellido = value
        End Set
    End Property

    Public Property dni() As Int32
        Get
            Return mdni
        End Get
        Set(ByVal value As Int32)
            mlegajo = value
        End Set
    End Property

    Public Property fecha_nac() As Date
        Get
            Return mfecha_nac
        End Get
        Set(ByVal value As Date)
            mfecha_nac = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return mtelefono
        End Get
        Set(ByVal value As String)
            mtelefono = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return memail
        End Get
        Set(ByVal value As String)
            memail = value
        End Set
    End Property

    Public Function agregar() As Boolean

    End Function

    Public Function modificar() As Boolean

    End Function

    Public Function eliminar() As Boolean

    End Function

    Public Function mostrar() As Boolean

    End Function
End Class
