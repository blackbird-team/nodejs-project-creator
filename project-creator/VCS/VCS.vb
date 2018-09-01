Module VCS
    Public ReadOnly Remotes() As Remote

    Public Sub AddRemote(Name As String, Url As String)
        'Remotes.
    End Sub

    Public Function Parse(Name As String, Url As String) As Remote
        Dim Protocol As String
        Dim parsed As String() = Nothing
        Dim sep(4) As Char

        sep(0) = "."
        sep(1) = ":"
        sep(2) = "/"
        sep(3) = "@"

        parsed = Url.Split(sep)

        Dim s As String

        If parsed(0) = "https" Then
            Protocol = "https"
        ElseIf parsed(0) = "git" Then
            Protocol = "ssh"
        Else
            Protocol = Nothing
        End If


        If IsNothing(Protocol) Then
            Return Nothing
        Else
            Return New Remote(Name, Url, Protocol)
        End If

        'For Each s In parsed
        '    Me.Label1.Text += vbCrLf & " -- " + s

        'Next s
    End Function
End Module
