Imports System.Data.SqlClient
Public Class baja_usuario

    Private Function eliminar_usuario() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "eliminar_usuario"
            com.Parameters.AddWithValue("@usu", txt_usuario.Text)
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
        End Try
    End Function

    Private Sub baja_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Baja Usuario - " & gv_nombre_sistema
        txt_usuario.Clear()
    End Sub

    Private Sub btn_aceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If txt_usuario.Text = "" Then
                MessageBox.Show("Ingrese el usuario")
                txt_usuario.Focus()
                Exit Sub
            End If
            If verificar_repetido(txt_usuario.Text) = True Then
                If gv_usuario = txt_usuario.Text Then
                    MessageBox.Show("No se puede Eliminar el Usuario Activo")
                    txt_usuario.Clear()
                    txt_usuario.Focus()
                    Exit Sub
                End If
                If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If eliminar_usuario() = True Then
                        MessageBox.Show("Usuario Eliminado Éxitosamente")
                        txt_usuario.Clear()
                        Me.Close()
                    End If
                Else
                    txt_usuario.Clear()
                    txt_usuario.Focus()
                End If
            Else
                MessageBox.Show("Usuario Inexistente")
                txt_usuario.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class