Imports System.Data
Imports System.Data.SqlClient
Public Class abm_mantenimiento
    Dim gv_motivo_abm As String

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alta.Click
        Try
            If gv_catalogo <> 1 Then
                txt_pk.Text = CStr(CByte(ds.Tables(gv_catalogo - 1).Rows(ds.Tables(gv_catalogo - 1).Rows.Count - 1).Item(0).ToString) + 1)
                txt_pk.Enabled = False
            Else
                txt_pk.Enabled = True
            End If
            grp_botones.Enabled = False
            grp_agregar.Enabled = True
            grp_ac.Enabled = True
            gv_motivo_abm = "A"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Try
            Select Case gv_motivo_abm
                Case "A"
                    If txt_pk.Text.Trim = "" Then
                        MessageBox.Show("Ingrese un código")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                    If Not verificar_numeros(txt_pk.Text, 3) Then
                        MessageBox.Show("El código ingresado es incorecto")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                    If CShort(txt_pk.Text) < 1 Then
                        MessageBox.Show("El código debe ser > 0")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                    If gv_catalogo = 1 Then
                        If CShort(txt_pk.Text) < 1000 Or CShort(txt_pk.Text) > 9999 Then
                            MessageBox.Show("El código postal está fuera de rango")
                            txt_pk.Focus()
                            Exit Sub
                        End If
                    Else
                        If CShort(txt_pk.Text) > 255 Then
                            MessageBox.Show("El código excede la capacidad de almacenamiento")
                            txt_pk.Focus()
                            Exit Sub
                        End If
                    End If
                    If txt_descripcion1.Text.Trim = "" Then
                        MessageBox.Show("Ingrese una descripción")
                        txt_descripcion1.Focus()
                        Exit Sub
                    End If
                    If gv_catalogo = 3 Or gv_catalogo = 6 Then
                        If Not verificar_cadena(txt_descripcion1.Text) Then
                            MessageBox.Show("La descripción ingresada es incorrecta")
                            txt_descripcion1.Focus()
                            Exit Sub
                        End If
                    End If
                    If Not verificar_repetidos() Then
                        If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If actualizar_tabla_catalogo() = True Then
                                If agregar_registro() = True Then
                                    MessageBox.Show("Registro Agregado Exitósamente")
                                    lsv_items.Items.Add(txt_pk.Text)
                                    lsv_items.Items(lsv_items.Items.Count - 1).SubItems.Add(txt_descripcion1.Text)
                                    limpiar_cajas()
                                    grp_botones.Enabled = True
                                    grp_ac.Enabled = False
                                    grp_agregar.Enabled = False
                                    Exit Sub
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("El código está repetido")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                Case "M"
                    If txt_pk.Text.Trim = "" Then
                        MessageBox.Show("Ingrese un código")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                    If Not verificar_numeros(txt_pk.Text, 3) Then
                        MessageBox.Show("El código ingresado es incorecto")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                    If CShort(txt_pk.Text) < 1 Then
                        MessageBox.Show("El código debe ser > 0")
                        txt_pk.Focus()
                        Exit Sub
                    End If
                    If gv_catalogo = 1 Then
                        If CShort(txt_pk.Text) < 1000 Or CShort(txt_pk.Text) > 9999 Then
                            MessageBox.Show("El código postal está fuera de rango")
                            txt_pk.Focus()
                            Exit Sub
                        End If
                    Else
                        If CShort(txt_pk.Text) > 255 Then
                            MessageBox.Show("El código excede la capacidad de almacenamiento")
                            txt_pk.Focus()
                            Exit Sub
                        End If
                    End If
                    If txt_descripcion1.Text.Trim = "" Then
                        MessageBox.Show("Ingrese una descripción")
                        txt_descripcion1.Focus()
                        Exit Sub
                    End If
                    If gv_catalogo = 3 Or gv_catalogo = 6 Then
                        If Not verificar_cadena(txt_descripcion1.Text) Then
                            MessageBox.Show("La descripción ingresada es incorrecta")
                            txt_descripcion1.Focus()
                            Exit Sub
                        End If
                    End If
                    If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If actualizar_tabla_catalogo() = True Then
                            If modificar_registro() = True Then
                                MessageBox.Show("Registro Modificado Exitósamente")
                                lsv_items.SelectedItems(0).SubItems(1).Text = txt_descripcion1.Text
                                limpiar_cajas()
                                grp_agregar.Enabled = False
                                grp_botones.Enabled = True
                                grp_ac.Enabled = False
                                Exit Sub
                            End If
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function verificar_repetidos() As Boolean
        Try
            If IsNothing(ds.Tables(gv_catalogo - 1).Rows.Find(txt_pk.Text)) Then
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Function agregar_registro() As Boolean
        Dim fila As DataRow
        Try
            fila = ds.Tables(gv_catalogo - 1).NewRow
            fila(0) = txt_pk.Text
            fila(1) = txt_descripcion1.Text.Trim
            ds.Tables(gv_catalogo - 1).Rows.Add(fila)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Private Function modificar_registro() As Boolean
        Dim fila As DataRow
        Try
            fila = ds.Tables(gv_catalogo - 1).Rows.Find(lsv_items.SelectedItems(0).SubItems(0).Text)
            fila.BeginEdit()
            fila(1) = txt_descripcion1.Text.Trim
            fila.EndEdit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Private Function eliminar_registro() As Boolean
        Dim fila As DataRow
        Try
            fila = ds.Tables(gv_catalogo - 1).Rows.Find(lsv_items.SelectedItems(0).SubItems(0).Text)
            fila.Delete()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Private Function actualizar_tabla_catalogo() As Boolean
        Dim tran As SqlTransaction
        Dim lv_nombre_columna As String
        Dim lv_nombre_tabla As String = devolver_nombre_tabla(lv_nombre_columna)
        Dim lv_cadena As String
        Try
            Select Case gv_motivo_abm
                Case "A" : lv_cadena = "INSERT INTO " & lv_nombre_tabla & " VALUES (" & txt_pk.Text & ",'" & txt_descripcion1.Text & "')"
                Case "B" : lv_cadena = "DELETE FROM " & lv_nombre_tabla & " WHERE " & lv_nombre_columna & " = " & lsv_items.SelectedItems(0).SubItems(0).Text
                    If gv_catalogo <> 1 Then
                        If gv_catalogo = 5 Then
                            lv_cadena = lv_cadena & "   UPDATE alumnosdetalles SET " & lv_nombre_columna & " = 255"
                        Else
                            lv_cadena = lv_cadena & "   UPDATE alumnos SET " & lv_nombre_columna & " = 255" & _
                                                    "   UPDATE profesores SET " & lv_nombre_columna & " = 255"
                        End If
                    Else
                        lv_cadena = lv_cadena & "   UPDATE alumnos SET " & lv_nombre_columna & " = 1000" & _
                                                "   UPDATE profesores SET " & lv_nombre_columna & " = 1000"
                    End If

                Case "M" : lv_cadena = "UPDATE " & lv_nombre_tabla & " SET descripcion = '" & txt_descripcion1.Text & "'" & _
                                             " WHERE " & lv_nombre_columna & " = " & lsv_items.SelectedItems(0).SubItems(0).Text
            End Select
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = lv_cadena
            con.Open()
            tran = con.BeginTransaction
            com.Transaction = tran
            com.ExecuteNonQuery()
            tran.Commit()
            con.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        txt_descripcion1.Clear()
        txt_pk.Clear()
        grp_agregar.Enabled = False
        grp_ac.Enabled = False
        grp_botones.Enabled = True
        Me.Close()
    End Sub

    Private Sub abm_mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            limpiar_cajas()
            cargar_lista()
            Select Case gv_catalogo
                Case 1
                    Me.Text = "ABM Localidades - " & gv_nombre_sistema
                    lbl_et_agregar_pk.Text = "CP"
                    lbl_et_agregar_desc.Text = "Localidad"
                    txt_pk.MaxLength = 4
                    txt_descripcion1.MaxLength = 50
                Case 3
                    Me.Text = "ABM Nacionalidades - " & gv_nombre_sistema
                    lbl_et_agregar_pk.Text = "Código"
                    lbl_et_agregar_desc.Text = "Nacionalidad"
                    txt_pk.MaxLength = 3
                    txt_descripcion1.MaxLength = 20
                Case 5
                    Me.Text = "ABM Lugares de Nacimiento - " & gv_nombre_sistema
                    lbl_et_agregar_pk.Text = "Código"
                    lbl_et_agregar_desc.Text = "L. de Nacimiento"
                    txt_pk.MaxLength = 3
                    txt_descripcion1.MaxLength = 50
                Case 6
                    Me.Text = "ABM Títulos - " & gv_nombre_sistema
                    lbl_et_agregar_pk.Text = "Código"
                    lbl_et_agregar_desc.Text = "Título"
                    txt_pk.MaxLength = 3
                    txt_descripcion1.MaxLength = 45
            End Select
            lsv_items.Columns(0).Text = lbl_et_agregar_pk.Text
            lsv_items.Columns(1).Text = lbl_et_agregar_desc.Text
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_descripcion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcion1.KeyPress
        Try
            Select Case gv_catalogo
                Case 1
                    If Char.IsNumber(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = "-" Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_descripcion2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Select Case gv_catalogo
                Case 1
                    If Char.IsNumber(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub limpiar_cajas()
        Try
            txt_descripcion1.Clear()
            txt_pk.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt_pk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pk.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            limpiar_cajas()
            grp_ac.Enabled = False
            grp_botones.Enabled = True
            grp_agregar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            If lsv_items.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un código")
                Exit Sub
            End If
            txt_pk.Text = lsv_items.SelectedItems(0).SubItems(0).Text
            txt_descripcion1.Text = lsv_items.SelectedItems(0).SubItems(1).Text
            txt_pk.Enabled = False
            grp_botones.Enabled = False
            grp_ac.Enabled = True
            grp_agregar.Enabled = True
            gv_motivo_abm = "M"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baja.Click
        Try
            If lsv_items.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione un código")
                Exit Sub
            End If
            gv_motivo_abm = "B"
            If MessageBox.Show("¿Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If actualizar_tabla_catalogo() = True Then
                    If eliminar_registro() = True Then
                        MessageBox.Show("Registro Eliminado Exitósamente")
                        limpiar_cajas()
                        lsv_items.Items.RemoveAt(lsv_items.SelectedIndices(0))
                        grp_botones.Enabled = True
                        grp_ac.Enabled = False
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub cargar_lista()
        Dim i As Int16
        lsv_items.Items.Clear()
        Try
            For i = 0 To CShort(ds.Tables(gv_catalogo - 1).Rows.Count - 1)
                lsv_items.Items.Add(ds.Tables(gv_catalogo - 1).Rows(i).Item(0).ToString)
                lsv_items.Items(i).SubItems.Add(ds.Tables(gv_catalogo - 1).Rows(i).Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class