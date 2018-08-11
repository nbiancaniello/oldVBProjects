Public Class Objetos
    Dim status As Boolean = False

    Private Sub btn_izq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_izq.Click
        If status Then
            If pcb_imagen.Left > CShort(txt_cantidad.Text) Then
                pcb_imagen.Left = (pcb_imagen.Left - CShort(txt_cantidad.Text))
            Else
                btn_izq.Enabled = False
            End If
        End If
        If btn_der.Enabled = False Then
            btn_der.Enabled = True
        End If
    End Sub

    Private Sub btn_der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_der.Click
        If status Then
            If (pcb_imagen.Left + pcb_imagen.Width) < (Me.Width - CShort(txt_cantidad.Text)) Then
                pcb_imagen.Left = (pcb_imagen.Left + CShort(txt_cantidad.Text))
            Else
                btn_der.Enabled = False
            End If
        End If
        If btn_izq.Enabled = False Then
            btn_izq.Enabled = True
        End If
    End Sub

    Private Sub btn_arr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_arr.Click
        If status Then
            If pcb_imagen.Top > CShort(txt_cantidad.Text) Then
                pcb_imagen.Top = (pcb_imagen.Top - CShort(txt_cantidad.Text))
            Else
                btn_arr.Enabled = False
            End If
        End If
        If btn_ab.Enabled = False Then
            btn_ab.Enabled = True
        End If
    End Sub

    Private Sub btn_ab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ab.Click
        If status Then
            If (pcb_imagen.Top + pcb_imagen.Height) < (Me.Height - CShort(txt_cantidad.Text)) Then
                pcb_imagen.Top = (pcb_imagen.Top + CShort(txt_cantidad.Text))
            Else
                btn_ab.Enabled = False
            End If
        End If
        If btn_arr.Enabled = False Then
            btn_arr.Enabled = True
        End If
    End Sub


    Private Sub txt_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        ' Permite sólo el ingreso de números
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cantidad.TextChanged
        If txt_cantidad.Text <> "" Or txt_cantidad.Text = "0" Then
            If txt_cantidad.TextLength < 3 Then
                status = True
            Else
                MessageBox.Show("No se mover con distancias de 3 digitos")
                status = False
            End If
        Else
            status = False
        End If
    End Sub


End Class