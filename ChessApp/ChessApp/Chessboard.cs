﻿using System;
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
            for (int x = 1; x <= 8; x++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    Board[x-1, y-1] = new Cell(x, y);
                }
            }
        }

        public void ClearMarkedLegalMoves()
        {
            foreach (Cell cell in Board)
            {
                cell.IsLegalMove = false;
            }
        }

        public void FindLegalMoves(Pieces piece)
        {
            switch (piece.Name)
            {
                case "Pawn":


                    break;

                case "Knight":
                    

                    break;

                case "King":
                    break;

                case "Rook":
                    break;

                case "Bishop":
                    break;

                case "Queen":
                    break;

            }
        }
    }
}
