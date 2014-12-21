Imports System.Net.NetworkInformation
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


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim summoner1 As New summoner
        try
            summoner1.pullSummonerData(TextBox1.Text)
        
            Label1.Text = summoner1.name
            Label2.Text = summoner1.id
            Label3.Text = summoner1.summonerLevel
        Catch
            MessageBox.Show("Username not found")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim summoner1 As New summoner

        summoner1.pullMasteryData(Label2.Text)

        Label6.Text = summoner1.masterySet(0).name
        Label5.Text = summoner1.masterySet(0).masteries(0).id
        Label4.Text = summoner1.masterySet(0).masteries(0).rank

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim summoner1 As New summoner

        summoner1.pullRuneData(Label2.Text)

        Label9.Text = summoner1.runeSet(0).name
        Label8.Text = summoner1.runeSet(0).slots(0).runeId
        Label7.Text = summoner1.runeSet(0).slots(0).runeSlotId
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim summoner1 As New summoner

        summoner1.pullStatsData(Label2.Text)

        Label15.Text = summoner1.stats(0).playerStatSummaryType
        Label14.Text = summoner1.stats(0).aggregatedStats.totalMagicDamageDealt
        Label13.Text = summoner1.stats(0).aggregatedStats.totalHeal
        Label12.Text = summoner1.stats(0).wins
        Label11.Text = summoner1.stats(0).losses
        Label10.Text = summoner1.stats(0).aggregatedStats.totalPentaKills
    End Sub



    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PlayerProfileUI.Show()
    End Sub

End Class

