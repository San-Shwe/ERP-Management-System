<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.lblTime = New System.Windows.Forms.Label
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblLogout = New System.Windows.Forms.Label
        Me.picCurrentUser = New System.Windows.Forms.PictureBox
        Me.lblCurrentUserName = New System.Windows.Forms.Label
        Me.lblCurrentPosition = New System.Windows.Forms.Label
        Me.pnlManagerInterface = New System.Windows.Forms.Panel
        Me.btnStudentData = New System.Windows.Forms.Button
        Me.btnAddNewUsers = New System.Windows.Forms.Button
        Me.lblManager = New System.Windows.Forms.Label
        Me.pnlStudentInterFace = New System.Windows.Forms.Panel
        Me.tcStudentInterface = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblStudentClass = New System.Windows.Forms.Label
        Me.lblStudentRank = New System.Windows.Forms.Label
        Me.lblStudentUsername = New System.Windows.Forms.Label
        Me.lblStudentPhoneNumber = New System.Windows.Forms.Label
        Me.dgvStudentOverview = New System.Windows.Forms.DataGridView
        Me.tpStudentTutorial = New System.Windows.Forms.TabPage
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.picMaximize = New System.Windows.Forms.PictureBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboStudentTutorialSubject = New System.Windows.Forms.ComboBox
        Me.lblType = New System.Windows.Forms.Label
        Me.lblTutorialSubject = New System.Windows.Forms.Label
        Me.lblTutorialTimeCounter = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.dudTutorial = New System.Windows.Forms.DomainUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.richTextAnswer = New System.Windows.Forms.RichTextBox
        Me.richtxtQuestion = New System.Windows.Forms.RichTextBox
        Me.btnSubmitTutorial = New System.Windows.Forms.Button
        Me.picStart = New System.Windows.Forms.PictureBox
        Me.picStop = New System.Windows.Forms.PictureBox
        Me.tpStudentAssignment = New System.Windows.Forms.TabPage
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboStudentAssignmentSubject = New System.Windows.Forms.ComboBox
        Me.lblAssignmentTimeCounter = New System.Windows.Forms.Label
        Me.lblAssignmentSubject = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dudAssignment = New System.Windows.Forms.DomainUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.richTxtAssignmentAnswer = New System.Windows.Forms.RichTextBox
        Me.richtxtAssignmentQuestion = New System.Windows.Forms.RichTextBox
        Me.btnAssignmentSend = New System.Windows.Forms.Button
        Me.picAssignmentStart = New System.Windows.Forms.PictureBox
        Me.picAssignmentStop = New System.Windows.Forms.PictureBox
        Me.tpStudentLab = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlParentsInterface = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblParentsInterface = New System.Windows.Forms.Label
        Me.pnlAdminUI = New System.Windows.Forms.Panel
        Me.gboModify = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnChange = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboModifyPositionList = New System.Windows.Forms.ComboBox
        Me.txtModify = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCancelDelete = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.cboRemovePositionList = New System.Windows.Forms.ComboBox
        Me.lblPositionList = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPositionName = New System.Windows.Forms.TextBox
        Me.lblStudentName1 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.pnlSoftwareUI = New System.Windows.Forms.Panel
        Me.richtxtNoteText = New System.Windows.Forms.RichTextBox
        Me.btnAddNote = New System.Windows.Forms.Button
        Me.lblNote = New System.Windows.Forms.Label
        Me.dgvTable = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.currentUsername = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlParents = New System.Windows.Forms.Panel
        Me.lblParent = New System.Windows.Forms.Label
        Me.lblParentsCount = New System.Windows.Forms.Label
        Me.lblParentNumber = New System.Windows.Forms.Label
        Me.pnlStaff = New System.Windows.Forms.Panel
        Me.lblStaffs = New System.Windows.Forms.Label
        Me.lblStaffsCount = New System.Windows.Forms.Label
        Me.lblStaffNumber = New System.Windows.Forms.Label
        Me.pnlTeacher = New System.Windows.Forms.Panel
        Me.lblTeachers = New System.Windows.Forms.Label
        Me.lblTeacherCounts = New System.Windows.Forms.Label
        Me.lblTeacherNumber = New System.Windows.Forms.Label
        Me.pnlStudent = New System.Windows.Forms.Panel
        Me.lblStudent = New System.Windows.Forms.Label
        Me.lblStudentAccount = New System.Windows.Forms.Label
        Me.lblStudentNumbers = New System.Windows.Forms.Label
        Me.btnMyInterface = New System.Windows.Forms.Button
        Me.pnlStaffInterface = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblStaffInterface = New System.Windows.Forms.Label
        Me.lblTeacherInterface = New System.Windows.Forms.Label
        Me.tcTeacher = New System.Windows.Forms.TabControl
        Me.tpTeacherOverview = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tpTeacherRollCallManagement = New System.Windows.Forms.TabPage
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboRollCallClass = New System.Windows.Forms.ComboBox
        Me.dgvRollCall = New System.Windows.Forms.DataGridView
        Me.identifier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.roll = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rollcallUsername = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rollcallPhone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rollcallName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpInstructionForStudent = New System.Windows.Forms.TabPage
        Me.lblSubject = New System.Windows.Forms.Label
        Me.lblSubjectLevel = New System.Windows.Forms.Label
        Me.dudAllowMinutes = New System.Windows.Forms.DomainUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dudNumber = New System.Windows.Forms.DomainUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnAttachFile = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.cboForStudentClass = New System.Windows.Forms.ComboBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.richtxtInstructionText = New System.Windows.Forms.RichTextBox
        Me.tpMarkManagement = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboMarkManagement = New System.Windows.Forms.ComboBox
        Me.dgvMarkManagement = New System.Windows.Forms.DataGridView
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.markUsername = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colClass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.markGrade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.markDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.markQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlTeacherInterface = New System.Windows.Forms.Panel
        Me.timerTutorial = New System.Windows.Forms.Timer(Me.components)
        Me.timerAssignment = New System.Windows.Forms.Timer(Me.components)
        Me.picPrivateNote = New System.Windows.Forms.PictureBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.picCurrentUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlManagerInterface.SuspendLayout()
        Me.pnlStudentInterFace.SuspendLayout()
        Me.tcStudentInterface.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvStudentOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpStudentTutorial.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpStudentAssignment.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAssignmentStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAssignmentStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParentsInterface.SuspendLayout()
        Me.pnlAdminUI.SuspendLayout()
        Me.gboModify.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlSoftwareUI.SuspendLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParents.SuspendLayout()
        Me.pnlStaff.SuspendLayout()
        Me.pnlTeacher.SuspendLayout()
        Me.pnlStudent.SuspendLayout()
        Me.pnlStaffInterface.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tcTeacher.SuspendLayout()
        Me.tpTeacherOverview.SuspendLayout()
        Me.tpTeacherRollCallManagement.SuspendLayout()
        CType(Me.dgvRollCall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInstructionForStudent.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tpMarkManagement.SuspendLayout()
        CType(Me.dgvMarkManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeacherInterface.SuspendLayout()
        CType(Me.picPrivateNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTime.Location = New System.Drawing.Point(654, 38)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(80, 25)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.Visible = False
        '
        'timerClock
        '
        Me.timerClock.Interval = 1000
        '
        'lblLogout
        '
        Me.lblLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogout.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLogout.Location = New System.Drawing.Point(1280, 9)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(58, 21)
        Me.lblLogout.TabIndex = 33
        Me.lblLogout.Text = "Logout"
        '
        'picCurrentUser
        '
        Me.picCurrentUser.BackColor = System.Drawing.Color.Transparent
        Me.picCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCurrentUser.Image = CType(resources.GetObject("picCurrentUser.Image"), System.Drawing.Image)
        Me.picCurrentUser.Location = New System.Drawing.Point(18, 30)
        Me.picCurrentUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCurrentUser.Name = "picCurrentUser"
        Me.picCurrentUser.Size = New System.Drawing.Size(45, 45)
        Me.picCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCurrentUser.TabIndex = 38
        Me.picCurrentUser.TabStop = False
        '
        'lblCurrentUserName
        '
        Me.lblCurrentUserName.AutoSize = True
        Me.lblCurrentUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentUserName.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUserName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurrentUserName.Location = New System.Drawing.Point(68, 32)
        Me.lblCurrentUserName.Name = "lblCurrentUserName"
        Me.lblCurrentUserName.Size = New System.Drawing.Size(47, 25)
        Me.lblCurrentUserName.TabIndex = 39
        Me.lblCurrentUserName.Text = "User"
        '
        'lblCurrentPosition
        '
        Me.lblCurrentPosition.AutoSize = True
        Me.lblCurrentPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPosition.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrentPosition.Location = New System.Drawing.Point(72, 57)
        Me.lblCurrentPosition.Name = "lblCurrentPosition"
        Me.lblCurrentPosition.Size = New System.Drawing.Size(77, 17)
        Me.lblCurrentPosition.TabIndex = 40
        Me.lblCurrentPosition.Text = "non-position"
        '
        'pnlManagerInterface
        '
        Me.pnlManagerInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlManagerInterface.BackColor = System.Drawing.Color.Silver
        Me.pnlManagerInterface.Controls.Add(Me.btnStudentData)
        Me.pnlManagerInterface.Controls.Add(Me.btnAddNewUsers)
        Me.pnlManagerInterface.Controls.Add(Me.lblManager)
        Me.pnlManagerInterface.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlManagerInterface.Location = New System.Drawing.Point(23, 124)
        Me.pnlManagerInterface.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlManagerInterface.Name = "pnlManagerInterface"
        Me.pnlManagerInterface.Size = New System.Drawing.Size(1331, 545)
        Me.pnlManagerInterface.TabIndex = 41
        '
        'btnStudentData
        '
        Me.btnStudentData.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentData.Location = New System.Drawing.Point(1039, 93)
        Me.btnStudentData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStudentData.Name = "btnStudentData"
        Me.btnStudentData.Size = New System.Drawing.Size(167, 36)
        Me.btnStudentData.TabIndex = 2
        Me.btnStudentData.Text = "View Reports"
        Me.btnStudentData.UseVisualStyleBackColor = True
        '
        'btnAddNewUsers
        '
        Me.btnAddNewUsers.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewUsers.Location = New System.Drawing.Point(1039, 40)
        Me.btnAddNewUsers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNewUsers.Name = "btnAddNewUsers"
        Me.btnAddNewUsers.Size = New System.Drawing.Size(167, 36)
        Me.btnAddNewUsers.TabIndex = 1
        Me.btnAddNewUsers.Text = "Add New Users"
        Me.btnAddNewUsers.UseVisualStyleBackColor = True
        '
        'lblManager
        '
        Me.lblManager.AutoSize = True
        Me.lblManager.ForeColor = System.Drawing.Color.Red
        Me.lblManager.Location = New System.Drawing.Point(25, 17)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(108, 17)
        Me.lblManager.TabIndex = 0
        Me.lblManager.Text = "Manager Interface"
        '
        'pnlStudentInterFace
        '
        Me.pnlStudentInterFace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStudentInterFace.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnlStudentInterFace.Controls.Add(Me.tcStudentInterface)
        Me.pnlStudentInterFace.Controls.Add(Me.Label1)
        Me.pnlStudentInterFace.Location = New System.Drawing.Point(41, 106)
        Me.pnlStudentInterFace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlStudentInterFace.Name = "pnlStudentInterFace"
        Me.pnlStudentInterFace.Size = New System.Drawing.Size(1301, 582)
        Me.pnlStudentInterFace.TabIndex = 42
        '
        'tcStudentInterface
        '
        Me.tcStudentInterface.Controls.Add(Me.tpStudentTutorial)
        Me.tcStudentInterface.Controls.Add(Me.tpStudentAssignment)
        Me.tcStudentInterface.Controls.Add(Me.tpStudentLab)
        Me.tcStudentInterface.Controls.Add(Me.TabPage1)
        Me.tcStudentInterface.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcStudentInterface.Location = New System.Drawing.Point(32, 71)
        Me.tcStudentInterface.Name = "tcStudentInterface"
        Me.tcStudentInterface.SelectedIndex = 0
        Me.tcStudentInterface.Size = New System.Drawing.Size(1265, 500)
        Me.tcStudentInterface.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblStudentClass)
        Me.TabPage1.Controls.Add(Me.lblStudentRank)
        Me.TabPage1.Controls.Add(Me.lblStudentUsername)
        Me.TabPage1.Controls.Add(Me.lblStudentPhoneNumber)
        Me.TabPage1.Controls.Add(Me.dgvStudentOverview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1257, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Overview"
        '
        'lblStudentClass
        '
        Me.lblStudentClass.AutoSize = True
        Me.lblStudentClass.Location = New System.Drawing.Point(51, 136)
        Me.lblStudentClass.Name = "lblStudentClass"
        Me.lblStudentClass.Size = New System.Drawing.Size(26, 20)
        Me.lblStudentClass.TabIndex = 4
        Me.lblStudentClass.Text = "5A"
        '
        'lblStudentRank
        '
        Me.lblStudentRank.AutoSize = True
        Me.lblStudentRank.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStudentRank.Location = New System.Drawing.Point(51, 105)
        Me.lblStudentRank.Name = "lblStudentRank"
        Me.lblStudentRank.Size = New System.Drawing.Size(17, 20)
        Me.lblStudentRank.TabIndex = 3
        Me.lblStudentRank.Text = "4"
        '
        'lblStudentUsername
        '
        Me.lblStudentUsername.AutoSize = True
        Me.lblStudentUsername.Location = New System.Drawing.Point(51, 39)
        Me.lblStudentUsername.Name = "lblStudentUsername"
        Me.lblStudentUsername.Size = New System.Drawing.Size(68, 20)
        Me.lblStudentUsername.TabIndex = 2
        Me.lblStudentUsername.Text = "San Shwe"
        '
        'lblStudentPhoneNumber
        '
        Me.lblStudentPhoneNumber.AutoSize = True
        Me.lblStudentPhoneNumber.Location = New System.Drawing.Point(51, 73)
        Me.lblStudentPhoneNumber.Name = "lblStudentPhoneNumber"
        Me.lblStudentPhoneNumber.Size = New System.Drawing.Size(94, 20)
        Me.lblStudentPhoneNumber.TabIndex = 2
        Me.lblStudentPhoneNumber.Text = "09456691306"
        '
        'dgvStudentOverview
        '
        Me.dgvStudentOverview.AllowUserToAddRows = False
        Me.dgvStudentOverview.AllowUserToDeleteRows = False
        Me.dgvStudentOverview.AllowUserToResizeColumns = False
        Me.dgvStudentOverview.AllowUserToResizeRows = False
        Me.dgvStudentOverview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudentOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudentOverview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStudentOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentOverview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Grade})
        Me.dgvStudentOverview.Location = New System.Drawing.Point(23, 193)
        Me.dgvStudentOverview.MultiSelect = False
        Me.dgvStudentOverview.Name = "dgvStudentOverview"
        Me.dgvStudentOverview.ReadOnly = True
        Me.dgvStudentOverview.RowHeadersVisible = False
        Me.dgvStudentOverview.Size = New System.Drawing.Size(1210, 252)
        Me.dgvStudentOverview.TabIndex = 1
        '
        'tpStudentTutorial
        '
        Me.tpStudentTutorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tpStudentTutorial.Controls.Add(Me.PictureBox3)
        Me.tpStudentTutorial.Controls.Add(Me.picMaximize)
        Me.tpStudentTutorial.Controls.Add(Me.Label14)
        Me.tpStudentTutorial.Controls.Add(Me.cboStudentTutorialSubject)
        Me.tpStudentTutorial.Controls.Add(Me.lblType)
        Me.tpStudentTutorial.Controls.Add(Me.lblTutorialSubject)
        Me.tpStudentTutorial.Controls.Add(Me.lblTutorialTimeCounter)
        Me.tpStudentTutorial.Controls.Add(Me.PictureBox2)
        Me.tpStudentTutorial.Controls.Add(Me.dudTutorial)
        Me.tpStudentTutorial.Controls.Add(Me.Label7)
        Me.tpStudentTutorial.Controls.Add(Me.Label6)
        Me.tpStudentTutorial.Controls.Add(Me.richTextAnswer)
        Me.tpStudentTutorial.Controls.Add(Me.richtxtQuestion)
        Me.tpStudentTutorial.Controls.Add(Me.btnSubmitTutorial)
        Me.tpStudentTutorial.Controls.Add(Me.picStart)
        Me.tpStudentTutorial.Controls.Add(Me.picStop)
        Me.tpStudentTutorial.Location = New System.Drawing.Point(4, 29)
        Me.tpStudentTutorial.Name = "tpStudentTutorial"
        Me.tpStudentTutorial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStudentTutorial.Size = New System.Drawing.Size(1257, 467)
        Me.tpStudentTutorial.TabIndex = 1
        Me.tpStudentTutorial.Text = "Tutorial"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1186, 7)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'picMaximize
        '
        Me.picMaximize.BackColor = System.Drawing.Color.Transparent
        Me.picMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMaximize.Image = CType(resources.GetObject("picMaximize.Image"), System.Drawing.Image)
        Me.picMaximize.Location = New System.Drawing.Point(1224, 6)
        Me.picMaximize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(27, 25)
        Me.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMaximize.TabIndex = 83
        Me.picMaximize.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(975, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 30)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Step 1: first choose subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Step 2: choose type of your task"
        '
        'cboStudentTutorialSubject
        '
        Me.cboStudentTutorialSubject.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentTutorialSubject.FormattingEnabled = True
        Me.cboStudentTutorialSubject.Items.AddRange(New Object() {"DBMS", "Data Structure", "Network" & Global.Microsoft.VisualBasic.ChrW(9), "php" & Global.Microsoft.VisualBasic.ChrW(9), "English ", "Math", "Java"})
        Me.cboStudentTutorialSubject.Location = New System.Drawing.Point(637, 125)
        Me.cboStudentTutorialSubject.Name = "cboStudentTutorialSubject"
        Me.cboStudentTutorialSubject.Size = New System.Drawing.Size(131, 25)
        Me.cboStudentTutorialSubject.TabIndex = 7
        Me.cboStudentTutorialSubject.Text = "--- Select One ---"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblType.Location = New System.Drawing.Point(934, 127)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(46, 20)
        Me.lblType.TabIndex = 83
        Me.lblType.Text = "Type :"
        '
        'lblTutorialSubject
        '
        Me.lblTutorialSubject.AutoSize = True
        Me.lblTutorialSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblTutorialSubject.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutorialSubject.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTutorialSubject.Location = New System.Drawing.Point(565, 127)
        Me.lblTutorialSubject.Name = "lblTutorialSubject"
        Me.lblTutorialSubject.Size = New System.Drawing.Size(61, 20)
        Me.lblTutorialSubject.TabIndex = 82
        Me.lblTutorialSubject.Text = "Subject :"
        '
        'lblTutorialTimeCounter
        '
        Me.lblTutorialTimeCounter.AutoSize = True
        Me.lblTutorialTimeCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblTutorialTimeCounter.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutorialTimeCounter.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTutorialTimeCounter.Location = New System.Drawing.Point(101, 414)
        Me.lblTutorialTimeCounter.Name = "lblTutorialTimeCounter"
        Me.lblTutorialTimeCounter.Size = New System.Drawing.Size(56, 25)
        Me.lblTutorialTimeCounter.TabIndex = 81
        Me.lblTutorialTimeCounter.Text = "00:00"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1144, 292)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'dudTutorial
        '
        Me.dudTutorial.Items.Add("Tutorial1")
        Me.dudTutorial.Items.Add("Tutorial2")
        Me.dudTutorial.Items.Add("Tutorial3")
        Me.dudTutorial.Items.Add("Tutorial4")
        Me.dudTutorial.Items.Add("Tutorial5")
        Me.dudTutorial.Items.Add("Tutorial6")
        Me.dudTutorial.Location = New System.Drawing.Point(986, 125)
        Me.dudTutorial.Name = "dudTutorial"
        Me.dudTutorial.ReadOnly = True
        Me.dudTutorial.Size = New System.Drawing.Size(153, 27)
        Me.dudTutorial.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Question:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Write the answere here:"
        '
        'richTextAnswer
        '
        Me.richTextAnswer.Location = New System.Drawing.Point(9, 159)
        Me.richTextAnswer.Name = "richTextAnswer"
        Me.richTextAnswer.Size = New System.Drawing.Size(1129, 231)
        Me.richTextAnswer.TabIndex = 6
        Me.richTextAnswer.Text = ""
        '
        'richtxtQuestion
        '
        Me.richtxtQuestion.Location = New System.Drawing.Point(9, 34)
        Me.richtxtQuestion.Name = "richtxtQuestion"
        Me.richtxtQuestion.ReadOnly = True
        Me.richtxtQuestion.Size = New System.Drawing.Size(1129, 81)
        Me.richtxtQuestion.TabIndex = 5
        Me.richtxtQuestion.Text = ""
        '
        'btnSubmitTutorial
        '
        Me.btnSubmitTutorial.Image = CType(resources.GetObject("btnSubmitTutorial.Image"), System.Drawing.Image)
        Me.btnSubmitTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmitTutorial.Location = New System.Drawing.Point(1026, 425)
        Me.btnSubmitTutorial.Name = "btnSubmitTutorial"
        Me.btnSubmitTutorial.Size = New System.Drawing.Size(113, 31)
        Me.btnSubmitTutorial.TabIndex = 4
        Me.btnSubmitTutorial.Text = "Send"
        Me.btnSubmitTutorial.UseVisualStyleBackColor = True
        '
        'picStart
        '
        Me.picStart.BackColor = System.Drawing.Color.Transparent
        Me.picStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStart.Image = CType(resources.GetObject("picStart.Image"), System.Drawing.Image)
        Me.picStart.Location = New System.Drawing.Point(31, 403)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(53, 50)
        Me.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStart.TabIndex = 10
        Me.picStart.TabStop = False
        '
        'picStop
        '
        Me.picStop.BackColor = System.Drawing.Color.Transparent
        Me.picStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStop.Image = CType(resources.GetObject("picStop.Image"), System.Drawing.Image)
        Me.picStop.Location = New System.Drawing.Point(31, 403)
        Me.picStop.Name = "picStop"
        Me.picStop.Size = New System.Drawing.Size(53, 50)
        Me.picStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStop.TabIndex = 9
        Me.picStop.TabStop = False
        '
        'tpStudentAssignment
        '
        Me.tpStudentAssignment.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tpStudentAssignment.Controls.Add(Me.PictureBox4)
        Me.tpStudentAssignment.Controls.Add(Me.PictureBox5)
        Me.tpStudentAssignment.Controls.Add(Me.Label13)
        Me.tpStudentAssignment.Controls.Add(Me.cboStudentAssignmentSubject)
        Me.tpStudentAssignment.Controls.Add(Me.lblAssignmentTimeCounter)
        Me.tpStudentAssignment.Controls.Add(Me.lblAssignmentSubject)
        Me.tpStudentAssignment.Controls.Add(Me.PictureBox1)
        Me.tpStudentAssignment.Controls.Add(Me.dudAssignment)
        Me.tpStudentAssignment.Controls.Add(Me.Label9)
        Me.tpStudentAssignment.Controls.Add(Me.Label10)
        Me.tpStudentAssignment.Controls.Add(Me.richTxtAssignmentAnswer)
        Me.tpStudentAssignment.Controls.Add(Me.richtxtAssignmentQuestion)
        Me.tpStudentAssignment.Controls.Add(Me.btnAssignmentSend)
        Me.tpStudentAssignment.Controls.Add(Me.picAssignmentStart)
        Me.tpStudentAssignment.Controls.Add(Me.picAssignmentStop)
        Me.tpStudentAssignment.Location = New System.Drawing.Point(4, 29)
        Me.tpStudentAssignment.Name = "tpStudentAssignment"
        Me.tpStudentAssignment.Size = New System.Drawing.Size(1257, 467)
        Me.tpStudentAssignment.TabIndex = 2
        Me.tpStudentAssignment.Text = "Assignment"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1183, 8)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 87
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1221, 7)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 86
        Me.PictureBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label13.Location = New System.Drawing.Point(918, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 20)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Type :"
        '
        'cboStudentAssignmentSubject
        '
        Me.cboStudentAssignmentSubject.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentAssignmentSubject.FormattingEnabled = True
        Me.cboStudentAssignmentSubject.Items.AddRange(New Object() {"DBMS", "Data Structure", "Network" & Global.Microsoft.VisualBasic.ChrW(9), "php" & Global.Microsoft.VisualBasic.ChrW(9), "English ", "Math", "Java"})
        Me.cboStudentAssignmentSubject.Location = New System.Drawing.Point(628, 126)
        Me.cboStudentAssignmentSubject.Name = "cboStudentAssignmentSubject"
        Me.cboStudentAssignmentSubject.Size = New System.Drawing.Size(131, 25)
        Me.cboStudentAssignmentSubject.TabIndex = 83
        Me.cboStudentAssignmentSubject.Text = "--- Select One ---"
        '
        'lblAssignmentTimeCounter
        '
        Me.lblAssignmentTimeCounter.AutoSize = True
        Me.lblAssignmentTimeCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignmentTimeCounter.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentTimeCounter.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAssignmentTimeCounter.Location = New System.Drawing.Point(101, 414)
        Me.lblAssignmentTimeCounter.Name = "lblAssignmentTimeCounter"
        Me.lblAssignmentTimeCounter.Size = New System.Drawing.Size(56, 25)
        Me.lblAssignmentTimeCounter.TabIndex = 90
        Me.lblAssignmentTimeCounter.Text = "00:00"
        '
        'lblAssignmentSubject
        '
        Me.lblAssignmentSubject.AutoSize = True
        Me.lblAssignmentSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignmentSubject.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentSubject.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAssignmentSubject.Location = New System.Drawing.Point(556, 128)
        Me.lblAssignmentSubject.Name = "lblAssignmentSubject"
        Me.lblAssignmentSubject.Size = New System.Drawing.Size(61, 20)
        Me.lblAssignmentSubject.TabIndex = 84
        Me.lblAssignmentSubject.Text = "Subject :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1144, 295)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'dudAssignment
        '
        Me.dudAssignment.Items.Add("Assignment1")
        Me.dudAssignment.Items.Add("Assignment2")
        Me.dudAssignment.Items.Add("Assignment3")
        Me.dudAssignment.Items.Add("Assignment4" & Global.Microsoft.VisualBasic.ChrW(9))
        Me.dudAssignment.Items.Add("Assignment5")
        Me.dudAssignment.Location = New System.Drawing.Point(985, 125)
        Me.dudAssignment.Name = "dudAssignment"
        Me.dudAssignment.ReadOnly = True
        Me.dudAssignment.Size = New System.Drawing.Size(153, 27)
        Me.dudAssignment.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Question:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 20)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Write the answere here:"
        '
        'richTxtAssignmentAnswer
        '
        Me.richTxtAssignmentAnswer.Location = New System.Drawing.Point(9, 159)
        Me.richTxtAssignmentAnswer.Name = "richTxtAssignmentAnswer"
        Me.richTxtAssignmentAnswer.ReadOnly = True
        Me.richTxtAssignmentAnswer.Size = New System.Drawing.Size(1129, 231)
        Me.richTxtAssignmentAnswer.TabIndex = 86
        Me.richTxtAssignmentAnswer.Text = ""
        '
        'richtxtAssignmentQuestion
        '
        Me.richtxtAssignmentQuestion.Location = New System.Drawing.Point(9, 34)
        Me.richtxtAssignmentQuestion.Name = "richtxtAssignmentQuestion"
        Me.richtxtAssignmentQuestion.ReadOnly = True
        Me.richtxtAssignmentQuestion.Size = New System.Drawing.Size(1129, 81)
        Me.richtxtAssignmentQuestion.TabIndex = 85
        Me.richtxtAssignmentQuestion.Text = ""
        '
        'btnAssignmentSend
        '
        Me.btnAssignmentSend.Image = CType(resources.GetObject("btnAssignmentSend.Image"), System.Drawing.Image)
        Me.btnAssignmentSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAssignmentSend.Location = New System.Drawing.Point(1030, 414)
        Me.btnAssignmentSend.Name = "btnAssignmentSend"
        Me.btnAssignmentSend.Size = New System.Drawing.Size(113, 31)
        Me.btnAssignmentSend.TabIndex = 84
        Me.btnAssignmentSend.Text = "    Send       "
        Me.btnAssignmentSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAssignmentSend.UseVisualStyleBackColor = True
        '
        'picAssignmentStart
        '
        Me.picAssignmentStart.BackColor = System.Drawing.Color.Transparent
        Me.picAssignmentStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAssignmentStart.Image = CType(resources.GetObject("picAssignmentStart.Image"), System.Drawing.Image)
        Me.picAssignmentStart.Location = New System.Drawing.Point(31, 403)
        Me.picAssignmentStart.Name = "picAssignmentStart"
        Me.picAssignmentStart.Size = New System.Drawing.Size(53, 50)
        Me.picAssignmentStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAssignmentStart.TabIndex = 11
        Me.picAssignmentStart.TabStop = False
        '
        'picAssignmentStop
        '
        Me.picAssignmentStop.BackColor = System.Drawing.Color.Transparent
        Me.picAssignmentStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAssignmentStop.Image = CType(resources.GetObject("picAssignmentStop.Image"), System.Drawing.Image)
        Me.picAssignmentStop.Location = New System.Drawing.Point(31, 403)
        Me.picAssignmentStop.Name = "picAssignmentStop"
        Me.picAssignmentStop.Size = New System.Drawing.Size(53, 50)
        Me.picAssignmentStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAssignmentStop.TabIndex = 89
        Me.picAssignmentStop.TabStop = False
        '
        'tpStudentLab
        '
        Me.tpStudentLab.BackColor = System.Drawing.Color.Orange
        Me.tpStudentLab.Location = New System.Drawing.Point(4, 29)
        Me.tpStudentLab.Name = "tpStudentLab"
        Me.tpStudentLab.Size = New System.Drawing.Size(1257, 467)
        Me.tpStudentLab.TabIndex = 3
        Me.tpStudentLab.Text = "Lab"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Interface"
        '
        'pnlParentsInterface
        '
        Me.pnlParentsInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlParentsInterface.BackColor = System.Drawing.Color.HotPink
        Me.pnlParentsInterface.Controls.Add(Me.Panel3)
        Me.pnlParentsInterface.Controls.Add(Me.Panel2)
        Me.pnlParentsInterface.Controls.Add(Me.Panel1)
        Me.pnlParentsInterface.Controls.Add(Me.lblParentsInterface)
        Me.pnlParentsInterface.Location = New System.Drawing.Point(2, 147)
        Me.pnlParentsInterface.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlParentsInterface.Name = "pnlParentsInterface"
        Me.pnlParentsInterface.Size = New System.Drawing.Size(1352, 582)
        Me.pnlParentsInterface.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Plum
        Me.Panel3.Location = New System.Drawing.Point(903, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(355, 388)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Plum
        Me.Panel2.Location = New System.Drawing.Point(491, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 388)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Plum
        Me.Panel1.Location = New System.Drawing.Point(81, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 388)
        Me.Panel1.TabIndex = 1
        '
        'lblParentsInterface
        '
        Me.lblParentsInterface.AutoSize = True
        Me.lblParentsInterface.Location = New System.Drawing.Point(24, 22)
        Me.lblParentsInterface.Name = "lblParentsInterface"
        Me.lblParentsInterface.Size = New System.Drawing.Size(143, 25)
        Me.lblParentsInterface.TabIndex = 0
        Me.lblParentsInterface.Text = "Parents Interface"
        '
        'pnlAdminUI
        '
        Me.pnlAdminUI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAdminUI.BackColor = System.Drawing.Color.DarkGray
        Me.pnlAdminUI.Controls.Add(Me.gboModify)
        Me.pnlAdminUI.Controls.Add(Me.GroupBox2)
        Me.pnlAdminUI.Controls.Add(Me.GroupBox1)
        Me.pnlAdminUI.Location = New System.Drawing.Point(31, 115)
        Me.pnlAdminUI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlAdminUI.Name = "pnlAdminUI"
        Me.pnlAdminUI.Size = New System.Drawing.Size(1316, 631)
        Me.pnlAdminUI.TabIndex = 38
        '
        'gboModify
        '
        Me.gboModify.Controls.Add(Me.btnCancel)
        Me.gboModify.Controls.Add(Me.btnChange)
        Me.gboModify.Controls.Add(Me.Label2)
        Me.gboModify.Controls.Add(Me.cboModifyPositionList)
        Me.gboModify.Controls.Add(Me.txtModify)
        Me.gboModify.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboModify.Location = New System.Drawing.Point(63, 255)
        Me.gboModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gboModify.Name = "gboModify"
        Me.gboModify.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gboModify.Size = New System.Drawing.Size(357, 160)
        Me.gboModify.TabIndex = 43
        Me.gboModify.TabStop = False
        Me.gboModify.Text = "Modify"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(243, 113)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 29)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(147, 113)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(92, 29)
        Me.btnChange.TabIndex = 40
        Me.btnChange.Text = "Ok"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Position List :"
        '
        'cboModifyPositionList
        '
        Me.cboModifyPositionList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboModifyPositionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModifyPositionList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModifyPositionList.FormattingEnabled = True
        Me.cboModifyPositionList.Location = New System.Drawing.Point(147, 39)
        Me.cboModifyPositionList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModifyPositionList.Name = "cboModifyPositionList"
        Me.cboModifyPositionList.Size = New System.Drawing.Size(191, 25)
        Me.cboModifyPositionList.TabIndex = 39
        Me.cboModifyPositionList.Visible = False
        '
        'txtModify
        '
        Me.txtModify.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModify.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModify.Location = New System.Drawing.Point(157, 40)
        Me.txtModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtModify.Name = "txtModify"
        Me.txtModify.Size = New System.Drawing.Size(149, 25)
        Me.txtModify.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelDelete)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.cboRemovePositionList)
        Me.GroupBox2.Controls.Add(Me.lblPositionList)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(438, 63)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(367, 160)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remove"
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.Location = New System.Drawing.Point(257, 112)
        Me.btnCancelDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(92, 29)
        Me.btnCancelDelete.TabIndex = 41
        Me.btnCancelDelete.Text = "Cancel"
        Me.btnCancelDelete.UseVisualStyleBackColor = True
        Me.btnCancelDelete.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(145, 112)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 29)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'cboRemovePositionList
        '
        Me.cboRemovePositionList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboRemovePositionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemovePositionList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemovePositionList.FormattingEnabled = True
        Me.cboRemovePositionList.Location = New System.Drawing.Point(145, 38)
        Me.cboRemovePositionList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRemovePositionList.Name = "cboRemovePositionList"
        Me.cboRemovePositionList.Size = New System.Drawing.Size(202, 25)
        Me.cboRemovePositionList.TabIndex = 39
        '
        'lblPositionList
        '
        Me.lblPositionList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPositionList.AutoSize = True
        Me.lblPositionList.Location = New System.Drawing.Point(30, 40)
        Me.lblPositionList.Name = "lblPositionList"
        Me.lblPositionList.Size = New System.Drawing.Size(87, 20)
        Me.lblPositionList.TabIndex = 38
        Me.lblPositionList.Text = "Position List :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPositionName)
        Me.GroupBox1.Controls.Add(Me.lblStudentName1)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 160)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add"
        '
        'txtPositionName
        '
        Me.txtPositionName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPositionName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositionName.Location = New System.Drawing.Point(147, 38)
        Me.txtPositionName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPositionName.Name = "txtPositionName"
        Me.txtPositionName.Size = New System.Drawing.Size(191, 25)
        Me.txtPositionName.TabIndex = 4
        '
        'lblStudentName1
        '
        Me.lblStudentName1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStudentName1.AutoSize = True
        Me.lblStudentName1.Location = New System.Drawing.Point(17, 40)
        Me.lblStudentName1.Name = "lblStudentName1"
        Me.lblStudentName1.Size = New System.Drawing.Size(105, 20)
        Me.lblStudentName1.TabIndex = 0
        Me.lblStudentName1.Text = "Position Name :"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(188, 112)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(148, 29)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlSoftwareUI
        '
        Me.pnlSoftwareUI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSoftwareUI.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlSoftwareUI.Controls.Add(Me.richtxtNoteText)
        Me.pnlSoftwareUI.Controls.Add(Me.btnAddNote)
        Me.pnlSoftwareUI.Controls.Add(Me.lblNote)
        Me.pnlSoftwareUI.Controls.Add(Me.dgvTable)
        Me.pnlSoftwareUI.Controls.Add(Me.pnlParents)
        Me.pnlSoftwareUI.Controls.Add(Me.pnlStaff)
        Me.pnlSoftwareUI.Controls.Add(Me.pnlTeacher)
        Me.pnlSoftwareUI.Controls.Add(Me.pnlStudent)
        Me.pnlSoftwareUI.Font = New System.Drawing.Font("Pyidaungsu", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSoftwareUI.Location = New System.Drawing.Point(10, 88)
        Me.pnlSoftwareUI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSoftwareUI.Name = "pnlSoftwareUI"
        Me.pnlSoftwareUI.Size = New System.Drawing.Size(1331, 899)
        Me.pnlSoftwareUI.TabIndex = 43
        '
        'richtxtNoteText
        '
        Me.richtxtNoteText.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.richtxtNoteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richtxtNoteText.Location = New System.Drawing.Point(224, 511)
        Me.richtxtNoteText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.richtxtNoteText.Name = "richtxtNoteText"
        Me.richtxtNoteText.Size = New System.Drawing.Size(867, 65)
        Me.richtxtNoteText.TabIndex = 79
        Me.richtxtNoteText.Text = ""
        '
        'btnAddNote
        '
        Me.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddNote.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNote.Location = New System.Drawing.Point(1125, 523)
        Me.btnAddNote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(93, 46)
        Me.btnAddNote.TabIndex = 78
        Me.btnAddNote.Text = "Add Note"
        Me.btnAddNote.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNote.Location = New System.Drawing.Point(99, 512)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(104, 20)
        Me.lblNote.TabIndex = 72
        Me.lblNote.Text = "Add Note Here"
        '
        'dgvTable
        '
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.AllowUserToDeleteRows = False
        Me.dgvTable.AllowUserToResizeColumns = False
        Me.dgvTable.AllowUserToResizeRows = False
        Me.dgvTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.currentUsername, Me.Position, Me.Message, Me.time})
        Me.dgvTable.Location = New System.Drawing.Point(98, 173)
        Me.dgvTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvTable.MultiSelect = False
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.ReadOnly = True
        Me.dgvTable.RowHeadersVisible = False
        Me.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTable.Size = New System.Drawing.Size(1127, 326)
        Me.dgvTable.TabIndex = 11
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'currentUsername
        '
        Me.currentUsername.HeaderText = "User Name"
        Me.currentUsername.Name = "currentUsername"
        Me.currentUsername.ReadOnly = True
        '
        'Position
        '
        Me.Position.HeaderText = "Position"
        Me.Position.Name = "Position"
        Me.Position.ReadOnly = True
        '
        'Message
        '
        Me.Message.HeaderText = "Message"
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        '
        'time
        '
        Me.time.HeaderText = "Date"
        Me.time.Name = "time"
        Me.time.ReadOnly = True
        Me.time.Visible = False
        '
        'pnlParents
        '
        Me.pnlParents.BackColor = System.Drawing.Color.Silver
        Me.pnlParents.Controls.Add(Me.lblParent)
        Me.pnlParents.Controls.Add(Me.lblParentsCount)
        Me.pnlParents.Controls.Add(Me.lblParentNumber)
        Me.pnlParents.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlParents.Location = New System.Drawing.Point(680, 25)
        Me.pnlParents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlParents.Name = "pnlParents"
        Me.pnlParents.Size = New System.Drawing.Size(258, 100)
        Me.pnlParents.TabIndex = 10
        '
        'lblParent
        '
        Me.lblParent.AutoSize = True
        Me.lblParent.BackColor = System.Drawing.Color.Silver
        Me.lblParent.Location = New System.Drawing.Point(8, 18)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(47, 17)
        Me.lblParent.TabIndex = 1
        Me.lblParent.Text = "Parents"
        '
        'lblParentsCount
        '
        Me.lblParentsCount.AutoSize = True
        Me.lblParentsCount.BackColor = System.Drawing.Color.Silver
        Me.lblParentsCount.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentsCount.Location = New System.Drawing.Point(7, 56)
        Me.lblParentsCount.Name = "lblParentsCount"
        Me.lblParentsCount.Size = New System.Drawing.Size(125, 20)
        Me.lblParentsCount.TabIndex = 2
        Me.lblParentsCount.Text = "Total Parents count"
        '
        'lblParentNumber
        '
        Me.lblParentNumber.AutoSize = True
        Me.lblParentNumber.BackColor = System.Drawing.Color.Silver
        Me.lblParentNumber.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentNumber.ForeColor = System.Drawing.Color.Crimson
        Me.lblParentNumber.Location = New System.Drawing.Point(172, 18)
        Me.lblParentNumber.Name = "lblParentNumber"
        Me.lblParentNumber.Size = New System.Drawing.Size(61, 25)
        Me.lblParentNumber.TabIndex = 3
        Me.lblParentNumber.Text = "1,453"
        '
        'pnlStaff
        '
        Me.pnlStaff.BackColor = System.Drawing.Color.Silver
        Me.pnlStaff.Controls.Add(Me.lblStaffs)
        Me.pnlStaff.Controls.Add(Me.lblStaffsCount)
        Me.pnlStaff.Controls.Add(Me.lblStaffNumber)
        Me.pnlStaff.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlStaff.Location = New System.Drawing.Point(967, 25)
        Me.pnlStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlStaff.Name = "pnlStaff"
        Me.pnlStaff.Size = New System.Drawing.Size(258, 100)
        Me.pnlStaff.TabIndex = 10
        '
        'lblStaffs
        '
        Me.lblStaffs.AutoSize = True
        Me.lblStaffs.BackColor = System.Drawing.Color.Silver
        Me.lblStaffs.Location = New System.Drawing.Point(10, 18)
        Me.lblStaffs.Name = "lblStaffs"
        Me.lblStaffs.Size = New System.Drawing.Size(37, 17)
        Me.lblStaffs.TabIndex = 1
        Me.lblStaffs.Text = "Staffs"
        '
        'lblStaffsCount
        '
        Me.lblStaffsCount.AutoSize = True
        Me.lblStaffsCount.BackColor = System.Drawing.Color.Silver
        Me.lblStaffsCount.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffsCount.Location = New System.Drawing.Point(8, 56)
        Me.lblStaffsCount.Name = "lblStaffsCount"
        Me.lblStaffsCount.Size = New System.Drawing.Size(127, 20)
        Me.lblStaffsCount.TabIndex = 2
        Me.lblStaffsCount.Text = "Total Student count"
        '
        'lblStaffNumber
        '
        Me.lblStaffNumber.AutoSize = True
        Me.lblStaffNumber.BackColor = System.Drawing.Color.Silver
        Me.lblStaffNumber.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffNumber.ForeColor = System.Drawing.Color.Crimson
        Me.lblStaffNumber.Location = New System.Drawing.Point(167, 18)
        Me.lblStaffNumber.Name = "lblStaffNumber"
        Me.lblStaffNumber.Size = New System.Drawing.Size(72, 25)
        Me.lblStaffNumber.TabIndex = 3
        Me.lblStaffNumber.Text = "20,453"
        '
        'pnlTeacher
        '
        Me.pnlTeacher.BackColor = System.Drawing.Color.Silver
        Me.pnlTeacher.Controls.Add(Me.lblTeachers)
        Me.pnlTeacher.Controls.Add(Me.lblTeacherCounts)
        Me.pnlTeacher.Controls.Add(Me.lblTeacherNumber)
        Me.pnlTeacher.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTeacher.Location = New System.Drawing.Point(392, 25)
        Me.pnlTeacher.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTeacher.Name = "pnlTeacher"
        Me.pnlTeacher.Size = New System.Drawing.Size(258, 100)
        Me.pnlTeacher.TabIndex = 10
        '
        'lblTeachers
        '
        Me.lblTeachers.AutoSize = True
        Me.lblTeachers.BackColor = System.Drawing.Color.Silver
        Me.lblTeachers.Location = New System.Drawing.Point(13, 18)
        Me.lblTeachers.Name = "lblTeachers"
        Me.lblTeachers.Size = New System.Drawing.Size(55, 17)
        Me.lblTeachers.TabIndex = 5
        Me.lblTeachers.Text = "Teachers"
        '
        'lblTeacherCounts
        '
        Me.lblTeacherCounts.AutoSize = True
        Me.lblTeacherCounts.BackColor = System.Drawing.Color.Silver
        Me.lblTeacherCounts.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCounts.Location = New System.Drawing.Point(15, 56)
        Me.lblTeacherCounts.Name = "lblTeacherCounts"
        Me.lblTeacherCounts.Size = New System.Drawing.Size(129, 20)
        Me.lblTeacherCounts.TabIndex = 6
        Me.lblTeacherCounts.Text = "Total Teacher count"
        '
        'lblTeacherNumber
        '
        Me.lblTeacherNumber.AutoSize = True
        Me.lblTeacherNumber.BackColor = System.Drawing.Color.Silver
        Me.lblTeacherNumber.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherNumber.ForeColor = System.Drawing.Color.Crimson
        Me.lblTeacherNumber.Location = New System.Drawing.Point(190, 18)
        Me.lblTeacherNumber.Name = "lblTeacherNumber"
        Me.lblTeacherNumber.Size = New System.Drawing.Size(61, 25)
        Me.lblTeacherNumber.TabIndex = 7
        Me.lblTeacherNumber.Text = "2,453"
        '
        'pnlStudent
        '
        Me.pnlStudent.BackColor = System.Drawing.Color.Silver
        Me.pnlStudent.Controls.Add(Me.lblStudent)
        Me.pnlStudent.Controls.Add(Me.lblStudentAccount)
        Me.pnlStudent.Controls.Add(Me.lblStudentNumbers)
        Me.pnlStudent.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlStudent.Location = New System.Drawing.Point(98, 25)
        Me.pnlStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(258, 100)
        Me.pnlStudent.TabIndex = 9
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.BackColor = System.Drawing.Color.Silver
        Me.lblStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStudent.Location = New System.Drawing.Point(12, 21)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(55, 17)
        Me.lblStudent.TabIndex = 1
        Me.lblStudent.Text = "Students"
        '
        'lblStudentAccount
        '
        Me.lblStudentAccount.AutoSize = True
        Me.lblStudentAccount.BackColor = System.Drawing.Color.Silver
        Me.lblStudentAccount.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentAccount.Location = New System.Drawing.Point(12, 60)
        Me.lblStudentAccount.Name = "lblStudentAccount"
        Me.lblStudentAccount.Size = New System.Drawing.Size(127, 20)
        Me.lblStudentAccount.TabIndex = 2
        Me.lblStudentAccount.Text = "Total Student count"
        '
        'lblStudentNumbers
        '
        Me.lblStudentNumbers.AutoSize = True
        Me.lblStudentNumbers.BackColor = System.Drawing.Color.Silver
        Me.lblStudentNumbers.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNumbers.ForeColor = System.Drawing.Color.Crimson
        Me.lblStudentNumbers.Location = New System.Drawing.Point(177, 18)
        Me.lblStudentNumbers.Name = "lblStudentNumbers"
        Me.lblStudentNumbers.Size = New System.Drawing.Size(72, 25)
        Me.lblStudentNumbers.TabIndex = 3
        Me.lblStudentNumbers.Text = "20,453"
        '
        'btnMyInterface
        '
        Me.btnMyInterface.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMyInterface.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMyInterface.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyInterface.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMyInterface.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyInterface.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyInterface.Location = New System.Drawing.Point(1071, 38)
        Me.btnMyInterface.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMyInterface.Name = "btnMyInterface"
        Me.btnMyInterface.Size = New System.Drawing.Size(131, 45)
        Me.btnMyInterface.TabIndex = 80
        Me.btnMyInterface.Text = "Home"
        Me.btnMyInterface.UseVisualStyleBackColor = False
        '
        'pnlStaffInterface
        '
        Me.pnlStaffInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStaffInterface.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStaffInterface.Controls.Add(Me.Panel4)
        Me.pnlStaffInterface.Controls.Add(Me.SplitContainer1)
        Me.pnlStaffInterface.Controls.Add(Me.Button4)
        Me.pnlStaffInterface.Controls.Add(Me.Button1)
        Me.pnlStaffInterface.Controls.Add(Me.Button2)
        Me.pnlStaffInterface.Controls.Add(Me.lblStaffInterface)
        Me.pnlStaffInterface.ForeColor = System.Drawing.Color.Black
        Me.pnlStaffInterface.Location = New System.Drawing.Point(6, 139)
        Me.pnlStaffInterface.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlStaffInterface.Name = "pnlStaffInterface"
        Me.pnlStaffInterface.Size = New System.Drawing.Size(1369, 532)
        Me.pnlStaffInterface.TabIndex = 44
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(1183, 206)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(149, 317)
        Me.Panel4.TabIndex = 11
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(33, 77)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer1.Size = New System.Drawing.Size(1125, 426)
        Me.SplitContainer1.SplitterDistance = 473
        Me.SplitContainer1.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1195, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 33)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1195, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1195, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblStaffInterface
        '
        Me.lblStaffInterface.AutoSize = True
        Me.lblStaffInterface.Location = New System.Drawing.Point(28, 34)
        Me.lblStaffInterface.Name = "lblStaffInterface"
        Me.lblStaffInterface.Size = New System.Drawing.Size(120, 25)
        Me.lblStaffInterface.TabIndex = 0
        Me.lblStaffInterface.Text = "Staff Interface"
        '
        'lblTeacherInterface
        '
        Me.lblTeacherInterface.AutoSize = True
        Me.lblTeacherInterface.Location = New System.Drawing.Point(30, 34)
        Me.lblTeacherInterface.Name = "lblTeacherInterface"
        Me.lblTeacherInterface.Size = New System.Drawing.Size(146, 25)
        Me.lblTeacherInterface.TabIndex = 0
        Me.lblTeacherInterface.Text = "Teacher Interface"
        '
        'tcTeacher
        '
        Me.tcTeacher.Controls.Add(Me.tpTeacherOverview)
        Me.tcTeacher.Controls.Add(Me.tpTeacherRollCallManagement)
        Me.tcTeacher.Controls.Add(Me.tpInstructionForStudent)
        Me.tcTeacher.Controls.Add(Me.tpMarkManagement)
        Me.tcTeacher.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTeacher.Location = New System.Drawing.Point(25, 75)
        Me.tcTeacher.Name = "tcTeacher"
        Me.tcTeacher.SelectedIndex = 0
        Me.tcTeacher.Size = New System.Drawing.Size(1289, 430)
        Me.tcTeacher.TabIndex = 2
        '
        'tpTeacherOverview
        '
        Me.tpTeacherOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tpTeacherOverview.Controls.Add(Me.GroupBox4)
        Me.tpTeacherOverview.Controls.Add(Me.GroupBox5)
        Me.tpTeacherOverview.Controls.Add(Me.GroupBox3)
        Me.tpTeacherOverview.Location = New System.Drawing.Point(4, 29)
        Me.tpTeacherOverview.Name = "tpTeacherOverview"
        Me.tpTeacherOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTeacherOverview.Size = New System.Drawing.Size(1281, 397)
        Me.tpTeacherOverview.TabIndex = 0
        Me.tpTeacherOverview.Text = "Overview"
        '
        'GroupBox4
        '
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(463, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(355, 346)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Class F9"
        '
        'GroupBox5
        '
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(842, 30)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(355, 346)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Class Q4"
        '
        'GroupBox3
        '
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(77, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 346)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Class E6"
        '
        'tpTeacherRollCallManagement
        '
        Me.tpTeacherRollCallManagement.BackColor = System.Drawing.Color.Orange
        Me.tpTeacherRollCallManagement.Controls.Add(Me.Label15)
        Me.tpTeacherRollCallManagement.Controls.Add(Me.Label5)
        Me.tpTeacherRollCallManagement.Controls.Add(Me.cboRollCallClass)
        Me.tpTeacherRollCallManagement.Controls.Add(Me.dgvRollCall)
        Me.tpTeacherRollCallManagement.Location = New System.Drawing.Point(4, 29)
        Me.tpTeacherRollCallManagement.Name = "tpTeacherRollCallManagement"
        Me.tpTeacherRollCallManagement.Size = New System.Drawing.Size(1281, 397)
        Me.tpTeacherRollCallManagement.TabIndex = 4
        Me.tpTeacherRollCallManagement.Text = "Roll Call Management"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(38, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(359, 20)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "You can edit student roll number and roll call parcentage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(999, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Select Class :"
        '
        'cboRollCallClass
        '
        Me.cboRollCallClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRollCallClass.FormattingEnabled = True
        Me.cboRollCallClass.Location = New System.Drawing.Point(1103, 22)
        Me.cboRollCallClass.Name = "cboRollCallClass"
        Me.cboRollCallClass.Size = New System.Drawing.Size(145, 28)
        Me.cboRollCallClass.TabIndex = 6
        '
        'dgvRollCall
        '
        Me.dgvRollCall.AllowUserToAddRows = False
        Me.dgvRollCall.AllowUserToDeleteRows = False
        Me.dgvRollCall.AllowUserToResizeColumns = False
        Me.dgvRollCall.AllowUserToResizeRows = False
        Me.dgvRollCall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRollCall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRollCall.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRollCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRollCall.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identifier, Me.roll, Me.rollcallUsername, Me.rollcallPhone, Me.ClassName, Me.rollcallName})
        Me.dgvRollCall.Location = New System.Drawing.Point(38, 61)
        Me.dgvRollCall.MultiSelect = False
        Me.dgvRollCall.Name = "dgvRollCall"
        Me.dgvRollCall.RowHeadersVisible = False
        Me.dgvRollCall.Size = New System.Drawing.Size(1210, 315)
        Me.dgvRollCall.TabIndex = 0
        '
        'identifier
        '
        Me.identifier.HeaderText = "id"
        Me.identifier.Name = "identifier"
        Me.identifier.Visible = False
        '
        'roll
        '
        Me.roll.HeaderText = "roll no"
        Me.roll.Name = "roll"
        '
        'rollcallUsername
        '
        Me.rollcallUsername.HeaderText = "Username"
        Me.rollcallUsername.Name = "rollcallUsername"
        '
        'rollcallPhone
        '
        Me.rollcallPhone.HeaderText = "Phone"
        Me.rollcallPhone.Name = "rollcallPhone"
        '
        'ClassName
        '
        Me.ClassName.HeaderText = "Class"
        Me.ClassName.Name = "ClassName"
        '
        'rollcallName
        '
        Me.rollcallName.HeaderText = "RollCall"
        Me.rollcallName.Name = "rollcallName"
        '
        'tpInstructionForStudent
        '
        Me.tpInstructionForStudent.BackColor = System.Drawing.Color.Goldenrod
        Me.tpInstructionForStudent.Controls.Add(Me.lblSubject)
        Me.tpInstructionForStudent.Controls.Add(Me.lblSubjectLevel)
        Me.tpInstructionForStudent.Controls.Add(Me.dudAllowMinutes)
        Me.tpInstructionForStudent.Controls.Add(Me.Label12)
        Me.tpInstructionForStudent.Controls.Add(Me.Label11)
        Me.tpInstructionForStudent.Controls.Add(Me.dudNumber)
        Me.tpInstructionForStudent.Controls.Add(Me.Label4)
        Me.tpInstructionForStudent.Controls.Add(Me.cboType)
        Me.tpInstructionForStudent.Controls.Add(Me.Label3)
        Me.tpInstructionForStudent.Controls.Add(Me.TextBox1)
        Me.tpInstructionForStudent.Controls.Add(Me.btnAttachFile)
        Me.tpInstructionForStudent.Controls.Add(Me.btnSend)
        Me.tpInstructionForStudent.Controls.Add(Me.cboForStudentClass)
        Me.tpInstructionForStudent.Controls.Add(Me.Panel5)
        Me.tpInstructionForStudent.Location = New System.Drawing.Point(4, 29)
        Me.tpInstructionForStudent.Name = "tpInstructionForStudent"
        Me.tpInstructionForStudent.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInstructionForStudent.Size = New System.Drawing.Size(1281, 397)
        Me.tpInstructionForStudent.TabIndex = 1
        Me.tpInstructionForStudent.Text = "For Student "
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(93, 333)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 20)
        Me.lblSubject.TabIndex = 14
        Me.lblSubject.Text = "DBMS"
        '
        'lblSubjectLevel
        '
        Me.lblSubjectLevel.AutoSize = True
        Me.lblSubjectLevel.Location = New System.Drawing.Point(28, 332)
        Me.lblSubjectLevel.Name = "lblSubjectLevel"
        Me.lblSubjectLevel.Size = New System.Drawing.Size(61, 20)
        Me.lblSubjectLevel.TabIndex = 13
        Me.lblSubjectLevel.Text = "Subject :"
        '
        'dudAllowMinutes
        '
        Me.dudAllowMinutes.BackColor = System.Drawing.Color.BurlyWood
        Me.dudAllowMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dudAllowMinutes.Items.Add("5")
        Me.dudAllowMinutes.Items.Add("10")
        Me.dudAllowMinutes.Items.Add("20")
        Me.dudAllowMinutes.Items.Add("30")
        Me.dudAllowMinutes.Items.Add("40")
        Me.dudAllowMinutes.Items.Add("50")
        Me.dudAllowMinutes.Items.Add("60")
        Me.dudAllowMinutes.Items.Add("90")
        Me.dudAllowMinutes.Items.Add("120")
        Me.dudAllowMinutes.Items.Add("150")
        Me.dudAllowMinutes.Items.Add("180")
        Me.dudAllowMinutes.Location = New System.Drawing.Point(1071, 292)
        Me.dudAllowMinutes.Name = "dudAllowMinutes"
        Me.dudAllowMinutes.Size = New System.Drawing.Size(131, 23)
        Me.dudAllowMinutes.TabIndex = 11
        Me.dudAllowMinutes.Text = "180"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(956, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Allow Minutes:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(225, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "You can add attach file if it is necessary!"
        '
        'dudNumber
        '
        Me.dudNumber.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dudNumber.Items.Add("1")
        Me.dudNumber.Items.Add("2")
        Me.dudNumber.Items.Add("3")
        Me.dudNumber.Items.Add("4")
        Me.dudNumber.Items.Add("5")
        Me.dudNumber.Items.Add("6")
        Me.dudNumber.Location = New System.Drawing.Point(1208, 249)
        Me.dudNumber.Name = "dudNumber"
        Me.dudNumber.Size = New System.Drawing.Size(47, 27)
        Me.dudNumber.TabIndex = 8
        Me.dudNumber.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(967, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Select Type :"
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Assignment", "Tutorial ", "Lab Instruction"})
        Me.cboType.Location = New System.Drawing.Point(1071, 249)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(131, 28)
        Me.cboType.TabIndex = 6
        Me.cboType.Text = "--- Select One ---"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(967, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Select Class :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 210)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 27)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "C:/"
        '
        'btnAttachFile
        '
        Me.btnAttachFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttachFile.Image = CType(resources.GetObject("btnAttachFile.Image"), System.Drawing.Image)
        Me.btnAttachFile.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAttachFile.Location = New System.Drawing.Point(396, 209)
        Me.btnAttachFile.Name = "btnAttachFile"
        Me.btnAttachFile.Size = New System.Drawing.Size(147, 32)
        Me.btnAttachFile.TabIndex = 3
        Me.btnAttachFile.Text = "Attach File"
        Me.btnAttachFile.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(1071, 351)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(184, 34)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'cboForStudentClass
        '
        Me.cboForStudentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboForStudentClass.FormattingEnabled = True
        Me.cboForStudentClass.Location = New System.Drawing.Point(1071, 209)
        Me.cboForStudentClass.Name = "cboForStudentClass"
        Me.cboForStudentClass.Size = New System.Drawing.Size(182, 28)
        Me.cboForStudentClass.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel5.Controls.Add(Me.richtxtInstructionText)
        Me.Panel5.Location = New System.Drawing.Point(30, 28)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1223, 149)
        Me.Panel5.TabIndex = 0
        '
        'richtxtInstructionText
        '
        Me.richtxtInstructionText.BackColor = System.Drawing.Color.AntiqueWhite
        Me.richtxtInstructionText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richtxtInstructionText.Location = New System.Drawing.Point(13, 13)
        Me.richtxtInstructionText.Name = "richtxtInstructionText"
        Me.richtxtInstructionText.Size = New System.Drawing.Size(1194, 118)
        Me.richtxtInstructionText.TabIndex = 0
        Me.richtxtInstructionText.Text = ""
        '
        'tpMarkManagement
        '
        Me.tpMarkManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.tpMarkManagement.Controls.Add(Me.Label8)
        Me.tpMarkManagement.Controls.Add(Me.cboMarkManagement)
        Me.tpMarkManagement.Controls.Add(Me.dgvMarkManagement)
        Me.tpMarkManagement.Location = New System.Drawing.Point(4, 29)
        Me.tpMarkManagement.Name = "tpMarkManagement"
        Me.tpMarkManagement.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMarkManagement.Size = New System.Drawing.Size(1281, 397)
        Me.tpMarkManagement.TabIndex = 5
        Me.tpMarkManagement.Text = "Mark Management"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(996, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Select Class :"
        '
        'cboMarkManagement
        '
        Me.cboMarkManagement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarkManagement.FormattingEnabled = True
        Me.cboMarkManagement.Location = New System.Drawing.Point(1100, 21)
        Me.cboMarkManagement.Name = "cboMarkManagement"
        Me.cboMarkManagement.Size = New System.Drawing.Size(145, 28)
        Me.cboMarkManagement.TabIndex = 9
        '
        'dgvMarkManagement
        '
        Me.dgvMarkManagement.AllowUserToAddRows = False
        Me.dgvMarkManagement.AllowUserToDeleteRows = False
        Me.dgvMarkManagement.AllowUserToResizeColumns = False
        Me.dgvMarkManagement.AllowUserToResizeRows = False
        Me.dgvMarkManagement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMarkManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMarkManagement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMarkManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarkManagement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.markUsername, Me.colClass, Me.markGrade, Me.markDate, Me.colType, Me.markQuestion, Me.Mark})
        Me.dgvMarkManagement.Location = New System.Drawing.Point(35, 60)
        Me.dgvMarkManagement.MultiSelect = False
        Me.dgvMarkManagement.Name = "dgvMarkManagement"
        Me.dgvMarkManagement.RowHeadersVisible = False
        Me.dgvMarkManagement.Size = New System.Drawing.Size(1210, 315)
        Me.dgvMarkManagement.TabIndex = 8
        '
        'colid
        '
        Me.colid.HeaderText = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        '
        'markUsername
        '
        Me.markUsername.HeaderText = "Username"
        Me.markUsername.Name = "markUsername"
        '
        'colClass
        '
        Me.colClass.HeaderText = "Class"
        Me.colClass.Name = "colClass"
        '
        'markGrade
        '
        Me.markGrade.HeaderText = "roll no"
        Me.markGrade.Name = "markGrade"
        '
        'markDate
        '
        Me.markDate.HeaderText = "Date"
        Me.markDate.Name = "markDate"
        '
        'colType
        '
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        '
        'markQuestion
        '
        Me.markQuestion.HeaderText = "Answer"
        Me.markQuestion.Name = "markQuestion"
        '
        'Mark
        '
        Me.Mark.HeaderText = "Score Mark"
        Me.Mark.Name = "Mark"
        '
        'pnlTeacherInterface
        '
        Me.pnlTeacherInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTeacherInterface.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlTeacherInterface.Controls.Add(Me.tcTeacher)
        Me.pnlTeacherInterface.Controls.Add(Me.lblTeacherInterface)
        Me.pnlTeacherInterface.Location = New System.Drawing.Point(14, 131)
        Me.pnlTeacherInterface.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTeacherInterface.Name = "pnlTeacherInterface"
        Me.pnlTeacherInterface.Size = New System.Drawing.Size(1331, 582)
        Me.pnlTeacherInterface.TabIndex = 43
        '
        'timerTutorial
        '
        '
        'timerAssignment
        '
        '
        'picPrivateNote
        '
        Me.picPrivateNote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picPrivateNote.BackColor = System.Drawing.Color.Transparent
        Me.picPrivateNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPrivateNote.Image = CType(resources.GetObject("picPrivateNote.Image"), System.Drawing.Image)
        Me.picPrivateNote.Location = New System.Drawing.Point(1004, 38)
        Me.picPrivateNote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPrivateNote.Name = "picPrivateNote"
        Me.picPrivateNote.Size = New System.Drawing.Size(45, 50)
        Me.picPrivateNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrivateNote.TabIndex = 82
        Me.picPrivateNote.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "RollCall"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Grade
        '
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        '
        'frmMainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 682)
        Me.Controls.Add(Me.pnlTeacherInterface)
        Me.Controls.Add(Me.pnlStudentInterFace)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.picPrivateNote)
        Me.Controls.Add(Me.pnlManagerInterface)
        Me.Controls.Add(Me.btnMyInterface)
        Me.Controls.Add(Me.lblCurrentPosition)
        Me.Controls.Add(Me.lblCurrentUserName)
        Me.Controls.Add(Me.picCurrentUser)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.pnlAdminUI)
        Me.Controls.Add(Me.pnlParentsInterface)
        Me.Controls.Add(Me.pnlStaffInterface)
        Me.Controls.Add(Me.pnlSoftwareUI)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmMainForm"
        Me.Text = "ERP Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picCurrentUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlManagerInterface.ResumeLayout(False)
        Me.pnlManagerInterface.PerformLayout()
        Me.pnlStudentInterFace.ResumeLayout(False)
        Me.pnlStudentInterFace.PerformLayout()
        Me.tcStudentInterface.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvStudentOverview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpStudentTutorial.ResumeLayout(False)
        Me.tpStudentTutorial.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpStudentAssignment.ResumeLayout(False)
        Me.tpStudentAssignment.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAssignmentStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAssignmentStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParentsInterface.ResumeLayout(False)
        Me.pnlParentsInterface.PerformLayout()
        Me.pnlAdminUI.ResumeLayout(False)
        Me.gboModify.ResumeLayout(False)
        Me.gboModify.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlSoftwareUI.ResumeLayout(False)
        Me.pnlSoftwareUI.PerformLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParents.ResumeLayout(False)
        Me.pnlParents.PerformLayout()
        Me.pnlStaff.ResumeLayout(False)
        Me.pnlStaff.PerformLayout()
        Me.pnlTeacher.ResumeLayout(False)
        Me.pnlTeacher.PerformLayout()
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.pnlStaffInterface.ResumeLayout(False)
        Me.pnlStaffInterface.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tcTeacher.ResumeLayout(False)
        Me.tpTeacherOverview.ResumeLayout(False)
        Me.tpTeacherRollCallManagement.ResumeLayout(False)
        Me.tpTeacherRollCallManagement.PerformLayout()
        CType(Me.dgvRollCall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInstructionForStudent.ResumeLayout(False)
        Me.tpInstructionForStudent.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.tpMarkManagement.ResumeLayout(False)
        Me.tpMarkManagement.PerformLayout()
        CType(Me.dgvMarkManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTeacherInterface.ResumeLayout(False)
        Me.pnlTeacherInterface.PerformLayout()
        CType(Me.picPrivateNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents timerClock As System.Windows.Forms.Timer
    Friend WithEvents lblLogout As System.Windows.Forms.Label
    Friend WithEvents picCurrentUser As System.Windows.Forms.PictureBox
    Public WithEvents lblCurrentUserName As System.Windows.Forms.Label
    Public WithEvents lblCurrentPosition As System.Windows.Forms.Label
    Public WithEvents pnlManagerInterface As System.Windows.Forms.Panel
    Public WithEvents pnlStudentInterFace As System.Windows.Forms.Panel
    Friend WithEvents lblManager As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStudentData As System.Windows.Forms.Button
    Friend WithEvents btnAddNewUsers As System.Windows.Forms.Button
    Public WithEvents pnlAdminUI As System.Windows.Forms.Panel
    Friend WithEvents gboModify As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboModifyPositionList As System.Windows.Forms.ComboBox
    Friend WithEvents txtModify As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cboRemovePositionList As System.Windows.Forms.ComboBox
    Friend WithEvents lblPositionList As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPositionName As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentName1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Public WithEvents pnlSoftwareUI As System.Windows.Forms.Panel
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents lblStudentAccount As System.Windows.Forms.Label
    Friend WithEvents lblTeacherNumber As System.Windows.Forms.Label
    Friend WithEvents lblTeacherCounts As System.Windows.Forms.Label
    Friend WithEvents lblTeachers As System.Windows.Forms.Label
    Friend WithEvents lblStudentNumbers As System.Windows.Forms.Label
    Friend WithEvents pnlParents As System.Windows.Forms.Panel
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents lblParentsCount As System.Windows.Forms.Label
    Friend WithEvents lblParentNumber As System.Windows.Forms.Label
    Friend WithEvents pnlStaff As System.Windows.Forms.Panel
    Friend WithEvents lblStaffs As System.Windows.Forms.Label
    Friend WithEvents lblStaffsCount As System.Windows.Forms.Label
    Friend WithEvents lblStaffNumber As System.Windows.Forms.Label
    Friend WithEvents pnlTeacher As System.Windows.Forms.Panel
    Friend WithEvents pnlStudent As System.Windows.Forms.Panel
    Friend WithEvents dgvTable As System.Windows.Forms.DataGridView
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents btnAddNote As System.Windows.Forms.Button
    Friend WithEvents richtxtNoteText As System.Windows.Forms.RichTextBox
    Friend WithEvents btnMyInterface As System.Windows.Forms.Button
    Public WithEvents btnChange As System.Windows.Forms.Button
    Public WithEvents pnlParentsInterface As System.Windows.Forms.Panel
    Friend WithEvents lblParentsInterface As System.Windows.Forms.Label
    Public WithEvents pnlStaffInterface As System.Windows.Forms.Panel
    Private WithEvents lblStaffInterface As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tcStudentInterface As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tpStudentTutorial As System.Windows.Forms.TabPage
    Friend WithEvents tpStudentAssignment As System.Windows.Forms.TabPage
    Friend WithEvents tpStudentLab As System.Windows.Forms.TabPage
    Friend WithEvents lblTeacherInterface As System.Windows.Forms.Label
    Friend WithEvents tcTeacher As System.Windows.Forms.TabControl
    Friend WithEvents tpTeacherOverview As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tpTeacherRollCallManagement As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboRollCallClass As System.Windows.Forms.ComboBox
    Friend WithEvents dgvRollCall As System.Windows.Forms.DataGridView
    Friend WithEvents tpInstructionForStudent As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAttachFile As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents richtxtInstructionText As System.Windows.Forms.RichTextBox
    Public WithEvents pnlTeacherInterface As System.Windows.Forms.Panel
    Friend WithEvents btnSubmitTutorial As System.Windows.Forms.Button
    Friend WithEvents dudTutorial As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents richTextAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents richtxtQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvStudentOverview As System.Windows.Forms.DataGridView
    Public WithEvents lblStudentUsername As System.Windows.Forms.Label
    Public WithEvents lblStudentPhoneNumber As System.Windows.Forms.Label
    Public WithEvents lblStudentRank As System.Windows.Forms.Label
    Public WithEvents lblStudentClass As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picStart As System.Windows.Forms.PictureBox
    Friend WithEvents picStop As System.Windows.Forms.PictureBox
    Private WithEvents lblTutorialTimeCounter As System.Windows.Forms.Label
    Friend WithEvents timerTutorial As System.Windows.Forms.Timer
    Friend WithEvents picAssignmentStop As System.Windows.Forms.PictureBox
    Private WithEvents lblAssignmentTimeCounter As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dudAssignment As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents richTxtAssignmentAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents richtxtAssignmentQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAssignmentSend As System.Windows.Forms.Button
    Friend WithEvents picAssignmentStart As System.Windows.Forms.PictureBox
    Friend WithEvents dudNumber As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dudAllowMinutes As System.Windows.Forms.DomainUpDown
    Friend WithEvents timerAssignment As System.Windows.Forms.Timer
    Friend WithEvents tpMarkManagement As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboMarkManagement As System.Windows.Forms.ComboBox
    Friend WithEvents dgvMarkManagement As System.Windows.Forms.DataGridView
    Friend WithEvents identifier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rollcallUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rollcallPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rollcallName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblSubjectLevel As System.Windows.Forms.Label
    Private WithEvents lblTutorialSubject As System.Windows.Forms.Label
    Friend WithEvents cboStudentTutorialSubject As System.Windows.Forms.ComboBox
    Private WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cboStudentAssignmentSubject As System.Windows.Forms.ComboBox
    Private WithEvents lblAssignmentSubject As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents picPrivateNote As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents picMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currentUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Message As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents markUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents markGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents markDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents markQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mark As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents cboForStudentClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grade As System.Windows.Forms.DataGridViewTextBoxColumn


    'Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    '    ArrangeForm()
    'End Sub
End Class
