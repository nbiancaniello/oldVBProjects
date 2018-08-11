Public Class frm_listas

    '********************************************************************
    ' Todos los procedimientos y funciones que pertenecen a este proyecto
    ' se encuentran en el módulo "ModRutinas"
    '********************************************************************

    Private Sub btn_eliminarlista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminarlista.Click
        ' Borra la lista entera
        If lst_nombres.Items.Count <> 0 Then
            If MessageBox.Show("¿Está seguro que desea eliminar todos los elementos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                eliminarlista(lst_nombres)
            End If
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
    End Sub

    Private Sub btn_eliminaritem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminaritem.Click
        ' Borra el ítem seleccionado
        If lst_nombres.Items.Count <> 0 Then
            If lst_nombres.SelectedIndex <> -1 Then
                If MessageBox.Show("¿Está seguro que desea eliminar este elemento?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    eliminaritem(lst_nombres)
                End If
            Else
                MessageBox.Show("Seleccione un elemento de la lista")
            End If
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
    End Sub

    Private Sub btn_cantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cantidad.Click
        ' Cuenta cuantos items se ingresaron
        If lst_nombres.Items.Count <> 0 Then
            cantidad(lst_nombres)
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        ' Agrega un item a la lista
        If txt_nombre.Text.Trim <> "" Then
            If lst_nombres.Items.Contains(txt_nombre.Text) = False Then
                agregaritem(lst_nombres, txt_nombre)
            Else
                MessageBox.Show("Este elemento está repetido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("No se permite el ingreso de elementos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txt_nombre.Clear()
    End Sub

    Private Sub btn_mayorlong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mayorlong.Click
        ' Muestra el elemento de mayor longitud, su posición y la cantidad de caracteres
        Dim pos As Byte
        Dim cadena As String
        pos = mayorlongitud(lst_nombres)
        cadena = CStr(lst_nombres.Items.Item(pos))
        MessageBox.Show("En la posición " & (pos + 1).ToString & " está el elemento de mayor longitud: " & lst_nombres.Items.Item(pos).ToString & " con " & cadena.Length & " caracteres")
    End Sub

    Private Sub btn_menorlong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menorlong.Click
        ' Muestra el elemento de menor longitud, su posición y la cantidad de caracteres
        Dim pos As Byte
        Dim cadena As String
        pos = menorlongitud(lst_nombres)
        cadena = CStr(lst_nombres.Items.Item(pos))
        MessageBox.Show("En el índice " & (pos + 1).ToString & " está el elemento de menor longitud: " & lst_nombres.Items.Item(pos).ToString & " con " & cadena.Length & " caracteres")
        End Sub

    Private Sub btn_caracteres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_caracteres.Click
        ' Cuenta cuantos caracteres hay en un item
        If lst_nombres.SelectedIndex <> -1 Then
            MessageBox.Show("El nombre contiene " & contarcaracteres(lst_nombres.SelectedItem.ToString) & " caracteres")
        Else
            MessageBox.Show("Debe elegir un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        ' Sale del programa
        End
    End Sub

    Private Sub btn_cant2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cant2.Click
        ' Cuenta cuantos caracteres hay en un item, segun el caracter a buscar
        If lst_nombres.Items.Count <> 0 Then
            If lst_nombres.SelectedIndex <> -1 Then
                MessageBox.Show("Este elemento contiene " & contarletras(CChar(txt_letra.Text), lst_nombres.SelectedItem.ToString) & " letras '" & txt_letra.Text & "'")
            Else
                MessageBox.Show("Seleccione un elemento de la lista")
            End If
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
        End Sub
End Class
