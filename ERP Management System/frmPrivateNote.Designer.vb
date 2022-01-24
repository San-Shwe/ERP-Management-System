<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrivateNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrivateNote))
        Me.richtxtPrivateNote = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'richtxtPrivateNote
        '
        Me.richtxtPrivateNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.richtxtPrivateNote.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.richtxtPrivateNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richtxtPrivateNote.Location = New System.Drawing.Point(12, 12)
        Me.richtxtPrivateNote.Name = "richtxtPrivateNote"
        Me.richtxtPrivateNote.Size = New System.Drawing.Size(545, 324)
        Me.richtxtPrivateNote.TabIndex = 0
        Me.richtxtPrivateNote.Text = ""
        '
        'frmPrivateNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 348)
        Me.Controls.Add(Me.richtxtPrivateNote)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPrivateNote"
        Me.Text = "Private Note"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents richtxtPrivateNote As System.Windows.Forms.RichTextBox
End Class
