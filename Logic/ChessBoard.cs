using ChessBoardTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessBoardTask.Logic
{
    class ChessBoard: IBoard
    {
        public ChessBoard(int height, int width)
        {
            _height = height;
            _width = width;
            _cells = new Cell[height, width];

            CreateBoard();
        }

        private readonly int _height;
        private readonly int _width;
        private readonly Cell[,] _cells;

        public int Width => _width;
        public int Height => _height;
        public Cell this[int i, int j] => _cells[i,j];

        public void CreateBoard()
        {
            bool isWhiteColumn = true;
            
            for (int i = 0; i < _height; i++)
            {
                bool isWhiteRow = isWhiteColumn;

                for (int j = 0; j < _width; j++)
                {
                    _cells[i, j] = new Cell(isWhiteRow);
                    isWhiteRow = !isWhiteRow;
                }

                isWhiteColumn = !isWhiteColumn;
            }
        }
    }
}
