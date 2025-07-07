
Public Class Form1
    Dim i As Integer = 0
    Dim j As Integer

#Region "Global Variables"
    Dim point As New System.Drawing.Point
    Dim X, Y As Integer
#End Region
#Region "GUI"
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            point = Control.MousePosition
            point.X = point.X - (X)
            point.Y = point.Y - (Y)
            Me.Location = point

        End If
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y

    End Sub
#End Region
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close1.Visible = True
        Close1.BringToFront()
    End Sub

    Private Sub btnFull_Check_Click(sender As Object, e As EventArgs) Handles btnFull_Check.Click
        If Settings1.cmbThemes.Text = "Dark Theme" Then
            Full_check1.BringToFront()
            btnFull_Check.BackColor = Color.White
            btnFull_Check.ForeColor = Color.Black
            btnVirusScan.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Full_check1.BringToFront()
                btnFull_Check.BackColor = Color.Black
                btnFull_Check.ForeColor = Color.White
                btnVirusScan.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Full_check1.BringToFront()
                    btnFull_Check.BackColor = Color.Red
                    btnFull_Check.ForeColor = Color.White
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If
    End Sub

    Private Sub btnVirusScan_Click(sender As Object, e As EventArgs) Handles btnVirusScan.Click


        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Scan1.BringToFront()
            btnVirusScan.BackColor = Color.White
            btnVirusScan.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Scan1.BringToFront()
                btnVirusScan.BackColor = Color.Black
                btnVirusScan.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Scan1.BringToFront()
                    btnVirusScan.BackColor = Color.Red
                    btnVirusScan.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If

    End Sub

    Private Sub btnSpeedUp_Click(sender As Object, e As EventArgs) Handles btnSpeedUp.Click



        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Speedup1.BringToFront()
            btnSpeedUp.BackColor = Color.White
            btnSpeedUp.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnVirusScan.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Speedup1.BringToFront()
                btnSpeedUp.BackColor = Color.Black
                btnSpeedUp.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnVirusScan.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Speedup1.BringToFront()
                    btnSpeedUp.BackColor = Color.Red
                    btnSpeedUp.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If


    End Sub

    Private Sub btnCleanUp_Click(sender As Object, e As EventArgs) Handles btnCleanUp.Click





        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Cleanup1.BringToFront()
            btnCleanUp.BackColor = Color.White
            btnCleanUp.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnVirusScan.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Cleanup1.BringToFront()
                btnCleanUp.BackColor = Color.Black
                btnCleanUp.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnVirusScan.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Cleanup1.BringToFront()
                    btnCleanUp.BackColor = Color.Red
                    btnCleanUp.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                End If
            End If
        End If



    End Sub

    Private Sub btnToolBox_Click(sender As Object, e As EventArgs) Handles btnToolBox.Click
    


        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Settings1.BringToFront()

            btnToolBox.BackColor = Color.White
            btnToolBox.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnVirusScan.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Settings1.BringToFront()
                btnToolBox.BackColor = Color.Black
                btnToolBox.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnVirusScan.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Settings1.BringToFront()

                    btnToolBox.BackColor = Color.Red
                    btnToolBox.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer2.Start()
        lblSmart.Text = ""
        Timer1.Start()

        Settings1.cmbThemes.Text = "Default Theme"
        Full_check1.computerName.Text = My.Computer.Name
        Full_check1.ComputerVersion.Text = My.Computer.Info.OSFullName
        Full_check1.OSPlatform.Text = My.Computer.Info.OSPlatform
        Full_check1.userName.Text = SystemInformation.UserName

        If Timer2.Enabled = True Then
            Timer3.Enabled = False
        Else
            Timer3.Enabled = True
        End If

    End Sub

    Private Sub btnQuickScan_Click(sender As Object, e As EventArgs) Handles btnQuickScan.Click
        Me.Hide()
        quick_scan.Show()

    End Sub

    Private Sub btnTimer_Tick(sender As Object, e As EventArgs) Handles btnTimer.Tick

        


    End Sub

    Private Sub HeaderPanel_Paint(sender As Object, e As PaintEventArgs) Handles HeaderPanel.Paint

    End Sub

    Private Sub Close1_Load(sender As Object, e As EventArgs) Handles Close1.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim str As String = "ONE-CLICK DEFENDER..... "
        Dim C(str.Length) As Char
        C = str.ToCharArray
        If j = 0 Then
            lblSmart.ForeColor = Color.Gainsboro

            If i < str.Length Then
                lblSmart.Text = lblSmart.Text & C(i)
                i = i + 1
            Else
                i = 0
                lblSmart.Text = ""
            End If
            j = 1

        Else
            j = 0
            lblSmart.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            notification.Show()

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 100 Then
            Timer3.Stop()
            notification.Timer1.Start()
            notification.Timer2.Start()

        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label1.Text = TimeString
        Label6.Text = DateString

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPreium_Click(sender As Object, e As EventArgs) Handles btnPreium.Click
        register.Show()
        Me.Hide()
    End Sub

    Private Sub btnTrialVersion_Click(sender As Object, e As EventArgs) Handles btnTrialVersion.Click
        trialVersion.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        auth.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        userprofile.ShowDialog()

    End Sub


End Class
