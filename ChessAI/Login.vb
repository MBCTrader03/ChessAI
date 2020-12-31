Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PlayerList.Items.Add("New Player")
        Dim Users As String() = U.ListUsers()
        For i = 0 To Users.Length - 1
            Me.PlayerList.Items.Add(Users(i))
        Next
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Me.PlayerList.SelectedItem Is Nothing Then
            MsgBox("You must select a username or 'New Player'.")
        ElseIf Me.PlayerList.SelectedItem = "New Player" And Me.Username.Text = "" Then
            MsgBox("You must enter a username.")
        ElseIf Me.Password.Text = "" Then
            MsgBox("You must enter a password.")
        ElseIf Me.PlayerList.SelectedItem = "New Player" Then
            If Me.ValidateUsername() = True And Me.ValidatePassword() = True Then
                AIChess.SetUsername(Me.Username.Text)
                U.AddUser(Me.Username.Text, Me.Password.Text)
                ChessAI.Menu.Show()
                Me.Close()
            ElseIf Me.ValidateUsername() = False Then
                MsgBox("The username you entered contained an invalid character. Invalid characters: \/:*?""<>|,.")
            Else
                MsgBox("The password you entered contained an invalid character. Invalid characters: \/:*?""<>|,.")
            End If
        Else
            If Me.Password.Text = U.Passwords(Me.PlayerList.SelectedItem) Then
                AIChess.SetUsername(Me.PlayerList.SelectedItem)
                ChessAI.Menu.Show()
                Me.Close()
            Else
                MsgBox("Password doesn't match.")
            End If
        End If
    End Sub
    Private Function ValidateUsername() As Boolean
        Dim Valid As Boolean = True
        If Me.Username.Text = "New Player" Then
            Valid = False
        Else
            Dim Users As String() = U.ListUsers()
            For i = 0 To Users.Length - 1
                If Me.Username.Text = Users(i) Then
                    Valid = False
                End If
            Next
        End If
        For i = 0 To Me.Username.Text.Length - 1
            If Me.Username.Text(i) = "\" Then
                Valid = False
            ElseIf Me.Username.Text(i) = "/" Then
                Valid = False
            ElseIf Me.Username.Text(i) = ":" Then
                Valid = False
            ElseIf Me.Username.Text(i) = "*" Then
                Valid = False
            ElseIf Me.Username.Text(i) = "?" Then
                Valid = False
            ElseIf Me.Username.Text(i) = """" Then
                Valid = False
            ElseIf Me.Username.Text(i) = "<" Then
                Valid = False
            ElseIf Me.Username.Text(i) = ">" Then
                Valid = False
            ElseIf Me.Username.Text(i) = "|" Then
                Valid = False
            ElseIf Me.Username.Text(i) = "," Then
                Valid = False
            ElseIf Me.Username.Text(i) = "." Then
                Valid = False
            End If
        Next
        Return Valid
    End Function
    Private Function ValidatePassword() As Boolean
        Dim Valid As Boolean = True
        For i = 0 To Me.Password.Text.Length - 1
            If Me.Password.Text(i) = "\" Then
                Valid = False
            ElseIf Me.Password.Text(i) = "/" Then
                Valid = False
            ElseIf Me.Password.Text(i) = ":" Then
                Valid = False
            ElseIf Me.Password.Text(i) = "*" Then
                Valid = False
            ElseIf Me.Password.Text(i) = "?" Then
                Valid = False
            ElseIf Me.Password.Text(i) = """" Then
                Valid = False
            ElseIf Me.Password.Text(i) = "<" Then
                Valid = False
            ElseIf Me.Password.Text(i) = ">" Then
                Valid = False
            ElseIf Me.Password.Text(i) = "|" Then
                Valid = False
            ElseIf Me.Password.Text(i) = "," Then
                Valid = False
            ElseIf Me.Password.Text(i) = "." Then
                Valid = False
            End If
        Next
        Return Valid
    End Function
End Class