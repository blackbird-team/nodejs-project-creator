Public Class Remote
    Public Property Url As String
    Public Property Protocol As String
    Public Sub parse(Url As String)
        Me.Url = Url

        Dim parsed As String() = Nothing
        Dim sep(4) As Char

        sep(0) = "."
        sep(1) = ":"
        sep(2) = "/"
        sep(3) = "@"

        parsed = Url.Split(sep)

        Dim s As String

        If parsed(0) = "https" Then
            Me.Protocol = "https"
        ElseIf parsed(0) = "git" Then
            Me.Protocol = "ssh"
        Else
            Me.Protocol = "invalid"
        End If

        'For Each s In parsed
        '    Me.Label1.Text += vbCrLf & " -- " + s

        'Next s
    End Sub
End Class
