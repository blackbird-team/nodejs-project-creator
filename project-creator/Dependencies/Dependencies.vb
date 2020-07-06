Public Class Dependencies
    Public Categories As Collection = New Collection()

    Public Sub AddCategory(Category As Category)
        Categories.Add(Category, Category.Primary.Name)
    End Sub

    Public Sub RemoveCategory(name As String)
        Categories.Remove(name)
    End Sub

    Public Sub AddDep(Category As String, Dep As Dependency)
        Dim Cat As Category = Categories.Item(Category)
        If IsNothing(Cat) Then
            AddCategory(New Category(Dep))
        Else
            Cat.Add(Dep)
        End If
    End Sub
End Class
