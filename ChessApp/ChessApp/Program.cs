using System;

namespace ChessApp
{
    class Program
    {
        Chessboard chessboard = new Chessboard();

        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard();
            Pawn whitePawn1 = new Pawn(true, chessboard.Board[1, 0]);
            Rook blackKnight = new Knight(false, chessboard.Board[2, 2]);
            King whiteKing = new King(false, chessboard.Board[0, 3]);


            // Not setting empty cells as legal
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(blackKnight);
            PrintBoardOccupiedAndLegal(chessboard);
            
            Console.WriteLine("=====================================================");

            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(whitePawn1);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(whiteKing);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");
            
        }

        private static void PrintBoardOccupiedAndLegal(Chessboard chessboard)
        {
            int rowLength = chessboard.Board.GetLength(0);
            int colLength = chessboard.Board.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (chessboard.Board[i, j].IsOccupied)
                    {
                        if (chessboard.Board[i, j].IsLegal)
                        {
                            Console.Write("X    ");
                        }
                        else if (chessboard.Board[i, j].piece.IsWhite)
                        {

                            switch (chessboard.Board[i, j].piece.Name)
                            {
                                case "Pawn":
                                    Console.Write("P    ");
                                    break;

                                case "Knight":
                                    Console.Write("N    ");
                                    break;

                                case "King":
                                    Console.Write("K    ");
                                    break;

                                case "Queen":
                                    Console.Write("Q    ");
                                    break;

                                case "Rook":
                                    Console.Write("R    ");
                                    break;

                                case "Bishop":
                                    Console.Write("K    ");
                                    break;
                            }
                        }
                        else if (!chessboard.Board[i, j].piece.IsWhite)
                        {

                            switch (chessboard.Board[i, j].piece.Name)
                            {
                                case "Pawn":
                                    Console.Write("p    ");
                                    break;

                                case "Knight":
                                    Console.Write("n    ");
                                    break;

                                case "King":
                                    Console.Write("k    ");
                                    break;

                                case "Queen":
                                    Console.Write("q    ");
                                    break;

                                case "Rook":
                                    Console.Write("r    ");
                                    break;

                                case "Bishop":
                                    Console.Write("k    ");
                                    break;
                            }
                        }

                    }
                    else if (chessboard.Board[i, j].IsLegal)
                    {
                        Console.Write("X    ");
                    }
                    else
                    {
                        Console.Write("-    ");
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

    }
}
