using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hyperloop
{
    public static class Processor
    {
        public static List<Point> getInsidePoints(List<List<Point>> obstacles,  List<Point> points)
        {
            List<Point> result = new List<Point>();

            foreach (Point p in points)
            {
                double ap = Math.Atan2(p.Y, p.X);
                bool valid = true;

                foreach (List<Point> obstacle in obstacles)
                {
                    double a1 = Math.Atan2(obstacle[0].Y, obstacle[0].X);
                    double a2 = Math.Atan2(obstacle[1].Y, obstacle[1].X);

                    if (obstacle[0].Y > 0)
                    {
                        if (ap < a1 && ap > a2 && p.Y > obstacle[0].Y)
                            valid = false;
                    }
                    else
                    {
                        if (ap > a1 && ap < a2 && p.Y < obstacle[0].Y)
                            valid = false;
                    }
                }
                if(valid)
                    result.Add(p);
            }

            return result;
        }
    }
}
