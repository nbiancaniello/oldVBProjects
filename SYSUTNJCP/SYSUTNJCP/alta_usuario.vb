Imports System.Data.SqlClient
Public Class alta_usuario

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpiar_cajas_alta_usuario()
        Me.Close()
    End Sub

    Private Sub limpiar_cajas_alta_usuario()
        Try
            txt_usuario.Clear()
            txt_clave.Clear()
            cmb_tipo_permiso.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If verificar_cajas_vacias_alta_usuario() = True Then
                If verificar_repetido(txt_usuario.Text) = False Then
                    If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If registrar_usuario() = True Then
                            MessageBox.Show("Usuario Registrado Satisfactoriamente")
                            limpiar_cajas_alta_usuario()
                            Me.Close()
                        End If
                    Else
                        limpiar_cajas_alta_usuario()
                        txt_usuario.Focus()
                    End If
                Else
                    MessageBox.Show("El Usuario ya está Registrado")
                    limpiar_cajas_alta_usuario()
                    txt_usuario.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_cajas_vacias_alta_usuario() As Boolean
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

    Private Function registrar_usuario() As Boolean
        Dim tran As SqlTransaction
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "registrar_usuario"
            com.Parameters.AddWithValue("@usu", txt_usuario.Text.ToLower)
            com.Parameters.AddWithValue("@pass", txt_clave.Text)
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

    Private Sub alta_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Alta Usuario - " & gv_nombre_sistema
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class