using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBoardTask.Enums;
using ChessBoardTask.Logic;

namespace ChessBoardTask.View
{
    class ChessBoardViewer
    {
        public ChessBoardViewer(ChessBoard chessBoard)
        {
           _chessBoardInit = chessBoard;
        }

        readonly ChessBoard _chessBoardInit;

        public void ShowFullBoard()
        {
            for (int i = 0; i < _chessBoardInit.Height; i++)
            {
                for (int j = 0; j < _chessBoardInit.Width; j++)
                {
                    switch (Convert.ToInt32(_chessBoardInit[i,j].IsWhite))
                    {
                        case (int)CellColor.White: 
                            Console.Write(Constant.WHITE_CELL);
                            break;

                        case (int)CellColor.Black:
                            Console.Write(Constant.BLACK_CELL);
                            break;
                    }  
                }

                Console.WriteLine();
            }
        }
    }
}
