﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBoardTask.Logic;

namespace ChessBoardTask.View
{
   static class ConsolePrinter
    {
        public static string ReadLine()
        {
            return Console.ReadLine();
        }
        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public static void Write(string message)
        {
            Console.Write(message);
        }
    }
}
