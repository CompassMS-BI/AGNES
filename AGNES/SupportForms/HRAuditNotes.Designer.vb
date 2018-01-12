<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAuditNotes
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNoteHeader = New System.Windows.Forms.Label()
        Me.rtxtNotes = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.OldLace
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(413, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblNoteHeader
        '
        Me.lblNoteHeader.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteHeader.Location = New System.Drawing.Point(12, 7)
        Me.lblNoteHeader.Name = "lblNoteHeader"
        Me.lblNoteHeader.Size = New System.Drawing.Size(876, 22)
        Me.lblNoteHeader.TabIndex = 4
        Me.lblNoteHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtxtNotes
        '
        Me.rtxtNotes.Location = New System.Drawing.Point(12, 32)
        Me.rtxtNotes.Name = "rtxtNotes"
        Me.rtxtNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtxtNotes.Size = New System.Drawing.Size(876, 227)
        Me.rtxtNotes.TabIndex = 3
        Me.rtxtNotes.Text = ""
        '
        'HRAuditNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(900, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblNoteHeader)
        Me.Controls.Add(Me.rtxtNotes)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(900, 300)
        Me.MinimumSize = New System.Drawing.Size(900, 300)
        Me.Name = "HRAuditNotes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HRAuditNotes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblNoteHeader As Label
    Friend WithEvents rtxtNotes As RichTextBox
End Class
