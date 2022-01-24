Public Class BL_Staff
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_Staff.CheckLoginData(username, email, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
