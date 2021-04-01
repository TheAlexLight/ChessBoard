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
        readonly ConsolePrinter consoleActor = new ConsolePrinter();
       

        public ChessBoardStartSize CheckBoardValues(string widthArg, string heightArg) 
        {
            consoleActor.Write(Constant.CHECK_ARGS_PROMPT); 

            string prompt = consoleActor.ReadLine();

            bool needToCheck = false;

            if (prompt.ToUpper().Equals(Constant.SIMPLE_YES) || prompt.ToUpper().Equals(Constant.YES))
            {
                needToCheck = true;
            }

            chessBoardParameters.Width = GetBoardValue(widthArg, needToCheck, Constant.ARG_WIDTH);
            chessBoardParameters.Height = GetBoardValue(heightArg, needToCheck, Constant.ARG_HEIGHT);

            return chessBoardParameters;
        }

        private int GetBoardValue(string strBoardArg, bool needToCheck, string valueName)
        {
            int result = -1;
            bool successFormat = false;
            Converter converterArgs = new Converter();
            Validator validArgs = new Validator();

            try
            {


                while (!successFormat)
                {
                    result = converterArgs.ParseToInt(strBoardArg, needToCheck);

                    if (result != -1)
                    {
                        if (!validArgs.CheckIntOnPositive(result, ChessBoardStartSize.MAX_CHESSBOARD_SIZE, needToCheck))
                        {
                            consoleActor.WriteLine(Constant.WRONG_BOUNDARIES);
                        }
                        else
                        {
                            successFormat = true;
                        }
                    }
                    else
                    {
                        consoleActor.WriteLine(Constant.INT_WRONG_TYPE);

                        consoleActor.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                        strBoardArg = consoleActor.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                consoleActor.WriteLine(string.Format("{0}: {1}",Constant.EXCEPTION_OCCURED, ex.Message)); //Complete Exception
            }

            return result;
        }
    }
}
