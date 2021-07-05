using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTest
{
    [TestFixture]
    public class PositionTest
    {
        [Test]
        public void PositionCompareEqual()
        {
            Position pos1 = new Position(5, 7);
            Position pos2 = new Position(5, 7);
            
            Assert.AreEqual(pos1,pos2);
        }
        
        [Test]
        public void PositionCompareUnqual()
        {
            Position pos1 = new Position(2, 9);
            Position pos2 = new Position(3, 13);
            
            Assert.AreNotEqual(pos1,pos2);
        }
    }
}