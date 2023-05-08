Public Class FrmCiudad

    Sub LlenarRegistros()
        Dim idCiudad As New DCiudades
        DgvRegistros.DataSource = idCiudad.MostrarRegistros.Tables(0)
        DgvRegistros.Refresh()
        GrbRegistros.Text = "Registros almacenados: " & DgvRegistros.Rows.Count

    End Sub

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles Me.Load
        LlenarRegistros()
    End Sub

End Class