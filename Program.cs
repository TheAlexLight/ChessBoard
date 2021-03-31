﻿using System;
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

            ChessBoardStartSize chessBoardValues;

            chessBoardValues = chessBoardStarter.CheckBoardValues(args[0],args[1]);

            ChessBoard chessBoardInit = new ChessBoard(chessBoardValues.Width,chessBoardValues.Height);
            ChessBoardViewer chessBoardInterface = new ChessBoardViewer(chessBoardInit);

            chessBoardInterface.ShowFullBoard();

            Console.ReadKey();
        }
    }
}
