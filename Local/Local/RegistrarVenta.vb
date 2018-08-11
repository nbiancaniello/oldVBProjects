Imports System.Data.SqlClient
Public Class RegistrarVenta
    Dim concretar As Boolean
    Private Sub btn_traer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_traer.Click
        Try
            If verificar_codigos() = False Then
                Exit Sub
            End If
            If buscar_codigo() = False Then
                MessageBox.Show("No hay productos para mostrar")
                limpiar_cajas_detalle_ventas()
                txt_cod_anio.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function verificar_codigos() As Boolean
        Try
            If txt_cod_anio.Text.Trim = "" Then
                MessageBox.Show("Ingrese Código de Año")
                txt_cod_anio.Focus()
                Return False
            Else
                If verificarnumeronatural(txt_cod_anio.Text) = False Then
                    MessageBox.Show("Código de Año incorrecto")
                    txt_cod_anio.Focus()
                    Exit Function
                End If
                If CShort(txt_cod_anio.Text) = 0 Then
                    MessageBox.Show("El Código de Año debe ser mayor a 0")
                    txt_cod_anio.Focus()
                    Return False
                    Exit Function
                End If
                If CShort(txt_cod_anio.Text) > 256 Then
                    MessageBox.Show("Código de año mayor al permitido")
                    txt_cod_anio.Focus()
                    Return False
                End If
            End If

            If txt_cod_rubro.Text.Trim = "" Then
                MessageBox.Show("Ingrese Código de Rubro")
                txt_cod_rubro.Focus()
                Return False
            Else
                If verificarnumeronatural(txt_cod_rubro.Text) = False Then
                    MessageBox.Show("Código de Rubro incorrecto")
                    txt_cod_rubro.Focus()
                    Exit Function
                End If
                If CShort(txt_cod_rubro.Text) = 0 Then
                    MessageBox.Show("El Código de Rubro debe ser mayor a 0")
                    txt_cod_rubro.Focus()
                    Return False
                    Exit Function
                End If
                If CShort(txt_cod_rubro.Text) > 256 Then
                    MessageBox.Show("Código de rubro mayor al permitido")
                    txt_cod_rubro.Focus()
                    Return False
                End If
            End If

            If txt_cod_modelo.Text.Trim = "" Then
                MessageBox.Show("Ingrese Código de Modelo")
                txt_cod_modelo.Focus()
                Return False
            Else
                If verificarnumeronatural(txt_cod_modelo.Text) = False Then
                    MessageBox.Show("Código de Modelo incorrecto")
                    txt_cod_modelo.Focus()
                    Exit Function
                End If
                If CShort(txt_cod_modelo.Text) = 0 Then
                    MessageBox.Show("El Código de Modelo debe ser mayor a 0")
                    txt_cod_modelo.Focus()
                    Return False
                    Exit Function
                End If
                If CShort(txt_cod_modelo.Text) > 256 Then
                    MessageBox.Show("Código de Modelo mayor al permitido")
                    txt_cod_modelo.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Public Function buscar_codigo() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traerproducto"
            If Accion = eAccion.Seleccionar Then
                cm.Parameters.AddWithValue("@anio", txt_cod_anio.Text)
                cm.Parameters.AddWithValue("@rubro", txt_cod_rubro.Text)
                cm.Parameters.AddWithValue("@modelo", txt_cod_modelo.Text)
            End If
            If Accion = eAccion.Ver Then
                cm.Parameters.AddWithValue("@anio", txt_cod_anio.Text)
                cm.Parameters.AddWithValue("@rubro", txt_cod_rubro.Text)
                cm.Parameters.AddWithValue("@modelo", txt_cod_modelo.Text)
            End If

            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read()
                    txt_marca.Text = dr.GetString(0)
                    txt_rubro.Text = dr.GetString(1)
                    txt_modelo.Text = dr.GetString(2)
                    If dr.IsDBNull(3) Then
                        txt_detalle.Text = "No hay detalles"
                    Else
                        txt_detalle.Text = dr.GetString(3)
                    End If
                    txt_talle.Text = dr.GetString(4)
                    txt_stock.Text = CStr(CByte(dr.GetByte(5).ToString) - CByte(dr.GetByte(6).ToString))
                    txt_precio_unitario.Text = dr.GetDecimal(7).ToString
                    txt_cod_interno.Text = dr.GetInt16(8).ToString
                    txt_costo.Text = dr.GetDecimal(9).ToString
                    txt_stock_min.Text = dr.GetByte(6).ToString
                    agregar = True
                End While
            Else
                cn.Close()
                dr.Close()
                agregar = False
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
    Public Sub limpiar_cajas_detalle_ventas()
        txt_cantidad.Text = ""
        txt_cod_anio.Text = ""
        txt_cod_modelo.Text = ""
        txt_cod_rubro.Text = ""
        txt_marca.Text = ""
        txt_rubro.Text = ""
        txt_modelo.Text = ""
        txt_detalle.Text = ""
        txt_talle.Text = ""
        txt_stock.Text = ""
    End Sub

    Private Sub btn_lista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lista.Click
        Accion = eAccion.Seleccionar
        Productos.ShowDialog()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If concretar = True Then
                btn_concretar.Enabled = True
                cbo_empresa.Enabled = True
                cbo_tipo_pago.Enabled = True
                txt_cuotas.Enabled = True
                grp_detalle.Enabled = False
            Else
                MessageBox.Show("Debe registrar un producto para poder efectuar la venta")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Try
            limpieza_general()
            concretar = False
            btn_aceptar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub RegistrarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lv_productos.Columns(8).Width = 0
            lv_productos.Columns(8).AutoResize(ColumnHeaderAutoResizeStyle.None)
            lv_productos.Columns(9).Width = 0
            lv_productos.Columns(9).AutoResize(ColumnHeaderAutoResizeStyle.None)
            lv_productos.Columns(10).Width = 0
            lv_productos.Columns(10).AutoResize(ColumnHeaderAutoResizeStyle.None)
            lv_productos.Columns(11).Width = 0
            lv_productos.Columns(11).AutoResize(ColumnHeaderAutoResizeStyle.None)
            agregar = False
            concretar = False
            btn_aceptar.Enabled = False
            cbo_empresa.Enabled = False
            cbo_tipo_pago.Enabled = False
            txt_cuotas.Enabled = False
            txt_numero_cliente.Enabled = False
            grp_detalle.Enabled = True
            txt_numero_factura.Text = traer_ultima_factura.ToString
            limpieza_general()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_agregar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar_producto.Click
        Try
            If agregar = True Then
                If validar_cantidad() = False Then
                    Exit Sub
                End If
                insertar_registro()
                concretar = True
                btn_aceptar.Enabled = True
                limpiar_cajas_detalle_ventas()
            Else
                MessageBox.Show("Debe elegir un producto para poder registrar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub insertar_registro()
        Dim c As Byte
        Dim cadena As String = txt_cod_anio.Text + txt_cod_rubro.Text + txt_cod_modelo.Text
        Try
            If verificar_agregados(cadena, c) Then
                c = Convert.ToByte(lv_productos.Items.Count)
                With lv_productos
                    .Items.Add(cadena)
                    .Items(c).SubItems.Add(txt_marca.Text)
                    .Items(c).SubItems.Add(txt_rubro.Text)
                    .Items(c).SubItems.Add(txt_modelo.Text)
                    .Items(c).SubItems.Add(txt_talle.Text)
                    .Items(c).SubItems.Add(txt_detalle.Text)
                    .Items(c).SubItems.Add(txt_cantidad.Text)
                    .Items(c).SubItems.Add(CStr(CDec(txt_precio_unitario.Text) * CByte(txt_cantidad.Text)))
                    .Items(c).SubItems.Add(txt_cod_interno.Text)
                    .Items(c).SubItems.Add(CStr(CByte(txt_stock.Text) - CByte(txt_cantidad.Text)))
                    .Items(c).SubItems.Add(txt_costo.Text)
                    .Items(c).SubItems.Add(txt_precio_unitario.Text)
                    .Items(c).SubItems.Add(txt_stock_min.Text)
                End With
            Else
                MessageBox.Show("Este Producto ya fue agregado")
            End If
            actualizar_total()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lv_productos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_productos.DoubleClick
        frm_Cantidad.ShowDialog()
    End Sub

    Public Function verificar_agregados(ByVal cadena As String, ByRef c As Byte) As Boolean
        Dim i As Byte
        Dim codigo As String
        Try
            If lv_productos.Items.Count > 0 Then
                For i = 0 To CByte(lv_productos.Items.Count - 1)
                    codigo = lv_productos.Items(i).Text
                    If codigo = cadena Then
                        c = i
                        Return False
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function
    Public Sub actualizar_total()
        Dim i As Byte
        Dim acu As Decimal = 0
        Try
            For i = 0 To CByte(lv_productos.Items.Count - 1)
                acu = acu + CDec(lv_productos.Items(i).SubItems(7).Text)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        lbl_total_venta.Text = CStr(acu)
    End Sub

    Private Sub btn_eliminar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_producto.Click
        Try
            If lv_productos.Items.Count = 0 Then
                MessageBox.Show("No hay registros para eliminar")
                Exit Sub
            End If
            If lv_productos.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar un registro para eliminar")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        lv_productos.Items.RemoveAt(lv_productos.SelectedIndices(0))
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar_venta.Click
        Try
            If grp_cliente.Enabled = True Then
                cbo_tipo_pago.SelectedIndex = -1
                cbo_empresa.SelectedIndex = -1
                txt_cuotas.Text = ""
                btn_concretar.Enabled = True
            End If
            If grp_detalle.Enabled = False Then
                grp_detalle.Enabled = True
                cbo_tipo_pago.SelectedIndex = -1
                cbo_empresa.SelectedIndex = -1
                txt_cuotas.Text = ""
                btn_concretar.Enabled = False
                cbo_tipo_pago.Enabled = False
                cbo_empresa.Enabled = False
                txt_cuotas.Enabled = False
                grp_cliente.Enabled = False
                limpiar_cajas_cliente()
            Else
                limpieza_general()
                Accion = aAnterior
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_concretar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_concretar.Click
        Try
            If validar_transaccion() = False Then
                Exit Sub
            End If
            If concretar_venta() Then
                MessageBox.Show("Venta efectuada exitosamente")
                limpieza_general()
                Accion = aAnterior
                Me.Close()
            Else
                MessageBox.Show("Ha ocurrido un problema durante la transacción")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function concretar_venta() As Boolean
        Dim i As Byte
        Dim ok As Boolean = True
        Try
            insertar_venta()
            For i = 0 To CByte(lv_productos.Items.Count - 1)
                If insertar_detalles(i) = False Then
                    ok = False
                    Exit For
                End If
                If actualizar_stock(i) = False Then
                    ok = False
                    Exit For
                End If
            Next
            If ok = False Then
                eliminar_venta()
                Return False
            End If
            actualizar_lista_ventas()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub limpieza_general()
        Try
            lv_productos.Items.Clear()
            lbl_total_venta.Text = "0"
            limpiar_cajas_cliente()
            limpiar_cajas_detalle_ventas()
            limpiar_cajas_factura()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub insertar_venta()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "insertarventa"
            cm.Parameters.AddWithValue("@pago", CByte(cbo_tipo_pago.SelectedIndex + 1))
            cm.Parameters.AddWithValue("@empresa", CByte(cbo_empresa.SelectedIndex + 1))
            cm.Parameters.AddWithValue("@cuotas", CByte(txt_cuotas.Text))
            cm.Parameters.AddWithValue("@cod_cliente", CShort(txt_numero_cliente.Text))
            cm.Connection = cn
            cn.Open()
            cm.ExecuteNonQuery()
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

    Public Function insertar_detalles(ByVal i As Byte) As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "insertardetallesventa"
            cm.Parameters.AddWithValue("@num_fac", CInt(txt_numero_factura.Text))
            cm.Parameters.AddWithValue("@cod_prod", CShort(lv_productos.Items(i).SubItems(8).Text))
            cm.Parameters.AddWithValue("@cantidad", CByte(lv_productos.Items(i).SubItems(6).Text))
            cm.Parameters.AddWithValue("@costo", CDec(lv_productos.Items(i).SubItems(10).Text))
            cm.Parameters.AddWithValue("@precio_venta", CDec(lv_productos.Items(i).SubItems(11).Text))
            cm.Connection = cn
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
        Return True
    End Function

    Private Sub cbo_tipo_pago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_tipo_pago.SelectedIndexChanged
        Try
            If cbo_tipo_pago.SelectedIndex = 0 Then
                cbo_empresa.SelectedIndex = 0
                cbo_empresa.Enabled = False
                txt_numero_cliente.Text = "1"
                txt_cuotas.Text = "1"
                txt_cuotas.Enabled = False
                grp_cliente.Enabled = False
                limpiar_cajas_cliente()
                txt_numero_cliente.Text = "1"
            Else
                cbo_empresa.Enabled = True
                cbo_empresa.SelectedIndex = -1
                txt_cuotas.Enabled = True
                grp_cliente.Enabled = True
                btn_concretar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function traer_ultima_factura() As Int32
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim factura As Int32
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traerultimafactura"
            cm.Connection = cn
            cn.Open()
            factura = CInt(cm.ExecuteScalar)
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
        Return factura + 1
    End Function

    Public Sub eliminar_venta()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "eliminarventa"
            cm.Parameters.AddWithValue("@num_fac", CInt(txt_numero_factura.Text))
            cm.Connection = cn
            cn.Open()
            cm.ExecuteNonQuery()
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
            cm.CommandText = "traercliente"
            cm.Parameters.AddWithValue("@cod_cli", txt_numero_cliente.Text)
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read()
                    txt_nombre.Text = dr.GetString(0)
                    txt_numero_dni.Text = dr.GetInt32(1).ToString
                    txt_direccion.Text = dr.GetString(2)
                    txt_localidad.Text = dr.GetString(3)
                    If dr.IsDBNull(4) Then
                        txt_telefono.Text = "No tiene"
                    Else
                        txt_telefono.Text = dr.GetString(4)
                    End If
                    If dr.IsDBNull(5) Then
                        txt_celular.Text = "No tiene"
                    Else
                        txt_celular.Text = dr.GetString(5)
                    End If
                    If dr.IsDBNull(6) Then
                        txt_email.Text = "No tiene"
                    Else
                        txt_email.Text = dr.GetString(6)
                    End If
                End While
            Else
                cn.Close()
                dr.Close()
                btn_concretar.Enabled = False
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
        btn_concretar.Enabled = True
        Return True
    End Function

    Private Sub cbo_empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_empresa.SelectedIndexChanged
        If cbo_empresa.SelectedIndex = 0 And cbo_tipo_pago.SelectedIndex > 0 Then
            MessageBox.Show("Esta opción es sólo válida para ventas al contado")
            cbo_empresa.SelectedIndex = -1
        End If
    End Sub

    Private Sub btn_traer_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_traer_cliente.Click
        If traer_cliente() = False Then
            MessageBox.Show("No existe tal cliente")
        End If
    End Sub

    Public Sub limpiar_cajas_cliente()
        txt_numero_cliente.Text = ""
        txt_nombre.Text = ""
        txt_numero_dni.Text = ""
        txt_direccion.Text = ""
        txt_localidad.Text = ""
        txt_telefono.Text = ""
        txt_celular.Text = ""
        txt_email.Text = ""
    End Sub

    Private Sub txt_numero_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero_cliente.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cuotas.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_anio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_anio.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_rubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_rubro.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_modelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_modelo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function validar_cantidad() As Boolean
        Try
            If txt_cantidad.Text.Trim = "" Then
                MessageBox.Show("Ingrese la cantidad de productos a vender")
                txt_cantidad.Focus()
                Exit Function
            Else
                If verificarnumeronatural(txt_cantidad.Text) = False Then
                    MessageBox.Show("Cantidad incorrecta")
                    txt_cantidad.Focus()
                    Exit Function
                End If
                If CShort(txt_cantidad.Text) = 0 Then
                    MessageBox.Show("Ingrese cantidad mayor a 0")
                    txt_cantidad.Focus()
                    Exit Function
                End If
                If CShort(txt_cantidad.Text) > CShort(txt_stock.Text) Then
                    MessageBox.Show("Stock insuficiente")
                    Return False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function validar_transaccion() As Boolean
        Try
            If cbo_tipo_pago.SelectedIndex = -1 Then
                MessageBox.Show("Elija una forma de pago")
                cbo_tipo_pago.Focus()
                Return False
            End If
            If cbo_empresa.SelectedIndex = -1 And cbo_tipo_pago.SelectedIndex > 0 Then
                MessageBox.Show("Elija una empresa")
                cbo_empresa.Focus()
                Return False
            End If
            If txt_cuotas.Text.Trim = "" Then
                MessageBox.Show("Ingrese Número de Cuotas")
                txt_cuotas.Focus()
                Return False
            Else
                If verificarnumeronatural(txt_cuotas.Text) = False Then
                    MessageBox.Show("Cantidad incorrecta")
                    txt_cuotas.Focus()
                    Exit Function
                End If
                If CShort(txt_cuotas.Text) < 1 Or CShort(txt_cuotas.Text) > 12 Then
                    MessageBox.Show("Número de cuotas incorrecto")
                    txt_cuotas.Focus()
                    Return False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function actualizar_stock(ByVal i As Byte) As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "actualizarstock"
            cm.Parameters.AddWithValue("@cod_int", CShort(lv_productos.Items(i).SubItems(8).Text))
            cm.Parameters.AddWithValue("@stock", CByte(lv_productos.Items(i).SubItems(9).Text) + CByte(lv_productos.Items(i).SubItems(12).Text))
            cm.Connection = cn
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
        Return True
    End Function

    Public Sub actualizar_lista_ventas()
        Dim p As Int16 = CShort(Ventas.lv_ventas.Items.Count)
        Try
            With Ventas.lv_ventas
                .Items.Add(txt_numero_factura.Text)
                .Items(p).SubItems.Add(Now.Date.ToShortDateString + " " + Now.Date.ToLongTimeString)
                .Items(p).SubItems.Add(cbo_tipo_pago.SelectedItem.ToString)
                .Items(p).SubItems.Add(cbo_empresa.SelectedItem.ToString)
                .Items(p).SubItems.Add(txt_cuotas.Text)
                .Items(p).SubItems.Add("Cerrada")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub limpiar_cajas_factura()
        Try
            cbo_tipo_pago.SelectedIndex = -1
            cbo_empresa.SelectedIndex = -1
            txt_cuotas.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lv_productos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lv_productos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            frm_Cantidad.ShowDialog()
        End If
    End Sub
End Class