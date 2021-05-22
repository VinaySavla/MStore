Imports System.Media
Public Class Form2
    Public Property form1 As Form1
    Public Property song As Song
    Public Property player As SoundPlayer
    Public Property isPlaying As Boolean

    Public Sub New(form1 As Form1, song As Song)
        Me.form1 = form1
        Me.song = song
        Me.player = New SoundPlayer(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "songs", Me.song.song_mp3))
        Me.isPlaying = False
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO
        Panel2.Hide()
        LessButton.Hide()
        PictureBox1.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "thumbnails", Me.song.song_img))
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Text = Me.song.name
        Label4.Text = Me.song.album
        Label6.Text = Me.song.artist
        Label8.Text = Me.song.genre
        Label10.Text = Me.song.producer
        Label12.Text = Me.song.r_year
        Label14.Text = Me.song.type
        BackButton.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "back.png"))
        Play_Pause.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "Play.png"))
        MoreButton.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "i.png"))
        LessButton.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "exit.png"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Play_Pause.Click
        If Me.isPlaying Then
            Me.player.Stop()
            Play_Pause.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "Play.png"))
        Else
            Me.player.Play()
            Play_Pause.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "..", "..", "resources", "icons", "pause.png"))
        End If
        Me.isPlaying = Not (Me.isPlaying)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If Me.isPlaying Then
            Me.player.Stop()
        End If
        Me.Hide()
        Me.form1.Show()
    End Sub

    Private Sub MoreButton_Click(sender As Object, e As EventArgs) Handles MoreButton.Click
        Panel2.Show()
        MoreButton.Hide()
        LessButton.Show()
    End Sub

    Private Sub LessButton_Click(sender As Object, e As EventArgs) Handles LessButton.Click
        Panel2.Hide()
        LessButton.Hide()
        MoreButton.Show()
    End Sub

End Class
