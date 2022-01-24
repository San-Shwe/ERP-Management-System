Public Class BL_Teacher
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return DataAccecss.DA_Teacher.CheckLoginData(username, email, password, position)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function TeacherInstruction(ByVal m_school As Modal.M_School, ByVal text As String, ByVal classText As String, ByVal typeText As String, ByVal allowMinutes As Integer, ByVal subject As String) As Boolean
        Try
            Return DataAccecss.DA_Teacher.TeacherInstruction(m_school, text, classText, typeText, allowMinutes, subject)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyRollCall(ByVal identifier As Integer, ByVal rollcall As Integer) As Boolean
        Try
            Return DataAccecss.DA_Teacher.ModifyRollCall(identifier, rollcall)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowInstruction(ByVal type As String, ByVal className As String, ByVal subject As String) As DataTable
        Try
            Return DataAccecss.DA_Teacher.ShowInstruction(type, className, subject)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowForMarkManage(ByVal className As String) As DataTable
        Try
            Return DataAccecss.DA_Teacher.ShowForMarkManage(className)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyMark(ByVal identifier As Integer, ByVal mark As Integer) As Boolean
        Try
            DataAccecss.DA_Teacher.ModifyMark(identifier, mark)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyAnswerMark(ByVal identifier As Integer, ByVal mark As Integer) As Boolean
        Try
            Return DataAccecss.DA_Teacher.ModifyAnswerMark(identifier, mark)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyStudentGrade(ByVal identifier As Integer, ByVal grade As Integer) As Boolean
        Try
            Return DataAccecss.DA_Teacher.ModifyStudentGrade(identifier, grade)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Shared Function ModifyStudentMarkText(ByVal identifier As Integer, ByVal marktext As String, ByVal subject As String) As Boolean
    '    Try
    '        Return DataAccecss.DA_Teacher.ModifyStudentMarkText(identifier, marktext, subject)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
End Class
