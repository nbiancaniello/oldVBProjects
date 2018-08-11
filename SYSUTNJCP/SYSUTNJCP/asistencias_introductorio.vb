Imports System.Data.SqlClient
Public Class asistencias_introductorio
    Dim gv_nro_clase As Byte
    Dim gv_cod_materia As Byte
    Dim gv_motivo As String
    Dim gv_max_fecha As Date

    Private Sub planilla_asistencia_introductorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargar_anios(cmb_anios)
            traer_instancias_a_control(cmb_instancia)
            dtp_fecha_asistencia.MaxDate = Now.Date
            lsv_materias.Items.Clear()
            lsv_materias.Enabled = False
            lsv_planilla.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Try
            If cmb_anios.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un Año")
                cmb_anios.Focus()
                Exit Sub
            End If
            If cmb_instancia.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una Instancia")
                cmb_instancia.Focus()
                Exit Sub
            End If
            lsv_materias.Items.Clear()
            lsv_planilla.Clear()
            If buscar_lista_por_anio_cuatrimestre() = True Then
                btn_registrar_asistencias.Enabled = True
                btn_modificar.Enabled = True
                btn_eliminar.Enabled = True
            Else
                btn_registrar_asistencias.Enabled = False
                btn_modificar.Enabled = False
                btn_eliminar.Enabled = False
                MessageBox.Show("No hay planillas para el año y cuatrimestre seleccionados")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function buscar_lista_por_anio_cuatrimestre() As Boolean
        Dim dr As SqlDataReader
        Dim i As Int16 = 0
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            lsv_materias.Enabled = False
            lsv_materias.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_materias_por_anio_cuatrimestre"
            com.Parameters.AddWithValue("@anio", cmb_anios.Text)
            com.Parameters.AddWithValue("@cuat", cmb_instancia.SelectedIndex + 1)
            com.Parameters.AddWithValue("@carr", 0)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lsv_materias.Items.Add(dr.GetInt32(0).ToString)
                    lsv_materias.Items(i).SubItems.Add(dr.GetByte(1).ToString)
                    lsv_materias.Items(i).SubItems.Add(dr.GetString(2))
                    lsv_materias.Items(i).SubItems.Add(dr.GetString(3))
                    i = CShort(i + 1)
                End While
                lsv_materias.Enabled = True
                dr.Close()
                con.Close()
                Return True
            Else
                dr.Close()
                con.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub lsv_materias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_materias.KeyDown
        buscar_planilla()
    End Sub

    Private Sub lsv_materias_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_materias.KeyUp
        buscar_planilla()
    End Sub

    Private Sub lsv_materias_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_materias.MouseClick
        buscar_planilla()
    End Sub

    Public Sub buscar_planilla()
        Try
            lsv_planilla.Visible = False
            lsv_planilla.Clear()
            lsv_planilla.Columns.Add("insc")
            lsv_planilla.Columns(0).Width = 0
            lsv_planilla.Columns.Add("anio")
            lsv_planilla.Columns(1).Width = 0
            lsv_planilla.Columns.Add("Apellido y Nombre")
            lsv_planilla.Columns(2).Text = "Apellido y Nombre"
            lsv_planilla.Columns(2).Width = 200
            lsv_planilla.Columns(2).TextAlign = HorizontalAlignment.Center
            lsv_planilla.Visible = True
            traer_cabecera_planilla()
            lbl_nroplanilla.Text = lsv_materias.SelectedItems(0).SubItems(0).Text
            lbl_anio.Text = cmb_anios.Text
            lbl_instancia.Text = cmb_instancia.Items(cmb_instancia.SelectedIndex).ToString
            If lsv_materias.SelectedItems(0).SubItems(3).Text = "A" Then
                lbl_estado.Text = "ABIERTA"
                btn_eliminar.Enabled = True
                btn_modificar.Enabled = True
                btn_registrar_asistencias.Enabled = True
            Else
                lbl_estado.Text = "CERRADA"
                btn_eliminar.Enabled = False
                btn_modificar.Enabled = False
                btn_registrar_asistencias.Enabled = False
            End If
            traer_detalles_planilla_asistencia()
            gv_cod_materia = CByte(lsv_materias.SelectedItems(0).SubItems(1).Text)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub traer_cabecera_planilla()
        Dim dr As SqlDataReader
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_cabecera_planilla"
            com.Parameters.AddWithValue("@nro", lsv_materias.SelectedItems(0).SubItems(0).Text)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                lbl_profesor.Text = dr.GetString(1) & ", " & dr.GetString(0)
                lbl_curso.Text = dr.GetString(2)
                lbl_comision.Text = dr.GetByte(3).ToString
                lbl_dias.Text = devolver_dia(dr.GetByte(4))
                gv_dia1_materia = dr.GetByte(4)
                If Not dr.IsDBNull(5) Then
                    lbl_dias.Text = lbl_dias.Text & " Y " & devolver_dia(dr.GetByte(5))
                    gv_dia2_materia = dr.GetByte(5)
                End If
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

    Private Sub traer_detalles_planilla_asistencia()
        Dim dr As SqlDataReader
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim i As Byte = 0
        Try
            gv_nro_clase = 0
            lsv_planilla.Visible = False
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_fechas_detalle_planillas"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_materias.SelectedItems(0).SubItems(0).Text)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                gv_nro_clase = 1
                While dr.Read
                    gv_max_fecha = CDate(dr.GetDateTime(0).ToShortDateString)
                    lsv_planilla.Columns.Add(dr.GetDateTime(0).ToShortDateString.Substring(0, 5))
                    lsv_planilla.Columns(gv_nro_clase + 1).Width = 50
                    lsv_planilla.Columns(gv_nro_clase + 1).TextAlign = HorizontalAlignment.Center
                    gv_nro_clase = CByte(gv_nro_clase + 1)
                End While
            End If
            dr.Close()

            com.CommandText = "traer_alumnos_planilla_asistencia"
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lsv_planilla.Items.Add(dr.GetInt16(0).ToString)
                    lsv_planilla.Items(i).SubItems.Add(dr.GetInt16(1).ToString)
                    lsv_planilla.Items(i).SubItems.Add(dr.GetString(3) & ", " & dr.GetString(2))
                    traer_asistencias_por_planilla(lsv_materias.SelectedItems(0).SubItems(0).Text, dr.GetInt16(0), dr.GetInt16(1), i)
                    i = CByte(i + 1)
                End While
                'Else
                '    MessageBox.Show("No hay alumnos inscriptos")
            End If
            lsv_planilla.Columns(2).Width = 200
            lsv_planilla.Visible = True
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Private Sub traer_asistencias_por_planilla(ByVal nroplanilla As String, ByVal nroinscripcion As Int16, ByVal anio As Int16, ByVal posicion As Byte)
        Dim dr As SqlDataReader
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_asistencias_por_planilla"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", nroplanilla)
            com.Parameters.AddWithValue("@ins", nroinscripcion)
            com.Parameters.AddWithValue("@anio", anio)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lsv_planilla.Items(posicion).SubItems.Add(dr.GetString(0))
                End While
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Private Sub btn_registrar_asistencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar_asistencias.Click
        Try
            gv_motivo = "A"
            If lsv_materias.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe Seleccionar un registro")
                Exit Sub
            End If
            gv_cod_materia = CByte(lsv_materias.SelectedItems(0).SubItems(1).Text)
            grp_cabecera.Enabled = False
            grp_planilla.Enabled = True
            grp_fecha.Enabled = True
            btn_aceptar.Enabled = False
            lsv_planilla.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            gv_motivo = "M"
            If lsv_materias.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe Seleccionar un registro")
                Exit Sub
            End If
            If gv_nro_clase = 0 Then
                MessageBox.Show("No se puede modificar, no hay asistencias registradas")
                Exit Sub
            End If
            lsv_planilla.Enabled = False
            grp_estados.Enabled = False
            btn_aceptar.Enabled = False
            grp_cabecera.Enabled = False
            grp_planilla.Enabled = True
            grp_fecha.Enabled = False
            grp_nro_clase.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            If lsv_materias.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe Seleccionar un registro")
                Exit Sub
            End If
            If gv_nro_clase = 0 Then
                MessageBox.Show("No se puede eliminar, no hay asistencias registradas")
                Exit Sub
            End If
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If eliminar_clase_planilla_detalle(CByte(gv_nro_clase - 1)) Then
                    MessageBox.Show("La clase " & (gv_nro_clase - 1) & " para el Nº de planilla " & lbl_nroplanilla.Text & " fue eliminada Satisfactoriamente")
                    grp_planilla.Enabled = False
                    grp_cabecera.Enabled = True
                    cmb_anios.SelectedIndex = -1
                    lsv_materias.Items.Clear()
                    lsv_planilla.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function eliminar_clase_planilla_detalle(ByVal nroclase As Byte) As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.CommandType = CommandType.Text
            com.CommandText = "DELETE FROM pl_asist_de WHERE nroclase = " & nroclase & " AND nroplanilla = " & lbl_nroplanilla.Text
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

    Private Sub btn_fecha_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fecha_ok.Click
        Try
            If CByte(dtp_fecha_asistencia.Value.DayOfWeek) = 0 Then
                MessageBox.Show("El día seleccionado es Domingo. Reintente")
                dtp_fecha_asistencia.Focus()
                Exit Sub
            End If
            If verificar_fecha_repetida_planilla() = True Then
                MessageBox.Show("La fecha Ingresada ya está registrada")
                dtp_fecha_asistencia.Focus()
                Exit Sub
            End If
            If dtp_fecha_asistencia.Value < gv_max_fecha Then
                MessageBox.Show("La fecha Ingresada es menor a la última fecha registrada")
                dtp_fecha_asistencia.Focus()
                Exit Sub
            End If
            If gv_dia1_materia <> CByte(dtp_fecha_asistencia.Value.DayOfWeek) Then
                If gv_dia2_materia <> CByte(dtp_fecha_asistencia.Value.DayOfWeek) Then
                    If MessageBox.Show("La fecha a registrar no coinciden con los días designados", "Advertencia", _
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Cancel Then
                        Exit Sub
                    Else
                    End If
                Else
                End If
            End If
            grp_estados.Enabled = True
            btn_aceptar.Enabled = True
            lsv_planilla.Enabled = True
            grp_fecha.Enabled = False
            If gv_motivo = "M" Then
                lsv_planilla.Columns(gv_nro_clase + 1).Text = dtp_fecha_asistencia.Value.ToShortDateString.Substring(0, 5)
            Else
                If gv_nro_clase = 0 Then
                    gv_nro_clase = 1
                End If
                lsv_planilla.Columns.Add(dtp_fecha_asistencia.Value.ToShortDateString.Substring(0, 5))
                lsv_planilla.Columns(gv_nro_clase + 1).Width = 50
                lsv_planilla.Columns(gv_nro_clase + 1).TextAlign = HorizontalAlignment.Center
                habilitar_casilleros()
            End If
            lsv_planilla.Columns(2).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_fecha_repetida_planilla() As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "verificar_fecha_repetida_planilla"
            com.Parameters.AddWithValue("@nro", lsv_materias.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@fec", dtp_fecha_asistencia.Value)
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

    Private Sub habilitar_casilleros()
        Dim i As Int16
        Try
            For i = 0 To CShort(lsv_planilla.Items.Count - 1)
                lsv_planilla.Items(i).SubItems.Add("")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_clase_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clase_ok.Click
        Try
            If txt_nro_clase.Text = "" Then
                MessageBox.Show("Ingrese el nº de clase")
                txt_nro_clase.Focus()
                Exit Sub
            End If
            If CShort(txt_nro_clase.Text) <= 0 Then
                txt_nro_clase.Clear()
                MessageBox.Show("El nº de clase no puede ser 0 o negativo")
                txt_nro_clase.Focus()
                Exit Sub
            End If
            If (lsv_planilla.Columns.Count - 3) >= CDbl(txt_nro_clase.Text) Then
                gv_nro_clase = CByte(txt_nro_clase.Text)
                If MessageBox.Show("¿Desea Modificar la Fecha?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    grp_nro_clase.Enabled = False
                    grp_fecha.Enabled = True
                Else
                    grp_estados.Enabled = True
                    lsv_planilla.Enabled = True
                    btn_aceptar.Enabled = True
                    btn_cancelar.Enabled = True
                    grp_estados.Enabled = True
                End If
            Else
                txt_nro_clase.Clear()
                MessageBox.Show("El nº de clase ingresado no está registrado")
                txt_nro_clase.Focus()
                Exit Sub
            End If
            gv_nro_clase = CByte(txt_nro_clase.Text)
            grp_nro_clase.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If verificar_casilleros_vacios() = True Then
                MessageBox.Show("Hay registros sin completar")
                Exit Sub
            End If
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Select Case gv_motivo
                    Case "A"
                        If insertar_detalles_en_planilla() = True Then
                            MessageBox.Show("Planilla Actualizada Éxitosamente")
                            grp_planilla.Enabled = False
                            grp_cabecera.Enabled = True
                            cmb_anios.SelectedIndex = -1
                            lsv_materias.Items.Clear()
                            btn_modificar.Enabled = False
                            btn_eliminar.Enabled = False
                            btn_registrar_asistencias.Enabled = False
                            lsv_planilla.Clear()
                        End If
                    Case "M"
                        If eliminar_clase_planilla_detalle(gv_nro_clase) Then
                            If insertar_detalles_en_planilla() = True Then
                                MessageBox.Show("Planilla Actualizada Éxitosamente")
                                grp_planilla.Enabled = False
                                grp_cabecera.Enabled = True
                                cmb_anios.SelectedIndex = -1
                                lsv_materias.Items.Clear()
                                btn_modificar.Enabled = False
                                btn_eliminar.Enabled = False
                                btn_registrar_asistencias.Enabled = False
                                lsv_planilla.Clear()
                            End If
                        End If

                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_casilleros_vacios() As Boolean
        Dim i As Int16
        Try
            For i = 0 To CShort(lsv_planilla.Items.Count - 1)
                If lsv_planilla.Items(i).SubItems(gv_nro_clase + 1).Text = "" Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Function insertar_detalles_en_planilla() As Boolean
        Dim tran As SqlTransaction
        Dim i As Int16
        Dim con1 As New SqlConnection(ruta)
        Dim com1 As New SqlCommand

        Try
            com1.Connection = con1
            con1.Open()
            tran = con1.BeginTransaction
            com1.Transaction = tran
            com1.CommandType = CommandType.StoredProcedure
            If lsv_planilla.Items.Count > 0 Then
                com1.CommandText = "insertar_detalles_en_planilla"
                For i = 0 To CShort(lsv_planilla.Items.Count - 1)
                    com1.Parameters.Clear()
                    com1.Parameters.AddWithValue("@nro", lbl_nroplanilla.Text)
                    com1.Parameters.AddWithValue("@cla", gv_nro_clase)
                    com1.Parameters.AddWithValue("@fec", CDate(lsv_planilla.Columns(gv_nro_clase + 2).Text))
                    com1.Parameters.AddWithValue("@alu", lsv_planilla.Items(i).SubItems(0).Text)
                    com1.Parameters.AddWithValue("@anio", lsv_planilla.Items(i).SubItems(1).Text)
                    com1.Parameters.AddWithValue("@est", lsv_planilla.Items(i).SubItems(gv_nro_clase + 2).Text)
                    com1.ExecuteNonQuery()
                Next
            End If
            tran.Commit()
            con1.Close()
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

    Private Sub cmb_anios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_anios.SelectedIndexChanged
        Try
            lsv_planilla.Clear()
            lsv_materias.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_volver_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver_atras.Click
        Try
            grp_planilla.Enabled = False
            grp_cabecera.Enabled = True
            grp_fecha.Enabled = False
            grp_nro_clase.Enabled = False
            cmb_anios.SelectedIndex = -1
            lsv_materias.Items.Clear()
            lsv_planilla.Clear()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_presente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_presente.Click
        Try
            If lsv_planilla.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione registros de la planilla")
                Exit Sub
            End If
            agregar_estado("P")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_ausente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ausente.Click
        Try
            If lsv_planilla.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione registros de la planilla")
                Exit Sub
            End If
            agregar_estado("A")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_tarde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tarde.Click
        Try
            If lsv_planilla.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione registros de la planilla")
                Exit Sub
            End If
            agregar_estado("T")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_tarde_con_aviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tarde_con_aviso.Click
        Try
            If lsv_planilla.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione registros de la planilla")
                Exit Sub
            End If
            agregar_estado("V")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub agregar_estado(ByVal estado As String)
        Dim i As Int16
        Try
            For i = 0 To CShort(lsv_planilla.SelectedItems.Count - 1)
                If lsv_planilla.SelectedItems(i).SubItems(gv_nro_clase + 2).Text <> "B" Then
                    lsv_planilla.SelectedItems(i).SubItems(gv_nro_clase + 2).Text = estado
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            grp_planilla.Enabled = False
            grp_cabecera.Enabled = True
            grp_fecha.Enabled = False
            grp_nro_clase.Enabled = False
            cmb_anios.SelectedIndex = -1
            lsv_materias.Items.Clear()
            lsv_planilla.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class