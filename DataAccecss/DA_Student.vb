Public Class DA_Student
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblStudent where (username = '" & username & "' or email='" & email & "')  and password = '" & password & "' and position = '" & position & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowRollcall(ByVal className As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblStudent where class = '" & className & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function SendAnswer(ByVal m_student As Modal.M_School, ByVal answerText As String, ByVal className As String, ByVal grade As Integer, ByVal datetime As String, ByVal type As String, ByVal timetaken As String, ByVal question As String, ByVal subject As String) As Boolean
        Try
            Dim arr(10) As Object
            arr(0) = m_student.Username
            arr(1) = m_student.Position
            arr(2) = answerText.Trim
            arr(3) = className.Trim
            arr(4) = grade
            arr(5) = datetime.Trim
            arr(6) = type.Trim
            arr(7) = timetaken.Trim
            arr(8) = question.Trim
            arr(9) = subject.trim
            Dim iD As Integer
            iD = SqlHelper.Insert(arr, "username,position,text,class,grade,datetime,type,timetaken,question,subject", "tblStudentAnswers")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
