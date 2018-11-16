using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public static class Processor
    {

        public static int TestForBuilding(List<int> values)
        {
            
            var buildings = new List<int>();
            foreach (var x in values)
            {
                if(x>0) buildings.Add(x);
            }
            {
                
            }
            if (buildings.Count > 0) return 1;
            else return 0;
        }

        public static List<int> GetHighestBuildingsAscending(int[,] values)
        {
            for (int i = 0; i < values.Length;i++)
            {
                for (int i1 = 0; i1 < values[i].Length; i1++)
                {
                    if(values[i][i1] != 0) FindSurroundingBlocks(values,new KeyValuePair<int,int>(i,i1))
                }
            }
        }

        public static GoRight(KeyValuePair<int, int> position, int[,] values)
        {
            //temporary counter for elements which are neighbours
            //hasConnectionVariable
            for (int i = 0; i < position.Value; i++)
            {
                //Check before
                if()
                //Check above
            }
        }


















































        //Berger


        public static List<int> GetBuildings (int[][] grid)
        {
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if(CheckForBuilding(grid, i, j) == )
                }
            }
        }

        public static string CheckForBuilding(int[][] grid, int row, int col)
        {
            string direction = "";

            if (col < grid[0].Length && grid[row][col + 1] == grid[row][col])
            {
                direction = "right";
            }
            else if (row < grid.Length && grid[row + 1][col] == grid[row][col])
            {
                direction = "down";
            }
            else if (col > 0 && grid[row][col - 1] == grid[row][col])
            {
                direction = "left";
            }

            return direction;
            
        }

    }
}
