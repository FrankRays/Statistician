using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistician
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Performance> pozitions = new List<Performance>();
            List<MyPerformance1> MyPozitions = new List<MyPerformance1>();
            char c;
            do
            {
                c = Menu.MakeMenu();
                switch (c)
                {
                    case '1':
                        MenuFunctions.AddPerformance(pozitions);
                        break;
                    case '2':
                        MenuFunctions.SeePerformances(pozitions);
                        break;
                    case '3':
                        MenuFunctions.SeePerformances(pozitions);
                        MenuFunctions.RemovePerformance(pozitions);
                        MenuFunctions.SeePerformances(pozitions);
                        break;
                    case '4':
                        MenuFunctions.SortByRating(pozitions);
                        break;
                    case '5':
                        MenuFunctions.SeePreviousPerformances(MyPozitions);
                        break;
                }
            }
            while (!(c == '6'));
        }
    }
}
