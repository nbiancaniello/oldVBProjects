Imports System.Data.SqlClient
Public Class bajas_alumnos

    Private Sub bajas_alumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Baja de Alumnos - " & gv_nombre_sistema
            traer_nombre_apellido(lsv_alumnos_inscriptos, 6)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub traer_alumnos_seleccionados()
        Dim dr As SqlDataReader

        Try
            limpiar_cajas_baja_alumnos()
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_dp_alumno_baja"
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                txt_nombre.Text = dr.GetString(0)
                txt_apellido.Text = dr.GetString(1)
                If Not dr.IsDBNull(2) Then
                    txt_nro_legajo.Text = dr.GetInt16(2).ToString
                End If
                txt_domicilio.Text = dr.GetString(3)
                txt_localidad.Text = dr.GetString(4)
                txt_tipo_documento.Text = dr.GetString(5)
                txt_nro_documento.Text = dr.GetInt32(6).ToString
                txt_nacionalidad.Text = dr.GetString(7)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            grp_datos_alumno.Enabled = False
            grp_baja.Enabled = False
            limpiar_cajas_baja_alumnos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If lsv_alumnos_inscriptos.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar un registro")
                Exit Sub
            End If
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If dar_baja_alumno() Then
                    MessageBox.Show("El alumno ha sido de baja satisfactoriamente")
                    limpiar_cajas_baja_alumnos()
                    lsv_alumnos_inscriptos.Items.RemoveAt(lsv_alumnos_inscriptos.SelectedIndices(0))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function dar_baja_alumno() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Clear()
            com.CommandText = "inactivar_alumno"
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()

            com.CommandText = "dar_baja_alumno"
            com.Parameters.AddWithValue("@mot", txt_motivo.Text)
            com.ExecuteNonQuery()

            com.CommandType = CommandType.Text
            If cbx_motivo1.Checked = True Then
                com.CommandText = "INSERT INTO bajasalumnosxmotivos VALUES(" & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text _
                               & "," & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text & ",1)"
                com.ExecuteNonQuery()
            End If
            If cbx_motivo2.Checked = True Then
                com.CommandText = "INSERT INTO bajasalumnosxmotivos VALUES(" & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text _
                               & "," & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text & ",2)"
                com.ExecuteNonQuery()
            End If
            If cbx_motivo3.Checked = True Then
                com.CommandText = "INSERT INTO bajasalumnosxmotivos VALUES(" & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text _
                               & "," & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text & ",3)"
                com.ExecuteNonQuery()
            End If
            If cbx_motivo4.Checked = True Then
                com.CommandText = "INSERT INTO bajasalumnosxmotivos VALUES(" & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text _
                               & "," & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text & ",4)"
                com.ExecuteNonQuery()
            End If
            If cbx_motivo5.Checked = True Then
                com.CommandText = "INSERT INTO bajasalumnosxmotivos VALUES(" & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text _
                               & "," & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text & ",5)"
                com.ExecuteNonQuery()
            End If

            com.CommandText = "dar_baja_materias_alumno"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.ExecuteNonQuery()

            tran.Commit()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return True
    End Function

    Private Sub limpiar_cajas_baja_alumnos()
        Try
            txt_nacionalidad.Clear()
            txt_apellido.Clear()
            txt_domicilio.Clear()
            txt_nombre.Clear()
            txt_nro_documento.Clear()
            txt_nro_legajo.Clear()
            txt_localidad.Clear()
            txt_tipo_documento.Clear()
            txt_motivo.Clear()
            cbx_motivo1.Checked = False
            cbx_motivo2.Checked = False
            cbx_motivo3.Checked = False
            cbx_motivo4.Checked = False
            cbx_motivo5.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_alumnos_inscriptos.KeyDown
        Try
            traer_alumnos_seleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_alumnos_inscriptos.KeyUp
        Try
            traer_alumnos_seleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_MouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_alumnos_inscriptos.MouseClick
        Try
            traer_alumnos_seleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class