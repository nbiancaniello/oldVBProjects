Public Class solapa_abm

    Private Sub btn_localidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_localidad.Click
        gv_catalogo = 1
        abm_mantenimiento.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_nacionalidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nacionalidades.Click
        gv_catalogo = 3
        abm_mantenimiento.ShowDialog()
    End Sub

    Private Sub btn_titulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_titulos.Click
        gv_catalogo = 6
        abm_mantenimiento.ShowDialog()
    End Sub

    Private Sub btn_lugares_nac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lugares_nac.Click
        gv_catalogo = 5
        abm_mantenimiento.ShowDialog()
    End Sub

    Private Sub solapa_abm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento - " & gv_nombre_sistema
    End Sub
End Class