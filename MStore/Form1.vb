Public Class Form1
    Public Property songs As New List(Of Song)

    Private Sub Song_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Song_ListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database11DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11DataSet.Song_List' table. You can move, or remove it, as needed.
        Me.Song_ListTableAdapter.Fill(Me.Database11DataSet.Song_List)
        For Each song As Database11DataSet.Song_ListRow In Me.Database11DataSet.Song_List
            Dim album As String
            Dim producer As String
            Try
                album = song.Album
            Catch ex As StrongTypingException
                album = String.Empty
            End Try
            Try
                producer = song.Producer
            Catch ex As StrongTypingException
                producer = String.Empty
            End Try
            songs.Add(New Song(song.Song_ID, song.Song_Name, album, song.Artist, song.Genre, producer, song.R_Year, song.Type, song.Song_img, song.Song_mp3))
        Next
        Next_Button.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "Play.png"))
    End Sub


    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        If Song_ListListBox.SelectedIndex <> -1 Then
            Dim form2 As Form2 = New Form2(Me, songs.ElementAt(Song_ListListBox.SelectedIndex))
            Me.Hide()
            form2.Show()
        End If
    End Sub

End Class
