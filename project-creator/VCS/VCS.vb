Module VCS
    Public ReadOnly Remotes As Collection = New Collection()

    Public Function AddRemote(Name As String, Url As String) As Remote
        Dim remo = IIf(Parse(Name, Url), New Remote(Name, Url), Nothing)
        Remotes.Add(remo)

        If IsNothing(remo) Then
            Throw New Exception("Remote invalid")
        End If

        Return remo
    End Function

    Public Function Parse(Name As String, Url As String) As Boolean
        Dim Protocol As String
        Dim parsed As String() = Nothing
        Dim sep(4) As Char

        sep(0) = "."
        sep(1) = ":"
        sep(2) = "/"
        sep(3) = "@"

        parsed = Url.Split(sep)

        If parsed(0) = "https" Then
            Protocol = "https"
        ElseIf parsed(0) = "git" Then
            Protocol = "ssh"
        Else
            Protocol = Nothing
        End If


        If IsNothing(Protocol) Then
            Return False
        Else
            Return True
        End If

        'Dim s As String
        'For Each s In parsed
        '    Me.Label1.Text += vbCrLf & " -- " + s

        'Next s
    End Function
End Module
