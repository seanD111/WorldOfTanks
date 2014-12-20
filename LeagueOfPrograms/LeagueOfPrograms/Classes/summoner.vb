Public Class summoner
    Public Property id As Long
    Public Property name As String
    Public Property profileIconId As Integer
    Public Property summonerLevel As Long
    Public Property revisionDate As Long
    Public Property masterySet As masteryPage
    Public Property runeSet As runePage
    Public Property leagues As league
    Public Property highestRank As String
    Public Property stats As modeStats

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
    Public Sub pullMasteryData(ByVal summonerName As String)
        Dim data As New dataFromAPI
        id = data.getSummoner(summonerName)

    End Sub
    Public Sub pullRuneData(ByVal summonerName As String)
        Dim data As New dataFromAPI
        id = data.getSummoner(summonerName)
    End Sub
    Public Sub pullLeagueData(ByVal summonerName As String)
        Dim data As New dataFromAPI
        id = data.getSummoner(summonerName)

    End Sub

End Class
