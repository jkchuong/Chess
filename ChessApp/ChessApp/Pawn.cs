using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Pawn : IPieces
    {
        public bool IsWhite { get; set; }
        public bool IsFirstMove { get; set; } = true;
        public Cell Position { get; set; }

        private Move[] _possibleMoves = Rulebook.PawnMoves;
        private Move[] _legalMoves;

        public Pawn(bool isWhite, Cell postion)
        {
            IsWhite = isWhite;
            Position = postion;
        }

        // =================================
        // Getting Methods
        // =================================
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

        // =================================
        // Moving Methods
        // =================================
        public void Moving(int moveIndex)
        {
            Move move = _legalMoves[moveIndex];
            Position.X += move.MoveX;
            Position.Y += move.MoveY;
        }

        public void UpdateLegalMoves()
        {
            foreach (Move possibleMove in _possibleMoves)
            {
                
            }
        }
    }
}
