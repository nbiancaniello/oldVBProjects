Imports System.Data.SqlClient
Module Módulos
    Public Enum eAccion As Byte
        Agregar = 0
        Modificar = 1
    End Enum
    Public Accion As eAccion
    Public Const Ruta As String = "DATA SOURCE=(LOCAL); INITIAL CATALOG=P3TP4;USER ID=SA; PASSWORD=''; INTEGRATED SECURITY=sspi"

    Public Function verificar_existencia(ByVal legajo As Int16) As Boolean
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = Ruta
            CM.CommandType = CommandType.StoredProcedure
            CM.Connection = CN
            CM.CommandText = "VerificarExistencia"
            CM.Parameters.AddWithValue("@legajo", legajo)
            CN.Open()
            If Convert.ToInt16(CM.ExecuteScalar) = 1 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con la base de datos")
        End Try
    End Function

    Public Function verificarcadena(ByVal texto As String) As Boolean
        Dim i As Byte

        For i = 0 To CByte(texto.Length - 1)
            If IsNumeric(texto.Substring(i, 1)) = True Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function verificarcadena(ByVal texto As String, ByVal flag As Byte) As Boolean
        Dim i As Byte

        Select Case flag
            Case 1
                For i = 0 To CByte(texto.Length - 1)
                    If IsNumeric(texto.Substring(i, 1)) = False Then
                        Return False
                    End If
                Next
            Case 2
                For i = 0 To CByte(texto.Length - 1)
                    If IsNumeric(texto.Substring(i, 1)) = False And texto.Substring(i, 1) <> "-" And texto.Substring(i, 1) <> "(" And texto.Substring(i, 1) <> ")" Then
                        Return False
                    End If
                Next
            Case 3
                For i = 0 To CByte(texto.Length - 1)
                    If IsNumeric(texto.Substring(i, 1)) = False And texto.Substring(i, 1) <> "-" Then
                        Return False
                    End If
                Next
        End Select

        Return True
    End Function

    Public Function verificar_email(ByVal mail As String) As Boolean
        Dim i As Byte
        Dim cont As Byte = 0
        For i = 0 To CByte(mail.Length - 1)
            If mail.Substring(i, 1) = "@" Then
                cont = CByte(cont + 1)
            End If
            If cont > 1 Then
                Return False
            End If
        Next
        Return True
    End Function
End Module
