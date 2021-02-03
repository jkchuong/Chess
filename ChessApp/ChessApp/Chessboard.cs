using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Chessboard
    {
        private readonly Dictionary<int, char> chessAN = new Dictionary<int, char>()
        {
            {1 , 'a'},
            {2 , 'b'},
            {3 , 'c'},
            {4 , 'd'},
            {5 , 'e'},
            {6 , 'f'},
            {7 , 'g'},
            {8 , 'h'}
        };

        public List<Cell> board = new List<Cell>();

        public Chessboard()
        {
            for (int xPosition = 1; xPosition <= 8; xPosition++)
            {
                for (int yPosition = 1; yPosition <= 8; yPosition++)
                {
                    Cell cell = new Cell(xPosition, yPosition);
                    board.Add(cell);
                }
            }
        }

        public override string ToString()
        {
            string boardCells = "";
            foreach (Cell cell in board)
            {
                boardCells += cell.ToString() + ", ";
            }
            return boardCells;
        }
    }
}
