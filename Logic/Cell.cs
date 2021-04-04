using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardTask.Logic
{
    class Cell
    {
        public Cell(bool isWhite)
        {
            _isWhite = isWhite;
        }

        private readonly bool _isWhite;

        public bool IsWhite { get { return _isWhite; } }
    }
}
