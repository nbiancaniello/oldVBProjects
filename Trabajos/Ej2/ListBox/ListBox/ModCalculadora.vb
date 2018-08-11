Module ModCalculadora
    Public Function sumar(ByVal N1 As Double, ByVal N2 As Double) As Double
        Return N1 + N2
    End Function

    Public Function restar(ByVal N1 As Double, ByVal N2 As Double) As Double
        Return N1 - N2
    End Function

    Public Function dividir(ByVal N1 As Double, ByVal N2 As Double) As Double
        Return Convert.ToDouble(N1 / N2)
    End Function

    Public Function multiplicar(ByVal N1 As Double, ByVal N2 As Double) As Double
        Return N1 * N2
    End Function
End Module
