Imports System.Data.SqlClient
Public Class Ventas
    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        traer_ventas()
    End Sub

    Private Sub lv_ventas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_ventas.DoubleClick
        Accion = eAccion.Ver
        aAnterior = eAccion.Ver
        DetalleVenta.ShowDialog()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Accion = eAccion.Seleccionar
        aAnterior = eAccion.Seleccionar
        RegistrarVenta.ShowDialog()
    End Sub

    Private Sub btn_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anular.Click
        Try
            If lv_ventas.Items.Count = 0 Then
                MessageBox.Show("No hay Ventas")
                Exit Sub
            End If
            If lv_ventas.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar un registro de la lista")
                Exit Sub
            End If
            If lv_ventas.SelectedItems(0).SubItems(5).Text = "Anulada" Then
                MessageBox.Show("Esta venta ya fue anulada")
                Exit Sub
            End If
            If MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                anular_venta()
            End If
        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub

    Public Sub anular_venta()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Connection = cn
            cm.CommandText = "anularventa"
            cm.Parameters.AddWithValue("@num_fac", Convert.ToInt32(lv_ventas.SelectedItems(0).Text))
            cn.Open()
            cm.ExecuteNonQuery()
            MessageBox.Show("Venta Anulada Satisfactoriamente")
            lv_ventas.SelectedItems(0).SubItems(5).Text = "Anulada"
        Catch ex As Exception
            MessageBox.Show("Problema con la base de datos")
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try

    End Sub

    Public Sub traer_ventas()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Byte = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "verventas"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            lv_ventas.Items.Clear()
            lv_ventas.Visible = False
            If dr.HasRows = True Then
                While dr.Read()
                    lv_ventas.Items.Add(dr.GetInt32(0).ToString)
                    lv_ventas.Items(i).SubItems.Add(dr.GetDateTime(1).ToShortDateString + " " + dr.GetDateTime(1).ToLongTimeString)
                    lv_ventas.Items(i).SubItems.Add(dr.GetString(2).ToString)
                    lv_ventas.Items(i).SubItems.Add(dr.GetString(3).ToString)
                    lv_ventas.Items(i).SubItems.Add(dr.GetByte(4).ToString)
                    If dr.GetString(5) = "C" Then
                        lv_ventas.Items(i).SubItems.Add("Cerrada")
                    Else
                        lv_ventas.Items(i).SubItems.Add("Anulada")
                    End If

                    i = CByte(i + 1)
                End While
                lv_ventas.Visible = True
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            cn.Close()
            dr.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show("Existe un problema con el programa")
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub btn_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtro.Click
        Accion = eAccion.Filtro
        Filtro_v.ShowDialog()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Accion = eAccion.Ver
        Me.Close()
    End Sub

    Private Sub btn_ver_todo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ver_todo.Click
        traer_ventas()
    End Sub

    Private Sub lv_ventas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lv_ventas.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DetalleVenta.ShowDialog()
        End If
    End Sub
End Class