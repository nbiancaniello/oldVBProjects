Imports System.Data.SqlClient
Public Class DetalleVenta

    Private Sub DetalleVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lv_detalle_venta.Columns(4).Width = 0
            lv_detalle_venta.Columns(4).AutoResize(ColumnHeaderAutoResizeStyle.None)
            Me.Text = "Detalle de Venta Factura Nº " + Ventas.lv_ventas.SelectedItems(0).Text
            traer_detalle_venta()
            traer_total_detalle_venta()
            traer_comprobante()
            If Ventas.lv_ventas.SelectedItems(0).SubItems(2).Text = "Contado" Then
                Me.Width = 448
                grp_cliente.Visible = False
                btn_comprobante.Visible = False
            Else
                Me.Width = 819
                grp_cliente.Visible = True
                If traer_cliente() = False Then
                    MessageBox.Show("El cliente no está registrado")
                End If
                btn_comprobante.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub traer_detalle_venta()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Byte = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "verdetalleventa"
            cm.Parameters.AddWithValue("@num_fac", Ventas.lv_ventas.SelectedItems(0).Text)
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            lv_detalle_venta.Items.Clear()
            lv_detalle_venta.Visible = False
            If dr.HasRows = True Then
                While dr.Read()
                    lv_detalle_venta.Items.Add(dr.GetString(0))
                    lv_detalle_venta.Items(i).SubItems.Add(dr.GetByte(1).ToString)
                    lv_detalle_venta.Items(i).SubItems.Add(dr.GetDecimal(2).ToString)
                    lv_detalle_venta.Items(i).SubItems.Add(dr.GetDecimal(3).ToString)
                    i = CByte(i + 1)
                End While
                lv_detalle_venta.Visible = True
                cn.Close()
                dr.Close()
            Else
                MessageBox.Show("No hay datos en la tabla")
                Me.Close()
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
    Private Sub traer_total_detalle_venta()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "vertotaldetalleventa"
            cm.Parameters.AddWithValue("@num_fac", Ventas.lv_ventas.SelectedItems(0).Text)
            cm.Connection = cn
            cn.Open()
            lbl_total_venta.Text = cm.ExecuteScalar.ToString
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Public Function traer_cliente() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traerclienteadetalle"
            cm.Parameters.AddWithValue("@num_fac", CInt(Ventas.lv_ventas.SelectedItems(0).Text))
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read()
                    txt_numero_cliente.Text = dr.GetInt16(0).ToString
                    txt_nombre.Text = dr.GetString(1)
                    txt_numero_dni.Text = dr.GetInt32(2).ToString
                    txt_direccion.Text = dr.GetString(3)
                    txt_localidad.Text = dr.GetString(4)
                    If dr.IsDBNull(5) Then
                        txt_telefono.Text = "No tiene"
                    Else
                        txt_telefono.Text = dr.GetString(5)
                    End If
                    If dr.IsDBNull(6) Then
                        txt_celular.Text = "No tiene"
                    Else
                        txt_celular.Text = dr.GetString(6)
                    End If
                    If dr.IsDBNull(7) Then
                        txt_email.Text = "No tiene"
                    Else
                        txt_email.Text = dr.GetString(7)
                    End If
                End While
            Else
                cn.Close()
                dr.Close()
                Return False
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
        Return True
    End Function

    Public Sub traer_comprobante()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traercomprobante"
            cm.Parameters.AddWithValue("@num_fac", CInt(Ventas.lv_ventas.SelectedItems(0).Text))
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read()
                    If dr.IsDBNull(0) Then
                        txt_comprobante.Text = "No ingresado"
                    Else
                        txt_comprobante.Text = dr.GetInt32(0).ToString
                    End If

                End While
            Else
                cn.Close()
                dr.Close()
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

    Private Sub btn_comprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobante.Click
        Comprobante.ShowDialog()
    End Sub
End Class