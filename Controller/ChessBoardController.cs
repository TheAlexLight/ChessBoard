using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Logic;
using ChessBoardTask.Validation;
using ChessBoardTask.View;
using ConsoleTaskLibrary;

namespace ChessBoardTask.Interfaces
{
    class ChessBoardController
    {
       
        private readonly ConsolePrinter _printer = new ConsolePrinter();

        public void ExecuteMainOperations(string widthArgument, string heightArgument)
        {

            try
            {
                ChessBoardStartSize _chessBoardParameters;

                _chessBoardParameters = CheckChessBoardValues(widthArgument, heightArgument);

                ChessBoard chessBoardInit = new ChessBoard(_chessBoardParameters.Width, _chessBoardParameters.Height); //TODO implement exception handling
                ChessBoardViewer chessBoardInterface = new ChessBoardViewer(chessBoardInit);

                chessBoardInterface.ShowFullBoard();
            }
            catch (ArgumentException ex)
            {
                _printer.WriteLine(string.Format("{0}: {1}", Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }
        }

        public ChessBoardStartSize CheckChessBoardValues(string widthArgument, string heightArgument)
        {
            ChessBoardStartSize _chessBoardParameters = new ChessBoardStartSize
            {
                Width = GetBoardValue(widthArgument),

                Height = GetBoardValue(heightArgument)
            };

            return _chessBoardParameters;
        }

        private int GetBoardValue(string chessBoardArgument)
        {
            Converter converterArgs = new Converter();
            Validator validArgs = new Validator();

                   int result = converterArgs.TryParseToInt(chessBoardArgument);

            if (result != -1)
            {
                if (!validArgs.CheckIntOnPositive(result))
                {
                    _printer.WriteLine(Constant.WRONG_BOUNDARIES); 
                    _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE),
                            string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE));
                    Environment.Exit(-1);
                }
            }
            else
            {
                _printer.WriteLine(Constant.INT_WRONG_TYPE);
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE),
                            string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE));
                Environment.Exit(-1);
            }

            return result;
        }
    }
}
