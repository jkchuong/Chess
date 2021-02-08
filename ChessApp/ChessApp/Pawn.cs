using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Pawn : Pieces
    {
        public Pawn(bool isWhite, Cell position) : base(isWhite, position)
        {
            if (isWhite)
            {
                Name = "WhitePawn";
                PossibleMoves = Rulebook.WhitePawnMoves;
            }
            else
            {
                Name = "BlackPawn";
                PossibleMoves = Rulebook.BlackPawnMoves;
            }
            Position = position;
            Position.ChangeStatus();
        }
    }
}
