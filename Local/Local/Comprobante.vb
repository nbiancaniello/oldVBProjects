Imports System.Data.SqlClient
Public Class Comprobante

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        txt_comprobante.Text = ""
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_comprobante.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try

            If txt_comprobante.Text.Trim = "" Then
                MessageBox.Show("Ingrese Comprobante de Tarjeta")
                txt_comprobante.Focus()
                Exit Sub
            Else
                If verificarnumeronatural(txt_comprobante.Text) = False Then
                    MessageBox.Show("Número de Comprobante incorrecto")
                    txt_comprobante.Focus()
                    Exit Sub
                End If
                If CDbl(txt_comprobante.Text) = 0 Then
                    MessageBox.Show("Ingrese Comprobante de Tarjeta")
                    txt_comprobante.Focus()
                    Exit Sub
                End If
            End If
            agregar_comprobante()
            txt_comprobante.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Me.Close()
    End Sub

    Public Sub agregar_comprobante()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "agregarcomprobante"
            cm.Parameters.AddWithValue("@num_fac", CInt(Ventas.lv_ventas.SelectedItems(0).Text))
            cm.Parameters.AddWithValue("@comp", CInt(txt_comprobante.Text))
            cm.Connection = cn
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            DetalleVenta.txt_comprobante.Text = txt_comprobante.Text
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub Comprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class