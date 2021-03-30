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


            //BasicBoards();
            //currentChessBoardPair.board = "Chess";
            //currentChessBoardPair.chess = boardAndChessPairList["Chess"];
        }

        private readonly int height;
        private readonly int width;
        private readonly Cell[,] cells;

        //private Dictionary<String, int[]> boardAndChessPairList = new Dictionary<string, int[]>();
        //private (String board, int[] chess) currentChessBoardPair;

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





        //private void BasicBoards()
        //{
        //    boardAndChessPairList.Add("Chess", new int[5] { 0, 1, 2, 3, 4 });
        //    boardAndChessPairList.Add("Checker", new int[3] { 0, 1, 2 });
        //}

        //public void ChangeChessman(int chessType)
        //{
        //    cells[0, 0].Chessman = new Chessman(true) { Chesstype = currentChessBoardPair.chess[chessType] };
        //}
    }
}
