Imports System.Data.SqlClient

Public Class Form2

    Private Sub btn_traer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_traer.Click
        Dim CN As New SqlConnection
        Dim DR As SqlDataReader
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = "DATA SOURCE = METAL-3B17106FD; INITIAL CATALOG = Alumnos; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = SSPI"
            CM.CommandType = CommandType.Text
            CM.CommandText = "SELECT localidad FROM Localidades WHERE cod_postal = " & txt_cod_postal.Text
            CM.Connection = CN
            CN.Open()
            DR = CM.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                lbl_nombre_localidad.Text = DR.GetString(0)
            Else
                lbl_nombre_localidad.Text = "No Encontrado"
            End If
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