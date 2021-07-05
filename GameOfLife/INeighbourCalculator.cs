namespace GameOfLife
{
    public interface INeighbourCalculator
    {
        int GetNumberOfNeighbours(Board board, Position pos);
    }
}