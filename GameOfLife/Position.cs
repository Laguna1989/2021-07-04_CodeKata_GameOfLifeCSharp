namespace GameOfLife
{
    public class Position
    {
        public int x;
        public int y;
        
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            var rhs = obj as Position;

            return x == rhs?.x && y == rhs.y;
        }
    }
}