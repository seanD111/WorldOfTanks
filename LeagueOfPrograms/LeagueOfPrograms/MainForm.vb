﻿Imports System.Net.NetworkInformation
Public Class MainForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
    'im unreal
End Class

