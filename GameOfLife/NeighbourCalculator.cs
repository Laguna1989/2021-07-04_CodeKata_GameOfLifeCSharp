using System.Linq;

namespace GameOfLife
{
    public class NeighbourCalculator : INeighbourCalculator
    {
        public int GetNumberOfNeighbours(Board board, Position pos)
        {
            BoardSize boardSize = new BoardSize(pos);

            var cellsToCheck = boardSize.Extend().ToList();
            cellsToCheck.Remove(pos);
            return cellsToCheck.Count(newPosition => board.Get(newPosition) == CellState.Alive);
        }
    }
}