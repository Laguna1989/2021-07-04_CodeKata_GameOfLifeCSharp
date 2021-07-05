using System.Collections.Generic;
using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    [TestFixture]
    public class GetNumberOfNeighboursTest
    {
        private Board b;
        private NeighbourCalculator nc;

        [SetUp]
        public void Init()
        {
            b = new Board();
            nc = new NeighbourCalculator();
        }
        [Test]
        public void ZeroNeighboursForEmptyBoard()
        {
            Assert.AreEqual(0, nc.GetNumberOfNeighbours(b, new Position(1,1)));
        }
        
        [Test]
        public void OneNeighbour()
        {
            b = new Board(new List<Position>(){new Position(2,1)});
            Assert.AreEqual(1, nc.GetNumberOfNeighbours(b,new Position(1,1)));
        }
        
        [Test]
        public void TwoNeighbours()
        {
            b = new Board(new List<Position>(){new Position(2,1), new Position(0,1)});
            Assert.AreEqual(2, nc.GetNumberOfNeighbours(b,new Position(1,1)));
        }
        
        [Test]
        public void AllNeighbours()
        {
            b = new Board(new List<Position>()
            {
                new Position(0,0), new Position(0,1), new Position(0,2),
                new Position(1, 0), new Position(1,2),
                new Position(2,0), new Position(2,1), new Position(2,2)
            });
            Assert.AreEqual(8, nc.GetNumberOfNeighbours(b,new Position(1,1)));
        }
        
        [Test]
        public void DoNotCountCentralCell()
        {
            b = new Board(new List<Position>()
            {
                new Position(0,0), new Position(0,1), new Position(0,2),
                new Position(1, 0),new Position(1, 1), new Position(1,2),
                new Position(2,0), new Position(2,1), new Position(2,2)
            });
            Assert.AreEqual(8, nc.GetNumberOfNeighbours(b,new Position(1,1)));
        }
    }
}