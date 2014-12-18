Public Class SplashUI


    Private Sub imgLaunchButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseHover
        imgLaunchButton.BackgroundImage = My.Resources.light_launch

    End Sub


    Private Sub imgLaunchButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseLeave
        imgLaunchButton.BackgroundImage = My.Resources.dark_launch
    End Sub

    Private Sub imgLaunchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLaunchButton.Click
        MainUI.Show()
        Me.Hide()
    End Sub

    Private Sub imgCloseSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgCloseSplash.Click
        Me.Close()
    End Sub

    Private Sub imgMinimizeSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgMinimizeSplash.Click
        Me.Hide()

        'this needs to be fixed
    End Sub
End Class

