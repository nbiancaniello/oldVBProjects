Public Class Ventana_principal

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ventas.Click
        Accion = eAccion.Ver
        aAnterior = eAccion.Ver
        Ventas.ShowDialog()
    End Sub

    Private Sub btn_proveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proveedores.Click
    End Sub

    Private Sub btn_productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productos.Click
        Accion = eAccion.Ver
        aAnterior = eAccion.Ver
        Productos.ShowDialog()
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        Compras.ShowDialog()
    End Sub

    Private Sub Ventana_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class