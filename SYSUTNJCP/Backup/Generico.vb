Imports System.Data
Imports System.Data.SqlClient
Module Genérico
    Public ruta As String = "DATA SOURCE =(LOCAL); INITIAL CATALOG = sysadm_prueba; USER ID = sa; PASSWORD = ''; INTEGRATED SECURITY = sspi"
    Public ds As New DataSet("Generico")
    Public con As SqlConnection
    Public com As SqlCommand
    Public da As SqlDataAdapter
    Public fila As DataRow
    Public dv1 As New DataView
    Public dv2 As New DataView
    Public dv3 As New DataView
    Public dv4 As New DataView
    Public dv5 As New DataView
    Public dv6 As New DataView
    Public dv7 As New DataView
    Public dv8 As New DataView
    Public dv9 As New DataView
    Public dv10 As New DataView
    Public dv11 As New DataView
    Public dv12 As New DataView
    Public gv_usuario As String
    Public gv_permiso As String
    Public gv_nombre_sistema As String = "UTN System ®"
    Public gv_dia1_materia As Byte
    Public gv_dia2_materia As Byte
    Public gv_carrera As Byte
    Public gv_catalogo As Byte
    Public gv_cant_materias_introductorio As Byte
    Public gv_cant_materias_tsp As Byte
    Public gv_cant_materias_tssi As Byte

    Public Sub retocar_formulario(ByRef form As Form, ByVal titulo As String)
        Try
            form.ControlBox = False
            form.Text = titulo
            form.StartPosition = FormStartPosition.CenterScreen
            form.FormBorderStyle = FormBorderStyle.FixedSingle
            'form.ShowIcon = True 
            'Icon.ExtractAssociatedIcon("D:\Documentos\Documentos de Nico\SYSUTNJCP\utn.jpg")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub traer_cantidad_materias_por_etapa()
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim cant As Byte
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_cantidad_materias_por_etapa"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@carr", 0)
            con.Open()
            gv_cant_materias_introductorio = CByte(com.ExecuteScalar)
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@carr", 1)
            gv_cant_materias_tsp = CByte(com.ExecuteScalar)
            com.Parameters.Clear()
            com.Parameters.AddWithValue("@carr", 2)
            gv_cant_materias_tssi = CByte(com.ExecuteScalar)
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_datos_de_tablas()
        ' Se traen todos los datos de ls BD al comienzo del programa
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            da = New SqlDataAdapter

            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_localidades"
            com.Connection = con
            con.Open()
            da.SelectCommand = com
            da.Fill(ds, "Localidades")
            com.CommandText = "traer_tipo_documentos"
            da.Fill(ds, "TiposDocumento")
            com.CommandText = "traer_nacionalidades"
            da.Fill(ds, "Nacionalidades")
            com.CommandText = "traer_estados_civiles"
            da.Fill(ds, "EstadosCivil")
            com.CommandText = "traer_lugares_nacimiento"
            da.Fill(ds, "LugaresNacimiento")
            com.CommandText = "traer_titulos"
            da.Fill(ds, "Titulos")
            com.CommandText = "traer_materias_tsp"
            da.Fill(ds, "Materias_tsp")
            com.CommandText = "traer_lista_profesores"
            da.Fill(ds, "Profesores")
            com.CommandText = "traer_materias_tssi"
            da.Fill(ds, "Materias_tssi")
            com.CommandText = "traer_carreras"
            da.Fill(ds, "Carreras")
            com.CommandText = "traer_materias"
            da.Fill(ds, "Materias")
            com.CommandText = "traer_materias_introductorio"
            da.Fill(ds, "Materias_introductorio")
            ds.Tables(0).PrimaryKey = New DataColumn() {ds.Tables(0).Columns(0)}
            ds.Tables(1).PrimaryKey = New DataColumn() {ds.Tables(1).Columns(0)}
            ds.Tables(2).PrimaryKey = New DataColumn() {ds.Tables(2).Columns(0)}
            ds.Tables(3).PrimaryKey = New DataColumn() {ds.Tables(3).Columns(0)}
            ds.Tables(4).PrimaryKey = New DataColumn() {ds.Tables(4).Columns(0)}
            ds.Tables(5).PrimaryKey = New DataColumn() {ds.Tables(5).Columns(0)}
            ds.Tables(6).PrimaryKey = New DataColumn() {ds.Tables(6).Columns(0)}
            ds.Tables(7).PrimaryKey = New DataColumn() {ds.Tables(7).Columns(0)}
            ds.Tables(8).PrimaryKey = New DataColumn() {ds.Tables(8).Columns(0)}
            ds.Tables(9).PrimaryKey = New DataColumn() {ds.Tables(9).Columns(0)}
            ds.Tables(10).PrimaryKey = New DataColumn() {ds.Tables(10).Columns(0)}
            ds.Tables(11).PrimaryKey = New DataColumn() {ds.Tables(11).Columns(0)}
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
            da.Dispose()
        End Try
    End Sub

    Public Function verificar_numeros(ByVal numero As String, ByVal tipo As Byte) As Boolean
        ' Esta función se utiliza con cadenas que contengan sólo números enteros
        Dim i As Byte
        Try
            Select Case tipo
                Case 1
                    For i = 0 To CByte(numero.Length - 1)
                        If Char.IsNumber(CChar(numero.Substring(i, 1))) = False And numero.Substring(i, 1) <> "," Then
                            Return False
                        End If
                    Next
                Case 2
                    For i = 0 To CByte(numero.Length - 1)
                        If Char.IsNumber(CChar(numero.Substring(i, 1))) = False And numero.Substring(i, 1) <> "-" _
                           And numero.Substring(i, 1) <> "(" And numero.Substring(i, 1) <> ")" Then
                            Return False
                        End If
                    Next
                Case 3
                    For i = 0 To CByte(numero.Length - 1)
                        If Char.IsNumber(CChar(numero.Substring(i, 1))) = False Then
                            Return False
                        End If
                    Next
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function verificar_cadena(ByVal cadena As String) As Boolean
        ' Esta función se utiliza con cadenas que contengan sólo números enteros
        Dim i As Byte
        Try
            For i = 0 To CByte(cadena.Length - 1)
                If Char.IsLetter(CChar(cadena.Substring(i, 1))) = False And Char.IsWhiteSpace(CChar(cadena.Substring(i, 1))) = False _
                    And cadena.Substring(i, 1) <> "'" And cadena.Substring(i, 1) <> "." And cadena.Substring(i, 1) <> "," _
                    And cadena.Substring(i, 1) <> "-" And cadena.Substring(i, 1) <> "/" Then

                    Return False
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function verificar_mail(ByVal mail As String) As Boolean
        ' Esta función se utiliza para verificar que el mail comienze con una letra, y que no contenga más de 1 "@"
        Dim i As Byte
        Dim cant As Byte = 0
        Try
            If Char.IsLetter(CChar(mail.Substring(0, 1))) = False Then
                Return False
            End If
            For i = 1 To CByte(mail.Length - 1)
                If mail.Substring(i, 1) = "@" Then
                    cant = CByte(cant + 1)
                    If cant > 1 Then
                        Return False
                    End If
                End If
                If (Char.IsLetter(CChar(mail.Substring(0, 1))) = False And Char.IsNumber(CChar(mail.Substring(0, 1))) = False) _
                    And cant = 0 Then
                    Return False
                End If
            Next
            If cant = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Public Sub registrar_errores(ByVal nombre As String, ByVal mensaje As String)
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "registrar_errores"
            com.Parameters.AddWithValue("@fechayhora", Now)
            com.Parameters.AddWithValue("@modulo", nombre)
            com.Parameters.AddWithValue("@mensaje", mensaje)
            com.Parameters.AddWithValue("@usuario", gv_usuario)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Function devolver_estado_materia(ByVal caracter As String) As String
        Try
            Select Case caracter
                Case "P" : Return "PENDIENTE"
                Case "F" : Return "FINAL"
                Case "C" : Return "CURSANDO"
                Case "R" : Return "RECURSA"
                Case "A" : Return "APROBADA"
                Case "B" : Return "ABANDONO"
                Case "D" : Return "DIAGNÓSTICO"
                Case "T" : Return "RECUPERATORIO"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "DESCONOCIDO"
    End Function

    Public Function devolver_tipo_letra(ByVal caracter As String) As String
        Try
            Select Case caracter
                Case "PARCIAL" : Return "P"
                Case "RECUPERATORIO 1" : Return "R1"
                Case "RECUPERATORIO 2" : Return "R2"
                Case "ORAL" : Return "O"
                Case "DOMICILIARIO" : Return "D"
                Case "AMBOS" : Return "A"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "U"
    End Function

    Public Function devolver_tipo(ByVal caracter As String) As String
        Try
            Select Case caracter
                Case "P" : Return "PARCIAL"
                Case "R1" : Return "RECUPERATORIO 1"
                Case "R2" : Return "RECUPERATORIO 2"
                Case "O" : Return "ORAL"
                Case "D" : Return "DOMICILIARIO"
                Case "A" : Return "AMBOS"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "DESCONOCIDO"
    End Function

    Public Function devolver_asistencia(ByVal caracter As String) As String
        Try
            Select Case caracter
                Case "P" : Return "PRESENTE"
                Case "T" : Return "TARDE"
                Case "V" : Return "TARDE C/AVISO"
                Case "A" : Return "AUSENTE"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "DESCONOCIDO"
    End Function

    Public Function devolver_letra_numero(ByVal numero As Byte) As String
        Try
            Select Case numero
                Case 1 : Return "UNO"
                Case 2 : Return "DOS"
                Case 3 : Return "TRES"
                Case 4 : Return "CUATRO"
                Case 5 : Return "CINCO"
                Case 6 : Return "SEIS"
                Case 7 : Return "SIETE"
                Case 8 : Return "OCHO"
                Case 9 : Return "NUEVE"
                Case 10 : Return "DIEZ"
                Case 11 : Return "APROBADO"
                Case 12 : Return "DESAPROBADO"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "CERO"
    End Function

    Public Sub traer_nombre_apellido(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_alumnos_por_carrera"
                    com.Parameters.AddWithValue("@car", gv_carrera)
                Case 2 : com.CommandText = "traer_profesores"
                    com.Parameters.AddWithValue("@tipo", "P")
                Case 3 : com.CommandText = "traer_profesores"
                    com.Parameters.AddWithValue("@tipo", "A")
                Case 4 : com.CommandText = "traer_docentes"
                Case 5 : com.CommandText = "traer_profesores_por_codprofesor"
                Case 6 : com.CommandText = "traer_alumnos_activos_por_carrera"
                    com.Parameters.AddWithValue("@car", gv_carrera)
            End Select

            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                If tipo = 1 Then
                    While dr.Read
                        lista.Items.Add(dr.GetInt16(0).ToString)
                        lista.Items(i).SubItems.Add(dr.GetInt16(1).ToString)
                        lista.Items(i).SubItems.Add(dr.GetString(2) & ", " & dr.GetString(3))
                        i = CShort(i + 1)
                    End While
                End If
                If tipo = 6 Then
                    While dr.Read
                        lista.Items.Add(dr.GetInt16(0).ToString)
                        lista.Items(i).SubItems.Add(dr.GetInt16(1).ToString)
                        lista.Items(i).SubItems.Add(dr.GetString(2) & ", " & dr.GetString(3))
                        lista.Items(i).SubItems.Add(dr.GetByte(4).ToString)
                        i = CShort(i + 1)
                    End While
                End If
                If tipo >= 2 And tipo <= 5 Then
                    While dr.Read
                        lista.Items.Add(dr.GetInt16(0).ToString)
                        lista.Items(i).SubItems.Add(dr.GetString(1) & ", " & dr.GetString(2))
                        i = CShort(i + 1)
                    End While
                End If
                lista.Visible = True
            Else
                Select Case tipo
                    Case 1 : MessageBox.Show("No hay alumnos inscriptos")
                    Case 2 : MessageBox.Show("No hay profesores inscriptos")
                    Case 3 : MessageBox.Show("No hay ayudantes inscriptos")
                    Case 5 : MessageBox.Show("No hay profesores inscriptos")
                        'observacionesprofesores.Close()
                        Exit Sub
                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Function traer_nombre_materia(ByVal codmateria As Byte) As String
        Dim dr As SqlDataReader
        Dim nombre As String

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_nombre_materia"
            com.Parameters.AddWithValue("@cod", codmateria)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                nombre = dr.GetString(0)
            End While
            dr.Close()
            con.Close()
            Return nombre
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
        Return ""
    End Function

    Public Sub traer_nombreplanmateria(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            ''lista.Visible = False
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_planmaterias_tsp"
                    'com.Parameters.AddWithValue("@plan", plan)


                Case 2 : com.CommandText = "traer_planmaterias_tssi"
                    'com.Parameters.AddWithValue("@plan", plan)

            End Select

            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetByte(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(1))
                    i = CShort(i + 1)
                End While
                lista.Visible = True

            Else
                Select Case tipo
                    Case 1 : MessageBox.Show("No Hay Materias Cargadas")
                        'tsp_plandecarrera.lblmaterias.Text = "Debe cargar las materias antes de ingresar el plan "


                    Case 2 : MessageBox.Show("No Hay Materias Cargadas")
                        'tssi_plandecarrera.lblmaterias.Text = "Debe cargar las materias antes de ingresar el plan "
                        Exit Sub

                End Select

            End If


            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_materia(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            'lista.Visible = False
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_materias_tsp"
                Case 2 : com.CommandText = "traer_materias_tssi"


            End Select

            con.Open()
            dr = com.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetByte(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(1))

                    i = CShort(i + 1)
                End While
                lista.Visible = True
            Else
                Select Case tipo
                    Case 1 : MessageBox.Show("No Hay Materias Cargadas")
                    Case 2 : MessageBox.Show("No Hay Materias Cargadas")

                        Exit Sub


                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_materiacompleta(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            'lista.Visible = False
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_materiascompletastsp"
                Case 2 : com.CommandText = "traer_materiascompletastssi"


            End Select

            con.Open()
            dr = com.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetByte(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetByte(1).ToString)
                    lista.Items(i).SubItems.Add(dr.GetByte(2).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(3))
                    lista.Items(i).SubItems.Add(dr.GetByte(4).ToString)
                    lista.Items(i).SubItems.Add(dr.GetByte(5).ToString)


                    i = CShort(i + 1)
                End While
                lista.Visible = True
            Else
                Select Case tipo
                    Case 1 : MessageBox.Show("No Hay Materias Cargadas")
                    Case 2 : MessageBox.Show("No Hay Materias Cargadas")

                        Exit Sub


                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_descripcion(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            'lista.Visible = False
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_observaciones"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)

                Case 2 : com.CommandText = "traer_observacionesp"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)


            End Select

            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetString(0))
                    lista.Items(i).SubItems.Add(dr.GetString(1))
                    i = CShort(i + 1)
                End While
                lista.Visible = True
            Else
                Select Case tipo
                    Case 1 : MessageBox.Show("No hay observaciones inscriptas")
                    Case 2 : MessageBox.Show("No hay observaciones inscriptas")
                    Case 3 : MessageBox.Show("No hay observaciones inscriptas")
                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Function verificar_documentorepetido(ByVal tipo As Byte, ByVal nrodoc As Int32, ByVal tipodoc As Byte) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            Select Case tipo
                Case 1 : com.CommandText = "SELECT COUNT(nrodoc) FROM alumnos WHERE nrodoc = " & nrodoc & " AND tipodoc = " & tipodoc
                Case 2 : com.CommandText = "SELECT COUNT(nrodoc) FROM profesores WHERE nrodoc = " & nrodoc & " AND tipodoc = " & tipodoc
            End Select

            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_planrepetida(ByVal codmateria As String, ByVal Descripcion As String, ByVal tema As String, ByVal plan As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(codmateria) FROM materiasplanificacion WHERE codmateria = '" & codmateria & "' and  Descripcion= '" & Descripcion & "' and  tema   = '" & tema & "'and  plandecarrera  = '" & plan & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_bitrepetida(ByVal codmateria As String, ByVal Descripcion As String, ByVal clase As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(codmateria) FROM materiasbitacora WHERE codmateria = '" & codmateria & "' and  Descripcion= '" & Descripcion & "' and  clase  = '" & clase & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Sub traer_descripcionmateria(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_planificacionestsp"
                    com.Parameters.Clear()
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)
                Case 2 : com.CommandText = "traer_planificacionestssi"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)
                Case 3 : com.CommandText = "traer_bitacoratsp"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)
                Case 4 : com.CommandText = "traer_bitacoratssi"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)

            End Select

            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetInt16(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(1))

                    i = CShort(i + 1)
                End While
                lista.Visible = True
            Else

                Select Case tipo
                    Case 1 : MessageBox.Show("No hay Temas Cargados")
                    Case 2 : MessageBox.Show("No hay Temas Cargados")
                    Case 3 : MessageBox.Show("No hay clases Cargadas")
                    Case 4 : MessageBox.Show("No hay clases Cargadas")

                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_descripcionmateriaxplan(ByRef lista As ListView, ByVal tipo As Byte, ByVal plan As String)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            'lista.Visible = False
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_planificacionestsp"
                    com.Parameters.Clear()
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)
                    com.Parameters.AddWithValue("@plandecarrera", plan)

                Case 2 : com.CommandText = "traer_planificacionestssi"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)
                    com.Parameters.AddWithValue("@plandecarrera", plan)

            End Select

            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetInt16(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(1))

                    i = CShort(i + 1)
                End While
                lista.Visible = True
            Else

                Select Case tipo
                    Case 1 : MessageBox.Show("No hay planificaciones Cargadas")
                    Case 2 : MessageBox.Show("No hay planificaciones Cargadas")


                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_biblografia(ByRef lista As ListView, ByVal tipo As Byte)
        Dim dr As SqlDataReader
        Dim i As Int16 = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            'lista.Visible = False
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case tipo
                Case 1 : com.CommandText = "traer_bibliografiatsp"
                    com.Parameters.Clear()
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)
                Case 2 : com.CommandText = "traer_bibliografiatssi"
                    com.Parameters.AddWithValue("@nro", lista.SelectedItems(0).SubItems(0).Text)

            End Select

            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetString(0))
                    lista.Items(i).SubItems.Add(dr.GetString(1))
                    lista.Items(i).SubItems.Add(dr.GetString(2))


                    i = CShort(i + 1)
                End While
                lista.Visible = True
            Else

                Select Case tipo
                    Case 1 : MessageBox.Show("No hay Apuntes Cargados")
                    Case 2 : MessageBox.Show("No hay Apuntes Cargados")

                End Select
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_materias_por_alumno(ByRef lista As ListView, ByVal nroinscripcion As Int16, ByVal anioingreso As Int16, ByVal codcarrera As Byte)
        Dim dr As SqlDataReader
        Dim i As Byte = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            lista.Items.Clear()

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_materias_por_alumno"
            com.Parameters.AddWithValue("@nro", nroinscripcion)
            com.Parameters.AddWithValue("@anio", anioingreso)
            com.Parameters.AddWithValue("@carr", codcarrera)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetByte(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(1))
                    lista.Items(i).SubItems.Add(dr.GetByte(2).ToString)
                    lista.Items(i).SubItems.Add(dr.GetInt16(3).ToString)
                    lista.Items(i).SubItems.Add(devolver_estado_materia(dr.GetString(4)))
                    i = CByte(i + 1)
                End While
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub traer_materias_por_alumno_introductorio(ByRef lista As ListView, ByVal nroinscripcion As Int16, ByVal anioingreso As Int16, ByVal aniocursada As Int16, ByVal instancia As Byte, ByVal codcarrera As Byte)
        Dim dr As SqlDataReader
        Dim i As Byte = 0

        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand
            lista.Items.Clear()

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_materias_por_alumno_introductorio"
            com.Parameters.AddWithValue("@nro", nroinscripcion)
            com.Parameters.AddWithValue("@ing", anioingreso)
            com.Parameters.AddWithValue("@anio", aniocursada)
            com.Parameters.AddWithValue("@inst", instancia)
            com.Parameters.AddWithValue("@carr", codcarrera)
            con.Open()
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Items.Add(dr.GetByte(0).ToString)
                    lista.Items(i).SubItems.Add(dr.GetString(1))
                    lista.Items(i).SubItems.Add(dr.GetByte(2).ToString)
                    lista.Items(i).SubItems.Add(dr.GetInt16(3).ToString)
                    lista.Items(i).SubItems.Add(devolver_estado_materia(dr.GetString(4)))
                    i = CByte(i + 1)
                End While
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Sub

    Public Sub asignar_set_de_datos(ByRef lista As ComboBox, ByVal tipo As Byte)
        '                                           '
        '   TIPOS:                                  '
        '           1 - LOCALIDAD                   '
        '           2 - TIPO DOCUMENTO              '
        '           3 - NACIONALIDAD                '
        '           4 - ESTADO CIVIL                '
        '           5 - LUGAR DE NACIMIENTO         '
        '           6 - TÍTULO                      '
        '           7 - MATERIAS TSP                '
        '           8 - PROFESORES                  '
        '           9 - MATERIAS TSSI               '
        '          10 - CARRERAS                    '
        '          11 - MATERIAS                    '
        '          12 - MATERIAS INTRODUCTORIO      '
        '                                           '

        Try
            Select Case tipo
                Case 1
                    dv1.Table = ds.Tables(0)
                    dv1.Sort = "descripcion"
                    lista.DataSource = dv1
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "codpos"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 2
                    dv2.Table = ds.Tables(1)
                    dv2.Sort = "tipodoc"
                    lista.DataSource = dv2
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "tipodoc"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 3
                    dv3.Table = ds.Tables(2)
                    dv3.Sort = "descripcion"
                    lista.DataSource = dv3
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "nacionalidad"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 4
                    dv4.Table = ds.Tables(3)
                    dv4.Sort = "descripcion"
                    lista.DataSource = dv4
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "estadocivil"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 5
                    dv5.Table = ds.Tables(4)
                    dv5.Sort = "descripcion"
                    lista.DataSource = dv5
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "lugarnac"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 6
                    dv6.Table = ds.Tables(5)
                    dv6.Sort = "descripcion"
                    lista.DataSource = dv6
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "titulo"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 7
                    dv7.Table = ds.Tables(6)
                    dv7.Sort = "nombremateria"
                    lista.DataSource = dv7
                    lista.DisplayMember = "nombremateria"
                    lista.ValueMember = "codmateria"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 8
                    dv8.Table = ds.Tables(7)
                    dv8.Sort = "razonsocial"
                    lista.DataSource = dv8
                    lista.DisplayMember = "razonsocial"
                    lista.ValueMember = "codprofesor"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 9
                    dv9.Table = ds.Tables(8)
                    dv9.Sort = "nombremateria"
                    lista.DataSource = dv9
                    lista.DisplayMember = "nombremateria"
                    lista.ValueMember = "codmateria"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 10
                    dv10.Table = ds.Tables(9)
                    dv10.Sort = "descripcion"
                    lista.DataSource = dv10
                    lista.DisplayMember = "descripcion"
                    lista.ValueMember = "codcarrera"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 11
                    dv11.Table = ds.Tables(10)
                    dv11.Sort = "nombremateria"
                    lista.DataSource = dv11
                    lista.DisplayMember = "nombremateria"
                    lista.ValueMember = "codmateria"
                    lista.SelectedIndex = -1
                    Exit Sub
                Case 12
                    dv12.Table = ds.Tables(11)
                    dv12.Sort = "nombremateria"
                    lista.DataSource = dv12
                    lista.DisplayMember = "nombremateria"
                    lista.ValueMember = "codmateria"
                    lista.SelectedIndex = -1
                    Exit Sub
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function devolver_nombre_tabla(ByRef lv_nombre_columna As String) As String
        Try
            Select Case gv_catalogo
                Case 1
                    lv_nombre_columna = "codpos"
                    Return "localidades"
                Case 3
                    lv_nombre_columna = "nacionalidad"
                    Return "nacionalidades"
                Case 5
                    lv_nombre_columna = "lugarnac"
                    Return "lugaresnacimiento"
                Case 6
                    lv_nombre_columna = "titulo"
                    Return "titulos"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return ""
    End Function

    Public Function verificar_password(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim dr As SqlDataReader

        Try
            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT tipopermiso FROM usuarios WHERE usuario = '" & usuario & "' AND pass = '" & clave & "'"
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                If Not dr.IsDBNull(0) Then
                    gv_permiso = dr.GetString(0)
                    con.Close()
                    Return True
                Else
                    con.Close()
                    Return False
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_repetido(ByVal usuario As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(usuario) FROM usuarios WHERE usuario = '" & usuario & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_obsrepetida(ByVal nroinscripcion As String, ByVal Descripcion As String, ByVal firma As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(nroinscripcion) FROM alumnosobservaciones WHERE nroinscripcion = '" & nroinscripcion & "' and  Descripcion= '" & Descripcion & "' and  firma  = '" & firma & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function devolver_dia(ByVal dia As Byte) As String
        Try
            Select Case dia
                Case 0 : Return "DOMINGO"
                Case 1 : Return "LUNES"
                Case 2 : Return "MARTES"
                Case 3 : Return "MIÉRCOLES"
                Case 4 : Return "JUEVES"
                Case 5 : Return "VIERNES"
                Case 6 : Return "SÁBADO"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "DESCONOCIDO"
    End Function

    Public Function actualizar_cursada_por_alumno(ByVal codmateria As String, ByVal anio As String, ByVal cuatrimestre As Byte, ByVal estado As String) As Boolean
        Dim tran As SqlTransaction
        Dim con1 As New SqlConnection(ruta)
        Dim com1 As New SqlCommand

        Try
            com1.Connection = con1
            com1.CommandType = CommandType.StoredProcedure
            com1.CommandText = "actualizar_cursada_por_alumno"
            com1.Parameters.AddWithValue("@cod", codmateria)
            com1.Parameters.AddWithValue("@anio", anio)
            com1.Parameters.AddWithValue("@cuat", cuatrimestre)
            com1.Parameters.AddWithValue("@est", estado)
            con1.Open()
            tran = con1.BeginTransaction
            com1.Transaction = tran
            com1.ExecuteNonQuery()

            tran.Commit()
            con1.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            tran.Rollback()
            Return False
        Finally
            con1.Dispose()
            com1.Dispose()
        End Try
    End Function

    Public Sub cargar_anios(ByRef combo As ComboBox)
        Dim anio As Int16 = 2008
        Try
            combo.Items.Clear()
            While True
                combo.Items.Add(anio.ToString)
                If anio = Now.Year Then
                    Exit While
                End If
                anio = CShort(anio + 1)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function buscar_legajo(ByVal legajo As String) As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim cant As Byte
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "buscar_legajo"
            com.Parameters.AddWithValue("@leg", legajo)
            con.Open()
            cant = CByte(com.ExecuteScalar)
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_etapa_aprobada(ByVal nroinscripcion As String, ByVal anioingreso As String, ByVal carrera As Byte) As Boolean
        '   1 - INTRODUCTORIO
        '   2 - TSP
        '   3 - TSSI

        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim cant As Byte
        Try
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            Select Case carrera
                Case 1 : com.CommandText = "verificar_introductorio_aprobado"
                Case 2 : com.CommandText = "verificar_carrera_aprobada"
                Case 3 : com.CommandText = "verificar_carrera_aprobada"
            End Select
            com.Parameters.AddWithValue("@nro", nroinscripcion)
            com.Parameters.AddWithValue("@anio", anioingreso)
            Select Case carrera
                Case 2 : com.Parameters.AddWithValue("@car", 1)
                Case 3 : com.Parameters.AddWithValue("@car", 2)
            End Select
            con.Open()
            cant = CByte(com.ExecuteScalar)
            con.Close()
            Select Case carrera
                Case 1
                    If cant = gv_cant_materias_introductorio Then
                        Return True
                    Else
                        Return False
                    End If
                Case 2
                    If cant = gv_cant_materias_tsp Then
                        Return True
                    Else
                        Return False
                    End If
                Case 3
                    If cant = gv_cant_materias_tssi Then
                        Return True
                    Else
                        Return False
                    End If
            End Select
            If cant = gv_cant_materias_introductorio Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_existencia_planilla(ByVal codmateria As Byte, ByVal anio As Int16, ByVal cuatrimestre As Byte) As Boolean
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim cant As Byte
        Try

            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "verificar_existencia_planilla"
            com.Parameters.AddWithValue("@cod", codmateria)
            com.Parameters.AddWithValue("@anio", anio)
            com.Parameters.AddWithValue("@cuat", cuatrimestre)
            con.Open()
            cant = CByte(com.ExecuteScalar)
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try

    End Function

    Public Function verificar_obsrepetidap(ByVal codprofesor As String, ByVal Descripcion As String, ByVal firma As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(codprofesor) FROM profesoresobservaciones WHERE codprofesor = '" & codprofesor & "' and  Descripcion= '" & Descripcion & "' and  firma  = '" & firma & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_bibliografiatsprepetida(ByVal codmateria As String, ByVal descripcion As String, ByVal autor As String, ByVal temas As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(codmateria) FROM materiasbibliografia WHERE codmateria = '" & codmateria & "' and  Descripcion= '" & descripcion & "' and  autor  = '" & autor & "'and  temas= '" & temas & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_materiarepetida(ByVal codmateria As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(codmateria) FROM materias WHERE codmateria = '" & codmateria & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Function verificar_materiarepetidaxnombre(ByVal nombremateria As String) As Boolean
        Dim cant As Int16
        Try
            con = New SqlConnection(ruta)
            com = New SqlCommand

            com.Connection = con
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT COUNT(codmateria) FROM materias WHERE nombremateria = '" & nombremateria & "'"
            con.Open()
            cant = CShort(com.ExecuteScalar())
            con.Close()
            If cant <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Dispose()
            com.Dispose()
        End Try
    End Function

    Public Sub cargar_meses(ByRef combo As ComboBox)
        Dim i As Int16
        Try
            For i = 1 To 12
                Select Case i
                    Case 1
                        combo.Items.Add("ENERO")
                    Case 2
                        combo.Items.Add("FEBRERO")
                    Case 3
                        combo.Items.Add("MARZO")
                    Case 4
                        combo.Items.Add("ABRIL")
                    Case 5
                        combo.Items.Add("MAYO")
                    Case 6
                        combo.Items.Add("JUNIO")
                    Case 7
                        combo.Items.Add("JULIO")
                    Case 8
                        combo.Items.Add("AGOSTO")
                    Case 9
                        combo.Items.Add("SEPTIEMBRE")
                    Case 10
                        combo.Items.Add("OCTUBRE")
                    Case 11
                        combo.Items.Add("NOVIEMBRE")
                    Case 12
                        combo.Items.Add("DICIEMBRE")
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function devolver_mes(ByVal mes As Byte) As String
        Try
            Select Case mes
                Case 1
                    Return "ENERO"
                Case 2
                    Return "FEBRERO"
                Case 3
                    Return "MARZO"
                Case 4
                    Return "ABRIL"
                Case 5
                    Return "MAYO"
                Case 6
                    Return "JUNIO"
                Case 7
                    Return "JULIO"
                Case 8
                    Return "AGOSTO"
                Case 9
                    Return "SEPTIEMBRE"
                Case 10
                    Return "OCTUBRE"
                Case 11
                    Return "NOVIEMBRE"
                Case 12
                    Return "DICIEMBRE"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return "DESCONOCIDO"
    End Function

    Public Function devolver_numero_mes(ByVal cadena As String) As Byte
        Try
            Select Case cadena
                Case "ENERO"
                    Return 1
                Case "FEBRERO"
                    Return 2
                Case "MARZO"
                    Return 3
                Case "ABRIL"
                    Return 4
                Case "MAYO"
                    Return 5
                Case "JUNIO"
                    Return 6
                Case "JULIO"
                    Return 7
                Case "AGOSTO"
                    Return 8
                Case "SEPTIEMBRE"
                    Return 9
                Case "OCTUBRE"
                    Return 10
                Case "NOVIEMBRE"
                    Return 11
                Case "DICIEMBRE"
                    Return 12
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return 0
    End Function

    Public Sub traer_instancias_a_control(ByVal lista As ComboBox)
        Dim con As New SqlConnection(ruta)
        Dim com As New SqlCommand
        Dim dr As SqlDataReader
        Try
            lista.Items.Clear()
            com.Connection = con
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "traer_instancias_anio"
            com.Parameters.AddWithValue("@anio", Now.Year)
            con.Open()
            dr = com.ExecuteReader
            While dr.Read
                lista.Items.Add(devolver_mes(dr.GetByte(1)))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            com.Dispose()
            con.Dispose()
        End Try
    End Sub
End Module
