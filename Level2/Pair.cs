using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public class Pair
    {
        Building b1;
        Building b2;

        public Pair(Building b1, Building b2)
        {
            this.b1 = b1;
            this.b2 = b2;
        }

        public double getDistance()
        {
            Position b1Center = b1.getCentroid();
            Position b2Center = b2.getCentroid();

            return Math.Sqrt(Math.Pow(b2Center.i - b1Center.i, 2) + Math.Pow(b2Center.j - b1Center.j, 2));
        }


        public Building B1
        {
            get
            {
                return b1;
            }

            set
            {
                b1 = value;
            }
        }

        public Building B2
        {
            get
            {
                return b2;
            }

            set
            {
                b2 = value;
            }
        }
    }
}
