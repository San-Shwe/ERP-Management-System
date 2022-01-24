Public Class frmMainForm

#Region "Variable Declaration"
    Dim m_user As New Modal.M_School
    Public Shared doOnce As Boolean = True
    Public Shared username As String = frmLogin.txtUsername.Text.ToString.Trim
    Public Shared password As String = frmLogin.txtPassword.Text.ToString.Trim
    Public Shared newPassword As String

#End Region

    Public Function AddPosition()
        Try
            If txtPositionName.Text.Trim <> "" Then
                Dim successSave As Boolean
                Dim positionName As String = txtPositionName.Text.Trim
                successSave = BusinessLogic.BL_School.Insert(positionName)
                If successSave Then
                    MessageBox.Show("Save Successful!")
                Else
                    MessageBox.Show("Save Unsuccessful!")
                End If
                txtPositionName.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function deletePosition()
        Try
            If cboRemovePositionList.SelectedIndex <> -1 Then
                Dim successSave As Boolean
                Dim positionName As String = cboRemovePositionList.Text.Trim
                successSave = BusinessLogic.BL_School.deletePosition(positionName)
                If successSave Then
                    MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    BindRemovePosition()
                Else
                    MessageBox.Show("Delete Unsuccessful!", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                txtPositionName.Text = ""
                BindModifyPosition()
                BindRemovePosition()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ModifyPosition()
        Try
            If doOnce = False Then
                If txtModify.Text.Trim <> "" Then
                    Dim successSave As Boolean
                    Dim positionName As String = txtModify.Text.Trim
                    Dim positionValue As String = cboModifyPositionList.SelectedValue
                    successSave = BusinessLogic.BL_School.ModifyPosition(positionValue, positionName)
                    If successSave Then
                        MessageBox.Show("Change Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        MessageBox.Show("Change Unsuccessful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                    txtModify.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function BindRemovePosition()
        Try
            Dim dtTable As New DataTable
            dtTable = BusinessLogic.BL_School.ShowPositionData()
            If Not dtTable Is Nothing Then
                Dim row As DataRow = dtTable.NewRow()
                row("position") = "---Select One---"
                dtTable.Rows.InsertAt(row, 0)
                cboRemovePositionList.DataSource = dtTable
                cboRemovePositionList.DisplayMember = "position"
                cboRemovePositionList.ValueMember = "id"
                cboRemovePositionList.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function BindModifyPosition()
        Try
            Dim dtTable As New DataTable
            dtTable = BusinessLogic.BL_School.ShowPositionData()
            If Not dtTable Is Nothing Then
                Dim row As DataRow = dtTable.NewRow()
                row("position") = "---Select One---"
                dtTable.Rows.InsertAt(row, 0)
                cboModifyPositionList.DataSource = dtTable
                cboModifyPositionList.DisplayMember = "position"
                cboModifyPositionList.ValueMember = "id"
                cboModifyPositionList.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Dim dtPositionCountTable As New DataTable

    Public Function countPositionNumber(ByVal position As String)
        Try
            dtPositionCountTable = BusinessLogic.BL_School.ShowPositionsNumber(position)
            If position = "student" Then
                lblStudentNumbers.Text = dtPositionCountTable.Rows.Count()
            ElseIf position = "teacher" Then
                lblTeacherNumber.Text = dtPositionCountTable.Rows.Count()
            ElseIf position = "parents" Then
                lblParentNumber.Text = dtPositionCountTable.Rows.Count()
            ElseIf position = "staff" Then
                lblStaffNumber.Text = dtPositionCountTable.Rows.Count()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ShowNoticeBoard()
        Try
            dgvTable.DataSource = Nothing
            Dim dtTable As New DataTable
            dtTable = BusinessLogic.BL_School.ShowNoticeBoard()
            If dtTable.Rows.Count > 0 Then
                dgvTable.Rows.Clear()
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    dgvTable.Rows.Add()
                    dgvTable.Rows(i).Cells(0).Value = dtTable.Rows(i).Item("id").ToString()
                    dgvTable.Rows(i).Cells(1).Value = dtTable.Rows(i).Item("username").ToString()
                    dgvTable.Rows(i).Cells(2).Value = dtTable.Rows(i).Item("position").ToString()
                    dgvTable.Rows(i).Cells(3).Value = dtTable.Rows(i).Item("message").ToString()
                    dgvTable.Rows(i).Cells(4).Value = dtTable.Rows(i).Item("date").ToString()
                Next
            End If

            If dgvTable.Columns.Count < 6 Then
                Dim btn As New DataGridViewButtonColumn
                dgvTable.Columns.Add(btn)
                btn.HeaderText = "View Message"
                btn.Text = "View"
                btn.UseColumnTextForButtonValue = True
            End If

            If dgvTable.Columns.Count < 7 Then
                Dim btn1 As New DataGridViewButtonColumn
                dgvTable.Columns.Add(btn1)
                btn1.HeaderText = "Delete Message"
                btn1.Text = "Delete"
                btn1.UseColumnTextForButtonValue = True
            End If

            'sort Descending
            dgvTable.Sort(dgvTable.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function AddNote()
        Try
            If richtxtNoteText.Text.Trim <> "" Then
                Dim successSave As Boolean
                m_user.Username = lblCurrentUserName.Text
                m_user.Position = lblCurrentPosition.Text
                Dim text As String = richtxtNoteText.Text.ToString.Trim
                Dim datetime As String = Now.ToString
                successSave = BusinessLogic.BL_School.InsertNote(m_user, text, datetime)
                If successSave Then
                    MessageBox.Show("Note Added to Noticeboard Successfully!","Noticboard Message",MessageBoxButtons.OK,MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Note add unsuccessful")
                End If
                txtPositionName.Text = ""
            Else
                MessageBox.Show("Please wirte your note in text box!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function showCurrentUserDetails(ByVal username As String, ByVal password As String)
        Try
            Dim dtTable As New DataTable
            username = lblCurrentUserName.Text
            password = frmLogin.txtPassword.Text.Trim
            Dim currentPosition As String = lblCurrentPosition.Text.Trim
            dtTable = BusinessLogic.BL_School.ShowCurrentUserDetails(username, password, currentPosition)
            frmCurrentUserProfile.txtUsername.Text = dtTable.Rows(0).Item("username").ToString()
            frmCurrentUserProfile.txtPassword.Text = dtTable.Rows(0).Item("password").ToString()
            frmCurrentUserProfile.txtPosition.Text = dtTable.Rows(0).Item("position").ToString()
            frmCurrentUserProfile.txtPhoneNo.Text = dtTable.Rows(0).Item("phone").ToString()
            frmCurrentUserProfile.txtEmail.Text = dtTable.Rows(0).Item("email").ToString()
            frmCurrentUserProfile.txtFatherName.Text = dtTable.Rows(0).Item("father").ToString()
            frmCurrentUserProfile.txtMotherName.Text = dtTable.Rows(0).Item("mother").ToString()
            frmCurrentUserProfile.txtNRCNo.Text = dtTable.Rows(0).Item("nrc").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function SendTeacherInstruction()
        Try
            If richtxtInstructionText.Text.Trim <> "" Then
                Dim successSave As Boolean
                m_user.Username = lblCurrentUserName.Text
                m_user.Position = lblCurrentPosition.Text
                Dim text As String = richtxtInstructionText.Text.ToString
                Dim classText As String = cboForStudentClass.Text.Trim
                Dim typeText As String = cboType.Text.Trim + dudNumber.Text.Trim
                Dim allowMinutes As Integer = dudAllowMinutes.Text.Trim
                Dim subject As String = lblSubject.Text.Trim
                successSave = BusinessLogic.BL_Teacher.TeacherInstruction(m_user, text, classText, typeText, allowMinutes, subject)
                If successSave Then
                    MessageBox.Show("Add Instruction Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Note add unsuccessful")
                End If
                txtPositionName.Text = ""
            Else
                MessageBox.Show("Please wirte your text for specific class!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function RollCall()
        Try
            dgvTable.DataSource = Nothing
            Dim dtTable As New DataTable
            Dim className As String = cboRollCallClass.Text.Trim
            dtTable = BusinessLogic.BL_Student.ShowRollcall(className)
            If dtTable.Rows.Count > 0 Then
                dgvTable.Rows.Clear()
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    dgvTable.Rows.Add()
                    dgvTable.Rows(i).Cells(0).Value = dtTable.Rows(i).Item("id").ToString()
                    dgvTable.Rows(i).Cells(1).Value = dtTable.Rows(i).Item("username").ToString()
                    dgvTable.Rows(i).Cells(2).Value = dtTable.Rows(i).Item("phone").ToString()
                    dgvTable.Rows(i).Cells(3).Value = dtTable.Rows(i).Item("class").ToString()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ModifyStudentRollCall()
        Try
            For i As Integer = 0 To dgvRollCall.Rows.Count - 1

                Dim successSave As Boolean
                Dim id As Integer = dgvRollCall.Rows(i).Cells(0).Value
                Dim roll As Integer
                If dgvRollCall.Rows(i).Cells(5).Value <> "" Then
                    roll = dgvRollCall.Rows(i).Cells(5).Value
                Else
                    roll = 0
                End If
                successSave = BusinessLogic.BL_Teacher.ModifyRollCall(id, roll)
                'If successSave Then
                '    'MessageBox.Show("Change Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                'Else
                '    MessageBox.Show("Change Unsuccessful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                'End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ModifyStudentGrade()
        Try
            For i As Integer = 0 To dgvRollCall.Rows.Count - 1

                Dim successSave As Boolean
                Dim id As Integer = dgvRollCall.Rows(i).Cells(0).Value
                Dim grade As Integer
                If dgvRollCall.Rows(i).Cells(1).Value <> "" Then
                    grade = dgvRollCall.Rows(i).Cells(1).Value
                Else
                    grade = 0
                End If
                successSave = BusinessLogic.BL_Teacher.ModifyStudentGrade(id, grade)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Shared pubmark() As String
    Public Shared teacherSubject As String = frmMainForm.teacherSubject.Trim
    Public Function BindStudentRollCall()
        Try
            dgvTable.DataSource = Nothing
            Dim dtTable As New DataTable
            Dim className As String = cboRollCallClass.SelectedItem.ToString.Trim
            dtTable = BusinessLogic.BL_Student.ShowRollcall(className)
            If dtTable.Rows.Count > 0 Then
                dgvRollCall.Rows.Clear()
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    dgvRollCall.Rows.Add()
                    dgvRollCall.Rows(i).Cells(0).Value = dtTable.Rows(i).Item("id").ToString()
                    dgvRollCall.Rows(i).Cells(1).Value = dtTable.Rows(i).Item("grade").ToString()
                    dgvRollCall.Rows(i).Cells(2).Value = dtTable.Rows(i).Item("username").ToString()
                    dgvRollCall.Rows(i).Cells(3).Value = dtTable.Rows(i).Item("phone").ToString()
                    dgvRollCall.Rows(i).Cells(4).Value = dtTable.Rows(i).Item("class").ToString()
                    dgvRollCall.Rows(i).Cells(5).Value = dtTable.Rows(i).Item("rollcall").ToString()
                    pubmark(i) = dtTable.Rows(i).Item(teacherSubject).ToString()
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function BindStudentOverview()
        Try
            dgvTable.DataSource = Nothing
            Dim dtTable As New DataTable
            Dim className As String = lblStudentClass.Text.ToString.Trim
            dtTable = BusinessLogic.BL_Student.ShowRollcall(className)
            If dtTable.Rows.Count > 0 Then
                dgvStudentOverview.Rows.Clear()
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    dgvStudentOverview.Rows.Add()
                    dgvStudentOverview.Rows(i).Cells(0).Value = dtTable.Rows(i).Item("id").ToString()
                    dgvStudentOverview.Rows(i).Cells(1).Value = dtTable.Rows(i).Item("username").ToString()
                    dgvStudentOverview.Rows(i).Cells(2).Value = dtTable.Rows(i).Item("phone").ToString()
                    dgvStudentOverview.Rows(i).Cells(3).Value = dtTable.Rows(i).Item("class").ToString()
                    dgvStudentOverview.Rows(i).Cells(4).Value = dtTable.Rows(i).Item("rollcall").ToString()
                    dgvStudentOverview.Rows(i).Cells(5).Value = dtTable.Rows(i).Item("grade").ToString()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function SendTutorial()
        Try
            If richTextAnswer.Text.Trim <> "" Then
                Dim successSave As Boolean
                m_user.Username = lblStudentUsername.Text.Trim
                m_user.Position = lblCurrentPosition.Text
                Dim className As String = lblStudentClass.Text.Trim
                Dim rank As String = lblStudentRank.Text.Trim
                Dim text As String = richTextAnswer.Text.ToString.Trim
                Dim datetime As String = Now.ToString
                Dim type As String = dudTutorial.SelectedItem.ToString
                Dim timetaken As String = lblTutorialTimeCounter.Text.Trim
                Dim question As String = richtxtQuestion.Text.Trim
                Dim subject As String = cboStudentTutorialSubject.SelectedItem.ToString.Trim
                successSave = BusinessLogic.BL_Student.SendAnswer(m_user, text, className, rank, datetime, type, timetaken, question, subject)
                If successSave Then
                    MessageBox.Show("You finished your " & type & "!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dudTutorial.ReadOnly = False
                    picStart.Visible = True
                    picStop.Visible = False
                Else
                    MessageBox.Show("unsuccessful")
                End If
                'txtPositionName.Text = ""
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function SendAssignment()
        Try
            If richTxtAssignmentAnswer.Text.Trim <> "" Then
                Dim successSave As Boolean
                m_user.Username = lblStudentUsername.Text.Trim
                m_user.Position = lblCurrentPosition.Text
                Dim className As String = lblStudentClass.Text.Trim
                Dim rank As String = lblStudentRank.Text.Trim
                Dim text As String = richTxtAssignmentAnswer.Text.ToString.Trim
                Dim datetime As String = Now.ToString
                Dim type As String = dudAssignment.SelectedItem.ToString
                Dim timetaken As String = lblAssignmentTimeCounter.Text.Trim
                Dim question As String = richtxtAssignmentQuestion.Text.Trim
                Dim subject As String = cboStudentAssignmentSubject.SelectedItem.ToString.Trim
                successSave = BusinessLogic.BL_Student.SendAnswer(m_user, text, className, rank, datetime, type, timetaken, question, subject)
                If successSave Then
                    MessageBox.Show("You finished your " & type & "!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dudAssignment.ReadOnly = False
                    picAssignmentStart.Visible = True
                    picAssignmentStop.Visible = False
                Else
                    MessageBox.Show("unsuccessful")
                End If
                'txtPositionName.Text = ""

            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function BindForStudentClass(ByVal cbo As ComboBox)
        Dim a() As String = frmLogin.classname.Split(",")
        cbo.Items.Clear()
        cbo.Items.Add("--- Select One ---")
        For i As Integer = 0 To a.Length - 1
            cbo.Items.Add(a(i))
        Next
        cbo.SelectedIndex = 0
    End Function

    Public Function modifyStudentAnswerMark()
        Try
            Dim successSave As Boolean
            Dim i As Integer = dgvMarkManagement.CurrentRow.Index
            Dim id As Integer = dgvMarkManagement.Rows(i).Cells(0).Value
            Dim mark As Integer
            If dgvMarkManagement.Rows(i).Cells(7).Value <> "" Then
                mark = dgvMarkManagement.Rows(i).Cells(7).Value
            Else
                mark = 0
            End If
            successSave = BusinessLogic.BL_Teacher.ModifyAnswerMark(id, mark)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Public Shared realtext As String
    'Public Function modifyStudentMark()
    '    Try
    '        Dim successSave As Boolean
    '        Dim i As Integer = dgvMarkManagement.CurrentRow.Index
    '        Dim id As Integer = dgvMarkManagement.Rows(i).Cells(0).Value
    '        Dim mark As Integer
    '        If dgvMarkManagement.Rows(i).Cells(7).Value <> "" Then
    '            Dim text As String = pubmark(i)
    '            Dim type As String = dgvMarkManagement.Rows(i).Cells(5).Value
    '            mark = dgvMarkManagement.Rows(i).Cells(7).Value
    '            Dim separator() As String = {"=", ","}
    '            Dim strlist() As String = text.Split(separator, StringSplitOptions.RemoveEmptyEntries)
    '            '    If type.Contains("Tutorial") Then
    '            '        For j As Integer = 0 To strlist.Length
    '            '            If j = 2 Then
    '            '                realtext += dgvMarkManagement.Rows(i).Cells(7).Value.ToString
    '            '                Continue For
    '            '                realtext += strlist(i) & IIf(((j + 1) Mod 2) = 0, "=", ",")
    '            '            End If
    '            '        Next
    '            '        successSave = BusinessLogic.BL_Teacher.ModifyStudentMarkText(id, realtext, frmLogin.subjectname.Trim)
    '            '    ElseIf type.Contains("Assignmet") Then
    '            '        For j As Integer = 0 To strlist.Length
    '            '            If j = 4 Then
    '            '                realtext += dgvMarkManagement.Rows(i).Cells(7).Value.ToString
    '            '                Continue For
    '            '                realtext += strlist(i) & IIf(((j + 1) Mod 2) = 0, "=", ",")
    '            '            End If
    '            '        Next
    '            '        successSave = BusinessLogic.BL_Teacher.ModifyStudentMarkText(id, realtext, frmLogin.subjectname.Trim)
    '            '    ElseIf type.Contains("Lab") Then
    '            '        For j As Integer = 0 To strlist.Length
    '            '            If j = 6 Then
    '            '                realtext += dgvMarkManagement.Rows(i).Cells(7).Value.ToString
    '            '                Continue For
    '            '                realtext += strlist(i) & IIf(((j + 1) Mod 2) = 0, "=", ",")
    '            '            End If
    '            '        Next
    '            '        successSave = BusinessLogic.BL_Teacher.ModifyStudentMarkText(id, realtext, frmLogin.subjectname.Trim)

    '            '    End If

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Function


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        timerClock.Start()
        lblTime.Visible = True

        txtModify.Visible = False
        cboModifyPositionList.Visible = True
        If doOnce = True Then
            btnChange_Click(sender, e)
            doOnce = False
        End If
        btnChange.Visible = False
        btnCancel.Visible = False
        btnCancelDelete.Visible = False
        btnAdd.Visible = False
        btnDelete.Visible = False

        countPositionNumber("student")
        countPositionNumber("teacher")
        countPositionNumber("staff")
        countPositionNumber("parents")

        ShowNoticeBoard()
        dgvTable.RowsDefaultCellStyle.BackColor = Color.Bisque
        dgvTable.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

        Me.dgvTable.Columns(1).Width = 80
        Me.dgvTable.Columns(2).Width = 100
        Me.dgvTable.Columns(5).Width = 70
        Me.dgvTable.Columns(6).Width = 100

    End Sub

    Private Sub timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerClock.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmExit.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogout.Click
        'Are you sure to logout
        frmLogin.Show()
        Me.Hide()
        'lblCurrentUserName.Text = ""
        'lblCurrentPosition.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddPosition()
        BindRemovePosition()
        BindModifyPosition()
        btnCancel_Click(sender, e)
        btnCancelDelete_Click(sender, e)
    End Sub

    Private Sub btnCancelDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelDelete.Click
        BindRemovePosition()
        btnCancelDelete.Visible = False
        btnDelete.Visible = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        deletePosition()
        btnCancel_Click(sender, e)
        btnDelete.Visible = False
        btnCancelDelete.Visible = False
    End Sub

    Public Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        ModifyPosition()
        BindRemovePosition()
        BindModifyPosition()
        btnCancelDelete_Click(sender, e)
        cboModifyPositionList.Visible = True
        txtModify.Visible = False
        btnCancel.Visible = False
        btnChange.Visible = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        BindModifyPosition()
        cboModifyPositionList.Visible = True
        txtModify.Visible = False
        btnCancel.Visible = False
        btnChange.Visible = False
    End Sub

    Private Sub txtPositionName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPositionName.TextChanged
        If txtPositionName.Text.Trim <> "" Then
            btnAdd.Visible = True
        Else
            btnAdd.Visible = False
        End If
    End Sub

    Private Sub cboRemovePositionList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemovePositionList.SelectedIndexChanged
        btnDelete.Visible = True
        btnCancelDelete.Visible = True
    End Sub

    Private Sub cboModifyPositionList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModifyPositionList.SelectedIndexChanged
        txtModify.Visible = True
        cboModifyPositionList.Visible = False
        txtModify.Text = cboModifyPositionList.Text
        btnCancel.Visible = True
        btnChange.Visible = True
    End Sub

    Public Sub btnAddNewUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewUsers.Click
        'Me.Hide()
        frmNewUser.Show()
        frmNewUser.ShowRegisterDetails()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlAdminUI.Visible = False
        pnlManagerInterface.Visible = False
        pnlStudentInterFace.Visible = False
        pnlSoftwareUI.Visible = True

    End Sub

    Private Sub picCurrentUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCurrentUser.Click
        Me.Hide()
        frmCurrentUserProfile.Show()
        showCurrentUserDetails(username, frmLogin.txtPassword.Text.Trim)
    End Sub

    Private Sub btnAddNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNote.Click
        AddNote()
        ShowNoticeBoard()
        richtxtNoteText.Text = ""

        'sort Descending
        dgvTable.Sort(dgvTable.Columns(0), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub btnMyInterface_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMyInterface.Click
        If btnMyInterface.Text = "Home" Then
            btnMyInterface.Text = "My Interface"
            pnlAdminUI.Visible = False
            pnlManagerInterface.Visible = False
            pnlStudentInterFace.Visible = False
            pnlTeacherInterface.Visible = False
            pnlStaffInterface.Visible = False
            pnlParentsInterface.Visible = False
            pnlSoftwareUI.Visible = True
            If lblCurrentPosition.Text = "manager" Or frmLogin.cboLoginPosition.Text = "manager" Then
                Me.dgvTable.Columns(6).Visible = True
            Else
                Me.dgvTable.Columns(6).Visible = False
            End If
        ElseIf btnMyInterface.Text = "My Interface" Then
            frmLogin.picLogin_Click(sender, e)
            btnMyInterface.Text = "Home"
        End If
    End Sub

    Private Sub dgvTable_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTable.CellClick
        Try
            If e.ColumnIndex = 5 Then
                Dim i As Integer = dgvTable.CurrentRow.Index
                frmNoticeBoard.lblUsername.Text = dgvTable.Rows(i).Cells(1).Value
                frmNoticeBoard.lblPosition.Text = dgvTable.Rows(i).Cells(2).Value
                frmNoticeBoard.richNoteText.Text = dgvTable.Rows(i).Cells(3).Value
                frmNoticeBoard.lblDatetime.Text = dgvTable.Rows(i).Cells(4).Value
                frmNoticeBoard.Show()
            ElseIf e.ColumnIndex = 6 Then
                Dim id As Integer = dgvTable.Rows(dgvTable.CurrentRow.Index).Cells(0).Value
                Dim successSave As Boolean = BusinessLogic.BL_School.DeleteNoteiceBoardRecord(id)
                If successSave Then
                    ShowNoticeBoard()
                Else
                    MessageBox.Show("unsuccessful")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnStudentData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentData.Click
        frmViewData.Show()
        frmViewData.BindPosition()
        'Me.Hide()
    End Sub

    Private Sub RepoortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnStudentData_Click(sender, e)
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        SendTeacherInstruction()
        'richtxtInstructionText.Text = ""
        'cboClass.SelectedIndex = 0
        'cboType.SelectedIndex = 0
    End Sub

    Private Sub cboClassName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRollCallClass.SelectedIndexChanged
        BindStudentRollCall()
    End Sub

    Private Sub dgvRollCall_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = 13 Then
            ModifyStudentRollCall()
        End If

    End Sub

    Private Sub dgvRollCall_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ModifyStudentRollCall()
    End Sub

    Private Sub dgvRollCall_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModifyStudentRollCall()
    End Sub

    Private Sub dudTutorial_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudTutorial.SelectedItemChanged
        Try
            'dgvTable.DataSource = Nothing
            Dim dtTable As New DataTable
            Dim type As String = dudTutorial.SelectedItem.ToString.Trim
            Dim className As String = lblStudentClass.Text.Trim
            Dim subject As String = cboStudentTutorialSubject.Text.Trim
            dtTable = BusinessLogic.BL_Teacher.ShowInstruction(type, className, subject)
            If dtTable.Rows.Count > 0 Then
                richtxtQuestion.Text = dtTable.Rows(0).Item("text").ToString()
                lblTutorialTimeCounter.Text = dtTable.Rows(0).Item("minutes") & " minutes"
                minutes = dtTable.Rows(0).Item("minutes") - 1
            Else
                richtxtQuestion.Text = "No Question"
                lblTutorialTimeCounter.Text = "00:00"
                richTextAnswer.ReadOnly = True
                picStop_Click(sender, e)
            End If
            timerTutorial.Stop()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStart.Click
        picStart.Visible = False
        picStop.Visible = True
        timerTutorial.Start()
        richTextAnswer.ReadOnly = False
        dudTutorial.Enabled = False
    End Sub

    Private Sub picStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStop.Click
        picStart.Visible = True
        picStop.Visible = False
        timerTutorial.Stop()
        richTextAnswer.ReadOnly = True
        btnSubmitTutorial_Click(sender, e)
        dudTutorial.Enabled = True
    End Sub

    Public Shared minutes As Integer = 60
    Public Shared seconds As Integer = 60

    Private Sub dudAssignment_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudAssignment.SelectedItemChanged
        Try
            dgvTable.DataSource = Nothing
            Dim dtTable As New DataTable
            Dim type As String = dudAssignment.SelectedItem.ToString.Trim
            Dim className As String = lblStudentClass.Text.Trim
            Dim subject As String = cboStudentAssignmentSubject.Text.Trim
            dtTable = BusinessLogic.BL_Teacher.ShowInstruction(type, className, subject)
            If dtTable.Rows.Count > 0 Then
                richtxtAssignmentQuestion.Text = dtTable.Rows(0).Item("text").ToString()
                lblAssignmentTimeCounter.Text = dtTable.Rows(0).Item("minutes") & " minutes"
                minutes = dtTable.Rows(0).Item("minutes") - 1
            Else
                richtxtAssignmentQuestion.Text = "No Question"
                lblAssignmentTimeCounter.Text = "00:00"
                richTxtAssignmentAnswer.ReadOnly = True
                picAssignmentStop_Click(sender, e)
            End If
            timerAssignment.Stop()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmitTutorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitTutorial.Click
        SendTutorial()
        timerTutorial.Stop()
    End Sub

    Private Sub picAssignmentStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAssignmentStop.Click
        picAssignmentStart.Visible = True
        picAssignmentStop.Visible = False
        timerAssignment.Stop()
        richTxtAssignmentAnswer.ReadOnly = True
        btnAssignmentSend_Click(sender, e)
        dudAssignment.Enabled = True
    End Sub

    Private Sub picAssignmentStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAssignmentStart.Click
        picAssignmentStart.Visible = False
        picAssignmentStop.Visible = True
        timerAssignment.Start()
        richTxtAssignmentAnswer.ReadOnly = False
        dudAssignment.Enabled = False
    End Sub

    Private Sub btnAssignmentSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignmentSend.Click
        SendAssignment()
        timerAssignment.Stop()
    End Sub

    Private Sub timerAssignment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAssignment.Tick
        seconds -= 1
        lblAssignmentTimeCounter.Text = (minutes & ":" & seconds).ToString
        If minutes = 0 And seconds = 0 Then
            timerAssignment.Stop()
            lblAssignmentTimeCounter.Text = "00:00"
            MessageBox.Show("Time Up", "e-schcool", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnAssignmentSend_Click(sender, e)
            richTxtAssignmentAnswer.ReadOnly = True
            minutes = seconds = 0
            dudAssignment.Enabled = True
        End If

        If seconds = 0 Then
            minutes -= 1
            seconds = 60
        End If

    End Sub

    Private Sub timerTutorial_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTutorial.Tick
        seconds -= 1
        lblTutorialTimeCounter.Text = (minutes & ":" & seconds).ToString

        If minutes = 0 AndAlso seconds = 0 Then
            timerTutorial.Stop()
            lblTutorialTimeCounter.Text = "00:00"
            MessageBox.Show("Time Up", "e-schcool", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnSubmitTutorial_Click(sender, e)
            richTextAnswer.Enabled = False
            minutes = seconds = 0
            dudTutorial.Enabled = True
        End If

        If seconds = 0 Then
            minutes -= 1
            seconds = 60
        End If

    End Sub

    Private Sub cboMarkManagement_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarkManagement.SelectedIndexChanged
        Try
            dgvMarkManagement.DataSource = Nothing
            dgvMarkManagement.Rows.Clear()
            Dim dtTable As New DataTable
            Dim className As String = cboMarkManagement.SelectedItem.ToString.Trim
            dtTable = BusinessLogic.BL_Teacher.ShowForMarkManage(className)

            If dtTable.Rows.Count > 0 Then
                dgvMarkManagement.Rows.Clear()
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    dgvMarkManagement.Rows.Add()
                    dgvMarkManagement.Rows(i).Cells(0).Value = dtTable.Rows(i).Item("id").ToString()
                    dgvMarkManagement.Rows(i).Cells(1).Value = dtTable.Rows(i).Item("username").ToString()
                    dgvMarkManagement.Rows(i).Cells(2).Value = dtTable.Rows(i).Item("class").ToString()
                    dgvMarkManagement.Rows(i).Cells(3).Value = dtTable.Rows(i).Item("grade").ToString()
                    dgvMarkManagement.Rows(i).Cells(4).Value = dtTable.Rows(i).Item("datetime").ToString()
                    dgvMarkManagement.Rows(i).Cells(5).Value = dtTable.Rows(i).Item("type").ToString()
                    dgvMarkManagement.Rows(i).Cells(6).Value = dtTable.Rows(i).Item("text").ToString()
                    dgvMarkManagement.Rows(i).Cells(7).Value = dtTable.Rows(i).Item("mark").ToString()
                Next
            End If

            If dgvMarkManagement.Columns.Count < 9 Then
                Dim btn As New DataGridViewButtonColumn
                dgvMarkManagement.Columns.Add(btn)
                btn.HeaderText = "Check Mark"
                btn.Text = "Check"
                btn.UseColumnTextForButtonValue = True


            End If

            dgvMarkManagement.RowsDefaultCellStyle.BackColor = Color.Bisque
            dgvMarkManagement.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tcTeacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcTeacher.SelectedIndexChanged
        If tcTeacher.SelectedIndex = 3 Then
            cboRollCallClass.SelectedIndex = cboMarkManagement.SelectedIndex
            BindForStudentClass(cboMarkManagement)
        ElseIf tcTeacher.SelectedIndex = 2 Then
            BindForStudentClass(cboForStudentClass)
            lblSubject.Text = frmLogin.subjectname.Trim
        ElseIf tcTeacher.SelectedIndex = 1 Then
            BindForStudentClass(cboRollCallClass)
        End If

    End Sub

    Public Shared dgvCurrentRow As Integer
    Private Sub dgvMarkManagement_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMarkManagement.CellClick
        Try
            If e.ColumnIndex = 8 Then
                frmCheckMark.Show()
                dgvCurrentRow = dgvMarkManagement.CurrentRow.Index
                frmCheckMark.bindQuestion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picPrivateNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPrivateNote.Click
        frmPrivateNote.Show()
    End Sub

    Private Sub dgvMarkManagement_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMarkManagement.CellEndEdit
        modifyStudentAnswerMark()
        'modifyStudentMark()
    End Sub

    Private Sub dgvRollCall_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRollCall.CellEndEdit
        ModifyStudentGrade()
        ModifyStudentRollCall()
    End Sub
End Class

