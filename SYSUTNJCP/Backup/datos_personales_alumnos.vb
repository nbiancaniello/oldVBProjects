Imports System.Data.SqlClient
Public Class datospersonales_alumnos
    Dim gv_legajo_anterior As Int16
    Dim gv_nro_documento_ant As Int32
    Private Sub datospersonales_alumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If gv_carrera = 0 Then
                txt_nro_legajo.Enabled = False
                lbl_nro_legajo.Enabled = False
            End If
            Me.Text = "Datos Personales de Alumnos - " & gv_nombre_sistema
            limpiar_cajas_dp_alumnos()
            traer_nombre_apellido(lsv_alumnos_inscriptos, 1)
            asignar_set_de_datos(cmb_localidad, 1)
            asignar_set_de_datos(cmb_tipo_documento, 2)
            asignar_set_de_datos(cmb_nacionalidad, 3)
            asignar_set_de_datos(cmb_estado_civil, 4)
            asignar_set_de_datos(cmb_lugar_nac, 5)
            asignar_set_de_datos(cmb_titulo_secundario, 6)
            asignar_set_de_datos(cmb_carrera, 11)
            dtp_fecha_nac.MaxDate = Now.Date
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If lsv_alumnos_inscriptos.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe elegir un registro de la lista")
                lsv_alumnos_inscriptos.Focus()
                Exit Sub
            End If
            grp_datos_personales.Enabled = True
            grp_detalles.Enabled = True
            btn_aceptar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub traer_alumnos_seleccionados()
        Dim dr As SqlDataReader

        Try
            limpiar_cajas_dp_alumnos()
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_datos_personales_alumno"
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                txt_nombre.Text = dr.GetString(0)
                txt_apellido.Text = dr.GetString(1)
                If Not dr.IsDBNull(2) Then
                    txt_nro_legajo.Text = dr.GetInt16(2).ToString
                    gv_legajo_anterior = CShort(txt_nro_legajo.Text)
                End If
                txt_domicilio.Text = dr.GetString(3)
                cmb_localidad.SelectedValue = dr.GetInt16(4)
                dtp_fecha_nac.Value = dr.GetDateTime(5)
                Select Case dr.GetString(6)
                    Case "F" : rdb_femenino.Checked = True
                    Case "M" : rdb_masculino.Checked = True
                End Select
                cmb_tipo_documento.SelectedValue = dr.GetByte(7)
                txt_nro_documento.Text = dr.GetInt32(8).ToString
                gv_nro_documento_ant = dr.GetInt32(8)
                cmb_nacionalidad.SelectedValue = dr.GetByte(9)
                If Not dr.IsDBNull(10) Then
                    txt_telefono.Text = dr.GetString(10)
                End If
                If Not dr.IsDBNull(11) Then
                    txt_celular.Text = dr.GetString(11)
                End If
                If Not dr.IsDBNull(12) Then
                    txt_email.Text = dr.GetString(12)
                End If
                cmb_carrera.SelectedValue = dr.GetByte(13)
                Select Case dr.GetBoolean(15)
                    Case CBool(0)
                        lbl_status.Text = "No activo"
                        btn_reincorporar.Enabled = True
                    Case CBool(1)
                        lbl_status.Text = "Activo"
                        btn_reincorporar.Enabled = False
                End Select
            End While
            dr.Close()
            com.CommandText = "traer_datos_personales_detalles_alumno"
            dr = com.ExecuteReader
            While dr.Read
                cmb_lugar_nac.SelectedValue = dr.GetByte(0)
                cmb_titulo_secundario.SelectedValue = dr.GetByte(1)
                If Not dr.IsDBNull(2) Then
                    txt_nombre_colegio.Text = dr.GetString(2)
                End If
                cmb_estado_civil.SelectedValue = dr.GetByte(3)
                Select Case dr.GetBoolean(4)
                    Case CBool(0) : rdb_hijos_no.Checked = True
                    Case CBool(1) : rdb_hijos_si.Checked = True
                End Select
                txt_cantidad.Text = dr.GetByte(5).ToString
                Select Case dr.GetBoolean(6)
                    Case CBool(0) : rdb_no.Checked = True
                    Case CBool(1) : rdb_si.Checked = True
                End Select
                If Not dr.IsDBNull(7) Then
                    cmb_carga_horaria.SelectedIndex = dr.GetByte(7)
                End If
                If Not dr.IsDBNull(8) Then
                    cmb_relacion_trabajo.SelectedIndex = dr.GetByte(8)
                End If
            End While
            dr.Close()

            com.CommandText = "traer_conocimientos_alumnos"
            dr = com.ExecuteReader
            While dr.Read
                chk_opcion1.Checked = dr.GetBoolean(0)
                chk_opcion2.Checked = dr.GetBoolean(1)
                chk_opcion3.Checked = dr.GetBoolean(2)
                chk_opcion4.Checked = dr.GetBoolean(3)
                chk_opcion5.Checked = dr.GetBoolean(4)
                chk_opcion6.Checked = dr.GetBoolean(5)
                chk_opcion7.Checked = dr.GetBoolean(6)
                If Not dr.IsDBNull(7) Then
                    chk_opcion8.Checked = True
                    txt_otro.Text = dr.GetString(7)
                Else
                    chk_opcion8.Checked = False
                End If
            End While
            dr.Close()

            com.CommandText = "traer_documentaciones"
            dr = com.ExecuteReader
            While dr.Read
                chk_fot_dni.Checked = dr.GetBoolean(0)
                chk_fot_titulo.Checked = dr.GetBoolean(1)
                chk_foto.Checked = dr.GetBoolean(2)
            End While
            dr.Close()

            If lbl_status.Text = "No activo" Then
                com.CommandText = "traer_motivo_baja_alumno"
                dr = com.ExecuteReader
                While dr.Read
                    txt_motivo.Text = dr.GetString(0)
                End While
                dr.Close()
                com.CommandText = "traer_items_motivo_baja_alumno"
                dr = com.ExecuteReader
                While dr.Read
                    Select Case dr.GetByte(0)
                        Case 1 : cbx_motivo1.Checked = True
                        Case 2 : cbx_motivo2.Checked = True
                        Case 3 : cbx_motivo3.Checked = True
                        Case 4 : cbx_motivo4.Checked = True
                        Case 5 : cbx_motivo5.Checked = True
                    End Select
                End While
                dr.Close()
            End If

            If txt_nro_legajo.Enabled Then
                If verificar_etapa_aprobada(lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text, lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text, 1) Then
                    txt_nro_legajo.Enabled = True
                End If
            End If
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
            btn_aceptar.Enabled = False
            grp_alumnos_inscriptos.Enabled = True
            grp_detalles.Enabled = False
            grp_datos_personales.Enabled = False
            limpiar_cajas_dp_alumnos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If lsv_alumnos_inscriptos.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe elegir un registro de la lista")
                lsv_alumnos_inscriptos.Focus()
                Exit Sub
            End If
            If verificar_datos_personales_alumnos_vacío() Then
                If verificar_datos_personales_alumnos_tipos() Then
                    If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If actualizar_datos_personales_alumno() Then
                            MessageBox.Show("Alumno modificado exitósamente")
                            traer_alumnos_seleccionados()
                            grp_dp_baja.Enabled = False
                            lsv_alumnos_inscriptos.Focus()
                            Exit Sub
                        End If
                    Else
                        txt_nro_legajo.Focus()
                    End If
                End If
                Exit Sub
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function verificar_datos_personales_alumnos_vacío() As Boolean
        Try
            If txt_nombre.Text = "" Then
                MessageBox.Show("El nombre no puede estar vacío")
                txt_nombre.Focus()
                Return False
            End If
            If txt_apellido.Text = "" Then
                MessageBox.Show("El apellido no puede estar vacío")
                txt_apellido.Focus()
                Return False
            End If
            If txt_domicilio.Text = "" Then
                MessageBox.Show("El domicilio no puede estar vacío")
                txt_domicilio.Focus()
                Return False
            End If
            If txt_nro_documento.Text = "" Then
                MessageBox.Show("El nº de documento no puede estar vacío")
                txt_nro_documento.Focus()
                Return False
            End If
            If cmb_nacionalidad.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Nacionalidad")
                cmb_nacionalidad.Focus()
                Return False
            End If
            If cmb_localidad.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Localidad")
                cmb_localidad.Focus()
                Return False
            End If
            If cmb_tipo_documento.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Tipo de Documento")
                cmb_tipo_documento.Focus()
                Return False
            End If
            If cmb_lugar_nac.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Lugar de Nacimiento")
                cmb_lugar_nac.Focus()
                Return False
            End If
            If cmb_titulo_secundario.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Título Secundario")
                cmb_titulo_secundario.Focus()
                Return False
            End If
            If cmb_estado_civil.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Estado Civil")
                cmb_estado_civil.Focus()
                Return False
            End If
            If rdb_si.Checked Then
                If cmb_carga_horaria.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione Carga Horaria")
                    cmb_carga_horaria.Focus()
                    Return False
                End If
                If cmb_relacion_trabajo.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione Relación de Trabajo")
                    cmb_relacion_trabajo.Focus()
                    Return False
                End If
            End If
            If rdb_hijos_si.Checked Then
                If txt_cantidad.Text = "" Then
                    MessageBox.Show("Ingrese la cantidad de hijos")
                    txt_cantidad.Focus()
                    Return False
                End If
            End If
            If txt_nro_legajo.Text = "" And txt_nro_legajo.Enabled = True Then
                MessageBox.Show("El legajo no puede estar vacío")
                txt_nro_legajo.Focus()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function verificar_datos_personales_alumnos_tipos() As Boolean
        Try
            If txt_nro_legajo.Text <> "" Then
                If CShort(txt_nro_legajo.Text) <> gv_legajo_anterior Then
                    If Not verificar_numeros(txt_nro_legajo.Text, 3) Then
                        MessageBox.Show("El legajo ingresado es incorrecto")
                        txt_nro_legajo.Focus()
                        Return False
                    End If
                    If CInt(txt_nro_legajo.Text) > 32000 Then
                        MessageBox.Show("El legajo ingresado es incorrecto")
                        txt_nro_legajo.Focus()
                        Return False
                    End If
                    If buscar_legajo(txt_nro_legajo.Text) Then
                        MessageBox.Show("El legajo ingresado ya está registrado")
                        txt_nro_legajo.Focus()
                        Return False
                    End If
                End If
            End If
            If Not verificar_cadena(txt_nombre.Text) Then
                MessageBox.Show("El nombre ingresado es incorrecto")
                txt_nombre.Focus()
                Return False
            End If
            If Not verificar_cadena(txt_apellido.Text) Then
                MessageBox.Show("El apellido ingresado es incorrecto")
                txt_apellido.Focus()
                Return False
            End If
            If dtp_fecha_nac.Value.Year >= Now.Year - 17 Then
                MessageBox.Show("El alumno debe tener 17 años o más")
                dtp_fecha_nac.Focus()
                Return False
            End If
            If Not verificar_numeros(txt_nro_documento.Text, 1) Then
                MessageBox.Show("El nº de documento ingresado es incorrecto")
                txt_nro_documento.Focus()
                Return False
            End If
            If CInt(txt_nro_documento.Text) = 0 Then
                MessageBox.Show("El nº de documento no puede ser 0")
                txt_nro_documento.Focus()
                Return False
            End If
            If CInt(txt_nro_documento.Text) < 1000000 Or CInt(txt_nro_documento.Text) > 99999999 Then
                MessageBox.Show("El nº de documento ingresado es incorrecto")
                txt_nro_documento.Focus()
                Return False
            End If
            If gv_nro_documento_ant <> CInt(txt_nro_documento.Text) Then
                If Not verificar_documentorepetido(1, CInt(txt_nro_documento.Text), CByte(cmb_tipo_documento.SelectedValue)) Then
                    MessageBox.Show("El nº de documento ingresado ya está registrado")
                    txt_nro_documento.Focus()
                    Return False
                End If
            End If
            If txt_telefono.Text <> "" Then
                If Not verificar_numeros(txt_telefono.Text, 2) Then
                    MessageBox.Show("El telefono ingresado es incorrecto")
                    txt_telefono.Focus()
                    Return False
                End If
            End If
            If txt_celular.Text <> "" Then
                If Not verificar_numeros(txt_celular.Text, 2) Then
                    MessageBox.Show("El celular ingresado es incorrecto")
                    txt_celular.Focus()
                    Return False
                End If
            End If
            If txt_email.Text.Trim <> "" Then
                If Not verificar_mail(txt_email.Text) Then
                    MessageBox.Show("El mail ingresado es incorrecto")
                    txt_email.Focus()
                    Return False
                End If
            End If
            If rdb_hijos_si.Checked Then
                If Not verificar_numeros(txt_cantidad.Text, 3) Then
                    MessageBox.Show("La cantidad de hijos es ingresada incorrecta")
                    txt_cantidad.Focus()
                    Return False
                End If
                If CInt(txt_cantidad.Text) <= 0 Or CInt(txt_cantidad.Text) >= 16 Then
                    MessageBox.Show("El nº permitido de hijos es de 1-15")
                    txt_nro_documento.Focus()
                    Return False
                End If
            Else
                txt_cantidad.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function actualizar_datos_personales_alumno() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            If txt_nro_legajo.Text = "" Then
                txt_nro_legajo.Text = "0"
            End If

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "actualizar_datos_personales_alumno_introductorio"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.Parameters.AddWithValue("@leg", txt_nro_legajo.Text)
            com.Parameters.AddWithValue("@nom", txt_nombre.Text.ToUpper)
            com.Parameters.AddWithValue("@ape", txt_apellido.Text.ToUpper)
            com.Parameters.AddWithValue("@dom", txt_domicilio.Text.ToUpper)
            com.Parameters.AddWithValue("@cp", cmb_localidad.SelectedValue)
            com.Parameters.AddWithValue("@fec", dtp_fecha_nac.Value)
            If rdb_femenino.Checked Then
                com.Parameters.AddWithValue("@sexo", "F")
            Else
                com.Parameters.AddWithValue("@sexo", "M")
            End If
            com.Parameters.AddWithValue("@tip", cmb_tipo_documento.SelectedValue)
            com.Parameters.AddWithValue("@doc", txt_nro_documento.Text.ToUpper)
            com.Parameters.AddWithValue("@nac", cmb_nacionalidad.SelectedValue)
            com.Parameters.AddWithValue("@tel", txt_telefono.Text)
            com.Parameters.AddWithValue("@cel", txt_celular.Text)
            com.Parameters.AddWithValue("@mail", txt_email.Text)
            com.Parameters.AddWithValue("@lug", cmb_lugar_nac.SelectedValue)
            com.Parameters.AddWithValue("@tit", cmb_titulo_secundario.SelectedValue)
            com.Parameters.AddWithValue("@col", txt_nombre_colegio.Text.ToUpper)
            com.Parameters.AddWithValue("@civ", cmb_estado_civil.SelectedValue)
            com.Parameters.AddWithValue("@hij", rdb_hijos_si.Checked)
            com.Parameters.AddWithValue("@cth", txt_cantidad.Text)
            If rdb_si.Checked Then
                com.Parameters.AddWithValue("@tra", 1)
                com.Parameters.AddWithValue("@car", cmb_carga_horaria.SelectedIndex)
                com.Parameters.AddWithValue("@rel", cmb_relacion_trabajo.SelectedIndex)
            Else
                com.Parameters.AddWithValue("@tra", 0)
                com.Parameters.AddWithValue("@car", DBNull.Value)
                com.Parameters.AddWithValue("@rel", DBNull.Value)
            End If
            com.Parameters.AddWithValue("@carr", gv_carrera)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()

            com.CommandType = CommandType.Text
            com.CommandText = "DELETE FROM conocimientos_alumnos WHERE nroinscripcion = " & _
                               lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text & " AND anioingreso = " & _
                               lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text
            com.ExecuteNonQuery()
            If chk_opcion8.Checked = False Then
                txt_otro.Clear()
            End If
            com.CommandType = CommandType.Text
            com.CommandText = "INSERT INTO conocimientos_alumnos VALUES(" & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text _
                           & "," & Now.Year.ToString & "," & CByte(chk_opcion1.Checked) _
                           & "," & CByte(chk_opcion2.Checked) & "," & CByte(chk_opcion3.Checked) & "," & CByte(chk_opcion4.Checked) _
                           & "," & CByte(chk_opcion5.Checked) & "," & CByte(chk_opcion6.Checked) & "," & CByte(chk_opcion7.Checked) _
                           & ",'" & txt_otro.Text & "')"
            com.ExecuteNonQuery()

            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "almacenar_documentaciones"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", Now.Year)
            com.Parameters.AddWithValue("@doc1", CByte(chk_fot_dni.Checked))
            com.Parameters.AddWithValue("@doc2", CByte(chk_fot_titulo.Checked))
            com.Parameters.AddWithValue("@doc3", CByte(chk_foto.Checked))
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
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

    Public Sub limpiar_cajas_dp_alumnos()
        Try
            lbl_anio_insc.Text = ""
            txt_apellido.Clear()
            txt_celular.Clear()
            txt_domicilio.Clear()
            txt_email.Clear()
            txt_nombre.Clear()
            txt_nombre_colegio.Clear()
            txt_nro_documento.Clear()
            txt_nro_legajo.Clear()
            txt_telefono.Clear()
            cmb_carga_horaria.SelectedIndex = -1
            cmb_estado_civil.SelectedIndex = -1
            cmb_localidad.SelectedIndex = -1
            cmb_lugar_nac.SelectedIndex = -1
            cmb_nacionalidad.SelectedIndex = -1
            cmb_relacion_trabajo.SelectedIndex = -1
            cmb_tipo_documento.SelectedIndex = -1
            cmb_titulo_secundario.SelectedIndex = -1
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

    Private Sub txt_nro_legajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nro_legajo.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "'" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_nro_documento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nro_documento.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = "-" Or e.KeyChar = "(" Or e.KeyChar = ")" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_celular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_celular.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = "-" Or e.KeyChar = "(" Or e.KeyChar = ")" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_otros_estudios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_idiomas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rdb_no.Checked Then
            cmb_carga_horaria.Enabled = False
            cmb_relacion_trabajo.Enabled = False
        End If
    End Sub

    Private Sub rdb_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rdb_si.Checked Then
            cmb_carga_horaria.Enabled = True
            cmb_relacion_trabajo.Enabled = True
        End If
    End Sub

    Private Sub cmb_localidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_localidad.SelectedIndexChanged
        Try
            If cmb_localidad.SelectedIndex = -1 Then
                cmb_nacionalidad.Enabled = False
            Else
                cmb_nacionalidad.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmb_tipo_documento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo_documento.SelectedIndexChanged
        Try
            If cmb_tipo_documento.SelectedIndex = -1 Then
                txt_nro_documento.Enabled = False
            Else
                txt_nro_documento.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_mantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mantenimiento.Click
        solapa_abm.ShowDialog()
    End Sub

    Private Sub lsv_alumnos_inscriptos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_alumnos_inscriptos.KeyDown
        Try
            lbl_anio_insc.Text = lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text
            txt_nro_legajo.Focus()
            traer_alumnos_seleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_alumnos_inscriptos.KeyUp
        Try
            lbl_anio_insc.Text = lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text
            txt_nro_legajo.Focus()
            traer_alumnos_seleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_alumnos_inscriptos.MouseClick
        Try
            lbl_anio_insc.Text = lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text
            txt_nro_legajo.Focus()
            traer_alumnos_seleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_hijos_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_hijos_si.CheckedChanged
        Try
            txt_cantidad.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_hijos_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_hijos_no.CheckedChanged
        Try
            txt_cantidad.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
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

    Private Sub chk_opcion8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_opcion8.CheckedChanged
        Try
            If chk_opcion8.Checked Then
                txt_otro.Enabled = True
            Else
                txt_otro.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_si_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_si.CheckedChanged
        Try
            If rdb_si.Checked Then
                cmb_carga_horaria.Enabled = True
                cmb_relacion_trabajo.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_no_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_no.CheckedChanged
        Try
            If rdb_no.Checked Then
                cmb_carga_horaria.Enabled = False
                cmb_relacion_trabajo.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_reincorporar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reincorporar.Click
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If reincorporar_alumno Then
                    MessageBox.Show("Alumno reincorporado exitósamente")
                    traer_alumnos_seleccionados()
                    grp_alumnos_inscriptos.Enabled = True
                    grp_datos_personales.Enabled = False
                    grp_detalles.Enabled = False
                    grp_dp_baja.Enabled = False
                    lsv_alumnos_inscriptos.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function reincorporar_alumno() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim tran As SqlTransaction
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "reincorporar_alumno"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            com.Dispose()
            con.Dispose()
        End Try
        Return True
    End Function
End Class