Imports System.Reflection.Emit

Public Class profile
    Dim i As Integer = 0
    Dim j As Integer
    Dim a As Integer = 0
    Dim b As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim str As String = "OUR VISIONARY GUIDE....... "
        Dim C(str.Length) As Char
        C = str.ToCharArray
        If b = 0 Then
            Label1.ForeColor = Color.Black

            If a < str.Length Then
                Label1.Text = Label1.Text & C(a)
                a = a + 1
            Else
                a = 0
                Label1.Text = ""
            End If
            b = 1

        Else
            b = 0
            Label1.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim str As String = "OUR PHOENIX PHALANX..... "
        Dim C(str.Length) As Char
        C = str.ToCharArray
        If j = 0 Then
            Label2.ForeColor = Color.Black

            If i < str.Length Then
                Label2.Text = Label2.Text & C(i)
                i = i + 1
            Else
                i = 0
                Label2.Text = ""
            End If
            j = 1

        Else
            j = 0
            Label2.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class