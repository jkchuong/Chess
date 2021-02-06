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
            Console.WriteLine(pawnMoves);
            Console.WriteLine(chessboard.Board[0,1].IsOccupied);
            Console.WriteLine(chessboard.Board[0,0].IsOccupied);

            Console.WriteLine("Chessboard information");
            chessboard.GetBoardInformation();
        }
    }
}
