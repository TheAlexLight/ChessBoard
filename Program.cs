using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Controller;
using ChessBoardTask.Logic;
using ChessBoardTask.View;
using ConsoleTaskLibrary;

namespace ChessBoardTask
{
    class Program
    {
        static void Main(string[] args) 
        {
            ConsolePrinter printer = new ConsolePrinter();
            try
            {
                if (args.Length != 2)
                {
                    throw new ArgumentException();
                }

                ChessBoardController chessBoardStarter = new ChessBoardController();

                ChessBoardStartSize chessBoardValues;

                chessBoardValues = chessBoardStarter.CheckBoardValues(args[0], args[1]);

                ChessBoard chessBoardInit = new ChessBoard(chessBoardValues.Width, chessBoardValues.Height);
                ChessBoardViewer chessBoardInterface = new ChessBoardViewer(chessBoardInit);

                chessBoardInterface.ShowFullBoard();

                Console.ReadKey();
            }
            catch (Exception)
            {
                printer.WriteLine(Constant.INSTRUCTION);
                printer.WriteLine(string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE));
                printer.WriteLine(string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_CHESSBOARD_SIZE));

                Console.ReadKey();
            }
        }
    }
}
