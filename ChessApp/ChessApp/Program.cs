using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard();
            Console.WriteLine(chessboard.ToString());
        }
    }
}
