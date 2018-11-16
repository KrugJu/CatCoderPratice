using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public static class Processor
    {

        public static List<Building> getBuildings(int[][] grid)
        {

            List<Building> buildings = new List<Building>();
            int id = 0;
            int area = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] != 0)
                    {
                        id++;
                        area++;
                        List<Position> visitedPos = new List<Position>();
                        buildings.Add(getBuilding(ref grid, new Position(i,j), new Position(i,j), visitedPos, grid[i][j], id, ref area));
                    }
                }
            }

            return buildings.OrderBy(b => b.Id).ToList();
            
        }

        private static Building getBuilding (ref int[][] grid, Position origin, Position pos, List<Position> visitedPos, int height, int id, ref int area)
        {
            visitedPos.Add(new Position(pos.i, pos.j));
            grid[pos.i][pos.j] = 0;
            area++;


            if(checkForRightBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i, pos.j + 1)))
            {
                getBuilding(ref grid, origin, new Position(pos.i, pos.j + 1), visitedPos, height, id, ref area);
            }
            else if (checkForLeftBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i, pos.j - 1)))
            {
                getBuilding(ref grid, origin, new Position(pos.i, pos.j - 1), visitedPos, height, id, ref area);
            }
            else if (checkForUpBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i - 1, pos.j)))
            {
                getBuilding(ref grid, origin, new Position(pos.i - 1, pos.j), visitedPos, height, id, ref area);
            }
            else if (checkForDownBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i + 1, pos.j)))
            {
                getBuilding(ref grid, origin, new Position(pos.i + 1, pos.j), visitedPos, height, id, ref area);
            }

            if(pos.i == origin.i && pos.j == origin.j) //if first function call gets here were done, otherwise we can return null as we dont need any return value if were not done
            {
                return new Building(id, area);
            }
            else
            {
                return null;
            }

            
        }

        private static bool checkForRightBuilding(int[][] grid, Position pos, int height)
        {
            if(pos.j + 1 < grid[pos.i].Length && grid[pos.i][pos.j + 1] == height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkForLeftBuilding(int[][] grid, Position pos, int height)
        {
            if (pos.j - 1 >= 0 && grid[pos.i][pos.j - 1] == height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkForUpBuilding(int[][] grid, Position pos, int height)
        {
            if (pos.i - 1 >= 0 && pos.j < grid[pos.i - 1].Length && grid[pos.i - 1][pos.j] == height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkForDownBuilding(int[][] grid, Position pos, int height)
        {
            if (pos.i + 1 < grid.Length && pos.j < grid[pos.i + 1].Length && grid[pos.i + 1][pos.j] == height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
