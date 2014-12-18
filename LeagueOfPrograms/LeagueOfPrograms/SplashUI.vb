Public Class Splash

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseHover
        imgLaunchButton.BackgroundImage = My.Resources.light_launch

    End Sub


    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLaunchButton.MouseLeave
        imgLaunchButton.BackgroundImage = My.Resources.dark_launch
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLaunchButton.Click
        MainUI.Show()
        Me.Hide()
    End Sub
End Class

