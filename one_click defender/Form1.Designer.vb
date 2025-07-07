<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.btnToolBox = New System.Windows.Forms.Button()
        Me.btnCleanUp = New System.Windows.Forms.Button()
        Me.btnSpeedUp = New System.Windows.Forms.Button()
        Me.btnVirusScan = New System.Windows.Forms.Button()
        Me.btnFull_Check = New System.Windows.Forms.Button()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTrialVersion = New System.Windows.Forms.Button()
        Me.btnPreium = New System.Windows.Forms.Button()
        Me.btnQuickScan = New System.Windows.Forms.Button()
        Me.lblSmart = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Welcome2 = New OneClick_defender.welcome()
        Me.Full_check1 = New OneClick_defender.full_check()
        Me.Scan1 = New OneClick_defender.scan()
        Me.Speedup1 = New OneClick_defender.speedup()
        Me.Settings1 = New OneClick_defender.settings()
        Me.Cleanup1 = New OneClick_defender.cleanup()
        Me.Welcome1 = New OneClick_defender.welcome()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close1 = New OneClick_defender.close()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SidePanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.DarkBlue
        Me.SidePanel.Controls.Add(Me.btnToolBox)
        Me.SidePanel.Controls.Add(Me.btnCleanUp)
        Me.SidePanel.Controls.Add(Me.btnSpeedUp)
        Me.SidePanel.Controls.Add(Me.btnVirusScan)
        Me.SidePanel.Controls.Add(Me.btnFull_Check)
        Me.SidePanel.Location = New System.Drawing.Point(0, 146)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(207, 346)
        Me.SidePanel.TabIndex = 0
        '
        'btnToolBox
        '
        Me.btnToolBox.BackColor = System.Drawing.Color.DarkBlue
        Me.btnToolBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToolBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToolBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnToolBox.ForeColor = System.Drawing.Color.White
        Me.btnToolBox.Image = Global.OneClick_defender.My.Resources.Resources.full_tool_storage_box__filled_50px
        Me.btnToolBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToolBox.Location = New System.Drawing.Point(3, 287)
        Me.btnToolBox.Name = "btnToolBox"
        Me.btnToolBox.Size = New System.Drawing.Size(199, 51)
        Me.btnToolBox.TabIndex = 4
        Me.btnToolBox.Text = "            ToolBox"
        Me.btnToolBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToolBox.UseVisualStyleBackColor = False
        '
        'btnCleanUp
        '
        Me.btnCleanUp.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCleanUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCleanUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCleanUp.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleanUp.ForeColor = System.Drawing.Color.White
        Me.btnCleanUp.Image = Global.OneClick_defender.My.Resources.Resources.waste_filled_50px
        Me.btnCleanUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanUp.Location = New System.Drawing.Point(3, 222)
        Me.btnCleanUp.Name = "btnCleanUp"
        Me.btnCleanUp.Size = New System.Drawing.Size(199, 51)
        Me.btnCleanUp.TabIndex = 3
        Me.btnCleanUp.Text = "            CleanUp "
        Me.btnCleanUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanUp.UseVisualStyleBackColor = False
        '
        'btnSpeedUp
        '
        Me.btnSpeedUp.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSpeedUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSpeedUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpeedUp.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSpeedUp.ForeColor = System.Drawing.Color.White
        Me.btnSpeedUp.Image = Global.OneClick_defender.My.Resources.Resources.running_filled_50px
        Me.btnSpeedUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeedUp.Location = New System.Drawing.Point(3, 150)
        Me.btnSpeedUp.Name = "btnSpeedUp"
        Me.btnSpeedUp.Size = New System.Drawing.Size(199, 51)
        Me.btnSpeedUp.TabIndex = 2
        Me.btnSpeedUp.Text = "            SpeedUp"
        Me.btnSpeedUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeedUp.UseVisualStyleBackColor = False
        '
        'btnVirusScan
        '
        Me.btnVirusScan.BackColor = System.Drawing.Color.DarkBlue
        Me.btnVirusScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVirusScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVirusScan.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnVirusScan.ForeColor = System.Drawing.Color.White
        Me.btnVirusScan.Image = Global.OneClick_defender.My.Resources.Resources.antivirus_scanner_filled_50px
        Me.btnVirusScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVirusScan.Location = New System.Drawing.Point(3, 82)
        Me.btnVirusScan.Name = "btnVirusScan"
        Me.btnVirusScan.Size = New System.Drawing.Size(199, 51)
        Me.btnVirusScan.TabIndex = 1
        Me.btnVirusScan.Text = "            Virus Scan"
        Me.btnVirusScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVirusScan.UseVisualStyleBackColor = False
        '
        'btnFull_Check
        '
        Me.btnFull_Check.BackColor = System.Drawing.Color.DarkBlue
        Me.btnFull_Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFull_Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFull_Check.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFull_Check.ForeColor = System.Drawing.Color.White
        Me.btnFull_Check.Image = Global.OneClick_defender.My.Resources.Resources.monitor_filled_50px
        Me.btnFull_Check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFull_Check.Location = New System.Drawing.Point(3, 13)
        Me.btnFull_Check.Name = "btnFull_Check"
        Me.btnFull_Check.Size = New System.Drawing.Size(199, 51)
        Me.btnFull_Check.TabIndex = 0
        Me.btnFull_Check.Text = "            Full Check"
        Me.btnFull_Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFull_Check.UseVisualStyleBackColor = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.DarkBlue
        Me.HeaderPanel.Controls.Add(Me.Button1)
        Me.HeaderPanel.Controls.Add(Me.Label5)
        Me.HeaderPanel.Controls.Add(Me.Label4)
        Me.HeaderPanel.Controls.Add(Me.Label3)
        Me.HeaderPanel.Controls.Add(Me.btnTrialVersion)
        Me.HeaderPanel.Controls.Add(Me.btnPreium)
        Me.HeaderPanel.Controls.Add(Me.btnQuickScan)
        Me.HeaderPanel.Controls.Add(Me.lblSmart)
        Me.HeaderPanel.Controls.Add(Me.Label2)
        Me.HeaderPanel.Controls.Add(Me.PictureBox1)
        Me.HeaderPanel.Location = New System.Drawing.Point(1, 28)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(798, 115)
        Me.HeaderPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(630, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Database"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(216, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "YOUR SYSTEM IS PROTECTED "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(126, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "STATUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(631, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "30 Days Remaining"
        '
        'btnTrialVersion
        '
        Me.btnTrialVersion.BackColor = System.Drawing.Color.Red
        Me.btnTrialVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrialVersion.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnTrialVersion.ForeColor = System.Drawing.Color.White
        Me.btnTrialVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrialVersion.Location = New System.Drawing.Point(346, 44)
        Me.btnTrialVersion.Name = "btnTrialVersion"
        Me.btnTrialVersion.Size = New System.Drawing.Size(221, 35)
        Me.btnTrialVersion.TabIndex = 7
        Me.btnTrialVersion.Text = "TRIAL VERSION"
        Me.btnTrialVersion.UseVisualStyleBackColor = False
        '
        'btnPreium
        '
        Me.btnPreium.BackColor = System.Drawing.Color.Green
        Me.btnPreium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreium.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnPreium.ForeColor = System.Drawing.Color.White
        Me.btnPreium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreium.Location = New System.Drawing.Point(126, 45)
        Me.btnPreium.Name = "btnPreium"
        Me.btnPreium.Size = New System.Drawing.Size(215, 35)
        Me.btnPreium.TabIndex = 12
        Me.btnPreium.Text = "ACTIVATE PREMIUM"
        Me.btnPreium.UseVisualStyleBackColor = False
        '
        'btnQuickScan
        '
        Me.btnQuickScan.BackColor = System.Drawing.Color.Red
        Me.btnQuickScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuickScan.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, System.Drawing.FontStyle.Italic)
        Me.btnQuickScan.ForeColor = System.Drawing.Color.White
        Me.btnQuickScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuickScan.Location = New System.Drawing.Point(631, 9)
        Me.btnQuickScan.Name = "btnQuickScan"
        Me.btnQuickScan.Size = New System.Drawing.Size(164, 35)
        Me.btnQuickScan.TabIndex = 5
        Me.btnQuickScan.Text = "Quick Scan"
        Me.btnQuickScan.UseVisualStyleBackColor = False
        '
        'lblSmart
        '
        Me.lblSmart.AutoSize = True
        Me.lblSmart.BackColor = System.Drawing.Color.Transparent
        Me.lblSmart.Font = New System.Drawing.Font("Lucida Handwriting", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblSmart.ForeColor = System.Drawing.Color.White
        Me.lblSmart.Location = New System.Drawing.Point(120, 3)
        Me.lblSmart.Name = "lblSmart"
        Me.lblSmart.Size = New System.Drawing.Size(431, 41)
        Me.lblSmart.TabIndex = 0
        Me.lblSmart.Text = "ONE-CLICK DEFENDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(450, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Blue
        Me.PictureBox1.Image = Global.OneClick_defender.My.Resources.Resources.snapedit_1706169058170_removeb_unscreen
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Welcome2)
        Me.Panel3.Controls.Add(Me.Full_check1)
        Me.Panel3.Controls.Add(Me.Scan1)
        Me.Panel3.Controls.Add(Me.Speedup1)
        Me.Panel3.Controls.Add(Me.Settings1)
        Me.Panel3.Controls.Add(Me.Cleanup1)
        Me.Panel3.Controls.Add(Me.Welcome1)
        Me.Panel3.Location = New System.Drawing.Point(210, 146)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 350)
        Me.Panel3.TabIndex = 8
        '
        'Welcome2
        '
        Me.Welcome2.BackColor = System.Drawing.Color.Black
        Me.Welcome2.Location = New System.Drawing.Point(0, 0)
        Me.Welcome2.Name = "Welcome2"
        Me.Welcome2.Size = New System.Drawing.Size(592, 350)
        Me.Welcome2.TabIndex = 6
        '
        'Full_check1
        '
        Me.Full_check1.BackColor = System.Drawing.Color.Black
        Me.Full_check1.Location = New System.Drawing.Point(-1, -4)
        Me.Full_check1.Margin = New System.Windows.Forms.Padding(0)
        Me.Full_check1.Name = "Full_check1"
        Me.Full_check1.Size = New System.Drawing.Size(587, 345)
        Me.Full_check1.TabIndex = 1
        '
        'Scan1
        '
        Me.Scan1.BackColor = System.Drawing.Color.Black
        Me.Scan1.Location = New System.Drawing.Point(-6, -2)
        Me.Scan1.Name = "Scan1"
        Me.Scan1.Size = New System.Drawing.Size(592, 350)
        Me.Scan1.TabIndex = 2
        '
        'Speedup1
        '
        Me.Speedup1.BackColor = System.Drawing.Color.Black
        Me.Speedup1.Location = New System.Drawing.Point(-5, -2)
        Me.Speedup1.Name = "Speedup1"
        Me.Speedup1.Size = New System.Drawing.Size(592, 350)
        Me.Speedup1.TabIndex = 3
        '
        'Settings1
        '
        Me.Settings1.BackColor = System.Drawing.Color.Black
        Me.Settings1.Location = New System.Drawing.Point(0, 0)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(592, 350)
        Me.Settings1.TabIndex = 5
        '
        'Cleanup1
        '
        Me.Cleanup1.BackColor = System.Drawing.Color.Black
        Me.Cleanup1.Location = New System.Drawing.Point(-2, -4)
        Me.Cleanup1.Name = "Cleanup1"
        Me.Cleanup1.Size = New System.Drawing.Size(592, 350)
        Me.Cleanup1.TabIndex = 4
        '
        'Welcome1
        '
        Me.Welcome1.BackColor = System.Drawing.Color.Black
        Me.Welcome1.Location = New System.Drawing.Point(0, -3)
        Me.Welcome1.Name = "Welcome1"
        Me.Welcome1.Size = New System.Drawing.Size(592, 350)
        Me.Welcome1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label14.Location = New System.Drawing.Point(34, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(273, 22)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "STS ANTI-VIRUS SOFTWARE"
        '
        'btnTimer
        '
        Me.btnTimer.Enabled = True
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(244, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBar1.TabIndex = 14
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 50
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(350, 4)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBar2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(581, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "00.00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(472, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "mm/dd/yyyy"
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(578, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 20)
        Me.Panel1.TabIndex = 18
        '
        'Close1
        '
        Me.Close1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Close1.Location = New System.Drawing.Point(234, 183)
        Me.Close1.Margin = New System.Windows.Forms.Padding(0)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(374, 137)
        Me.Close1.TabIndex = 13
        Me.Close1.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.OneClick_defender.My.Resources.Resources.output_image__1__removebg_preview
        Me.PictureBox7.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.OneClick_defender.My.Resources.Resources.profile
        Me.PictureBox6.Location = New System.Drawing.Point(677, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.OneClick_defender.My.Resources.Resources.menu
        Me.PictureBox5.Location = New System.Drawing.Point(701, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.OneClick_defender.My.Resources.Resources.minus
        Me.PictureBox4.Location = New System.Drawing.Point(726, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.OneClick_defender.My.Resources.Resources.minimize
        Me.PictureBox3.Location = New System.Drawing.Point(750, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.OneClick_defender.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(774, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One-Click Defender"
        Me.SidePanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSmart As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFull_Check As System.Windows.Forms.Button
    Friend WithEvents btnToolBox As System.Windows.Forms.Button
    Friend WithEvents btnCleanUp As System.Windows.Forms.Button
    Friend WithEvents btnSpeedUp As System.Windows.Forms.Button
    Friend WithEvents btnVirusScan As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTrialVersion As System.Windows.Forms.Button
    Friend WithEvents btnPreium As System.Windows.Forms.Button
    Friend WithEvents btnQuickScan As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Welcome1 As OneClick_defender.welcome
    Friend WithEvents Full_check1 As OneClick_defender.full_check
    Friend WithEvents Scan1 As OneClick_defender.scan
    Friend WithEvents Speedup1 As OneClick_defender.speedup
    Friend WithEvents Cleanup1 As OneClick_defender.cleanup
    Friend WithEvents Settings1 As OneClick_defender.settings
    Friend WithEvents Close1 As OneClick_defender.close
    Friend WithEvents btnTimer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Welcome2 As welcome
    Friend WithEvents Button1 As Button
End Class
