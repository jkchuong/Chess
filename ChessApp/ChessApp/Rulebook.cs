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

        public static readonly List<Move> RookMoves = new List<Move>
        {
            new Move(1, 0),
            new Move(2, 0),
            new Move(3, 0),
            new Move(4, 0),
            new Move(5, 0),
            new Move(6, 0),
            new Move(7, 0),

            new Move(-1, 0),
            new Move(-2, 0),
            new Move(-3, 0),
            new Move(-4, 0),
            new Move(-5, 0),
            new Move(-6, 0),
            new Move(-7, 0),

            new Move(0, 1),
            new Move(0, 2),
            new Move(0, 3),
            new Move(0, 4),
            new Move(0, 5),
            new Move(0, 6),
            new Move(0, 7),

            new Move(0, -1),
            new Move(0, -2),
            new Move(0, -3),
            new Move(0, -4),
            new Move(0, -5),
            new Move(0, -6),
            new Move(0, -7),
        };

        public static readonly List<Move> BishopMoves = new List<Move>
        {
            new Move(1, 1),
            new Move(2, 2),
            new Move(3, 3),
            new Move(4, 4),
            new Move(5, 5),
            new Move(6, 6),
            new Move(7, 7),

            new Move(-1, -1),
            new Move(-2, -2),
            new Move(-3, -3),
            new Move(-4, -4),
            new Move(-5, -5),
            new Move(-6, -6),
            new Move(-7, -7),

            new Move(-1, 1),
            new Move(-2, 2),
            new Move(-3, 3),
            new Move(-4, 4),
            new Move(-5, 5),
            new Move(-6, 6),
            new Move(-7, 7),

            new Move(1, -1),
            new Move(2, -2),
            new Move(3, -3),
            new Move(4, -4),
            new Move(5, -5),
            new Move(6, -6),
            new Move(7, -7),
        };

        // somehow concatenate the bishop and rook moves?
        public static readonly List<Move> QueenMoves = new List<Move>
        {
            // Rook Moves
            new Move(1, 0),
            new Move(2, 0),
            new Move(3, 0),
            new Move(4, 0),
            new Move(5, 0),
            new Move(6, 0),
            new Move(7, 0),

            new Move(-1, 0),
            new Move(-2, 0),
            new Move(-3, 0),
            new Move(-4, 0),
            new Move(-5, 0),
            new Move(-6, 0),
            new Move(-7, 0),

            new Move(0, 1),
            new Move(0, 2),
            new Move(0, 3),
            new Move(0, 4),
            new Move(0, 5),
            new Move(0, 6),
            new Move(0, 7),

            new Move(0, -1),
            new Move(0, -2),
            new Move(0, -3),
            new Move(0, -4),
            new Move(0, -5),
            new Move(0, -6),
            new Move(0, -7),

            //Bishop Moves
            new Move(1, 1),
            new Move(2, 2),
            new Move(3, 3),
            new Move(4, 4),
            new Move(5, 5),
            new Move(6, 6),
            new Move(7, 7),

            new Move(-1, -1),
            new Move(-2, -2),
            new Move(-3, -3),
            new Move(-4, -4),
            new Move(-5, -5),
            new Move(-6, -6),
            new Move(-7, -7),

            new Move(-1, 1),
            new Move(-2, 2),
            new Move(-3, 3),
            new Move(-4, 4),
            new Move(-5, 5),
            new Move(-6, 6),
            new Move(-7, 7),

            new Move(1, -1),
            new Move(2, -2),
            new Move(3, -3),
            new Move(4, -4),
            new Move(5, -5),
            new Move(6, -6),
            new Move(7, -7),
        };
    }
}
