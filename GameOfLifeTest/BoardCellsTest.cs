using System.Collections.Generic;
using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    [TestFixture]
    public class BoardCellsTest
    {
        [Test]
        public void BoardIsEmptyOnDefault()
        {
            Board b = new Board();
            Assert.AreEqual(CellState.Dead, b.Get(new Position(1,1)));
        }
        
        [Test]
        public void BoardGetReturnsCorrectValue()
        {
            Board b = new Board(new List<Position>(){new Position(1,1)});
            Assert.AreEqual(CellState.Alive, b.Get(new Position(1,1)));
        }

        [Test]
        public void BoardSetReturnsCorrectValue()
        {
            Board b = new Board();
            b.Set(new Position(1, 1));
            Assert.AreEqual(CellState.Alive, b.Get(new Position(1, 1)));
        }
    }
}