Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim persona As New Alumno
        persona.apellido = "Biancaniello"
        MessageBox.Show(persona.apellido)
    End Sub
End Class
