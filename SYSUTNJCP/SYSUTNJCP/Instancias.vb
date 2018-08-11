Imports System.Data.SqlClient
Public Class Instancias
    Dim gv_instancia As Byte
    Dim gv_motivo As String
    Private Sub Instancias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargar_meses(cmb_mes)
            traer_instancias()
            lbl_instancias.Text = lbl_instancias.Text & " " & Now.Year.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub traer_instancias()
        Dim dr As SqlDataReader
        Dim i As Int16 = 0
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Try
            lsv_instancias.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_instancias_anio"
            com.Parameters.AddWithValue("@anio", Now.Year)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                lsv_instancias.Items.Add(Now.Year.ToString)
                lsv_instancias.Items(i).SubItems.Add(dr.GetByte(0).ToString)
                lsv_instancias.Items(i).SubItems.Add(dr.GetByte(1).ToString)
                lsv_instancias.Items(i).SubItems.Add(devolver_mes(dr.GetByte(1)))
                i = CShort(i + 1)
            End While
            dr.Close()
            con.Close()
            gv_instancia = CByte(i + 1)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alta.Click
        Try
            gv_motivo = "A"
            grp_instancias.Enabled = True
            txt_num.Text = gv_instancia.ToString
            btn_alta.Enabled = False
            btn_modificar.Enabled = False
            btn_baja.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar_alta.Click
        Try
            If cmb_mes.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un mes")
                cmb_mes.Focus()
                Exit Sub
            End If
            If gv_motivo = "A" Then
                If Not verificar_instancia_anterior() Then
                    MessageBox.Show("El mes seleccionado es inválido. Reintente")
                    cmb_mes.Focus()
                    Exit Sub
                End If
                If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If registrar_instancia() Then
                        MessageBox.Show("Registro agregado Correctamente")
                        lsv_instancias.Items.Add(Now.Year.ToString)
                        lsv_instancias.Items(lsv_instancias.Items.Count - 1).SubItems.Add(gv_instancia.ToString)
                        lsv_instancias.Items(lsv_instancias.Items.Count - 1).SubItems.Add(CStr(cmb_mes.SelectedIndex + 1))
                        lsv_instancias.Items(lsv_instancias.Items.Count - 1).SubItems.Add(devolver_mes(CByte(cmb_mes.SelectedIndex + 1)))
                        Exit Sub
                    End If
                End If
            Else
                If CInt(lsv_instancias.SelectedItems(0).SubItems(2).Text) = cmb_mes.SelectedIndex + 1 Then
                    MessageBox.Show("Seleccione un mes distinto al registrado")
                    cmb_mes.Focus()
                    Exit Sub
                End If
                If Not verificar_instancia_anterior() Then
                    MessageBox.Show("El mes seleccionado es inválido. Reintente")
                    cmb_mes.Focus()
                    Exit Sub
                End If
                If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If modificar_instancia() Then
                        MessageBox.Show("Registro modificado Correctamente")
                        lsv_instancias.Items(lsv_instancias.Items.Count).SubItems(2).Text = CStr(cmb_mes.SelectedIndex + 1)
                        lsv_instancias.Items(lsv_instancias.Items.Count).SubItems(2).Text = devolver_mes(CByte(cmb_mes.SelectedIndex + 1))
                        Exit Sub
                    End If
                End If
            End If
            btn_alta.Enabled = True
            btn_modificar.Enabled = True
            btn_baja.Enabled = True
            grp_instancias.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_instancia_anterior() As Boolean
        Try
            If lsv_instancias.Items.Count = 0 Then
                Return True
            End If
            If CInt(lsv_instancias.Items(lsv_instancias.Items.Count - 1).SubItems(2).Text) >= cmb_mes.SelectedIndex + 1 Then
                Return False
            End If
            If gv_motivo = "M" Then
                If (lsv_instancias.Items.Count > (lsv_instancias.SelectedIndices(0) + 1)) Then
                    If CInt(lsv_instancias.SelectedItems(lsv_instancias.SelectedIndices(0) + 1).SubItems(2).Text) >= cmb_mes.SelectedIndex + 1 Then
                        Return False
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Function registrar_instancia() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim tran As SqlTransaction
        Try

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "registrar_instancia"
            com.Parameters.AddWithValue("@anio", Now.Year)
            com.Parameters.AddWithValue("@inst", gv_instancia)
            com.Parameters.AddWithValue("@mes", cmb_mes.SelectedIndex + 1)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Function modificar_instancia() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim tran As SqlTransaction
        Try

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "modificar_instancia"
            com.Parameters.AddWithValue("@anio", Now.Year)
            com.Parameters.AddWithValue("@inst", gv_instancia)
            com.Parameters.AddWithValue("@mes", cmb_mes.SelectedIndex + 1)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            If lsv_instancias.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un registro")
                Exit Sub
            End If
            gv_motivo = "M"
            grp_instancias.Enabled = True
            txt_num.Text = lsv_instancias.SelectedItems(0).SubItems(1).Text
            btn_alta.Enabled = False
            btn_modificar.Enabled = False
            btn_baja.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baja.Click
        If MessageBox.Show("Se eliminará la última instancia ¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If eliminar_instancia() Then
                lsv_instancias.Items(lsv_instancias.Items.Count - 1).Remove()
                MessageBox.Show("Registro eliminado Correctamente")
                Exit Sub
            End If
        End If
    End Sub

    Private Function eliminar_instancia() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim tran As SqlTransaction
        Try

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "eliminar_instancia"
            com.Parameters.AddWithValue("@anio", Now.Year)
            com.Parameters.AddWithValue("@inst", lsv_instancias.Items(lsv_instancias.Items.Count - 1).SubItems(1).Text)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            cmb_mes.SelectedIndex = -1
            txt_num.Clear()
            grp_instancias.Enabled = False
            btn_alta.Enabled = True
            btn_modificar.Enabled = True
            btn_baja.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class