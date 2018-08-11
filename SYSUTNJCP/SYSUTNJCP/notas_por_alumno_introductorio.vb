Imports System.Data.SqlClient
Public Class notas_por_alumno_introductorio

    Private Sub notas_por_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargar_anios(cmb_anios)
            cmb_anios.SelectedIndex = -1
            traer_instancias_a_control(cmb_instancia)
            limpiar_pantalla()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub limpiar_pantalla()
        Try
            lsv_alumnos_inscriptos.Items.Clear()
            lsv_materias_por_alumno.Items.Clear()
            lsv_final.Items.Clear()
            lsv_diagnostico.Items.Clear()
            lsv_recuperatorio.Items.Clear()
            btn_diag_aprobado.Enabled = False
            btn_diag_desaprobado.Enabled = False
            btn_final_aprobado.Enabled = False
            btn_final_desaprobado.Enabled = False
            btn_rec_aprobado.Enabled = False
            btn_rec_desaprobado.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Try
            If cmb_anios.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Año")
                cmb_anios.Focus()
                Exit Sub
            End If
            If cmb_instancia.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione Instancia")
                cmb_instancia.Focus()
                Exit Sub
            End If
            limpiar_pantalla()
            If Not traer_alumnos_introductorio_filtro1() Then
                MessageBox.Show("No se encontraron registros")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function traer_alumnos_introductorio_filtro1() As Boolean
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_alumnos_introductorio_filtro1"
            com.Parameters.AddWithValue("@anio", cmb_anios.Items(cmb_anios.SelectedIndex))
            com.Parameters.AddWithValue("@eta", cmb_instancia.SelectedIndex + 1)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lsv_alumnos_inscriptos.Items.Add(dr.GetInt16(0).ToString)
                    lsv_alumnos_inscriptos.Items(i).SubItems.Add(dr.GetInt16(1).ToString)
                    lsv_alumnos_inscriptos.Items(i).SubItems.Add(dr.GetString(2) & "," & dr.GetString(3))
                    i = CShort(i + 1)
                End While
                dr.Close()
                con.Close()
                Return True
            Else
                dr.Close()
                con.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub lsv_alumnos_inscriptos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_alumnos_inscriptos.KeyDown
        Try
            traer_info_materias()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_alumnos_inscriptos.KeyUp
        Try
            traer_info_materias()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_alumnos_inscriptos_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_alumnos_inscriptos.MouseClick
        Try
            traer_info_materias()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub traer_info_materias()
        Try
            lsv_diagnostico.Items.Clear()
            lsv_final.Items.Clear()
            lsv_recuperatorio.Items.Clear()
            btn_diag_aprobado.Enabled = False
            btn_diag_desaprobado.Enabled = False
            btn_final_aprobado.Enabled = False
            btn_final_desaprobado.Enabled = False
            btn_rec_aprobado.Enabled = False
            btn_rec_desaprobado.Enabled = False
            traer_materias_por_alumno_introductorio(lsv_materias_por_alumno, CShort(lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text), _
                                        CShort(lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text), CShort(cmb_anios.Items(cmb_anios.SelectedIndex).ToString) _
                                        , CByte(cmb_instancia.SelectedIndex + 1), 0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_materias_por_alumno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_materias_por_alumno.KeyDown
        Try
            traer_info_notas_introductorio()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_materias_por_alumno_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_materias_por_alumno.KeyUp
        Try
            traer_info_notas_introductorio()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lsv_materias_por_alumno_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_materias_por_alumno.MouseClick
        Try
            traer_info_notas_introductorio()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub traer_info_notas_introductorio()
        Dim dr As SqlDataReader

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            lsv_diagnostico.Items.Clear()
            lsv_final.Items.Clear()
            lsv_recuperatorio.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_info_notas_introductorio"
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@ing", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.Parameters.AddWithValue("@cod", lsv_materias_por_alumno.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_materias_por_alumno.SelectedItems(0).SubItems(3).Text)
            com.Parameters.AddWithValue("@eta", lsv_materias_por_alumno.SelectedItems(0).SubItems(2).Text)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Select Case dr.GetString(2)
                        Case "D"
                            lsv_diagnostico.Items.Add(dr.GetDateTime(0).ToShortDateString)
                            lsv_diagnostico.Items(0).SubItems.Add(devolver_letra_numero(dr.GetByte(1)))
                            btn_diag_aprobado.Enabled = False
                            btn_diag_desaprobado.Enabled = False
                            If lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text <> "CURSANDO" Then
                                btn_final_aprobado.Enabled = True
                                btn_final_desaprobado.Enabled = True
                            Else
                                btn_final_aprobado.Enabled = False
                                btn_final_desaprobado.Enabled = False
                            End If
                        Case "F"
                            lsv_final.Items.Add(dr.GetDateTime(0).ToShortDateString)
                            lsv_final.Items(0).SubItems.Add(devolver_letra_numero(dr.GetByte(1)))
                            btn_final_aprobado.Enabled = False
                            btn_final_desaprobado.Enabled = False
                            If dr.GetByte(1) = 12 Then
                                btn_rec_aprobado.Enabled = True
                                btn_rec_desaprobado.Enabled = True
                            End If
                        Case "R"
                            lsv_recuperatorio.Items.Add(dr.GetDateTime(0).ToShortDateString)
                            lsv_recuperatorio.Items(0).SubItems.Add(devolver_letra_numero(dr.GetByte(1)))
                    End Select
                End While
            Else
                btn_diag_aprobado.Enabled = True
                btn_diag_desaprobado.Enabled = True
                btn_final_aprobado.Enabled = False
                btn_final_desaprobado.Enabled = False
                btn_rec_aprobado.Enabled = False
                btn_rec_desaprobado.Enabled = False
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Private Sub btn_diag_aprobado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_diag_aprobado.Click
        Dim estado As String
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                estado = verificar_cursada_obligatoria
                If asignar_nota_introductorio("D", 11) And actualizar_estado_introductorio(estado) Then
                    MessageBox.Show("Registro actualizado correctamente")
                    lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text = devolver_estado_materia(estado)
                    lsv_diagnostico.Items.Add(Now.Date.ToShortDateString)
                    lsv_diagnostico.Items(0).SubItems.Add(devolver_letra_numero(11))
                    btn_diag_aprobado.Enabled = False
                    btn_diag_desaprobado.Enabled = False
                    If lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text <> "CURSANDO" Then
                        btn_final_aprobado.Enabled = True
                        btn_final_desaprobado.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_cursada_obligatoria() As String
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim dr As SqlDataReader
        Dim estado As String
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "verificar_cursada_obligatoria"
            com.Parameters.AddWithValue("@cod", lsv_materias_por_alumno.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_materias_por_alumno.SelectedItems(0).SubItems(3).Text)
            com.Parameters.AddWithValue("@eta", lsv_materias_por_alumno.SelectedItems(0).SubItems(2).Text)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                If dr.GetBoolean(0) Then
                    estado = "C"
                Else
                    estado = "F"
                End If
            End While
            dr.Close()
            con.Close()
            Return estado
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return ""
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return "F"
    End Function

    Private Function actualizar_estado_introductorio(ByVal estado As String) As Boolean
        Dim tran As SqlTransaction

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "actualizar_estado_introductorio"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@ing", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.Parameters.AddWithValue("@cod", lsv_materias_por_alumno.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_materias_por_alumno.SelectedItems(0).SubItems(3).Text)
            com.Parameters.AddWithValue("@eta", lsv_materias_por_alumno.SelectedItems(0).SubItems(2).Text.Substring(0, 1))
            com.Parameters.AddWithValue("@est", estado)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return True
    End Function

    Private Function asignar_nota_introductorio(ByVal evaluacion As String, ByVal nota As Byte) As Boolean
        Dim tran As SqlTransaction

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "asignar_nota_introductorio"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@ing", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.Parameters.AddWithValue("@cod", lsv_materias_por_alumno.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", lsv_materias_por_alumno.SelectedItems(0).SubItems(3).Text)
            com.Parameters.AddWithValue("@eta", lsv_materias_por_alumno.SelectedItems(0).SubItems(2).Text.Substring(0, 1))
            com.Parameters.AddWithValue("@eva", evaluacion)
            com.Parameters.AddWithValue("@nota", nota)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return True
    End Function

    Private Sub btn_final_aprobado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_final_aprobado.Click
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If asignar_nota_introductorio("F", 11) And actualizar_estado_introductorio("A") Then
                    MessageBox.Show("Registro actualizado correctamente")
                End If
            End If
            lsv_final.Items.Add(Now.Date.ToShortDateString)
            lsv_final.Items(0).SubItems.Add(devolver_letra_numero(11))
            btn_final_aprobado.Enabled = False
            btn_final_desaprobado.Enabled = False
            lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text = devolver_estado_materia("A")
            If verificar_estado_introductorio Then
                If inscripcion_primer_cuatrimestre() Then
                    MessageBox.Show("Se han asignado las materias del 1º Cuatrimestre al alumnos " _
                                    & lsv_alumnos_inscriptos.SelectedItems(0).SubItems(2).Text)
                    lsv_alumnos_inscriptos.Items.RemoveAt(lsv_alumnos_inscriptos.SelectedIndices(0))
                    lsv_diagnostico.Items.Clear()
                    lsv_final.Items.Clear()
                    lsv_recuperatorio.Items.Clear()
                    lsv_materias_por_alumno.Items.Clear()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_rec_aprobado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rec_aprobado.Click
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If asignar_nota_introductorio("R", 11) And actualizar_estado_introductorio("A") Then
                    MessageBox.Show("Registro actualizado correctamente")
                    lsv_recuperatorio.Items.Add(Now.Date.ToShortDateString)
                    lsv_recuperatorio.Items(0).SubItems.Add(devolver_letra_numero(11))
                    btn_rec_aprobado.Enabled = False
                    btn_rec_desaprobado.Enabled = False
                    lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text = devolver_estado_materia("A")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_diag_desaprobado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_diag_desaprobado.Click
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If asignar_nota_introductorio("D", 12) And actualizar_estado_introductorio("C") Then
                    MessageBox.Show("Registro actualizado correctamente")
                    lsv_diagnostico.Items.Add(Now.Date.ToShortDateString)
                    lsv_diagnostico.Items(0).SubItems.Add(devolver_letra_numero(12))
                    btn_diag_aprobado.Enabled = False
                    btn_diag_desaprobado.Enabled = False
                    btn_final_aprobado.Enabled = True
                    btn_final_desaprobado.Enabled = True
                    lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text = devolver_estado_materia("C")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_final_desaprobado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_final_desaprobado.Click
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If asignar_nota_introductorio("F", 12) And actualizar_estado_introductorio("T") Then
                    MessageBox.Show("Registro actualizado correctamente")
                    lsv_final.Items.Add(Now.Date.ToShortDateString)
                    lsv_final.Items(0).SubItems.Add(devolver_letra_numero(12))
                    btn_final_aprobado.Enabled = False
                    btn_final_desaprobado.Enabled = False
                    btn_rec_aprobado.Enabled = True
                    btn_rec_desaprobado.Enabled = True
                    lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text = devolver_estado_materia("T")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_rec_desaprobado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rec_desaprobado.Click
        Try
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If asignar_nota_introductorio("R", 12) And actualizar_estado_introductorio("R") Then
                    If reasignar_materia_introductorio() Then
                        MessageBox.Show("Registro actualizado correctamente")
                        lsv_recuperatorio.Items.Add(Now.Date.ToShortDateString)
                        lsv_recuperatorio.Items(0).SubItems.Add(devolver_letra_numero(12))
                        btn_rec_aprobado.Enabled = False
                        btn_rec_desaprobado.Enabled = False
                        lsv_materias_por_alumno.SelectedItems(0).SubItems(4).Text = devolver_estado_materia("R")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_estado_introductorio() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim cant As Int16
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "verificar_estado_introductorio"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", CShort(lsv_alumnos_inscriptos.SelectedItems(0).Text))
            com.Parameters.AddWithValue("@anio", CShort(lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text))
            con.Open()
            cant = CShort(com.ExecuteScalar)
            con.Close()
            If cant = gv_cant_materias_introductorio Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function
    Private Function inscripcion_primer_cuatrimestre() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim cuat As Byte
        Dim anio As Int16
        Dim tran As SqlTransaction
        Try
            If devolver_numero_mes(cmb_instancia.SelectedText) <= 2 Then
                cuat = 1
                anio = CShort(Now.Year)
            End If
            If devolver_numero_mes(cmb_instancia.SelectedText) <= 7 And devolver_numero_mes(cmb_instancia.SelectedText) >= 3 Then
                cuat = 2
                anio = CShort(Now.Year)
            End If
            If devolver_numero_mes(cmb_instancia.SelectedText) > 7 Then
                cuat = 1
                anio = CShort(CShort(Now.Year) + 1)
            End If
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "inscripcion_primer_cuatrimestre"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).Text)
            com.Parameters.AddWithValue("@ing", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.Parameters.AddWithValue("@anio", anio)
            com.Parameters.AddWithValue("@cuat", cuat)
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return True
    End Function

    Private Function reasignar_materia_introductorio() As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim instancia As Byte
        Dim anio As Int16
        Dim tran As SqlTransaction

        Try
            If cmb_instancia.SelectedIndex + 1 = cmb_instancia.Items.Count Then
                instancia = 1
                anio = CShort(CShort(cmb_anios.Items(cmb_anios.SelectedIndex).ToString) + 1)
            Else
                anio = CShort(Now.Year)
                instancia = CByte(cmb_instancia.SelectedIndex + 1)
            End If
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "reasignar_materia_introductorio"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@nro", lsv_alumnos_inscriptos.SelectedItems(0).Text)
            com.Parameters.AddWithValue("@ing", lsv_alumnos_inscriptos.SelectedItems(0).SubItems(1).Text)
            com.Parameters.AddWithValue("@cod", lsv_materias_por_alumno.SelectedItems(0).SubItems(0).Text)
            com.Parameters.AddWithValue("@anio", anio)
            com.Parameters.AddWithValue("@eta", instancia)
            com.Parameters.AddWithValue("@est", "D")
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return True
    End Function
End Class