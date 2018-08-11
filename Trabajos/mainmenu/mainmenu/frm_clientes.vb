Imports System.Data.SqlClient

Public Class frm_clientes

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        Dim i As Short = 0
        Dim CN As New SqlConnection
        Dim DR As SqlDataReader
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = TP4; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = SSPI"
            CM.CommandType = CommandType.Text
            CM.CommandText = "SELECT NUMERO, NOMBRE, DIRECCION, CP, TELEFONO, CELULAR, EMAIL FROM CLIENTES"
            CM.Connection = CN
            CN.Open()
            DR = CM.ExecuteReader
            lv_clientes.Items.Clear()
            lv_clientes.Visible = False
            If DR.HasRows = True Then
                While DR.Read()
                    lv_clientes.Items.Add(DR.GetInt16(0).ToString)
                    lv_clientes.Items(i).SubItems.Add(DR.GetString(1))
                    If DR.IsDBNull(2) = True Then
                        lv_clientes.Items(i).SubItems.Add("")
                    Else
                        lv_clientes.Items(i).SubItems.Add(DR.GetString(2))
                    End If
                    lv_clientes.Items(i).SubItems.Add(DR.GetInt16(3).ToString)
                    If DR.IsDBNull(4) = True Then
                        lv_clientes.Items(i).SubItems.Add("")
                    Else
                        lv_clientes.Items(i).SubItems.Add(DR.GetString(4))
                    End If
                    If DR.IsDBNull(5) = True Then
                        lv_clientes.Items(i).SubItems.Add("")
                    Else
                        lv_clientes.Items(i).SubItems.Add(DR.GetString(5))
                    End If
                    If DR.IsDBNull(6) = True Then
                        lv_clientes.Items(i).SubItems.Add("")
                    Else
                        lv_clientes.Items(i).SubItems.Add(DR.GetString(6))
                    End If
                    i = i + 1
                End While
                lv_clientes.Visible = True
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