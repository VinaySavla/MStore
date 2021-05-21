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
        Me.NextButton = New System.Windows.Forms.Button()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Song_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Song_ListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Song_ListBindingNavigator.SuspendLayout()
        CType(Me.Song_ListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Song_ListListBox.Location = New System.Drawing.Point(170, 58)
        Me.Song_ListListBox.Name = "Song_ListListBox"
        Me.Song_ListListBox.Size = New System.Drawing.Size(441, 264)
        Me.Song_ListListBox.TabIndex = 22
        Me.Song_ListListBox.ValueMember = "Song_ID"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(170, 338)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(441, 66)
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
    Friend WithEvents NextButton As Button
End Class
