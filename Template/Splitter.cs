using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public static class Splitter
    {
        public static List<int> SplitIntoBuildings(string s)
        {
            string[] values = s.Split(' ', '\n');

            List<int> valuesList = new List<int>();

            for(int i = 2; i < values.Length; i++)
            {
                valuesList.Add(Convert.ToInt32(values[i]));
            }
                      
            return valuesList;
        }

        public static int[][] SplitIntoMatrix(string s)
        {
            string[] rows = s.Split('\n');
            string[][] grid = new string[rows.Length][];
            
            for (int row = 1; row < rows.Length; row++)
            {
                grid[row] = rows[row].Split(' ');
            }

            int[][] intGrid = new int[rows.Length][];

            for (int row = 0; row < rows.Length; row++)
            {
                for(int col = 0; col < grid[0].Length; col++)
                {
                    intGrid[row][col] = Convert.ToInt32(grid[row][col]);
                }
            }

            return intGrid;
        }


        public static List<int> GetRowsCols(string s)
        {
            string[] values = s.Split(' ', '\n');
            List<int> valuesList = new List<int>();
            valuesList.Add(Convert.ToInt32(values[0]));
            valuesList.Add(Convert.ToInt32(values[1]));
            return valuesList;
        }
    }
}
