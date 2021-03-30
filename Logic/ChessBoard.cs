using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessBoardTask.Logic
{
    class ChessBoard
    {
        public ChessBoard(int height, int width)
        {
            this.height = height;
            this.width = width;
            cells = new Cell[height, width];

            FillColor();
        }

        private readonly int height;
        private readonly int width;
        private readonly Cell[,] cells;

        public int Width { get { return width; } }
        public int Height { get { return height; }  }
        public Cell[,] Cells { get { return cells; }  }

        private void FillColor()
        {
            bool isWhiteColumn = true;
            
            for (int i = 0; i < height; i++)
            {
                bool isWhiteRow = isWhiteColumn;

                for (int j = 0; j < width; j++)
                {
                    cells[i, j] = new Cell(isWhiteRow);
                    isWhiteRow = !isWhiteRow;
                }

                isWhiteColumn = !isWhiteColumn;
            }
        }
    }
}
