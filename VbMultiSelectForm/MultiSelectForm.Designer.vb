<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiSelectForm
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
        Me.AvailableList = New System.Windows.Forms.ListBox()
        Me.SelectedList = New System.Windows.Forms.ListBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.addAllButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.removeAllButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AvailableList
        '
        Me.AvailableList.FormattingEnabled = True
        Me.AvailableList.ItemHeight = 16
        Me.AvailableList.Location = New System.Drawing.Point(12, 12)
        Me.AvailableList.Name = "AvailableList"
        Me.AvailableList.Size = New System.Drawing.Size(120, 116)
        Me.AvailableList.TabIndex = 0
        '
        'SelectedList
        '
        Me.SelectedList.FormattingEnabled = True
        Me.SelectedList.ItemHeight = 16
        Me.SelectedList.Location = New System.Drawing.Point(279, 12)
        Me.SelectedList.Name = "SelectedList"
        Me.SelectedList.Size = New System.Drawing.Size(120, 116)
        Me.SelectedList.TabIndex = 1
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(138, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(135, 23)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "Add >>"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'addAllButton
        '
        Me.addAllButton.Location = New System.Drawing.Point(138, 42)
        Me.addAllButton.Name = "addAllButton"
        Me.addAllButton.Size = New System.Drawing.Size(135, 23)
        Me.addAllButton.TabIndex = 3
        Me.addAllButton.Text = "Add All >>"
        Me.addAllButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(138, 72)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(135, 23)
        Me.removeButton.TabIndex = 4
        Me.removeButton.Text = "<< Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'removeAllButton
        '
        Me.removeAllButton.Location = New System.Drawing.Point(138, 102)
        Me.removeAllButton.Name = "removeAllButton"
        Me.removeAllButton.Size = New System.Drawing.Size(135, 23)
        Me.removeAllButton.TabIndex = 5
        Me.removeAllButton.Text = "<< Remove All"
        Me.removeAllButton.UseVisualStyleBackColor = True
        '
        'MultiSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 160)
        Me.Controls.Add(Me.removeAllButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addAllButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.SelectedList)
        Me.Controls.Add(Me.AvailableList)
        Me.Name = "MultiSelectForm"
        Me.Text = "MultiSelectForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AvailableList As ListBox
    Friend WithEvents SelectedList As ListBox
    Friend WithEvents addButton As Button
    Friend WithEvents addAllButton As Button
    Friend WithEvents removeButton As Button
    Friend WithEvents removeAllButton As Button
End Class
