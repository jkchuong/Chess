using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class Pieces
    {
        // ==============================
        // Properties
        // ==============================

        public bool IsWhite { get; set; }
        public bool IsFirstMove { get; set; } = true;
        public Cell Position { get; set; }
        public string Name { get; set; }

        protected List<Move> _possibleMoves;
        protected List<Move> _legalMoves;

        // ==============================
        // Constructor
        // ==============================
        public Pieces(bool isWhite, Cell position)
        {
            IsWhite = isWhite;
            Position = position;
        }

        // ==============================
        // Methods
        // ==============================
        public string GetPosition()
        {
            return Position.ToString();
        }

        public string GetPossibleMoves()
        {
            string listOfPossibleMoves = "";
            foreach (Move move in _possibleMoves)
            {
                listOfPossibleMoves += move + ", ";
            }
            return listOfPossibleMoves;
        }

        public string GetLegalMoves()
        {
            string listOfLegalMoves = "";
            foreach (Move move in _legalMoves)
            {
                listOfLegalMoves += move + ", ";
            }
            return listOfLegalMoves;
        }
    }
}
