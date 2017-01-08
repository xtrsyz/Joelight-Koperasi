Module koneksi


    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public NIKUSER As String
    Public loginadmin As Boolean

    Public Sub koneksimysql()
        If conn.State = ConnectionState.Closed Then
            Dim myString As String = "server=localhost" _
            & ";user=root" _
            & ";password=" _
            & ";database=koperasi"
            Try
                conn.ConnectionString = myString
                conn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message)
                End
            End Try
        End If
    End Sub


End Module
