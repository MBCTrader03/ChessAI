Imports System.IO
Imports System.DateTime
Imports ChessAI.Chess

Namespace Chess
    Public Class Game
        Private GameID As String
        Private Username As String
        Private Diff_Nr As Integer
        Private Diff_Str As String
        Private Tutorial As Boolean
        Private AIPrompt As Boolean
        Private Board As Chess.Board
        Private Moves As Chess.Moves
        Private Pieces As Chess.Pieces
        Private Players(2) As Chess.Player
        Private AI As Chess.AI
        Private Turn As Boolean
        Public Sub New()
            Me.Diff_Nr = 0
            Me.Diff_Str = "undefined"
            Me.Tutorial = False
            Me.AIPrompt = False
            Me.Board = New Board
            Me.Moves = New Moves
            Me.Pieces = New Pieces
            Me.Players(0) = New Player(True, {0, 4})
            Me.Players(1) = New Player(False, {7, 4})
            Me.AI = New AI
            Me.Turn = True
        End Sub
        Public Sub SetUsername(PlayerName As String)
            Me.Username = PlayerName
        End Sub
        Public Function GetUsername() As String
            Return Me.Username
        End Function
        Public Sub StartGame()
            Me.CreateGameID()
        End Sub
        Public Sub CreateGameID()
            Dim CreationTime As String = DateTime.UtcNow.ToString()
            Dim TimeAndDate As String() = CreationTime.Split(" ")
            Dim GDate As String() = TimeAndDate(0).Split("/")
            Dim GTime As String() = TimeAndDate(1).Split(":")
            Me.GameID = Me.Username + "_" + GDate(2) + "-" + GDate(1) + "-" + GDate(0) + "_" + GTime(0) + "-" + GTime(1) + "-" + GTime(2)
        End Sub
        Public Sub SetDifficulty(Nr As Integer, Str As String)
            Me.Diff_Nr = Nr
            Me.Diff_Str = Str
        End Sub
        Public Function GetDifficulty() As Integer
            Return Me.Diff_Nr
        End Function
        Public Sub SetGameSettings(TMode As Boolean, Prompter As Boolean)
            Me.Tutorial = TMode
            Me.AIPrompt = Prompter
        End Sub
        Public Function InitialiseBoard() As String(,)
            Return Me.Board.Initialise()
        End Function
        Public Sub SqSelect(x As Integer, y As Integer)
            Me.Board.Click(x, y)
        End Sub
        Public Function GetSelected() As Boolean
            Return Me.Board.GetSelectedStatus()
        End Function
        Public Function PawnTake(Owner As Boolean, x As Integer, y As Integer) As Integer(,)
            Return Me.Moves.PawnTake(Owner, x, y)
        End Function
        Public Function GetMoves(Type As String, Owner As Boolean, HasMoved As Boolean, x As Integer, y As Integer) As Integer(,)
            Return Me.Moves.GetSquare(Type, Owner, HasMoved, x, y)
        End Function
        Public Sub ToggleTurn()
            If Me.Turn = True Then
                Me.Turn = False
                Me.Players(1).IsInCheck()
                Me.AI.Mirror()
            Else
                Me.Turn = True
                Me.Players(0).IsInCheck()
            End If
        End Sub
        Public Function GetTurn() As Boolean
            Return Me.Turn
        End Function
        Public Sub StoreMove(Move As Integer(,))
            Me.AI.RecordMove(Move)
        End Sub
        Public Sub KingMove(Owner As Boolean, NewPos As Integer())
            If Owner = True Then
                Me.Players(0).MoveKing(NewPos)
            Else
                Me.Players(1).MoveKing(NewPos)
            End If
        End Sub
        Public Sub IsInCheck(Player As Boolean, KingPos As Integer())
            Me.Board.IsInCheck(Player, KingPos, True)
        End Sub
        Public Function GetKing(Player As Boolean) As Integer()
            If Player = True Then
                Return Me.Players(0).GetKingPos()
            Else
                Return Me.Players(1).GetKingPos()
            End If
        End Function
        Public Sub PieceTaken(Owner As Boolean, PieceType As String)
            If Owner = True Then
                Me.Players(1).AddScore(Me.Pieces.GetValue(PieceType))
            Else
                Me.Players(1).AddScore(Me.Pieces.GetValue(PieceType))
            End If
        End Sub
        Public Function GetScores() As Integer()
            Return {Me.Players(0).GetScore(), Me.Players(1).GetScore()}
        End Function
        Public Sub SaveGame()
            Using sWriter As New StreamWriter("Users\" + Me.Username + "\" + Me.GameID + ".csv")
                sWriter.WriteLine(Me.Diff_Nr.ToString() + "," + Me.Diff_Str)
                Dim Scores As Integer() = Me.GetScores()
                sWriter.WriteLine(Scores(0).ToString() + "," + Scores(1).ToString())
                sWriter.WriteLine(Me.Tutorial.ToString() + "," + Me.AIPrompt.ToString())
                Dim PieceDetails As New PieceDetails
                Dim Owner_Str As String
                Dim HasMoved_Str As String
                For i = 0 To 7
                    For j = 0 To 7
                        PieceDetails = Me.Board.GetPieceDetails({i, j})
                        If PieceDetails.Extant = True Then
                            If PieceDetails.Owner = True Then
                                Owner_Str = "True"
                            Else
                                Owner_Str = "False"
                            End If
                            If PieceDetails.HasMoved = True Then
                                HasMoved_Str = "True"
                            Else
                                HasMoved_Str = "False"
                            End If
                            sWriter.WriteLine(i.ToString() + "," + j.ToString() + "," + PieceDetails.Symbol + "," + PieceDetails.PieceType + "," + Owner_Str + "," + HasMoved_Str)
                        End If
                    Next
                Next
            End Using
        End Sub
        Public Sub LoadGame(ID As String)
            Using sReader As New StreamReader("Users\" + Me.Username + "\" + ID + ".csv")
                Me.GameID = ID
                Dim line As String
                line = sReader.ReadLine()
                Dim DiffSettings As String() = line.Split(",")
                Me.Diff_Nr = CInt(DiffSettings(0))
                Me.Diff_Str = DiffSettings(1)
                line = sReader.ReadLine()
                Dim Scores As String() = line.Split(",")
                Me.Players(0).SetScore(CInt(Scores(0)))
                Me.Players(1).SetScore(CInt(Scores(1)))
                line = sReader.ReadLine()
                Dim GameSettings As String() = line.Split(",")
                If GameSettings(0) = "True" Then
                    Me.Tutorial = True
                Else
                    Me.Tutorial = False
                End If
                If GameSettings(1) = "True" Then
                    Me.AIPrompt = True
                Else
                    Me.AIPrompt = False
                End If
                line = sReader.ReadLine()
                While Not line Is Nothing
                    Me.Board.LoadPiece(line)
                    If line.Split(",")(3) = "king" Then
                        If line.Split(",")(4) = "True" Then
                            Me.Players(0).MoveKing({CInt(line.Split(",")(0)), CInt(line.Split(",")(1))})
                        Else
                            Me.Players(1).MoveKing({CInt(line.Split(",")(0)), CInt(line.Split(",")(1))})
                        End If
                    End If
                    line = sReader.ReadLine()
                End While
            End Using
            Form1.RefreshBoard()
        End Sub
    End Class
    Public Class Board
        Private Squares(8, 8) As Chess.Square
        Private LastClickedX As Integer
        Private LastClickedY As Integer
        Private SquareSelected As Boolean
        Public Sub New()
            Me.SquareSelected = False
            Dim Start(8) As String
            Using sReader As New StreamReader("start.txt")
                Dim k As Integer = 0
                Dim line As String = sReader.ReadLine
                While Not line Is Nothing
                    Start(k) = line
                    line = sReader.ReadLine
                    k += 1
                End While
            End Using
            For i = 0 To 7
                For j = 0 To 7
                    Me.Squares(i, j) = New Square(i, j, Start(i)(j))
                Next
            Next
        End Sub
        Public Function Initialise() As String(,)
            Dim Symbols(8, 8) As String
            For i = 0 To 7
                For j = 0 To 7
                    Symbols(i, j) = Me.Squares(i, j).GetOccupier()
                Next
            Next
            Return Symbols
        End Function
        Public Sub LoadPiece(line As String)
            Dim Info As String() = line.Split(",")
            Me.Squares(CInt(Info(0)), CInt(Info(1))).ImportPiece(Info)
        End Sub
        Public Sub Click(x As Integer, y As Integer)
            If Me.SquareSelected = False And Me.Squares(x, y).GetOccupied() = True And Me.Squares(x, y).GetOwner() = AIChess.GetTurn() Then
                Me.SquareSelected = True
                Me.LastClickedX = x
                Me.LastClickedY = y
                If Me.Squares(x, y).GetPieceType() = "pawn" Then
                    Dim Target As Integer(,)
                    Target = Me.Squares(x, y).SelectSquare()
                    For i = 0 To Target.GetLength(0) - 1
                        If Me.Squares(Target(i, 0), Target(i, 1)).GetOccupied() = False And Me.IsBlocked(x, y, Target(i, 0), Target(i, 1)) = False Then
                            Form1.EmptyTarget({Target(i, 0), Target(i, 1)}, {x, y}, "pawn", Me.Squares(x, y).GetOwner())
                        End If
                    Next
                    Dim TakeTarget As Integer(,)
                    TakeTarget = AIChess.PawnTake(Me.Squares(x, y).GetOwner(), x, y)
                    For i = 0 To TakeTarget.GetLength(0) - 1
                        If Me.Squares(TakeTarget(i, 0), TakeTarget(i, 1)).GetOccupied() = True And Me.Squares(TakeTarget(i, 0), TakeTarget(i, 1)).GetOwner <> Me.Squares(x, y).GetOwner() Then
                            Form1.EnemyTarget({TakeTarget(i, 0), TakeTarget(i, 1)}, {x, y}, "pawn", Me.Squares(x, y).GetOwner())
                        End If
                    Next
                    If Me.Squares(x, y).GetOwner = True And x = 6 Then
                        If Me.Squares(7, y).GetOccupied = False Then
                            Form1.SpecialTarget({7, y}, {x, y}, "pawn", True)
                        End If
                        If y > 0 Then
                            If Me.Squares(7, y - 1).GetOccupied() = True And Me.Squares(7, y - 1).GetOwner() = False Then
                                Form1.SpecialTarget({7, y - 1}, {x, y}, "pawn", True)
                            End If
                        End If
                        If y < 7 Then
                            If Me.Squares(7, y + 1).GetOccupied() = True And Me.Squares(7, y + 1).GetOwner() = False Then
                                Form1.SpecialTarget({7, y + 1}, {x, y}, "pawn", True)
                            End If
                        End If
                    ElseIf Me.Squares(x, y).GetOwner = False And x = 1 Then
                        If Me.Squares(0, y).GetOccupied = False Then
                            Form1.SpecialTarget({0, y}, {x, y}, "pawn", False)
                        End If
                        If y > 0 Then
                            If Me.Squares(0, y - 1).GetOccupied() = True And Me.Squares(0, y - 1).GetOwner() = True Then
                                Form1.SpecialTarget({0, y - 1}, {x, y}, "pawn", False)
                            End If
                        End If
                        If y < 7 Then
                            If Me.Squares(0, y + 1).GetOccupied() = True And Me.Squares(0, y + 1).GetOwner() = True Then
                                Form1.SpecialTarget({0, y + 1}, {x, y}, "pawn", False)
                            End If
                        End If
                    End If
                Else
                    Dim Target As Integer(,)
                    Target = Me.Squares(x, y).SelectSquare()
                    For i = 0 To Target.GetLength(0) - 1
                        If Me.Squares(Target(i, 0), Target(i, 1)).GetOccupied() = True And Me.Squares(Target(i, 0), Target(i, 1)).GetOwner <> Me.Squares(x, y).GetOwner() And Me.IsBlocked(x, y, Target(i, 0), Target(i, 1)) = False Then
                            Form1.EnemyTarget({Target(i, 0), Target(i, 1)}, {x, y}, Me.Squares(x, y).GetPieceType(), Me.Squares(x, y).GetOwner())
                        ElseIf Me.Squares(Target(i, 0), Target(i, 1)).GetOccupied() = False And Me.IsBlocked(x, y, Target(i, 0), Target(i, 1)) = False Then
                            Form1.EmptyTarget({Target(i, 0), Target(i, 1)}, {x, y}, Me.Squares(x, y).GetPieceType(), Me.Squares(x, y).GetOwner())
                        End If
                        If Me.Squares(x, y).GetPieceType() = "king" And (Me.Squares(Target(i, 0), Target(i, 1)).GetOccupied() = False Or Me.Squares(Target(i, 0), Target(i, 1)).GetOwner() <> Me.Squares(x, y).GetOwner()) Then
                            Me.IsInCheck(Me.Squares(x, y).GetOwner(), {Target(i, 0), Target(i, 1)}, False)
                        End If
                    Next
                End If
                If Me.Squares(x, y).GetPieceType() = "king" And Me.Squares(x, y).GetHasMoved() = False Then
                    If Me.Squares(x, 5).GetOccupied() = False And Me.Squares(x, 6).GetOccupied() = False And Me.Squares(x, 7).GetOccupied() = True And Me.Squares(x, 7).GetPieceType = "rook" And Me.Squares(x, 7).GetOwner() = Me.Squares(x, y).GetOwner() And Me.Squares(x, 7).GetHasMoved() = False Then
                        Form1.SpecialTarget({x, 6}, {x, y}, "king", Me.Squares(x, y).GetOwner())
                    End If
                    If Me.Squares(x, 3).GetOccupied() = False And Me.Squares(x, 2).GetOccupied() = False And Me.Squares(x, 1).GetOccupied() = False And Me.Squares(x, 0).GetOccupied() = True And Me.Squares(x, 0).GetPieceType = "rook" And Me.Squares(x, 0).GetOwner() = Me.Squares(x, y).GetOwner() And Me.Squares(x, 0).GetHasMoved() = False Then
                        Form1.SpecialTarget({x, 2}, {x, y}, "king", Me.Squares(x, y).GetOwner())
                    End If
                End If
            ElseIf Me.SquareSelected = True Then
                If Form1.GetColour(x, y) = "+" Then
                    If Me.Squares(x, y).GetOccupied() = True Then
                        AIChess.PieceTaken(Me.Squares(x, y).GetOwner(), Me.Squares(x, y).GetPieceType())
                    End If
                    If Me.Squares(Me.LastClickedX, Me.LastClickedY).GetPieceType() = "king" Then
                        AIChess.KingMove(Me.Squares(Me.LastClickedX, Me.LastClickedY).GetOwner(), {x, y})
                    End If
                    Me.Squares(x, y).Occupy(Me.Squares(Me.LastClickedX, Me.LastClickedY).GetOccupier)
                    Me.Squares(Me.LastClickedX, Me.LastClickedY).Vacate()
                    Form1.RefreshBoard()
                    Me.SquareSelected = False
                    Dim MoveMatrix(2, 2) As Integer
                    MoveMatrix(0, 0) = Me.LastClickedX
                    MoveMatrix(0, 1) = Me.LastClickedY
                    MoveMatrix(1, 0) = x
                    MoveMatrix(1, 1) = y
                    AIChess.StoreMove(MoveMatrix)
                    Form1.MoveMade()
                ElseIf Form1.GetColour(x, y) = "=" Then
                    Form1.RefreshBoard()
                    Me.SquareSelected = False
                ElseIf Form1.GetColour(x, y) = "@" Then
                    If Me.Squares(Me.LastClickedX, Me.LastClickedY).GetPieceType() = "pawn" Then
                        If Me.Squares(Me.LastClickedX, Me.LastClickedY).GetOwner() = True Then
                            Me.Squares(x, y).Occupy("♕")
                        Else
                            Me.Squares(x, y).Occupy("♛")
                        End If
                    End If
                    If Me.Squares(Me.LastClickedX, Me.LastClickedY).GetPieceType() = "king" Then
                        If Me.Squares(Me.LastClickedX, Me.LastClickedY).GetOwner() = True Then
                            AIChess.KingMove(True, {x, y})
                            Me.Squares(x, y).Occupy("♔")
                            If y = 6 Then
                                Me.Squares(x, 5).Occupy("♖")
                                Me.Squares(x, 7).Vacate()
                            ElseIf y = 2 Then
                                Me.Squares(x, 3).Occupy("♖")
                                Me.Squares(x, 0).Vacate()
                            End If
                        Else
                            AIChess.KingMove(False, {x, y})
                            Me.Squares(x, y).Occupy("♚")
                            If y = 6 Then
                                Me.Squares(x, 5).Occupy("♜")
                                Me.Squares(x, 7).Vacate()
                            ElseIf y = 2 Then
                                Me.Squares(x, 3).Occupy("♜")
                                Me.Squares(x, 0).Vacate()
                            End If
                        End If
                    End If
                    Me.Squares(Me.LastClickedX, Me.LastClickedY).Vacate()
                    Form1.RefreshBoard()
                    Me.SquareSelected = False
                    Dim MoveMatrix(2, 2) As Integer
                    MoveMatrix(0, 0) = Me.LastClickedX
                    MoveMatrix(0, 1) = Me.LastClickedY
                    MoveMatrix(1, 0) = x
                    MoveMatrix(1, 1) = y
                    AIChess.StoreMove(MoveMatrix)
                    Form1.MoveMade()
                End If
            Else
                Form1.RefreshBoard()
                Me.SquareSelected = False
            End If
        End Sub
        Public Function GetSelectedStatus() As Boolean
            Return Me.SquareSelected
        End Function
        Public Function IsBlocked(SenderX As Integer, SenderY As Integer, TargetX As Integer, TargetY As Integer) As Boolean
            Dim Blocked As Boolean = False
            If SenderX - TargetX = 0 Then
                If SenderY - TargetY > 1 Then
                    For i = 0 To SenderY - TargetY - 2
                        If Me.Squares(TargetX, TargetY + i + 1).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                ElseIf TargetY - SenderY > 1 Then
                    For i = 0 To TargetY - SenderY - 2
                        If Me.Squares(SenderX, SenderY + i + 1).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                End If
            ElseIf SenderY - TargetY = 0 Then
                If SenderX - TargetX > 1 Then
                    For i = 0 To SenderX - TargetX - 2
                        If Me.Squares(TargetX + i + 1, TargetY).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                ElseIf TargetX - SenderX > 1 Then
                    For i = 0 To TargetX - SenderX - 2
                        If Me.Squares(SenderX + i + 1, SenderY).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                End If
            ElseIf SenderX - TargetX = SenderY - TargetY Then
                If SenderY - TargetY > 1 Then
                    For i = 0 To SenderY - TargetY - 2
                        If Me.Squares(TargetX + i + 1, TargetY + i + 1).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                ElseIf TargetY - SenderY > 1 Then
                    For i = 0 To TargetY - SenderY - 2
                        If Me.Squares(SenderX + i + 1, SenderY + i + 1).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                End If
            ElseIf SenderX - TargetX = TargetY - SenderY Then
                If SenderY - TargetY > 1 Then
                    For i = 0 To SenderY - TargetY - 2
                        If Me.Squares(SenderX + i + 1, SenderY - i - 1).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                ElseIf TargetY - SenderY > 1 Then
                    For i = 0 To TargetY - SenderY - 2
                        If Me.Squares(TargetX + i + 1, TargetY - i - 1).GetOccupied() = True Then
                            Blocked = True
                        End If
                    Next
                End If
            End If
            Return Blocked
        End Function
        Public Sub IsInCheck(Player As Boolean, KingPos As Integer(), King As Boolean)
            Dim InCheck As Boolean = False
            For i = 0 To 7
                For j = 0 To 7
                    If Me.Squares(i, j).GetOccupied = True And Me.Squares(i, j).GetOwner <> Player Then
                        If Me.Squares(i, j).GetPieceType() = "pawn" Then
                            Dim Target As Integer(,)
                            Target = AIChess.PawnTake(Me.Squares(i, j).GetOwner(), i, j)
                            For k = 0 To Target.GetLength(0) - 1
                                If Target(k, 0) = KingPos(0) And Target(k, 1) = KingPos(1) And Me.IsBlocked(i, j, KingPos(0), KingPos(1)) = False Then
                                    InCheck = True
                                End If
                            Next
                        Else
                            Dim Target As Integer(,)
                            Target = Me.Squares(i, j).SelectSquare()
                            For k = 0 To Target.GetLength(0) - 1
                                If Target(k, 0) = KingPos(0) And Target(k, 1) = KingPos(1) And Me.IsBlocked(i, j, KingPos(0), KingPos(1)) = False Then
                                    InCheck = True
                                End If
                            Next
                        End If
                    End If
                Next
            Next
            If InCheck = True And King = True Then
                If Player = True Then
                    Form1.Msg("Your king is in check.")
                Else
                    Form1.Msg("The AI's king is in check.")
                End If
            End If
            If InCheck = True And King = False Then
                Form1.CheckTarget(KingPos, AIChess.GetKing(Player))
            End If
        End Sub
        Public Function GetPieceDetails(Loc As Integer()) As Chess.PieceDetails
            Dim Details As New PieceDetails
            Details.Pos = Loc
            Details.Symbol = Me.Squares(Loc(0), Loc(1)).GetOccupier()
            Details.PieceType = Me.Squares(Loc(0), Loc(1)).GetPieceType()
            Details.Owner = Me.Squares(Loc(0), Loc(1)).GetOwner()
            Details.HasMoved = Me.Squares(Loc(0), Loc(1)).GetHasMoved()
            Details.Extant = Me.Squares(Loc(0), Loc(1)).GetOccupied()
            Return Details
        End Function
    End Class
    Public Class Square
        Private Occupied As Boolean
        Private Occupier As BoardPiece
        Private Row As Integer
        Private Column As Integer
        Public Sub New(i As Integer, j As Integer, InitialOccupier As String)
            Me.Occupied = False
            Me.Row = i
            Me.Column = j
            If Me.Row = 0 Or Me.Row = 1 Or Me.Row = 6 Or Me.Row = 7 Then
                Me.Occupied = True
            End If
            Occupier = New BoardPiece(InitialOccupier, Me.Occupied)
        End Sub
        Public Sub ImportPiece(Info As String())
            If Info(5) = "True" Then
                Me.Occupier.Import(Info(2), True, True)
            Else
                Me.Occupier.Import(Info(2), True, False)
            End If
        End Sub
        Public Function GetOccupier() As String
            Return Me.Occupier.GetSymbol()
        End Function
        Public Function SelectSquare() As Integer(,)
            Dim Owner As Boolean = Me.Occupier.GetOwner()
            Dim Type As String = Me.Occupier.GetPieceType()
            Dim HasMoved As Boolean = Me.Occupier.GetHasMoved()
            Dim Target As Integer(,) = AIChess.GetMoves(Type, Owner, HasMoved, Me.Row, Me.Column)
            Return Target
        End Function
        Public Sub Occupy(Symbol As String)
            Me.Occupied = True
            Me.Occupier.MoveTo(Symbol, True)
        End Sub
        Public Sub Vacate()
            Me.Occupied = False
            Me.Occupier.MoveTo(" ", False)
        End Sub
        Public Function GetOccupied() As Boolean
            Return Me.Occupied
        End Function
        Public Function GetOwner() As Boolean
            Return Me.Occupier.GetOwner()
        End Function
        Public Function GetPieceType() As String
            Return Me.Occupier.GetPieceType()
        End Function
        Public Function GetHasMoved() As Boolean
            Return Me.Occupier.GetHasMoved()
        End Function
    End Class
    Public Class BoardPiece
        Private Owner As Boolean
        Private Type As String
        Private Symbol As String
        Private HasMoved As Boolean
        Public Sub New(InitialSymbol As String, Exists As Boolean)
            Me.HasMoved = False
            Me.SetPiece(InitialSymbol, Exists)
        End Sub
        Public Sub Import(Symbol As String, Exists As Boolean, Moved As Boolean)
            Me.HasMoved = Moved
            Me.SetPiece(Symbol, Exists)
        End Sub
        Public Sub MoveTo(Symbol As String, Exists As Boolean)
            Me.HasMoved = True
            Me.SetPiece(Symbol, Exists)
        End Sub
        Public Sub SetPiece(Symbol As String, Exists As Boolean)
            Me.Symbol = Symbol
            If Me.Symbol = "♔" Then
                Me.Owner = True
                Me.Type = "king"
            ElseIf Me.Symbol = "♕" Then
                Me.Owner = True
                Me.Type = "queen"
            ElseIf Me.Symbol = "♖" Then
                Me.Owner = True
                Me.Type = "rook"
            ElseIf Me.Symbol = "♗" Then
                Me.Owner = True
                Me.Type = "bishop"
            ElseIf Me.Symbol = "♘" Then
                Me.Owner = True
                Me.Type = "knight"
            ElseIf Me.Symbol = "♙" Then
                Me.Owner = True
                Me.Type = "pawn"
            ElseIf Me.Symbol = "♚" Then
                Me.Owner = False
                Me.Type = "king"
            ElseIf Me.Symbol = "♛" Then
                Me.Owner = False
                Me.Type = "queen"
            ElseIf Me.Symbol = "♜" Then
                Me.Owner = False
                Me.Type = "rook"
            ElseIf Me.Symbol = "♝" Then
                Me.Owner = False
                Me.Type = "bishop"
            ElseIf Me.Symbol = "♞" Then
                Me.Owner = False
                Me.Type = "knight"
            ElseIf Me.Symbol = "♟︎" Then
                Me.Owner = False
                Me.Type = "pawn"
            ElseIf Exists = True Then
                Me.Owner = False
                Me.Type = "pawn"
            Else
                Me.Owner = False
                Me.Type = "empty"
            End If
        End Sub
        Public Function GetSymbol() As String
            Return Me.Symbol
        End Function
        Public Function GetOwner() As Boolean
            Return Me.Owner
        End Function
        Public Function GetPieceType() As String
            Return Me.Type
        End Function
        Public Function GetHasMoved() As Boolean
            Return Me.HasMoved
        End Function
    End Class
    Public Class Moves
        Private Dict As Dictionary(Of String, Integer(,))
        Public Sub New()
            Me.Dict = New Dictionary(Of String, Integer(,)) From {
                {"king+-", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king++", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king--", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king-+", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"knight+-", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight++", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight--", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight-+", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"pawn+-", {{1, 0}, {2, 0}}},
                {"pawn++", {{1, 0}}},
                {"pawn--", {{-1, 0}, {-2, 0}}},
                {"pawn-+", {{-1, 0}}},
                {"pawn+=", {{1, 1}, {1, -1}}},
                {"pawn-=", {{-1, 1}, {-1, -1}}}
            }
        End Sub
        Public Function GetSquare(Type As String, Owner As Boolean, HasMoved As Boolean, x As Integer, y As Integer) As Integer(,)
            If Type = "queen" Then
                Return Me.Queen(x, y)
            ElseIf Type = "rook" Then
                Return Me.Rook(x, y)
            ElseIf Type = "bishop" Then
                Return Me.Bishop(x, y)
            Else
                Dim key As String = Type
                If Owner = True Then
                    key += "+"
                Else
                    key += "-"
                End If
                If HasMoved = True Then
                    key += "+"
                Else
                    key += "-"
                End If
                Dim SqVect As Integer(,) = Me.Dict(key)
                Dim Target(SqVect.GetLength(0), 2) As Integer
                For i = 0 To SqVect.GetLength(0) - 1
                    If x + SqVect(i, 0) > -1 And x + SqVect(i, 0) < 8 And y + SqVect(i, 1) > -1 And y + SqVect(i, 1) < 8 Then
                        Target(i, 0) = x + SqVect(i, 0)
                        Target(i, 1) = y + SqVect(i, 1)
                    End If
                Next
                Return Target
            End If
        End Function
        Public Function PawnTake(Owner As Boolean, x As Integer, y As Integer) As Integer(,)
            Dim key As String = "pawn"
            If Owner = True Then
                key += "+"
            Else
                key += "-"
            End If
            key += "="
            Dim SqVect As Integer(,) = Me.Dict(key)
            Dim Target(SqVect.GetLength(0), 2) As Integer
            For i = 0 To SqVect.GetLength(0) - 1
                If x + SqVect(i, 0) > -1 And x + SqVect(i, 0) < 8 And y + SqVect(i, 1) > -1 And y + SqVect(i, 1) < 8 Then
                    Target(i, 0) = x + SqVect(i, 0)
                    Target(i, 1) = y + SqVect(i, 1)
                End If
            Next
            Return Target
        End Function
        Public Function Queen(x As Integer, y As Integer) As Integer(,)
            Dim Target(14 + Me.DiagonalMoves(x, y), 2) As Integer
            Dim j As Integer = 0
            For i = 0 To 7
                If i <> x Then
                    Target(j, 0) = i
                    Target(j, 1) = y
                    j += 1
                End If
            Next
            For i = 0 To 7
                If i <> y Then
                    Target(j, 0) = x
                    Target(j, 1) = i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x + i < 8 And y + i < 8 Then
                    Target(j, 0) = x + i
                    Target(j, 1) = y + i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x + i < 8 And y - i > -1 Then
                    Target(j, 0) = x + i
                    Target(j, 1) = y - i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x - i > -1 And y + i < 8 Then
                    Target(j, 0) = x - i
                    Target(j, 1) = y + i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x - i > -1 And y - i > -1 Then
                    Target(j, 0) = x - i
                    Target(j, 1) = y - i
                    j += 1
                End If
            Next
            Return Target
        End Function
        Public Function Rook(x As Integer, y As Integer) As Integer(,)
            Dim Target(14, 2) As Integer
            Dim j As Integer = 0
            For i = 0 To 7
                If i <> x Then
                    Target(j, 0) = i
                    Target(j, 1) = y
                    j += 1
                End If
            Next
            For i = 0 To 7
                If i <> y Then
                    Target(j, 0) = x
                    Target(j, 1) = i
                    j += 1
                End If
            Next
            Return Target
        End Function
        Public Function Bishop(x As Integer, y As Integer) As Integer(,)
            Dim Target(Me.DiagonalMoves(x, y), 2) As Integer
            Dim j As Integer = 0
            For i = 1 To 7
                If x + i < 8 And y + i < 8 Then
                    Target(j, 0) = x + i
                    Target(j, 1) = y + i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x + i < 8 And y - i > -1 Then
                    Target(j, 0) = x + i
                    Target(j, 1) = y - i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x - i > -1 And y + i < 8 Then
                    Target(j, 0) = x - i
                    Target(j, 1) = y + i
                    j += 1
                End If
            Next
            For i = 1 To 7
                If x - i > -1 And y - i > -1 Then
                    Target(j, 0) = x - i
                    Target(j, 1) = y - i
                    j += 1
                End If
            Next
            Return Target
        End Function
        Public Function DiagonalMoves(x As Integer, y As Integer) As Integer
            Dim DistX As Integer
            Dim DistY As Integer
            Dim Dist As Integer
            Dim NrDiagonalMoves As Integer
            If x > 3 Then
                DistX = 7 - x
            Else
                DistX = x
            End If
            If y > 3 Then
                DistY = 7 - y
            Else
                DistY = y
            End If
            If DistX > DistY Then
                Dist = DistY
            Else
                Dist = DistX
            End If
            NrDiagonalMoves = (2 * Dist) + 7
            Return NrDiagonalMoves
        End Function
    End Class
    Public Class Player
        Private IsHuman As Boolean
        Private KingPos(2) As Integer
        Private Score As Integer
        Public Sub New(PlayerID As Boolean, King As Integer())
            Me.IsHuman = PlayerID
            Me.KingPos = King
            Form1.MoveKing(Me.IsHuman, Me.KingPos)
            Me.Score = 0
        End Sub
        Public Sub MoveKing(NewPos As Integer())
            Me.KingPos = NewPos
            Form1.MoveKing(Me.IsHuman, Me.KingPos)
        End Sub
        Public Sub IsInCheck()
            AIChess.IsInCheck(Me.IsHuman, Me.KingPos)
        End Sub
        Public Function GetKingPos() As Integer()
            Return Me.KingPos
        End Function
        Public Sub AddScore(Points As Integer)
            Me.Score += Points
        End Sub
        Public Sub SetScore(Value As Integer)
            Me.Score = Value
        End Sub
        Public Function GetScore() As Integer
            Return Me.Score
        End Function
    End Class
    Public Class Pieces
        Private Dict As Dictionary(Of String, Integer)
        Public Sub New()
            Me.Dict = New Dictionary(Of String, Integer) From {
                {"king", 50},
                {"queen", 10},
                {"rook", 5},
                {"bishop", 3},
                {"knight", 3},
                {"pawn", 1}
                }
        End Sub
        Public Function GetValue(PieceType As String) As Integer
            Return Me.Dict(PieceType)
        End Function
    End Class
    Public Class PieceDetails
        Public Pos(2) As Integer
        Public Symbol As String
        Public PieceType As String
        Public Owner As Boolean
        Public HasMoved As Boolean
        Public Extant As Boolean
    End Class
    Public Class AI
        Private StoredMove(2, 2) As Integer
        Public Sub RecordMove(Move As Integer(,))
            Me.StoredMove = Move
        End Sub
        Public Sub Mirror()
            Dim MirroredMove(2, 2) As Integer
            MirroredMove(0, 0) = 7 - Me.StoredMove(0, 0)
            MirroredMove(0, 1) = Me.StoredMove(0, 1)
            MirroredMove(1, 0) = 7 - Me.StoredMove(1, 0)
            MirroredMove(1, 1) = Me.StoredMove(1, 1)
            Me.MakeMove(MirroredMove)
        End Sub
        Public Sub MakeMove(Move As Integer(,))
            AIChess.SqSelect(Move(0, 0), Move(0, 1))
            AIChess.SqSelect(Move(1, 0), Move(1, 1))
        End Sub
    End Class
    Public Class AccountManager
        Public Usernames As String()
        Public Sub New()
            Using sReader As New StreamReader("users.csv")
                Dim User(2) As String
                Dim line As String
                line = sReader.ReadLine()
                ReDim Usernames(line.Split(",").Length)
                Me.Usernames = line.Split(",")
            End Using
        End Sub
        Public Function Passwords(Username As String)
            Dim line As String
            Using sReader As New StreamReader("Users\" + Username + "\password.txt")
                line = sReader.ReadLine()
            End Using
            Return line
        End Function
        Public Function ListUsers() As String()
            Return Me.Usernames
        End Function
        Public Sub AddUser(Username As String, Password As String)
            Me.Usernames(Me.Usernames.Length - 1) = Username
            Dim line As String
            Using sReader As New StreamReader("users.csv")
                line = sReader.ReadLine()
            End Using
            Using sWriter As New StreamWriter("users.csv")
                sWriter.WriteLine(line + "," + Username)
            End Using
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "\Users\" + Username)
            Using sWriter As New StreamWriter("Users\" + Username + "\password.txt")
                sWriter.WriteLine(Password)
            End Using
        End Sub
    End Class
End Namespace
Module Module1
    Public AIChess As New Chess.Game
    Public U As New Chess.AccountManager
End Module