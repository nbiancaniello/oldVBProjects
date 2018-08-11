Imports System.Math
Module Rutinas

    Public Function retorna_tipo(ByVal L1 As Int32, ByVal L2 As Int32, ByVal L3 As Int32) As Int16
        If L1 = L2 And L2 = L3 Then
            Return 1
        End If

        If (L1 = L2 And L3 <> L1) Or (L2 = L3 And L3 <> L1) Or (L1 = L3 And L3 <> L2) Then
            Return 2
        End If
        If L1 <> L2 And L2 <> L3 And L1 <> L3 Then
            Return 3
        End If
    End Function

    Public Function perimetro_rec(ByVal L1 As Int16, ByVal L2 As Int16) As Int16
        Return CShort(L1 * 2 + L2 * 2)
    End Function

    Public Function area_triang(ByVal L1 As Int32, ByVal L2 As Int32, ByVal L3 As Int32, ByVal tipo As Int16) As Double
        Dim area As Double
        If tipo = 1 Then
            area = (L1 * (Sqrt(L2 ^ 2 + (L1 / 2) ^ 2))) / 2
        End If
        If tipo = 2 Then
            If (L1 = L2 And L3 <> L1) Then
                area = (L1 * (Sqrt(L2 ^ 2 + (L1 / 2) ^ 2))) / 2
            End If
            If (L2 = L3 And L3 <> L1) Then
                area = (L3 * (Sqrt(L2 ^ 2 + (L3 / 2) ^ 2))) / 2
            End If
            If (L1 = L3 And L3 <> L2) Then
                area = (L1 * (Sqrt(L3 ^ 2 + (L1 / 2) ^ 2))) / 2
            End If
        End If
        If tipo = 3 Then
            area = (L1 * (Sqrt(L2 ^ 2 + (L1 / 2) ^ 2))) / 2
        End If
        Return area
    End Function

    Private Function area_paralelogramo(ByVal B As Int32, ByVal h As Int32) As Double
        Dim area As Double

        Try
            area = (L1 * (Sqrt(L2 ^ 2 + (L1 / 2) ^ 2))) / 2
            Return area
        Catch ex As OverflowException
            MessageBox.Show("Uno de los lados es demasiado grande")
        Catch ex As InvalidCastException
            MessageBox.Show("No esta permitido el ingreso de letras")
        Catch ex As Exception
            MessageBox.Show("")
        End Try
    End Function

    Private Function area_rectangulo(ByVal B As Int32, ByVal h As Int32) As Double
        Dim area As Double

        Try
            area = B * h
            Return area
        Catch ex As OverflowException
            MessageBox.Show("Uno de los lados es demasiado grande")
        Catch ex As InvalidCastException
            MessageBox.Show("No esta permitido el ingreso de letras")
        Catch ex As Exception
            MessageBox.Show("")
        End Try
    End Function
End Module
