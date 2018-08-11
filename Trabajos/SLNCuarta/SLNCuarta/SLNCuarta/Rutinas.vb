Public Class Rutinas

    ' La caja de texto en la cual se ingresan los datos está limitada
    ' al ingreso de 40 caracteres *no numéricos* como máximo

    '***************************************
    '       Rutinas a desarrollar
    '***************************************

    Public Function devolver_longitud(ByVal texto As String) As Byte
        Return CByte(texto.Length)
    End Function

    Public Function cantidad_espacios(ByVal texto As String) As Byte
        Dim i As Byte
        Dim acu As Byte = 0
        For i = 0 To CByte(texto.Length - 1)
            If texto.Substring(i, 1) = " " Then
                acu = CByte(acu + 1)
            End If
        Next
        Return acu
    End Function

    'Esta función contará solamente los caracteres que no contengan
    'tilde (´), tanto en mayusculas como minúsculas

    Public Function cantidad_caracteres(ByVal texto As String, ByVal caracter As Char) As Byte
        Dim i As Byte
        Dim acu As Byte = 0
        For i = 0 To CByte(texto.Length - 1)
            If texto.Substring(i, 1) = caracter.ToString.ToUpper Or texto.Substring(i, 1) = caracter.ToString.ToLower Then
                acu = CByte(acu + 1)
            End If
        Next
        Return acu
    End Function

    '***************************************
    '               Validaciones
    '***************************************

    Private Sub txt_caja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_caja.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_caracter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_caracter.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
            btn_cantidad.Enabled = True
        Else
            e.Handled = True
        End If
    End Sub

    '***************************************
    '       Ejecución desde botones
    '***************************************

    Private Sub btn_longitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_longitud.Click
        Try
            MessageBox.Show("La cadena tiene una longitud de " & devolver_longitud(txt_caja.Text.Trim).ToString & " caracteres")
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con los datos ingresados")
        End Try

    End Sub

    Private Sub btn_espacios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_espacios.Click
        Try
            MessageBox.Show("Hay " & cantidad_espacios(txt_caja.Text.Trim).ToString & " espacios en la cadena escrita")
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con los datos ingresados")
        End Try
    End Sub

    Private Sub btn_cantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cantidad.Click
        Try
            MessageBox.Show("Hay " & cantidad_caracteres(txt_caja.Text, CChar(txt_caracter.Text)).ToString & " caracteres '" & CChar(txt_caracter.Text) & "' en la cadena")
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con los datos ingresados")
        End Try
    End Sub
    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        txt_caja.Clear()
        txt_caracter.Clear()
        btn_cantidad.Enabled = False
    End Sub

    '***************************************
    '           FIN DE MODULO
    '***************************************
End Class
