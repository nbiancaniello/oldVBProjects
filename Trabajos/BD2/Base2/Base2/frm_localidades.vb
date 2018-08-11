Imports System.Data.SqlClient

Public Class frm_localidades
    Dim ArchivoAImprimir As System.IO.StreamReader
    Dim FuenteAUsar As System.Drawing.Font
    Private Sub frm_localidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim CN As New SqlConnection
        Dim DR As SqlDataReader
        Dim CM As New SqlCommand
        Try
            CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = TP4; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = SSPI"
            CM.CommandType = CommandType.Text
            CM.CommandText = "SELECT CP, LOCALIDAD FROM LOCALIDADES"
            CM.Connection = CN
            CN.Open()
            DR = CM.ExecuteReader
            lv_localidades.Items.Clear()
            lv_localidades.Visible = False
            If DR.HasRows = True Then
                While DR.Read()
                    lv_localidades.Items.Add(DR.GetInt16(0).ToString)
                    lv_localidades.Items(i).SubItems.Add(DR.GetString(1))
                    i = i + 1
                End While
                lv_localidades.Visible = True
            Else
                MessageBox.Show("No hay datos en la tabla")
            End If
            CN.Close()
            DR.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show("Existe un problema con el programa")
        Finally
            CN.Dispose()
            CM.Dispose()
        End Try

        FuenteAUsar = New System.Drawing.Font("Arial", 10)
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand

        Try
            If lv_localidades.Items.Count = 0 Then
                MessageBox.Show("No hay datos")
            Else
                If lv_localidades.SelectedItems.Count = 0 Then
                    MessageBox.Show("Seleccione un elemento")
                Else
                    If MessageBox.Show("¿Está Seguro?", "Pregunta", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        CN.ConnectionString = "DATA SOURCE = (LOCAL); INITIAL CATALOG = TP4; USER ID = SA; PASSWORD = ''; INTEGRATED SECURITY = sspi"
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM LOCALIDADES WHERE CP = " & lv_localidades.SelectedItems(0).Text
                        End With
                        CN.Open()
                        CM.ExecuteNonQuery()
                        CN.Close()
                        lv_localidades.Items.Remove(lv_localidades.SelectedItems(0))
                    End If
                End If
            End If
        Catch ex As SqlException
            MessageBox.Show("Problema con la base de datos")
        Catch ex As Exception
            MessageBox.Show("Problema con los datos")
        Finally
            CN.Dispose()
            CM.Dispose()
        End Try
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Accion = eAccion.AGREGAR
        frm_agrmodlocalidades.ShowDialog()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If lv_localidades.SelectedItems.Count = 1 Then
            Accion = eAccion.MODIFICAR
            frm_agrmodlocalidades.ShowDialog()
        Else
            MessageBox.Show("Seleccione una localidad")
        End If
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        PDocumento.Print()
    End Sub

    Private Sub PDocumento_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDocumento.PrintPage
        Dim LineasPorPagina As Single
        Dim yPos As Single
        Dim MargenIzquierdo As Single = e.MarginBounds.Left
        Dim Linea As String = Nothing
        Dim i As Integer
        LineasPorPagina = e.MarginBounds.Height /FuenteAUsar.GetHeight(e.Graphics)
        For i = 0 To lv_localidades.Items.Count - 1
            Linea = lv_localidades.Items(i).Text.PadLeft(2) & " - " & lv_localidades.Items(i).SubItems(1).Text()
            If Linea Is Nothing Then
                Exit For
            End If
            yPos = MargenIzquierdo + i * FuenteAUsar.GetHeight(e.Graphics)
            e.Graphics.DrawString(Linea, FuenteAUsar, Brushes.Black, MargenIzquierdo, yPos, New StringFormat)
        Next

    End Sub
End Class
