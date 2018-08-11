Imports System.Data.SqlClient
Public Class Form2
    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand

        If verificar_nombre(txt_nombre) = False Then
            MessageBox.Show("Nombre ingresado incorrectamente")
            txt_nombre.Focus()
            Exit Sub
        End If
        CN.ConnectionString = Ruta
        CM.CommandType = CommandType.StoredProcedure
        CM.Connection = CN
        If AccionForm = eAccion.AGREGAR Then
            If verificar_existencia(CShort(txt_codigo.Text)) = True Then
                Try
                    CM.CommandText = "AgregarPersona"
                    CM.Parameters.AddWithValue("@cod", Convert.ToInt16(txt_codigo.Text))
                    CM.Parameters.AddWithValue("@nombre", txt_nombre)
                    CM.Parameters.AddWithValue("@fecha_nac", dtp_fecha_nac.Value)
                    CN.Open()
                    CM.ExecuteNonQuery()
                    MessageBox.Show("Registro Agregado")
                    With Form1.lv_datos
                        .Items.Add(txt_codigo.Text)
                        .Items(Form1.lv_datos.Items.Count - 1).SubItems.Add(txt_nombre.Text)
                        .Items(Form1.lv_datos.Items.Count - 1).SubItems.Add(dtp_fecha_nac.Value.ToShortDateString)
                        .Items(Form1.lv_datos.Items.Count - 1).SubItems.Add(cbo_estado.SelectedIndex.ToString)
                    End With
                Catch ex As Exception
                    MessageBox.Show("Problemas con la conexion a la base de datos")
                End Try
            Else
                MessageBox.Show("Ya existe este codigo de usuario")
            End If
        Else
            Try
                CM.CommandText = "ActualizarPersona"
                CM.Parameters.AddWithValue("@cod", Convert.ToInt16(txt_codigo.Text))
                CM.Parameters.AddWithValue("@nombre", txt_nombre)
                CM.Parameters.AddWithValue("@fecha_nac", dtp_fecha_nac.Value)
                CM.Parameters.AddWithValue("@estado", Convert.ToByte(cbo_estado.SelectedIndex.ToString))
                CN.Open()
                CM.ExecuteNonQuery()
                MessageBox.Show("Registro Modificado")
                With Form1.lv_datos
                    .SelectedItems(0).SubItems(1).Text = txt_nombre.Text.Trim
                    .SelectedItems(0).SubItems(2).Text = dtp_fecha_nac.Value.ToString
                    .SelectedItems(0).SubItems(3).Text = cbo_estado.SelectedIndex.ToString
                End With
            Catch ex As Exception
                MessageBox.Show("Problemas con la conexion a la base de datos")
            End Try
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fecha_nac.MaxDate = Now.Date
        If AccionForm = eAccion.AGREGAR Then
            Me.Text = "Agregar Persona"
            cbo_estado.Enabled = False
        Else
            Me.Text = "Modificar Persona"
            txt_codigo.Text = Form1.lv_datos.SelectedItems(0).Text
            txt_nombre.Text = Form1.lv_datos.SelectedItems(0).SubItems(1).Text
            dtp_fecha_nac.Value = Convert.ToDateTime(Form1.lv_datos.SelectedItems(0).SubItems(2).Text)
            If Form1.lv_datos.SelectedItems(0).SubItems(3).Text = "ACTIVO" Then
                cbo_estado.SelectedIndex = 0
            Else
                cbo_estado.SelectedIndex = 1
            End If
            cbo_estado.Enabled = True
            txt_codigo.Enabled = False
        End If
    End Sub

    Private Sub txt_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class