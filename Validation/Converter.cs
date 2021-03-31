using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask.Validation
{
    class Converter
    {
        public int ParseToInt(string strToCheck, bool needToCheck)
        {
            int result = -1;

            if (needToCheck)
            {
                if (Int32.TryParse(strToCheck, out _))
                {
                    result = Int32.Parse(strToCheck);
                }
            }
            else
            {
                try
                {
                   result = Int32.Parse(strToCheck);
                }
                catch (Exception )
                {

                    throw; //TODO: Exception
                }
            }

            return result;
        }
    }
}
