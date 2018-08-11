Imports System.Data.SqlClient
Module Genérico
    Public Const Ruta As String = "DATA SOURCE=(LOCAL); INITIAL CATALOG=Local;USER ID=SA; PASSWORD=''; INTEGRATED SECURITY=sspi"
    Public agregar As Boolean
    Public ArchivoAImprimir As System.IO.StreamReader
    Public FuenteAUsar As System.Drawing.Font = New System.Drawing.Font("Arial", 14)

    Public Enum eAccion As Byte
        Ver = 0
        Agregar = 1
        Modificar = 2
        Seleccionar = 3
        Filtro = 4
    End Enum
    Public Accion As eAccion
    Public aAnterior As eAccion
    Public Sub traer_codigos()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "devolvercodigos"
            cm.Parameters.AddWithValue("@cod_int", CShort(Productos.lv_productos.SelectedItems(0).SubItems(10).Text))
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If Accion = eAccion.Seleccionar Then
                        With RegistrarVenta
                            .txt_cod_anio.Text = dr.GetByte(0).ToString
                            .txt_cod_rubro.Text = dr.GetByte(1).ToString
                            .txt_cod_modelo.Text = dr.GetByte(2).ToString
                        End With
                    End If
                    If Accion = eAccion.Modificar Then
                        With Gestion_producto
                            .txt_codigo_anio.Text = dr.GetByte(0).ToString
                            .txt_codigo_rubro.Text = dr.GetByte(1).ToString
                            .txt_codigo_modelo.Text = dr.GetByte(2).ToString
                            .txt_ant_anio.Text = dr.GetByte(0).ToString
                            .txt_ant_mod.Text = dr.GetByte(2).ToString
                            .txt_ant_rub.Text = dr.GetByte(1).ToString
                        End With
                    End If
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

    Public Sub traer_marcas()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traermarcas"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader

            If Accion = eAccion.Modificar Or Accion = eAccion.Agregar Then
                Gestion_producto.cbo_marca.Items.Clear()
            End If
            If Accion = eAccion.Filtro Then
                With Filtro_p
                    .cbo_d_marca.Items.Clear()
                    .cbo_h_marca.Items.Clear()
                End With
            End If

            If dr.HasRows = True Then
                While dr.Read()
                    If Accion = eAccion.Modificar Or Accion = eAccion.Agregar Then
                        Gestion_producto.cbo_marca.Items.Add(dr.GetString(0))
                    End If
                    If Accion = eAccion.Filtro Then
                        With Filtro_p
                            .cbo_d_marca.Items.Add(dr.GetString(0))
                            .cbo_h_marca.Items.Add(dr.GetString(0))
                        End With
                    End If
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

    Public Sub traer_talles()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "traertalles"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader

            If Accion = eAccion.Modificar Or Accion = eAccion.Agregar Then
                Gestion_producto.cbo_talle.Items.Clear()
            End If
            If Accion = eAccion.Filtro Then
                With Filtro_p
                    .cbo_d_talle.Items.Clear()
                    .cbo_h_talle.Items.Clear()
                End With
            End If

            If dr.HasRows = True Then
                While dr.Read()
                    If Accion = eAccion.Modificar Or Accion = eAccion.Agregar Then
                        Gestion_producto.cbo_talle.Items.Add(dr.GetString(0))
                    End If
                    If Accion = eAccion.Filtro Then
                        With Filtro_p
                            .cbo_d_talle.Items.Add(dr.GetString(0))
                            .cbo_h_talle.Items.Add(dr.GetString(0))
                        End With
                    End If
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

    Public Function verificarnumerodecimal(ByVal numero As String) As Boolean
        Dim i As Byte
        Dim cont As Byte = 0
        Try
            If numero.Substring(0, 1) = "." Then
                Return False
                Exit Function
            End If
            For i = 0 To CByte(numero.Length - 1)
                If numero.Substring(i, 1) = "." Then
                    cont = CByte(cont + 1)
                    If cont > 1 Then
                        Return False
                        Exit Function
                    End If
                End If
            Next
            For i = 0 To CByte(numero.Length - 1)
                If IsNumeric(numero.Substring(i, 1)) = False And numero.Substring(i, 1) <> "." Then
                    Return False
                    Exit Function
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function
    Public Function verificarnumeronatural(ByVal numero As String) As Boolean
        Dim i As Byte
        Try
            For i = 0 To CByte(numero.Length - 1)
                If IsNumeric(numero.Substring(i, 1)) = False Then
                    Return False
                    Exit Function
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function
End Module
