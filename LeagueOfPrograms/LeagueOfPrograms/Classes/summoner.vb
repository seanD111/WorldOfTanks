Public Class summoner
    Public id As Long
    Public name As String
    Public profileIconId As Integer
    Public summonerLevel As Long
    Public revisionDate As Long
    Public masterySet As masteryPage
    Public runeSet As runePage
    Public leagues As league
    Public highestRank As String
    Public stats As modeStats

    Public Sub New(ByVal summonerName As String)
        Dim data As New dataFromAPI
        id = data.getSummoner(summonerName)

    End Sub

End Class
