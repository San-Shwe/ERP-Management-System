Public Class DA_Staff
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblStaff where (username = '" & username & "' or email='" & email & "')  and password = '" & password & "' and position = '" & position & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
