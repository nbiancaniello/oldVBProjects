Imports System.Data.SqlClient
Public Class Compras

    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection
        Dim cm As New SqlCommand
        Dim dr As SqlDataReader
        Dim i As Byte = 0
        Try
            cn.ConnectionString = Ruta
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "vercompras"
            cm.Connection = cn
            cn.Open()
            dr = cm.ExecuteReader
            lv_compras.Items.Clear()
            lv_compras.Visible = False
            If dr.HasRows = True Then
                While dr.Read()
                    lv_compras.Items.Add(dr.GetInt32(0).ToString)
                    lv_compras.Items(i).SubItems.Add(dr.GetInt16(1).ToString)
                    lv_compras.Items(i).SubItems.Add(dr.GetDateTime(2).ToShortDateString)
                    i = CByte(i + 1)
                End While
                lv_compras.Visible = True
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            cn.Close()
            dr.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            'MessageBox.Show("Existe un problema con el programa")
            MessageBox.Show(ex.ToString)
        Finally
            cn.Dispose()
            cm.Dispose()
        End Try
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub lv_compras_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_compras.DoubleClick
        DetalleCompras.ShowDialog()
    End Sub
End Class