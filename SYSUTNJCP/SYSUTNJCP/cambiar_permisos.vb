Imports System.Data.SqlClient
Public Class cambiar_permisos

    Private Sub cambiar_permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cambiar Permiso - " & gv_nombre_sistema
        limpiar_cajas_cambiar_permisos()
    End Sub

    Private Sub limpiar_cajas_cambiar_permisos()
        Try
            txt_usuario.Clear()
            cmb_tipo_permiso.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_cajas_vacias_permisos() As Boolean
        Try
            If txt_usuario.Text = "" Then
                MessageBox.Show("Ingrese el usuario")
                txt_usuario.Focus()
                Return False
            End If
            If cmb_tipo_permiso.SelectedIndex = -1 Then
                MessageBox.Show("Elija el Tipo de Permiso")
                cmb_tipo_permiso.Focus()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Function cambiar_permiso() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "cambiar_permiso"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@usu", txt_usuario.Text)
            Select Case cmb_tipo_permiso.SelectedIndex
                Case 0 : com.Parameters.AddWithValue("@tipo", "T")
                Case 1 : com.Parameters.AddWithValue("@tipo", "P")
                Case 2 : com.Parameters.AddWithValue("@tipo", "A")
            End Select
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_aceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If verificar_cajas_vacias_permisos() = True Then
                If verificar_repetido(txt_usuario.Text) = True Then
                    If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If cambiar_permiso() = True Then
                            MessageBox.Show("Permiso Modificado Satisfactoriamente")
                            limpiar_cajas_cambiar_permisos()
                            Me.Close()
                        End If
                    Else
                        limpiar_cajas_cambiar_permisos()
                        txt_usuario.Focus()
                    End If
                Else
                    MessageBox.Show("Usuario inexistente")
                    limpiar_cajas_cambiar_permisos()
                    txt_usuario.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            limpiar_cajas_cambiar_permisos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class