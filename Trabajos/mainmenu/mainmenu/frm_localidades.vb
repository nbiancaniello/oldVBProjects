Imports System.Data.SqlClient

Public Class frm_localidades

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        Dim i As Integer = 0
        Dim CN As New SqlConnection
        Dim DR As SqlDataReader
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = TP4; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = SSPI"
            CM.CommandType = CommandType.Text
            CM.CommandText = "SELECT CP, LOCALIDAD FROM LOCALIDADES"
            CM.Connection = CN
            CN.Open()
            DR = CM.ExecuteReader
            lv_localidades.Items.Clear()
            lv_localidades.Visible = False

            If DR.HasRows = True Then
                While DR.Read()
                    lv_localidades.Items.Add(DR.GetInt16(0).ToString)
                    lv_localidades.Items(i).SubItems.Add(DR.GetString(1))
                    i = i + 1
                End While
                lv_localidades.Visible = True
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            CN.Close()
            DR.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show("Existe un problema con el programa")
        Finally
            CN.Dispose()
            CM.Dispose()
        End Try
    End Sub
End Class