Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Class DataAccessLayer

    Dim con As SqlConnection = New SqlConnection("server=.;
                    database=PMSoftware;integrated security=true")

    'create connection
    Shared Sub New()
        Dim con As SqlConnection
        '        Dim mode As String = Properties.Settings.Default.Mode
        '        If mode = "SQL" Then
        '            sqlconnection = New SqlConnection("server=" + Properties.Settings.Default.Server + ";
        'database=" + Properties.Settings.Default.DataBase + ";
        'integrated security=False;User ID=" + Properties.Settings.Default.ID + ";
        '           Password=" + Properties.Settings.Default.Password + "")
        '        Else
        '            sqlconnection = New SqlConnection("server=" + Properties.Settings.Default.Server + ";
        'database=" + Properties.Settings.Default.DataBase + ";integrated security=true")

        '        End If
        con = New SqlConnection("server=.;
                    database=PMSoftware;integrated security=true")
    End Sub


    'open connection

    Public Sub Open()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
    End Sub

    'close connection
    Public Sub Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    'read data from database
    Public Function selectdata(ByVal stored_procedure As String, ByVal param() As SqlParameter) As DataTable
        Dim sqlcmd As New SqlCommand()
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = stored_procedure
        sqlcmd.Connection = con
        If (param IsNot Nothing) Then
            For i As Integer = 0 To param.Length - 1 Step 1
                sqlcmd.Parameters.Add(param(i))
            Next
        End If

        Dim da As New SqlDataAdapter(sqlcmd)
        Dim dtdal As New DataTable()
        da.Fill(dtdal)
        Return dtdal
    End Function

    'to insert ,update And delete data from database
    Public Sub executedata(ByVal stored_procedure As String, ByVal param() As SqlParameter)
        Dim sqlcmd As New SqlCommand()
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = stored_procedure
        sqlcmd.Connection = con

        If param IsNot Nothing Then
            sqlcmd.Parameters.AddRange(param)
        End If
        sqlcmd.ExecuteNonQuery()
    End Sub


End Class


