Public Class DA_School


    Public Shared Function ShowPositionData() As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblPosition", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowUserData() As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblLogin", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Insert(ByVal position As String) As Boolean
        Try
            Dim arr(1) As Object
            arr(0) = position.Trim
            Dim id As Integer = SqlHelper.Insert(arr, "position", "tblPosition")
            If id <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function deletePosition(ByVal position As String) As Boolean
        Try
            Return SqlHelper.Update("delete from tblPosition where position ='" & position & "'")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function CheckLoginData(ByVal username As String, ByVal email As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblLogin where (username = '" & username & "' or email='" & email & "')  and password = '" & password & "' and position = '" & position & "'", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function keepMeLogin_UpdateData(ByVal m_school As Modal.M_School) As Boolean
        Try
            Dim arr(4) As Object
            arr(0) = m_school.Username
            arr(1) = m_school.Password
            arr(2) = m_school.Position
            arr(3) = m_school.keepMeLogin
            Dim iD As Integer = SqlHelper.Updating("tblLogin", arr, "keepMeLoginUpdate")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyPosition(ByVal value As Integer, ByVal position As String) As Boolean
        Try
            Dim arr(2) As Object
            arr(0) = value
            arr(1) = position.Trim
            Dim iD As Integer = SqlHelper.Updating("tblPosition", arr, "modifyPosition")
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowPositionsNumber(ByVal position As String) As DataTable
        Try
            Select Case position
                Case "student"
                    Return SqlHelper.getDataTable("select * from tblStudent where position='" & position & "'", CommandType.Text)
                Case "teacher"
                    Return SqlHelper.getDataTable("select * from tblTeacher where position='" & position & "'", CommandType.Text)
                Case "parents"
                    Return SqlHelper.getDataTable("select * from tblParents where position='" & position & "'", CommandType.Text)
                Case "staff"
                    Return SqlHelper.getDataTable("select * from tblStaff where position='" & position & "'", CommandType.Text)
                Case "manager"
                    Return SqlHelper.getDataTable("select * from tblLogin where position='" & position & "'", CommandType.Text)
                Case "admin"
                    Return SqlHelper.getDataTable("select * from tblLogin where position='" & position & "'", CommandType.Text)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function InsertUsers(ByVal m_student As Modal.M_School) As Boolean
        Try
            Dim arr(8) As Object
            arr(0) = m_student.Username
            arr(1) = m_student.Password
            arr(2) = m_student.Position
            arr(3) = m_student.phoneNumber
            arr(4) = m_student.email
            arr(5) = m_student.nrc
            arr(6) = m_student.father
            arr(7) = m_student.mother
            Dim id As Integer
            Select Case m_student.Position
                Case "student"
                    id = SqlHelper.Insert(arr, "username,password,position,phone,email,NRC,father,mother", "tblStudent")
                Case "teacher"
                    id = SqlHelper.Insert(arr, "username,password,position,phone,email,NRC,father,mother", "tblTeacher")
                Case "parents"
                    id = SqlHelper.Insert(arr, "username,password,position,phone,email,NRC,father,mother", "tblParents")
                Case "staff"
                    id = SqlHelper.Insert(arr, "username,password,position,phone,email,NRC,father,mother", "tblStaff")
            End Select

            If id <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowCurrentUserDetails(ByVal username As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Select Case position
                Case "student"
                    Return SqlHelper.getDataTable("select * from tblStudent where username='" & username & "' and password='" & password & "'", CommandType.Text)
                Case "teacher"
                    Return SqlHelper.getDataTable("select * from tblTeacher where username='" & username & "' and password='" & password & "'", CommandType.Text)
                Case "parents"
                    Return SqlHelper.getDataTable("select * from tblParents where username='" & username & "' and password='" & password & "'", CommandType.Text)
                Case "staff"
                    Return SqlHelper.getDataTable("select * from tblStaff where username='" & username & "' and password='" & password & "'", CommandType.Text)
                Case Else
                    Return SqlHelper.getDataTable("select * from tblLogin where username='" & username & "' and password='" & password & "'", CommandType.Text)
            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ChangeUserDetails(ByVal m_student As Modal.M_School) As Boolean
        Try
            Dim arr(8) As Object
            arr(0) = m_student.Username
            arr(1) = m_student.Password
            arr(2) = m_student.Position
            arr(3) = m_student.phoneNumber
            arr(4) = m_student.email
            arr(5) = m_student.nrc
            arr(6) = m_student.father
            arr(7) = m_student.mother
            Dim iD As Integer
            Select Case m_student.Position
                Case "student"
                    iD = SqlHelper.Updating("tblStudent", arr, "modifyUser")
                Case "teacher"
                    iD = SqlHelper.Updating("tblTeacher", arr, "modifyUser")
                Case "parents"
                    iD = SqlHelper.Updating("tblParents", arr, "modifyUser")
                Case "staff"
                    iD = SqlHelper.Updating("tblStaff", arr, "modifyUser")
                Case Else
                    iD = SqlHelper.Updating("tblLogin", arr, "modifyUser")
            End Select

            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowNoticeBoard() As DataTable
        Try
            Return SqlHelper.getDataTable("select * from tblNoticeBoard", CommandType.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function DeleteNoteiceBoardRecord(ByVal id As Integer)
        Try
            Return SqlHelper.Update("Delete from tblNoticeBoard where id=" & id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function InsertNote(ByVal m_student As Modal.M_School, ByVal text As String, ByVal datetime As String) As Boolean
        Try
            Dim arr(4) As Object
            arr(0) = m_student.Username
            arr(1) = m_student.Position
            arr(2) = text
            arr(3) = datetime
            Dim id As Integer = SqlHelper.Insert(arr, "username,position,message,date", "tblNoticeBoard")
            If id <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ModifyNote(ByVal m_user As Modal.M_School, ByVal text As String) As Boolean
        Try
            Dim arr(4) As Object
            arr(0) = m_user.Username
            arr(1) = m_user.Position
            arr(2) = m_user.Password
            arr(3) = text
            Dim iD As Integer
            Select Case m_user.Position.Trim
                Case "student"
                    iD = SqlHelper.Updating("tblStudent", arr, "modifyNote")
                Case "teacher"
                    iD = SqlHelper.Updating("tblTeacher", arr, "modifyNote")
                Case "parents"
                    iD = SqlHelper.Updating("tblParents", arr, "modifyNote")
                Case "staff"
                    iD = SqlHelper.Updating("tblStaff", arr, "modifyNote")
                Case "manager"
                    iD = SqlHelper.Updating("tblLogin", arr, "modifyNote")
                Case "admin"
                    iD = SqlHelper.Updating("tblLogin", arr, "modifyNote")
            End Select
            If iD <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ShowCurrentUserNote(ByVal username As String, ByVal password As String, ByVal position As String) As DataTable
        Try
            Select Case position
                Case "student"
                    Return SqlHelper.getDataTable("select * from tblStudent where username='" & username & "' and password='" & password & "' and position='" & position & "'", CommandType.Text)
                Case "teacher"
                    Return SqlHelper.getDataTable("select * from tblTeacher where username='" & username & "' and password='" & password & "' and position='" & position & "'", CommandType.Text)
                Case "parents"
                    Return SqlHelper.getDataTable("select * from tblParents where username='" & username & "' and password='" & password & "' and position='" & position & "'", CommandType.Text)
                Case "staff"
                    Return SqlHelper.getDataTable("select * from tblStaff where username='" & username & "' and password='" & password & "' and position='" & position & "'", CommandType.Text)
                Case "manager"
                    Return SqlHelper.getDataTable("select * from tblLogin where username='" & username & "' and password='" & password & "' and position='" & position & "'", CommandType.Text)
                Case "admin"
                    Return SqlHelper.getDataTable("select * from tblLogin  where username='" & username & "' and password='" & password & "' and position='" & position & "'", CommandType.Text)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
