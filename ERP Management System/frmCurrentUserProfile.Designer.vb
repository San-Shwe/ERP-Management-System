<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrentUserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurrentUserProfile))
        Me.picCurrentUserPhoto = New System.Windows.Forms.PictureBox
        Me.txtNRCNo = New System.Windows.Forms.TextBox
        Me.lblNRCNo = New System.Windows.Forms.Label
        Me.txtMotherName = New System.Windows.Forms.TextBox
        Me.lblMotherName = New System.Windows.Forms.Label
        Me.txtFatherName = New System.Windows.Forms.TextBox
        Me.lblFatherName = New System.Windows.Forms.Label
        Me.txtPhoneNo = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPhoneNumber = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.btnChangeUserDetails = New System.Windows.Forms.Button
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblEmailAddress = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblPosition = New System.Windows.Forms.Label
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblNote = New System.Windows.Forms.Label
        CType(Me.picCurrentUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCurrentUserPhoto
        '
        Me.picCurrentUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCurrentUserPhoto.Image = CType(resources.GetObject("picCurrentUserPhoto.Image"), System.Drawing.Image)
        Me.picCurrentUserPhoto.Location = New System.Drawing.Point(29, 25)
        Me.picCurrentUserPhoto.Name = "picCurrentUserPhoto"
        Me.picCurrentUserPhoto.Size = New System.Drawing.Size(125, 128)
        Me.picCurrentUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCurrentUserPhoto.TabIndex = 0
        Me.picCurrentUserPhoto.TabStop = False
        '
        'txtNRCNo
        '
        Me.txtNRCNo.Enabled = False
        Me.txtNRCNo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRCNo.Location = New System.Drawing.Point(679, 219)
        Me.txtNRCNo.Name = "txtNRCNo"
        Me.txtNRCNo.Size = New System.Drawing.Size(393, 27)
        Me.txtNRCNo.TabIndex = 74
        '
        'lblNRCNo
        '
        Me.lblNRCNo.AutoSize = True
        Me.lblNRCNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNRCNo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRCNo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNRCNo.Location = New System.Drawing.Point(678, 196)
        Me.lblNRCNo.Name = "lblNRCNo"
        Me.lblNRCNo.Size = New System.Drawing.Size(60, 20)
        Me.lblNRCNo.TabIndex = 78
        Me.lblNRCNo.Text = "NRC No"
        '
        'txtMotherName
        '
        Me.txtMotherName.Enabled = False
        Me.txtMotherName.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherName.Location = New System.Drawing.Point(679, 166)
        Me.txtMotherName.Name = "txtMotherName"
        Me.txtMotherName.Size = New System.Drawing.Size(393, 27)
        Me.txtMotherName.TabIndex = 73
        '
        'lblMotherName
        '
        Me.lblMotherName.AutoSize = True
        Me.lblMotherName.BackColor = System.Drawing.Color.Transparent
        Me.lblMotherName.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotherName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMotherName.Location = New System.Drawing.Point(678, 143)
        Me.lblMotherName.Name = "lblMotherName"
        Me.lblMotherName.Size = New System.Drawing.Size(96, 20)
        Me.lblMotherName.TabIndex = 76
        Me.lblMotherName.Text = "Mother Name"
        '
        'txtFatherName
        '
        Me.txtFatherName.Enabled = False
        Me.txtFatherName.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.Location = New System.Drawing.Point(679, 108)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(393, 27)
        Me.txtFatherName.TabIndex = 72
        '
        'lblFatherName
        '
        Me.lblFatherName.AutoSize = True
        Me.lblFatherName.BackColor = System.Drawing.Color.Transparent
        Me.lblFatherName.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatherName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFatherName.Location = New System.Drawing.Point(676, 85)
        Me.lblFatherName.Name = "lblFatherName"
        Me.lblFatherName.Size = New System.Drawing.Size(89, 20)
        Me.lblFatherName.TabIndex = 75
        Me.lblFatherName.Text = "Father Name"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Enabled = False
        Me.txtPhoneNo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(205, 228)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(391, 27)
        Me.txtPhoneNo.TabIndex = 69
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(203, 112)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(393, 27)
        Me.txtPassword.TabIndex = 63
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPhoneNumber.Location = New System.Drawing.Point(201, 206)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(105, 20)
        Me.lblPhoneNumber.TabIndex = 68
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPassword.Location = New System.Drawing.Point(202, 89)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(66, 20)
        Me.lblPassword.TabIndex = 65
        Me.lblPassword.Text = "Password"
        '
        'btnChangeUserDetails
        '
        Me.btnChangeUserDetails.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeUserDetails.Location = New System.Drawing.Point(206, 358)
        Me.btnChangeUserDetails.Name = "btnChangeUserDetails"
        Me.btnChangeUserDetails.Size = New System.Drawing.Size(187, 32)
        Me.btnChangeUserDetails.TabIndex = 77
        Me.btnChangeUserDetails.Text = "Change Password"
        Me.btnChangeUserDetails.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(203, 55)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(393, 27)
        Me.txtUsername.TabIndex = 62
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName.Location = New System.Drawing.Point(200, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 20)
        Me.lblName.TabIndex = 64
        Me.lblName.Text = "Name"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailAddress.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEmailAddress.Location = New System.Drawing.Point(675, 33)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(96, 20)
        Me.lblEmailAddress.TabIndex = 70
        Me.lblEmailAddress.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(679, 55)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(391, 27)
        Me.txtEmail.TabIndex = 71
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPosition.Location = New System.Drawing.Point(202, 147)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(56, 20)
        Me.lblPosition.TabIndex = 67
        Me.lblPosition.Text = "Position"
        '
        'txtPosition
        '
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(203, 170)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(393, 27)
        Me.txtPosition.TabIndex = 79
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(427, 358)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(169, 32)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNote.Location = New System.Drawing.Point(200, 310)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(278, 15)
        Me.lblNote.TabIndex = 81
        Me.lblNote.Text = "user can change 'password'  and 'phone number' only."
        '
        'frmCurrentUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1162, 568)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtNRCNo)
        Me.Controls.Add(Me.lblNRCNo)
        Me.Controls.Add(Me.txtMotherName)
        Me.Controls.Add(Me.lblMotherName)
        Me.Controls.Add(Me.txtFatherName)
        Me.Controls.Add(Me.lblFatherName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnChangeUserDetails)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picCurrentUserPhoto)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCurrentUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current User Profile"
        CType(Me.picCurrentUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCurrentUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtNRCNo As System.Windows.Forms.TextBox
    Friend WithEvents lblNRCNo As System.Windows.Forms.Label
    Friend WithEvents txtMotherName As System.Windows.Forms.TextBox
    Friend WithEvents lblMotherName As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As System.Windows.Forms.TextBox
    Friend WithEvents lblFatherName As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnChangeUserDetails As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblNote As System.Windows.Forms.Label
End Class
