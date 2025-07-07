Public Class auth
    Private Sub auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtEmail_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtEmail.MaskInputRejected

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEmail.Text = Nothing Then
            MsgBox("pls Enter password", MsgBoxStyle.Critical)
        ElseIf txtEmail.Text = "Sri.2363#" Then
            Label4.Text = "We're in the process of loading a substantial database." & vbCrLf & "           Thank you for your patience.Please Wait....."
            viruslist.Show()
            Me.Hide()

        Else
            MsgBox("Password is incorrect pls try again", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class