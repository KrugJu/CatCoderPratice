using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public static class Printer
    {

        public static void printAllOutputs(string inputfilepath, string outputfilepath)
        {

            string input = System.IO.File.ReadAllText(inputfilepath);
            List<string> outputs = new List<string>();

            
            int[][] splitValues = Splitter.splitIntoBuildingGrid(input);
            List<Pair> pairs = Splitter.splitIntoPairs(input);

            List<Building> sortedBuildings = Processor.getBuildings(splitValues);
            List<double> distances = Processor.getDistances(pairs, sortedBuildings);

            string line = "";

            foreach (double distance in distances)
            {
                int intDis = Convert.ToInt32(Math.Ceiling(distance));

                line += intDis;

                line = line.TrimEnd(' ');
                
                outputs.Add(line);

                line = "";
            }

            
            

            System.IO.File.WriteAllLines(outputfilepath, outputs);
        }
    }
}
