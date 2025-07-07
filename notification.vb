﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class notification
    Private Sub notification_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Visible = True

        Form1.Timer3.Start()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Me.ShowInTaskbar = False
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        If Form1.ProgressBar2.Value = 50 Then
            Form1.Timer3.Stop()
            Timer1.Start()
            Timer2.Start()
            Form1.Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0.2 Then
            Me.Hide()
            Form1.ProgressBar1.Value = 0
            Form1.Timer2.Interval = 50
            Form1.Timer2.Start()

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer1.Start()
        Timer2.Start()
        Form1.Timer3.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        quick_scan.Show()
        Form1.Timer3.Stop()


    End Sub
End Class