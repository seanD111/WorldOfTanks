Public Class summoner
    Public Property id As Long
    Public Property name As String
    Public Property profileIconId As Integer
    Public Property summonerLevel As Long
    Public Property revisionDate As Long
    Public Property masterySet As masteryPage()
    Public Property runeSet As runePage()
    Public Property leagues As league
    Public Property highestRank As String
    Public Property stats As modeStats()

    Public Sub pullSummonerData(ByVal summonerName As String)
        Dim data As New dataFromAPI
        Dim tempSum As New summoner
        tempSum = data.getSummoner(summonerName)
        id = tempSum.id
        name = tempSum.name
        profileIconId = tempSum.profileIconId
        summonerLevel = tempSum.summonerLevel
        revisionDate = tempSum.revisionDate

    End Sub
    Public Sub pullMasteryData(ByVal summonerID As String)
        Dim data As New dataFromAPI
        Dim tempMast As masteryPage() = data.getMasteries(summonerID)
        ReDim masterySet(tempMast.Length)
        For i As Integer = 0 To tempMast.Length - 1
            masterySet(i) = tempMast(i)
        Next

    End Sub
    Public Sub pullRuneData(ByVal summonerID As String)
        Dim data As New dataFromAPI
        Dim tempRune As runePage() = data.getRunes(summonerID)
        ReDim runeSet(tempRune.Length)
        For i As Integer = 0 To tempRune.Length - 1
            runeSet(i) = tempRune(i)
        Next
    End Sub
    Public Sub pullLeagueData(ByVal summonerID As String)
        Dim data As New dataFromAPI
        id = data.getSummoner(summonerID)

    End Sub

    Public Sub pullStatsData(ByVal summonerID As String)
        Dim data As New dataFromAPI
        Dim tempStats As modeStats() = data.getStats(summonerID)
        ReDim stats(tempStats.Length)
        For i As Integer = 0 To tempStats.Length - 1
            stats(i) = tempStats(i)
        Next
    End Sub

End Class
