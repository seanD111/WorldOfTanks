Public Class BuildList
    Public Property Build As Build
    Public Property Pic As String
    Public Property SummonerSpells As String()
    Public Property Item() As String()
    Public Property Title As String
    Public Property Author As String
    Public Property Update As String
    Public Property BuildURL As String

    Public Property Votes As String

    Public Sub New(ByVal picString As String, ByVal summSpells() As String, ByVal items() As String, ByVal information() As String)
        Pic = picString
        SummonerSpells = summSpells
        Item = items
        Title = information(0)
        Author = information(1)
        Update = information(2)
        BuildURL = information(3)

    End Sub

    Public Overrides Function toString() As String
        Dim s As String = Pic
        For i As Integer = 0 To SummonerSpells.Count - 1
            s = s & " " & SummonerSpells(i)
        Next
        For j As Integer = 0 To Item.Count - 1
            s = s & " " & Item(j)
        Next

        Return Title & " by: " & Author & " " & Update & " " & BuildURL & Environment.NewLine & s
    End Function
End Class
