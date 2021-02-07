using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    static class Rulebook
    {
        // Can be condensed? Make one for each direction and have it be multiplied?

        public static readonly List<Move> PawnMoves = new List<Move>
        {
            new Move(2, 0),
            new Move(1, 0),
            new Move(1, 1)
        };

        public static readonly List<Move> KnightMoves = new List<Move>
        {
            new Move(2, 1),
            new Move(1, 2),

            new Move(2, -1),
            new Move(-1, 2),

            new Move(-2, 1),
            new Move(1, -2),

            new Move(-2, -1),
            new Move(-1, -2)
        };

        public static readonly List<Move> KingMoves = new List<Move>
        {
            new Move(1, 0),
            new Move(1, 1),
            new Move(1, -1),

            new Move(-1, 0),
            new Move(-1, 1),
            new Move(-1, -1),

            new Move(0, -1),
            new Move(0, 1)
        };
    }
}
