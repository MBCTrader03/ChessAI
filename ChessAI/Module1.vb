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
        Public Sub Click(x As Integer, y As Integer)
            If Me.SquareSelected = False And Me.Squares(x, y).GetOccupied() = True Then
                Me.SquareSelected = True
                Me.LastClickedX = x
                Me.LastClickedY = y
                Dim Target As Integer(,)
                Target = Me.Squares(x, y).SelectSquare()
                For i = 0 To Target.GetLength(0) - 1
                    Form1.Target({Target(i, 0), Target(i, 1)}, {x, y}, Me.Squares(x, y).GetPieceType(), Me.Squares(x, y).GetOwner())
                Next
            Else
                Form1.GenerateBoard()
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
            Me.Occupied = False
            Me.Row = i
            Me.Column = j
            If Me.Row = 0 Or Me.Row = 1 Or Me.Row = 6 Or Me.Row = 7 Then
                Me.Occupied = True
            End If
            Occupier = New Piece(InitialOccupier, Me.Occupied)
        End Sub
        Public Function GetOccupier() As String
            Return Me.Occupier.GetSymbol()
        End Function
        Public Function SelectSquare() As Integer(,)
            If Occupied = True Then
                Dim Owner As Boolean = Me.Occupier.GetOwner()
                Dim Type As String = Me.Occupier.GetPieceType()
                Dim HasMoved As Boolean = Me.Occupier.GetHasMoved()
                Dim Target As Integer(,) = movesa.GetSquare(Type, Owner, HasMoved, Me.Row, Me.Column)
                Return Target
            Else
                Dim NullTarget As Integer(,) = {{9, 9}}
                Return NullTarget
            End If
        End Function
        Public Function GetOccupied() As Boolean
            Return Me.Occupied
        End Function
        Public Function GetOwner() As Boolean
            Return Me.Occupier.GetOwner()
        End Function
        Public Function GetPieceType() As String
            Return Me.Occupier.GetPieceType()
        End Function
    End Class
    Public Class Piece
        Private Owner As Boolean
        Private Type As String
        Private Symbol As String
        Private HasMoved As Boolean
        Public Sub New(InitialSymbol As String, Exists As Boolean)
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
            Dict = New Dictionary(Of String, Integer(,)) From {
                {"king+-", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king++", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king--", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king-+", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"queen+-", {{9, 0}, {9, 9}, {0, 9}, {-9, 9}, {-9, 0}, {-9, -9}, {0, -9}, {9, -9}}},
                {"queen++", {{9, 0}, {9, 9}, {0, 9}, {-9, 9}, {-9, 0}, {-9, -9}, {0, -9}, {9, -9}}},
                {"queen--", {{9, 0}, {9, 9}, {0, 9}, {-9, 9}, {-9, 0}, {-9, -9}, {0, -9}, {9, -9}}},
                {"queen-+", {{9, 0}, {9, 9}, {0, 9}, {-9, 9}, {-9, 0}, {-9, -9}, {0, -9}, {9, -9}}},
                {"rook+-", {{9, 0}, {0, 9}, {-9, 0}, {0, -9}}},
                {"rook++", {{9, 0}, {0, 9}, {-9, 0}, {0, -9}}},
                {"rook--", {{9, 0}, {0, 9}, {-9, 0}, {0, -9}}},
                {"rook-+", {{9, 0}, {0, 9}, {-9, 0}, {0, -9}}},
                {"bishop+-", {{9, 9}, {-9, 9}, {-9, -9}, {9, -9}}},
                {"bishop++", {{9, 9}, {-9, 9}, {-9, -9}, {9, -9}}},
                {"bishop--", {{9, 9}, {-9, 9}, {-9, -9}, {9, -9}}},
                {"bishop-+", {{9, 9}, {-9, 9}, {-9, -9}, {9, -9}}},
                {"knight+-", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight++", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight--", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight-+", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"pawn+-", {{1, 0}, {2, 0}}},
                {"pawn++", {{1, 0}}},
                {"pawn--", {{-1, 0}, {-2, 0}}},
                {"pawn-+", {{-1, 0}}},
                {"king+=", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"king-=", {{1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}, {0, -1}, {1, -1}}},
                {"queen+=", {{9, 0}, {9, 9}, {0, 9}, {-9, 9}, {-9, 0}, {-9, -9}, {0, -9}, {9, -9}}},
                {"queen-=", {{9, 0}, {9, 9}, {0, 9}, {-9, 9}, {-9, 0}, {-9, -9}, {0, -9}, {9, -9}}},
                {"rook+=", {{9, 0}, {0, 9}, {-9, 0}, {0, -9}}},
                {"rook-=", {{9, 0}, {0, 9}, {-9, 0}, {0, -9}}},
                {"bishop+=", {{9, 9}, {-9, 9}, {-9, -9}, {9, -9}}},
                {"bishop-=", {{9, 9}, {-9, 9}, {-9, -9}, {9, -9}}},
                {"knight+=", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
                {"knight-=", {{2, 1}, {1, 2}, {-1, 2}, {-2, 1}, {-2, -1}, {-1, -2}, {1, -2}, {2, -1}}},
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
                Dim key As String
                key = Type
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
                    Target(i, 0) = x + SqVect(i, 0)
                    Target(i, 1) = y + SqVect(i, 1)
                Next
                Return Target
            End If
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
End Namespace
Module Module1
    Public movesa As New Chess.Moves
    Public board As New Chess.Board
End Module
