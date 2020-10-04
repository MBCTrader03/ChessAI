Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RefreshBoard()
    End Sub
    Public Sub RefreshBoard()
        Dim Symbols As String(,)
        Symbols = board.Initialise()
        Label0_0.Text = Symbols(0, 0)
        Label0_1.Text = Symbols(0, 1)
        Label0_2.Text = Symbols(0, 2)
        Label0_3.Text = Symbols(0, 3)
        Label0_4.Text = Symbols(0, 4)
        Label0_5.Text = Symbols(0, 5)
        Label0_6.Text = Symbols(0, 6)
        Label0_7.Text = Symbols(0, 7)
        Label1_0.Text = Symbols(1, 0)
        Label1_1.Text = Symbols(1, 1)
        Label1_2.Text = Symbols(1, 2)
        Label1_3.Text = Symbols(1, 3)
        Label1_4.Text = Symbols(1, 4)
        Label1_5.Text = Symbols(1, 5)
        Label1_6.Text = Symbols(1, 6)
        Label1_7.Text = Symbols(1, 7)
        Label2_0.Text = Symbols(2, 0)
        Label2_1.Text = Symbols(2, 1)
        Label2_2.Text = Symbols(2, 2)
        Label2_3.Text = Symbols(2, 3)
        Label2_4.Text = Symbols(2, 4)
        Label2_5.Text = Symbols(2, 5)
        Label2_6.Text = Symbols(2, 6)
        Label2_7.Text = Symbols(2, 7)
        Label3_0.Text = Symbols(3, 0)
        Label3_1.Text = Symbols(3, 1)
        Label3_2.Text = Symbols(3, 2)
        Label3_3.Text = Symbols(3, 3)
        Label3_4.Text = Symbols(3, 4)
        Label3_5.Text = Symbols(3, 5)
        Label3_6.Text = Symbols(3, 6)
        Label3_7.Text = Symbols(3, 7)
        Label4_0.Text = Symbols(4, 0)
        Label4_1.Text = Symbols(4, 1)
        Label4_2.Text = Symbols(4, 2)
        Label4_3.Text = Symbols(4, 3)
        Label4_4.Text = Symbols(4, 4)
        Label4_5.Text = Symbols(4, 5)
        Label4_6.Text = Symbols(4, 6)
        Label4_7.Text = Symbols(4, 7)
        Label5_0.Text = Symbols(5, 0)
        Label5_1.Text = Symbols(5, 1)
        Label5_2.Text = Symbols(5, 2)
        Label5_3.Text = Symbols(5, 3)
        Label5_4.Text = Symbols(5, 4)
        Label5_5.Text = Symbols(5, 5)
        Label5_6.Text = Symbols(5, 6)
        Label5_7.Text = Symbols(5, 7)
        Label6_0.Text = Symbols(6, 0)
        Label6_1.Text = Symbols(6, 1)
        Label6_2.Text = Symbols(6, 2)
        Label6_3.Text = Symbols(6, 3)
        Label6_4.Text = Symbols(6, 4)
        Label6_5.Text = Symbols(6, 5)
        Label6_6.Text = Symbols(6, 6)
        Label6_7.Text = Symbols(6, 7)
        Label7_0.Text = Symbols(7, 0)
        Label7_1.Text = Symbols(7, 1)
        Label7_2.Text = Symbols(7, 2)
        Label7_3.Text = Symbols(7, 3)
        Label7_4.Text = Symbols(7, 4)
        Label7_5.Text = Symbols(7, 5)
        Label7_6.Text = Symbols(7, 6)
        Label7_7.Text = Symbols(7, 7)
        GenerateBoard()
    End Sub
    Public Sub GenerateBoard()
        Dim BoardColours(8, 8) As Color
        For i = 0 To 7
            For j = 0 To 7
                If (i + j) Mod 2 = 0 Then
                    BoardColours(i, j) = DarkPanel.BackColor
                Else
                    BoardColours(i, j) = LightPanel.BackColor
                End If
            Next
        Next
        Panel0_0.BackColor = BoardColours(0, 0)
        Panel0_1.BackColor = BoardColours(0, 1)
        Panel0_2.BackColor = BoardColours(0, 2)
        Panel0_3.BackColor = BoardColours(0, 3)
        Panel0_4.BackColor = BoardColours(0, 4)
        Panel0_5.BackColor = BoardColours(0, 5)
        Panel0_6.BackColor = BoardColours(0, 6)
        Panel0_7.BackColor = BoardColours(0, 7)
        Panel1_0.BackColor = BoardColours(1, 0)
        Panel1_1.BackColor = BoardColours(1, 1)
        Panel1_2.BackColor = BoardColours(1, 2)
        Panel1_3.BackColor = BoardColours(1, 3)
        Panel1_4.BackColor = BoardColours(1, 4)
        Panel1_5.BackColor = BoardColours(1, 5)
        Panel1_6.BackColor = BoardColours(1, 6)
        Panel1_7.BackColor = BoardColours(1, 7)
        Panel2_0.BackColor = BoardColours(2, 0)
        Panel2_1.BackColor = BoardColours(2, 1)
        Panel2_2.BackColor = BoardColours(2, 2)
        Panel2_3.BackColor = BoardColours(2, 3)
        Panel2_4.BackColor = BoardColours(2, 4)
        Panel2_5.BackColor = BoardColours(2, 5)
        Panel2_6.BackColor = BoardColours(2, 6)
        Panel2_7.BackColor = BoardColours(2, 7)
        Panel3_0.BackColor = BoardColours(3, 0)
        Panel3_1.BackColor = BoardColours(3, 1)
        Panel3_2.BackColor = BoardColours(3, 2)
        Panel3_3.BackColor = BoardColours(3, 3)
        Panel3_4.BackColor = BoardColours(3, 4)
        Panel3_5.BackColor = BoardColours(3, 5)
        Panel3_6.BackColor = BoardColours(3, 6)
        Panel3_7.BackColor = BoardColours(3, 7)
        Panel4_0.BackColor = BoardColours(4, 0)
        Panel4_1.BackColor = BoardColours(4, 1)
        Panel4_2.BackColor = BoardColours(4, 2)
        Panel4_3.BackColor = BoardColours(4, 3)
        Panel4_4.BackColor = BoardColours(4, 4)
        Panel4_5.BackColor = BoardColours(4, 5)
        Panel4_6.BackColor = BoardColours(4, 6)
        Panel4_7.BackColor = BoardColours(4, 7)
        Panel5_0.BackColor = BoardColours(5, 0)
        Panel5_1.BackColor = BoardColours(5, 1)
        Panel5_2.BackColor = BoardColours(5, 2)
        Panel5_3.BackColor = BoardColours(5, 3)
        Panel5_4.BackColor = BoardColours(5, 4)
        Panel5_5.BackColor = BoardColours(5, 5)
        Panel5_6.BackColor = BoardColours(5, 6)
        Panel5_7.BackColor = BoardColours(5, 7)
        Panel6_0.BackColor = BoardColours(6, 0)
        Panel6_1.BackColor = BoardColours(6, 1)
        Panel6_2.BackColor = BoardColours(6, 2)
        Panel6_3.BackColor = BoardColours(6, 3)
        Panel6_4.BackColor = BoardColours(6, 4)
        Panel6_5.BackColor = BoardColours(6, 5)
        Panel6_6.BackColor = BoardColours(6, 6)
        Panel6_7.BackColor = BoardColours(6, 7)
        Panel7_0.BackColor = BoardColours(7, 0)
        Panel7_1.BackColor = BoardColours(7, 1)
        Panel7_2.BackColor = BoardColours(7, 2)
        Panel7_3.BackColor = BoardColours(7, 3)
        Panel7_4.BackColor = BoardColours(7, 4)
        Panel7_5.BackColor = BoardColours(7, 5)
        Panel7_6.BackColor = BoardColours(7, 6)
        Panel7_7.BackColor = BoardColours(7, 7)
    End Sub

    Private Sub Panel0_0_Click(sender As Object, e As MouseEventArgs) Handles Panel0_0.Click
        If board.GetSelectedStatus = False Then
            Panel0_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 0)
    End Sub
    Private Sub Panel0_1_Click(sender As Object, e As MouseEventArgs) Handles Panel0_1.Click
        If board.GetSelectedStatus = False Then
            Panel0_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 1)
    End Sub
    Private Sub Panel0_2_Click(sender As Object, e As MouseEventArgs) Handles Panel0_2.Click
        If board.GetSelectedStatus = False Then
            Panel0_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 2)
    End Sub
    Private Sub Panel0_3_Click(sender As Object, e As MouseEventArgs) Handles Panel0_3.Click
        If board.GetSelectedStatus = False Then
            Panel0_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 3)
    End Sub
    Private Sub Panel0_4_Click(sender As Object, e As MouseEventArgs) Handles Panel0_4.Click
        If board.GetSelectedStatus = False Then
            Panel0_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 4)
    End Sub
    Private Sub Panel0_5_Click(sender As Object, e As MouseEventArgs) Handles Panel0_5.Click
        If board.GetSelectedStatus = False Then
            Panel0_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 5)
    End Sub
    Private Sub Panel0_6_Click(sender As Object, e As MouseEventArgs) Handles Panel0_6.Click
        If board.GetSelectedStatus = False Then
            Panel0_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 6)
    End Sub
    Private Sub Panel0_7_Click(sender As Object, e As MouseEventArgs) Handles Panel0_7.Click
        If board.GetSelectedStatus = False Then
            Panel0_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 7)
    End Sub
    Private Sub Panel1_0_Click(sender As Object, e As MouseEventArgs) Handles Panel1_0.Click
        If board.GetSelectedStatus = False Then
            Panel1_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 0)
    End Sub
    Private Sub Panel1_1_Click(sender As Object, e As MouseEventArgs) Handles Panel1_1.Click
        If board.GetSelectedStatus = False Then
            Panel1_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 1)
    End Sub
    Private Sub Panel1_2_Click(sender As Object, e As MouseEventArgs) Handles Panel1_2.Click
        If board.GetSelectedStatus = False Then
            Panel1_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 2)
    End Sub
    Private Sub Panel1_3_Click(sender As Object, e As MouseEventArgs) Handles Panel1_3.Click
        If board.GetSelectedStatus = False Then
            Panel1_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 3)
    End Sub
    Private Sub Panel1_4_Click(sender As Object, e As MouseEventArgs) Handles Panel1_4.Click
        If board.GetSelectedStatus = False Then
            Panel1_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 4)
    End Sub
    Private Sub Panel1_5_Click(sender As Object, e As MouseEventArgs) Handles Panel1_5.Click
        If board.GetSelectedStatus = False Then
            Panel1_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 5)
    End Sub
    Private Sub Panel1_6_Click(sender As Object, e As MouseEventArgs) Handles Panel1_6.Click
        If board.GetSelectedStatus = False Then
            Panel1_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 6)
    End Sub
    Private Sub Panel1_7_Click(sender As Object, e As MouseEventArgs) Handles Panel1_7.Click
        If board.GetSelectedStatus = False Then
            Panel1_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 7)
    End Sub
    Private Sub Panel2_0_Click(sender As Object, e As MouseEventArgs) Handles Panel2_0.Click
        If board.GetSelectedStatus = False Then
            Panel2_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 0)
    End Sub
    Private Sub Panel2_1_Click(sender As Object, e As MouseEventArgs) Handles Panel2_1.Click
        If board.GetSelectedStatus = False Then
            Panel2_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 1)
    End Sub
    Private Sub Panel2_2_Click(sender As Object, e As MouseEventArgs) Handles Panel2_2.Click
        If board.GetSelectedStatus = False Then
            Panel2_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 2)
    End Sub
    Private Sub Panel2_3_Click(sender As Object, e As MouseEventArgs) Handles Panel2_3.Click
        If board.GetSelectedStatus = False Then
            Panel2_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 3)
    End Sub
    Private Sub Panel2_4_Click(sender As Object, e As MouseEventArgs) Handles Panel2_4.Click
        If board.GetSelectedStatus = False Then
            Panel2_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 4)
    End Sub
    Private Sub Panel2_5_Click(sender As Object, e As MouseEventArgs) Handles Panel2_5.Click
        If board.GetSelectedStatus = False Then
            Panel2_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 5)
    End Sub
    Private Sub Panel2_6_Click(sender As Object, e As MouseEventArgs) Handles Panel2_6.Click
        If board.GetSelectedStatus = False Then
            Panel2_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 6)
    End Sub
    Private Sub Panel2_7_Click(sender As Object, e As MouseEventArgs) Handles Panel2_7.Click
        If board.GetSelectedStatus = False Then
            Panel2_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 7)
    End Sub
    Private Sub Panel3_0_Click(sender As Object, e As MouseEventArgs) Handles Panel3_0.Click
        If board.GetSelectedStatus = False Then
            Panel3_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 0)
    End Sub
    Private Sub Panel3_1_Click(sender As Object, e As MouseEventArgs) Handles Panel3_1.Click
        If board.GetSelectedStatus = False Then
            Panel3_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 1)
    End Sub
    Private Sub Panel3_2_Click(sender As Object, e As MouseEventArgs) Handles Panel3_2.Click
        If board.GetSelectedStatus = False Then
            Panel3_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 2)
    End Sub
    Private Sub Panel3_3_Click(sender As Object, e As MouseEventArgs) Handles Panel3_3.Click
        If board.GetSelectedStatus = False Then
            Panel3_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 3)
    End Sub
    Private Sub Panel3_4_Click(sender As Object, e As MouseEventArgs) Handles Panel3_4.Click
        If board.GetSelectedStatus = False Then
            Panel3_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 4)
    End Sub
    Private Sub Panel3_5_Click(sender As Object, e As MouseEventArgs) Handles Panel3_5.Click
        If board.GetSelectedStatus = False Then
            Panel3_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 5)
    End Sub
    Private Sub Panel3_6_Click(sender As Object, e As MouseEventArgs) Handles Panel3_6.Click
        If board.GetSelectedStatus = False Then
            Panel3_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 6)
    End Sub
    Private Sub Panel3_7_Click(sender As Object, e As MouseEventArgs) Handles Panel3_7.Click
        If board.GetSelectedStatus = False Then
            Panel3_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 7)
    End Sub
    Private Sub Panel4_0_Click(sender As Object, e As MouseEventArgs) Handles Panel4_0.Click
        If board.GetSelectedStatus = False Then
            Panel4_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 0)
    End Sub
    Private Sub Panel4_1_Click(sender As Object, e As MouseEventArgs) Handles Panel4_1.Click
        If board.GetSelectedStatus = False Then
            Panel4_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 1)
    End Sub
    Private Sub Panel4_2_Click(sender As Object, e As MouseEventArgs) Handles Panel4_2.Click
        If board.GetSelectedStatus = False Then
            Panel4_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 2)
    End Sub
    Private Sub Panel4_3_Click(sender As Object, e As MouseEventArgs) Handles Panel4_3.Click
        If board.GetSelectedStatus = False Then
            Panel4_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 3)
    End Sub
    Private Sub Panel4_4_Click(sender As Object, e As MouseEventArgs) Handles Panel4_4.Click
        If board.GetSelectedStatus = False Then
            Panel4_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 4)
    End Sub
    Private Sub Panel4_5_Click(sender As Object, e As MouseEventArgs) Handles Panel4_5.Click
        If board.GetSelectedStatus = False Then
            Panel4_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 5)
    End Sub
    Private Sub Panel4_6_Click(sender As Object, e As MouseEventArgs) Handles Panel4_6.Click
        If board.GetSelectedStatus = False Then
            Panel4_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 6)
    End Sub
    Private Sub Panel4_7_Click(sender As Object, e As MouseEventArgs) Handles Panel4_7.Click
        If board.GetSelectedStatus = False Then
            Panel4_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 7)
    End Sub
    Private Sub Panel5_0_Click(sender As Object, e As MouseEventArgs) Handles Panel5_0.Click
        If board.GetSelectedStatus = False Then
            Panel5_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 0)
    End Sub
    Private Sub Panel5_1_Click(sender As Object, e As MouseEventArgs) Handles Panel5_1.Click
        If board.GetSelectedStatus = False Then
            Panel5_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 1)
    End Sub
    Private Sub Panel5_2_Click(sender As Object, e As MouseEventArgs) Handles Panel5_2.Click
        If board.GetSelectedStatus = False Then
            Panel5_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 2)
    End Sub
    Private Sub Panel5_3_Click(sender As Object, e As MouseEventArgs) Handles Panel5_3.Click
        If board.GetSelectedStatus = False Then
            Panel5_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 3)
    End Sub
    Private Sub Panel5_4_Click(sender As Object, e As MouseEventArgs) Handles Panel5_4.Click
        If board.GetSelectedStatus = False Then
            Panel5_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 4)
    End Sub
    Private Sub Panel5_5_Click(sender As Object, e As MouseEventArgs) Handles Panel5_5.Click
        If board.GetSelectedStatus = False Then
            Panel5_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 5)
    End Sub
    Private Sub Panel5_6_Click(sender As Object, e As MouseEventArgs) Handles Panel5_6.Click
        If board.GetSelectedStatus = False Then
            Panel5_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 6)
    End Sub
    Private Sub Panel5_7_Click(sender As Object, e As MouseEventArgs) Handles Panel5_7.Click
        If board.GetSelectedStatus = False Then
            Panel5_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 7)
    End Sub
    Private Sub Panel6_0_Click(sender As Object, e As MouseEventArgs) Handles Panel6_0.Click
        If board.GetSelectedStatus = False Then
            Panel6_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 0)
    End Sub
    Private Sub Panel6_1_Click(sender As Object, e As MouseEventArgs) Handles Panel6_1.Click
        If board.GetSelectedStatus = False Then
            Panel6_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 1)
    End Sub
    Private Sub Panel6_2_Click(sender As Object, e As MouseEventArgs) Handles Panel6_2.Click
        If board.GetSelectedStatus = False Then
            Panel6_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 2)
    End Sub
    Private Sub Panel6_3_Click(sender As Object, e As MouseEventArgs) Handles Panel6_3.Click
        If board.GetSelectedStatus = False Then
            Panel6_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 3)
    End Sub
    Private Sub Panel6_4_Click(sender As Object, e As MouseEventArgs) Handles Panel6_4.Click
        If board.GetSelectedStatus = False Then
            Panel6_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 4)
    End Sub
    Private Sub Panel6_5_Click(sender As Object, e As MouseEventArgs) Handles Panel6_5.Click
        If board.GetSelectedStatus = False Then
            Panel6_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 5)
    End Sub
    Private Sub Panel6_6_Click(sender As Object, e As MouseEventArgs) Handles Panel6_6.Click
        If board.GetSelectedStatus = False Then
            Panel6_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 6)
    End Sub
    Private Sub Panel6_7_Click(sender As Object, e As MouseEventArgs) Handles Panel6_7.Click
        If board.GetSelectedStatus = False Then
            Panel6_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 7)
    End Sub
    Private Sub Panel7_0_Click(sender As Object, e As MouseEventArgs) Handles Panel7_0.Click
        If board.GetSelectedStatus = False Then
            Panel7_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 0)
    End Sub
    Private Sub Panel7_1_Click(sender As Object, e As MouseEventArgs) Handles Panel7_1.Click
        If board.GetSelectedStatus = False Then
            Panel7_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 1)
    End Sub
    Private Sub Panel7_2_Click(sender As Object, e As MouseEventArgs) Handles Panel7_2.Click
        If board.GetSelectedStatus = False Then
            Panel7_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 2)
    End Sub
    Private Sub Panel7_3_Click(sender As Object, e As MouseEventArgs) Handles Panel7_3.Click
        If board.GetSelectedStatus = False Then
            Panel7_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 3)
    End Sub
    Private Sub Panel7_4_Click(sender As Object, e As MouseEventArgs) Handles Panel7_4.Click
        If board.GetSelectedStatus = False Then
            Panel7_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 4)
    End Sub
    Private Sub Panel7_5_Click(sender As Object, e As MouseEventArgs) Handles Panel7_5.Click
        If board.GetSelectedStatus = False Then
            Panel7_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 5)
    End Sub
    Private Sub Panel7_6_Click(sender As Object, e As MouseEventArgs) Handles Panel7_6.Click
        If board.GetSelectedStatus = False Then
            Panel7_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 6)
    End Sub
    Private Sub Panel7_7_Click(sender As Object, e As MouseEventArgs) Handles Panel7_7.Click
        If board.GetSelectedStatus = False Then
            Panel7_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 7)
    End Sub
    Private Sub Label0_0_Click(sender As Object, e As MouseEventArgs) Handles Label0_0.Click
        If board.GetSelectedStatus = False Then
            Panel0_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 0)
    End Sub
    Private Sub Label0_1_Click(sender As Object, e As MouseEventArgs) Handles Label0_1.Click
        If board.GetSelectedStatus = False Then
            Panel0_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 1)
    End Sub
    Private Sub Label0_2_Click(sender As Object, e As MouseEventArgs) Handles Label0_2.Click
        If board.GetSelectedStatus = False Then
            Panel0_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 2)
    End Sub
    Private Sub Label0_3_Click(sender As Object, e As MouseEventArgs) Handles Label0_3.Click
        If board.GetSelectedStatus = False Then
            Panel0_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 3)
    End Sub
    Private Sub Label0_4_Click(sender As Object, e As MouseEventArgs) Handles Label0_4.Click
        If board.GetSelectedStatus = False Then
            Panel0_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 4)
    End Sub
    Private Sub Label0_5_Click(sender As Object, e As MouseEventArgs) Handles Label0_5.Click
        If board.GetSelectedStatus = False Then
            Panel0_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 5)
    End Sub
    Private Sub Label0_6_Click(sender As Object, e As MouseEventArgs) Handles Label0_6.Click
        If board.GetSelectedStatus = False Then
            Panel0_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 6)
    End Sub
    Private Sub Label0_7_Click(sender As Object, e As MouseEventArgs) Handles Label0_7.Click
        If board.GetSelectedStatus = False Then
            Panel0_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(0, 7)
    End Sub
    Private Sub Label1_0_Click(sender As Object, e As MouseEventArgs) Handles Label1_0.Click
        If board.GetSelectedStatus = False Then
            Panel1_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 0)
    End Sub
    Private Sub Label1_1_Click(sender As Object, e As MouseEventArgs) Handles Label1_1.Click
        If board.GetSelectedStatus = False Then
            Panel1_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 1)
    End Sub
    Private Sub Label1_2_Click(sender As Object, e As MouseEventArgs) Handles Label1_2.Click
        If board.GetSelectedStatus = False Then
            Panel1_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 2)
    End Sub
    Private Sub Label1_3_Click(sender As Object, e As MouseEventArgs) Handles Label1_3.Click
        If board.GetSelectedStatus = False Then
            Panel1_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 3)
    End Sub
    Private Sub Label1_4_Click(sender As Object, e As MouseEventArgs) Handles Label1_4.Click
        If board.GetSelectedStatus = False Then
            Panel1_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 4)
    End Sub
    Private Sub Label1_5_Click(sender As Object, e As MouseEventArgs) Handles Label1_5.Click
        If board.GetSelectedStatus = False Then
            Panel1_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 5)
    End Sub
    Private Sub Label1_6_Click(sender As Object, e As MouseEventArgs) Handles Label1_6.Click
        If board.GetSelectedStatus = False Then
            Panel1_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 6)
    End Sub
    Private Sub Label1_7_Click(sender As Object, e As MouseEventArgs) Handles Label1_7.Click
        If board.GetSelectedStatus = False Then
            Panel1_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(1, 7)
    End Sub
    Private Sub Label2_0_Click(sender As Object, e As MouseEventArgs) Handles Label2_0.Click
        If board.GetSelectedStatus = False Then
            Panel2_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 0)
    End Sub
    Private Sub Label2_1_Click(sender As Object, e As MouseEventArgs) Handles Label2_1.Click
        If board.GetSelectedStatus = False Then
            Panel2_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 1)
    End Sub
    Private Sub Label2_2_Click(sender As Object, e As MouseEventArgs) Handles Label2_2.Click
        If board.GetSelectedStatus = False Then
            Panel2_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 2)
    End Sub
    Private Sub Label2_3_Click(sender As Object, e As MouseEventArgs) Handles Label2_3.Click
        If board.GetSelectedStatus = False Then
            Panel2_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 3)
    End Sub
    Private Sub Label2_4_Click(sender As Object, e As MouseEventArgs) Handles Label2_4.Click
        If board.GetSelectedStatus = False Then
            Panel2_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 4)
    End Sub
    Private Sub Label2_5_Click(sender As Object, e As MouseEventArgs) Handles Label2_5.Click
        If board.GetSelectedStatus = False Then
            Panel2_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 5)
    End Sub
    Private Sub Label2_6_Click(sender As Object, e As MouseEventArgs) Handles Label2_6.Click
        If board.GetSelectedStatus = False Then
            Panel2_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 6)
    End Sub
    Private Sub Label2_7_Click(sender As Object, e As MouseEventArgs) Handles Label2_7.Click
        If board.GetSelectedStatus = False Then
            Panel2_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(2, 7)
    End Sub
    Private Sub Label3_0_Click(sender As Object, e As MouseEventArgs) Handles Label3_0.Click
        If board.GetSelectedStatus = False Then
            Panel3_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 0)
    End Sub
    Private Sub Label3_1_Click(sender As Object, e As MouseEventArgs) Handles Label3_1.Click
        If board.GetSelectedStatus = False Then
            Panel3_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 1)
    End Sub
    Private Sub Label3_2_Click(sender As Object, e As MouseEventArgs) Handles Label3_2.Click
        If board.GetSelectedStatus = False Then
            Panel3_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 2)
    End Sub
    Private Sub Label3_3_Click(sender As Object, e As MouseEventArgs) Handles Label3_3.Click
        If board.GetSelectedStatus = False Then
            Panel3_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 3)
    End Sub
    Private Sub Label3_4_Click(sender As Object, e As MouseEventArgs) Handles Label3_4.Click
        If board.GetSelectedStatus = False Then
            Panel3_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 4)
    End Sub
    Private Sub Label3_5_Click(sender As Object, e As MouseEventArgs) Handles Label3_5.Click
        If board.GetSelectedStatus = False Then
            Panel3_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 5)
    End Sub
    Private Sub Label3_6_Click(sender As Object, e As MouseEventArgs) Handles Label3_6.Click
        If board.GetSelectedStatus = False Then
            Panel3_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 6)
    End Sub
    Private Sub Label3_7_Click(sender As Object, e As MouseEventArgs) Handles Label3_7.Click
        If board.GetSelectedStatus = False Then
            Panel3_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(3, 7)
    End Sub
    Private Sub Label4_0_Click(sender As Object, e As MouseEventArgs) Handles Label4_0.Click
        If board.GetSelectedStatus = False Then
            Panel4_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 0)
    End Sub
    Private Sub Label4_1_Click(sender As Object, e As MouseEventArgs) Handles Label4_1.Click
        If board.GetSelectedStatus = False Then
            Panel4_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 1)
    End Sub
    Private Sub Label4_2_Click(sender As Object, e As MouseEventArgs) Handles Label4_2.Click
        If board.GetSelectedStatus = False Then
            Panel4_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 2)
    End Sub
    Private Sub Label4_3_Click(sender As Object, e As MouseEventArgs) Handles Label4_3.Click
        If board.GetSelectedStatus = False Then
            Panel4_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 3)
    End Sub
    Private Sub Label4_4_Click(sender As Object, e As MouseEventArgs) Handles Label4_4.Click
        If board.GetSelectedStatus = False Then
            Panel4_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 4)
    End Sub
    Private Sub Label4_5_Click(sender As Object, e As MouseEventArgs) Handles Label4_5.Click
        If board.GetSelectedStatus = False Then
            Panel4_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 5)
    End Sub
    Private Sub Label4_6_Click(sender As Object, e As MouseEventArgs) Handles Label4_6.Click
        If board.GetSelectedStatus = False Then
            Panel4_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 6)
    End Sub
    Private Sub Label4_7_Click(sender As Object, e As MouseEventArgs) Handles Label4_7.Click
        If board.GetSelectedStatus = False Then
            Panel4_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(4, 7)
    End Sub
    Private Sub Label5_0_Click(sender As Object, e As MouseEventArgs) Handles Label5_0.Click
        If board.GetSelectedStatus = False Then
            Panel5_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 0)
    End Sub
    Private Sub Label5_1_Click(sender As Object, e As MouseEventArgs) Handles Label5_1.Click
        If board.GetSelectedStatus = False Then
            Panel5_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 1)
    End Sub
    Private Sub Label5_2_Click(sender As Object, e As MouseEventArgs) Handles Label5_2.Click
        If board.GetSelectedStatus = False Then
            Panel5_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 2)
    End Sub
    Private Sub Label5_3_Click(sender As Object, e As MouseEventArgs) Handles Label5_3.Click
        If board.GetSelectedStatus = False Then
            Panel5_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 3)
    End Sub
    Private Sub Label5_4_Click(sender As Object, e As MouseEventArgs) Handles Label5_4.Click
        If board.GetSelectedStatus = False Then
            Panel5_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 4)
    End Sub
    Private Sub Label5_5_Click(sender As Object, e As MouseEventArgs) Handles Label5_5.Click
        If board.GetSelectedStatus = False Then
            Panel5_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 5)
    End Sub
    Private Sub Label5_6_Click(sender As Object, e As MouseEventArgs) Handles Label5_6.Click
        If board.GetSelectedStatus = False Then
            Panel5_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 6)
    End Sub
    Private Sub Label5_7_Click(sender As Object, e As MouseEventArgs) Handles Label5_7.Click
        If board.GetSelectedStatus = False Then
            Panel5_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(5, 7)
    End Sub
    Private Sub Label6_0_Click(sender As Object, e As MouseEventArgs) Handles Label6_0.Click
        If board.GetSelectedStatus = False Then
            Panel6_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 0)
    End Sub
    Private Sub Label6_1_Click(sender As Object, e As MouseEventArgs) Handles Label6_1.Click
        If board.GetSelectedStatus = False Then
            Panel6_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 1)
    End Sub
    Private Sub Label6_2_Click(sender As Object, e As MouseEventArgs) Handles Label6_2.Click
        If board.GetSelectedStatus = False Then
            Panel6_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 2)
    End Sub
    Private Sub Label6_3_Click(sender As Object, e As MouseEventArgs) Handles Label6_3.Click
        If board.GetSelectedStatus = False Then
            Panel6_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 3)
    End Sub
    Private Sub Label6_4_Click(sender As Object, e As MouseEventArgs) Handles Label6_4.Click
        If board.GetSelectedStatus = False Then
            Panel6_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 4)
    End Sub
    Private Sub Label6_5_Click(sender As Object, e As MouseEventArgs) Handles Label6_5.Click
        If board.GetSelectedStatus = False Then
            Panel6_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 5)
    End Sub
    Private Sub Label6_6_Click(sender As Object, e As MouseEventArgs) Handles Label6_6.Click
        If board.GetSelectedStatus = False Then
            Panel6_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 6)
    End Sub
    Private Sub Label6_7_Click(sender As Object, e As MouseEventArgs) Handles Label6_7.Click
        If board.GetSelectedStatus = False Then
            Panel6_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(6, 7)
    End Sub
    Private Sub Label7_0_Click(sender As Object, e As MouseEventArgs) Handles Label7_0.Click
        If board.GetSelectedStatus = False Then
            Panel7_0.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 0)
    End Sub
    Private Sub Label7_1_Click(sender As Object, e As MouseEventArgs) Handles Label7_1.Click
        If board.GetSelectedStatus = False Then
            Panel7_1.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 1)
    End Sub
    Private Sub Label7_2_Click(sender As Object, e As MouseEventArgs) Handles Label7_2.Click
        If board.GetSelectedStatus = False Then
            Panel7_2.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 2)
    End Sub
    Private Sub Label7_3_Click(sender As Object, e As MouseEventArgs) Handles Label7_3.Click
        If board.GetSelectedStatus = False Then
            Panel7_3.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 3)
    End Sub
    Private Sub Label7_4_Click(sender As Object, e As MouseEventArgs) Handles Label7_4.Click
        If board.GetSelectedStatus = False Then
            Panel7_4.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 4)
    End Sub
    Private Sub Label7_5_Click(sender As Object, e As MouseEventArgs) Handles Label7_5.Click
        If board.GetSelectedStatus = False Then
            Panel7_5.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 5)
    End Sub
    Private Sub Label7_6_Click(sender As Object, e As MouseEventArgs) Handles Label7_6.Click
        If board.GetSelectedStatus = False Then
            Panel7_6.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 6)
    End Sub
    Private Sub Label7_7_Click(sender As Object, e As MouseEventArgs) Handles Label7_7.Click
        If board.GetSelectedStatus = False Then
            Panel7_7.BackColor = SelectedPanel.BackColor
        End If
        board.Click(7, 7)
    End Sub
    Public Sub EmptyTarget(Target As Integer(), senderPos As Integer(), senderType As String, senderOwner As Boolean)
        If Target(0) = 0 Then
            If Target(1) = 0 And (senderPos(0) <> 0 Or senderPos(1) <> 0) Then
                If (senderType = "queen" Or senderType = "bishop") And senderPos(0) = senderPos(1) Then
                    Panel0_0.BackColor = MovePanel.BackColor
                ElseIf (senderType = "queen" Or senderType = "rook") And (senderPos(0) = 0 Or senderPos(1) = 0) Then
                    Panel0_0.BackColor = MovePanel.BackColor
                ElseIf senderType = "knight" And (senderPos Is {2, 1} Or senderPos Is {1, 2}) Then
                    Panel0_0.BackColor = MovePanel.BackColor
                ElseIf senderType = "king" And (senderPos Is {1, 0} Or senderPos Is {1, 1} Or senderPos Is {0, 1}) Then
                    Panel0_0.BackColor = MovePanel.BackColor
                ElseIf senderType = "pawn" And senderOwner = False And senderPos Is {1, 0} Then
                    Panel0_0.BackColor = MovePanel.BackColor
                End If
            ElseIf Target(1) = 1 Then
                Panel0_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel0_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel0_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel0_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel0_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel0_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel0_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 1 Then
            If Target(1) = 0 Then
                Panel1_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel1_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel1_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel1_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel1_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel1_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel1_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel1_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 2 Then
            If Target(1) = 0 Then
                Panel2_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel2_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel2_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel2_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel2_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel2_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel2_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel2_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 3 Then
            If Target(1) = 0 Then
                Panel3_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel3_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel3_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel3_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel3_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel3_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel3_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel3_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 4 Then
            If Target(1) = 0 Then
                Panel4_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel4_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel4_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel4_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel4_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel4_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel4_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel4_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 5 Then
            If Target(1) = 0 Then
                Panel5_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel5_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel5_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel5_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel5_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel5_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel5_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel5_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 6 Then
            If Target(1) = 0 Then
                Panel6_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel6_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel6_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel6_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel6_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel6_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel6_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel6_7.BackColor = MovePanel.BackColor
            End If
        ElseIf Target(0) = 7 Then
            If Target(1) = 0 Then
                Panel7_0.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 1 Then
                Panel7_1.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 2 Then
                Panel7_2.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 3 Then
                Panel7_3.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 4 Then
                Panel7_4.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 5 Then
                Panel7_5.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 6 Then
                Panel7_6.BackColor = MovePanel.BackColor
            ElseIf Target(1) = 7 Then
                Panel7_7.BackColor = MovePanel.BackColor
            End If
        End If
    End Sub
    Public Sub EnemyTarget(Target As Integer(), senderPos As Integer(), senderType As String, senderOwner As Boolean)
        For i = 0 To Target.Length - 1
            If Target(0) = 0 Then
                If Target(1) = 0 And (senderPos(0) <> 0 Or senderPos(1) <> 0) Then
                    If (senderType = "queen" Or senderType = "bishop") And senderPos(0) = senderPos(1) Then
                        Panel0_0.BackColor = TakePanel.BackColor
                    ElseIf (senderType = "queen" Or senderType = "rook") And (senderPos(0) = 0 Or senderPos(1) = 0) Then
                        Panel0_0.BackColor = TakePanel.BackColor
                    ElseIf senderType = "knight" And (senderPos Is {2, 1} Or senderPos Is {1, 2}) Then
                        Panel0_0.BackColor = TakePanel.BackColor
                    ElseIf senderType = "king" And (senderPos Is {1, 0} Or senderPos Is {1, 1} Or senderPos Is {0, 1}) Then
                        Panel0_0.BackColor = TakePanel.BackColor
                    ElseIf senderType = "pawn" And senderOwner = False And senderPos Is {1, 0} Then
                        Panel0_0.BackColor = TakePanel.BackColor
                    End If
                ElseIf Target(1) = 1 Then
                    Panel0_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel0_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel0_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel0_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel0_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel0_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel0_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 1 Then
                If Target(1) = 0 Then
                    Panel1_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel1_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel1_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel1_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel1_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel1_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel1_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel1_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 2 Then
                If Target(1) = 0 Then
                    Panel2_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel2_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel2_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel2_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel2_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel2_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel2_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel2_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 3 Then
                If Target(1) = 0 Then
                    Panel3_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel3_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel3_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel3_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel3_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel3_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel3_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel3_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 4 Then
                If Target(1) = 0 Then
                    Panel4_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel4_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel4_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel4_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel4_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel4_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel4_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel4_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 5 Then
                If Target(1) = 0 Then
                    Panel5_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel5_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel5_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel5_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel5_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel5_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel5_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel5_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 6 Then
                If Target(1) = 0 Then
                    Panel6_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel6_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel6_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel6_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel6_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel6_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel6_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel6_7.BackColor = TakePanel.BackColor
                End If
            ElseIf Target(0) = 7 Then
                If Target(1) = 0 Then
                    Panel7_0.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 1 Then
                    Panel7_1.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 2 Then
                    Panel7_2.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 3 Then
                    Panel7_3.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 4 Then
                    Panel7_4.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 5 Then
                    Panel7_5.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 6 Then
                    Panel7_6.BackColor = TakePanel.BackColor
                ElseIf Target(1) = 7 Then
                    Panel7_7.BackColor = TakePanel.BackColor
                End If
            End If
        Next
    End Sub
    Public Function GetColour(x As Integer, y As Integer) As String
        Dim Colour As String = "-"
        If x = 0 Then
            If y = 0 Then
                If Panel0_0.BackColor = MovePanel.BackColor Or Panel0_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel0_1.BackColor = MovePanel.BackColor Or Panel0_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel0_2.BackColor = MovePanel.BackColor Or Panel0_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel0_3.BackColor = MovePanel.BackColor Or Panel0_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel0_4.BackColor = MovePanel.BackColor Or Panel0_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel0_5.BackColor = MovePanel.BackColor Or Panel0_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel0_6.BackColor = MovePanel.BackColor Or Panel0_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel0_7.BackColor = MovePanel.BackColor Or Panel0_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 1 Then
            If y = 0 Then
                If Panel1_0.BackColor = MovePanel.BackColor Or Panel1_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel1_1.BackColor = MovePanel.BackColor Or Panel1_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel1_2.BackColor = MovePanel.BackColor Or Panel1_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel1_3.BackColor = MovePanel.BackColor Or Panel1_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel1_4.BackColor = MovePanel.BackColor Or Panel1_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel1_5.BackColor = MovePanel.BackColor Or Panel1_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel1_6.BackColor = MovePanel.BackColor Or Panel1_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel1_7.BackColor = MovePanel.BackColor Or Panel1_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 2 Then
            If y = 0 Then
                If Panel2_0.BackColor = MovePanel.BackColor Or Panel2_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel2_1.BackColor = MovePanel.BackColor Or Panel2_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel2_2.BackColor = MovePanel.BackColor Or Panel2_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel2_3.BackColor = MovePanel.BackColor Or Panel2_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel2_4.BackColor = MovePanel.BackColor Or Panel2_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel2_5.BackColor = MovePanel.BackColor Or Panel2_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel2_6.BackColor = MovePanel.BackColor Or Panel2_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel2_7.BackColor = MovePanel.BackColor Or Panel2_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 3 Then
            If y = 0 Then
                If Panel3_0.BackColor = MovePanel.BackColor Or Panel3_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel3_1.BackColor = MovePanel.BackColor Or Panel3_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel3_2.BackColor = MovePanel.BackColor Or Panel3_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel3_3.BackColor = MovePanel.BackColor Or Panel3_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel3_4.BackColor = MovePanel.BackColor Or Panel3_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel3_5.BackColor = MovePanel.BackColor Or Panel3_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel3_6.BackColor = MovePanel.BackColor Or Panel3_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel3_7.BackColor = MovePanel.BackColor Or Panel3_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 4 Then
            If y = 0 Then
                If Panel4_0.BackColor = MovePanel.BackColor Or Panel4_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel4_1.BackColor = MovePanel.BackColor Or Panel4_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel4_2.BackColor = MovePanel.BackColor Or Panel4_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel4_3.BackColor = MovePanel.BackColor Or Panel4_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel4_4.BackColor = MovePanel.BackColor Or Panel4_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel4_5.BackColor = MovePanel.BackColor Or Panel4_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel4_6.BackColor = MovePanel.BackColor Or Panel4_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel4_7.BackColor = MovePanel.BackColor Or Panel4_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 5 Then
            If y = 0 Then
                If Panel5_0.BackColor = MovePanel.BackColor Or Panel5_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel5_1.BackColor = MovePanel.BackColor Or Panel5_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel5_2.BackColor = MovePanel.BackColor Or Panel5_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel5_3.BackColor = MovePanel.BackColor Or Panel5_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel5_4.BackColor = MovePanel.BackColor Or Panel5_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel5_5.BackColor = MovePanel.BackColor Or Panel5_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel5_6.BackColor = MovePanel.BackColor Or Panel5_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel5_7.BackColor = MovePanel.BackColor Or Panel5_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 6 Then
            If y = 0 Then
                If Panel6_0.BackColor = MovePanel.BackColor Or Panel6_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel6_1.BackColor = MovePanel.BackColor Or Panel6_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel6_2.BackColor = MovePanel.BackColor Or Panel6_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel6_3.BackColor = MovePanel.BackColor Or Panel6_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel6_4.BackColor = MovePanel.BackColor Or Panel6_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel6_5.BackColor = MovePanel.BackColor Or Panel6_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel6_6.BackColor = MovePanel.BackColor Or Panel6_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel6_7.BackColor = MovePanel.BackColor Or Panel6_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        ElseIf x = 7 Then
            If y = 0 Then
                If Panel7_0.BackColor = MovePanel.BackColor Or Panel7_0.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 1 Then
                If Panel7_1.BackColor = MovePanel.BackColor Or Panel7_1.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 2 Then
                If Panel7_2.BackColor = MovePanel.BackColor Or Panel7_2.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 3 Then
                If Panel7_3.BackColor = MovePanel.BackColor Or Panel7_3.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 4 Then
                If Panel7_4.BackColor = MovePanel.BackColor Or Panel7_4.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 5 Then
                If Panel7_5.BackColor = MovePanel.BackColor Or Panel7_5.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 6 Then
                If Panel7_6.BackColor = MovePanel.BackColor Or Panel7_6.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            ElseIf y = 7 Then
                If Panel7_7.BackColor = MovePanel.BackColor Or Panel7_7.BackColor = TakePanel.BackColor Then
                    Colour = "+"
                End If
            End If
        End If
        If x = 0 Then
            If y = 0 Then
                If Panel0_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel0_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel0_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel0_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel0_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel0_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel0_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel0_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 1 Then
            If y = 0 Then
                If Panel1_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel1_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel1_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel1_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel1_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel1_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel1_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel1_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 2 Then
            If y = 0 Then
                If Panel2_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel2_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel2_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel2_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel2_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel2_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel2_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel2_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 3 Then
            If y = 0 Then
                If Panel3_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel3_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel3_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel3_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel3_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel3_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel3_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel3_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 4 Then
            If y = 0 Then
                If Panel4_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel4_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel4_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel4_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel4_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel4_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel4_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel4_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 5 Then
            If y = 0 Then
                If Panel5_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel5_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel5_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel5_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel5_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel5_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel5_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel5_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 6 Then
            If y = 0 Then
                If Panel6_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel6_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel6_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel6_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel6_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel6_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel6_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel6_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        ElseIf x = 7 Then
            If y = 0 Then
                If Panel7_0.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 1 Then
                If Panel7_1.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 2 Then
                If Panel7_2.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 3 Then
                If Panel7_3.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 4 Then
                If Panel7_4.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 5 Then
                If Panel7_5.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 6 Then
                If Panel7_6.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            ElseIf y = 7 Then
                If Panel7_7.BackColor = SelectedPanel.BackColor Then
                    Colour = "="
                End If
            End If
        End If
        Return Colour
    End Function
End Class
