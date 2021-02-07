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
    }
}