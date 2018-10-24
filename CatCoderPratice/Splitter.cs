using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    static class Splitter
    {
        public static List<Block> Split(string s)
        {
            string[] values = s.Split(' ');

            List<Block> valuesBlocked = new List<Block>();
            for(int i = 0; i < values.Length; i += 5)
            {
                valuesBlocked.Add(new Block(Convert.ToInt32(values[i]), Convert.ToChar(values[i + 1]), Convert.ToInt32(values[i + 2]), Convert.ToInt32(values[i + 3]), Convert.ToInt32(values[i + 4])));
            }
            
            return valuesBlocked;
        }
    }
}
