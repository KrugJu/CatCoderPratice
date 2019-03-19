using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperloop
{
    public static class Splitter
    {
        public static List<Point> SplitPoints(string s)
        {
            string[] values = s.Split(' ', '\n');

            List<Point> points = new List<Point>();

            for (int i = 4; i < values.Length - 1; i+=2)
            {
                points.Add(new Point(Convert.ToInt32(values[i]), Convert.ToInt32(values[i+1])));
            }
                      
            return points;
        }

        public static int getY(string s)
        {
            return Convert.ToInt32(s.Split('\n')[2]);
        }

        public static List<Point> getObstacle(string s)
        {
            string[] values = s.Split(' ', '\n');

            List<Point> points = new List<Point>();

            points.Add(new Point(Convert.ToInt32(values[0]), Convert.ToInt32(values[2])));
            points.Add(new Point(Convert.ToInt32(values[1]), Convert.ToInt32(values[2])));

            return points;
        }
    }
}
