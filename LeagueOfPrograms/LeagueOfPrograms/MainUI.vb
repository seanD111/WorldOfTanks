Imports System.Net.NetworkInformation
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public NotInheritable Class MainUI

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPing.Tick
        Dim pingSender As New Ping()

        Dim reply As PingReply = pingSender.Send("50.203.115.149", 1000)

        lblping.Text = "Ping: " & reply.RoundtripTime
        If reply.RoundtripTime > 200 Then
            lblping.ForeColor = Color.Red
        Else : lblping.ForeColor = Color.Green
        End If

        If reply.RoundtripTime = 0 Then
            lblping.Text = "Ping: Checking..."
        Else : lblping.Text = "Ping: " & reply.RoundtripTime
        End If
    End Sub

    Private Sub MainUI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SplashUI.Close()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgExitButton.Click
        Me.Close()
        SplashUI.Close()
    End Sub


    Private Sub imgTopBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgTopBar.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgTopBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgTopBar.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgTopBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgTopBar.MouseUp
        drag = False
    End Sub

    Private Sub imgBottomBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBottomBar.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgBottomBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBottomBar.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgBottomBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBottomBar.MouseUp
        drag = False
    End Sub

    Private Sub imgBackground_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBackground.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgBackground_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBackground.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgBackground_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBackground.MouseUp
        drag = False
    End Sub


    Private Sub PictureBox4_MouseClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseClick
        PictureBox4.BackgroundImage = My.Resources.pressedbutton
        lblComingSoon1.Image = My.Resources.pressedbutton

    End Sub


    Private Sub lblComingSoon1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblComingSoon1.MouseClick
        PictureBox4.BackgroundImage = My.Resources.pressedbutton
        lblComingSoon1.Image = My.Resources.pressedbutton
    End Sub

    Private Sub PictureBox4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseClick

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Dim data As New summonerAPI
        Dim summoner As JObject = data.Parse(data.getJSON("Stole His Wife"))
        Label1.Text = summoner.Item("stolehiswife").Item("name")

    End Sub
End Class
