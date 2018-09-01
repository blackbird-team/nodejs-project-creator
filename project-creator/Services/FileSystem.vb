Imports System.IO

Module FileSystem
    Public ReadOnly Property _DEFAULT_PATH = New DirectoryInfo("C:\\Projects\\node")

    Public Function ProjectNameIsAvailable(name As String, ByRef path As DirectoryInfo) As Boolean
        Dim subDirs = path.EnumerateDirectories()

        Dim isExist As Boolean = False
        For Each value As DirectoryInfo In subDirs
            If value.Name = name Then : isExist = True
            End If
        Next

        Return Not isExist
    End Function
End Module
