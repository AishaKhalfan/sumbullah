Imports System.Data
Imports System.Data.SqlClient
Public Class dbase

    Private pay As String
    Friend dt As Object
    Private _p1 As String

    Sub New(p1 As String)
        ' TODO: Complete member initialization 
        _p1 = p1
    End Sub

    Sub save()
        Throw New NotImplementedException
    End Sub

    Function con() As Object
        Throw New NotImplementedException
    End Function

    


End Class
