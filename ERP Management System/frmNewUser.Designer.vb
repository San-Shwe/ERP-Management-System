<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUser))
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPhoneNo = New System.Windows.Forms.TextBox
        Me.txtNewUserPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAddUser = New System.Windows.Forms.Button
        Me.txtNewUserName = New System.Windows.Forms.TextBox
        Me.lblAddName = New System.Windows.Forms.Label
        Me.cboRegisterPosition = New System.Windows.Forms.ComboBox
        Me.txtMotherName = New System.Windows.Forms.TextBox
        Me.lblMotherName = New System.Windows.Forms.Label
        Me.txtFatherName = New System.Windows.Forms.TextBox
        Me.lblFatherName = New System.Windows.Forms.Label
        Me.txtNRCNo = New System.Windows.Forms.TextBox
        Me.lblNRCNo = New System.Windows.Forms.Label
        Me.dgvRegisterationList = New System.Windows.Forms.DataGridView
        Me.registerName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerpassword = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerPosition = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerPhone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerFather = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerMother = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerNrc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.registerEmail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.dgvRegisterationList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(14, 295)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(391, 29)
        Me.txtEmail.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(10, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Email Address"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(14, 222)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(391, 29)
        Me.txtPhoneNo.TabIndex = 20
        '
        'txtNewUserPassword
        '
        Me.txtNewUserPassword.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserPassword.Location = New System.Drawing.Point(12, 95)
        Me.txtNewUserPassword.Name = "txtNewUserPassword"
        Me.txtNewUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewUserPassword.Size = New System.Drawing.Size(393, 29)
        Me.txtNewUserPassword.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(10, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(11, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Position"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(11, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Password"
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(11, 534)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(147, 32)
        Me.btnAddUser.TabIndex = 60
        Me.btnAddUser.Text = "Confirm New User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'txtNewUserName
        '
        Me.txtNewUserName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserName.Location = New System.Drawing.Point(12, 39)
        Me.txtNewUserName.Name = "txtNewUserName"
        Me.txtNewUserName.Size = New System.Drawing.Size(393, 29)
        Me.txtNewUserName.TabIndex = 5
        '
        'lblAddName
        '
        Me.lblAddName.AutoSize = True
        Me.lblAddName.BackColor = System.Drawing.Color.Transparent
        Me.lblAddName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAddName.Location = New System.Drawing.Point(9, 13)
        Me.lblAddName.Name = "lblAddName"
        Me.lblAddName.Size = New System.Drawing.Size(50, 21)
        Me.lblAddName.TabIndex = 11
        Me.lblAddName.Text = "Name"
        '
        'cboRegisterPosition
        '
        Me.cboRegisterPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegisterPosition.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegisterPosition.FormattingEnabled = True
        Me.cboRegisterPosition.Location = New System.Drawing.Point(14, 157)
        Me.cboRegisterPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRegisterPosition.Name = "cboRegisterPosition"
        Me.cboRegisterPosition.Size = New System.Drawing.Size(391, 28)
        Me.cboRegisterPosition.TabIndex = 15
        '
        'txtMotherName
        '
        Me.txtMotherName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherName.Location = New System.Drawing.Point(10, 421)
        Me.txtMotherName.Name = "txtMotherName"
        Me.txtMotherName.Size = New System.Drawing.Size(393, 29)
        Me.txtMotherName.TabIndex = 35
        '
        'lblMotherName
        '
        Me.lblMotherName.AutoSize = True
        Me.lblMotherName.BackColor = System.Drawing.Color.Transparent
        Me.lblMotherName.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotherName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMotherName.Location = New System.Drawing.Point(9, 398)
        Me.lblMotherName.Name = "lblMotherName"
        Me.lblMotherName.Size = New System.Drawing.Size(96, 20)
        Me.lblMotherName.TabIndex = 59
        Me.lblMotherName.Text = "Mother Name"
        '
        'txtFatherName
        '
        Me.txtFatherName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.Location = New System.Drawing.Point(13, 359)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(393, 29)
        Me.txtFatherName.TabIndex = 30
        '
        'lblFatherName
        '
        Me.lblFatherName.AutoSize = True
        Me.lblFatherName.BackColor = System.Drawing.Color.Transparent
        Me.lblFatherName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatherName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFatherName.Location = New System.Drawing.Point(10, 336)
        Me.lblFatherName.Name = "lblFatherName"
        Me.lblFatherName.Size = New System.Drawing.Size(95, 21)
        Me.lblFatherName.TabIndex = 57
        Me.lblFatherName.Text = "Father Name"
        '
        'txtNRCNo
        '
        Me.txtNRCNo.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRCNo.Location = New System.Drawing.Point(10, 483)
        Me.txtNRCNo.Name = "txtNRCNo"
        Me.txtNRCNo.Size = New System.Drawing.Size(393, 29)
        Me.txtNRCNo.TabIndex = 40
        '
        'lblNRCNo
        '
        Me.lblNRCNo.AutoSize = True
        Me.lblNRCNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNRCNo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRCNo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNRCNo.Location = New System.Drawing.Point(9, 460)
        Me.lblNRCNo.Name = "lblNRCNo"
        Me.lblNRCNo.Size = New System.Drawing.Size(60, 20)
        Me.lblNRCNo.TabIndex = 61
        Me.lblNRCNo.Text = "NRC No"
        '
        'dgvRegisterationList
        '
        Me.dgvRegisterationList.AllowUserToAddRows = False
        Me.dgvRegisterationList.AllowUserToDeleteRows = False
        Me.dgvRegisterationList.AllowUserToResizeColumns = False
        Me.dgvRegisterationList.AllowUserToResizeRows = False
        Me.dgvRegisterationList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvRegisterationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegisterationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegisterationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegisterationList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.registerName, Me.registerpassword, Me.registerPosition, Me.registerPhone, Me.registerFather, Me.registerMother, Me.registerNrc, Me.registerDate, Me.registerEmail})
        Me.dgvRegisterationList.Location = New System.Drawing.Point(413, 39)
        Me.dgvRegisterationList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvRegisterationList.MultiSelect = False
        Me.dgvRegisterationList.Name = "dgvRegisterationList"
        Me.dgvRegisterationList.ReadOnly = True
        Me.dgvRegisterationList.RowHeadersVisible = False
        Me.dgvRegisterationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegisterationList.Size = New System.Drawing.Size(843, 473)
        Me.dgvRegisterationList.TabIndex = 62
        '
        'registerName
        '
        Me.registerName.HeaderText = "name"
        Me.registerName.Name = "registerName"
        Me.registerName.ReadOnly = True
        '
        'registerpassword
        '
        Me.registerpassword.HeaderText = "password"
        Me.registerpassword.Name = "registerpassword"
        Me.registerpassword.ReadOnly = True
        Me.registerpassword.Visible = False
        '
        'registerPosition
        '
        Me.registerPosition.HeaderText = "position"
        Me.registerPosition.Name = "registerPosition"
        Me.registerPosition.ReadOnly = True
        '
        'registerPhone
        '
        Me.registerPhone.HeaderText = "phone"
        Me.registerPhone.Name = "registerPhone"
        Me.registerPhone.ReadOnly = True
        '
        'registerFather
        '
        Me.registerFather.HeaderText = "father"
        Me.registerFather.Name = "registerFather"
        Me.registerFather.ReadOnly = True
        '
        'registerMother
        '
        Me.registerMother.HeaderText = "mother"
        Me.registerMother.Name = "registerMother"
        Me.registerMother.ReadOnly = True
        '
        'registerNrc
        '
        Me.registerNrc.HeaderText = "nrc"
        Me.registerNrc.Name = "registerNrc"
        Me.registerNrc.ReadOnly = True
        '
        'registerDate
        '
        Me.registerDate.HeaderText = "date"
        Me.registerDate.Name = "registerDate"
        Me.registerDate.ReadOnly = True
        '
        'registerEmail
        '
        Me.registerEmail.HeaderText = "email"
        Me.registerEmail.Name = "registerEmail"
        Me.registerEmail.ReadOnly = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(266, 534)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(137, 32)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.Text = "Reset"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1294, 578)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgvRegisterationList)
        Me.Controls.Add(Me.txtNRCNo)
        Me.Controls.Add(Me.lblNRCNo)
        Me.Controls.Add(Me.txtMotherName)
        Me.Controls.Add(Me.lblMotherName)
        Me.Controls.Add(Me.txtFatherName)
        Me.Controls.Add(Me.lblFatherName)
        Me.Controls.Add(Me.cboRegisterPosition)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtNewUserPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.txtNewUserName)
        Me.Controls.Add(Me.lblAddName)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New User "
        CType(Me.dgvRegisterationList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtNewUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents txtNewUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddName As System.Windows.Forms.Label
    Public WithEvents cboRegisterPosition As System.Windows.Forms.ComboBox
    Friend WithEvents txtMotherName As System.Windows.Forms.TextBox
    Friend WithEvents lblMotherName As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As System.Windows.Forms.TextBox
    Friend WithEvents lblFatherName As System.Windows.Forms.Label
    Friend WithEvents txtNRCNo As System.Windows.Forms.TextBox
    Friend WithEvents lblNRCNo As System.Windows.Forms.Label
    Friend WithEvents dgvRegisterationList As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents registerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerpassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerFather As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerMother As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerNrc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents registerEmail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
