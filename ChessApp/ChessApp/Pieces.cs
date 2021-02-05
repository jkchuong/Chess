using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Pieces
    {
        // ==============================
        // Properties
        // ==============================

        public bool IsWhite { get; set; }
        public bool IsFirstMove { get; set; } = true;
        public Cell Position { get; set; }
        public string Name { get; set; }

        public virtual List<Move> PossibleMoves { get; }
        public virtual List<Move> LegalMoves { get; set; }

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
        public virtual string GetPosition()
        {
            return Position.ToString();
        }

        public virtual string GetPossibleMoves()
        {
            string listOfPossibleMoves = "";
            foreach (Move move in PossibleMoves)
            {
                listOfPossibleMoves += move + ", ";
            }
            return listOfPossibleMoves;
        }

        public virtual string GetLegalMoves()
        {
            string listOfLegalMoves = "";
            foreach (Move move in LegalMoves)
            {
                listOfLegalMoves += move + ", ";
            }
            return listOfLegalMoves;
        }
    }
}
