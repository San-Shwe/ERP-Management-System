Public Class frmCurrentUserProfile
    Dim m_student As New Modal.M_School

    Public Function ModifyUserDetails()
        Try
            If txtPhoneNo.Text.Trim <> "" And txtPassword.Text.Trim <> "" Then
                Dim successSave As Boolean
                m_student.Username = txtUsername.Text.Trim
                'm_student.Password = frmLogin.txtPassword.Text.Trim
                m_student.Password = txtPassword.Text.Trim
                m_student.Position = txtPosition.Text.Trim
                m_student.phoneNumber = txtPhoneNo.Text.Trim
                m_student.email = txtEmail.Text.Trim
                m_student.father = txtFatherName.Text.Trim
                m_student.mother = txtMotherName.Text.Trim
                m_student.nrc = txtNRCNo.Text.Trim
                successSave = BusinessLogic.BL_School.ChangeUserDetails(m_student)
                If successSave Then
                    MessageBox.Show("Change Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Change Unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub frmCurrentUserProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNewUserName_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.DoubleClick
        txtUsername.ReadOnly = False
    End Sub

    Private Sub frmCurrentUserProfile_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        frmMainForm.Show()
    End Sub



    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnCancel.Visible = False
        btnChangeUserDetails.Text = "Change Password"
        txtPassword.Enabled = False
        lblPassword.ForeColor = Color.White
    End Sub

    Private Sub btnChangeUserDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeUserDetails.Click
        If btnChangeUserDetails.Text = "Change Password" Then
            btnChangeUserDetails.Text = "OK"
            btnCancel.Visible = True
            txtPassword.Enabled = True
            lblPassword.ForeColor = Color.Green
        ElseIf btnChangeUserDetails.Text = "OK" Then
            frmLogin.txtPassword.Text = txtPassword.Text.ToString.Trim
            frmMainForm.password = txtPassword.Text.ToString.Trim
            btnChangeUserDetails.Text = "Change Password"
            txtPassword.Enabled = False
            btnCancel.Visible = False
            lblPassword.ForeColor = Color.White
            ModifyUserDetails()
        End If
    End Sub
End Class