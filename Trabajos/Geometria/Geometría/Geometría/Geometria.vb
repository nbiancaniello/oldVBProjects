Public Class Geometria

    Private Sub btn_perim_rect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_perim_rect.Click
        Try
            MessageBox.Show("El perímetro es: " & perimetro_rec(Convert.ToInt16(txt_lado1.Text), Convert.ToInt16(txt_lado2.Text)).ToString)
        Catch ex As OverflowException
            MessageBox.Show("Uno de los lados es demasiado grande")
        Catch ex As InvalidCastException
            MessageBox.Show("No esta permitido el ingreso de letras")
        Catch ex As Exception
            MessageBox.Show("")
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lado1.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lado2.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lado3.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_area_triangulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_area_triangulo.Click
        Dim tipo As Short
        Try
            tipo = retorna_tipo(Convert.ToInt16(txt_lado1.Text), Convert.ToInt16(txt_lado2.Text), Convert.ToInt16(txt_lado3.Text))
            MessageBox.Show("El Área es: " & area_triang(Convert.ToInt16(txt_lado1.Text), Convert.ToInt16(txt_lado2.Text), Convert.ToInt16(txt_lado3.Text), tipo).ToString)
        Catch ex As OverflowException
            MessageBox.Show("Uno de los lados es demasiado grande")
        Catch ex As InvalidCastException
            MessageBox.Show("No esta permitido el ingreso de letras")
        Catch ex As Exception
            MessageBox.Show("")
        End Try
    End Sub
End Class
