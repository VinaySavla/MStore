Public Module MusicStore
    Public Class Song
        Public Property id As Integer
        Public Property name As String
        Public Property artist As String
        Public Property album As String
        Public Property genre As String
        Public Property producer As String
        Public Property r_year As String
        Public Property type As String
        Public Property song_img As String
        Public Property song_mp3 As String

        Public Sub New(id As Integer, name As String, artist As String, album As String, genre As String, producer As String, r_year As String, type As String, song_img As String, song_mp3 As String)
            Me.id = id
            Me.name = name
            Me.artist = artist
            Me.album = album
            Me.genre = genre
            Me.producer = producer
            Me.r_year = r_year
            Me.type = type
            Me.song_img = song_img
            Me.song_mp3 = song_mp3
        End Sub
    End Class
End Module
