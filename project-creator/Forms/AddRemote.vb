Public Class AddRemote
    Private Sub MaskedTextBoxRemoteUrl_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxRemoteUrl.TextChanged
        Me.LabelExceptionAddRemote.Text = vbEmpty
        IsValid()
    End Sub

    Private Sub TextBoxRemoteName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRemoteName.TextChanged
        Me.LabelRemoteNameException.Text = IIf(Me.TextBoxRemoteName.Text.Length < 1, "Name can't be undefined", "")
        IsValid()
    End Sub

    Private Sub IsValid()
        Dim check As Boolean = Me.LabelRemoteNameException.Text.Length = 0 And Me.LabelRemoteUrlException.Text.Length = 0
        Me.ButtonOk.Enabled = check
    End Sub
End Class