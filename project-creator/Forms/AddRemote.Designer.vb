<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemote
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
        Me.TextBoxRemoteName = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxRemoteUrl = New System.Windows.Forms.MaskedTextBox()
        Me.LabelRemoteName = New System.Windows.Forms.Label()
        Me.LabelRemoteUrl = New System.Windows.Forms.Label()
        Me.LabelExceptionAddRemote = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxRemoteName
        '
        Me.TextBoxRemoteName.Location = New System.Drawing.Point(147, 54)
        Me.TextBoxRemoteName.Name = "TextBoxRemoteName"
        Me.TextBoxRemoteName.Size = New System.Drawing.Size(287, 20)
        Me.TextBoxRemoteName.TabIndex = 0
        '
        'MaskedTextBoxRemoteUrl
        '
        Me.MaskedTextBoxRemoteUrl.Location = New System.Drawing.Point(147, 108)
        Me.MaskedTextBoxRemoteUrl.Name = "MaskedTextBoxRemoteUrl"
        Me.MaskedTextBoxRemoteUrl.Size = New System.Drawing.Size(287, 20)
        Me.MaskedTextBoxRemoteUrl.TabIndex = 1
        '
        'LabelRemoteName
        '
        Me.LabelRemoteName.AutoSize = True
        Me.LabelRemoteName.Location = New System.Drawing.Point(30, 60)
        Me.LabelRemoteName.Name = "LabelRemoteName"
        Me.LabelRemoteName.Size = New System.Drawing.Size(103, 13)
        Me.LabelRemoteName.TabIndex = 2
        Me.LabelRemoteName.Text = "Enter Remote Name"
        '
        'LabelRemoteUrl
        '
        Me.LabelRemoteUrl.AutoSize = True
        Me.LabelRemoteUrl.Location = New System.Drawing.Point(30, 111)
        Me.LabelRemoteUrl.Name = "LabelRemoteUrl"
        Me.LabelRemoteUrl.Size = New System.Drawing.Size(97, 13)
        Me.LabelRemoteUrl.TabIndex = 3
        Me.LabelRemoteUrl.Text = "Enter Remote URL"
        '
        'LabelExceptionAddRemote
        '
        Me.LabelExceptionAddRemote.AutoSize = True
        Me.LabelExceptionAddRemote.Location = New System.Drawing.Point(190, 160)
        Me.LabelExceptionAddRemote.Name = "LabelExceptionAddRemote"
        Me.LabelExceptionAddRemote.Size = New System.Drawing.Size(39, 13)
        Me.LabelExceptionAddRemote.TabIndex = 4
        Me.LabelExceptionAddRemote.Text = "Label3"
        '
        'ButtonOk
        '
        Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOk.Location = New System.Drawing.Point(179, 187)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 5
        Me.ButtonOk.Text = "Add"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(274, 187)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'AddRemote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 225)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.LabelExceptionAddRemote)
        Me.Controls.Add(Me.LabelRemoteUrl)
        Me.Controls.Add(Me.LabelRemoteName)
        Me.Controls.Add(Me.MaskedTextBoxRemoteUrl)
        Me.Controls.Add(Me.TextBoxRemoteName)
        Me.Name = "AddRemote"
        Me.Text = "AddRemote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxRemoteName As TextBox
    Friend WithEvents MaskedTextBoxRemoteUrl As MaskedTextBox
    Friend WithEvents LabelRemoteName As Label
    Friend WithEvents LabelRemoteUrl As Label
    Friend WithEvents LabelExceptionAddRemote As Label
    Friend WithEvents ButtonOk As Button
    Friend WithEvents ButtonCancel As Button
End Class
