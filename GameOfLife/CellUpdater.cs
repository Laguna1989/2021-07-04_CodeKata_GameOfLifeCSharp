using GameOfLife;

namespace GameOfLifeTest
{
    public class CellUpdater : ICellUpdater
    {
        public CellState GetNewCellState(CellState currentState, int aliveNeighbours)
        {
            if (aliveNeighbours == 3)
            {
                return CellState.Alive;
            }
            else if (aliveNeighbours == 2 && currentState == CellState.Alive)
            {
                return CellState.Alive;
            }
            else
            {
                return CellState.Dead;
            }
        }
    }
}