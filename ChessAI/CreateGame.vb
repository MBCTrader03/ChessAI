Public Class CreateGame
    Private Sub CreateGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BeginnerButton_Click(sender As Object, e As EventArgs) Handles BeginnerButton.Click
        AIChess.SetDifficulty(1, "beginner")
        TutorialBox.Checked = True
        AIPromptBox.Checked = True
        TutorialBox.AutoCheck = False
        AIPromptBox.AutoCheck = False
    End Sub
    Private Sub EasyButton_Click(sender As Object, e As EventArgs) Handles EasyButton.Click
        If AIChess.GetDifficulty() = 1 Then
            TutorialBox.AutoCheck = True
            AIPromptBox.AutoCheck = True
            TutorialBox.Checked = False
            AIPromptBox.Checked = False
        End If
        AIChess.SetDifficulty(3, "easy")
    End Sub
    Private Sub NormalButton_Click(sender As Object, e As EventArgs) Handles NormalButton.Click
        If AIChess.GetDifficulty() = 1 Then
            TutorialBox.AutoCheck = True
            AIPromptBox.AutoCheck = True
            TutorialBox.Checked = False
            AIPromptBox.Checked = False
        End If
        AIChess.SetDifficulty(4, "normal")
    End Sub
    Private Sub ModerateButton_Click(sender As Object, e As EventArgs) Handles ModerateButton.Click
        If AIChess.GetDifficulty() = 1 Then
            TutorialBox.AutoCheck = True
            AIPromptBox.AutoCheck = True
            TutorialBox.Checked = False
            AIPromptBox.Checked = False
        End If
        AIChess.SetDifficulty(5, "moderate")
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        AIChess.SetGameSettings(TutorialBox.Checked, AIPromptBox.Checked)
        AIChess.StartGame()
        Form1.Show()
        Me.Close()
    End Sub
End Class