Public Class Form1

    
    Private Sub btn_der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_izq.Click
        If pcb_imagen.Left > 0 Then
            pcb_imagen.Left = (pcb_imagen.Left - 3)
        End If
    End Sub

    Private Sub btn_arr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_arr.Click
        If pcb_imagen.Top > 0 Then
            pcb_imagen.Top = (pcb_imagen.Top - 3)
        End If
    End Sub

    Private Sub btn_ab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ab.Click
        If (pcb_imagen.Top + pcb_imagen.Height) < (Me.Height - 30) Then
            pcb_imagen.Top = (pcb_imagen.Top + 3)
        End If
    End Sub

    Private Sub btn_der_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_der.Click
        If (pcb_imagen.Left + pcb_imagen.Width) < (Me.Width - 8) Then
            pcb_imagen.Left = (pcb_imagen.Left + 3)
        End If
    End Sub
End Class
