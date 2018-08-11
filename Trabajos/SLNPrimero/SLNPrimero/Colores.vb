Public Class frm_colores

    Private Sub txt_nombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.GotFocus
        txt_nombre.BackColor = Color.Red
    End Sub

    Private Sub txt_apellido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_apellido.GotFocus
        txt_apellido.BackColor = Color.Red
    End Sub

    Private Sub txt_edad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_edad.GotFocus
        txt_edad.BackColor = Color.Red
    End Sub

    Private Sub btn_aceptar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar2.Click
        If txt_nombre.Text <> "" And txt_apellido.Text <> "" And txt_edad.Text <> "" Then
            MessageBox.Show("Las cajas estan llenas")
            txt_nombre.Text = ""
            txt_apellido.Text = ""
            txt_edad.Text = ""
            Me.Hide()
            frm_key.Show()
            frm_key.Height = 150
        Else
            If txt_nombre.Text.Trim = "" Then
                MessageBox.Show("Falta el nombre del usuario")
                txt_nombre.BackColor = Color.Red
            End If
            If txt_apellido.Text.Trim = "" Then
                MessageBox.Show("Falta el apellido del usuario")
                txt_apellido.BackColor = Color.Red
            End If
            If txt_apellido.Text.Trim = "" Then
                MessageBox.Show("Falta la edad del usuario")
                txt_edad.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txt_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.LostFocus
        txt_nombre.BackColor = Color.White
    End Sub

    Private Sub txt_edad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_edad.LostFocus
        txt_edad.BackColor = Color.White
    End Sub

    Private Sub txt_apellido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_apellido.LostFocus
        txt_apellido.BackColor = Color.White
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged

    End Sub
End Class