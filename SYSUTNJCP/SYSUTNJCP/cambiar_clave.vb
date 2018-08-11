Imports System.Data.SqlClient
Public Class cambiar_clave
    Public gv_usuario_ant As String
    Public gv_permiso_ant As String

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpiar_cajas_cambio_clave()
        Me.Close()
    End Sub

    Private Sub limpiar_cajas_cambio_clave()
        Try
            txt_clave.Clear()
            txt_clave_nueva.Clear()
            txt_clave_nueva_repetir.Clear()
            txt_usuario.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_vacíos_cambio_clave() As Boolean
        Try
            If txt_usuario.Text = "" Then
                MessageBox.Show("Ingrese el usuario")
                txt_usuario.Focus()
                Return False
            End If
            If txt_clave.Text = "" Then
                MessageBox.Show("Ingrese el password anterior")
                txt_clave.Focus()
                Return False
            End If
            If txt_clave_nueva.Text = "" Then
                MessageBox.Show("Ingrese el password nuevo")
                txt_clave_nueva.Focus()
                Return False
            End If
            If txt_clave_nueva_repetir.Text = "" Then
                MessageBox.Show("Repita el password nuevo")
                txt_clave_nueva_repetir.Focus()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Function cambiar_password() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "cambiar_password"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@usu", txt_usuario.Text)
            com.Parameters.AddWithValue("@new", txt_clave_nueva.Text)
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

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            gv_permiso_ant = gv_permiso
            gv_usuario_ant = gv_usuario
            If verificar_vacíos_cambio_clave() = True Then
                If verificar_password(txt_usuario.Text, txt_clave.Text) = True Then
                    If txt_clave_nueva.Text = txt_clave_nueva_repetir.Text Then
                        If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If cambiar_password() = True Then
                                MessageBox.Show("Password Modificado Exitósamente")
                            End If
                            limpiar_cajas_cambio_clave()
                            gv_permiso = gv_permiso_ant
                            gv_usuario = gv_usuario_ant
                            Me.Close()
                        Else
                            limpiar_cajas_cambio_clave()
                            txt_usuario.Focus()
                        End If
                    Else
                        txt_clave_nueva.Clear()
                        txt_clave_nueva_repetir.Clear()
                        MessageBox.Show("El password nuevo no coincide con el password reingresado")
                        txt_clave_nueva.Focus()
                        Exit Sub
                    End If
                Else
                    txt_clave.Clear()
                    txt_usuario.Clear()
                    txt_usuario.Focus()
                    MessageBox.Show("El usuario y/o la clave ingresada es incorrecta")
                End If
            End If
            gv_permiso = gv_permiso_ant
            gv_usuario = gv_usuario_ant
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cambio_clave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cambio de Clave - " & gv_nombre_sistema
    End Sub
End Class