Public Class Tbl_Persona
    Dim _idPersona As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _fechaNac As DateTime
    Dim _sexo As Boolean
    Dim _telefono As String
    Dim _correo As String
    Dim _idCiudad As Integer
    Dim _direccion As String
    Dim _activo As Boolean

    Public Sub New(idPersona As Integer, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, fechaNac As Date, sexo As Boolean, telefono As String, correo As String, idCiudad As Integer, direccion As String, activo As Boolean)
        Me._idPersona = idPersona
        Me._primerNombre = primerNombre
        Me._segundoNombre = segundoNombre
        Me._primerApellido = primerApellido
        Me._segundoApellido = segundoApellido
        Me._fechaNac = fechaNac
        Me._sexo = sexo
        Me._telefono = telefono
        Me._correo = correo
        Me._idCiudad = idCiudad
        Me._direccion = direccion
        Me._activo = activo
    End Sub
End Class
