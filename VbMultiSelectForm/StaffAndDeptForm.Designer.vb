<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAndDeptForm
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
        Me.Staff = New System.Windows.Forms.ListBox()
        Me.departmentComboBox = New System.Windows.Forms.ComboBox()
        Me.departmentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Staff
        '
        Me.Staff.FormattingEnabled = True
        Me.Staff.ItemHeight = 16
        Me.Staff.Location = New System.Drawing.Point(13, 13)
        Me.Staff.Name = "Staff"
        Me.Staff.Size = New System.Drawing.Size(120, 148)
        Me.Staff.TabIndex = 0
        '
        'departmentComboBox
        '
        Me.departmentComboBox.FormattingEnabled = True
        Me.departmentComboBox.Location = New System.Drawing.Point(140, 13)
        Me.departmentComboBox.Name = "departmentComboBox"
        Me.departmentComboBox.Size = New System.Drawing.Size(121, 24)
        Me.departmentComboBox.TabIndex = 1
        '
        'departmentButton
        '
        Me.departmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentButton.Location = New System.Drawing.Point(268, 13)
        Me.departmentButton.Name = "departmentButton"
        Me.departmentButton.Size = New System.Drawing.Size(33, 23)
        Me.departmentButton.TabIndex = 2
        Me.departmentButton.Text = "..."
        Me.departmentButton.UseVisualStyleBackColor = True
        '
        'StaffAndDeptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 232)
        Me.Controls.Add(Me.departmentButton)
        Me.Controls.Add(Me.departmentComboBox)
        Me.Controls.Add(Me.Staff)
        Me.Name = "StaffAndDeptForm"
        Me.Text = "StaffAndDeptForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Staff As ListBox
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents departmentButton As Button
End Class
