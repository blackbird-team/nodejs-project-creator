Public Class Remote
    Public Property Name As String
    Public Property Url As String
    Public Property Protocol As String

    Public Sub New(Name As String, Url As String, Protocol As String)
        Me.Name = Name
        Me.Url = Url
        Me.Protocol = Protocol
    End Sub
End Class
