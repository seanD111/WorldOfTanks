Imports System.Web.Script.Serialization
Public Class dataFromAPI
    Protected fetchedData As String
    Sub Main()

        Dim json As String = _
        "{" + _
        """Result"":""Success""," + _
        """UserID"":""johns""," + _
        """Password"":null," + _
        """Locked"":""False""," + _
        """Comment"":""""," + _
        """LastLoggedOn"":""11/9/2013 9:14:17 PM""," + _
        """NumFailedAttempts"":""1""," + _
        """FirstName"":""John""," + _
        """LastName"":""Smith""," + _
        """MessageNum"":""UA-000""," + _
        """MessageText"":""Authorisation successful""" + _
        "}"
        Dim JsonConvert As New JavaScriptSerializer
        Dim a As saLoginResponse = JsonConvert.DeserializeObject(json)(runePage)

        Debug.WriteLine(a.MessageText + " for " + a.FirstName + " " + a.LastName)

    End Sub

    Protected Overridable Sub requestData(ByVal key As String)
    End Sub
    Protected Overridable Sub populateFields(ByVal key As String)
    End Sub

End Class
Public Class saLoginResponse As Object
    Public Property Result As String
    Public Property UserID As String
    Public Property Password As String
    Public Property Locked As Boolean
    Public Property Comment As String
    Public Property LastLoggedOn As String
    Public Property NumFailedAttempts As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property MessageNum As String
    Public Property MessageText As String
End Class