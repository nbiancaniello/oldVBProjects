Public Class Empleado
    Private mlegajo As Int16
    Private mnombre As String
    Private mfechanac As Date
    Private msueldo As Double
    Private mcomision As Int16

    Public Property legajo() As Int16
        Get
            Return mlegajo
        End Get
        Set(ByVal value As Int16)
            If value <= 10000 Then
                mlegajo = value
            Else
                Throw New Exception("El legajo ingresado excede el valor máximo permitido")
            End If
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return mnombre
        End Get
        Set(ByVal value As String)
            If value.Length <= 40 Then
                mnombre = value
            Else
                Throw New Exception("El nombre excede la longitud máxima permitida")
            End If
        End Set
    End Property

    Public Property fechanac() As Date
        Get
            Return mfechanac
        End Get
        Set(ByVal value As Date)
            If DateDiff(DateInterval.Year, value, Now.Date) >= 18 Then
                mfechanac = value
            Else
                Throw New Exception("La edad del empleado es menor de 18")
            End If
        End Set
    End Property

    Public Property sueldo() As Double
        Get
            Return msueldo
        End Get
        Set(ByVal value As Double)
            If value >= 500 And value <= 20000 Then
                msueldo = value
            Else
                Throw New Exception("El sueldo excede el máximo establecido")
            End If
        End Set
    End Property

    Public Property comision() As Int16
        Get
            Return mcomision
        End Get
        Set(ByVal value As Int16)
            If value >= 1 And value <= 20 Then
                mcomision = value
            Else
                Throw New Exception("La comisión excede el máximo establecido")
            End If
        End Set
    End Property

    Public Sub Dispose()
        MyBase.Finalize()
    End Sub

    Public Function calcularsueldo() As Double
        Return (sueldo + ((comision * sueldo) / 100))
    End Function

    Public Sub asignardatos(ByVal xlegajo As Int16)
        legajo = xlegajo
    End Sub

    Public Sub asignardatos(ByVal xlegajo As Int16, ByVal xnombre As String)
        legajo = xlegajo
        nombre = xnombre
    End Sub

    Public Sub asignardatos(ByVal xlegajo As Int16, ByVal xnombre As String, ByVal xfecha As Date)
        legajo = xlegajo
        nombre = xnombre
        fechanac = xfecha
    End Sub

    Public Sub asignardatos(ByVal xlegajo As Int16, ByVal xnombre As String, ByVal xfecha As Date, ByVal xsueldo As Double)
        legajo = xlegajo
        nombre = xnombre
        fechanac = xfecha
        sueldo = xsueldo
    End Sub

    Public Sub asignardatos(ByVal xlegajo As Int16, ByVal xnombre As String, ByVal xfecha As Date, ByVal xsueldo As Double, ByVal xcomision As Int16)
        legajo = xlegajo
        nombre = xnombre
        fechanac = xfecha
        sueldo = xsueldo
        comision = xcomision
    End Sub
    Public Function edad() As Int16
        Return CShort(DateDiff(DateInterval.Year, Form1.dtp_fecha_nac.Value, Now.Date))
    End Function
End Class
