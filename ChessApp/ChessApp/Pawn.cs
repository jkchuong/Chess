using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Pawn : Pieces
    {
        private new List<Move> _possibleMoves = Rulebook.PawnMoves;

        public Pawn(bool isWhite, Cell position) : base(isWhite, position)
        {
            UpdateLegalMoves();
        }

        // =================================
        // Moving Methods
        // =================================
        public void Moving(int moveIndex)
        {
            // This changes status of same cell after it moves
            // How to move pieces within cells?
            Position.ChangeStatus();

            Move move = _possibleMoves[moveIndex];
            Position.X += move.MoveX;
            Position.Y += move.MoveY;

            Position.ChangeStatus();

            UpdateLegalMoves();
        }

        public void UpdateLegalMoves()
        {
            foreach (Move possibleMove in _possibleMoves)
            {
                
            }
        }
    }
}
