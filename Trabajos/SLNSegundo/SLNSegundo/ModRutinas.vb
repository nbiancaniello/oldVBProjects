Module ModRutinas

    '************************************************************************
    ' Aquí se detallan los procedimientos y funciones del proyecto SLNSegundo
    '************************************************************************

    '-----------------------------------------
    ' LISTAS.VB
    '-----------------------------------------
    Public Function contarcaracteres(ByVal texto As String) As Byte
        ' La funcion devuelve el largo de la cadena
        Return CByte(texto.Length)
    End Function

    Public Function contarletras(ByVal letra As Char, ByVal texto As String) As Byte
        ' La funcion busca la igualdad entre el caracter deseado y el de la subcadena (de 1 caracter)
        Dim cant, i As Byte
        cant = 0
        For i = 0 To CByte(texto.Length - 1)
            If texto.Substring(i, 1) = letra.ToString Or texto.Substring(i, 1).ToLower = letra.ToString Or texto.Substring(i, 1).ToUpper = letra.ToString Then
                cant = CByte(cant + 1)
            End If
        Next
        Return cant
    End Function

    Public Function mayorlongitud(ByRef lista As ListBox) As Byte
        ' La funcion devuelve el índice del elemento más largo en la lista
        Dim i, pos As Byte
        Dim cadena1, cadena2 As String
        pos = 0
        cadena1 = CStr(lista.Items.Item(0))
        For i = 1 To CByte(lista.Items.Count - 1)
            cadena2 = CStr(lista.Items.Item(i))
            If cadena1.Length < cadena2.Length Then
                pos = i
                cadena1 = CStr(lista.Items.Item(i))
            End If
        Next
        Return pos
    End Function

    Public Function menorlongitud(ByRef lista As ListBox) As Byte
        ' La funcion devuelve el índice del elemento más corto en la lista
        Dim i, pos As Byte
        Dim cadena1, cadena2 As String
        pos = 0
        cadena1 = CStr(lista.Items.Item(0))
        For i = 1 To CByte(lista.Items.Count - 1)
            cadena2 = CStr(lista.Items.Item(i))
            If cadena2.Length < cadena1.Length Then
                pos = i
                cadena1 = CStr(lista.Items.Item(i))
            End If
        Next
        Return pos
    End Function

    Public Sub eliminarlista(ByRef lista As ListBox)
        ' Borra la lista entera
        lista.Items.Clear()
    End Sub

    Public Sub eliminaritem(ByRef lista As ListBox)
        ' Borra el ítem seleccionado
        lista.Items.RemoveAt(lista.SelectedIndex)
    End Sub

    Public Function cantidad(ByRef lista As ListBox) As Int16
        Return CShort(lista.Items.Count)
    End Function

    Public Sub agregaritem(ByRef lista As ListBox, ByVal nombre As TextBox)
        ' Agrega un item a la lista
        lista.Items.Add(nombre.Text)
        nombre.Text = ""
        nombre.Focus()
    End Sub

    '-----------------------------------------
    ' LISTA_CRUCE.VB
    '-----------------------------------------
    Public Sub pasaritem(ByRef lista1 As ListBox, ByRef lista2 As ListBox)
        lista2.Items.Add(lista1.SelectedItem)
    End Sub
End Module
