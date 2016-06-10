using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistician
{
    public class MenuFunctions
    {
        public static void AddPerformance(List<Performance> pozitions)
        {
            pozitions.Add(new Performance());
        }

        public static void SeePerformances(List<Performance> pozitions)
        {
            int i = 0;
            foreach (Performance per in pozitions)
            {
                Console.WriteLine("{0}. Opposite Team: {1}", i, per.OppositeTeam);
                Console.WriteLine("Pozition: {0} ", per.MyPozition);
                Console.WriteLine("PTS: {0} FG: {1}% 3FG: {2}% FT: {3}% BLK: {4} AST: {5} REB: {6} STL: {7} TO: {8} RATING: {9}\n", 
                    per.Points, per.FGPersentage, per.ThreePPersentage, per.FTPersentage, per.Blocks, 
                    per.Assists, per.Rebounds, per.Steals, per.Turnovers, per.Rating);
                i++;
            }
            Console.ReadKey(true);
        }

        public static void RemovePerformance(List<Performance> pozitions)
        {
            Console.WriteLine("Which performance would you like to remove?");
            int index = Convert.ToInt32(Console.ReadLine());
            pozitions.RemoveAt(index);
        }

        public static void SeePreviousPerformances(List<MyPerformance1> MyPozitions)
        {
            MyPozitions.Add(new MyPerformance1());
            MyPozitions.Add(new MyPerformance2());
            MyPozitions.Add(new MyPerformance3());
            int i = 0;
            foreach (MyPerformance1 per in MyPozitions)
            {
                per.SetDate();
                Console.WriteLine("{0}. Opposite Team: {1}", i, per.OppositeTeam);
                Console.WriteLine("PTS: {0} FG: {1}% 3FG: {2}% FT: {3}% BLK: {4} AST: {5} REB: {6} STL: {7} TO: {8} RATING: {9}\n",
                    per.Points, per.FGPersentage, per.ThreePPersentage, per.FTPersentage, per.Blocks,
                    per.Assists, per.Rebounds, per.Steals, per.Turnovers, per.Rating);
                i++;
            }
            Console.ReadKey(true);
        }

        public static void SortByRating(List<Performance> pozitions)
        {
            pozitions.Sort();
            int i = 0;
            foreach (Performance per in pozitions)
            {
                Console.WriteLine("{0}. Opposite Team: {1}", i, per.OppositeTeam);
                Console.WriteLine("Pozition: {0}", per.MyPozition);
                Console.WriteLine("PTS: {0} FG: {1}% 3FG: {2}% FT: {3}% BLK: {4} AST: {5} REB: {6} STL: {7} TO: {8} RATING: {9}\n",
                    per.Points, per.FGPersentage, per.ThreePPersentage, per.FTPersentage, per.Blocks,
                    per.Assists, per.Rebounds, per.Steals, per.Turnovers, per.Rating);
                i++;
            }
            Console.ReadKey(true);
        }
    }
}
