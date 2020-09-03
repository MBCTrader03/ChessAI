Imports System.IO
Imports ChessAI.Chess

Namespace Chess
    Public Class Board
        Private Squares(8, 8) As Square
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
        Public Sub Click(X As Integer, Y As Integer)
            If Me.SquareSelected = False Then
                Me.SquareSelected = True
                Me.LastClickedX = X
                Me.LastClickedY = Y
                Dim Target As New List(Of Integer())
                Target = Me.Squares(X, Y).SelectSquare()
                Form1.Target(Target)
            Else
                Me.SquareSelected = False
            End If
        End Sub
        Public Function GetSelectedStatus() As Boolean
            Return Me.SquareSelected
        End Function
    End Class
    Public Class Square
        Private Occupied As Boolean
        Private Occupier As Piece
        Private Row As Integer
        Private Column As Integer
        Public Sub New(i As Integer, j As Integer, InitialOccupier As String)
            Me.Row = i
            Me.Column = j
            If Me.Row = 0 Or Me.Row = 1 Or Me.Row = 6 Or Me.Row = 7 Then
                Me.Occupied = True
            End If
            Occupier = New Piece(InitialOccupier)
        End Sub
        Public Function GetOccupier() As String
            Return Me.Occupier.GetSymbol()
        End Function
        Public Function SelectSquare() As List(Of Integer())
            If Occupied = True Then
                Dim Owner As Boolean = Me.Occupier.GetOwner()
                Dim Type As String = Me.Occupier.GetPieceType()
                Dim HasMoved As Boolean = Me.Occupier.GetHasMoved()
                Dim Target As New List(Of Integer())
                Dim PosArr(2) As Integer
                If Type = "king" Then
                    For i = 0 To 7
                        PosArr(0) = Me.Row + Module1.moves.King(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.King(i, 1)
                        Target.Add(PosArr)
                    Next
                ElseIf Type = "queen" Then
                    For i = 0 To 55
                        PosArr(0) = Me.Row + Module1.moves.Queen(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.Queen(i, 1)
                        Target.Add(PosArr)
                    Next
                ElseIf Type = "rook" Then
                    For i = 0 To 27
                        PosArr(0) = Me.Row + Module1.moves.Rook(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.Rook(i, 1)
                        Target.Add(PosArr)
                    Next
                ElseIf Type = "bishop" Then
                    For i = 0 To 27
                        PosArr(0) = Me.Row + Module1.moves.Bishop(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.Bishop(i, 1)
                        Target.Add(PosArr)
                    Next
                ElseIf Type = "knight" Then
                    For i = 0 To 7
                        PosArr(0) = Me.Row + Module1.moves.Knight(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.Knight(i, 1)
                        Target.Add(PosArr)
                    Next
                ElseIf Type = "pawn" And Owner = True And HasMoved = True Then
                    PosArr(0) = Me.Row + Module1.moves.WhitePawn(0)
                    PosArr(1) = Me.Column + Module1.moves.WhitePawn(1)
                    Target.Add(PosArr)
                ElseIf Type = "pawn" And Owner = False And HasMoved = True Then
                    PosArr(0) = Me.Row + Module1.moves.BlackPawn(0)
                    PosArr(1) = Me.Column + Module1.moves.BlackPawn(1)
                    Target.Add(PosArr)
                ElseIf Type = "pawn" And Owner = True And HasMoved = False Then
                    For i = 0 To 1
                        PosArr(0) = Me.Row + Module1.moves.UnmovedWhitePawn(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.UnmovedWhitePawn(i, 1)
                        Target.Add(PosArr)
                    Next
                ElseIf Type = "pawn" And Owner = True And HasMoved = False Then

                    For i = 0 To 1
                        PosArr(0) = Me.Row + Module1.moves.UnmovedBlackPawn(i, 0)
                        PosArr(1) = Me.Column + Module1.moves.UnmovedBlackPawn(i, 1)
                        Target.Add(PosArr)
                    Next
                End If
                Return Target
            Else
                Dim NullTarget As New List(Of Integer())
                Dim NullArr(2) As Integer
                NullArr(0) = 8
                NullArr(1) = 8
                NullTarget.Add(NullArr)
                Return NullTarget
            End If
        End Function
    End Class
    Public Class Piece
        Private Owner As Boolean
        Private Type As String
        Private Symbol As String
        Private HasMoved As Boolean
        Public Sub New(InitialSymbol As String)
            Me.HasMoved = False
            Me.Symbol = InitialSymbol
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
        Public King(8, 2) As Integer
        Public Queen(56, 2) As Integer
        Public Rook(28, 2) As Integer
        Public Bishop(28, 2) As Integer
        Public Knight(8, 2) As Integer
        Public WhitePawn(2) As Integer
        Public BlackPawn(2) As Integer
        Public UnmovedWhitePawn(2, 2) As Integer
        Public UnmovedBlackPawn(2, 2) As Integer
        Public WhitePawnTake(2, 2) As Integer
        Public BlackPawnTake(2, 2) As Integer
        Public Sub New()
            Me.KingMoves()
            Me.QueenMoves()
            Me.RookMoves()
            Me.BishopMoves()
            Me.KnightMoves()
            Me.PawnMoves()
        End Sub
        Public Sub KingMoves()
            Me.King(0, 0) = 1
            Me.King(0, 1) = 0
            Me.King(1, 0) = 1
            Me.King(1, 1) = 1
            Me.King(2, 0) = 0
            Me.King(2, 1) = 1
            Me.King(3, 0) = -1
            Me.King(3, 1) = 1
            Me.King(4, 0) = -1
            Me.King(4, 1) = 0
            Me.King(5, 0) = -1
            Me.King(5, 1) = -1
            Me.King(6, 0) = 0
            Me.King(6, 1) = -1
            Me.King(7, 0) = 1
            Me.King(7, 1) = -1
        End Sub
        Public Sub QueenMoves()
            For i = 0 To 7
                For j = 0 To 6
                    For k = 0 To 1
                        Me.Queen((7 * i) + j, k) = Me.King(i, k) * (j + 1)
                    Next
                Next
            Next
        End Sub
        Public Sub RookMoves()
            For i = 0 To 6
                Me.Rook(i, 0) = i + 1
                Me.Rook(i, 1) = 0
            Next
            For i = 0 To 6
                Me.Rook(i + 7, 0) = 0
                Me.Rook(i + 7, 1) = i + 1
            Next
            For i = 0 To 6
                Me.Rook(i + 14, 0) = -1 - i
                Me.Rook(i + 14, 1) = 0
            Next
            For i = 0 To 6
                Me.Rook(i + 21, 0) = 0
                Me.Rook(i + 21, 1) = -1 - i
            Next
        End Sub
        Public Sub BishopMoves()
            For i = 0 To 6
                Me.Bishop(i, 0) = i + 1
                Me.Bishop(i, 1) = i + 1
            Next
            For i = 0 To 6
                Me.Bishop(i + 7, 0) = -1 - i
                Me.Bishop(i + 7, 1) = i + 1
            Next
            For i = 0 To 6
                Me.Bishop(i + 14, 0) = -1 - i
                Me.Bishop(i + 14, 1) = -1 - i
            Next
            For i = 0 To 6
                Me.Bishop(i + 21, 0) = i + 1
                Me.Bishop(i + 21, 1) = -1 - i
            Next
        End Sub
        Public Sub KnightMoves()
            Me.Knight(0, 0) = 2
            Me.Knight(0, 1) = 1
            Me.Knight(1, 0) = 1
            Me.Knight(1, 1) = 2
            Me.Knight(2, 0) = -1
            Me.Knight(2, 1) = 2
            Me.Knight(3, 0) = -2
            Me.Knight(3, 1) = 1
            Me.Knight(4, 0) = -2
            Me.Knight(4, 1) = -1
            Me.Knight(5, 0) = -1
            Me.Knight(5, 1) = -2
            Me.Knight(6, 0) = 1
            Me.Knight(6, 1) = -2
            Me.Knight(7, 0) = 2
            Me.Knight(7, 1) = -1
        End Sub
        Public Sub PawnMoves()
            Me.WhitePawn(0) = 1
            Me.WhitePawn(1) = 0
            Me.BlackPawn(0) = -1
            Me.BlackPawn(1) = 0
            Me.UnmovedWhitePawn(0, 0) = 1
            Me.UnmovedWhitePawn(0, 1) = 0
            Me.UnmovedWhitePawn(1, 0) = 2
            Me.UnmovedWhitePawn(1, 1) = 0
            Me.UnmovedBlackPawn(0, 0) = -1
            Me.UnmovedBlackPawn(0, 1) = 0
            Me.UnmovedBlackPawn(1, 0) = -2
            Me.UnmovedBlackPawn(1, 1) = 0
            Me.WhitePawnTake(0, 0) = 1
            Me.WhitePawnTake(0, 1) = 1
            Me.WhitePawnTake(1, 0) = 1
            Me.WhitePawnTake(1, 1) = -1
            Me.BlackPawnTake(0, 0) = -1
            Me.BlackPawnTake(0, 1) = -1
            Me.BlackPawnTake(1, 0) = -1
            Me.BlackPawnTake(1, 1) = 1
        End Sub
    End Class
End Namespace
Module Module1
    Public moves As New Chess.Moves
    Public board As New Chess.Board
End Module
