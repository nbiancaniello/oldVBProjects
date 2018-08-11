Public Class Form1
    Dim emp As Empleado
    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        Try
            If txt_sueldo.Text = "" Then
                MessageBox.Show("El sueldo no puede estar vacío")
                Exit Sub
            End If
            If txt_comision.Text = "" Then
                MessageBox.Show("La comisión no puede estar vacía")
                Exit Sub
            End If
            emp = New Empleado
            emp.sueldo = CDbl(txt_sueldo.Text)
            emp.comision = CShort(txt_comision.Text)
            MessageBox.Show("Sueldo del empleado: " & emp.calcularsueldo().ToString, "Sueldo Neto")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fecha_nac.MaxDate = Now.Date
    End Sub

    Private Sub txt_legajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_legajo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_sueldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sueldo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_comision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_comision.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asignar.Click
        Try
            If txt_legajo.Text.Trim = "" Then
                MessageBox.Show("El legajo no puede estar vacío")
                Exit Sub
            End If
            If txt_nombre.Text.Trim = "" Then
                MessageBox.Show("El nombre no puede estar vacío")
                Exit Sub
            End If
            If txt_sueldo.Text.Trim = "" Then
                MessageBox.Show("El sueldo no puede estar vacío")
                Exit Sub
            End If
            If txt_comision.Text.Trim = "" Then
                MessageBox.Show("La comisión no puede estar vacía")
                Exit Sub
            End If
            emp = New Empleado
            emp.asignardatos(Convert.ToInt16(txt_legajo.Text), txt_nombre.Text.Trim, dtp_fecha_nac.Value, Convert.ToDouble(txt_sueldo.Text), Convert.ToInt16(txt_comision.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_obtener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_obtener.Click

        Try
            MessageBox.Show(emp.legajo.ToString & " - " & emp.nombre.ToString & " - " & emp.fechanac.ToString & " - " & emp.sueldo.ToString & " - " & emp.comision, "Datos obtenidos")
        Catch ex As Exception
            MessageBox.Show("Problema con los datos")
        End Try

    End Sub

    Private Sub btn_edad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edad.Click
        Try
            emp = New Empleado
            emp.fechanac = dtp_fecha_nac.Value
            MessageBox.Show("Edad del empleado: " & emp.edad.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
