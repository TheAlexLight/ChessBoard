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
            this.chessBoardInit = chessBoard;
        }

        readonly ChessBoard chessBoardInit;

        public void ShowFullBoard()
        {
            for (int i = 0; i < chessBoardInit.Height; i++)
            {
                for (int j = 0; j < chessBoardInit.Width; j++)
                {
                    switch (Convert.ToInt32(chessBoardInit.Cells[i,j].IsWhite))
                    {
                        case (int)CellColor.White: 
                            Console.Write("*");
                            break;

                        case (int)CellColor.Black:
                            Console.Write("#");
                            break;
                    }  
                }

                Console.WriteLine();
            }
        }
    }
}
