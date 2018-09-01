Imports System.IO

Public Class Project
    Private Property _Path As DirectoryInfo = _DEFAULT_PATH
    Public Property _Name As String = ""

    Public Function GetProjectsPath() As String
        Try : Return _Path.FullName
        Catch e As Exception : Return ""
        End Try
    End Function

    Public Sub SetProjectsPath(path As String)
        _Path = New DirectoryInfo(path)
        If Not _Path.Exists Then : Throw New Exception("Projects directory doesn't set")
        End If
    End Sub

    Public Sub SetProjectName(name As String)
        If ProjectNameIsAvailable(name, _Path) Then : _Name = name
        Else
            _Name = ""
            Throw New Exception("Already exist '" + name + "'")
        End If
    End Sub

    Public Sub CreateProjectDirectory()
        Try : _Path.CreateSubdirectory(_Name)
        Catch e As Exception : Throw e
        End Try
    End Sub
End Class
