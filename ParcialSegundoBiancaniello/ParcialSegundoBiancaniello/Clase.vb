Public Class Clase

    Dim motor As New Motor
    Dim auto As New Automovil
    Private Sub btn_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asignar.Click
        Try
            motor.asignar_datos(Convert.ToInt32(txt_numero.Text), txt_marca.Text, txt_modelo.Text, Convert.ToByte(txt_cilindros.Text), CChar(txt_tipo.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mostrar.Click
        Try
            motor.mostrar_datos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            auto.asignar_datos(Convert.ToInt32(txt_numero.Text), txt_marca.Text, txt_modelo.Text, Convert.ToByte(txt_cilindros.Text), CChar(txt_tipo.Text), TextBox3.Text, TextBox2.Text, TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_marca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_marca.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_modelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_modelo.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cilindros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cilindros.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tipo.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            auto.mostrar_datos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class