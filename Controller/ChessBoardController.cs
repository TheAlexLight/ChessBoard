using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Validation;
using ChessBoardTask.View;

namespace ChessBoardTask.Controller
{
    class ChessBoardController
    {
        private const int MAX_CHESSBOARD_SIZE = 20; 

        public (int width,int height) Start() // ToDo: Rename
        {

            string message = "Please enter ChessBoard width";
            int width = GetBoardValues(message);

            message = "Please enter ChessBoard height";
            int height = GetBoardValues(message);

            return (width, height);

        }

        private int GetBoardValues(string message)
        {

            int result = -1;

            while (true) //ToDo: Condition
            {
                string tempStr = string.Format("{0}: ", message);
                ConsolePrinter.Write(tempStr);

                if (Validator.TryParseToInt(tempStr = Console.ReadLine()))
                {
                    result = Int32.Parse(tempStr);
                    if (!Validator.CheckIntOnPositive(result, MAX_CHESSBOARD_SIZE))
                    {
                        tempStr = "Wrong width, try again";
                        ConsolePrinter.WriteLine(tempStr);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    tempStr = "Wrong width, try again";
                    ConsolePrinter.WriteLine(tempStr);
                }
            }

            return result;
        }
    }
}
