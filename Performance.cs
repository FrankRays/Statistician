using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistician
{
    public class Performance : IComparable<Performance>
    {
        public virtual string OppositeTeam { get; set; }
        public virtual int Points { get; set; }
        private double FGM { get; set; }
        private double FGA { get; set; }
        public virtual double FGPersentage { get; set; }
        private double ThreePM { get; set; }
        private double ThreePA { get; set; }
        public virtual double ThreePPersentage { get; set; }
        private double FTM { get; set; }
        private double FTA { get; set; }
        public virtual double FTPersentage { get; set; }
        public virtual int Assists { get; set; }
        public virtual int Rebounds { get; set; }
        public virtual int Steals { get; set; }
        public virtual int Turnovers { get; set; }
        public virtual double Rating { get; set; }
        public virtual int Blocks { get; set; }
        private int i;

        //In basketball there are five pozitions: Point Guard (PG), Shooting Guard (SG),
        //Small Forward (SF), Power Forward (PF), Center (C)
        public enum Pozition { PG, SG, SF, PF, C }
        public Pozition MyPozition;

        public Performance()
        {
            Console.WriteLine("Choose your pozition on court: (0: PG, 1: SG, 2: SF, 3: PF, 4: C)");
            i = Convert.ToInt32(Console.ReadLine());

            if (i == 0)
            {
                MyPozition = Pozition.PG;
            }else
            if (i == 1)
            {
                MyPozition = Pozition.SG;
            }else
            if (i == 2)
            {
                MyPozition = Pozition.SF;
            }else
            if (i == 3)
            {
                MyPozition = Pozition.PF;
            }else
            if(i == 4)
            {
                MyPozition = Pozition.C;
            }else throw new ArgumentException("Wrong pozition!");


            Console.WriteLine("Write your performance from previous match:");
            Console.WriteLine("Opposite Team: ");
            OppositeTeam = Console.ReadLine();

            Console.WriteLine("Points: ");
            Points = Convert.ToInt32(Console.ReadLine());
            if (Points < 0)
                throw new ArgumentException("Points must be positive!");

            Console.Write("Field goals made: ");
            FGM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Field goal attempts: ");
            FGA = Convert.ToInt32(Console.ReadLine());
            if (FGM > FGA || FGM < 0 || FGA < 0)
                throw new ArgumentException("Field goals made can't be bigger than field goals attempts or must be positive!");
            FGPersentage = (FGM / FGA) * 100;
            FGPersentage = Math.Round(FGPersentage);

            Console.WriteLine("3 point field goals made: ");
            ThreePM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 point field goals attempts: ");
            ThreePA = Convert.ToInt32(Console.ReadLine());
            if (ThreePM > ThreePA || ThreePM < 0 || ThreePA < 0)
                throw new ArgumentException("3 Field goals made can't be bigger than 3 field  goals attempts or must be positive!");
            ThreePPersentage = (ThreePM / ThreePA) * 100;
            ThreePPersentage = Math.Round(ThreePPersentage);

            Console.WriteLine("Free throws made: ");
            FTM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Free throws attempts: ");
            FTA = Convert.ToInt32(Console.ReadLine());
            if (FTM > FTA || FTM < 0 || FTA < 0)
                throw new ArgumentException("Free throws made can't be bigger than free throws attempts or must be positive!");
            FTPersentage = (FTM / FTA) * 100;
            FTPersentage = Math.Round(FTPersentage);

            Console.WriteLine("Assists: ");
            Assists = Convert.ToInt32(Console.ReadLine());
            if (Assists < 0)
                throw new ArgumentException("Assists must be positive!");
            Console.WriteLine("Rebounds: ");
            Rebounds = Convert.ToInt32(Console.ReadLine());
            if (Rebounds < 0)
                throw new ArgumentException("Rebounds must be positive!");
            Console.WriteLine("Steals: ");
            Steals = Convert.ToInt32(Console.ReadLine());
            if (Steals < 0)
                throw new ArgumentException("Steals must be positive!");
            Console.WriteLine("Turnovers: ");
            Turnovers = Convert.ToInt32(Console.ReadLine());
            if (Turnovers < 0)
                throw new ArgumentException("Turnovers must be positive!");
            Console.WriteLine("Blocks: ");
            Blocks = Convert.ToInt32(Console.ReadLine());
            if (Blocks < 0)
                throw new ArgumentException("Blocks must be positive!");

            Rating =  (5 * FGPersentage + 4 * ThreePPersentage + FTPersentage
                + (Blocks + Steals + Assists + Rebounds - Turnovers) * 2) / 100;
        }

        public int CompareTo(Performance other)
        {
            return this.Rating.CompareTo(other.Rating);
        }

    }
}
