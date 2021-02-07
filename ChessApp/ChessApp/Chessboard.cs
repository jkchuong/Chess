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

        public void ClearMarkedLegalMoves()
        {
            foreach (Cell cell in Board)
            {
                cell.IsLegal = false;
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
                        Board[piece.Position.Row + move.MoveRow, piece.Position.Column + move.MoveColumn].IsLegal = true;
                    }
                    break;

                case "Knight":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        Board[piece.Position.Row + move.MoveRow, piece.Position.Column + move.MoveColumn].IsLegal = true;
                    }
                    break;

                case "King":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        Board[piece.Position.Row + move.MoveRow, piece.Position.Column + move.MoveColumn].IsLegal = true;
                    }
                    break;

                case "Rook":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        Board[piece.Position.Row + move.MoveRow, piece.Position.Column + move.MoveColumn].IsLegal = true;
                    }
                    break;

                case "Bishop":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        Board[piece.Position.Row + move.MoveRow, piece.Position.Column + move.MoveColumn].IsLegal = true;
                    }
                    break;

                case "Queen":
                    foreach (Move move in piece.PossibleMoves)
                    {
                        Board[piece.Position.Row + move.MoveRow, piece.Position.Column + move.MoveColumn].IsLegal = true;
                    }
                    break;

            }
        }
    }
}
