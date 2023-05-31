Imports System.Data.SqlClient

Module connection

    Dim con As SqlConnection

    Public Sub createConnection()

        con = New SqlConnection
        con.ConnectionString = "Data Source=ALMAGHANDY-PC;Initial Catalog=SUMBULLAH;Integrated Security=true;"
        con.Open()

    End Sub

    Private Sub checkConnection()

        If con Is Nothing OrElse con.State = ConnectionState.Closed Then
            createConnection()
        End If

    End Sub

    Public Function getDataReader(ByVal SQL As String) As SqlDataReader

        checkConnection()
        Dim cmd As New SqlCommand(SQL, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Return dr

    End Function

    Public Function getDataTable(ByVal SQL As String) As DataTable

        checkConnection()
        Dim cmd As New SqlCommand(SQL, con)
        Dim table As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(table)
        Return table

    End Function

    Public Sub executeQuery(ByVal SQL As String)

        checkConnection()
        Dim cmd As New SqlCommand(SQL, con)
        cmd.ExecuteNonQuery()

    End Sub

    Public Sub disableRights(ByRef btn1 As CloudToolkitN6.CloudButton, ByRef btn2 As CloudToolkitN6.CloudButton, ByRef btn3 As CloudToolkitN6.CloudButton, ByRef btn4 As CloudToolkitN6.CloudButton, ByRef menu As MenuStrip)

        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        menu.Enabled = False

    End Sub


    Public Sub enableRights(ByRef btn1 As CloudToolkitN6.CloudButton, ByRef btn2 As CloudToolkitN6.CloudButton, ByRef btn3 As CloudToolkitN6.CloudButton, ByRef btn4 As CloudToolkitN6.CloudButton, ByRef menu As MenuStrip)

        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        menu.Enabled = True

    End Sub

End Module


