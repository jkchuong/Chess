using System;

namespace ChessApp
{
    class Program
    {
        Chessboard chessboard = new Chessboard();

        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard();
            Pawn whitePawn = new Pawn(true, chessboard.Board[4, 3]);
            Pawn blackPawn = new Pawn(false, chessboard.Board[6, 0]);
            Knight blackKnight = new Knight(false, chessboard.Board[2, 2]);
            King whiteKing = new King(false, chessboard.Board[7, 3]);
            Rook whiteRook = new Rook(true, chessboard.Board[3, 6]);
            Bishop blackBishop = new Bishop(false, chessboard.Board[2, 4]);
            Queen whiteQueen = new Queen(true, chessboard.Board[1, 5]);


            Console.WriteLine("The Pieces");
            chessboard.ClearMarkedLegalMoves();
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("White Pawn");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(whitePawn);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("Black Pawn");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(blackPawn);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("Black Rook");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(blackKnight);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("White King");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(whiteKing);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("White Rook");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(whiteRook);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("Black Bishop");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(blackBishop);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("White Queen");
            chessboard.ClearMarkedLegalMoves();
            chessboard.FindLegalMoves(whiteQueen);
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("Clear Board");
            chessboard.ClearBoard();
            PrintBoardOccupiedAndLegal(chessboard);

            Console.WriteLine("=====================================================");

            Console.WriteLine("New Game");
            chessboard.NewGame();
            PrintBoardOccupiedAndLegal(chessboard);
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
                                case "WhitePawn":
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
                                    Console.Write("B    ");
                                    break;
                            }
                        }
                        else if (!chessboard.Board[i, j].piece.IsWhite)
                        {

                            switch (chessboard.Board[i, j].piece.Name)
                            {
                                case "BlackPawn":
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
                                    Console.Write("b    ");
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
