Imports OneClick_defender.My

Public Class register
    Dim key As String = "9080-3837-2094-8627-9779"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtEmail.Text = Nothing And mtxtkey.Text = Nothing Then
            MsgBox("pls fill all the provided spaces before continue", MsgBoxStyle.Critical)
        ElseIf txtEmail.Text = Nothing Then
            MsgBox("No Email Found!", MsgBoxStyle.Critical)
        ElseIf mtxtkey.Text = Nothing Then
            MsgBox("No key Found!", MsgBoxStyle.Critical)
        ElseIf mtxtkey.Text = key Then
            My.Settings.email = txtEmail.Text
            My.Settings.key = mtxtkey.Text
            My.Settings.Save()
            Form1.Label14.Text = "STS ANTI-VIRUS SOFTWARE - PRE ACTIVATED"
            Form1.btnPreium.Visible = False
            Form1.btnTrialVersion.Location = New Point(125, 44)
            MsgBox("Activation Key Accepted! Thank you for purchasing our software", MsgBoxStyle.Information)
            Me.Hide()
            Form1.Show()



        Else
            MsgBox("Invalid Activation key provided! Please Try again!,", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class