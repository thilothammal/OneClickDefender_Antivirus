Imports System.IO

Public Class prefetch
    Dim i As Integer
    Dim j As Integer
    Dim totalFiles As Integer
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub files_Click(sender As Object, e As EventArgs) Handles lblFileCount.Click


    End Sub

    Private Sub prefetch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim folderPath As String = "C:\Windows\prefetch"
        Try
            ' Check if the directory exists
            If Directory.Exists(folderPath) Then
                ' Get all files in the directory
                Dim files As String() = Directory.GetFiles(folderPath)

                ' Get the total number of files
                totalFiles = files.Length

                ' Update the label's text property
                lblFileCount.Text = $"{totalFiles}"
            Else
                lblFileCount.Text = "The specified folder does not exist."
            End If
        Catch ex As Exception
            lblFileCount.Text = "An error occurred: " & ex.Message
        End Try




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        i = 1
        Timer1.Enabled = False
        Label2.Text = ""
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label2.Text = "Process " & i & "% Completed"
        i += 1

        If i >= 100 Then
            Timer1.Enabled = False

        End If

        If ProgressBar1.Value = 100 Then
            Label2.Text = "Process 100% Completed"
            total.Text = totalFiles
            Timer1.Stop()
            Try
                Dim file As String
                For Each file In System.IO.Directory.GetFiles("C:\Windows\prefetch")
                    System.IO.File.Delete(file)
                Next file
                MsgBox("cache file have been removed", MsgBoxStyle.Information, "One-Click Defender")
            Catch ex As Exception
                MsgBox("Can not delete Prefetch right now!", MsgBoxStyle.Information, "One-Click Defender")
            End Try
        End If
        If ProgressBar1.Value = 100 Then
            detected.Text = totalFiles
            total.Text = totalFiles
        End If

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim folderPath As String = "C:\Windows\prefetch"
        If Directory.Exists(folderPath) Then
            Dim files As String() = Directory.GetFiles(folderPath)
            Dim totalFiles As Integer = files.Length

            j = j + 1
            total.Text = j - 1
            If j > totalFiles Then
                Timer2.Stop()

            End If


        End If

    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub total_Click_1(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Me.WindowState = FormWindowState.Minimized
    End Sub
End Class