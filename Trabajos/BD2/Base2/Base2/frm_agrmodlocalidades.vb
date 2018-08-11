Imports System.Data.SqlClient
Public Class frm_agrmodlocalidades

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_agrmodlocalidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Accion = eAccion.MODIFICAR Then
            txt_cp.Text = frm_localidades.lv_localidades.SelectedItems(0).Text
            txt_localidad.Text = frm_localidades.lv_localidades.SelectedItems(0).SubItems(1).Text
            txt_cp.Enabled = False
            Me.Text = "Modificar Localidad"
        Else
            txt_cp.Clear()
            txt_localidad.Clear()
            txt_cp.Enabled = True
            Me.Text = "Agregar Localidad"
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        Dim ok As Boolean = True

        If CDbl(txt_cp.Text) < 1000 Then
            ok = False
            MessageBox.Show("El código postal debe ser mayor a 1000")
        End If
        If txt_localidad.Text.Trim = "" Then
            ok = False
            MessageBox.Show("La localidad no debe estar vacía")
        End If
        If ok Then
            Try
                If verificar_existencia(CShort(txt_cp.Text)) = False Then
                    CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = TP4; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = sspi"
                    CM.CommandType = CommandType.Text
                    If Accion = eAccion.AGREGAR Then
                        CM.CommandText = "INSERT INTO LOCALIDADES (CP,LOCALIDAD) VALUES (" & txt_cp.Text & ",'" & txt_localidad.Text.Trim & "')"
                    Else
                        CM.CommandText = "UPDATE LOCALIDADES SET LOCALIDAD = '" & Me.txt_localidad.Text.Trim & "' WHERE CP = " & Me.txt_cp.Text
                    End If
                    CM.Connection = CN
                    CN.Open()
                    CM.ExecuteNonQuery()
                    CN.Close()
                    If Accion = eAccion.AGREGAR Then

                        With frm_localidades.lv_localidades
                            .Items.Add(txt_cp.Text)
                            .Items((frm_localidades.lv_localidades.Items.Count) - 1).SubItems.Add(txt_localidad.Text.Trim)
                        End With

                    Else
                        With frm_localidades.lv_localidades
                            .SelectedItems(0).Text = txt_cp.Text
                            .SelectedItems(0).SubItems(1).Text = txt_localidad.Text.Trim
                        End With
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("El código postal ya existe")
                End If
            Catch ex As Exception
                MessageBox.Show("Problema con los datos")
            Finally
                CN.Dispose()
                CM.Dispose()
            End Try
        End If
    End Sub

    Private Sub txt_cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cp.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class