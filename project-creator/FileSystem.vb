Imports System.IO

Module FileSystem
    Private Property _DEFAULT_PATH = New DirectoryInfo("C:\\Projects\\node")
    Private Property _PATH As DirectoryInfo = Nothing
    Private Property _NAME As String = ""

    Public Function GetProjectsPath() As String
        Try
            Return _PATH.FullName
        Catch e As Exception
            _PATH = _DEFAULT_PATH
            Return _DEFAULT_PATH.FullName
        End Try
    End Function

    Public Sub SetProjectsPath(path As String)
        _PATH = New DirectoryInfo(path)
        ProjectDirectoryValidate()
    End Sub

    Public Sub SetProjectName(name As String)
        _NAME = name
        ProjectNameIsAvailable()
    End Sub

    Public Sub CreateProjectDirectory()
        Try
            _PATH.CreateSubdirectory(_NAME)
        Catch e As Exception
            FormMain.LabelExceptionProjectName.Text = e.ToString()
            FormMain.LabelExceptionProjectName.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub ProjectDirectoryValidate()
        If _PATH.Exists = True Then
            FormMain.LabelProjectsPath.Text = _PATH.FullName
            FormMain.LabelProjectsPath.ForeColor = Color.White
        Else
            FormMain.LabelProjectsPath.Text = "Projects directory doesn't set"
            FormMain.LabelProjectsPath.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ProjectNameIsAvailable()
        If _NAME.Length < 3 Then
            Return
        End If

        Dim subDirs = _PATH.EnumerateDirectories()

        Dim isExist As Boolean = False
        For Each value As DirectoryInfo In subDirs
            If value.Name = _NAME Then
                isExist = True
            End If
        Next

        If isExist = False Then
            FormMain.LabelExceptionProjectName.Text = ""
        Else
            FormMain.LabelExceptionProjectName.Text = "Already exist '" + _NAME + "'"
            _NAME = ""
        End If
    End Sub
End Module
