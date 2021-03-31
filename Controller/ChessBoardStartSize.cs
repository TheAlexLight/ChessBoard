using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Validation;

namespace ChessBoardTask.Controller
{
    struct ChessBoardStartSize
    {
       public const int MAX_CHESSBOARD_SIZE = 20;
        private int width;
        private int height;

        public int Width { get { return width; }
            set 
            {
                if (value > 0 && value < MAX_CHESSBOARD_SIZE)
                {
                    width = value;
                }
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 && value < MAX_CHESSBOARD_SIZE)
                {
                    height = value;
                }
            }
        }
    }
}
