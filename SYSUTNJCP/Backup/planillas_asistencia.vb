Imports System.Data.SqlClient
Public Class planillas_asistencia
    Dim gv_cuatrimestre As Byte
    Dim gv_motivo As String
    Private Sub planillas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            asignar_set_de_datos(cmb_materias_alta, 12)
            asignar_set_de_datos(cmb_profesores_alta, 8)
            traer_planillas_abiertas()
            limpiar_cajas_alta()
            traer_instancias_a_control(cmb_instancia)
            lbl_anio_alta.Text = Now.Year.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub traer_planillas_abiertas()
        Dim dr As SqlDataReader
        Dim i As Short
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            lsv_planillas.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_planillas_abiertas_introductorio"
            'com.Parameters.AddWithValue("@carr", gv_carrera)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                lsv_planillas.Items.Add(dr.GetInt32(0).ToString)
                lsv_planillas.Items(i).SubItems.Add(dr.GetInt16(1).ToString)
                lsv_planillas.Items(i).SubItems.Add(devolver_mes(dr.GetByte(2)))
                lsv_planillas.Items(i).SubItems.Add(dr.GetString(3))
                lsv_planillas.Items(i).SubItems.Add(dr.GetByte(4).ToString)
                i = CShort(i + 1)
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

    Private Sub limpiar_cajas_alta()
        Try
            cmb_dia1_alta.SelectedIndex = -1
            cmb_dia2_alta.SelectedIndex = -1
            cmb_materias_alta.SelectedIndex = -1
            cmb_profesores_alta.SelectedIndex = -1
            txt_comision.Clear()
            txt_curso.Clear()
            lbl_anio_alta.Text = ""
            cmb_instancia.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_comision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_comision.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub chk_segundo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_segundo.CheckedChanged
        Try
            If chk_segundo.Checked Then
                cmb_dia2_alta.Enabled = True
            Else
                cmb_dia2_alta.Enabled = False
                cmb_dia2_alta.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar_alta.Click
        Try
            Select Case gv_motivo
                Case "A"
                    If verificar_vacios_generacion_planilla() Then
                        If verificar_numeros(txt_comision.Text, 3) = False Then
                            MessageBox.Show("El Nº de Comisión es inválido")
                            txt_comision.Focus()
                            Exit Sub
                        End If
                        If CInt(txt_comision.Text) > 255 Then
                            MessageBox.Show("El Nº debe ser menor a 255")
                            txt_comision.Focus()
                            Exit Sub
                        End If
                        If verificar_otra_planillas() = True Then
                            MessageBox.Show("Ya existe una planilla generada con estos datos")
                            Exit Sub
                        End If
                        If verificar_cantidad_alumnos_inscriptos_a_materia() = False Then
                            MessageBox.Show("No hay Alumnos inscriptos para esta Materia")
                            Exit Sub
                        End If
                        If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If generar_planilla_alumnos() Then
                                MessageBox.Show("Planilla Generada Exitósamente")
                                grp_alta.Enabled = False
                                btn_alta.Enabled = True
                                btn_modificar.Enabled = True
                                btn_baja.Enabled = True
                                btn_cerrar.Enabled = True
                                limpiar_cajas_alta()
                                Exit Sub
                            End If
                        End If
                    End If
                Case "M"
                    If verificar_vacios_generacion_planilla() Then
                        If verificar_numeros(txt_comision.Text, 3) = False Then
                            MessageBox.Show("El Nº de Comisión es inválido")
                            txt_comision.Focus()
                            Exit Sub
                        End If
                        If CInt(txt_comision.Text) > 255 Then
                            MessageBox.Show("El Nº debe ser menor a 255")
                            txt_comision.Focus()
                            Exit Sub
                        End If
                        'If verificar_otra_planillas() = True Then
                        '    MessageBox.Show("Ya existe una planilla generada con estos datos")
                        '    Exit Sub
                        'End If
                        If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If eliminar_planilla() Then
                                If generar_planilla_alumnos() Then
                                    MessageBox.Show("Planilla Modificada Exitósamente")
                                    grp_alta.Enabled = False
                                    btn_alta.Enabled = True
                                    btn_modificar.Enabled = True
                                    btn_baja.Enabled = True
                                    limpiar_cajas_alta()
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function cerrar_planilla() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.CommandType = CommandType.Text
            com.CommandText = "UPDATE pl_asist_ca SET estado = 'C' WHERE nroplanilla = " & lsv_planillas.SelectedItems(0).SubItems(0).Text
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Function verificar_cantidad_alumnos_inscriptos_a_materia() As Boolean
        Dim cant As Int16
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "verificar_cantidad_alumnos_inscriptos_a_materia"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@cod", cmb_materias_alta.SelectedValue)
            com.Parameters.AddWithValue("@anio", lbl_anio_alta.Text)
            com.Parameters.AddWithValue("@cuat", cmb_instancia.SelectedIndex + 1)
            con.Open()
            cant = CShort(com.ExecuteScalar)
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try

    End Function

    Private Function verificar_vacios_generacion_planilla() As Boolean
        Try
            If cmb_materias_alta.SelectedIndex = -1 Then
                MessageBox.Show("Elija una Materia")
                cmb_materias_alta.Focus()
                Return False
            End If
            If cmb_profesores_alta.SelectedIndex = -1 Then
                MessageBox.Show("Elija un Profesor/a")
                cmb_profesores_alta.Focus()
                Return False
            End If
            If txt_curso.Text = "" Then
                MessageBox.Show("Ingrese el Curso")
                txt_curso.Focus()
                Return False
            End If
            If txt_comision.Text = "" Then
                MessageBox.Show("Ingrese la Comisión")
                txt_comision.Focus()
                Return False
            End If
            If cmb_dia1_alta.SelectedIndex = -1 Then
                MessageBox.Show("Elija Día de Cursada")
                cmb_dia1_alta.Focus()
                Return False
            End If
            If chk_segundo.Checked Then
                If cmb_dia2_alta.SelectedIndex = -1 Then
                    MessageBox.Show("Elija 2º Día de Cursada")
                    cmb_dia2_alta.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub cmb_dia2_alta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_dia2_alta.SelectedIndexChanged
        If cmb_dia1_alta.SelectedIndex = cmb_dia2_alta.SelectedIndex Then
            If Not (cmb_dia1_alta.SelectedIndex = -1 And cmb_dia2_alta.SelectedIndex = -1) Then
                MessageBox.Show("Elija días distintos")
                cmb_dia2_alta.SelectedIndex = -1
                cmb_dia2_alta.Focus()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub cmb_dia1_alta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_dia1_alta.SelectedIndexChanged
        If chk_segundo.Checked Then
            If cmb_dia1_alta.SelectedIndex = cmb_dia2_alta.SelectedIndex Then
                If Not (cmb_dia1_alta.SelectedIndex = -1 And cmb_dia2_alta.SelectedIndex = -1) Then
                    MessageBox.Show("Elija días distintos")
                    cmb_dia2_alta.SelectedIndex = -1
                    cmb_dia2_alta.Focus()
                End If

                Exit Sub
            End If
        End If
    End Sub

    Private Function generar_planilla_alumnos() As Boolean
        Dim tran As SqlTransaction
        Dim con1 As New SqlConnection(ruta)
        Dim com1 As New SqlCommand
        Dim nro As Int32

        Try
            nro = traer_ultimo_nro_planilla()
            com1.Connection = con1
            com1.CommandType = CommandType.StoredProcedure
            com1.CommandText = "generar_nueva_planilla"
            If gv_motivo = "M" Then
                com1.Parameters.AddWithValue("@nro", lsv_planillas.SelectedItems(0).SubItems(0).Text)
            Else
                com1.Parameters.AddWithValue("@nro", nro)
            End If
            com1.Parameters.AddWithValue("@cod", cmb_materias_alta.SelectedValue)
            com1.Parameters.AddWithValue("@pro", cmb_profesores_alta.SelectedValue)
            com1.Parameters.AddWithValue("@cur", txt_curso.Text)
            com1.Parameters.AddWithValue("@com", txt_comision.Text)
            com1.Parameters.AddWithValue("@anio", lbl_anio_alta.Text)
            gv_cuatrimestre = CByte(cmb_instancia.SelectedIndex + 1)
            com1.Parameters.AddWithValue("@cuat", gv_cuatrimestre)
            com1.Parameters.AddWithValue("@dia", cmb_dia1_alta.SelectedIndex + 1)
            If cmb_dia2_alta.SelectedIndex <> -1 Then
                com1.Parameters.AddWithValue("@diados", cmb_dia2_alta.SelectedIndex + 1)
            Else
                com1.Parameters.AddWithValue("@diados", DBNull.Value)
            End If
            com1.Parameters.AddWithValue("@est", "A")
            com1.Parameters.AddWithValue("@obl", chk_asis_obl.Checked)
            con1.Open()
            tran = con1.BeginTransaction
            com1.Transaction = tran
            com1.ExecuteNonQuery()

            If gv_motivo = "A" And chk_asis_obl.Checked = True Then
                If Not actualizar_cursada_por_alumno(CStr(cmb_materias_alta.SelectedValue), lbl_anio_alta.Text, gv_cuatrimestre, "C") Then
                    tran.Rollback()
                    con1.Close()
                    Return False
                End If
            End If

            tran.Commit()
            con1.Close()

            If gv_motivo = "A" Then
                lsv_planillas.Items.Add(nro.ToString)
                lsv_planillas.Items(lsv_planillas.Items.Count - 1).SubItems.Add(lbl_anio_alta.Text)
                lsv_planillas.Items(lsv_planillas.Items.Count - 1).SubItems.Add(cmb_instancia.Items(cmb_instancia.SelectedIndex).ToString)
                lsv_planillas.Items(lsv_planillas.Items.Count - 1).SubItems.Add(traer_nombre_materia(CByte(cmb_materias_alta.SelectedValue.ToString)))
                lsv_planillas.Items(lsv_planillas.Items.Count - 1).SubItems.Add(cmb_materias_alta.SelectedValue.ToString)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con1.Dispose()
            com1.Dispose()
        End Try
    End Function

    Public Function verificar_otra_planillas() As Boolean
        Dim cant As Int16
        Dim cadena As String
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.Text

            cadena = "SELECT COUNT(nroplanilla) FROM pl_asist_ca WHERE codmateria = " & cmb_materias_alta.SelectedValue.ToString & _
            " AND anio = " & lbl_anio_alta.Text & " AND cuatrimestre = " & cmb_instancia.SelectedIndex + 1
            com.CommandText = cadena
            con.Open()
            cant = CShort(com.ExecuteScalar)
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Function traer_ultimo_nro_planilla() As Int32
        Dim dr As SqlDataReader
        Dim nro_planilla As Int32
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_ultimo_nro_planilla"
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If dr.IsDBNull(0) Then
                        nro_planilla = 1
                    Else
                        nro_planilla = dr.GetInt32(0)
                    End If
                End While
                dr.Close()
                con.Close()
                Return nro_planilla
            Else
                dr.Close()
                con.Close()
                Return 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return 0
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alta.Click
        Try
            gv_motivo = "A"
            limpiar_cajas_alta()
            lbl_anio_alta.Text = Now.Year.ToString
            cmb_materias_alta.Enabled = True
            cmb_instancia.Enabled = True
            btn_alta.Enabled = False
            btn_baja.Enabled = False
            btn_modificar.Enabled = False
            btn_cerrar.Enabled = False
            grp_alta.Enabled = True
            btn_aceptar_alta.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            limpiar_cajas_alta()
            grp_alta.Enabled = False
            btn_alta.Enabled = True
            btn_baja.Enabled = True
            btn_modificar.Enabled = True
            btn_cerrar.Enabled = True
            btn_aceptar_alta.Enabled = False
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            If lsv_planillas.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe elegir un registro de la lista")
                lsv_planillas.Focus()
                Exit Sub
            End If
            lbl_anio_alta.Text = Now.Year.ToString
            gv_motivo = "M"
            cmb_materias_alta.Enabled = False
            cmb_instancia.Enabled = False
            btn_alta.Enabled = False
            btn_baja.Enabled = False
            btn_modificar.Enabled = False
            grp_alta.Enabled = True
            btn_cerrar.Enabled = False
            btn_aceptar_alta.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function contiene_registros() As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(nroplanilla) FROM pl_asist_de WHERE nroplanilla = " & lsv_planillas.SelectedItems(0).SubItems(0).Text
            con.Open()
            cant = CShort(com.ExecuteScalar)
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function traer_cabecera_planilla_seleccionada() As Boolean
        Dim dr As SqlDataReader
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_cabecera_planilla_seleccionada"
            com.Parameters.AddWithValue("@nro", lsv_planillas.SelectedItems(0).SubItems(0).Text)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                cmb_materias_alta.SelectedValue = dr.GetByte(0)
                cmb_profesores_alta.SelectedValue = dr.GetInt16(1)
                txt_curso.Text = dr.GetString(2)
                txt_comision.Text = dr.GetByte(3).ToString
                lbl_anio_alta.Text = dr.GetInt16(4).ToString
                cmb_instancia.SelectedIndex = dr.GetByte(5) - 1
                cmb_dia1_alta.Text = devolver_dia(dr.GetByte(6))
                If Not dr.IsDBNull(7) Then
                    cmb_dia2_alta.Text = devolver_dia(dr.GetByte(7))
                    chk_segundo.Checked = True
                Else
                    chk_segundo.Checked = False
                End If
                chk_asis_obl.Checked = dr.GetBoolean(9)
            End While
            dr.Close()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baja.Click
        Try
            If lsv_planillas.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe elegir un registro de la lista")
                lsv_planillas.Focus()
                Exit Sub
            End If
            gv_motivo = "E"
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If contiene_registros() Then
                    MessageBox.Show("Esta planilla contiene registros, no se puede eliminar")
                    Exit Sub
                End If
                If eliminar_planilla() Then
                    lsv_planillas.Items.RemoveAt(lsv_planillas.SelectedIndices(0))
                    MessageBox.Show("Planilla Eliminada Exitósamente")
                    grp_alta.Enabled = False
                    btn_alta.Enabled = True
                    btn_modificar.Enabled = True
                    btn_baja.Enabled = True
                    btn_cerrar.Enabled = True
                    limpiar_cajas_alta()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function eliminar_planilla() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.CommandType = CommandType.Text
            com.CommandText = "DELETE FROM pl_asist_ca WHERE nroplanilla = " & lsv_planillas.SelectedItems(0).SubItems(0).Text
            com.ExecuteNonQuery()
            If gv_motivo = "E" Then
                If Not actualizar_cursada_por_alumno(lsv_planillas.SelectedItems(0).SubItems(4).Text, lbl_anio_alta.Text, CByte(cmb_instancia.SelectedIndex + 1), "D") Then
                    tran.Rollback()
                    con.Close()
                    Return False
                End If
            End If
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Try
            If lsv_planillas.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe elegir un registro de la lista")
                lsv_planillas.Focus()
                Exit Sub
            End If
            If MessageBox.Show("¿Desea Cerrar la Planilla?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cerrar_planilla() And actualizar_cursada_por_alumno(lsv_planillas.SelectedItems(0).SubItems(4).Text, lbl_anio_alta.Text, CByte(cmb_instancia.SelectedIndex + 1), "F") Then
                    MessageBox.Show("Cerrada Exitósamente")
                    lsv_planillas.SelectedItems(0).SubItems(4).Text = "CERRADA"
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_planillas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_planillas.KeyDown
        Try
            If lsv_planillas.Items.Count <> 0 Then
                traer_cabecera_planilla_seleccionada()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_planillas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_planillas.KeyUp
        Try
            If lsv_planillas.Items.Count <> 0 Then
                traer_cabecera_planilla_seleccionada()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_planillas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_planillas.MouseClick
        Try
            If lsv_planillas.Items.Count <> 0 Then
                traer_cabecera_planilla_seleccionada()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class