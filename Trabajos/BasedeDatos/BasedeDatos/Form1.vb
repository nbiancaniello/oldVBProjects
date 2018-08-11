Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_conectar.Click
        Dim CN As New SqlConnection
        Try
            CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = Alumnos; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = SSPI"
            CN.Open()
            MessageBox.Show("Me conecté!!")
            CN.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("ERROR DE CONEXIÓN")
        Finally
            CN.Dispose()
        End Try
    End Sub
End Class
