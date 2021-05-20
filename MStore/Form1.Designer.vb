<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Song_IDLabel As System.Windows.Forms.Label
        Dim Song_NameLabel As System.Windows.Forms.Label
        Dim AlbumLabel As System.Windows.Forms.Label
        Dim ArtistLabel As System.Windows.Forms.Label
        Dim GenreLabel As System.Windows.Forms.Label
        Dim ProducerLabel As System.Windows.Forms.Label
        Dim R_YearLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim Song_imgLabel As System.Windows.Forms.Label
        Dim Song_mp3Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Database11DataSet = New MStore.Database11DataSet()
        Me.Song_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Song_ListTableAdapter = New MStore.Database11DataSetTableAdapters.Song_ListTableAdapter()
        Me.TableAdapterManager = New MStore.Database11DataSetTableAdapters.TableAdapterManager()
        Me.Song_ListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Song_ListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Song_ListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Song_ListListBox = New System.Windows.Forms.ListBox()
        Me.Song_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Song_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AlbumTextBox = New System.Windows.Forms.TextBox()
        Me.ArtistTextBox = New System.Windows.Forms.TextBox()
        Me.GenreTextBox = New System.Windows.Forms.TextBox()
        Me.ProducerTextBox = New System.Windows.Forms.TextBox()
        Me.R_YearTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Song_imgTextBox = New System.Windows.Forms.TextBox()
        Me.Song_mp3TextBox = New System.Windows.Forms.TextBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Song_IDLabel = New System.Windows.Forms.Label()
        Song_NameLabel = New System.Windows.Forms.Label()
        AlbumLabel = New System.Windows.Forms.Label()
        ArtistLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        ProducerLabel = New System.Windows.Forms.Label()
        R_YearLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        Song_imgLabel = New System.Windows.Forms.Label()
        Song_mp3Label = New System.Windows.Forms.Label()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Song_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Song_ListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Song_ListBindingNavigator.SuspendLayout()
        CType(Me.Song_ListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Song_IDLabel
        '
        Song_IDLabel.AutoSize = True
        Song_IDLabel.Location = New System.Drawing.Point(50, 70)
        Song_IDLabel.Name = "Song_IDLabel"
        Song_IDLabel.Size = New System.Drawing.Size(49, 13)
        Song_IDLabel.TabIndex = 22
        Song_IDLabel.Text = "Song ID:"
        '
        'Song_NameLabel
        '
        Song_NameLabel.AutoSize = True
        Song_NameLabel.Location = New System.Drawing.Point(50, 96)
        Song_NameLabel.Name = "Song_NameLabel"
        Song_NameLabel.Size = New System.Drawing.Size(66, 13)
        Song_NameLabel.TabIndex = 24
        Song_NameLabel.Text = "Song Name:"
        '
        'AlbumLabel
        '
        AlbumLabel.AutoSize = True
        AlbumLabel.Location = New System.Drawing.Point(50, 122)
        AlbumLabel.Name = "AlbumLabel"
        AlbumLabel.Size = New System.Drawing.Size(39, 13)
        AlbumLabel.TabIndex = 26
        AlbumLabel.Text = "Album:"
        '
        'ArtistLabel
        '
        ArtistLabel.AutoSize = True
        ArtistLabel.Location = New System.Drawing.Point(50, 148)
        ArtistLabel.Name = "ArtistLabel"
        ArtistLabel.Size = New System.Drawing.Size(33, 13)
        ArtistLabel.TabIndex = 28
        ArtistLabel.Text = "Artist:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Location = New System.Drawing.Point(50, 174)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(39, 13)
        GenreLabel.TabIndex = 30
        GenreLabel.Text = "Genre:"
        '
        'ProducerLabel
        '
        ProducerLabel.AutoSize = True
        ProducerLabel.Location = New System.Drawing.Point(50, 200)
        ProducerLabel.Name = "ProducerLabel"
        ProducerLabel.Size = New System.Drawing.Size(53, 13)
        ProducerLabel.TabIndex = 32
        ProducerLabel.Text = "Producer:"
        '
        'R_YearLabel
        '
        R_YearLabel.AutoSize = True
        R_YearLabel.Location = New System.Drawing.Point(50, 226)
        R_YearLabel.Name = "R_YearLabel"
        R_YearLabel.Size = New System.Drawing.Size(43, 13)
        R_YearLabel.TabIndex = 34
        R_YearLabel.Text = "R Year:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(50, 252)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 36
        TypeLabel.Text = "Type:"
        '
        'Song_imgLabel
        '
        Song_imgLabel.AutoSize = True
        Song_imgLabel.Location = New System.Drawing.Point(50, 278)
        Song_imgLabel.Name = "Song_imgLabel"
        Song_imgLabel.Size = New System.Drawing.Size(54, 13)
        Song_imgLabel.TabIndex = 38
        Song_imgLabel.Text = "Song img:"
        '
        'Song_mp3Label
        '
        Song_mp3Label.AutoSize = True
        Song_mp3Label.Location = New System.Drawing.Point(50, 304)
        Song_mp3Label.Name = "Song_mp3Label"
        Song_mp3Label.Size = New System.Drawing.Size(58, 13)
        Song_mp3Label.TabIndex = 40
        Song_mp3Label.Text = "Song mp3:"
        '
        'Database11DataSet
        '
        Me.Database11DataSet.DataSetName = "Database11DataSet"
        Me.Database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Song_ListBindingSource
        '
        Me.Song_ListBindingSource.DataMember = "Song_List"
        Me.Song_ListBindingSource.DataSource = Me.Database11DataSet
        '
        'Song_ListTableAdapter
        '
        Me.Song_ListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Song_ListTableAdapter = Me.Song_ListTableAdapter
        Me.TableAdapterManager.UpdateOrder = MStore.Database11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Song_ListBindingNavigator
        '
        Me.Song_ListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Song_ListBindingNavigator.BindingSource = Me.Song_ListBindingSource
        Me.Song_ListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Song_ListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Song_ListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Song_ListBindingNavigatorSaveItem})
        Me.Song_ListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Song_ListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Song_ListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Song_ListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Song_ListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Song_ListBindingNavigator.Name = "Song_ListBindingNavigator"
        Me.Song_ListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Song_ListBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Song_ListBindingNavigator.TabIndex = 0
        Me.Song_ListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Song_ListBindingNavigatorSaveItem
        '
        Me.Song_ListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Song_ListBindingNavigatorSaveItem.Image = CType(resources.GetObject("Song_ListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Song_ListBindingNavigatorSaveItem.Name = "Song_ListBindingNavigatorSaveItem"
        Me.Song_ListBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Song_ListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Song_ListBindingSource1
        '
        Me.Song_ListBindingSource1.DataMember = "Song_List"
        Me.Song_ListBindingSource1.DataSource = Me.Database11DataSet
        '
        'Song_ListListBox
        '
        Me.Song_ListListBox.DataSource = Me.Song_ListBindingSource1
        Me.Song_ListListBox.DisplayMember = "Song_Name"
        Me.Song_ListListBox.FormattingEnabled = True
        Me.Song_ListListBox.Location = New System.Drawing.Point(457, 71)
        Me.Song_ListListBox.Name = "Song_ListListBox"
        Me.Song_ListListBox.Size = New System.Drawing.Size(191, 264)
        Me.Song_ListListBox.TabIndex = 22
        Me.Song_ListListBox.ValueMember = "Song_ID"
        '
        'Song_IDTextBox
        '
        Me.Song_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Song_ID", True))
        Me.Song_IDTextBox.Location = New System.Drawing.Point(122, 67)
        Me.Song_IDTextBox.Name = "Song_IDTextBox"
        Me.Song_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Song_IDTextBox.TabIndex = 23
        '
        'Song_NameTextBox
        '
        Me.Song_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Song_Name", True))
        Me.Song_NameTextBox.Location = New System.Drawing.Point(122, 93)
        Me.Song_NameTextBox.Name = "Song_NameTextBox"
        Me.Song_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Song_NameTextBox.TabIndex = 25
        '
        'AlbumTextBox
        '
        Me.AlbumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Album", True))
        Me.AlbumTextBox.Location = New System.Drawing.Point(122, 119)
        Me.AlbumTextBox.Name = "AlbumTextBox"
        Me.AlbumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlbumTextBox.TabIndex = 27
        '
        'ArtistTextBox
        '
        Me.ArtistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Artist", True))
        Me.ArtistTextBox.Location = New System.Drawing.Point(122, 145)
        Me.ArtistTextBox.Name = "ArtistTextBox"
        Me.ArtistTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArtistTextBox.TabIndex = 29
        '
        'GenreTextBox
        '
        Me.GenreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Genre", True))
        Me.GenreTextBox.Location = New System.Drawing.Point(122, 171)
        Me.GenreTextBox.Name = "GenreTextBox"
        Me.GenreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenreTextBox.TabIndex = 31
        '
        'ProducerTextBox
        '
        Me.ProducerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Producer", True))
        Me.ProducerTextBox.Location = New System.Drawing.Point(122, 197)
        Me.ProducerTextBox.Name = "ProducerTextBox"
        Me.ProducerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProducerTextBox.TabIndex = 33
        '
        'R_YearTextBox
        '
        Me.R_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "R_Year", True))
        Me.R_YearTextBox.Location = New System.Drawing.Point(122, 223)
        Me.R_YearTextBox.Name = "R_YearTextBox"
        Me.R_YearTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_YearTextBox.TabIndex = 35
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(122, 249)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TypeTextBox.TabIndex = 37
        '
        'Song_imgTextBox
        '
        Me.Song_imgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Song_img", True))
        Me.Song_imgTextBox.Location = New System.Drawing.Point(122, 275)
        Me.Song_imgTextBox.Name = "Song_imgTextBox"
        Me.Song_imgTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Song_imgTextBox.TabIndex = 39
        '
        'Song_mp3TextBox
        '
        Me.Song_mp3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Song_ListBindingSource, "Song_mp3", True))
        Me.Song_mp3TextBox.Location = New System.Drawing.Point(122, 301)
        Me.Song_mp3TextBox.Name = "Song_mp3TextBox"
        Me.Song_mp3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Song_mp3TextBox.TabIndex = 41
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(457, 362)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(156, 55)
        Me.NextButton.TabIndex = 42
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Song_IDLabel)
        Me.Controls.Add(Me.Song_IDTextBox)
        Me.Controls.Add(Song_NameLabel)
        Me.Controls.Add(Me.Song_NameTextBox)
        Me.Controls.Add(AlbumLabel)
        Me.Controls.Add(Me.AlbumTextBox)
        Me.Controls.Add(ArtistLabel)
        Me.Controls.Add(Me.ArtistTextBox)
        Me.Controls.Add(GenreLabel)
        Me.Controls.Add(Me.GenreTextBox)
        Me.Controls.Add(ProducerLabel)
        Me.Controls.Add(Me.ProducerTextBox)
        Me.Controls.Add(R_YearLabel)
        Me.Controls.Add(Me.R_YearTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Song_imgLabel)
        Me.Controls.Add(Me.Song_imgTextBox)
        Me.Controls.Add(Song_mp3Label)
        Me.Controls.Add(Me.Song_mp3TextBox)
        Me.Controls.Add(Me.Song_ListListBox)
        Me.Controls.Add(Me.Song_ListBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Song_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Song_ListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Song_ListBindingNavigator.ResumeLayout(False)
        Me.Song_ListBindingNavigator.PerformLayout()
        CType(Me.Song_ListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database11DataSet As Database11DataSet
    Friend WithEvents Song_ListBindingSource As BindingSource
    Friend WithEvents Song_ListTableAdapter As Database11DataSetTableAdapters.Song_ListTableAdapter
    Friend WithEvents TableAdapterManager As Database11DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Song_ListBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Song_ListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Song_ListBindingSource1 As BindingSource
    Friend WithEvents Song_ListListBox As ListBox
    Friend WithEvents Song_IDTextBox As TextBox
    Friend WithEvents Song_NameTextBox As TextBox
    Friend WithEvents AlbumTextBox As TextBox
    Friend WithEvents ArtistTextBox As TextBox
    Friend WithEvents GenreTextBox As TextBox
    Friend WithEvents ProducerTextBox As TextBox
    Friend WithEvents R_YearTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents Song_imgTextBox As TextBox
    Friend WithEvents Song_mp3TextBox As TextBox
    Friend WithEvents NextButton As Button
End Class
