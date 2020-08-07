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
        Public Function Click(X As Integer, Y As Integer) As List(Of Integer())
            If Me.SquareSelected = False Then
                Me.SquareSelected = True
                Me.LastClickedX = X
                Me.LastClickedY = Y
                Dim Target As New List(Of Integer())
                Target = Me.Squares(X, Y).SelectSquare()
                Return Target
            Else
                Me.SquareSelected = False
                Dim NullTarget As New List(Of Integer())
                Dim NullArr(2) As Integer
                NullArr(0) = 8
                NullArr(1) = 8
                NullTarget.Add(NullArr)
                Return NullTarget
            End If
        End Function
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
                Dim Instructions As String = ""
                Using sReader As New StreamReader("moves.csv")
                    Dim line As String = sReader.ReadLine()
                    While Not line Is Nothing
                        If line.Split(",")(0) = Type Then
                            Instructions = line
                        End If
                        line = sReader.ReadLine()
                    End While
                End Using
                Dim Instructions1 As String() = Instructions.Split(",")
                Dim Instructions2(Instructions1.Length - 1)() As String
                Dim InstConv(2) As String
                For i = 1 To Instructions1.Length - 1
                    InstConv = Instructions1(i).Split("/")
                    Instructions2(i - 1)(0) = InstConv(0)
                    Instructions2(i - 1)(1) = InstConv(1)
                Next
                Dim PosArr(2) As Integer
                If Instructions2(0)(0) = "x" Then
                    Dim ArrX As String
                    Dim ArrY As String
                    For i = 0 To Instructions2.Length - 1
                        For k = 0 To 7
                            ArrX = ""
                            ArrY = ""
                            For j = 0 To Instructions2(i)(0).Length - 1
                                If Instructions2(i)(0)(j) = "x" Then
                                    ArrX += k.ToString
                                Else
                                    ArrX += Instructions2(i)(0)(j)
                                End If
                            Next
                            For j = 0 To Instructions2(i)(1).Length - 1
                                If Instructions2(i)(1)(j) = "x" Then
                                    ArrY += k.ToString
                                Else
                                    ArrY += Instructions2(i)(1)(j)
                                End If
                            Next
                            If Owner = True Then
                                PosArr(0) = Me.Row + CInt(ArrX)
                                PosArr(1) = Me.Column + CInt(ArrY)
                            Else
                                PosArr(0) = Me.Row - CInt(ArrX)
                                PosArr(1) = Me.Column - CInt(ArrY)
                            End If
                            Target.Add(PosArr)
                        Next
                    Next
                Else
                    For i = 0 To Instructions2.Length - 1
                        If Owner = True Then
                            PosArr(0) = Me.Row + CInt(Instructions2(i)(0))
                            PosArr(1) = Me.Column + CInt(Instructions2(i)(1))
                        Else
                            PosArr(0) = Me.Row - CInt(Instructions2(i)(0))
                            PosArr(1) = Me.Column - CInt(Instructions2(i)(1))
                        End If
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
End Namespace
Module Module1
    Public board As New Board
End Module
