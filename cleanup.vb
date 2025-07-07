Imports System.Threading
Imports System.IO

Public Class cleanup
    Dim i As Integer
    Dim j As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        prefetch.Show()
        prefetch.Timer1.Enabled = True
        prefetch.Timer2.Enabled = True
        prefetch.ProgressBar1.Maximum = 100
        prefetch.ProgressBar2.Maximum = 100

        i = 1
        j = 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        profile.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        prefetch.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        profile.Show()

    End Sub
End Class
