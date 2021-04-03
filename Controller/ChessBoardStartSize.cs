using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Validation;
using ChessBoardTask.View;

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
                if (value <= 0 || value > MAX_CHESSBOARD_SIZE)
                {
                    throw new ArgumentException(Constant.WRONG_BOUNDARIES);
                }

                width = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0 || value > MAX_CHESSBOARD_SIZE)
                {
                    throw new ArgumentException(Constant.WRONG_BOUNDARIES);
                }

                height = value;
            }
        }
    }
}
