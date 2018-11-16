using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public static class Splitter
    {

        public static int[][] SplitIntoMatrix(string s)
        {
            string[] rows = s.Split('\n');
            string[][] grid = new string[rows.Length - 1][];

            for (int row = 1; row < rows.Length; row++)
            {
                rows[row] = rows[row].TrimEnd('\r');
                grid[row - 1] = rows[row].Split(' ');
            }

            int[][] intGrid = new int[grid.Length][];

            for (int row = 0; row < grid.Length; row++)
            {
                intGrid[row] = new int[grid[row].Length];

                for (int col = 0; col < grid[row].Length; col++)
                {
                    intGrid[row][col] = Convert.ToInt32(grid[row][col]);
                }
            }

            return intGrid;
        }
    }
}
