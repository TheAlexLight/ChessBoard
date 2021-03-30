using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardTask.Logic
{
    class Cell
    {
        public Cell(bool isWhite)
        {
            this.isWhite = isWhite;
        }

        private readonly bool isWhite;

        public bool IsWhite { get { return isWhite; } }
    }
}
