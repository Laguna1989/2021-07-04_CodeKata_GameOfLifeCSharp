namespace GameOfLife
{
    public interface ICellUpdater
    {
        CellState GetNewCellState(CellState currentState, int aliveNeighbours);
    }
}