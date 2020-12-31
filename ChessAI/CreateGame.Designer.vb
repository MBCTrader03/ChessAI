<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateGame
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
        Me.TutorialBox = New System.Windows.Forms.CheckBox()
        Me.AIPromptBox = New System.Windows.Forms.CheckBox()
        Me.BeginnerButton = New System.Windows.Forms.Button()
        Me.EasyButton = New System.Windows.Forms.Button()
        Me.NormalButton = New System.Windows.Forms.Button()
        Me.ModerateButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TutorialBox
        '
        Me.TutorialBox.AutoSize = True
        Me.TutorialBox.Location = New System.Drawing.Point(356, 107)
        Me.TutorialBox.Name = "TutorialBox"
        Me.TutorialBox.Size = New System.Drawing.Size(91, 17)
        Me.TutorialBox.TabIndex = 0
        Me.TutorialBox.Text = "Tutorial Mode"
        Me.TutorialBox.UseVisualStyleBackColor = True
        '
        'AIPromptBox
        '
        Me.AIPromptBox.AutoSize = True
        Me.AIPromptBox.Location = New System.Drawing.Point(356, 130)
        Me.AIPromptBox.Name = "AIPromptBox"
        Me.AIPromptBox.Size = New System.Drawing.Size(81, 17)
        Me.AIPromptBox.TabIndex = 1
        Me.AIPromptBox.Text = "AI Prompter"
        Me.AIPromptBox.UseVisualStyleBackColor = True
        '
        'BeginnerButton
        '
        Me.BeginnerButton.Location = New System.Drawing.Point(150, 192)
        Me.BeginnerButton.Name = "BeginnerButton"
        Me.BeginnerButton.Size = New System.Drawing.Size(121, 66)
        Me.BeginnerButton.TabIndex = 2
        Me.BeginnerButton.Text = "Beginner (1)"
        Me.BeginnerButton.UseVisualStyleBackColor = True
        '
        'EasyButton
        '
        Me.EasyButton.Location = New System.Drawing.Point(277, 192)
        Me.EasyButton.Name = "EasyButton"
        Me.EasyButton.Size = New System.Drawing.Size(121, 66)
        Me.EasyButton.TabIndex = 3
        Me.EasyButton.Text = "Easy (3)"
        Me.EasyButton.UseVisualStyleBackColor = True
        '
        'NormalButton
        '
        Me.NormalButton.Location = New System.Drawing.Point(404, 192)
        Me.NormalButton.Name = "NormalButton"
        Me.NormalButton.Size = New System.Drawing.Size(121, 66)
        Me.NormalButton.TabIndex = 4
        Me.NormalButton.Text = "Normal (4)"
        Me.NormalButton.UseVisualStyleBackColor = True
        '
        'ModerateButton
        '
        Me.ModerateButton.Location = New System.Drawing.Point(531, 192)
        Me.ModerateButton.Name = "ModerateButton"
        Me.ModerateButton.Size = New System.Drawing.Size(121, 66)
        Me.ModerateButton.TabIndex = 5
        Me.ModerateButton.Text = "Moderate (5)"
        Me.ModerateButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(340, 281)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(121, 66)
        Me.StartButton.TabIndex = 6
        Me.StartButton.Text = "Start Game"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'CreateGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ModerateButton)
        Me.Controls.Add(Me.NormalButton)
        Me.Controls.Add(Me.EasyButton)
        Me.Controls.Add(Me.BeginnerButton)
        Me.Controls.Add(Me.AIPromptBox)
        Me.Controls.Add(Me.TutorialBox)
        Me.Name = "CreateGame"
        Me.Text = "CreateGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TutorialBox As CheckBox
    Friend WithEvents AIPromptBox As CheckBox
    Friend WithEvents BeginnerButton As Button
    Friend WithEvents EasyButton As Button
    Friend WithEvents NormalButton As Button
    Friend WithEvents ModerateButton As Button
    Friend WithEvents StartButton As Button
End Class
