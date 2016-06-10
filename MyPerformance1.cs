using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistician
{
    public class MyPerformance1
    {
        public virtual string OppositeTeam { get; set; }
        public virtual int Points { get; set; }
        public virtual double FGPersentage { get; set; }
        public virtual double ThreePPersentage { get; set; }
        public virtual double FTPersentage { get; set; }
        public virtual int Assists { get; set; }
        public virtual int Rebounds { get; set; }
        public virtual int Steals { get; set; }
        public virtual int Turnovers { get; set; }
        public virtual double Rating { get; set; }
        public virtual int Blocks { get; set; }

        public MyPerformance1()
        {
            OppositeTeam = "Nobody";
            Points = 24;
            FGPersentage = 49;
            ThreePPersentage = 40;
            FTPersentage = 89;
            Assists = 9;
            Rebounds = 10;
            Steals = 5;
            Turnovers = 2;
            Rating = 5.23;
            Blocks = 5;
        }

        public virtual void SetDate()
        {
            Console.WriteLine("Game 0 Date - 27.04.2016");
        }

    }
}
