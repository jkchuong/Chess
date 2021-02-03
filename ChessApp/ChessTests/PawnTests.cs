using NUnit.Framework;
using ChessApp;

namespace ChessTests
{
    public class PawnTests
    {
        [TestCase(true, 1, 1, "(1, 1)")]
        [TestCase(false, 2, 5, "(2, 5)")]
        public void ReturnPawnPosition(bool colour, int x, int y, string expectedOutput)
        {
            var pawn = new Pawn(colour, new Cell(x, y));
            string result = pawn.GetPosition();
            Assert.AreEqual(expectedOutput, result);
        }

        [TestCase(true, 1, 1, 0, "(2, 1)")]
        [TestCase(true, 1, 1, 1, "(2, 2)")]
        public void MovePawns(bool colour, int x, int y, int moveIndex, string expectedOutput)
        {
            var pawn = new Pawn(colour, new Cell(x, y));
            pawn.Moving(moveIndex);
            string result = pawn.GetPosition();
            Assert.AreEqual(expectedOutput, result);
        }

        [TestCase(true, 1, 1, 0, false)]
        public void MovingPawnLeavesCellUnoccupied(bool colour, int x, int y, int moveIndex, bool expectedOutput)
        {
            Cell initialCell = new Cell(x, y);
            var pawn = new Pawn(colour, initialCell);
            pawn.Moving(moveIndex);
            bool result = initialCell.IsOccupied;
            Assert.AreEqual(expectedOutput, result);
        }


        [TestCase(true, 1, 1, 0, true)]
        public void MovingPawnOccupiesCell(bool colour, int x, int y, int moveIndex, bool expectedOutput)
        {
            Cell initialCell = new Cell(x, y);
            var pawn = new Pawn(colour, initialCell);
            pawn.Moving(moveIndex);
            bool result = pawn.Position.IsOccupied;
            Assert.AreEqual(expectedOutput, result);
        }
    }
}