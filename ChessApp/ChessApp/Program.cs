using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard();
            Console.WriteLine(chessboard.Board);
            Pawn pawn = new Pawn(true, chessboard.Board[0, 1]);
            string pawnMoves = pawn.GetPossibleMoves();
            Console.WriteLine(pawnMoves);
        }
    }
}
