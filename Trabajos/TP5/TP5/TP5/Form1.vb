Imports System.Data.SqlClient
Public Class Form1
    Dim subcadena As String
    Dim condicion As String

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer
        Dim cadena As String

        lv_datos.Items.Clear()
        Try
            If cbo_campos.SelectedIndex = -1 And txt_dato.Text = "" Then
                MessageBox.Show("Seleccione un campo")
                cbo_campos.Focus()
                Exit Sub
            End If
            If cbo_campos.SelectedIndex <> 2 Then
                If cbo_requisitos.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione un requisito")
                    cbo_requisitos.Focus()
                    Exit Sub
                End If
                If txt_dato.Text.Trim = "" Then
                    MessageBox.Show("Escriba algún dato")
                    txt_dato.Focus()
                    Exit Sub
                End If
            End If
            If cbo_campos.SelectedIndex <> 2 Then
                cadena = "SELECT codigo, nombre, fecha_nac, estado FROM Personas "
                If cbo_campos.SelectedIndex <> 1 Then
                    cadena = cadena & "WHERE " & subcadena & condicion & txt_dato.Text
                Else
                    Select Case cbo_requisitos.SelectedIndex
                        Case 0 : condicion = condicion & txt_dato.Text.Trim & "'"
                        Case 1 : condicion = condicion & txt_dato.Text.Trim & "%'"
                        Case 2 : condicion = condicion & txt_dato.Text.Trim & "%'"
                        Case 3 : condicion = condicion & txt_dato.Text.Trim & "'"
                    End Select
                    cadena = cadena & "WHERE " & subcadena & condicion
                End If
            Else
                cadena = "SELECT codigo, nombre, fecha_nac, estado FROM Personas "
                cadena = cadena & "WHERE fecha_nac = '" & dtp_fecha.Value.ToShortDateString & "'"
            End If
            CN.ConnectionString = Ruta
            CM.CommandType = CommandType.Text
            CM.Connection = CN
            CM.CommandText = cadena
            CN.Open()
            DR = CM.ExecuteReader
            While DR.Read
                lv_datos.Items.Add(DR.GetInt16(0).ToString)
                lv_datos.Items(i).SubItems.Add(DR.GetString(1))
                lv_datos.Items(i).SubItems.Add(DR.GetDateTime(2).ToShortDateString)
                If DR.GetByte(3) = 0 Then
                    lv_datos.Items(i).SubItems.Add("ACTIVO")
                Else
                    lv_datos.Items(i).SubItems.Add("INACTIVO")
                End If
                i = i + 1
            End While
            DR.Close()
            CN.Close()
        Catch ex As Exception
            MessageBox.Show("Problema con los datos")
        Finally
            CM.Dispose()
            CN.Dispose()
        End Try
        'Else
        '    Try
        '        CN.ConnectionString = Ruta
        '        CM.CommandType = CommandType.StoredProcedure
        '        CM.Connection = CN
        '        CM.CommandText = "TraerDatosPersonas"
        '        CN.Open()
        '        DR = CM.ExecuteReader
        '        While DR.Read
        '            lv_datos.Items.Add(DR.GetInt16(0).ToString)
        '            lv_datos.Items(i).SubItems.Add(DR.GetString(1))
        '            lv_datos.Items(i).SubItems.Add(DR.GetDateTime(2).ToShortDateString)
        '            If DR.GetByte(3) = 0 Then
        '                lv_datos.Items(i).SubItems.Add("ACTIVO")
        '            Else
        '                lv_datos.Items(i).SubItems.Add("INACTIVO")
        '            End If
        '            i = i + 1
        '        End While
        '        DR.Close()
        '        CN.Close()
        '    Catch ex As Exception
        '        MessageBox.Show("Problemas con la conexión")
        '    Finally
        '        CM.Dispose()
        '        CN.Dispose()
        '    End Try
        'End If
        stp_estado.Items.Clear()
        stp_estado.Items.Add("Filtro: " & cbo_campos.Text & " - " & cbo_requisitos.Text & " - " & txt_dato.Text)
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        AccionForm = eAccion.AGREGAR
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If lv_datos.Items.Count = 0 Then
            MessageBox.Show("No hay datos en la tabla")
        Else
            If lv_datos.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un registro")
            Else
                AccionForm = eAccion.MODIFICAR
                Form2.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        If lv_datos.Items.Count <> 0 Then
            If lv_datos.SelectedItems.Count <> 0 Then
                If MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Try
                        CN.ConnectionString = Ruta
                        CM.CommandType = CommandType.StoredProcedure
                        CM.Connection = CN
                        CM.CommandText = "EliminarPersona"
                        CM.Parameters.AddWithValue("@codigo", Convert.ToInt16(lv_datos.SelectedItems(0).Text))
                        CN.Open()
                        CM.ExecuteNonQuery()
                        MessageBox.Show("Registro eliminado")
                        lv_datos.Items.Remove(lv_datos.SelectedItems(0))
                    Catch ex As Exception
                        MessageBox.Show("Problema con la base de datos")
                    End Try
                End If
            Else
                MessageBox.Show("Elija un registro para eliminar")
            End If
        Else
            MessageBox.Show("No hay datos en la tabla")
        End If
    End Sub

    Private Sub cbo_campos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_campos.SelectedIndexChanged
        subcadena = ""
        Select Case cbo_campos.SelectedIndex
            Case 0 : cargar_requisitos_numero()
                subcadena = "codigo"
            Case 1 : cargar_requisitos_texto()
                subcadena = "nombre"
            Case 2 : cargar_fecha()
            Case 3 : cargar_requisitos_numero()
                subcadena = "estado"
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fecha.MaxDate = Now.Date
    End Sub

    Private Sub cargar_requisitos_numero()
        With cbo_requisitos.Items
            .Clear()
            .Add("Igual a")
            .Add("Mayor que")
            .Add("Menor que")
            .Add("Distinto de")
        End With
        ocultar_fecha()
        txt_dato.Clear()
    End Sub

    Private Sub cargar_requisitos_texto()
        With cbo_requisitos.Items
            .Clear()
            .Add("Igual que")
            .Add("Comienza con")
            .Add("Contiene")
            .Add("Finaliza en")
        End With
        ocultar_fecha()
        txt_dato.Clear()
    End Sub

    Private Sub cargar_fecha()
        cbo_requisitos.Visible = False
        txt_dato.Visible = False
        dtp_fecha.Visible = True
        txt_dato.Clear()
    End Sub

    Private Sub ocultar_fecha()
        cbo_requisitos.Visible = True
        txt_dato.Visible = True
        dtp_fecha.Visible = False
        txt_dato.Clear()
    End Sub

    Private Sub cbo_requisitos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_requisitos.SelectedIndexChanged
        condicion = ""
        If cbo_campos.SelectedIndex <> 1 Then
            Select Case cbo_requisitos.SelectedIndex
                Case 0 : condicion = " = "
                Case 1 : condicion = " > "
                Case 2 : condicion = " < "
                Case 3 : condicion = " <> "
            End Select
        Else
            Select Case cbo_requisitos.SelectedIndex
                Case 0 : condicion = " = '"
                Case 1 : condicion = " LIKE '"
                Case 2 : condicion = " LIKE '%"
                Case 3 : condicion = " LIKE '%"
            End Select
        End If
    End Sub

End Class
