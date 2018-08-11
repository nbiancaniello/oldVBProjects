Imports System.Data.SqlClient
Public Class altas_alumnos

    Private Sub altas_alumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Alta de Alumnos - " & gv_nombre_sistema
            txt_nombre.Focus()
            limpiar_cajas_alta_alumnos()
            txt_nro_inscripcion.Text = traer_ultimo_nro_inscripcion()
            asignar_set_de_datos(cmb_localidad, 1)
            asignar_set_de_datos(cmb_tipo_documento, 2)
            asignar_set_de_datos(cmb_nacionalidad, 3)
            asignar_set_de_datos(cmb_estado_civil, 4)
            asignar_set_de_datos(cmb_lugar_nac, 5)
            asignar_set_de_datos(cmb_titulo_secundario, 6)
            traer_instancias_a_control(cmb_instancia)
            'dtp_fecha_nac.Value = DateAdd(DateInterval.Year.ToString, -17, Now.year)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function traer_ultimo_nro_inscripcion() As String
        Dim dr As SqlDataReader
        Dim nro_inscripcion As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_ultimo_nro_inscripcion"
            com.Parameters.AddWithValue("@anio", Now.Year)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If dr.IsDBNull(0) Then
                        nro_inscripcion = 1
                    Else
                        nro_inscripcion = CShort(dr.GetInt32(0))
                    End If
                End While
                dr.Close()
                con.Close()
                Return CStr(nro_inscripcion)
            Else
                dr.Close()
                con.Close()
                Return CStr(1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return CStr(0)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

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

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_celular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Public Function verificar_datos_personales_alumnos_vacío() As Boolean
        Try
            If cmb_instancia.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Instancia")
                cmb_instancia.Focus()
                Return False
            End If
            If txt_nombre.Text.Trim = "" Then
                MessageBox.Show("El nombre no puede estar vacío")
                txt_nombre.Focus()
                Return False
            End If
            If txt_apellido.Text.Trim = "" Then
                MessageBox.Show("El apellido no puede estar vacío")
                txt_apellido.Focus()
                Return False
            End If
            If txt_domicilio.Text.Trim = "" Then
                MessageBox.Show("El domicilio no puede estar vacío")
                txt_domicilio.Focus()
                Return False
            End If
            If txt_nro_documento.Text.Trim = "" Then
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function verificar_datos_personales_alumnos_tipos() As Boolean
        Try
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
            If Not verificar_numeros(txt_nro_documento.Text, 3) Then
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
            If Not verificar_documentorepetido(1, CInt(txt_nro_documento.Text), CByte(cmb_tipo_documento.SelectedValue)) Then
                MessageBox.Show("El nº de documento ingresado ya está registrado")
                txt_nro_documento.Focus()
                Return False
            End If
            If txt_telefono.Text.Trim <> "" Then
                If Not verificar_numeros(txt_telefono.Text, 2) Then
                    MessageBox.Show("El telefono ingresado es incorrecto")
                    txt_telefono.Focus()
                    Return False
                End If
            End If
            If txt_celular.Text.Trim <> "" Then
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

    Public Function registrar_alumno() As Boolean
        Dim tran As SqlTransaction

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "registrar_alumno"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", txt_nro_inscripcion.Text)
            com.Parameters.AddWithValue("@anio", Now.Year)
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
            If rdb_hijos_no.Checked Then
                com.Parameters.AddWithValue("@hij", 0)
            Else
                com.Parameters.AddWithValue("@hij", 1)
            End If
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
            com.Parameters.AddWithValue("@eta", devolver_numero_mes(cmb_instancia.SelectedText))
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()

            com.CommandText = "asignar_introductorio"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", txt_nro_inscripcion.Text)
            com.Parameters.AddWithValue("@ing", Now.Year)

            com.Parameters.AddWithValue("@anio", Now.Year)
            com.Parameters.AddWithValue("@eta", cmb_instancia.SelectedIndex + 1)
            com.Parameters.AddWithValue("@est", "D")
            com.ExecuteNonQuery()

            If chk_opcion8.Checked = False Then
                txt_otro.Clear()
            End If
            com.CommandType = CommandType.Text
            com.CommandText = "INSERT INTO conocimientos_alumnos VALUES(" & txt_nro_inscripcion.Text _
                           & "," & Now.Year.ToString & "," & CByte(chk_opcion1.Checked) _
                           & "," & CByte(chk_opcion2.Checked) & "," & CByte(chk_opcion3.Checked) & "," & CByte(chk_opcion4.Checked) _
                           & "," & CByte(chk_opcion5.Checked) & "," & CByte(chk_opcion6.Checked) & "," & CByte(chk_opcion7.Checked) _
                           & ",'" & txt_otro.Text & "')"
            com.ExecuteNonQuery()

            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "almacenar_documentaciones"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", txt_nro_inscripcion.Text)
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

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub limpiar_cajas_alta_alumnos()
        Try
            txt_apellido.Clear()
            txt_celular.Clear()
            txt_domicilio.Clear()
            txt_email.Clear()
            txt_nombre.Clear()
            txt_nombre_colegio.Clear()
            txt_nro_documento.Clear()
            txt_nro_inscripcion.Clear()
            txt_telefono.Clear()
            txt_cantidad.Clear()
            rdb_hijos_no.Checked = True
            cmb_carga_horaria.SelectedIndex = -1
            cmb_estado_civil.SelectedIndex = -1
            cmb_localidad.SelectedIndex = -1
            cmb_lugar_nac.SelectedIndex = -1
            cmb_nacionalidad.SelectedIndex = -1
            cmb_relacion_trabajo.SelectedIndex = -1
            cmb_tipo_documento.SelectedIndex = -1
            cmb_titulo_secundario.SelectedIndex = -1
            chk_opcion1.Checked = False
            chk_opcion2.Checked = False
            chk_opcion3.Checked = False
            chk_opcion4.Checked = False
            chk_opcion5.Checked = False
            chk_opcion6.Checked = False
            chk_opcion7.Checked = False
            chk_opcion8.Checked = False
            txt_otro.Clear()
            chk_fot_dni.Checked = False
            chk_fot_titulo.Checked = False
            chk_foto.Checked = False
            rdb_no.Checked = True
            cmb_instancia.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_si.CheckedChanged
        Try
            If rdb_si.Checked Then
                cmb_carga_horaria.Enabled = True
                cmb_relacion_trabajo.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rdb_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_no.CheckedChanged
        Try
            If rdb_no.Checked Then
                cmb_carga_horaria.Enabled = False
                cmb_relacion_trabajo.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If verificar_datos_personales_alumnos_vacío() Then
                If verificar_datos_personales_alumnos_tipos() Then
                    If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If registrar_alumno() Then
                            MessageBox.Show("Alumno registrado exitósamente")
                            limpiar_cajas_alta_alumnos()
                            Exit Sub
                        End If
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

    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            If MessageBox.Show("¿Desea Salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                limpiar_cajas_alta_alumnos()
                Me.Close()
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

    Private Sub btn_mantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mantenimiento.Click
        solapa_abm.ShowDialog()
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
End Class