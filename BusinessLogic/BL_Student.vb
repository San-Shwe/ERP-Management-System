Public Class BL_Student
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_Student.CheckLoginData(username, email, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowRollcall(ByVal className As String) As DataTable
        Try
            Return DataAccecss.DA_Student.ShowRollcall(className)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function SendAnswer(ByVal m_student As Modal.M_School, ByVal answerText As String, ByVal className As String, ByVal grade As Integer, ByVal datetime As String, ByVal type As String, ByVal timetaken As String, ByVal question As String, ByVal subject As String) As Boolean
        Try
            Return DataAccecss.DA_Student.SendAnswer(m_student, answerText, className, grade, datetime, type, timetaken, question, subject)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
