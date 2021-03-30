using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Logic;

namespace ChessBoardTask.Validation
{
    static class Validator
    {
        public static bool TryParseToInt(string strToCheck)
        {
            return Int32.TryParse(strToCheck, out _);
        }

        public static bool CheckIntOnPositive(int intToCheck)
        {
            return intToCheck > 0;
        }

        public static bool CheckIntOnPositive(int intToCheck, int maxValue)
        {
            return (intToCheck > 0 && intToCheck <= maxValue);
        }

        public static bool ChessTableContainsZero(Cell[,] cells)
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
