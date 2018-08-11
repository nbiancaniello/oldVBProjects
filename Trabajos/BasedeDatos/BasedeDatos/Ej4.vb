Imports System.Data.SqlClient
Public Class Ej4

    Private Sub txt_cod_postal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_postal.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
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
                If lst_localidades.Items.Contains(DR.GetString(0)) = False Then
                    lst_localidades.Items.Add(DR.GetString(0))
                Else
                    lst_localidades.Text = "No Hay Filas"
                End If
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