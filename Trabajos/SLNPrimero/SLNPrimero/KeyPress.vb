Public Class frm_key
    Private Sub txt_letras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_letras.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_totalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_totalizar.Click
        Me.Height = 205
        lbl_tlet.Text = txt_letras.TextLength.ToString
        lbl_tnum.Text = txt_numero.TextLength.ToString
    End Sub
End Class