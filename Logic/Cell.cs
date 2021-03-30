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
        //private Chessman chessman;

        public bool IsWhite { get { return isWhite; } }








        //public Chessman Chessman 
        //{ 
        //    get 
        //    {
        //        return chessman;
        //    }
        //    set 
        //    {
        //        if (chessman != null)
        //        {
        //            chessman = value;
        //        }
        //    }
        //}

    }
}
