using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Chessboard
    {
        //private readonly Dictionary<int, char> chessAN = new Dictionary<int, char>()
        //{
        //    {1 , 'a'},
        //    {2 , 'b'},
        //    {3 , 'c'},
        //    {4 , 'd'},
        //    {5 , 'e'},
        //    {6 , 'f'},
        //    {7 , 'g'},
        //    {8 , 'h'}
        //};

        public Cell[,] Board { get; }

        public Chessboard()
        {
            Board = new Cell[8, 8];
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Board[x, y] = new Cell(x, y);
                }
            }
        }

        public bool IsOnBoard(int row, int column)
        {
            if (row >= 8 || column >= 8 || row < 0 || column < 0)
            {
                return false;
            }
            return true;
        }

        public bool IsDifferentColour(bool isWhite, bool otherPieceWhite)
        {
            if((isWhite && otherPieceWhite) || (!isWhite && !otherPieceWhite))
            {
                return false;
            }
            return true;
        }

        public void ClearMarkedLegalMoves()
        {
            foreach (Cell cell in Board)
            {
                cell.IsLegal = false;
            }
        }

        // How to delete all pieces?
        public void ClearBoard()
        {
            foreach (Cell cell in Board)
            {
                cell.IsLegal = false;
                cell.IsOccupied = false;
                cell.piece = null;
            }
        }

        // Can make this shorter? (DRY)
        // Include limits - don't let it move on another place of piece with same colour
        // don't let it move out of bounds
        // create method to check each of these and reuse?
        public void FindLegalMoves(Pieces piece)
        {
            switch (piece.Name)
            {
                case "Pawn":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        int desitinationRow = piece.Position.Row + move.MoveRow;
                        int desitnationColumn = piece.Position.Column + move.MoveColumn;

                        if (IsOnBoard(desitinationRow, desitnationColumn))
                        {
                            if (Board[desitinationRow, desitnationColumn].piece == null)
                            {
                                Board[desitinationRow, desitnationColumn].IsLegal = true;
                            }
                            else
                            {
                                if (IsDifferentColour(piece.IsWhite, Board[desitinationRow, desitnationColumn].piece.IsWhite))
                                {
                                    Board[desitinationRow, desitnationColumn].IsLegal = true;
                                }
                            }
                        }
                    }
                    break;

                case "Knight":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        int desitinationRow = piece.Position.Row + move.MoveRow;
                        int desitnationColumn = piece.Position.Column + move.MoveColumn;

                        if (IsOnBoard(desitinationRow, desitnationColumn))
                        {
                            if (Board[desitinationRow, desitnationColumn].piece == null)
                            {
                                Board[desitinationRow, desitnationColumn].IsLegal = true;
                            }
                            else
                            {
                                if (IsDifferentColour(piece.IsWhite, Board[desitinationRow, desitnationColumn].piece.IsWhite))
                                {
                                    Board[desitinationRow, desitnationColumn].IsLegal = true;
                                }
                            }
                        }
                    }
                    break;

                case "King":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        int desitinationRow = piece.Position.Row + move.MoveRow;
                        int desitnationColumn = piece.Position.Column + move.MoveColumn;
                        if (IsOnBoard(desitinationRow, desitnationColumn))
                        {
                            if (Board[desitinationRow, desitnationColumn].piece == null)
                            {
                                Board[desitinationRow, desitnationColumn].IsLegal = true;
                            }
                            else
                            {
                                if (IsDifferentColour(piece.IsWhite, Board[desitinationRow, desitnationColumn].piece.IsWhite))
                                {
                                    Board[desitinationRow, desitnationColumn].IsLegal = true;
                                }
                            }
                        }
                    }
                    break;

                case "Rook":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        int desitinationRow = piece.Position.Row + move.MoveRow;
                        int desitnationColumn = piece.Position.Column + move.MoveColumn;
                        if (IsOnBoard(desitinationRow, desitnationColumn))
                        {
                            if (Board[desitinationRow, desitnationColumn].piece != null)
                            {
                                if (IsDifferentColour(piece.IsWhite, Board[desitinationRow, desitnationColumn].piece.IsWhite))
                                {
                                    Board[desitinationRow, desitnationColumn].IsLegal = true;
                                }

                                Board[desitinationRow, desitnationColumn].IsLegal = true;
                            }
                        }
                    }
                    break;

                case "Bishop":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        int desitinationRow = piece.Position.Row + move.MoveRow;
                        int desitnationColumn = piece.Position.Column + move.MoveColumn;
                        if (IsOnBoard(desitinationRow, desitnationColumn))
                        {
                            if (Board[desitinationRow, desitnationColumn].piece != null)
                            {
                                if (IsDifferentColour(piece.IsWhite, Board[desitinationRow, desitnationColumn].piece.IsWhite))
                                {
                                    Board[desitinationRow, desitnationColumn].IsLegal = true;
                                }

                                Board[desitinationRow, desitnationColumn].IsLegal = true;
                            }
                        }
                    }
                    break;

                case "Queen":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        int desitinationRow = piece.Position.Row + move.MoveRow;
                        int desitnationColumn = piece.Position.Column + move.MoveColumn;
                        if (IsOnBoard(desitinationRow, desitnationColumn))
                        {
                            if (Board[desitinationRow, desitnationColumn].piece != null)
                            {
                                if (IsDifferentColour(piece.IsWhite, Board[desitinationRow, desitnationColumn].piece.IsWhite))
                                {
                                    Board[desitinationRow, desitnationColumn].IsLegal = true;
                                }

                                Board[desitinationRow, desitnationColumn].IsLegal = true;
                            }
                        }
                    }
                    break;

            }
        }
    }
}
