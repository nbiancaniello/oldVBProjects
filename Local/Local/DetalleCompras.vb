Imports System.Data.SqlClient
Public Class DetalleCompras

    Private Sub DetalleCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        traer_detalle_compra()
        traer_total_compra()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        PDetalleCompra.DocumentName = "obtener"
        PDetalleCompra.Print()
    End Sub
    Private Sub pdetallecompras_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDetalleCompra.PrintPage
        Dim LineasPorPagina As Single
        Dim yPos As Single
        Dim MargenIzquierdo As Single = e.MarginBounds.Left
        Dim Linea As String = Nothing
        Dim i As Integer
        FuenteAUsar = New System.Drawing.Font("Arial", 10)
        LineasPorPagina = e.MarginBounds.Height / FuenteAUsar.GetHeight(e.Graphics)
        For i = 0 To lv_detalle_compra.Items.Count - 1
            Linea = lv_detalle_compra.Items(i).Text.PadLeft(2) & " - " & lv_detalle_compra.Items(i).SubItems(1).Text() & " - "
            Linea = Linea + lv_detalle_compra.Items(i).SubItems(2).Text() & " - " & lv_detalle_compra.Items(i).SubItems(3).Text()
            If Linea Is Nothing Then
                Exit For
            End If
            yPos = MargenIzquierdo + i * FuenteAUsar.GetHeight(e.Graphics)
            e.Graphics.DrawString(Linea, FuenteAUsar, Brushes.Black, MargenIzquierdo, yPos, New StringFormat)
        Next

    End Sub
    Private Sub traer_detalle_compra()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Byte = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "verdetallecompra"
            cm.Parameters.AddWithValue("@num_fac", Convert.ToInt32(Compras.lv_compras.SelectedItems(0).Text))
            cm.Parameters.AddWithValue("@cod_pro", Convert.ToInt16(Compras.lv_compras.SelectedItems(0).SubItems(1).Text))
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            lv_detalle_compra.Items.Clear()
            lv_detalle_compra.Visible = False
            If dr.HasRows = True Then
                While dr.Read()
                    lv_detalle_compra.Items.Add(dr.GetInt16(0).ToString)
                    lv_detalle_compra.Items(i).SubItems.Add(dr.GetByte(1).ToString)
                    lv_detalle_compra.Items(i).SubItems.Add(dr.GetDecimal(2).ToString)
                    lv_detalle_compra.Items(i).SubItems.Add(dr.GetDecimal(3).ToString)
                    i = CByte(i + 1)
                End While
                lv_detalle_compra.Visible = True
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            cn.Close()
            dr.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            'MessageBox.Show("Existe un problema con el programa")
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub traer_total_compra()
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "vertotaldetallecompra"
            cm.Parameters.AddWithValue("@num_fac", CInt(Compras.lv_compras.SelectedItems(0).Text))
            cm.Parameters.AddWithValue("@cod_pro", CShort(Compras.lv_compras.SelectedItems(0).SubItems(1).Text))
            cm.Connection = cn
            cn.Open()
            lbl_total_compra.Text = cm.ExecuteScalar.ToString
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
End Class