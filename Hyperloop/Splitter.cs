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

            for (int i = Convert.ToInt32(values[0]) * 3 + 2; i < values.Length - 1; i+=2)
            {
                points.Add(new Point(Convert.ToInt32(values[i]), Convert.ToInt32(values[i+1])));
            }
                      
            return points;
        }

        public static int getY(string s)
        {
            return Convert.ToInt32(s.Split('\n')[2]);
        }

        public static List<List<Point>> getObstacles(string s)
        {
            string[] values = s.Split(' ', '\n');
            List<List<Point>> obstacles = new List<List<Point>>();          

            for(int i = 1; i <= Convert.ToInt32(values[0]) * 3; i+= 3)
            {
                List<Point> points = new List<Point>();
                points.Add(new Point(Convert.ToInt32(values[i]), Convert.ToInt32(values[i+2])));
                points.Add(new Point(Convert.ToInt32(values[i+1]), Convert.ToInt32(values[i+2])));
                obstacles.Add(points);
            }

            

            return obstacles;
        }
    }
}
