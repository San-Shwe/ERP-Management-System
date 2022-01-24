Public Class DA_Manager
    Public Shared Function ShowRegisterData() As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblRegisterNewUser", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Insert(ByVal m_student As Modal.M_School) As Boolean
        Try
            Dim arr(9) As Object
            arr(0) = m_student.Username
            arr(1) = m_student.Password
            arr(2) = m_student.phoneNumber
            arr(3) = m_student.email
            arr(4) = m_student.father
            arr(5) = m_student.mother
            arr(6) = m_student.nrc
            arr(7) = Now.ToString
            arr(8) = m_student.Position
            Dim id As Integer = SqlHelper.Insert(arr, "username,password,phone,email,father,mother,nrc,date,position", "tblRegisterNewUser")
            If id <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function deleteRegisterUser(ByVal email As String) As Boolean
        Try
            Return SqlHelper.Update("delete from tblRegisterNewUser where email ='" & email & "'")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
