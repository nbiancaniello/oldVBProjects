Imports System.Data.SqlClient
Public Class Filtro_v
    Dim cadena As String
    Dim primero As Boolean
    Private Sub Filtro_v_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            limpiar_cajas()
            Accion = eAccion.Filtro
            traer_empresas()
            dtp_d_fecha.MaxDate = Now.Date
            dtp_h_fecha.MaxDate = Now.Date
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub traer_empresas()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traerempresas"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            cbo_d_empresa.Items.Clear()
            If dr.HasRows = True Then
                While dr.Read()
                    cbo_d_empresa.Items.Add(dr.GetString(0))
                    cbo_h_empresa.Items.Add(dr.GetString(0))
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
    Public Sub limpiar_cajas()
        Try
            cbo_cr_numero_factura.SelectedIndex = -1
            cbo_cr_fecha.SelectedIndex = -1
            cbo_cr_tipo_pago.SelectedIndex = -1
            cbo_cr_empresa.SelectedIndex = -1
            cbo_cr_cuotas.SelectedIndex = -1
            cbo_cr_estado.SelectedIndex = -1
            txt_d_num_fac.Clear()
            txt_h_num_fac.Clear()
            dtp_d_fecha.Value = Now.Date()
            dtp_h_fecha.Value = Now.Date()
            cbo_d_tipo_pago.SelectedIndex = -1
            cbo_h_tipo_pago.SelectedIndex = -1
            cbo_d_empresa.SelectedIndex = -1
            cbo_h_empresa.SelectedIndex = -1
            txt_d_cuotas.Clear()
            txt_h_cuotas.Clear()
            cbo_cr_estado.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub establecer_topes()
        Try
            If cbo_cr_numero_factura.SelectedIndex = 4 Then
                If txt_d_num_fac.Text.Trim = "" Then
                    txt_d_num_fac.Text = "0"
                End If
                If txt_h_num_fac.Text.Trim = "" Then
                    txt_h_num_fac.Text = "99999999"
                End If
            Else
                If txt_d_num_fac.Text.Trim = "" Then
                    cbo_cr_numero_factura.SelectedIndex = -1
                End If
                txt_h_num_fac.Text = ""
            End If
            If cbo_cr_tipo_pago.SelectedIndex = 4 Then
                If cbo_d_tipo_pago.SelectedIndex = -1 Then
                    cbo_d_tipo_pago.SelectedIndex = 0
                End If
                If cbo_h_tipo_pago.SelectedIndex = -1 Then
                    cbo_h_tipo_pago.SelectedIndex = cbo_h_tipo_pago.Items.Count - 1
                End If
            Else
                If cbo_d_tipo_pago.SelectedIndex = -1 Then
                    cbo_cr_tipo_pago.SelectedIndex = -1
                End If
                cbo_h_tipo_pago.SelectedIndex = -1
            End If
            If cbo_cr_empresa.SelectedIndex = 4 Then
                If cbo_d_empresa.SelectedIndex = -1 Then
                    cbo_d_empresa.SelectedIndex = 0
                End If
                If cbo_h_empresa.SelectedIndex = -1 Then
                    cbo_h_empresa.SelectedIndex = cbo_h_empresa.Items.Count - 1
                End If
            Else
                If cbo_d_empresa.SelectedIndex = -1 Then
                    cbo_cr_empresa.SelectedIndex = -1
                End If
                cbo_h_empresa.SelectedIndex = -1
            End If
            If cbo_cr_cuotas.SelectedIndex = 4 Then
                If txt_d_cuotas.Text.Trim = "" Then
                    txt_d_cuotas.Text = "0"
                End If
                If txt_h_cuotas.Text.Trim = "" Then
                    txt_h_cuotas.Text = "12"
                End If
            Else
                If txt_d_cuotas.Text.Trim = "" Then
                    cbo_cr_cuotas.SelectedIndex = -1
                End If
                txt_h_cuotas.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub buscar_en_base()
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
                Ventas.lv_ventas.Items.Clear()
                While dr.Read
                    With Ventas.lv_ventas
                        .Items.Add(dr.GetInt32(0).ToString)
                        .Items(i).SubItems.Add(dr.GetDateTime(1).ToShortDateString + " " + dr.GetDateTime(1).ToLongTimeString)
                        .Items(i).SubItems.Add(dr.GetString(2))
                        .Items(i).SubItems.Add(dr.GetString(3))
                        .Items(i).SubItems.Add(dr.GetByte(4).ToString)
                        If dr.GetString(5) = "C" Then
                            .Items(i).SubItems.Add("Cerrada")
                        Else
                            .Items(i).SubItems.Add("Anulada")
                        End If

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
    End Sub

    Private Sub cbo_cr_numero_factura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_numero_factura.SelectedIndexChanged
        If cbo_cr_numero_factura.SelectedIndex = 4 Then
            txt_h_num_fac.Enabled = True
        Else
            txt_h_num_fac.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_fecha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_fecha.SelectedIndexChanged
        If cbo_cr_fecha.SelectedIndex = 4 Then
            dtp_h_fecha.Enabled = True
        Else
            dtp_h_fecha.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_tipo_pago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_tipo_pago.SelectedIndexChanged
        If cbo_cr_tipo_pago.SelectedIndex = 1 Then
            cbo_h_tipo_pago.Enabled = True
        Else
            cbo_h_tipo_pago.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_empresa.SelectedIndexChanged
        If cbo_cr_empresa.SelectedIndex = 1 Then
            cbo_h_empresa.Enabled = True
        Else
            cbo_h_empresa.Enabled = False
        End If
    End Sub

    Private Sub cbo_cr_cuotas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_cr_cuotas.SelectedIndexChanged
        If cbo_cr_cuotas.SelectedIndex = 4 Then
            txt_h_cuotas.Enabled = True
        Else
            txt_h_cuotas.Enabled = False
        End If
    End Sub

    Private Sub txt_d_num_fac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_num_fac.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_num_fac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_num_fac.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_d_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_d_cuotas.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_h_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_h_cuotas.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Accion = aAnterior
        Me.Close()
    End Sub
    Public Function establecer_cadena() As Boolean
        primero = True
        Try
            cadena = "SELECT v.numero_factura, v.fecha_venta, tp.descripcion, e.descripcion, v.cuotas, v.estado"
            cadena = cadena + " FROM TipoPago tp INNER JOIN Ventas v  ON tp.codigo_pago = v.tipo_pago "
            cadena = cadena + " INNER JOIN Empresas e ON v.empresa = e.codigo_empresa WHERE "

            If cbo_cr_numero_factura.SelectedIndex <> -1 Then
                cadena = cadena + " v.numero_factura "
                If verificarnumeronatural(txt_d_num_fac.Text) = True Then
                    Select Case cbo_cr_numero_factura.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_num_fac.Text
                        Case 1 : cadena = cadena + " > " & txt_d_num_fac.Text
                        Case 2 : cadena = cadena + " < " & txt_d_num_fac.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_num_fac.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_num_fac.Text & " and " & txt_h_num_fac.Text
                            If CInt(txt_d_num_fac.Text) > CInt(txt_h_num_fac.Text) Then
                                MessageBox.Show("El número de factura desde debe ser menor al número de factura hasta")
                                txt_d_num_fac.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_num_fac.Text) = False Then
                                MessageBox.Show("Número de factura Incorrecto")
                                txt_h_num_fac.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                Else
                    MessageBox.Show("Número de factura Incorrecto")
                    txt_d_num_fac.Focus()
                    Return False
                    Exit Function
                End If
                primero = False
            End If

            If cbo_cr_fecha.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " v.fecha_venta "
                Else
                    cadena = cadena + " and v.fecha_venta "
                End If
                Select Case cbo_cr_fecha.SelectedIndex
                    Case 0 : cadena = cadena + " = '" & dtp_d_fecha.Value.ToShortDateString & "'"
                    Case 1 : cadena = cadena + " > '" & dtp_d_fecha.Value.ToShortDateString & "'"
                    Case 2 : cadena = cadena + " < '" & dtp_d_fecha.Value.ToShortDateString & "'"
                    Case 3 : cadena = cadena + " <> '" & dtp_d_fecha.Value.ToShortDateString & "'"
                    Case 4
                        cadena = cadena + " between '" & dtp_d_fecha.Value.ToShortDateString & " 00:00:00 ' and ' " & dtp_h_fecha.Value.ToShortDateString & " 23:59:59'"
                        If dtp_d_fecha.Value > dtp_h_fecha.Value Then
                            MessageBox.Show("La fecha desde debe ser menor a la fecha hasta")
                            dtp_d_fecha.Focus()
                            Return False
                            Exit Function
                        End If
                End Select
                primero = False
            End If

            If cbo_cr_tipo_pago.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " tp.descripcion "
                Else
                    cadena = cadena + " and tp.descripcion "
                End If
                Select Case cbo_cr_tipo_pago.SelectedIndex
                    Case 0 : cadena = cadena + " LIKE '" & cbo_d_tipo_pago.SelectedItem.ToString & "'"
                    Case 1
                        If cbo_h_tipo_pago.SelectedIndex = -1 Then
                            MessageBox.Show("Debe seleccionar un tipo de pago hasta")
                            cbo_h_tipo_pago.Focus()
                            Return False
                            Exit Function
                        Else
                            If CShort(cbo_d_tipo_pago.SelectedIndex) > CShort(cbo_d_tipo_pago.SelectedIndex) Then
                                MessageBox.Show("El tipo de pago desde debe ser menor al tipo de pago hasta")
                                cbo_h_tipo_pago.Focus()
                                Return False
                                Exit Function
                            End If
                        End If
                        cadena = cadena + " between '" & cbo_d_tipo_pago.SelectedItem.ToString & "' and '" & cbo_h_tipo_pago.SelectedItem.ToString & "'"
                End Select
                primero = False
            End If

            If cbo_cr_empresa.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " e.descripcion "
                Else
                    cadena = cadena + " and e.descripcion "
                End If
                Select Case cbo_cr_empresa.SelectedIndex
                    Case 0 : cadena = cadena + " LIKE '" & cbo_d_empresa.SelectedItem.ToString & "'"
                    Case 1
                        If cbo_h_empresa.SelectedIndex = -1 Then
                            MessageBox.Show("Debe seleccionar un tipo de pago hasta")
                            cbo_h_empresa.Focus()
                            Return False
                            Exit Function
                        Else
                            If CShort(cbo_d_empresa.SelectedIndex) > CShort(cbo_h_empresa.SelectedIndex) Then
                                MessageBox.Show("La Empresa desde debe ser menor al Empresa hasta")
                                cbo_d_empresa.Focus()
                                Return False
                                Exit Function
                            End If
                        End If
                        cadena = cadena + " between '" & cbo_d_empresa.SelectedItem.ToString & "' and '" & cbo_h_empresa.SelectedItem.ToString & "'"
                End Select
                primero = False
            End If

            If cbo_cr_cuotas.SelectedIndex <> -1 Then
                If primero = True Then
                    cadena = cadena + " v.cuotas "
                Else
                    cadena = cadena + " and v.cuotas "
                End If
                If verificarnumeronatural(txt_d_cuotas.Text) = True Then
                    Select Case cbo_cr_cuotas.SelectedIndex
                        Case 0 : cadena = cadena + " = " & txt_d_cuotas.Text
                        Case 1 : cadena = cadena + " > " & txt_d_cuotas.Text
                        Case 2 : cadena = cadena + " < " & txt_d_cuotas.Text
                        Case 3 : cadena = cadena + " <> " & txt_d_cuotas.Text
                        Case 4
                            cadena = cadena + " between " & txt_d_cuotas.Text & " and " & txt_h_cuotas.Text
                            If CShort(txt_d_cuotas.Text) > CShort(txt_h_cuotas.Text) Then
                                MessageBox.Show("La cuota desde debe ser menor a la cuota hasta")
                                txt_d_cuotas.Focus()
                                Return False
                                Exit Function
                            End If
                            If verificarnumeronatural(txt_h_cuotas.Text) = False Then
                                MessageBox.Show("Cuota Incorrecta")
                                txt_h_cuotas.Focus()
                                Return False
                                Exit Function
                            End If
                    End Select
                    primero = False
                Else
                    MessageBox.Show("Cuota Incorrecta")
                    txt_d_cuotas.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If cbo_cr_estado.SelectedIndex <> -1 Then
                If cbo_cr_estado.SelectedIndex <> 0 Then
                    If primero = True Then
                        cadena = cadena + " estado "
                    Else
                        cadena = cadena + " and estado "
                    End If
                    Select Case cbo_cr_estado.SelectedIndex
                        Case 1 : cadena = cadena + " = 'C'"
                        Case 2 : cadena = cadena + " = 'A'"
                    End Select
                End If
                primero = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function
End Class