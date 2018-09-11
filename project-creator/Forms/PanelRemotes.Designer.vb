<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelRemotes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelVCSTitle = New System.Windows.Forms.Label()
        Me.DataGridViewRemotes = New System.Windows.Forms.DataGridView()
        Me.NameRemote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrlRemote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAddRemote = New System.Windows.Forms.Button()
        CType(Me.DataGridViewRemotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(3, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 2)
        Me.Panel1.TabIndex = 18
        '
        'LabelVCSTitle
        '
        Me.LabelVCSTitle.AutoSize = True
        Me.LabelVCSTitle.Font = New System.Drawing.Font("HelveticaNeueLT W1G 35 Th", 18.0!)
        Me.LabelVCSTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.LabelVCSTitle.Location = New System.Drawing.Point(-2, 10)
        Me.LabelVCSTitle.Name = "LabelVCSTitle"
        Me.LabelVCSTitle.Size = New System.Drawing.Size(245, 27)
        Me.LabelVCSTitle.TabIndex = 22
        Me.LabelVCSTitle.Text = "Control Version System"
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
        Me.DataGridViewRemotes.Location = New System.Drawing.Point(3, 57)
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
        Me.DataGridViewRemotes.TabIndex = 21
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(10, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'ButtonAddRemote
        '
        Me.ButtonAddRemote.FlatAppearance.BorderSize = 0
        Me.ButtonAddRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddRemote.Font = New System.Drawing.Font("HelveticaNeueLT W1G 65 Md", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonAddRemote.ForeColor = System.Drawing.Color.White
        Me.ButtonAddRemote.Location = New System.Drawing.Point(345, 12)
        Me.ButtonAddRemote.Name = "ButtonAddRemote"
        Me.ButtonAddRemote.Size = New System.Drawing.Size(110, 30)
        Me.ButtonAddRemote.TabIndex = 19
        Me.ButtonAddRemote.Text = "Add remote"
        Me.ButtonAddRemote.UseVisualStyleBackColor = True
        '
        'PanelRemotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.LabelVCSTitle)
        Me.Controls.Add(Me.DataGridViewRemotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAddRemote)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PanelRemotes"
        Me.Size = New System.Drawing.Size(456, 251)
        CType(Me.DataGridViewRemotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelVCSTitle As Label
    Friend WithEvents DataGridViewRemotes As DataGridView
    Friend WithEvents NameRemote As DataGridViewTextBoxColumn
    Friend WithEvents UrlRemote As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAddRemote As Button
End Class
