using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Validation;
using ChessBoardTask.View;
using ConsolePrinterLibrary;

namespace ChessBoardTask.Controller
{
    class ChessBoardController
    {
        ChessBoardStartSize chessBoardParameters = new ChessBoardStartSize();
        readonly ConsolePrinter printer = new ConsolePrinter();
       
        public ChessBoardStartSize CheckBoardValues(string widthArg, string heightArg) 
        {
            try
            {
                chessBoardParameters.Width = GetBoardValue(widthArg, Constant.ARG_WIDTH);
                chessBoardParameters.Height = GetBoardValue(heightArg, Constant.ARG_HEIGHT);
            }
            catch (ArgumentException ex)
            {
                printer.WriteLine(string.Format("{0}: {1}", Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }

            return chessBoardParameters;
        }

        private int GetBoardValue(string strBoardArg, string valueName)
        {
            int result = -1;
            bool successFormat = false;
            Converter converterArgs = new Converter();
            Validator validArgs = new Validator();

                while (!successFormat)
                {
                    result = converterArgs.TryParseToInt(strBoardArg);

                    if (result != -1)
                    {
                        if (!validArgs.CheckIntOnPositive(result, ChessBoardStartSize.MAX_CHESSBOARD_SIZE))
                        {
                            printer.WriteLine(Constant.WRONG_BOUNDARIES);
                            printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                            strBoardArg = printer.ReadLine();
                        }
                        else
                        {
                            successFormat = true;
                        }
                    }
                    else
                    {
                        printer.WriteLine(Constant.INT_WRONG_TYPE);
                        printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                        strBoardArg = printer.ReadLine();
                    }
                }

            return result;
        }
    }
}
