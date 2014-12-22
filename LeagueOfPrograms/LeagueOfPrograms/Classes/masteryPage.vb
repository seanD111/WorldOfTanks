Public Class masteryPage
    Public Property id As Long
    Public Property name As String
    Public Property current As Boolean
    Public Property masteries As mastery()
    Public Sub updateImages()
        For i As Integer = 0 To masteries.Length - 1
            masteries(i).masteryPic = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://ddragon.leagueoflegends.com/cdn/4.20.1/img/mastery/" & masteries(i).id & ".png")))
        Next

    End Sub
End Class
