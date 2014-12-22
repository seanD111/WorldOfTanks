Public Class runePage

    Public Property id As Long
    Public Property name As String
    Public Property current As Boolean
    Public Property slots As rune()
    Public Sub updateImages()

        For i As Integer = 0 To slots.Length - 1
            'slots(i).runePic = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://ddragon.leagueoflegends.com/cdn/4.20.1/img/rune/" & slots(i).runeId & ".png")))
            slots(i).runePic = CType(My.Resources.ResourceManager.GetObject(slots(i).runeId, My.Resources.Culture()), System.Drawing.Bitmap)

        Next

    End Sub
End Class
