using System.Collections.Generic;
using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    public class BoardSizeTest
    {
        [Test]
        public void StoresCorrectValues()
        {
            BoardSize s = new BoardSize(1, 2, 3, 4);
            
            Assert.AreEqual(1, s.xMin);
            Assert.AreEqual(2, s.yMin);
            Assert.AreEqual(3, s.xMax);
            Assert.AreEqual(4, s.yMax);
        }
        
        [Test]
        public void CompareEqual()
        {
            BoardSize s1 = new BoardSize(1, 2, 3, 4);
            BoardSize s2 = new BoardSize(1, 2, 3, 4);
            
            Assert.AreEqual(s1, s2);
        }
        
        [Test]
        public void CompareUnqual()
        {
            BoardSize s1 = new BoardSize(1, 2, 3, 4);
            BoardSize s2 = new BoardSize(5, 6, 7, 8);
            
            Assert.AreNotEqual(s1, s2);
        }
        
        [Test]
        public void ExtendEmptyBoardSize()
        {
            BoardSize s1 = new BoardSize(0,0,0,0);
            BoardSize s2 = s1.Extend();
            BoardSize expected =  new BoardSize(-1,-1,1,1);
            Assert.AreEqual(expected, s2);
        }
        
        [Test]
        public void ExtendOneCell()
        {
            BoardSize s1 = new BoardSize(1,1,1,1);
            BoardSize s2 = s1.Extend();
            BoardSize expected = new BoardSize(0, 0, 2, 2);
            Assert.AreEqual(expected, s2);
        }
        
        [Test]
        public void ExtendMultipleCells()
        {
            BoardSize s1 = new BoardSize(-10,1,55,100);
            BoardSize s2 = s1.Extend();
            BoardSize expected = new BoardSize(-11, 0, 56, 101);
            Assert.AreEqual(expected, s2);
        }

        [Test]
        public void ToListForEmptyBoard()
        {
            BoardSize size = new BoardSize(0, 0, 0, 0);
            List<Position> expected = new List<Position>()
                { new Position(0,0)};
            Assert.That(expected, Is.EquivalentTo(size.ToList()));
        }

        [Test]
        public void ToListForMultipleCells()
        {
            BoardSize size = new BoardSize(0, 0, 2, 2);
            List<Position> expected = new List<Position>()
            {
                new Position(0, 0), new Position(0, 1), new Position(0, 2),
                new Position(1, 0), new Position(1, 1), new Position(1, 2),
                new Position(2, 0), new Position(2, 1), new Position(2, 2)
            };

            Assert.That(expected, Is.EquivalentTo(size.ToList()));
        }
    }
    
}