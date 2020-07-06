Public Class Category
    Public Primary As Dependency
    Public Deps As List(Of Dependency) = New List(Of Dependency)

    Public Sub New(Primary As Dependency)
        Me.Primary = Primary
    End Sub

    Public Sub Add(Dependency As Dependency)
        If Not Deps.Contains(Dependency) Then
            Deps.Add(Dependency)
        End If
    End Sub

    Public Sub Remove(Dependency As Dependency)
        Deps.Remove(Dependency)
    End Sub
End Class
