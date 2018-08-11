Public Class frm_triangulo

    Private Sub btn_triangulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_triangulo.Click
        Dim lado1, lado2, lado3 As Int16
        Try
            If verificar_numeros() = True Then
                lado1 = Convert.ToInt16(txt_lado1.Text)
                lado2 = Convert.ToInt16(txt_lado2.Text)
                lado3 = Convert.ToInt16(txt_lado3.Text)
                Select Case comparar_lados(lado1, lado2, lado3)
                    Case 1 : MessageBox.Show("El triángulo es equilátero")
                    Case 2 : MessageBox.Show("El triángulo es isósceles")
                    Case 3 : MessageBox.Show("El triángulo es escaleno")
                End Select
            Else
                MessageBox.Show("Datos incorrectos en las cajas")
            End If
        Catch ex As Exception
            MessageBox.Show("Problemas con los cálculos, intente de nuevo")
        End Try

    End Sub

    Private Sub txt_lado1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lado1.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_lado2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lado2.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_lado3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lado3.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function verificar_numeros() As Boolean
        Dim i As Byte
        For i = 0 To CByte(txt_lado1.Text.Length - 1)
            If IsNumeric(txt_lado1.Text.Substring(i, 1)) = False Then
                Return False
                txt_lado1.Focus()
            End If
        Next
        For i = 0 To CByte(txt_lado2.Text.Length - 1)
            If IsNumeric(txt_lado2.Text.Substring(i, 1)) = False Then
                Return False
                txt_lado2.Focus()
            End If
        Next
        For i = 0 To CByte(txt_lado3.Text.Length - 1)
            If IsNumeric(txt_lado3.Text.Substring(i, 1)) = False Then
                Return False
                txt_lado3.Focus()
            End If
        Next
        Return True
    End Function

    Public Function comparar_lados(ByVal lado1 As Int16, ByVal lado2 As Int16, ByVal lado3 As Int16) As Byte
        If lado1 = lado2 And lado2 = lado3 Then
            Return 1
        End If
        If lado1 = lado2 And lado1 <> lado3 Then
            Return 2
        End If
        If lado2 = lado3 And lado2 <> lado1 Then
            Return 2
        End If
        If lado3 = lado1 And lado3 <> lado2 Then
            Return 2
        End If
        Return 3
    End Function

    Private Sub frm_triangulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
