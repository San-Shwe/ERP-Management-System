Public Class frmPrivateNote

    Dim dtPositionCountTable As New DataTable
    Dim m_user As New Modal.M_School

    Public Function ShowCurrentUserNote(ByVal username As String, ByVal password As String, ByVal position As String)
        Try
            dtPositionCountTable = BusinessLogic.BL_School.ShowCurrentUserNote(username, password, position)
            richtxtPrivateNote.Text = dtPositionCountTable.Rows(0).Item("note").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ModifyNote()
        Try
            Dim successSave As Boolean
            m_user.Username = frmMainForm.lblCurrentUserName.Text.Trim
            m_user.Position = frmMainForm.lblCurrentPosition.Text.Trim
            m_user.Password = frmLogin.txtPassword.Text.ToString.Trim
            Dim text As String = richtxtPrivateNote.Text.ToString
            successSave = BusinessLogic.BL_School.ModifyNote(m_user, text)
            If successSave Then
                'MessageBox.Show("Change Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                'MessageBox.Show("Change Unsuccessful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub frmPrivateNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowCurrentUserNote(frmMainForm.lblCurrentUserName.Text.Trim, frmLogin.txtPassword.Text.Trim, frmMainForm.lblCurrentPosition.Text.Trim)
    End Sub

    Private Sub frmPrivateNote_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ModifyNote()
    End Sub
End Class