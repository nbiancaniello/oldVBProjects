Public Class Validar_Datos

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        ' Permite sólo el ingreso de letras en el nombre
        If Char.IsLetter(e.KeyChar) = True Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        ' Permite sólo el ingreso de letras en el apellido
        If Char.IsLetter(e.KeyChar) = True Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        ' Permite sólo el ingreso de numeros en el telefono
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            If e.KeyChar = "(" Or e.KeyChar = ")" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_numero_domicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero_domicilio.KeyPress
        ' Permite sólo el ingreso de numeros en el numero de domicilio
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Validar_Datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establece la fecha máxima al control DateTimePicker
        dtp_fecha_nac.MaxDate = Now.Date
    End Sub

    Private Sub btn_buscarfoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarfoto.Click
        'Abre un cuadro de diálogo para buscar una imagen
        Try
            If opf_Foto.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pcb_foto.Image = Image.FromFile(opf_Foto.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("El archivo seleccionado no es una imagen válida", "Advertencia", MessageBoxButtons.OK)
        Finally
            opf_Foto.Dispose()
        End Try
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_email.KeyPress
        ' Verifica que se ingrese una sola @
        If txt_email.Text.Contains("@") Then
            If e.KeyChar = "@" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'Fin del programa
        End
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        quitar_espacios()
        Try
            If txt_nombre.Text = "" Then
                MessageBox.Show("Debe ingresar un nombre", "Advertencia", MessageBoxButtons.OK)
                txt_nombre.Focus()
                Exit Sub
            End If
            If txt_apellido.Text = "" Then
                MessageBox.Show("Debe ingresar un apellido", "Advertencia", MessageBoxButtons.OK)
                txt_apellido.Focus()
                Exit Sub
            End If
            If txt_domicilio.Text = "" Then
                MessageBox.Show("Debe ingresar un domicilio", "Advertencia", MessageBoxButtons.OK)
                txt_domicilio.Focus()
                Exit Sub
            End If
            If devolver_numero(CInt(txt_numero_domicilio.Text)) = 0 Or txt_numero_domicilio.Text = "" Then
                MessageBox.Show("Numero de domicilio incorrecto", "Advertencia", MessageBoxButtons.OK)
                txt_numero_domicilio.Focus()
                Exit Sub
            End If
            If devolver_numero(CInt(txt_telefono.Text)) = 0 Or txt_telefono.Text = "" Then
                MessageBox.Show("Numero de telefono incorrecto", "Advertencia", MessageBoxButtons.OK)
                txt_telefono.Focus()
                Exit Sub
            End If
            If rdb_femenino.Checked = False And rdb_masculino.Checked = False Then
                MessageBox.Show("Debe elegir el sexo")
                grb_sexo.Focus()
                Exit Sub
            End If
            If msk_cuil.Text <> "" Then
                If devolver_numero(CInt(msk_cuil.Text.Substring(3, 8))) = 0 Then
                    MessageBox.Show("El número de CUIL no puede ser 0", "Advertencia", MessageBoxButtons.OK)
                    msk_cuil.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Debe ingresar el número de CUIL", "Advertencia", MessageBoxButtons.OK)
                msk_cuil.Focus()
                Exit Sub
            End If
            If cmb_localidad.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir una localidad", "Advertencia", MessageBoxButtons.OK)
                cmb_localidad.Focus()
                Exit Sub
            End If
            If txt_email.Text.Contains("@") = False Or txt_email.Text = "" Then
                MessageBox.Show("El email ingresado no es válido", "Advertencia", MessageBoxButtons.OK)
                txt_email.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Se ingreso un dato incorrecto en uno de los campos", "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub quitar_espacios()
        txt_nombre.Text.Trim()
        txt_apellido.Text.Trim()
        txt_domicilio.Text.Trim()
        txt_numero_domicilio.Text.Trim()
        txt_telefono.Text.Trim()
        txt_email.Text.Trim()
        msk_cuil.Text.Trim()
    End Sub
End Class