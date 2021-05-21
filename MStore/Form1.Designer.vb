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
        Me.Database11DataSet = New MStore.Database11DataSet()
        Me.Song_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Song_ListTableAdapter = New MStore.Database11DataSetTableAdapters.Song_ListTableAdapter()
        Me.TableAdapterManager = New MStore.Database11DataSetTableAdapters.TableAdapterManager()
        Me.Song_ListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Song_ListListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Next_Button = New System.Windows.Forms.Button()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Song_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Song_ListBindingSource1
        '
        Me.Song_ListBindingSource1.DataMember = "Song_List"
        Me.Song_ListBindingSource1.DataSource = Me.Database11DataSet
        '
        'Song_ListListBox
        '
        Me.Song_ListListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Song_ListListBox.DataSource = Me.Song_ListBindingSource1
        Me.Song_ListListBox.DisplayMember = "Song_Name"
        Me.Song_ListListBox.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Song_ListListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Song_ListListBox.FormattingEnabled = True
        Me.Song_ListListBox.ItemHeight = 27
        Me.Song_ListListBox.Location = New System.Drawing.Point(-2, -1)
        Me.Song_ListListBox.Name = "Song_ListListBox"
        Me.Song_ListListBox.Size = New System.Drawing.Size(807, 382)
        Me.Song_ListListBox.TabIndex = 22
        Me.Song_ListListBox.ValueMember = "Song_ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 25.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 43)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "MusicStore"
        '
        'Next_Button
        '
        Me.Next_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Next_Button.FlatAppearance.BorderSize = 0
        Me.Next_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next_Button.Location = New System.Drawing.Point(740, 304)
        Me.Next_Button.Name = "Next_Button"
        Me.Next_Button.Size = New System.Drawing.Size(48, 43)
        Me.Next_Button.TabIndex = 44
        Me.Next_Button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 363)
        Me.Controls.Add(Me.Next_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Song_ListListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Song_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Song_ListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database11DataSet As Database11DataSet
    Friend WithEvents Song_ListBindingSource As BindingSource
    Friend WithEvents Song_ListTableAdapter As Database11DataSetTableAdapters.Song_ListTableAdapter
    Friend WithEvents TableAdapterManager As Database11DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Song_ListBindingSource1 As BindingSource
    Friend WithEvents Song_ListListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Next_Button As Button
End Class
