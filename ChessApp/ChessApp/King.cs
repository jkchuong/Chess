using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class King : Pieces
    {
        public King(bool isWhite, Cell position) : base(isWhite, position)
        {
            Name = "King";
            PossibleMoves = Rulebook.KingMoves;
            Position = position;
            Position.ChangeStatus();
        }
    }
}
