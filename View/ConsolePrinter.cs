using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBoardTask.Logic;

namespace ChessBoardTask.View
{
    class ConsolePrinter
    {
        public  string ReadLine()
        {
            return Console.ReadLine();
        }
        public  void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public  void Write(string message)
        {
            Console.Write(message);
        }
    }
}
