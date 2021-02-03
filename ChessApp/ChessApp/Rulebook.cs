using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    static class Rulebook
    {
        public static readonly List<Move> PawnMoves = new List<Move>
        {
            new Move(1, 0),
            new Move(1, 1)
        };
    }
}
