Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
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

            InicializarVariables()
            IniciarBusqueda()
            btnProgreso.Visible = True
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
End Class
