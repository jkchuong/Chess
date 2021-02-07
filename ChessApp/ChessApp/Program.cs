using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard();

            Pawn pawn = new Pawn(true, chessboard.Board[0, 1]);

            string pawnMoves = pawn.GetPossibleMoves();
            string pawnPosition = pawn.Position.ToString();
            Console.WriteLine($"Possible Moves: {pawnMoves}");
            Console.WriteLine($"Position: {pawnPosition}");

        }
    }
}
