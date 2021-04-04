﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessBoardTask.Logic
{
    class ChessBoard
    {
        public ChessBoard(int height, int width)
        {
            _height = height;
            _width = width;
            _cells = new Cell[height, width];

            FillColor();
        }

        private readonly int _height;
        private readonly int _width;
        private readonly Cell[,] _cells;

        public int Width { get { return _width; } }
        public int Height { get { return _height; }  }

        public Cell this[int i, int j]
        {
            get
            {
                return _cells[i, j];
            }

        }

        private void FillColor()
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
