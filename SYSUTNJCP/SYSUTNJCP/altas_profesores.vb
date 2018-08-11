Imports System.Data.SqlClient
Public Class altas_profesores

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub altas_profesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Alta de Profesores/Ayudantes - " & gv_nombre_sistema
            asignar_set_de_datos(cmb_localidad, 1)
            asignar_set_de_datos(cmb_tipo_documento, 2)
            asignar_set_de_datos(cmb_nacionalidad, 3)
            asignar_set_de_datos(cmb_titulo, 6)
            limpiar_cajas_profesores()
            dtp_fecha_nac.MaxDate = Now.Date
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If verificar_datos_personales_docentes_vacío() Then
                If verificar_datos_personales_docentes_tipos() Then
                    If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If registrar_docente() Then
                            Select Case cmb_tipo_docente.SelectedIndex
                                Case 0 : MessageBox.Show("Profesor registrado exitósamente")
                                Case 1 : MessageBox.Show("Ayudante registrado exitósamente")
                            End Select
                            limpiar_cajas_profesores()
                        End If
                    Else
                        limpiar_cajas_profesores()
                        txt_nombre.Focus()
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

    Public Function verificar_datos_personales_docentes_vacío() As Boolean
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
            If cmb_localidad.SelectedIndex = -1 Then
                MessageBox.Show("El Debe Elegir una localidad")
                cmb_localidad.Focus()
                Return False
            End If
            If cmb_nacionalidad.SelectedIndex = -1 Then
                MessageBox.Show("El Debe Elegir una nacionalidad")
                cmb_nacionalidad.Focus()
                Return False
            End If
            If cmb_tipo_docente.SelectedIndex = -1 Then
                MessageBox.Show("El Debe Elegir el tipo de Docente")
                cmb_tipo_docente.Focus()
                Return False
            End If
            If cmb_titulo.SelectedIndex = -1 Then
                MessageBox.Show("El Debe Elegir un título")
                cmb_titulo.Focus()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function verificar_datos_personales_docentes_tipos() As Boolean
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
                MessageBox.Show("El profesor debe tener 17 años o más")
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
            If Not verificar_documentorepetido(2, CInt(txt_nro_documento.Text), CByte(cmb_tipo_documento.SelectedValue)) Then
                MessageBox.Show("El nº de documento ingresado ya está registrado")
                txt_nro_documento.Focus()
                Return False
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function registrar_docente() As Boolean
        Dim con1 As New SqlConnection(ruta)
        Dim com1 As New SqlCommand
        Dim tran As SqlTransaction
        Try

            com1.Connection = con1
            com1.CommandType = CommandType.StoredProcedure
            com1.CommandText = "registrar_profesor"
            com1.Parameters.Clear()
            com1.Parameters.AddWithValue("@nro", traer_ultimo_codigo)
            com1.Parameters.AddWithValue("@nom", txt_nombre.Text.ToUpper)
            com1.Parameters.AddWithValue("@ape", txt_apellido.Text.ToUpper)
            com1.Parameters.AddWithValue("@dom", txt_domicilio.Text.ToUpper)
            com1.Parameters.AddWithValue("@cp", cmb_localidad.SelectedValue)
            com1.Parameters.AddWithValue("@fec", dtp_fecha_nac.Value)
            If rdb_femenino.Checked Then
                com1.Parameters.AddWithValue("@sexo", "F")
            Else
                com1.Parameters.AddWithValue("@sexo", "M")
            End If
            com1.Parameters.AddWithValue("@tip", cmb_tipo_documento.SelectedValue)
            com1.Parameters.AddWithValue("@doc", txt_nro_documento.Text.ToUpper)
            com1.Parameters.AddWithValue("@nac", cmb_nacionalidad.SelectedValue)
            com1.Parameters.AddWithValue("@tel", txt_telefono.Text)
            com1.Parameters.AddWithValue("@cel", txt_celular.Text)
            com1.Parameters.AddWithValue("@mail", txt_email.Text)
            com1.Parameters.AddWithValue("@tit", cmb_titulo.SelectedValue)
            If cmb_tipo_docente.SelectedIndex = 0 Then
                com1.Parameters.AddWithValue("@tipo", "P")
            Else
                com1.Parameters.AddWithValue("@tipo", "A")
            End If
            con1.Open()
            tran = con1.BeginTransaction
            com1.Transaction = tran
            com1.ExecuteNonQuery()

            tran.Commit()
            con1.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con1.Dispose()
            com1.Dispose()
        End Try
        Return True
    End Function

    Private Function traer_ultimo_codigo() As Int16
        Dim dr As SqlDataReader
        Dim codigo As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_ultimo_codigo_profesor"
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                codigo = CShort(dr.GetInt32(0))
            End While
            dr.Close()
            con.Close()
            Return codigo
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Sub limpiar_cajas_profesores()
        Try
            txt_apellido.Clear()
            txt_celular.Clear()
            txt_domicilio.Clear()
            txt_email.Clear()
            txt_nombre.Clear()
            txt_nro_documento.Clear()
            txt_telefono.Clear()
            cmb_localidad.SelectedIndex = -1
            cmb_nacionalidad.SelectedIndex = -1
            cmb_tipo_documento.SelectedIndex = -1
            cmb_titulo.SelectedIndex = -1
            cmb_tipo_docente.SelectedIndex = -1
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

    Private Sub cmb_localidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_localidad.SelectedIndexChanged
        Try
            If cmb_localidad.SelectedIndex <> -1 Then
                cmb_nacionalidad.Enabled = True
            Else
                cmb_nacionalidad.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmb_tipo_documento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo_documento.SelectedIndexChanged
        Try
            If cmb_tipo_documento.SelectedIndex <> -1 Then
                txt_nro_documento.Enabled = True
            Else
                txt_nro_documento.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btn_mantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mantenimiento.Click
        solapa_abm.ShowDialog()
    End Sub

End Class