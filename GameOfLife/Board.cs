using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class Board
    {
        private List<Position> _positions;
        
        public Board()
        {
            _positions = new List<Position>();
        }

        public Board(List<Position> positions)
        {
            _positions = positions;
        }
        
        public override bool Equals(object obj)
        {
            var rhs = obj as Board;

            return _positions.SequenceEqual(rhs?._positions);
        }

        public CellState Get(Position position)
        {
            return _positions.Contains(position) ? CellState.Alive : CellState.Dead;
        }

        public void Set(Position position)
        {
            _positions.Add(position);
        }

        public BoardSize GetBoardSize()
        {
            if (_positions.Count == 0)
            {
                return new BoardSize(0, 0, 0, 0);
            }
            var xValues = _positions.Select(position => position.x).ToList();
            var yValues = _positions.Select(position => position.y).ToList();
            return new BoardSize(xValues.Min(), yValues.Min(), xValues.Max(), yValues.Max());
        }

        public List<Position> Update(INeighbourCalculator nc, ICellUpdater cu)
        {
            var newSize = GetBoardSize().Extend();
            List<Position> newPositions = new List<Position>();
            foreach (Position p in newSize.ToList())
            {
                int aliveCells = nc.GetNumberOfNeighbours(this, p);
                if (cu.GetNewCellState(Get(p), aliveCells) == CellState.Alive)
                {
                    newPositions.Add(p);
                }
            }

            return newPositions;
        }
    }
}