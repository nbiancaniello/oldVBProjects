Public Class Principal

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ventana_principal.MdiParent = Me
        Ventana_principal.Show()
    End Sub
End Class
