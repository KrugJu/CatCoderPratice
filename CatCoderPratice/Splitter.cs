using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    static class Splitter
    {
        public static List<Block> SplitIntoBlocks(string s)
        {
            string[] values = s.Split(' ');

            List<Block> valuesBlocked = new List<Block>();
            for(int i = 3; i < values.Length - 2; i += 5)
            {
                valuesBlocked.Add(new Block(Convert.ToInt32(values[i]), Convert.ToChar(values[i + 1]), Convert.ToInt32(values[i + 2]), Convert.ToInt32(values[i + 3]), Convert.ToInt32(values[i + 4])));
            }
            
            return valuesBlocked;
        }

        public static int[] GetMove(string s)
        {
            string[] values = s.Split(' ');
            int[] move = new int[] { Convert.ToInt32(values[values.Length - 2]), Convert.ToInt32(values[values.Length - 1])};
            return move;
        }

        public static int[] GetGrid(string s)
        {
            string[] values = s.Split(' ');
            int[] grid = new int[] { Convert.ToInt32(values[0]), Convert.ToInt32(values[1]) };
            return grid;
        }
    }
}
