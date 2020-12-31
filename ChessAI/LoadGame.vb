Public Class LoadGame
    Private Sub LoadGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListFiles(My.Computer.FileSystem.CurrentDirectory + "\Users\" + AIChess.GetUsername())
    End Sub
    Private Sub ListFiles(ByVal FolderPath As String)
        FilesListBox.Items.Clear()
        Dim FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.csv")
        For Each FileName As String In FileNames
            FilesListBox.Items.Add(FileName.Split("\")(FileName.Split("\").Length - 1).Split(".")(0))
        Next
    End Sub
    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        If FilesListBox.SelectedItem Is Nothing Then
            MsgBox("Please select a file.")
            Exit Sub
        End If
        Dim FilePath = My.Computer.FileSystem.CurrentDirectory + "\Users\" + AIChess.GetUsername() + "\" + FilesListBox.SelectedItem.ToString() + ".csv"
        If My.Computer.FileSystem.FileExists(FilePath) = False Then
            MsgBox("File Not Found: " + FilePath)
            Exit Sub
        End If
        Dim FileText As String = GetText(FilePath)
        MsgBox(FileText)
    End Sub
    Private Function GetText(ByVal FilePath As String) As String
        If My.Computer.FileSystem.FileExists(FilePath) = False Then
            Throw New Exception("File Not Found: " + FilePath)
        End If
        Dim FileText As New System.Text.StringBuilder()
        Using sReader As New System.IO.StreamReader(FilePath)
            Dim line As String
            line = sReader.ReadLine()
            FileText.Append("Difficulty: " + line.Split(",")(0))
            FileText.Append(vbCrLf)
            line = sReader.ReadLine()
            FileText.Append(AIChess.GetUsername() + " " + line.Split(",")(0) + " - " + line.Split(",")(1) + " " + "Computer")
            line = sReader.ReadLine()
            If line.Split(",")(0) = "True" Then
                FileText.Append(vbCrLf)
                FileText.Append("Tutorial Mode")
            End If
            If line.Split(",")(1) = "True" Then
                FileText.Append(vbCrLf)
                FileText.Append("AIPrompt")
            End If
        End Using
        Return FileText.ToString
    End Function
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Form1.Show()
        AIChess.LoadGame(FilesListBox.SelectedItem.ToString())
        Me.Close()
    End Sub
End Class