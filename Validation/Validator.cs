using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Logic;

namespace ChessBoardTask.Validation
{
     class Validator
    {
        public  bool CheckIntOnPositive(int intToCheck, bool needToCheck)
        {
            if (!needToCheck)
            {
                if (intToCheck <= 0)
                {
                    throw new Exception(); //TODO: Exception
                }
            }
            return intToCheck > 0;
        }

        public  bool CheckIntOnPositive(int intToCheck, int maxValue, bool needToCheck)
        {
            if(!needToCheck)
            {
                if (intToCheck <= 0 || intToCheck > maxValue)
                {
                    throw new Exception(); //TODO: Exception
                }
            }
            return (intToCheck > 0 && intToCheck <= maxValue);
        }

        public  bool ChessTableContainsZero(Cell[,] cells)
        {
            foreach (var cell in cells)
            {
                if (cell == null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
