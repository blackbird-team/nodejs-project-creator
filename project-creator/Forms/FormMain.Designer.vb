<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.TextBoxProjectName = New System.Windows.Forms.TextBox()
        Me.TextBoxProjectVersion = New System.Windows.Forms.TextBox()
        Me.LabelProjectsPath = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonChangeProjectsPath = New System.Windows.Forms.Button()
        Me.LabelProjectsDirectory = New System.Windows.Forms.Label()
        Me.LabelProjectName = New System.Windows.Forms.Label()
        Me.LabelExceptionProjectName = New System.Windows.Forms.Label()
        Me.ButtonAddRemote = New System.Windows.Forms.Button()
        Me.LabelProjectVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewRemotes = New System.Windows.Forms.DataGridView()
        Me.NameRemote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrlRemote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelVCSTitle = New System.Windows.Forms.Label()
        CType(Me.DataGridViewRemotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.LabelTitle.Location = New System.Drawing.Point(12, 18)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(223, 38)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Project Creator"
        '
        'ButtonExit
        '
        Me.ButtonExit.FlatAppearance.BorderSize = 0
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("HelveticaNeueLT W1G 65 Md", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.White
        Me.ButtonExit.Location = New System.Drawing.Point(409, 0)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 30)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonCreate
        '
        Me.ButtonCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ButtonCreate.FlatAppearance.BorderSize = 0
        Me.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCreate.Font = New System.Drawing.Font("HelveticaNeueLT W1G 65 Md", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ButtonCreate.Location = New System.Drawing.Point(141, 682)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(175, 45)
        Me.ButtonCreate.TabIndex = 4
        Me.ButtonCreate.Text = "Create"
        Me.ButtonCreate.UseVisualStyleBackColor = False
        '
        'TextBoxProjectName
        '
        Me.TextBoxProjectName.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.TextBoxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxProjectName.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBoxProjectName.ForeColor = System.Drawing.Color.White
        Me.TextBoxProjectName.Location = New System.Drawing.Point(164, 121)
        Me.TextBoxProjectName.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBoxProjectName.Name = "TextBoxProjectName"
        Me.TextBoxProjectName.Size = New System.Drawing.Size(175, 24)
        Me.TextBoxProjectName.TabIndex = 5
        '
        'TextBoxProjectVersion
        '
        Me.TextBoxProjectVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.TextBoxProjectVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxProjectVersion.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBoxProjectVersion.ForeColor = System.Drawing.Color.White
        Me.TextBoxProjectVersion.Location = New System.Drawing.Point(164, 166)
        Me.TextBoxProjectVersion.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBoxProjectVersion.Name = "TextBoxProjectVersion"
        Me.TextBoxProjectVersion.Size = New System.Drawing.Size(175, 24)
        Me.TextBoxProjectVersion.TabIndex = 13
        Me.TextBoxProjectVersion.Text = "0.0.1-alpha"
        '
        'LabelProjectsPath
        '
        Me.LabelProjectsPath.AutoSize = True
        Me.LabelProjectsPath.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelProjectsPath.ForeColor = System.Drawing.Color.White
        Me.LabelProjectsPath.Location = New System.Drawing.Point(160, 80)
        Me.LabelProjectsPath.Name = "LabelProjectsPath"
        Me.LabelProjectsPath.Size = New System.Drawing.Size(0, 19)
        Me.LabelProjectsPath.TabIndex = 7
        '
        'ButtonChangeProjectsPath
        '
        Me.ButtonChangeProjectsPath.FlatAppearance.BorderSize = 0
        Me.ButtonChangeProjectsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonChangeProjectsPath.Font = New System.Drawing.Font("HelveticaNeueLT W1G 65 Md", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonChangeProjectsPath.ForeColor = System.Drawing.Color.White
        Me.ButtonChangeProjectsPath.Location = New System.Drawing.Point(365, 75)
        Me.ButtonChangeProjectsPath.Name = "ButtonChangeProjectsPath"
        Me.ButtonChangeProjectsPath.Size = New System.Drawing.Size(110, 30)
        Me.ButtonChangeProjectsPath.TabIndex = 8
        Me.ButtonChangeProjectsPath.Text = "Change path"
        Me.ButtonChangeProjectsPath.UseVisualStyleBackColor = True
        '
        'LabelProjectsDirectory
        '
        Me.LabelProjectsDirectory.AutoSize = True
        Me.LabelProjectsDirectory.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelProjectsDirectory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.LabelProjectsDirectory.Location = New System.Drawing.Point(20, 80)
        Me.LabelProjectsDirectory.Name = "LabelProjectsDirectory"
        Me.LabelProjectsDirectory.Size = New System.Drawing.Size(123, 18)
        Me.LabelProjectsDirectory.TabIndex = 9
        Me.LabelProjectsDirectory.Text = "Projects Directory"
        '
        'LabelProjectName
        '
        Me.LabelProjectName.AutoSize = True
        Me.LabelProjectName.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.LabelProjectName.Location = New System.Drawing.Point(20, 121)
        Me.LabelProjectName.Name = "LabelProjectName"
        Me.LabelProjectName.Size = New System.Drawing.Size(97, 18)
        Me.LabelProjectName.TabIndex = 10
        Me.LabelProjectName.Text = "Project Name"
        '
        'LabelExceptionProjectName
        '
        Me.LabelExceptionProjectName.AutoSize = True
        Me.LabelExceptionProjectName.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelExceptionProjectName.ForeColor = System.Drawing.Color.Red
        Me.LabelExceptionProjectName.Location = New System.Drawing.Point(160, 140)
        Me.LabelExceptionProjectName.Name = "LabelExceptionProjectName"
        Me.LabelExceptionProjectName.Size = New System.Drawing.Size(0, 18)
        Me.LabelExceptionProjectName.TabIndex = 11
        '
        'ButtonAddRemote
        '
        Me.ButtonAddRemote.FlatAppearance.BorderSize = 0
        Me.ButtonAddRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddRemote.Font = New System.Drawing.Font("HelveticaNeueLT W1G 65 Md", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonAddRemote.ForeColor = System.Drawing.Color.White
        Me.ButtonAddRemote.Location = New System.Drawing.Point(365, 265)
        Me.ButtonAddRemote.Name = "ButtonAddRemote"
        Me.ButtonAddRemote.Size = New System.Drawing.Size(110, 30)
        Me.ButtonAddRemote.TabIndex = 12
        Me.ButtonAddRemote.Text = "Add remote"
        Me.ButtonAddRemote.UseVisualStyleBackColor = True
        '
        'LabelProjectVersion
        '
        Me.LabelProjectVersion.AutoSize = True
        Me.LabelProjectVersion.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelProjectVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.LabelProjectVersion.Location = New System.Drawing.Point(20, 166)
        Me.LabelProjectVersion.Name = "LabelProjectVersion"
        Me.LabelProjectVersion.Size = New System.Drawing.Size(105, 18)
        Me.LabelProjectVersion.TabIndex = 14
        Me.LabelProjectVersion.Text = "Project Version"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(20, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'DataGridViewRemotes
        '
        Me.DataGridViewRemotes.AllowUserToAddRows = False
        Me.DataGridViewRemotes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridViewRemotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 15.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRemotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRemotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRemotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameRemote, Me.UrlRemote})
        Me.DataGridViewRemotes.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridViewRemotes.Location = New System.Drawing.Point(23, 310)
        Me.DataGridViewRemotes.Name = "DataGridViewRemotes"
        Me.DataGridViewRemotes.ReadOnly = True
        Me.DataGridViewRemotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRemotes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("HelveticaNeueLT W1G 45 Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DataGridViewRemotes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewRemotes.RowTemplate.Height = 35
        Me.DataGridViewRemotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewRemotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRemotes.Size = New System.Drawing.Size(450, 126)
        Me.DataGridViewRemotes.TabIndex = 16
        '
        'NameRemote
        '
        Me.NameRemote.HeaderText = "Name"
        Me.NameRemote.Name = "NameRemote"
        Me.NameRemote.ReadOnly = True
        Me.NameRemote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NameRemote.Width = 120
        '
        'UrlRemote
        '
        Me.UrlRemote.HeaderText = "Url"
        Me.UrlRemote.Name = "UrlRemote"
        Me.UrlRemote.ReadOnly = True
        Me.UrlRemote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UrlRemote.Width = 270
        '
        'LabelVCSTitle
        '
        Me.LabelVCSTitle.AutoSize = True
        Me.LabelVCSTitle.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 18.0!)
        Me.LabelVCSTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.LabelVCSTitle.Location = New System.Drawing.Point(18, 263)
        Me.LabelVCSTitle.Name = "LabelVCSTitle"
        Me.LabelVCSTitle.Size = New System.Drawing.Size(245, 27)
        Me.LabelVCSTitle.TabIndex = 17
        Me.LabelVCSTitle.Text = "Control Version System"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelVCSTitle)
        Me.Controls.Add(Me.DataGridViewRemotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelProjectVersion)
        Me.Controls.Add(Me.TextBoxProjectVersion)
        Me.Controls.Add(Me.ButtonAddRemote)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.LabelExceptionProjectName)
        Me.Controls.Add(Me.LabelProjectName)
        Me.Controls.Add(Me.LabelProjectsDirectory)
        Me.Controls.Add(Me.ButtonChangeProjectsPath)
        Me.Controls.Add(Me.LabelProjectsPath)
        Me.Controls.Add(Me.TextBoxProjectName)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.ButtonExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 750)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 750)
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FormMain"
        CType(Me.DataGridViewRemotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents LabelProjectsPath As Label
    Friend WithEvents ButtonChangeProjectsPath As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LabelProjectsDirectory As Label
    Friend WithEvents LabelProjectName As Label
    Friend WithEvents LabelExceptionProjectName As Label
    Friend WithEvents TextBoxProjectName As TextBox
    Friend WithEvents LabelProjectVersion As Label
    Friend WithEvents TextBoxProjectVersion As TextBox
    Friend WithEvents ButtonAddRemote As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewRemotes As DataGridView
    Friend WithEvents NameRemote As DataGridViewTextBoxColumn
    Friend WithEvents UrlRemote As DataGridViewTextBoxColumn
    Friend WithEvents LabelVCSTitle As Label
End Class
