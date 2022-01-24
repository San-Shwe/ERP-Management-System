Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmViewData


    Dim crParameterFieldDefinitons As ParameterFieldDefinitions
    Dim crParameterFieldDefiniton As ParameterFieldDefinition
    Dim crParameterValues As New ParameterValues
    Dim crParameterDiscreteValue As New ParameterDiscreteValue
    Dim cryRpt As New ReportDocument

    Public Sub Dynamic()
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        With crConnectionInfo
            .ServerName = "."
            .DatabaseName = "dbERPManagementProject"
            .UserID = "sa"
            .Password = "successful"
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
    End Sub

    Public Function BindPosition()
        Try
            'Dim dtTable As New DataTable
            'dtTable = BusinessLogic.BL_School.ShowPositionData()
            'If Not dtTable Is Nothing Then
            '    Dim row As DataRow = dtTable.NewRow()
            '    row("position") = "---Select One---"
            '    dtTable.Rows.InsertAt(row, 0)
            '    cboRegisterPosition.DataSource = dtTable
            '    cboRegisterPosition.DisplayMember = "position"
            '    cboRegisterPosition.ValueMember = "id"

            cboRegisterPosition.SelectedIndex = 0
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub frmViewData_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        frmMainForm.Show()
        frmMainForm.btnMyInterface.Text = "Home"
    End Sub

    Private Sub frmViewData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboRegisterPosition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegisterPosition.SelectedIndexChanged
        If cboRegisterPosition.SelectedIndex = 0 Then
            crtvStudent.ReportSource = Nothing
            crtvStudent.Refresh()
            Exit Sub
        ElseIf cboRegisterPosition.Text = "student" Then
            cryRpt.Load(Application.StartupPath & "\crtStudentClass.rpt")
            Dynamic()

            crtvStudent.ReportSource = cryRpt
            crtvStudent.Refresh()
        ElseIf cboRegisterPosition.Text = "teacher" Then
            cryRpt.Load(Application.StartupPath & "\crtTeacherClass.rpt")
            Dynamic()

            crtvStudent.ReportSource = cryRpt
            crtvStudent.Refresh()
        ElseIf cboRegisterPosition.Text = "parents" Then
            cryRpt.Load(Application.StartupPath & "\crtParentsClass.rpt")
            Dynamic()

            crtvStudent.ReportSource = cryRpt
            crtvStudent.Refresh()
        ElseIf cboRegisterPosition.Text = "staff" Then
            cryRpt.Load(Application.StartupPath & "\crtStaffClass.rpt")
            Dynamic()

            crtvStudent.ReportSource = cryRpt
            crtvStudent.Refresh()
        End If



        'cryRpt.Load(Application.StartupPath & "\crtStudentClass.rpt")
        'Dynamic()

        'crParameterDiscreteValue.Value = cboRegisterPosition.Text
        'crParameterFieldDefinitons = cryRpt.DataDefinition.ParameterFields
        'crParameterFieldDefiniton = crParameterFieldDefinitons.Item("position")
        'crParameterValues = crParameterFieldDefiniton.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefiniton.ApplyCurrentValues(crParameterValues)

        'crtvStudent.ReportSource = cryRpt
        'crtvStudent.Refresh()

    End Sub
End Class