using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    [TestFixture]
    public class UpdateRulesTest
    {
        [Test]
        [TestCase(0, CellState.Dead)]
        [TestCase(1, CellState.Dead)]
        [TestCase(2, CellState.Alive)]
        [TestCase(3, CellState.Alive)]
        [TestCase(4, CellState.Dead)]
        [TestCase(5, CellState.Dead)]
        [TestCase(6, CellState.Dead)]
        [TestCase(7, CellState.Dead)]
        [TestCase(8, CellState.Dead)]
        public void UpdateForAliveCellsTest(int aliveNeighbours, CellState expectedNewState)
        {
            CellUpdater cu = new CellUpdater();
            Assert.AreEqual(expectedNewState, cu.GetNewCellState(CellState.Alive, aliveNeighbours));
        }
        
        [Test]
        [TestCase(0, CellState.Dead)]
        [TestCase(1, CellState.Dead)]
        [TestCase(2, CellState.Dead)]
        [TestCase(3, CellState.Alive)]
        [TestCase(4, CellState.Dead)]
        [TestCase(5, CellState.Dead)]
        [TestCase(6, CellState.Dead)]
        [TestCase(7, CellState.Dead)]
        [TestCase(8, CellState.Dead)]
        public void UpdateForDeadCellsTest(int aliveNeighbours, CellState expectedNewState)
        {
            CellUpdater cu = new CellUpdater();
            Assert.AreEqual(expectedNewState, cu.GetNewCellState(CellState.Dead, aliveNeighbours));
        }
    }
}