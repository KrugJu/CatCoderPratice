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

            
            int[][] splitValues = Splitter.SplitIntoMatrix(input);

            List<Building> sortedBuildings = Processor.getBuildings(splitValues);


            string line = "";

            foreach (Building building in sortedBuildings)
            {
                line += building.Id + " " + building.Area + " ";
            }


            line = line.TrimEnd(' ');


            outputs.Add(line + "\n");
            

            System.IO.File.WriteAllLines(outputfilepath, outputs);
        }
    }
}
