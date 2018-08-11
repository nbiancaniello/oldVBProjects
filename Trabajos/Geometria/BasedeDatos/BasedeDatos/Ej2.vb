Imports System.Data.SqlClient
Public Class Ej2
    
    Private Sub Ej2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Short = 0
        Dim cadena As String
        Dim CN As New SqlConnection
        Dim DR As SqlDataReader
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = "DATA SOURCE = METAL-3B17106FD; INITIAL CATALOG = Alumnos; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = SSPI"
            CM.CommandType = CommandType.StoredProcedure
            CM.CommandText = "TraerLocalidades"
            CM.Connection = CN
            CN.Open()
            DR = CM.ExecuteReader
            While DR.Read()
                cadena = ""
                cadena = CStr(DR.Item("cod_postal"))
                cadena = cadena + " - "
                cadena = cadena + CStr(DR.Item("localidad"))
                lst_localidades.Items.Insert(i, cadena)
                i = CShort((i + 1))
            End While
            CN.Close()
            DR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            CN.Dispose()
            CM.Dispose()
        End Try
    End Sub
End Class