Imports System.Data.SqlClient
Module Rutinas
    Public Enum eAccion As Byte
        AGREGAR = 0
        MODIFICAR = 1
    End Enum
    Public Accion As eAccion

    Public Function verificar_existencia(ByVal cod As Short) As Boolean
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Try
            CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = TP4; USER ID = SA; PASSWORD =''; INTEGRATED SECURITY = sspi"
            CM.CommandType = CommandType.Text
            CM.CommandText = "SELECT CP FROM LOCALIDADES WHERE CP = " & cod
            CM.Connection = CN
            CN.Open()
            DR = CM.ExecuteReader
            If DR.HasRows = True Then
                Return True
            Else
                Return False
            End If
            CN.Close()
            DR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            CN.Dispose()
            CM.Dispose()
        End Try
    End Function
End Module
