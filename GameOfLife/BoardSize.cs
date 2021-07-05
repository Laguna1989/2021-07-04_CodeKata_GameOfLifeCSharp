using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class BoardSize
    {
        public int xMin;
        public int yMin;
        public int xMax;
        public int yMax;
        
        public BoardSize(int xmin, int ymin, int xmax, int ymax)
        {
            xMin = xmin;
            yMin = ymin;
            xMax = xmax;
            yMax = ymax;
        }
        public BoardSize(Position pos)
        {
            xMin = pos.x;
            yMin = pos.y;
            xMax = pos.x;
            yMax = pos.y;
        }
        
        public override bool Equals(object obj)
        {
            var rhs = obj as BoardSize;

            return xMin == rhs?.xMin && yMin == rhs.yMin && xMax == rhs.xMax && yMax == rhs.yMax;
        }
        
        public BoardSize Extend()
        {
            return new BoardSize(xMin - 1, yMin - 1, xMax + 1, yMax + 1);
        }



        public List<Position> ToList()
        {
            List<Position> positions = new List<Position>();
            foreach (var xPos in Enumerable.Range(xMin, xMax-xMin+1))
            {
                foreach (var yPos in Enumerable.Range(yMin, yMax - yMin +1))
                {
                    positions.Add(new Position(xPos, yPos));
                }
            }
            return positions;
        }
    }
    

}