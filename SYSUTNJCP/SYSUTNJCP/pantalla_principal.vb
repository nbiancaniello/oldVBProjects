Public Class pantalla_principal

    Private Sub pantalla_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = gv_nombre_sistema
            'establecer_permisos()
            retocar_formulario(Me, "Pantalla Principal")
            traer_datos_de_tablas()
            traer_cantidad_materias_por_etapa()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_inscripciones_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inscripciones_alu.Click
        altas_alumnos.ShowDialog()
    End Sub

    Private Sub btn_status_materias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_status_materias.Click
        notas_por_alumno_introductorio.ShowDialog()
    End Sub

    Private Sub btn_plan_carrera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plan_carrera.Click
        gv_carrera = 0
        planillas_asistencia.ShowDialog()
    End Sub

    Private Sub btn_asistencia_por_materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asistencia_por_materia.Click
        asistencias_introductorio.ShowDialog()
    End Sub

    Private Sub btn_datos_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_datos_alu.Click
        gv_carrera = 0
        datospersonales_alumnos.ShowDialog()
    End Sub

    Private Sub btn_baja_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baja_alu.Click
        gv_carrera = 0
        bajas_alumnos.ShowDialog()
    End Sub

    Private Sub btn_nuevo_docente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo_docente.Click
        altas_profesores.ShowDialog()
    End Sub

    Private Sub btn_definiciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_definiciones.Click
        solapa_abm.ShowDialog()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        ds.Dispose()
        Me.Close()
    End Sub

    Private Sub btnacerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacerca.Click
        acercade.ShowDialog()
    End Sub
End Class
