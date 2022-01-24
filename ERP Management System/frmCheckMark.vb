Public Class frmCheckMark

    Public Function bindQuestion()
        Try
            Dim dtTable As New DataTable
            Dim type As String = frmMainForm.dgvMarkManagement.Rows(frmMainForm.dgvCurrentRow).Cells(5).Value
            Dim className As String = frmMainForm.dgvMarkManagement.Rows(frmMainForm.dgvCurrentRow).Cells(2).Value
            Dim subject As String = frmLogin.subjectname.Trim
            dtTable = BusinessLogic.BL_Teacher.ShowInstruction(type, className, subject)
            If dtTable.Rows.Count > 0 Then
                richtxtQuestion.Text = dtTable.Rows(0).Item("text").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub picNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picNextPage.Click
        picNextPage.Location = New Point(picNextPage.Location.X - 6, picNextPage.Location.Y)
        picNextPage.Size = New Size(32, 26)
        For i = 1 To 5
            Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next
        picNextPage.Location = New Point(picNextPage.Location.X + 6, picNextPage.Location.Y)
        picNextPage.Size = New Size(26, 26)
    End Sub

    Private Sub picHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHome.Click
        Me.Hide()
    End Sub

    Private Sub picPreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPreviousPage.Click
        picPreviousPage.Location = New Point(picPreviousPage.Location.X - 6, picPreviousPage.Location.Y)
        picPreviousPage.Size = New Size(32, 26)
        For i = 1 To 5
            Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next
        picPreviousPage.Location = New Point(picPreviousPage.Location.X + 6, picPreviousPage.Location.Y)
        picPreviousPage.Size = New Size(26, 26)
    End Sub

    Public Shared studentMark As Integer = 0
    Private Sub picMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMark.Click
        picMark.Size = New Size(picMark.Width + 12, picMark.Height + 12)
        For i = 1 To 5
            Threading.Thread.Sleep(20)
            Application.DoEvents()
        Next
        studentMark += 10
        picMark.Size = New Size(picMark.Width - 12, picMark.Height - 12)
    End Sub

    Private Sub picWrong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picWrong.Click
        picWrong.Size = New Size(picWrong.Width + 12, picWrong.Height + 12)
        For i = 1 To 5
            Threading.Thread.Sleep(20)
            Application.DoEvents()
        Next
        picWrong.Size = New Size(picWrong.Width - 12, picWrong.Height - 12)
    End Sub

    Private Sub picUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUndo.Click
        picUndo.Size = New Size(picUndo.Width + 12, picUndo.Height + 12)
        For i = 1 To 5
            Threading.Thread.Sleep(20)
            Application.DoEvents()
        Next
        picUndo.Size = New Size(picUndo.Width - 12, picUndo.Height - 12)
    End Sub

    Private Sub picDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDelete.Click
        picDelete.Size = New Size(picDelete.Width + 12, picDelete.Height + 12)
        For i = 1 To 5
            Threading.Thread.Sleep(20)
            Application.DoEvents()
        Next
        picDelete.Size = New Size(picDelete.Width - 12, picDelete.Height - 12)
    End Sub

    Private Sub picSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSave.Click
        picSave.Size = New Size(picSave.Width + 12, picSave.Height + 12)
        For i = 1 To 5
            Threading.Thread.Sleep(20)
            Application.DoEvents()
        Next
        picSave.Size = New Size(picSave.Width - 12, picSave.Height - 12)
    End Sub

    Private Sub frmCheckMark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bindQuestion()
        richtxtAnswers.Text = frmMainForm.dgvMarkManagement.Rows(frmMainForm.dgvCurrentRow).Cells(6).Value
    End Sub

    Private Sub btnFinishPaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishPaper.Click

    End Sub
End Class