using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Validation;
using ChessBoardTask.View;
using ConsoleTaskLibrary;

namespace ChessBoardTask.Controller
{
    class ChessBoardController
    {
        private ChessBoardStartSize _chessBoardParameters = new ChessBoardStartSize();
        private readonly ConsolePrinter _printer = new ConsolePrinter();
       
        public ChessBoardStartSize CheckBoardValues(string widthArgument, string heightArgument) 
        {
            try
            {
                _chessBoardParameters.Width = GetBoardValue(widthArgument, Constant.ARG_WIDTH);
                _chessBoardParameters.Height = GetBoardValue(heightArgument, Constant.ARG_HEIGHT);
            }
            catch (ArgumentException ex)
            {
                _printer.WriteLine(string.Format("{0}: {1}", Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }

            return _chessBoardParameters;
        }

        private int GetBoardValue(string chessBoardArgument, string valueName)
        {
            int result = -1;
            bool successFormat = false;
            Converter converterArgs = new Converter();
            Validator validArgs = new Validator();

                while (!successFormat)
                {
                    result = converterArgs.TryParseToInt(chessBoardArgument);

                    if (result != -1)
                    {
                        if (!validArgs.CheckIntOnPositive(result, Constant.MAX_CHESSBOARD_SIZE))
                        {
                            _printer.WriteLine(Constant.WRONG_BOUNDARIES);
                            _printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                            chessBoardArgument = _printer.ReadLine();
                        }
                        else
                        {
                            successFormat = true;
                        }
                    }
                    else
                    {
                        _printer.WriteLine(Constant.INT_WRONG_TYPE);
                        _printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                        chessBoardArgument = _printer.ReadLine();
                    }
                }

            return result;
        }
    }
}
