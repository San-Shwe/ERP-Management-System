Public Class BL_Manager
    Public Shared Function ShowRegisterData() As DataTable
        Try
            Return DataAccecss.DA_Manager.ShowRegisterData()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Insert(ByVal m_student As Modal.M_School) As Boolean
        Try
            Return DataAccecss.DA_Manager.Insert(m_student)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function deleteRegisterUser(ByVal email As String) As Boolean
        Try
            Return DataAccecss.DA_Manager.deleteRegisterUser(email)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
