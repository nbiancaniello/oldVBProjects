Public Class mainmenu

    Private Sub mnu_archivo_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_archivo_salir.Click
        End
    End Sub

    Private Sub mnu_abrir_localidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_abrir_localidades.Click
        frm_localidades.MdiParent = Me
        frm_localidades.Show()
    End Sub

    Private Sub mnu_abrir_clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_abrir_clientes.Click
        frm_clientes.MdiParent = Me
        frm_clientes.Show()
    End Sub
End Class
