Public Class BL_School

    Public Shared Function ShowPositionData() As DataTable
        Try
            Return DataAccecss.DA_School.ShowPositionData()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowUserData() As DataTable
        Try
            Return DataAccecss.DA_School.ShowUserData()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_School.CheckLoginData(username, email, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function keepMeLogin_UpdateData(ByVal m_school As Modal.M_School) As Boolean
        Try
            Return DataAccecss.DA_School.keepMeLogin_UpdateData(m_school)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Insert(ByVal position As String) As Boolean
        Try
            Return DataAccecss.DA_School.Insert(position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function deletePosition(ByVal position As String) As Boolean
        Try
            Return DataAccecss.DA_School.deletePosition(position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyPosition(ByVal value As Integer, ByVal position As String) As Boolean
        Try
            Return DataAccecss.DA_School.ModifyPosition(value, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowPositionsNumber(ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_School.ShowPositionsNumber(position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function InsertUsers(ByVal m_student As Modal.M_School) As Boolean
        Try
            Return DataAccecss.DA_School.InsertUsers(m_student)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowCurrentUserDetails(ByVal username As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_School.ShowCurrentUserDetails(username, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ChangeUserDetails(ByVal m_student As Modal.M_School) As Boolean
        Try
            Return DataAccecss.DA_School.ChangeUserDetails(m_student)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowNoticeBoard() As DataTable
        Try
            Return DataAccecss.DA_School.ShowNoticeBoard()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function DeleteNoteiceBoardRecord(ByVal id As Integer)
        Try
            Return DataAccecss.DA_School.DeleteNoteiceBoardRecord(id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function InsertNote(ByVal m_student As Modal.M_School, ByVal text As String, ByVal datetime As String) As Boolean
        Try
            Return DataAccecss.DA_School.InsertNote(m_student, text, datetime)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyNote(ByVal m_user As Modal.M_School, ByVal text As String) As Boolean
        Try
            Return DataAccecss.DA_School.ModifyNote(m_user, text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowCurrentUserNote(ByVal username As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_School.ShowCurrentUserNote(username, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
