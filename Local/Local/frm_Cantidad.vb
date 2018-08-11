Public Class frm_Cantidad

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If txt_cantidad.Text.Trim = "" Then
                MessageBox.Show("La Cantidad no puede estar vacía")
                txt_cantidad.Focus()
                Exit Sub
            Else
                If verificarnumeronatural(txt_cantidad.Text) = False Then
                    MessageBox.Show("Cantidad incorrecta")
                    txt_cantidad.Focus()
                    Exit Sub
                End If
                If CShort(txt_cantidad.Text) <= 0 Then
                    MessageBox.Show("La Cantidad debe ser mayor a 0")
                    txt_cantidad.Focus()
                    Exit Sub
                End If
            End If
            If CByte(txt_cantidad.Text) <= (CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text) + CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(9).Text)) Then
                If CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text) > CByte(txt_cantidad.Text) Then
                    RegistrarVenta.lv_productos.SelectedItems(0).SubItems(9).Text = CStr(CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(9).Text) + (CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text) - CByte(txt_cantidad.Text)))
                End If
                If CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text) < CByte(txt_cantidad.Text) Then
                    RegistrarVenta.lv_productos.SelectedItems(0).SubItems(9).Text = CStr(CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(9).Text) - (CByte(txt_cantidad.Text) - CByte(RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text)))
                End If
                RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text = txt_cantidad.Text
                Me.Close()
            Else
                MessageBox.Show("Stock insuficiente")
                txt_cantidad.Text = RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text
                txt_cantidad.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frm_Cantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txt_cantidad.Text = RegistrarVenta.lv_productos.SelectedItems(0).SubItems(6).Text
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub txt_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class