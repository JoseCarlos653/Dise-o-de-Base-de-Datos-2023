'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Ciudad
    Public Property idCiudad As Integer
    Public Property nombreCiudad As String
    Public Property estado As Nullable(Of Boolean)

    Public Overridable Property Persona As ICollection(Of Tbl_Persona) = New HashSet(Of Tbl_Persona)

End Class
