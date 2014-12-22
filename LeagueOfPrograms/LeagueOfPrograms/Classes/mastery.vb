
Public Class Image
    Public Property w As Integer
    Public Property full As String
    Public Property sprite As String
    Public Property group As String
    Public Property h As Integer
    Public Property y As Integer
    Public Property x As Integer
End Class

Public Class mastery
    Public Property rank As Integer
    Public Property id As Integer
    Public Property sanitizedDescription As String()
    Public Property description As String()
    Public Property name As String
    Public Property image As Image
    Public Property prereq As String
End Class