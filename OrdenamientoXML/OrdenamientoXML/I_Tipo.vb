Public Class I_Tipo

    Private _id As String
    Private _nombre As String
    Private _total As Integer

    Public Sub New()
        Id = ""
        Nombre = ""
        Total = 0
    End Sub

    Public Sub New(id As String, nombre As String)
        _id = id
        _nombre = nombre
        Total = 0
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property
End Class
