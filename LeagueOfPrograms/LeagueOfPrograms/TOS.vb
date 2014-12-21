Public NotInheritable Class TOS



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub TOS_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        SplashUI.imgLaunchButton.Enabled = True
    End Sub

    Private Sub TOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(750, 300)
    End Sub
End Class
