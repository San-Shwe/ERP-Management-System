Public Class frmNewUser

    Dim m_student As New Modal.M_School


    Public Function addNewUsers()
        Try
            If RequiredValidation() = True Then
                m_student.Username = txtNewUserName.Text.Trim
                m_student.Password = txtNewUserPassword.Text.Trim
                m_student.phoneNumber = txtPhoneNo.Text.Trim
                m_student.Position = cboRegisterPosition.Text
                m_student.email = txtEmail.Text.Trim
                m_student.father = txtFatherName.Text.Trim
                m_student.mother = txtMotherName.Text.Trim
                m_student.nrc = txtNRCNo.Text.Trim
                Dim success As Boolean
                success = BusinessLogic.BL_School.InsertUsers(m_student)
                If success Then
                    DeleteRegisterData(m_student.email)
                    ShowRegisterDetails()
                Else
                    MessageBox.Show("Add Unsuccessful!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function clearData()
        txtNewUserName.Text = ""
        txtNewUserPassword.Text = ""
        cboRegisterPosition.SelectedIndex = 0
        txtPhoneNo.Text = ""
        txtMotherName.Text = ""
        txtFatherName.Text = ""
        txtEmail.Text = ""
        txtNRCNo.Text = ""
    End Function

    Public Function RequiredValidation() As Boolean
        Try
            If txtNewUserName.Text.Trim = "" Then
                MessageBox.Show("Please enter name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If txtNewUserPassword.Text.Trim = "" Then
                MessageBox.Show("Please enter password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If cboRegisterPosition.SelectedIndex = 0 Then
                MessageBox.Show("Please choose a position!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If txtEmail.Text = "" Then
                MessageBox.Show("Please enter email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If txtPhoneNo.Text = "" Then
                MessageBox.Show("Please enter phone number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If txtFatherName.Text = "" Then
                MessageBox.Show("Please enter father name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If txtMotherName.Text = "" Then
                MessageBox.Show("Please enter mother name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If txtNRCNo.Text = "" Then
                MessageBox.Show("Please enter NRC numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ShowRegisterDetails()
        Try
            dgvRegisterationList.DataSource = Nothing
            Dim dtTable As New DataTable
            dtTable = BusinessLogic.BL_Manager.ShowRegisterData()
            If dtTable.Rows.Count > 0 Then
                dgvRegisterationList.Rows.Clear()
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    dgvRegisterationList.Rows.Add()
                    dgvRegisterationList.Rows(i).Cells(0).Value = dtTable.Rows(i).Item("username").ToString()
                    dgvRegisterationList.Rows(i).Cells(1).Value = dtTable.Rows(i).Item("password").ToString()
                    dgvRegisterationList.Rows(i).Cells(2).Value = dtTable.Rows(i).Item("position").ToString()
                    dgvRegisterationList.Rows(i).Cells(3).Value = dtTable.Rows(i).Item("phone").ToString()
                    dgvRegisterationList.Rows(i).Cells(4).Value = dtTable.Rows(i).Item("father").ToString()
                    dgvRegisterationList.Rows(i).Cells(5).Value = dtTable.Rows(i).Item("mother").ToString()
                    dgvRegisterationList.Rows(i).Cells(6).Value = dtTable.Rows(i).Item("nrc").ToString()
                    dgvRegisterationList.Rows(i).Cells(7).Value = dtTable.Rows(i).Item("date").ToString()
                    dgvRegisterationList.Rows(i).Cells(8).Value = dtTable.Rows(i).Item("email").ToString()
                Next
            End If

            If dgvRegisterationList.Columns.Count < 10 Then
                Dim btn As New DataGridViewButtonColumn
                dgvRegisterationList.Columns.Add(btn)
                btn.HeaderText = "Delete Register"
                btn.Text = "Delete"
                btn.UseColumnTextForButtonValue = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function DeleteRegisterData(ByVal email As String)
        Try
            m_student.email = email
            Dim success As Boolean
            success = BusinessLogic.BL_Manager.deleteRegisterUser(m_student.email)
            If success Then
                clearData()
                ShowRegisterDetails()
            Else
                MessageBox.Show("Delete Unsuccessful!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub frmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.BindPosition()
        txtNewUserName.Focus()
        'cboRegisterPosition.SelectedIndex = 0
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        addNewUsers()
        'clearData()
    End Sub

    Private Sub frmNewUser_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        frmMainForm.Show()
        frmMainForm.btnMyInterface.Focus()
        frmLogin.cboLoginPosition.Text = frmMainForm.lblCurrentPosition.Text.Trim
        frmMainForm.btnMyInterface.Text = "Home"

    End Sub

    Private Sub dgvRegisterationList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegisterationList.DoubleClick
        Try
            If dgvRegisterationList.CurrentRow.Index <> -1 Then
                Dim i As Integer = dgvRegisterationList.CurrentRow.Index
                txtNewUserName.Text = dgvRegisterationList.Rows(i).Cells(0).Value.ToString
                txtNewUserPassword.Text = dgvRegisterationList.Rows(i).Cells(1).Value.ToString
                cboRegisterPosition.Text = dgvRegisterationList.Rows(i).Cells(2).Value.ToString
                txtPhoneNo.Text = dgvRegisterationList.Rows(i).Cells(3).Value.ToString
                txtFatherName.Text = dgvRegisterationList.Rows(i).Cells(4).Value.ToString
                txtMotherName.Text = dgvRegisterationList.Rows(i).Cells(5).Value.ToString
                txtNRCNo.Text = dgvRegisterationList.Rows(i).Cells(6).Value.ToString
                txtEmail.Text = dgvRegisterationList.Rows(i).Cells(8).Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clearData()
    End Sub

    Private Sub dgvRegisterationList_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRegisterationList.CellClick
        Try
            If e.ColumnIndex = 9 Then
                DialogResult = MessageBox.Show("Are You Sure Want To Delete This User Registeration Data", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If DialogResult = Windows.Forms.DialogResult.Yes Then
                    'Me.Hide()
                    'frmMainForm.btnAddNewUsers_Click(sender, e)
                    Dim i As Integer = dgvRegisterationList.CurrentRow.Index
                    DeleteRegisterData(dgvRegisterationList.Rows(i).Cells(8).Value.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class