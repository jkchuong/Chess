using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Cell
    {
        public bool IsOccupied { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }

        public Cell()
        {

        }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public (int x, int y) GetPoint()
        {
            return (X, Y);
        }

        // =================================================
        // Returning and moving cells
        // =================================================

        public void ChangeStatus()
        {
            IsOccupied = !IsOccupied;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        // =================================================
        // Comparison Methods 
        // =================================================

        public override bool Equals(object obj)
        {
            return obj is Cell point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
