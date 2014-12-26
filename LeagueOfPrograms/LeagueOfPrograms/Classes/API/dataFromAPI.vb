﻿Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports HtmlAgilityPack
Public Class dataFromAPI
    Protected Shared keys As String()
    Protected URL As String
    Protected json As String
    Sub New()
        ReDim keys(3)
        keys(0) = "e5547c49-b045-4e3b-a486-63d69fefacdf"
        keys(1) = "479c1f0e-396e-41d0-9f04-d178279aaccf"
        keys(2) = "a98f0029-9ce3-496e-b2ad-8f351ffe6678"
    End Sub

    Public Function getBuildList(ByVal champ As String)
        ' Load the html document
        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load("http://www.mobafire.com/league-of-legends/" & champ & "-guide")
        ' Get all tables in the document
        Dim tables As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'browse-table')]")
        ' Iterate all rows in the first table
        Dim rows As HtmlNodeCollection = tables.SelectNodes(".//tr")

        Dim buildList(rows.Count) As BuildList

        For i As Integer = 0 To rows.Count - 1
            Dim cols As HtmlNodeCollection = rows(i).SelectNodes(".//*[contains(@class,'pic')]")
            Dim title As String = ""
            For j As Integer = 0 To cols.Count - 1
                title = cols(j).SelectSingleNode(".//img").Attributes("title").Value
            Next
            cols = rows(i).SelectNodes(".//*[contains(@class,'desc')]")
            For j As Integer = 0 To cols.Count - 1
                Dim items As HtmlNodeCollection = rows(i).SelectNodes(".//*[contains(@class,'build-items')]")
                Dim a(1) As String
                Dim b(5) As String
                For k As Integer = 0 To items.Count - 1
                    Dim name As HtmlNodeCollection = items(k).SelectNodes(".//img")
                    For l As Integer = 0 To name.Count - 1
                        If (name.Item(l).Attributes("src").Value.Contains(".png")) Then
                            a(l) = name.Item(l).Attributes("src").Value.Replace("/images/summoner-spell/", "").Replace(".png", "")
                            'Debug.Write(a(l) & " ")
                        ElseIf (name.Item(l).Attributes("src").Value.Contains(".gif")) Then
                            b(l) = name.Item(l).Attributes("src").Value.Replace("/images/item/", "").Replace(".gif", "")
                            'Debug.Write(b(l) & " ")
                        End If
                    Next
                    'Debug.WriteLine("")
                Next
                buildList(i) = New BuildList(title, a, b)
            Next
        Next
        Return buildList
    End Function

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


        Return JsonConvert.DeserializeObject(Of summoner)(JsonObject.Item(name).ToString())
    End Function

    Public Function getMasteries(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/" & summonerID & "/masteries?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim id As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim masteries As masteryPage() = JsonConvert.DeserializeObject(Of masteryPage())(JsonObject.Item(id).Item("pages").ToString())
        ' finally return the summoner object
        Return masteries
    End Function
    Public Function getRunes(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/" & summonerID & "/runes?api_key=" & keys(2)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim id As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim runes As runePage() = JsonConvert.DeserializeObject(Of runePage())(JsonObject.Item(id).Item("pages").ToString())

        ' finally return the summoner object



        Return runes
    End Function
    Public Function getStats(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v1.3/stats/by-summoner/" & summonerID & "/summary?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)


        Dim modeStats As modeStats() = JsonConvert.DeserializeObject(Of modeStats())(JsonObject.Item("playerStatSummaries").ToString())
        ' finally return the summoner object
        Return modeStats
    End Function
    Public Function getLeague(ByVal summonerID As String)
        ' original json object from url
        URL = "https://na.api.pvp.net/api/lol/na/v2.5/league/by-summoner/" & summonerID & "/entry?api_key=" & keys(2)
        Dim objWC As New System.Net.WebClient()
        Dim json As String = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        ' use this to get summoner object from JSON object
        Dim JsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        ' name of the first item
        Dim id As String = JsonObject.Properties.First.Name
        ' stupid nested object in json
        Dim leagues As league() = JsonConvert.DeserializeObject(Of league())(JsonObject.Item(id).ToString())
        ' finally return the summoner object
        Return leagues
    End Function
End Class