Public Class Menu
    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click
        CreateGame.Show()
        Me.Close()
    End Sub
    Private Sub LoadGameButton_Click(sender As Object, e As EventArgs) Handles LoadGameButton.Click
        LoadGame.Show()
        Me.Close()
    End Sub
    Private Sub LeaderboardButton_Click(sender As Object, e As EventArgs) Handles LeaderboardButton.Click

    End Sub
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub
End Class