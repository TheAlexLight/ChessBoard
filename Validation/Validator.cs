using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Logic;
using ChessBoardTask.View;

namespace ChessBoardTask.Validation
{
     class Validator
    {
        public  bool CheckIntOnPositive(int intToCheck)
        {
            return intToCheck > 0;
        }

        public  bool CheckIntOnPositive(int intToCheck, int maxValue)
        {
            return (intToCheck > 0 && intToCheck <= maxValue);
        }
    }
}
