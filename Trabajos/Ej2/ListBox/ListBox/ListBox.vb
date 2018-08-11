Public Class frm_ListBox

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If txt_provincia.Text.Trim <> "" Then
            If lst_provincias.Items.Contains(txt_provincia.Text) = False Then
                lst_provincias.Items.Add(txt_provincia.Text)
                txt_provincia.Text = ""
                txt_provincia.Focus()
            Else
                MessageBox.Show("Esta provincia esta repetida!")
            End If
        Else
            MessageBox.Show("No se permite el ingreso de nombres vacios")
        End If
    End Sub



    Private Sub btn_bsel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bsel.Click
        If lst_provincias.Items.Count <> 0 Then
            If lst_provincias.SelectedIndex <> -1 Then
                lst_provincias.Items.RemoveAt(lst_provincias.SelectedIndex)
            Else
                MessageBox.Show("Seleccione un elemento de la lista")
            End If
        Else
            MessageBox.Show("Ingrese al menos una provincia para poder borrar")
        End If
    End Sub

    Private Sub btn_vaciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vaciar.Click
        lst_provincias.Items.Clear()
    End Sub

    Private Sub txt_provincia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_provincia.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btn_cant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cant.Click
        MessageBox.Show("Cantidad de provincias ingresadas: " & lst_provincias.Items.Count.ToString)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_provincia.Focus()
    End Sub

    
End Class
