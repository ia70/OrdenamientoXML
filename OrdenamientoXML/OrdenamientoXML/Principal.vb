Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        InicializarVariables()
    End Sub

    Private Sub DlgFolder_HelpRequest(sender As Object, e As EventArgs) Handles dlgFolder.HelpRequest

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dlgFolder.ShowDialog() = DialogResult.OK Then
            txtCarpeta.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If txtCarpeta.TextLength > 0 Then
            Folder = txtCarpeta.Text
            btnIniciar.Enabled = False
            btnProgreso.Visible = True
            ProcesoActivo = True
            TimerActualizacion.Enabled = True

            Tipos.LimpiarTotales()

            InicializarVariables()
            IniciarBusqueda()

        Else
            Msg("Selecciona una carpeta!", 2)
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCarpeta.Text = ""
        txtTotalNuevos.Text = "0"
        txtTotalXML.Text = "0"
        dgvTabla.Rows.Clear()
    End Sub

    Public Sub ActualizarTabla()
        Dim i As Integer
        i = 0

        Try
            If dgvTabla.Rows.Count = 0 Then
                For Each linea As I_Tipo In Tipos.Tipos
                    dgvTabla.Rows.Add({i + 1, linea.Id, linea.Nombre, linea.Total})
                    i += 1
                Next
            ElseIf dgvTabla.Rows.Count <= Tipos.Tipos.Count Then
                For i = 0 To dgvTabla.Rows.Count - 1
                    dgvTabla.Rows(i).Cells(3).Value = Tipos.Tipos(i).Total
                Next
            End If

            If dgvTabla.Rows.Count < Tipos.Tipos.Count Then
                For i = dgvTabla.Rows.Count To Tipos.Tipos.Count - 1
                    dgvTabla.Rows.Add({i, Tipos.Tipos(i).Id, Tipos.Tipos(i).Nombre, Tipos.Tipos(i).Total})
                Next
            End If

        Catch ex As Exception
        End Try

    End Sub

    Public Sub ActualizarDatos()
        Try
            txtTotalXML.Text = N_TotalAnalizados
            txtTotalNuevos.Text = N_TotalNuevos
        Catch ex As Exception
        End Try

        ActualizarTabla()
    End Sub

    Private Sub TimerActualizacion_Tick(sender As Object, e As EventArgs) Handles TimerActualizacion.Tick

        If ProcesoActivo Then
            ActualizarDatos()
        Else
            ActualizarDatos()
            btnProgreso.Visible = False
            btnIniciar.Enabled = True

            TimerActualizacion.Enabled = False
        End If

    End Sub
End Class
