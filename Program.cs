using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask.Controller;
using ChessBoardTask.Logic;
using ChessBoardTask.View;

namespace ChessBoardTask
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Instruction"); //ToDo: Implement instruction
                return;
            }

            ChessBoardController chessBoardStarter = new ChessBoardController();

            (int width, int height) = chessBoardStarter.Start();

            ChessBoard chessBoardInit = new ChessBoard(width,height);
            ChessBoardViewer chessBoardInterface = new ChessBoardViewer(chessBoardInit);

            chessBoardInterface.ShowFullBoard();

            Console.ReadKey();
        }
    }
}
