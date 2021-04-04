using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask.View
{
   public static class Constant
    {
        public const int MAX_CHESSBOARD_SIZE = 20;

       public const string SIMPLE_YES = "Y";
       public const string YES = "Yes";
       public const string ARG_WIDTH = "width";
       public const string ARG_HEIGHT = "height";
       public const string WRONG_BOUNDARIES = "Wrong number boundaries, try again";
       public const string INT_WRONG_TYPE = "Type of data should be integer, try again";
       public const string ENTER_PROMPT = "Enter your {0}: ";
       public const string WHITE_CELL = "*";
       public const string BLACK_CELL = " ";
       public const string OUT_OF_RANGE_ERROR = "ERROR: The number is out of range";
       public const string EXCEPTION_OCCURED = "ERROR occured";
       public const string INSTRUCTION = "Instruction of using: You should use 2 arguments:";
       public const string FIRST_ARGUMENT = "1 argument - Width: Type - Integer(Greater than 0 and less than {0})";
       public const string SECOND_ARGUMENT = "2 argument - Height: Type - Integer(Greater than 0 and less than {0})";



    }
}
