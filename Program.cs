using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Interfaces;
using ChessBoardTask.Logic;
using ChessBoardTask.View;
using ConsoleTaskLibrary;

namespace ChessBoardTask
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new ArgumentException();
                }

                ChessBoardController chessBoardStarter = new ChessBoardController();

                chessBoardStarter.ExecuteMainOperations(args[0],args[1]);

            }
            catch (Exception)
            {
                ConsolePrinter _printer = new ConsolePrinter();
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE), 
                        string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE));
            }
        }
    }
}
