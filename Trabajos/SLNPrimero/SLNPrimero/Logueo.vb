Public Class frm_logueo

    Private Sub btn_canc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_canc.Click
        MessageBox.Show("Gracias por usar nuestro producto")
        Application.Exit()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        If txt_usuario.Text = "Javier" Then
            If txt_clave.Text = "123456" Then
                frm_colores.Show()
                Me.Hide()
            ElseIf txt_clave.Text = "" Then
                MessageBox.Show("Clave Vacía")
            Else
                MessageBox.Show("Contraseña errónea")
                txt_clave.Text = ""
            End If

        ElseIf txt_usuario.Text = "" Then
            MessageBox.Show("Usuario Vacío")
        Else
            MessageBox.Show("Usuario incorrecto")
            txt_usuario.Text = ""
        End If


    End Sub
End Class
