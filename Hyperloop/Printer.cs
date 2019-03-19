using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperloop
{
    public static class Printer
    {
        public static void printAllOutputs(string inputfilepath, string outputfilepath)
        {

            string input = System.IO.File.ReadAllText(inputfilepath);
            List<string> outputs = new List<string>();


            List<Point> obstacle = Splitter.getAngle(input);
            List<Point> points = Splitter.SplitPoints(input);

            List<Point> validPoints = Processor.getInsidePoints(obstacle, points);

            string line = "";

            foreach (Point p in validPoints)
            {
                line += p.ToString();
            }

            line = line.TrimEnd(' ');

            System.IO.File.WriteAllText(outputfilepath, line);
        }
    }
}
