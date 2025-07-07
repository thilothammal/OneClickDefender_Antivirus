<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbThemes = New System.Windows.Forms.ComboBox()
        Me.btnDefaulTheme = New System.Windows.Forms.Button()
        Me.btnChangeTheme = New System.Windows.Forms.Button()
        Me.ThemePic = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.cmbThemes)
        Me.GroupBox1.Controls.Add(Me.ThemePic)
        Me.GroupBox1.Controls.Add(Me.btnDefaulTheme)
        Me.GroupBox1.Controls.Add(Me.btnChangeTheme)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'cmbThemes
        '
        Me.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThemes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbThemes.FormattingEnabled = True
        Me.cmbThemes.Location = New System.Drawing.Point(103, 241)
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.Size = New System.Drawing.Size(366, 28)
        Me.cmbThemes.TabIndex = 3
        '
        'btnDefaulTheme
        '
        Me.btnDefaulTheme.BackColor = System.Drawing.Color.Red
        Me.btnDefaulTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaulTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaulTheme.ForeColor = System.Drawing.Color.White
        Me.btnDefaulTheme.Location = New System.Drawing.Point(292, 277)
        Me.btnDefaulTheme.Name = "btnDefaulTheme"
        Me.btnDefaulTheme.Size = New System.Drawing.Size(154, 35)
        Me.btnDefaulTheme.TabIndex = 1
        Me.btnDefaulTheme.Text = "Default Theme"
        Me.btnDefaulTheme.UseVisualStyleBackColor = False
        '
        'btnChangeTheme
        '
        Me.btnChangeTheme.BackColor = System.Drawing.Color.Red
        Me.btnChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeTheme.ForeColor = System.Drawing.Color.White
        Me.btnChangeTheme.Location = New System.Drawing.Point(132, 277)
        Me.btnChangeTheme.Name = "btnChangeTheme"
        Me.btnChangeTheme.Size = New System.Drawing.Size(154, 35)
        Me.btnChangeTheme.TabIndex = 0
        Me.btnChangeTheme.Text = "Change Theme"
        Me.btnChangeTheme.UseVisualStyleBackColor = False
        '
        'ThemePic
        '
        Me.ThemePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThemePic.Image = Global.OneClick_defender.My.Resources.Resources._DEFAULT
        Me.ThemePic.Location = New System.Drawing.Point(103, 19)
        Me.ThemePic.Name = "ThemePic"
        Me.ThemePic.Size = New System.Drawing.Size(366, 215)
        Me.ThemePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThemePic.TabIndex = 2
        Me.ThemePic.TabStop = False
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "settings"
        Me.Size = New System.Drawing.Size(592, 350)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ThemePic As System.Windows.Forms.PictureBox
    Friend WithEvents btnDefaulTheme As System.Windows.Forms.Button
    Friend WithEvents btnChangeTheme As System.Windows.Forms.Button
    Friend WithEvents cmbThemes As System.Windows.Forms.ComboBox

End Class
