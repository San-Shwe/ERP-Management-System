Public Class BL_Parents
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_Parents.CheckLoginData(username, email, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
