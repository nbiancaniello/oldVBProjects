Public Class frm_Calculadora
    'Dim resultado As Int32
    Private Sub txt_num1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_num1.KeyPress
        ' Este evento me permite validar el ingreso de numeros
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "." Then
            If txt_num1.Text.EndsWith(".") Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_num2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_num2.KeyPress
        ' Este evento me permite validar el ingreso de numeros
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "." Then
            ' If Asc(e.KeyChar) = 8 Then
            'txt_num1.Text.
            'End If

            If txt_num2.Text.EndsWith(".") Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_sumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sumar.Click
        ' Este evento suma los valores de las cajas de texto
        'resultado = sumar(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text))
        lbl_resultado.Text = " El resultado de la suma es: " & sumar(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text)).ToString
    End Sub

    Private Sub btn_restar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restar.Click
        ' Este evento resta los valores de las cajas de texto
        'resultado = restar(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text))
        lbl_resultado.Text = " El resultado de la resta es: " & restar(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text)).ToString
    End Sub

    Private Sub btn_dividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dividir.Click
        ' Este evento divide los valores de las cajas de texto
        ' y ademas valida que el divisor sea distinto de 0
        If Convert.ToInt32(txt_num2.Text) <> 0 Then
            'resultado = dividir(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text))
            lbl_resultado.Text = " El resultado de la división es: " & dividir(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text)).ToString
        Else
            MessageBox.Show("El divisor debe ser distinto de 0!!!")
        End If
    End Sub

    Private Sub btn_multiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_multiplicar.Click
        ' Este evento multiplica los valores de las cajas de texto
        'resultado = multiplicar(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text))
        lbl_resultado.Text = " El resultado de la multiplicación es: " & multiplicar(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text)).ToString
    End Sub
End Class