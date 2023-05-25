Friend Class Comentarios
    Public Interface IComentarios
        Sub AggComentario(comentario As String)
        Function TomarComentarios() As List(Of String)
    End Interface

    'The IComentarios interface provides a common structure for adding comments and
    'retrieving a list of stored comments. Classes that implement this interface will
    'need to provide specific logic for adding and retrieving comments based on their
    'needs.
    Public Class ComentarioTienda
        Implements IComentarios

        Private comentarios As New List(Of String)()

        Public Sub AggComentario(comentario As String) Implements IComentarios.AggComentario
            comentarios.Add(comentario)
        End Sub

        Public Function TomarComentarios() As List(Of String) Implements IComentarios.TomarComentarios
            Return comentarios
        End Function
    End Class
    'ComentarioTienda implements the functionality of adding comments to a list and
    'retrieving the complete list of comments. This allows the class to act as a comment
    'storage for a store or similar entity.
End Class

