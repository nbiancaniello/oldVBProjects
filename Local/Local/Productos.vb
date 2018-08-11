Imports System.Data.SqlClient
Public Class Productos

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lv_productos.Columns(10).Width = 0
            lv_productos.Columns(10).AutoResize(ColumnHeaderAutoResizeStyle.None)
            traer_productos()
            If Accion = eAccion.Seleccionar Then
                btn_agregar.Visible = False
                btn_eliminar.Visible = False
                btn_modificar.Visible = False
            Else
                btn_agregar.Visible = True
                btn_eliminar.Visible = True
                btn_modificar.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub traer_productos()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Byte = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "verproductos"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            lv_productos.Items.Clear()
            lv_productos.Visible = False
            If dr.HasRows = True Then
                While dr.Read()
                    lv_productos.Items.Add(dr.GetString(0).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetString(1).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetString(2).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetString(3).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetString(4).ToString)
                    If dr.IsDBNull(5) Then
                        lv_productos.Items(i).SubItems.Add("No hay detalle")
                    Else
                        lv_productos.Items(i).SubItems.Add(dr.GetString(5).ToString)
                    End If
                    lv_productos.Items(i).SubItems.Add(dr.GetDecimal(6).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetDecimal(7).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetByte(8).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetByte(9).ToString)
                    lv_productos.Items(i).SubItems.Add(dr.GetInt16(10).ToString)
                    i = CByte(i + 1)
                End While
                lv_productos.Visible = True
                cn.Close()
                dr.Close()
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            cn.Close()
            dr.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub lv_productos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_productos.DoubleClick
        Try
            If Accion = eAccion.Seleccionar Then
                If (CShort(lv_productos.SelectedItems(0).SubItems(8).Text) - CShort(lv_productos.SelectedItems(0).SubItems(9).Text)) > 0 Then
                    devolver_datos()
                Else
                    MessageBox.Show("No se puede vender este producto: Stock Actual menor o igual a stock mínimo")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            If lv_productos.Items.Count = 0 Then
                MessageBox.Show("No hay productos")
                Exit Sub
            End If
            If lv_productos.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar un registro de la lista")
                Exit Sub
            End If
            If MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                eliminar_producto()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub eliminar_producto()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Connection = cn
            cm.CommandText = "eliminarproducto"
            cm.Parameters.AddWithValue("@cod_int", CShort(lv_productos.SelectedItems(0).SubItems(10).Text))
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Producto Eliminado Satisfactoriamente")
            lv_productos.Items.RemoveAt(lv_productos.SelectedIndices(0))
        Catch ex As Exception
            MessageBox.Show("Problema con la base de datos")
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Accion = eAccion.Agregar
        Gestion_producto.ShowDialog()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            If lv_productos.Items.Count = 0 Then
                MessageBox.Show("No hay productos para modificar")
                Exit Sub
            End If
            If lv_productos.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un producto para modificar")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Accion = eAccion.Modificar
        Gestion_producto.ShowDialog()
    End Sub

    Private Sub btn_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtro.Click
        Accion = eAccion.Filtro
        Filtro_p.ShowDialog()
    End Sub

    Public Sub devolver_datos()
        Try
            traer_codigos()
            With RegistrarVenta
                .txt_marca.Text = lv_productos.SelectedItems(0).SubItems(1).Text
                .txt_rubro.Text = lv_productos.SelectedItems(0).SubItems(2).Text
                .txt_modelo.Text = lv_productos.SelectedItems(0).SubItems(3).Text
                .txt_detalle.Text = lv_productos.SelectedItems(0).SubItems(5).Text
                .txt_talle.Text = lv_productos.SelectedItems(0).SubItems(4).Text
                verificar_productos_agregados()
                .txt_precio_unitario.Text = lv_productos.SelectedItems(0).SubItems(7).Text
                .txt_costo.Text = lv_productos.SelectedItems(0).SubItems(6).Text
                .txt_cod_interno.Text = lv_productos.SelectedItems(0).SubItems(10).Text
                .txt_stock_min.Text = lv_productos.SelectedItems(0).SubItems(9).Text
            End With
            agregar = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_ver_todo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ver_todo.Click
        traer_productos()
    End Sub

    Public Sub verificar_productos_agregados()
        Dim i As Short
        Dim cadena As String = RegistrarVenta.txt_cod_anio.Text + RegistrarVenta.txt_cod_rubro.Text + RegistrarVenta.txt_cod_modelo.Text
        Try
            For i = 0 To CShort(RegistrarVenta.lv_productos.Items.Count - 1)
                If lv_productos.Items(i).Text = cadena Then
                    RegistrarVenta.txt_stock.Text = RegistrarVenta.lv_productos.Items(i).SubItems(9).Text
                End If
            Next
            RegistrarVenta.txt_stock.Text = CStr(CByte(lv_productos.SelectedItems(0).SubItems(8).Text) - CByte(lv_productos.SelectedItems(0).SubItems(9).Text))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lv_productos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lv_productos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Accion = eAccion.Seleccionar Then
                devolver_datos()
            End If
        End If
    End Sub

    Private Sub lv_productos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_productos.SelectedIndexChanged

    End Sub
End Class