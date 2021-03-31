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
        ChessBoardStartSize chessBoardParameters = new ChessBoardStartSize();
       

        public ChessBoardStartSize CheckBoardValues(string widthArg, string heightArg) // ToDo: Rename
        {
            string message = @"Do you want to check arguments?(Write """"y"""" or """"yes"""" to accept)";
            ConsolePrinter.Write(message);

            string prompt = ConsolePrinter.ReadLine();

            bool needToCheck = false;

            if (prompt.ToUpper().Equals("y") || prompt.ToUpper().Equals("yes"))
            {
                needToCheck = true;
            }

            chessBoardParameters.Width = GetBoardValue(widthArg, needToCheck);
            chessBoardParameters.Height = GetBoardValue(heightArg, needToCheck);


            return chessBoardParameters;

            // string message = "Please enter ChessBoard width";
            //  int width = GetBoardValues(message);

            ////  message = "Please enter ChessBoard height";
            //  int heigh = GetBoardValues(message);

        }

        private int GetBoardValue(string strBoardArg, bool needToCheck)
        {
            int result = -1;
            bool successFormat = false;
            Converter converterArgs = new Converter();
            Validator validArgs = new Validator();

            while (!successFormat) 
            {
                //string tempStr = string.Format("{0}: ", message);
                //ConsolePrinter.Write(tempStr);

                result = converterArgs.ParseToInt(strBoardArg, needToCheck);

                if (result != -1) //TODO: Change
                {
                    if (!validArgs.CheckIntOnPositive(result, ChessBoardStartSize.MAX_CHESSBOARD_SIZE, needToCheck))
                    {
                        string tempStr = "Wrong number boundaries, try again";
                        ConsolePrinter.WriteLine(tempStr);
                    }
                    else
                    {
                        successFormat = true;
                    }
                }
                else
                {
                    string tempStr = "Wrong number, try again";
                    ConsolePrinter.WriteLine(tempStr);

                    strBoardArg = ConsolePrinter.ReadLine();
                }
            }

            return result;
        }
    }
}
