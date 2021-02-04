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
        public new string Name = "Pawn";

        public Pawn(bool isWhite, Cell position) : base(isWhite, position)
        {
            
        }
    }
}
