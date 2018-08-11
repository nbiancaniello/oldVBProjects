Imports System.Data.SqlClient
Public Class Modificar

    Private Sub Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fecha.MaxDate = Now.Date
        Me.Text = "Modificar Código"
        txt_nombre.Text = Tabla.lv_datos.SelectedItems(0).SubItems(1).Text
        dtp_fecha.Value = CDate(Tabla.lv_datos.SelectedItems(0).SubItems(2).Text)
        If Tabla.lv_datos.SelectedItems(0).SubItems(3).Text = "No tiene" Then
            txt_telefono.Text = ""
        Else
            txt_telefono.Text = Tabla.lv_datos.SelectedItems(0).SubItems(3).Text
        End If
        If Tabla.lv_datos.SelectedItems(0).SubItems(4).Text = "No tiene" Then
            txt_telefono.Text = ""
        Else
            txt_celular.Text = Tabla.lv_datos.SelectedItems(0).SubItems(4).Text
        End If
        If Tabla.lv_datos.SelectedItems(0).SubItems(5).Text = "No tiene" Then
            txt_telefono.Text = ""
        Else
            txt_email.Text = Tabla.lv_datos.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
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
        If Char.IsLetter(e.KeyChar) = True Then
            If txt_email.Text.Contains("@") = False Then
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim conexion As New SqlConnection
        Dim comando As New SqlCommand
        Dim cadena As String

        If validar_datos() = False Then
            MessageBox.Show("Tipo de dato incorrecto")
            Exit Sub
        End If
        If validar_fecha() = False Then
            MessageBox.Show("La edad no debe ser inferior a 21")
            Exit Sub
        End If

        cadena = "UPDATE PROFESORES SET "
        cadena = cadena + "NOMBRE = '" & txt_nombre.Text.Trim & "',"
        cadena = cadena + "FECHANAC = '" & dtp_fecha.Value.ToShortDateString & "',"
        cadena = cadena + "TELEFONO = '" & txt_telefono.Text & "',"
        cadena = cadena + "CELULAR = '" & txt_celular.Text & "',"
        cadena = cadena + "EMAIL = '" & txt_email.Text & "'"
        cadena = cadena + "WHERE CODPROFESOR = " & Tabla.lv_datos.Items(0).Text
        Try
            conexion.ConnectionString = ruta
            comando.CommandType = CommandType.Text
            comando.CommandText = cadena
            comando.Connection = conexion
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Registro Actualizado exitosamente")
            With Tabla.lv_datos
                .SelectedItems.Item(0).SubItems(1).Text = txt_nombre.Text.Trim
                .SelectedItems.Item(0).SubItems(2).Text = dtp_fecha.Value.ToShortDateString
                .SelectedItems.Item(0).SubItems(3).Text = txt_telefono.Text.Trim
                .SelectedItems.Item(0).SubItems(4).Text = txt_celular.Text.Trim
                .SelectedItems.Item(0).SubItems(5).Text = txt_email.Text.Trim
            End With
            Me.Close()
        Catch ex As SqlException
            MessageBox.Show("Hubo un problema con la base de datos")
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con los datos")
        Finally
            conexion.Dispose()
            comando.Dispose()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Public Function validar_datos() As Boolean
        Dim i As Byte
        For i = 0 To CByte(txt_nombre.Text.Length - 1)
            If IsNumeric(txt_nombre.Text.Substring(i, 1)) = True Then
                txt_nombre.Focus()
                Return False
            End If
        Next
        For i = 0 To CByte(txt_telefono.Text.Length - 1)
            If IsNumeric(txt_telefono.Text.Substring(i, 1)) = False And txt_telefono.Text.Substring(i, 1) <> "-" And txt_telefono.Text.Substring(i, 1) <> "(" And txt_telefono.Text.Substring(i, 1) <> ")" Then
                txt_telefono.Focus()
                Return False
            End If
        Next
        For i = 0 To CByte(txt_celular.Text.Length - 1)
            If IsNumeric(txt_celular.Text.Substring(i, 1)) = False And txt_celular.Text.Substring(i, 1) <> "-" Then
                txt_celular.Focus()
                Return False
            End If
        Next
        Return True
    End Function
    Public Function validar_fecha() As Boolean
        If DateDiff(DateInterval.Year, dtp_fecha.Value, Now.Date) < 21 Then
            Return False
        End If
        Return True
    End Function
End Class