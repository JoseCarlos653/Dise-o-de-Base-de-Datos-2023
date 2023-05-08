Imports System.Data.SqlClient
Public Class DCiudades

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "Select id as N'CODIGO', nombre as N'CIUDAD' from Ciudad"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function

End Class
