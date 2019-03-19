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
        public static List<Point> getInsidePoints(List<Point> obstacle,  List<Point> points)
        {
            List<Point> result = new List<Point>();
            double a1 = Math.Atan2(obstacle[0].Y, obstacle[0].X);
            double a2 = Math.Atan2(obstacle[1].Y, obstacle[1].X);

            foreach (Point p in points)
            {
                double ap = Math.Atan2(p.Y, p.X);
                if (a1 < a2)
                {
                    if (ap < a1 || ap > a2)
                        result.Add(p);
                }
                else
                {
                    if (ap > a1 || ap < a2)
                        result.Add(p);
                }
            }

            return result;
        }
    }
}
