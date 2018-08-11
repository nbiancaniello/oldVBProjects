Imports System.Data.SqlClient
Public Class Filtro_p
    Dim cadena As String
    Dim primero As Boolean
    Private Sub cbo_cr_codigo_anio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_codigo_anio.SelectedIndexChanged
        If cbo_cr_codigo_anio.SelectedIndex = 4 Then
            txt_h_cod_anio.Enabled = True
        Else
            txt_h_cod_anio.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_codigo_rubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_codigo_rubro.SelectedIndexChanged
        If cbo_cr_codigo_rubro.SelectedIndex = 4 Then
            txt_h_cod_rubro.Enabled = True
        Else
            txt_h_cod_rubro.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_codigo_modelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_codigo_modelo.SelectedIndexChanged
        If cbo_cr_codigo_modelo.SelectedIndex = 4 Then
            txt_h_cod_modelo.Enabled = True
        Else
            txt_h_cod_modelo.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_talle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_talle.SelectedIndexChanged
        If cbo_cr_talle.SelectedIndex = 1 Then
            cbo_h_talle.Enabled = True
        Else
            cbo_h_talle.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_marca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_marca.SelectedIndexChanged
        If cbo_cr_marca.SelectedIndex = 1 Then
            cbo_h_marca.Enabled = True
        Else
            cbo_h_marca.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_costo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_costo.SelectedIndexChanged
        If cbo_cr_costo.SelectedIndex = 4 Then
            txt_h_costo.Enabled = True
        Else
            txt_h_costo.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_precio_unitario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_precio_unitario.SelectedIndexChanged
        If cbo_cr_precio_unitario.SelectedIndex = 4 Then
            txt_h_precio_unitario.Enabled = True
        Else
            txt_h_precio_unitario.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_stock_minimo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_stock_minimo.SelectedIndexChanged
        If cbo_cr_stock_minimo.SelectedIndex = 4 Then
            txt_h_stock_min.Enabled = True
        Else
            txt_h_stock_min.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_stock_actual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_stock_actual.SelectedIndexChanged
        If cbo_cr_stock_actual.SelectedIndex = 4 Then
            txt_h_stock_ac.Enabled = True
        Else
            txt_h_stock_ac.Enabled = False
        End If
    End Sub

    Private Sub Filtro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            limpiar_cajas()
            traer_talles()
            traer_marcas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            establecer_topes()
            If establecer_cadena() = True Then
                If primero = False Then
                    buscar_en_base()
                Else
                    MessageBox.Show("Debe elegir alguna opción para poder efectuar la búsqueda")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_d_cod_anio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_cod_anio.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_cod_rubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_cod_rubro.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_cod_modelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_cod_modelo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_costo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "." Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_precio_unitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_precio_unitario.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "." Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_stock_min_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_stock_min.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_stock_ac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_stock_ac.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_cod_anio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_cod_anio.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_cod_rubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_cod_rubro.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_cod_modelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_cod_modelo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_costo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "." Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_precio_unitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_precio_unitario.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = "." Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_stock_min_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_stock_min.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_stock_ac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_stock_ac.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function buscar_en_base() As Boolean
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Integer = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.Text
            cm.Connection = cn
            cm.CommandText = cadena
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows = True Then
                Productos.lv_productos.Items.Clear()
                While dr.Read
                    With Productos.lv_productos
                        .Items.Add(dr.GetString(0))
                        .Items(i).SubItems.Add(dr.GetString(1))
                        .Items(i).SubItems.Add(dr.GetString(2))
                        .Items(i).SubItems.Add(dr.GetString(3))
                        .Items(i).SubItems.Add(dr.GetString(4))
                        If dr.IsDBNull(5) Then
                            .Items(i).SubItems.Add("No hay detalle para este producto")
                        Else
                            .Items(i).SubItems.Add(dr.GetString(5))
                        End If
                        .Items(i).SubItems.Add(dr.GetDecimal(6).ToString)
                        .Items(i).SubItems.Add(dr.GetDecimal(7).ToString)
                        .Items(i).SubItems.Add(dr.GetByte(8).ToString)
                        .Items(i).SubItems.Add(dr.GetByte(9).ToString)
                    End With
                    i = i + 1
                End While
                Accion = aAnterior
                Me.Close()
            Else
                limpiar_cajas()
                MessageBox.Show("No se han encontrado registros en la busqueda seleccionada")
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
    End Function

    Public Sub establecer_topes()
        Try
            If cbo_cr_codigo_anio.SelectedIndex = 4 Then
                If txt_d_cod_anio.Text.Trim = "" Then
                    txt_d_cod_anio.Text = "0"
                End If
                If txt_h_cod_anio.Text.Trim = "" Then
                    txt_h_cod_anio.Text = "256"
                End If
            Else
                If txt_d_cod_anio.Text.Trim = "" Then
                    cbo_cr_codigo_anio.SelectedIndex = -1
                End If
            End If
            If cbo_cr_codigo_rubro.SelectedIndex = 4 Then
                If txt_d_cod_rubro.Text.Trim = "" Then
                    txt_d_cod_rubro.Text = "0"
                End If
                If txt_h_cod_rubro.Text.Trim = "" Then
                    txt_h_cod_rubro.Text = "256"
                End If
            Else
                If txt_d_cod_rubro.Text.Trim = "" Then
                    cbo_cr_codigo_rubro.SelectedIndex = -1
                End If
            End If
            If cbo_cr_codigo_modelo.SelectedIndex = 4 Then
                If txt_d_cod_modelo.Text.Trim = "" Then
                    txt_d_cod_modelo.Text = "0"
                End If
                If txt_h_cod_modelo.Text.Trim = "" Then
                    txt_h_cod_modelo.Text = "256"
                End If
            Else
                If txt_d_cod_modelo.Text.Trim = "" Then
                    cbo_cr_codigo_modelo.SelectedIndex = -1
                End If
            End If
            If cbo_cr_talle.SelectedIndex = 4 Then
                If cbo_d_talle.SelectedIndex = -1 Then
                    cbo_d_talle.SelectedIndex = 0
                End If
                If cbo_h_talle.SelectedIndex = -1 Then
                    cbo_h_talle.SelectedIndex = cbo_h_talle.Items.Count - 1
                End If
            Else
                If cbo_d_talle.SelectedIndex = -1 Then
                    cbo_cr_talle.SelectedIndex = -1
                End If
            End If
            If cbo_cr_marca.SelectedIndex = 4 Then
                If cbo_d_marca.SelectedIndex = -1 Then
                    cbo_d_marca.SelectedIndex = 0
                End If
                If cbo_h_marca.SelectedIndex = -1 Then
                    cbo_h_marca.SelectedIndex = cbo_h_marca.Items.Count - 1
                End If
            Else
                If cbo_d_marca.SelectedIndex = -1 Then
                    cbo_cr_marca.SelectedIndex = -1
                End If
            End If
            If cbo_cr_costo.SelectedIndex = 4 Then
                If txt_d_costo.Text.Trim = "" Then
                    txt_d_costo.Text = "0"
                End If
                If txt_h_costo.Text.Trim = "" Then
                    txt_h_costo.Text = "9999.99"
                End If
            Else
                If txt_d_costo.Text.Trim = "" Then
                    cbo_cr_costo.SelectedIndex = -1
                End If
            End If
            If cbo_cr_precio_unitario.SelectedIndex = 4 Then
                If txt_d_precio_unitario.Text.Trim = "" Then
                    txt_d_precio_unitario.Text = "0"
                End If
                If txt_h_precio_unitario.Text.Trim = "" Then
                    txt_h_precio_unitario.Text = "9999.99"
                End If
            Else
                If txt_d_precio_unitario.Text.Trim = "" Then
                    cbo_cr_precio_unitario.SelectedIndex = -1
                End If
            End If
            If cbo_cr_stock_minimo.SelectedIndex = 4 Then
                If txt_d_stock_min.Text.Trim = "" Then
                    txt_d_stock_min.Text = "0"
                End If
                If txt_h_stock_min.Text.Trim = "" Then
                    txt_h_stock_min.Text = "256"
                End If
            Else
                If txt_d_stock_min.Text.Trim = "" Then
                    cbo_cr_stock_minimo.SelectedIndex = -1
                End If
            End If
            If cbo_cr_stock_actual.SelectedIndex = 4 Then
                If txt_d_stock_ac.Text.Trim = "" Then
                    txt_d_stock_ac.Text = "0"
                End If
                If txt_h_stock_ac.Text.Trim = "" Then
                    txt_h_stock_ac.Text = "256"
                End If
            Else
                If txt_d_stock_ac.Text.Trim = "" Then
                    cbo_cr_stock_actual.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub limpiar_cajas()
        Try
            cbo_cr_codigo_anio.SelectedIndex = -1
            cbo_cr_codigo_rubro.SelectedIndex = -1
            cbo_cr_codigo_modelo.SelectedIndex = -1
            cbo_cr_talle.SelectedIndex = -1
            cbo_cr_marca.SelectedIndex = -1
            cbo_cr_costo.SelectedIndex = -1
            cbo_cr_precio_unitario.SelectedIndex = -1
            cbo_cr_stock_minimo.SelectedIndex = -1
            cbo_cr_stock_actual.SelectedIndex = -1
            txt_d_cod_anio.Clear()
            txt_h_cod_anio.Clear()
            txt_d_cod_rubro.Clear()
            txt_h_cod_rubro.Clear()
            txt_d_cod_modelo.Clear()
            txt_h_cod_modelo.Clear()
            cbo_d_talle.SelectedIndex = -1
            cbo_h_talle.SelectedIndex = -1
            cbo_d_marca.SelectedIndex = -1
            cbo_h_marca.SelectedIndex = -1
            txt_d_costo.Clear()
            txt_h_costo.Clear()
            txt_d_precio_unitario.Clear()
            txt_h_precio_unitario.Clear()
            txt_d_stock_min.Clear()
            txt_h_stock_min.Clear()
            txt_d_stock_ac.Clear()
            txt_h_stock_ac.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Accion = aAnterior
        Me.Close()
    End Sub

    Private Function establecer_cadena() As Boolean
        primero = True
        Try
            cadena = "SELECT (convert(varchar(4), p.codigo_anio) + convert(varchar(4), p.codigo_rubro)+ convert(varchar(4), p.codigo_modelo)), "
            cadena = cadena + " mr.descripcion, r.descripcion, m.descripcion, t.sigla, p.detalle, p.costo, p.precio_unitario, p.stock_actual, "
            cadena = cadena + " p.stock_minimo, p.codigo_interno "
            cadena = cadena + " FROM Productos p INNER JOIN Marcas mr  ON p.marca = mr.codigo_marca "
            cadena = cadena + " INNER JOIN Rubros r ON p.codigo_rubro = r.codigo_rubro "
            cadena = cadena + " INNER JOIN Talles t ON p.talle = t.numero_talle "
            cadena = cadena + " INNER JOIN Modelos m ON p.codigo_modelo = m.codigo_modelo WHERE "

            If cbo_cr_codigo_anio.SelectedIndex <> -1 Then
                cadena = cadena + " p.codigo_anio "
                If verificarnumeronatural(txt_d_cod_anio.Text) = True Then
                    Select Case cbo_cr_codigo_anio.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_cod_anio.Text
                        Case 1 : cadena = cadena + " > " & txt_d_cod_anio.Text
                        Case 2 : cadena = cadena + " < " & txt_d_cod_anio.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_cod_anio.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_cod_anio.Text & " and " & txt_h_cod_anio.Text
                            If CShort(txt_d_cod_anio.Text) > CShort(txt_h_cod_anio.Text) Then
                                MessageBox.Show("El código de año desde debe ser menor al código de año hasta")
                                txt_d_cod_anio.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_cod_anio.Text) = False Then
                                MessageBox.Show("Código de Año Incorrecto")
                                txt_h_cod_anio.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                Else
                    MessageBox.Show("Código de Año Incorrecto")
                    txt_d_cod_anio.Focus()
                    Return False
                    Exit Function
                End If
                primero = False
            End If

            If cbo_cr_codigo_rubro.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " p.codigo_rubro "
                Else
                    cadena = cadena + " and p.codigo_rubro "
                End If
                If verificarnumeronatural(txt_d_cod_rubro.Text) = True Then
                    Select Case cbo_cr_codigo_rubro.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_cod_rubro.Text
                        Case 1 : cadena = cadena + " > " & txt_d_cod_rubro.Text
                        Case 2 : cadena = cadena + " < " & txt_d_cod_rubro.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_cod_rubro.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_cod_rubro.Text & " and " & txt_h_cod_rubro.Text
                            If CShort(txt_d_cod_rubro.Text) > CShort(txt_h_cod_rubro.Text) Then
                                MessageBox.Show("El código de rubro desde debe ser menor al código de rubro hasta")
                                txt_d_cod_rubro.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_cod_rubro.Text) = False Then
                                MessageBox.Show("Código de Rubro Incorrecto")
                                txt_h_cod_rubro.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Código de Rubro Incorrecto")
                    txt_d_cod_rubro.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If cbo_cr_codigo_modelo.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " p.codigo_modelo "
                Else
                    cadena = cadena + " and p.codigo_modelo "
                End If
                If verificarnumeronatural(txt_d_cod_modelo.Text) = True Then
                    Select Case cbo_cr_codigo_modelo.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_cod_modelo.Text
                        Case 1 : cadena = cadena + " > " & txt_d_cod_modelo.Text
                        Case 2 : cadena = cadena + " < " & txt_d_cod_modelo.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_cod_modelo.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_cod_modelo.Text & " and " & txt_h_cod_modelo.Text
                            If CShort(txt_d_cod_modelo.Text) > CShort(txt_h_cod_modelo.Text) Then
                                MessageBox.Show("El código de modelo desde debe ser menor al código de modelo hasta")
                                txt_d_cod_modelo.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_cod_modelo.Text) = False Then
                                MessageBox.Show("Código de Modelo Incorrecto")
                                txt_h_cod_modelo.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Código de Modelo Incorrecto")
                    txt_d_cod_modelo.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If cbo_cr_talle.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " t.sigla "
                Else
                    cadena = cadena + " and t.sigla "
                End If
                Select Case cbo_cr_talle.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & cbo_d_talle.SelectedItem.ToString & "'"
                    Case 1
                        If cbo_h_talle.SelectedIndex = -1 Then
                            MessageBox.Show("Debe seleccionar un talle hasta")
                            cbo_h_talle.Focus()
                            Return False
                            Exit Function
                        Else
                            If CShort(cbo_d_talle.SelectedIndex) > CShort(cbo_h_talle.SelectedIndex) Then
                                MessageBox.Show("El Talle desde debe ser menor al Talle hasta")
                                cbo_d_talle.Focus()
                                Return False
                                Exit Function
                            End If
                        End If
                        cadena = cadena + " between '" & cbo_d_talle.SelectedItem.ToString & "' and '" & cbo_h_talle.SelectedItem.ToString & "'"
                End Select
                primero = False
            End If

            If cbo_cr_marca.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " mr.descripcion "
                Else
                    cadena = cadena + " and mr.descripcion "
                End If
                Select Case cbo_cr_marca.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & cbo_d_marca.SelectedItem.ToString & "'"
                    Case 1
                        If cbo_h_marca.SelectedIndex = -1 Then
                            MessageBox.Show("Debe seleccionar una marca hasta")
                            cbo_h_marca.Focus()
                            Return False
                            Exit Function
                        Else
                            If CShort(cbo_d_marca.SelectedIndex) > CShort(cbo_h_marca.SelectedIndex) Then
                                MessageBox.Show("La Marca desde debe ser menor al Marca hasta")
                                cbo_d_marca.Focus()
                                Return False
                                Exit Function
                            End If
                        End If
                        cadena = cadena + " between '" & cbo_d_marca.SelectedItem.ToString & "' and '" & cbo_h_marca.SelectedItem.ToString & "'"
                End Select
                primero = False
            End If

            If cbo_cr_costo.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " p.costo "
                Else
                    cadena = cadena + " and p.costo "
                End If
                If verificarnumerodecimal(txt_d_costo.Text) = True Then
                    Select Case cbo_cr_costo.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_costo.Text
                        Case 1 : cadena = cadena + " > " & txt_d_costo.Text
                        Case 2 : cadena = cadena + " < " & txt_d_costo.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_costo.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_costo.Text & " and " & txt_h_costo.Text
                            If CShort(txt_d_costo.Text) > CShort(txt_h_costo.Text) Then
                                MessageBox.Show("El costo desde debe ser menor al costo hasta")
                                txt_d_costo.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumerodecimal(txt_h_costo.Text) = False Then
                                MessageBox.Show("Costo Incorrecto")
                                txt_h_costo.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Costo Incorrecto")
                    txt_d_costo.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If cbo_cr_precio_unitario.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " p.precio_unitario "
                Else
                    cadena = cadena + " and p.precio_unitario "
                End If
                If verificarnumerodecimal(txt_d_precio_unitario.Text) = True Then
                    Select Case cbo_cr_precio_unitario.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_precio_unitario.Text
                        Case 1 : cadena = cadena + " > " & txt_d_precio_unitario.Text
                        Case 2 : cadena = cadena + " < " & txt_d_precio_unitario.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_precio_unitario.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_precio_unitario.Text & " and " & txt_h_precio_unitario.Text
                            If CShort(txt_d_precio_unitario.Text) > CShort(txt_h_precio_unitario.Text) Then
                                MessageBox.Show("El Precio Unitario desde debe ser menor al Precio Unitario hasta")
                                txt_d_precio_unitario.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumerodecimal(txt_h_precio_unitario.Text) = False Then
                                MessageBox.Show("Precio Unitario Incorrecto")
                                txt_h_precio_unitario.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Precio Unitario Incorrecto")
                    txt_d_precio_unitario.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If cbo_cr_stock_minimo.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " p.stock_minimo "
                Else
                    cadena = cadena + " and p.stock_minimo "
                End If
                If verificarnumeronatural(txt_d_stock_min.Text) = True Then
                    Select Case cbo_cr_stock_minimo.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_stock_min.Text
                        Case 1 : cadena = cadena + " > " & txt_d_stock_min.Text
                        Case 2 : cadena = cadena + " < " & txt_d_stock_min.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_stock_min.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_stock_min.Text & " and " & txt_h_stock_min.Text
                            If CShort(txt_d_stock_min.Text) > CShort(txt_h_stock_min.Text) Then
                                MessageBox.Show("El Stock Mínimo desde debe ser menor al Stock Mínimo hasta")
                                txt_d_stock_min.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_stock_min.Text) = False Then
                                MessageBox.Show("Stock Mínimo Incorrecto")
                                txt_h_stock_min.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Stock Mínimo Incorrecto")
                    txt_d_stock_min.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If cbo_cr_stock_actual.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " p.stock_actual "
                Else
                    cadena = cadena + " and p.stock_actual "
                End If
                If verificarnumeronatural(txt_d_stock_ac.Text) = True Then
                    Select Case cbo_cr_stock_actual.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_stock_ac.Text
                        Case 1 : cadena = cadena + " > " & txt_d_stock_ac.Text
                        Case 2 : cadena = cadena + " < " & txt_d_stock_ac.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_stock_ac.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_stock_ac.Text & " and " & txt_h_stock_ac.Text
                            If CShort(txt_d_stock_ac.Text) > CShort(txt_h_stock_ac.Text) Then
                                MessageBox.Show("El Stock Actual desde debe ser menor al Stock Actual hasta")
                                txt_d_stock_ac.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_stock_ac.Text) = False Then
                                MessageBox.Show("Stock Actual Incorrecto")
                                txt_h_stock_ac.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Stock Actual Incorrecto")
                    txt_d_stock_ac.Focus()
                    Return False
                    Exit Function
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function
End Class