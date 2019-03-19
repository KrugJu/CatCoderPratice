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
            int area = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] != 0) //origin of building found
                    {
                        List<Position> visitedPos = new List<Position>(); //create list of visited positions
                        buildings.Add(getBuilding(ref grid, new Position(i,j), new Position(i,j), visitedPos, grid[i][j], ref area)); //start algorithm for finding the whole building and add it to the list of buildings
                        area = 0;
                    }
                }
            }

            List<Building> orderedBuildings = buildings.OrderBy(b => b.Area).ToList();

            for(int i = 0; i < orderedBuildings.Count; i++)
            {
                orderedBuildings[i].Id = i;
            }



            return orderedBuildings;
            
        }

        public static List<double> getDistances(List<Pair> pairs, List<Building> buildings)
        {
            List<double> distances = new List<double>();
            Pair newPair;

            foreach(Pair pair in pairs)
            {
                newPair = new Pair(buildings[pair.B1.Id], buildings[pair.B2.Id]);
                distances.Add(newPair.getDistance());
            }

            return distances;
        }

        private static Building getBuilding (ref int[][] grid, Position origin, Position pos, List<Position> visitedPos, int height, ref int area)
        {
            visitedPos.Add(new Position(pos.i, pos.j));
            grid[Convert.ToInt32(pos.i)][Convert.ToInt32(pos.j)] = 0;
            area++;


            if(checkForRightBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i, pos.j + 1)))
            {
                getBuilding(ref grid, origin, new Position(pos.i, pos.j + 1), visitedPos, height, ref area);
            }
            if (checkForLeftBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i, pos.j - 1)))
            {
                getBuilding(ref grid, origin, new Position(pos.i, pos.j - 1), visitedPos, height, ref area);
            }
            if (checkForUpBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i - 1, pos.j)))
            {
                getBuilding(ref grid, origin, new Position(pos.i - 1, pos.j), visitedPos, height, ref area);
            }
            if (checkForDownBuilding(grid, pos, height) && !visitedPos.Contains(new Position(pos.i + 1, pos.j)))
            {
                getBuilding(ref grid, origin, new Position(pos.i + 1, pos.j), visitedPos, height, ref area);
            }

            if(pos.i == origin.i && pos.j == origin.j) //if first function call gets here were done, otherwise we can return null as we dont need any return value if were not done
            {
                return new Building(0, area, visitedPos);
            }
            else
            {
                return null;
            }

            
        }

        private static bool checkForRightBuilding(int[][] grid, Position pos, int height)
        {
            if(pos.j + 1 < grid[Convert.ToInt32(pos.i)].Length && grid[Convert.ToInt32(pos.i)][Convert.ToInt32(pos.j) + 1] == height)
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
            if (pos.j - 1 >= 0 && grid[Convert.ToInt32(pos.i)][Convert.ToInt32(pos.j) - 1] == height)
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
            if (pos.i - 1 >= 0 && pos.j < grid[Convert.ToInt32(pos.i) - 1].Length && grid[Convert.ToInt32(pos.i) - 1][Convert.ToInt32(pos.j)] == height)
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
            if (pos.i + 1 < grid.Length && pos.j < grid[Convert.ToInt32(pos.i) + 1].Length && grid[Convert.ToInt32(pos.i) + 1][Convert.ToInt32(pos.j)] == height)
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
