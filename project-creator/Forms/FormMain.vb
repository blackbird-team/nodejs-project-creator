Public Class FormMain
    Private Project As New Project()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ResetFormMain()
    End Sub

    Private Sub ResetFormMain()
        Me.LabelProjectsPath.Text = Project.GetProjectsPath()

        TextBoxProjectName.Select()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Try
            Project.CreateProjectDirectory()
        Catch ex As Exception
            Throw ex
            Me.LabelExceptionProjectName.Text = e.ToString()
            Me.LabelExceptionProjectName.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub ButtonChangeProjectsPath_Click(sender As Object, e As EventArgs) Handles ButtonChangeProjectsPath.Click
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Project.SetProjectsPath(FolderBrowserDialog1.SelectedPath)
                Me.LabelProjectsPath.Text = Project.GetProjectsPath()
                Me.LabelProjectsPath.ForeColor = Color.White
            Catch ex As Exception
                Me.LabelProjectsPath.Text = ex.Message
                Me.LabelProjectsPath.ForeColor = Color.Red
            End Try

        End If
    End Sub

    Private Sub TextBoxProjectName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxProjectName.TextChanged
        Try
            Project.SetProjectName(Me.TextBoxProjectName.Text)
            Me.LabelExceptionProjectName.Text = ""
        Catch ex As Exception
            Me.LabelExceptionProjectName.Text = ex.Message
        End Try

    End Sub

    Private Sub ButtonAddRemote_Click(sender As Object, e As EventArgs) Handles ButtonAddRemote.Click
        If AddRemote.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim name As String = AddRemote.TextBoxRemoteName.Text
            Dim url As String = AddRemote.MaskedTextBoxRemoteUrl.Text
            Dim remote As Remote = VCS.AddRemote(name, url)
            DataGridViewRemotes.Rows.Add({remote.Name, remote.Url})
            DrawRemotes()
        End If
    End Sub

    Private Sub DataGridViewRemotes_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewRemotes.RowsRemoved
        VCS.Remotes.Remove(e.RowIndex + 1)

        DrawRemotes()
    End Sub

    Private Sub DrawRemotes()
        Me.Label1.Text = VCS.Remotes.Count
    End Sub
End Class
