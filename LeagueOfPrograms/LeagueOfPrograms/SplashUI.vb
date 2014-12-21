﻿Imports WMPLib
Public Class SplashUI

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub imgLaunchButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseHover
        imgLaunchButton.BackgroundImage = My.Resources.light_launch

    End Sub


    Private Sub imgLaunchButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseLeave
        imgLaunchButton.BackgroundImage = My.Resources.dark_launch
    End Sub

    Private Sub imgLaunchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLaunchButton.Click
        imgLaunchButton.BackgroundImage = My.Resources.light_launch


        My.Computer.Audio.Play(My.Resources.buttonclickaudio,
               AudioPlayMode.BackgroundLoop)
        System.Threading.Thread.Sleep(900)
        My.Computer.Audio.Stop()
   
        Me.Hide()
        MainUI.Show()
    End Sub

    Private Sub imgCloseSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgCloseSplash.Click
        Me.Close()
    End Sub

    Private Sub imgMinimizeSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgMinimizeSplash.Click
        Me.Hide()

        'this needs to be fixed
    End Sub

    Private Sub imgSplash_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgSplash.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgSplash_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgSplash.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgSplash_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgSplash.MouseUp
        drag = False
    End Sub

    Private Sub imgBannerSplash_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBannerSplash.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub imgBannerSplash_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBannerSplash.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub imgBannerSplash_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgBannerSplash.MouseUp
        drag = False
    End Sub



    Private Sub timerBGCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBGCheck.Tick
        If RadioButton1.Checked = True Then
            imgSplash.BackgroundImage = My.Resources.wallpaper1
            imgSplash.BackgroundImageLayout = ImageLayout.Center
        Else
            imgSplash.BackgroundImage = My.Resources.wallpaper2
            imgSplash.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

  
    Private Sub SplashUI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.LoginScreenLoop,
              AudioPlayMode.BackgroundLoop)
    End Sub
End Class

