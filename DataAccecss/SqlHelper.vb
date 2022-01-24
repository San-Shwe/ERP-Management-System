Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Configuration.ConfigurationSettings

Public Class SqlHelper

    Public Shared dbconnectionstring As String = "server=" + AppSettings("sqlservername") + ";Database=" + AppSettings("dbname") + ";User Id=sa;Password=successful;Trusted_Connection=false;Pooling=false;"
    Public Shared insert_fieldname As String = ""
    Public Shared sFieldName(0) As String
    Public Shared sqlstr As String = ""

    Public Shared Function Insert(ByVal arr() As Object, ByVal sFieldName As String, ByVal sTableName As String) As Int64

        Dim tblresult As DataTable
        Dim sInsertItem As String = ""
        Dim iID As Integer = 0

        Dim tran As SqlTransaction

        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionString
        cn.Open()

        tran = cn.BeginTransaction(IsolationLevel.ReadCommitted)

        Dim cmd As New SqlCommand '(commandText, cn)
        cmd.Connection = cn
        cmd.CommandTimeout = 300
        If (Not arr Is Nothing) Then

            For p As Integer = 1 To arr.Length - 1

                cmd.Parameters.AddWithValue("@" & p, arr(p - 1))

                If p <> arr.Length - 1 Then
                    sInsertItem += "@" & p & ","
                Else
                    sInsertItem += "@" & p
                End If
            Next
        End If
        Try
            cmd.CommandText = "INSERT INTO " & sTableName & "(" & sFieldName & ")" _
                              & " VALUES(" & sInsertItem & ")"
            cmd.Transaction = tran
            cmd.ExecuteNonQuery()
            cmd.CommandText = ""

            cmd.CommandText = "SELECT @@IDENTITY"
            iID = cmd.ExecuteScalar()

            tran.Commit()
            cn.Close()

        Catch ex As Exception
            tran.Commit()
            cn.Close()
            MsgBox(ex.Message)
            tblresult = Nothing
        End Try

        Return iID

    End Function



    Public Shared Function Update(ByVal sUpdateQuery As String) As Boolean
        Dim tran As SqlTransaction
        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionstring
        cn.Open()
        tran = cn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        Try
            cmd.CommandText = sUpdateQuery
            cmd.Transaction = tran
            cmd.ExecuteNonQuery()
            tran.Commit()
            cn.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MsgBox(ex.ToString)
        Finally
            cn.Close()
            cn.Dispose()
        End Try
        Return False
    End Function

    Public Shared Function Updating(ByVal tblName As String, ByVal arr() As Object, ByVal state As String) As Boolean 'Update SQL Command
        Dim sInsertItem As String
        Dim cnmycon As New SqlConnection
        Try
            Get_FieldName(state)
            cnmycon.ConnectionString = dbconnectionString
            cnmycon.Open()
            Dim cmSqlcmd As New SqlCommand
            sInsertItem = ""

            sFieldName = insert_fieldname.Split(",")
            For i As Integer = 1 To arr.Length - 2
                cmSqlcmd.Parameters.AddWithValue("@" & i, arr(i))

                If i <> arr.Length - 2 Then
                    sInsertItem += sFieldName(i) & "=" & "@" & i & ","
                Else
                    sInsertItem += sFieldName(i) & "=" & "@" & i
                End If
            Next

            cmSqlcmd.Connection = cnmycon

            cmSqlcmd.CommandType = CommandType.Text
            'cmSqlcmd.CommandText = "Update " & tblName & " SET " & sInsertItem & " where " & sFieldName(0) & "='" & arr(0) & "'" 'old code
            ' If state = "import_temp_update" Then
            'cmSqlcmd.CommandText = "Update " & tblName & " SET " & sInsertItem & " where " & sFieldName(7) & "=N'" & arr(7) & "'"
            ' Else
            cmSqlcmd.CommandText = "Update " & tblName & " SET " & sInsertItem & " where " & sFieldName(0) & "='" & arr(0) & "'"
            ' End If
            cmSqlcmd.ExecuteNonQuery()
            cnmycon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            cnmycon.Close()
            Return False
        End Try

    End Function

    Public Shared Sub Get_FieldName(ByVal state As String)
        Try
            Select Case state
                Case "temp_update" : sqlstr = "tempcode,studentcode"
                Case "keepMeLoginUpdate" : sqlstr = "username,password,position,keepLogin"
                Case "modifyPosition" : sqlstr = "id,position"
                Case "modifyUser" : sqlstr = "username,password,position,phone,email,nrc,father,mother"
                Case "modifyRollCall" : sqlstr = "id,rollcall"
                Case "modifyNote" : sqlstr = "username,position,password,note"
                Case "modifyMark" : sqlstr = "id,mark"
                Case "modifyGrade" : sqlstr = "id,grade"
                Case "modifyphpMarkText" : sqlstr = "id,php"
                Case "modifyjavaMarkText" : sqlstr = "id,java"
                Case "modifydatastructureMarkText" : sqlstr = "id,data_structure"
                Case "modifynetworkMarkText" : sqlstr = "id,network"
                Case "modifydbmsMarkText" : sqlstr = "id,dbms"
                Case "modifymathMarkText" : sqlstr = "id,math"
                Case "modifyenglishMarkText" : sqlstr = "id,english"

            End Select
            insert_fieldname = ""
            insert_fieldname = sqlstr
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Public Shared Function getDataTable(ByVal commandText As String, ByVal commandType As CommandType) As DataTable

        Dim tblresult As DataTable

        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionstring
        cn.Open()

        Dim cmd As New SqlCommand(commandText, cn)
        cmd.CommandTimeout = 0
        cmd.CommandType = commandType

        Try
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = cmd
            Dim ds As New DataSet()
            adapter.Fill(ds)
            tblresult = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            cn.Close()
            tblresult = Nothing
        End Try
        Return tblresult

    End Function

    Public Shared Function Auto_GenerateNo(ByVal sField As String, ByVal sTableName As String, ByVal CodeFormat As String) As String
        Try
            Dim i_prefixcount As Integer = 0
            i_prefixcount = CodeFormat.Length

            Dim cn As New SqlConnection(SqlHelper.dbconnectionstring)
            Dim cmd As New SqlCommand
            Dim tblResult As New DataTable
            Dim tmpFINNo As String = ""
            Dim startNo As String = ""
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "SELECT MAX(convert(int,substring(" & sField & "," & i_prefixcount + 1 & ",LEN(" & sField & ")))) as Max FROM " & sTableName & ""

            'cmd.CommandText = "SELECT MAX(" & sField & ") as Max FROM " & sTableName
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tblResult)

            If (tblResult.Rows(0)(0).ToString.Equals(String.Empty)) Then

                tmpFINNo = CodeFormat & "1"
                cn.Close()
                Return tmpFINNo
            End If
            If (Not tblResult.Rows(0)(0).ToString.Equals(String.Empty)) Then
                Dim st As String = CodeFormat
                Dim temp As Integer = st.Count
                'Dim s_cno As String = tblResult.Rows(0).Item("Max").ToString.Substring(temp)
                Dim i As Integer = tblResult.Rows(0).Item("Max") 'Convert.ToInt32(s_cno)
                i = i + 1
                tmpFINNo = CodeFormat & i
                cn.Close()
                Return tmpFINNo
            End If
            cn.Close()
            Return tmpFINNo

        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Public Shared Function Generate_Code(ByVal sField As String, ByVal sTableName As String, ByVal schoolcode As String, ByVal CodeFormat As String) As String
        Try
            Dim i_prefixcount As Integer = 0
            i_prefixcount = schoolcode.Length + CodeFormat.Length

            Dim cn As New SqlConnection(SqlHelper.dbconnectionString)
            Dim cmd As New SqlCommand
            Dim tblResult As New DataTable
            Dim tmpFINNo As String = ""
            Dim startNo As String = ""
            cn.Open()
            cmd.Connection = cn
            'cmd.CommandText = "SELECT MAX(convert(int,substring(" & sField & "," & i_prefixcount + 1 & ",LEN(" & sField & ")))) as Max FROM " & sTableName & "  where " & sField & " like '" & schoolcode & "%'"

            cmd.CommandText = "SELECT MAX(convert(int,replace(" & sField & ",'" & schoolcode & CodeFormat & "',''))) as Max FROM " & sTableName & "  where " & sField & " like '" & schoolcode & "%'"

            'cmd.CommandText = "SELECT MAX(" & sField & ") as Max FROM " & sTableName
            cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tblResult)

            If (tblResult.Rows(0)(0).ToString.Equals(String.Empty)) Then

                tmpFINNo = schoolcode.ToString & CodeFormat & "1"
                cn.Close()
                Return tmpFINNo
            End If

            If (Not tblResult.Rows(0)(0).ToString.Equals(String.Empty)) Then
                Dim st As String = schoolcode.ToString + CodeFormat
                Dim temp As Integer = st.Count
                ' Dim s_cno As String = tblResult.Rows(0).Item("Max").ToString.Substring(temp)
                Dim i As Integer = tblResult.Rows(0).Item("Max") 'Convert.ToInt32(s_cno)
                i = i + 1
                tmpFINNo = schoolcode.ToString & CodeFormat & i
                cn.Close()
                Return tmpFINNo
            End If
            cn.Close()
            Return tmpFINNo

        Catch ex As Exception

            Throw (ex)
        End Try
    End Function


    Public Shared Function GetFieldNameFunc(ByVal Table As String) As String
        Try
            Dim str As String = ""
            Select Case Table
               
                Case "tblclass"
                    str = "class_code,class_name,class_description,class_display_code,edulevel_code,createddate,updateddate,class_order"

                

            End Select

            Return str

        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Public Shared Function Insert_ThreeTable(ByVal arr_Courses() As Object, ByVal sTableName1 As String, ByVal arr_Major() As Object, ByVal sTableName2 As String, ByVal arr_Batch As Object, ByVal sTableName3 As String) As Boolean

        Dim CourseFields As String = ""
        Dim MajorFields As String = ""
        Dim BatchFields As String = ""

        Dim sInsertItem1 As String = ""
        Dim sInsertItem2 As String = ""
        Dim sInsertItem3 As String = ""

        Dim iID1 As Integer = 0
        Dim iID2 As Integer = 0
        Dim iID3 As Integer = 0

        CourseFields = GetFieldNameFunc(sTableName1) 'Get FieldNames for three tables
        MajorFields = GetFieldNameFunc(sTableName2)
        BatchFields = GetFieldNameFunc(sTableName3)

        Dim tran As SqlTransaction
        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionString
        cn.Open()
        tran = cn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim cmd As New SqlCommand
        cmd.Connection = cn

        Try
            If sTableName1 = "courses" Then
                If (Not arr_Courses Is Nothing) Then
                    For p As Integer = 1 To arr_Courses.Length - 1
                        cmd.Parameters.AddWithValue("@" & p, arr_Courses(p - 1))

                        If p <> arr_Courses.Length - 1 Then
                            sInsertItem1 += "@" & p & ","
                        Else
                            sInsertItem1 += "@" & p
                        End If
                    Next
                End If
            End If

            If sTableName2 = "major" Then
                If (Not arr_Major Is Nothing) Then

                    For p As Integer = 1 To arr_Major.Length - 1
                        cmd.Parameters.AddWithValue("@" & p & "_" & p, arr_Major(p - 1)) '
                        If p <> arr_Major.Length - 1 Then
                            sInsertItem2 += "@" & p & "_" & p & "," ' 
                        Else
                            sInsertItem2 += "@" & p & "_" & p
                        End If
                    Next
                End If
            End If

            If sTableName3 = "batches" Then
                If (Not arr_Batch Is Nothing) Then
                    For p As Integer = 1 To arr_Batch.Length - 1
                        cmd.Parameters.AddWithValue("@" & p & "__" & p, arr_Batch(p - 1))
                        If p <> arr_Batch.Length - 1 Then
                            sInsertItem3 += "@" & p & "__" & p & ","
                        Else
                            sInsertItem3 += "@" & p & "__" & p
                        End If
                    Next
                End If
            End If
            Try
                cmd.CommandText = "INSERT INTO " & sTableName1 & "(" & CourseFields & ")" _
                                & " VALUES(" & sInsertItem1 & ")"
                cmd.Transaction = tran
                cmd.ExecuteNonQuery()
                ' iID1 = cmd.ExecuteScalar()

                cmd.CommandText = "INSERT INTO " & sTableName2 & "(" & MajorFields & ")" _
                                  & " VALUES(" & sInsertItem2 & ");"
                cmd.Transaction = tran
                cmd.ExecuteNonQuery()
                'iID2 = cmd.ExecuteScalar()

                cmd.CommandText = "INSERT INTO " & sTableName3 & "(" & BatchFields & ")" _
                                          & " VALUES(" & sInsertItem3 & ");"
                cmd.Transaction = tran
                cmd.ExecuteNonQuery()

                ' iID3 = cmd.ExecuteScalar()

                tran.Commit()
                cn.Close()
                Return True

            Catch ex As Exception
                tran.Rollback()
                cn.Close()
                Return False
            End Try

        Catch ex As Exception
            tran.Rollback()
            cn.Close()
            Return 0
        End Try
    End Function

    Public Shared Function Delete(ByVal sDeleteQuery As String) As Boolean
        Dim tran As SqlTransaction
        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionstring
        cn.Open()
        tran = cn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        Try
            cmd.CommandText = sDeleteQuery
            cmd.Transaction = tran
            cmd.ExecuteNonQuery()
            tran.Commit()
            cn.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MsgBox(ex.ToString)
        Finally
            cn.Close()
            cn.Dispose()
        End Try
        Return False
    End Function

    Public Shared Function GetFieldNameFromTable(ByVal tblName As String) As String
        Dim ds As New DataSet
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim FieldNames As String = ""
        Try
            cn.ConnectionString = dbconnectionstring
            cn.Open()
            Dim s As String = "SELECT * FROM information_schema.columns WHERE  table_name = '" & tblName & "' ORDER  BY ordinal_position"
            cmd.CommandText = s
            cmd.Connection = cn
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    If i <> ds.Tables(0).Rows.Count - 1 Then
                        FieldNames += ds.Tables(0).Rows(i)("COLUMN_NAME").ToString() & ","
                    Else
                        FieldNames += ds.Tables(0).Rows(i)("COLUMN_NAME").ToString()
                    End If
                Next
                Return FieldNames
            End If

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return FieldNames
        End Try
    End Function

    Public Shared Function GetCreatedUserCode(ByVal UserName As String, ByVal Pwd As String) As String
        Dim ds As New DataSet
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim st As String
        Try
            cn.ConnectionString = dbconnectionstring
            cn.Open()
            Dim s As String = "SELECT UserCode FROM tblUser where UserName='" & UserName & "' and UserPassword='" & Pwd & "'"
            cmd.CommandText = s
            cmd.Connection = cn
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item("UserCode").ToString <> "" Then
                    st = ds.Tables(0).Rows(0).Item("UserCode").ToString()
                    Return st
                Else
                    Return ""
                End If
            End If

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return ""
        End Try

    End Function

    Public Shared Function GetDataSetForCombo() As DataSet

        Dim dsSet As New DataSet
        Dim adapter As New SqlDataAdapter()
        Dim cn As New SqlConnection
        Dim cmd As SqlCommand

        Try
            cn.ConnectionString = dbconnectionstring
            cn.Open()

            cmd = New SqlCommand("Select SizeCode,SizeName from tblSize", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(0).TableName = "tblSize"

            cmd = New SqlCommand("Select DivisionCode,DivisionName from tblDivision", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(1).TableName = "tblDivision"

            cmd = New SqlCommand("Select DistrictCode,DistrictName from tblDistrict", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(2).TableName = "tblDistrict"

            cmd = New SqlCommand("Select OwnerCode,OwnerName from tblOwner  where Active='1' ", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(3).TableName = "tblOwner"

            cmd = New SqlCommand("Select CategoryCode,CategoryName from tblCategory ", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(4).TableName = "tblCategory"

            cmd = New SqlCommand("Select SubCategoryCode,SubCategoryName from tblSubCategory", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(5).TableName = "tblSubCategory"

            cmd = New SqlCommand("Select TownshipCode,TownshipName from tblTownship", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(6).TableName = "tblTownship"

            cmd = New SqlCommand("Select IndustrialZoneCode,IndustrialZoneName from tblIndustrialZone", cn)
            adapter.SelectCommand = cmd
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text

            adapter.Fill(dsSet)
            dsSet.Tables(7).TableName = "tblIndustrialZone"
            cn.Close()

            Return dsSet

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            cn.Close()
            Return Nothing
        End Try
    End Function

    ' Public Shared Function GetDataSetForImportExcel(ByVal oOwner As Modal.Owner, ByVal oSize As Modal.Size, ByVal oSubCategory As Modal.SubCategory, ByVal oTownship As Modal.Township, ByVal oIndustrialZone As Modal.IndustrialZone) As DataSet
    'Public Shared Function GetDataSetForImportExcel(ByVal oSize As Modal.Size, ByVal oSubCategory As Modal.SubCategory, ByVal oTownship As Modal.Township, ByVal oIndustrialZone As Modal.IndustrialZone) As DataSet
    '    Dim dsSet As New DataSet
    '    Dim adapter As New SqlDataAdapter()
    '    Dim cn As New SqlConnection
    '    Dim cmd As SqlCommand

    '    Try
    '        cn.ConnectionString = dbconnectionstring
    '        cn.Open()
    '        'For OwnerCode
    '        'cmd = New SqlCommand("Select OwnerCode,OwnerName from tblOwner where OwnerName=N'" & oOwner.OwnerName & "'", cn)
    '        'adapter.SelectCommand = cmd
    '        'cmd.CommandTimeout = 0
    '        'cmd.CommandType = CommandType.Text

    '        'adapter.Fill(dsSet)
    '        'dsSet.Tables(0).TableName = "tblOwner"

    '        'For SizeCode
    '        cmd = New SqlCommand("Select SizeCode,SizeName from tblSize where SizeName=N'" & oSize.SizeName & "'", cn)
    '        adapter.SelectCommand = cmd
    '        cmd.CommandTimeout = 0
    '        cmd.CommandType = CommandType.Text

    '        adapter.Fill(dsSet)
    '        dsSet.Tables(0).TableName = "tblSize"

    '        'For SubCategoryCode
    '        cmd = New SqlCommand("Select SubCategoryCode,SubCategoryName from tblSubCategory where SubCategoryName=N'" & oSubCategory.SubCategoryName & "'", cn)
    '        adapter.SelectCommand = cmd
    '        cmd.CommandTimeout = 0
    '        cmd.CommandType = CommandType.Text

    '        adapter.Fill(dsSet)
    '        dsSet.Tables(1).TableName = "tblSubCategory"

    '        'For TownshipCode
    '        cmd = New SqlCommand("Select TownshipCode,TownshipName from tblTownship where TownshipName=N'" & oTownship.TownshipName & "'", cn)
    '        adapter.SelectCommand = cmd
    '        cmd.CommandTimeout = 0
    '        cmd.CommandType = CommandType.Text

    '        adapter.Fill(dsSet)
    '        dsSet.Tables(2).TableName = "tblTownship"

    '        'For IndustrialZoneCode
    '        cmd = New SqlCommand("Select IndustrialZoneCode,IndustrialZoneName from tblIndustrialZone where IndustrialZoneName=N'" & oIndustrialZone.IndustrialName & "'", cn)
    '        adapter.SelectCommand = cmd
    '        cmd.CommandTimeout = 0
    '        cmd.CommandType = CommandType.Text

    '        adapter.Fill(dsSet)
    '        dsSet.Tables(3).TableName = "tblIndustrialZone"

    '        cn.Close()

    '        Return dsSet

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString())
    '        cn.Close()
    '        Return Nothing
    '    End Try

    'End Function

    Public Shared Function BackUp(ByVal fname As String) As Boolean

        Dim tran As SqlTransaction
        Dim sQuery As String = "backup database IndustrialManagementSystem to disk='" & fname & "' with FORMAT"
        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionstring
        cn.Open()
        Dim cmd As New SqlCommand '(commandText, cn)
        cmd.Connection = cn
        Try
            cmd.CommandText = sQuery
            cmd.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            tran.Rollback()
            MsgBox(ex.ToString)
        Finally
            cn.Close()
            cn.Dispose()
        End Try
        Return False
    End Function

    '------------
    Public Shared Function UpdateApprove(ByVal rollnum As String) As Boolean 'Update SQL Command
        'Dim sInsertItem As String
        Dim cnmycon As New SqlConnection
        Try

            cnmycon.ConnectionString = dbconnectionstring
            cnmycon.Open()
            Dim cmSqlcmd As New SqlCommand
            'sInsertItem = ""

            'sFieldName = insert_fieldname.Split(",")
            'For i As Integer = 1 To arr.Length - 2
            '    cmSqlcmd.Parameters.AddWithValue("@" & i, arr(i))

            '    If i <> arr.Length - 2 Then
            '        sInsertItem += sFieldName(i) & "=" & "@" & i & ","
            '    Else
            '        sInsertItem += sFieldName(i) & "=" & "@" & i
            '    End If
            'Next

            cmSqlcmd.Connection = cnmycon

            cmSqlcmd.CommandType = CommandType.Text
            'cmSqlcmd.CommandText = "Update " & tblName & " SET " & sInsertItem & " where " & sFieldName(0) & "='" & arr(0) & "'" 'old code
            'If state = "import_temp_update" Then
            '    cmSqlcmd.CommandText = "Update " & tblName & " SET " & sInsertItem & " where " & sFieldName(7) & "=N'" & arr(7) & "'"
            'Else
            '    cmSqlcmd.CommandText = "Update " & tblName & " SET " & sInsertItem & " where " & sFieldName(0) & "='" & arr(0) & "'"
            'End If
            'If (SqlHelper.Update("update tbltemp set studentcode=null where studentcode in (select studentcode from tblcard where rollno=N'" & rollnum.ToString & "')") And
            'SqlHelper.Update("delete from tblstudent where studentcode in (select studentcode from tblcard where rollno=N'" & rollnum.ToString & "')") And
            'SqlHelper.Update("delete  from tblcard where rollno=N'" & rollnum.ToString & "'")) Then

            '    Return True
            'End If


           
        Catch ex As Exception
            MsgBox(ex.Message)
            cnmycon.Close()
            Return False
        End Try

    End Function

    Public Shared Function Modify(ByVal sUpdateQuery As String) As Boolean

        Dim tran As SqlTransaction

        Dim cn As New SqlConnection
        cn.ConnectionString = dbconnectionstring
        cn.Open()

        tran = cn.BeginTransaction(IsolationLevel.ReadCommitted)

        Dim cmd As New SqlCommand '(commandText, cn)
        cmd.Connection = cn

        Try

            cmd.CommandText = sUpdateQuery
            cmd.Transaction = tran
            cmd.ExecuteNonQuery()
            tran.Commit()
            cn.Close()

            Return True

        Catch ex As Exception
            tran.Rollback()
            MsgBox(ex.ToString)
        Finally
            cn.Close()
            cn.Dispose()

        End Try

        Return False

    End Function

   
    '-------

End Class
