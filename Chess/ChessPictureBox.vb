Public Class ChessPictureBox
    Inherits PictureBox
    Private _HasImage As Boolean = False
    Public Property HasImage() As Object
        Get
            Return _HasImage
        End Get
        Set(ByVal value As Object)
            _HasImage = value
        End Set
    End Property
End Class
