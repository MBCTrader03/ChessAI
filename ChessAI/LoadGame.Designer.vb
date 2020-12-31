<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadGame
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
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.FilesListBox = New System.Windows.Forms.ListBox()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(223, 217)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(165, 85)
        Me.LoadButton.TabIndex = 0
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'FilesListBox
        '
        Me.FilesListBox.FormattingEnabled = True
        Me.FilesListBox.Location = New System.Drawing.Point(223, 12)
        Me.FilesListBox.Name = "FilesListBox"
        Me.FilesListBox.Size = New System.Drawing.Size(336, 199)
        Me.FilesListBox.TabIndex = 1
        '
        'SettingsButton
        '
        Me.SettingsButton.Location = New System.Drawing.Point(394, 217)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(165, 85)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "View Game Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'LoadGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.FilesListBox)
        Me.Controls.Add(Me.LoadButton)
        Me.Name = "LoadGame"
        Me.Text = "LoadGame"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadButton As Button
    Friend WithEvents FilesListBox As ListBox
    Friend WithEvents SettingsButton As Button
End Class
