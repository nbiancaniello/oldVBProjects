Imports System.Data.SqlClient
Public Class Buscar

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpiar_cajas()
        Me.Close()
        BaseDeDatos.Show()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim conexion As New SqlConnection
        Dim comando As New SqlCommand
        Dim datareader As SqlDataReader
        Dim i As Integer = 0
        Dim primero As Boolean = True
        Dim cadena As String

        cadena = "SELECT legajo,nombre,telefono,celular,email,fecha_nacimiento,sexo"
        cadena = cadena + " FROM Datos WHERE "

        If cmb_legajo.SelectedIndex <> -1 Then
            cadena = cadena + " legajo "
            If verificarcadena(txt_legajo1.Text, 1) = True Then
                Select Case cmb_legajo.SelectedIndex
                    Case 0 : cadena = cadena + " = " & txt_legajo1.Text
                    Case 1 : cadena = cadena + " > " & txt_legajo1.Text
                    Case 2 : cadena = cadena + " < " & txt_legajo1.Text
                    Case 3 : cadena = cadena + " <> " & txt_legajo1.Text
                    Case 4
                        cadena = cadena + " between " & txt_legajo1.Text & " and " & txt_legajo2.Text
                        If verificarcadena(txt_legajo2.Text, 1) = False Then
                            MessageBox.Show("Legajo Incorrecto")
                            txt_legajo2.Focus()
                            Exit Sub
                        End If
                End Select
            Else
                MessageBox.Show("Legajo Incorrecto")
                txt_legajo1.Focus()
                Exit Sub
            End If
            primero = False
        End If

        If cmb_nombre.SelectedIndex <> -1 Then
            If primero = True Then
                cadena = cadena + " nombre "
            Else
                cadena = cadena + " and nombre "
            End If
            If verificarcadena(txt_nombre1.Text, 1) = True Then
                Select Case cmb_nombre.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & txt_nombre1.Text & "'"
                    Case 1 : cadena = cadena + " LIKE '" & txt_nombre1.Text & "%'"
                    Case 2 : cadena = cadena + " LIKE '%" & txt_nombre1.Text & "%'"
                    Case 3 : cadena = cadena + " LIKE '%" & txt_nombre1.Text & "'"
                End Select
                primero = False
            Else
                MessageBox.Show("Nombre Incorrecto")
                txt_nombre1.Focus()
                Exit Sub
            End If

        End If

        If cmb_telefono.SelectedIndex <> -1 Then
            If primero = True Then
                cadena = cadena + " telefono "
            Else
                cadena = cadena + " and telefono "
            End If
            If verificarcadena(txt_telefono1.Text, 2) = True Then
                Select Case cmb_telefono.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & txt_telefono1.Text & "'"
                    Case 1 : cadena = cadena + " LIKE '" & txt_telefono1.Text & "%'"
                    Case 2 : cadena = cadena + " LIKE '%" & txt_telefono1.Text & "%'"
                    Case 3 : cadena = cadena + " LIKE '%" & txt_telefono1.Text & "'"
                End Select
                primero = False
            Else
                MessageBox.Show("Telefono Incorrecto")
                txt_telefono1.Focus()
                Exit Sub
            End If
        End If

        If cmb_celular.SelectedIndex <> -1 Then
            If primero = True Then
                cadena = cadena + " celular "
            Else
                cadena = cadena + " and celular "
            End If
            If verificarcadena(txt_celular1.Text, 3) = True Then
                Select Case cmb_celular.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & txt_celular1.Text & "'"
                    Case 1 : cadena = cadena + " LIKE '" & txt_celular1.Text & "%'"
                    Case 2 : cadena = cadena + " LIKE '%" & txt_celular1.Text & "%'"
                    Case 3 : cadena = cadena + " LIKE '%" & txt_celular1.Text & "'"
                End Select
                primero = False
            Else
                MessageBox.Show("Celular Incorrecto")
                txt_celular1.Focus()
                Exit Sub
            End If
        End If

        If cmb_email.SelectedIndex <> -1 Then
            If primero = True Then
                cadena = cadena + " email "
            Else
                cadena = cadena + " and email "
            End If
            If verificar_email(txt_email1.Text) = True Then
                Select Case cmb_email.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & txt_email1.Text & "'"
                    Case 1 : cadena = cadena + " LIKE '" & txt_email1.Text & "%'"
                    Case 2 : cadena = cadena + " LIKE '%" & txt_email1.Text & "%'"
                    Case 3 : cadena = cadena + " LIKE '%" & txt_email1.Text & "'"
                End Select
                primero = False
            Else
                MessageBox.Show("E-mail Incorrecto")
                txt_email1.Focus()
                Exit Sub
            End If
        End If

            If cmb_sexo.SelectedIndex <> -1 Then
                If cmb_sexo.SelectedIndex <> 0 Then
                    If primero = True Then
                        cadena = cadena + " sexo "
                    Else
                        cadena = cadena + " and sexo "
                    End If
                    Select Case cmb_sexo.SelectedIndex
                        Case 1 : cadena = cadena + " = 'M'"
                        Case 2 : cadena = cadena + " = 'F'"
                    End Select
                End If
                primero = False
            End If

            If cmb_fecha.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " fecha_nacimiento "
                Else
                    cadena = cadena + " and fecha_nacimiento "
                End If
                Select Case cmb_fecha.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & dtp_fecha_nacimiento1.Value.ToShortDateString & "'"
                    Case 1 : cadena = cadena + " > '" & dtp_fecha_nacimiento1.Value.ToShortDateString & "'"
                    Case 2 : cadena = cadena + " < '" & dtp_fecha_nacimiento1.Value.ToShortDateString & "'"
                    Case 3 : cadena = cadena + " <> '" & dtp_fecha_nacimiento1.Value.ToShortDateString & "'"
                    Case 4 : cadena = cadena + " between '" & dtp_fecha_nacimiento1.Value.ToShortDateString & "' and '" & dtp_fecha_nacimiento2.Value.ToShortDateString & "'"
                End Select
                primero = False
            End If

            If primero = False Then
                Try
                    conexion.ConnectionString = Ruta
                    comando.CommandType = CommandType.Text
                    comando.Connection = conexion
                    comando.CommandText = cadena

                    conexion.Open()
                    datareader = comando.ExecuteReader
                    If datareader.HasRows = True Then
                        BaseDeDatos.lv_datos.Items.Clear()
                        While datareader.Read
                            With BaseDeDatos.lv_datos
                                .Items.Add(datareader.GetInt16(0).ToString)
                                .Items(i).SubItems.Add(datareader.GetString(1))
                                If datareader.IsDBNull(2) Then
                                    .Items(i).SubItems.Add("No tiene")
                                Else
                                    .Items(i).SubItems.Add(datareader.GetString(2))
                                End If
                                If datareader.IsDBNull(4) Then
                                    .Items(i).SubItems.Add("No tiene")
                                Else
                                    .Items(i).SubItems.Add(datareader.GetString(4))
                                End If
                                If datareader.IsDBNull(3) Then
                                    .Items(i).SubItems.Add("No tiene")
                                Else
                                    .Items(i).SubItems.Add(datareader.GetString(3))
                                End If
                                .Items(i).SubItems.Add(datareader.GetDateTime(5).ToShortDateString)
                                .Items(i).SubItems.Add(datareader.GetString(6))
                            End With
                            i = i + 1
                        End While
                        limpiar_cajas()
                        Me.Close()
                    Else
                        MessageBox.Show("No se han encontrado registros en la busqueda seleccionada")
                    End If
                    conexion.Close()
                    datareader.Close()
                Catch ex As SqlException
                    MessageBox.Show("Hubo un problema con la base de datos")
                Catch ex As Exception
                    MessageBox.Show("Hubo un problema con los datos")
                Finally
                    conexion.Dispose()
                    comando.Dispose()
                End Try
            Else
                MessageBox.Show("Debe elegir alguna opción para poder efectuar la búsqueda")
            End If
    End Sub

    Private Sub cmb_legajo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_legajo.SelectedIndexChanged
        txt_legajo1.Enabled = True
        If cmb_legajo.SelectedIndex = 4 Then
            txt_legajo2.Enabled = True
        Else
            txt_legajo2.Enabled = False
        End If
    End Sub

    Private Sub cmb_fecha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_fecha.SelectedIndexChanged
        dtp_fecha_nacimiento1.Enabled = True
        If cmb_fecha.SelectedIndex = 4 Then
            dtp_fecha_nacimiento2.Enabled = True
        Else
            dtp_fecha_nacimiento2.Enabled = False
        End If
    End Sub

    Private Sub txt_legajo2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_legajo2.LostFocus
        If txt_legajo2.Text.Trim = "" Then
            txt_legajo2.Text = "32000"
        Else
            If Convert.ToInt32(txt_legajo1.Text) > Convert.ToInt32(txt_legajo2.Text) Then
                MessageBox.Show("El legajo 'desde' debe ser menor al legajo 'hasta'")
                txt_legajo2.Clear()
                txt_legajo2.Focus()
            End If
        End If
        If Convert.ToInt32(txt_legajo2.Text) > 32000 Then
            MessageBox.Show("El legajo hasta no puede ser mayor a 32000")
            txt_legajo2.Clear()
            txt_legajo2.Focus()
        End If
    End Sub
    Private Sub txt_legajo1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_legajo1.LostFocus
        If txt_legajo1.Text.Trim = "" Then
            txt_legajo1.Text = "0"
        Else
            If txt_legajo2.Text.Trim <> "" Then
                If Convert.ToInt32(txt_legajo1.Text) > Convert.ToInt32(txt_legajo2.Text) Then
                    MessageBox.Show("El legajo 'desde' debe ser menor al legajo 'hasta'")
                    txt_legajo1.Clear()
                    txt_legajo1.Focus()
                End If
            End If
            End If
            If Convert.ToInt32(txt_legajo1.Text) > 32000 Then
                MessageBox.Show("El legajo desde no puede ser mayor a 32000")
                txt_legajo1.Clear()
                txt_legajo1.Focus()
            End If
    End Sub

    Public Sub limpiar_cajas()
        txt_legajo1.Clear()
        txt_legajo2.Clear()
        txt_nombre1.Clear()
        txt_telefono1.Clear()
        txt_celular1.Clear()
        txt_email1.Clear()
        dtp_fecha_nacimiento1.Value = Now.Date
        dtp_fecha_nacimiento2.Value = Now.Date
    End Sub

    Private Sub dtp_fecha_nacimiento1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha_nacimiento1.ValueChanged
        If dtp_fecha_nacimiento1.Value > dtp_fecha_nacimiento2.Value Then
            MessageBox.Show("La fecha 'desde' debe ser menor a la fecha 'hasta'")
            dtp_fecha_nacimiento1.Focus()
        End If
    End Sub

    Private Sub dtp_fecha_nacimiento2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha_nacimiento2.ValueChanged
        If dtp_fecha_nacimiento1.Value > dtp_fecha_nacimiento2.Value Then
            MessageBox.Show("La fecha 'desde' debe ser menor a la fecha 'hasta'")
            dtp_fecha_nacimiento2.Focus()
        End If
    End Sub

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class