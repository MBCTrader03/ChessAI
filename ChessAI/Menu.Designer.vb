<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.LoadGameButton = New System.Windows.Forms.Button()
        Me.LeaderboardButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(137, 80)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(248, 122)
        Me.NewGameButton.TabIndex = 0
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'LoadGameButton
        '
        Me.LoadGameButton.Location = New System.Drawing.Point(391, 80)
        Me.LoadGameButton.Name = "LoadGameButton"
        Me.LoadGameButton.Size = New System.Drawing.Size(248, 122)
        Me.LoadGameButton.TabIndex = 1
        Me.LoadGameButton.Text = "Load Game"
        Me.LoadGameButton.UseVisualStyleBackColor = True
        '
        'LeaderboardButton
        '
        Me.LeaderboardButton.Location = New System.Drawing.Point(137, 208)
        Me.LeaderboardButton.Name = "LeaderboardButton"
        Me.LeaderboardButton.Size = New System.Drawing.Size(248, 122)
        Me.LeaderboardButton.TabIndex = 2
        Me.LeaderboardButton.Text = "Leaderboard"
        Me.LeaderboardButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(391, 208)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(248, 122)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.LeaderboardButton)
        Me.Controls.Add(Me.LoadGameButton)
        Me.Controls.Add(Me.NewGameButton)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewGameButton As Button
    Friend WithEvents LoadGameButton As Button
    Friend WithEvents LeaderboardButton As Button
    Friend WithEvents QuitButton As Button
End Class
