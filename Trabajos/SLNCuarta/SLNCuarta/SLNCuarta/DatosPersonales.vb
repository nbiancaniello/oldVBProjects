Imports System.Data.SqlClient
Public Class DatosPersonales
    Dim sexo As Char

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub DatosPersonales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fecha_nacimiento.MaxDate = Now.Date
        If Accion = eAccion.Agregar Then
            txt_legajo.Clear()
            txt_legajo.Enabled = True
            txt_nombre.Clear()
            txt_telefono.Clear()
            txt_celular.Clear()
            txt_email.Clear()
            rdb_femenino.Checked = False
            rdb_masculino.Checked = False
            dtp_fecha_nacimiento.Value = Now.Date
        Else
            txt_legajo.Text = BaseDeDatos.lv_datos.SelectedItems(0).Text
            txt_legajo.Enabled = False
            txt_nombre.Text = BaseDeDatos.lv_datos.SelectedItems(0).SubItems(1).Text
            txt_telefono.Text = BaseDeDatos.lv_datos.SelectedItems(0).SubItems(2).Text
            txt_celular.Text = BaseDeDatos.lv_datos.SelectedItems(0).SubItems(4).Text
            txt_email.Text = BaseDeDatos.lv_datos.SelectedItems(0).SubItems(3).Text
            dtp_fecha_nacimiento.Value = CDate(BaseDeDatos.lv_datos.SelectedItems(0).SubItems(5).Text)
            If BaseDeDatos.lv_datos.SelectedItems(0).SubItems(6).Text = "M" Then
                rdb_masculino.Checked = True
            Else
                rdb_femenino.Checked = True
            End If
        End If
    End Sub

    Private Sub txt_legajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles msk_legajo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "-" Or e.KeyChar = "(" Or e.KeyChar = ")" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_celular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_celular.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_email.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) = True Then
            e.Handled = True
        Else
            If txt_email.Text.Contains("@") Then
                If e.KeyChar = "@" Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim conexion As New SqlConnection
        Dim comando As New SqlCommand

        Try
            If validaciones() = False Then
                Exit Sub
            End If
            conexion.ConnectionString = Ruta
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            If Accion = eAccion.Agregar Then
                comando.CommandText = "AgregarPersona"
                comando.Parameters.AddWithValue("@legajo", Convert.ToInt16(txt_legajo.Text))
                comando.Parameters.AddWithValue("@nombre", txt_nombre.Text)
                comando.Parameters.AddWithValue("@telefono", txt_telefono.Text)
                comando.Parameters.AddWithValue("@celular", txt_celular.Text)
                comando.Parameters.AddWithValue("@email", txt_email.Text)
                comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtp_fecha_nacimiento.Value))
                comando.Parameters.AddWithValue("@sexo", sexo)
                If verificar_existencia(Convert.ToInt16(txt_legajo.Text)) = True Then
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Datos agregados exitosamente")
                    With BaseDeDatos.lv_datos
                        .Items.Add(txt_legajo.Text)
                        .Items(BaseDeDatos.lv_datos.Items.Count - 1).SubItems.Add(txt_nombre.Text)
                        .Items(BaseDeDatos.lv_datos.Items.Count - 1).SubItems.Add(txt_telefono.Text)
                        .Items(BaseDeDatos.lv_datos.Items.Count - 1).SubItems.Add(txt_email.Text)
                        .Items(BaseDeDatos.lv_datos.Items.Count - 1).SubItems.Add(txt_celular.Text)
                        .Items(BaseDeDatos.lv_datos.Items.Count - 1).SubItems.Add(dtp_fecha_nacimiento.Value.ToShortDateString)
                        .Items(BaseDeDatos.lv_datos.Items.Count - 1).SubItems.Add(sexo)
                    End With
                Else
                    MessageBox.Show("El numero de legajo está repetido")
                    Exit Sub
                End If
            Else
                comando.CommandText = "ModificarPersona"
                comando.Parameters.AddWithValue("@legajo", Convert.ToInt16(txt_legajo.Text))
                comando.Parameters.AddWithValue("@nombre", txt_nombre.Text)
                comando.Parameters.AddWithValue("@telefono", txt_telefono.Text)
                comando.Parameters.AddWithValue("@celular", txt_celular.Text)
                comando.Parameters.AddWithValue("@email", txt_email.Text)
                comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtp_fecha_nacimiento.Value))
                comando.Parameters.AddWithValue("@sexo", sexo)
                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                MessageBox.Show("Datos modificados exitosamente")
                With BaseDeDatos.lv_datos
                    .SelectedItems(0).SubItems(1).Text = txt_nombre.Text.Trim
                    .SelectedItems(0).SubItems(2).Text = txt_telefono.Text.Trim
                    .SelectedItems(0).SubItems(3).Text = txt_email.Text.Trim
                    .SelectedItems(0).SubItems(4).Text = txt_celular.Text.Trim
                    .SelectedItems(0).SubItems(5).Text = dtp_fecha_nacimiento.Value.ToShortDateString
                    .SelectedItems(0).SubItems(6).Text = sexo
                End With
            End If
            Me.Close()
        Catch ex As SqlException
            MessageBox.Show("Hay problemas con la base de datos")
        Catch ex As Exception
            MessageBox.Show("Hay problemas con el procesamiento de datos")
        Finally
            conexion.Dispose()
            comando.Dispose()
        End Try
    End Sub

    Public Function validaciones() As Boolean
        Try
            If txt_legajo.Text = "" Then
                MessageBox.Show("El legajo no puede estar vacío")
                txt_legajo.Focus()
                Return False
            End If
            If Convert.ToInt32(txt_legajo.Text) > 32000 Then
                MessageBox.Show("Numero de legajo debe ser menor a 32000")
                txt_legajo.Focus()
                Return False
            End If
            If verificarcadena(txt_legajo.Text, 1) = False Then
                MessageBox.Show("El legajo no puede contener letras")
                txt_legajo.Focus()
                Return False
            End If
            If txt_nombre.Text.Trim = "" Then
                MessageBox.Show("El nombre no puede estar vacío")
                txt_nombre.Focus()
                Return False
            End If
            If verificarcadena(txt_nombre.Text) = False Then
                MessageBox.Show("El nombre no puede contener numeros")
                txt_nombre.Focus()
                Return False
            End If
            If txt_telefono.Text.Trim <> "" Then
                If verificarcadena(txt_telefono.Text, 2) = False Then
                    MessageBox.Show("El telefono no puede contener letras")
                    txt_telefono.Focus()
                    Return False
                End If
            End If
            If txt_celular.Text.Trim <> "" Then
                If verificarcadena(txt_celular.Text, 3) = False Then
                    MessageBox.Show("El celular no puede contener letras")
                    txt_celular.Focus()
                    Return False
                End If
            End If
            If txt_email.Text.Contains("@") = False Then
                MessageBox.Show("El email debe contener '@'")
                txt_email.Focus()
                Return False
            End If
            If verificar_email(txt_email.Text) = False Then
                MessageBox.Show("El email debe contener sólo 1 '@'")
                txt_email.Focus()
                Return False
            End If
            If rdb_femenino.Checked = False And rdb_masculino.Checked = False Then
                MessageBox.Show("Debe seleccionar un sexo")
                Return False
            End If
            If rdb_femenino.Checked = True Then
                sexo = CChar("F")
            Else
                sexo = CChar("M")
            End If
            If DateDiff(DateInterval.Year, dtp_fecha_nacimiento.Value, Now.Date) < 17 Then
                MessageBox.Show("La persona debe tener como minimo 17 años")
                dtp_fecha_nacimiento.Focus()
                Return False
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Se ingresaron datos incorrectamente")
            Return False
        Catch ex As Exception
            MessageBox.Show("Hay un problema con los datos")
            Return False
        End Try
        Return True
    End Function
End Class