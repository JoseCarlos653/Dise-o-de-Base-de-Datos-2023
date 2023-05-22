Public Class FrmPersonas

    Dim ciudad As New DCiudades

    Sub LlenarCiudades()
        Dim ds As New DataSet
        ds = ciudad.MostrarRegistros()
        CmbIdCiudad.DataSource = ds.Tables(0)
        CmbIdCiudad.Refresh()
        CmbIdCiudad.DisplayMember = "CIUDAD" 'Nombre del alias
        CmbIdCiudad.ValueMember = "CÓDIGO" 'Nombre del alias
    End Sub

    Private Sub FrmPersonas_Load(sender As Object, e As EventArgs) Handles Me.Load
        LlenarCiudades()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        DireccionTextBox.Text = CmbIdCiudad.SelectedValue
    End Sub
End Class