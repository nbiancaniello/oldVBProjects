Public Class frm_CombosListas

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_opcion.SelectedIndexChanged
        lst_contenido.Items.Clear()
        If cmb_opcion.SelectedIndex = 0 Then
            With lst_contenido.Items
                .Add("San Miguel")
                .Add("J.C.Paz")
                .Add("Haedo")
                .Add("La Plata")
            End With
        End If
        If cmb_opcion.SelectedIndex = 1 Then
            With lst_contenido.Items
                .Add("San Miguel")
                .Add("San Martín")
                .Add("La Matanza")
            End With
        End If
        If cmb_opcion.SelectedIndex = 2 Then
            With lst_contenido.Items
                .Add("Buenos Aires")
                .Add("Santa Fe")
                .Add("Entre Ríos")
                .Add("Córdoba")
                .Add("San Luis")
            End With
        End If
        If cmb_opcion.SelectedIndex = 3 Then
            With lst_contenido.Items
                .Add("Argentina")
                .Add("Suiza")
            End With
        End If
        lbl_contador.Text = lst_contenido.Items.Count.ToString

    End Sub
End Class