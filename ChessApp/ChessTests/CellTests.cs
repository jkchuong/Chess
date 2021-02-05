using NUnit.Framework;
using ChessApp;

namespace ChessTests
{
    public class CellTests
    {
        [TestCase(1, 1, "(1, 1)")]
        [TestCase(2, 5, "(2, 5)")]
        public void CellReturnsCellPosition(int x, int y, string expectedOutput)
        {
            var cell = new Cell(x, y);
            Assert.AreEqual(expectedOutput, cell.ToString());
        }

        [TestCase(2, 5, false)]
        public void CellIsUnoccupiedOnCreation(int x, int y, bool expectedOutput)
        {
            var cell = new Cell(x, y);
            Assert.AreEqual(expectedOutput, cell.IsOccupied);
        }
    }
}