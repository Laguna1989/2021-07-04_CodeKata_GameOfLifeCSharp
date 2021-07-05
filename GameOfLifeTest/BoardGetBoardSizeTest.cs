using System.Collections.Generic;
using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    public class BoardTest
    {
        
        
        [Test]
        public void GetBoardSizeForEmptyBoard()
        {
            Board b = new Board();
            Assert.AreEqual(new BoardSize(0,0,0,0), b.GetBoardSize());
        }
        
        [Test]
        public void GetBoardSizeForOneCell()
        {
            Board b = new Board(new List<Position>(){new Position(1,1)});
            Assert.AreEqual(new BoardSize(1,1,1,1), b.GetBoardSize());
        }

        [Test]
        public void GetBoardSizeForMultipleCells()
        {
            List<Position> setPositions = new List<Position>()
                {new Position(1, 1), new Position(5, 5), new Position(-20, 4)};
            Board b = new Board(setPositions);
            Assert.AreEqual(new BoardSize(-20, 1, 5, 5), b.GetBoardSize());
        }
    }
}