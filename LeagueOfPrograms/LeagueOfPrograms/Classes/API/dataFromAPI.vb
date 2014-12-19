Imports System.Web.Script.Serialization
Public Class dataFromAPI
    Protected Shared keys As String()
    Protected URL As String
    Protected json As String
    Sub New()
        ReDim keys(3)
        keys(0) = "e5547c49-b045-4e3b-a486-63d69fefacdf"
    End Sub

    Public Overridable Sub JSONtoObject()
    End Sub
    Public Overridable Sub ObjectToData()
    End Sub

End Class

Public Class masteryAPI
    Inherits dataFromAPI


    Public Sub getJSON(ByVal summonerID As Long)
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/" & summonerID & "/masteries?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        json = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
    End Sub
    Overrides Sub JSONtoObject()

        Dim JsonConvert As New JavaScriptSerializer
        Dim data As wrapper = JsonConvert.Deserialize(Of wrapper)(json)

    End Sub
End Class

Public Class summonerAPI
    Inherits dataFromAPI
    Public Sub getJSON(ByVal summonerName As String)
        summonerName = Replace(summonerName, " ", "")
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" & summonerName & "?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        json = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
    End Sub
    Overrides Sub JSONtoObject()

        Dim json As String = "{""ticker"":{""high"":5.31,""low"":4.23,""success"":True}}"
        Dim JsonConvert As New JavaScriptSerializer
        Dim data As wrapper = JsonConvert.Deserialize(Of wrapper)(json)

    End Sub
End Class


Public Class runeAPI
    Inherits dataFromAPI
    Public Sub getJSON(ByVal summonerID As Long)
        URL = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/" & summonerID & "/runes?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        json = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
    End Sub

    Overrides Sub JSONtoObject()

        Dim json As String = "{""ticker"":{""high"":5.31,""low"":4.23,""success"":True}}"
        Dim JsonConvert As New JavaScriptSerializer
        Dim data As wrapper = JsonConvert.Deserialize(Of wrapper)(json)

    End Sub
End Class

Public Class statsAPI
    Inherits dataFromAPI
    Public Sub getJSON(ByVal summonerID As Long)
        URL = "https://na.api.pvp.net/api/lol/na/v1.3/stats/by-summoner/" & summonerID & "/summary?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        json = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
    End Sub
    Overrides Sub JSONtoObject()

        Dim json As String = "{""ticker"":{""high"":5.31,""low"":4.23,""success"":True}}"
        Dim JsonConvert As New JavaScriptSerializer
        Dim data As wrapper = JsonConvert.Deserialize(Of wrapper)(json)

    End Sub
End Class
Public Class leagueAPI
    Inherits dataFromAPI
    Public Sub getJSON(ByVal summonerID As Long)
        URL = "https://na.api.pvp.net/api/lol/na/v2.5/league/by-summoner/" & summonerID & "/entry?api_key=" & keys(0)
        Dim objWC As New System.Net.WebClient()
        json = New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
    End Sub
    Overrides Sub JSONtoObject()

        Dim json As String = "{""ticker"":{""high"":5.31,""low"":4.23,""success"":True}}"
        Dim JsonConvert As New JavaScriptSerializer
        Dim data As wrapper = JsonConvert.Deserialize(Of wrapper)(json)

    End Sub
End Class


Public Class wrapper
    ' wrapper for "ticker" in json returned from server
    Public ticker As ticker
End Class

Public Class ticker
    Public Property high As Decimal
    Public Property low As Decimal
    Public Property success As Boolean
End Class
