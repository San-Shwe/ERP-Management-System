Public Class DA_Teacher
    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblTeacher where (username = '" & username & "' or email='" & email & "')  and password = '" & password & "' and position = '" & position & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function TeacherInstruction(ByVal m_school As Modal.M_School, ByVal text As String, ByVal classText As String, ByVal typeText As String, ByVal allowMinutes As Integer, ByVal subject As String) As Boolean
        Try
            Dim arr(7) As Object
            arr(0) = m_school.Username
            arr(1) = text.Trim
            arr(2) = m_school.Position
            arr(3) = classText
            arr(4) = typeText
            arr(5) = allowMinutes
            arr(6) = subject
            Dim id As Integer = SqlHelper.Insert(arr, "username,text,position,class,type,minutes,subject", "tblTeacherInstruction")
            If id <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyRollCall(ByVal identifier As Integer, ByVal rollcall As Integer) As Boolean
        Try
            Dim arr(2) As Object
            arr(0) = identifier
            arr(1) = rollcall
            Dim iD As Integer
            iD = SqlHelper.Updating("tblStudent", arr, "modifyRollCall")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyMark(ByVal identifier As Integer, ByVal mark As Integer) As Boolean
        Try
            Dim arr(2) As Object
            arr(0) = identifier
            arr(1) = mark
            Dim iD As Integer
            iD = SqlHelper.Updating("tblStudent", arr, "modifyMark")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyAnswerMark(ByVal identifier As Integer, ByVal mark As Integer) As Boolean
        Try
            Dim arr(2) As Object
            arr(0) = identifier
            arr(1) = mark
            Dim iD As Integer
            iD = SqlHelper.Updating("tblStudentAnswers", arr, "modifyMark")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyStudentGrade(ByVal identifier As Integer, ByVal grade As Integer) As Boolean
        Try
            Dim arr(2) As Object
            arr(0) = identifier
            arr(1) = grade
            Dim iD As Integer
            iD = SqlHelper.Updating("tblStudent", arr, "modifyGrade")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowInstruction(ByVal type As String, ByVal className As String, ByVal subject As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblTeacherInstruction where type = '" & type & "' and class = '" & className & "' and subject='" & subject & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowForMarkManage(ByVal className As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblStudentAnswers where class = '" & className & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Shared Function ModifyStudentMarkText(ByVal identifier As Integer, ByVal marktext As String, ByVal subject As String) As Boolean
    '    Try
    '        Dim arr(2) As Object
    '        arr(0) = identifier
    '        arr(1) = marktext
    '        Dim iD As Integer
    '        Select Case subject
    '            Case "php"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifyphpMarkText")
    '            Case "java"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifyjavaMarkText")
    '            Case "network"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifynetworkMarkText")
    '            Case "data structure"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifydatastructureMarkText")
    '            Case "dbms"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifydbmsMarkText")
    '            Case "math"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifymathMarkText")
    '            Case "english"
    '                iD = SqlHelper.Updating("tblStudent", arr, "modifyenglishMarkText")
    '        End Select

    '        If iD <> 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
End Class
