using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public static class Splitter
    {

        public static int[][] splitIntoBuildingGrid(string s)
        {
            int row = 0;
            string[] rows = s.Split('\n');
            int buildingRowCount = Convert.ToInt32(rows[0].Split(' ')[0]);
            rows = rows.Skip(1).ToArray();
            
            int[][] buildingGrid = new int[buildingRowCount][];
        

            for (; row < buildingRowCount; row++)
            {
                rows[row] = rows[row].TrimEnd('\r');
                List<string> numbers = rows[row].Split(' ').ToList();
                buildingGrid[row] = new int[rows[row].Length];
                for (int col = 0; col < numbers.Count; col++)
                {
                    buildingGrid[row][col] = Convert.ToInt32(numbers[col]);
                }
            }

            return buildingGrid;
        }

        public static List<Pair> splitIntoPairs(string s)
        {
            int row = 0;
            string[] rows = s.Split('\n');
            int buildingRowCount = Convert.ToInt32(rows[0].Split(' ')[0]);
            rows = rows.Skip(2 + buildingRowCount).ToArray();

            List<Pair> pairs = new List<Pair>();

            for (; row < rows.Length; row++)
            {
                pairs.Add(new Pair(new Building(Convert.ToInt32(rows[row].Split(' ')[0])), new Building(Convert.ToInt32(rows[row].Split(' ')[1]))));
            }

            return pairs;
        }
    }
}
