Public Class speedup
    Dim i, ss As Integer
    Dim tt = 4
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Public Sub FlushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = Process.GetProcessesByName("ApplicationName")
                Dim myProcess As Process
                'Dim ProcessInfo As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer1.Start()
        Timer3.Start()

        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar4.Value = 0
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        ProgressBar2.Increment(1)
        ProgressBar4.Increment(1)


        Label9.Text = "Scanning....."
        Label15.Text = "Yet to Boost" & vbCrLf & "your computer "
        Label13.Text = i & "% Completed"
        i += 1
        If i >= 100 Then
            Timer1.Enabled = False
            Timer3.Enabled = False
            i = 0
        End If

        If ProgressBar1.Value = 100 Then
            FlushMemory()
            Label15.Text = "Boost completed"
            Label9.Text = "Scanning" & vbCrLf & "Completed"
            Label13.Text = "100% Completed"
            Label11.Text = "00:00"
        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        i = 4
        Label11.Text = i & "sec"
        i = i - 1
        If ProgressBar1.Value = 100 Then
            Timer3.Enabled = False

        End If
    End Sub
End Class
