Public Class FrmCiudad

    Sub LlenarRegistros()
        Dim idCiudad As New DCiudades
        DgvRegistros.DataSource = idCiudad.MostrarRegistros.Tables(0)
        DgvRegistros.Refresh()
        GrbRegistros.Text = "Registros Guardados: " & DgvRegistros.Rows.Count - 1

    End Sub

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        TxtId.Clear()
        TxtNombre.Clear()
        TxtNombre.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim ciudad = New Ciudades() 'Entidad/Tabla de Cuidad
            Dim ciudadDao As New DCiudades() 'DAO de Ciudades
            ciudad.NombreCiudad = TxtNombre.Text.Trim()

            Dim resp = ciudadDao.GuardarRegistros(ciudad)
            If (resp) Then
                MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Ciudades")
            Else
                MsgBox("Error al guardar el registro.", MsgBoxStyle.Critical, "Ciudades")
            End If
            TxtId.Clear()
            TxtNombre.Clear()
            LlenarRegistros()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro..." & ex.Message, MsgBoxStyle.Critical, "Ciudades")
        End Try



    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim ciudad = New Ciudades(CInt(TxtId.Text), TxtNombre.Text, True)
            Dim ciudadDao As New DCiudades()

            Dim resp = ciudadDao.EditarRegistros(ciudad)
            If (resp) Then
                MsgBox("Registro editado exitosamente.", MsgBoxStyle.Information, "Ciudades")
            Else
                MsgBox("Error al editar el registro.", MsgBoxStyle.Critical, "Ciudades")
            End If
            TxtId.Clear()
            TxtNombre.Clear()
            LlenarRegistros()
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Ciudades")
        End Try
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As Integer = TxtId.Text
        Dim ciudadDao As New DCiudades()
        Dim ciudad As New Ciudades
        ciudad = ciudadDao.BuscarRegistros(codigo)
        If (ciudad.IdCiudad = 0) Then
            MsgBox("Registro no existente. ", MsgBoxStyle.Exclamation, "Ciudades")
            Exit Sub
        End If
        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro? " & ciudad.IdCiudad, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Ciudades"))
        If (resp = vbNo) Then
            MsgBox("Operación cancelada", MsgBoxStyle.Information, "Ciudades")
            Exit Sub
        End If

        Dim eliminado = ciudadDao.EliminarRegistros(ciudad.IdCiudad)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("Error al eliminar el registro", MsgBoxStyle.Critical, "Ciudades")
        End If
        TxtId.Clear()
        TxtNombre.Clear()
        LlenarRegistros()
    End Sub


    Private Sub DgvRegistros_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvRegistros.CellMouseDoubleClick
        Dim fila As Integer = DgvRegistros.CurrentRow.Index
        TxtId.Text = DgvRegistros.Rows(fila).Cells(0).Value
        TxtNombre.Text = DgvRegistros.Rows(fila).Cells(1).Value
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim ds As New DataSet
        Dim dao As New DCiudades
        ds = dao.BuscarXNombre(TxtValor.Text.Trim)
        DgvRegistros.DataSource = ds.Tables(0)
        DgvRegistros.Refresh()

    End Sub
End Class