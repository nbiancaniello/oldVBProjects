Imports System.Data.SqlClient
Module Módulo
    Public Const Ruta As String = "DATA SOURCE=(LOCAL); INITIAL CATALOG=BD5;USER ID=SA; PASSWORD=''; INTEGRATED SECURITY=sspi"
    Public Enum eAccion As Byte
        AGREGAR = 0
        MODIFICAR = 1
    End Enum
    Public AccionForm As eAccion

    Public Function verificar_nombre(ByRef nombre As TextBox) As Boolean
        If nombre.Text.Trim = "" Then
            Return False
        Else
            If nombre.Text.Contains(CStr(0)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(1)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(2)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(3)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(4)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(5)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(6)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(7)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(8)) Then
                Return False
            End If
            If nombre.Text.Contains(CStr(9)) Then
                Return False
            End If
            Return True
        End If
    End Function

    Public Function verificar_existencia(ByVal codigo As Int16) As Boolean
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = Ruta
            CM.CommandType = CommandType.StoredProcedure
            CM.Connection = CN
            CM.CommandText = "VerificarSiExiste"
            CM.Parameters.AddWithValue("@codigo", codigo)
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
End Module
