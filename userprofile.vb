Public Class userprofile

    Private Sub userprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            imgprofile.Image = Image.FromFile(My.Settings.image.ToString)
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Dim pImage As Object
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Settings.name = txtName.Text
        My.Settings.email = txtEmail.Text
        My.Settings.image = pImage
        My.Settings.Save()
        If txtName.Text = Nothing And txtEmail.Text = Nothing Then
            MsgBox("pls fill all the provided spaces before continue", MsgBoxStyle.Critical)
        ElseIf txtName.Text = Nothing Then
            MsgBox("No Name Found!", MsgBoxStyle.Critical)
        ElseIf txtEmail.Text = Nothing Then
            MsgBox("No Email Found!", MsgBoxStyle.Critical)
        Else
            lblName.Text = My.Settings.name
            lblEmail.Text = My.Settings.email
            MsgBox("All Settings Uptaded Successfully!", MsgBoxStyle.Information)
            lblKey.Text = My.Settings.key

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim odf As New OpenFileDialog
        If odf.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgprofile.Image = Image.FromFile(odf.FileName)
            pImage = odf.FileName.ToString

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class