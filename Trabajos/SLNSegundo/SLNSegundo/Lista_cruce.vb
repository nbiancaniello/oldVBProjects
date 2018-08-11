Public Class frm_Lista_cruce

    Private Sub btn_agregaruno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregaruno.Click
        If lst_izquierda.Items.Count <> 0 Then
            If lst_izquierda.SelectedIndex <> -1 Then
                pasaritem(lst_izquierda, lst_derecha)
                lst_izquierda.Items.RemoveAt(lst_izquierda.SelectedIndex)
            Else
                MessageBox.Show("Seleccione un elemento de la lista")
            End If
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
        lbl_cantidadizquierda.Text = lst_izquierda.Items.Count.ToString
        lbl_cantidadderecha.Text = lst_derecha.Items.Count.ToString
    End Sub

    Private Sub btn_agregartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregartodos.Click
        If lst_izquierda.Items.Count <> 0 Then
            lst_derecha.Items.AddRange(lst_izquierda.Items)
            eliminarlista(lst_izquierda)
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
        lbl_cantidadizquierda.Text = lst_izquierda.Items.Count.ToString
        lbl_cantidadderecha.Text = lst_derecha.Items.Count.ToString
    End Sub

    Private Sub btn_sacaruno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sacaruno.Click
        If lst_derecha.Items.Count <> 0 Then
            If lst_derecha.SelectedIndex <> -1 Then
                pasaritem(lst_derecha, lst_izquierda)
                lst_derecha.Items.RemoveAt(lst_derecha.SelectedIndex)
            Else
                MessageBox.Show("Seleccione un elemento de la lista")
            End If
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
        lbl_cantidadizquierda.Text = lst_izquierda.Items.Count.ToString
        lbl_cantidadderecha.Text = lst_derecha.Items.Count.ToString
    End Sub

    Private Sub btn_sacartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sacartodos.Click
        If lst_derecha.Items.Count <> 0 Then
            lst_izquierda.Items.AddRange(lst_derecha.Items)
            eliminarlista(lst_derecha)
        Else
            MessageBox.Show("No hay elementos cargados en la lista")
        End If
        lbl_cantidadizquierda.Text = lst_izquierda.Items.Count.ToString
        lbl_cantidadderecha.Text = lst_derecha.Items.Count.ToString
    End Sub
End Class