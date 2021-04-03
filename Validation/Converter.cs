using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask.Validation
{
    class Converter
    {
        public int TryParseToInt(string strToCheck)
        {
            int result = -1;

                if (Int32.TryParse(strToCheck, out _))
                {
                    result = Int32.Parse(strToCheck);
                }


            return result;
        }
    }
}
