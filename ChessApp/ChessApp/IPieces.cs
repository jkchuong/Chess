using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public interface IPieces
    {
        // ==============================
        // Properties
        // ==============================

        public bool IsWhite { get; set; }
        public bool IsFirstMove { get; set; }
        public Cell Position { get; set; }

        // ==============================
        // Methods
        // ==============================
        public void Moving(int moveIndex);
    }
}
