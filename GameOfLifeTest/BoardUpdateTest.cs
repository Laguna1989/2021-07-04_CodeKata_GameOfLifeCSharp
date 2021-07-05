using System.Collections.Generic;
using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    [TestFixture]
    public class UpdateBoardTest
    {
        private Board oldBoard ;
        private NeighbourCalculator nc ;
        private CellUpdater cu ;
        
        [SetUp]
        public void Init()
        {
            oldBoard = new Board();
            nc = new NeighbourCalculator();
            cu = new CellUpdater();
        }

        [Test]
        public void EmptyBoardStaysEmpty()
        {
            Assert.AreEqual(new Board(), new Board(oldBoard.Update(nc, cu)));
        }

        [Test]
        public void BoardWithOneCellDies()
        {
            oldBoard = new Board(new List<Position>(){new Position(1,1)});
            Assert.AreEqual(new Board(), new Board(oldBoard.Update(nc, cu)));
        }
        
        [Test]
        public void HorizontalBlinkerFlips()
        {
            oldBoard = createHorizontalBlinker();
            var updatedBoard = new Board(oldBoard.Update(nc, cu));
            Assert.AreEqual(createVerticalBlinker(), updatedBoard);
        }
        
        [Test]
        public void VerticalBlinkerFlips()
        {
            oldBoard = createVerticalBlinker();
            Assert.AreEqual(createHorizontalBlinker(), new Board(oldBoard.Update(nc, cu)));
        }

        private static Board createHorizontalBlinker()
        {
            return new Board(new List<Position>(){new Position(0,1),new Position(1,1),new Position(2,1)});
        }
        private static Board createVerticalBlinker()
        {
            return new Board(new List<Position>(){new Position(1,0),new Position(1,1),new Position(1,2)});
        }
    }
}