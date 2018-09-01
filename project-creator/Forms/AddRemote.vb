Public Class AddRemote
    Private Sub MaskedTextBoxRemoteUrl_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxRemoteUrl.TextChanged
        Dim url As String = Me.MaskedTextBoxRemoteUrl.Text
        Me.LabelExceptionAddRemote.Text = vbEmpty

        Dim remote As Remote = VCS.Parse("origin", url)
        Try
            Me.LabelExceptionAddRemote.Text = IIf(remote.Protocol.Length > 0, remote.Protocol, "")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class