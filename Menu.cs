using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistician
{
    class Menu
    {
        public static char MakeMenu()
        {
            Console.Clear();
            Console.WriteLine("                               Statistician\n");
            Console.WriteLine("1 - Add performance");
            Console.WriteLine("2 - See your performances");
            Console.WriteLine("3 - Remove performance");
            Console.WriteLine("4 - Sort your performances by overall rating");
            Console.WriteLine("5 - See previous performances");
            Console.WriteLine("6 - Exit\n");
            return Console.ReadKey(true).KeyChar;
        }
    }
}
