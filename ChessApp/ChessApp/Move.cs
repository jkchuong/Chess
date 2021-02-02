using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Move
    {
        public int MoveX { get; set; }
        public int MoveY { get; set; }

        public Move(int moveX, int moveY)
        {
            MoveX = moveX;
            MoveY = moveY;
        }

        public override string ToString()
        {
            return $"({MoveX}, {MoveY})";
        }
    }
}
