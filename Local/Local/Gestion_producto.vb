Imports System.Data.SqlClient
Public Class Gestion_producto
    Private Sub Gestion_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            limpiar_cajas()
            traer_marcas()
            traer_talles()
            If Accion = eAccion.Modificar Then
                traer_codigos()
                txt_costo.Text = Productos.lv_productos.SelectedItems(0).SubItems(6).Text
                txt_detalle.Text = Productos.lv_productos.SelectedItems(0).SubItems(5).Text
                txt_precio_unitario.Text = Productos.lv_productos.SelectedItems(0).SubItems(7).Text
                txt_stock_actual.Text = Productos.lv_productos.SelectedItems(0).SubItems(8).Text
                txt_stock_minimo.Text = Productos.lv_productos.SelectedItems(0).SubItems(9).Text
                cbo_talle.SelectedItem = Productos.lv_productos.SelectedItems(0).SubItems(4).Text
                cbo_marca.SelectedItem = Productos.lv_productos.SelectedItems(0).SubItems(1).Text
                txt_ant_tll.Text = CStr(cbo_talle.SelectedIndex + 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub limpiar_cajas()
        txt_codigo_anio.Text = ""
        txt_codigo_modelo.Text = ""
        txt_codigo_rubro.Text = ""
        txt_costo.Text = ""
        txt_detalle.Text = ""
        txt_precio_unitario.Text = ""
        txt_stock_actual.Text = ""
        txt_stock_minimo.Text = ""
        cbo_talle.Items.Clear()
        cbo_marca.Items.Clear()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            If validar_datos() = False Then
                Exit Sub
            End If
            If verificar_rubro() = False Then
                MessageBox.Show("Código de Rubro inexistente")
                Exit Sub
            End If
            If verificar_modelo() = False Then
                MessageBox.Show("Código de Modelo inexistente")
                Exit Sub
            End If
            If txt_detalle.Text.Trim = "" Then
                txt_detalle.Text = "No hay detalles"
            End If
            If Accion = eAccion.Agregar Then
                If verificar_existencia() = True Then
                    MessageBox.Show("Este producto ya existe")
                    Exit Sub
                End If
                If registrar_producto() = False Then
                    MessageBox.Show("Producto Registrado Satisfactoriamente")
                End If
            Else
                If actualizar_producto() = False Then
                    MessageBox.Show("Producto Modificado Satisfactoriamente")
                End If
            End If
            actualizar_lista()
            limpiar_cajas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Accion = aAnterior
        Me.Close()
    End Sub

    Public Function verificar_existencia() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Connection = cn
            cm.CommandText = "verificarexistenciaproducto"
            cm.Parameters.AddWithValue("@cod_anio", CByte(txt_codigo_anio.Text))
            cm.Parameters.AddWithValue("@cod_rub", CByte(txt_codigo_rubro.Text))
            cm.Parameters.AddWithValue("@cod_mod", CByte(txt_codigo_modelo.Text))
            cm.Parameters.AddWithValue("@cod_tll", CByte(cbo_talle.SelectedIndex + 1))
            cn.Open()
            If CShort(cm.ExecuteScalar) = 1 Then
                cn.Close()
                Return True
            Else
                cn.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un problema con la base de datos")
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Function

    Public Function registrar_producto() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "registrarproducto"
            cm.Parameters.AddWithValue("@cod_anio", CByte(txt_codigo_anio.Text))
            cm.Parameters.AddWithValue("@cod_rub", CByte(txt_codigo_rubro.Text))
            cm.Parameters.AddWithValue("@cod_mod", CByte(txt_codigo_modelo.Text))
            cm.Parameters.AddWithValue("@cod_tll", CByte(cbo_talle.SelectedIndex + 1))
            cm.Parameters.AddWithValue("@detalle", txt_detalle.Text)
            cm.Parameters.AddWithValue("@marca", CByte(cbo_marca.SelectedIndex + 1))
            cm.Parameters.AddWithValue("@costo", CDec(txt_costo.Text))
            cm.Parameters.AddWithValue("@precio", CDec(txt_precio_unitario.Text))
            cm.Parameters.AddWithValue("@st_ac", CByte(txt_stock_actual.Text))
            cm.Parameters.AddWithValue("@st_min", CByte(txt_stock_minimo.Text))
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
    End Function

    Public Function actualizar_producto() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "actualizarproducto"
            cm.Parameters.AddWithValue("@cod_anio", CByte(txt_codigo_anio.Text))
            cm.Parameters.AddWithValue("@cod_rub", CByte(txt_codigo_rubro.Text))
            cm.Parameters.AddWithValue("@cod_mod", CByte(txt_codigo_modelo.Text))
            cm.Parameters.AddWithValue("@cod_tll", CByte(cbo_talle.SelectedIndex + 1))
            cm.Parameters.AddWithValue("@detalle", txt_detalle.Text)
            cm.Parameters.AddWithValue("@marca", CByte(cbo_marca.SelectedIndex + 1))
            cm.Parameters.AddWithValue("@costo", CDec(txt_costo.Text))
            cm.Parameters.AddWithValue("@precio", CDec(txt_precio_unitario.Text))
            cm.Parameters.AddWithValue("@st_ac", CByte(txt_stock_actual.Text))
            cm.Parameters.AddWithValue("@st_min", CByte(txt_stock_minimo.Text))
            cm.Parameters.AddWithValue("@ant_anio", CByte(txt_ant_anio.Text))
            cm.Parameters.AddWithValue("@ant_rub", CByte(txt_ant_rub.Text))
            cm.Parameters.AddWithValue("@ant_mod", CByte(txt_ant_mod.Text))
            cm.Parameters.AddWithValue("@ant_tll", CByte(txt_ant_tll.Text))
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
    End Function

    Public Sub actualizar_lista()
        Dim p As Short
        Try
            If Accion = eAccion.Agregar Then
                p = CShort(Productos.lv_productos.Items.Count)
                With Productos.lv_productos
                    .Items.Add(txt_codigo_anio.Text + txt_codigo_rubro.Text + txt_codigo_modelo.Text)
                    .Items(p).SubItems.Add(cbo_marca.SelectedItem.ToString)
                    .Items(p).SubItems.Add(traer_rubro)
                    .Items(p).SubItems.Add(traer_modelo)
                    .Items(p).SubItems.Add(cbo_talle.SelectedItem.ToString)
                    .Items(p).SubItems.Add(txt_detalle.Text)
                    .Items(p).SubItems.Add(txt_costo.Text)
                    .Items(p).SubItems.Add(txt_precio_unitario.Text)
                    .Items(p).SubItems.Add(txt_stock_actual.Text)
                    .Items(p).SubItems.Add(txt_stock_minimo.Text)
                    devolver_interno(p)
                End With
            Else
                p = CShort(Productos.lv_productos.SelectedIndices(0))
                With Productos.lv_productos
                    .Items(p).Text = txt_codigo_anio.Text + txt_codigo_rubro.Text + txt_codigo_modelo.Text
                    .Items(p).Text = cbo_marca.SelectedItem.ToString
                    .Items(p).Text = traer_rubro()
                    .Items(p).Text = traer_modelo()
                    .Items(p).Text = cbo_talle.SelectedItem.ToString
                    .Items(p).Text = txt_detalle.Text
                    .Items(p).Text = txt_costo.Text
                    .Items(p).Text = txt_precio_unitario.Text
                    .Items(p).Text = txt_stock_actual.Text
                    .Items(p).Text = txt_stock_minimo.Text
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Function traer_rubro() As String
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Parameters.AddWithValue("@cod_rub", CByte(txt_codigo_rubro.Text))
            cm.CommandText = "traerrubro"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read()
                    Return dr.GetString(0)
                End While
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
        Return "DESCONOCIDO"
    End Function

    Public Function traer_modelo() As String
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Parameters.AddWithValue("@cod_mod", CByte(txt_codigo_modelo.Text))
            cm.CommandText = "traermodelo"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read()
                    Return dr.GetString(0)
                End While
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
        Return "DESCONOCIDO"
    End Function

    Public Function validar_datos() As Boolean
        Try
            If verificar_consistencia_datos() = False Then
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub txt_codigo_anio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo_anio.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_codigo_rubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo_rubro.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_codigo_modelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo_modelo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_costo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_precio_unitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio_unitario.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_minimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_stock_minimo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_actual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_stock_actual.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpiar_cajas()
        Accion = aAnterior
        Me.Close()
    End Sub

    Public Function verificar_consistencia_datos() As Boolean
        Try
            If txt_codigo_anio.Text.Trim = "" Then
                MessageBox.Show("Ingrese código de año")
                txt_codigo_anio.Focus()
                Return False
                Exit Function
            Else
                If verificarnumeronatural(txt_codigo_anio.Text) = False Then
                    MessageBox.Show("Código de Año incorrecto")
                    txt_codigo_anio.Focus()
                    Return False
                End If
                If CShort(txt_codigo_anio.Text) = 0 Then
                    MessageBox.Show("Ingrese código de año")
                    txt_codigo_anio.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CShort(txt_codigo_anio.Text) > 256 Then
                MessageBox.Show("Código de año mayor al permitido")
                txt_codigo_anio.Focus()
                Return False
                Exit Function
            End If

            If txt_codigo_rubro.Text.Trim = "" Then
                MessageBox.Show("Ingrese código de rubro")
                txt_codigo_rubro.Focus()
                Return False
                Exit Function
            Else
                If verificarnumeronatural(txt_codigo_rubro.Text) = False Then
                    MessageBox.Show("Código de Rubro incorrecto")
                    txt_codigo_rubro.Focus()
                    Return False
                End If
                If CShort(txt_codigo_rubro.Text) = 0 Then
                    MessageBox.Show("Ingrese código de rubro")
                    txt_codigo_rubro.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CShort(txt_codigo_rubro.Text) > 256 Then
                MessageBox.Show("Código de rubro mayor al permitido")
                txt_codigo_rubro.Focus()
                Return False
                Exit Function
            End If

            If txt_codigo_modelo.Text.Trim = "" Then
                MessageBox.Show("Ingrese código de modelo")
                txt_codigo_modelo.Focus()
                Return False
                Exit Function
            Else
                If verificarnumeronatural(txt_codigo_modelo.Text) = False Then
                    MessageBox.Show("Código de Modelo incorrecto")
                    txt_codigo_modelo.Focus()
                    Return False
                End If
                If CShort(txt_codigo_modelo.Text) = 0 Then
                    MessageBox.Show("Ingrese código de modelo")
                    txt_codigo_modelo.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CShort(txt_codigo_modelo.Text) > 256 Then
                MessageBox.Show("Código de modelo mayor al permitido")
                txt_codigo_modelo.Focus()
                Return False
                Exit Function
            End If

            If cbo_talle.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un talle")
                cbo_talle.Focus()
                Return False
                Exit Function
            End If

            If cbo_marca.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una marca")
                cbo_marca.Focus()
                Return False
                Exit Function
            End If

            If txt_costo.Text.Trim = "" Then
                MessageBox.Show("Ingrese el costo del producto")
                txt_costo.Focus()
                Return False
                Exit Function
            Else
                If verificarnumerodecimal(txt_costo.Text) = False Then
                    MessageBox.Show("Costo incorrecto")
                    txt_costo.Focus()
                    Return False
                End If
                If CDbl(txt_costo.Text) <= 0 Then
                    MessageBox.Show("Ingrese el costo del producto")
                    txt_costo.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CDbl(txt_costo.Text) > 9999.99 Then
                MessageBox.Show("Costo mayor al permitido")
                txt_costo.Focus()
                Return False
                Exit Function
            End If

            If txt_precio_unitario.Text.Trim = "" Then
                MessageBox.Show("Ingrese precio unitario del producto")
                txt_precio_unitario.Focus()
                Return False
                Exit Function
            Else
                If verificarnumerodecimal(txt_precio_unitario.Text) = False Then
                    MessageBox.Show("Precio Unitario incorrecto")
                    txt_precio_unitario.Focus()
                    Return False
                End If
                If CDbl(txt_precio_unitario.Text) <= 0 Then
                    MessageBox.Show("Ingrese precio unitario del producto")
                    txt_precio_unitario.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CDbl(txt_precio_unitario.Text) > 9999.99 Then
                MessageBox.Show("Precio Unitario mayor al permitido")
                txt_precio_unitario.Focus()
                Return False
                Exit Function
            End If

            If txt_stock_actual.Text.Trim = "" Then
                MessageBox.Show("Ingrese stock actual del producto")
                txt_stock_actual.Focus()
                Return False
                Exit Function
            Else
                If verificarnumeronatural(txt_stock_actual.Text) = False Then
                    MessageBox.Show("Stock Actual incorrecto")
                    txt_stock_actual.Focus()
                    Return False
                End If
                If CShort(txt_stock_actual.Text) = 0 Then
                    MessageBox.Show("Ingrese stock actual del producto")
                    txt_stock_actual.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CShort(txt_stock_actual.Text) > 256 Then
                MessageBox.Show("Stock actual mayor al permitido")
                txt_stock_actual.Focus()
                Return False
                Exit Function
            End If

            If txt_stock_minimo.Text.Trim = "" Then
                MessageBox.Show("Ingrese stock mínimo del producto")
                txt_stock_minimo.Focus()
                Return False
                Exit Function
            Else
                If verificarnumeronatural(txt_stock_minimo.Text) = False Then
                    MessageBox.Show("Stock Mínimo incorrecto")
                    txt_stock_minimo.Focus()
                    Return False
                End If
                If CShort(txt_stock_minimo.Text) < 0 Then
                    MessageBox.Show("Ingrese stock actual del producto")
                    txt_stock_minimo.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If CShort(txt_stock_minimo.Text) > 256 Then
                MessageBox.Show("Stock mínimo mayor al permitido")
                txt_stock_minimo.Focus()
                Return False
                Exit Function
            End If

            If CShort(txt_stock_actual.Text) < CShort(txt_stock_minimo.Text) Then
                MessageBox.Show("El stock actual debe ser mayor al stock mínimo")
                txt_stock_actual.Focus()
                Return False
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function verificar_rubro() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Connection = cn
            cm.CommandText = "verexistenciarubro"
            cm.Parameters.AddWithValue("@cod_rubro", CByte(txt_codigo_rubro.Text))
            cn.Open()
            If CShort(cm.ExecuteScalar) = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Function
    Public Function verificar_modelo() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Connection = cn
            cm.CommandText = "verexistenciamodelo"
            cm.Parameters.AddWithValue("@cod_modelo", CByte(txt_codigo_modelo.Text))
            cn.Open()
            If CShort(cm.ExecuteScalar) = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Function

    Public Sub devolver_interno(ByVal p As Short)
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.Connection = cn
            cm.CommandText = "devolverinterno"
            cm.Parameters.AddWithValue("@anio", CByte(txt_codigo_anio.Text))
            cm.Parameters.AddWithValue("@rubro", CByte(txt_codigo_rubro.Text))
            cm.Parameters.AddWithValue("@modelo", CByte(txt_codigo_modelo.Text))
            cm.Parameters.AddWithValue("@talle", CByte(cbo_talle.SelectedIndex + 1))
            cn.Open()
            dr = cm.ExecuteReader
            While dr.Read
                Productos.lv_productos.Items(p).SubItems.Add(dr.GetInt16(0).ToString)
            End While
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub
End Class