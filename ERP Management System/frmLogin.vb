Imports System.Text.RegularExpressions

Public Class frmLogin

#Region "Variable Declaration"
    Dim m_student As New Modal.M_School
#End Region
    Public Shared currentUsername As String
    Public Shared currentPosition As String
    Public Shared classname As String
    Public Shared subjectname As String


    Public Function compareLoginData()
        Try
            Dim dtTable As New DataTable
            m_student.Username = txtUsername.Text.Trim
            m_student.email = txtUsername.Text.Trim
            m_student.Password = txtPassword.Text.Trim
            m_student.Position = cboLoginPosition.Text.Trim
            If m_student.Position = "student" Then
                dtTable = BusinessLogic.BL_Student.CheckLoginData(m_student.Username, m_student.email, m_student.Password, m_student.Position)
            ElseIf m_student.Position = "teacher" Then
                dtTable = BusinessLogic.BL_Teacher.CheckLoginData(m_student.Username, m_student.email, m_student.Password, m_student.Position)
            ElseIf m_student.Position = "parents" Then
                dtTable = BusinessLogic.BL_Parents.CheckLoginData(m_student.Username, m_student.email, m_student.Password, m_student.Position)
            ElseIf m_student.Position = "staff" Then
                dtTable = BusinessLogic.BL_Staff.CheckLoginData(m_student.Username, m_student.email, m_student.Password, m_student.Position)
            Else
                dtTable = BusinessLogic.BL_School.CheckLoginData(m_student.Username, m_student.email, m_student.Password, m_student.Position)
            End If

            If dtTable.Rows.Count > 0 Then
                currentUsername = txtUsername.Text
                currentPosition = cboLoginPosition.Text
                frmMainForm.lblCurrentUserName.Text = dtTable.Rows(0).Item("username").ToString()
                frmMainForm.lblCurrentPosition.Text = dtTable.Rows(0).Item("position").ToString()

                If cboLoginPosition.Text = "admin" Then
                    frmMainForm.pnlAdminUI.Visible = True
                    frmMainForm.pnlStudentInterFace.Visible = False
                    frmMainForm.pnlManagerInterface.Visible = False
                    frmMainForm.pnlTeacherInterface.Visible = False
                    frmMainForm.pnlParentsInterface.Visible = False
                    frmMainForm.pnlSoftwareUI.Visible = False
                    frmMainForm.pnlStaffInterface.Visible = False
                ElseIf cboLoginPosition.Text = "student" Then
                    frmMainForm.pnlAdminUI.Visible = False
                    frmMainForm.pnlStudentInterFace.Visible = True
                    frmMainForm.pnlManagerInterface.Visible = False
                    frmMainForm.pnlTeacherInterface.Visible = False
                    frmMainForm.pnlParentsInterface.Visible = False
                    frmMainForm.pnlSoftwareUI.Visible = False
                    frmMainForm.pnlStaffInterface.Visible = False
                    frmMainForm.lblStudentUsername.Text = dtTable.Rows(0).Item("username").ToString()
                    frmMainForm.lblStudentPhoneNumber.Text = dtTable.Rows(0).Item("phone").ToString()
                    frmMainForm.lblStudentRank.Text = dtTable.Rows(0).Item("grade").ToString()
                    frmMainForm.lblStudentClass.Text = dtTable.Rows(0).Item("class").ToString()
                    frmMainForm.BindStudentOverview()
                    frmMainForm.dudTutorial.SelectedIndex = 0
                    frmMainForm.dudAssignment.SelectedIndex = 0
                ElseIf cboLoginPosition.Text = "teacher" Then
                    frmMainForm.pnlAdminUI.Visible = False
                    frmMainForm.pnlStudentInterFace.Visible = False
                    frmMainForm.pnlManagerInterface.Visible = False
                    frmMainForm.pnlTeacherInterface.Visible = True
                    frmMainForm.pnlParentsInterface.Visible = False
                    frmMainForm.pnlSoftwareUI.Visible = False
                    frmMainForm.pnlStaffInterface.Visible = False
                    classname = dtTable.Rows(0).Item("class").ToString()
                    subjectname = dtTable.Rows(0).Item("subject").ToString()

                ElseIf cboLoginPosition.Text = "parents" Then
                    frmMainForm.pnlAdminUI.Visible = False
                    frmMainForm.pnlStudentInterFace.Visible = False
                    frmMainForm.pnlManagerInterface.Visible = False
                    frmMainForm.pnlTeacherInterface.Visible = False
                    frmMainForm.pnlParentsInterface.Visible = True
                    frmMainForm.pnlSoftwareUI.Visible = False
                    frmMainForm.pnlStaffInterface.Visible = False
                ElseIf cboLoginPosition.Text = "staff" Then
                    frmMainForm.pnlAdminUI.Visible = False
                    frmMainForm.pnlStudentInterFace.Visible = False
                    frmMainForm.pnlManagerInterface.Visible = False
                    frmMainForm.pnlTeacherInterface.Visible = False
                    frmMainForm.pnlParentsInterface.Visible = False
                    frmMainForm.pnlSoftwareUI.Visible = False
                    frmMainForm.pnlStaffInterface.Visible = True
                ElseIf cboLoginPosition.Text = "manager" Then
                    frmMainForm.pnlAdminUI.Visible = False
                    frmMainForm.pnlStudentInterFace.Visible = False
                    frmMainForm.pnlManagerInterface.Visible = True
                    frmMainForm.pnlTeacherInterface.Visible = False
                    frmMainForm.pnlParentsInterface.Visible = False
                    frmMainForm.pnlSoftwareUI.Visible = False
                    frmMainForm.pnlStaffInterface.Visible = False

                    frmMainForm.txtModify.Visible = False
                    frmMainForm.cboModifyPositionList.Visible = True
                    frmMainForm.BindModifyPosition()
                    frmMainForm.BindRemovePosition()
                    If frmMainForm.doOnce = True Then
                        'frmMainForm.btnChange_Click(,)
                        frmMainForm.doOnce = False
                    End If
                    frmMainForm.btnChange.Visible = False
                    frmMainForm.btnCancel.Visible = False
                    frmMainForm.btnCancelDelete.Visible = False
                    frmMainForm.btnAdd.Visible = False
                    frmMainForm.btnDelete.Visible = False
                End If
                Me.Hide()
                frmMainForm.Show()
                If chkKeepMeLogin.Checked = True Then
                    m_student.keepMeLogin = True
                Else
                    m_student.keepMeLogin = False
                End If
                BusinessLogic.BL_School.keepMeLogin_UpdateData(m_student)
            Else
                MessageBox.Show("Invalid username and password", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            ' if statement

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Public Function BindPosition()
        Try
            Dim dtTable As New DataTable
            dtTable = BusinessLogic.BL_School.ShowPositionData()
            If Not dtTable Is Nothing Then
                Dim row As DataRow = dtTable.NewRow()
                row("position") = "---Select One---"
                dtTable.Rows.InsertAt(row, 0)
                cboLoginPosition.DataSource = dtTable
                cboLoginPosition.DisplayMember = "position"
                cboLoginPosition.ValueMember = "id"

                cboRegisterPosition.DataSource = dtTable
                cboRegisterPosition.DisplayMember = "position"
                cboRegisterPosition.ValueMember = "id"

                frmNewUser.cboRegisterPosition.DataSource = dtTable
                frmNewUser.cboRegisterPosition.DisplayMember = "position"
                frmNewUser.cboRegisterPosition.ValueMember = "id"

                cboRegisterPosition.SelectedIndex = 1
                cboLoginPosition.SelectedIndex = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Public Function RequiredValidation() As Boolean
        Try
            If txtUsername.Text.Trim = "" Then
                lblUsername.Text = "Please enter a username"
                lblUsername.Visible = True
                Return False
            End If

            If txtPassword.Text.Trim = "" Then
                lblPassword.Text = "Please enter a password"
                lblPassword.Visible = True
                Return False
            End If

            If chkKeepMeLogin.Checked = True Then
                'MessageBox.Show("Please choose a gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If cboLoginPosition.SelectedIndex = 0 Then
                lblPosition.Text = "Please choose your position!"
                lblPosition.Visible = True
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function



    Public Function RequiredValidationForRegister() As Boolean
        Try
            If txtRegisterName.Text.Trim = "" Then
                lblRegisterUsername.Text = "Please enter a username"
                lblRegisterUsername.Visible = True
                Return False
            End If

            If txtRegisterPassword.Text.Trim.Length < 5 Then
                lblRegisterPassword.Text = "Weak Password"
                lblRegisterPassword.ForeColor = Color.Yellow
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = True
                Return False
            End If

            If txtRegisterPassword.Text.Trim = "" Then
                lblRegisterPassword.Text = "Please enter a password"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = True
                Return False
            End If

            If txtRegisterConfirmPassword.Text.Trim <> txtRegisterPassword.Text.Trim Then
                lblRegisterConfirmPassword.Text = "Invalid Confirm Password"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = True
                Return False
            End If

            If cboRegisterPosition.SelectedIndex = 0 Then
                lblRegisterPosition.Text = "Please choose your position!"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = True
                Return False
            End If

            If txtPhoneNumber.Text = "" Then
                lblPhoneNumber.Text = "Please add your real phone number"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = False
                lblPhoneNumber.Visible = True
                Return False
                'ElseIf 
            End If

            If txtEmail.Text = "" Then
                lblEmail.Text = "Please add your email"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = False
                lblPhoneNumber.Visible = False
                lblEmail.Visible = True
                Return False
            ElseIf validateEmail(txtEmail.Text.Trim) = False Then
                lblEmail.Text = "Please enter correct email"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = False
                lblPhoneNumber.Visible = False
                lblEmail.Visible = True
                Return False
            ElseIf txtFatherName.Text = "" Then
                lblFatherName.Text = "Please Father Name"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = False
                lblPhoneNumber.Visible = False
                lblFatherName.Visible = True
                Return False
            ElseIf txtMohterName.Text = "" Then
                lblMotherName.Text = "Please Mother Name"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = False
                lblPhoneNumber.Visible = False
                lblEmail.Visible = False
                lblFatherName.Visible = False
                lblMotherName.Visible = True
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function validateEmail(ByVal emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+)])*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ClearData()
        pnlLogin.Visible = True
        pnlNewUser.Visible = False
        txtRegisterName.Text = ""
        txtRegisterPassword.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        txtRegisterConfirmPassword.Text = ""
        chkShowPassword.Checked = False
        lblEmail.Visible = False
        cboLoginPosition.SelectedIndex = 0
    End Function

    Public Sub picLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogin.Click

        If RequiredValidation() = True Then
            'keepMeLogin_New()
            compareLoginData()
            frmMainForm.newPassword = txtPassword.Text.Trim
            frmMainForm.btnMyInterface.Text = "Home"
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindPosition()
        pnlLogin.Visible = True
        pnlNewUser.Visible = False
        txtUsername.Focus()
        'keepMeLogin()
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub picShowPassword0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShowPassword0.Click
        txtPassword.PasswordChar = "•"
        picShowPassword0.Visible = False
        picShowPassword1.Visible = True
    End Sub

    Private Sub picShowPassword1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShowPassword1.Click
        txtPassword.PasswordChar = ""
        picShowPassword1.Visible = False
        picShowPassword0.Visible = True
    End Sub

    Private Sub lblSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSignUp.Click
        pnlLogin.Visible = False
        pnlNewUser.Visible = True
        BindPosition()
        txtRegisterName.Focus()
        cboRegisterPosition.SelectedIndex = 0
    End Sub

    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtRegisterPassword.PasswordChar = ""
            txtRegisterConfirmPassword.PasswordChar = ""
        Else
            txtRegisterPassword.PasswordChar = "•"
            txtRegisterConfirmPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoneNumber.TextChanged
        If txtPhoneNumber.TextLength <> 0 Then
            If Char.IsNumber(txtPhoneNumber.Text.Chars(txtPhoneNumber.TextLength - 1)) <> True Then
                lblPhoneNumber.Text = "Enter Number Only"
                lblRegisterUsername.Visible = False
                lblRegisterPassword.Visible = False
                lblRegisterConfirmPassword.Visible = False
                lblRegisterPosition.Visible = False
                lblPhoneNumber.Visible = True
                txtPhoneNumber.Text = ""
            End If
        End If
    End Sub

    Private Sub picRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRegister.Click
        If RequiredValidationForRegister() = True Then
            Try
                If RequiredValidation() = True Then
                    m_student.Username = txtRegisterName.Text.Trim
                    m_student.Password = txtRegisterConfirmPassword.Text.Trim
                    m_student.phoneNumber = txtPhoneNumber.Text.Trim
                    m_student.Position = cboRegisterPosition.Text
                    m_student.email = txtEmail.Text.Trim
                    m_student.father = txtFatherName.Text.Trim
                    m_student.mother = txtMohterName.Text.Trim
                    m_student.nrc = txtnrc.Text.Trim
                    Dim success As Boolean
                    success = BusinessLogic.BL_Manager.Insert(m_student)
                    If success Then
                        MessageBox.Show("We would check your registeration form", "Think for your registeration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        ClearData()
                    Else
                        MessageBox.Show("Register Unsuccessful!")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub picCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.Click
        pnlLogin.Show()
        pnlNewUser.Hide()
        cboLoginPosition.SelectedIndex = 0
    End Sub

    Private Sub cboLoginPosition_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLoginPosition.KeyPress
        If Asc(e.KeyChar) = 13 Then
            picLogin_Click(sender, e)
        End If
    End Sub
End Class
