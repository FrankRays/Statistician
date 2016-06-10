using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistician
{
    class MyPerformance2 : MyPerformance1
    {
        private string _OppositeTeam;
        private int _Points;
        private double _FGPersentage;
        private double _ThreePPersentage;
        private double _FTPersentage;
        private int _Assists;
        private int _Rebounds;
        private int _Steals;
        private int _Turnovers;
        private double _Rating;
        private int _Blocks;

        public override string OppositeTeam
        {
            get
            {
                return this._OppositeTeam;
            }

            set
            {
                this._OppositeTeam = "Sprzęgło Wejherowo";
            }
        }

        public override int Points
        {
            get
            {
                return this._Points;
            }

            set
            {
                this._Points = 23;
            }
        }
        public override double FGPersentage
        {
            get
            {
                return this._FGPersentage;
            }

            set
            {
                this._FGPersentage = 56;
            }
        }

        public override double FTPersentage
        {
            get
            {
                return this._FTPersentage;
            }

            set
            {
                this._FTPersentage = 78;
            }
        }

        public override double ThreePPersentage
        {
            get
            {
                return this._ThreePPersentage;
            }

            set
            {
                this._ThreePPersentage = 48;
            }
        }

        public override int Assists
        {
            get
            {
                return this._Assists;
            }

            set
            {
                this._Assists = 8;
            }
        }

        public override int Blocks
        {
            get
            {
                return this._Blocks;
            }

            set
            {
                this._Blocks = 5;
            }
        }

        public override int Rebounds
        {
            get
            {
                return this._Rebounds;
            }

            set
            {
                this._Rebounds = 10;
            }
        }

        public override int Steals
        {
            get
            {
                return this._Steals;
            }

            set
            {
                this._Steals = 9;
            }
        }

        public override int Turnovers
        {
            get
            {
                return this._Turnovers;
            }

            set
            {
                this._Turnovers = 5;
            }
        }

        public override double Rating
        {
            get
            {
                return this._Rating;
            }

            set
            {
                this._Rating = 5.45;
            }
        }

        public MyPerformance2()
        {
            Console.WriteLine("Your performance from previous matches were loaded.\n");
        }

        public override void SetDate()
        {
            Console.WriteLine("Game 1 date - 5.05.2016");
        }
    }
}
