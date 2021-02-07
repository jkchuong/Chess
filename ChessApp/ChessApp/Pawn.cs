﻿using System;
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
            Name = "Pawn";
            PossibleMoves = Rulebook.PawnMoves;
            Position = position;
            Position.ChangeStatus();
        }
    }
}
