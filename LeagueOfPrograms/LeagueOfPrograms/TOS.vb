Public NotInheritable Class TOS



    Private Sub imgOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgOK.Click
        Me.Close()

    End Sub

    Private Sub TOS_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        SplashUI.imgLaunchButton.Enabled = True
    End Sub

End Class
