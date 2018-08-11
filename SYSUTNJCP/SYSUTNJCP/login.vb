Public Class login

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        End
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            If txt_usuario.Text = "" Then
                MessageBox.Show("Ingrese el nombre de Usuario")
                txt_usuario.Focus()
                Exit Sub
            End If
            gv_usuario = txt_usuario.Text
            If verificar_password(txt_usuario.Text, txt_clave.Text) Then
                Me.Hide()
                pantalla_principal.Show()
            Else
                txt_clave.Clear()
                txt_usuario.Clear()
                txt_usuario.Focus()
                MessageBox.Show("El usuario y/o la clave ingresada es incorrecta")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class