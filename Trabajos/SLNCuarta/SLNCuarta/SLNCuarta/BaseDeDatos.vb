Imports System.Data.SqlClient
Public Class BaseDeDatos
    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
        Acceso.Close()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Accion = eAccion.Agregar
        DatosPersonales.ShowDialog()
    End Sub

    Private Sub BaseDeDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Byte = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.Text
            cm.CommandText = "SELECT legajo, nombre, telefono, celular, email, fecha_nacimiento, sexo FROM Datos"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            lv_datos.Items.Clear()
            lv_datos.Visible = False
            If dr.HasRows = True Then
                While dr.Read()
                    lv_datos.Items.Add(dr.GetInt16(0).ToString)
                    lv_datos.Items(i).SubItems.Add(dr.GetString(1))
                    If dr.IsDBNull(2) Then
                        lv_datos.Items(i).SubItems.Add("No tiene")
                    Else
                        lv_datos.Items(i).SubItems.Add(dr.GetString(2))
                    End If
                    If dr.IsDBNull(4) Then
                        lv_datos.Items(i).SubItems.Add("No tiene")
                    Else
                        lv_datos.Items(i).SubItems.Add(dr.GetString(4))
                    End If
                    If dr.IsDBNull(3) Then
                        lv_datos.Items(i).SubItems.Add("No tiene")
                    Else
                        lv_datos.Items(i).SubItems.Add(dr.GetString(3))
                    End If
                    lv_datos.Items(i).SubItems.Add(dr.GetDateTime(5).ToShortDateString)
                    lv_datos.Items(i).SubItems.Add(dr.GetString(6))
                    i = CByte(i + 1)
                End While
                lv_datos.Visible = True
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            cn.Close()
            dr.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show("Existe un problema con el programa")
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand

        Try
            If lv_datos.Items.Count = 0 Then
                MessageBox.Show("No hay datos")
            Else
                If lv_datos.SelectedItems.Count = 0 Then
                    MessageBox.Show("Seleccione un elemento")
                Else
                    If MessageBox.Show("¿Está Seguro?", "Pregunta", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = P3TP4; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = sspi"
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "EliminarPersona"
                            .Parameters.AddWithValue("@legajo", Convert.ToInt16(lv_datos.SelectedItems(0).Text))
                        End With
                        CN.Open()
                        CM.ExecuteNonQuery()
                        CN.Close()
                        lv_datos.Items.Remove(lv_datos.SelectedItems(0))
                    End If
                End If
            End If
        Catch ex As SqlException
            MessageBox.Show("Problema con la base de datos")
        Catch ex As Exception
            MessageBox.Show("Problema con los datos")
        Finally
            CN.Dispose()
            CM.Dispose()
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If lv_datos.Items.Count = 0 Then
            MessageBox.Show("No hay datos para modificar")
        Else
            If lv_datos.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un registro para modificar")
            Else
                Accion = eAccion.Modificar
                DatosPersonales.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Buscar.ShowDialog()
    End Sub
End Class