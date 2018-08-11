Imports System.Data.SqlClient

Public Class Tabla
    Private Sub Tabla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection
        Dim comando As New SqlCommand
        Dim datareader As SqlDataReader
        Dim i As Byte
        Try
            conexion.ConnectionString = ruta
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "TRAERTODOS"
            comando.Connection = conexion
            conexion.Open()
            datareader = comando.ExecuteReader
            If datareader.HasRows = True Then
                While datareader.Read
                    With lv_datos
                        .Items.Add(datareader.GetByte(0).ToString)
                        .Items(i).SubItems.Add(datareader.GetString(1))
                        .Items(i).SubItems.Add(datareader.GetDateTime(2).ToShortDateString)
                        If datareader.IsDBNull(3) Then
                            .Items(i).SubItems.Add("No tiene")
                        Else
                            .Items(i).SubItems.Add(datareader.GetString(3))
                        End If

                        If datareader.IsDBNull(4) Then
                            .Items(i).SubItems.Add("No tiene")
                        Else
                            .Items(i).SubItems.Add(datareader.GetString(4))
                        End If

                        If datareader.IsDBNull(5) Then
                            .Items(i).SubItems.Add("No tiene")
                        Else
                            .Items(i).SubItems.Add(datareader.GetString(5))
                        End If
                    End With
                    i = CByte(i + 1)
                End While
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            comando.Dispose()
        End Try

    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        End
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If lv_datos.Items.Count = 0 Then
            MessageBox.Show("No hay registros en la tabla")
        Else
            If lv_datos.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un registro para modificar")
            Else
                Modificar.Show()
            End If
        End If
    End Sub
End Class