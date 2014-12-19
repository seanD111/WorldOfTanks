Public Class dataFromAPI
    Protected fetchedData As String

    Protected Overridable Sub requestData(ByVal key As String)
    End Sub
    Protected Overridable Sub populateFields(ByVal key As String)
    End Sub
End Class
