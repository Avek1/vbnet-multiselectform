Public Class Employee
    Public Property ID As Integer
    Public Property FirstName As String
    Public Property LastName As String

    Public Sub New(id As Integer, fname As String, lname As String)
        Me.ID = id
        Me.FirstName = fname
        Me.LastName = lname
    End Sub
End Class
