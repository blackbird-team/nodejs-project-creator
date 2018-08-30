Public Class FormMain
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ResetFormMain()
    End Sub

    Private Sub ResetFormMain()
        Me.LabelProjectsPath.Text = GetProjectsPath()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        CreateProjectDirectory()
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub ButtonChangeProjectsPath_Click(sender As Object, e As EventArgs) Handles ButtonChangeProjectsPath.Click
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SetProjectsPath(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub TextBoxProjectName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxProjectName.TextChanged
        SetProjectName(Me.TextBoxProjectName.Text.ToString())
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim url As String = Me.TextBox1.Text.ToString()

        Dim remote As Remote = New Remote()

        Me.Label1.Text = vbEmpty

        remote.parse(url)
        Me.Label1.Text = remote.Protocol
    End Sub
End Class
