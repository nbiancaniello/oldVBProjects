Public Class Acceso

    Private Sub Acceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BaseDeDatos.MdiParent = Me
        BaseDeDatos.Show()
    End Sub
End Class