using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berger
{
    public class Color
    {
        public int R;
        public int G;
        public int B;

        public Color(int r, int g, int b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public int getDistance(Color c)
        {
            if (c.R == 0 && c.B == 0 && c.G == 0)
                return int.MaxValue;
            return (int) Math.Sqrt(Math.Pow(this.R - c.R, 2) + Math.Pow(this.G - c.G, 2) + Math.Pow(this.B - c.B, 2));
        }
    }
}
