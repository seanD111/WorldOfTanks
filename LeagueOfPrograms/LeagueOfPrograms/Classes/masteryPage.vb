Public Class masteryPage
    Public Property id As Long
    Public Property name As String
    Public Property current As Boolean
    Public Property masteries As mastery()
    Public Sub updateImages()
        For i As Integer = 0 To masteries.Length - 1
            'masteries(i).masteryPic = CType(My.Resources.ResourceManager.GetObject("_" & masteries(i).id, My.Resources.Culture()), System.Drawing.Bitmap)
        Next

    End Sub
End Class
