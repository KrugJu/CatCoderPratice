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
    }
}
