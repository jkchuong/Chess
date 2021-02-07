using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Pawn : Pieces
    {
        public override List<Move> PossibleMoves { get => Rulebook.PawnMoves; }
        public new string Name = "Pawn";

        public Pawn(bool isWhite, Cell position) : base(isWhite, position)
        {
            Position = position;
            position.ChangeStatus();
        }

        public void Moving(int moveIndex)
        {
            
        }
    }
}
