Public Class PanelRemotes
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DrawRemotes()
    End Sub
    Private Sub ButtonAddRemote_Click(sender As Object, e As EventArgs) Handles ButtonAddRemote.Click
        If AddRemote.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim name As String = AddRemote.TextBoxRemoteName.Text
            Dim url As String = AddRemote.MaskedTextBoxRemoteUrl.Text
            Dim remote As Remote = VCS.AddRemote(name, url)
            DataGridViewRemotes.Rows.Add({remote.Name, remote.Url})
            DrawRemotes()
        End If
    End Sub

    Private Sub DataGridViewRemotes_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewRemotes.RowsRemoved
        VCS.Remotes.Remove(e.RowIndex + 1)

        DrawRemotes()
    End Sub

    Private Sub DrawRemotes()
        Me.Label1.Text = VCS.Remotes.Count

        Me.Panel1.Controls.Clear()

        If VCS.Remotes.Count = 0 Then
            Dim Label = New Label With {
                    .Text = "Not any remotes yet.",
                    .ForeColor = Color.White,
                    .Size = New Size(450, 25)
                }
            Me.Panel1.Controls.Add(Label)
        Else
            Dim i As Int16 = 0

            For Each item As Remote In VCS.Remotes
                Dim Label = New Label With {
                    .Text = item.Name + "  " + item.Url,
                    .ForeColor = Color.White,
                    .Top = i * 25,
                    .Size = New Size(450, 25)
                }
                Me.Panel1.Controls.Add(Label)
                i += 1
            Next
        End If

        FormMain.Size = New Size(FormMain.Size.Width, FormMain.Size.Height + Me.Size.Height)
    End Sub
End Class
