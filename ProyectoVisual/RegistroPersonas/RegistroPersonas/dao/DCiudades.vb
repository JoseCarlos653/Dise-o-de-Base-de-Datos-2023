Imports System.Data.SqlClient
Public Class DCiudades

    Dim StrConnection As String = My.Settings.StrConnection.ToString()

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(StrConnection)
            Dim tsql As String = "Select idCiudad as N'CÓDIGO', nombreCiudad as N'CIUDAD' from Ciudad"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function GuardarRegistros(ByVal ciudad As Ciudades) As Boolean
        Dim resultado As Boolean = False

        Try
            Dim tsql As String = "Insert into Ciudad(nombreCiudad) values(@nombreCiudad)"
            Dim conn As New SqlConnection(StrConnection)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreCiudad", ciudad.NombreCiudad)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            resultado = False
        End Try
        Return resultado
    End Function

    Public Function BuscarRegistros(ByVal id As Integer) As Ciudades
        Dim ciudad As New Ciudades
        Try
            Dim tsql As String = "Select * From Ciudad Where idCiudad = @idCiudad"
            Dim conn As New SqlConnection(StrConnection)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idCiudad", id)
            da.Fill(tbl)
            If (tbl.Rows.Count > 0) Then
                ciudad.idCiudad = tbl.Rows(0).Item("idCiudad")
                ciudad.nombreCiudad = tbl.Rows(0).Item("nombreCiudad")
                ciudad.estado = tbl.Rows(0).Item("estado")
            End If

        Catch ex As Exception

        End Try
        Return ciudad
    End Function

    Public Function EditarRegistros(ByVal ciudad As Ciudades) As Boolean
        Dim resultado As Boolean = False

        Try
            Dim tsql As String = "Update Ciudad Set nombreCiudad = @nombreCiudad, estado = @estado Where idCiudad = @idCiudad"
            Dim conn As New SqlConnection(StrConnection)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreCiudad", ciudad.NombreCiudad)
            cmd.Parameters.AddWithValue("@estado", ciudad.Estado)
            cmd.Parameters.AddWithValue("@idCiudad", ciudad.IdCiudad)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resultado = False
        End Try

        Return resultado
    End Function

    Public Function EliminarRegistros(ByVal id As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim tsql As String = "Delete From Ciudad Where idCiudad = @idCiudad"
            Dim conn As New SqlConnection(StrConnection)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idCiudad", id)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            resultado = False
        End Try
        Return resultado
    End Function

    Public Function BuscarXNombre(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "Select * From Ciudad Where nombreCiudad like @nombreCiudad"
            Dim conn As New SqlConnection(StrConnection)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreCiudad", nombre)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

End Class
