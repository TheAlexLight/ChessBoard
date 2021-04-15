using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Logic;

namespace ChessBoardTask.View
{
    class ChessBoardViewer
    {
        public ChessBoardViewer(ChessBoard chessBoardInit)
        {
           _chessBoardInit = chessBoardInit;
        }

        private readonly ChessBoard _chessBoardInit;

        public void ShowFullBoard()
        {
            for (int i = 0; i < _chessBoardInit.Height; i++)
            {
                for (int j = 0; j < _chessBoardInit.Width; j++)
                {
                    if (_chessBoardInit[i,j].IsWhite)
                    {
                        Console.Write(Constant.WHITE_CELL);
                    }
                    else
                    {
                        Console.Write(Constant.BLACK_CELL);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
