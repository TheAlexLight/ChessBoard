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
        private int _width;
        private int _height;

        public int Width { get { return _width; }
            set 
            {
                if (value <= 0 || value > Constant.MAX_CHESSBOARD_SIZE)
                {
                    throw new ArgumentException(Constant.WRONG_BOUNDARIES);
                }

                _width = value;
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value <= 0 || value > Constant.MAX_CHESSBOARD_SIZE)
                {
                    throw new ArgumentException(Constant.WRONG_BOUNDARIES);
                }

                _height = value;
            }
        }
    }
}
