Imports System.Net.NetworkInformation
Public Class MainForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPing.Tick
        Dim pingSender As New Ping()

        Dim reply As PingReply = pingSender.Send("216.52.241.254", 1000)

        ping.Text = "Ping: " & reply.RoundtripTime
        If reply.RoundtripTime > 200 Then
            ping.ForeColor = Color.Red
        Else : ping.ForeColor = Color.Green
        End If

        If reply.RoundtripTime = 0 Then
            ping.Text = "Ping: Checking..."
        Else : ping.Text = "Ping: " & reply.RoundtripTime
        End If
    End Sub
    'yeusuusus
End Class

