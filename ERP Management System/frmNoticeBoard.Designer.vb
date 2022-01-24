<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoticeBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNoticeBoard))
        Me.richNoteText = New System.Windows.Forms.RichTextBox
        Me.lblUsername = New System.Windows.Forms.Label
        Me.lblPosition = New System.Windows.Forms.Label
        Me.lblDatetime = New System.Windows.Forms.Label
        Me.picPosition = New System.Windows.Forms.PictureBox
        CType(Me.picPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'richNoteText
        '
        Me.richNoteText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.richNoteText.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.richNoteText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richNoteText.Font = New System.Drawing.Font("Pyidaungsu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richNoteText.ForeColor = System.Drawing.Color.Black
        Me.richNoteText.Location = New System.Drawing.Point(72, 97)
        Me.richNoteText.Name = "richNoteText"
        Me.richNoteText.Size = New System.Drawing.Size(500, 325)
        Me.richNoteText.TabIndex = 0
        Me.richNoteText.Text = ""
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Maroon
        Me.lblUsername.Location = New System.Drawing.Point(69, 31)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 17)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "User Name"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(69, 58)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(51, 17)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = "position"
        '
        'lblDatetime
        '
        Me.lblDatetime.AutoSize = True
        Me.lblDatetime.BackColor = System.Drawing.Color.Transparent
        Me.lblDatetime.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatetime.ForeColor = System.Drawing.Color.Black
        Me.lblDatetime.Location = New System.Drawing.Point(481, 58)
        Me.lblDatetime.Name = "lblDatetime"
        Me.lblDatetime.Size = New System.Drawing.Size(32, 17)
        Me.lblDatetime.TabIndex = 3
        Me.lblDatetime.Text = "date"
        '
        'picPosition
        '
        Me.picPosition.BackColor = System.Drawing.Color.Transparent
        Me.picPosition.BackgroundImage = CType(resources.GetObject("picPosition.BackgroundImage"), System.Drawing.Image)
        Me.picPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPosition.Image = CType(resources.GetObject("picPosition.Image"), System.Drawing.Image)
        Me.picPosition.Location = New System.Drawing.Point(602, 431)
        Me.picPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picPosition.Name = "picPosition"
        Me.picPosition.Size = New System.Drawing.Size(31, 30)
        Me.picPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPosition.TabIndex = 30
        Me.picPosition.TabStop = False
        '
        'frmNoticeBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 472)
        Me.Controls.Add(Me.picPosition)
        Me.Controls.Add(Me.lblDatetime)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.richNoteText)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNoticeBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notice Board"
        CType(Me.picPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents richNoteText As System.Windows.Forms.RichTextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblDatetime As System.Windows.Forms.Label
    Private WithEvents picPosition As System.Windows.Forms.PictureBox
End Class
