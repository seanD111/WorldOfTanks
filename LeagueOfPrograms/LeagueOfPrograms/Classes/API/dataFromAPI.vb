Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class dataFromAPI
    Protected Shared keys As String()
    Protected URL As String
    Protected json As String
    Sub New()
        ReDim keys(3)
        keys(0) = "e5547c49-b045-4e3b-a486-63d69fefacdf"
        keys(1) = "ce57ec7f-3d6f-4481-89bc-c83e3310ab7d"
    End Sub

    Public Function getSummoner(ByVal summonerName As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" & summonerName & "?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim name As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim summoner As summoner = JsonConvert.DeserializeObject(Of summoner)(JsonObject.Item(name).ToString())
        'call the other shit
        'summoner.masterySet = getMasteries(summoner.id)
        'summoner.runeSet = getRunes(summoner.id)
        'summoner.leagues = getLeague(summoner.id)
        'summoner.stats = getStats(summoner.id)
        ' finally return the summoner object
        Return summoner
    End Function

    Public Function getMasteries(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/" & summonerID & "/masteries?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim name As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim mastery As mastery = JsonConvert.DeserializeObject(Of mastery)(JsonObject.Item(name).ToString())
        ' finally return the summoner object
        Return mastery
    End Function
    Public Function getRunes(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/" & summonerID & "/runes?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim name As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim rune As rune = JsonConvert.DeserializeObject(Of rune)(JsonObject.Item(name).ToString())
        ' finally return the summoner object
        Return rune
    End Function
    Public Function getStats(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.3/stats/by-summoner/" & summonerID & "/summary?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim name As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim modeStats As modeStats = JsonConvert.DeserializeObject(Of modeStats)(JsonObject.Item(name).ToString())
        ' finally return the summoner object
        Return modeStats
    End Function
    Public Function getLeague(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v2.5/league/by-summoner/" & summonerID & "/entry?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim name As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim league As league = JsonConvert.DeserializeObject(Of league)(JsonObject.Item(name).ToString())
        ' finally return the summoner object
        Return league
    End Function
End Class