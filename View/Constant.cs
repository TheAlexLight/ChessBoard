using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask.View
{
   public static class Constant
    {
       public const string CHECK_ARGS_PROMPT = @"Do you want to check arguments?(Write """"y"""" or """"yes"""" to accept): ";
       public const string SIMPLE_YES = "Y";
       public const string YES = "Yes";
       public const string ARG_WIDTH = "width";
       public const string ARG_HEIGHT = "height";
       public const string WRONG_BOUNDARIES = "Wrong number boundaries, try again";
       public const string INT_WRONG_TYPE = "Type of data should be integer, try again";
       public const string ENTER_PROMPT = "Enter your {0}: ";
       public const string WHITE_CELL = "*";
       public const string BLACK_CELL = " ";

    }
}
